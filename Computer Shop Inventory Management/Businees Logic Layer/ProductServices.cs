using Computer_Shop_Inventory_Management.Data_Access_Layer;
using Computer_Shop_Inventory_Management.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Shop_Inventory_Management.Businees_Logic_Layer
{
    class ProductServices
    {
        ProductDataAccess productDataAccess;
        public ProductServices()
        {
            this.productDataAccess = new ProductDataAccess();
        }

        public int AddProduct(string catagory, string brand, int quantity, float price, string warranty, string desciption, Dictionary<string, string> features)
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
                else if(keyValuePair.Key == "Picture")
                {
                    picture = keyValuePair.Value;
                }
            }
            Product product = new Product()
            {
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
                Desciption = desciption
            };
            this.productDataAccess = new ProductDataAccess();
            return this.productDataAccess.AddProduct(product);
        }
        public int CheckProductId(int productId)
        {
            Product product = new Product()
            {
                ProductId = productId
            };
            return this.productDataAccess.CheckProductId(product);
        }
        public List<Product> GetAllProducts()
        {
            this.productDataAccess = new ProductDataAccess();
            return this.productDataAccess.GetAllProducts();
        }

        public List<Product> GetProductById(int productId)
        {
            List<Product> product = new List<Product>();
            this.productDataAccess = new ProductDataAccess();
            product.Add(this.productDataAccess.GetProductById(productId));

            return product;
        }
        public List<Product> GetProductsByCategory(string category)
        {
            this.productDataAccess = new ProductDataAccess();
            return this.productDataAccess.GetProductsByCategory(category);
        }

        public List<Product> GetProductsByBrand(string brand)
        {
            this.productDataAccess = new ProductDataAccess();
            return this.productDataAccess.GetProductsByBrand(brand);
        }

        public List<Product> GetProductsByCategoryAndBrand(string category, string brand)
        {
            this.productDataAccess = new ProductDataAccess();
            return this.productDataAccess.GetProductsByCategoryAndBrand(category,brand);
        }
        public int RemoveProduct(int productId)
        {
            this.productDataAccess = new ProductDataAccess();
            return this.productDataAccess.RemoveProduct(productId);
        }
        public Product ReadProduct(int productId)
        {
            this.productDataAccess = new ProductDataAccess();
            return this.productDataAccess.ReadProduct(productId);
        }
        public List<Product> ALLProductSortByPriceHighToLow()
        {
            List<Product> products = new List<Product>();
            this.productDataAccess = new ProductDataAccess();
            products = this.productDataAccess.GetAllProducts();

            products.Sort(delegate (Product x, Product y) {
                return x.Price.CompareTo(y.Price);
            });

            products.Reverse();

            return products;
        }
        public List<Product> ALLProductSortByPriceLowToHigh()
        {
            List<Product> products = new List<Product>();
            this.productDataAccess = new ProductDataAccess();
            products = this.productDataAccess.GetAllProducts();

            products.Sort(delegate (Product x, Product y) {
                return x.Price.CompareTo(y.Price);
            });
            return products;
        }

        public int UpdateProduct(int productId,string catagory, string brand, int quantity, float price, string warranty, string desciption, Dictionary<string, string> features)
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
                else
                {
                    picture = keyValuePair.Value;
                }
            }
            Product product = new Product()
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
                Desciption = desciption
            };
            this.productDataAccess = new ProductDataAccess();
            return this.productDataAccess.UpdateProduct(product);

        }

    }
}

