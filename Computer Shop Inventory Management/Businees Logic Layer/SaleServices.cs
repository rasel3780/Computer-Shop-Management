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

        public int MonthlySell()
        {
            int dailySell = 0;
            string today = DateTime.Now.ToString();
            int i = 0;
            string d = "", m = "", y = "";
            int day = -1, month = -1, year = -1;
            while (true)
            {
                while(today[i] != '/')
                {
                    d += today[i];
                    i++;
                }
                day = Convert.ToInt32(d);
                i++;
                while (today[i] != '/')
                {
                    m += today[i];
                    i++;
                }
                month = Convert.ToInt32(m);
                i++;

                int t = 0;
                while (t <4)
                {
                    y += today[i];
                    i++;
                    t++;
                }
                year = Convert.ToInt32(y);

                break;
            }

            List<Sale> sales = new List<Sale>();
            this.saleDataAccess = new SaleDataAccess();
            sales = this.saleDataAccess.GetAllSale();

            foreach(Sale sale in sales)
            {
                string value = sale.SaleDate;


                int x = 0;
                string sd = "", sm = "", sy = "";
                int sday = -1, smonth = -1, syear = -1;
                while (true)
                {
                    while (value[x] != '/')
                    {
                        sd += value[x];
                        x++;
                    }
                    sday = Convert.ToInt32(sd);
                    x++;
                    while (value[x] != '/')
                    {
                        sm += value[x];
                        x++;
                    }
                    smonth = Convert.ToInt32(sm);
                    x++;

                    int p = 0;
                    while (p < 4)
                    {
                        sy += value[x];
                        x++;
                        p++;
                    }
                    syear = Convert.ToInt32(sy);

                    break;
                }

                if(sday == day)
                {
                    dailySell++;
                }

            }
            return dailySell;
        }

        public int DailySell()
        {
            int monthlySell = 0;
            string today = DateTime.Now.ToString();
            int i = 0;
            string d = "", m = "", y = "";
            int day = -1, month = -1, year = -1;
            while (true)
            {
                while (today[i] != '/')
                {
                    d += today[i];
                    i++;
                }
                day = Convert.ToInt32(d);
                i++;
                while (today[i] != '/')
                {
                    m += today[i];
                    i++;
                }
                month = Convert.ToInt32(m);
                i++;

                int t = 0;
                while (t < 4)
                {
                    y += today[i];
                    i++;
                    t++;
                }
                year = Convert.ToInt32(y);

                break;
            }

            List<Sale> sales = new List<Sale>();
            this.saleDataAccess = new SaleDataAccess();
            sales = this.saleDataAccess.GetAllSale();

            foreach (Sale sale in sales)
            {
                string value = sale.SaleDate;


                int x = 0;
                string sd = "", sm = "", sy = "";
                int sday = -1, smonth = -1, syear = -1;
                while (true)
                {
                    while (value[x] != '/')
                    {
                        sd += value[x];
                        x++;
                    }
                    sday = Convert.ToInt32(sd);
                    x++;
                    while (value[x] != '/')
                    {
                        sm += value[x];
                        x++;
                    }
                    smonth = Convert.ToInt32(sm);
                    x++;

                    int p = 0;
                    while (p < 4)
                    {
                        sy += value[x];
                        x++;
                        p++;
                    }
                    syear = Convert.ToInt32(sy);

                    break;
                }

                if (smonth == month)
                {
                    monthlySell++;
                }

            }
            return monthlySell;
        }

        //ok
        public int YearlySell()
        {
            int yearSell = 0;
            string today = DateTime.Now.ToString();
            int i = 0;
            string d = "", m = "", y = "";
            int day = -1, month = -1, year = -1;
            while (true)
            {
                while (today[i] != '/')
                {
                    d += today[i];
                    i++;
                }
                day = Convert.ToInt32(d);
                i++;
                while (today[i] != '/')
                {
                    m += today[i];
                    i++;
                }
                month = Convert.ToInt32(m);
                i++;

                int t = 0;
                while (t < 4)
                {
                    y += today[i];
                    i++;
                    t++;
                }
                year = Convert.ToInt32(y);

                break;
            }

            List<Sale> sales = new List<Sale>();
            this.saleDataAccess = new SaleDataAccess();
            sales = this.saleDataAccess.GetAllSale();

            foreach (Sale sale in sales)
            {
                string value = sale.SaleDate;


                int x = 0;
                string sd = "", sm = "", sy = "";
                int sday = -1, smonth = -1, syear = -1;
                while (true)
                {
                    while (value[x] != '/')
                    {
                        sd += today[x];
                        x++;
                    }
                    sday = Convert.ToInt32(sd);
                    x++;
                    while (value[x] != '/')
                    {
                        sm += today[x];
                        x++;
                    }
                    smonth = Convert.ToInt32(sm);
                    x++;

                    int p = 0;
                    while (p < 4)
                    {
                        sy += value[x];
                        x++;
                        p++;
                    }
                    syear = Convert.ToInt32(sy);

                    break;
                }

                if (syear == year)
                {
                    yearSell++;
                }

            }
            return yearSell;
        }


        public int TotalSell()
        {
            List<Sale> sales = new List<Sale>();
            this.saleDataAccess = new SaleDataAccess();
            sales = this.saleDataAccess.GetAllSale();

            return sales.Count;
        }


        public long TotalAmountSell()
        {
            List<Sale> sales = new List<Sale>();
            this.saleDataAccess = new SaleDataAccess();
            sales = this.saleDataAccess.GetAllSale();
            long price = 0;

            foreach(Sale sale in sales)
            {
                price += Convert.ToInt64(sale.Price);
            }

            return price;
        }


        public long DailyAmountSell()
        {
            long dailyAmont = 0;
            string today = DateTime.Now.ToString();
            int i = 0;
            string d = "", m = "", y = "";
            int day = -1, month = -1, year = -1;
            while (true)
            {
                while (today[i] != '/')
                {
                    d += today[i];
                    i++;
                }
                day = Convert.ToInt32(d);
                i++;
                while (today[i] != '/')
                {
                    m += today[i];
                    i++;
                }
                month = Convert.ToInt32(m);
                i++;

                int t = 0;
                while (t < 4)
                {
                    y += today[i];
                    i++;
                    t++;
                }
                year = Convert.ToInt32(y);

                break;
            }

            List<Sale> sales = new List<Sale>();
            this.saleDataAccess = new SaleDataAccess();
            sales = this.saleDataAccess.GetAllSale();

            foreach (Sale sale in sales)
            {
                string value = sale.SaleDate;


                int x = 0;
                string sd = "", sm = "", sy = "";
                int sday = -1, smonth = -1, syear = -1;
                while (true)
                {
                    while (value[x] != '/')
                    {
                        sd += value[x];
                        x++;
                    }
                    sday = Convert.ToInt32(sd);
                    x++;
                    while (value[x] != '/')
                    {
                        sm += value[x];
                        x++;
                    }
                    smonth = Convert.ToInt32(sm);
                    x++;

                    int p = 0;
                    while (p < 4)
                    {
                        sy += value[x];
                        x++;
                        p++;
                    }
                    syear = Convert.ToInt32(sy);

                    break;
                }

                if (smonth == month)
                {
                    dailyAmont += Convert.ToInt64(sale.Price);
                }

            }
            return dailyAmont;
        }


        public long MonthlyAmountSell()
        {
            long monthlyAmont = 0;
            string today = DateTime.Now.ToString();
            int i = 0;
            string d = "", m = "", y = "";
            int day = -1, month = -1, year = -1;
            while (true)
            {
                while (today[i] != '/')
                {
                    d += today[i];
                    i++;
                }
                day = Convert.ToInt32(d);
                i++;
                while (today[i] != '/')
                {
                    m += today[i];
                    i++;
                }
                month = Convert.ToInt32(m);
                i++;

                int t = 0;
                while (t < 4)
                {
                    y += today[i];
                    i++;
                    t++;
                }
                year = Convert.ToInt32(y);

                break;
            }

            List<Sale> sales = new List<Sale>();
            this.saleDataAccess = new SaleDataAccess();
            sales = this.saleDataAccess.GetAllSale();

            foreach (Sale sale in sales)
            {
                string value = sale.SaleDate;


                int x = 0;
                string sd = "", sm = "", sy = "";
                int sday = -1, smonth = -1, syear = -1;
                while (true)
                {
                    while (value[x] != '/')
                    {
                        sd += value[x];
                        x++;
                    }
                    sday = Convert.ToInt32(sd);
                    x++;
                    while (value[x] != '/')
                    {
                        sm += value[x];
                        x++;
                    }
                    smonth = Convert.ToInt32(sm);
                    x++;

                    int p = 0;
                    while (p < 4)
                    {
                        sy += value[x];
                        x++;
                        p++;
                    }
                    syear = Convert.ToInt32(sy);

                    break;
                }

                if (sday == day)
                {
                    monthlyAmont += Convert.ToInt64(sale.Price);
                }

            }
            return monthlyAmont;
        }

        public long YearlyAmountSell()
        {
            long yearlyAmont = 0;
            string today = DateTime.Now.ToString();
            int i = 0;
            string d = "", m = "", y = "";
            int day = -1, month = -1, year = -1;
            while (true)
            {
                while (today[i] != '/')
                {
                    d += today[i];
                    i++;
                }
                day = Convert.ToInt32(d);
                i++;
                while (today[i] != '/')
                {
                    m += today[i];
                    i++;
                }
                month = Convert.ToInt32(m);
                i++;

                int t = 0;
                while (t < 4)
                {
                    y += today[i];
                    i++;
                    t++;
                }
                year = Convert.ToInt32(y);

                break;
            }

            List<Sale> sales = new List<Sale>();
            this.saleDataAccess = new SaleDataAccess();
            sales = this.saleDataAccess.GetAllSale();

            foreach (Sale sale in sales)
            {
                string value = sale.SaleDate;


                int x = 0;
                string sd = "", sm = "", sy = "";
                int sday = -1, smonth = -1, syear = -1;
                while (true)
                {
                    while (value[x] != '/')
                    {
                        sd += value[x];
                        x++;
                    }
                    sday = Convert.ToInt32(sd);
                    x++;
                    while (value[x] != '/')
                    {
                        sm += value[x];
                        x++;
                    }
                    smonth = Convert.ToInt32(sm);
                    x++;

                    int p = 0;
                    while (p < 4)
                    {
                        sy += value[x];
                        x++;
                        p++;
                    }
                    syear = Convert.ToInt32(sy);

                    break;
                }

                if (syear == year)
                {
                    yearlyAmont += Convert.ToInt64(sale.Price);
                }

            }
            return yearlyAmont;
        }


        public List<Sale> SellSort()
        {
            List<Sale> sales = new List<Sale>();
            this.saleDataAccess = new SaleDataAccess();
            sales = this.saleDataAccess.GetAllSale();

            sales.Sort(delegate (Sale x, Sale y) {
                return x.SaleDate.CompareTo(y.SaleDate);
            });

            return sales;
        }

        public List<Sale> SellSortDescending()
        {
            List<Sale> sales = new List<Sale>();
            this.saleDataAccess = new SaleDataAccess();
            sales = this.saleDataAccess.GetAllSale();

            sales.Sort(delegate (Sale x, Sale y) {
                return x.SaleDate.CompareTo(y.SaleDate);
            });

            sales.Reverse();

            return sales;
        }
    }
}
