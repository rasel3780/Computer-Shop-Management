
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
            this.salesmanRadioButton = new System.Windows.Forms.RadioButton();
            this.managerRadioButton = new System.Windows.Forms.RadioButton();
            this.adminRadioButton = new System.Windows.Forms.RadioButton();
            this.sortByGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.sortByGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Location = new System.Drawing.Point(20, 145);
            this.employeeDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.RowHeadersWidth = 51;
            this.employeeDataGridView.RowTemplate.Height = 24;
            this.employeeDataGridView.Size = new System.Drawing.Size(958, 338);
            this.employeeDataGridView.TabIndex = 0;
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(51, 94);
            this.selectButton.Margin = new System.Windows.Forms.Padding(2);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(68, 25);
            this.selectButton.TabIndex = 1;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // highButton
            // 
            this.highButton.Location = new System.Drawing.Point(17, 34);
            this.highButton.Margin = new System.Windows.Forms.Padding(2);
            this.highButton.Name = "highButton";
            this.highButton.Size = new System.Drawing.Size(160, 30);
            this.highButton.TabIndex = 2;
            this.highButton.Text = "By Salary High to Low";
            this.highButton.UseVisualStyleBackColor = true;
            this.highButton.Click += new System.EventHandler(this.highButton_Click);
            // 
            // lowButton
            // 
            this.lowButton.Location = new System.Drawing.Point(17, 73);
            this.lowButton.Margin = new System.Windows.Forms.Padding(2);
            this.lowButton.Name = "lowButton";
            this.lowButton.Size = new System.Drawing.Size(160, 29);
            this.lowButton.TabIndex = 3;
            this.lowButton.Text = "By Salary Low to High";
            this.lowButton.UseVisualStyleBackColor = true;
            this.lowButton.Click += new System.EventHandler(this.lowButton_Click);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(10, 34);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.userNameTextBox.Multiline = true;
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(134, 30);
            this.userNameTextBox.TabIndex = 4;
            // 
            // userNameButton
            // 
            this.userNameButton.Location = new System.Drawing.Point(10, 68);
            this.userNameButton.Margin = new System.Windows.Forms.Padding(2);
            this.userNameButton.Name = "userNameButton";
            this.userNameButton.Size = new System.Drawing.Size(134, 34);
            this.userNameButton.TabIndex = 5;
            this.userNameButton.Text = "By Username";
            this.userNameButton.UseVisualStyleBackColor = true;
            this.userNameButton.Click += new System.EventHandler(this.userNameButton_Click);
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(157, 34);
            this.showAllButton.Margin = new System.Windows.Forms.Padding(2);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(80, 68);
            this.showAllButton.TabIndex = 6;
            this.showAllButton.Text = "Show All";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(20, 487);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(70, 29);
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
            this.groupBox1.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(168, 129);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Show Employee By";
            // 
            // salesmanRadioButton
            // 
            this.salesmanRadioButton.AutoSize = true;
            this.salesmanRadioButton.Location = new System.Drawing.Point(13, 47);
            this.salesmanRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.salesmanRadioButton.Name = "salesmanRadioButton";
            this.salesmanRadioButton.Size = new System.Drawing.Size(75, 20);
            this.salesmanRadioButton.TabIndex = 2;
            this.salesmanRadioButton.TabStop = true;
            this.salesmanRadioButton.Text = "Salesman";
            this.salesmanRadioButton.UseVisualStyleBackColor = true;
            // 
            // managerRadioButton
            // 
            this.managerRadioButton.AutoSize = true;
            this.managerRadioButton.Location = new System.Drawing.Point(13, 68);
            this.managerRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.managerRadioButton.Name = "managerRadioButton";
            this.managerRadioButton.Size = new System.Drawing.Size(75, 20);
            this.managerRadioButton.TabIndex = 1;
            this.managerRadioButton.TabStop = true;
            this.managerRadioButton.Text = "Manager";
            this.managerRadioButton.UseVisualStyleBackColor = true;
            // 
            // adminRadioButton
            // 
            this.adminRadioButton.AutoSize = true;
            this.adminRadioButton.Location = new System.Drawing.Point(13, 23);
            this.adminRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.adminRadioButton.Name = "adminRadioButton";
            this.adminRadioButton.Size = new System.Drawing.Size(64, 20);
            this.adminRadioButton.TabIndex = 0;
            this.adminRadioButton.TabStop = true;
            this.adminRadioButton.Text = "Admin";
            this.adminRadioButton.UseVisualStyleBackColor = true;
            // 
            // sortByGroupBox
            // 
            this.sortByGroupBox.Controls.Add(this.highButton);
            this.sortByGroupBox.Controls.Add(this.lowButton);
            this.sortByGroupBox.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortByGroupBox.Location = new System.Drawing.Point(480, 12);
            this.sortByGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.sortByGroupBox.Name = "sortByGroupBox";
            this.sortByGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.sortByGroupBox.Size = new System.Drawing.Size(194, 129);
            this.sortByGroupBox.TabIndex = 9;
            this.sortByGroupBox.TabStop = false;
            this.sortByGroupBox.Text = "Sort By";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.userNameButton);
            this.groupBox3.Controls.Add(this.userNameTextBox);
            this.groupBox3.Controls.Add(this.showAllButton);
            this.groupBox3.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(209, 12);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(252, 128);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Show";
            // 
            // EmployeeInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 522);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.sortByGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.employeeDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EmployeeInformation";
            this.Text = "EmployeeInformation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeInformation_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.sortByGroupBox.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox sortByGroupBox;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}