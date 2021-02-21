using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EBankingClient.ServiceReference3;

namespace EBankingClient
{
    public partial class Transaction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        ServiceReference3.TransactionServiceClient proxy;
        protected void Button1_Click(object sender, EventArgs e)
        {
            proxy = new ServiceReference3.TransactionServiceClient();

            ServiceReference3.Transaction ts = new ServiceReference3.Transaction();
            ts.Name = TextBox1.Text;
            ts.From = Session["Email"].ToString();
            ts.To = TextBox2.Text;
            ts.Money = Int32.Parse(TextBox3.Text);


            string msg = proxy.DoTransac(ts);
            Label4.Text = msg;


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}