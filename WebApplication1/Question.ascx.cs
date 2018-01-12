using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Question : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTheNewests_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Questions/TheNewests.aspx");
        }

        protected void btnMyFavorites_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Questions/MyFavorites.aspx");
        }

        protected void btnMostAnswered_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Questions/MostAnswered.aspx");
        }

        protected void btnMyQuestions_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Questions/MyQuestions.aspx");
        }

        protected void btnLanguageQuestion_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Questions/LanguageQuestion.aspx");
        }
        
    }
}