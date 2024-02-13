using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Billing2.update;

namespace Billing2
{
    public partial class update : Form
    {
        
        public update(int ItemId, string ItemName, int QNT, decimal ItemPrice)
        {
            InitializeComponent();
            textBox5.Text = Convert.ToString(ItemId);
            textBox5.ReadOnly = true;
            textBox1.Text = ItemName;
            textBox2.Text = Convert.ToString(QNT);
            textBox3.Text = Convert.ToString(ItemPrice);
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public void GetupdatedDetails(out string itemName, out int qnt, out decimal itemprice)
        {
            itemName = textBox1.Text;
            qnt = Convert.ToInt32(textBox2.Text);
            itemprice = Convert.ToDecimal(textBox3.Text);
        }

        private void Ok_Click(object sender, EventArgs e)
        {

           /* ItemId = Convert.ToInt32(textBox5.Text);
            ItemName = textBox1.Text;
            Qnt = Convert.ToInt32(textBox2.Text);
            ItemPrice = Convert.ToDecimal(textBox3.Text);
*/

            // Close the form
            this.DialogResult = DialogResult.OK;
        }

       


      
    }
}

        

            