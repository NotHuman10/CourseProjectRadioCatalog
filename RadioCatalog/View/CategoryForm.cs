using System;
using System.Drawing;
using System.Windows.Forms;

namespace RadioCatalog
{
    public partial class CategoryForm : Form, ICategoryView
    {
        public CategoryForm(string categoryEditable = null)
        {
            InitializeComponent();

            Text = categoryEditable == null ? "Добавление категории" : "Редактирование категории";
            CreateCategoryBtn.Text = categoryEditable == null ? "Добавить" : "Подтвердить";
            CategotyNameTextBox.Text = categoryEditable ?? "";

            CreateCategoryBtn.Click += CreateCategory;
        }

        public new void Show()
        {
            ShowDialog();
        }

        public event CategoryEventHandler CategoryCreated;

        void CreateCategory(object sender, EventArgs e)
        {
            string categoryName = CategotyNameTextBox.Text;
            int imgId = ChooseImgList.SelectedIndices.Count > 0 ? ChooseImgList.SelectedIndices[0] : -1;

            if (IsValidInput(categoryName, imgId))
            {
                CategoryCreated?.Invoke(categoryName, imgId);
                Close();
            }
        }

        bool IsValidInput(string name, int id)
        {
            Color standard = Color.FromName("Black");
            Color highlight = Color.FromName("Red");

            InputNameLabel.ForeColor = name == "" ? highlight : standard;

            SelectImageLabel.ForeColor = id < 0 ? highlight : standard;

            return name != "" && id >= 0;
        }
    }
}
