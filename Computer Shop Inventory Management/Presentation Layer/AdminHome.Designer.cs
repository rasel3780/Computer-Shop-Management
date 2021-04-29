
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
            this.logoutButton = new System.Windows.Forms.Button();
            this.viewProdcutButton = new System.Windows.Forms.Button();
            this.adminGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(185, 44);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Employee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductButton.Location = new System.Drawing.Point(185, 202);
            this.addProductButton.Margin = new System.Windows.Forms.Padding(4);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(219, 58);
            this.addProductButton.TabIndex = 2;
            this.addProductButton.Text = "Add Product";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyButton.Location = new System.Drawing.Point(185, 124);
            this.modifyButton.Margin = new System.Windows.Forms.Padding(4);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(219, 58);
            this.modifyButton.TabIndex = 4;
            this.modifyButton.Text = "Update Employee";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // sellButton
            // 
            this.sellButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellButton.Location = new System.Drawing.Point(185, 373);
            this.sellButton.Margin = new System.Windows.Forms.Padding(4);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(219, 58);
            this.sellButton.TabIndex = 5;
            this.sellButton.Text = "Total Sale";
            this.sellButton.UseVisualStyleBackColor = true;
            // 
            // adminGroupBox
            // 
            this.adminGroupBox.Controls.Add(this.logoutButton);
            this.adminGroupBox.Controls.Add(this.button1);
            this.adminGroupBox.Controls.Add(this.sellButton);
            this.adminGroupBox.Controls.Add(this.viewProdcutButton);
            this.adminGroupBox.Controls.Add(this.addProductButton);
            this.adminGroupBox.Controls.Add(this.modifyButton);
            this.adminGroupBox.Location = new System.Drawing.Point(85, 15);
            this.adminGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.adminGroupBox.Name = "adminGroupBox";
            this.adminGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.adminGroupBox.Size = new System.Drawing.Size(904, 506);
            this.adminGroupBox.TabIndex = 6;
            this.adminGroupBox.TabStop = false;
            this.adminGroupBox.Text = "Admin";
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.SystemColors.Control;
            this.logoutButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(735, 426);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(112, 36);
            this.logoutButton.TabIndex = 7;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // viewProdcutButton
            // 
            this.viewProdcutButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewProdcutButton.Location = new System.Drawing.Point(185, 283);
            this.viewProdcutButton.Margin = new System.Windows.Forms.Padding(4);
            this.viewProdcutButton.Name = "viewProdcutButton";
            this.viewProdcutButton.Size = new System.Drawing.Size(219, 58);
            this.viewProdcutButton.TabIndex = 2;
            this.viewProdcutButton.Text = "View Product";
            this.viewProdcutButton.UseVisualStyleBackColor = true;
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.adminGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminHome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminHome_FormClosing);
            this.adminGroupBox.ResumeLayout(false);
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
    }
}