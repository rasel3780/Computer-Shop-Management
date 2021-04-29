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
        public UpdateEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
            string userName = employeeServices.CheckUserName(removeTextBox.Text);
            if(userName != removeTextBox.Text)
            {
                MessageBox.Show("Employee Not Found!!");
            }
            else
            {

                int res = employeeServices.RemoveEmployee(removeTextBox.Text);
                if(res > 0)
                {
                    MessageBox.Show("Employee Removed.");
                }
                else
                {
                    MessageBox.Show("Employee Can't be Removed.");
                }
            }
        }
    }
}
