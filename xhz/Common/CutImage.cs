using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Maticsoft.Common
{
    /// <summary>
    /// 作者：黄雪峰
    /// 时间：2012-10-28
    /// 功能描述：用于对上传的图片进行截取
    /// </summary>
    ///   /// <summary>
    /// 截取图片
    /// </summary>
    /// <param name="oPath">原图片路径</param>
    /// <param name="nPaht">新图片路径</param>
    /// <param name="w">略缩图的宽度</param>
    /// <param name="h">略缩图的高度</param>
    /// <param name="mode">截取模式</param>
    public static class CutImage
    {
      
        public static void CutImg(string oPath, string nPaht, int w, int h,string mode)
        {
            Image oimg = Image.FromFile(oPath);
            int nToWidth = w;
            int nToHeight = h;
            int x = 0;
            int y = 0;
            int oWidth = oimg.Width;
            int oHeight = oimg.Height;
            switch (mode)
            {
                case "HW"://按照指定的宽高进行缩放，可能变形
                    break;
                case "W"://指定宽度，高按比例缩放
                    nToHeight = oWidth * oHeight / nToWidth;
                    break;
                case "H"://指定高度，宽按比例缩放
                    nToWidth=oWidth*oHeight/nToHeight;
                    break;
                case "CUT"://按照指定的宽、高缩放
                    if ((oimg.Width / oimg.Height) > (nToWidth / nToHeight))
                    {
                        oHeight = oimg.Height;
                        oWidth = oimg.Height * nToWidth / nToHeight;
                        y = 0;
                        x = (oimg.Width - oWidth) / 2;
                    }
                    else
                    {
                        oWidth = oimg.Width;
                        oHeight = oimg.Width * nToHeight / nToWidth;
                        x = 0;
                        y = (oimg.Height - oHeight) / 2;
                    }
                    break;
                case "h"://高级缩放，不形变，不裁剪，根据画布大小偏小缩放
                    if (((double)oimg.Width / oimg.Height) > ((double)w / h))
                    {
                        if (oWidth>w)
                        {
                            nToHeight =oHeight *nToWidth / oWidth;
                        }
                        else
                        {
                            nToWidth = oWidth;
                            nToHeight = oHeight;
                        }
                    }
                    else
                    {
                        if (oHeight>h)
                        {
                            nToWidth = oWidth * nToHeight / oHeight;
                        }
                        else
                        {
                            nToWidth = oWidth;
                            nToHeight = oHeight;
                        }
                    }
                    break;
                default: break;
            }
            //新建一个BMP图片
            Image bitmap = new Bitmap(nToWidth, nToHeight);
            //新建一个画板
            Graphics gp = Graphics.FromImage(bitmap);
            gp.InterpolationMode = InterpolationMode.High;
            gp.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //清空画布，并以背景色为透明色填充
            gp.Clear(Color.Transparent);
            gp.DrawImage(oimg, new Rectangle(0, 0, nToWidth, nToHeight), new Rectangle(x, y, oWidth, oHeight), GraphicsUnit.Pixel);
            try
            {
                bitmap.Save(nPaht, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                oimg.Dispose();
                bitmap.Dispose();
            }
        }
        /// <summary>
        /// 获取图片等比缩放后的大小
        /// </summary>
        /// <param name="newWidth">缩小后的宽度</param>
        /// <param name="newHeight">缩小后的高度</param>
        /// <param name="oldWidth">原来的宽度</param>
        /// <param name="oldHeight">原来的高度</param>
        /// <returns></returns>
        public static Size GetNewSize(int newWidth, int newHeight, int oldWidth, int oldHeight)
        {
            double h = 0.0;
            double w = 0.0;
            double ow = Convert.ToDouble(oldWidth);
            double oh = Convert.ToDouble(oldHeight);
            double nw = Convert.ToDouble(newWidth);
            double nh = Convert.ToDouble(newHeight);
            if (ow < nw & oh < nh)//如果指定的宽高都大于图片的原宽高，则范围缩小图片大小直接为原来宽高
            {
                h = oh;
                w = ow;
            }
            else if ((ow / oh) > (nw / nh))//如果图片原来的宽高比大于新生成的图片的宽高比
            {
                w = nw;
                h = (w * oh) / ow;
            }
            else
            {
                h = nh;
                w = h * ow / oh;
            }
            return new Size(Convert.ToInt32(w), Convert.ToInt32(h));
        }
        /// <summary>
        /// 对给定的图像生成一个指定大小的略缩图
        /// </summary>
        /// <param name="image">原始图片</param>
        /// <param name="newWidth">略缩图的宽</param>
        /// <param name="newHeight">略缩图的高</param>
        /// <returns></returns>
        public static Image GetThumbNailImage(Image image, int newWidth, int newHeight)
        {
            Size newSize = Size.Empty;
            Image newImage = image;
            newSize = GetNewSize(newWidth, newHeight, image.Width, image.Height);
            Graphics g = null;
            try
            {
                g = Graphics.FromImage(image);
                newImage = new Bitmap(newSize.Width, newSize.Height);
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.Clear(Color.Transparent);
                g.DrawImage(image, new Rectangle(0, 0, newSize.Width, newSize.Height), new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);
            }
            catch
            {

            }
            finally
            {
                g.Dispose();
                g = null;
            }
            return newImage;
        }
        /// <summary>
        /// 根据一个已经存在的图片，生成一个略缩图
        /// </summary>
        /// <param name="imagepath">给定文件的路径</param>
        /// <param name="newWidth">略缩图的宽</param>
        /// <param name="newHeight">略缩图的高</param>
        /// <returns></returns>
        public static Image GetThumbNailImage(string imagepath, int newWidth, int newHeight,string path)
        {
            Image oimage = null;
            Image newImage = null;
            try
            {
                oimage = Image.FromFile(imagepath);
                newImage = GetThumbNailImage(oimage, newWidth, newHeight);
            }
            catch
            {
            }
            finally
            {
                oimage.Dispose();
                newImage.Dispose();
            }
            string pa = path + "olive.jpg";
            newImage.Save(pa);
            return newImage;
        }

    }
}