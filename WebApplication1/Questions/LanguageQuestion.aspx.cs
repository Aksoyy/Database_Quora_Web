using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Quora;

namespace WebApplication1
{
    public partial class WebForm14 : System.Web.UI.Page
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
            }
            GetQuestionListLanguage();
        }

        private void GetQuestionListLanguage()
        {
            long languageId = Session["LanguageId"] != null ? Convert.ToInt32(Session["LanguageId"].ToString()) : -1;
            List<QuestionInfo> questionInfoList = client.GetQuestionListByLanguageId(languageId, Session["SessionKey"].ToString())?.ToList();
            DataTable dt = new DataTable();
            if (questionInfoList != null)
            {
                dt.Columns.Add(new DataColumn("RESULT", typeof(string)));

                foreach (QuestionInfo item in questionInfoList)
                {
                    var row = dt.NewRow();
                    row["RESULT"] = String.Concat("<a href='QuestionForm.aspx?Id=", item.QuestionId, "'>", item.Title, "</a>", "<br><hr>", item.Description);
                    dt.Rows.Add(row);
                }
            }
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void btGetLanguage_Click(object sender, EventArgs e)
        {
            long languageId = Convert.ToInt32(dLanguageList.SelectedValue);
            if (languageId > 0)
            {
                Session["LanguageId"] = languageId;
                GetQuestionListLanguage();
            }
        }


        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }
    }
}