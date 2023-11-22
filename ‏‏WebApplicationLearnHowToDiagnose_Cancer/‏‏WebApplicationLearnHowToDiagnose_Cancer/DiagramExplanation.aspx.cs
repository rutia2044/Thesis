using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class DiagramExplanation : System.Web.UI.Page
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

                ExplainTheDiagramLbl.Text = "<br/>&nbsp The following diagram is an example that will help us to learn to determine how likely a specific patient has cancer based on his data." + "<br/>";
                // int NumTree = Convert.ToInt32(HttpContext.Current.Session["NumTree"].ToString());
                // Image1.ImageUrl = "~/Images/ExampleOfDiagram1.png";//Tree 1
                // Image1.ImageUrl = "~/Images/ExampleOfDiagram.png";//Tree2
                Image1.ImageUrl = "~/Images/IndepandentExampleDiagram.png";
                /*if (NumTree == 1)
                {
                    Image1.ImageUrl = "~/Images/ExampleOfDiagram1.png";
                    //  Image1.Height = Unit.Percentage(90);
                    //  Image1.Width = Unit.Percentage(90);

                }
                else
                {
                    if (NumTree == 2)
                        Image1.ImageUrl = "~/Images/ExampleOfDiagram.png";
                    else
                    {
                        Image1.ImageUrl = "~/Images/ExampleOfDiagram3.png";
                    }
                }
                */

            }
            else
            {
                // בצע את שאר הפעולות
            }
        
      }

        protected void BtnNext_Click(object sender, EventArgs e)
        {
            String ClickTime = DateTime.Now.ToString("h:mm:ss tt");
            HttpContext.Current.Session["DiagramEplanationClick"] = ClickTime;
            // Response.Redirect("~/ExampleOnTheModelPage.aspx");
            Response.Redirect("~/AnimationForm.aspx");
        }
    }
}