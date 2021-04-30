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
            brandComboBox.DataSource = productList.Brand();
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

        private void selectButton_Click(object sender, EventArgs e)
        {
            int check = 0;
            ProductList productList = new ProductList();
            for (int i = 0; i <= (checkedListBox1.Items.Count - 1); i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    string s = checkedListBox1.Items[i].ToString();
                    if(s == "Capacity")
                    {
                        if(check == 0)
                        {
                            label1.Text = s;
                            comboBox1.DataSource = productList.Capacity();
                        }
                        else if (check == 1)
                        {
                            label2.Text = s;
                            comboBox2.DataSource = productList.Capacity();
                        }
                        else if(check==2)
                        {
                            label3.Text = s;
                            comboBox3.DataSource = productList.Capacity();
                        }
                        else if (check == 3)
                        {
                            label4.Text = s;
                            comboBox4.DataSource = productList.Capacity();
                        }
                        else if (check == 4)
                        {
                            label5.Text = s;
                            comboBox5.DataSource = productList.Capacity();
                        }
                        check++;
                    }
                    else if(s == "Memory Type")
                    {
                        if (check == 0)
                        {
                            label1.Text = s;
                            comboBox1.DataSource = productList.Capacity();
                        }
                        else if (check == 1)
                        {
                            label2.Text = s;
                            comboBox2.DataSource = productList.Capacity();
                        }
                        else if (check == 2)
                        {
                            label3.Text = s;
                            comboBox3.DataSource = productList.Capacity();
                        }
                        else if (check == 3)
                        {
                            label4.Text = s;
                            comboBox4.DataSource = productList.Capacity();
                        }
                        else if (check == 4)
                        {
                            label5.Text = s;
                            comboBox5.DataSource = productList.Capacity();
                        }
                        check++;
                    }
                    else if(s == "Bus Speed")
                    {
                        if (check == 0)
                        {
                            label1.Text = s;
                            comboBox1.DataSource = productList.Capacity();
                        }
                        else if (check == 1)
                        {
                            label2.Text = s;
                            comboBox2.DataSource = productList.Capacity();
                        }
                        else if (check == 2)
                        {
                            label3.Text = s;
                            comboBox3.DataSource = productList.Capacity();
                        }
                        else if (check == 3)
                        {
                            label4.Text = s;
                            comboBox4.DataSource = productList.Capacity();
                        }
                        else if (check == 4)
                        {
                            label5.Text = s;
                            comboBox5.DataSource = productList.Capacity();
                        }
                        check++;
                    }
                    else if(s == "Screen Size")
                    {
                        if (check == 0)
                        {
                            label1.Text = s;
                            comboBox1.DataSource = productList.Capacity();
                        }
                        else if (check == 1)
                        {
                            label2.Text = s;
                            comboBox2.DataSource = productList.Capacity();
                        }
                        else if (check == 2)
                        {
                            label3.Text = s;
                            comboBox3.DataSource = productList.Capacity();
                        }
                        else if (check == 3)
                        {
                            label4.Text = s;
                            comboBox4.DataSource = productList.Capacity();
                        }
                        else if (check == 4)
                        {
                            label5.Text = s;
                            comboBox5.DataSource = productList.Capacity();
                        }
                        check++;
                    }
                    else if(s== "Refresh Rate")
                    {
                        if (check == 0)
                        {
                            label1.Text = s;
                            comboBox1.DataSource = productList.Capacity();
                        }
                        else if (check == 1)
                        {
                            label2.Text = s;
                            comboBox2.DataSource = productList.Capacity();
                        }
                        else if (check == 2)
                        {
                            label3.Text = s;
                            comboBox3.DataSource = productList.Capacity();
                        }
                        else if (check == 3)
                        {
                            label4.Text = s;
                            comboBox4.DataSource = productList.Capacity();
                        }
                        else if (check == 4)
                        {
                            label5.Text = s;
                            comboBox5.DataSource = productList.Capacity();
                        }
                        check++;
                    }
                    else if(s=="Wattage")
                    {
                        if (check == 0)
                        {
                            label1.Text = s;
                            comboBox1.DataSource = productList.Capacity();
                        }
                        else if (check == 1)
                        {
                            label2.Text = s;
                            comboBox2.DataSource = productList.Capacity();
                        }
                        else if (check == 2)
                        {
                            label3.Text = s;
                            comboBox3.DataSource = productList.Capacity();
                        }
                        else if (check == 3)
                        {
                            label4.Text = s;
                            comboBox4.DataSource = productList.Capacity();
                        }
                        else if (check == 4)
                        {
                            label5.Text = s;
                            comboBox5.DataSource = productList.Capacity();
                        }
                        check++;
                    }
                    else if(s=="Motherboard Type")
                    {
                        if (check == 0)
                        {
                            label1.Text = s;
                            comboBox1.DataSource = productList.Capacity();
                        }
                        else if (check == 1)
                        {
                            label2.Text = s;
                            comboBox2.DataSource = productList.Capacity();
                        }
                        else if (check == 2)
                        {
                            label3.Text = s;
                            comboBox3.DataSource = productList.Capacity();
                        }
                        else if (check == 3)
                        {
                            label4.Text = s;
                            comboBox4.DataSource = productList.Capacity();
                        }
                        else if (check == 4)
                        {
                            label5.Text = s;
                            comboBox5.DataSource = productList.Capacity();
                        }
                        check++;
                    }
                    else if(s =="Clock Speed")
                    {
                        if (check == 0)
                        {
                            label1.Text = s;
                            comboBox1.DataSource = productList.Capacity();
                        }
                        else if (check == 1)
                        {
                            label2.Text = s;
                            comboBox2.DataSource = productList.Capacity();
                        }
                        else if (check == 2)
                        {
                            label3.Text = s;
                            comboBox3.DataSource = productList.Capacity();
                        }
                        else if (check == 3)
                        {
                            label4.Text = s;
                            comboBox4.DataSource = productList.Capacity();
                        }
                        else if (check == 4)
                        {
                            label5.Text = s;
                            comboBox5.DataSource = productList.Capacity();
                        }
                        check++;
                    }
                    else if(s=="Connection Type")
                    {
                        if (check == 0)
                        {
                            label1.Text = s;
                            comboBox1.DataSource = productList.Capacity();
                        }
                        else if (check == 1)
                        {
                            label2.Text = s;
                            comboBox2.DataSource = productList.Capacity();
                        }
                        else if (check == 2)
                        {
                            label3.Text = s;
                            comboBox3.DataSource = productList.Capacity();
                        }
                        else if (check == 3)
                        {
                            label4.Text = s;
                            comboBox4.DataSource = productList.Capacity();
                        }
                        else if (check == 4)
                        {
                            label5.Text = s;
                            comboBox5.DataSource = productList.Capacity();
                        }
                        check++;
                    }
                }
            }



        }
    }
}
