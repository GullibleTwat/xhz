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
namespace Maticsoft.Web.Admin
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string ID= Request.Params["id"];
					ShowInfo(ID);
				}
			}
		}
			
	private void ShowInfo(string ID)
	{
		Maticsoft.BLL.Admin bll=new Maticsoft.BLL.Admin();
		Maticsoft.Model.Admin model=bll.GetModel(ID);
		this.lblID.Text=model.ID;
		this.txtPasswd.Text=model.Passwd;
		this.txtPower.Text=model.Power.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtPasswd.Text.Trim().Length==0)
			{
				strErr+="标题不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtPower.Text))
			{
				strErr+="权限格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string ID=this.lblID.Text;
			string Passwd=this.txtPasswd.Text;
			int Power=int.Parse(this.txtPower.Text);


			Maticsoft.Model.Admin model=new Maticsoft.Model.Admin();
			model.ID=ID;
			model.Passwd=Passwd;
			model.Power=Power;

			Maticsoft.BLL.Admin bll=new Maticsoft.BLL.Admin();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
