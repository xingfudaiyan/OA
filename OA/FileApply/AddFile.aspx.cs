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
    public partial class AddFile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["BackUrl"] = Request.UrlReferrer.ToString();
                pageInit();
            }
        }

        protected void pageInit()
        {
            lblEm.Text = Session["EmployeeName"].ToString();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (UpFile.HasFile)
            {
                this.UpFile.PostedFile.SaveAs(Server.MapPath("~/Files/File/" + UpFile.FileName));
                FileOfApplyInfo ffa = new FileOfApplyInfo();
                ffa.FileOfName = UpFile.FileName.ToString();
                ffa.PhysicalName = UpFile.PostedFile.FileName.ToString();
                ffa.Save();

                FileApplyInfo fa = new FileApplyInfo();
                fa.ApplyName = lblEm.Text.ToString();
                fa.ApplyTime = txtTime.Text.ToString();
                fa.DepartName = Session["DepartName"].ToString();
                fa.DepartView = txtSectionView.Text.ToString();
                fa.FileDes = txtFileDes.Text.ToString();
                fa.FilesName = txtFileName.Text.ToString();
                fa.FileType = txtFileType.Text.ToString();
                fa.State = 0;
                fa.FileOfApplyId = ffa.FileOfApplyId;
                fa.Save();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('新增成功，确认无误后需要您进一步提交！');</script>");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('请上传文件！');</script>");
            }
         
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(ViewState["BackUrl"].ToString());
        }
    }
}
