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
