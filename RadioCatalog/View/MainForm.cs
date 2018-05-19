using System;
using System.Windows.Forms;
using System.Collections.Generic;
using RadioCatalog.LIB;
using System.Drawing;

namespace RadioCatalog
{
    public partial class MainForm : Form, IMainView
    {
        public string SelectedCategoryName { get; private set; }
        public int SelectedCategoryId { get; private set; }
        public int SelectedItemKey { get; private set; }

        public MainForm()
        {
            InitializeComponent();

            OpenToolStripMenuItem.Click += OpenFile;
            CreateToolStripMenuItem.Click += CreateFile;
            SaveAsToolStripMenuItem.Click += SaveFileAs;

            CategoryList.SelectedIndexChanged += ChooseCategory;
            DataGrid.SelectionChanged += ChooseItem;

            DataGrid.DoubleClick += delegate (object sender, EventArgs e)
            {
                LoadItems?.Invoke(this, EventArgs.Empty);
            };
        }

        public event StringEventHandler ConnectDatabase;
        public event StringEventHandler CreateDatabase;
        public event StringEventHandler CopyDatabase;

        public event EventHandler AddCategory;
        public event EventHandler EditCategory;
        public event EventHandler RemoveCategory;

        public event EventHandler AddItem;
        public event EventHandler EditItem;
        public event EventHandler RemoveItem;

        public event EventHandler LoadItems;
        public event StringEventHandler Search;

        public new void Show()
        {
            Application.Run(this);
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Файл каталога данных|*.rcd|XML файл данных|*.xml";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ConnectDatabase?.Invoke(dlg.FileName);
                SaveAsToolStripMenuItem.Enabled = true;
                AddCategoryBtn.Enabled = true;
            }
        }

        private void CreateFile(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog
            {
                Filter = "Файл каталога данных|*.rcd|XML файл данных|*.xml",
                Title = "Создание"
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                CreateDatabase?.Invoke(dlg.FileName);
                ConnectDatabase?.Invoke(dlg.FileName);
                SaveAsToolStripMenuItem.Enabled = true;
                AddCategoryBtn.Enabled = true;
            }
        }

        private void SaveFileAs(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Файл каталога данных|*.rcd|XML файл данных|*.xml";

            if (dlg.ShowDialog() == DialogResult.OK)
                CopyDatabase?.Invoke(dlg.FileName);
        }

        private void AddCategoryBtn_Click(object sender, EventArgs e)
        {
            AddCategory?.Invoke(this, EventArgs.Empty);
        }
        private void EditCategoryBtn_Click(object sender, EventArgs e)
        {
            EditCategory?.Invoke(this, EventArgs.Empty);
        }
        private void RemoveCategoryBtn_Click(object sender, EventArgs e)
        {
            RemoveCategory?.Invoke(this, EventArgs.Empty);
        }
        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            AddItem?.Invoke(this, EventArgs.Empty);
        }
        private void EditItemBtn_Click(object sender, EventArgs e)
        {
            EditItem?.Invoke(this, EventArgs.Empty);
        }
        private void RemoveItemBtn_Click(object sender, EventArgs e)
        {
            RemoveItem?.Invoke(this, EventArgs.Empty);
        }

        private void ChooseCategory(object sender, EventArgs e)
        {
            if(CategoryList.SelectedIndices.Count > 0)
            {
                SelectedCategoryName = CategoryList.SelectedItems[0].Text;
                SelectedCategoryId = CategoryList.SelectedItems[0].ImageIndex;

                ItemsHeading.Text = SelectedCategoryName;

                EditCategoryBtn.Enabled = true;
                RemoveCategoryBtn.Enabled = true;
                AddItemBtn.Enabled = true;

                LoadItems?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                SelectedCategoryName = null;
                EditCategoryBtn.Enabled = false;
                RemoveCategoryBtn.Enabled = false;
                AddItemBtn.Enabled = false;
            }
        }

        private void ChooseItem(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = DataGrid.SelectedRows;
            int Length = rows.Count;

            if (Length == 1)
            {
                SelectedItemKey = Int32.Parse(rows[0].Cells[0].Value.ToString());

                EditItemBtn.Enabled = true;
                RemoveItemBtn.Enabled = true;
            }
            else
            {
                EditItemBtn.Enabled = false;
                RemoveItemBtn.Enabled = false;
            }
        }

        public void UpdateCategories(Dictionary<string, int> categories)
        {
            CategoryList.Clear();

            foreach (KeyValuePair<string, int> entry in categories)
                CategoryList.Items.Add(entry.Key, entry.Value);
        }

        public void UpdateItems(Dictionary<int, RadioComponent> items)
        {
            DataGrid.Rows.Clear();

            foreach (KeyValuePair<int, RadioComponent> entry in items)
            {
                DataGrid.Rows.Add(

                    entry.Key.ToString(),
                    entry.Value.Model,
                    entry.Value.Name,
                    entry.Value.Specs,
                    entry.Value.MaxVal,
                    entry.Value.Price
                );
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (SelectedCategoryName != null && SearchStrip.Text != "")
                Search?.Invoke(SearchStrip.Text);
        }

        private void SearchStrip_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Search?.Invoke(SearchStrip.Text);
        }
    }
}
