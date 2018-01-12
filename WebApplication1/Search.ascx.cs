using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Quora;

namespace WebApplication1
{
    public partial class Search : System.Web.UI.UserControl
    {
        Quora.QuaraClient client = new Quora.QuaraClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                List<LanguageInfo> languageList = client.GetLanguageList()?.ToList();
                dLanguageList.DataSource = languageList;
                dLanguageList.DataTextField = "Name";
                dLanguageList.DataValueField = "LanguageId";
                dLanguageList.DataBind();

                List<CategoryInfo> categoryList = client.GetCategoryList()?.ToList();
                dCategoryList.DataSource = categoryList;
                dCategoryList.DataTextField = "Name";
                dCategoryList.DataValueField = "CategoryId";
                dCategoryList.DataBind();
            }
        }

        protected void btSearch_Click(object sender, EventArgs e)
        {
            string word = teWord.Text;
            long categoryId = Convert.ToInt32(dCategoryList.SelectedValue); 
            long languageId = Convert.ToInt32(dLanguageList.SelectedValue);

            Response.Redirect(String.Format("~/Questions/SearchForm.aspx?CategoryId={0}&LanguageId={1}&Filter={2}", categoryId, languageId, word));
        }
    }
}