
namespace Computer_Shop_Inventory_Management.Presentation_Layer
{
    partial class UpdateEmployee
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
            this.updateNameTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.removeNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.updateGroupBox = new System.Windows.Forms.GroupBox();
            this.removeGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            this.updateGroupBox.SuspendLayout();
            this.removeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Location = new System.Drawing.Point(455, 27);
            this.employeeDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.RowHeadersWidth = 51;
            this.employeeDataGridView.RowTemplate.Height = 24;
            this.employeeDataGridView.Size = new System.Drawing.Size(600, 468);
            this.employeeDataGridView.TabIndex = 0;
            this.employeeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // updateNameTextBox
            // 
            this.updateNameTextBox.Location = new System.Drawing.Point(188, 38);
            this.updateNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateNameTextBox.Name = "updateNameTextBox";
            this.updateNameTextBox.Size = new System.Drawing.Size(151, 27);
            this.updateNameTextBox.TabIndex = 1;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(137, 79);
            this.updateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(109, 33);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(137, 79);
            this.removeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(108, 33);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // removeNameTextBox
            // 
            this.removeNameTextBox.Location = new System.Drawing.Point(188, 38);
            this.removeNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeNameTextBox.Multiline = true;
            this.removeNameTextBox.Name = "removeNameTextBox";
            this.removeNameTextBox.Size = new System.Drawing.Size(151, 26);
            this.removeNameTextBox.TabIndex = 3;
            this.removeNameTextBox.TextChanged += new System.EventHandler(this.removeTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter User Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(16, 507);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 32);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // updateGroupBox
            // 
            this.updateGroupBox.Controls.Add(this.updateNameTextBox);
            this.updateGroupBox.Controls.Add(this.updateButton);
            this.updateGroupBox.Controls.Add(this.label1);
            this.updateGroupBox.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateGroupBox.Location = new System.Drawing.Point(16, 103);
            this.updateGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.updateGroupBox.Name = "updateGroupBox";
            this.updateGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.updateGroupBox.Size = new System.Drawing.Size(432, 135);
            this.updateGroupBox.TabIndex = 7;
            this.updateGroupBox.TabStop = false;
            this.updateGroupBox.Text = "Update";
            // 
            // removeGroupBox
            // 
            this.removeGroupBox.Controls.Add(this.label2);
            this.removeGroupBox.Controls.Add(this.removeNameTextBox);
            this.removeGroupBox.Controls.Add(this.removeButton);
            this.removeGroupBox.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeGroupBox.Location = new System.Drawing.Point(16, 274);
            this.removeGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.removeGroupBox.Name = "removeGroupBox";
            this.removeGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.removeGroupBox.Size = new System.Drawing.Size(432, 137);
            this.removeGroupBox.TabIndex = 8;
            this.removeGroupBox.TabStop = false;
            this.removeGroupBox.Text = "Remove";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter User Name";
            // 
            // UpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.removeGroupBox);
            this.Controls.Add(this.updateGroupBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.employeeDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateEmployee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateEmployee_FormClosing);
            this.Load += new System.EventHandler(this.UpdateEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            this.updateGroupBox.ResumeLayout(false);
            this.updateGroupBox.PerformLayout();
            this.removeGroupBox.ResumeLayout(false);
            this.removeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.TextBox updateNameTextBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox removeNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.GroupBox updateGroupBox;
        private System.Windows.Forms.GroupBox removeGroupBox;
        private System.Windows.Forms.Label label2;

        public string UpdateNameTextBox
        {
            get { return this.updateNameTextBox.Text; }
        }
        public string RemoveNameTextBox
        {
            get { return this.removeNameTextBox.Text; }
        }

    }
}