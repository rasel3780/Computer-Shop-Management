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
        public int RemoveEmployee(string userName)
        {
            this.employeeDataAccess = new EmployeeDataAccess();
            return this.employeeDataAccess.RemoveEmployee(userName);
        }
        public string CheckUserName(string userName)
        {
            Employee employee = new Employee()
            {
                UserName = userName
            };
            return this.employeeDataAccess.CheckUserName(employee);
        }
        public List<Employee> GetAllEmployees()
        {
            this.employeeDataAccess = new EmployeeDataAccess();
            return this.employeeDataAccess.GetAllEmployees();
        }

       public Employee ReadEmployee(string userName)
        {
            Employee employee = new Employee()
            {
                UserName = userName
            };
            this.employeeDataAccess = new EmployeeDataAccess();
            return this.employeeDataAccess.ReadEmployee(employee);
        }
        //ReadSalesman
        public List<Employee> ReadSalesman(string userName)
        {
            this.employeeDataAccess = new EmployeeDataAccess();
            return this.employeeDataAccess.ReadSalesman(userName);
        }

        public List<Employee> GetAllEmployeesByType(string empType)
        {
            this.employeeDataAccess = new EmployeeDataAccess();
            return this.employeeDataAccess.GetAllEmployeesByType(empType);
        }

        public List<Employee> ALLEmployeeSortBySalaryHighToLow()
        {
            List<Employee> employees = new List<Employee>();
            this.employeeDataAccess = new EmployeeDataAccess();
            employees =  this.employeeDataAccess.GetAllEmployees();

            employees.Sort(delegate (Employee x, Employee y) {
                return x.Salary.CompareTo(y.Salary);
            });

            employees.Reverse();

            return employees;
        }
        public List<Employee> ALLEmployeeSortBySalaryLowToHigh()
        {
            List<Employee> employees = new List<Employee>();
            this.employeeDataAccess = new EmployeeDataAccess();
            employees = this.employeeDataAccess.GetAllEmployees();

            employees.Sort(delegate (Employee x, Employee y) {
                return x.Salary.CompareTo(y.Salary);
            });

            return employees;
        }
        public List<Employee> EmployeeSearchName(string userName)
        {
            Employee employee = new Employee()
            {
                UserName = userName
            };
            this.employeeDataAccess = new EmployeeDataAccess();
            return this.employeeDataAccess.EmployeeSearchName(employee);
        }
    

    }
}
