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
    public partial class DepartApprove : System.Web.UI.Page
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
            lblName.Text = fa.FilesName.ToString();
            lblTime.Text = fa.ApplyTime.ToString();
            lblType.Text = fa.FileType.ToString();
        }

      

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (rblOver.SelectedIndex == -1)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('请选择修正或通过！');</script>");
            }
            else
            {
                 try
                {
                    int fid = Convert.ToInt32(Request["FileApplyId"].ToString());
                    FileApplyInfo fa = new FileApplyInfo(fid);
                    fa.DepartView = txtView.Text.ToString();
                    if (rblOver.Items[0].Selected)
                    {
                        fa.State = 2;
                        fa.Save();
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('您让申请人修正！');</script>");
                    }
                    else if (rblOver.Items[1].Selected)
                    {

                        fa.State = 3;
                        fa.Save();
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('审批通过！');</script>");
                    }

                }
                catch (Exception Ex)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Save", "alert('保存失败：" + Ex.Message + "');", true);
                }

            }
 
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
