using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Quora;

namespace WebApplication1
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        Quora.QuaraClient client = new Quora.QuaraClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SessionKey"] == null)
            {
                Response.Redirect("~/Error.aspx");
            }
            else
            {
                long id = Convert.ToInt32(Request.QueryString["Id"].ToString());
                GetQuestionAnswerList(id);
            }
        }

        private void GetQuestionAnswerList(long id)
        {
            QuestionAnswerInfo info = client.GetAnswerListByQuestionId(id, Session["SessionKey"].ToString());

            if (info != null)
            {
                laTitle.Text = info.QuestionInfo.Title;
                laQuestionDesc.Text = info.QuestionInfo.Description;
                laQuestionNameSurname.Text = info.QuestionInfo.NameSurname;
                laQuestionCreationDate.Text = info.QuestionInfo.CreationDate.ToString();

                if (info.AnswerInfoList != null & info.AnswerInfoList.Length > 0)
                {
                    myRepeater.DataSource = info.AnswerInfoList;
                    myRepeater.DataBind();
                }
            }
        }

        protected void btAnswer_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["Id"].ToString());
            string description = teDescription.Value;
            client.AnswerByQuestionId(id, description, Session["SessionKey"].ToString());
            GetQuestionAnswerList(id);
        }
    }
}