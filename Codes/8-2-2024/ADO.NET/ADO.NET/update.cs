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
    public class update
    {

        public static void UpdateCategory(int categoryId, string name, string description)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn1"].ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                   
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.CommandText = @"UPDATE Category_Table 
                                    SET Name = @Name, Description = @Description
                                    WHERE CategoryId = @CategoryId";

                    cmd.Parameters.AddWithValue("@CategoryId", categoryId);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Description", description);


                    
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Category updated successfully.");
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
        public static void UpdateUserDetails(int userId, string username, string email)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn1"].ConnectionString))
            {
               conn.Open();
                using (SqlCommand cmd = new SqlCommand("updatedetails", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Email", email);

                    
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("User details updated successfully");
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
                   
      