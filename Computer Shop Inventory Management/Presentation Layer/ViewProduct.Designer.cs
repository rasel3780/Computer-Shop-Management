
namespace Computer_Shop_Inventory_Management.Presentation_Layer
{
    partial class ViewProduct
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
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.viewByIdButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.showByIdTextBox = new System.Windows.Forms.TextBox();
            this.removeTextBox = new System.Windows.Forms.TextBox();
            this.enterIdLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.brandComboBox = new System.Windows.Forms.ComboBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.showGroupBox = new System.Windows.Forms.GroupBox();
            this.showAllButton = new System.Windows.Forms.Button();
            this.bothButton = new System.Windows.Forms.Button();
            this.showByBrandButton = new System.Windows.Forms.Button();
            this.showByCategoryButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.updateTextBox = new System.Windows.Forms.TextBox();
            this.sellTextBox = new System.Windows.Forms.TextBox();
            this.sellButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.phoneNoTextBox = new System.Windows.Forms.TextBox();
            this.buyerNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.highToLowButton = new System.Windows.Forms.Button();
            this.lowToHighButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            this.showGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // productGridView
            // 
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView.Location = new System.Drawing.Point(35, 156);
            this.productGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productGridView.Name = "productGridView";
            this.productGridView.RowHeadersWidth = 51;
            this.productGridView.RowTemplate.Height = 24;
            this.productGridView.Size = new System.Drawing.Size(1133, 390);
            this.productGridView.TabIndex = 0;
            this.productGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productGridView_CellContentClick);
            // 
            // viewByIdButton
            // 
            this.viewByIdButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewByIdButton.Location = new System.Drawing.Point(586, 69);
            this.viewByIdButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewByIdButton.Name = "viewByIdButton";
            this.viewByIdButton.Size = new System.Drawing.Size(101, 30);
            this.viewByIdButton.TabIndex = 1;
            this.viewByIdButton.Text = "View";
            this.viewByIdButton.UseVisualStyleBackColor = true;
            this.viewByIdButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(1092, 80);
            this.removeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(103, 31);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // showByIdTextBox
            // 
            this.showByIdTextBox.Location = new System.Drawing.Point(587, 33);
            this.showByIdTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showByIdTextBox.Name = "showByIdTextBox";
            this.showByIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.showByIdTextBox.TabIndex = 2;
            // 
            // removeTextBox
            // 
            this.removeTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.removeTextBox.Location = new System.Drawing.Point(1092, 36);
            this.removeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeTextBox.Multiline = true;
            this.removeTextBox.Name = "removeTextBox";
            this.removeTextBox.Size = new System.Drawing.Size(103, 27);
            this.removeTextBox.TabIndex = 3;
            this.removeTextBox.Text = "Enter Product ID";
            this.removeTextBox.Click += new System.EventHandler(this.removeTextBox_Click);
            this.removeTextBox.TextChanged += new System.EventHandler(this.removeTextBox_TextChanged);
            // 
            // enterIdLabel
            // 
            this.enterIdLabel.AutoSize = true;
            this.enterIdLabel.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterIdLabel.Location = new System.Drawing.Point(582, 11);
            this.enterIdLabel.Name = "enterIdLabel";
            this.enterIdLabel.Size = new System.Drawing.Size(132, 20);
            this.enterIdLabel.TabIndex = 4;
            this.enterIdLabel.Text = "Enter Product ID";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(35, 565);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 31);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(93, 25);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(121, 24);
            this.categoryComboBox.TabIndex = 6;
            // 
            // brandComboBox
            // 
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.Location = new System.Drawing.Point(301, 25);
            this.brandComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brandComboBox.Name = "brandComboBox";
            this.brandComboBox.Size = new System.Drawing.Size(121, 24);
            this.brandComboBox.TabIndex = 7;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(8, 25);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(76, 20);
            this.categoryLabel.TabIndex = 8;
            this.categoryLabel.Text = "Category";
            this.categoryLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandLabel.Location = new System.Drawing.Point(240, 30);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(53, 20);
            this.brandLabel.TabIndex = 9;
            this.brandLabel.Text = "Brand";
            // 
            // showGroupBox
            // 
            this.showGroupBox.Controls.Add(this.groupBox2);
            this.showGroupBox.Controls.Add(this.showAllButton);
            this.showGroupBox.Controls.Add(this.bothButton);
            this.showGroupBox.Controls.Add(this.showByBrandButton);
            this.showGroupBox.Controls.Add(this.enterIdLabel);
            this.showGroupBox.Controls.Add(this.showByCategoryButton);
            this.showGroupBox.Controls.Add(this.showByIdTextBox);
            this.showGroupBox.Controls.Add(this.categoryComboBox);
            this.showGroupBox.Controls.Add(this.brandLabel);
            this.showGroupBox.Controls.Add(this.brandComboBox);
            this.showGroupBox.Controls.Add(this.viewByIdButton);
            this.showGroupBox.Controls.Add(this.categoryLabel);
            this.showGroupBox.Location = new System.Drawing.Point(35, 14);
            this.showGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showGroupBox.Name = "showGroupBox";
            this.showGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showGroupBox.Size = new System.Drawing.Size(912, 124);
            this.showGroupBox.TabIndex = 10;
            this.showGroupBox.TabStop = false;
            this.showGroupBox.Text = "Show";
            this.showGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(461, 25);
            this.showAllButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(109, 30);
            this.showAllButton.TabIndex = 13;
            this.showAllButton.Text = "Show All";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // bothButton
            // 
            this.bothButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bothButton.Location = new System.Drawing.Point(461, 69);
            this.bothButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bothButton.Name = "bothButton";
            this.bothButton.Size = new System.Drawing.Size(109, 30);
            this.bothButton.TabIndex = 12;
            this.bothButton.Text = "By Both";
            this.bothButton.UseVisualStyleBackColor = true;
            this.bothButton.Click += new System.EventHandler(this.bothButton_Click);
            // 
            // showByBrandButton
            // 
            this.showByBrandButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showByBrandButton.Location = new System.Drawing.Point(304, 69);
            this.showByBrandButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showByBrandButton.Name = "showByBrandButton";
            this.showByBrandButton.Size = new System.Drawing.Size(123, 30);
            this.showByBrandButton.TabIndex = 11;
            this.showByBrandButton.Text = "By Brand";
            this.showByBrandButton.UseVisualStyleBackColor = true;
            this.showByBrandButton.Click += new System.EventHandler(this.showByBrandButton_Click);
            // 
            // showByCategoryButton
            // 
            this.showByCategoryButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showByCategoryButton.Location = new System.Drawing.Point(93, 68);
            this.showByCategoryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showByCategoryButton.Name = "showByCategoryButton";
            this.showByCategoryButton.Size = new System.Drawing.Size(123, 30);
            this.showByCategoryButton.TabIndex = 10;
            this.showByCategoryButton.Text = "By Category";
            this.showByCategoryButton.UseVisualStyleBackColor = true;
            this.showByCategoryButton.Click += new System.EventHandler(this.showByCategoryButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(953, 79);
            this.updateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(103, 31);
            this.updateButton.TabIndex = 11;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // updateTextBox
            // 
            this.updateTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.updateTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.updateTextBox.Location = new System.Drawing.Point(953, 36);
            this.updateTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateTextBox.Multiline = true;
            this.updateTextBox.Name = "updateTextBox";
            this.updateTextBox.Size = new System.Drawing.Size(114, 27);
            this.updateTextBox.TabIndex = 12;
            this.updateTextBox.Text = "Enter Product ID";
            this.updateTextBox.Click += new System.EventHandler(this.updateTextBox_Click);
            this.updateTextBox.TextChanged += new System.EventHandler(this.updateTextBox_TextChanged_1);
            // 
            // sellTextBox
            // 
            this.sellTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.sellTextBox.Location = new System.Drawing.Point(27, 135);
            this.sellTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sellTextBox.Multiline = true;
            this.sellTextBox.Name = "sellTextBox";
            this.sellTextBox.Size = new System.Drawing.Size(132, 31);
            this.sellTextBox.TabIndex = 14;
            this.sellTextBox.Text = "Enter Product ID";
            this.sellTextBox.Click += new System.EventHandler(this.sellTextBox_Click);
            // 
            // sellButton
            // 
            this.sellButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellButton.Location = new System.Drawing.Point(45, 240);
            this.sellButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(103, 34);
            this.sellButton.TabIndex = 13;
            this.sellButton.Text = "Sell";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.quantityTextBox);
            this.groupBox1.Controls.Add(this.phoneNoTextBox);
            this.groupBox1.Controls.Add(this.buyerNameTextBox);
            this.groupBox1.Controls.Add(this.sellButton);
            this.groupBox1.Controls.Add(this.sellTextBox);
            this.groupBox1.Location = new System.Drawing.Point(1201, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(196, 298);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sell";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.quantityTextBox.Location = new System.Drawing.Point(27, 185);
            this.quantityTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quantityTextBox.Multiline = true;
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(132, 31);
            this.quantityTextBox.TabIndex = 16;
            this.quantityTextBox.Text = "Quantity";
            this.quantityTextBox.Click += new System.EventHandler(this.quantityTextBox_Click);
            this.quantityTextBox.TextChanged += new System.EventHandler(this.quantityTextBox_TextChanged);
            // 
            // phoneNoTextBox
            // 
            this.phoneNoTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.phoneNoTextBox.Location = new System.Drawing.Point(27, 85);
            this.phoneNoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phoneNoTextBox.Multiline = true;
            this.phoneNoTextBox.Name = "phoneNoTextBox";
            this.phoneNoTextBox.Size = new System.Drawing.Size(132, 31);
            this.phoneNoTextBox.TabIndex = 14;
            this.phoneNoTextBox.Text = "Enter Phone No";
            this.phoneNoTextBox.Click += new System.EventHandler(this.phoneNoTextBox_Click);
            // 
            // buyerNameTextBox
            // 
            this.buyerNameTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.buyerNameTextBox.Location = new System.Drawing.Point(27, 42);
            this.buyerNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buyerNameTextBox.Multiline = true;
            this.buyerNameTextBox.Name = "buyerNameTextBox";
            this.buyerNameTextBox.Size = new System.Drawing.Size(132, 31);
            this.buyerNameTextBox.TabIndex = 15;
            this.buyerNameTextBox.Text = "Enter Buyer Name";
            this.buyerNameTextBox.Click += new System.EventHandler(this.buyerNameTextBox_Click);
            this.buyerNameTextBox.TextChanged += new System.EventHandler(this.buyerNameTextBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lowToHighButton);
            this.groupBox2.Controls.Add(this.highToLowButton);
            this.groupBox2.Location = new System.Drawing.Point(729, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 100);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sort By Price";
            // 
            // highToLowButton
            // 
            this.highToLowButton.Location = new System.Drawing.Point(27, 22);
            this.highToLowButton.Name = "highToLowButton";
            this.highToLowButton.Size = new System.Drawing.Size(121, 26);
            this.highToLowButton.TabIndex = 0;
            this.highToLowButton.Text = "High To Low";
            this.highToLowButton.UseVisualStyleBackColor = true;
            this.highToLowButton.Click += new System.EventHandler(this.highToLowButton_Click);
            // 
            // lowToHighButton
            // 
            this.lowToHighButton.Location = new System.Drawing.Point(27, 57);
            this.lowToHighButton.Name = "lowToHighButton";
            this.lowToHighButton.Size = new System.Drawing.Size(120, 30);
            this.lowToHighButton.TabIndex = 1;
            this.lowToHighButton.Text = "Low to High";
            this.lowToHighButton.UseVisualStyleBackColor = true;
            this.lowToHighButton.Click += new System.EventHandler(this.lowToHighButton_Click);
            // 
            // ViewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 609);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.updateTextBox);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.showGroupBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.removeTextBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.productGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ViewProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewProduct";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewProduct_FormClosing);
            this.Load += new System.EventHandler(this.ViewProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            this.showGroupBox.ResumeLayout(false);
            this.showGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productGridView;
        private System.Windows.Forms.Button viewByIdButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox showByIdTextBox;
        private System.Windows.Forms.TextBox removeTextBox;
        private System.Windows.Forms.Label enterIdLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox brandComboBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.GroupBox showGroupBox;
        private System.Windows.Forms.Button showByCategoryButton;
        private System.Windows.Forms.Button bothButton;
        private System.Windows.Forms.Button showByBrandButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox updateTextBox;
        private System.Windows.Forms.TextBox sellTextBox;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.TextBox phoneNoTextBox;
        private System.Windows.Forms.TextBox buyerNameTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button lowToHighButton;
        private System.Windows.Forms.Button highToLowButton;

        public string ShowByIdTextBox
        {
            get { return this.showByIdTextBox.Text; }
        }
        public string RemoveTextBox
        {
            get { return this.removeTextBox.Text; }
        }
        public string CategoryComboBox
        {
            get { return this.categoryComboBox.Text; }
        }
        public string BrandComboBox
        {
            get { return this.brandComboBox.Text; }
        }
       
        public string UpdateTextBox
        {
            get { return this.updateTextBox.Text;}
        }
        public string SellTextBox
        {
            get { return this.sellTextBox.Text; }
        }
      
    }
}