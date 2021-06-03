using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2.xhz
{
    public partial class header : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Admin thisAdmin = (Admin)Session["Admin"];
            //if (thisAdmin != null)
            //{
            //    UserLabel.Text = thisAdmin.Name;
            //    PasswordChange.HRef = "~/Admin/AdminManager/ChangePassword.aspx?AdminId=" + thisAdmin.Id.ToString();
            //}
            //else
            //{
            //    JSpript.RedirectParent("login.aspx");
            //}
        }
        protected void LogoutButton_Click(object sender, EventArgs e)
        {
            //Session.Clear();
            //JSpript.RedirectParent("login.aspx");
        }
    }
}