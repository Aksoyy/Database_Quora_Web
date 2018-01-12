using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        Quora.QuaraClient client = new Quora.QuaraClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SessionKey"] != null)
            {
                laName.Text = String.Concat(client.GetUserInfo(Session["SessionKey"].ToString()).Name , ",");
            }
        }

        protected void btRegisterUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("/RegisterUser.aspx");
        }

        protected void btLogin_Click(object sender, EventArgs e)
        {
            string userName = teUserName.Text;
            string password = tePassword.Text;

            // Quora.QuaraClient client = new Quora.QuaraClient();
            string sessionKey = client.Login(userName, password);
            if (!String.IsNullOrEmpty(sessionKey))
            {
                Session["SessionKey"] = sessionKey;
                laName.Text = String.Concat(client.GetUserInfo(sessionKey).Name, ",");
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {

            string sessionKey = Session["SessionKey"]?.ToString();

            if (!String.IsNullOrEmpty(sessionKey))
            {
                client.Logout(sessionKey);
                Session["SessionKey"] = null;
                Response.Redirect("~/Default.aspx");
            }
        }

        protected void btnProfileUpdate_Click(object sender, EventArgs e)
        {
            Response.Redirect("/UpdateUser.aspx");
        }

        protected void btnChangePassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("/ChangePassword.aspx");
        }

    }
}