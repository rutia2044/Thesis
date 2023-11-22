using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class TransitionFromLearningToExam : System.Web.UI.Page
    {
        public void SetPageNoCache()
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
            Response.Cache.SetAllowResponseInBrowserHistory(false);
            Response.Cache.SetNoStore();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               

                    SetPageNoCache();

                    /* ExplanationLable.Text = " At the diagnosis phase:" + "<br/>" +
                         "Left column- contains patient data." + "<br/>" +
                         "Right column- your diagnosis:" + "<br/>"+
                         " * Suspected Cancer / Normal" + "<br/>" +
                         " * Which patient characteristics were used in the diagnosis" + "<br/>" ;
                    */

                }
            else
            {
                // בצע את שאר הפעולות
            }
        }

        protected void BtnBeginTest_Click(object sender, EventArgs e)
        {

            String ClickTime = DateTime.Now.ToString("h:mm:ss tt");
            HttpContext.Current.Session["TransitionFromLearningToExamClick"] = ClickTime;

            Response.Redirect("~/ExampleOfTest.aspx");
        }
    }
}