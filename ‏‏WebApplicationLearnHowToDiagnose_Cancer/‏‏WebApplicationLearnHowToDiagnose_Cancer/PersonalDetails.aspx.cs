using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class PersonalDetails : System.Web.UI.Page
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
            }
                LblErrorDetails.Visible = false;
        }

        protected void Btn1_Click(object sender, EventArgs e)
        {
            if (DropDownListEducation.SelectedIndex == 0 ||
                DropDownListGender.SelectedIndex == 0 ||
                TxtAge.Text == " " ||
                 RdbGoodMemory.SelectedIndex == -1 ||
                 RdbLearnQuickly.SelectedIndex == -1 ||
                 RdbGoodVisualMemory.SelectedIndex == -1 ||
                 RdbMedicalKnowledge.SelectedIndex == -1 
                 )
            {
                LblErrorDetails.Visible = true;
            }
            else
            {
                // to do: add to database personal details
                string connectionString = SqlConnectionHandler.GetConnection(); //ConfigurationManager.ConnectionStrings["ExperimentDBProd"].ToString();
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {

                    String workerId, age, gender, education, MedicalKnowledge;
                    workerId = HttpContext.Current.Session["UserId"].ToString();
                    age = TxtAge.Text.ToString();
                    gender = DropDownListGender.Text.ToString();
                    education = DropDownListEducation.Text.ToString();
                    MedicalKnowledge = RdbMedicalKnowledge.SelectedValue;
                    sqlConnection.Open();
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.Connection = sqlConnection;
                    cmd1.Parameters.AddWithValue("@param1", workerId);
                    // SqlCommand cmd2 = new SqlCommand("select count(*) from Users", sqlConnection);
                    // int count = (int)cmd2.ExecuteScalar();
                    // UsersMone = count % 3;
                    // UsersMone++;
                    cmd1.Parameters.AddWithValue("@param2", HttpContext.Current.Session["NumTree"]);
                    cmd1.Parameters.AddWithValue("@param3", HttpContext.Current.Session["HitId"]);
                    cmd1.Parameters.AddWithValue("@param4", HttpContext.Current.Session["AssignmentId"]);
                    cmd1.Parameters.AddWithValue("@param5", gender);
                    cmd1.Parameters.AddWithValue("@param6", age);
                    cmd1.Parameters.AddWithValue("@param7", education);
                    cmd1.Parameters.AddWithValue("@p8", RdbGoodMemory.SelectedIndex);
                    cmd1.Parameters.AddWithValue("@p9", RdbLearnQuickly.SelectedIndex);
                    cmd1.Parameters.AddWithValue("@p10", RdbGoodVisualMemory.SelectedIndex);
                    cmd1.Parameters.AddWithValue("@p11", MedicalKnowledge);
                    // System.Diagnostics.Debug.WriteLine("@@count@@@@@@@" + count);
                    cmd1.CommandText = "INSERT INTO Users(UserId, NumTree,HitId,AssignmentId,Gender,Age,Education,GoodMemory,LearnQuickly,GoodVisualMemory,MedicalKnowledge) VALUES(@param1,@param2,@param3,@param4,@param5,@param6,@param7,@p8,@p9,@p10,@p11)";
                    System.Diagnostics.Debug.WriteLine("@@yesss@@@@@@@");
                    cmd1.ExecuteNonQuery();
                    sqlConnection.Close();
                }

                Response.Redirect("~/ExperimentalProcess.aspx");
            }
        }

        protected void DropDownListEducation_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblErrorDetails.Visible = false;
        }

        protected void DropDownListGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblErrorDetails.Visible = false;
        }

        protected void TxtAge_TextChanged(object sender, EventArgs e)
        {
            LblErrorDetails.Visible = false;
        }

       
    }
}