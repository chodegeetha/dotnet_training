using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Security.Policy;

namespace Billing2
{
    public partial class Form1 : Form
    {

        void showTable()
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            conn.Open();

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from ItemSales";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dt;

            }


            conn.Close();
        }

        public Form1()
        {
            InitializeComponent();
            //dataGridView1.AutoGenerateColumns = true;
            showTable();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            conn.Open();

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                var ItemName = textBox1.Text;
                var Qnt = Convert.ToInt32(textBox2.Text);
                var ItemPrice = Convert.ToDecimal(textBox3.Text);
                var cst = Qnt * ItemPrice;

                cmd.CommandText = "insert into ItemSales(ItemName,Qnt,ItemPrice,Cost) values(@ItemName,@Qnt,@ItemPrice,@Cost)";

                cmd.Parameters.AddWithValue("@ItemName", ItemName);
                cmd.Parameters.AddWithValue("@Qnt", Qnt);
                cmd.Parameters.AddWithValue("@ItemPrice", ItemPrice);
                cmd.Parameters.AddWithValue("@Cost", cst);

                decimal sum = 0;
                for (int row = 0; row < dataGridView1.Rows.Count; row++)
                {
                    sum = sum + cst;
                }


                int rows = cmd.ExecuteNonQuery();
                if (rows < 0)
                {
                    Console.WriteLine("Failed to insert");
                }
                else
                    Console.WriteLine("Inserted Succesfully");

                conn.Close();
                showTable();


            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wordVoyagerDataSet.ItemSales' table. You can move, or remove it, as needed.
            this.itemSalesTableAdapter.Fill(this.wordVoyagerDataSet.ItemSales);
            showTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void PrintInvoice_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Retrieve the item details from the selected row
                int itemId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ItemId"].Value);
                string itemName = Convert.ToString(dataGridView1.SelectedRows[0].Cells["ItemName"].Value);
                int itemQuantity = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Qnt"].Value);
                decimal itemPrice = Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells["ItemPrice"].Value);



                // Display the "Edit Item" form
                update updateForm = new update(itemId, itemName, itemQuantity, itemPrice);
                DialogResult result = updateForm.ShowDialog();

                // If the user clicks "OK" in the update form, update the item in the database
                if (result == DialogResult.OK)
                {

                    updateForm.GetupdatedDetails(out string updatedItemName, out int updatedQNT, out decimal updatedItemPrice);
                    decimal updatedcost = updatedQNT * updatedItemPrice;

                    // Update the item in the database
                    UpdateItemInDatabase(itemId, updatedItemName, updatedQNT, updatedItemPrice, updatedcost);


                    showTable();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }
        void UpdateItemInDatabase(int itemId, string updatedItemName, int updatedQNT, decimal updatedItemPrice, decimal updatedcost)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            conn.Open();

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update ItemSales set ItemName=@updatedItemName, QNT=@updatedQNT, ItemPrice=@updatedItemPrice,Cost=@updatedcost  where ItemId=@ItemId";
                cmd.Parameters.AddWithValue("@updatedItemName", updatedItemName);
                cmd.Parameters.AddWithValue("updatedQNT", updatedQNT);
                cmd.Parameters.AddWithValue("@updatedItemPrice", updatedItemPrice);
                cmd.Parameters.AddWithValue("@ItemId", itemId);
                cmd.Parameters.AddWithValue("@updatedcost", updatedcost);

                int rows = cmd.ExecuteNonQuery();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Retrieve the item details from the selected row
                int ItemId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ItemId"].Value);
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from ItemSales where ItemId=@ItemId";
                    cmd.Parameters.AddWithValue("@ItemId", ItemId);
                    int row=cmd.ExecuteNonQuery();
                    if (row > 0)
                    {
                        showTable();
                    }
                }
                conn.Close();
            }
        }
    }
}

        
     

        

    


    
       