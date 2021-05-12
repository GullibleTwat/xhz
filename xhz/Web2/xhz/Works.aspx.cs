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
                Maticsoft.BLL.WorksGroup groupbll = new Maticsoft.BLL.WorksGroup();
                GroupList.DataSource = groupbll.GetAllList();
                GroupList.DataValueField = "ID";
                GroupList.DataTextField = "Title";
                GroupList.DataBind();
                Maticsoft.BLL.WorksItem Itembll = new Maticsoft.BLL.WorksItem();

                ItemsList.DataSource = Itembll.GetAllList();
                ItemsList.DataValueField = "ID";
                ItemsList.DataTextField = "Title";
                ItemsList.DataBind();
            }
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
            }
            else
            {
                label1.Text = "没有文件，或不支持文件";
                return;
            }
            // 生成缩略图
            string bigPath = Server.MapPath("~/") + filepath + "big_" +filename+ System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
            Maticsoft.Common.CutImage.CutImg(Server.MapPath("~/") + path, bigPath, 896, 650, "h");
            string miniPath = Server.MapPath("~/") + filepath + "mini_" + filename + System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
            Maticsoft.Common.CutImage.CutImg(Server.MapPath("~/") + path, miniPath, 100, 75, "h");

            string wPath = Server.MapPath("~/") + filepath + "w_" + filename + System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
            Maticsoft.Common.CutImage.CutImg(Server.MapPath("~/") + path, wPath, 100, 86, "CUT");

           //保存数据到数据库
            Maticsoft.Model.Works model = new Maticsoft.Model.Works();
            model.Title = txtTitle.Text;
            model.Content = txtsum.Text;
            model.GroupID = Convert.ToInt32(GroupList.SelectedItem.Value);//
            model.ItemID = Convert.ToInt32(ItemsList.SelectedItem.Value);
            model.Attachment = path;//图片路径

                Maticsoft.BLL.Works bll = new Maticsoft.BLL.Works();

                if ( bll.Add(model)==0)
                {
                    label1.Text = "插入失败";
                }
            label1.Text = "操作成功";
        }
    }
}