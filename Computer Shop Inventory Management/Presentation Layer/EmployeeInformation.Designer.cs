
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
            this.typeButton = new System.Windows.Forms.Button();
            this.highButton = new System.Windows.Forms.Button();
            this.lowButton = new System.Windows.Forms.Button();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.userNameButton = new System.Windows.Forms.Button();
            this.showAllButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
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
            // typeButton
            // 
            this.typeButton.Location = new System.Drawing.Point(275, 98);
            this.typeButton.Name = "typeButton";
            this.typeButton.Size = new System.Drawing.Size(137, 36);
            this.typeButton.TabIndex = 1;
            this.typeButton.Text = "By Type";
            this.typeButton.UseVisualStyleBackColor = true;
            // 
            // highButton
            // 
            this.highButton.Location = new System.Drawing.Point(463, 97);
            this.highButton.Name = "highButton";
            this.highButton.Size = new System.Drawing.Size(174, 37);
            this.highButton.TabIndex = 2;
            this.highButton.Text = "By Salary High to Low";
            this.highButton.UseVisualStyleBackColor = true;
            this.highButton.Click += new System.EventHandler(this.highButton_Click);
            // 
            // lowButton
            // 
            this.lowButton.Location = new System.Drawing.Point(709, 98);
            this.lowButton.Name = "lowButton";
            this.lowButton.Size = new System.Drawing.Size(169, 36);
            this.lowButton.TabIndex = 3;
            this.lowButton.Text = "By Salary Low to High";
            this.lowButton.UseVisualStyleBackColor = true;
            this.lowButton.Click += new System.EventHandler(this.lowButton_Click);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(955, 97);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(177, 22);
            this.userNameTextBox.TabIndex = 4;
            // 
            // userNameButton
            // 
            this.userNameButton.Location = new System.Drawing.Point(955, 126);
            this.userNameButton.Name = "userNameButton";
            this.userNameButton.Size = new System.Drawing.Size(177, 30);
            this.userNameButton.TabIndex = 5;
            this.userNameButton.Text = "By Username";
            this.userNameButton.UseVisualStyleBackColor = true;
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(108, 98);
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
            // EmployeeInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 673);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.userNameButton);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.lowButton);
            this.Controls.Add(this.highButton);
            this.Controls.Add(this.typeButton);
            this.Controls.Add(this.employeeDataGridView);
            this.Name = "EmployeeInformation";
            this.Text = "EmployeeInformation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeInformation_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.Button typeButton;
        private System.Windows.Forms.Button highButton;
        private System.Windows.Forms.Button lowButton;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Button userNameButton;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.Button backButton;
    }
}