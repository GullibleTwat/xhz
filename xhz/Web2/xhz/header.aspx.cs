using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/// <summary>
/// Written by 朱培源 2011.9.4
/// </summary>
public partial class Admin_header : System.Web.UI.Page
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