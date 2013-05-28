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
    public partial class FileDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["BackUrl"] = Request.UrlReferrer.ToString();
                PageInit();
            }
        }

        protected void PageInit()
        {
            FileApplyInfo fa = new FileApplyInfo(Convert.ToInt32(Request["FileApplyId"].ToString()));
            lblDes.Text = fa.FileDes.ToString();
            lblEm.Text = fa.ApplyName.ToString();
            lblManagerView.Text = fa.ManagerView.ToString();
            lblName.Text = fa.FilesName.ToString();
            lblTime.Text = fa.ApplyTime.ToString();
            lblType.Text = fa.FileType.ToString();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(ViewState["BackUrl"].ToString());
        }

        protected void btnDownLoad_Click(object sender, EventArgs e)
        {
            int fid = Convert.ToInt32(Request["FileApplyId"].ToString());
            FileApplyInfo fa = new FileApplyInfo(fid);
            int fileid = Convert.ToInt32(fa.FileOfApplyId);
            Response.Redirect("DownLoadFile.aspx?fileid=" + fileid);
        }
    }
}
