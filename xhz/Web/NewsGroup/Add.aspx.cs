using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace Maticsoft.Web.NewsGroup
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtTitle.Text.Trim().Length==0)
			{
				strErr+="组名不能为空！\\n";	
			}
			if(this.txtAtlas.Text.Trim().Length==0)
			{
				strErr+="Atlas不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtTime.Text))
			{
				strErr+="Time格式错误！\\n";	
			}
			if(this.txtInfo.Text.Trim().Length==0)
			{
				strErr+="Info不能为空！\\n";	
			}
			if(this.txtNo.Text.Trim().Length==0)
			{
				strErr+="No不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtMark.Text))
			{
				strErr+="Mark格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtClick.Text))
			{
				strErr+="Click格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string Title=this.txtTitle.Text;
			string Atlas=this.txtAtlas.Text;
			DateTime Time=DateTime.Parse(this.txtTime.Text);
			string Info=this.txtInfo.Text;
			string No=this.txtNo.Text;
			int Mark=int.Parse(this.txtMark.Text);
			int Click=int.Parse(this.txtClick.Text);

			Maticsoft.Model.NewsGroup model=new Maticsoft.Model.NewsGroup();
			model.Title=Title;
			model.Atlas=Atlas;
			model.Time=Time;
			model.Info=Info;
			model.No=No;
			model.Mark=Mark;
			model.Click=Click;

			Maticsoft.BLL.NewsGroup bll=new Maticsoft.BLL.NewsGroup();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
