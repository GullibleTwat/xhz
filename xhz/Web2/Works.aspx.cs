using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2
{
    public partial class Works : System.Web.UI.Page
    {
        public string  Art = "Works";
        public int No = 6;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["Art"]!=null)
            {
                Art =  Request.QueryString["Art"];
            }
            if (Request.QueryString["No"] != null)
            {
                No = Convert.ToInt32(Request.QueryString["No"]);
            }

        }
    }
}