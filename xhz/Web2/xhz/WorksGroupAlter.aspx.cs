using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2.xhz
{
    public partial class WorksGroupAlter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind();
            }

        }
        private void Bind()
        {
            int Id = 0;
            if (Request.QueryString["Id"] != null)
            {
                Id = int.Parse(Request.QueryString["Id"]);
            }
            else
            {
                return;
            }
            Maticsoft.BLL.WorksGroup bll = new Maticsoft.BLL.WorksGroup();
            Maticsoft.Model.WorksGroup model = bll.GetModel(Id);
            txtNo.Text = model.No.ToString();
            txtClick.Text = model.Click.ToString();
            txtMark.Text = model.Mark.ToString();
            txtTitle.Text = model.Title;
            txtTime.Text = model.Time.ToString();
            txtsum.Text = model.Info;
            Image1.ImageUrl = model.Atlas;
            label2.Text = model.ID.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //保存文件
            string path = "";
            string filepath = "", filename = "";
            if (FileUpload1.HasFile)
            {
                if (Maticsoft.Common.FileUp.IsImg(FileUpload1.FileName))
                {
                    filepath = Maticsoft.Common.FileUp.GetUploadPath("/Upload/Works");
                    filename = Maticsoft.Common.FileUp.GetRandomName();
                    path = Maticsoft.Common.FileUp.uploadfile(FileUpload1.PostedFile, filepath, filename);
                    //生成缩略图
                }
                else
                {
                    label1.Text = "不支持该文件";
                    return;
                }
            }
            

            //保存数据到数据库
            Maticsoft.BLL.WorksGroup bll = new Maticsoft.BLL.WorksGroup();
            Maticsoft.Model.WorksGroup model = new Maticsoft.Model.WorksGroup();
            model.ID = int.Parse(label2.Text);
            model.Title = txtTitle.Text;
            model.Time = DateTime.Parse(txtTime.Text);
            model.Info = txtsum.Text;
            model.Mark = int.Parse(txtMark.Text);
            model.No = int.Parse( txtNo.Text);
            model.Click = int.Parse(txtClick.Text);
            if (path!="")
            {
                model.Atlas = path;//图片路径
            }
            else
            {
                model.Atlas = Image1.ImageUrl;
            }
            if (bll.Update(model))
            {
                label1.Text = "操作成功";
            }
            else
            {
                label1.Text = "操作失败";
            }

        }
    }
}