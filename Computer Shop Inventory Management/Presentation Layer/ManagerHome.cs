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
    public partial class ManagerHome : Form
    {
        private string empName;
        public ManagerHome(string empName)
        {
            InitializeComponent();
            this.empName = empName;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void ManagerHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
       
        private void viewProductButton_Click(object sender, EventArgs e)
        {
            ViewProduct viewProduct = new ViewProduct("Manager",empName);
            viewProduct.Show();
            this.Hide();
        }

        private void saleInfoButton_Click(object sender, EventArgs e)
        {
            SaleDetails sale = new SaleDetails("Manager",empName);
            sale.Show();
            this.Hide();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            AddProducts addProducts = new AddProducts("Manager",empName);
            addProducts.Show();
            this.Hide();
        }

        private void viewSalesmanButton_Click(object sender, EventArgs e)
        {
            EmployeeInformation employeeInformation = new EmployeeInformation("Manager", empName);
            this.Hide();
            employeeInformation.Show();
        }
    }
}
