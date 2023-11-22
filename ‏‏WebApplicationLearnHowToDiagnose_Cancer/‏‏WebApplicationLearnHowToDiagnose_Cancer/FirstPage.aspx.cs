using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
namespace WebApplication3
{

    public partial class FirstPage : System.Web.UI.Page
    {
        private readonly string NO_ID = "ASSIGNMENT_ID_NOT_AVAILABLE";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SetPageNoCache();
                if (Request.QueryString != null && Request.QueryString.Count > 0)
                {


                    string hitId = Request.QueryString["hitId"].ToString();


                    Session["HitId"] = hitId;

                    string assignmentId = Request.QueryString["assignmentId"].ToString();
                    Session["AssignmentId"] = assignmentId;

                    if (string.Compare(assignmentId, NO_ID, true) == 0)//preview mode
                    {
                        BtnNextPage1.Enabled = false;
                    }
                    else//accept mode
                    {
                        //HttpContext.Current.Session["NumTree"] = WebConfigurationManager.AppSettings["NumTree"].ToString();
                        //TODO: Save in the db the hit id and the worker id after submit!!
                        BtnNextPage1.Enabled = true;
                        String ClickTime = DateTime.Now.ToString("h:mm:ss tt");
                        HttpContext.Current.Session["FirstPageClick"] = ClickTime;

                        string workerId = Request.QueryString["workerId"].ToString();
                        HttpContext.Current.Session["UserId"] = workerId;
                    }
                }

                int precentPerUser = 60;
                float bonusPerUser = 0.6f;
                // HttpContext.Current.Session["NumTree"] = 2;
                HttpContext.Current.Session["NumTree"] = WebConfigurationManager.AppSettings["NumTree"].ToString();

                // int NumTree = Convert.ToInt32(Request.QueryString["NumTree"]);
                int NumTree = Convert.ToInt32(HttpContext.Current.Session["NumTree"]);
                //int NumTree = 3;

                if (NumTree == 1)
                { 
                    precentPerUser = 60;
                    //bonusPerUser = 1;
                 }
                 else if (NumTree == 2)
                {
                    precentPerUser = 80;
                    //bonusPerUser = 1;
                 }
                else if (NumTree == 3)
                {
                    precentPerUser = 89;
                   // bonusPerUser = 1;
                }
                else if (NumTree == 4)
                {
                    precentPerUser = 68;
                  //  bonusPerUser = 1;
                 }
                else//NumTree == 5
                {
                    precentPerUser = 75;
                   // bonusPerUser = 1;
                }

                MainGoalLable.Text = " We want to enable anyone to diagnose a threat of cancer and from there to consult a physician." + "<br/><br/>" +
                        " We <q>teach</q> the person how a set of certain conditions may lead to <q>Cancer Suspicion</q>." + "<br/>" +
                       " The conditions and outcomes (shown as a diagram) are derived from real cases  and provide correct prediction results of: " + precentPerUser + " %." + "<br/><br/> ";
                UserRoleLable.Text = "<br/> YOUR ROLE IN THIS EXPERIMENT:" + "<br/>  " +
                 "<strong>  * Learn what symptoms indicate a suspicion of cancer, by understanding the diagnoses made using the diagram on different patients." + "<br/>" +

                 "  * To make a diagnosis by yourself in order to test your level of knowledge.<br/><br/> You will be given a <u>bonus salary according to your level of success </u>in the diagnosis you will perform. (maximum bonus is $"+ bonusPerUser +") </strong>" + "<br/><br/><br/>";
            }
            else
            {
                // בצע את שאר הפעולות
            }

        }

        public void SetPageNoCache()
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
            Response.Cache.SetAllowResponseInBrowserHistory(false);
            Response.Cache.SetNoStore();
        }
        protected void BtnNextPage1_Click(object sender, EventArgs e)
        {
            // var workerId = Request.QueryString["workerId"].ToString();
            var url = "~/InformedConsent.aspx";//?workerId=" + workerId;
            //window.history.forward();
            Response.Redirect(url);
            //window.location.replace("/rating-exp/Evaluation/Evaluation"); //to prevent page back
        }
    }
}