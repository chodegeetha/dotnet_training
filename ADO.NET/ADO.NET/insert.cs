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
   public class Insert
    {
        public static void insertcategory()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn1"].ConnectionString))
            {
                conn.Open();
                Console.WriteLine(conn.State);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.CommandText = @"INSERT INTO Category_Table (CategoryId, Name, Description)
                            VALUES
                               (71, 'Technology', 'Articles related to technology trends and innovations'),
                               (85, 'Travel', 'Explore travel destinations tips,and experiences')";

                // Execute the SQL command
                int _rows = cmd.ExecuteNonQuery();
                if (_rows > 0)
                {
                    Console.WriteLine("Categories Inserted succesfully");
                }
                else
                {
                    Console.WriteLine("failed to insert categories");
                }


                conn.Close();
                Console.WriteLine(conn.State);
            }
            Console.Read();
        }

        public static void InsertUser()
        {
           
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn1"].ConnectionString))
            {
                
                conn.Open();
                Console.WriteLine(conn.State);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.CommandText = @"INSERT INTO User_Table (UserId, Username, Email)
                            VALUES
                                (56, 'JohnDoe', 'john@example.com'),
                                (67, 'JaneDoe', 'jane@example.com')";

              
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Users inserted successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to insert users.");
                }
                conn.Close();
                Console.WriteLine(conn.State);
            }
            Console.Read();
        }




        public static void Insertsp(int articleId, string title, string content, DateTime publishedDate, DateTime lastModifiedDate, int authorId, int categoryId)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn1"].ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("Articledetails", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                   
                    cmd.Parameters.AddWithValue("@ArticleId", articleId);
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@Content", content);
                    cmd.Parameters.AddWithValue("@PublishedDate", publishedDate);
                    cmd.Parameters.AddWithValue("@LastModifiedDate", lastModifiedDate);
                    cmd.Parameters.AddWithValue("@AuthorId", authorId);
                    cmd.Parameters.AddWithValue("@CategoryId", categoryId);

                   
                    int _rows = cmd.ExecuteNonQuery();
                    if (_rows > 0)
                    {
                        Console.WriteLine("Articles Inserted succesfully");
                    }
                    else
                    {
                        Console.WriteLine("failed to insert- articles");
                    }


                    conn.Close();
                    Console.WriteLine(conn.State);
                }
                Console.Read();
            }
        }
    }
}
             



  
