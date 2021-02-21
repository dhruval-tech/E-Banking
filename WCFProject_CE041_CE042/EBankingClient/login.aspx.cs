using EBankingClient.ServiceReference2;
using System;
using System.Collections.Generic;
using System.Linq;
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

            try
            {
                Users userinfo = new Users();
                userinfo.Email = TextBox1.Text;
                userinfo.Password = TextBox2.Text;
                List<string> msg = client.LoginUserDetails(userinfo).ToList();
                //Label3.Text = "Employee Name = " + msg.ElementAt(0) + " Employee Id = " + msg.ElementAt(1);
                if (msg != null)
                {
                    Session["Email"] = msg.ElementAt(0);
                    Response.Redirect("Employee.aspx");

                }
                else {

                    Session["Email"] = null;
                    Response.Redirect("login.aspx");

                }
            }
            catch (Exception ex)
            {
                Label3.Text = "Wrong Id Or Password";
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }
    }
}