using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    // public static class UsersAmount
    // {
    // public static int UsersMone = 0;
    //}

    
    public partial class Login : System.Web.UI.Page
    {
        public string UserIdentity;
        public int UsersMone;
        //public int NumTree;
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

                if (IsMobileDevice())
            {
                Response.Redirect("~/IlegalBrowser.aspx");
            }

            Lbl_error.Visible = false;
            //if (!IsPostBack)
            //{

            //  }
            /* string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=ExperimentDB;Integrated Security=True";
             using (SqlConnection sqlConnection = new SqlConnection(connectionString))
             {
                 sqlConnection.Open();

                 SqlCommand cmd = new SqlCommand();
                 cmd.Connection = sqlConnection;

                 cmd.CommandText = "INSERT INTO Users(Id, NumTree)   VALUES(@param1,@param2)";

                 cmd.Parameters.AddWithValue("@param1", "343451654656");
                 cmd.Parameters.AddWithValue("@param2", 2);

                 cmd.ExecuteNonQuery();

                 sqlConnection.Close();
             }
 */
        }
        protected void Txt1change(object sender, EventArgs e)
        {
            Lbl_error.Visible = false;

        }

        protected void BtnNext_Click(object sender, EventArgs e)
        {
           String ClickTime = DateTime.Now.ToString("h:mm:ss tt");
            HttpContext.Current.Session["LoginClick"] = ClickTime;
            UserIdentity = TextBox1.Text;
            if (UserIdentity == "")
                Lbl_error.Visible = true;
            else
            {
                // string connectionString = @"Data Source=DESKTOP-0SB8TU9\SQLEXPRESS01;Initial Catalog=ExperimentDB;Integrated Security=True";
                //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=ExperimentDB;Integrated Security=True";
                string connectionString = SqlConnectionHandler.GetConnection(); //ConfigurationManager.ConnectionStrings["ExperimentDBProd"].ToString();
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {

                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.Parameters.AddWithValue("@param1", UserIdentity);
                    System.Diagnostics.Debug.WriteLine("@@@1111@@@@@@");
                    cmd.CommandText = "SELECT UserId FROM  Users WHERE UserId = @param1";
                    SqlDataReader myReader = null;
                    myReader = cmd.ExecuteReader();
                    // Lbl_error.Visible = true;
                    if (myReader.Read())
                    {
                        //System.Diagnostics.Debug.WriteLine(myReader.GetString(0));
                        //System.Diagnostics.Debug.WriteLine("@@nooooo@@@@@@@");

                        //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Inserted Successfully')", true);
                        //lable          
                        Lbl_error.Visible = true;
                        sqlConnection.Close();
                    }
                    else
                    {
                        myReader.Close();
                        SqlCommand cmd1 = new SqlCommand();
                        cmd1.Connection = sqlConnection;
                        cmd1.Parameters.AddWithValue("@param1", UserIdentity);
                        SqlCommand cmd2 = new SqlCommand("select count(*) from Users", sqlConnection);
                        int count = (int)cmd2.ExecuteScalar();
                        UsersMone = count % 3;
                        UsersMone++;
                        cmd1.Parameters.AddWithValue("@param2", UsersMone);
                        System.Diagnostics.Debug.WriteLine("@@count@@@@@@@" + count);
                        cmd1.CommandText = "INSERT INTO Users(UserId, NumTree) VALUES(@param1,@param2)";
                        System.Diagnostics.Debug.WriteLine("@@yesss@@@@@@@");
                        cmd1.ExecuteNonQuery();
                        sqlConnection.Close();
                        HttpContext.Current.Session["UserId"] = UserIdentity;
                        HttpContext.Current.Session["NumTree"] = UsersMone.ToString();
                       // HttpContext.Current.Session["NumTree"] = 2;
                        Response.Redirect("~/FirstPage.aspx"); //?tz=UserIdentity");
                    }


                    //  System.Diagnostics.Debug.WriteLine("@@222@@@@@@@");


                }
            }








            //NumTree = (UsersAmount.UsersMone % 3) + 1;
            //UsersAmount.UsersMone++;

            // UserIdentity = TextBox1.Text;
            //Application["UserId"] = UserIdentity;
            //Application["NumTree"] = NumTree;

        }

        public bool IsMobileDevice()
        {
            string[] mobileDevices = new string[] {"iphone","ppc",
                                                   "windows ce","blackberry",
                                                   "opera mini","mobile","palm",
                                                   "portable","opera mobi" };

            string userAgent = Request.UserAgent.ToString().ToLower();
            return mobileDevices.Any(x => userAgent.Contains(x));
        }
    }
}