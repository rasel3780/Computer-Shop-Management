﻿using Computer_Shop_Inventory_Management.Businees_Logic_Layer;
using Computer_Shop_Inventory_Management.Presentation_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Shop_Inventory_Management
{
    public partial class AdminHome : Form
    {
        private string empName;
        public AdminHome(string empName)
        {
            InitializeComponent();
            this.empName = empName;
        }

        private void AdminHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration(empName);
            registration.Show();
            this.Hide();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            UpdateEmployee updateEmployee = new UpdateEmployee(empName);
            updateEmployee.Show();
            this.Hide();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            AddProducts addProducts = new AddProducts("Admin",empName);
            addProducts.Show();
            this.Hide();
        }

        private void viewProdcutButton_Click(object sender, EventArgs e)
        {
            ViewProduct viewProduct = new ViewProduct("Admin",empName);
            viewProduct.Show();
            this.Hide();
        }

        private void saleInfoButton_Click(object sender, EventArgs e)
        {
            SaleDetails sale = new SaleDetails("Admin",empName);
            sale.Show();
            this.Hide();
        }

        private void showAllEmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeeInformation employeeInformation = new EmployeeInformation("Admin",empName);
            employeeInformation.Show();
            this.Hide();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if(dailyRadioButton.Checked == true)
            {
                SaleServices saleServices = new SaleServices();
                int dailySell =  saleServices.DailySell();
                label3.Text = dailySell.ToString();
                label3.Visible = true;
            }
            else if(monthlyRadioButton.Checked == true)
            {
                SaleServices saleServices = new SaleServices();
                int monthlySell = saleServices.MonthlySell();
                label3.Text = monthlySell.ToString();
                label3.Visible = true;
            }
            else if(yearlyRadioButton.Checked == true)
            {
                SaleServices saleServices = new SaleServices();
                int yearlySell = saleServices.YearlySell();
                label3.Text = yearlySell.ToString();
                label3.Visible = true;
            }
            else if(totalSellRadioButton.Checked == true)
            {
                SaleServices saleServices = new SaleServices();
                int totalSell = saleServices.TotalSell();
                label3.Text = totalSell.ToString();
                label3.Visible = true;
            }
        }
    }
}
