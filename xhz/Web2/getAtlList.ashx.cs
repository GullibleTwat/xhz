using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace Web2
{
    /// <summary>
    /// getAtlList 的摘要说明 select * from @Art where Group=@GroupID
    /// <param name="Art">表</param>
    /// <param name="Group">分组</param>
    /// </summary>
    public class getAtlList : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            string Art = "";
            string Group = "";
            string html = "";
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Title,Attachment from ");
            if (context.Request.QueryString["Art"] == null)
            {
                context.Response.Write("Hello World");
                return;
            }
            Art = context.Request.QueryString["Art"].ToString();
            strSql.Append(Art);

            if (context.Request.QueryString["Group"] == null)
            {
                context.Response.Write("Hello World");
                return;
            }

            Group = context.Request.QueryString["Group"].ToString();
            strSql.Append(" where IsOpen=1 and GroupID=@GroupID ");
            SqlParameter[] parameters ={
                        new SqlParameter("@GroupID", SqlDbType.Int, 4)};
            parameters[0].Value = Group;
            SqlDataReader dr = Maticsoft.DBUtility.DbHelperSQL.ExecuteReader(strSql.ToString(), parameters);

            while (dr.Read())
            {
                string relurl = dr["Attachment"].ToString();
                string title = dr["Title"].ToString();
                string name = "mini_" + relurl.Substring(relurl.LastIndexOf("/") + 1);
                string url = relurl.Substring(0, relurl.LastIndexOf("/") + 1) + name;
                html += "<LI><div class='img-wrap'><a href='javascript:;'><img  height='75' width='100' alt='"
                    + title
                    + "' src='"
                    + url
                    + "' rel='"
                    + relurl
                    + "'/></a></div></LI>";
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