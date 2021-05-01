
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
            this.productGridView.Location = new System.Drawing.Point(26, 127);
            this.productGridView.Margin = new System.Windows.Forms.Padding(2);
            this.productGridView.Name = "productGridView";
            this.productGridView.RowHeadersWidth = 51;
            this.productGridView.RowTemplate.Height = 24;
            this.productGridView.Size = new System.Drawing.Size(922, 288);
            this.productGridView.TabIndex = 0;
            // 
            // viewByIdButton
            // 
            this.viewByIdButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewByIdButton.Location = new System.Drawing.Point(550, 55);
            this.viewByIdButton.Margin = new System.Windows.Forms.Padding(2);
            this.viewByIdButton.Name = "viewByIdButton";
            this.viewByIdButton.Size = new System.Drawing.Size(76, 24);
            this.viewByIdButton.TabIndex = 1;
            this.viewByIdButton.Text = "View";
            this.viewByIdButton.UseVisualStyleBackColor = true;
            this.viewByIdButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(825, 67);
            this.removeButton.Margin = new System.Windows.Forms.Padding(2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(77, 25);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // showByIdTextBox
            // 
            this.showByIdTextBox.Location = new System.Drawing.Point(550, 20);
            this.showByIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.showByIdTextBox.Name = "showByIdTextBox";
            this.showByIdTextBox.Size = new System.Drawing.Size(76, 20);
            this.showByIdTextBox.TabIndex = 2;
            // 
            // removeTextBox
            // 
            this.removeTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.removeTextBox.Location = new System.Drawing.Point(825, 32);
            this.removeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.removeTextBox.Multiline = true;
            this.removeTextBox.Name = "removeTextBox";
            this.removeTextBox.Size = new System.Drawing.Size(116, 23);
            this.removeTextBox.TabIndex = 3;
            this.removeTextBox.Text = "Enter Product ID";
            this.removeTextBox.Click += new System.EventHandler(this.removeTextBox_Click);
            this.removeTextBox.TextChanged += new System.EventHandler(this.removeTextBox_TextChanged);
            // 
            // enterIdLabel
            // 
            this.enterIdLabel.AutoSize = true;
            this.enterIdLabel.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterIdLabel.Location = new System.Drawing.Point(443, 20);
            this.enterIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enterIdLabel.Name = "enterIdLabel";
            this.enterIdLabel.Size = new System.Drawing.Size(103, 16);
            this.enterIdLabel.TabIndex = 4;
            this.enterIdLabel.Text = "Enter Product ID";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(461, 430);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(56, 19);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(70, 20);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(92, 21);
            this.categoryComboBox.TabIndex = 6;
            // 
            // brandComboBox
            // 
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.Location = new System.Drawing.Point(226, 20);
            this.brandComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.brandComboBox.Name = "brandComboBox";
            this.brandComboBox.Size = new System.Drawing.Size(92, 21);
            this.brandComboBox.TabIndex = 7;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(6, 20);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(60, 16);
            this.categoryLabel.TabIndex = 8;
            this.categoryLabel.Text = "Category";
            this.categoryLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandLabel.Location = new System.Drawing.Point(180, 24);
            this.brandLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(42, 16);
            this.brandLabel.TabIndex = 9;
            this.brandLabel.Text = "Brand";
            // 
            // showGroupBox
            // 
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
            this.showGroupBox.Location = new System.Drawing.Point(26, 11);
            this.showGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.showGroupBox.Name = "showGroupBox";
            this.showGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.showGroupBox.Size = new System.Drawing.Size(630, 101);
            this.showGroupBox.TabIndex = 10;
            this.showGroupBox.TabStop = false;
            this.showGroupBox.Text = "Show";
            this.showGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bothButton
            // 
            this.bothButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bothButton.Location = new System.Drawing.Point(346, 20);
            this.bothButton.Margin = new System.Windows.Forms.Padding(2);
            this.bothButton.Name = "bothButton";
            this.bothButton.Size = new System.Drawing.Size(82, 59);
            this.bothButton.TabIndex = 12;
            this.bothButton.Text = "By Both";
            this.bothButton.UseVisualStyleBackColor = true;
            this.bothButton.Click += new System.EventHandler(this.bothButton_Click);
            // 
            // showByBrandButton
            // 
            this.showByBrandButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showByBrandButton.Location = new System.Drawing.Point(228, 56);
            this.showByBrandButton.Margin = new System.Windows.Forms.Padding(2);
            this.showByBrandButton.Name = "showByBrandButton";
            this.showByBrandButton.Size = new System.Drawing.Size(92, 24);
            this.showByBrandButton.TabIndex = 11;
            this.showByBrandButton.Text = "By Brand";
            this.showByBrandButton.UseVisualStyleBackColor = true;
            this.showByBrandButton.Click += new System.EventHandler(this.showByBrandButton_Click);
            // 
            // showByCategoryButton
            // 
            this.showByCategoryButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showByCategoryButton.Location = new System.Drawing.Point(70, 55);
            this.showByCategoryButton.Margin = new System.Windows.Forms.Padding(2);
            this.showByCategoryButton.Name = "showByCategoryButton";
            this.showByCategoryButton.Size = new System.Drawing.Size(92, 24);
            this.showByCategoryButton.TabIndex = 10;
            this.showByCategoryButton.Text = "By Category";
            this.showByCategoryButton.UseVisualStyleBackColor = true;
            this.showByCategoryButton.Click += new System.EventHandler(this.showByCategoryButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(673, 66);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(77, 25);
            this.updateButton.TabIndex = 11;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // updateTextBox
            // 
            this.updateTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.updateTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.updateTextBox.Location = new System.Drawing.Point(673, 31);
            this.updateTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.updateTextBox.Multiline = true;
            this.updateTextBox.Name = "updateTextBox";
            this.updateTextBox.Size = new System.Drawing.Size(116, 23);
            this.updateTextBox.TabIndex = 12;
            this.updateTextBox.Text = "Enter Product ID";
            this.updateTextBox.Click += new System.EventHandler(this.updateTextBox_Click);
            // 
            // ViewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 495);
            this.Controls.Add(this.updateTextBox);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.showGroupBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.removeTextBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.productGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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