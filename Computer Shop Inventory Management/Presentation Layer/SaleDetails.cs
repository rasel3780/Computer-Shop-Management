﻿using System;
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
        public SaleDetails()
        {
            InitializeComponent();
        }

        private void SaleDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();


        }
    }
}
