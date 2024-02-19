using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Firstweb_wcf_
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        ServiceReference1.Service1Client client=new ServiceReference1.Service1Client();

        protected void Button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(TextBox1.Text);
            double b= double.Parse(TextBox2.Text);
            TextBox3.Text=client.add(a,b).ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox3.Text = client.sub(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text)).ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox3.Text = client.mul(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text)).ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            TextBox3.Text = client.div(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text)).ToString();
        }
    }
}