using System;
using System.IO;
using System.Web;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections;

/// <summary>
/// Summary description for Fileop
/// 搜集编写者 tonny
/// QQ:276433352
/// </summary>
public static class MyFileOp
{

    //生成 (年,月,日,时,分,秒)+随机数的文件名
    private static string names()
    {
        Random rm = new Random(System.Environment.TickCount);
        return System.DateTime.Now.ToString("yyyyMMddhhmmss") + System.DateTime.Now.Millisecond + rm.Next(1000, 9999).ToString();
    }

    /// <summary>
    /// 得到1970年的时间戳
    /// </summary>
    /// <returns></returns>
    public static long Timestamp()
    {
        DateTime timeStamp = new DateTime(1970, 1, 1);  //得到1970年的时间戳
        long a = (DateTime.UtcNow.Ticks - timeStamp.Ticks) / 10000000;  //注意这里有时区问题，用now就要减掉8个小时
        return a;
    }

    public static bool Is_File(string name)
    {
        name = name.ToLower();
        if (name.Contains(".exe"))
            return true;
        else
            return false;
    }

    /// <summary>
    /// 判断文件格式是否为图片，返回真假
    /// </summary>
    /// <param name="name">文件名</param>
    /// <returns>返回真假</returns>
    public static bool Is_Img(string name)
    {
        name = System.IO.Path.GetExtension(name);
        if (name.Contains(".gif") || name.Contains(".png") || name.Contains(".jpg") || name.Contains(".jpeg") || name.Contains(".bmp"))
            return true;
        else
            return false;
    }

    /// <summary>
    /// 判断文件是否为pdf文件，若是返回true
    /// </summary>
    /// <param name="fileName">文件名或路径</param>
    /// <returns></returns>
    public static bool IsPDF(string fileName)
    {
        fileName = System.IO.Path.GetExtension(fileName);
        if (fileName.EndsWith(".pdf"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool Is_AuthenticationFile(string name)
    {
        string ExtensionName = System.IO.Path.GetExtension(name);
        ExtensionName = ExtensionName.ToLower();
        if (name.Contains(".gif") || name.Contains(".png") || name.Contains(".jpg") || name.Contains(".jpeg") || name.Contains(".bmp") || name.Contains(".rar") || name.Contains(".zip"))
            return true;
        else
            return false;
    }
    public static bool Size_Limit(HttpPostedFile file, int length, string unit)
    {
        if (unit.ToUpper() == "B")
            goto end;
        length = length * 1024;//KB
        if (unit.ToUpper() == "KB")
            goto end;
        length = length * 1024;//M
        if (unit.ToUpper() == "M")
            goto end;
        length = length * 1024;//G
        if (unit.ToUpper() == "G")
            goto end;
        length = length * 1024;//T
    end: if (file.ContentLength > length)
            return true;
        else
            return false;
    }

    /// <summary>
    /// 在某个地方建立制定名字的文件夹供用户用，返回虚拟路径
    /// </summary>
    /// <param name="mappath">待建目录的路径</param>
    /// <param name="username">待建文件夹的名字</param>
    /// <returns>返回虚拟路径</returns>
    public static string User_Path(string mappath, string username)
    {
        string path = mappath + Path.DirectorySeparatorChar + username;
        if (!path.Contains(":"))
            path = HttpContext.Current.Server.MapPath(path);
        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);
        return path.Replace(HttpContext.Current.Server.MapPath("~/"), "~/").Replace("\\", "/");
    }

    /// <summary>
    /// 创建目录，返回物理目录路径。
    /// </summary>
    /// <param name="path">待创建目录路径</param>
    /// <returns>返回物理目录路径</returns>
    public static string Creat_Dir(string path)
    {
        if (!path.Contains(":"))
            path = HttpContext.Current.Server.MapPath(path);
        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);
        if (Directory.Exists(path))
            return path;
        else
            return "";
    }

    /// <summary>
    /// 删除路径
    /// </summary>
    /// <param name="path"></param>
    /// <returns></returns>
    public static bool Del_Dir(string path)
    {
        if (!path.Contains(":"))
            path = HttpContext.Current.Server.MapPath(path);
        try
        {
            foreach (string file in Directory.GetDirectories(path))
                Del_Dir(file);
            foreach (string file in Directory.GetFiles(path))
                File.Delete(file);
            Directory.Delete(path);
        }
        catch
        {
            return false;
        }
        return true;
    }

    /// <summary>
    /// 创建文件并写入内容
    /// </summary>
    /// <param name="path">虚拟路径</param>
    /// <param name="content"></param>
    /// <returns></returns>
    public static bool Creat_File(string path, string content)
    {
        if (!path.Contains(":"))
            path = HttpContext.Current.Server.MapPath(path);
        try
        {
            StreamWriter sw = new StreamWriter(path, false, Encoding.Default);
            sw.Write(content);
            sw.Close();
            sw.Dispose();
        }
        catch
        {
            return false;
        }
        return true;
    }

    /// <summary>
    /// 续写文件内容
    /// </summary>
    /// <param name="filepath">虚拟路径包含文件名</param>
    /// <param name="content"></param>
    /// <returns></returns>
    public static bool Append_File(string filepath, string content)
    {
        if (!filepath.Contains(":"))
            filepath = HttpContext.Current.Server.MapPath(filepath);
        try
        {
            StreamWriter sw = new StreamWriter(filepath, true, Encoding.Default);
            sw.Write(content);
            sw.Close();
            sw.Dispose();
        }
        catch
        {
            return false;
        }
        return true;
    }

    /// <summary>
    /// 读取文件内容
    /// </summary>
    /// <param name="filepath">虚拟路径包含文件名</param>
    /// <returns></returns>
    public static string Read_File(string filepath)
    {
        StreamReader sr;
        if (!filepath.Contains(":"))
            filepath = HttpContext.Current.Server.MapPath(filepath);
        try
        {
            sr = new StreamReader(filepath, Encoding.Default);
            return sr.ReadToEnd();
        }
        catch
        {
            sr = null;
            return string.Empty;
        }
    }

    /// <summary>
    /// 上传文件并自动命名，返回文件的虚拟地址
    /// </summary>
    /// <param name="file">要上传的本地文件</param>
    /// <param name="mappath">服务器的虚拟路径,请使用相对路径</param>
    public static string Up_File(HttpPostedFile file, string visualpath, string mappath)
    {
        try
        {
            string name = names() + Path.GetExtension(file.FileName);
            StringBuilder path = new StringBuilder(HttpContext.Current.Server.MapPath(mappath));
            if (!Directory.Exists(path.ToString()))
                Directory.CreateDirectory(path.ToString());
            path.Append(Path.DirectorySeparatorChar);
            path.Append(name);
            file.SaveAs(path.ToString());
            return (HttpContext.Current.Server.MapPath(mappath).Replace(HttpContext.Current.Server.MapPath(visualpath), "") + Path.DirectorySeparatorChar + name).Replace("\\", "/");
        }
        catch (IOException e)
        {
            throw e;
        }
    }

    /// <summary>
    /// 上传文件指定文件名含扩展名，返回文件的虚拟地址
    /// </summary>
    /// <param name="file">要上传的本地文件</param>
    /// <param name="mappath">服务器的虚拟路径,请使用相对路径</param>
    /// <param name="filename">要保存的文件命名,包括扩展名</param>
    public static string Up_File(HttpPostedFile file, string visualpath, string mappath, string filename)
    {
        try
        {
            StringBuilder path = new StringBuilder(HttpContext.Current.Server.MapPath(mappath));
            if (!Directory.Exists(path.ToString()))
                Directory.CreateDirectory(path.ToString());
            path.Append(Path.DirectorySeparatorChar);
            path.Append(filename);
            path.Append(Path.GetExtension(file.FileName));
            file.SaveAs(path.ToString());
            return (HttpContext.Current.Server.MapPath(mappath).Replace(HttpContext.Current.Server.MapPath(visualpath), "") + Path.DirectorySeparatorChar + filename + Path.GetExtension(file.FileName)).Replace("\\", "/");
        }
        catch (IOException e)
        {
            throw e;
        }
    }
   
    /// <summary>
    /// 上传加水印图片，返回图片的虚拟地址
    /// </summary>
    /// <param name="file">要上传的本地图片</param>
    /// <param name="visualpath">设置的服务器文件上传虚拟路径用于替换掉无用的物理路径头</param>
    /// <param name="mappath">要上传到的服务器虚拟路径,请使用相对路径</param>
    /// <param name="filename">要保存的文件命名,包括扩展名，为空将自动命名</param>
    /// <param name="text">水印文字，为空则不打</param>
    /// <param name="waterimg">水印图片，为空则不打</param>
    public static string Up_Image(HttpPostedFile file, string visualpath, string mappath, string filename, string text, string waterimg)
    {
        try
        {
            string name = names() + Path.GetExtension(file.FileName);
            if (filename != "")
                name = filename + Path.GetExtension(file.FileName);
            StringBuilder path = new StringBuilder(HttpContext.Current.Server.MapPath(mappath));
            if (!Directory.Exists(path.ToString()))
                Directory.CreateDirectory(path.ToString());
            path.Append(Path.DirectorySeparatorChar);
            path.Append(name);
            string filetemp = path.ToString() + "temp";
            file.SaveAs(filetemp);
            //定义Image对象变量
            Image image = Image.FromFile(filetemp);
            Image newimage = new Bitmap(image.Width, image.Height, PixelFormat.Format32bppRgb);
            Graphics g = Graphics.FromImage(newimage);
            g.DrawImage(image, 0, 0, image.Width, image.Height);
            //写版权文字
            if (text != "")
            {
                //选择字体和大小
                int[] sizes = new int[] { 16, 14, 12, 10, 8, 6, 4 };
                Font crFont = null;
                SizeF crSize = new SizeF();
                for (int i = 0; i < 7; i++)
                {
                    crFont = new Font("arial", sizes[i], FontStyle.Bold);
                    crSize = g.MeasureString(text, crFont);

                    if ((ushort)crSize.Width < (ushort)image.Width)
                        break;
                }
                //匹配适合高度底部上5%
                int yPixlesFromBottom = (int)(image.Height * .05);
                float yPosFromBottom = ((image.Height -
                           yPixlesFromBottom) - (crSize.Height / 2));
                float xCenterOfImg = (image.Width / 2);
                //定位中间
                StringFormat StrFormat = new StringFormat();
                StrFormat.Alignment = StringAlignment.Center;

                //使用60%黑色的一个Color(alpha值153)创建一个SolidBrush 
                SolidBrush semiTransBrush1 = new SolidBrush(Color.FromArgb(153, 0, 0, 0));
                g.DrawString(text, crFont, semiTransBrush1, new PointF(xCenterOfImg + 1, yPosFromBottom + 1), StrFormat);
                //在偏离右边1像素，底部1像素的合适位置绘制版权字符串。这段偏离将用来创建阴影效果
                SolidBrush semiTransBrush = new SolidBrush(Color.FromArgb(153, 255, 255, 255));
                g.DrawString(text, crFont, semiTransBrush, new PointF(xCenterOfImg, yPosFromBottom), StrFormat);
            }
            //打水印图片
            if (waterimg != "")
            {
                Bitmap bmWatermark = new Bitmap(newimage);
                bmWatermark.SetResolution(newimage.HorizontalResolution, newimage.VerticalResolution);
                Graphics gw = Graphics.FromImage(bmWatermark);
                //加载图片
                string x = HttpContext.Current.Server.MapPath(waterimg);
                Image watermark = Image.FromFile(x);
                //处理白色为透明色
                ImageAttributes imageAttributes = new ImageAttributes();
                ColorMap colorMap = new ColorMap();
                colorMap.OldColor = Color.FromArgb(255, 255, 255, 255);
                colorMap.NewColor = Color.FromArgb(0, 0, 0, 0);
                ColorMap[] remapTable = { colorMap };
                imageAttributes.SetRemapTable(remapTable, ColorAdjustType.Bitmap);
                //第二个颜色处理用来改变水印的不透明性。通过应用包含提供了坐标的RGBA空间的5x5矩阵来做这个。通过设定第三行、第三列为0.3f我们就达到了一个不透明的水平。结果是水印会轻微地显示在图象底下一些。
                float[][] colorMatrixElements = { 
                    new float[] {1.0f,  0.0f,  0.0f,  0.0f, 0.0f},
                    new float[] {0.0f,  1.0f,  0.0f,  0.0f, 0.0f},
                    new float[] {0.0f,  0.0f,  1.0f,  0.0f, 0.0f},
                    new float[] {0.0f,  0.0f,  0.0f,  0.3f, 0.0f},
                    new float[] {0.0f,  0.0f,  0.0f,  0.0f, 1.0f}
                };
                ColorMatrix wmColorMatrix = new ColorMatrix(colorMatrixElements);

                imageAttributes.SetColorMatrix(wmColorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                //绘制水印
                int xPosOfWm = ((image.Width - watermark.Width) - 10);
                int yPosOfWm = 10;
                gw.DrawImage(watermark, new Rectangle(xPosOfWm, yPosOfWm, watermark.Width, watermark.Height), 0, 0, watermark.Width, watermark.Height, GraphicsUnit.Pixel, imageAttributes);
                //返回图片
                newimage = bmWatermark;
                gw.Dispose();
                watermark.Dispose();
            }
            g.Dispose();
            File.Delete(path.ToString());
            newimage.Save(path.ToString());
            image.Dispose();
            newimage.Dispose();
            if (File.Exists(filetemp))
                File.Delete(filetemp);
            return (HttpContext.Current.Server.MapPath(mappath).Replace(HttpContext.Current.Server.MapPath(visualpath), "") + Path.DirectorySeparatorChar + name).Replace("\\", "/");
        }
        catch (IOException e)
        {
            throw e;
        }
    }

    private static bool ThumbnailCallback()
    {
        return false;
    }

    /// <summary>
    /// 生成缩略图，返回图片的相对于visualpath的相对路径
    /// </summary>
    /// <param name="file">生成缩略图片</param>
    /// <param name="visualpath">设置的服务器文件上传虚拟路径用于替换掉无用的物理路径头</param>
    /// <param name="mappath">要上传到的服务器虚拟路径,请使用相对路径</param>
    /// <param name="newwidth">缩略图宽度</param>
    /// <param name="newheight">缩略图高度</param>
    public static string Minimage(string file, string filename, string visualpath, string mappath, int newwidth, int newheight)
    {
        try
        {
            //定义Image对象变量
            Image image = Image.FromFile(HttpContext.Current.Server.MapPath(file));
            //下面根据原有的图片尺寸计算要生成的图片尺寸
            int width = image.Width;
            int height = image.Height;
            if (width > height)
            {
                newheight = newwidth * height / width;
            }
            else
            {
                newwidth = newheight * width / height;
            }
            Image.GetThumbnailImageAbort callb = new Image.GetThumbnailImageAbort(ThumbnailCallback);
            Image newimage = image.GetThumbnailImage(newwidth, newheight, callb, new System.IntPtr());
            string name = "mini" + Path.GetFileName(file);
            if(filename!= "")
                name = filename + Path.GetExtension(file);
            string newfile = HttpContext.Current.Server.MapPath(mappath);
            if (!Directory.Exists(newfile))
                Directory.CreateDirectory(newfile);
            newfile += Path.DirectorySeparatorChar + name;
            File.Delete(newfile);
            newimage.Save(newfile);
            image.Dispose();
            newimage.Dispose();
            return (HttpContext.Current.Server.MapPath(mappath).Replace(HttpContext.Current.Server.MapPath(visualpath), "") + Path.DirectorySeparatorChar + name).Replace("\\", "/");
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    /// <summary>
    /// 生成缩略图，返回图片的虚拟地址
    /// </summary>
    /// <param name="file">生成缩略图片</param>
    /// <param name="visualpath">设置的服务器文件上传虚拟路径用于替换掉无用的物理路径头</param>
    /// <param name="mappath">要上传到的服务器虚拟路径,请使用相对路径</param>
    /// <param name="newwidth">缩略图宽度</param>
    /// <param name="newheight">缩略图高度</param>
    public static string MinimageFixSize(string file, string filename, string visualpath, string mappath, int newwidth, int newheight)
    {
        //try
        //{
        //定义Image对象变量
        Image image = Image.FromFile(file);
        //下面根据原有的图片尺寸计算要生成的图片尺寸
        int width = image.Width;
        int height = image.Height;
        int nwidth = newwidth;
        int nheight = newheight;
        if (width > height)
        {
            nheight = nwidth * height / width;
        }
        else
        {
            nwidth = nheight * width / height;
        }
        Image.GetThumbnailImageAbort callb = new Image.GetThumbnailImageAbort(ThumbnailCallback);
        Image newimage = image.GetThumbnailImage(nwidth, nheight, callb, new System.IntPtr());

        Bitmap bmWatermark = new Bitmap(newwidth, newheight);
        bmWatermark.SetResolution(bmWatermark.HorizontalResolution, bmWatermark.VerticalResolution);
        Graphics gw = Graphics.FromImage(bmWatermark);
        gw.Clear(Color.White);

        int xPosOfWm = ((bmWatermark.Width - newimage.Width) / 2);
        int yPosOfWm = ((bmWatermark.Height - newimage.Height) / 2);
        gw.DrawImage(newimage,new Rectangle(xPosOfWm, yPosOfWm, newimage.Width, newimage.Height),0,0,newimage.Width,newimage.Height, GraphicsUnit.Pixel);

        string name = names() + Path.GetExtension(file);
        if (filename != "")
            name = filename + Path.GetExtension(file);
        string newfile = HttpContext.Current.Server.MapPath(mappath);
        if (!Directory.Exists(newfile))
            Directory.CreateDirectory(newfile);
        newfile += Path.DirectorySeparatorChar + name;
        File.Delete(newfile);
        bmWatermark.Save(newfile);
        image.Dispose();
        newimage.Dispose();
        gw.Dispose();
        bmWatermark.Dispose();

        return (HttpContext.Current.Server.MapPath(mappath).Replace(HttpContext.Current.Server.MapPath(visualpath), "") + Path.DirectorySeparatorChar + name).Replace("\\", "/");
        //}
        //catch (Exception e)
        //{
        //    throw e;
        //}
    }
    /// <summary>
    /// 生成缩略图,裁减尺寸，如果设置宽高为-1，默认用正方形最大取，如果设置偏移为-1，默认从中间位置取，返回图片的虚拟地址
    /// </summary>
    /// <param name="file">生成缩略图片</param>
    /// <param name="visualpath">设置的服务器文件上传虚拟路径用于替换掉无用的物理路径头</param>
    /// <param name="mappath">要上传到的服务器虚拟路径,请使用相对路径</param>
    /// <param name="newwidth">截取范围宽度</param>
    /// <param name="newheight">截取范围高度</param>
    /// <param name="posLeft">左侧偏移量</param>
    /// <param name="posTop">顶部偏移量</param>
    public static string ImageCutMaxSize(string file,string filename, string visualpath, string mappath, int newwidth, int newheight, int posLeft, int posTop)
    {
        //try
        //{
        //定义Image对象变量
        Image image = Image.FromFile(HttpContext.Current.Server.MapPath(file));
        
        int width = image.Width;
        int height = image.Height;
        int nwidth = width;
        int nheight = height;
        if (newwidth < nwidth || newheight < nheight)
        {
            int ratio = (int)(((float)newheight / (float)newwidth) * 1000);
            if (nheight > height)
                nheight = height;
            if (nwidth == -1)
                nwidth = width;
            if (nheight == -1)
                nheight = height;
            if (((float)height / (float)width) * 1000 > ratio)
                nheight = nwidth * ratio / 1000;
            else
                nwidth = nheight / ratio / 1000;

            //下面根据原有的图片尺寸计算要生成的图片尺寸
            if (width < height)
            {
                if (newheight == -1)
                    nheight = width;
                if (posLeft == -1)
                    posLeft = 0;
            }
            else
            {
                if (newwidth == -1)
                    nwidth = height;
                if (posTop == -1)
                    posTop = 0;
            }
        }
        //如果为设置偏移重新计算偏移到中间
        if (posLeft == -1)
            posLeft = (image.Width - nwidth) / 2;
        if (posTop == -1)
            posTop = (image.Height - nheight) / 2;
        //绘制背景
        Bitmap bmWatermark = new Bitmap(nwidth, nheight);
        bmWatermark.SetResolution(bmWatermark.HorizontalResolution, bmWatermark.VerticalResolution);
        Graphics gw = Graphics.FromImage(bmWatermark);
        gw.Clear(Color.White);

        gw.DrawImage(image, new Rectangle(0, 0, nwidth, nheight), posLeft, posTop, nwidth, nheight, GraphicsUnit.Pixel);
        if (filename == "")
            filename = Path.GetFileNameWithoutExtension(file);
        filename += Path.GetExtension(file);
        string newfile = HttpContext.Current.Server.MapPath(mappath);
        if (!Directory.Exists(newfile))
            Directory.CreateDirectory(newfile);
        newfile += Path.DirectorySeparatorChar + filename;
        File.Delete(newfile);
        bmWatermark.Save(newfile);
        image.Dispose();
        gw.Dispose();
        bmWatermark.Dispose();

        return (HttpContext.Current.Server.MapPath(mappath).Replace(HttpContext.Current.Server.MapPath(visualpath), "") + Path.DirectorySeparatorChar + filename).Replace("\\", "/");

        //}
        //catch (Exception err)
        //{
        //    throw err;
        //}
    }

    /// <summary>
    /// 生成缩略图,裁减尺寸，如果设置宽高为-1，默认用正方形最大取，如果设置偏移为-1，默认从中间位置取，返回图片的虚拟地址
    /// </summary>
    /// <param name="file">生成缩略图片</param>
    /// <param name="visualpath">设置的服务器文件上传虚拟路径用于替换掉无用的物理路径头</param>
    /// <param name="mappath">要上传到的服务器虚拟路径,请使用相对路径</param>
    /// <param name="newwidth">截取范围宽度</param>
    /// <param name="newheight">截取范围高度</param>
    /// <param name="posLeft">左侧偏移量</param>
    /// <param name="posTop">顶部偏移量</param>
    public static string ImageCutSize(string file, string filename, string visualpath, string mappath, int newwidth, int newheight, int posLeft, int posTop)
    {
        //try
        //{
        //定义Image对象变量
        Image image = Image.FromFile(HttpContext.Current.Server.MapPath(file));

        int width = image.Width;
        int height = image.Height;
        int nwidth = newwidth;
        int nheight = newheight;
        if (nwidth == -1)
            nwidth = width;
        if (nheight == -1)
            nheight = height;
        //下面根据原有的图片尺寸计算要生成的图片尺寸
        if (width < height)
        {
            if (newheight == -1)
                nheight = width;
            if (posLeft == -1)
                posLeft = 0;
        }
        else
        {
            if (newwidth == -1)
                nwidth = height;
            if (posTop == -1)
                posTop = 0;
        }
        //如果为设置偏移重新计算偏移到中间
        if (posLeft == -1)
            posLeft = (image.Width - nwidth) / 2;
        if (posTop == -1)
            posTop = (image.Height - nheight) / 2;
        //绘制背景
        Bitmap bmWatermark = new Bitmap(nwidth, nheight);
        bmWatermark.SetResolution(bmWatermark.HorizontalResolution, bmWatermark.VerticalResolution);
        Graphics gw = Graphics.FromImage(bmWatermark);
        gw.Clear(Color.White);

        gw.DrawImage(image, new Rectangle(0, 0, nwidth, nheight), posLeft, posTop, nwidth, nheight, GraphicsUnit.Pixel);
        if (filename == "")
            filename = Path.GetFileNameWithoutExtension(file);
        filename += Path.GetExtension(file);
        string newfile = HttpContext.Current.Server.MapPath(mappath);
        if (!Directory.Exists(newfile))
            Directory.CreateDirectory(newfile);
        newfile += Path.DirectorySeparatorChar + filename;
        File.Delete(newfile);
        bmWatermark.Save(newfile);
        image.Dispose();
        gw.Dispose();
        bmWatermark.Dispose();

        return (HttpContext.Current.Server.MapPath(mappath).Replace(HttpContext.Current.Server.MapPath(visualpath), "") + Path.DirectorySeparatorChar + filename).Replace("\\", "/");

        //}
        //catch (Exception err)
        //{
        //    throw err;
        //}
    }

    /// <summary>
    /// 生成缩略图,裁减尺寸，如果设置偏移为-1，默认从中间位置取，返回图片的虚拟地址
    /// </summary>
    /// <param name="file">生成缩略图片</param>
    /// <param name="visualpath">设置的服务器文件上传虚拟路径用于替换掉无用的物理路径头</param>
    /// <param name="mappath">要上传到的服务器虚拟路径,请使用相对路径</param>
    /// <param name="newwidth">缩略图宽度</param>
    /// <param name="newheight">缩略图高度</param>
    /// <param name="posLeft">左侧偏移量</param>
    /// <param name="posTop">顶部偏移量</param>
    public static string MinimageCutSize(string file, string filename, string visualpath, string mappath, int newwidth, int newheight, int posLeft, int posTop)
    {
        //try
        //{
            //定义Image对象变量
            Image image = Image.FromFile(HttpContext.Current.Server.MapPath(file));
            //绘制背景
            Bitmap bmWatermark = new Bitmap(newwidth, newheight);
            bmWatermark.SetResolution(bmWatermark.HorizontalResolution, bmWatermark.VerticalResolution);
            Graphics gw = Graphics.FromImage(bmWatermark);
            gw.Clear(Color.White);
  
            //如果为设置偏移重新计算偏移到中间
            if (posLeft == -1)
                posLeft = (image.Width - newwidth) / 2;
            if (posTop == -1)
                posTop = (image.Height - newheight) / 2;
            gw.DrawImage(image, new Rectangle(0, 0, newwidth, newwidth), posLeft, posTop, newwidth, newwidth, GraphicsUnit.Pixel);

            if (filename == "")
                filename = Path.GetFileNameWithoutExtension(file);
            filename += Path.GetExtension(file);
            string newfile = HttpContext.Current.Server.MapPath(mappath);
            if (!Directory.Exists(newfile))
                Directory.CreateDirectory(newfile);
            newfile += Path.DirectorySeparatorChar + filename;
            File.Delete(newfile);
            bmWatermark.Save(newfile);
            image.Dispose();
            gw.Dispose();
            bmWatermark.Dispose();

            return (HttpContext.Current.Server.MapPath(mappath).Replace(HttpContext.Current.Server.MapPath(visualpath), "") + Path.DirectorySeparatorChar + filename).Replace("\\", "/");

        //}
        //catch (Exception err)
        //{
        //    throw err;
        //}

    }
    public static bool Del_File(string mappath)
    {
        if (!mappath.Contains(":"))
            mappath = HttpContext.Current.Server.MapPath(mappath);
        try
        {
            File.Delete(mappath);
        }
        catch
        {
            return false;
        }
        return true;
    }

    public static bool Exists_File(string mappath)
    {
        if (!mappath.Contains(":"))
            mappath = HttpContext.Current.Server.MapPath(mappath);
        return File.Exists(mappath);
    }

    public static string[] List_File(string mappath)
    {
        if (!mappath.Contains(":"))
            mappath = HttpContext.Current.Server.MapPath(mappath);
        return Directory.GetFiles(mappath);
    }
}
