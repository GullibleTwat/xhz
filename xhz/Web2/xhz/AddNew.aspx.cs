using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


public partial class Admin_AddNews : System.Web.UI.Page
{
    //DbHelper dbh = new DbHelper();
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!IsPostBack)
        //{
        //    SqlCommand cmd = dbh.GetSqlStringCommond("select ItemID,ItemStr from Items where ItemTypeID='News'");
        //    DropDownList1.DataSource = dbh.ExecuteReader(cmd);
        //    DropDownList1.DataTextField = "ItemStr";
        //    DropDownList1.DataValueField = "ItemID";
        //    DropDownList1.DataBind();
        //}
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
    //     SqlCommand cmda = dbh.GetStoredProcCommond("insertNews");
    //     SqlParameter paTitle = new SqlParameter("@Title", TitleText.Text);
    //     SqlParameter paTime = new SqlParameter("@Time", DateTime.Now);
    //     SqlParameter paItems = new SqlParameter("@Items", DropDownList1.SelectedItem.Value);
    //     SqlParameter paContents = new SqlParameter("@Contents", elm1.InnerText);
    //     SqlParameter paIsOpen = new SqlParameter("@IsOpen", CheckOpen.Checked);
    //     dbh.AddParameters(cmda, paTitle, paTime, paItems, paContents, paIsOpen);

    //     if (dbh.ExecuteNonQuery(cmda) >= 1)
    //     {
    //         Response.Write("<script>alert('添加成功！'); </script>");
    //     }
    //     else
    //     {
    //         Response.Write("<script>alert('添加失败！'); </script>");
    //     }
    }
}