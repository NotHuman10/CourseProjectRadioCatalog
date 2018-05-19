using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;

namespace RadioCatalog.LIB
{
    public class DatabaseManager : IDataManager
    {
        #region Fields
        private const string DefaultRootName = "Data";
        private const string DefaultCategoryName = "category";
        private const string DefaultElementName = "item";

        private const string Id = "id";

        private const string Key = "key";
        private const string Model = "model";
        private const string Name = "name";
        private const string Specs = "specs";
        private const string MaxVal = "maxval";
        private const string Price = "price";

        private const string nodata = "";

        public string FilePath { get; set; }
        #endregion

        #region Main Methods
        public bool IsExist(string Path)
        {
            return File.Exists(FilePath);
        }

        public Dictionary<int, RadioComponent> GetCategoryData(string category)
        {
            XDocument doc = XDocument.Load(FilePath);

            XElement xCategory = 
                doc.Root.XPathSelectElement($"{DefaultCategoryName}[@{Name}='{category}']");

            IEnumerable<XElement> elements = xCategory?.Elements();

            Dictionary<int, RadioComponent> items = new Dictionary<int, RadioComponent>();

            foreach (XElement el in elements)
            {
                if (!Int32.TryParse(el.Attribute(Key)?.Value, out int ElementKey))
                    continue;

                if (!items.ContainsKey(ElementKey))
                {
                    Single.TryParse(el.Element(Price)?.Value, out float ElementPrice);

                    items.Add(ElementKey, new RadioComponent(

                        el.Attribute(Model)?.Value ?? nodata,
                        el.Element(Name)?.Value ?? nodata,
                        el.Element(Specs)?.Value ?? nodata,
                        el.Element(MaxVal)?.Value ?? nodata,
                        ElementPrice
                    ));
                }
            }

            return items;
        }

        public void AddNode(RadioComponent com, string category, int key)
        {
            XDocument doc = XDocument.Load(FilePath);

            XElement xCategory =
                doc.Root.XPathSelectElement($"{DefaultCategoryName}[@{Name}='{category}']");

            if (xCategory == null)
                throw new InvalidOperationException("Ошибка пути. Переподключитесь к базе.");

            XElement SameKeyElem =
                xCategory.XPathSelectElement($"{DefaultElementName}[@{Key}='{key}']");

            if (SameKeyElem == null)
            {
                XElement addable = ConvertToXElement(ref com, key);
                xCategory.Add(addable);
            }
            else
            {
                throw new InvalidOperationException(
                    $"Элемент с ключем {key} уже имеется\n" +
                    "Для исправления ошибки переподключитесь к базе"
                );
            }

            doc.Save(FilePath);
        }

        public void EditNode(RadioComponent com, string category, int key)
        {
            XDocument doc = XDocument.Load(FilePath);

            XElement xCategory = 
                doc.Root.XPathSelectElement($"{DefaultCategoryName}[@{Name}='{category}']");

            if (xCategory == null)
                throw new InvalidOperationException("Ошибка пути. Переподключитесь к базе.");

            IEnumerable<XElement> elements = xCategory.Elements();

            XElement editable = SearchByKey(elements, key);

            if (editable != null)
            {
                editable.SetAttributeValue(Model, com.Model);
                editable.SetElementValue(Name, com.Name);
                editable.SetElementValue(Specs, com.Specs);
                editable.SetElementValue(MaxVal, com.MaxVal);
                editable.SetElementValue(Price, com.Price.ToString());
            }

            doc.Save(FilePath);
        }

        public void RemoveNode(string category, int key)
        {
            XDocument doc = XDocument.Load(FilePath);

            XElement xCategory = 
                doc.Root?.XPathSelectElement($"{DefaultCategoryName}[@{Name}='{category}']");

            IEnumerable<XElement> elements = xCategory?.Elements();

            XElement removable = SearchByKey(elements, key);

            removable?.Remove();

            doc.Save(FilePath);
        }

        public void CreateFile()
        {
            XDocument doc = new XDocument(
                   new XDeclaration("1.0", "utf-8", "yes"),
                   new XElement(DefaultRootName)
                );

            doc.Save(FilePath);
        }

        public Dictionary<string, int> GetCategories()
        {
            XDocument doc = XDocument.Load(FilePath);

            Dictionary<string, int> categories = new Dictionary<string, int>();

            foreach (XElement el in doc.Root.Elements())
            {
                if (!categories.ContainsKey($"{el.Attribute(Name).Value}"))
                {
                    Int32.TryParse(el.Attribute(Id).Value, out int id);
                    categories.Add(el.Attribute(Name).Value, id);
                }
            }

            return categories;
        }

        public void AddCategory(string category, int id)
        {
            XDocument doc = XDocument.Load(FilePath);

            doc.Root.Add(new XElement($"{DefaultCategoryName}",
                
                new XAttribute(Name, category),
                new XAttribute(Id, id)
            ));

            doc.Save(FilePath);
        }

        public void EditCategory(string name, string newName, int id)
        {
            XDocument doc = XDocument.Load(FilePath);

            XElement xCategory =
                doc.Root.XPathSelectElement($"{DefaultCategoryName}[@{Name}='{name}']");

            if (xCategory != null)
            {
                xCategory.SetAttributeValue(Id, id);
                xCategory.SetAttributeValue(Name, newName);
            }

            doc.Save(FilePath);
        }

        public void RemoveCategory(string category)
        {
            XDocument doc = XDocument.Load(FilePath);

            XElement xCategory =
                doc.Root?.XPathSelectElement($"{DefaultCategoryName}[@{Name}='{category}']");

            xCategory?.Remove();

            doc.Save(FilePath);
        }

        public void SaveFileAs(string newPath)
        {
            XDocument doc = XDocument.Load(FilePath);

            doc.Save(newPath);
        }
        #endregion

        #region Service Methods
        private XElement SearchByKey(IEnumerable<XElement> elements, int key)
        {
            string keyWanted = key.ToString();
            IEnumerable<XElement> founded = from el in elements
                                            where el.Attribute(Key).Value == keyWanted
                                            select el;

            int len = founded?.Count() ?? 0;

            if (len == 0)
                throw new InvalidDataException($"Элемент с ключем {key} не найден");

            return founded.First();
        }

        private XElement ConvertToXElement(ref RadioComponent com, int key)
        {
            return new XElement(DefaultElementName,

                    new XAttribute(Key, key.ToString()),
                    new XAttribute(Model, com.Model),
                    new XElement(Name, com.Name),
                    new XElement(Specs, com.Specs),
                    new XElement(MaxVal, com.MaxVal),
                    new XElement(Price, com.Price.ToString())
            );
        }
        #endregion
    }
}