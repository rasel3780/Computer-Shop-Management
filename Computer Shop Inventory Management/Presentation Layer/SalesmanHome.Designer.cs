﻿
namespace Computer_Shop_Inventory_Management.Presentation_Layer
{
    partial class SalesmanHome
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
            this.sellButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewProductButton
            // 
            this.viewProductButton.Location = new System.Drawing.Point(124, 59);
            this.viewProductButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewProductButton.Name = "viewProductButton";
            this.viewProductButton.Size = new System.Drawing.Size(116, 28);
            this.viewProductButton.TabIndex = 0;
            this.viewProductButton.Text = "View Product";
            this.viewProductButton.UseVisualStyleBackColor = true;
            this.viewProductButton.Click += new System.EventHandler(this.viewProductButton_Click);
            // 
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(124, 107);
            this.sellButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(116, 30);
            this.sellButton.TabIndex = 1;
            this.sellButton.Text = "Sell Product";
            this.sellButton.UseVisualStyleBackColor = true;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(532, 327);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(58, 28);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.viewProductButton);
            this.groupBox1.Controls.Add(this.sellButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(110, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(365, 190);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salesman Home";
            // 
            // SalesmanHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.logoutButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SalesmanHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesmanHome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SalesmanHome_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewProductButton;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}