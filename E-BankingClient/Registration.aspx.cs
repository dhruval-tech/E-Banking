using E_BankingClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;




namespace E_BankingClient
{
    public partial class CustomerInsert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = false;
        }

        ServiceReference1.AccountServiceClient client; 

        protected void Button1_Click(object sender, EventArgs e)
        {
           client = new ServiceReference1.AccountServiceClient();
            Users cs = new Users();
            cs.FirstName = fn.Text;
            cs.LastName = ln.Text;
            cs.Email = email.Text;
            cs.Address = addr.Text;
            cs.Balance = int.Parse(bal.Text);
            cs.Contact = cont.Text;
            cs.Password = pswd.Text;

            string r = client.Insert(cs);

            Label1.Visible = true;
            Label1.Text = r.ToString();
        }

      
    }
}