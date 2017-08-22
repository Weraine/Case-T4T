using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Case_T4T_WebShop.cs
{
    public static class Connection
    {
        private static SqlConnection conn;
        private static SqlCommand command;

        static Connection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SandwichShopConnectionString"].ToString();
            conn = new SqlConnection(connectionString);
            command = new SqlCommand("", conn);
        }
        public static ArrayList GetSandwiches()
        {
            ArrayList list = new ArrayList();
            string query = string.Format("SELECT * FROM Sandwich");

            try
            {
                conn.Open();
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    string details = reader.GetString(2);
                    double price = reader.GetDouble(3);

                    Sandwich sandwich = new Sandwich(id,name,details,price);
                    list.Add(sandwich);
                }
            }
            finally
            {
                conn.Close();
            }

            return list;
        }
        public static Sandwich GetSandwichById(int id)
        {
            string query = String.Format("SELECT * FROM Sandwich WHERE id =  '{0}'", id);
            Sandwich sandwich = null;

            try
            {
                conn.Open();
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int Id = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    string details = reader.GetString(2);
                    double price = reader.GetDouble(3);

                    sandwich = new Sandwich(Id, name,details,price);
                }
            }
            finally
            {
                conn.Close();
            }

            return sandwich;
        }

    }
}