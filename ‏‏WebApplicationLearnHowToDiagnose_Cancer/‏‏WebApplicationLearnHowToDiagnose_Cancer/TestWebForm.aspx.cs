using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    enum classificationType { NORMAL = 0, SUSPECTED_CANCER = 1,DONT_KNOW = 2 }
    class Answer
    {
        public classificationType classificationAnswer;
        public bool age;
        public bool gender;
        public bool yearsSinceAcidTasteStart;
        public bool chestPain;
        public bool weight;
        public bool stomachPain;
        public bool burningChestLevel;
        public bool takingStomachMed;

        public Answer(classificationType classificationAnswer, bool age, bool gender, bool yearsSinceAcidTasteStart, bool chestPain, bool weight,
                       bool stomachPain, bool burningChestLevel, bool takingStomachMed)
        {
            this.classificationAnswer = classificationAnswer;
            this.age = age;
            this.gender = gender;
            this.yearsSinceAcidTasteStart = yearsSinceAcidTasteStart;
            this.chestPain = chestPain;
            this.weight = weight;
            this.stomachPain = stomachPain;
            this.burningChestLevel = burningChestLevel;
            this.takingStomachMed = takingStomachMed;
        }
        public Answer() {

            this.classificationAnswer = classificationType.DONT_KNOW;
            this.age = false;
            this.gender = false;
            this.yearsSinceAcidTasteStart = false;
            this.chestPain = false;
            this.weight = false;
            this.stomachPain = false;
            this.burningChestLevel = false;
            this.takingStomachMed = false;
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
        new Case("Old","Male","Long_time","Medium","High","Low","No","NORMAL","SUSPECTED CANCER","NORMAL","NORMAL","SUSPECTED CANCER","NORMAL"), //808,5_11
        new Case("Middle","Male","Long_time","Low","Medium","Medium","Yes","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER"),//	888,5_6
         new Case("Middle","Male","Recent","Low","Low","Low","Yes","SUSPECTED CANCER","NORMAL","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER","NORMAL"),//5_13
        new Case("Old","Female","Long_time","Medium","Low","Low","Yes","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER"),	//914,5_2
        new Case("Young","Male","Long_time","Medium","Low","Low","No","NORMAL","SUSPECTED CANCER","SUSPECTED CANCER","NORMAL","SUSPECTED CANCER","SUSPECTED CANCER"),//	418,5_3
        new Case("Middle","Female","Recent","Medium","Low","High","Yes","NORMAL","NORMAL","NORMAL","NORMAL","NORMAL","NORMAL"),//	50,5_17
        new Case("Old","Male","Long_time","Low","Low","Low","Yes","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER"),//	965,5_1
       // new Case("Old","Male","Long_time","Low","Medium","Medium","No","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER"),//	1146
        new Case("Young","Male","Long_time","Low","Medium","Low","Yes","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER"),//	148,5_7
       // new Case("Middle","Female","Recent","Low","High","High","No","SUSPECTED CANCER","NORMAL","NORMAL","NORMAL"),//309
        new Case("Old","Male","Recent","Low","Low","Low","Yes","SUSPECTED CANCER","NORMAL","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER","NORMAL"),//	16,5_12
       // new Case("Middle","Male","Recent","Low","Low","Low","Yes","NORMAL","NORMAL","SUSPECTED CANCER","SUSPECTED CANCER"),//	1113
        new Case("Middle","Female","Long_time","Low","High","Medium","Yes","NORMAL","SUSPECTED CANCER","NORMAL","SUSPECTED CANCER","SUSPECTED CANCER","NORMAL"),//	556,5_10
        new Case("Young","Male","Recent","Medium","High","High","No","NORMAL","NORMAL","SUSPECTED CANCER","NORMAL","SUSPECTED CANCER","NORMAL"),//	706,5_16
        new Case("Middle","Female","Long_time","High","Low","High","Yes","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER"),//	1140,5_4
       // new Case("Old","Male","Long_time","Medium","Medium","Medium","Yes","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER")//	1199

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
               int NumTree = 2;
               switch(NumTree)
                {
                    case 1:
                        CheckBoxList1.Visible = false;
                        Label_which.Visible = false;
                        Label20.Visible = false;
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[7]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[6]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[5]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[4]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[3]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[2]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[1]);
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
                        break;
                    case 2:
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
                        break;
                       
                    case 4:
                       // CheckBoxList1.Visible = false;
                       // Label_which.Visible = false;
                        //Label20.Visible = false;
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[7]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[6]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[5]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[4]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[3]);
                       // CheckBoxList1.Items.Remove(CheckBoxList1.Items[2]);//gender
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[1]);//stomachPain
                        Label_2_a.Visible = false;
                        lblStonachPain.Visible = false;
                        //Label_2_b.Visible = false;
                        //lblGenderT.Visible = false;
                        Label_3_a.Visible = false;
                        lblAge.Visible = false;
                        Label_3_b.Visible = false;
                        lblTakingStomachMed.Visible = false;
                        Label_3_c.Visible = false;
                        lblChestPain.Visible = false;
                        Label_3_d.Visible = false;
                        lblBurningChest.Visible = false;
                        break;
                    case 5:
                        // CheckBoxList1.Visible = false;
                        // Label_which.Visible = false;
                        //Label20.Visible = false;
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[7]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[6]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[5]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[4]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[3]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[2]);//gender
                        //CheckBoxList1.Items.Remove(CheckBoxList1.Items[1]);////stomachPain
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
                       
                        break;
                    default:
                        break;
                }
                /*if (NumTree == 1)
                {

                    CheckBoxList1.Visible = false;
                    Label_which.Visible = false;
                    Label20.Visible = false;
                    CheckBoxList1.Items.Remove(CheckBoxList1.Items[7]);
                    CheckBoxList1.Items.Remove(CheckBoxList1.Items[6]);
                    CheckBoxList1.Items.Remove(CheckBoxList1.Items[5]);
                    CheckBoxList1.Items.Remove(CheckBoxList1.Items[4]);
                    CheckBoxList1.Items.Remove(CheckBoxList1.Items[3]);
                    CheckBoxList1.Items.Remove(CheckBoxList1.Items[2]);
                    CheckBoxList1.Items.Remove(CheckBoxList1.Items[1]);
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


                }
                else
                {
                    if (NumTree == 2)
                    {


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


                    }
                    else if (NumTree == 4)
                    {

                        CheckBoxList1.Visible = false;
                        Label_which.Visible = false;
                        Label20.Visible = false;
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[7]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[6]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[5]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[4]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[3]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[2]);
                        CheckBoxList1.Items.Remove(CheckBoxList1.Items[1]);
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


                    }
                }
                */
                MoneQuestionTestingPhase = 0;
                StartTesting = DateTime.Now.ToString("h:mm:ss tt");
                HttpContext.Current.Session["StartTesting"] = StartTesting;
                lblGenderT.Text = casesArr[MoneQuestionTestingPhase].gender;
                lblAge.Text = casesArr[MoneQuestionTestingPhase].age;
                lblYearsSinceAcidTasteStart.Text = casesArr[MoneQuestionTestingPhase].yearsSinceAcidTasteStart;
                lblStonachPain.Text = casesArr[MoneQuestionTestingPhase].stomachPain;
                lblTakingStomachMed.Text = casesArr[MoneQuestionTestingPhase].takingStomachMed;
                lblChestPain.Text = casesArr[MoneQuestionTestingPhase].chestPain;
                lblBurningChest.Text = casesArr[MoneQuestionTestingPhase].burningChestLevel;
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
            // Image1.ImageUrl = "~/Images/treeDepth4_Samples10_Acc83_Case1.png";

            //  DetailedLevelArr[mone] = RadBtn_DetailedLevel.SelectedIndex;
            //  IsSaticfiedArr[mone] = RadBtn_IsSaticfied.SelectedIndex;
            // if (DetailedLevelArr[mone] == -1 || IsSaticfiedArr[mone] == -1)
            //   if (DetailedLevelArr[mone] == -1)
            // Lbl_DetailedLevelEmpty.Visible = true;
            //  if (IsSaticfiedArr[mone] == -1)
            //    Lbl_isSatifiedEmpty.Visible = true;
            ////else
       ///classificationType { NORMAL = 0, SUSPECTED_CANCER = 1 }
    /*class Answer
        {
            public classificationType classificationAnswer;
            public bool age;
            public bool gender;
            public bool yearsSinceAcidTasteStart;
            public bool chestPain;
            public bool weight;
            public bool stomachPain;
            public bool burningChestLevel;
            public bool takingStomachMed;
    */

            /// 
            /// 
            //// {
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
                    classAnswer = classificationType.SUSPECTED_CANCER;
                else
                    classAnswer = classificationType.DONT_KNOW;

                Answer ans = new Answer();
                ans.classificationAnswer = classAnswer;
                int i = 0;
                int NumTree = Convert.ToInt32(HttpContext.Current.Session["NumTree"].ToString());

                // mess.Text = "<p>Selected Item(s):</p>";
                for (i = 0; i <= CheckBoxList1.Items.Count - 1; i++)
                {
                    if (CheckBoxList1.Items[i].Selected)
                    {
                        switch (i)
                        {

                            case 0:
                                
                                ans.yearsSinceAcidTasteStart = true;
                                break;
                            case 1:
                                if (NumTree == 4)
                                    ans.gender = true;
                                else // numTree=1/2/3/5
                                    ans.stomachPain = true;
                                
                                break;
                            case 2:
                                ans.gender = true;
                                
                                break;
                            case 3:
                                ans.age = true;
                                
                                break;
                            case 4:
                                ans.weight = true;
                                break;
                            case 5:
                                ans.chestPain = true;
                                
                                break;
                            case 6:
                                ans.takingStomachMed = true;
                                break;
                            case 7:
                                ans.burningChestLevel = true;
                               
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
                    lblGenderT.Text = casesArr[MoneQuestionTestingPhase].gender;
                    lblAge.Text = casesArr[MoneQuestionTestingPhase].age;
                    lblYearsSinceAcidTasteStart.Text = casesArr[MoneQuestionTestingPhase].yearsSinceAcidTasteStart;
                    lblStonachPain.Text = casesArr[MoneQuestionTestingPhase].stomachPain;
                    lblTakingStomachMed.Text = casesArr[MoneQuestionTestingPhase].takingStomachMed;
                    lblChestPain.Text = casesArr[MoneQuestionTestingPhase].chestPain;
                    lblBurningChest.Text = casesArr[MoneQuestionTestingPhase].burningChestLevel;
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
                            cmd_insert.Parameters.AddWithValue("@age", l.age);
                            cmd_insert.Parameters.AddWithValue("@gender", l.gender);
                            cmd_insert.Parameters.AddWithValue("@yearsSinceAcidTasteStart", l.yearsSinceAcidTasteStart);
                            cmd_insert.Parameters.AddWithValue("@chestPain", l.chestPain);
                            cmd_insert.Parameters.AddWithValue("@weight", l.weight);
                            cmd_insert.Parameters.AddWithValue("@stomachPain", l.stomachPain);
                            cmd_insert.Parameters.AddWithValue("@burningChestLevel", l.burningChestLevel);
                            cmd_insert.Parameters.AddWithValue("@takingStomachMed", l.takingStomachMed);

                            cmd_insert.CommandText = @"insert into ANSWERS(UserId,QuestionId,ClassificationAnswer,Age,Gender,HowLongAcidTasteExists,
                            ChestPain, Weight, StomachPain, BurningChestLevel,TakingStomachMed)
                            values (@tz,@name_q, @classificationAnswer,@age, @gender, @yearsSinceAcidTasteStart,
                            @chestPain,@weight,@stomachPain, @burningChestLevel, @takingStomachMed)";
                            cmd_insert.ExecuteNonQuery();
                            i_q++;
                        }
                        sqlConnection.Close();
                    
                    }


                    Response.Redirect("~/SatisfactionForm.aspx");
                }

                /*Message.Text = "Selected Item(s):<br /><br />";
                // Iterate through the Items collection of the CheckBoxList
                // control and display the selected items.
                for (int i=0; i<checkboxlist1.Items.Count; i++)
                {
                if (checkboxlist1.Items[i].Selected)
                {Message.Text += checkboxlist1.Items[i].Text + "<br />";            }
                }
                */
            }
        }

 


    }
}
