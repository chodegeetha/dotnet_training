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
    internal class Delete
    {
        public static void DeleteCategory(int categoryId)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn1"].ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.CommandText = @"DELETE FROM Category_Table WHERE CategoryId = @CategoryId";
                    cmd.Parameters.AddWithValue("@CategoryId", categoryId);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Category deleted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("No rows were affected. Category may not exist.");
                    }
                    conn.Close();
                    Console.WriteLine(conn.State);
                }
                Console.Read();
            }
        }
        public static void DeleteUser(int userId)
        {

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn1"].ConnectionString))
            {
                conn.Open();
                Console.WriteLine(conn.State);
                using (SqlCommand cmd = new SqlCommand("DeleteUser", conn))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("User deleted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("No rows were affected. User may not exist.");
                    }
                    conn.Close();
                    Console.WriteLine(conn.State);
                }
                Console.Read();
            }

        }
    }
}

                    
               
       

