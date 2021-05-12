using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Reflection;
using System.Collections;

/// <summary>
/// Summary description for Fileop
/// 搜集编写者 tonny
/// QQ:276433352
/// </summary>
public class MyTheme 
{
	public MyTheme()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    public static string ThesisPath()
    {
        string path;
        path = "~/Update/ThesisFiles/" + DateTime.Now.ToShortDateString().Replace('-', '/');
        MyFileOp.Creat_Dir(path);
        return path;
    }
    public static string ActivePath()
    {
        string path;
        path = "~/Upload/Active/" + DateTime.Now.ToShortDateString().Replace('-', '/');
        MyFileOp.Creat_Dir(path);
        return path;
    }        
    public static String GetSMPDateDayOfWeekTime(DateTime datetime)
    {
        string _ret = string.Empty;
        //s_ret = datetime.Date.ToShortDateString()+"&nbsp;";
        switch (datetime.DayOfWeek)
        {
            case DayOfWeek.Monday:
                _ret += "  周一 ";
                break;
            case DayOfWeek.Tuesday:
                _ret += "  周二 ";
                break;
            case DayOfWeek.Wednesday:
                _ret += "  周三 ";
                break;
            case DayOfWeek.Thursday:
                _ret += "  周四 ";
                break;
            case DayOfWeek.Friday:
                _ret += "  周五 ";
                break;
            case DayOfWeek.Saturday:
                _ret += "  周六 ";
                break;
            case DayOfWeek.Sunday:
                _ret += "  周日 ";
                break;
        }
        //_ret += datetime.ToShortTimeString();
        return _ret;
    }

   

    public static string SafeRequest(string ParaName, int ParaType)
    {
        string Paravalue = "";
        Paravalue = ParaName;
        if (ParaType == 1)
        {
            if (!(IsNumeric(Paravalue)))
            {
                Paravalue = "0";
            }
        }
        else
        {
            Paravalue = Paravalue.Replace("'", "’");
        }
        return (Paravalue);
    }

    private static bool IsNumeric(string strData)
    {
        float fData;
        bool bValid = true;
        if (strData.Length > 12)
        {
            bValid = false;
        }
        else
        {
            try
            {
                fData = float.Parse(strData);
            }
            catch (FormatException)
            {
                bValid = false;
            }
        }
        return bValid;
    }

    public static string DomainName = ConfigurationManager.AppSettings["DomainName"];
    public static string ServerUrl()
    {
        return DomainName;
    }  
}
