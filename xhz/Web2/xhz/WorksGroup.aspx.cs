﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2.xhz
{
    public partial class WorksGroup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //保存文件
            string path = "";
            string filepath="" ,filename="";
            if (FileUpload1.HasFile || Maticsoft.Common.FileUp.IsImg(FileUpload1.FileName))
            {
                filepath = Maticsoft.Common.FileUp.GetUploadPath("/Upload/Works");
                filename = Maticsoft.Common.FileUp.GetRandomName();
                path = Maticsoft.Common.FileUp.uploadfile(FileUpload1.PostedFile, filepath, filename);
                // 生成缩略图
                string bigPath = Server.MapPath("~/") + filepath + "big_" + filename + System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
                Maticsoft.Common.CutImage.CutImg(Server.MapPath("~/") + path, bigPath, 896, 650, "h");
                string miniPath = Server.MapPath("~/") + filepath + "mini_" + filename + System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
                Maticsoft.Common.CutImage.CutImg(Server.MapPath("~/") + path, miniPath, 100, 75, "h");
                string wPath = Server.MapPath("~/") + filepath + "w_" + filename + System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
                Maticsoft.Common.CutImage.CutImg(Server.MapPath("~/") + path, wPath, 100, 86, "CUT");

            }
            else
            {
                label1.Text = "没有文件，或不支持文件";
                return;
            }
            //保存数据到数据库
            Maticsoft.BLL.WorksGroup bll = new Maticsoft.BLL.WorksGroup();
            Maticsoft.Model.WorksGroup model = new Maticsoft.Model.WorksGroup();
            model.Title = txtTitle.Text;
            model.Info = txtsum.Text;
            model.Mark = int.Parse( txtMark.Text );
            model.No = bll.GetMaxId();
            model.Atlas = path;//图片路径


            if (bll.Add(model) == 0)
            {
                label1.Text = "插入失败";
            }
            label1.Text = "操作成功";
        }
    }

}