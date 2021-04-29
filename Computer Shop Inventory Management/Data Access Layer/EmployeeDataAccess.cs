using Computer_Shop_Inventory_Management.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Shop_Inventory_Management.Data_Access_Layer
{
    class EmployeeDataAccess:DataAccess
    {
        public int AddEmployee(Employee employee)
        {
            string sql = "INSERT INTO Employees(Name,UserName,Password,Email,Address,DateOfBirth,BloodGroup,Gender,EmployeeType) VALUES('" + employee.Name + "'," + employee.UserName + "," + employee.Password + ",'" + employee.Email + "','" + employee.Address + "','" + employee.DateOfBirth + "','" + employee.BloodGroup + "','" + employee.Gender + "','" + employee.EmployeeType + "')";
            return this.ExecuteQuery(sql);
        }
    }
}
