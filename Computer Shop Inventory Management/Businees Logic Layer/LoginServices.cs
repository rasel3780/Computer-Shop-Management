using Computer_Shop_Inventory_Management.Data_Access_Layer;
using Computer_Shop_Inventory_Management.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Shop_Inventory_Management.Businees_Logic_Layer
{
    class LoginServices
    {
        LoginDataAccess loginDataAccess;
        public LoginServices()
        {
            this.loginDataAccess = new LoginDataAccess();
        }
        public string LoginCheck(string username, string password)
        {
            Employee employee = new Employee()
            {
                UserName = username,
                Password = password
            };

            return loginDataAccess.LoginValidation(employee);
        }

        public string ReturnEmployeeType(string username, string password)
        {
            Employee employee = new Employee()
            {
                UserName = username,
                Password = password
            };

            return loginDataAccess.ReturnEmployeeType(employee);
        }
    }
}
