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
namespace Maticsoft.Web.WorksGroup
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(ID);
				}
			}
		}
			
	private void ShowInfo(int ID)
	{
		Maticsoft.BLL.WorksGroup bll=new Maticsoft.BLL.WorksGroup();
		Maticsoft.Model.WorksGroup model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtTitle.Text=model.Title;
		this.txtAtlas.Text=model.Atlas;
		this.txtTime.Text=model.Time.ToString();
		this.txtInfo.Text=model.Info;
		this.lblNo.Text=model.No.ToString();
		this.txtMark.Text=model.Mark.ToString();
		this.txtClick.Text=model.Click.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
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
			int ID=int.Parse(this.lblID.Text);
			string Title=this.txtTitle.Text;
			string Atlas=this.txtAtlas.Text;
			DateTime Time=DateTime.Parse(this.txtTime.Text);
			string Info=this.txtInfo.Text;
			int No=int.Parse(this.lblNo.Text);
			int Mark=int.Parse(this.txtMark.Text);
			int Click=int.Parse(this.txtClick.Text);


			Maticsoft.Model.WorksGroup model=new Maticsoft.Model.WorksGroup();
			model.ID=ID;
			model.Title=Title;
			model.Atlas=Atlas;
			model.Time=Time;
			model.Info=Info;
			model.No=No;
			model.Mark=Mark;
			model.Click=Click;

			Maticsoft.BLL.WorksGroup bll=new Maticsoft.BLL.WorksGroup();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
