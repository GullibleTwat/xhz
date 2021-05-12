using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2.xhz
{
    public partial class login1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Maticsoft.BLL.Admin bll = new Maticsoft.BLL.Admin();

            Maticsoft.Model.Admin modol = bll.GetModel(UsernameText.Text.ToLower());


            //////或者
            if (bll.GetRecordCount("ID =" + "'" + UsernameText.Text + "' and Passwd=" + "'" + PasswordText.Text + "'") > 0)
            {
                //登陆成功
                Session.Clear();
                Session["Admin"] = UsernameText.Text;
                Maticsoft.Common.JSpript.RedirectParent("login.aspx");
            }
            else
            {
                //登陆失败
                Response.Write("<script>alert('登陆失败')</script>");
            }
        }
    }
}