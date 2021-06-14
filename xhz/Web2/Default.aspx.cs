using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bind();
            }

        }
        protected void bind() {
            //艺人艺事
            Maticsoft.BLL.ArtsMatterGroup artsmattergroup = new Maticsoft.BLL.ArtsMatterGroup();
            Repeater1.DataSource =dtbindbig( artsmattergroup.GetList(10, "", "No desc").Tables[0]);
            Repeater1.DataBind();

            //作品
            Maticsoft.BLL.WorksGroup works = new Maticsoft.BLL.WorksGroup();
            //由原图路径转化成缩略图路径W
            Works.DataSource = dtbind(works.GetList(10, "", "No desc").Tables[0]);
            Works.DataBind();

            //新闻动态
            Maticsoft.BLL.NewsGroup newsbll = new Maticsoft.BLL.NewsGroup();
            RepeaterNews .DataSource = dtbind( newsbll.GetList(10, "", "No desc").Tables[0]);
            RepeaterNews.DataBind();
            //同行评价
            Maticsoft.BLL.EvaluateGroup Evabll = new Maticsoft.BLL.EvaluateGroup();
            RepeaterEva.DataSource = dtbind( Evabll.GetList(10, "", "No desc").Tables[0]);
            RepeaterEva.DataBind();
        }

        private DataTable dtbind(DataTable dt) {

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["Atlas"] = Maticsoft.Common.IMG.GetW(dt.Rows[i]["Atlas"].ToString());
            }
            return dt;
        }
        private DataTable dtbindbig(DataTable dt)
        {

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["Atlas"] = Maticsoft.Common.IMG.GetBig(dt.Rows[i]["Atlas"].ToString());
            }
            return dt;
        }
    }
}