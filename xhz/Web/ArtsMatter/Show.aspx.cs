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
namespace Maticsoft.Web.ArtsMatter
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int ID=(Convert.ToInt32(strid));
					ShowInfo(ID);
				}
			}
		}
		
	private void ShowInfo(int ID)
	{
		Maticsoft.BLL.ArtsMatter bll=new Maticsoft.BLL.ArtsMatter();
		Maticsoft.Model.ArtsMatter model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblTitle.Text=model.Title;
		this.lblContent.Text=model.Content;
		this.lblTime.Text=model.Time.ToString();
		this.lblAttachment.Text=model.Attachment;
		this.lblGroupID.Text=model.GroupID.ToString();
		this.lblIsOpen.Text=model.IsOpen?"是":"否";
		this.lblClick.Text=model.Click.ToString();
		this.lblNo.Text=model.No.ToString();
		this.lblMark.Text=model.Mark.ToString();
		this.lblS1.Text=model.S1;

	}


    }
}
