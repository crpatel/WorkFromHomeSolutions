using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPageDemo
{
    public partial class WebForm2 : System.Web.UI.Page
    {




        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
            {
                pnlLogin.Visible = false;
                pnlWelcome.Visible = true;
            }
            else
            {
                pnlLogin.Visible = true;
                pnlWelcome.Visible = false;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (validateUser())
            {
                lblErrorMessage.Visible = false;
                //TODO: Write welcome message
                //((Site1)Master).LblWelcomeMessage.Text = $"Welcome {Session["username"]}";
                pnlLogin.Visible = false;
                pnlWelcome.Visible = true;
                Master.LinkLogin.Text = "Logout";
                
            }
            else
            {
                lblErrorMessage.Visible = true;
            }
        }

        private bool validateUser()
        {
            //TODO: Check username and password from the database
            if (txtUserName.Text == "admin" && txtPassword.Text == "admin")
            {
                Session["Username"] = "Chirag";
                return true;
            }

            return false;
        }
    }
}