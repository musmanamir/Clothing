using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Clothing_
{
    public class Connection
    {
        public static SqlConnection sc;
        public static string dbCon = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        public static SqlConnection get()
        {
            if (sc == null)
            {
                sc = new SqlConnection();
                sc.ConnectionString = dbCon;
                sc.Open();
            }
            return sc;
        }
    }
}