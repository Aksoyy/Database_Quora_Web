using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        Quora.QuaraClient client = new Quora.QuaraClient();
        protected void Page_Load(object sender, EventArgs e)
        {
          // page load her sayfa açıldığında yenilendiğinde çalışır.
        }

        protected void btOk_Click(object sender, EventArgs e)
        {
            string name = teName.Text;
            string lastName = teLastName.Text;
            string surname = teSurname.Text;
            string nationalityTypeCd = teNationality.Text;
            string userName = teUsername.Text;
            string password = tePassword.Text;

            if (!String.IsNullOrEmpty(userName) && !String.IsNullOrEmpty(password)) //Kayıttaki username ve şifre girilme kontrol işlemidir.
            {
                if (client.RegisterUser(name, lastName, surname, nationalityTypeCd, userName, password))
                {
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Kayıt İşlemi", "<script>alert('Kaydınız tamamlandı.');</script>");
                    //Kayıt islemi mesajıdır.

                }
                else
                {
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Uyarı", "<script>alert('Kullanıcı adı kullanılmaktadır. Lütfen kullanıcı adınızı değiştiriniz.');</script>");
                }
            }
            else
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Uyarı", "<script>alert('Lütfen kullanıcı adı ve şifreniz boş olmamalıdır.');</script>");
            }
        }
    }
}