using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Shop_Inventory_Management.Data_Access_Layer
{
        class DataAccess : IDisposable
        {
            protected SqlConnection connection;
            protected SqlCommand command;

            public DataAccess()
            {
                try
                {
                    this.connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ComputerInventoryManagement"].ConnectionString);
                    this.connection.Open();
                }
                catch (Exception exp)
                {

                }
            }

            public SqlDataReader GetData(string sql)
            {
                this.command = new SqlCommand(sql, connection);
                return this.command.ExecuteReader();
            }
            public int ExecuteQuery(string sql)
            {
                try
                {
                    this.command = new SqlCommand(sql, connection);

                }
                catch (Exception e)
                {
                    //MessageBox.Show(e.Message);
                }
                return this.command.ExecuteNonQuery();
            }

            public void Dispose()
            {
                this.connection.Close();
            }

            ~DataAccess()
            {
                //this.connection.Close();
            }
        }
}
