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
        public string age;
        public string gender;
        public string yearsSinceAcidTasteStart;
        public string chestPain;
        public string stomachPain;
        public string burningChestLevel;
        public string takingStomachMed;
        public string realClassification;
        public string classificationPth1;
        public string classificationPth2;
        public string classificationPth3;
        public string classificationPth4;
        public string classificationPth5;
        public string imagePth1;
        public string imagePth2;
        public string imagePth3;
        public string imagePth4;
        public string imagePth5;
        // int  featersExistFlags [7];
        public Case(string age,
                    string gender,
                    string yearsSinceAcidTasteStart,
                    string chestPain,
                    string stomachPain,
                    string burningChestLevel,
                    string takingStomachMed,
                    string realClassification,
                    string classificationPth1,
                    string classificationPth2,
                    string classificationPth3,
                    string classificationPth4,
                    string classificationPth5,
                    string imagePth1,
                    string imagePth2,
                    string imagePth3,
                    string imagePth4,
                    string imagePth5)
        {
            this.age = age;
            this.gender = gender;
            this.yearsSinceAcidTasteStart = yearsSinceAcidTasteStart;
            this.chestPain = chestPain;
            this.stomachPain = stomachPain;
            this.burningChestLevel = burningChestLevel;
            this.takingStomachMed = takingStomachMed;
            this.realClassification = realClassification;
            this.classificationPth1 = classificationPth1;
            this.classificationPth2 = classificationPth2;
            this.classificationPth3 = classificationPth3;
            this.classificationPth4 = classificationPth4;
            this.classificationPth5 = classificationPth5;
            this.imagePth1 = imagePth1;
            this.imagePth2 = imagePth2;
            this.imagePth3 = imagePth3;
            this.imagePth4 = imagePth4;
            this.imagePth5 = imagePth5;
        }

        public Case(string age,
               string gender,
               string yearsSinceAcidTasteStart,
               string chestPain,
               string stomachPain,
               string burningChestLevel,
               string takingStomachMed,
               string realClassification,
               string classificationPth1,
               string classificationPth2,
               string classificationPth3,
               string classificationPth4,
               string classificationPth5
               )
        {
            this.age = age;
            this.gender = gender;
            this.yearsSinceAcidTasteStart = yearsSinceAcidTasteStart;
            this.chestPain = chestPain;
            this.stomachPain = stomachPain;
            this.burningChestLevel = burningChestLevel;
            this.takingStomachMed = takingStomachMed;
            this.realClassification = realClassification;
            this.classificationPth1 = classificationPth1;
            this.classificationPth2 = classificationPth2;
            this.classificationPth3 = classificationPth3;
            this.classificationPth4 = classificationPth4;
            this.classificationPth5 = classificationPth5;
            this.imagePth1 = " ";
            this.imagePth2 = " ";
            this.imagePth3 = " ";
            this.imagePth4 = " ";
            this.imagePth5 = " ";
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

        new Case("Old", "Male",    "Long_time",   "Medium",  "Low", "Low" ,"Yes","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER", "SUSPECTED CANCER", "SUSPECTED CANCER","SUSPECTED CANCER","~/Images/img_1_1.png","~/Images/img_2_1.png","~/Images/img_5_2.png","~/Images/img_4_1.png","~/Images/img_5_b_1.png"), //BE, true true true
         new Case("Old","Female","Recent","Low","Low","Medium","Yes","SUSPECTED CANCER","NORMAL","NORMAL","NORMAL","NORMAL","NORMAL","~/Images/img_1_2.png","~/Images/img_2_5.png","~/Images/img_5_17.png","~/Images/img_4_3.png","~/Images/img_5_b_4.png"),//BE, false false false
        new Case("Middle","Female","Long_time","Low","Low","Medium","Yes","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER", "SUSPECTED CANCER", "SUSPECTED CANCER","SUSPECTED CANCER","~/Images/img_1_1.png","~/Images/img_2_1.png","~/Images/img_5_1.png","~/Images/img_4_1.png","~/Images/img_5_b_1.png"), // BE, true true true
        new Case("Old","Male","Recent","Low","Low","Low","Yes","SUSPECTED CANCER","NORMAL","SUSPECTED CANCER", "SUSPECTED CANCER", "SUSPECTED CANCER","NORMAL","~/Images/img_1_2.png","~/Images/img_2_4.png","~/Images/img_5_12.png","~/Images/img_4_2.png","~/Images/img_5_b_4.png"), //BE, true true true
        //new Case("Middle","Female","Recent","Medium","High","Low","Yes","NORMAL","NORMAL","NORMAL","NORMAL","~/Images/img_1_2.png","~/Images/img_2_5.png","~/Images/img_5_17.png"), //Normal, true true true        
       // new Case("Young","Male","Recent","Medium","High","High","Yes","NORMAL","NORMAL","SUSPECTED CANCER","NORMAL","~/Images/img_1_2.png","~/Images/img_2_4.png","~/Images/img_5_16.png"), //Normal, true false true
        new Case("Old","Male","Long_time","High","Low","Low","Yes","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER", "SUSPECTED CANCER","SUSPECTED CANCER","~/Images/img_1_1.png","~/Images/img_2_1.png","~/Images/img_5_4.png","~/Images/img_4_1.png","~/Images/img_5_b_1.png"),//BE, true true true
	  	//new Case("Middle","Male","Long_time","Medium","Low","Medium","Yes","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER", "SUSPECTED CANCER","~/Images/img_1_1.png","~/Images/img_2_1.png","~/Images/img_5_2.png"),//BE, true true true
        new Case("Old","Female","Long_time","Medium","Medium","High","Yes","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER", "SUSPECTED CANCER", "SUSPECTED CANCER","SUSPECTED CANCER","~/Images/img_1_1.png","~/Images/img_2_2.png","~/Images/img_5_5.png","~/Images/img_4_1.png","~/Images/img_5_b_2.png"),//BE, true true true
       // new Case("Young","Female","Long_time","Medium","High","High","No","NORMAL","SUSPECTED CANCER","NORMAL","NORMAL","~/Images/img_1_1.png","~/Images/img_2_3.png","~/Images/img_5_11.png"), //Normal, true true true		
		//new Case("Middle","Female","Long_time","High","Medium","High","No","NORMAL","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER","~/Images/img_1_1.png","~/Images/img_2_2.png","~/Images/img_5_6.png"), //Normal all wrong, true true true
        new Case("Middle","Male","Recent","Low","Low","High","No","NORMAL","NORMAL","SUSPECTED CANCER","NORMAL", "SUSPECTED CANCER","NORMAL","~/Images/img_1_2.png","~/Images/img_2_4.png","~/Images/img_5_15.png","~/Images/img_4_2.png","~/Images/img_5_b_4.png"),///Normal, true false true		
		//new Case("Old","Female","Long_time","Medium","Medium","Medium","Yes","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER","~/Images/img_1_1.png","~/Images/img_2_2.png","~/Images/img_5_5.png"),//BE, true true true     
		
        new Case("Middle","Male","Long_time","Low","High","Low","Yes","NORMAL","SUSPECTED CANCER","NORMAL", "SUSPECTED CANCER", "SUSPECTED CANCER","NORMAL","~/Images/img_1_1.png","~/Images/img_2_3.png","~/Images/img_5_10.png","~/Images/img_4_1.png","~/Images/img_5_b_3.png"), //Normal, false true false
       //new Case("Middle","Male","Recent","Low","Low","Medium","No","NORMAL","NORMAL","SUSPECTED CANCER","NORMAL","~/Images/img_1_2.png","~/Images/img_2_4.png","~/Images/img_5_14.png"),///Normal, true false true							
		new Case("Young","Male","Long_time","High","Medium","High","No","NORMAL","SUSPECTED CANCER","SUSPECTED CANCER","NORMAL", "SUSPECTED CANCER","SUSPECTED CANCER","~/Images/img_1_1.png","~/Images/img_2_2.png","~/Images/img_5_9.png","~/Images/img_4_1.png","~/Images/img_5_b_2.png"),//Normal, false false true
		//new Case("Young","Female","Recent","High","High","High","Yes","NORMAL","NORMAL","NORMAL","NORMAL","~/Images/img_1_2.png","~/Images/img_2_5.png","~/Images/img_5_17.png"), //Normal, true true true       
       // new Case("Young","Male","Long_time","Low","Medium","Low","Yes","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER","~/Images/img_1_1.png","~/Images/img_2_2.png","~/Images/img_5_7.png"),//BE, true true true
		new Case("Middle","Male","Recent","Low","Low","Low","Yes","SUSPECTED CANCER","NORMAL","SUSPECTED CANCER","SUSPECTED CANCER", "SUSPECTED CANCER","NORMAL","~/Images/img_1_2.png","~/Images/img_2_4.png","~/Images/img_5_13.png","~/Images/img_4_2.png","~/Images/img_5_b_4.png"),///BE, false true true		
       // new Case("Young","Female","Long_time","Medium","Medium","Medium","Yes","NORMAL","SUSPECTED CANCER","SUSPECTED CANCER","NORMAL","~/Images/img_1_1.png","~/Images/img_2_2.png","~/Images/img_5_8.png"),//Normal, false false true
        new Case("Young","Male","Long_time","Medium	","Low","Low","No","NORMAL","SUSPECTED CANCER","SUSPECTED CANCER","NORMAL", "SUSPECTED CANCER","SUSPECTED CANCER","~/Images/img_1_1.png","~/Images/img_2_1.png","~/Images/img_5_3.png","~/Images/img_4_1.png","~/Images/img_5_b_1.png"),//Normal, false false true
       // new Case("Old","Male","Long_time","Low","Medium","Medium","No","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER","SUSPECTED CANCER","~/Images/img_1_1.png","~/Images/img_2_2.png","~/Images/img_5_5.png"),//BE, true true true
		new Case("Young","Male","Recent","Low","High","Medium","Yes","NORMAL","NORMAL","SUSPECTED CANCER","NORMAL", "SUSPECTED CANCER","NORMAL","~/Images/img_1_2.png","~/Images/img_2_4.png","~/Images/img_5_16.png","~/Images/img_4_2.png","~/Images/img_5_b_4.png") ///Normal, true true true
 };



        protected void ChangeBackColor(Color cGender, Color cAge, Color cStonachPain,
                                       Color cTakingStomachMed, Color cChestPain, Color cBurningChest)
        {
            lblGenderQ.BackColor = cGender;
            lblGender.BackColor = cGender;

            lblAgeQ.BackColor = cAge;
            lblAge.BackColor = cAge;



            lblStonachPainQ.BackColor = cStonachPain;
            lblStonachPain.BackColor = cStonachPain;

            lblTakingStomachMedQ.BackColor = cTakingStomachMed;
            lblTakingStomachMed.BackColor = cTakingStomachMed;

            lblChestPainQ.BackColor = cChestPain;
            lblChestPain.BackColor = cChestPain;

            lblBurningChestQ.BackColor = cBurningChest;
            lblBurningChest.BackColor = cBurningChest;

          

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
           

            lblYearsSinceAcidTasteStartQ.BackColor = System.Drawing.Color.LightGreen;
            lblYearsSinceAcidTasteStart.BackColor = System.Drawing.Color.LightGreen;

            lblClassificationQ.BackColor = System.Drawing.Color.LightGreen;
            lblClassification.BackColor = System.Drawing.Color.LightGreen;
            SetPageNoCache();

            //lblChestPain. = System.Drawing.Color.MediumSeaGreen;
            //lblBurningChestQ.ForeColor = System.Drawing.Color.Black;
            if (!IsPostBack)
            {
              

                    
                    MoneQuestionLearningPhase = 0;
                StartLearning = DateTime.Now.ToString("h:mm:ss tt");
                HttpContext.Current.Session["StartLearning"] = StartLearning;
                
                 NumTree = Convert.ToInt32(HttpContext.Current.Session["NumTree"].ToString());
               // NumTree = 5;
                switch(NumTree)
                {
                    case 1:
                        Image1.ImageUrl = casesArr[MoneQuestionLearningPhase].imagePth1;
                        Image1.Height = Unit.Percentage(90);
                        Image1.Width = Unit.Percentage(90);
                        lblClassification.Text = casesArr[MoneQuestionLearningPhase].classificationPth1;
                        lblStonachPainQ.Visible = false;
                        lblStonachPain.Visible = false;
                        lblGenderQ.Visible = false;
                        lblGender.Visible = false;
                        lblAgeQ.Visible = false;
                        lblAge.Visible = false;
                        lblTakingStomachMedQ.Visible = false;
                        lblTakingStomachMed.Visible = false;
                        lblChestPainQ.Visible = false;
                        lblChestPain.Visible = false;
                        lblBurningChestQ.Visible = false;
                        lblBurningChest.Visible = false;
                        break;
                    case 2:
                        ChangeBackColor(cGray, cGray, cGreen, cGray, cGray, cGray);
                        Image1.ImageUrl = casesArr[MoneQuestionLearningPhase].imagePth2;
                        // Image1.ImageUrl = "C:/Users/Yonatan/Desktop/projectHazatMechkar/‏‏WebApplication5/WebApplication3/Images/img_2_5.png";


                        Image1.Height = Unit.Percentage(90);
                        Image1.Width = Unit.Percentage(90);
                        lblClassification.Text = casesArr[MoneQuestionLearningPhase].classificationPth2;

                        lblAgeQ.Visible = false;
                        lblAge.Visible = false;
                        lblTakingStomachMedQ.Visible = false;
                        lblTakingStomachMed.Visible = false;
                        lblChestPainQ.Visible = false;
                        lblChestPain.Visible = false;
                        lblBurningChestQ.Visible = false;
                        lblBurningChest.Visible = false;
                        break;
                    case 3:
                        ChangeBackColor(cGray, cGray, cGreen, cGreen, cGreen, cGray);
                        Image1.ImageUrl = casesArr[MoneQuestionLearningPhase].imagePth3;
                        // Image1.Height = Unit.Percentage(97);
                        //  Image1.Width = Unit.Percentage(100);
                        lblClassification.Text = casesArr[MoneQuestionLearningPhase].classificationPth3;

                        break;
                    case 4:
                        ChangeBackColor(cGray, cGray, cGray, cGray, cGray, cGray);
                        Image1.ImageUrl = casesArr[MoneQuestionLearningPhase].imagePth4;
                        Image1.Height = Unit.Percentage(90);
                        Image1.Width = Unit.Percentage(90);
                        lblClassification.Text = casesArr[MoneQuestionLearningPhase].classificationPth4;
                        lblStonachPainQ.Visible = false;
                        lblStonachPain.Visible = false;
                       // lblGenderQ.Visible = false;
                       // lblGender.Visible = false;
                        lblAgeQ.Visible = false;
                        lblAge.Visible = false;
                        lblTakingStomachMedQ.Visible = false;
                        lblTakingStomachMed.Visible = false;
                        lblChestPainQ.Visible = false;
                        lblChestPain.Visible = false;
                        lblBurningChestQ.Visible = false;
                        lblBurningChest.Visible = false;
                        break;
                    case 5:
                        ChangeBackColor(cGray, cGray, cGreen, cGray, cGray, cGray);
                        Image1.ImageUrl = casesArr[MoneQuestionLearningPhase].imagePth5;
                        Image1.Height = Unit.Percentage(90);
                        Image1.Width = Unit.Percentage(90);
                        lblClassification.Text = casesArr[MoneQuestionLearningPhase].classificationPth5;
                        //lblStonachPainQ.Visible = false;
                        //lblStonachPain.Visible = false;
                        lblGenderQ.Visible = false;
                         lblGender.Visible = false;
                        lblAgeQ.Visible = false;
                        lblAge.Visible = false;
                        lblTakingStomachMedQ.Visible = false;
                        lblTakingStomachMed.Visible = false;
                        lblChestPainQ.Visible = false;
                        lblChestPain.Visible = false;
                        lblBurningChestQ.Visible = false;
                        lblBurningChest.Visible = false;
                        break;
                    default: break;
                }
               /* if (NumTree == 1)
                {
                    Image1.ImageUrl = casesArr[MoneQuestionLearningPhase].imagePth1;
                    Image1.Height = Unit.Percentage(90);
                    Image1.Width = Unit.Percentage(90);
                    lblClassification.Text = casesArr[MoneQuestionLearningPhase].classificationPth1;
                    lblStonachPainQ.Visible = false;
                    lblStonachPain.Visible = false;
                    lblGenderQ.Visible = false;
                    lblGender.Visible = false;
                    lblAgeQ.Visible = false;
                    lblAge.Visible = false;
                    lblTakingStomachMedQ.Visible = false;
                    lblTakingStomachMed.Visible = false;
                    lblChestPainQ.Visible = false;
                    lblChestPain.Visible = false;
                    lblBurningChestQ.Visible = false;
                    lblBurningChest.Visible = false;
                }
                else if(NumTree == 2)
                {
                    ChangeBackColor(cGray, cGray, cGreen, cGray, cGray, cGray);
                    Image1.ImageUrl = casesArr[MoneQuestionLearningPhase].imagePth2;
                   // Image1.ImageUrl = "C:/Users/Yonatan/Desktop/projectHazatMechkar/‏‏WebApplication5/WebApplication3/Images/img_2_5.png";


                   Image1.Height = Unit.Percentage(90);
                   Image1.Width = Unit.Percentage(90);
                    lblClassification.Text = casesArr[MoneQuestionLearningPhase].classificationPth2;
                   
                    lblAgeQ.Visible = false;
                    lblAge.Visible = false;
                    lblTakingStomachMedQ.Visible = false;
                    lblTakingStomachMed.Visible = false;
                    lblChestPainQ.Visible = false;
                    lblChestPain.Visible = false;
                    lblBurningChestQ.Visible = false;
                    lblBurningChest.Visible = false;
                }
                else
                {
                    ChangeBackColor(cGray, cGray,cGreen, cGreen, cGreen, cGray);
                    Image1.ImageUrl = casesArr[MoneQuestionLearningPhase].imagePth3;
                   // Image1.Height = Unit.Percentage(97);
                  //  Image1.Width = Unit.Percentage(100);
                    lblClassification.Text = casesArr[MoneQuestionLearningPhase].classificationPth3;
                }
                */
                lblGender.Text = casesArr[MoneQuestionLearningPhase].gender;
                lblAge.Text = casesArr[MoneQuestionLearningPhase].age;
                lblYearsSinceAcidTasteStart.Text = casesArr[MoneQuestionLearningPhase].yearsSinceAcidTasteStart;
                lblStonachPain.Text = casesArr[MoneQuestionLearningPhase].stomachPain;
                lblTakingStomachMed.Text = casesArr[MoneQuestionLearningPhase].takingStomachMed;
                lblChestPain.Text = casesArr[MoneQuestionLearningPhase].chestPain;
                lblBurningChest.Text = casesArr[MoneQuestionLearningPhase].burningChestLevel;

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
            // NumTree = 1;
            // Image1.ImageUrl = "~/Images/treeDepth4_Samples10_Acc83_Case1.png";

            //  DetailedLevelArr[mone] = RadBtn_DetailedLevel.SelectedIndex;
            //  IsSaticfiedArr[mone] = RadBtn_IsSaticfied.SelectedIndex;
            // if (DetailedLevelArr[mone] == -1 || IsSaticfiedArr[mone] == -1)
            //   if (DetailedLevelArr[mone] == -1)
            //  Lbl_DetailedLevelEmpty.Visible = true;
            //  if (IsSaticfiedArr[mone] == -1)
            //    Lbl_isSatifiedEmpty.Visible = true;
            ////else
            //// {
            MoneQuestionLearningPhase = Convert.ToInt32(HttpContext.Current.Session["MoneQuestionLearningPhase"].ToString());
            
            ClickTime = DateTime.Now.ToString("h:mm:ss tt");
            HttpContext.Current.Session["LearningPhaseClick"+ MoneQuestionLearningPhase.ToString()] = ClickTime;
            if (MoneQuestionLearningPhase < NumCases)
            {
                 NumTree = Convert.ToInt32(HttpContext.Current.Session["NumTree"].ToString());
               // NumTree = 5;
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
                        lblStonachPainQ.Visible = false;
                        lblStonachPain.Visible = false;
                        lblGenderQ.Visible = false;
                        lblGender.Visible = false;
                        lblAgeQ.Visible = false;
                        lblAge.Visible = false;
                        lblTakingStomachMedQ.Visible = false;
                        lblTakingStomachMed.Visible = false;
                        lblChestPainQ.Visible = false;
                        lblChestPain.Visible = false;
                        lblBurningChestQ.Visible = false;
                        lblBurningChest.Visible = false;
                        break;
                    case 2:
                        Image1.ImageUrl = casesArr[MoneQuestionLearningPhase].imagePth2;
                        Image1.Height = Unit.Percentage(90);
                        Image1.Width = Unit.Percentage(90);
                        lblClassification.Text = casesArr[MoneQuestionLearningPhase].classificationPth2;
                        switch (MoneQuestionLearningPhase)
                        {
                            case 1:
                                ChangeBackColor(cGreen, cGray, cGray, cGray, cGray, cGray);
                                break;
                            case 2:
                                ChangeBackColor(cGray, cGray, cGreen, cGray, cGray, cGray);
                                break;
                            case 3:
                                ChangeBackColor(cGreen, cGray, cGray, cGray, cGray, cGray);
                                break;
                            case 4:
                                ChangeBackColor(cGray, cGray, cGreen, cGray, cGray, cGray);
                                break;
                            case 5:
                                ChangeBackColor(cGray, cGray, cGreen, cGray, cGray, cGray);
                                break;
                            case 6:
                                ChangeBackColor(cGreen, cGray, cGray, cGray, cGray, cGray);
                                break;
                            case 7:
                                ChangeBackColor(cGray, cGray, cGreen, cGray, cGray, cGray);
                                break;
                            case 8:
                                ChangeBackColor(cGray, cGray, cGreen, cGray, cGray, cGray);
                                break;
                            case 9:
                                ChangeBackColor(cGreen, cGray, cGray, cGray, cGray, cGray);
                                break;
                            case 10:
                                ChangeBackColor(cGray, cGray, cGreen, cGray, cGray, cGray);
                                break;
                            case 11:
                                ChangeBackColor(cGreen, cGray, cGray, cGray, cGray, cGray);
                                break;

                        }

                        lblAgeQ.Visible = false;
                        lblAge.Visible = false;
                        lblTakingStomachMedQ.Visible = false;
                        lblTakingStomachMed.Visible = false;
                        lblChestPainQ.Visible = false;
                        lblChestPain.Visible = false;
                        lblBurningChestQ.Visible = false;
                        lblBurningChest.Visible = false;
                        break;
                    case 3:
                        Image1.ImageUrl = casesArr[MoneQuestionLearningPhase].imagePth3;
                        // Image1.Height = Unit.Percentage(97);
                        //Image1.Width = Unit.Percentage(100);
                        lblClassification.Text = casesArr[MoneQuestionLearningPhase].classificationPth3;
                        switch (MoneQuestionLearningPhase)
                        {
                            case 1:
                                ChangeBackColor(cGreen, cGray, cGray, cGray, cGray, cGray);
                                break;
                            case 2:
                                ChangeBackColor(cGray, cGray, cGreen, cGray, cGreen, cGray);
                                break;
                            case 3:
                                ChangeBackColor(cGreen, cGreen, cGray, cGray, cGray, cGray);
                                break;
                            case 4:
                                ChangeBackColor(cGray, cGray, cGreen, cGray, cGreen, cGray);
                                break;
                            case 5:
                                ChangeBackColor(cGray, cGreen, cGreen, cGray, cGray, cGray);
                                break;
                            case 6:
                                ChangeBackColor(cGreen, cGreen, cGray, cGray, cGray, cGreen);
                                break;
                            case 7:
                                ChangeBackColor(cGray, cGray, cGreen, cGreen, cGray, cGray);
                                break;
                            case 8:
                                ChangeBackColor(cGray, cGreen, cGreen, cGray, cGreen, cGray);
                                break;
                            case 9:
                                ChangeBackColor(cGreen, cGreen, cGray, cGray, cGray, cGreen);
                                break;
                            case 10:
                                ChangeBackColor(cGray, cGray, cGreen, cGreen, cGreen, cGray);
                                break;
                            case 11:
                                ChangeBackColor(cGreen, cGreen, cGray, cGray, cGray, cGray);
                                break;

                        }
                        break;
                    case 4:
                        Image1.ImageUrl = casesArr[MoneQuestionLearningPhase].imagePth4;
                        Image1.Height = Unit.Percentage(90);
                        Image1.Width = Unit.Percentage(90);
                        lblClassification.Text = casesArr[MoneQuestionLearningPhase].classificationPth4;
                        switch (MoneQuestionLearningPhase)
                        {
                         
                            case 1:
                                ChangeBackColor(cGreen, cGray, cGray, cGray, cGray, cGray);
                                break;
                            case 2:
                                ChangeBackColor(cGray, cGray, cGray, cGray, cGray, cGray);
                                break;
                            case 3:
                                ChangeBackColor(cGreen, cGray, cGray, cGray, cGray, cGray);
                                break;
                            case 4:
                                ChangeBackColor(cGray, cGray, cGray, cGray, cGray, cGray);
                                break;
                            case 5:
                                ChangeBackColor(cGray, cGray, cGray, cGray, cGray, cGray);
                                break;
                            case 6:
                                ChangeBackColor(cGreen, cGray, cGray, cGray, cGray, cGray);
                                break;
                            case 7:
                                ChangeBackColor(cGray, cGray, cGray, cGray, cGray, cGray);
                                break;
                            case 8:
                                ChangeBackColor(cGray, cGray, cGray, cGray, cGray, cGray);
                                break;
                            case 9:
                                ChangeBackColor(cGreen, cGray, cGray, cGray, cGray, cGray);
                                break;
                            case 10:
                                ChangeBackColor(cGray, cGray, cGray, cGray, cGray, cGray);
                                break;
                            case 11:
                                ChangeBackColor(cGreen, cGray, cGray, cGray, cGray, cGray);
                                break;

                        }
                        lblStonachPainQ.Visible = false;
                        lblStonachPain.Visible = false;
                        // lblGenderQ.Visible = false;
                        // lblGender.Visible = false;
                        lblAgeQ.Visible = false;
                        lblAge.Visible = false;
                        lblTakingStomachMedQ.Visible = false;
                        lblTakingStomachMed.Visible = false;
                        lblChestPainQ.Visible = false;
                        lblChestPain.Visible = false;
                        lblBurningChestQ.Visible = false;
                        lblBurningChest.Visible = false;
                        break;
                    case 5:
                         Image1.ImageUrl = casesArr[MoneQuestionLearningPhase].imagePth5;
                         Image1.Height = Unit.Percentage(90);
                         Image1.Width = Unit.Percentage(90);
                         lblClassification.Text = casesArr[MoneQuestionLearningPhase].classificationPth5;
                         switch (MoneQuestionLearningPhase)
                         {
                                    

                                     case 1:
                                         ChangeBackColor(cGray, cGray, cGray, cGray, cGray, cGray);
                                          break;
                                     case 2:
                                         ChangeBackColor(cGray, cGray, cGreen, cGray, cGray, cGray);
                                          break;
                                     case 3:
                                         ChangeBackColor(cGray, cGray, cGray, cGray, cGray, cGray);
                                          break;
                                     case 4:
                                         ChangeBackColor(cGray, cGray, cGreen, cGray, cGray, cGray);
                                          break;
                                     case 5:
                                         ChangeBackColor(cGray, cGray, cGreen, cGray, cGray, cGray);
                                          break;
                                     case 6:
                                         ChangeBackColor(cGray, cGray, cGray, cGray, cGray, cGray);
                                          break;
                                     case 7:
                                         ChangeBackColor(cGray, cGray, cGreen, cGray, cGray, cGray);
                                          break;
                                     case 8:
                                         ChangeBackColor(cGray, cGray, cGreen, cGray, cGray, cGray);
                                         break;
                                     case 9:
                                         ChangeBackColor(cGray, cGray, cGray, cGray, cGray, cGray);
                                         break;
                                     case 10:
                                         ChangeBackColor(cGray, cGray, cGreen, cGray, cGray, cGray);
                                         break;
                                     case 11:
                                         ChangeBackColor(cGray, cGray, cGray, cGray, cGray, cGray);
                                         break;

                     }
                     //lblStonachPainQ.Visible = false;
                     //lblStonachPain.Visible = false;
                     lblGenderQ.Visible = false;
                     lblGender.Visible = false;
                     lblAgeQ.Visible = false;
                     lblAge.Visible = false;
                     lblTakingStomachMedQ.Visible = false;
                     lblTakingStomachMed.Visible = false;
                     lblChestPainQ.Visible = false;
                     lblChestPain.Visible = false;
                     lblBurningChestQ.Visible = false;
                     lblBurningChest.Visible = false;
                     break;

                    default:
                        break;

                }
              /*  if (NumTree == 1)
                {
                   
                    Image1.ImageUrl = casesArr[MoneQuestionLearningPhase].imagePth1;
                    Image1.Height = Unit.Percentage(90);
                    Image1.Width = Unit.Percentage(90);
                    lblClassification.Text = casesArr[MoneQuestionLearningPhase].classificationPth1;
                    lblStonachPainQ.Visible = false;
                    lblStonachPain.Visible = false;
                    lblGenderQ.Visible = false;
                    lblGender.Visible = false;
                    lblAgeQ.Visible = false;
                    lblAge.Visible = false;
                    lblTakingStomachMedQ.Visible = false;
                    lblTakingStomachMed.Visible = false;
                    lblChestPainQ.Visible = false;
                    lblChestPain.Visible = false;
                    lblBurningChestQ.Visible = false;
                    lblBurningChest.Visible = false;
                }
                else if (NumTree == 2)
                {
                    Image1.ImageUrl = casesArr[MoneQuestionLearningPhase].imagePth2;
                   Image1.Height = Unit.Percentage(90);
                   Image1.Width = Unit.Percentage(90);
                    lblClassification.Text = casesArr[MoneQuestionLearningPhase].classificationPth2;
                    switch (MoneQuestionLearningPhase)
                    {
                        case 1:
                            ChangeBackColor(cGreen, cGray, cGray, cGray, cGray, cGray);
                            break;
                        case 2:
                            ChangeBackColor(cGray, cGray, cGreen, cGray, cGray, cGray);
                            break;
                        case 3:
                            ChangeBackColor(cGreen, cGray, cGray, cGray, cGray, cGray);
                            break;
                        case 4:
                            ChangeBackColor(cGray, cGray, cGreen, cGray, cGray, cGray);
                            break;
                        case 5:
                            ChangeBackColor(cGray, cGray, cGreen, cGray, cGray, cGray);
                            break;
                        case 6:
                            ChangeBackColor(cGreen, cGray, cGray, cGray, cGray, cGray);
                            break;
                        case 7:
                            ChangeBackColor(cGray, cGray, cGreen, cGray, cGray, cGray);
                            break;
                        case 8:
                            ChangeBackColor(cGray, cGray, cGreen, cGray, cGray, cGray);
                            break;
                        case 9:
                            ChangeBackColor(cGreen, cGray, cGray, cGray, cGray, cGray);
                            break;
                        case 10:
                            ChangeBackColor(cGray, cGray, cGreen, cGray, cGray, cGray);
                            break;
                        case 11:
                            ChangeBackColor(cGreen, cGray, cGray, cGray, cGray, cGray);
                            break;

                    }
                    
                    lblAgeQ.Visible = false;
                    lblAge.Visible = false;
                    lblTakingStomachMedQ.Visible = false;
                    lblTakingStomachMed.Visible = false;
                    lblChestPainQ.Visible = false;
                    lblChestPain.Visible = false;
                    lblBurningChestQ.Visible = false;
                    lblBurningChest.Visible = false;
                }
                else // case 3
                {
                    Image1.ImageUrl = casesArr[MoneQuestionLearningPhase].imagePth3;
                   // Image1.Height = Unit.Percentage(97);
                    //Image1.Width = Unit.Percentage(100);
                    lblClassification.Text = casesArr[MoneQuestionLearningPhase].classificationPth3;
                    switch (MoneQuestionLearningPhase)
                    {
                        case 1:
                            ChangeBackColor(cGreen, cGray, cGray, cGray, cGray, cGray);
                            break;
                        case 2: ChangeBackColor(cGray, cGray, cGreen, cGray, cGreen, cGray);
                            break;
                        case 3:
                            ChangeBackColor(cGreen, cGreen, cGray, cGray, cGray, cGray);
                            break;
                        case 4:
                            ChangeBackColor(cGray, cGray, cGreen, cGray, cGreen, cGray);
                            break;
                        case 5:
                            ChangeBackColor(cGray, cGreen, cGreen, cGray, cGray, cGray);
                            break;
                        case 6:
                            ChangeBackColor(cGreen, cGreen, cGray, cGray, cGray, cGreen);
                            break;
                        case 7:
                            ChangeBackColor(cGray, cGray, cGreen, cGreen, cGray, cGray);
                            break;
                        case 8:
                            ChangeBackColor(cGray, cGreen, cGreen, cGray, cGreen, cGray);
                            break;
                        case 9:
                            ChangeBackColor(cGreen, cGreen, cGray, cGray, cGray, cGreen);
                            break;
                        case 10:
                            ChangeBackColor(cGray, cGray, cGreen, cGreen, cGreen, cGray);
                            break;
                        case 11:
                            ChangeBackColor(cGreen, cGreen, cGray, cGray, cGray, cGray);
                            break;
                     
                    }
                }
              */
                lblGender.Text = casesArr[MoneQuestionLearningPhase].gender;
                lblAge.Text = casesArr[MoneQuestionLearningPhase].age;
                lblYearsSinceAcidTasteStart.Text = casesArr[MoneQuestionLearningPhase].yearsSinceAcidTasteStart;
                lblStonachPain.Text = casesArr[MoneQuestionLearningPhase].stomachPain;
                lblTakingStomachMed.Text = casesArr[MoneQuestionLearningPhase].takingStomachMed;
                lblChestPain.Text = casesArr[MoneQuestionLearningPhase].chestPain;
                lblBurningChest.Text = casesArr[MoneQuestionLearningPhase].burningChestLevel;
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
