using Computer_Shop_Inventory_Management.Businees_Logic_Layer;
using Computer_Shop_Inventory_Management.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Shop_Inventory_Management.Presentation_Layer
{
    public partial class ModifyEmployeeInformation : Form
    {
        private string userName;
        public ModifyEmployeeInformation(string userName)
        {
            InitializeComponent();
            this.userName = userName;
            Employee employee = new Employee();
            EmployeeServices employeeServices = new EmployeeServices();
            employee =  employeeServices.ReadEmployee(userName);

            nameTextBox.Text = employee.Name;
            passTextBox.Text = employee.Password;
            dateTimePicker.Text = employee.DateOfBirth;
            //MessageBox.Show("" + employee.Gender);
            if (employee.Gender == "Male") maleRadioButton.Checked = true;
            else femaleRadioButton.Checked = true;

            addressTextBox.Text = employee.Address;
            emailTextBox.Text = employee.Email;
            bloodgroupTextBox.Text = employee.BloodGroup;
            typeComboBox.Text = employee.EmployeeType;
            salaryTextBox.Text = employee.Salary.ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ModifyEmployeeInformation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ModifyEmployeeInformation_Load(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(nameTextBox.Text == "" || passTextBox.Text == "" || emailTextBox.Text == "" || addressTextBox.Text == "" || bloodgroupTextBox.Text == "" || typeComboBox.Text == "" || salaryTextBox.Text == "")
                {
                    MessageBox.Show("Please Fillup Every Information..");
                }
                else if(maleRadioButton.Checked == false && femaleRadioButton.Checked == false)
                {
                    MessageBox.Show("Please Fillup Every Information..");
                }
                else
                {
                    string gender = "";
                    if (MaleRadioButton == true) gender = "Male";
                    else gender = "Female";
                    EmployeeServices employeeServices = new EmployeeServices();
                    int res = employeeServices.UpdateEmployee(NameTextBox, userName, PasswordTextBox, EmailTextBox, AddressTextBox, DateTimePicker, BloodGroupTextBox, gender, TypeTextBox, Convert.ToSingle(SalaryTextBox));
                    if (res > 0)
                    {
                        MessageBox.Show("Employee Updated....");

                        UpdateEmployee update = new UpdateEmployee(userName);
                        update.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Could Not Update....");
                    }
                }

                
            }
            catch(Exception e2)
            {
                MessageBox.Show(e2.Message);
            }            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            UpdateEmployee update = new UpdateEmployee(userName);
            update.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
