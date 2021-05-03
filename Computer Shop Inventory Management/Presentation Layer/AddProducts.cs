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
        int check = 0;
        string picture = null;
        private string empType;
        private string empName;
        public AddProducts(string empType,string empName)
        {
            InitializeComponent();
            this.empType = empType;
            this.empName = empName;
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
                    if(s == "Capacity")
                    {
                        if(check == 0)
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
                        else if(check==2)
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
                    else if(s == "Memory Type")
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
                    else if(s == "Bus Speed")
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
                    else if(s == "Screen Size")
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
                    else if(s== "Refresh Rate")
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
                    else if(s=="Wattage")
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
                    else if(s=="Motherboard Type")
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
                    else if(s =="Clock Speed")
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
                    else if(s=="Connection Type")
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

        private void backButton_Click(object sender, EventArgs e)
        {
            if(empType == "Admin")
            {
                AdminHome admin = new AdminHome(empName);
                admin.Show();
                this.Hide();
            }
            else if(empType == "Manager")
            {
                ManagerHome manager = new ManagerHome(empName);
                manager.Show();
                this.Hide();
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureAddButton_Click(object sender, EventArgs e)
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

        private void addProductButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(" "+check);
            try
            {
                if(Convert.ToInt32(priceTextBox.Text)<0)
                {
                    MessageBox.Show("Please Enter a Valid Price!!");
                }

                else if(Convert.ToInt32(quantityTextBox.Text) < 0)
                {
                    MessageBox.Show("Quanity Can't be Negative!!");
                }
                else
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
                    int addChecking = productServices.AddProduct(Category, Brand, Convert.ToInt32(Quantity), Convert.ToSingle(Price), Warranty, Description, dictionary);

                    if (addChecking > 0)
                    {
                        MessageBox.Show("Product Added Successfully");

                        categoryComboBox.Text = null;
                        brandComboBox.Text = null;
                        priceTextBox.Text = "";
                        quantityTextBox.Text = "";
                        descriptionTextBox.Text = "";
                        featureGroupBox.Visible = false;
                        warrentyComboBox.Text = null;

                        for (int i = 0; i < 10; i++)
                        {
                            checkedListBox1.SetItemChecked(i, false);
                        }
                        pictureBox1.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Not Added...");
                    }
                }
                
            }

            catch(Exception e1)
            {
                MessageBox.Show("There is an empty field!! Please fill that up..");
            }


        }
    }
}
