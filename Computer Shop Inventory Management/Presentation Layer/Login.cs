using Computer_Shop_Inventory_Management.Businees_Logic_Layer;
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
            
           if (nameTextBox.Text == "")
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
                LoginServices loginServices = new LoginServices();
                string res = loginServices.LoginCheck(nameTextBox.Text, passTextBox.Text);
                LoginServices loginServices1 = new LoginServices();
                string empType = loginServices1.ReturnEmployeeType(nameTextBox.Text, passTextBox.Text);
                
                if (res == nameTextBox.Text && empType =="Admin")
                {
                    AdminHome admin = new AdminHome(nameTextBox.Text);
                    admin.Show();
                    this.Hide();
                }
                else if(res == nameTextBox.Text && empType == "Manager")
                {
                    ManagerHome managerHome = new ManagerHome(nameTextBox.Text);
                    managerHome.Show();
                    this.Hide();
                }
                else if(res == nameTextBox.Text && empType == "Salesman")
                {
                    SalesmanHome salesmanHome = new SalesmanHome(nameTextBox.Text);
                    salesmanHome.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password!!");
                }
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
