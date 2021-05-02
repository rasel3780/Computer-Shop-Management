using Computer_Shop_Inventory_Management.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Shop_Inventory_Management.Data_Access_Layer
{
    class LoginDataAccess:DataAccess
    {
        public string LoginValidation(Employee employee)
        {
            string query = "SELECT * FROM Employees WHERE UserName='" + employee.UserName + "' AND Password='" + employee.Password + "'";
            SqlDataReader reader = GetData(query);
            if (reader.Read())
            {
                return reader["UserName"].ToString();
            }
            return null;
        }

        public string ReturnEmployeeType(Employee employee)
        {
            string query = "SELECT * FROM Employees WHERE UserName='" + employee.UserName + "' AND Password='" + employee.Password + "'";
            SqlDataReader reader = GetData(query);
            if (reader.Read())
            {
                return reader["EmployeeType"].ToString();
            }
            return null;
        }
    }
}
