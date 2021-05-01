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
    public partial class SalesmanHome : Form
    {
        private string empName;
        public SalesmanHome(string empName)
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

        private void SalesmanHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void viewProductButton_Click(object sender, EventArgs e)
        {
            ViewProduct viewProduct = new ViewProduct("Salesman",empName);
            viewProduct.Show();
            this.Hide();
        }
    }
}
