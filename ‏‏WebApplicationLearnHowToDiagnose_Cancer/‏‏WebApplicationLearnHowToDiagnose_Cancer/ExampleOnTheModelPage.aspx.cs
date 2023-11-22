using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class ExampleOnTheModelPage : System.Web.UI.Page
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
                ExplainTheExampleLabel.Text = "  &nbsp The learning process will be done in stages:" + "<br/>" +
                     "  &nbsp In each stage a specific patient's information is given in the <strong> left column</strong>.<br/>" +
                    "&nbsp In the<strong> right column </strong> , we display a diagram with patient's relevant information in logical order reaching a conclusion.(green path)<br/>" +
                "&nbsp Note: Sometimes the diagram on the right side is missing part of the patient’s data.";

                lblGender.Text = "Average";
                lblAge.Text = "Middle";
                lblYearsSinceAcidTasteStart.Text = "Yes";
                lblStonachPain.Text = "Medium";
                lblTakingStomachMed.Text = "Yes";
                lblChestPain.Text = "Low";
                lblBurningChest.Text = "Low";
                lblClassification.Text = "SUSPECTED CANCER";





/*
                int NumTree = Convert.ToInt32(HttpContext.Current.Session["NumTree"].ToString());
               int NumTree = 2;
                if (NumTree == 1)
               {
                  Image1.ImageUrl = "~/Images/ExampleOfDiagram1.png";
                
                  LabelStom_2_a.Visible = false;
                  lblStonachPain.Visible = false;
                  Label_2_b.Visible = false;
                  lblGender.Visible = false;
                  Label_3_a.Visible = false;
                  lblAge.Visible = false;
                  Label_3_b.Visible = false;
                  lblTakingStomachMed.Visible = false;
                  LabelChest_3_c.Visible = false;
                  lblChestPain.Visible = false;
                  Label_3_d.Visible = false;
                  lblBurningChest.Visible = false;
                }
                else
                {
                    if (NumTree == 2)
                    {
               
                        Image1.ImageUrl = "~/Images/ExampleOfDiagram.png";
                        LabelStom_2_a.BackColor = System.Drawing.Color.LightGreen;
                        lblStonachPain.BackColor = System.Drawing.Color.LightGreen;
                        Label_3_a.Visible = false;
                        lblAge.Visible = false;
                        Label_3_b.Visible = false;
                        lblTakingStomachMed.Visible = false;
                        LabelChest_3_c.Visible = false;
                        lblChestPain.Visible = false;
                        Label_3_d.Visible = false;
                        lblBurningChest.Visible = false;
                   }
                   else
                   {

                       Image1.ImageUrl = "~/Images/ExampleOfDiagram3.png";
                       LabelStom_2_a.BackColor = System.Drawing.Color.LightGreen;
                       lblStonachPain.BackColor = System.Drawing.Color.LightGreen;
                       lblStonachPain.Text = "Low";
                       LabelChest_3_c.BackColor = System.Drawing.Color.LightGreen;
                       lblChestPain.BackColor = System.Drawing.Color.LightGreen;
                   }
               }
            */

                Image1.ImageUrl = "~/Images/IndepandentExampleDiagram.png";
                LabelStom_2_a.BackColor = System.Drawing.Color.LightGreen;
                lblStonachPain.BackColor = System.Drawing.Color.LightGreen;
                Label_3_a.Visible = false;
                lblAge.Visible = false;
                Label_3_b.Visible = false;
                lblTakingStomachMed.Visible = false;
                LabelChest_3_c.Visible = false;
                lblChestPain.Visible = false;
                Label_3_d.Visible = false;
                lblBurningChest.Visible = false;
            }
            else
            {
                // בצע את שאר הפעולות
            }
        }

        protected void BtnBeginLearning_Click(object sender, EventArgs e)
        {
            String ClickTime = DateTime.Now.ToString("h:mm:ss tt");
            HttpContext.Current.Session["ExampleOnTheModelPageClick"] = ClickTime;
             Response.Redirect("~/TransitionToLearning.aspx");
            // Response.Redirect("~/WebForm1.aspx");
        }
    }
}