using System;
using System.Collections.Generic;
using RadioCatalog.LIB;

namespace RadioCatalog
{
    public delegate void CategoryEventHandler(string name, int id);
    public delegate void NodeEventHandler(RadioComponent rc);
    public delegate void StringEventHandler(string data);

    public interface IView
    {
        void Show();
        void Close();
    }

    public interface IMainView : IView
    {
        string SelectedCategoryName { get; }
        int SelectedCategoryId { get; }
        int SelectedItemKey { get; }

        event StringEventHandler ConnectDatabase;
        event StringEventHandler CreateDatabase;
        event StringEventHandler CopyDatabase;

        event EventHandler AddCategory;
        event EventHandler EditCategory;
        event EventHandler RemoveCategory;

        event EventHandler AddItem;
        event EventHandler EditItem;
        event EventHandler RemoveItem;

        event EventHandler LoadItems;
        event StringEventHandler Search;

        void UpdateCategories(Dictionary<string, int> categories);
        void UpdateItems(Dictionary<int, RadioComponent> items);
    }

    public interface ICategoryView : IView
    {
        event CategoryEventHandler CategoryCreated;
    }

    public interface IViewItem : IView
    {
        event NodeEventHandler ItemCreated;
    }
}
