﻿using Computer_Shop_Inventory_Management.Businees_Logic_Layer;
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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                nameWarning.Visible = true;
            }
            else if (usernameTextBox.Text == "")
            {
                usernameWarning.Visible = true;
            }
            else if (passTextBox.Text == "")
            {
                passWarning.Visible = true;
            }
            else if (cpassTextBox.Text == "")
            {
                cpassWarning.Visible = true;
            }
            else if (emailTextBox.Text == "")
            {
                emailWarning.Visible = true;
            }
            else if (dateTimePicker.Text == "")
            {
                dobWarning.Visible = true;
            }
            else if (maleRadioButton.Checked == false && femaleRadioButton.Checked == false)
            {
                genderWarning.Visible = true;
            }
            else if (bloodgroupTextBox.Text == "")
            {
                bgWarning.Visible = true;
            }
            else if (addressTextBox.Text == "")
            {
                addressWarning.Visible = true;
            }
            else if(typeComboBox.Text == "")
            {
                typeWarning.Visible = true;
            }
            else if(salaryTextBox.Text == "")
            {
                salaryWarning.Visible = true;
            }
            else if (passTextBox.Text != cpassTextBox.Text)
            {
                    MessageBox.Show("Password Did Not Match!!");
            }
            
            else
            {


                EmployeeServices employeeServices = new EmployeeServices();
                string gender = "";
                if (maleRadioButton.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }

                //Checking if Username already exists in Table
                string userExists = employeeServices.CheckUserName(usernameTextBox.Text);
                if (userExists == usernameTextBox.Text)
                {
                    MessageBox.Show("Username is already taken, please try different Username");
                }
                // add new Employee
                else
                {
                    EmployeeServices employeeServices1 = new EmployeeServices();
                    float salary = Convert.ToSingle(salaryTextBox.Text);
                    int res = employeeServices1.AddEmployee(nameTextBox.Text, usernameTextBox.Text, passTextBox.Text, emailTextBox.Text, addressTextBox.Text, dateTimePicker.Text, bloodgroupTextBox.Text, gender, typeComboBox.Text, salary);

                    if (res > 0)
                    {
                        MessageBox.Show("Employee Added");
                        nameTextBox.Text = usernameTextBox.Text = emailTextBox.Text = passTextBox.Text = cpassTextBox.Text = addressTextBox.Text= salaryTextBox.Text="";
                        maleRadioButton.Checked = femaleRadioButton.Checked = termscheckBox.Checked  = submitButton.Enabled = false;
                        bloodgroupTextBox.Text = null;
                    }
                    else
                    {
                        MessageBox.Show("There was an Error could not create the user");
                    }

                }
            }



        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nameWarning.Visible == true)
            {
                nameWarning.Visible = false;
            }
        }
        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (usernameWarning.Visible == true)
            {
                usernameWarning.Visible = false;
            }
        }
        private void passTextBox_TextChanged(object sender, EventArgs e)
        {
            if (passWarning.Visible == true)
            {
                passWarning.Visible = false;
            }
        }
        private void cpassTextBox_TextChanged(object sender, EventArgs e)
        {
            if (cpassWarning.Visible == true)
            {
                cpassWarning.Visible = false;
            }
        }
        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (emailWarning.Visible == true)
            {
                emailWarning.Visible = false;
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (dobWarning.Visible == true)
            {
                dobWarning.Visible = false;
            }
        }

        private void bloodgroupTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bgWarning.Visible == true)
            {
                bgWarning.Visible = false;
            }
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (addressWarning.Visible == true)
            {
                addressWarning.Visible = false;
            }
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeWarning.Visible == true)
            {
                typeWarning.Visible = false;
            }
        }


        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void salaryTextBox_TextChanged(object sender, EventArgs e)
        {
            if(salaryWarning.Visible == true)
            {
                salaryWarning.Visible = false;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AdminHome admin = new AdminHome();
            admin.Show();
            this.Hide();
        }

        private void termscheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (termscheckBox.Checked == true) submitButton.Enabled = true;
        }

        private void termscheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (termscheckBox.Checked)
            {
                submitButton.Enabled = true;
            }
            else
                submitButton.Enabled = false;
        }
    }
    
}
