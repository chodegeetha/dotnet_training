using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace loginapp
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        string strcon = System.Configuration.ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            
                //Response.Write("<script> alert(' Button click');</script>");
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();

                    }
                    SqlCommand cmd = new SqlCommand("select * from UserTab where  UserName=@UserName AND Password=@Password", con);
                    cmd.Parameters.AddWithValue("@UserName", TextBox3.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", TextBox4.Text.Trim());
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Response.Write("<script>alert('Login Succesful');</script>");
                           
                            
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('Invalid credentials');</script>");
                    }

                }
                catch (Exception ex)
                {

                }
            
        }
    }
}




