using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Text;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace WebApplication3
{
    public partial class ExitForm : System.Web.UI.Page
    {
        //private static readonly HttpClient client = new HttpClient();

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
                // HttpContext.Current.Session["ModeE"] = "accept";
                // HttpContext.Current.Session["AssignmentId"] = "hkj87";
                /* Response.Write("Hello World...");
                 Response.Write(Request.Cookies["ModeE"]);

                 if (Request.Cookies["ModeE"] != null)
                 {
                     var value = Request.Cookies["ModeE"].Value;
                     Response.Write("value:  "+ value);

                     if (value=="NotAccept")
                     {
                         SubmitBtn.Enabled = false;
                         SubmitBtn.Visible = false;
                         LabelPlease.Visible = false;
                     }
                     else
                     {
                         SubmitBtn.Enabled = true;
                         SubmitBtn.Visible = true;
                         LabelPlease.Visible = true;
                     }
                 }
                */
                string url1 = WebConfigurationManager.AppSettings["submitUrl"].ToString() + "?assignmentId="+ HttpContext.Current.Session["AssignmentId"];
            //+ "?assignmentId=" + HttpContext.Current.Session["AssignmentId"].ToString();
            myAssignment.Value = url1;

            // LabelAssignment.Text = HttpContext.Current.Session["AssignmentId"].ToString();
            if (HttpContext.Current.Session["ModeE"].ToString() == "NotAccept")
            //if (HttpContext.Current.Session["ModeE"].ToString() == "Accept") //for debbug
            {
              //  btn_submit_input.enabled = false;
                btn_submit_input.Visible = false;
                LabelPlease.Visible = false;
            }
            else
            {
              //  btn_submit_input.Enabled = true;
                btn_submit_input.Visible = true;
                LabelPlease.Visible = true;
            }
        }
    }
}
        /*
        protected void SubmitBtn_Click(object sender, EventArgs e)
        {
            form1.Action = "https://workersandbox.mturk.com/mturk/externalSubmit?assignmentId=" + HttpContext.Current.Session["AssignmentId"].ToString();
           // document.getElementById('myAssignment').value = HttpContext.Current.Session["AssignmentId"];
            // f();
            //
            // c();
            //aAsync();
            //form_submit.Action= 
            SubmitBtn.Enabled = false;
            SubmitBtn.Visible = false;
            LabelPlease.Visible = false;
            //string strPost = "assignmentId=" + HttpContext.Current.Session["AssignmentId"];
            //string url = "https://workersandbox.mturk.com/mturk/externalSubmit";//ToDO: sand box - change to production 
            //HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);
            //objRequest.Method = "POST";
            //objRequest.ContentLength = strPost.Length;
            //objRequest.ContentType = "application/x-www-form-urlencoded";
            //StreamWriter myWriter = null;

            //try
            //{
            //    myWriter = new StreamWriter(objRequest.GetRequestStream());
            //    myWriter.Write(strPost);
            //}
            //catch (Exception )
            //{

            //}
            //finally
            //{
            //    myWriter.Close();
            //}
        }
        
        private async Task aAsync()
        {
            var url = WebConfigurationManager.AppSettings["submitUrl"];
            var values = new Dictionary<string, string>
            {
            {  "assignmentId=",HttpContext.Current.Session["AssignmentId"].ToString()}//,
          //   { "thing2", "world" }
            };
            url += "?assignmentId=" + HttpContext.Current.Session["AssignmentId"].ToString();
            var content = new FormUrlEncodedContent(values);

            var response = await client.PostAsync(url.ToString(), content);

            var responseString = await response.Content.ReadAsStringAsync();

        }



        private void c()
        {
            var url = WebConfigurationManager.AppSettings["submitUrl"];
           
            url += "?assignmentId=" + HttpContext.Current.Session["AssignmentId"].ToString();

            using (var client = new WebClient())
            {
   
             var response = client.UploadValues(url,new NameValueCollection());

             var responseString = Encoding.Default.GetString(response);
             }

        }
    private void f()
        {
          //  var url = WebConfigurationManager.AppSettings["submitUrl"];
          //
          //  var request = (HttpWebRequest)WebRequest.Create(url);
          //  //var request = (HttpWebRequest)WebRequest.Create("http://www.example.com/recepticle.aspx");
          //
          //  var postData = "assignmentId=" + Uri.EscapeDataString(HttpContext.Current.Session["AssignmentId"].ToString());
          //  //var postData = "thing1=" + Uri.EscapeDataString("hello");
          //  //postData += "&thing2=" + Uri.EscapeDataString("world");
          //  var data = Encoding.ASCII.GetBytes(postData);
          //
          //  request.Method = "POST";
          //  request.ContentType = "application/x-www-form-urlencoded";
          //  request.ContentLength = data.Length;
          //
          //  using (var stream = request.GetRequestStream())
          //  {
          //      stream.Write(data, 0, data.Length);
          //  }
          //
          //  var response = (HttpWebResponse)request.GetResponse();
          //
          //  var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
          //  Console.WriteLine(responseString);

            //////////////////
            var url = WebConfigurationManager.AppSettings["submitUrl"];
            
          
            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Method = "POST";
          
            httpRequest.ContentType = "application/x-www-form-urlencoded";
          
            var data = "assignmentId=" + HttpContext.Current.Session["AssignmentId"]; 
          
            using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
            {
                streamWriter.Write(data);
            }
          
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
          
            Console.WriteLine(httpResponse.StatusCode);
        }
    }
}*/