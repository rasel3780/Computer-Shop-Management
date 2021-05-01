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
    public partial class UpdateProduct : Form
    {
        private int productId;
        public UpdateProduct(int productId)
        {
            InitializeComponent();
            this.productId = productId;
            Product product = new Product();
            ProductServices productServices = new ProductServices();
            product = productServices.ReadProduct(productId);

            categoryComboBox.Text = product.Category;
            brandComboBox.Text = product.Brand;
            priceTextBox.Text = product.Price.ToString();
            quantityTextBox.Text = product.Quantity.ToString();
            warrentyComboBox.Text = product.Warranty;
            descriptionTextBox.Text = product.Desciption;

            //product image show in picture box
            string imageLoction = product.Picture;
            Size size = pictureBox1.Size;
            size.Height = 200;
            size.Width = 200;
            pictureBox1.Size = size;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile(imageLoction);
        }

        private void UpdateProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ViewProduct viewProduct = new ViewProduct();
            viewProduct.Show();
            this.Hide();
        }

        private void updateProductButton_Click(object sender, EventArgs e)
        {

        }
    }
}
