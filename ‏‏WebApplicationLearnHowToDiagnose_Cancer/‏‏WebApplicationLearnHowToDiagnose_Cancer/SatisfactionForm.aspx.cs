using EO.WebBrowser.DOM;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace WebApplication3
{
    public partial class FinishedForm : System.Web.UI.Page
    {
        // List<int> UserRatingAnswersLst = new List<int>();
        public int[] UserRatingAnswersArr = new int[5];
        public string UserComments;

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
                LblErr.Visible = false;
        }

      

        protected void BtnFinished_Click(object sender, EventArgs e)
        {
            UserRatingAnswersArr[0] = RadioButtonList1.SelectedIndex;
            UserRatingAnswersArr[1] = RadioButtonList2.SelectedIndex;
            UserRatingAnswersArr[2] = RadioButtonList3.SelectedIndex;
            UserRatingAnswersArr[3] = RadioButtonList4.SelectedIndex;
            UserRatingAnswersArr[4] = RadioButtonList5.SelectedIndex;
           
            if ((UserRatingAnswersArr[0] == -1) ||
                (UserRatingAnswersArr[1] == -1) ||
                (UserRatingAnswersArr[2] == -1) ||
                (UserRatingAnswersArr[3] == -1) ||
                (UserRatingAnswersArr[4] == -1))
                LblErr.Visible = true;
            else
            {
                UserComments =   UserCommentTxt.Text;
                string NumRules = TextBox_NumRules.Text;
                string SatisfiedLevelDetailed = DropDownListSatisfied.SelectedValue.ToString();
                // String p1;
                HttpContext.Current.Session["StartTesting"].ToString();
               // string UserId ="6666";
               string UserId = HttpContext.Current.Session["UserId"].ToString();
                //string connectionString = @"Data Source=DESKTOP-0SB8TU9\SQLEXPRESS01;Initial Catalog=ExperimentDB;Integrated Security=True";
                // string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=ExperimentDB;Integrated Security=True";
                string connectionString = SqlConnectionHandler.GetConnection();
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                 {
                     // sqlConnection.Open();
                     // string insertString = $"insert into USER_SATISFACTION_ANSWERS(UserId, StartLearning,FinishLearning) values ({UserId},{UserRatingAnswersArr[0]},{UserRatingAnswersArr[1]},{UserRatingAnswersArr[2]},{UserRatingAnswersArr[3]},{UserComments})";
                     // 1. Instantiate a new command with a query and connection
                     // SqlCommand cmd = new SqlCommand(insertString, sqlConnection);
                     // cmd.ExecuteNonQuery();
                     // sqlConnection.Close();
                    // int t1 = 1, t2 = 2, t3 = 3, t4 = 4;
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.Parameters.AddWithValue("@UserId", UserId);
                    cmd.Parameters.AddWithValue("@q_1", UserRatingAnswersArr[0]);
                    cmd.Parameters.AddWithValue("@q_2", UserRatingAnswersArr[1]);
                    cmd.Parameters.AddWithValue("@q_3", UserRatingAnswersArr[2]);
                    cmd.Parameters.AddWithValue("@q_4", UserRatingAnswersArr[3]);
                    cmd.Parameters.AddWithValue("@q_5", UserRatingAnswersArr[4]);
                    cmd.Parameters.AddWithValue("@AmountOfRulesForAbsorption", NumRules);
                    cmd.Parameters.AddWithValue("@SatisfactionWithTheLevelOfDetailed", SatisfiedLevelDetailed);
                    //cmd.Parameters.AddWithValue("@q_3", t3);
                    // cmd.Parameters.AddWithValue("@q_4", t4);
                    cmd.Parameters.AddWithValue("@q_6", UserComments);
                    cmd.CommandText = @"INSERT INTO USER_SATISFACTION_ANSWERS(UserId,UserRatingAnswer1,UserRatingAnswer2,UserRatingAnswer3, UserRatingAnswer4,
                    UserRatingAnswer5,AmountOfRulesForAbsorption,SatisfactionWithTheLevelOfDetailed, UserComments) VALUES (@UserId , @q_1 , @q_2 , @q_3 , @q_4 , 
                    @q_5,@AmountOfRulesForAbsorption, @SatisfactionWithTheLevelOfDetailed, @q_6)";
                    cmd.ExecuteNonQuery();
                    ///Update times to Table
                    SqlCommand cmdUpdate = new SqlCommand();
                    cmdUpdate.Connection = sqlConnection;
                    cmdUpdate.Parameters.AddWithValue("@param1", UserId);
                    cmdUpdate.Parameters.AddWithValue("@FirstPageClick", HttpContext.Current.Session["FirstPageClick"].ToString());
                    cmdUpdate.Parameters.AddWithValue("@InformedConsentPageClick", HttpContext.Current.Session["InformedConsentPageClick"].ToString());
                    cmdUpdate.Parameters.AddWithValue("@ExperimentalProcessClick", HttpContext.Current.Session["ExperimentalProcessClick"].ToString());
                    cmdUpdate.Parameters.AddWithValue("@DiagramEplanationClick", HttpContext.Current.Session["DiagramEplanationClick"].ToString());
                    cmdUpdate.Parameters.AddWithValue("@AnimationFormClick", HttpContext.Current.Session["AnimationFormClick"].ToString());
                    cmdUpdate.Parameters.AddWithValue("@ExampleOnTheModelPageClick", HttpContext.Current.Session["ExampleOnTheModelPageClick"].ToString());
                    cmdUpdate.Parameters.AddWithValue("@TransitionToLearningClick", HttpContext.Current.Session["TransitionToLearningClick"].ToString());
                    cmdUpdate.Parameters.AddWithValue("@LearningPhaseClick1", HttpContext.Current.Session["LearningPhaseClick1"].ToString());
                    cmdUpdate.Parameters.AddWithValue("@LearningPhaseClick2", HttpContext.Current.Session["LearningPhaseClick2"].ToString());
                    cmdUpdate.Parameters.AddWithValue("@LearningPhaseClick3", HttpContext.Current.Session["LearningPhaseClick3"].ToString());
                    cmdUpdate.Parameters.AddWithValue("@LearningPhaseClick4", HttpContext.Current.Session["LearningPhaseClick4"].ToString());
                    cmdUpdate.Parameters.AddWithValue("@LearningPhaseClick5", HttpContext.Current.Session["LearningPhaseClick5"].ToString());
                    cmdUpdate.Parameters.AddWithValue("@LearningPhaseClick6", HttpContext.Current.Session["LearningPhaseClick6"].ToString());
                    cmdUpdate.Parameters.AddWithValue("@LearningPhaseClick7", HttpContext.Current.Session["LearningPhaseClick7"].ToString());
                    cmdUpdate.Parameters.AddWithValue("@LearningPhaseClick8", HttpContext.Current.Session["LearningPhaseClick8"].ToString());
                    cmdUpdate.Parameters.AddWithValue("@LearningPhaseClick9", HttpContext.Current.Session["LearningPhaseClick9"].ToString());
                    cmdUpdate.Parameters.AddWithValue("@LearningPhaseClick10", HttpContext.Current.Session["LearningPhaseClick10"].ToString());
                    cmdUpdate.Parameters.AddWithValue("@LearningPhaseClick11", HttpContext.Current.Session["LearningPhaseClick11"].ToString());
                    cmdUpdate.Parameters.AddWithValue("@LearningPhaseClick12", HttpContext.Current.Session["LearningPhaseClick12"].ToString());
                    cmdUpdate.Parameters.AddWithValue("@TransitionFromLearningToExamClick", HttpContext.Current.Session["TransitionFromLearningToExamClick"].ToString());
                    cmdUpdate.Parameters.AddWithValue("@ExampleOfTestClick", HttpContext.Current.Session["ExampleOfTestClick"].ToString());
                    cmdUpdate.Parameters.AddWithValue("@TestingPhaseClick1", HttpContext.Current.Session["TestingPhaseClick1"].ToString());
                    cmdUpdate.Parameters.AddWithValue("@TestingPhaseClick2", HttpContext.Current.Session["TestingPhaseClick2"].ToString());
                    cmdUpdate.Parameters.AddWithValue("@TestingPhaseClick3", HttpContext.Current.Session["TestingPhaseClick3"].ToString());
                    cmdUpdate.Parameters.AddWithValue("@TestingPhaseClick4", HttpContext.Current.Session["TestingPhaseClick4"].ToString());
                    cmdUpdate.Parameters.AddWithValue("@TestingPhaseClick5", HttpContext.Current.Session["TestingPhaseClick5"].ToString());
                    cmdUpdate.Parameters.AddWithValue("@TestingPhaseClick6", HttpContext.Current.Session["TestingPhaseClick6"].ToString());
                    cmdUpdate.Parameters.AddWithValue("@TestingPhaseClick7", HttpContext.Current.Session["TestingPhaseClick7"].ToString());
                    cmdUpdate.Parameters.AddWithValue("@TestingPhaseClick8", HttpContext.Current.Session["TestingPhaseClick8"].ToString());
                    cmdUpdate.Parameters.AddWithValue("@TestingPhaseClick9", HttpContext.Current.Session["TestingPhaseClick9"].ToString());
                    cmdUpdate.Parameters.AddWithValue("@TestingPhaseClick10", HttpContext.Current.Session["TestingPhaseClick10"].ToString());
                    cmdUpdate.Parameters.AddWithValue("@TestingPhaseClick11", HttpContext.Current.Session["TestingPhaseClick11"].ToString());
                    cmdUpdate.Parameters.AddWithValue("@TestingPhaseClick12", HttpContext.Current.Session["TestingPhaseClick12"].ToString());
                    cmdUpdate.Parameters.AddWithValue("@SatisfactionClick", DateTime.Now.ToString("h:mm:ss tt"));

                    cmdUpdate.CommandText = "update TIMES_OF_USERS set " +

                        
                        "FirstPage =             @FirstPageClick," +
                        "InformedConsentPage = @InformedConsentPageClick," +
                        "ExperimentalProcess =   @ExperimentalProcessClick," +
                        "DiagramExplanation =    @DiagramEplanationClick, " +
                        "AnimationForm   =       @AnimationFormClick,"+
                        "ExampleOnTheModelPage = @ExampleOnTheModelPageClick," +
                        "TransitionToLearning =  @TransitionToLearningClick," +
                        "LearningClick1  =  @LearningPhaseClick1," +
                        "LearningClick2  =  @LearningPhaseClick2,"+
                        "LearningClick3  =  @LearningPhaseClick3,"+
                        "LearningClick4  =  @LearningPhaseClick4,"+
                        "LearningClick5  =  @LearningPhaseClick5,"+
                        "LearningClick6  =  @LearningPhaseClick6,"+
                        "LearningClick7  =  @LearningPhaseClick7,"+
                        "LearningClick8  =  @LearningPhaseClick8,"+
                        "LearningClick9  =  @LearningPhaseClick9,"+
                        "LearningClick10 =  @LearningPhaseClick10," +
                        "LearningClick11 =  @LearningPhaseClick11," +
                        "LearningClick12 =  @LearningPhaseClick12," +
                        "TransitionFromLearningToExam = @TransitionFromLearningToExamClick,"+
                        "ExampleOfTest   = @ExampleOfTestClick,"  +
                        "TestingClick1   = @TestingPhaseClick1,"  +
                        "TestingClick2   = @TestingPhaseClick2,"  +
                        "TestingClick3   = @TestingPhaseClick3,"  +
                        "TestingClick4   = @TestingPhaseClick4,"  +
                        "TestingClick5   = @TestingPhaseClick5,"  +
                        "TestingClick6   = @TestingPhaseClick6,"  +
                        "TestingClick7   = @TestingPhaseClick7,"  +
                        "TestingClick8   = @TestingPhaseClick8,"  +
                        "TestingClick9   = @TestingPhaseClick9,"  +
                        "TestingClick10  = @TestingPhaseClick10," +
                        "TestingClick11  = @TestingPhaseClick11," +
                        "TestingClick12  = @TestingPhaseClick12," +    
                        "Satisfaction    = @SatisfactionClick "+
                       " where UserId = @param1";
                    cmdUpdate.ExecuteNonQuery();
                    ///

                    sqlConnection.Close();

                 }
               // String ClickTime = DateTime.Now.ToString("h:mm:ss tt");
               // HttpContext.Current.Session["SatisfactionClick"] = ClickTime;
                Response.Redirect("~/ExitForm.aspx");
                // Response.Write("<script>window.close();</script>");
            }
        }
    }
}