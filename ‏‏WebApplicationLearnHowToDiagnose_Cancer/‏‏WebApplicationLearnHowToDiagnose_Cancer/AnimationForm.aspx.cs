using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class AnimationForm : System.Web.UI.Page
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
            // int NumTree = Convert.ToInt32(HttpContext.Current.Session["NumTree"].ToString());

            // if (NumTree == 1)
            //{
            //   ExplainTheDiagramLbl1.Text = "<strong> In this case we see that this patient has: " +
            //    " Acid taste  for a<strong> <u> long time </u></strong>, " +
            //     " Therefore, the diagnosis is <u> SUSPECTED CANCER </u>. (as you can see in the last circle of the green path) </strong>";

            //  src1.Src = "~/Images/‏‏animation1.mp4";
            //    Image1.Height = Unit.Percentage(90);
            //    Image1.Width = Unit.Percentage(90);
            //   v1.
            // }
            // else
            // {
            //   if (NumTree == 2)
            //  {
            //  ExplainTheDiagramLbl1.Text = "<strong> In this case we see that this patient has: " +
            //            " Acid taste  for a<strong> <u> long time </u></strong>, " +
            //           "  and <u> Medium </u> stomach pain level.<br/>" +
            //          " Therefore, the diagnosis is <u> SUSPECTED CANCER </u>. (as you can see in the last circle of the green path) </strong>";

            //        src1.Src = "~/Images/animation2.mp4";
            /*   }
               else
               {
                   ExplainTheDiagramLbl1.Text = "<strong>  In this case we see that this patient has: " +
                       " Acid taste  for a<strong> <u> long time </u>, " +
                      "   and <u> Low </u> stomach pain level, " +
                      "   and <u> Low </u> chest pain level. <br/>" +
                      "  Therefore, the diagnosis is <u> SUSPECTED CANCER </u>. (as you can see in the last circle of the green path) </strong>";

                   src1.Src = "~/Images/‏‏animation3.mp4";
               }
           }*/
            //Indepandent Diagram
            ExplainTheDiagramLbl1.Text = "<strong> In this case we see that this patient has: " +
                     " cancer in the family (the answer is Yes) " +
                    "  and <u> Medium </u> Headache level.<br/>" +
                    " Therefore, the diagnosis is <u> SUSPECTED CANCER </u>. (as you can see in the last circle of the green path) </strong>";

            src1.Src = "~/Images/IndepandedAnimation.mp4";

        }
        protected void BtnNext_Click(object sender, EventArgs e)
        {
            String ClickTime = DateTime.Now.ToString("h:mm:ss tt");
            HttpContext.Current.Session["AnimationFormClick"] = ClickTime;
           // Response.Redirect("~/WebForm1.aspx");
            Response.Redirect("~/ExampleOnTheModelPage.aspx");
        }
    }
}