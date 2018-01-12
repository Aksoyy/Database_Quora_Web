using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            System.Net.Mail.MailMessage mailMessage = new System.Net.Mail.MailMessage();

            mailMessage.From = new System.Net.Mail.MailAddress("gonderen@gmail.com", "Gönderen Firma Adı");
            mailMessage.Subject = "İletişim Formu: " + this.txtFullName.Text;

            mailMessage.To.Add("alici@firmaadi.com,digeralici@gmail.com");

            string body;
            body = "Ad Soyad: " + this.txtFullName.Text + "<br />";
            body += "Telefon: " + this.txtPhone.Text + "<br />";
            body += "E-posta: " + this.txtEmail.Text + "<br />";
            body += "Konu: " + this.txtSubject.Text + "<br />";
            body += "Mesaj: " + this.txtMessage.Text + "<br />";
            body += "Tarih: " + DateTime.Now.ToString("dd MMMM yyyy") + "<br />";
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = body;

            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new System.Net.NetworkCredential("gonderen@gmail.com", "gondereninmailsifresi");
            smtp.EnableSsl = true;
            smtp.Send(mailMessage);
            Information.Text = "Mesajınız gönderildi. Teşekkür ederiz.";
        }
    }
}