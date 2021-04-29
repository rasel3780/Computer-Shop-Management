using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Shop_Inventory_Management.Data_Access_Layer.Entities
{
    class Employee
    {
        public string Name { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public string Address { set; get; }
        public string DateOfBirth { set; get; }
        public string Gender { set; get; }
        public string BloodGroup { set; get; }
        public string Email { set; get; }
        public string EmployeeType { set; get; }
        public float Salary { set; get; }
    }
}
