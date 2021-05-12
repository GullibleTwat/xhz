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
        public int group = 6;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["group"]!=null)
            {
                group = Convert.ToInt32( Request.QueryString["group"]);
            }

            //Maticsoft.BLL.Works worksbll = new Maticsoft.BLL.Works();
            //Repeater1.DataSource = worksbll.GetList("GroupID='" + group + "'");
            //Repeater1.DataBind();
        }
    }
}