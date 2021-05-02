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
            string sql = "INSERT INTO Employees(Name,UserName,Password,Email,Address,DateOfBirth,BloodGroup,Gender,EmployeeType, Salary) VALUES('" + employee.Name + "','" + employee.UserName + "','" + employee.Password + "','" + employee.Email + "','" + employee.Address + "','" + employee.DateOfBirth + "','" + employee.BloodGroup + "','" + employee.Gender + "','" + employee.EmployeeType + "' ,'" + employee.Salary + "')";
            return this.ExecuteQuery(sql);
        }
        public int UpdateEmployee(Employee employee)
        {
            string sql = "UPDATE Employees SET Name='" + employee.Name + "', UserName='" + employee.UserName + "', Password='" + employee.Password + "', Email='" + employee.Email + "', Address='" + employee.Address + "', DateOfBirth='" + employee.DateOfBirth + "', BloodGroup='" + employee.BloodGroup + "', Gender='" + employee.Gender + "', EmployeeType='" + employee.EmployeeType + "', Salary='" + employee.Salary + "' WHERE UserName='" + employee.UserName+"'";
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
                return reader["Username"].ToString();
            }
            return null;
        }
        // checkSalesman
        public List<Employee> ReadSalesman(string userName)
        {
            string xyz = "Salesman";
            string sql = "SELECT * FROM Employees WHERE EmployeeType = '"+xyz+"' AND UserName = '"+userName+"'";
            SqlDataReader reader = this.GetData(sql);
            List<Employee> employees = new List<Employee>();
            while (reader.Read())
            {
                Employee employee = new Employee();
                employee.Name = reader["Name"].ToString();
                employee.UserName = reader["UserName"].ToString();
                employee.Password = reader["Password"].ToString();
                employee.Email = reader["Email"].ToString();
                employee.Address = reader["Address"].ToString();
                employee.DateOfBirth = reader["DateOfBirth"].ToString();
                employee.BloodGroup = reader["bloodGroup"].ToString();
                employee.Gender = reader["Gender"].ToString();
                employee.EmployeeType = reader["EmployeeType"].ToString();
                employee.Salary = Convert.ToSingle(reader["Salary"]);
                employees.Add(employee);
            }
            return employees;
        }
        public List<Employee> GetAllEmployees()
        {
            string sql = "SELECT * FROM Employees";
            SqlDataReader reader = this.GetData(sql);
            List<Employee> employees = new List<Employee>();
            while (reader.Read())
            {
                Employee employee = new Employee();
                employee.Name = reader["Name"].ToString();
                employee.UserName = reader["UserName"].ToString();
                employee.Password = reader["Password"].ToString();
                employee.Email = reader["Email"].ToString();
                employee.Address = reader["Address"].ToString();
                employee.DateOfBirth = reader["DateOfBirth"].ToString();
                employee.BloodGroup = reader["bloodGroup"].ToString();
                employee.Gender = reader["Gender"].ToString();
                employee.EmployeeType = reader["EmployeeType"].ToString();
                employee.Salary = Convert.ToSingle(reader["Salary"]);
                employees.Add(employee);
            }
            return employees;
        }

        public Employee ReadEmployee(Employee employee)
        {
            string sql = "SELECT * FROM Employees WHERE UserName = '" + employee.UserName + "'";
            SqlDataReader reader = this.GetData(sql);
           if (reader.Read())
            {
                Employee employee1 = new Employee();
                employee1.Name = reader["Name"].ToString();
                employee1.UserName = reader["UserName"].ToString();
                employee1.Password = reader["Password"].ToString();
                employee1.Email = reader["Email"].ToString();
                employee1.Address = reader["Address"].ToString();
                employee1.DateOfBirth = reader["DateOfBirth"].ToString();
                employee1.BloodGroup = reader["bloodGroup"].ToString();
                employee1.Gender = reader["Gender"].ToString();
                employee1.EmployeeType = reader["EmployeeType"].ToString();
                employee1.Salary = Convert.ToSingle(reader["Salary"]);
                return employee1;
            }
            else return null;
        }

        public List<Employee> GetAllEmployeesByType(string empType)
        {
            string sql = "SELECT * FROM Employees WHERE EmployeeType = '"+empType+"'";
            SqlDataReader reader = this.GetData(sql);
            List<Employee> employees = new List<Employee>();
            while (reader.Read())
            {
                Employee employee = new Employee();
                employee.Name = reader["Name"].ToString();
                employee.UserName = reader["UserName"].ToString();
                employee.Password = reader["Password"].ToString();
                employee.Email = reader["Email"].ToString();
                employee.Address = reader["Address"].ToString();
                employee.DateOfBirth = reader["DateOfBirth"].ToString();
                employee.BloodGroup = reader["bloodGroup"].ToString();
                employee.Gender = reader["Gender"].ToString();
                employee.EmployeeType = reader["EmployeeType"].ToString();
                employee.Salary = Convert.ToSingle(reader["Salary"]);
                employees.Add(employee);
            }
            return employees;
        }
        public List<Employee> EmployeeSearchName(Employee employee)
        {
            string sql = "SELECT * FROM Employees WHERE UserName = '"+employee.UserName+"'";
            SqlDataReader reader = this.GetData(sql);
            List<Employee> employees = new List<Employee>();
            while (reader.Read())
            {
                Employee employee1 = new Employee();
                employee1.Name = reader["Name"].ToString();
                employee1.UserName = reader["UserName"].ToString();
                employee1.Password = reader["Password"].ToString();
                employee1.Email = reader["Email"].ToString();
                employee1.Address = reader["Address"].ToString();
                employee1.DateOfBirth = reader["DateOfBirth"].ToString();
                employee1.BloodGroup = reader["bloodGroup"].ToString();
                employee1.Gender = reader["Gender"].ToString();
                employee1.EmployeeType = reader["EmployeeType"].ToString();
                employee1.Salary = Convert.ToSingle(reader["Salary"]);
                employees.Add(employee1);
            }
            return employees;
        }
        public List<Employee> SalesmanSearchName(Employee employee)
        {
            string sql = "SELECT * FROM Employees WHERE UserName = '" + employee.UserName + "' AND ";
            SqlDataReader reader = this.GetData(sql);
            List<Employee> employees = new List<Employee>();
            while (reader.Read())
            {
                Employee employee1 = new Employee();
                employee1.Name = reader["Name"].ToString();
                employee1.UserName = reader["UserName"].ToString();
                employee1.Password = reader["Password"].ToString();
                employee1.Email = reader["Email"].ToString();
                employee1.Address = reader["Address"].ToString();
                employee1.DateOfBirth = reader["DateOfBirth"].ToString();
                employee1.BloodGroup = reader["bloodGroup"].ToString();
                employee1.Gender = reader["Gender"].ToString();
                employee1.EmployeeType = reader["EmployeeType"].ToString();
                employee1.Salary = Convert.ToSingle(reader["Salary"]);
                employees.Add(employee1);
            }
            return employees;
        }

    }
}
