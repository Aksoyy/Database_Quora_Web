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
    public partial class WebForm15 : System.Web.UI.Page
    {
        Quora.QuaraClient client = new Quora.QuaraClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SessionKey"] == null)
            {
                Response.Redirect("./Error.aspx");
            }
            else
            {
                GetSearchList();
            }
        }
        private void GetSearchList()
        {
            long categoryId = Convert.ToInt32(Request.QueryString["CategoryId"].ToString());
            long languageId = Convert.ToInt32(Request.QueryString["LanguageId"].ToString());
            string word = Request.QueryString["Filter"].ToString();

            List<QuestionInfo> searchList = client.Search(categoryId, languageId, word, Session["Sessionkey"].ToString())?.ToList();

            DataTable dt = new DataTable();
            if (searchList != null)
            {
                dt.Columns.Add(new DataColumn("RESULT", typeof(string)));

                foreach (QuestionInfo item in searchList)
                {
                    var row = dt.NewRow();
                    row["RESULT"] = String.Concat("<a href='QuestionForm.aspx?Id=", item.QuestionId, "'>", item.Title, "</a>", "<br><hr>", item.Description);
                    dt.Rows.Add(row);
                }
            }
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }
    }
}