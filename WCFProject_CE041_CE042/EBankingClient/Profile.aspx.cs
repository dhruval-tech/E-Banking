using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EBankingClient.ServiceReference3;
using EBankingClient.ServiceReference2;


namespace EBankingClient
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference2.AccountServiceClient client;
            client = new ServiceReference2.AccountServiceClient();
            Users us = new Users();
            string email = Session["Email"].ToString();
            us = client.getUserbyID(email);
            Label1.Text = us.FirstName;
            Label2.Text = us.LastName;
            Label3.Text = us.Email;
            Label4.Text = us.Address;
            Label5.Text = us.Password;
            Label6.Text = (us.Balance).ToString();
            Label7.Text = us.Contact;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}