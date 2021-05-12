﻿using System;
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
namespace Maticsoft.Web.ArtsMatter
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
		Maticsoft.BLL.ArtsMatter bll=new Maticsoft.BLL.ArtsMatter();
		Maticsoft.Model.ArtsMatter model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtTitle.Text=model.Title;
		this.txtContent.Text=model.Content;
		this.txtTime.Text=model.Time.ToString();
		this.txtAttachment.Text=model.Attachment;
		this.txtGroupID.Text=model.GroupID.ToString();
		this.chkIsOpen.Checked=model.IsOpen;
		this.txtClick.Text=model.Click.ToString();
		this.lblNo.Text=model.No.ToString();
		this.txtMark.Text=model.Mark.ToString();
		this.txtS1.Text=model.S1;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
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
			if(this.txtAttachment.Text.Trim().Length==0)
			{
				strErr+="附件不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtGroupID.Text))
			{
				strErr+="分组格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtClick.Text))
			{
				strErr+="点击数格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtMark.Text))
			{
				strErr+="Mark格式错误！\\n";	
			}
			if(this.txtS1.Text.Trim().Length==0)
			{
				strErr+="S1不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			string Title=this.txtTitle.Text;
			string Content=this.txtContent.Text;
			DateTime Time=DateTime.Parse(this.txtTime.Text);
			string Attachment=this.txtAttachment.Text;
			int GroupID=int.Parse(this.txtGroupID.Text);
			bool IsOpen=this.chkIsOpen.Checked;
			int Click=int.Parse(this.txtClick.Text);
			int No=int.Parse(this.lblNo.Text);
			int Mark=int.Parse(this.txtMark.Text);
			string S1=this.txtS1.Text;


			Maticsoft.Model.ArtsMatter model=new Maticsoft.Model.ArtsMatter();
			model.ID=ID;
			model.Title=Title;
			model.Content=Content;
			model.Time=Time;
			model.Attachment=Attachment;
			model.GroupID=GroupID;
			model.IsOpen=IsOpen;
			model.Click=Click;
			model.No=No;
			model.Mark=Mark;
			model.S1=S1;

			Maticsoft.BLL.ArtsMatter bll=new Maticsoft.BLL.ArtsMatter();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
