
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
            this.removeButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.productButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.sellButton = new System.Windows.Forms.Button();
            this.adminGroupBox = new System.Windows.Forms.GroupBox();
            this.adminGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(139, 84);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(164, 47);
            this.removeButton.TabIndex = 0;
            this.removeButton.Text = "Remove Employee";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(139, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Employee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // productButton
            // 
            this.productButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productButton.Location = new System.Drawing.Point(139, 292);
            this.productButton.Name = "productButton";
            this.productButton.Size = new System.Drawing.Size(164, 47);
            this.productButton.TabIndex = 2;
            this.productButton.Text = "Product Details";
            this.productButton.UseVisualStyleBackColor = true;
            // 
            // modifyButton
            // 
            this.modifyButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyButton.Location = new System.Drawing.Point(139, 151);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(164, 47);
            this.modifyButton.TabIndex = 4;
            this.modifyButton.Text = "Update Employee";
            this.modifyButton.UseVisualStyleBackColor = true;
            // 
            // sellButton
            // 
            this.sellButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellButton.Location = new System.Drawing.Point(139, 224);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(164, 47);
            this.sellButton.TabIndex = 5;
            this.sellButton.Text = "Total Sale";
            this.sellButton.UseVisualStyleBackColor = true;
            // 
            // adminGroupBox
            // 
            this.adminGroupBox.Controls.Add(this.button1);
            this.adminGroupBox.Controls.Add(this.sellButton);
            this.adminGroupBox.Controls.Add(this.productButton);
            this.adminGroupBox.Controls.Add(this.removeButton);
            this.adminGroupBox.Controls.Add(this.modifyButton);
            this.adminGroupBox.Location = new System.Drawing.Point(92, 26);
            this.adminGroupBox.Name = "adminGroupBox";
            this.adminGroupBox.Size = new System.Drawing.Size(641, 381);
            this.adminGroupBox.TabIndex = 6;
            this.adminGroupBox.TabStop = false;
            this.adminGroupBox.Text = "Admin";
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminGroupBox);
            this.Name = "AdminHome";
            this.Text = "AdminHome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminHome_FormClosing);
            this.adminGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button productButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.GroupBox adminGroupBox;
    }
}