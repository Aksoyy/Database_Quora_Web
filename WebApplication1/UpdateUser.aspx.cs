using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Quora;

namespace WebApplication1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        Quora.QuaraClient client = new Quora.QuaraClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SessionKey"] == null)
                Response.Redirect("~/Error.aspx");
            else
            {   
                if (!Page.IsPostBack) //IsPostBack, sayfanın geri postalanması durumunu yönetir.
                {//Bu yapı sayfanın ilk kez yüklenmesi ile sonradan postback işlemi sonucunda yüklenmesi arasındaki farkı yönetmek için kullanılır.
                    UserInfo info = client.GetUserInfo(Session["SessionKey"].ToString());
                    teName.Text = info.Name;
                    teLastName.Text = info.LastName;
                    teSurname.Text = info.Surname;
                    teNationaltyTypeCd.Text = info.NationalityTypeCd;
                }
            }
        }

        protected void btOk_Click(object sender, EventArgs e)
        {
            string sessionKey = Session["SessionKey"].ToString();
            if (!String.IsNullOrEmpty(sessionKey))
            {
                string name = teName.Text;
                string lastName = teLastName.Text;
                string surname = teSurname.Text;
                string nationalityTypeCd = teNationaltyTypeCd.Text;
                if (client.UpdateUser(name, lastName, surname, nationalityTypeCd, sessionKey))
                {
                    string script = "alert(\"İşlem başarılı!\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    Response.Redirect("~/UpdateUser.aspx");
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Başlık", "<script>alert('İşlem başarılıdır.');</script>");

                }


            }
        }
    }
}