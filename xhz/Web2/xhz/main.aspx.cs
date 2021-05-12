using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/// <summary>
/// Written by 朱培源 2011.9.4
/// </summary>
public partial class Admin_main : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
            Bind();
    }

    private void Bind()
    {
        //Admin thisAdmin = (Admin)Session["Admin"];
        //if (thisAdmin != null)
        //{
        //    UsernameLabel1.Text = thisAdmin.Name;
        //    UsernameLabel2.Text = thisAdmin.Name;

        //    if (thisAdmin.Type == 0)
        //    {
        //        UserTypeLabel.Text = "超级管理员";
        //    }
        //    else
        //    {
        //        UserTypeLabel.Text = "普通管理员";
        //    }

        //    TimeLabel.Text = DateTime.Now.ToString();
        //}
        //else
        //{
        //    Response.Redirect("login.aspx");
        //    //JSpript.RedirectParent("login.aspx");
        //}
    }
}