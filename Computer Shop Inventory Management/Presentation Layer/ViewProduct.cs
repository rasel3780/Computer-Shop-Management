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
        private string empType;
        private string empName="hahaha";
        public ViewProduct(string empType)
        {
            InitializeComponent();
            this.empType = empType;
            //this.empName = empName;
            ProductServices productService = new ProductServices();
            productGridView.DataSource = productService.GetAllProducts();

            ProductList productList = new ProductList();
            categoryComboBox.DataSource = productList.Category();
            brandComboBox.DataSource = productList.Brand();
            if(empType=="Salesman")
            {
                updateButton.Enabled = false;
                removeButton.Enabled = false;
                updateButton.Visible = false;
                removeButton.Visible = false;

                removeTextBox.Visible = false;
                updateTextBox.Visible = false;
            }
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
            if(empType=="Manager")
            {
                ManagerHome managerHome = new ManagerHome();
                managerHome.Show();
                this.Hide();
            }
            else if(empType=="Admin")
            {
                AdminHome adminHome = new AdminHome();
                adminHome.Show();
                this.Hide();

            }
            else
            {
                SalesmanHome salesmanHome = new SalesmanHome();
                salesmanHome.Show();
                this.Hide();
            }
          
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

        private void updateButton_Click(object sender, EventArgs e)
        {
            ProductServices productServices = new ProductServices();
            int id = productServices.CheckProductId(Convert.ToInt32(UpdateTextBox));
           
            if(id == Convert.ToInt32(UpdateTextBox))
            {
                UpdateProduct updateProduct = new UpdateProduct(id,empType);
                updateProduct.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ProductId not found");
            }
        }

        private void updateTextBox_Click(object sender, EventArgs e)
        {
            updateTextBox.Text = null;
            if (removeTextBox.Text == "")
            {
                removeTextBox.Text = "Enter Product ID";
            }
            else if (sellTextBox.Text == "")
            {
                sellTextBox.Text = "Enter Product ID";
            }
        }

        private void removeTextBox_Click(object sender, EventArgs e)
        {
            removeTextBox.Text = null;
            if (updateTextBox.Text == "")
            {
                updateTextBox.Text = "Enter Product ID";
            }
            else if(sellTextBox.Text == "")
            {
                sellTextBox.Text = "Enter Product ID";
            }
        }

        private void updateTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void removeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void productGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sellTextBox_Click(object sender, EventArgs e)
        {
            sellTextBox.Text = null;
            if (removeTextBox.Text == "")
            {
                removeTextBox.Text = "Enter Product ID";
            }
            else if(updateTextBox.Text == "")
            {
                updateTextBox.Text = "Enter Product ID";
            }
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            ProductServices productServices = new ProductServices();
            int id = productServices.CheckProductId(Convert.ToInt32(SellTextBox));

            if(id==Convert.ToInt32(SellTextBox))
            {
                Product product = new Product();
                product = productServices.ReadProduct(id);
                productServices.RemoveProduct(id);


                Dictionary<string, string> dictionary = new Dictionary<string, string>();
                dictionary.Add("Capacity", product.Capacity);
                dictionary.Add("MemoryType", product.MemoryType);
                dictionary.Add("BusSpeed", product.BusSpeed);
                dictionary.Add("ScreenSize", product.ScreenSize);
                dictionary.Add("RefreshRate", product.RefreshRate);
                dictionary.Add("Wattage", product.Wattage);

                dictionary.Add("MotherBoardType", product.MotherBoardType);
                dictionary.Add("ClockSpeed", product.ClockSpeed);
                dictionary.Add("ConnectionType", product.ConnectionType);
                dictionary.Add("ResponseTime", product.ResponseTime);
                dictionary.Add("Picture", product.Picture);


                string now = DateTime.Now.ToString();
                

                SaleServices saleServices = new SaleServices();
                saleServices.SellProduct(product.ProductId, product.Category, product.Brand, product.Quantity, product.Price, product.Warranty, product.Desciption, dictionary, now, buyerNameTextBox.Text, buyerNoTextBox.Text, empName);
                
            }
            else
            {
                MessageBox.Show("Product not found");
            }
        }
    }
}
