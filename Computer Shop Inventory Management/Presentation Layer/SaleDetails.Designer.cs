
namespace Computer_Shop_Inventory_Management.Presentation_Layer
{
    partial class SaleDetails
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
            this.showGroupBox = new System.Windows.Forms.GroupBox();
            this.bothButton = new System.Windows.Forms.Button();
            this.showByBrandButton = new System.Windows.Forms.Button();
            this.showByCategoryButton = new System.Windows.Forms.Button();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.brandLabel = new System.Windows.Forms.Label();
            this.brandComboBox = new System.Windows.Forms.ComboBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.showGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // showGroupBox
            // 
            this.showGroupBox.Controls.Add(this.bothButton);
            this.showGroupBox.Controls.Add(this.showByBrandButton);
            this.showGroupBox.Controls.Add(this.showByCategoryButton);
            this.showGroupBox.Controls.Add(this.categoryComboBox);
            this.showGroupBox.Controls.Add(this.brandLabel);
            this.showGroupBox.Controls.Add(this.brandComboBox);
            this.showGroupBox.Controls.Add(this.categoryLabel);
            this.showGroupBox.Location = new System.Drawing.Point(29, 24);
            this.showGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showGroupBox.Name = "showGroupBox";
            this.showGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showGroupBox.Size = new System.Drawing.Size(452, 101);
            this.showGroupBox.TabIndex = 17;
            this.showGroupBox.TabStop = false;
            this.showGroupBox.Text = "Show";
            // 
            // bothButton
            // 
            this.bothButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bothButton.Location = new System.Drawing.Point(346, 20);
            this.bothButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bothButton.Name = "bothButton";
            this.bothButton.Size = new System.Drawing.Size(82, 59);
            this.bothButton.TabIndex = 12;
            this.bothButton.Text = "By Both";
            this.bothButton.UseVisualStyleBackColor = true;
            // 
            // showByBrandButton
            // 
            this.showByBrandButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showByBrandButton.Location = new System.Drawing.Point(228, 56);
            this.showByBrandButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showByBrandButton.Name = "showByBrandButton";
            this.showByBrandButton.Size = new System.Drawing.Size(92, 24);
            this.showByBrandButton.TabIndex = 11;
            this.showByBrandButton.Text = "By Brand";
            this.showByBrandButton.UseVisualStyleBackColor = true;
            // 
            // showByCategoryButton
            // 
            this.showByCategoryButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showByCategoryButton.Location = new System.Drawing.Point(70, 55);
            this.showByCategoryButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showByCategoryButton.Name = "showByCategoryButton";
            this.showByCategoryButton.Size = new System.Drawing.Size(92, 24);
            this.showByCategoryButton.TabIndex = 10;
            this.showByCategoryButton.Text = "By Category";
            this.showByCategoryButton.UseVisualStyleBackColor = true;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(70, 20);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(92, 21);
            this.categoryComboBox.TabIndex = 6;
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
            // brandComboBox
            // 
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.Location = new System.Drawing.Point(226, 20);
            this.brandComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(464, 443);
            this.backButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(56, 19);
            this.backButton.TabIndex = 16;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // productGridView
            // 
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView.Location = new System.Drawing.Point(29, 140);
            this.productGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productGridView.Name = "productGridView";
            this.productGridView.RowHeadersWidth = 51;
            this.productGridView.RowTemplate.Height = 24;
            this.productGridView.Size = new System.Drawing.Size(922, 288);
            this.productGridView.TabIndex = 13;
            // 
            // SaleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 487);
            this.Controls.Add(this.showGroupBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.productGridView);
            this.Name = "SaleDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaleDetails";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaleDetails_FormClosing);
            this.showGroupBox.ResumeLayout(false);
            this.showGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox showGroupBox;
        private System.Windows.Forms.Button bothButton;
        private System.Windows.Forms.Button showByBrandButton;
        private System.Windows.Forms.Button showByCategoryButton;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.ComboBox brandComboBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView productGridView;
    }
}