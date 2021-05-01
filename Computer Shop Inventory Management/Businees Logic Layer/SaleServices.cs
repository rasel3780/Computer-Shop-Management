using Computer_Shop_Inventory_Management.Data_Access_Layer;
using Computer_Shop_Inventory_Management.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Shop_Inventory_Management.Businees_Logic_Layer
{
    class SaleServices
    {
        SaleDataAccess saleDataAccess;
        public SaleServices()
        {
            this.saleDataAccess = new SaleDataAccess();
        }
        public int SellProduct(int productId, string catagory, string brand, int quantity, float price, string warranty, string desciption, Dictionary<string, string> features, string saleDate, string buyerName, string buyerPhoneNo, string soldBy)
        {
            string capacity = null;
            string memoryType = null;
            string busSpeed = null;
            string screenSize = null;
            string refreshRate = null;
            string wattage = null;
            string motherboardType = null;
            string clockSpeed = null;
            string connectionType = null;
            string responseTime = null;
            string picture = null;
            foreach (KeyValuePair<string, string> keyValuePair in features)
            {
                if (keyValuePair.Key == "Capacity")
                {
                    capacity = keyValuePair.Value;
                }
                else if (keyValuePair.Key == "Memory Type")
                {
                    memoryType = keyValuePair.Value;
                }
                else if (keyValuePair.Key == "Bus Speed")
                {
                    busSpeed = keyValuePair.Value;
                }
                else if (keyValuePair.Key == "Screen Size")
                {
                    screenSize = keyValuePair.Value;
                }
                else if (keyValuePair.Key == "refresh Rate")
                {
                    refreshRate = keyValuePair.Value;
                }
                else if (keyValuePair.Key == "Wattage")
                {
                    wattage = keyValuePair.Value;
                }
                else if (keyValuePair.Key == "MotherBoard Type")
                {
                    motherboardType = keyValuePair.Value;
                }
                else if (keyValuePair.Key == "Clock Speed")
                {
                    clockSpeed = keyValuePair.Value;
                }
                else if (keyValuePair.Key == "Connection Type")
                {
                    connectionType = keyValuePair.Value;
                }
                else if (keyValuePair.Key == "Response Time")
                {
                    responseTime = keyValuePair.Value;
                }
                else if (keyValuePair.Key == "Picture")
                {
                    picture = keyValuePair.Value;
                }
            }
            Sale saleProduct = new Sale()
            {
                ProductId = productId,
                Category = catagory,
                Brand = brand,
                Quantity = quantity,
                Price = price,
                Warranty = warranty,
                Capacity = capacity,
                MemoryType = memoryType,
                BusSpeed = busSpeed,
                ScreenSize = screenSize,
                RefreshRate = refreshRate,
                Wattage = wattage,
                MotherBoardType = motherboardType,
                ClockSpeed = clockSpeed,
                ConnectionType = connectionType,
                ResponseTime = responseTime,
                Picture = picture,
                Desciption = desciption,
                SaleDate = saleDate,
                BuyerName = buyerName,
                BuyerPhoneNo = buyerPhoneNo,
                SoldBy = soldBy
            };
            this.saleDataAccess = new SaleDataAccess();
            return this.saleDataAccess.SellProduct(saleProduct);
        }

        public List<Sale> GetAllSale()
        {
            this.saleDataAccess = new SaleDataAccess();
            return this.saleDataAccess.GetAllSale();
        }
        public List<Sale> GetAllSaleByCategory(string category)
        {
            this.saleDataAccess = new SaleDataAccess();
            return this.saleDataAccess.GetAllSaleByCategory(category);
        }
        public List<Sale> GetAllSaleByBrand(string brand)
        {
            this.saleDataAccess = new SaleDataAccess();
            return this.saleDataAccess.GetAllSaleByBrand(brand);
        }
        public List<Sale> GetAllSaleByBoth(string category,string brand)
        {
            this.saleDataAccess = new SaleDataAccess();
            return this.saleDataAccess.GetAllSaleByBoth(category,brand);
        }

    }
}
