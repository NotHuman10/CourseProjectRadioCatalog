namespace RadioCatalog
{
    partial class ItemForm
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
            this.ModelTxtBox = new System.Windows.Forms.TextBox();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.SpecsTxtBox = new System.Windows.Forms.TextBox();
            this.MaxValTxtBox = new System.Windows.Forms.TextBox();
            this.PriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.InputModelLabel = new System.Windows.Forms.Label();
            this.InputNameLabel = new System.Windows.Forms.Label();
            this.InputSpecsLabel = new System.Windows.Forms.Label();
            this.InputMaxValLabel = new System.Windows.Forms.Label();
            this.InputPriceLabel = new System.Windows.Forms.Label();
            this.CreateItemBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ModelTxtBox
            // 
            this.ModelTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModelTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelTxtBox.Location = new System.Drawing.Point(12, 27);
            this.ModelTxtBox.Name = "ModelTxtBox";
            this.ModelTxtBox.Size = new System.Drawing.Size(200, 21);
            this.ModelTxtBox.TabIndex = 0;
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTxtBox.Location = new System.Drawing.Point(12, 72);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(200, 21);
            this.NameTxtBox.TabIndex = 1;
            // 
            // SpecsTxtBox
            // 
            this.SpecsTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SpecsTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpecsTxtBox.Location = new System.Drawing.Point(12, 117);
            this.SpecsTxtBox.Name = "SpecsTxtBox";
            this.SpecsTxtBox.Size = new System.Drawing.Size(200, 21);
            this.SpecsTxtBox.TabIndex = 2;
            // 
            // MaxValTxtBox
            // 
            this.MaxValTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaxValTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxValTxtBox.Location = new System.Drawing.Point(12, 162);
            this.MaxValTxtBox.Name = "MaxValTxtBox";
            this.MaxValTxtBox.Size = new System.Drawing.Size(200, 21);
            this.MaxValTxtBox.TabIndex = 3;
            // 
            // PriceNumericUpDown
            // 
            this.PriceNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceNumericUpDown.DecimalPlaces = 2;
            this.PriceNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.PriceNumericUpDown.Location = new System.Drawing.Point(12, 207);
            this.PriceNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.PriceNumericUpDown.Name = "PriceNumericUpDown";
            this.PriceNumericUpDown.Size = new System.Drawing.Size(200, 21);
            this.PriceNumericUpDown.TabIndex = 4;
            // 
            // InputModelLabel
            // 
            this.InputModelLabel.AutoSize = true;
            this.InputModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputModelLabel.Location = new System.Drawing.Point(12, 9);
            this.InputModelLabel.Name = "InputModelLabel";
            this.InputModelLabel.Size = new System.Drawing.Size(53, 15);
            this.InputModelLabel.TabIndex = 6;
            this.InputModelLabel.Text = "Модель";
            // 
            // InputNameLabel
            // 
            this.InputNameLabel.AutoSize = true;
            this.InputNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputNameLabel.Location = new System.Drawing.Point(12, 54);
            this.InputNameLabel.Name = "InputNameLabel";
            this.InputNameLabel.Size = new System.Drawing.Size(64, 15);
            this.InputNameLabel.TabIndex = 7;
            this.InputNameLabel.Text = "Название";
            // 
            // InputSpecsLabel
            // 
            this.InputSpecsLabel.AutoSize = true;
            this.InputSpecsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputSpecsLabel.Location = new System.Drawing.Point(13, 99);
            this.InputSpecsLabel.Name = "InputSpecsLabel";
            this.InputSpecsLabel.Size = new System.Drawing.Size(103, 15);
            this.InputSpecsLabel.TabIndex = 8;
            this.InputSpecsLabel.Text = "Характеристики";
            // 
            // InputMaxValLabel
            // 
            this.InputMaxValLabel.AutoSize = true;
            this.InputMaxValLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputMaxValLabel.Location = new System.Drawing.Point(9, 144);
            this.InputMaxValLabel.Name = "InputMaxValLabel";
            this.InputMaxValLabel.Size = new System.Drawing.Size(203, 15);
            this.InputMaxValLabel.TabIndex = 9;
            this.InputMaxValLabel.Text = "Предельно допустимые значения";
            // 
            // InputPriceLabel
            // 
            this.InputPriceLabel.AutoSize = true;
            this.InputPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputPriceLabel.Location = new System.Drawing.Point(13, 189);
            this.InputPriceLabel.Name = "InputPriceLabel";
            this.InputPriceLabel.Size = new System.Drawing.Size(37, 15);
            this.InputPriceLabel.TabIndex = 10;
            this.InputPriceLabel.Text = "Цена";
            // 
            // CreateItemBtn
            // 
            this.CreateItemBtn.Location = new System.Drawing.Point(12, 244);
            this.CreateItemBtn.Name = "CreateItemBtn";
            this.CreateItemBtn.Size = new System.Drawing.Size(104, 23);
            this.CreateItemBtn.TabIndex = 11;
            this.CreateItemBtn.Text = "Добавить";
            this.CreateItemBtn.UseVisualStyleBackColor = true;
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 282);
            this.Controls.Add(this.CreateItemBtn);
            this.Controls.Add(this.InputPriceLabel);
            this.Controls.Add(this.InputMaxValLabel);
            this.Controls.Add(this.InputSpecsLabel);
            this.Controls.Add(this.InputNameLabel);
            this.Controls.Add(this.InputModelLabel);
            this.Controls.Add(this.PriceNumericUpDown);
            this.Controls.Add(this.MaxValTxtBox);
            this.Controls.Add(this.ModelTxtBox);
            this.Controls.Add(this.SpecsTxtBox);
            this.Controls.Add(this.NameTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление элемента";
            ((System.ComponentModel.ISupportInitialize)(this.PriceNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ModelTxtBox;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.TextBox SpecsTxtBox;
        private System.Windows.Forms.TextBox MaxValTxtBox;
        private System.Windows.Forms.NumericUpDown PriceNumericUpDown;
        private System.Windows.Forms.Label InputModelLabel;
        private System.Windows.Forms.Label InputNameLabel;
        private System.Windows.Forms.Label InputSpecsLabel;
        private System.Windows.Forms.Label InputMaxValLabel;
        private System.Windows.Forms.Label InputPriceLabel;
        private System.Windows.Forms.Button CreateItemBtn;
    }
}