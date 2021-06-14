using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2.xhz
{
    public partial class Works : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
           
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //保存文件
            string path = "";
            string filepath = "", filename = "";
            int Id = 0;
            try
            {
                Id = int.Parse(Request.QueryString["Id"]);
            }
            catch (Exception)
            {
                label1.Text = "操作失败，请重新进入，尝试";
                return;
            }
            if (FileUpload1.HasFile || Maticsoft.Common.FileUp.IsImg(FileUpload1.FileName))
            {
                filepath = Maticsoft.Common.FileUp.GetUploadPath("/Upload/Works");
                filename = Maticsoft.Common.FileUp.GetRandomName();
                path = Maticsoft.Common.FileUp.uploadfile(FileUpload1.PostedFile, filepath, filename);
            }
            else
            {
                label1.Text = "没有文件，或不支持文件";
                return;
            }
            // 生成缩略图
            string bigPath = Server.MapPath("~/") + filepath + "big_" + filename + System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
            Maticsoft.Common.CutImage.CutImg(Server.MapPath("~/") + path, bigPath, 896, 650, "h");
            string miniPath = Server.MapPath("~/") + filepath + "mini_" + filename + System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
            Maticsoft.Common.CutImage.CutImg(Server.MapPath("~/") + path, miniPath, 100, 75, "h");

            string wPath = Server.MapPath("~/") + filepath + "w_" + filename + System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
            Maticsoft.Common.CutImage.CutImg(Server.MapPath("~/") + path, wPath, 100, 86, "CUT");

            //保存数据到数据库
            Maticsoft.BLL.Works bll = new Maticsoft.BLL.Works();

            Maticsoft.Model.Works model = new Maticsoft.Model.Works();
            model.Title = txtTitle.Text;
            model.Content = txtsum.Text;
            model.GroupID = Id;//
            model.ItemID = 1;
            model.No = bll.GetMaxId();
            model.Attachment = path;//图片路径


            if (bll.Add(model) == 0)
            {
                label1.Text = "插入失败";
            }
            else
            {
                label1.Text = "操作成功";
            }

        }
    }
}