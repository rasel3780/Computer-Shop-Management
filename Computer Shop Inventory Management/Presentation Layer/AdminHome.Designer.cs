
namespace Computer_Shop_Inventory_Management
{
    partial class AdminHome
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
            this.button1 = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.sellButton = new System.Windows.Forms.Button();
            this.adminGroupBox = new System.Windows.Forms.GroupBox();
            this.saleInfoButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalSaleLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.yearlyRadioButton = new System.Windows.Forms.RadioButton();
            this.monthlyRadioButton = new System.Windows.Forms.RadioButton();
            this.dailyRadioButton = new System.Windows.Forms.RadioButton();
            this.logoutButton = new System.Windows.Forms.Button();
            this.viewProdcutButton = new System.Windows.Forms.Button();
            this.adminGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Employee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductButton.Location = new System.Drawing.Point(6, 116);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(129, 30);
            this.addProductButton.TabIndex = 2;
            this.addProductButton.Text = "Add Product";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyButton.Location = new System.Drawing.Point(6, 67);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(129, 30);
            this.modifyButton.TabIndex = 4;
            this.modifyButton.Text = "Update Employee";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // sellButton
            // 
            this.sellButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellButton.Location = new System.Drawing.Point(177, 19);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(145, 30);
            this.sellButton.TabIndex = 5;
            this.sellButton.Text = "Total Sale";
            this.sellButton.UseVisualStyleBackColor = true;
            // 
            // adminGroupBox
            // 
            this.adminGroupBox.Controls.Add(this.saleInfoButton);
            this.adminGroupBox.Controls.Add(this.label3);
            this.adminGroupBox.Controls.Add(this.label2);
            this.adminGroupBox.Controls.Add(this.totalSaleLabel);
            this.adminGroupBox.Controls.Add(this.groupBox1);
            this.adminGroupBox.Controls.Add(this.logoutButton);
            this.adminGroupBox.Controls.Add(this.button1);
            this.adminGroupBox.Controls.Add(this.sellButton);
            this.adminGroupBox.Controls.Add(this.viewProdcutButton);
            this.adminGroupBox.Controls.Add(this.addProductButton);
            this.adminGroupBox.Controls.Add(this.modifyButton);
            this.adminGroupBox.Location = new System.Drawing.Point(20, 12);
            this.adminGroupBox.Name = "adminGroupBox";
            this.adminGroupBox.Size = new System.Drawing.Size(768, 426);
            this.adminGroupBox.TabIndex = 6;
            this.adminGroupBox.TabStop = false;
            this.adminGroupBox.Text = "Admin";
            // 
            // saleInfoButton
            // 
            this.saleInfoButton.Font = new System.Drawing.Font("Maiandra GD", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleInfoButton.Location = new System.Drawing.Point(6, 210);
            this.saleInfoButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saleInfoButton.Name = "saleInfoButton";
            this.saleInfoButton.Size = new System.Drawing.Size(129, 30);
            this.saleInfoButton.TabIndex = 12;
            this.saleInfoButton.Text = "Sale Details";
            this.saleInfoButton.UseVisualStyleBackColor = true;
            this.saleInfoButton.Click += new System.EventHandler(this.saleInfoButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 10;
            // 
            // totalSaleLabel
            // 
            this.totalSaleLabel.AutoSize = true;
            this.totalSaleLabel.Location = new System.Drawing.Point(360, 67);
            this.totalSaleLabel.Name = "totalSaleLabel";
            this.totalSaleLabel.Size = new System.Drawing.Size(55, 13);
            this.totalSaleLabel.TabIndex = 9;
            this.totalSaleLabel.Text = "Total Sale";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectButton);
            this.groupBox1.Controls.Add(this.yearlyRadioButton);
            this.groupBox1.Controls.Add(this.monthlyRadioButton);
            this.groupBox1.Controls.Add(this.dailyRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(177, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 161);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(36, 126);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(71, 22);
            this.selectButton.TabIndex = 12;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            // 
            // yearlyRadioButton
            // 
            this.yearlyRadioButton.AutoSize = true;
            this.yearlyRadioButton.Location = new System.Drawing.Point(45, 85);
            this.yearlyRadioButton.Name = "yearlyRadioButton";
            this.yearlyRadioButton.Size = new System.Drawing.Size(54, 17);
            this.yearlyRadioButton.TabIndex = 2;
            this.yearlyRadioButton.TabStop = true;
            this.yearlyRadioButton.Text = "Yearly";
            this.yearlyRadioButton.UseVisualStyleBackColor = true;
            // 
            // monthlyRadioButton
            // 
            this.monthlyRadioButton.AutoSize = true;
            this.monthlyRadioButton.Location = new System.Drawing.Point(45, 62);
            this.monthlyRadioButton.Name = "monthlyRadioButton";
            this.monthlyRadioButton.Size = new System.Drawing.Size(62, 17);
            this.monthlyRadioButton.TabIndex = 1;
            this.monthlyRadioButton.TabStop = true;
            this.monthlyRadioButton.Text = "Monthly";
            this.monthlyRadioButton.UseVisualStyleBackColor = true;
            // 
            // dailyRadioButton
            // 
            this.dailyRadioButton.AutoSize = true;
            this.dailyRadioButton.Location = new System.Drawing.Point(45, 36);
            this.dailyRadioButton.Name = "dailyRadioButton";
            this.dailyRadioButton.Size = new System.Drawing.Size(48, 17);
            this.dailyRadioButton.TabIndex = 0;
            this.dailyRadioButton.TabStop = true;
            this.dailyRadioButton.Text = "Daily";
            this.dailyRadioButton.UseVisualStyleBackColor = true;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.SystemColors.Control;
            this.logoutButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(6, 391);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(84, 29);
            this.logoutButton.TabIndex = 7;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // viewProdcutButton
            // 
            this.viewProdcutButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewProdcutButton.Location = new System.Drawing.Point(6, 163);
            this.viewProdcutButton.Name = "viewProdcutButton";
            this.viewProdcutButton.Size = new System.Drawing.Size(129, 30);
            this.viewProdcutButton.TabIndex = 2;
            this.viewProdcutButton.Text = "View Product";
            this.viewProdcutButton.UseVisualStyleBackColor = true;
            this.viewProdcutButton.Click += new System.EventHandler(this.viewProdcutButton_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.adminGroupBox);
            this.Name = "AdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminHome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminHome_FormClosing);
            this.adminGroupBox.ResumeLayout(false);
            this.adminGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.GroupBox adminGroupBox;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button viewProdcutButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalSaleLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.RadioButton yearlyRadioButton;
        private System.Windows.Forms.RadioButton monthlyRadioButton;
        private System.Windows.Forms.RadioButton dailyRadioButton;
        private System.Windows.Forms.Button saleInfoButton;
    }
}