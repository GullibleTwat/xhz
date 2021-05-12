using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using Maticsoft.DBUtility;
using System.Text;
using System.Data.SqlClient;

namespace Web2
{
    /// <summary>
    /// getAtlas 的摘要说明 select ID,Title,Atlas,No from @Art where No=@No.xext/.pre
    /// <param name="Art">表</param>
    /// <param name="No">当前序号</param>
    /// </summary>
    public class getAtlas : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string Art = "";
            string No = "";
            string html = "";
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,Title,Atlas,No from ");

            if (context.Request.QueryString["Art"] == null)
            {
                context.Response.Write("Hello World");
                return;
            }
            Art = context.Request.QueryString["Art"].ToString();
            strSql.Append(Art);
            strSql.Append("Group");

            if (context.Request.QueryString["No"] == null)
            {
                context.Response.Write("Hello World");
                return;
            }

            No = context.Request.QueryString["No"].ToString();
            if (context.Request.QueryString["cmd"] == null)
            {
                context.Response.Write("Hello World");
                return;
            }

            string cmd = context.Request.QueryString["cmd"].ToString();
            switch (cmd)
            {
                case "next":
                     strSql.Append(" where No<@No ");
                    break;
                case "pre":
                    strSql.Append(" where No>@No ");
                    break;
                case "cur":
                    strSql.Append(" where No=@No");
                    break;
                default:
                    break;
            }
            SqlParameter[] parameters ={
                        new SqlParameter("@No", SqlDbType.Int, 4)};
            parameters[0].Value = No;
            SqlDataReader  dr = DbHelperSQL.ExecuteReader(strSql.ToString(), parameters);
            if (dr.Read())
            {
                string ID = dr["ID"].ToString();
                string title = dr["Title"].ToString();
                string Atl=dr["Atlas"].ToString();
                string nNo=dr["No"].ToString();
                html +="<DIV class='"
                    +cmd
                    +" picbig' Art='"
                    +Atl
                    +"' Group='"
                    +ID
                    +"' No='"
                    +nNo
                    +"'><div class='img-wrap'><A title='"
                    + title
                    + "' href='#"
                    +cmd
                    +"'><IMG style='HEIGHT: 70px; WIDTH: 71px' src='"
                    + Atl
                    + "'></A></div><A href='#"
                    +cmd
                    + "'>下一组&gt;</A></div>";
            }
            context.Response.Write(html);
            context.Response.Flush();
            context.Response.End();
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}