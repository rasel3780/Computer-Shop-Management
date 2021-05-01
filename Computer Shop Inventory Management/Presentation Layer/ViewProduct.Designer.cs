
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
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.brandComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.showGroupBox = new System.Windows.Forms.GroupBox();
            this.bothButton = new System.Windows.Forms.Button();
            this.showByBrandButton = new System.Windows.Forms.Button();
            this.showByCategoryButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.updateTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            this.showGroupBox.SuspendLayout();
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
            this.productGridView.Size = new System.Drawing.Size(1229, 355);
            this.productGridView.TabIndex = 0;
            // 
            // viewByIdButton
            // 
            this.viewByIdButton.Location = new System.Drawing.Point(614, 66);
            this.viewByIdButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewByIdButton.Name = "viewByIdButton";
            this.viewByIdButton.Size = new System.Drawing.Size(85, 28);
            this.viewByIdButton.TabIndex = 1;
            this.viewByIdButton.Text = "View";
            this.viewByIdButton.UseVisualStyleBackColor = true;
            this.viewByIdButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(429, 59);
            this.removeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(81, 30);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // showByIdTextBox
            // 
            this.showByIdTextBox.Location = new System.Drawing.Point(488, 69);
            this.showByIdTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showByIdTextBox.Name = "showByIdTextBox";
            this.showByIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.showByIdTextBox.TabIndex = 2;
            // 
            // removeTextBox
            // 
            this.removeTextBox.Location = new System.Drawing.Point(315, 62);
            this.removeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeTextBox.Name = "removeTextBox";
            this.removeTextBox.Size = new System.Drawing.Size(100, 22);
            this.removeTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Product ID";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(615, 529);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(117, 31);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(121, 24);
            this.categoryComboBox.TabIndex = 6;
            // 
            // brandComboBox
            // 
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.Location = new System.Drawing.Point(315, 33);
            this.brandComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brandComboBox.Name = "brandComboBox";
            this.brandComboBox.Size = new System.Drawing.Size(121, 24);
            this.brandComboBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Category";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Brand";
            // 
            // showGroupBox
            // 
            this.showGroupBox.Controls.Add(this.bothButton);
            this.showGroupBox.Controls.Add(this.showByBrandButton);
            this.showGroupBox.Controls.Add(this.label1);
            this.showGroupBox.Controls.Add(this.showByCategoryButton);
            this.showGroupBox.Controls.Add(this.showByIdTextBox);
            this.showGroupBox.Controls.Add(this.categoryComboBox);
            this.showGroupBox.Controls.Add(this.label3);
            this.showGroupBox.Controls.Add(this.brandComboBox);
            this.showGroupBox.Controls.Add(this.viewByIdButton);
            this.showGroupBox.Controls.Add(this.label2);
            this.showGroupBox.Location = new System.Drawing.Point(529, 14);
            this.showGroupBox.Name = "showGroupBox";
            this.showGroupBox.Size = new System.Drawing.Size(721, 124);
            this.showGroupBox.TabIndex = 10;
            this.showGroupBox.TabStop = false;
            this.showGroupBox.Text = "Show";
            this.showGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bothButton
            // 
            this.bothButton.Location = new System.Drawing.Point(327, 71);
            this.bothButton.Name = "bothButton";
            this.bothButton.Size = new System.Drawing.Size(109, 26);
            this.bothButton.TabIndex = 12;
            this.bothButton.Text = "By Both";
            this.bothButton.UseVisualStyleBackColor = true;
            this.bothButton.Click += new System.EventHandler(this.bothButton_Click);
            // 
            // showByBrandButton
            // 
            this.showByBrandButton.Location = new System.Drawing.Point(177, 71);
            this.showByBrandButton.Name = "showByBrandButton";
            this.showByBrandButton.Size = new System.Drawing.Size(109, 26);
            this.showByBrandButton.TabIndex = 11;
            this.showByBrandButton.Text = "By Brand";
            this.showByBrandButton.UseVisualStyleBackColor = true;
            this.showByBrandButton.Click += new System.EventHandler(this.showByBrandButton_Click);
            // 
            // showByCategoryButton
            // 
            this.showByCategoryButton.Location = new System.Drawing.Point(28, 71);
            this.showByCategoryButton.Name = "showByCategoryButton";
            this.showByCategoryButton.Size = new System.Drawing.Size(109, 26);
            this.showByCategoryButton.TabIndex = 10;
            this.showByCategoryButton.Text = "By Category";
            this.showByCategoryButton.UseVisualStyleBackColor = true;
            this.showByCategoryButton.Click += new System.EventHandler(this.showByCategoryButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(141, 63);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(81, 26);
            this.updateButton.TabIndex = 11;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // updateTextBox
            // 
            this.updateTextBox.Location = new System.Drawing.Point(35, 63);
            this.updateTextBox.Name = "updateTextBox";
            this.updateTextBox.Size = new System.Drawing.Size(100, 22);
            this.updateTextBox.TabIndex = 12;
            // 
            // ViewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 609);
            this.Controls.Add(this.updateTextBox);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.showGroupBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.removeTextBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.productGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ViewProduct";
            this.Text = "ViewProduct";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewProduct_FormClosing);
            this.Load += new System.EventHandler(this.ViewProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            this.showGroupBox.ResumeLayout(false);
            this.showGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productGridView;
        private System.Windows.Forms.Button viewByIdButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox showByIdTextBox;
        private System.Windows.Forms.TextBox removeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox brandComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox showGroupBox;
        private System.Windows.Forms.Button showByCategoryButton;
        private System.Windows.Forms.Button bothButton;
        private System.Windows.Forms.Button showByBrandButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox updateTextBox;

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
      
    }
}