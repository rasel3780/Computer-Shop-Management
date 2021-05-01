using Computer_Shop_Inventory_Management.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Shop_Inventory_Management.Data_Access_Layer
{
    class SaleDataAccess:DataAccess
    {
        public int SellProduct(Sale saleProduct)
        {
            string sql = "INSERT INTO Sales(ProductId,Category,Brand,Quantity,Price,Warranty,Capacity,MemoryType,BusSpeed,ScreenSize,RefreshRate,Wattage,MotherBoardType,ClockSpeed,ConnectionType,ResponseTime,Picture,Desciption,SaleDate,BuyerName,BuyerPhoneNo,SoldBy) VALUES('" + saleProduct.ProductId + "' ,'" + saleProduct.Category + "','" + saleProduct.Brand + "','" + saleProduct.Quantity + "','" + saleProduct.Price + "','" + saleProduct.Warranty + "','" + saleProduct.Capacity + "','" + saleProduct.MemoryType + "','" + saleProduct.BusSpeed + "','" + saleProduct.ScreenSize + "' ,'" + saleProduct.RefreshRate + "','" + saleProduct.Wattage + "','" + saleProduct.MotherBoardType + "','" + saleProduct.ClockSpeed + "','" + saleProduct.ConnectionType + "','" + saleProduct.ResponseTime + "','" + saleProduct.Picture + "','" + saleProduct.Desciption + "','"+ saleProduct.SaleDate+ "', '" + saleProduct.BuyerName + "','" + saleProduct.BuyerPhoneNo + "','" + saleProduct.SoldBy + "', )";
            return this.ExecuteQuery(sql);
        }
    }
}
