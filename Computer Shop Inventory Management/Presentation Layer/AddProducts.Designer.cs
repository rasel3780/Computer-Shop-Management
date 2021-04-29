
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
            this.label1 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.addProductGroupBox1 = new System.Windows.Forms.GroupBox();
            this.featureGroupBox = new System.Windows.Forms.GroupBox();
            this.screenSizeComboBox = new System.Windows.Forms.ComboBox();
            this.refreshRateComboBox = new System.Windows.Forms.ComboBox();
            this.memoryTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.capacityTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.busSpeedComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureAddButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addProductButton = new System.Windows.Forms.Button();
            this.brandComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addProductGroupBox1.SuspendLayout();
            this.featureGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(699, 66);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(221, 22);
            this.priceTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(571, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Price";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(177, 67);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(221, 24);
            this.categoryComboBox.TabIndex = 2;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // addProductGroupBox1
            // 
            this.addProductGroupBox1.Controls.Add(this.featureGroupBox);
            this.addProductGroupBox1.Controls.Add(this.pictureAddButton);
            this.addProductGroupBox1.Controls.Add(this.pictureBox1);
            this.addProductGroupBox1.Controls.Add(this.descriptionTextBox);
            this.addProductGroupBox1.Controls.Add(this.label4);
            this.addProductGroupBox1.Controls.Add(this.addProductButton);
            this.addProductGroupBox1.Controls.Add(this.brandComboBox);
            this.addProductGroupBox1.Controls.Add(this.label3);
            this.addProductGroupBox1.Controls.Add(this.quantityTextBox);
            this.addProductGroupBox1.Controls.Add(this.label1);
            this.addProductGroupBox1.Controls.Add(this.label5);
            this.addProductGroupBox1.Controls.Add(this.priceTextBox);
            this.addProductGroupBox1.Controls.Add(this.label2);
            this.addProductGroupBox1.Controls.Add(this.categoryComboBox);
            this.addProductGroupBox1.Location = new System.Drawing.Point(56, 12);
            this.addProductGroupBox1.Name = "addProductGroupBox1";
            this.addProductGroupBox1.Size = new System.Drawing.Size(1072, 676);
            this.addProductGroupBox1.TabIndex = 3;
            this.addProductGroupBox1.TabStop = false;
            this.addProductGroupBox1.Text = "Add Products";
            this.addProductGroupBox1.Enter += new System.EventHandler(this.addProductGroupBox1_Enter);
            // 
            // featureGroupBox
            // 
            this.featureGroupBox.Controls.Add(this.screenSizeComboBox);
            this.featureGroupBox.Controls.Add(this.refreshRateComboBox);
            this.featureGroupBox.Controls.Add(this.memoryTypeComboBox);
            this.featureGroupBox.Controls.Add(this.label9);
            this.featureGroupBox.Controls.Add(this.label10);
            this.featureGroupBox.Controls.Add(this.capacityTextBox);
            this.featureGroupBox.Controls.Add(this.label6);
            this.featureGroupBox.Controls.Add(this.busSpeedComboBox);
            this.featureGroupBox.Controls.Add(this.label7);
            this.featureGroupBox.Controls.Add(this.label8);
            this.featureGroupBox.Location = new System.Drawing.Point(15, 167);
            this.featureGroupBox.Name = "featureGroupBox";
            this.featureGroupBox.Size = new System.Drawing.Size(423, 344);
            this.featureGroupBox.TabIndex = 4;
            this.featureGroupBox.TabStop = false;
            this.featureGroupBox.Text = "Features";
            this.featureGroupBox.Visible = false;
            // 
            // screenSizeComboBox
            // 
            this.screenSizeComboBox.FormattingEnabled = true;
            this.screenSizeComboBox.Location = new System.Drawing.Point(162, 167);
            this.screenSizeComboBox.Name = "screenSizeComboBox";
            this.screenSizeComboBox.Size = new System.Drawing.Size(221, 24);
            this.screenSizeComboBox.TabIndex = 2;
            this.screenSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // refreshRateComboBox
            // 
            this.refreshRateComboBox.FormattingEnabled = true;
            this.refreshRateComboBox.Location = new System.Drawing.Point(162, 217);
            this.refreshRateComboBox.Name = "refreshRateComboBox";
            this.refreshRateComboBox.Size = new System.Drawing.Size(221, 24);
            this.refreshRateComboBox.TabIndex = 2;
            this.refreshRateComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // memoryTypeComboBox
            // 
            this.memoryTypeComboBox.FormattingEnabled = true;
            this.memoryTypeComboBox.Location = new System.Drawing.Point(162, 69);
            this.memoryTypeComboBox.Name = "memoryTypeComboBox";
            this.memoryTypeComboBox.Size = new System.Drawing.Size(221, 24);
            this.memoryTypeComboBox.TabIndex = 2;
            this.memoryTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Screen Size";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Refresh Rate";
            // 
            // capacityTextBox
            // 
            this.capacityTextBox.Location = new System.Drawing.Point(162, 24);
            this.capacityTextBox.Name = "capacityTextBox";
            this.capacityTextBox.Size = new System.Drawing.Size(221, 22);
            this.capacityTextBox.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Capacity";
            // 
            // busSpeedComboBox
            // 
            this.busSpeedComboBox.FormattingEnabled = true;
            this.busSpeedComboBox.Location = new System.Drawing.Point(162, 118);
            this.busSpeedComboBox.Name = "busSpeedComboBox";
            this.busSpeedComboBox.Size = new System.Drawing.Size(221, 24);
            this.busSpeedComboBox.TabIndex = 2;
            this.busSpeedComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Memory Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Bus Speed";
            // 
            // pictureAddButton
            // 
            this.pictureAddButton.Location = new System.Drawing.Point(745, 381);
            this.pictureAddButton.Name = "pictureAddButton";
            this.pictureAddButton.Size = new System.Drawing.Size(146, 30);
            this.pictureAddButton.TabIndex = 3;
            this.pictureAddButton.Text = "Add Picture";
            this.pictureAddButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(699, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 221);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(699, 472);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(269, 118);
            this.descriptionTextBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(696, 607);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Description";
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(203, 517);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(146, 30);
            this.addProductButton.TabIndex = 3;
            this.addProductButton.Text = "Add Product";
            this.addProductButton.UseVisualStyleBackColor = true;
            // 
            // brandComboBox
            // 
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.Location = new System.Drawing.Point(177, 113);
            this.brandComboBox.Name = "brandComboBox";
            this.brandComboBox.Size = new System.Drawing.Size(221, 24);
            this.brandComboBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Brand";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(699, 111);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(221, 22);
            this.quantityTextBox.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(571, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // AddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 700);
            this.Controls.Add(this.addProductGroupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddProducts";
            this.Text = "Product";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddProducts_FormClosing);
            this.Load += new System.EventHandler(this.AddProducts_Load);
            this.addProductGroupBox1.ResumeLayout(false);
            this.addProductGroupBox1.PerformLayout();
            this.featureGroupBox.ResumeLayout(false);
            this.featureGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.GroupBox addProductGroupBox1;
        private System.Windows.Forms.ComboBox brandComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox featureGroupBox;
        private System.Windows.Forms.ComboBox screenSizeComboBox;
        private System.Windows.Forms.ComboBox refreshRateComboBox;
        private System.Windows.Forms.ComboBox memoryTypeComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox capacityTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox busSpeedComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button pictureAddButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label label5;
    }
}