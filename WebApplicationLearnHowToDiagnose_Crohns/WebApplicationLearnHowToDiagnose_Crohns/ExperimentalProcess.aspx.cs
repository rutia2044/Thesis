using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class ExperimentalProcess : System.Web.UI.Page
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
            }
            }

        protected void BtnNext_Click(object sender, EventArgs e)
        {
            String ClickTime = DateTime.Now.ToString("h:mm:ss tt");
            HttpContext.Current.Session["ExperimentalProcessClick"] = ClickTime;
            // Response.Redirect("~/ExampleOnTheModelPage.aspx");
            Response.Redirect("~/DiagramExplanation.aspx");
        }
    }
}