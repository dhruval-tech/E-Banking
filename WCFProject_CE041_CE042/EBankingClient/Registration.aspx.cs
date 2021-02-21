using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EBankingClient.ServiceReference2;


namespace EBankingClient
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        ServiceReference2.AccountServiceClient client;

        protected void Button1_Click(object sender, EventArgs e)
        {
            client = new ServiceReference2.AccountServiceClient();
            Users cs = new Users();
            cs.FirstName = fn.Text;
            cs.LastName = ln.Text;
            cs.Email = email.Text;
            cs.Address = addr.Text;
            cs.Balance = int.Parse(bal.Text);
            cs.Contact = cont.Text;
            cs.Password = pswd.Text;

            string r = client.Insert(cs);

            
            Response.Redirect("login.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");

        }
    }
}
