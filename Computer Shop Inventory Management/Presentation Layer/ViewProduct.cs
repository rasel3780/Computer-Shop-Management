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
    public partial class ViewProduct : Form
    {
        public ViewProduct()
        {
            InitializeComponent();
            ProductServices productService = new ProductServices();
            productGridView.DataSource = productService.GetProducts();

            ProductList productList = new ProductList();
            categoryComboBox.DataSource = productList.Category();
            brandComboBox.DataSource = productList.Brand();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductServices productService = new ProductServices();
            productGridView.DataSource = productService.GetProducts();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductServices productService = new ProductServices();
            productGridView.DataSource = productService.GetProducts();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
            this.Hide();
        }

        private void ViewProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
