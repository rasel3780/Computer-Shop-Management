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
        int check = 0;
        string picture = null;
        string empType;
        string empName;
        public UpdateProduct(int productId, string empType,string empName)
        {
            InitializeComponent();
            this.productId = productId;
            this.empType = empType;
            this.empName = empName;
            Product product = new Product();
            ProductServices productServices = new ProductServices();
            product = productServices.ReadProduct(productId);

            label1.Visible = false;
            comboBox1.Visible = false;

            label2.Visible = false;
            comboBox2.Visible = false;

            label3.Visible = false;
            comboBox3.Visible = false;

            label4.Visible = false;
            comboBox4.Visible = false;

            label5.Visible = false;
            comboBox5.Visible = false;

            ProductList productList = new ProductList();
            categoryComboBox.DataSource = productList.Category();
            brandComboBox.DataSource = productList.Brand();

            categoryComboBox.Text = product.Category;
            brandComboBox.Text = product.Brand;
            priceTextBox.Text = product.Price.ToString();
            quantityTextBox.Text = product.Quantity.ToString();
            warrentyComboBox.Text = product.Warranty;
            descriptionTextBox.Text = product.Desciption;

            //product image show in picture box
           string imageLoction = product.Picture;
            if (imageLoction != "")
            {
                Size size = pictureBox1.Size;
                size.Height = 200;
                size.Width = 200;
                pictureBox1.Size = size;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Image.FromFile(imageLoction);
            }

            
            //Show Feature
            int ok = 0;

            //capacity check
            if(product.Capacity != "")
            {
                checkedListBox1.SetItemChecked(0, true);
                if (ok == 0)
                {
                    comboBox1.DataSource = productList.Capacity();
                    label1.Visible = true;
                    comboBox1.Visible = true;
                    label1.Text = "Capacity";
                    comboBox1.Text = product.Capacity;
                }
                else if (ok == 1)
                {
                    comboBox2.DataSource = productList.Capacity();
                    label2.Visible = true;
                    comboBox2.Visible = true;
                    label2.Text = "Capacity";
                    comboBox2.Text = product.Capacity;
                }
                else if (ok == 2)
                {
                    comboBox3.DataSource = productList.Capacity();
                    label3.Visible = true;
                    comboBox3.Visible = true;
                    label3.Text = "Capacity";
                    comboBox3.Text = product.Capacity;
                }
                else if (ok == 3)
                {
                    comboBox4.DataSource = productList.Capacity();
                    label4.Visible = true;
                    comboBox4.Visible = true;
                    label4.Text = "Capacity";
                    comboBox4.Text = product.Capacity;
                }
                else if (ok == 4)
                {
                    comboBox5.DataSource = productList.Capacity();
                    label5.Visible = true;
                    comboBox5.Visible = true;
                    label5.Text = "Capacity";
                    comboBox5.Text = product.Capacity;
                }
                ok++;

            }

            //memory type check
            if (product.MemoryType != "")
            {
                checkedListBox1.SetItemChecked(1, true);
                if (ok == 0)
                {
                    comboBox1.DataSource = productList.MemoryType();
                    label1.Visible = true;
                    comboBox1.Visible = true;
                    label1.Text = "Memory Type";
                    comboBox1.Text = product.MemoryType;
                }
                else if (ok == 1)
                {
                    comboBox2.DataSource = productList.MemoryType();
                    label2.Visible = true;
                    comboBox2.Visible = true;
                    label2.Text = "Memory Type";
                    comboBox2.Text = product.MemoryType;
                }
                else if (ok == 2)
                {
                    comboBox3.DataSource = productList.MemoryType();
                    label3.Visible = true;
                    comboBox3.Visible = true;
                    label3.Text = "Memory Type";
                    comboBox3.Text = product.MemoryType;
                }
                else if (ok == 3)
                {
                    comboBox4.DataSource = productList.MemoryType();
                    label4.Visible = true;
                    comboBox4.Visible = true;
                    label4.Text = "Memory Type";
                    comboBox4.Text = product.MemoryType;
                }
                else if (ok == 4)
                {
                    comboBox5.DataSource = productList.MemoryType();
                    label5.Visible = true;
                    comboBox5.Visible = true;
                    label5.Text = "Memory Type";
                    comboBox5.Text = product.MemoryType;
                }
                ok++;
            }

            //Bus Speed check

            if (product.BusSpeed != "")
            {
                checkedListBox1.SetItemChecked(2, true);
                if (ok == 0)
                {
                    comboBox1.DataSource = productList.BusSpeed();
                    label1.Visible = true;
                    comboBox1.Visible = true;
                    label1.Text = "Bus Speed";
                    comboBox1.Text = product.BusSpeed;
                }
                else if (ok == 1)
                {
                    comboBox2.DataSource = productList.BusSpeed();
                    label2.Visible = true;
                    comboBox2.Visible = true;
                    label2.Text = "Bus Speed";
                    comboBox2.Text = product.BusSpeed;
                }
                else if (ok == 2)
                {
                    comboBox3.DataSource = productList.BusSpeed();
                    label3.Visible = true;
                    comboBox3.Visible = true;
                    label3.Text = "Bus Speed";
                    comboBox3.Text = product.BusSpeed;
                }
                else if (ok == 3)
                {
                    comboBox4.DataSource = productList.BusSpeed();
                    label4.Visible = true;
                    comboBox4.Visible = true;
                    label4.Text = "Bus Speed";
                    comboBox4.Text = product.BusSpeed;
                }
                else if (ok == 4)
                {
                    comboBox5.DataSource = productList.BusSpeed();
                    label5.Visible = true;
                    comboBox5.Visible = true;
                    label5.Text = "Bus Speed";
                    comboBox5.Text = product.BusSpeed;
                }
                ok++;
            }

            //Screen Size check

            if (product.ScreenSize != "")
            {
                checkedListBox1.SetItemChecked(3, true);
                if (ok == 0)
                {
                    comboBox1.DataSource = productList.ScreenSize();
                    label1.Visible = true;
                    comboBox1.Visible = true;
                    label1.Text = "Screen Size";
                    comboBox1.Text = product.ScreenSize;
                }
                else if (ok == 1)
                {
                    comboBox2.DataSource = productList.ScreenSize();
                    label2.Visible = true;
                    comboBox2.Visible = true;
                    label2.Text = "Screen Size";
                    comboBox2.Text = product.ScreenSize;
                }
                else if (ok == 2)
                {
                    comboBox3.DataSource = productList.ScreenSize();
                    label3.Visible = true;
                    comboBox3.Visible = true;
                    label3.Text = "Screen Size";
                    comboBox3.Text = product.ScreenSize;
                }
                else if (ok == 3)
                {
                    comboBox4.DataSource = productList.ScreenSize();
                    label4.Visible = true;
                    comboBox4.Visible = true;
                    label4.Text = "Screen Size";
                    comboBox4.Text = product.ScreenSize;
                }
                else if (ok == 4)
                {
                    comboBox5.DataSource = productList.ScreenSize();
                    label5.Visible = true;
                    comboBox5.Visible = true;
                    label5.Text = "Screen Size";
                    comboBox5.Text = product.ScreenSize;
                }
                ok++;
            }

            //Referesh Rate check

            if (product.RefreshRate != "")
            {
                checkedListBox1.SetItemChecked(4, true);
                if (ok == 0)
                {
                    comboBox1.DataSource = productList.RefreshRate();
                    label1.Visible = true;
                    comboBox1.Visible = true;
                    label1.Text = "Referesh Rate";
                    comboBox1.Text = product.RefreshRate;
                }
                else if (ok == 1)
                {
                    comboBox2.DataSource = productList.RefreshRate();
                    label2.Visible = true;
                    comboBox2.Visible = true;
                    label2.Text = "Referesh Rate";
                    comboBox2.Text = product.RefreshRate;
                }
                else if (ok == 2)
                {
                    comboBox3.DataSource = productList.RefreshRate();
                    label3.Visible = true;
                    comboBox3.Visible = true;
                    label3.Text = "Referesh Rate";
                    comboBox3.Text = product.RefreshRate;
                }
                else if (ok == 3)
                {
                    comboBox4.DataSource = productList.RefreshRate();
                    label4.Visible = true;
                    comboBox4.Visible = true;
                    label4.Text = "Referesh Rate";
                    comboBox4.Text = product.RefreshRate;
                }
                else if (ok == 4)
                {
                    comboBox5.DataSource = productList.RefreshRate();
                    label5.Visible = true;
                    comboBox5.Visible = true;
                    label5.Text = "Referesh Rate";
                    comboBox5.Text = product.RefreshRate;
                }
                ok++;
            }

            //Wattage check

            if (product.Wattage != "")
            {
                checkedListBox1.SetItemChecked(5, true);
                if (ok == 0)
                {
                    comboBox1.DataSource = productList.Wattage();
                    label1.Visible = true;
                    comboBox1.Visible = true;
                    label1.Text = "Wattage";
                    comboBox1.Text = product.Wattage;
                }
                else if (ok == 1)
                {
                    comboBox2.DataSource = productList.Wattage();
                    label2.Visible = true;
                    comboBox2.Visible = true;
                    label2.Text = "Wattage";
                    comboBox2.Text = product.Wattage;
                }
                else if (ok == 2)
                {
                    comboBox3.DataSource = productList.Wattage();
                    label3.Visible = true;
                    comboBox3.Visible = true;
                    label3.Text = "Wattage";
                    comboBox3.Text = product.Wattage;
                }
                else if (ok == 3)
                {
                    label4.Visible = true;
                    comboBox4.Visible = true;
                    label4.Text = "Wattage";
                    comboBox4.Text = product.Wattage;
                }
                else if (ok == 4)
                {
                    comboBox5.DataSource = productList.Wattage();
                    label5.Visible = true;
                    comboBox5.Visible = true;
                    label5.Text = "Wattage";
                    comboBox5.Text = product.Wattage;
                }
                ok++;
            }

            //Motherboard Type check

            if (product.MotherBoardType != "")
            {
                checkedListBox1.SetItemChecked(6, true);
                if (ok == 0)
                {
                    comboBox1.DataSource = productList.MotherBoardType();
                    label1.Visible = true;
                    comboBox1.Visible = true;
                    label1.Text = "Motherboard Type";
                    comboBox1.Text = product.MotherBoardType;
                }
                else if (ok == 1)
                {
                    comboBox2.DataSource = productList.MotherBoardType();
                    label2.Visible = true;
                    comboBox2.Visible = true;
                    label2.Text = "Motherboard Type";
                    comboBox2.Text = product.MotherBoardType;
                }
                else if (ok == 2)
                {
                    comboBox3.DataSource = productList.MotherBoardType();
                    label3.Visible = true;
                    comboBox3.Visible = true;
                    label3.Text = "Motherboard Type";
                    comboBox3.Text = product.MotherBoardType;
                }
                else if (ok == 3)
                {
                    comboBox4.DataSource = productList.MotherBoardType();
                    label4.Visible = true;
                    comboBox4.Visible = true;
                    label4.Text = "Motherboard Type";
                    comboBox4.Text = product.MotherBoardType;
                }
                else if (ok == 4)
                {
                    comboBox5.DataSource = productList.MotherBoardType();
                    label5.Visible = true;
                    comboBox5.Visible = true;
                    label5.Text = "Motherboard Type";
                    comboBox5.Text = product.MotherBoardType;
                }
                ok++;
            }

            //Clock Speed check

            if (product.ClockSpeed != "")
            {
                checkedListBox1.SetItemChecked(7, true);
                if (ok == 0)
                {
                    comboBox1.DataSource = productList.ClockSpeed();
                    label1.Visible = true;
                    comboBox1.Visible = true;
                    label1.Text = "Clock Speed";
                    comboBox1.Text = product.ClockSpeed;
                }
                else if (ok == 1)
                {
                    comboBox2.DataSource = productList.ClockSpeed();
                    label2.Visible = true;
                    comboBox2.Visible = true;
                    label2.Text = "Clock Speed";
                    comboBox2.Text = product.ClockSpeed;
                }
                else if (ok == 2)
                {
                    comboBox3.DataSource = productList.ClockSpeed();
                    label3.Visible = true;
                    comboBox3.Visible = true;
                    label3.Text = "Clock Speed";
                    comboBox3.Text = product.ClockSpeed;
                }
                else if (ok == 3)
                {
                    comboBox4.DataSource = productList.ClockSpeed();
                    label4.Visible = true;
                    comboBox4.Visible = true;
                    label4.Text = "Clock Speed";
                    comboBox4.Text = product.ClockSpeed;
                }
                else if (ok == 4)
                {
                    comboBox5.DataSource = productList.ClockSpeed();
                    label5.Visible = true;
                    comboBox5.Visible = true;
                    label5.Text = "Clock Speed";
                    comboBox5.Text = product.ClockSpeed;
                }
                ok++;
            }


            //Connection Type check

            if (product.ConnectionType != "")
            {
                checkedListBox1.SetItemChecked(8, true);
                if (ok == 0)
                {
                    comboBox1.DataSource = productList.ConnectionType();
                    label1.Visible = true;
                    comboBox1.Visible = true;
                    label1.Text = "Connection Type";
                    comboBox1.Text = product.ConnectionType;
                }
                else if (ok == 1)
                {
                    comboBox2.DataSource = productList.ConnectionType();
                    label2.Visible = true;
                    comboBox2.Visible = true;
                    label2.Text = "Connection Type";
                    comboBox2.Text = product.ConnectionType;
                }
                else if (ok == 2)
                {
                    comboBox3.DataSource = productList.ConnectionType();
                    label3.Visible = true;
                    comboBox3.Visible = true;
                    label3.Text = "Connection Type";
                    comboBox3.Text = product.ConnectionType;
                }
                else if (ok == 3)
                {
                    comboBox4.DataSource = productList.ConnectionType();
                    label4.Visible = true;
                    comboBox4.Visible = true;
                    label4.Text = "Connection Type";
                    comboBox4.Text = product.ConnectionType;
                }
                else if (ok == 4)
                {
                    comboBox5.DataSource = productList.ConnectionType();
                    label5.Visible = true;
                    comboBox5.Visible = true;
                    label5.Text = "Connection Type";
                    comboBox5.Text = product.ConnectionType;
                }
                ok++;
            }

            //Response Time check

            if (product.ResponseTime != "")
            {
                checkedListBox1.SetItemChecked(9, true);
                if (ok == 0)
                {
                    comboBox1.DataSource = productList.ResponseTime();
                    label1.Visible = true;
                    comboBox1.Visible = true;
                    label1.Text = "Response Time";
                    comboBox1.Text = product.ResponseTime;
                }
                else if (ok == 1)
                {
                    comboBox2.DataSource = productList.ResponseTime();
                    label2.Visible = true;
                    comboBox2.Visible = true;
                    label2.Text = "Response Time";
                    comboBox2.Text = product.ResponseTime;
                }
                else if (ok == 2)
                {
                    comboBox3.DataSource = productList.ResponseTime();
                    label3.Visible = true;
                    comboBox3.Visible = true;
                    label3.Text = "Response Time";
                    comboBox3.DataSource = product.ResponseTime;
                }
                else if (ok == 3)
                {
                    comboBox4.DataSource = productList.ResponseTime();
                    label4.Visible = true;
                    comboBox4.Visible = true;
                    label4.Text = "Response Time";
                    comboBox4.Text = product.ResponseTime;
                }
                else if (ok == 4)
                {
                    comboBox5.DataSource = productList.ResponseTime();
                    label5.Visible = true;
                    comboBox5.Visible = true;
                    label5.Text = "Response Time";
                    comboBox5.Text = product.ResponseTime;
                }
                ok++;
            }
            check = ok;
        }

        private void UpdateProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if(empType== "Admin")
            {
                ViewProduct viewProduct = new ViewProduct("Admin",empName);
                viewProduct.Show();
                this.Hide();
            }
            else if(empType == "Manager")
            {
                ViewProduct viewProduct = new ViewProduct("Manager",empName);
                viewProduct.Show();
                this.Hide();
            }            
        }

        private void updateProductButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            for (int i = 0; i < check; i++)
            {
                if (i == 0) dictionary.Add(Label1, ComboBox1);
                if (i == 1) dictionary.Add(Label2, ComboBox2);
                if (i == 2) dictionary.Add(Label3, ComboBox3);
                if (i == 3) dictionary.Add(Label4, ComboBox4);
                if (i == 4) dictionary.Add(Label5, ComboBox5);
            }

            if (picture != null) dictionary.Add("Picture", picture);
            ProductServices productServices = new ProductServices();
            int ans =productServices.UpdateProduct(productId,Category, Brand, Convert.ToInt32(Quantity), Convert.ToSingle(Price), Warranty, Description, dictionary);
            
            if(ans>0)
            {
                MessageBox.Show("Updated....");
            }
            else
            {
                MessageBox.Show("Error...");
            }
        
        }

        private void pictureUpdateButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files(*.jpg; *.jpeg; *.png; .bmp)|.jpg; *.jpeg; *.png; *.bmp";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                picture = openFile.FileName;
                Size size = pictureBox1.Size;
                size.Height = 200;
                size.Width = 200;
                pictureBox1.Size = size;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Image.FromFile(picture);
            }
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            check = 0;
            label1.Visible = false;
            comboBox1.Visible = false;

            label2.Visible = false;
            comboBox2.Visible = false;

            label3.Visible = false;
            comboBox3.Visible = false;

            label4.Visible = false;
            comboBox4.Visible = false;

            label5.Visible = false;
            comboBox5.Visible = false;

            ProductList productList = new ProductList();
            for (int i = 0; i <= (checkedListBox1.Items.Count - 1); i++)
            {
                featureGroupBox.Visible = true;
                if (checkedListBox1.GetItemChecked(i))
                {
                    string s = checkedListBox1.Items[i].ToString();
                    if (s == "Capacity")
                    {
                        if (check == 0)
                        {
                            label1.Visible = true;
                            comboBox1.Visible = true;
                            label1.Text = s;
                            comboBox1.DataSource = productList.Capacity();
                        }
                        else if (check == 1)
                        {
                            label2.Visible = true;
                            comboBox2.Visible = true;
                            label2.Text = s;
                            comboBox2.DataSource = productList.Capacity();
                        }
                        else if (check == 2)
                        {
                            label3.Visible = true;
                            comboBox3.Visible = true;
                            label3.Text = s;
                            comboBox3.DataSource = productList.Capacity();
                        }
                        else if (check == 3)
                        {
                            label4.Visible = true;
                            comboBox4.Visible = true;
                            label4.Text = s;
                            comboBox4.DataSource = productList.Capacity();
                        }
                        else if (check == 4)
                        {
                            label5.Visible = true;
                            comboBox5.Visible = true;
                            label5.Text = s;
                            comboBox5.DataSource = productList.Capacity();
                        }
                        check++;
                    }
                    else if (s == "Memory Type")
                    {
                        if (check == 0)
                        {
                            label1.Visible = true;
                            comboBox1.Visible = true;
                            label1.Text = s;
                            comboBox1.DataSource = productList.MemoryType();
                        }
                        else if (check == 1)
                        {
                            label2.Visible = true;
                            comboBox2.Visible = true;
                            label2.Text = s;
                            comboBox2.DataSource = productList.MemoryType();
                        }
                        else if (check == 2)
                        {
                            label3.Visible = true;
                            comboBox3.Visible = true;
                            label3.Text = s;
                            comboBox3.DataSource = productList.MemoryType();
                        }
                        else if (check == 3)
                        {
                            label4.Visible = true;
                            comboBox4.Visible = true;
                            label4.Text = s;
                            comboBox4.DataSource = productList.MemoryType();
                        }
                        else if (check == 4)
                        {
                            label5.Visible = true;
                            comboBox5.Visible = true;
                            label5.Text = s;
                            comboBox5.DataSource = productList.MemoryType();
                        }
                        check++;
                    }
                    else if (s == "Bus Speed")
                    {
                        if (check == 0)
                        {
                            label1.Visible = true;
                            comboBox1.Visible = true;
                            label1.Text = s;
                            comboBox1.DataSource = productList.BusSpeed();
                        }
                        else if (check == 1)
                        {
                            label2.Visible = true;
                            comboBox2.Visible = true;
                            label2.Text = s;
                            comboBox2.DataSource = productList.BusSpeed();
                        }
                        else if (check == 2)
                        {
                            label3.Visible = true;
                            comboBox3.Visible = true;
                            label3.Text = s;
                            comboBox3.DataSource = productList.BusSpeed();
                        }
                        else if (check == 3)
                        {
                            label4.Visible = true;
                            comboBox4.Visible = true;
                            label4.Text = s;
                            comboBox4.DataSource = productList.BusSpeed();
                        }
                        else if (check == 4)
                        {
                            label5.Visible = true;
                            comboBox5.Visible = true;
                            label5.Text = s;
                            comboBox5.DataSource = productList.BusSpeed();
                        }
                        check++;
                    }
                    else if (s == "Screen Size")
                    {
                        if (check == 0)
                        {
                            label1.Visible = true;
                            comboBox1.Visible = true;
                            label1.Text = s;
                            comboBox1.DataSource = productList.ScreenSize();
                        }
                        else if (check == 1)
                        {
                            label2.Visible = true;
                            comboBox2.Visible = true;
                            label2.Text = s;
                            comboBox2.DataSource = productList.ScreenSize();
                        }
                        else if (check == 2)
                        {
                            label3.Visible = true;
                            comboBox3.Visible = true;
                            label3.Text = s;
                            comboBox3.DataSource = productList.ScreenSize();
                        }
                        else if (check == 3)
                        {
                            label4.Visible = true;
                            comboBox4.Visible = true;
                            label4.Text = s;
                            comboBox4.DataSource = productList.ScreenSize();
                        }
                        else if (check == 4)
                        {
                            label5.Visible = true;
                            comboBox5.Visible = true;
                            label5.Text = s;
                            comboBox5.DataSource = productList.ScreenSize();
                        }
                        check++;
                    }
                    else if (s == "Refresh Rate")
                    {
                        if (check == 0)
                        {
                            label1.Visible = true;
                            comboBox1.Visible = true;
                            label1.Text = s;
                            comboBox1.DataSource = productList.RefreshRate();
                        }
                        else if (check == 1)
                        {
                            label2.Visible = true;
                            comboBox2.Visible = true;
                            label2.Text = s;
                            comboBox2.DataSource = productList.RefreshRate();
                        }
                        else if (check == 2)
                        {
                            label3.Visible = true;
                            comboBox3.Visible = true;
                            label3.Text = s;
                            comboBox3.DataSource = productList.RefreshRate();
                        }
                        else if (check == 3)
                        {
                            label4.Visible = true;
                            comboBox4.Visible = true;
                            label4.Text = s;
                            comboBox4.DataSource = productList.RefreshRate();
                        }
                        else if (check == 4)
                        {
                            label5.Visible = true;
                            comboBox5.Visible = true;
                            label5.Text = s;
                            comboBox5.DataSource = productList.RefreshRate();
                        }
                        check++;
                    }
                    else if (s == "Wattage")
                    {
                        if (check == 0)
                        {
                            label1.Visible = true;
                            comboBox1.Visible = true;
                            label1.Text = s;
                            comboBox1.DataSource = productList.Wattage();
                        }
                        else if (check == 1)
                        {
                            label2.Visible = true;
                            comboBox2.Visible = true;
                            label2.Text = s;
                            comboBox2.DataSource = productList.Wattage();
                        }
                        else if (check == 2)
                        {
                            label3.Visible = true;
                            comboBox3.Visible = true;
                            label3.Text = s;
                            comboBox3.DataSource = productList.Wattage();
                        }
                        else if (check == 3)
                        {
                            label4.Visible = true;
                            comboBox4.Visible = true;
                            label4.Text = s;
                            comboBox4.DataSource = productList.Wattage();
                        }
                        else if (check == 4)
                        {
                            label5.Visible = true;
                            comboBox5.Visible = true;
                            label5.Text = s;
                            comboBox5.DataSource = productList.Wattage();
                        }
                        check++;
                    }
                    else if (s == "Motherboard Type")
                    {
                        if (check == 0)
                        {
                            label1.Visible = true;
                            comboBox1.Visible = true;
                            label1.Text = s;
                            comboBox1.DataSource = productList.MotherBoardType();
                        }
                        else if (check == 1)
                        {
                            label2.Visible = true;
                            comboBox2.Visible = true;
                            label2.Text = s;
                            comboBox2.DataSource = productList.MotherBoardType();
                        }
                        else if (check == 2)
                        {
                            label3.Visible = true;
                            comboBox3.Visible = true;
                            label3.Text = s;
                            comboBox3.DataSource = productList.MotherBoardType();
                        }
                        else if (check == 3)
                        {
                            label4.Visible = true;
                            comboBox4.Visible = true;
                            label4.Text = s;
                            comboBox4.DataSource = productList.MotherBoardType();
                        }
                        else if (check == 4)
                        {
                            label5.Visible = true;
                            comboBox5.Visible = true;
                            label5.Text = s;
                            comboBox5.DataSource = productList.MotherBoardType();
                        }
                        check++;
                    }
                    else if (s == "Clock Speed")
                    {
                        if (check == 0)
                        {
                            label1.Visible = true;
                            comboBox1.Visible = true;
                            label1.Text = s;
                            comboBox1.DataSource = productList.ClockSpeed();
                        }
                        else if (check == 1)
                        {
                            label2.Visible = true;
                            comboBox2.Visible = true;
                            label2.Text = s;
                            comboBox2.DataSource = productList.ClockSpeed();
                        }
                        else if (check == 2)
                        {
                            label3.Visible = true;
                            comboBox3.Visible = true;
                            label3.Text = s;
                            comboBox3.DataSource = productList.ClockSpeed();
                        }
                        else if (check == 3)
                        {
                            label4.Visible = true;
                            comboBox4.Visible = true;
                            label4.Text = s;
                            comboBox4.DataSource = productList.ClockSpeed();
                        }
                        else if (check == 4)
                        {
                            label5.Visible = true;
                            comboBox5.Visible = true;
                            label5.Text = s;
                            comboBox5.DataSource = productList.ClockSpeed();
                        }
                        check++;
                    }
                    else if (s == "Connection Type")
                    {
                        if (check == 0)
                        {
                            label1.Visible = true;
                            comboBox1.Visible = true;
                            label1.Text = s;
                            comboBox1.DataSource = productList.ConnectionType();
                        }
                        else if (check == 1)
                        {
                            label2.Visible = true;
                            comboBox2.Visible = true;
                            label2.Text = s;
                            comboBox2.DataSource = productList.ConnectionType();
                        }
                        else if (check == 2)
                        {
                            label3.Visible = true;
                            comboBox3.Visible = true;
                            label3.Text = s;
                            comboBox3.DataSource = productList.ConnectionType();
                        }
                        else if (check == 3)
                        {
                            label4.Visible = true;
                            comboBox4.Visible = true;
                            label4.Text = s;
                            comboBox4.DataSource = productList.ConnectionType();
                        }
                        else if (check == 4)
                        {
                            label5.Visible = true;
                            comboBox5.Visible = true;
                            label5.Text = s;
                            comboBox5.DataSource = productList.ConnectionType();
                        }
                        check++;
                    }
                    else if (s == "Response Time")
                    {
                        if (check == 0)
                        {
                            label1.Visible = true;
                            comboBox1.Visible = true;
                            label1.Text = s;
                            comboBox1.DataSource = productList.ResponseTime();
                        }
                        else if (check == 1)
                        {
                            label2.Visible = true;
                            comboBox2.Visible = true;
                            label2.Text = s;
                            comboBox2.DataSource = productList.ResponseTime();
                        }
                        else if (check == 2)
                        {
                            label3.Visible = true;
                            comboBox3.Visible = true;
                            label3.Text = s;
                            comboBox3.DataSource = productList.ResponseTime();
                        }
                        else if (check == 3)
                        {
                            label4.Visible = true;
                            comboBox4.Visible = true;
                            label4.Text = s;
                            comboBox4.DataSource = productList.ResponseTime();
                        }
                        else if (check == 4)
                        {
                            label5.Visible = true;
                            comboBox5.Visible = true;
                            label5.Text = s;
                            comboBox5.DataSource = productList.ResponseTime();
                        }
                        check++;
                    }
                }
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
