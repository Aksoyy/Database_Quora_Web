using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        Quora.QuaraClient client = new Quora.QuaraClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SessionKey"] == null)
                Response.Redirect("~/Error.aspx");
        }

        protected void btOk_Click(object sender, EventArgs e)
        {
            string sessionKey = Session["SessionKey"].ToString();
            if (!String.IsNullOrEmpty(sessionKey))
            {
                string oldPassword = tePassword.Text;
                string newPassword1 = tePassword1.Text;
                string newPassword2 = tePassword2.Text;

                if (newPassword1 == newPassword2)
                {
                    if (client.ChangePassword(oldPassword, newPassword1, sessionKey))
                    {
                        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Başlık", "<script>alert('Şifreniz değiştirilmiştir.');</script>");
                    }
                    else
                    {
                        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Başlık", "<script>alert('Eski şifrenizi kontrol ediniz.');</script>");
                    }
                }
                else
                {
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Başlık", "<script>alert('Girilen şifreler aynı değildir.');</script>");
                    //Information.Text = "Mesajınız gönderildi. Teşekkür ederiz."; 
                }

            }
        }
    }
}