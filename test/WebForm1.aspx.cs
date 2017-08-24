using Client.Method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Client.Entity;
using System.Data;

namespace test
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           All all = new All();

           //Dictionary<string, string> parames = new Dictionary<string, string>();
           //parames.Add("id", "1");
           //parames.Add("name", "wahaha");
           //string url = "http://localhost:3275/api/Hospital/GetHospital"; ;
           //Page.Response.Write(all.Get(url, parames));

           string url = "http://localhost:521/api/Hospital/AddHospital";

           var dt = new
           {
               ID = "1212",
               HospitalName = "121212"
           };

           Page.Response.Write(all.Post(url, dt)); 
        }
   
    }
}