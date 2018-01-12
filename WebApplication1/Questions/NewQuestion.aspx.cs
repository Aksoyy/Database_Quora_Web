using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Quora;

namespace WebApplication1
{
    public partial class WebForm12 : System.Web.UI.Page
    {
        Quora.QuaraClient client = new Quora.QuaraClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                List<CategoryInfo> categoryList = client.GetCategoryList()?.ToList();
                List<LanguageInfo> languageList = client.GetLanguageList()?.ToList();
                dCategoryList.DataSource = categoryList;
                dCategoryList.DataTextField = "Name";
                dCategoryList.DataValueField = "CategoryId";
                dCategoryList.DataBind();
                dLanguageList.DataSource = languageList;
                dLanguageList.DataTextField = "Name";
                dLanguageList.DataValueField = "LanguageId";
                dLanguageList.DataBind();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Session["SessionKey"] != null) //Giriş kontrol edilmektedir.
            {
                string title = teTitle.Text;
                string description = teDescription.Text;
                int languageId = Convert.ToInt32(dLanguageList.SelectedValue);
                int categoryId = Convert.ToInt32(dCategoryList.SelectedValue);
                string sessionKey = Session["SessionKey"].ToString();

                client.NewQuestion(title, description, languageId, categoryId, sessionKey);

                Page.ClientScript.RegisterClientScriptBlock(GetType(), "Başlık", "<script>alert('Sorunuz gönderilmiştir.');</script>");

                Response.Redirect("~/Default.aspx");
 


            }
        }
    }
}