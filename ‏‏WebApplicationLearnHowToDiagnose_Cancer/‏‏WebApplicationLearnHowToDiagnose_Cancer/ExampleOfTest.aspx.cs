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

                lblGenderT.Text = "Male";
                lblAge.Text = "Old";
                lblYearsSinceAcidTasteStart.Text = "Long_time";
                lblStonachPain.Text = "Medium";
                lblTakingStomachMed.Text = "Yes";
                lblChestPain.Text = "Medium";
                lblBurningChest.Text = "High";
                RadBtn_classification.SelectedIndex = 1;

                int NumTree = Convert.ToInt32(HttpContext.Current.Session["NumTree"].ToString());
               // int NumTree = 5;
                switch (NumTree)
                {
                    case 1:
                        CheckBoxList1.Items[0].Selected = true;

                        CheckBoxList1.Visible = false;
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[7]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[6]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[5]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[4]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[3]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[2]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[1]);
                        //CheckBoxList1.Items.Remove(CheckBoxList1.Items[0]);
                        Label_2_a.Visible = false;
                        lblStonachPain.Visible = false;
                        Label_2_b.Visible = false;
                        lblGenderT.Visible = false;
                        Label_3_a.Visible = false;
                        lblAge.Visible = false;
                        Label_3_b.Visible = false;
                        lblTakingStomachMed.Visible = false;
                        Label_3_c.Visible = false;
                        lblChestPain.Visible = false;
                        Label_3_d.Visible = false;
                        lblBurningChest.Visible = false;
                        Label_which.Visible = false;
                        Label20.Visible = false;
                        ExplainTheExampleLbl.Text = "<br/> The testing phase  will be done on a number of patients one after another." + "<br/>" +
                  " In each stage a specific patient's information is given(left column) and in the right column - You are asked to diagnose <strong>  based on the diagram you have learned </strong> :" + "<br/>" +
                    " &nbsp   &nbsp If the patient has suspected cancer or not.  " + "<br/>" +


            " <br/> In the following example we decided, According to the diagram we learned ,that the patient has <u> SUSPECTED CANCER. </u> (Because he has had acid taste for a long time) <br/>"; //And the patient's data we used for diagnosis according to the diagram we studied is: <u> How long acid taste exists </u>." + "<br/>";

                        break;
                    case 2:
                        CheckBoxList1.Items[0].Selected = true;
                        CheckBoxList1.Items[1].Selected = true;

                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[7]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[6]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[5]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[4]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[3]);
                        Label_3_a.Visible = false;
                        lblAge.Visible = false;
                        Label_3_b.Visible = false;
                        lblTakingStomachMed.Visible = false;
                        Label_3_c.Visible = false;
                        lblChestPain.Visible = false;
                        Label_3_d.Visible = false;
                        lblBurningChest.Visible = false;

                        ExplainTheExampleLbl.Text = "<br/> The testing phase  will be done on a number of patients one after another." + "<br/>" +
                " In each stage a specific patient's information is given(left column) and in the right column - You are asked to diagnose <strong>  based on the diagram you have learned </strong> :" + "<br/>" +
                  " &nbsp   &nbsp1. If the patient has suspected cancer or not.  " + "<br/>" +
                  "  &nbsp  &nbsp2.  Which  patient's data  are the basis of your diagnosis." + "<br/>" +

          " <br/> In the following example we decided, According to the diagram we learned ,that the patient has <u>SUSPECTED CANCER</u> .<br/> And the patient's data used for diagnosis according to the diagram we studied are: <u>How long acid taste exists </u>,  <u> Stomach pain level</u>." + "<br/>";

                        break;
                    case 3:

                        CheckBoxList1.Items[0].Selected = true;
                        CheckBoxList1.Items[1].Selected = true;
                        CheckBoxList1.Items[3].Selected = true;
                        ExplainTheExampleLbl.Text = "<br/> The testing phase  will be done on a number of patients one after another." + "<br/>" +
              " In each stage a specific patient's information is given(left column) and in the right column - You are asked to diagnose <strong>  based on the diagram you have learned </strong> :" + "<br/>" +
                " &nbsp   &nbsp1. If the patient has suspected cancer or not.  " + "<br/>" +
                "  &nbsp  &nbsp2.  Which  patient's data  are the basis of your diagnosis." + "<br/>" +

        " <br/> In the following example we decided, According to the diagram we learned ,that the patient has <u>SUSPECTED CANCER</u> .<br/>" +
        "And the patient's data used for diagnosis according to the diagram we studied are: <u> Age </u> , <u> How long acid taste exists </u> ,  <u> Stomach pain level </u>." + "<br/>";

                        break;
                    case 4:
                        CheckBoxList1.Items[0].Selected = true;
                        //CheckBoxList1.Items[1].Selected = true;
                       // CheckBoxList1.Items[2].Selected = true;
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[7]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[6]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[5]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[4]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[3]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[1]);
                        Label_2_a.Visible = false;
                        lblStonachPain.Visible = false;
                        //Label_2_b.Visible = false;
                       // lblGenderT.Visible = false;
                        Label_3_a.Visible = false;
                        lblAge.Visible = false;
                        Label_3_b.Visible = false;
                        lblTakingStomachMed.Visible = false;
                        Label_3_c.Visible = false;
                        lblChestPain.Visible = false;
                        Label_3_d.Visible = false;
                        lblBurningChest.Visible = false;

                        ExplainTheExampleLbl.Text = "<br/> The testing phase  will be done on a number of patients one after another." + "<br/>" +
                " In each stage a specific patient's information is given(left column) and in the right column <br/>" +
                "You are asked to diagnose <strong>  based on the diagram you have learned: </strong>" + "<br/>" +
                  " &nbsp   &nbsp1. If the patient has suspected cancer or not.  " + "<br/>" +
                  "  &nbsp  &nbsp2.  Which  patient's data  are the basis of your diagnosis." + "<br/>" +

          " <br/> In the following example we decided, According to the diagram we learned ,that the patient has <u>SUSPECTED CANCER</u> .<br/> And the patient's data used for diagnosis according to the diagram we studied are: <u>How long acid taste exists </u>." + "<br/>";

                        break;
                    case 5:
                        CheckBoxList1.Items[0].Selected = true;
                        CheckBoxList1.Items[1].Selected = true;
                        // CheckBoxList1.Items[2].Selected = true;
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[7]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[6]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[5]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[4]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[3]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[2]);
                        //Label_2_a.Visible = false;
                        //lblStonachPain.Visible = false;
                        Label_2_b.Visible = false;
                         lblGenderT.Visible = false;
                        Label_3_a.Visible = false;
                        lblAge.Visible = false;
                        Label_3_b.Visible = false;
                        lblTakingStomachMed.Visible = false;
                        Label_3_c.Visible = false;
                        lblChestPain.Visible = false;
                        Label_3_d.Visible = false;
                        lblBurningChest.Visible = false;

                        ExplainTheExampleLbl.Text = "<br/> The testing phase  will be done on a number of patients one after another." + "<br/>" +
                " In each stage a specific patient's information is given(left column) and in the right column <br/>" +
                "You are asked to diagnose <strong>  based on the diagram you have learned: </strong> " + "<br/>" +
                  " &nbsp   &nbsp1. If the patient has suspected cancer or not.  " + "<br/>" +
                  "  &nbsp  &nbsp2.  Which  patient's data  are the basis of your diagnosis." + "<br/>" +

          " <br/> In the following example we decided, According to the diagram we learned ,that the patient has <u>SUSPECTED CANCER</u> .<br/> And the patient's data used for diagnosis according to the diagram we studied are: <u>How long acid taste exists </u> , <u> Stomach pain level </u>." + "<br/>";

                        break;
                    default:
                        break;
                }
                /*
                if (NumTree == 1)
                {
                    CheckBoxList1.Items[0].Selected = true;
                    
                    CheckBoxList1.Visible = false;
                    CheckBoxList1.Items.Remove(CheckBoxList1.Items[7]);     
                    CheckBoxList1.Items.Remove(CheckBoxList1.Items[6]);
                    CheckBoxList1.Items.Remove(CheckBoxList1.Items[5]);
                    CheckBoxList1.Items.Remove(CheckBoxList1.Items[4]);
                    CheckBoxList1.Items.Remove(CheckBoxList1.Items[3]);
                    CheckBoxList1.Items.Remove(CheckBoxList1.Items[2]);
                    CheckBoxList1.Items.Remove(CheckBoxList1.Items[1]);
                    //CheckBoxList1.Items.Remove(CheckBoxList1.Items[0]);
                    Label_2_a.Visible = false;
                    lblStonachPain.Visible = false;
                    Label_2_b.Visible = false;
                    lblGenderT.Visible = false;
                    Label_3_a.Visible = false;
                    lblAge.Visible = false;
                    Label_3_b.Visible = false;
                    lblTakingStomachMed.Visible = false;
                    Label_3_c.Visible = false;
                    lblChestPain.Visible = false;
                    Label_3_d.Visible = false;
                    lblBurningChest.Visible = false;
                    Label_which.Visible = false;
                        Label20.Visible = false;
                    ExplainTheExampleLbl.Text = "<br/> The testing phase  will be done on a number of patients one after another." + "<br/>" +
              " In each stage a specific patient's information is given(left column) and in the right column - You are asked to diagnose <strong>  based on the diagram you have learned </strong> :" + "<br/>" +
                " &nbsp   &nbsp If the patient has suspected cancer or not.  " + "<br/>" +


        " <br/> In the following example we decided, According to the diagram we learned ,that the patient has <u> SUSPECTED CANCER. </u> (Because he has had acid taste for a long time) <br/>"; //And the patient's data we used for diagnosis according to the diagram we studied is: <u> How long acid taste exists </u>." + "<br/>";

                }
                else
                {
                    if (NumTree == 2)
                    {
                        CheckBoxList1.Items[0].Selected = true;
                        CheckBoxList1.Items[1].Selected = true;

                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[7]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[6]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[5]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[4]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[3]);
                        Label_3_a.Visible = false;
                        lblAge.Visible = false;
                        Label_3_b.Visible = false;
                        lblTakingStomachMed.Visible = false;
                        Label_3_c.Visible = false;
                        lblChestPain.Visible = false;
                        Label_3_d.Visible = false;
                        lblBurningChest.Visible = false;

                        ExplainTheExampleLbl.Text = "<br/> The testing phase  will be done on a number of patients one after another." + "<br/>" +
                " In each stage a specific patient's information is given(left column) and in the right column - You are asked to diagnose <strong>  based on the diagram you have learned </strong> :" + "<br/>" +
                  " &nbsp   &nbsp1. If the patient has suspected cancer or not.  " + "<br/>" +
                  "  &nbsp  &nbsp2.  Which  patient's data  are the basis of your diagnosis." + "<br/>" +

          " <br/> In the following example we decided, According to the diagram we learned ,that the patient has <u>SUSPECTED CANCER</u> .<br/> And the patient's data used for diagnosis according to the diagram we studied are: <u>How long acid taste exists </u>,  <u> Stomach pain level</u>." + "<br/>";

                    }
                    else //numTree=3
                    {

                        CheckBoxList1.Items[0].Selected = true;
                        CheckBoxList1.Items[1].Selected = true;
                        CheckBoxList1.Items[3].Selected = true;
                        ExplainTheExampleLbl.Text = "<br/> The testing phase  will be done on a number of patients one after another." + "<br/>" +
              " In each stage a specific patient's information is given(left column) and in the right column - You are asked to diagnose <strong>  based on the diagram you have learned </strong> :" + "<br/>" +
                " &nbsp   &nbsp1. If the patient has suspected cancer or not.  " + "<br/>" +
                "  &nbsp  &nbsp2.  Which  patient's data  are the basis of your diagnosis." + "<br/>" +

        " <br/> In the following example we decided, According to the diagram we learned ,that the patient has <u>SUSPECTED CANCER</u> .<br/>"+
        "And the patient's data used for diagnosis according to the diagram we studied are: <u> Age </u> , <u> How long acid taste exists </u> ,  <u> Stomach pain level </u>." + "<br/>";

                    }
                }

                */

               
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