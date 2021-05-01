using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Shop_Inventory_Management.Data_Access_Layer.Entities
{
    class Sale
    {
        public int ProductId { set; get; }
        public string Category { set; get; }
        public string Brand { set; get; }
        public int Quantity { set; get; }
        public float Price { set; get; }
        public string Warranty { set; get; }
        public string Capacity { set; get; }
        public string MemoryType { set; get; }
        public string BusSpeed { set; get; }
        public string ScreenSize { set; get; }
        public string RefreshRate { set; get; }
        public string Wattage { set; get; }
        public string MotherBoardType { set; get; }
        public string ClockSpeed { set; get; }
        public string ConnectionType { set; get; }
        public string ResponseTime { set; get; }
        public string Picture { set; get; }
        public string Desciption { set; get; }
        public string SaleDate { set; get; }
        public string BuyerName { set; get; }
        public string BuyerPhoneNo { set; get; }
        public string SoldBy { set; get; }

    }
}
