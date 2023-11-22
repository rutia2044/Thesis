using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace WebApplication3
{
    public class SqlConnectionHandler
    {

        public static string GetConnection()
        {
            return ConfigurationManager.ConnectionStrings["ExperimentDBConnection"].ToString();
        }
       
    }
}