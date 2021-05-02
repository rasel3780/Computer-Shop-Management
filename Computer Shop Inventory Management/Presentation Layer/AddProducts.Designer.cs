
namespace Computer_Shop_Inventory_Management.Presentation_Layer
{
    partial class AddProducts
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
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.addProductGroupBox1 = new System.Windows.Forms.GroupBox();
            this.backButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.featureGroupBox = new System.Windows.Forms.GroupBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureAddButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.addProductButton = new System.Windows.Forms.Button();
            this.brandComboBox = new System.Windows.Forms.ComboBox();
            this.brandLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.warrantyLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.warrentyComboBox = new System.Windows.Forms.ComboBox();
            this.addProductGroupBox1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.featureGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(443, 38);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(167, 23);
            this.priceTextBox.TabIndex = 0;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(347, 42);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(55, 16);
            this.priceLabel.TabIndex = 1;
            this.priceLabel.Text = "Price(/1)";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(135, 39);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(167, 24);
            this.categoryComboBox.TabIndex = 2;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // addProductGroupBox1
            // 
            this.addProductGroupBox1.Controls.Add(this.backButton);
            this.addProductGroupBox1.Controls.Add(this.groupBox1);
            this.addProductGroupBox1.Controls.Add(this.featureGroupBox);
            this.addProductGroupBox1.Controls.Add(this.pictureAddButton);
            this.addProductGroupBox1.Controls.Add(this.pictureBox1);
            this.addProductGroupBox1.Controls.Add(this.descriptionTextBox);
            this.addProductGroupBox1.Controls.Add(this.descriptionLabel);
            this.addProductGroupBox1.Controls.Add(this.addProductButton);
            this.addProductGroupBox1.Controls.Add(this.brandComboBox);
            this.addProductGroupBox1.Controls.Add(this.brandLabel);
            this.addProductGroupBox1.Controls.Add(this.quantityTextBox);
            this.addProductGroupBox1.Controls.Add(this.warrantyLabel);
            this.addProductGroupBox1.Controls.Add(this.priceLabel);
            this.addProductGroupBox1.Controls.Add(this.quantityLabel);
            this.addProductGroupBox1.Controls.Add(this.priceTextBox);
            this.addProductGroupBox1.Controls.Add(this.categoryLabel);
            this.addProductGroupBox1.Controls.Add(this.warrentyComboBox);
            this.addProductGroupBox1.Controls.Add(this.categoryComboBox);
            this.addProductGroupBox1.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductGroupBox1.Location = new System.Drawing.Point(10, 9);
            this.addProductGroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.addProductGroupBox1.Name = "addProductGroupBox1";
            this.addProductGroupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.addProductGroupBox1.Size = new System.Drawing.Size(947, 514);
            this.addProductGroupBox1.TabIndex = 3;
            this.addProductGroupBox1.TabStop = false;
            this.addProductGroupBox1.Text = "Add Products";
            this.addProductGroupBox1.Enter += new System.EventHandler(this.addProductGroupBox1_Enter);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(6, 477);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 27);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectButton);
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Location = new System.Drawing.Point(42, 132);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(238, 272);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Categories";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(83, 230);
            this.selectButton.Margin = new System.Windows.Forms.Padding(2);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(69, 28);
            this.selectButton.TabIndex = 1;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Capacity",
            "Memory Type",
            "Bus Speed",
            "Screen Size",
            "Refresh Rate",
            "Wattage",
            "Motherboard Type",
            "Clock Speed",
            "Connection Type",
            "Response Time"});
            this.checkedListBox1.Location = new System.Drawing.Point(25, 24);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(194, 184);
            this.checkedListBox1.TabIndex = 0;
            // 
            // featureGroupBox
            // 
            this.featureGroupBox.Controls.Add(this.comboBox4);
            this.featureGroupBox.Controls.Add(this.comboBox5);
            this.featureGroupBox.Controls.Add(this.comboBox1);
            this.featureGroupBox.Controls.Add(this.comboBox2);
            this.featureGroupBox.Controls.Add(this.label4);
            this.featureGroupBox.Controls.Add(this.label5);
            this.featureGroupBox.Controls.Add(this.label1);
            this.featureGroupBox.Controls.Add(this.comboBox3);
            this.featureGroupBox.Controls.Add(this.label2);
            this.featureGroupBox.Controls.Add(this.label3);
            this.featureGroupBox.Location = new System.Drawing.Point(299, 132);
            this.featureGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.featureGroupBox.Name = "featureGroupBox";
            this.featureGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.featureGroupBox.Size = new System.Drawing.Size(326, 272);
            this.featureGroupBox.TabIndex = 4;
            this.featureGroupBox.TabStop = false;
            this.featureGroupBox.Text = "Features";
            this.featureGroupBox.Visible = false;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(142, 168);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(167, 24);
            this.comboBox4.TabIndex = 2;
            this.comboBox4.Visible = false;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(142, 215);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(167, 24);
            this.comboBox5.TabIndex = 2;
            this.comboBox5.Visible = false;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(142, 37);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(142, 81);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(167, 24);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.Visible = false;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Screen Size";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Refresh Rate";
            this.label5.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Capacity";
            this.label1.Visible = false;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(142, 125);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(167, 24);
            this.comboBox3.TabIndex = 2;
            this.comboBox3.Visible = false;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Memory Type";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bus Speed";
            this.label3.Visible = false;
            // 
            // pictureAddButton
            // 
            this.pictureAddButton.Location = new System.Drawing.Point(720, 311);
            this.pictureAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.pictureAddButton.Name = "pictureAddButton";
            this.pictureAddButton.Size = new System.Drawing.Size(110, 25);
            this.pictureAddButton.TabIndex = 3;
            this.pictureAddButton.Text = "Add Picture";
            this.pictureAddButton.UseVisualStyleBackColor = true;
            this.pictureAddButton.Click += new System.EventHandler(this.pictureAddButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(720, 110);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 180);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(720, 359);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(203, 121);
            this.descriptionTextBox.TabIndex = 0;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(717, 482);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(71, 16);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "Description";
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(428, 460);
            this.addProductButton.Margin = new System.Windows.Forms.Padding(2);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(130, 37);
            this.addProductButton.TabIndex = 3;
            this.addProductButton.Text = "Add Product";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // brandComboBox
            // 
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.Location = new System.Drawing.Point(135, 77);
            this.brandComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.brandComboBox.Name = "brandComboBox";
            this.brandComboBox.Size = new System.Drawing.Size(167, 24);
            this.brandComboBox.TabIndex = 2;
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Location = new System.Drawing.Point(39, 79);
            this.brandLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(42, 16);
            this.brandLabel.TabIndex = 1;
            this.brandLabel.Text = "Brand";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(443, 74);
            this.quantityTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(167, 23);
            this.quantityTextBox.TabIndex = 0;
            // 
            // warrantyLabel
            // 
            this.warrantyLabel.AutoSize = true;
            this.warrantyLabel.Location = new System.Drawing.Point(647, 41);
            this.warrantyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.warrantyLabel.Name = "warrantyLabel";
            this.warrantyLabel.Size = new System.Drawing.Size(61, 16);
            this.warrantyLabel.TabIndex = 1;
            this.warrantyLabel.Text = "Warranty";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(347, 78);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(57, 16);
            this.quantityLabel.TabIndex = 1;
            this.quantityLabel.Text = "Quantity";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(39, 42);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(60, 16);
            this.categoryLabel.TabIndex = 1;
            this.categoryLabel.Text = "Category";
            // 
            // warrentyComboBox
            // 
            this.warrentyComboBox.FormattingEnabled = true;
            this.warrentyComboBox.Items.AddRange(new object[] {
            "6 Months",
            "1 Year",
            "2 Years",
            "3 Years",
            "5 Years",
            "7 Years",
            "10 Years",
            "Lifetime"});
            this.warrentyComboBox.Location = new System.Drawing.Point(720, 37);
            this.warrentyComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.warrentyComboBox.Name = "warrentyComboBox";
            this.warrentyComboBox.Size = new System.Drawing.Size(167, 24);
            this.warrentyComboBox.TabIndex = 2;
            this.warrentyComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // AddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 526);
            this.Controls.Add(this.addProductGroupBox1);
            this.Name = "AddProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddProducts_FormClosing);
            this.Load += new System.EventHandler(this.AddProducts_Load);
            this.addProductGroupBox1.ResumeLayout(false);
            this.addProductGroupBox1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.featureGroupBox.ResumeLayout(false);
            this.featureGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.GroupBox addProductGroupBox1;
        private System.Windows.Forms.ComboBox brandComboBox;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.GroupBox featureGroupBox;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button pictureAddButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label warrantyLabel;
        private System.Windows.Forms.ComboBox warrentyComboBox;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button backButton;

        public string Category 
        {
            get { return this.categoryComboBox.Text; }
        }
        public string Brand
        {
            get { return this.brandComboBox.Text; }
        }
        public string Price
        {
            get { return this.priceTextBox.Text; }
        }
        public string Quantity
        {
            get { return this.quantityTextBox.Text; }
        }
        public string Warranty
        {
            get { return this.warrentyComboBox.Text; }
        }

        public string Description
        {
            get { return this.descriptionTextBox.Text; }
        }


        public string ComboBox1
        {
            get { return this.comboBox1.Text; }
        }
        public string ComboBox2
        {
            get { return this.comboBox2.Text; }
        }
        public string ComboBox3
        {
            get { return this.comboBox3.Text; }
        }
        public string ComboBox4
        {
            get { return this.comboBox4.Text; }
        }
        public string ComboBox5
        {
            get { return this.comboBox5.Text; }
        }


        public string Label1
        {
            get { return this.label1.Text; }
        }
        public string Label2
        {
            get { return this.label2.Text; }
        }
        public string Label3
        {
            get { return this.label3.Text; }
        }
        public string Label4
        {
            get { return this.label4.Text; }
        }
        public string Label5
        {
            get { return this.label5.Text; }
        }





        /*public List<string> CheckedListBox
        {
            get { return this.CheckedListBox;  }
        }*/


    }
}