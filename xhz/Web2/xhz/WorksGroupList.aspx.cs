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
            Bind();
        }
        private void  Bind(){

            Maticsoft.BLL.WorksGroup workGroupbll = new Maticsoft.BLL.WorksGroup();
            GridView1.DataSource = workGroupbll.GetAllList().Tables[0].DefaultView;
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Maticsoft.BLL.WorksGroup bll = new Maticsoft.BLL.WorksGroup();
            bll.Delete(int.Parse( GridView1.DataKeys[e.RowIndex].Value.ToString()));
            Bind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            Bind();
        }
    }
}