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
    /// GetAtl :根据表，与分组序号获取图片展览HTML页面代码
    /// <param name="Art">表</param>
    /// <param name="No">当前序号</param>
    /// </summary>
    public class GetAtl : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            string html = "";
            if (context.Request.QueryString["Art"] == null)
            {
                context.Response.Write("Hello World");
                return;
            }



            //if (context.Request.QueryString["cmd"] == null)
            //{
            //    context.Response.Write("Hello World");
            //    return;
            //}
            string Art = context.Request.QueryString["Art"].ToString(); //表
            string No = context.Request.QueryString["No"].ToString();//分组排序序号
            //string cmd = context.Request.QueryString["cmd"].ToString();//命令
            //一.根据No 获取当前分组ID，title，info,将title，info嵌入指定网页位置
            SqlDataReader dr = GetAtlas(Art, No, "cur");
            if (dr.Read())
            {
                html += "<h1>"
                    + dr["Title"].ToString()
                    + "<br/><span>"
                    + dr["Time"].ToString()
                    + "&nbsp;&nbsp;&nbsp来源：&nbsp;&nbsp;&nbsp;点击：</span><span id='hits'>"
                    + dr["Click"].ToString()
                    + "</span></h1>";

            }
            else
            {
                context.Response.Write("Hello World");
                return;
            }
            html += "<div class='tool'><A name='pic'></A><a title='上一张' class='up' onclick=\"showpic('pre')\" href='javascript:;'><span>上一张</span></a><a title='下一张' class='next' onclick=\"showpic('next')\" href='javascript:;'><span>下一张</span></a><span class=\"stat\" id=\"picnum\">(1/1)</span><div class=\"Article-Tool\"></div></div>";

            //注：下面需要修改
            html += "<div class=\"big-pic\" style=\"height: 650px;\"><div id=\"big-pic\"><img style=\"height: 650px;\" onload=\"loadpic(1)\" src=\"#\"/></div><div class=\"photo_prev\"><a title=\"<上一页\" class=\"btn_pphoto\" id=\"photoPrev\" onfocus=\"this.blur()\"  onclick=\"showpic('pre');\" href=\"javascript:;\" target=\"_self\"></a></div><div class=\"photo_next\"><a title=\"下一页>\" class=\"btn_nphoto\" id=\"photoNext\" onfocus=\"this.blur()\"  onclick=\"showpic('next')\" href=\"javascript:;\" target=\"_self\"></a></div><a class=\"max\" onclick=\"showpic('big');\" href=\"javascript:;\">查看原图</a><DIV id=\"endSelect\"><DIV onclick=\"$('#endSelect').hide();\" id=\"endSelClose\"></DIV><DIV class=bg></DIV><DIV class=E_Cont><P>您已经浏览完所有图片</P><P><A onclick=\"showpic('next', 1);\" id=rePlayBut href=\"javascript:void(0)\"></A><A id=nextPicsBut href=\"http://qyx.zgsfj.net/html/2011/qyxpic1_0822/4.html\"></A></P></DIV></DIV></div>";


            //二.根据No 获取上一组ID，title，Atlas，info,No将title，Atlas，No嵌入指定网页位置
            SqlDataReader drPre = GetAtlas(Art, No, "pre");
            if (drPre.Read())
            {
                html += "<DIV class=list-pic><DIV class=\"pre picbig\" Art="
                  + Art
                  + " No="
                  + drPre["No"].ToString()
                  + " onclick=showGroup(this);"
                  + "><DIV class='img-wrap'><A href=\"#pre\"><IMG title="
                  + drPre["Title"].ToString()
                  + " style=\"HEIGHT: 75px; WIDTH: 100px\" src=\""
                  + drPre["Atlas"].ToString()
                  + "\"></A></DIV><A href=\"javascript:;\">&lt;上一组</A> </DIV><A onclick=\"showpic('pre')\" class=pre-bnt href=\"javascript:;\"  ><SPAN></SPAN></A><DIV class=cont style=\"POSITION: relative\">";
            }
            else
            {
                context.Response.Write("Hello World");
                return;
            }
            //三.根据当前分组ID（GroupID）获取本组数据列表，将本组数据嵌入网页
            SqlDataReader drList = GetAtlList(Art, dr["ID"].ToString());
            html += "<UL id=\"pictureurls\" class=\"cont picbig\" style=\"WIDTH: 1230px; POSITION: absolute; LEFT: 0px\">";
            while (drList.Read())
            {
                string relurl = drList["Attachment"].ToString();
                string title = drList["Title"].ToString();
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

            html += "</UL></DIV><A onclick=\"showpic('next')\" class=next-bnt href=\"javascript:;\"><SPAN></SPAN></A>";
            //四.根据No 获取下一组ID，title，Atlas，info,No将title，Atlas，No嵌入指定网页位置
            SqlDataReader drNext = GetAtlas(Art, No, "next");
            if (drNext.Read())
            {
                 html += "<DIV class=\"next picbig\" Art="
                       + Art
                       + " No="
                       + drNext["No"].ToString()
                       + " onclick=showGroup(this);"
                       + "><DIV class='img-wrap'><A href=\"#next\"><IMG title="
                       + drNext["Title"].ToString()
                       + " style=\"HEIGHT: 75px; WIDTH: 100px\" src=\""
                       + drNext["Atlas"].ToString()
                       + "\"></A></DIV><A href=\"#next\">&lt;下一组</A> </DIV></DIV>"
                       +"<div class='text' id='picinfo'>hello</div><div class='content'></div>";
            }
            context.Response.Write(html);
            context.Response.Flush();
            context.Response.End();

        }
        private SqlDataReader GetAtlas(string Art, string No, string cmd)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 ID,Title,Atlas,Time,No,Click from ");
            strSql.Append(Art);
            strSql.Append("Group");
            switch (cmd)
            {
                case "next":    //下一组
                    strSql.Append(" where No<@No ");
                    break;
                case "pre":     //上一组
                    strSql.Append(" where No>@No ");
                    break;
                case "cur":     //当前
                    strSql.Append(" where No=@No ");
                    break;
                default:
                    break;
            }
            SqlParameter[] parameters ={
                        new SqlParameter("@No", SqlDbType.Int, 4)};
            parameters[0].Value = No;
            return Maticsoft.DBUtility.DbHelperSQL.ExecuteReader(strSql.ToString(), parameters);

        }
        private SqlDataReader GetAtlList(string Art, string Group)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Title,Attachment from ");
            strSql.Append(Art);
            strSql.Append(" where IsOpen=1 and GroupID=@GroupID ");
            SqlParameter[] parameters ={
                        new SqlParameter("@GroupID", SqlDbType.Int, 4)};
            parameters[0].Value = Group;
            return Maticsoft.DBUtility.DbHelperSQL.ExecuteReader(strSql.ToString(), parameters);
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