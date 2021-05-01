using Computer_Shop_Inventory_Management.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Shop_Inventory_Management.Data_Access_Layer
{
    class ProductDataAccess:DataAccess
    {
        public int AddProduct(Product product)
        {
            string sql = "INSERT INTO Products(Category,Brand,Quantity,Price,Warranty,Capacity,MemoryType,BusSpeed,ScreenSize,RefreshRate,Wattage,MotherBoardType,ClockSpeed,ConnectionType,ResponseTime,Picture,Desciption) VALUES('" + product.Category + "','" + product.Brand + "','" + product.Quantity + "','" + product.Price + "','" + product.Warranty + "','" + product.Capacity + "','" + product.MemoryType + "','" + product.BusSpeed + "','" + product.ScreenSize + "' ,'" + product.RefreshRate + "','" + product.Wattage + "','" + product.MotherBoardType + "','" + product.ClockSpeed + "','" + product.ConnectionType + "','" + product.ResponseTime + "','" + product.Picture + "','" + product.Desciption + "')";
            return this.ExecuteQuery(sql);
        }

        public List<Product> GetAllProducts()
        {
            string sql = "SELECT * FROM Products";
            SqlDataReader reader = this.GetData(sql);
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product();
                product.ProductId = Convert.ToInt32(reader["ProductId"]);
                product.Category = reader["Category"].ToString();
                product.Brand = reader["Brand"].ToString();
                product.Quantity = Convert.ToInt32(reader["Quantity"]);
                product.Price = Convert.ToSingle(reader["Price"]);
                product.Warranty = reader["Warranty"].ToString();
                product.Capacity = reader["Capacity"].ToString();
                product.MemoryType = reader["MemoryType"].ToString();
                product.BusSpeed = reader["BusSpeed"].ToString();
                product.ScreenSize = reader["ScreenSize"].ToString();
                product.RefreshRate = reader["RefreshRate"].ToString();
                product.Wattage = reader["Wattage"].ToString();
                product.MotherBoardType = reader["MotherBoardType"].ToString();
                product.ClockSpeed = reader["ClockSpeed"].ToString();
                product.ConnectionType = reader["ConnectionType"].ToString();
                product.ResponseTime = reader["ResponseTime"].ToString();
                product.Picture = reader["Picture"].ToString();
                product.Desciption = reader["Desciption"].ToString();
                products.Add(product);
            }
            return products;
        }
        public int CheckProductId(Product product)
        {
            string query = "SELECT * FROM Products WHERE ProductId= '" + product.ProductId + "'";
            SqlDataReader reader = GetData(query);
            if (reader.Read())
            {
                return Convert.ToInt32(reader["ProductId"]);
            }
            else
            {
                return -1;
            }
        }

        public Product GetProductById(int productId)
        {
            string sql = "SELECT * FROM Products WHERE ProductId = '"+productId+"'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                Product product = new Product();
                product.ProductId = Convert.ToInt32(reader["ProductId"]);
                product.Category = reader["Category"].ToString();
                product.Brand = reader["Brand"].ToString();
                product.Quantity = Convert.ToInt32(reader["Quantity"]);
                product.Price = Convert.ToSingle(reader["Price"]);
                product.Warranty = reader["Warranty"].ToString();
                product.Capacity = reader["Capacity"].ToString();
                product.MemoryType = reader["MemoryType"].ToString();
                product.BusSpeed = reader["BusSpeed"].ToString();
                product.ScreenSize = reader["ScreenSize"].ToString();
                product.RefreshRate = reader["RefreshRate"].ToString();
                product.Wattage = reader["Wattage"].ToString();
                product.MotherBoardType = reader["MotherBoardType"].ToString();
                product.ClockSpeed = reader["ClockSpeed"].ToString();
                product.ConnectionType = reader["ConnectionType"].ToString();
                product.ResponseTime = reader["ResponseTime"].ToString();
                product.Picture = reader["Picture"].ToString();
                product.Desciption = reader["Desciption"].ToString();
                return product;
            }
            else return null;
        }

        public List<Product> GetProductsByCategory(string category)
        {
            string sql = "SELECT * FROM Products Where Category = '"+category+"'";
            SqlDataReader reader = this.GetData(sql);
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product();
                product.ProductId = Convert.ToInt32(reader["ProductId"]);
                product.Category = reader["Category"].ToString();
                product.Brand = reader["Brand"].ToString();
                product.Quantity = Convert.ToInt32(reader["Quantity"]);
                product.Price = Convert.ToSingle(reader["Price"]);
                product.Warranty = reader["Warranty"].ToString();
                product.Capacity = reader["Capacity"].ToString();
                product.MemoryType = reader["MemoryType"].ToString();
                product.BusSpeed = reader["BusSpeed"].ToString();
                product.ScreenSize = reader["ScreenSize"].ToString();
                product.RefreshRate = reader["RefreshRate"].ToString();
                product.Wattage = reader["Wattage"].ToString();
                product.MotherBoardType = reader["MotherBoardType"].ToString();
                product.ClockSpeed = reader["ClockSpeed"].ToString();
                product.ConnectionType = reader["ConnectionType"].ToString();
                product.ResponseTime = reader["ResponseTime"].ToString();
                product.Picture = reader["Picture"].ToString();
                product.Desciption = reader["Desciption"].ToString();
                products.Add(product);
            }
            return products;
        }

        public List<Product> GetProductsByBrand(string brand)
        {
            string sql = "SELECT * FROM Products Where Brand = '" + brand + "'";
            SqlDataReader reader = this.GetData(sql);
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product();
                product.ProductId = Convert.ToInt32(reader["ProductId"]);
                product.Category = reader["Category"].ToString();
                product.Brand = reader["Brand"].ToString();
                product.Quantity = Convert.ToInt32(reader["Quantity"]);
                product.Price = Convert.ToSingle(reader["Price"]);
                product.Warranty = reader["Warranty"].ToString();
                product.Capacity = reader["Capacity"].ToString();
                product.MemoryType = reader["MemoryType"].ToString();
                product.BusSpeed = reader["BusSpeed"].ToString();
                product.ScreenSize = reader["ScreenSize"].ToString();
                product.RefreshRate = reader["RefreshRate"].ToString();
                product.Wattage = reader["Wattage"].ToString();
                product.MotherBoardType = reader["MotherBoardType"].ToString();
                product.ClockSpeed = reader["ClockSpeed"].ToString();
                product.ConnectionType = reader["ConnectionType"].ToString();
                product.ResponseTime = reader["ResponseTime"].ToString();
                product.Picture = reader["Picture"].ToString();
                product.Desciption = reader["Desciption"].ToString();
                products.Add(product);
            }
            return products;
        }

        public List<Product> GetProductsByCategoryAndBrand(string category,string brand)
        {
            string sql = "SELECT * FROM Products Where Category = '" + category + "' AND Brand = '"+brand+"'";
            SqlDataReader reader = this.GetData(sql);
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product();
                product.ProductId = Convert.ToInt32(reader["ProductId"]);
                product.Category = reader["Category"].ToString();
                product.Brand = reader["Brand"].ToString();
                product.Quantity = Convert.ToInt32(reader["Quantity"]);
                product.Price = Convert.ToSingle(reader["Price"]);
                product.Warranty = reader["Warranty"].ToString();
                product.Capacity = reader["Capacity"].ToString();
                product.MemoryType = reader["MemoryType"].ToString();
                product.BusSpeed = reader["BusSpeed"].ToString();
                product.ScreenSize = reader["ScreenSize"].ToString();
                product.RefreshRate = reader["RefreshRate"].ToString();
                product.Wattage = reader["Wattage"].ToString();
                product.MotherBoardType = reader["MotherBoardType"].ToString();
                product.ClockSpeed = reader["ClockSpeed"].ToString();
                product.ConnectionType = reader["ConnectionType"].ToString();
                product.ResponseTime = reader["ResponseTime"].ToString();
                product.Picture = reader["Picture"].ToString();
                product.Desciption = reader["Desciption"].ToString();
                products.Add(product);
            }
            return products;
        }

        public int RemoveProduct(int productId)
        {
            string sql = "DELETE FROM Products WHERE ProductId='" + productId + "' ";
            return this.ExecuteQuery(sql);
        }
    }
}
