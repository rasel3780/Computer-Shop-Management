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
            "Laptop",
            "Keyboard",
            "Mouse",
            "Monitor",
            "RAM",
            "Graphics card",
            "Processor",
            "HDD",
            "SSD",
            "Pendrive",
            "Power Supply",
            "Motherborad",
            "Casing",
            "UPS",
            "Printer",
            "Headphone"

        };

        List<string> brand = new List<string>()
        {
            "Intel",
            "AMD",
            "MSI",
            "ASUS",
            "DELL",
            "Samsung",
            "Gigabyte",
            "LG",
            "Philips",
            "Acer",
            "HP",
            "Benq",
            "Walton",
            "Viewsonic",
            "Corsair",
            "Thermaltake",
            "G-skill",
            "PNY",
            "Transcend",
            "Adata",
            "Twinmos",
            "Team",
            "Apacer",
            "Apple"
        };

        List<string> capacity = new List<string>()
        {
            "1 GB",
            "256 GB",
            "1 TB",
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
            "Upto 75 Hz",
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
            "15 and Above"
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
            "3.5 mm"
        };
        List<string> wattage = new List<string>()
        {
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

        };

        List<string> motherboardType = new List<string>()
        {

        };

    }
}
