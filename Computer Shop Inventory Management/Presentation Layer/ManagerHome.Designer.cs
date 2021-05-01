
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
            this.sellProductButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.logoutButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewProductButton
            // 
            this.viewProductButton.Location = new System.Drawing.Point(41, 110);
            this.viewProductButton.Name = "viewProductButton";
            this.viewProductButton.Size = new System.Drawing.Size(185, 37);
            this.viewProductButton.TabIndex = 2;
            this.viewProductButton.Text = "View Product";
            this.viewProductButton.UseVisualStyleBackColor = true;
            this.viewProductButton.Click += new System.EventHandler(this.viewProductButton_Click);
            // 
            // sellProductButton
            // 
            this.sellProductButton.Location = new System.Drawing.Point(41, 181);
            this.sellProductButton.Name = "sellProductButton";
            this.sellProductButton.Size = new System.Drawing.Size(185, 36);
            this.sellProductButton.TabIndex = 4;
            this.sellProductButton.Text = "Sell Product";
            this.sellProductButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sellProductButton);
            this.groupBox1.Controls.Add(this.viewProductButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(245, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 336);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manager Home";
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(676, 400);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(89, 38);
            this.logoutButton.TabIndex = 6;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // ManagerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManagerHome";
            this.Text = "ManagerHome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerHome_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button viewProductButton;
        private System.Windows.Forms.Button sellProductButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button logoutButton;
    }
}