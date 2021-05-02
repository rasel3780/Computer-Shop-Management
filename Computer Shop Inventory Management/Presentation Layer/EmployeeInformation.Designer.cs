
namespace Computer_Shop_Inventory_Management.Presentation_Layer
{
    partial class EmployeeInformation
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
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.selectButton = new System.Windows.Forms.Button();
            this.highButton = new System.Windows.Forms.Button();
            this.lowButton = new System.Windows.Forms.Button();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.userNameButton = new System.Windows.Forms.Button();
            this.showAllButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.adminRadioButton = new System.Windows.Forms.RadioButton();
            this.managerRadioButton = new System.Windows.Forms.RadioButton();
            this.salesmanRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Location = new System.Drawing.Point(110, 228);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.RowHeadersWidth = 51;
            this.employeeDataGridView.RowTemplate.Height = 24;
            this.employeeDataGridView.Size = new System.Drawing.Size(1022, 416);
            this.employeeDataGridView.TabIndex = 0;
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(0, 133);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(91, 26);
            this.selectButton.TabIndex = 1;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            // 
            // highButton
            // 
            this.highButton.Location = new System.Drawing.Point(11, 42);
            this.highButton.Name = "highButton";
            this.highButton.Size = new System.Drawing.Size(174, 37);
            this.highButton.TabIndex = 2;
            this.highButton.Text = "By Salary High to Low";
            this.highButton.UseVisualStyleBackColor = true;
            this.highButton.Click += new System.EventHandler(this.highButton_Click);
            // 
            // lowButton
            // 
            this.lowButton.Location = new System.Drawing.Point(11, 95);
            this.lowButton.Name = "lowButton";
            this.lowButton.Size = new System.Drawing.Size(174, 36);
            this.lowButton.TabIndex = 3;
            this.lowButton.Text = "By Salary Low to High";
            this.lowButton.UseVisualStyleBackColor = true;
            this.lowButton.Click += new System.EventHandler(this.lowButton_Click);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(6, 112);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(177, 22);
            this.userNameTextBox.TabIndex = 4;
            // 
            // userNameButton
            // 
            this.userNameButton.Location = new System.Drawing.Point(6, 141);
            this.userNameButton.Name = "userNameButton";
            this.userNameButton.Size = new System.Drawing.Size(177, 30);
            this.userNameButton.TabIndex = 5;
            this.userNameButton.Text = "By Username";
            this.userNameButton.UseVisualStyleBackColor = true;
            this.userNameButton.Click += new System.EventHandler(this.userNameButton_Click);
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(6, 47);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(106, 36);
            this.showAllButton.TabIndex = 6;
            this.showAllButton.Text = "Show All";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(1210, 596);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(93, 36);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.salesmanRadioButton);
            this.groupBox1.Controls.Add(this.managerRadioButton);
            this.groupBox1.Controls.Add(this.adminRadioButton);
            this.groupBox1.Controls.Add(this.selectButton);
            this.groupBox1.Location = new System.Drawing.Point(110, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 165);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Show Employee By";
            // 
            // adminRadioButton
            // 
            this.adminRadioButton.AutoSize = true;
            this.adminRadioButton.Location = new System.Drawing.Point(6, 38);
            this.adminRadioButton.Name = "adminRadioButton";
            this.adminRadioButton.Size = new System.Drawing.Size(68, 21);
            this.adminRadioButton.TabIndex = 0;
            this.adminRadioButton.TabStop = true;
            this.adminRadioButton.Text = "Admin";
            this.adminRadioButton.UseVisualStyleBackColor = true;
            // 
            // managerRadioButton
            // 
            this.managerRadioButton.AutoSize = true;
            this.managerRadioButton.Location = new System.Drawing.Point(6, 65);
            this.managerRadioButton.Name = "managerRadioButton";
            this.managerRadioButton.Size = new System.Drawing.Size(85, 21);
            this.managerRadioButton.TabIndex = 1;
            this.managerRadioButton.TabStop = true;
            this.managerRadioButton.Text = "Manager";
            this.managerRadioButton.UseVisualStyleBackColor = true;
            // 
            // salesmanRadioButton
            // 
            this.salesmanRadioButton.AutoSize = true;
            this.salesmanRadioButton.Location = new System.Drawing.Point(6, 93);
            this.salesmanRadioButton.Name = "salesmanRadioButton";
            this.salesmanRadioButton.Size = new System.Drawing.Size(91, 21);
            this.salesmanRadioButton.TabIndex = 2;
            this.salesmanRadioButton.TabStop = true;
            this.salesmanRadioButton.Text = "Salesman";
            this.salesmanRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.highButton);
            this.groupBox2.Controls.Add(this.lowButton);
            this.groupBox2.Location = new System.Drawing.Point(466, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 159);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sort By";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.userNameButton);
            this.groupBox3.Controls.Add(this.userNameTextBox);
            this.groupBox3.Controls.Add(this.showAllButton);
            this.groupBox3.Location = new System.Drawing.Point(787, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 177);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Show";
            // 
            // EmployeeInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 673);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.employeeDataGridView);
            this.Name = "EmployeeInformation";
            this.Text = "EmployeeInformation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeInformation_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button highButton;
        private System.Windows.Forms.Button lowButton;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Button userNameButton;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton salesmanRadioButton;
        private System.Windows.Forms.RadioButton managerRadioButton;
        private System.Windows.Forms.RadioButton adminRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}