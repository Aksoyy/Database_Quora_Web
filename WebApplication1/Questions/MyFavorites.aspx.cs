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
    public partial class WebForm7 : System.Web.UI.Page
    {
        Quora.QuaraClient client = new Quora.QuaraClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                List<CategoryInfo> categoryList = client.GetCategoryList()?.ToList();
                dCategoryList.DataSource = categoryList;
                dCategoryList.DataTextField = "Name";
                dCategoryList.DataValueField = "CategoryId";
                dCategoryList.DataBind();
            }
            GetQuestionListCategory();
        }

        private void GetQuestionListCategory()
        {
            long categoryId = Session["CategoryId"] != null ? Convert.ToInt32(Session["CategoryId"].ToString()) : -1;
            List<QuestionInfo> questionInfoList = client.GetQuestionListByCategoryId(categoryId, Session["SessionKey"].ToString())?.ToList();
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

        protected void btGetCategory_Click(object sender, EventArgs e)
        {
            long categoryId = Convert.ToInt32(dCategoryList.SelectedValue);
            if (categoryId > 0)
            {
                Session["CategoryId"] = categoryId;
                GetQuestionListCategory();
            }
        }


        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }
    }
}