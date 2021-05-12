using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_menu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!IsPostBack)
        //{
        //    Admin admin = (Admin)Session["Admin"];
        //    if (admin.Type != 0)
        //    {
        //        Panel1.Visible = false;
        //    }
        //    bind();

        //}
    }
    public void bind()
    {

        //DBHelper myDB = new DBHelper();
        //string sqlstring = "select distinct ruleYear from rules";

        

        //repeater.DataSource = myDB.Select(sqlstring);
        //repeater.DataBind();


        //rulesDispose myRules = new rulesDispose();
        
        //PagedDataSource pgds = new PagedDataSource();

        //pgds.DataSource = myRules.GetYear();
        //repeater.DataSource = pgds;
        //repeater.DataBind();

    }
    public void lb_click(object sender, EventArgs e)
    {
        //rulesDispose myRule = new rulesDispose();
        //myRule.AddGroup();
        //bind();
    }
}