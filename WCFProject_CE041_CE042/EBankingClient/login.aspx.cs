using EBankingClient.ServiceReference2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EBankingClient
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        ServiceReference2.AccountServiceClient client;

        protected void Button1_Click(object sender, EventArgs e)
        {
            client = new ServiceReference2.AccountServiceClient();

        
                Users userinfo = new Users();
                userinfo.Email = TextBox1.Text;
                userinfo.Password = TextBox2.Text;
            if (TextBox1.Text == "admin" && TextBox2.Text == "admin")
            {
                Response.Redirect("Employee.aspx");
            }
            else
            {
                List<string> msg = client.LoginUserDetails(userinfo).ToList();
                //Label3.Text = "Employee Name = " + msg.ElementAt(0) + " Employee Id = " + msg.ElementAt(1);
                if (msg.Count != 0)
                {
                    Session["Email"] = msg.ElementAt(0);
                    Response.Redirect("Home.aspx");

                }
                else
                {
                    Label3.Text = "Enter the Valid Credentials!!!";
                    Thread.Sleep(5000);
                    Response.Redirect("login.aspx");

                }
            }
            

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }
    }
}