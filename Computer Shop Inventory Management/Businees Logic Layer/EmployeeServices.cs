using Computer_Shop_Inventory_Management.Data_Access_Layer;
using Computer_Shop_Inventory_Management.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Shop_Inventory_Management.Businees_Logic_Layer
{
    class EmployeeServices
    {
        EmployeeDataAccess employeeDataAccess;
        public EmployeeServices()
        {
            this.employeeDataAccess = new EmployeeDataAccess();
        }

        public int AddEmployee(string name, string userName, string password, string email, string address, string dateOfBirth, string bloodGroup, string gender, string employeeType, float salary)
        {
            Employee employee = new Employee()
            {
                Name = name,
                UserName = userName,
                Password = password,
                Email = email,
                Address = address,
                DateOfBirth = dateOfBirth,
                BloodGroup = bloodGroup,
                Gender = gender,
                EmployeeType = employeeType,
                Salary = salary
            };
            this.employeeDataAccess = new EmployeeDataAccess();
            return this.employeeDataAccess.AddEmployee(employee);
        }
        public int UpdateEmployee(string name, string userName, string password, string email, string address, string dateOfBirth, string bloodGroup, string gender, string employeeType, float salary)
        {
            Employee employee = new Employee()
            {
                Name = name,
                UserName = userName,
                Password = password,
                Email = email,
                Address = address,
                DateOfBirth = dateOfBirth,
                BloodGroup = bloodGroup,
                Gender = gender,
                EmployeeType = employeeType,
                Salary = salary
            };
            this.employeeDataAccess = new EmployeeDataAccess();
            return this.employeeDataAccess.UpdateEmployee(employee);
        }
    }
}
