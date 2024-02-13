using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;

namespace Studentpractice
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            selectstudent();
        }

        protected void Btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Students (StudentName, StudentAge, StudentMarks, StudentDept) VALUES (@StudentName, @StudentAge, @StudentMarks, @StudentDept)", con);
                cmd.Parameters.AddWithValue("@StudentName", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@StudentAge", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@StudentMarks", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@StudentDept", TextBox4.Text.Trim());
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                if (rows > 0)
                {
                    Response.Write("<Script>alert('Inserted successfully');</Script>");

                }
                else
                {
                    Response.Write("<Script>alert('Try Again of Insertion');</Script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write($"<Script>alert('An error occurred: {ex.Message}');</Script>");
            }
        }


        void selectstudent()
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Students", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView2.DataSource = dt;
                GridView2.DataBind();
                con.Close();

            }
            catch (Exception ex)
            {
                Response.Write($"<Script>alert('An error occurred: {ex.Message}');</Script>");
            }
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Linkbtndelete_Click(object sender, EventArgs e)
        {

        }

        protected void Btnupdate_Click(object sender, EventArgs e)
        {
        }

        protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView2.EditIndex = e.NewEditIndex;
            selectstudent();
        }

        protected void GridView2_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView2.DataKeys[e.RowIndex].Value.ToString());
            string StudentName = ((TextBox)GridView2.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            int age = Convert.ToInt32(((TextBox)GridView2.Rows[e.RowIndex].Cells[2].Controls[0]).Text);
            int marks = Convert.ToInt32(((TextBox)GridView2.Rows[e.RowIndex].Cells[3].Controls[0]).Text);
            string dept = ((TextBox)GridView2.Rows[e.RowIndex].Cells[4].Controls[0]).Text;


            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Students set StudentName=@StudentName,StudentAge=@StudentAge,StudentMarks=@StudentMarks,StudentDept=@StudentDept Where StudentId=@StudentId", con);
                cmd.Parameters.AddWithValue("@StudentName", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@StudentAge", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@StudentMarks", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@StudentDept", TextBox4.Text.Trim());

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    Response.Write("<script> alert('updated succesfully');</script>");
                    GridView2.EditIndex = -1;
                    selectstudent();
                }
                else
                {
                    Response.Write("<script>alert('Try Again of Insertion');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write($"<Script>alert('An error occurred: {ex.Message}');</Script>");
            }
        }

        protected void GridView2_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView2.EditIndex = -1;
            selectstudent();
        }

        protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView2.DataKeys[e.RowIndex].Value.ToString());
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete from Students Where StudentId=@StudentId", con);
                cmd.Parameters.AddWithValue("@StudentId", id);
               

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    Response.Write("<script> alert('deleted succesfully');</script>");
                    GridView2.EditIndex = -1;
                    selectstudent();
                }
                else
                {
                    Response.Write("<script>alert('Try Again of deletion');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write($"<Script>alert('An error occurred: {ex.Message}');</Script>");
            }
        }

    }
}


   