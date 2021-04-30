using Computer_Shop_Inventory_Management.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Shop_Inventory_Management.Data_Access_Layer
{
    class ProductDataAccess:DataAccess
    {
        public int AddProduct(Product product)
        {
            string sql = "INSERT INTO Products(Catagory,Brand,Quantity,Price,Waranty,Capacity,MemoryType,BusSpeed,ScreenSize,RefreshRate,Wattage,MotherBoardType,ClockSpeed,ConnectionType,ResponseTime,Picture,Desciption) VALUES('" + product.Category + "'," + product.Brand + "," + product.Quantity + ",'" + product.Price + "','" + product.Warranty + "','" + product.Capacity + "','" + product.MemoryType + "','" + product.BusSpeed + "','" + product.ScreenSize + "' ,'" + product.RefreshRate + "','" + product.Wattage + "','" + product.MotherBoardType + "','" + product.ClockSpeed + "','" + product.ConnectionType + "','" + product.ResponseTime + "','" + product.Picture + "','" + product.Desciption + "')";
            return this.ExecuteQuery(sql);
        }
    }
}
