using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    enum classificationType { NORMAL = 0, SUSPECTED_CROHN = 1,DONT_KNOW = 2 }
    class Answer
    {
        public classificationType classificationAnswer;
        public bool sufferedFrom_GI_problems;
        public bool fatigue;
        public bool rectalMucus;
        public bool everBeenOverweight;
        public bool height;
        public bool bowelChange;
       // public bool burningChestLevel;
        //public bool takingStomachMed;

        public Answer(classificationType classificationAnswer, bool sufferedFrom_GI_problems, bool fatigue, bool rectalMucus, bool everBeenOverweight, bool height,
                       bool bowelChange)
        {
            this.classificationAnswer = classificationAnswer;
            this.sufferedFrom_GI_problems = sufferedFrom_GI_problems;
            this.fatigue = fatigue;
            this.rectalMucus = rectalMucus;
            this.everBeenOverweight = everBeenOverweight;
            this.height = height;
            this.bowelChange = bowelChange;
           // this.burningChestLevel = burningChestLevel;
            //this.takingStomachMed = takingStomachMed;
        }
        public Answer() {

            this.classificationAnswer = classificationType.DONT_KNOW;
            this.sufferedFrom_GI_problems = false;
            this.fatigue = false;
            this.rectalMucus = false;
            this.everBeenOverweight = false;
            this.height = false;
            this.bowelChange = false;
           // this.burningChestLevel = false;
           // this.takingStomachMed = false;
        }
    }

    public partial class TestWebForm1 : System.Web.UI.Page
    {

         List<Answer> list1 = new List<Answer>();

        // list.Add(new Answer());

        // UserAnswers
        string StartTesting;
        string FinishTesting;
        int MoneQuestionTestingPhase;
        string  ClickTime;
      //  int NumCases = 15;
        int NumCases = 12;
        // int NumCases = 4;
        Case[] casesArr = new Case[]{
                // 1    2              3                 4          5              6                  7            8          9        10       11
	            //age, gender, yearsSinceAcidTaste, chestPain, stomachPain, burningChestLevel, takingStomachMed, realClass , class1 , class2 , class3
        new Case("YES", "NO","YES","YES","NO","SUSPECTED CROHN'S","SUSPECTED CROHN'S","SUSPECTED CANCER", "SUSPECTED CANCER", "SUSPECTED CANCER"), //BE, true true true
         new Case("NO","YES","NO","YES","YES","NORMAL","NORMAL","NORMAL","NORMAL","NORMAL"),//BE, false false false
        new Case("YES","YES","NO","YES","YES","SUSPECTED CROHN'S","SUSPECTED CROHN'S", "SUSPECTED CANCER", "SUSPECTED CANCER","SUSPECTED CANCER"), // BE, true true true
        new Case("YES","YES","YES","NO","NO","SUSPECTED CROHN'S","SUSPECTED CROHN'S", "SUSPECTED CANCER", "SUSPECTED CANCER","NORMAL"), //BE, true true true
        //new Case("Middle","Female","Recent","Medium","High","Low","Yes","NORMAL","NORMAL","NORMAL","NORMAL","~/Images/img_1_2.png","~/Images/img_2_5.png","~/Images/img_5_17.png"), //Normal, true true true        
       // new Case("Young","Male","Recent","Medium","High","High","Yes","NORMAL","NORMAL","SUSPECTED CANCER","NORMAL","~/Images/img_1_2.png","~/Images/img_2_4.png","~/Images/img_5_16.png"), //Normal, true false true
        new Case("NO","NO","NO","YES","YES","NORMAL","NORMAL","SUSPECTED CANCER", "SUSPECTED CANCER","SUSPECTED CANCER"),//BE, true true true
	  	//new Case("Middle","Male","Long_time","Medium","Low","Medium","Yes","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER", "SUSPECTED CANCER","~/Images/img_1_1.png","~/Images/img_2_1.png","~/Images/img_5_2.png"),//BE, true true true
        new Case("NO","YES","YES","YES","YES","SUSPECTED CROHN'S","NORMAL", "SUSPECTED CANCER", "SUSPECTED CANCER","SUSPECTED CANCER"),//BE, true true true
       // new Case("Young","Female","Long_time","Medium","High","High","No","NORMAL","SUSPECTED CANCER","NORMAL","NORMAL","~/Images/img_1_1.png","~/Images/img_2_3.png","~/Images/img_5_11.png"), //Normal, true true true		
		//new Case("Middle","Female","Long_time","High","Medium","High","No","NORMAL","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER","~/Images/img_1_1.png","~/Images/img_2_2.png","~/Images/img_5_6.png"), //Normal all wrong, true true true
        new Case("NO","NO","NO","NO","NO","NORMAL","NORMAL","SUSPECTED CANCER", "SUSPECTED CANCER","NORMAL"),///Normal, true false true		
		//new Case("Old","Female","Long_time","Medium","Medium","Medium","Yes","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER","~/Images/img_1_1.png","~/Images/img_2_2.png","~/Images/img_5_5.png"),//BE, true true true     
		
        new Case("YES","YES","NO","YES","NO","SUSPECTED CROHN'S","SUSPECTED CROHN'S", "SUSPECTED CANCER", "SUSPECTED CANCER","NORMAL"), //Normal, false true false
       //new Case("Middle","Male","Recent","Low","Low","Medium","No","NORMAL","NORMAL","SUSPECTED CANCER","NORMAL","~/Images/img_1_2.png","~/Images/img_2_4.png","~/Images/img_5_14.png"),///Normal, true false true							
		new Case("NO","YES","NO","NO","NO","SUSPECTED CROHN'S","NORMAL","NORMAL", "SUSPECTED CANCER","SUSPECTED CANCER"),//Normal, false false true
		//new Case("Young","Female","Recent","High","High","High","Yes","NORMAL","NORMAL","NORMAL","NORMAL","~/Images/img_1_2.png","~/Images/img_2_5.png","~/Images/img_5_17.png"), //Normal, true true true       
       // new Case("Young","Male","Long_time","Low","Medium","Low","Yes","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER","~/Images/img_1_1.png","~/Images/img_2_2.png","~/Images/img_5_7.png"),//BE, true true true
		new Case("NO","NO","NO","NO","NO","NORMAL","NORMAL","SUSPECTED CANCER", "SUSPECTED CANCER","NORMAL"),///BE, false true true		
       // new Case("Young","Female","Long_time","Medium","Medium","Medium","Yes","NORMAL","SUSPECTED CANCER","SUSPECTED CANCER","NORMAL","~/Images/img_1_1.png","~/Images/img_2_2.png","~/Images/img_5_8.png"),//Normal, false false true
        new Case("NO","NO","YES","NO","NO","SUSPECTED CROHN'S","NORMAL","NORMAL", "SUSPECTED CANCER","SUSPECTED CANCER"),//Normal, false false true
       // new Case("Old","Male","Long_time","Low","Medium","Medium","No","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER","~/Images/img_1_1.png","~/Images/img_2_2.png","~/Images/img_5_5.png"),//BE, true true true
		new Case("NO","NO","YES","NO","YES","NORMAL","NORMAL","NORMAL", "SUSPECTED CANCER","NORMAL") ///Normal, true true true
 };




        //static SarsaLambda SarsaModel;

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
            LblErr.Visible = false;
            SetPageNoCache();
            if (!IsPostBack)
            {
                

                    
               //int NumTree = Convert.ToInt32(HttpContext.Current.Session["NumTree"].ToString());
               int NumTree = 4;
               switch(NumTree)
                {
                    case 1:
                        CheckBoxList1.Visible = false;
                        Label_which.Visible = false;
                        Label20.Visible = false;
                       // CheckBoxList1.Items.Remove(CheckBoxList1.Items[7]);
                       // CheckBoxList1.Items.Remove(CheckBoxList1.Items[6]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[5]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[4]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[3]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[2]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[1]);
                        Label_2_a.Visible = false;
                        lblBowelChange.Visible = false;
                        Label_2_b.Visible = false;
                        lblFatigueT.Visible = false;
                        Label_3_a.Visible = false;
                        lblSuggerGI_Problems.Visible = false;
                        Label_3_b.Visible = false;
                       
                        lblEverBennOverweight.Visible = false;
                        
                        break;
                    case 2:
                      
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[5]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[4]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[3]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[2]);
                        Label_3_a.Visible = false;
                        lblSuggerGI_Problems.Visible = false;
                        Label_3_b.Visible = false;
                       
                        lblEverBennOverweight.Visible = false;
                        Label_2_b.Visible = false;
                        lblFatigueT.Visible = false;
                        break;
                       
                    case 3:
                       // CheckBoxList1.Visible = false;
                       // Label_which.Visible = false;
                        //Label20.Visible = false;
                       // CheckBoxList1.Items.Remove(CheckBoxList1.Items[7]);
                       // CheckBoxList1.Items.Remove(CheckBoxList1.Items[6]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[5]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[4]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[3]);
                       // CheckBoxList1.Items.Remove(CheckBoxList1.Items[2]);//gender
                        //CheckBoxList1.Items.Remove(CheckBoxList1.Items[1]);//stomachPain
                       // Label_2_a.Visible = false;
                       // lblBowelChange.Visible = false;
                        //Label_2_b.Visible = false;
                        //lblFatigueT.Visible = false;
                        Label_3_a.Visible = false;
                        lblSuggerGI_Problems.Visible = false;
                        Label_3_b.Visible = false;
                       
                        lblEverBennOverweight.Visible = false;
                      
                        break;
                   
                    default:
                        break;
                }
               
                MoneQuestionTestingPhase = 0;
                StartTesting = DateTime.Now.ToString("h:mm:ss tt");
                HttpContext.Current.Session["StartTesting"] = StartTesting;
                lblFatigueT.Text = casesArr[MoneQuestionTestingPhase].fatigue;
                lblSuggerGI_Problems.Text = casesArr[MoneQuestionTestingPhase].sufferedFrom_GI_problems;
                lblRectalMucus.Text = casesArr[MoneQuestionTestingPhase].rectalMucus;
                lblBowelChange.Text = casesArr[MoneQuestionTestingPhase].bowelChange;
               // lblTakingStomachMed.Text = casesArr[MoneQuestionTestingPhase].takingStomachMed;
                lblEverBennOverweight.Text = casesArr[MoneQuestionTestingPhase].everBeenOverweight;
               // lblBurningChest.Text = casesArr[MoneQuestionTestingPhase].burningChestLevel;
                // lblClassification.Text = casesArr[mone].classification;
                MoneQuestionTestingPhase++;
                //divTitle.Text = "";
                LblMone.Text = MoneQuestionTestingPhase.ToString() + "/12";
                HttpContext.Current.Session["MoneQuestionTestingPhase"] = MoneQuestionTestingPhase;
               HttpContext.Current.Session["ListAnswers"] = list1;
                // בצע פעולות אתחול
            }
            else
            {
                // בצע את שאר הפעולות
            }
        }
        
          
        
        protected void Btn1_Click(object sender, EventArgs e)
        {
           
            ///
            int t1= RadBtn_classification.SelectedIndex;
            //DetailedLevelArr[mone] = RadBtn_DetailedLevel.SelectedIndex;
            if (t1 == -1)
                LblErr.Visible = true;
            else
            {
                classificationType classAnswer;
                if (t1 == 0)
                    classAnswer = classificationType.NORMAL;
                else if (t1 == 1)
                    classAnswer = classificationType.SUSPECTED_CROHN;
                else
                    classAnswer = classificationType.DONT_KNOW;

                Answer ans = new Answer();
                ans.classificationAnswer = classAnswer;
                int i = 0;
                int NumTree = Convert.ToInt32(HttpContext.Current.Session["NumTree"].ToString());
                //int NumTree =4;
                // mess.Text = "<p>Selected Item(s):</p>";
                for (i = 0; i <= CheckBoxList1.Items.Count - 1; i++)
                {
                    if (CheckBoxList1.Items[i].Selected)
                    {
                        switch (i)
                        {

                            case 0:
                                
                                ans.rectalMucus = true;
                                break;
                            case 1:
                               // if (NumTree == 4)
                                   // ans.fatigue = true;
                               // else // numTree=1/2/3/5
                                    ans.bowelChange = true;
                                
                                break;
                            case 2:
                                ans.fatigue = true;
                                
                                break;
                            case 3:
                                ans.sufferedFrom_GI_problems = true;
                                
                                break;
                            case 4:
                                ans.height = true;
                                break;
                            case 5:
                                ans.everBeenOverweight = true;
                                
                                break;
                           

                        }

                    }
                }

                list1 = (List < Answer > )HttpContext.Current.Session["ListAnswers"];
                //var list = HttpContext.Current.Session["list1"] as List<object>;
                list1.Add(ans);
                HttpContext.Current.Session["ListAnswers"] = list1;   
                //HttpContext.Current.Session["list1"] = new List<object> { new object(), new object() };
                MoneQuestionTestingPhase = Convert.ToInt32(HttpContext.Current.Session["MoneQuestionTestingPhase"].ToString());
                ClickTime = DateTime.Now.ToString("h:mm:ss tt");
                HttpContext.Current.Session["TestingPhaseClick" + MoneQuestionTestingPhase.ToString()] = ClickTime;

                if (MoneQuestionTestingPhase < NumCases)
                {

                    //טעינת השאלה הבאה והתמונה הבאה

                    //  Image1.ImageUrl = "~/Images/img_3_4.png";
                    // panel1 = ArrCases[mone];
                    // CaseLable.Text = ArrCases[mone];
                    lblFatigueT.Text = casesArr[MoneQuestionTestingPhase].fatigue;
                    lblSuggerGI_Problems.Text = casesArr[MoneQuestionTestingPhase].sufferedFrom_GI_problems;
                    lblRectalMucus.Text = casesArr[MoneQuestionTestingPhase].rectalMucus;
                    lblBowelChange.Text = casesArr[MoneQuestionTestingPhase].bowelChange;
                   // lblTakingStomachMed.Text = casesArr[MoneQuestionTestingPhase].takingStomachMed;
                    lblEverBennOverweight.Text = casesArr[MoneQuestionTestingPhase].everBeenOverweight;
                    //lblBurningChest.Text = casesArr[MoneQuestionTestingPhase].burningChestLevel;
                    // lblClassification.Text = casesArr[mone].classification;
                    RadBtn_classification.SelectedIndex = -1;
                    CheckBoxList1.ClearSelection();
                    // RadBtn_IsSaticfied.SelectedIndex = -1;
                    MoneQuestionTestingPhase++;
                    LblMone.Text = MoneQuestionTestingPhase.ToString() + "/12";
                    HttpContext.Current.Session["MoneQuestionTestingPhase"] = MoneQuestionTestingPhase;
                }
                else
                { //

                    FinishTesting = DateTime.Now.ToString("h:mm:ss tt");
                    StartTesting  = HttpContext.Current.Session["StartTesting"].ToString();
                    string UserId = HttpContext.Current.Session["UserId"].ToString();
                    //string connectionString = @"Data Source=DESKTOP-0SB8TU9\SQLEXPRESS01;Initial Catalog=ExperimentDB;Integrated Security=True";
                    //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=ExperimentDB;Integrated Security=True";
                    string connectionString = SqlConnectionHandler.GetConnection();
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {



                        sqlConnection.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = sqlConnection;
                        cmd.Parameters.AddWithValue("@param1", UserId);
                        cmd.Parameters.AddWithValue("@param2", StartTesting);
                        cmd.Parameters.AddWithValue("@param3", FinishTesting);
                        cmd.CommandText = "update TIMES_OF_USERS set StartTesting = @param2, FinishTesting = @param3 where UserId = @param1";
                        cmd.ExecuteNonQuery();
                        int i_q = 1;
                        foreach (Answer l in list1)
                        {

                            SqlCommand cmd_insert = new SqlCommand();
                            cmd_insert.Connection = sqlConnection;
                            cmd_insert.Parameters.AddWithValue("@tz", UserId);
                            cmd_insert.Parameters.AddWithValue("@name_q", i_q);
                            cmd_insert.Parameters.AddWithValue("@classificationAnswer", l.classificationAnswer.ToString());
                            cmd_insert.Parameters.AddWithValue("@sufferedFrom_GI_problems", l.sufferedFrom_GI_problems);
                            cmd_insert.Parameters.AddWithValue("@fatigue", l.fatigue);
                            cmd_insert.Parameters.AddWithValue("@rectal_mucus", l.rectalMucus);
                            cmd_insert.Parameters.AddWithValue("@ever_been_overweight", l.everBeenOverweight);
                            cmd_insert.Parameters.AddWithValue("@height", l.height);
                            cmd_insert.Parameters.AddWithValue("@bowels_change", l.bowelChange);
                           // cmd_insert.Parameters.AddWithValue("@burningChestLevel", l.burningChestLevel);
                          //  cmd_insert.Parameters.AddWithValue("@takingStomachMed", l.takingStomachMed);

                            cmd_insert.CommandText = @"insert into ANSWERS(UserId,QuestionId,ClassificationAnswer,suffered_from_gi_problems,fatigue,rectal_mucus,
                            ever_been_overweight, height, bowels_change)
                            values (@tz,@name_q, @classificationAnswer,@sufferedFrom_GI_problems, @fatigue, @rectal_mucus,
                            @ever_been_overweight,@height,@bowels_change)";
                            cmd_insert.ExecuteNonQuery();
                            i_q++;
                        }
                        sqlConnection.Close();
                    
                    }


                    Response.Redirect("~/SatisfactionForm.aspx");
                }

          
            }
        }

 


    }
}
