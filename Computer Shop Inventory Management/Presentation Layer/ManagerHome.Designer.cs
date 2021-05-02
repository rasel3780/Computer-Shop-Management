
namespace Computer_Shop_Inventory_Management.Presentation_Layer
{
    partial class ManagerHome
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
            this.viewProductButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addProductButton = new System.Windows.Forms.Button();
            this.saleInfoButton = new System.Windows.Forms.Button();
            this.viewSalesmanButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewProductButton
            // 
            this.viewProductButton.Location = new System.Drawing.Point(161, 114);
            this.viewProductButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewProductButton.Name = "viewProductButton";
            this.viewProductButton.Size = new System.Drawing.Size(185, 41);
            this.viewProductButton.TabIndex = 2;
            this.viewProductButton.Text = "View Product";
            this.viewProductButton.UseVisualStyleBackColor = true;
            this.viewProductButton.Click += new System.EventHandler(this.viewProductButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addProductButton);
            this.groupBox1.Controls.Add(this.saleInfoButton);
            this.groupBox1.Controls.Add(this.viewSalesmanButton);
            this.groupBox1.Controls.Add(this.logoutButton);
            this.groupBox1.Controls.Add(this.viewProductButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(56, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(535, 316);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manager Home";
            // 
            // addProductButton
            // 
            this.addProductButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductButton.Location = new System.Drawing.Point(161, 53);
            this.addProductButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(185, 44);
            this.addProductButton.TabIndex = 9;
            this.addProductButton.Text = "Add Product";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // saleInfoButton
            // 
            this.saleInfoButton.Location = new System.Drawing.Point(161, 180);
            this.saleInfoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saleInfoButton.Name = "saleInfoButton";
            this.saleInfoButton.Size = new System.Drawing.Size(185, 41);
            this.saleInfoButton.TabIndex = 8;
            this.saleInfoButton.Text = "Sale Details";
            this.saleInfoButton.UseVisualStyleBackColor = true;
            this.saleInfoButton.Click += new System.EventHandler(this.saleInfoButton_Click);
            // 
            // viewSalesmanButton
            // 
            this.viewSalesmanButton.Location = new System.Drawing.Point(161, 245);
            this.viewSalesmanButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewSalesmanButton.Name = "viewSalesmanButton";
            this.viewSalesmanButton.Size = new System.Drawing.Size(185, 41);
            this.viewSalesmanButton.TabIndex = 7;
            this.viewSalesmanButton.Text = "Salesman Info";
            this.viewSalesmanButton.UseVisualStyleBackColor = true;
            this.viewSalesmanButton.Click += new System.EventHandler(this.viewSalesmanButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(408, 267);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(121, 38);
            this.logoutButton.TabIndex = 6;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // ManagerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 398);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManagerHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerHome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerHome_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button viewProductButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button viewSalesmanButton;
        private System.Windows.Forms.Button saleInfoButton;
        private System.Windows.Forms.Button addProductButton;
    }
}