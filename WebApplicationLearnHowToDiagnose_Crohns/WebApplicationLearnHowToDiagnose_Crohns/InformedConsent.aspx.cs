using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class InformedConsent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SetPageNoCache();
            }
        }
        public void SetPageNoCache()
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
            Response.Cache.SetAllowResponseInBrowserHistory(false);
            Response.Cache.SetNoStore();
        }
        protected void BtnNotAgree_Click(object sender, EventArgs e)
        {
           // Response.Cookies["ModeE"].Value = "NotAccept";
           // Response.Cookies["ModeE"].Expires = DateTime.Now.AddDays(1);

            HttpContext.Current.Session["ModeE"] = "NotAccept";
            Response.Redirect("~/ExitForm.aspx");
            
        }

        protected void BtnAgree_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Session["ModeE"] = "Accept";
            String ClickTime = DateTime.Now.ToString("h:mm:ss tt");
            HttpContext.Current.Session["InformedConsentPageClick"] = ClickTime;
            // Response.Redirect("~/DiagramExplanation.aspx");
           
            string connectionString = SqlConnectionHandler.GetConnection(); //ConfigurationManager.ConnectionStrings["ExperimentDBProd"].ToString();
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {

                ////to debug
                //String workerId = Request.QueryString["workerId"].ToString();
                String workerId = Session["UserId"].ToString();
               // String workerId = "77676667";
               // String ClickTime2 = DateTime.Now.ToString("h:mm:ss tt");
               // HttpContext.Current.Session["LoginClick"] = ClickTime2;
               // HttpContext.Current.Session["NumTree"] = 2;
               // HttpContext.Current.Session["UserId"]= "776767";
                ////to debug
                ///

                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;
                cmd.Parameters.AddWithValue("@param1", workerId);
                System.Diagnostics.Debug.WriteLine("@@@1111@@@@@@");
                cmd.CommandText = "SELECT UserId FROM  Users WHERE UserId = @param1";
                SqlDataReader myReader = null;
                myReader = cmd.ExecuteReader();
                // Lbl_error.Visible = true;
                if (myReader.Read())
                {
                    //TO DO   
                    LblError.Visible = true;
                    sqlConnection.Close();
                }
                else
                {
                    LblError.Visible = false;
                    myReader.Close();
                    Response.Redirect("~/PersonalDetails.aspx");
                    //   HttpContext.Current.Session["NumTree"] = UsersMone.ToString();
                    // HttpContext.Current.Session["NumTree"] = 2;

                }


                //  System.Diagnostics.Debug.WriteLine("@@222@@@@@@@");


            }
           
        }
    }
}