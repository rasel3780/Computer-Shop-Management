
namespace Computer_Shop_Inventory_Management
{
    partial class Login
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
            this.loginGroupBox = new System.Windows.Forms.GroupBox();
            this.typeWarning = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.loginType = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.passWarning = new System.Windows.Forms.Label();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.nameWarning = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.signUpButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loginGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginGroupBox
            // 
            this.loginGroupBox.Controls.Add(this.typeWarning);
            this.loginGroupBox.Controls.Add(this.typeComboBox);
            this.loginGroupBox.Controls.Add(this.loginType);
            this.loginGroupBox.Controls.Add(this.loginButton);
            this.loginGroupBox.Controls.Add(this.passWarning);
            this.loginGroupBox.Controls.Add(this.passTextBox);
            this.loginGroupBox.Controls.Add(this.passLabel);
            this.loginGroupBox.Controls.Add(this.nameWarning);
            this.loginGroupBox.Controls.Add(this.nameTextBox);
            this.loginGroupBox.Controls.Add(this.nameLabel);
            this.loginGroupBox.Location = new System.Drawing.Point(76, 24);
            this.loginGroupBox.Name = "loginGroupBox";
            this.loginGroupBox.Size = new System.Drawing.Size(651, 354);
            this.loginGroupBox.TabIndex = 3;
            this.loginGroupBox.TabStop = false;
            this.loginGroupBox.Text = "Log In";
            // 
            // typeWarning
            // 
            this.typeWarning.AutoSize = true;
            this.typeWarning.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeWarning.ForeColor = System.Drawing.Color.Red;
            this.typeWarning.Location = new System.Drawing.Point(270, 69);
            this.typeWarning.Name = "typeWarning";
            this.typeWarning.Size = new System.Drawing.Size(144, 14);
            this.typeWarning.TabIndex = 37;
            this.typeWarning.Text = "*This Field is Required*";
            this.typeWarning.Visible = false;
            this.typeWarning.Click += new System.EventHandler(this.loginTypeWarning_Click);
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Salesman"});
            this.typeComboBox.Location = new System.Drawing.Point(273, 45);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(204, 21);
            this.typeComboBox.TabIndex = 36;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // loginType
            // 
            this.loginType.AutoSize = true;
            this.loginType.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginType.Location = new System.Drawing.Point(149, 45);
            this.loginType.Name = "loginType";
            this.loginType.Size = new System.Drawing.Size(90, 22);
            this.loginType.TabIndex = 35;
            this.loginType.Text = "Login As";
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(289, 275);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(100, 37);
            this.loginButton.TabIndex = 34;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passWarning
            // 
            this.passWarning.AutoSize = true;
            this.passWarning.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passWarning.ForeColor = System.Drawing.Color.Red;
            this.passWarning.Location = new System.Drawing.Point(270, 200);
            this.passWarning.Name = "passWarning";
            this.passWarning.Size = new System.Drawing.Size(144, 14);
            this.passWarning.TabIndex = 33;
            this.passWarning.Text = "*This Field is Required*";
            this.passWarning.Visible = false;
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(273, 160);
            this.passTextBox.Multiline = true;
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '*';
            this.passTextBox.Size = new System.Drawing.Size(204, 33);
            this.passTextBox.TabIndex = 32;
            this.passTextBox.TextChanged += new System.EventHandler(this.passTextBox_TextChanged);
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.Location = new System.Drawing.Point(143, 160);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(96, 22);
            this.passLabel.TabIndex = 31;
            this.passLabel.Text = "Password";
            // 
            // nameWarning
            // 
            this.nameWarning.AutoSize = true;
            this.nameWarning.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameWarning.ForeColor = System.Drawing.Color.Red;
            this.nameWarning.Location = new System.Drawing.Point(270, 128);
            this.nameWarning.Name = "nameWarning";
            this.nameWarning.Size = new System.Drawing.Size(144, 14);
            this.nameWarning.TabIndex = 26;
            this.nameWarning.Text = "*This Field is Required*";
            this.nameWarning.Visible = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(273, 92);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(204, 33);
            this.nameTextBox.TabIndex = 25;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(128, 92);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(111, 22);
            this.nameLabel.TabIndex = 24;
            this.nameLabel.Text = "User Name";
            // 
            // signUpButton
            // 
            this.signUpButton.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.Location = new System.Drawing.Point(471, 410);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(75, 23);
            this.signUpButton.TabIndex = 5;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Do Not Have An Account?";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginGroupBox);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.loginGroupBox.ResumeLayout(false);
            this.loginGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox loginGroupBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label loginType;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label passWarning;
        public System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label nameWarning;
        public System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label typeWarning;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Label label1;
    }
}