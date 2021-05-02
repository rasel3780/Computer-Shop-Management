using Computer_Shop_Inventory_Management.Businees_Logic_Layer;
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
    public partial class UpdateEmployee : Form
    {
        private string empName;
        public UpdateEmployee(string empName)
        {
            InitializeComponent();
            this.empName = empName;
            EmployeeServices employeeServices = new EmployeeServices();
            employeeDataGridView.DataSource = employeeServices.GetAllEmployees();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeServices employeeServices = new EmployeeServices();
            string name = employeeServices.CheckUserName(UpdateNameTextBox);
            //MessageBox.Show("" + name);
            if(name==UpdateNameTextBox)
            {
                ModifyEmployeeInformation modifyEmployeeInformation = new ModifyEmployeeInformation(UpdateNameTextBox);
                modifyEmployeeInformation.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Employee not found");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UpdateEmployee_Load(object sender, EventArgs e)
        {

        }

        private void UpdateEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            EmployeeServices employeeServices = new EmployeeServices();
            string userName = employeeServices.CheckUserName(RemoveNameTextBox);
            if(userName != RemoveNameTextBox)
            {
                MessageBox.Show("Employee Not Found!!");
            }
            else
            {

                int res = employeeServices.RemoveEmployee(RemoveNameTextBox);
                if(res > 0)
                {
                    MessageBox.Show("Employee Removed.");
                    EmployeeServices employeeServices1 = new EmployeeServices();
                    employeeDataGridView.DataSource = employeeServices1.GetAllEmployees();
                }
                else
                {
                    MessageBox.Show("Employee Can't be Removed.");
                }
            }
        }

        private void removeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AdminHome admin = new AdminHome(empName);
            admin.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
