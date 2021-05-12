using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace Maticsoft.Common
{
    //此工具适合web应用程序，上传目录为web根目录
    public class FileUp
    {
        //
        //

        // 摘要:
        //     根据当前日期生成路径
        //     规则：eg：day_140425/
        // 参数:
        //      指定相对于web根目录的路径的上传目录
        //
        // 返回结果:
        //     返回相对于web根目录到文件名之间的路径字符串
        //     
        public static string GetUploadPath(string filepath)
        {
            filepath += "/day_" + DateTime.Now.ToString("yyMMdd") + "/";
            return filepath;
        }
        //获取上传文件名
        public static string GetRandomName()
        {

            Random random = new Random(DateTime.Now.Millisecond);
            string filename = DateTime.Now.ToString("yyyyMMddhhmmss") + random.Next(10000);
            return filename;
        }

        public static bool IsImg(string name)
        {
            string fileExtension =
                    System.IO.Path.GetExtension(name).ToLower();
            String[] allowedExtensions = { ".jpg", ".gif", ".png", "jpeg", ".bmp" };
            for (int i = 0; i < allowedExtensions.Length; i++)
            {
                if (fileExtension == allowedExtensions[i])
                {
                    return true;
                }
            }
            return false;
        }
        public static bool Delfile(string filename)
        {
            return true;
        }
        public static string uploadfile(HttpPostedFile file, string filepath, string filename)
        {
            try
            {
                string RelPath = HttpContext.Current.Server.MapPath("~/") + filepath;
                if (!Directory.Exists(RelPath))
                    Directory.CreateDirectory(RelPath);
                string VPath = filepath + filename  + System.IO.Path.GetExtension(file.FileName).ToLower();
                file.SaveAs(HttpContext.Current.Server.MapPath("~/") + VPath);
                return VPath;
            }
            catch (IOException e)
            {
                throw e;
            }
        }
    }
}
