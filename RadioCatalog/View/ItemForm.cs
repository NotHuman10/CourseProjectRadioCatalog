using System;
using System.Windows.Forms;
using RadioCatalog.LIB;
using System.Drawing;

namespace RadioCatalog
{
    public partial class ItemForm : Form, IViewItem
    {
        public ItemForm()
        {
            InitializeComponent();

            CreateItemBtn.Click += CreateItem;
        }

        public ItemForm(RadioComponent editable)
        {
            InitializeComponent();

            Text = "Редактирование элемента";
            CreateItemBtn.Text = "Применить";

            NameTxtBox.Text = editable.Name;
            ModelTxtBox.Text = editable.Model;
            SpecsTxtBox.Text = editable.Specs;
            MaxValTxtBox.Text = editable.MaxVal;
            PriceNumericUpDown.Value = (decimal)editable.Price;

            CreateItemBtn.Click += CreateItem;
        }

        public new void Show()
        {
            ShowDialog();
        }

        public event NodeEventHandler ItemCreated;

        void CreateItem(object sender, EventArgs e)
        {
            RadioComponent rc = new RadioComponent(

                ModelTxtBox.Text,
                NameTxtBox.Text,
                SpecsTxtBox.Text,
                MaxValTxtBox.Text,
                (float)PriceNumericUpDown.Value
            );

            if (IsValidInput(rc))
            {
                ItemCreated?.Invoke(rc);
                Close();
            }
                
        }

        bool IsValidInput(RadioComponent rc)
        {
            Color standard = Color.FromName("Black");
            Color highlight = Color.FromName("Red");

            InputModelLabel.ForeColor = rc.Model == "" ? highlight : standard;
            InputNameLabel.ForeColor = rc.Name == "" ? highlight : standard;
            InputSpecsLabel.ForeColor = rc.Specs == "" ? highlight : standard;
            InputMaxValLabel.ForeColor = rc.MaxVal == "" ? highlight : standard;
            InputPriceLabel.ForeColor = rc.Price == 0 ? highlight : standard;

            return rc.Model != "" && rc.Name != "" &&
                rc.Specs != "" && rc.MaxVal != "" && rc.Price != 0;
        }
    }
}
