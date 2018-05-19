namespace RadioCatalog
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoryPanel = new System.Windows.Forms.Panel();
            this.CategoryList = new System.Windows.Forms.ListView();
            this.IconsList = new System.Windows.Forms.ImageList(this.components);
            this.CategoryTools = new System.Windows.Forms.ToolStrip();
            this.AddCategoryBtn = new System.Windows.Forms.ToolStripButton();
            this.EditCategoryBtn = new System.Windows.Forms.ToolStripButton();
            this.RemoveCategoryBtn = new System.Windows.Forms.ToolStripButton();
            this.ViewPanel = new System.Windows.Forms.Panel();
            this.ItemsHeading = new System.Windows.Forms.Label();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxVal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewTools = new System.Windows.Forms.ToolStrip();
            this.AddItemBtn = new System.Windows.Forms.ToolStripButton();
            this.EditItemBtn = new System.Windows.Forms.ToolStripButton();
            this.RemoveItemBtn = new System.Windows.Forms.ToolStripButton();
            this.SearchBtn = new System.Windows.Forms.ToolStripButton();
            this.SearchStrip = new System.Windows.Forms.ToolStripTextBox();
            this.MenuStrip.SuspendLayout();
            this.CategoryPanel.SuspendLayout();
            this.CategoryTools.SuspendLayout();
            this.ViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.ViewTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(752, 24);
            this.MenuStrip.TabIndex = 0;
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.CreateToolStripMenuItem,
            this.SaveAsToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.OpenToolStripMenuItem.Image = global::RadioCatalog.Properties.Resources.Open;
            this.OpenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
            this.OpenToolStripMenuItem.Text = "Открыть";
            // 
            // CreateToolStripMenuItem
            // 
            this.CreateToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.CreateToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CreateToolStripMenuItem.Image = global::RadioCatalog.Properties.Resources.Create;
            this.CreateToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            this.CreateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.CreateToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
            this.CreateToolStripMenuItem.Text = "Создать";
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Enabled = false;
            this.SaveAsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SaveAsToolStripMenuItem.Image = global::RadioCatalog.Properties.Resources.SaveAs;
            this.SaveAsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
            this.SaveAsToolStripMenuItem.Text = "Сохранить как";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // CategoryPanel
            // 
            this.CategoryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CategoryPanel.Controls.Add(this.CategoryList);
            this.CategoryPanel.Controls.Add(this.CategoryTools);
            this.CategoryPanel.Location = new System.Drawing.Point(12, 27);
            this.CategoryPanel.Name = "CategoryPanel";
            this.CategoryPanel.Size = new System.Drawing.Size(192, 434);
            this.CategoryPanel.TabIndex = 2;
            // 
            // CategoryList
            // 
            this.CategoryList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CategoryList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoryList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryList.LargeImageList = this.IconsList;
            this.CategoryList.Location = new System.Drawing.Point(0, 28);
            this.CategoryList.Margin = new System.Windows.Forms.Padding(0);
            this.CategoryList.Name = "CategoryList";
            this.CategoryList.Size = new System.Drawing.Size(192, 406);
            this.CategoryList.SmallImageList = this.IconsList;
            this.CategoryList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.CategoryList.TabIndex = 1;
            this.CategoryList.UseCompatibleStateImageBehavior = false;
            this.CategoryList.View = System.Windows.Forms.View.SmallIcon;
            // 
            // IconsList
            // 
            this.IconsList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconsList.ImageStream")));
            this.IconsList.TransparentColor = System.Drawing.Color.Transparent;
            this.IconsList.Images.SetKeyName(0, "default.png");
            this.IconsList.Images.SetKeyName(1, "antenna.png");
            this.IconsList.Images.SetKeyName(2, "battery.png");
            this.IconsList.Images.SetKeyName(3, "breadboard.png");
            this.IconsList.Images.SetKeyName(4, "cable.png");
            this.IconsList.Images.SetKeyName(5, "capacitor.png");
            this.IconsList.Images.SetKeyName(6, "ceramic_capacitor.png");
            this.IconsList.Images.SetKeyName(7, "circuit.png");
            this.IconsList.Images.SetKeyName(8, "converter_ac_dc.png");
            this.IconsList.Images.SetKeyName(9, "cooler.png");
            this.IconsList.Images.SetKeyName(10, "counter.png");
            this.IconsList.Images.SetKeyName(11, "diode.png");
            this.IconsList.Images.SetKeyName(12, "display.png");
            this.IconsList.Images.SetKeyName(13, "fuse.png");
            this.IconsList.Images.SetKeyName(14, "inductor.png");
            this.IconsList.Images.SetKeyName(15, "integrated_circuit.png");
            this.IconsList.Images.SetKeyName(16, "lcd_display.png");
            this.IconsList.Images.SetKeyName(17, "led_diode.png");
            this.IconsList.Images.SetKeyName(18, "loudspeaker.png");
            this.IconsList.Images.SetKeyName(19, "microchip.png");
            this.IconsList.Images.SetKeyName(20, "potentiometer.png");
            this.IconsList.Images.SetKeyName(21, "processor.png");
            this.IconsList.Images.SetKeyName(22, "quartz_generator.png");
            this.IconsList.Images.SetKeyName(23, "relay.png");
            this.IconsList.Images.SetKeyName(24, "resistor.png");
            this.IconsList.Images.SetKeyName(25, "stepper_motor.png");
            this.IconsList.Images.SetKeyName(26, "switch.png");
            this.IconsList.Images.SetKeyName(27, "transistor.png");
            this.IconsList.Images.SetKeyName(28, "vacuum_tube.png");
            this.IconsList.Images.SetKeyName(29, "voltmetr.png");
            // 
            // CategoryTools
            // 
            this.CategoryTools.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CategoryTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.CategoryTools.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CategoryTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddCategoryBtn,
            this.EditCategoryBtn,
            this.RemoveCategoryBtn});
            this.CategoryTools.Location = new System.Drawing.Point(0, 0);
            this.CategoryTools.Name = "CategoryTools";
            this.CategoryTools.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.CategoryTools.Size = new System.Drawing.Size(192, 31);
            this.CategoryTools.TabIndex = 0;
            this.CategoryTools.Text = "toolStrip1";
            // 
            // AddCategoryBtn
            // 
            this.AddCategoryBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddCategoryBtn.Enabled = false;
            this.AddCategoryBtn.Image = global::RadioCatalog.Properties.Resources.Add;
            this.AddCategoryBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddCategoryBtn.Name = "AddCategoryBtn";
            this.AddCategoryBtn.Size = new System.Drawing.Size(28, 28);
            this.AddCategoryBtn.ToolTipText = "Добавить";
            this.AddCategoryBtn.Click += new System.EventHandler(this.AddCategoryBtn_Click);
            // 
            // EditCategoryBtn
            // 
            this.EditCategoryBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditCategoryBtn.Enabled = false;
            this.EditCategoryBtn.Image = global::RadioCatalog.Properties.Resources.Edit;
            this.EditCategoryBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditCategoryBtn.Name = "EditCategoryBtn";
            this.EditCategoryBtn.Size = new System.Drawing.Size(28, 28);
            this.EditCategoryBtn.ToolTipText = "Редактировать";
            this.EditCategoryBtn.Click += new System.EventHandler(this.EditCategoryBtn_Click);
            // 
            // RemoveCategoryBtn
            // 
            this.RemoveCategoryBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RemoveCategoryBtn.Enabled = false;
            this.RemoveCategoryBtn.Image = global::RadioCatalog.Properties.Resources.Remove;
            this.RemoveCategoryBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RemoveCategoryBtn.Name = "RemoveCategoryBtn";
            this.RemoveCategoryBtn.Size = new System.Drawing.Size(28, 28);
            this.RemoveCategoryBtn.ToolTipText = "Удалить";
            this.RemoveCategoryBtn.Click += new System.EventHandler(this.RemoveCategoryBtn_Click);
            // 
            // ViewPanel
            // 
            this.ViewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewPanel.Controls.Add(this.ItemsHeading);
            this.ViewPanel.Controls.Add(this.DataGrid);
            this.ViewPanel.Controls.Add(this.ViewTools);
            this.ViewPanel.Location = new System.Drawing.Point(210, 27);
            this.ViewPanel.Name = "ViewPanel";
            this.ViewPanel.Size = new System.Drawing.Size(530, 434);
            this.ViewPanel.TabIndex = 3;
            // 
            // ItemsHeading
            // 
            this.ItemsHeading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsHeading.BackColor = System.Drawing.Color.White;
            this.ItemsHeading.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemsHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ItemsHeading.Location = new System.Drawing.Point(0, 28);
            this.ItemsHeading.Margin = new System.Windows.Forms.Padding(0);
            this.ItemsHeading.Name = "ItemsHeading";
            this.ItemsHeading.Size = new System.Drawing.Size(530, 24);
            this.ItemsHeading.TabIndex = 2;
            this.ItemsHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid.BackgroundColor = System.Drawing.Color.White;
            this.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Key,
            this.Model,
            this.ItemName,
            this.Specs,
            this.MaxVal,
            this.Price});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid.DefaultCellStyle = dataGridViewCellStyle13;
            this.DataGrid.EnableHeadersVisualStyles = false;
            this.DataGrid.GridColor = System.Drawing.Color.White;
            this.DataGrid.Location = new System.Drawing.Point(0, 52);
            this.DataGrid.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.DataGrid.MultiSelect = false;
            this.DataGrid.Name = "DataGrid";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.DataGrid.RowHeadersVisible = false;
            this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid.Size = new System.Drawing.Size(530, 382);
            this.DataGrid.TabIndex = 1;
            // 
            // Key
            // 
            this.Key.HeaderText = "Ключ";
            this.Key.MaxInputLength = 4;
            this.Key.Name = "Key";
            this.Key.ReadOnly = true;
            this.Key.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Key.Visible = false;
            this.Key.Width = 35;
            // 
            // Model
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.Model.DefaultCellStyle = dataGridViewCellStyle10;
            this.Model.HeaderText = "Модель";
            this.Model.MaxInputLength = 20;
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.Width = 80;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Имя";
            this.ItemName.MaxInputLength = 40;
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 120;
            // 
            // Specs
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            this.Specs.DefaultCellStyle = dataGridViewCellStyle11;
            this.Specs.HeaderText = "Характеристики";
            this.Specs.MaxInputLength = 40;
            this.Specs.Name = "Specs";
            this.Specs.ReadOnly = true;
            this.Specs.Width = 220;
            // 
            // MaxVal
            // 
            this.MaxVal.HeaderText = "Предельно допустимые условия эксплуатации";
            this.MaxVal.MaxInputLength = 30;
            this.MaxVal.Name = "MaxVal";
            this.MaxVal.ReadOnly = true;
            this.MaxVal.Width = 200;
            // 
            // Price
            // 
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            this.Price.DefaultCellStyle = dataGridViewCellStyle12;
            this.Price.HeaderText = "Цена";
            this.Price.MaxInputLength = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 75;
            // 
            // ViewTools
            // 
            this.ViewTools.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ViewTools.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ViewTools.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ViewTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddItemBtn,
            this.EditItemBtn,
            this.RemoveItemBtn,
            this.SearchBtn,
            this.SearchStrip});
            this.ViewTools.Location = new System.Drawing.Point(0, 0);
            this.ViewTools.Name = "ViewTools";
            this.ViewTools.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ViewTools.Size = new System.Drawing.Size(530, 31);
            this.ViewTools.TabIndex = 0;
            this.ViewTools.Text = "toolStrip1";
            // 
            // AddItemBtn
            // 
            this.AddItemBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddItemBtn.Enabled = false;
            this.AddItemBtn.Image = global::RadioCatalog.Properties.Resources.Add;
            this.AddItemBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddItemBtn.Name = "AddItemBtn";
            this.AddItemBtn.Size = new System.Drawing.Size(28, 28);
            this.AddItemBtn.ToolTipText = "Добавить";
            this.AddItemBtn.Click += new System.EventHandler(this.AddItemBtn_Click);
            // 
            // EditItemBtn
            // 
            this.EditItemBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditItemBtn.Enabled = false;
            this.EditItemBtn.Image = global::RadioCatalog.Properties.Resources.Edit;
            this.EditItemBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditItemBtn.Name = "EditItemBtn";
            this.EditItemBtn.Size = new System.Drawing.Size(28, 28);
            this.EditItemBtn.ToolTipText = "Редактировать";
            this.EditItemBtn.Click += new System.EventHandler(this.EditItemBtn_Click);
            // 
            // RemoveItemBtn
            // 
            this.RemoveItemBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RemoveItemBtn.Enabled = false;
            this.RemoveItemBtn.Image = global::RadioCatalog.Properties.Resources.Remove;
            this.RemoveItemBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RemoveItemBtn.Name = "RemoveItemBtn";
            this.RemoveItemBtn.Size = new System.Drawing.Size(28, 28);
            this.RemoveItemBtn.ToolTipText = "Удалить";
            this.RemoveItemBtn.Click += new System.EventHandler(this.RemoveItemBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.SearchBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SearchBtn.Image = global::RadioCatalog.Properties.Resources.Search;
            this.SearchBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(28, 28);
            this.SearchBtn.Text = "toolStripButton1";
            this.SearchBtn.ToolTipText = "Поиск";
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchStrip
            // 
            this.SearchStrip.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.SearchStrip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchStrip.Name = "SearchStrip";
            this.SearchStrip.Size = new System.Drawing.Size(256, 31);
            this.SearchStrip.ToolTipText = "Введите текст для поиска";
            this.SearchStrip.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchStrip_KeyUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(752, 473);
            this.Controls.Add(this.ViewPanel);
            this.Controls.Add(this.CategoryPanel);
            this.Controls.Add(this.MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.MinimumSize = new System.Drawing.Size(576, 384);
            this.Name = "MainForm";
            this.Text = "Каталог радиодеталей";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.CategoryPanel.ResumeLayout(false);
            this.CategoryPanel.PerformLayout();
            this.CategoryTools.ResumeLayout(false);
            this.CategoryTools.PerformLayout();
            this.ViewPanel.ResumeLayout(false);
            this.ViewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ViewTools.ResumeLayout(false);
            this.ViewTools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.Panel CategoryPanel;
        private System.Windows.Forms.Panel ViewPanel;
        private System.Windows.Forms.ListView CategoryList;
        private System.Windows.Forms.ToolStrip CategoryTools;
        private System.Windows.Forms.ToolStrip ViewTools;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton AddCategoryBtn;
        private System.Windows.Forms.ToolStripButton EditCategoryBtn;
        private System.Windows.Forms.ToolStripButton RemoveCategoryBtn;
        private System.Windows.Forms.ToolStripButton AddItemBtn;
        private System.Windows.Forms.ToolStripButton EditItemBtn;
        private System.Windows.Forms.ToolStripButton RemoveItemBtn;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton SearchBtn;
        private System.Windows.Forms.ToolStripTextBox SearchStrip;
        private System.Windows.Forms.ImageList IconsList;
        private System.Windows.Forms.Label ItemsHeading;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specs;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxVal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}