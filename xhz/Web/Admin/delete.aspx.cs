using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maticsoft.Web.Admin
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				Maticsoft.BLL.Admin bll=new Maticsoft.BLL.Admin();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string ID= Request.Params["id"];
					bll.Delete(ID);
					Response.Redirect("list.aspx");
				}
			}

        }
    }
}