using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Shop_Inventory_Management
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void loginTypeWarning_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (typeComboBox.Text == "")
            {
                typeWarning.Visible = true;
            }
            else if (nameTextBox.Text == "")
            {
                nameWarning.Visible = true;
            }
            /*else if(emailTextBox.Text =="")
            {
                emailWarning.Visible = true;
            }*/
            else if (passTextBox.Text == "")
            {
                passWarning.Visible = true;
            }
            else
            {
                AdminHome admin = new AdminHome();
                admin.Show();
                this.Hide();
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
