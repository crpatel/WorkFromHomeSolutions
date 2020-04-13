using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPageDemo
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
            {
                linkLogin.Text = "Login";
            }
            else
            {
                lblWelcomeMessage.Text = $"Welcome {Session["username"]}";
                linkLogin.Text = "Logout";
            }
        }

        public Label LblWelcomeMessage
        {
            get
            {
                return lblWelcomeMessage;
            }
        }
        public LinkButton LinkLogin { get { return linkLogin; } }

        protected void linkLogin_Click(object sender, EventArgs e)
        {
            if (linkLogin.Text == "Login")
            {
                Response.Redirect("WebForm2.aspx");
            }
            else
            {
                Session["Username"] = null;
                Response.Redirect("WebForm2.aspx");
            }
        }
    }
}