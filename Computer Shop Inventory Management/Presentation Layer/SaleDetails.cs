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
    public partial class SaleDetails : Form
    {
        private string empType;
        private string empName;
        public SaleDetails(string empType,string empName)
        {
            InitializeComponent();
            this.empType = empType;
            this.empName = empName;
            SaleServices saleServices = new SaleServices();
            saleGridView.DataSource = saleServices.GetAllSale();

            ProductList productList = new ProductList();
            categoryComboBox.DataSource = productList.Category();
            brandComboBox.DataSource = productList.Brand();
        }

        private void SaleDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();


        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (empType == "Admin")
            {
                AdminHome admin = new AdminHome(empName);
                admin.Show();
                this.Hide();
            }
            else
            {
                ManagerHome manager = new ManagerHome(empName);
                manager.Show();
                this.Hide();
            }
        }

        private void showByCategoryButton_Click(object sender, EventArgs e)
        {
            SaleServices saleServices = new SaleServices();
            saleGridView.DataSource =saleServices.GetAllSaleByCategory(categoryComboBox.Text);
        }

        private void showByBrandButton_Click(object sender, EventArgs e)
        {
            SaleServices saleServices = new SaleServices();
            saleGridView.DataSource = saleServices.GetAllSaleByBrand(brandComboBox.Text);
        }

        private void bothButton_Click(object sender, EventArgs e)
        {
            SaleServices saleServices = new SaleServices();
            saleGridView.DataSource = saleServices.GetAllSaleByBoth(categoryComboBox.Text,brandComboBox.Text);
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            SaleServices saleServices = new SaleServices();
            saleGridView.DataSource = saleServices.GetAllSale();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaleServices saleServices = new SaleServices();
            saleGridView.DataSource =  saleServices.SellSort();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaleServices saleServices = new SaleServices();
            saleGridView.DataSource = saleServices.SellSortDescending();
        }
    }
}
