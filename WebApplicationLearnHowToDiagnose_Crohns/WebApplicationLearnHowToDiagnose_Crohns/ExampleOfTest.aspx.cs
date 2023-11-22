using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class ExampleOfTest : System.Web.UI.Page
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
                lblRectalMucusE.Text = "NO";
                lblFatigueE.Text = "YES";
                lblSuggerGI_ProblemsE.Text = "NO";
               
                lblBowelChangeE.Text = "YES";
                
                lblEverBennOverweightE.Text = "NO";
               
                RadBtn_classification.SelectedIndex = 1;

                int NumTree = Convert.ToInt32(HttpContext.Current.Session["NumTree"].ToString());
              //  int NumTree = 1;
                switch (NumTree)
                {
                    case 1:
                        lblRectalMucusE.Text = "YES";
                        CheckBoxList1.Items[0].Selected = true;

                        CheckBoxList1.Visible = false;
                       
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[5]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[4]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[3]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[2]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[1]);
                        //CheckBoxList1.Items.Remove(CheckBoxList1.Items[0]);
                        Label_2_a.Visible = false;
                        lblBowelChangeE.Visible = false;
                        Label_2_b.Visible = false;
                        lblFatigueE.Visible = false;
                        Label_3_a.Visible = false;
                        lblSuggerGI_ProblemsE.Visible = false;
                        Label_3_b.Visible = false;
                       // lblTakingStomachMed.Visible = false;
                       // Label_3_c.Visible = false;
                        lblEverBennOverweightE.Visible = false;
                        //Label_3_d.Visible = false;
                       // lblBurningChest.Visible = false;
                        Label_which.Visible = false;
                        Label20.Visible = false;

                        ExplainTheExampleLbl.Text = "<br/> The testing phase  will be done on a number of patients one after another." + "<br/>" +
                  " In each stage a specific patient's information is given(left column) and in the right column - You are asked to diagnose <strong>  based on the diagram you have learned </strong> :" + "<br/>" +
                    " &nbsp   &nbsp If the patient has suspected crohn's or not.  " + "<br/>" +


            " <br/> In the following example we decided, According to the diagram we learned ,that the patient has <u> SUSPECTED CROHN'S. </u> (Because he has had rectal mucus) <br/>"; //And the patient's data we used for diagnosis according to the diagram we studied is: <u> How long acid taste exists </u>." + "<br/>";

                        break;
                    case 2:
                       // lblRectalMucusE.Text = "NO";
                        CheckBoxList1.Items[0].Selected = true;
                        CheckBoxList1.Items[1].Selected = true;

                       
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[5]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[4]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[3]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[2]);
                        Label_3_a.Visible = false;
                        lblSuggerGI_ProblemsE.Visible = false;
                        Label_3_b.Visible = false;
                       // lblTakingStomachMed.Visible = false;
                        //Label_3_c.Visible = false;
                        lblEverBennOverweightE.Visible = false;
                        //Label_3_d.Visible = false;
                        // lblBurningChest.Visible = false;
                        Label_2_b.Visible = false;
                        lblFatigueE.Visible = false;
                        ExplainTheExampleLbl.Text = "<br/> The testing phase  will be done on a number of patients one after another." + "<br/>" +
                " In each stage a specific patient's information is given(left column) and in the right column - You are asked to diagnose <strong>  based on the diagram you have learned </strong> :" + "<br/>" +
                  " &nbsp   &nbsp1. If the patient has suspected crohn or not.  " + "<br/>" +
                  "  &nbsp  &nbsp2.  Which  patient's data  are the basis of your diagnosis." + "<br/>" +

          " <br/> In the following example we decided, According to the diagram we learned ,that the patient has <u>SUSPECTED CROHN</u> .<br/> And the patient's data used for diagnosis according to the diagram we studied are: <u> Is there rectal mucus </u>,<u> Is there bowel change </u>." + "<br/>";

                        break;
                    case 3:
                        CheckBoxList1.Items[0].Selected = true;
                        CheckBoxList1.Items[1].Selected = true;
                        CheckBoxList1.Items[2].Selected = true;
                      
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[5]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[4]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[3]);
                        //CheckBoxList1.Items.Remove(CheckBoxList1.Items[2]);
                        Label_3_a.Visible = false;
                        lblSuggerGI_ProblemsE.Visible = false;
                        Label_3_b.Visible = false;
                        // lblTakingStomachMed.Visible = false;
                        //Label_3_c.Visible = false;
                        lblEverBennOverweightE.Visible = false;
                        //Label_3_d.Visible = false;
                        // lblBurningChest.Visible = false;
                       // Label_2_b.Visible = false;
                       // lblFatigueE.Visible = false;
                        ExplainTheExampleLbl.Text = "<br/> The testing phase  will be done on a number of patients one after another." + "<br/>" +
              " In each stage a specific patient's information is given(left column) and in the right column - You are asked to diagnose <strong>  based on the diagram you have learned </strong> :" + "<br/>" +
                " &nbsp   &nbsp1. If the patient has suspected crohn or not.  " + "<br/>" +
                "  &nbsp  &nbsp2.  Which  patient's data  are the basis of your diagnosis." + "<br/>" +

     " <br/> In the following example we decided, According to the diagram we learned ,that the patient has <u>SUSPECTED CROHN</u> .<br/> And the patient's data used for diagnosis according to the diagram we studied are: <u> Is there rectal mucus </u>,<u> Is there bowel change </u>,  <u> Is there fatigue </u>." + "<br/>";


                        break;
                    case 4:
                        CheckBoxList1.Items[0].Selected = true;
                        CheckBoxList1.Items[1].Selected = true;
                        CheckBoxList1.Items[2].Selected = true;
                       

                        ExplainTheExampleLbl.Text = "<br/> The testing phase  will be done on a number of patients one after another." + "<br/>" +
                " In each stage a specific patient's information is given(left column) and in the right column <br/>" +
                "You are asked to diagnose <strong>  based on the diagram you have learned: </strong>" + "<br/>" +
                  " &nbsp   &nbsp1. If the patient has suspected crohn or not.  " + "<br/>" +
                  "  &nbsp  &nbsp2.  Which  patient's data  are the basis of your diagnosis." + "<br/>" +

          " <br/> In the following example we decided, According to the diagram we learned ,that the patient has <u>SUSPECTED CROHN</u> .<br/> And the patient's data used for diagnosis according to the diagram we studied are: <u> Is there rectal mucus </u>,<u> Is there bowel change </u>,  <u> Is there fatigue </u>." + "<br/>";

                        break;
                  
                    default:
                        break;
                }
                

               
             }
            else { }
        }

        protected void Btn1_Click(object sender, EventArgs e)
        {
            String ClickTime = DateTime.Now.ToString("h:mm:ss tt");
            HttpContext.Current.Session["ExampleOfTestClick"] = ClickTime;
            Response.Redirect("~/TestWebForm.aspx");
        }
    }
}