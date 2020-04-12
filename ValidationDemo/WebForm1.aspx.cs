using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ValidationDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            
            if(txtPassword.Text.Contains("@"))
            {
                Response.Write("Server side validattion : Fail");
                args.IsValid = false;
            }
            else
            {
                Response.Write("Server side validattion : Success");
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if(this.IsValid)
            {
                Response.Write("data saved");

            }
        }
    }
}