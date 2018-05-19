using System.Collections.Generic;

namespace RadioCatalog.LIB
{
    public interface IDataManager
    {
        string FilePath { get; set; }
        bool IsExist(string Path);
        Dictionary<int, RadioComponent> GetCategoryData(string category);
        void AddNode(RadioComponent com, string category, int key);
        void EditNode(RadioComponent com, string category, int key);
        void RemoveNode(string category, int key);
        void CreateFile();
        Dictionary<string, int> GetCategories();
        void AddCategory(string category, int id);
        void EditCategory(string name, string newName, int id);
        void RemoveCategory(string category);
        void SaveFileAs(string newFileName);
    }
}
