using Computer_Shop_Inventory_Management.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Shop_Inventory_Management.Data_Access_Layer
{
    class SaleDataAccess:DataAccess
    {
        public int SellProduct(Sale saleProduct)
        {
            string sql = "INSERT INTO Sales(ProductId,Category,Brand,Quantity,Price,Warranty,Capacity,MemoryType,BusSpeed,ScreenSize,RefreshRate,Wattage,MotherBoardType,ClockSpeed,ConnectionType,ResponseTime,Picture,Description,SaleDate,BuyerName,BuyerPhoneNo,SoldBy) VALUES('" + saleProduct.ProductId + "' ,'" + saleProduct.Category + "','" + saleProduct.Brand + "','" + saleProduct.Quantity + "','" + saleProduct.Price + "','" + saleProduct.Warranty + "','" + saleProduct.Capacity + "','" + saleProduct.MemoryType + "','" + saleProduct.BusSpeed + "','" + saleProduct.ScreenSize + "' ,'" + saleProduct.RefreshRate + "','" + saleProduct.Wattage + "','" + saleProduct.MotherBoardType + "','" + saleProduct.ClockSpeed + "','" + saleProduct.ConnectionType + "','" + saleProduct.ResponseTime + "','" + saleProduct.Picture + "','" + saleProduct.Desciption + "','"+ saleProduct.SaleDate+ "', '" + saleProduct.BuyerName + "','" + saleProduct.BuyerPhoneNo + "','" + saleProduct.SoldBy + "')";
            return this.ExecuteQuery(sql);
        }

        public List<Sale> GetAllSale()
        {
            string sql = "SELECT * FROM Sales";
            SqlDataReader reader = this.GetData(sql);
            List<Sale> sales = new List<Sale>();
            while (reader.Read())
            {
                Sale sale = new Sale();
                sale.ProductId = Convert.ToInt32(reader["ProductId"]);
                sale.Category = reader["Category"].ToString();
                sale.Brand = reader["Brand"].ToString();
                sale.Quantity = Convert.ToInt32(reader["Quantity"]);
                sale.Price = Convert.ToSingle(reader["Price"]);
                sale.Warranty = reader["Warranty"].ToString();
                sale.Capacity = reader["Capacity"].ToString();
                sale.MemoryType = reader["MemoryType"].ToString();
                sale.BusSpeed = reader["BusSpeed"].ToString();
                sale.ScreenSize = reader["ScreenSize"].ToString();
                sale.RefreshRate = reader["RefreshRate"].ToString();
                sale.Wattage = reader["Wattage"].ToString();
                sale.MotherBoardType = reader["MotherBoardType"].ToString();
                sale.ClockSpeed = reader["ClockSpeed"].ToString();
                sale.ConnectionType = reader["ConnectionType"].ToString();
                sale.ResponseTime = reader["ResponseTime"].ToString();
                sale.Picture = reader["Picture"].ToString();
                sale.Desciption = reader["Description"].ToString();
                sale.SaleDate = reader["SaleDate"].ToString();
                sale.BuyerName = reader["BuyerName"].ToString();
                sale.BuyerPhoneNo = reader["BuyerPhoneNo"].ToString();
                sale.SoldBy = reader["SoldBy"].ToString();
                sales.Add(sale);
            }
            return sales;
        }

        public List<Sale> GetAllSaleByCategory(string category)
        {
            string sql = "SELECT * FROM Sales WHERE Category = '"+category+"'";
            SqlDataReader reader = this.GetData(sql);
            List<Sale> sales = new List<Sale>();
            while (reader.Read())
            {
                Sale sale = new Sale();
                sale.ProductId = Convert.ToInt32(reader["ProductId"]);
                sale.Category = reader["Category"].ToString();
                sale.Brand = reader["Brand"].ToString();
                sale.Quantity = Convert.ToInt32(reader["Quantity"]);
                sale.Price = Convert.ToSingle(reader["Price"]);
                sale.Warranty = reader["Warranty"].ToString();
                sale.Capacity = reader["Capacity"].ToString();
                sale.MemoryType = reader["MemoryType"].ToString();
                sale.BusSpeed = reader["BusSpeed"].ToString();
                sale.ScreenSize = reader["ScreenSize"].ToString();
                sale.RefreshRate = reader["RefreshRate"].ToString();
                sale.Wattage = reader["Wattage"].ToString();
                sale.MotherBoardType = reader["MotherBoardType"].ToString();
                sale.ClockSpeed = reader["ClockSpeed"].ToString();
                sale.ConnectionType = reader["ConnectionType"].ToString();
                sale.ResponseTime = reader["ResponseTime"].ToString();
                sale.Picture = reader["Picture"].ToString();
                sale.Desciption = reader["Description"].ToString();
                sale.SaleDate = reader["SaleDate"].ToString();
                sale.BuyerName = reader["BuyerName"].ToString();
                sale.BuyerPhoneNo = reader["BuyerPhoneNo"].ToString();
                sale.SoldBy = reader["SoldBy"].ToString();
                sales.Add(sale);
            }
            return sales;
        }

        public List<Sale> GetAllSaleByBrand(string brand)
        {
            string sql = "SELECT * FROM Sales WHERE Brand = '" + brand + "'";
            SqlDataReader reader = this.GetData(sql);
            List<Sale> sales = new List<Sale>();
            while (reader.Read())
            {
                Sale sale = new Sale();
                sale.ProductId = Convert.ToInt32(reader["ProductId"]);
                sale.Category = reader["Category"].ToString();
                sale.Brand = reader["Brand"].ToString();
                sale.Quantity = Convert.ToInt32(reader["Quantity"]);
                sale.Price = Convert.ToSingle(reader["Price"]);
                sale.Warranty = reader["Warranty"].ToString();
                sale.Capacity = reader["Capacity"].ToString();
                sale.MemoryType = reader["MemoryType"].ToString();
                sale.BusSpeed = reader["BusSpeed"].ToString();
                sale.ScreenSize = reader["ScreenSize"].ToString();
                sale.RefreshRate = reader["RefreshRate"].ToString();
                sale.Wattage = reader["Wattage"].ToString();
                sale.MotherBoardType = reader["MotherBoardType"].ToString();
                sale.ClockSpeed = reader["ClockSpeed"].ToString();
                sale.ConnectionType = reader["ConnectionType"].ToString();
                sale.ResponseTime = reader["ResponseTime"].ToString();
                sale.Picture = reader["Picture"].ToString();
                sale.Desciption = reader["Description"].ToString();
                sale.SaleDate = reader["SaleDate"].ToString();
                sale.BuyerName = reader["BuyerName"].ToString();
                sale.BuyerPhoneNo = reader["BuyerPhoneNo"].ToString();
                sale.SoldBy = reader["SoldBy"].ToString();
                sales.Add(sale);
            }
            return sales;
        }

        public List<Sale> GetAllSaleByBoth(string category,string brand)
        {
            string sql = "SELECT * FROM Sales WHERE Category = '" + category + "' AND Brand = '"+brand+"'";
            SqlDataReader reader = this.GetData(sql);
            List<Sale> sales = new List<Sale>();
            while (reader.Read())
            {
                Sale sale = new Sale();
                sale.ProductId = Convert.ToInt32(reader["ProductId"]);
                sale.Category = reader["Category"].ToString();
                sale.Brand = reader["Brand"].ToString();
                sale.Quantity = Convert.ToInt32(reader["Quantity"]);
                sale.Price = Convert.ToSingle(reader["Price"]);
                sale.Warranty = reader["Warranty"].ToString();
                sale.Capacity = reader["Capacity"].ToString();
                sale.MemoryType = reader["MemoryType"].ToString();
                sale.BusSpeed = reader["BusSpeed"].ToString();
                sale.ScreenSize = reader["ScreenSize"].ToString();
                sale.RefreshRate = reader["RefreshRate"].ToString();
                sale.Wattage = reader["Wattage"].ToString();
                sale.MotherBoardType = reader["MotherBoardType"].ToString();
                sale.ClockSpeed = reader["ClockSpeed"].ToString();
                sale.ConnectionType = reader["ConnectionType"].ToString();
                sale.ResponseTime = reader["ResponseTime"].ToString();
                sale.Picture = reader["Picture"].ToString();
                sale.Desciption = reader["Description"].ToString();
                sale.SaleDate = reader["SaleDate"].ToString();
                sale.BuyerName = reader["BuyerName"].ToString();
                sale.BuyerPhoneNo = reader["BuyerPhoneNo"].ToString();
                sale.SoldBy = reader["SoldBy"].ToString();
                sales.Add(sale);
            }
            return sales;
        }
    }
}
