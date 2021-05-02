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
    public partial class EmployeeInformation : Form
    {
        private string empType;
        private string empName;
        public EmployeeInformation(string empType,string empName)
        {
            InitializeComponent();
            this.empType = empType;
            this.empName = empName;
            EmployeeServices employeeServices = new EmployeeServices();
            employeeDataGridView.DataSource = employeeServices.GetAllEmployees();
        }

        private void EmployeeInformation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            EmployeeServices employeeServices = new EmployeeServices();
            employeeDataGridView.DataSource = employeeServices.GetAllEmployees(); 
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if(empType == "Admin")
            {
                AdminHome adminHome = new AdminHome(empName);
                this.Hide();
                adminHome.Show();
            }
            else if (empType == "Manager")
            {
                ManagerHome managerHome = new ManagerHome(empName);
                this.Hide();
                managerHome.Show();
            }          
        }
    }
}
