using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using CanYou.OA.BLL;
namespace OA.FileApply
{
    public partial class EditFile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PageInit();
            }
        }

        protected void PageInit()
        {
            ViewState["BackUrl"] = Request.UrlReferrer.ToString();
            FileApplyInfo fa=new FileApplyInfo(Convert.ToInt32(Request["FileApplyId"].ToString()));
            lblEm.Text=fa.ApplyName.ToString();
            txtTime.Text=fa.ApplyTime.ToString();
            txtSectionView.Text=fa.DepartView.ToString();
            txtFileDes.Text=fa.FileDes.ToString();
            txtFileName.Text=fa.FilesName.ToString();
            txtFileType.Text=fa.FileType.ToString();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (UpFile.HasFile)
            {
                FileApplyInfo fa = new FileApplyInfo(Convert.ToInt32(Request["FileApplyId"].ToString()));

                FileOfApplyInfo ffa = new FileOfApplyInfo(Convert.ToInt32(fa.FileOfApplyId));
                ffa.FileOfName = UpFile.FileName.ToString();
                ffa.PhysicalName = UpFile.PostedFile.FileName.ToString();
                ffa.Save();

                fa.ApplyTime = txtTime.Text.ToString();
                fa.DepartView = txtSectionView.Text.ToString();
                fa.FileDes = txtFileDes.Text.ToString();
                fa.FilesName = txtFileName.Text.ToString();
                fa.FileType = txtFileType.Text.ToString();
                fa.Save();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('保存成功，确认无误后需要您进一步提交！');</script>");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('请重新修改文件名并上传！');</script>");
            }
           
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(ViewState["BackUrl"].ToString());
        }
    }
}
