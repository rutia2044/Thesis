using System;

using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ReinforcementLearning;

namespace WebApplication3
{

    public class Case
    {

        // int id;
        public string rectalMucus;
        public string bowelChange;
        public string fatigue;
        public string sufferedFrom_GI_problems;
        public string everBeenOverweight;
     
        public string realClassification;
        public string classificationPth1;
        public string classificationPth2;
        public string classificationPth3;
        public string classificationPth4;
        // public string classificationPth5;
        public string imagePth1;
        public string imagePth2;
        public string imagePth3;
        public string imagePth4;
        // public string imagePth5;
        // int  featersExistFlags [7];
        public Case(string  rectalMucus,
                    string  bowelChange,
                    string  fatigue,
                    string  sufferedFrom_GI_problems,
                    string everBeenOverweight,
                    string realClassification,
                    string classificationPth1,
                    string classificationPth2,
                    string classificationPth3,
                    string classificationPth4,
                 //   string classificationPth5,
                    string imagePth1,
                    string imagePth2,
                    string imagePth3,
                    string imagePth4
                    //string imagePth5
                    )
        {
            this.rectalMucus = rectalMucus;
            this.bowelChange = bowelChange;
            this.fatigue = fatigue;
            this.sufferedFrom_GI_problems = sufferedFrom_GI_problems;
            this.everBeenOverweight = everBeenOverweight;
           
            this.realClassification = realClassification;
            this.classificationPth1 = classificationPth1;
            this.classificationPth2 = classificationPth2;
            this.classificationPth3 = classificationPth3;
            this.classificationPth4 = classificationPth4;
           // this.classificationPth5 = classificationPth5;
            this.imagePth1 = imagePth1;
            this.imagePth2 = imagePth2;
            this.imagePth3 = imagePth3;
            this.imagePth4 = imagePth4;
           // this.imagePth5 = imagePth5;
        }

        public Case(string   rectalMucus,
                    string   bowelChange,
                    string   fatigue,
                    string   sufferedFrom_GI_problems,
                    string everBeenOverweight,
                    string realClassification,
                    string classificationPth1,
                    string classificationPth2,
                    string classificationPth3,
                    string classificationPth4
                   // string classificationPth5
               )
        {
            this.rectalMucus = rectalMucus;
            this.bowelChange = bowelChange;
            this.fatigue = fatigue;
            this.sufferedFrom_GI_problems = sufferedFrom_GI_problems;
            this.everBeenOverweight = everBeenOverweight;

            this.realClassification = realClassification;
            this.classificationPth1 = classificationPth1;
            this.classificationPth2 = classificationPth2;
            this.classificationPth3 = classificationPth3;
            this.classificationPth4 = classificationPth4;
            //this.classificationPth5 = classificationPth5;
            this.imagePth1 = " ";
            this.imagePth2 = " ";
            this.imagePth3 = " ";
            this.imagePth4 = " ";
            //this.imagePth5 = " ";
        }
    };
    public partial class WebForm1 : System.Web.UI.Page
    {
        int MoneQuestionLearningPhase;
        //int NumCases = 23;
        int NumCases = 12;
        Color cGreen = System.Drawing.Color.LightGreen;
        Color cGray = System.Drawing.Color.LightGray;
        int NumTree;
        string StartLearning;
        string FinishLearning;
        String ClickTime;
        Case[] casesArr = new Case[]
 {
	            // 1     2              3               4           5              6                  7            8           9        10      11      12     13     14
	            //age, gender, yearsSinceAcidTaste, chestPain, stomachPain, burningChestLevel, takingStomachMed, realClass , class1 , class2, class3 , img1 , img2 , img3       
             //   rectal_mucus    bowels_change   fatigue suffered_from_gi_problems   ever_been_overweight    RealClassification

   
        

         new Case("NO","YES","NO","NO","YES","NORMAL","NORMAL","SUSPECTED CROHN'S","NORMAL","NORMAL","~/Images/img_1_1.png","~/Images/img_2_2.png","~/Images/img_3_2.png","~/Images/img_4_4.png"),//BE, false false false
        new Case("YES","NO","NO","NO","YES","SUSPECTED CROHN'S","SUSPECTED CROHN'S", "SUSPECTED CROHN'S", "SUSPECTED CROHN'S","SUSPECTED CROHN'S","~/Images/img_1_2.png","~/Images/img_2_3.png","~/Images/img_3_4.png","~/Images/img_4_6.png"), // BE, true true true
        //new Case("Middle","Female","Recent","Medium","High","Low","Yes","NORMAL","NORMAL","NORMAL","NORMAL","~/Images/img_1_2.png","~/Images/img_2_5.png","~/Images/img_5_17.png"), //Normal, true true true        
       // new Case("Young","Male","Recent","Medium","High","High","Yes","NORMAL","NORMAL","SUSPECTED CANCER","NORMAL","~/Images/img_1_2.png","~/Images/img_2_4.png","~/Images/img_5_16.png"), //Normal, true false true
        new Case("NO","NO","NO","YES","YES","NORMAL","NORMAL","NORMAL", "NORMAL","NORMAL","~/Images/img_1_1.png","~/Images/img_2_1.png","~/Images/img_3_1.png","~/Images/img_4_3.png"),//BE, true true true
	  	//new Case("Middle","Male","Long_time","Medium","Low","Medium","Yes","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER", "SUSPECTED CANCER","~/Images/img_1_1.png","~/Images/img_2_1.png","~/Images/img_5_2.png"),//BE, true true true
        new Case("NO","YES","YES","YES","NO","SUSPECTED CROHN'S","NORMAL", "SUSPECTED CROHN'S", "SUSPECTED CROHN'S","SUSPECTED CROHN'S","~/Images/img_1_1.png","~/Images/img_2_2.png","~/Images/img_3_3.png","~/Images/img_4_5.png"),//BE, true true true
       // new Case("Young","Female","Long_time","Medium","High","High","No","NORMAL","SUSPECTED CANCER","NORMAL","NORMAL","~/Images/img_1_1.png","~/Images/img_2_3.png","~/Images/img_5_11.png"), //Normal, true true true		
		
          new Case("YES", "YES","YES","YES","NO","SUSPECTED CROHN'S","SUSPECTED CROHN'S","SUSPECTED CROHN'S", "SUSPECTED CROHN'S", "SUSPECTED CROHN'S","~/Images/img_1_2.png","~/Images/img_2_3.png","~/Images/img_3_4.png","~/Images/img_4_6.png"), //BE, true true true
 //new Case("Middle","Female","Long_time","High","Medium","High","No","NORMAL","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER","~/Images/img_1_1.png","~/Images/img_2_2.png","~/Images/img_5_6.png"), //Normal all wrong, true true true
        new Case("NO","NO","NO","NO","YES","NORMAL","NORMAL","NORMAL", "NORMAL","NORMAL","~/Images/img_1_1.png","~/Images/img_2_1.png","~/Images/img_3_1.png","~/Images/img_4_1.png"),///Normal, true false true		
		//new Case("Old","Female","Long_time","Medium","Medium","Medium","Yes","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER","~/Images/img_1_1.png","~/Images/img_2_2.png","~/Images/img_5_5.png"),//BE, true true true     
		
        new Case("YES","NO","NO","YES","YES","SUSPECTED CROHN'S","SUSPECTED CROHN'S","SUSPECTED CROHN'S", "SUSPECTED CROHN'S", "SUSPECTED CROHN'S","~/Images/img_1_2.png","~/Images/img_2_3.png","~/Images/img_3_4.png","~/Images/img_4_6.png"), //Normal, false true false
       //new Case("Middle","Male","Recent","Low","Low","Medium","No","NORMAL","NORMAL","SUSPECTED CANCER","NORMAL","~/Images/img_1_2.png","~/Images/img_2_4.png","~/Images/img_5_14.png"),///Normal, true false true							
		//new Case("Young","Female","Recent","High","High","High","Yes","NORMAL","NORMAL","NORMAL","NORMAL","~/Images/img_1_2.png","~/Images/img_2_5.png","~/Images/img_5_17.png"), //Normal, true true true       
       // new Case("Young","Male","Long_time","Low","Medium","Low","Yes","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER","~/Images/img_1_1.png","~/Images/img_2_2.png","~/Images/img_5_7.png"),//BE, true true true
		new Case("NO","NO","YES","NO","NO","NORMAL","NORMAL","NORMAL", "NORMAL","NORMAL","~/Images/img_1_1.png","~/Images/img_2_1.png","~/Images/img_3_1.png","~/Images/img_4_1.png"),///BE, false true true		
       // new Case("Young","Female","Long_time","Medium","Medium","Medium","Yes","NORMAL","SUSPECTED CANCER","SUSPECTED CANCER","NORMAL","~/Images/img_1_1.png","~/Images/img_2_2.png","~/Images/img_5_8.png"),//Normal, false false true
        new Case("YES","YES","NO","NO","NO","SUSPECTED CROHN'S","SUSPECTED CROHN'S","SUSPECTED CROHN'S", "SUSPECTED CROHN'S", "SUSPECTED CROHN'S","~/Images/img_1_2.png","~/Images/img_2_3.png","~/Images/img_3_4.png","~/Images/img_4_6.png"), //BE, true true true
         
     new Case("NO","NO","YES","YES","NO","SUSPECTED CROHN'S","NORMAL","NORMAL", "NORMAL","SUSPECTED CROHN'S","~/Images/img_1_1.png","~/Images/img_2_1.png","~/Images/img_3_1.png","~/Images/img_4_2.png"),//Normal, false false true
       // new Case("Old","Male","Long_time","Low","Medium","Medium","No","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER","~/Images/img_1_1.png","~/Images/img_2_2.png","~/Images/img_5_5.png"),//BE, true true true
	new Case("NO","YES","NO","NO","NO","SUSPECTED CROHN'S","NORMAL","SUSPECTED CROHN'S", "NORMAL","NORMAL","~/Images/img_1_1.png","~/Images/img_2_2.png","~/Images/img_3_2.png","~/Images/img_4_4.png"),//Normal, false false true
		
     new Case("NO","NO","YES","NO","YES","NORMAL","NORMAL","NORMAL", "NORMAL","NORMAL","~/Images/img_1_1.png","~/Images/img_2_1.png","~/Images/img_3_1.png","~/Images/img_4_1.png") ///Normal, true true true
 };



        protected void ChangeBackColor(Color cFatigue, Color cGI_Problems, Color cBowel, Color cOverweight)
        {
            lblFatigueQ.BackColor = cFatigue;
            lblFatigue.BackColor = cFatigue;

            lblSufferedFromGI_ProblemsQ.BackColor = cGI_Problems;
            lblSufferedFromGI_Problems.BackColor = cGI_Problems;



            lblBowelChangeQ.BackColor = cBowel;
            lblBowelChange.BackColor = cBowel;

           // lblTakingStomachMedQ.BackColor = cTakingStomachMed;
            //lblTakingStomachMed.BackColor = cTakingStomachMed;

            lblOverWeightQ.BackColor = cOverweight;
            lblOverWeight.BackColor = cOverweight;

           // lblBurningChestQ.BackColor = cBurningChest;
            //lblBurningChest.BackColor = cBurningChest;

          

            }



        public void SetPageNoCache()
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
            Response.Cache.SetAllowResponseInBrowserHistory(false);
            Response.Cache.SetNoStore();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            // Lbl_DetailedLevelEmpty.Visible = false;
            //  Lbl_isSatifiedEmpty.Visible = false;
           

            lblRectalMucusQ.BackColor = System.Drawing.Color.LightGreen;
            lblRectalMucus.BackColor = System.Drawing.Color.LightGreen;

            lblClassificationQ.BackColor = System.Drawing.Color.LightGreen;
            lblClassification.BackColor = System.Drawing.Color.LightGreen;
            SetPageNoCache();

            // lblOverWeight. = System.Drawing.Color.MediumSeaGreen;
            //lblBurningChestQ.ForeColor = System.Drawing.Color.Black;
            if (!IsPostBack)
            {
              

                    
                MoneQuestionLearningPhase = 0;
                StartLearning = DateTime.Now.ToString("h:mm:ss tt");
                HttpContext.Current.Session["StartLearning"] = StartLearning;
                
                 //NumTree = Convert.ToInt32(HttpContext.Current.Session["NumTree"].ToString());
                NumTree = 4;
                switch(NumTree)
                {
                    case 1:
                        Image1.ImageUrl = casesArr[MoneQuestionLearningPhase].imagePth1;
                        Image1.Height = Unit.Percentage(90);
                        Image1.Width = Unit.Percentage(90);
                        lblClassification.Text = casesArr[MoneQuestionLearningPhase].classificationPth1;
                        lblBowelChangeQ.Visible = false;
                        lblBowelChange.Visible = false;
                        lblFatigueQ.Visible = false;
                        lblFatigue.Visible = false;
                        lblSufferedFromGI_ProblemsQ.Visible = false;
                        lblSufferedFromGI_Problems.Visible = false;
                       
                        lblOverWeightQ.Visible = false;
                        lblOverWeight.Visible = false;
                       
                        break;
                    case 2:
                       // ChangeBackColor(cGray, cGray, cGreen, cGray);
                        Image1.ImageUrl = casesArr[MoneQuestionLearningPhase].imagePth2;
                        // Image1.ImageUrl = "C:/Users/Yonatan/Desktop/projectHazatMechkar/‏‏WebApplication5/WebApplication3/Images/img_2_5.png";


                        Image1.Height = Unit.Percentage(90);
                        Image1.Width = Unit.Percentage(90);
                        lblClassification.Text = casesArr[MoneQuestionLearningPhase].classificationPth2;

                        lblFatigueQ.Visible = false;
                        lblFatigue.Visible = false;

                        lblSufferedFromGI_ProblemsQ.Visible = false;
                        lblSufferedFromGI_Problems.Visible = false;
                       //lblTakingStomachMedQ.Visible = false;
                        //lblTakingStomachMed.Visible = false;
                         lblOverWeightQ.Visible = false;
                         lblOverWeight.Visible = false;
                       // lblBurningChestQ.Visible = false;
                       // lblBurningChest.Visible = false;
                        break;
                    case 3:
                       // ChangeBackColor(cGray, cGray, cGreen, cGreen);
                        Image1.ImageUrl = casesArr[MoneQuestionLearningPhase].imagePth3;
                         Image1.Height = Unit.Percentage(80);
                          Image1.Width = Unit.Percentage(80);
                        lblClassification.Text = casesArr[MoneQuestionLearningPhase].classificationPth3;
                        lblSufferedFromGI_ProblemsQ.Visible = false;
                        lblSufferedFromGI_Problems.Visible = false;
                        //lblTakingStomachMedQ.Visible = false;
                        //lblTakingStomachMed.Visible = false;
                        lblOverWeightQ.Visible = false;
                        lblOverWeight.Visible = false;
                        break;
                    case 4:
                       // ChangeBackColor(cGray, cGray, cGray, cGray);
                        Image1.ImageUrl = casesArr[MoneQuestionLearningPhase].imagePth4;
                        Image1.Height = Unit.Percentage(76);
                        Image1.Width = Unit.Percentage(74);
                        lblClassification.Text = casesArr[MoneQuestionLearningPhase].classificationPth4;
                       
                       // lblBurningChestQ.Visible = false;
                        //lblBurningChest.Visible = false;
                        break;
                    
                     
                    default:
                         break;
                }
                ChangeBackColor(cGreen, cGray, cGreen, cGray);
                lblFatigue.Text = casesArr[MoneQuestionLearningPhase].fatigue;
                lblSufferedFromGI_Problems.Text = casesArr[MoneQuestionLearningPhase].sufferedFrom_GI_problems;
                lblRectalMucus.Text = casesArr[MoneQuestionLearningPhase].rectalMucus;
                lblBowelChange.Text = casesArr[MoneQuestionLearningPhase].bowelChange;
                //lblTakingStomachMed.Text = casesArr[MoneQuestionLearningPhase].takingStomachMed;
                 lblOverWeight.Text = casesArr[MoneQuestionLearningPhase].everBeenOverweight;
                //lblBurningChest.Text = casesArr[MoneQuestionLearningPhase].burningChestLevel;

                MoneQuestionLearningPhase++;
                LblMone.Text = MoneQuestionLearningPhase.ToString() + "/12";
                HttpContext.Current.Session["MoneQuestionLearningPhase"] = MoneQuestionLearningPhase;
                // Image1.ImageUrl = "~/Images/‏‏img_5_1.png";
                //Image1.ImageUrl = "~/Images/ExampleOfDiagram.png";
                // בצע פעולות אתחול
            }
            else
            {
               
                //Image1.ImageUrl = "~/Images/‏‏img_2_1_1.png";
                // בצע את שאר הפעולות
            }
        }

        protected void Btn1_Click(object sender, EventArgs e)
        {
           
            MoneQuestionLearningPhase = Convert.ToInt32(HttpContext.Current.Session["MoneQuestionLearningPhase"].ToString());
            
            ClickTime = DateTime.Now.ToString("h:mm:ss tt");
            HttpContext.Current.Session["LearningPhaseClick"+ MoneQuestionLearningPhase.ToString()] = ClickTime;
            if (MoneQuestionLearningPhase < NumCases)
            {
                 NumTree = Convert.ToInt32(HttpContext.Current.Session["NumTree"].ToString());
                //NumTree = 4;
               
                //NumTree = 1;
                // Image1.ImageUrl = casesArr[mone].imagePth2;
                //  Image1.ImageUrl = "~/Images/img_3_4.png";
                // panel1 = ArrCases[mone];
                // CaseLable.Text = ArrCases[mone];
                //טעינת השאלה הבאה והתמונה הבאה
               switch(NumTree)
                {
                    case 1:
                        Image1.ImageUrl = casesArr[MoneQuestionLearningPhase].imagePth1;
                        Image1.Height = Unit.Percentage(90);
                        Image1.Width = Unit.Percentage(90);
                        lblClassification.Text = casesArr[MoneQuestionLearningPhase].classificationPth1;
                        lblBowelChangeQ.Visible = false;
                        lblBowelChange.Visible = false;
                        lblFatigueQ.Visible = false;
                        lblFatigue.Visible = false;
                         lblSufferedFromGI_ProblemsQ.Visible = false;
                        lblSufferedFromGI_Problems.Visible = false;
                        //  lblTakingStomachMedQ.Visible = false;
                        //  lblTakingStomachMed.Visible = false;
                        lblOverWeightQ.Visible = false;
                         lblOverWeight.Visible = false;
                       // lblBurningChestQ.Visible = false;
                        //lblBurningChest.Visible = false;
                        break;
                    case 2:
                        Image1.ImageUrl = casesArr[MoneQuestionLearningPhase].imagePth2;
                        Image1.Height = Unit.Percentage(90);
                        Image1.Width = Unit.Percentage(90);
                        lblClassification.Text = casesArr[MoneQuestionLearningPhase].classificationPth2;

                    
                        lblFatigueQ.Visible = false;
                        lblFatigue.Visible = false;
                        lblSufferedFromGI_ProblemsQ.Visible = false;
                        lblSufferedFromGI_Problems.Visible = false;
                      
                         lblOverWeightQ.Visible = false;
                         lblOverWeight.Visible = false;
                       // lblBurningChestQ.Visible = false;
                       // lblBurningChest.Visible = false;
                        break;
                    case 3:
                        Image1.ImageUrl = casesArr[MoneQuestionLearningPhase].imagePth3;
                         Image1.Height = Unit.Percentage(80);
                        Image1.Width = Unit.Percentage(80);
                        lblClassification.Text = casesArr[MoneQuestionLearningPhase].classificationPth3;
                        lblSufferedFromGI_ProblemsQ.Visible = false;
                        lblSufferedFromGI_Problems.Visible = false;

                        lblOverWeightQ.Visible = false;
                        lblOverWeight.Visible = false;
                        break;
                    case 4:
                        Image1.ImageUrl = casesArr[MoneQuestionLearningPhase].imagePth4;
                        Image1.Height = Unit.Percentage(76);
                        Image1.Width = Unit.Percentage(74);
                        lblClassification.Text = casesArr[MoneQuestionLearningPhase].classificationPth4;
                      
                        break;
              

                    default:
                        break;

                }

                switch (MoneQuestionLearningPhase)
                {
                    case 1:
                        ChangeBackColor(cGray, cGray, cGray, cGray);
                        break;
                    case 2:
                        ChangeBackColor(cGray, cGreen, cGreen, cGreen);
                        break;
                    case 3:
                        ChangeBackColor(cGreen, cGray, cGreen, cGray);
                        break;
                    case 4:
                        ChangeBackColor(cGray, cGray, cGray, cGray);
                        break;
                    case 5:
                        ChangeBackColor(cGray, cGreen, cGreen, cGray);
                        break;
                    case 6:
                        ChangeBackColor(cGray, cGray, cGray, cGray);
                        break;
                    case 7:
                        ChangeBackColor(cGray, cGreen, cGreen, cGray);
                        break;
                    case 8:
                        ChangeBackColor(cGray, cGray, cGray, cGray);
                        break;
                    case 9:
                        ChangeBackColor(cGray, cGreen, cGreen, cGreen);
                        break;
                    case 10:
                        ChangeBackColor(cGreen, cGray, cGreen, cGray);
                        break;
                    case 11:
                        ChangeBackColor(cGray, cGreen, cGreen, cGray);
                        break;

                }
                lblFatigue.Text = casesArr[MoneQuestionLearningPhase].fatigue;
                lblSufferedFromGI_Problems.Text = casesArr[MoneQuestionLearningPhase].sufferedFrom_GI_problems;
                lblRectalMucus.Text = casesArr[MoneQuestionLearningPhase].rectalMucus;
                lblBowelChange.Text = casesArr[MoneQuestionLearningPhase].bowelChange;
               // lblTakingStomachMed.Text = casesArr[MoneQuestionLearningPhase].takingStomachMed;
                 lblOverWeight.Text = casesArr[MoneQuestionLearningPhase].everBeenOverweight;
                //lblBurningChest.Text = casesArr[MoneQuestionLearningPhase].burningChestLevel;
                // lblClassification.Text = casesArr[mone].classificationPth2;
                //  RadBtn_DetailedLevel.SelectedIndex = -1;
                // RadBtn_IsSaticfied.SelectedIndex = -1;
                MoneQuestionLearningPhase++;
                LblMone.Text = MoneQuestionLearningPhase.ToString() + "/12";
                HttpContext.Current.Session["MoneQuestionLearningPhase"] = MoneQuestionLearningPhase;
            }
            else 
            { //
                FinishLearning = DateTime.Now.ToString("h:mm:ss tt");
                StartLearning = HttpContext.Current.Session["StartLearning"].ToString();
                string UserId = HttpContext.Current.Session["UserId"].ToString();

                //string connectionString = @"Data Source=DESKTOP-0SB8TU9\SQLEXPRESS01;Initial Catalog=ExperimentDB;Integrated Security=True";
                //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=ExperimentDB;Integrated Security=True";
                string connectionString = SqlConnectionHandler.GetConnection();
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    //sqlConnection.Open();
                    // static string StartLearning;
                    // static string FinishLearning;
                    //   string insertString = $"insert into TIMES_OF_USERS(UserId, StartLearning,FinishLearning) values (UserId,StartLearning,FinishLearning)";
                    //string insertString = "insert into TIMES_OF_USERS (UserId, StartLearning,FinishLearning) values ({"+"UserId"+"},{"+StartLearning+"},{"+FinishLearning+"})";
                    // string insertString = $"insert into TIMES_OF_USERS  values ('7','2','4',NULL,NULL)";
                    //StartLearning = "ff";
                    // FinishLearning = "ffff";
                    //string insertString = "insert into TIMES_OF_USERS(UserId, StartLearning,FinishLearning) values (" + UserId + "," + StartLearning + "," + FinishLearning + ")";

                    // 1. Instantiate a new command with a query and connection
                    //SqlCommand cmd = new SqlCommand(insertString, sqlConnection);
                    //cmd.ExecuteNonQuery();
                    //sqlConnection.Close();

                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.Parameters.AddWithValue("@param1", UserId);
                    cmd.Parameters.AddWithValue("@param2", StartLearning);
                    cmd.Parameters.AddWithValue("@param3", FinishLearning);

                    cmd.CommandText = "INSERT INTO TIMES_OF_USERS(UserId, StartLearning, FinishLearning) VALUES(@param1,@param2, @param3)";
                   // System.Diagnostics.Debug.WriteLine("@@yesss@@@@@@@");
                    cmd.ExecuteNonQuery();
                    sqlConnection.Close();
                }

                Response.Redirect("~/TransitionFromLearningToExam.aspx");
                //מעבר לעמוד הבחינה}

            }


        }



        }

       
}
