﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Main : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //if (Session["Admin"] == null)
            //{
            //    Maticsoft.Common.JSpript.RedirectParent("Login.aspx");
            //}
        }
    }
}
