using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EBankingClient
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session["Email"].ToString();
        }

        protected void Profile_Click(object sender, EventArgs e)
        {
            string email = Session["Email"].ToString();
            if (email != null)
            {
                Response.Redirect("Profile.aspx");
            }
            else {
                Response.Redirect("login.aspx");

            }
        }

        protected void Transaction_Click(object sender, EventArgs e)
        {
            string email = Session["Email"].ToString();
            if (email != null)
            {
                Response.Redirect("Transaction.aspx");
            }
            else
            {
                Response.Redirect("login.aspx");

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["Email"] = null;
            Response.Redirect("login.aspx");
        }
    }
}