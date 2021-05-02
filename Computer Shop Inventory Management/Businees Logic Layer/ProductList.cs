using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Shop_Inventory_Management.Businees_Logic_Layer
{
    class ProductList
    {
        List<string> category = new List<string>()
        {
            
            "Casing",
            "CPU",
            "Graphics card",
            "Headphone",
            "HDD",
            "Keyboard",
            "Laptop",
            "Motherborad",
            "Monitor",
            "Mouse",
            "Power Supply",
            "Printer",
            "Pendrive",
            "RAM",
            "SSD",
            "UPS"
           
        };

        List<string> brand = new List<string>()
        {

            "Acer",
            "Adata",
            "Apacer",
            "Apple",
            "ASRock",
            "ASUS",
            "A4Tech",
            "Benq",
            "Corsair",
            "DELL",
            "Fantech",
            "Gamdias",
            "Gigabyte",
            "G.Skill",
            "HP",
            "Intel",
            "Lian Li",
            "LG",
            "Logitech",
            "MaxGreen",
            "MSI",
            "Philips",
            "PNY",
            "Razer",
            "Rapoo",
            "Ryzen",
            "Seagate",
            "Samsung",
            "Team",
            "Thermaltake",
            "Transcend",
            "Twinmos",
            "Viewsonic",
            "Walton",
            "XFX",
            "Zotac"

            
        };

        List<string> capacity = new List<string>()
        {
            "1 GB",
            "2 GB",
            "4 GB",
            "6 GB",
            "8 GB",
            "16 GB",
            "24 GB",
            "120 GB",
            "240 GB",
            "256 GB",
            "512 GB",
            "1 TB",
            "2 TB",
            "4 TB",
            "5 TB",
            "6 TB",
            "10 TB",
            "12 TB",
            "14 TB"
        };

        List<string> busSpeed = new List<string>()
        {
            "1333 MHz",
            "1600 MHz",
            "2133 MHz",
            "2400 MHz",
            "2666 MHz",
            "2933 MHz",
            "3000 MHz",
            "3200 MHz",
            "3400 MHz",
            "3466 MHz",
            "3600 MHz",
            "4000 MHz",
            "4200 MHz",
            "4400 MHz",
            "4600 MHz",
        };

        List<string> clockSpeed = new List<string>()
        {
            "Upto 2.4 GHz",
            "2.5 GHz to 3.4 GHz",
            "3.5 GHz to 3.9 GHz",
            "4.0 GHz to 5.0 GHz"
        };

        List<string> refreshRate = new List<string>()
        {
            "60 Hz",
            "75 Hz",
            "90 Hz",
            "100 Hz",
            "144 Hz",
            "155 Hz",
            "165 Hz",
            "170 Hz",
            "240 Hz",
            "244 Hz"
        };

        List<string> responseTime = new List<string>()
        {
            "0.5 ms",
            "1 ms",
            "4 ms",
            "5 ms",
            "7 ms",
            "8 ms",
            "12 ms",
            "13 ms",
            "14 ms",
            "15 ms"
        };

        List<string> connectionType = new List<string>()
        {
            "VGA",
            "HDMI",
            "DVI",
            "DVI-D",
            "Display Port",
            "Audio Jack",
            "USB",
            "D-SUB",
            "Type-C",
            "Wireless",
            "3.5 mm",
            "Bluetooth"
        };
        List<string> wattage = new List<string>()
        {
            "150 watt",
            "200 Watt",
            "300 Watt",
            "350 Watt",
            "400 Watt",
            "450 Watt",
            "500 Watt",
            "550 Watt",
            "600 Watt",
            "650 Watt",
            "700 Watt",
            "750 Watt",
            "800 Watt",
            "1000 Watt",
            "1200 Watt",
        };

        List<string> screenSize = new List<string>()
        {
            "10 inch",
            "12 inch",
            "14.9 inch",
            "15 inch",
            "17 inch",
            "18 inch",
            "20 inch",
            "21 inch",
            "22 inch",
            "23 inch",
            "24 inch",
            "26 inch",
            "27 inch",
            "28 inch",
            "30 inch",
            "Above 30 inch"
        };

        List<string> motherboardType = new List<string>()
        {
            "ATX",
            "Micro ATX",
            "Extended ATX",
            "Mini ITX"
        };


        List<string> memoryType = new List<string>()
        {
            "DDR3",
            "DDR3L",
            "DDR4",
            "DDR5",
            "GDDR5",
            "GDDR5X",
            "DDR6",
            "GDDR6",
            "GDDR6X"
        };

        public List<string> Category()
        {
            return category;
        }
        public List<string> Brand()
        {
            return brand;
        }
        public List<string> Capacity()
        {
            return capacity;
        }
        public List<string> MemoryType()
        {
            return memoryType;
        }
        public List<string> BusSpeed()
        {
            return busSpeed;
        }
        public List<string> ScreenSize()
        {
            return screenSize;
        }
        public List<string> RefreshRate()
        {
            return refreshRate;
        }
        public List<string> Wattage()
        {
            return wattage;
        }
        public List<string> MotherBoardType()
        {
            return motherboardType;
        }
        public List<string> ClockSpeed()
        {
            return clockSpeed;
        }
        public List<string> ConnectionType()
        {
            return connectionType;
        }
        public List<string> ResponseTime()
        {
            return responseTime;
        }

    }
}
