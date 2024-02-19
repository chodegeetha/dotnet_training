using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Drawing;

namespace Crud_mvc_withado1.Models
{
    public class Articledb
    {

        
        public static bool InsertArticle(string Title, string content, DateTime publishedDate, DateTime lastModifiedDate)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.CommandText = @"INSERT INTO ArticleTab ( Title, Content, PublishedDate, LastModifiedDate) 
                                VALUES ( @Title, @Content, @PublishedDate, @LastModifiedDate)";
               
                cmd.Parameters.AddWithValue("@Title", Title);
                cmd.Parameters.AddWithValue("@Content", content);
                cmd.Parameters.AddWithValue("@PublishedDate", publishedDate);
                cmd.Parameters.AddWithValue("@LastModifiedDate", lastModifiedDate);


                int rows = cmd.ExecuteNonQuery();
                conn.Close();
                if (rows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static List<Articlemodel> GetArticleById(int articleId)
        {
            List<Articlemodel> articles = new List<Articlemodel>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("Select * from ArticleTab  WHERE ArticleId = @ArticleId ", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@articleId", articleId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Articlemodel article = new Articlemodel
                            {
                                ArticleId = Convert.ToInt32(reader["articleId"]),
                                Title = reader["Title"].ToString(),
                                Content = reader["content"].ToString(),
                                PublishedDate = Convert.ToDateTime(reader["publishedDate"]),
                                LastModifiedDate = Convert.ToDateTime(reader["lastModifiedDate"])
                            };

                            articles.Add(article);
                        }
                    }
                }
            }

            return articles;
        }

        public static List<Articlemodel> GetAllArticles()
        {
            List<Articlemodel> articles = new List<Articlemodel>();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("Select * from ArticleTab", conn))
                {
                    cmd.CommandType = CommandType.Text;


                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Articlemodel article = new Articlemodel
                            {
                                ArticleId = Convert.ToInt32(reader["articleId"]),
                                Title = reader["Title"].ToString(),
                                Content = reader["content"].ToString(),
                                PublishedDate = Convert.ToDateTime(reader["publishedDate"]),
                                LastModifiedDate = Convert.ToDateTime(reader["lastModifiedDate"])
                            };

                            articles.Add(article);
                        }
                    }
                }
            }

            return articles;
        }
        public static bool UpdateArticle(int? articleId, string title, string content, DateTime publishedDate, DateTime lastModifiedDate)
        {
            if (!articleId.HasValue)
            {
                // Handle the case where articleId is not provided
                return false;
            }

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("UPDATE ArticleTab SET Title = @Title, Content = @Content, PublishedDate = @PublishedDate, LastModifiedDate = @LastModifiedDate WHERE ArticleId = @ArticleId", conn))
                {
                    cmd.Parameters.AddWithValue("@ArticleId", articleId.Value);
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@Content", content);
                    cmd.Parameters.AddWithValue("@PublishedDate", publishedDate);
                    cmd.Parameters.AddWithValue("@LastModifiedDate", lastModifiedDate);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

      /*  public static bool UpdateArticle(int articleId, string Title, string content, DateTime publishedDate, DateTime lastModifiedDate)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("UPDATE ArticleTab SET Title = @Title, Content = @Content, PublishedDate = @PublishedDate, LastModifiedDate = @LastModifiedDate WHERE ArticleId = @ArticleId", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ArticleId", articleId);
                    cmd.Parameters.AddWithValue("@Title", Title);
                    cmd.Parameters.AddWithValue("@Content", content);
                    cmd.Parameters.AddWithValue("@PublishedDate", publishedDate);
                    cmd.Parameters.AddWithValue("@LastModifiedDate", lastModifiedDate);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
*/
        public static bool DeleteArticle(int articleId)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString))
            {


                conn.Open();

                using (SqlCommand cmd = new SqlCommand("DELETE FROM ArticleTab WHERE ArticleId = @ArticleId", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@articleId", articleId);

                    int rows = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (rows > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}


