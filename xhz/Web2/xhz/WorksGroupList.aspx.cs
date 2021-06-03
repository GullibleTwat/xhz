using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2.xhz
{
    public partial class WorksGroupList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Maticsoft.BLL.WorksGroup workGroupbll = new Maticsoft.BLL.WorksGroup();
            GridView1.DataSource = workGroupbll.GetAllList().Tables[0].DefaultView;
            GridView1.DataBind();
        }
    }
}