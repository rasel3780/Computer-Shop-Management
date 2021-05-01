using Computer_Shop_Inventory_Management.Presentation_Layer;
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
            else if(typeComboBox.Text=="Admin")
            {
                AdminHome admin = new AdminHome(nameTextBox.Text);
                admin.Show();
                this.Hide();
            }
            else if(typeComboBox.Text== "Manager")
            {
                ManagerHome managerHome = new ManagerHome(nameTextBox.Text);
                managerHome.Show();
                this.Hide();
            }
            else if(typeComboBox.Text == "Salesman")
            {
                SalesmanHome salesmanHome = new SalesmanHome(nameTextBox.Text);
                salesmanHome.Show();
                this.Hide();
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration(nameTextBox.Text);
            registration.Show();
            this.Hide();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(typeWarning.Visible == true)
            {
                typeWarning.Visible = false;
            }
            
           
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nameWarning.Visible == true)
            {
                nameWarning.Visible = false;
            }
        }

        private void passTextBox_TextChanged(object sender, EventArgs e)
        {
             if (passWarning.Visible == true)
             {
                passWarning.Visible = false;
             }
        }
    }
}
