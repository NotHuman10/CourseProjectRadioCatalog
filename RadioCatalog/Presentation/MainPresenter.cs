using System;
using System.Collections.Generic;
using System.Linq;
using RadioCatalog.LIB;

namespace RadioCatalog
{
    public class MainPresenter : IMainPresenter
    {
        private readonly IMainView _view;
        private readonly IMessageService _messageService;
        private readonly IDataManager _manager;

        public Dictionary<string, int> Categories { get; private set; }
        public Dictionary<int, RadioComponent> Items { get; private set; }

        public MainPresenter(IMainView view, IMessageService service, IDataManager manager)
        {
            _view = view;
            _messageService = service;
            _manager = manager;

            _view.ConnectDatabase += ConnectDatabase;
            _view.CreateDatabase += CreateDatabase;
            _view.CopyDatabase += CopyDatabase;

            _view.AddCategory += AddCategory;
            _view.EditCategory += EditCategory;
            _view.RemoveCategory += RemoveCategory;

            _view.AddItem += AddItem;
            _view.EditItem += EditItem;
            _view.RemoveItem += RemoveItem;

            _view.LoadItems += delegate (object sender, EventArgs e)
            {
                Items = _manager.GetCategoryData(_view.SelectedCategoryName);
                _view.UpdateItems(Items);
            };

            _view.Search += Search;
        }

        public void Run()
        {
            _view.Show();
        }

        void ConnectDatabase(string path)
        {
            _manager.FilePath = path;
            if(_manager.IsExist(path))
            {
                Categories = _manager.GetCategories();
                _view.UpdateCategories(Categories);
            }
        }

        void CreateDatabase(string path)
        {
            _manager.FilePath = path;
            _manager.CreateFile();
            Categories = new Dictionary<string, int>();
            _view.UpdateCategories(Categories);
        }

        void CopyDatabase(string path)
        {
            _manager.SaveFileAs(path);
        }

        void AddCategory(object sender, EventArgs e)
        {
            ICategoryView _categoryView = new CategoryForm();
            _categoryView.CategoryCreated += delegate (string name, int id)
            {
                if (!Categories.ContainsKey(name))
                {
                    _manager.AddCategory(name, id);
                    Categories.Add(name, id);
                    _view.UpdateCategories(Categories);
                }
                else
                    _messageService.ShowExclamation("Категория с таким именем уже существует!");
            };

            _categoryView.Show();
        }

        void EditCategory(object sender, EventArgs e)
        {
            ICategoryView _categoryView = new CategoryForm(_view.SelectedCategoryName);
            _categoryView.CategoryCreated += delegate (string name, int id)
            {
                if (!Categories.ContainsKey(name))
                {
                    Categories.Remove(_view.SelectedCategoryName);
                    Categories.Add(name, id);
                    _manager.EditCategory(_view.SelectedCategoryName, name, id);
                    _view.UpdateCategories(Categories);
                }
                else
                {
                    Categories[name] = id;
                    _manager.EditCategory(name, name, id);
                    _view.UpdateCategories(Categories);
                }
            };

            _categoryView.Show();
        }

        void RemoveCategory(object sender, EventArgs e)
        {
            string dialog = "Вы уверены?\n(Это действие отменить невозможно)";
            bool result = _messageService.ShowDialogYesNo(dialog);

            string removable = _view.SelectedCategoryName;

            if (result)
            {
                Categories.Remove(removable);
                _manager.RemoveCategory(removable);
                _view.UpdateCategories(Categories);
            }
        }

        void AddItem(object sender, EventArgs e)
        {
            IViewItem _viewItem = new ItemForm();
            _viewItem.ItemCreated += delegate (RadioComponent rc)
            {
                int maxKey = Items.Keys.Count() != 0 ? Items.Keys.Max() : 0;
                try
                {
                    _manager.AddNode(rc, _view.SelectedCategoryName, ++maxKey);
                    Items.Add(maxKey, rc);
                    _view.UpdateItems(Items);
                }
                catch (Exception ex)
                {
                    _messageService.ShowError(ex.Message);
                }
            };

            _viewItem.Show();
        }

        void EditItem(object sender, EventArgs e)
        {
            RadioComponent editable = Items[_view.SelectedItemKey];

            IViewItem _viewItem = new ItemForm(editable);
            _viewItem.ItemCreated += delegate (RadioComponent rc)
            {
                int key = _view.SelectedItemKey;
                string category = _view.SelectedCategoryName;

                try
                {
                    _manager.EditNode(rc, category, key);
                    Items[key] = rc;
                    _view.UpdateItems(Items);
                }
                catch (Exception ex)
                {
                    _messageService.ShowError(ex.Message);
                }
            };

            _viewItem.Show();
        }

        void RemoveItem(object sender, EventArgs e)
        {
            string dialog = "Вы уверены?\n(Это действие отменить невозможно)";
            bool result = _messageService.ShowDialogYesNo(dialog);

            if (result)
            {
                string category = _view.SelectedCategoryName;
                int key = _view.SelectedItemKey;

                _manager.RemoveNode(category, key);
                Items.Remove(key);

                _view.UpdateItems(Items);
            }
        }

        void Search(string sample)
        {
            Dictionary<int, RadioComponent> founded = new Dictionary<int, RadioComponent>();

            string[] keyWords =
                sample.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (KeyValuePair<int, RadioComponent> entry in Items)
            {
                string itemString = entry.Value.ToString();
                StringComparison comparison = StringComparison.OrdinalIgnoreCase;
                bool find = true;

                for (int i = 0; i < keyWords.Length; i++)
                {
                    if (itemString.IndexOf(keyWords[i], comparison) == -1)
                    {
                        find = false;
                        break;
                    }
                }

                if (find)
                    founded.Add(entry.Key, entry.Value);
            }

            _view.UpdateItems(founded);
        }
    }
}
