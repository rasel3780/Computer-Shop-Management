
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
            this.adminGroupBox = new System.Windows.Forms.GroupBox();
            this.amountGroupBox = new System.Windows.Forms.GroupBox();
            this.amonutButton = new System.Windows.Forms.Button();
            this.amountTotalRadioButton = new System.Windows.Forms.RadioButton();
            this.amountYearltRadioButton = new System.Windows.Forms.RadioButton();
            this.amountMonthlyRadioButton = new System.Windows.Forms.RadioButton();
            this.amountDailyRadioButton = new System.Windows.Forms.RadioButton();
            this.saleGroupBox = new System.Windows.Forms.GroupBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalSaleLabel = new System.Windows.Forms.Label();
            this.lastSaleLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.saleInfoButton = new System.Windows.Forms.Button();
            this.viewProdcutButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.showAllEmployeeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.totalSellRadioButton = new System.Windows.Forms.RadioButton();
            this.selectButton = new System.Windows.Forms.Button();
            this.yearlyRadioButton = new System.Windows.Forms.RadioButton();
            this.monthlyRadioButton = new System.Windows.Forms.RadioButton();
            this.dailyRadioButton = new System.Windows.Forms.RadioButton();
            this.logoutButton = new System.Windows.Forms.Button();
            this.adminGroupBox.SuspendLayout();
            this.amountGroupBox.SuspendLayout();
            this.saleGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(11, 30);
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
            this.addProductButton.Location = new System.Drawing.Point(11, 30);
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
            this.modifyButton.Location = new System.Drawing.Point(11, 75);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(129, 30);
            this.modifyButton.TabIndex = 4;
            this.modifyButton.Text = "Update Employee";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // adminGroupBox
            // 
            this.adminGroupBox.Controls.Add(this.amountGroupBox);
            this.adminGroupBox.Controls.Add(this.saleGroupBox);
            this.adminGroupBox.Controls.Add(this.groupBox3);
            this.adminGroupBox.Controls.Add(this.groupBox2);
            this.adminGroupBox.Controls.Add(this.label2);
            this.adminGroupBox.Controls.Add(this.groupBox1);
            this.adminGroupBox.Controls.Add(this.logoutButton);
            this.adminGroupBox.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminGroupBox.Location = new System.Drawing.Point(20, 12);
            this.adminGroupBox.Name = "adminGroupBox";
            this.adminGroupBox.Size = new System.Drawing.Size(694, 362);
            this.adminGroupBox.TabIndex = 6;
            this.adminGroupBox.TabStop = false;
            this.adminGroupBox.Text = "Admin";
            // 
            // amountGroupBox
            // 
            this.amountGroupBox.Controls.Add(this.amonutButton);
            this.amountGroupBox.Controls.Add(this.amountTotalRadioButton);
            this.amountGroupBox.Controls.Add(this.amountYearltRadioButton);
            this.amountGroupBox.Controls.Add(this.amountMonthlyRadioButton);
            this.amountGroupBox.Controls.Add(this.amountDailyRadioButton);
            this.amountGroupBox.Location = new System.Drawing.Point(528, 22);
            this.amountGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.amountGroupBox.Name = "amountGroupBox";
            this.amountGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.amountGroupBox.Size = new System.Drawing.Size(127, 172);
            this.amountGroupBox.TabIndex = 21;
            this.amountGroupBox.TabStop = false;
            this.amountGroupBox.Text = "Amount sell";
            // 
            // amonutButton
            // 
            this.amonutButton.Location = new System.Drawing.Point(36, 124);
            this.amonutButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.amonutButton.Name = "amonutButton";
            this.amonutButton.Size = new System.Drawing.Size(74, 25);
            this.amonutButton.TabIndex = 4;
            this.amonutButton.Text = "Select";
            this.amonutButton.UseVisualStyleBackColor = true;
            this.amonutButton.Click += new System.EventHandler(this.amonutButton_Click);
            // 
            // amountTotalRadioButton
            // 
            this.amountTotalRadioButton.AutoSize = true;
            this.amountTotalRadioButton.Location = new System.Drawing.Point(14, 100);
            this.amountTotalRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.amountTotalRadioButton.Name = "amountTotalRadioButton";
            this.amountTotalRadioButton.Size = new System.Drawing.Size(55, 20);
            this.amountTotalRadioButton.TabIndex = 3;
            this.amountTotalRadioButton.TabStop = true;
            this.amountTotalRadioButton.Text = "Total";
            this.amountTotalRadioButton.UseVisualStyleBackColor = true;
            // 
            // amountYearltRadioButton
            // 
            this.amountYearltRadioButton.AutoSize = true;
            this.amountYearltRadioButton.Location = new System.Drawing.Point(14, 75);
            this.amountYearltRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.amountYearltRadioButton.Name = "amountYearltRadioButton";
            this.amountYearltRadioButton.Size = new System.Drawing.Size(61, 20);
            this.amountYearltRadioButton.TabIndex = 2;
            this.amountYearltRadioButton.TabStop = true;
            this.amountYearltRadioButton.Text = "Yearly";
            this.amountYearltRadioButton.UseVisualStyleBackColor = true;
            // 
            // amountMonthlyRadioButton
            // 
            this.amountMonthlyRadioButton.AutoSize = true;
            this.amountMonthlyRadioButton.Location = new System.Drawing.Point(14, 50);
            this.amountMonthlyRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.amountMonthlyRadioButton.Name = "amountMonthlyRadioButton";
            this.amountMonthlyRadioButton.Size = new System.Drawing.Size(74, 20);
            this.amountMonthlyRadioButton.TabIndex = 1;
            this.amountMonthlyRadioButton.TabStop = true;
            this.amountMonthlyRadioButton.Text = "Monthly";
            this.amountMonthlyRadioButton.UseVisualStyleBackColor = true;
            // 
            // amountDailyRadioButton
            // 
            this.amountDailyRadioButton.AutoSize = true;
            this.amountDailyRadioButton.Location = new System.Drawing.Point(14, 24);
            this.amountDailyRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.amountDailyRadioButton.Name = "amountDailyRadioButton";
            this.amountDailyRadioButton.Size = new System.Drawing.Size(54, 20);
            this.amountDailyRadioButton.TabIndex = 0;
            this.amountDailyRadioButton.TabStop = true;
            this.amountDailyRadioButton.Text = "Daily";
            this.amountDailyRadioButton.UseVisualStyleBackColor = true;
            // 
            // saleGroupBox
            // 
            this.saleGroupBox.Controls.Add(this.amountLabel);
            this.saleGroupBox.Controls.Add(this.label6);
            this.saleGroupBox.Controls.Add(this.totalSaleLabel);
            this.saleGroupBox.Controls.Add(this.lastSaleLabel);
            this.saleGroupBox.Controls.Add(this.label3);
            this.saleGroupBox.Controls.Add(this.label4);
            this.saleGroupBox.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleGroupBox.Location = new System.Drawing.Point(6, 221);
            this.saleGroupBox.Name = "saleGroupBox";
            this.saleGroupBox.Size = new System.Drawing.Size(553, 132);
            this.saleGroupBox.TabIndex = 20;
            this.saleGroupBox.TabStop = false;
            this.saleGroupBox.Text = "Sale Details";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.Location = new System.Drawing.Point(172, 19);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(161, 19);
            this.amountLabel.TabIndex = 16;
            this.amountLabel.Text = "Total Amount Sold";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(379, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // totalSaleLabel
            // 
            this.totalSaleLabel.AutoSize = true;
            this.totalSaleLabel.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSaleLabel.Location = new System.Drawing.Point(13, 19);
            this.totalSaleLabel.Name = "totalSaleLabel";
            this.totalSaleLabel.Size = new System.Drawing.Size(88, 19);
            this.totalSaleLabel.TabIndex = 9;
            this.totalSaleLabel.Text = "Total Sale";
            // 
            // lastSaleLabel
            // 
            this.lastSaleLabel.AutoSize = true;
            this.lastSaleLabel.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastSaleLabel.Location = new System.Drawing.Point(395, 19);
            this.lastSaleLabel.Name = "lastSaleLabel";
            this.lastSaleLabel.Size = new System.Drawing.Size(114, 19);
            this.lastSaleLabel.TabIndex = 18;
            this.lastSaleLabel.Text = "Last Sell Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(225, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.saleInfoButton);
            this.groupBox3.Controls.Add(this.addProductButton);
            this.groupBox3.Controls.Add(this.viewProdcutButton);
            this.groupBox3.Location = new System.Drawing.Point(6, 21);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(152, 173);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Product";
            // 
            // saleInfoButton
            // 
            this.saleInfoButton.Font = new System.Drawing.Font("Maiandra GD", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleInfoButton.Location = new System.Drawing.Point(11, 124);
            this.saleInfoButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saleInfoButton.Name = "saleInfoButton";
            this.saleInfoButton.Size = new System.Drawing.Size(129, 30);
            this.saleInfoButton.TabIndex = 12;
            this.saleInfoButton.Text = "Sale Details";
            this.saleInfoButton.UseVisualStyleBackColor = true;
            this.saleInfoButton.Click += new System.EventHandler(this.saleInfoButton_Click);
            // 
            // viewProdcutButton
            // 
            this.viewProdcutButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewProdcutButton.Location = new System.Drawing.Point(11, 78);
            this.viewProdcutButton.Name = "viewProdcutButton";
            this.viewProdcutButton.Size = new System.Drawing.Size(129, 30);
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
            this.groupBox2.Location = new System.Drawing.Point(182, 21);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(152, 173);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employee ";
            // 
            // showAllEmployeeButton
            // 
            this.showAllEmployeeButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllEmployeeButton.Location = new System.Drawing.Point(10, 118);
            this.showAllEmployeeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showAllEmployeeButton.Name = "showAllEmployeeButton";
            this.showAllEmployeeButton.Size = new System.Drawing.Size(129, 34);
            this.showAllEmployeeButton.TabIndex = 13;
            this.showAllEmployeeButton.Text = "Show All Employee";
            this.showAllEmployeeButton.UseVisualStyleBackColor = true;
            this.showAllEmployeeButton.Click += new System.EventHandler(this.showAllEmployeeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.totalSellRadioButton);
            this.groupBox1.Controls.Add(this.selectButton);
            this.groupBox1.Controls.Add(this.yearlyRadioButton);
            this.groupBox1.Controls.Add(this.monthlyRadioButton);
            this.groupBox1.Controls.Add(this.dailyRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(356, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 172);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total Sale";
            // 
            // totalSellRadioButton
            // 
            this.totalSellRadioButton.AutoSize = true;
            this.totalSellRadioButton.Location = new System.Drawing.Point(45, 103);
            this.totalSellRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.totalSellRadioButton.Name = "totalSellRadioButton";
            this.totalSellRadioButton.Size = new System.Drawing.Size(55, 20);
            this.totalSellRadioButton.TabIndex = 13;
            this.totalSellRadioButton.TabStop = true;
            this.totalSellRadioButton.Text = "Total";
            this.totalSellRadioButton.UseVisualStyleBackColor = true;
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(43, 134);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(71, 25);
            this.selectButton.TabIndex = 12;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // yearlyRadioButton
            // 
            this.yearlyRadioButton.AutoSize = true;
            this.yearlyRadioButton.Location = new System.Drawing.Point(45, 79);
            this.yearlyRadioButton.Name = "yearlyRadioButton";
            this.yearlyRadioButton.Size = new System.Drawing.Size(61, 20);
            this.yearlyRadioButton.TabIndex = 2;
            this.yearlyRadioButton.TabStop = true;
            this.yearlyRadioButton.Text = "Yearly";
            this.yearlyRadioButton.UseVisualStyleBackColor = true;
            // 
            // monthlyRadioButton
            // 
            this.monthlyRadioButton.AutoSize = true;
            this.monthlyRadioButton.Location = new System.Drawing.Point(45, 56);
            this.monthlyRadioButton.Name = "monthlyRadioButton";
            this.monthlyRadioButton.Size = new System.Drawing.Size(74, 20);
            this.monthlyRadioButton.TabIndex = 1;
            this.monthlyRadioButton.TabStop = true;
            this.monthlyRadioButton.Text = "Monthly";
            this.monthlyRadioButton.UseVisualStyleBackColor = true;
            // 
            // dailyRadioButton
            // 
            this.dailyRadioButton.AutoSize = true;
            this.dailyRadioButton.Location = new System.Drawing.Point(45, 30);
            this.dailyRadioButton.Name = "dailyRadioButton";
            this.dailyRadioButton.Size = new System.Drawing.Size(54, 20);
            this.dailyRadioButton.TabIndex = 0;
            this.dailyRadioButton.TabStop = true;
            this.dailyRadioButton.Text = "Daily";
            this.dailyRadioButton.UseVisualStyleBackColor = true;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.SystemColors.Control;
            this.logoutButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(598, 323);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(84, 29);
            this.logoutButton.TabIndex = 7;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 377);
            this.Controls.Add(this.adminGroupBox);
            this.Name = "AdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminHome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminHome_FormClosing);
            this.adminGroupBox.ResumeLayout(false);
            this.adminGroupBox.PerformLayout();
            this.amountGroupBox.ResumeLayout(false);
            this.amountGroupBox.PerformLayout();
            this.saleGroupBox.ResumeLayout(false);
            this.saleGroupBox.PerformLayout();
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
        private System.Windows.Forms.RadioButton totalSellRadioButton;
        private System.Windows.Forms.GroupBox saleGroupBox;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lastSaleLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox amountGroupBox;
        private System.Windows.Forms.Button amonutButton;
        private System.Windows.Forms.RadioButton amountTotalRadioButton;
        private System.Windows.Forms.RadioButton amountYearltRadioButton;
        private System.Windows.Forms.RadioButton amountMonthlyRadioButton;
        private System.Windows.Forms.RadioButton amountDailyRadioButton;
    }
}