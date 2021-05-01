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
    public partial class ViewProduct : Form
    {
        public ViewProduct()
        {
            InitializeComponent();
            ProductServices productService = new ProductServices();
            productGridView.DataSource = productService.GetAllProducts();

            ProductList productList = new ProductList();
            categoryComboBox.DataSource = productList.Category();
            brandComboBox.DataSource = productList.Brand();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductServices productService = new ProductServices();
            int ans = productService.CheckProductId(Convert.ToInt32(ShowByIdTextBox));
            if (ans > 0)
            {
                productGridView.DataSource = productService.GetProductById(Convert.ToInt32(ShowByIdTextBox));
            }
            else
            {
                MessageBox.Show("No Product Found....");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductServices productService = new ProductServices();
            int ans = productService.CheckProductId(Convert.ToInt32(RemoveTextBox));
            if (ans > 0)
            {
                int x = productService.RemoveProduct(Convert.ToInt32(RemoveTextBox));
                if (x > 0)
                {
                    MessageBox.Show("Product Removed.....");
                    productGridView.DataSource = productService.GetAllProducts();
                }
                else
                {
                    MessageBox.Show("Error...");
                }
            }
            else
            {
                MessageBox.Show("No Product Found....");
            }
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

        private void ViewProduct_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void showByCategoryButton_Click(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>();
            ProductServices productService = new ProductServices();
            products = productService.GetProductsByCategory(CategoryComboBox);
            if (products.Count > 0)
            {
                productGridView.DataSource = productService.GetProductsByCategory(CategoryComboBox);
            }
            else
            {
                MessageBox.Show("Product Not found.....");
            }
        }

        private void showByBrandButton_Click(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>();
            ProductServices productService = new ProductServices();
            products = productService.GetProductsByBrand(BrandComboBox);
            if (products.Count > 0)
            {
                productGridView.DataSource = productService.GetProductsByBrand(BrandComboBox);
            }
            else
            {
                MessageBox.Show("Product Not found.....");
            }
        }

        private void bothButton_Click(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>();
            ProductServices productService = new ProductServices();
            products = productService.GetProductsByCategoryAndBrand(CategoryComboBox,BrandComboBox);
            if (products.Count > 0)
            {
                productGridView.DataSource = productService.GetProductsByCategoryAndBrand(CategoryComboBox, BrandComboBox);
            }
            else
            {
                MessageBox.Show("Product Not found.....");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
