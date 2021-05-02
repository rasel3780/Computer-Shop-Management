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
    public partial class EmployeeInformation : Form
    {
        public EmployeeInformation()
        {
            InitializeComponent();
            EmployeeServices employeeServices = new EmployeeServices();
            employeeDataGridView.DataSource = employeeServices.GetAllEmployees();
        }

        private void EmployeeInformation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            EmployeeServices employeeServices = new EmployeeServices();
            employeeDataGridView.DataSource = employeeServices.GetAllEmployees(); 
        }
    }
}
