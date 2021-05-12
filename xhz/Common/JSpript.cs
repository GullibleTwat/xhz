using System;
using System.Collections.Generic;
using System.Web;
namespace Maticsoft.Common
{
    /// <summary>
    ///JSpript 的摘要说明
    ///JS的服务器调用
    ///writen by 朱培源 2011.9.3
    /// </summary>
    public static class JSpript
    {
        /// <summary>
        /// 弹出消息
        /// </summary>
        /// <param name="message">消息内容</param>
        public static void Alert(string message)
        {
            string js = "<Script language='JavaScript'>alert('" + message + "');</Script>";
            HttpContext.Current.Response.Write(js);
        }

        /// <summary>
        /// 弹出消息并进行页面跳转
        /// </summary>
        /// <param name="message">消息内容</param>
        /// <param name="url">新页面的地址</param>
        public static void AlertAndRedirect(string message, string url)
        {
            string js = "<script language=javascript>alert('" + message + "');window.location.replace('" + url + "')</script>";
            HttpContext.Current.Response.Write(js);
        }

        /// <summary>
        /// 将框架的父页跳转到指定url,改用sever路径
        /// </summary>
        /// <param name="url">新页面的地址</param>
        public static void RedirectParent(string url)
        {
            //string urls = "www.hacf.org.cn/Admin/" + url;
            string js = "<script> window.parent.location.replace='" + url + "'</script>";
            HttpContext.Current.Response.Write(js);
        }
    }
}