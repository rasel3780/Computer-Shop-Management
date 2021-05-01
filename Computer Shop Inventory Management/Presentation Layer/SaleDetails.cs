﻿using Computer_Shop_Inventory_Management.Businees_Logic_Layer;
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
        string empType = null;
        public SaleDetails(string empType)
        {
            InitializeComponent();
            this.empType = empType;
            SaleServices saleServices = new SaleServices();
            saleGridView.DataSource = saleServices.GetAllSale();
        }

        private void SaleDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();


        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (empType == "Admin")
            {
                AdminHome admin = new AdminHome();
                admin.Show();
                this.Hide();
            }
            else
            {
                ManagerHome manager = new ManagerHome();
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
    }
}
