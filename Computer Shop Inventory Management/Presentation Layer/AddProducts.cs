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
    public partial class AddProducts : Form
    {
        public AddProducts()
        {
            InitializeComponent();
            ProductList productList = new ProductList();
            categoryComboBox.DataSource = productList.Category();
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addProductGroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddProducts_Load(object sender, EventArgs e)
        {

        }

        private void AddProducts_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}
