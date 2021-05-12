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
namespace Maticsoft.Web.Message
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
		Maticsoft.BLL.Message bll=new Maticsoft.BLL.Message();
		Maticsoft.Model.Message model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtUserName.Text=model.UserName;
		this.txtTitle.Text=model.Title;
		this.txtContent.Text=model.Content;
		this.txtTime.Text=model.Time.ToString();
		this.txtEmail.Text=model.Email;
		this.txtMobile.Text=model.Mobile;
		this.txtPhone.Text=model.Phone;
		this.txtMark.Text=model.Mark.ToString();
		this.txtS1.Text=model.S1;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtUserName.Text.Trim().Length==0)
			{
				strErr+="称呼不能为空！\\n";	
			}
			if(this.txtTitle.Text.Trim().Length==0)
			{
				strErr+="标题不能为空！\\n";	
			}
			if(this.txtContent.Text.Trim().Length==0)
			{
				strErr+="内容不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtTime.Text))
			{
				strErr+="发布时间格式错误！\\n";	
			}
			if(this.txtEmail.Text.Trim().Length==0)
			{
				strErr+="电子邮箱不能为空！\\n";	
			}
			if(this.txtMobile.Text.Trim().Length==0)
			{
				strErr+="手机不能为空！\\n";	
			}
			if(this.txtPhone.Text.Trim().Length==0)
			{
				strErr+="电话不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtMark.Text))
			{
				strErr+="Mark格式错误！\\n";	
			}
			if(this.txtS1.Text.Trim().Length==0)
			{
				strErr+="备用不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			string UserName=this.txtUserName.Text;
			string Title=this.txtTitle.Text;
			string Content=this.txtContent.Text;
			DateTime Time=DateTime.Parse(this.txtTime.Text);
			string Email=this.txtEmail.Text;
			string Mobile=this.txtMobile.Text;
			string Phone=this.txtPhone.Text;
			int Mark=int.Parse(this.txtMark.Text);
			string S1=this.txtS1.Text;


			Maticsoft.Model.Message model=new Maticsoft.Model.Message();
			model.ID=ID;
			model.UserName=UserName;
			model.Title=Title;
			model.Content=Content;
			model.Time=Time;
			model.Email=Email;
			model.Mobile=Mobile;
			model.Phone=Phone;
			model.Mark=Mark;
			model.S1=S1;

			Maticsoft.BLL.Message bll=new Maticsoft.BLL.Message();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
