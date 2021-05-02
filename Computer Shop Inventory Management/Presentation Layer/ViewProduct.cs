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
        private string empName;
        public ViewProduct(string empType,string empName)
        {
            InitializeComponent();
            this.empType = empType;
            this.empName = empName;
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
            try
            {
                if (ShowByIdTextBox != "")
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
                else
                {
                    MessageBox.Show("Enter Product Id");
                }
            }
            catch(Exception e6)
            {
                MessageBox.Show("Please Enter a Valid ID");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
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
            catch(Exception e5)
            {
                MessageBox.Show(e5.Message);
                MessageBox.Show("Enter Valid Product ID");
            }

            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if(empType=="Manager")
            {
                ManagerHome managerHome = new ManagerHome(empName);
                managerHome.Show();
                this.Hide();
            }
            else if(empType=="Admin")
            {
                AdminHome adminHome = new AdminHome(empName);
                adminHome.Show();
                this.Hide();

            }
            else
            {
                SalesmanHome salesmanHome = new SalesmanHome(empName);
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
            try
            {
                if (UpdateTextBox != "")
                {
                    ProductServices productServices = new ProductServices();
                    int id = productServices.CheckProductId(Convert.ToInt32(UpdateTextBox));

                    if (id == Convert.ToInt32(UpdateTextBox))
                    {
                        UpdateProduct updateProduct = new UpdateProduct(id, empType, empName);
                        updateProduct.Show();
                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("ProductId not found");
                    }
                }
                else
                {
                    MessageBox.Show("Enter Product id");
                }
            }
            catch(Exception e7)
            {
                MessageBox.Show("Enter a valid Product id");
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

            else if (quantityTextBox.Text == "")
            {
                quantityTextBox.Text = "Quantity";
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
            else if (quantityTextBox.Text == "")
            {
                quantityTextBox.Text = "Quantity";
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
            else if(buyerNameTextBox.Text == "")
            {
                buyerNameTextBox.Text = "Enter Buyer Name";
            }
            else if(phoneNoTextBox.Text == "")
            {
                phoneNoTextBox.Text = "Enter Phone No";
            }
            else if (quantityTextBox.Text == "")
            {
                quantityTextBox.Text = "Quantity";
            }
        }

        private void sellButton_Click(object sender, EventArgs e)
        {

            try
            {
                ProductServices productServices = new ProductServices();
                int id = productServices.CheckProductId(Convert.ToInt32(SellTextBox));

                if (id == Convert.ToInt32(SellTextBox))
                {
                    Product product = new Product();
                    product = productServices.ReadProduct(id);
                    int availableQuantity = product.Quantity - Convert.ToInt32(quantityTextBox.Text);
                    if (availableQuantity < 0)
                    {
                        MessageBox.Show("Product Quantity Not Available!!");
                    }
                    else
                    {
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

                        if (availableQuantity > 0)
                        {
                            productServices.UpdateProduct(Convert.ToInt32(SellTextBox), product.Category, product.Brand, availableQuantity, product.Price, product.Warranty, product.Desciption, dictionary);
                        }
                        else
                        {
                            productServices.RemoveProduct(id);
                        }

                        if (Convert.ToInt32(quantityTextBox.Text) <= 0)
                        {
                            MessageBox.Show("Quantity must be greater than zero");
                        }
                        else
                        {
                            string now = DateTime.Now.ToString();

                            float price = (Convert.ToSingle(product.Price)) * (Convert.ToSingle(quantityTextBox.Text));
                            SaleServices saleServices = new SaleServices();
                            int ans = saleServices.SellProduct(product.ProductId, product.Category, product.Brand, Convert.ToInt32(quantityTextBox.Text), price, product.Warranty, product.Desciption, dictionary, now, buyerNameTextBox.Text, phoneNoTextBox.Text, empName);
                            if (ans > 0)
                            {
                                MessageBox.Show("Product Sold Successfully..");
                                productGridView.DataSource = productServices.GetAllProducts();
                            }
                            else
                            {
                                MessageBox.Show("Can Not Sell the Product!!");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Out of Stock!!");
                }
            }
            catch(Exception e9)
            {
                MessageBox.Show("Enter Valid Information");
            }
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            ProductServices productServices = new ProductServices();
            productGridView.DataSource = productServices.GetAllProducts();
        }

        private void buyerNameTextBox_Click(object sender, EventArgs e)
        {
            buyerNameTextBox.Text = null;
            if (removeTextBox.Text == "")
            {
                removeTextBox.Text = "Enter Product ID";
            }
            else if (updateTextBox.Text == "")
            {
                updateTextBox.Text = "Enter Product ID";
            }
            else if (phoneNoTextBox.Text == "")
            {
                phoneNoTextBox.Text = "Enter Phone No";
            }
            else if (sellTextBox.Text == "")
            {
                sellTextBox.Text = "Enter Product ID";
            }
            else if (quantityTextBox.Text == "")
            {
                quantityTextBox.Text = "Quantity";
            }
        }

        private void phoneNoTextBox_Click(object sender, EventArgs e)
        {
            phoneNoTextBox.Text = null;
            
            if (removeTextBox.Text == "")
            {
                removeTextBox.Text = "Enter Product ID";
            }
            else if (updateTextBox.Text == "")
            {
                updateTextBox.Text = "Enter Product ID";
            }
            else if (sellTextBox.Text == "")
            {
                sellTextBox.Text = "Enter Product ID";
            }
            else if (buyerNameTextBox.Text == "")
            {
                buyerNameTextBox.Text = "Enter Buyer Name";
            }
            else if(quantityTextBox.Text == "")
            {
                quantityTextBox.Text = "Quantity";
            }
        }

        private void buyerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (buyerNameTextBox.Text == "")
            {

            }
        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantityTextBox_Click(object sender, EventArgs e)
        {
            quantityTextBox.Text = null;
            if (removeTextBox.Text == "")
            {
                removeTextBox.Text = "Enter Product ID";
            }
            else if (updateTextBox.Text == "")
            {
                updateTextBox.Text = "Enter Product ID";
            }
            else if (sellTextBox.Text == "")
            {
                sellTextBox.Text = "Enter Product ID";
            }
            else if (buyerNameTextBox.Text == "")
            {
                buyerNameTextBox.Text = "Enter Buyer Name";
            }
            else if (phoneNoTextBox.Text == "")
            {
                phoneNoTextBox.Text = "Enter Phone No";
            }
        }

        private void highToLowButton_Click(object sender, EventArgs e)
        {
            ProductServices productServices = new ProductServices();
            productGridView.DataSource = productServices.ALLProductSortByPriceHighToLow();
        }

        private void lowToHighButton_Click(object sender, EventArgs e)
        {
            ProductServices productServices = new ProductServices();
            productGridView.DataSource = productServices.ALLProductSortByPriceLowToHigh();
        }
    }
}
