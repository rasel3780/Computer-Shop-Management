using Computer_Shop_Inventory_Management.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Shop_Inventory_Management.Data_Access_Layer
{
    class EmployeeDataAccess:DataAccess
    {
        public int AddEmployee(Employee employee)
        {
            string sql = "INSERT INTO Employees(Name,UserName,Password,Email,Address,DateOfBirth,BloodGroup,Gender,EmployeeType, Salary) VALUES('" + employee.Name + "'," + employee.UserName + "," + employee.Password + ",'" + employee.Email + "','" + employee.Address + "','" + employee.DateOfBirth + "','" + employee.BloodGroup + "','" + employee.Gender + "','" + employee.EmployeeType + "' ,'" + employee.Salary + "')";
            return this.ExecuteQuery(sql);
        }
        public int UpdateEmployee(Employee employee)
        {
            string sql = "UPDATE Employees SET Name='" + employee.Name + "',UserName=" + employee.UserName + ",Password=" + employee.Password + ",,Email=" + employee.Email + ",Address=" + employee.Address + ",DateOfBirth=" + employee.DateOfBirth + ",BloodGroup=" + employee.BloodGroup + ",Gender=" + employee.Gender + ",EmployeeType=" + employee.EmployeeType + ",Salary=" + employee.Salary + " WHERE UserName=" + employee.Name;
            return this.ExecuteQuery(sql);
        }
        public int RemoveEmployee(string userName)
        {
            string sql = "DELETE FROM Employees WHERE UserName='" + userName + "' ";
            return this.ExecuteQuery(sql);
        }
        public string CheckUserName(Employee employee)
        {
            string query = "SELECT * FROM Employees WHERE UserName= '" + employee.UserName + "'";
            SqlDataReader reader = GetData(query);
            if (reader.Read())
            {
                return (string)reader["Username"];
            }
            return null;
        }
    }
}
