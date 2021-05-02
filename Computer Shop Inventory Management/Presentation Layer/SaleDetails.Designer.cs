
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
            this.showAllButton = new System.Windows.Forms.Button();
            this.bothButton = new System.Windows.Forms.Button();
            this.showByBrandButton = new System.Windows.Forms.Button();
            this.showByCategoryButton = new System.Windows.Forms.Button();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.brandLabel = new System.Windows.Forms.Label();
            this.brandComboBox = new System.Windows.Forms.ComboBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.saleGridView = new System.Windows.Forms.DataGridView();
            this.sortGroupBox = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.showGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleGridView)).BeginInit();
            this.sortGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // showGroupBox
            // 
            this.showGroupBox.Controls.Add(this.showAllButton);
            this.showGroupBox.Controls.Add(this.bothButton);
            this.showGroupBox.Controls.Add(this.showByBrandButton);
            this.showGroupBox.Controls.Add(this.showByCategoryButton);
            this.showGroupBox.Controls.Add(this.categoryComboBox);
            this.showGroupBox.Controls.Add(this.brandLabel);
            this.showGroupBox.Controls.Add(this.brandComboBox);
            this.showGroupBox.Controls.Add(this.categoryLabel);
            this.showGroupBox.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showGroupBox.Location = new System.Drawing.Point(39, 14);
            this.showGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showGroupBox.Name = "showGroupBox";
            this.showGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showGroupBox.Size = new System.Drawing.Size(733, 135);
            this.showGroupBox.TabIndex = 17;
            this.showGroupBox.TabStop = false;
            this.showGroupBox.Text = "Show";
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(588, 34);
            this.showAllButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(123, 73);
            this.showAllButton.TabIndex = 13;
            this.showAllButton.Text = "Show All";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // bothButton
            // 
            this.bothButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bothButton.Location = new System.Drawing.Point(447, 34);
            this.bothButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bothButton.Name = "bothButton";
            this.bothButton.Size = new System.Drawing.Size(123, 73);
            this.bothButton.TabIndex = 12;
            this.bothButton.Text = "By Both";
            this.bothButton.UseVisualStyleBackColor = true;
            this.bothButton.Click += new System.EventHandler(this.bothButton_Click);
            // 
            // showByBrandButton
            // 
            this.showByBrandButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showByBrandButton.Location = new System.Drawing.Point(304, 79);
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
            this.showByCategoryButton.Location = new System.Drawing.Point(93, 78);
            this.showByCategoryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showByCategoryButton.Name = "showByCategoryButton";
            this.showByCategoryButton.Size = new System.Drawing.Size(123, 30);
            this.showByCategoryButton.TabIndex = 10;
            this.showByCategoryButton.Text = "By Category";
            this.showByCategoryButton.UseVisualStyleBackColor = true;
            this.showByCategoryButton.Click += new System.EventHandler(this.showByCategoryButton_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(93, 34);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(121, 27);
            this.categoryComboBox.TabIndex = 6;
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandLabel.Location = new System.Drawing.Point(240, 39);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(53, 20);
            this.brandLabel.TabIndex = 9;
            this.brandLabel.Text = "Brand";
            // 
            // brandComboBox
            // 
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.Location = new System.Drawing.Point(301, 34);
            this.brandComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brandComboBox.Name = "brandComboBox";
            this.brandComboBox.Size = new System.Drawing.Size(121, 27);
            this.brandComboBox.TabIndex = 7;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(8, 34);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(76, 20);
            this.categoryLabel.TabIndex = 8;
            this.categoryLabel.Text = "Category";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(39, 532);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 33);
            this.backButton.TabIndex = 16;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // saleGridView
            // 
            this.saleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.saleGridView.Location = new System.Drawing.Point(39, 154);
            this.saleGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saleGridView.Name = "saleGridView";
            this.saleGridView.RowHeadersWidth = 51;
            this.saleGridView.RowTemplate.Height = 24;
            this.saleGridView.Size = new System.Drawing.Size(1229, 373);
            this.saleGridView.TabIndex = 13;
            // 
            // sortGroupBox
            // 
            this.sortGroupBox.Controls.Add(this.button2);
            this.sortGroupBox.Controls.Add(this.button1);
            this.sortGroupBox.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortGroupBox.Location = new System.Drawing.Point(796, 14);
            this.sortGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sortGroupBox.Name = "sortGroupBox";
            this.sortGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sortGroupBox.Size = new System.Drawing.Size(255, 134);
            this.sortGroupBox.TabIndex = 18;
            this.sortGroupBox.TabStop = false;
            this.sortGroupBox.Text = "Sort by Time";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(39, 76);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "Descending";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(39, 36);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ascending";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SaleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 574);
            this.Controls.Add(this.sortGroupBox);
            this.Controls.Add(this.showGroupBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.saleGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SaleDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaleDetails";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaleDetails_FormClosing);
            this.showGroupBox.ResumeLayout(false);
            this.showGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saleGridView)).EndInit();
            this.sortGroupBox.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView saleGridView;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.GroupBox sortGroupBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}