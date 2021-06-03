using System;
using System.Collections.Generic;
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
            Repeater1.DataSource = artsmattergroup.GetList(10, "", "No desc").Tables[0].DefaultView ;
            Repeater1.DataBind();

            //作品
            Maticsoft.BLL.WorksGroup works = new Maticsoft.BLL.WorksGroup();
            Works.DataSource = works.GetList(10, "", "No desc").Tables[0].DefaultView;
            Works.DataBind();

            //新闻动态
            Maticsoft.BLL.NewsGroup newsbll = new Maticsoft.BLL.NewsGroup();
            RepeaterNews .DataSource = newsbll.GetList(10, "", "No desc").Tables[0].DefaultView;
            RepeaterNews.DataBind();
            //同行评价
            Maticsoft.BLL.EvaluateGroup Evabll = new Maticsoft.BLL.EvaluateGroup();
            RepeaterEva.DataSource = Evabll.GetList(10, "", "No desc").Tables[0].DefaultView;
            RepeaterEva.DataBind();
        }
    }
}