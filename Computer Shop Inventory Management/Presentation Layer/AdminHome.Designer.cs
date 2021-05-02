
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.saleInfoButton = new System.Windows.Forms.Button();
            this.viewProdcutButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.showAllEmployeeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalSaleLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.yearlyRadioButton = new System.Windows.Forms.RadioButton();
            this.monthlyRadioButton = new System.Windows.Forms.RadioButton();
            this.dailyRadioButton = new System.Windows.Forms.RadioButton();
            this.logoutButton = new System.Windows.Forms.Button();
            this.adminGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 40);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Employee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductButton.Location = new System.Drawing.Point(15, 44);
            this.addProductButton.Margin = new System.Windows.Forms.Padding(4);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(172, 37);
            this.addProductButton.TabIndex = 2;
            this.addProductButton.Text = "Add Product";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyButton.Location = new System.Drawing.Point(12, 95);
            this.modifyButton.Margin = new System.Windows.Forms.Padding(4);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(172, 37);
            this.modifyButton.TabIndex = 4;
            this.modifyButton.Text = "Update Employee";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // sellButton
            // 
            this.sellButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellButton.Location = new System.Drawing.Point(236, 23);
            this.sellButton.Margin = new System.Windows.Forms.Padding(4);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(193, 37);
            this.sellButton.TabIndex = 5;
            this.sellButton.Text = "Total Sale";
            this.sellButton.UseVisualStyleBackColor = true;
            // 
            // adminGroupBox
            // 
            this.adminGroupBox.Controls.Add(this.groupBox3);
            this.adminGroupBox.Controls.Add(this.groupBox2);
            this.adminGroupBox.Controls.Add(this.label3);
            this.adminGroupBox.Controls.Add(this.label2);
            this.adminGroupBox.Controls.Add(this.totalSaleLabel);
            this.adminGroupBox.Controls.Add(this.groupBox1);
            this.adminGroupBox.Controls.Add(this.logoutButton);
            this.adminGroupBox.Controls.Add(this.sellButton);
            this.adminGroupBox.Location = new System.Drawing.Point(27, 15);
            this.adminGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.adminGroupBox.Name = "adminGroupBox";
            this.adminGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.adminGroupBox.Size = new System.Drawing.Size(1024, 524);
            this.adminGroupBox.TabIndex = 6;
            this.adminGroupBox.TabStop = false;
            this.adminGroupBox.Text = "Admin";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.saleInfoButton);
            this.groupBox3.Controls.Add(this.addProductButton);
            this.groupBox3.Controls.Add(this.viewProdcutButton);
            this.groupBox3.Location = new System.Drawing.Point(7, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(203, 213);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Product";
            // 
            // saleInfoButton
            // 
            this.saleInfoButton.Font = new System.Drawing.Font("Maiandra GD", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleInfoButton.Location = new System.Drawing.Point(15, 160);
            this.saleInfoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saleInfoButton.Name = "saleInfoButton";
            this.saleInfoButton.Size = new System.Drawing.Size(172, 37);
            this.saleInfoButton.TabIndex = 12;
            this.saleInfoButton.Text = "Sale Details";
            this.saleInfoButton.UseVisualStyleBackColor = true;
            this.saleInfoButton.Click += new System.EventHandler(this.saleInfoButton_Click);
            // 
            // viewProdcutButton
            // 
            this.viewProdcutButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewProdcutButton.Location = new System.Drawing.Point(15, 103);
            this.viewProdcutButton.Margin = new System.Windows.Forms.Padding(4);
            this.viewProdcutButton.Name = "viewProdcutButton";
            this.viewProdcutButton.Size = new System.Drawing.Size(172, 37);
            this.viewProdcutButton.TabIndex = 2;
            this.viewProdcutButton.Text = "View Product";
            this.viewProdcutButton.UseVisualStyleBackColor = true;
            this.viewProdcutButton.Click += new System.EventHandler(this.viewProdcutButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.showAllEmployeeButton);
            this.groupBox2.Controls.Add(this.modifyButton);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(8, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 196);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employee ";
            // 
            // showAllEmployeeButton
            // 
            this.showAllEmployeeButton.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllEmployeeButton.Location = new System.Drawing.Point(11, 148);
            this.showAllEmployeeButton.Name = "showAllEmployeeButton";
            this.showAllEmployeeButton.Size = new System.Drawing.Size(172, 42);
            this.showAllEmployeeButton.TabIndex = 13;
            this.showAllEmployeeButton.Text = "Show All Employee";
            this.showAllEmployeeButton.UseVisualStyleBackColor = true;
            this.showAllEmployeeButton.Click += new System.EventHandler(this.showAllEmployeeButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(579, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 10;
            // 
            // totalSaleLabel
            // 
            this.totalSaleLabel.AutoSize = true;
            this.totalSaleLabel.Location = new System.Drawing.Point(480, 82);
            this.totalSaleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalSaleLabel.Name = "totalSaleLabel";
            this.totalSaleLabel.Size = new System.Drawing.Size(72, 17);
            this.totalSaleLabel.TabIndex = 9;
            this.totalSaleLabel.Text = "Total Sale";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectButton);
            this.groupBox1.Controls.Add(this.yearlyRadioButton);
            this.groupBox1.Controls.Add(this.monthlyRadioButton);
            this.groupBox1.Controls.Add(this.dailyRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(236, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(193, 198);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(48, 155);
            this.selectButton.Margin = new System.Windows.Forms.Padding(4);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(95, 27);
            this.selectButton.TabIndex = 12;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // yearlyRadioButton
            // 
            this.yearlyRadioButton.AutoSize = true;
            this.yearlyRadioButton.Location = new System.Drawing.Point(60, 105);
            this.yearlyRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.yearlyRadioButton.Name = "yearlyRadioButton";
            this.yearlyRadioButton.Size = new System.Drawing.Size(69, 21);
            this.yearlyRadioButton.TabIndex = 2;
            this.yearlyRadioButton.TabStop = true;
            this.yearlyRadioButton.Text = "Yearly";
            this.yearlyRadioButton.UseVisualStyleBackColor = true;
            // 
            // monthlyRadioButton
            // 
            this.monthlyRadioButton.AutoSize = true;
            this.monthlyRadioButton.Location = new System.Drawing.Point(60, 76);
            this.monthlyRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.monthlyRadioButton.Name = "monthlyRadioButton";
            this.monthlyRadioButton.Size = new System.Drawing.Size(78, 21);
            this.monthlyRadioButton.TabIndex = 1;
            this.monthlyRadioButton.TabStop = true;
            this.monthlyRadioButton.Text = "Monthly";
            this.monthlyRadioButton.UseVisualStyleBackColor = true;
            // 
            // dailyRadioButton
            // 
            this.dailyRadioButton.AutoSize = true;
            this.dailyRadioButton.Location = new System.Drawing.Point(60, 44);
            this.dailyRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.dailyRadioButton.Name = "dailyRadioButton";
            this.dailyRadioButton.Size = new System.Drawing.Size(60, 21);
            this.dailyRadioButton.TabIndex = 0;
            this.dailyRadioButton.TabStop = true;
            this.dailyRadioButton.Text = "Daily";
            this.dailyRadioButton.UseVisualStyleBackColor = true;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.SystemColors.Control;
            this.logoutButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(895, 480);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(112, 36);
            this.logoutButton.TabIndex = 7;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 554);
            this.Controls.Add(this.adminGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminHome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminHome_FormClosing);
            this.adminGroupBox.ResumeLayout(false);
            this.adminGroupBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button showAllEmployeeButton;
    }
}