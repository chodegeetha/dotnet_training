using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET
{
    public class Select
    {
        public static void SelectCategories()
        {

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn1"].ConnectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Category_Table";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int categoryId = (int)reader["CategoryId"];
                                string name = (string)reader["Name"];
                                string description = (string)reader["Description"];

                                Console.WriteLine($"Category ID: {categoryId}, Name: {name}, Description: {description}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No categories found.");
                        }
                        conn.Close();

                    }
                    Console.ReadLine();
                }
            }
        }



        // Example using DataAdapter and DataSet
        public static void Selectuser()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn1"].ConnectionString))
            {
                conn.Open();
                string query = "SELECT * FROM User_Table";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                DataTable userTable = dataSet.Tables[0]; // If multiple tables we can write another datatable
                if (userTable != null && userTable.Rows.Count > 0)
                {
                    foreach (DataRow row in userTable.Rows)
                    {
                        Console.WriteLine($"UserId: {row["UserId"]}, Username: {row["Username"]}, Email: {row["Email"]}");

                    }
                }
                else
                {
                    Console.WriteLine("No users found.");
                }
                conn.Close();

            }
            Console.ReadLine();
        }
    }
}
       











                    