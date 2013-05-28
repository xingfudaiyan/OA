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

namespace OA.ContractApply
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

        private void PageInit()
        {
            int cid = Convert.ToInt32(Request["ContractApplyId"].ToString());
            ContractApplyInfo ca = new ContractApplyInfo(cid);

            lblDepart.Text = ca.DepartName.ToString();
            lblEmployee.Text = ca.ApplyName.ToString();
            lblSignName.Text = ca.SignName.ToString();
            lblContractNum.Text = ca.ContractNum.ToString();
            lblSheetNum.Text = ca.SheetNum.ToString();
            lblContract.Text = ca.ContractName.ToString();
            lblBeginDate.Text = ca.BeginDate.ToString();
            lblApplyDate.Text = ca.ApplyDate.ToString();
            lblContractDes.Text = ca.ContractDes.ToString();
            lblBigMoney.Text = ca.BigMoney.ToString();
            lblSmallMoney.Text = ca.SmallMoney.ToString();

        }

        protected void btnDownLoad_Click(object sender, EventArgs e)
        {
            int cid = Convert.ToInt32(Request["ContractApplyId"].ToString());
            ContractApplyInfo ca = new ContractApplyInfo(cid);
            int fileid = Convert.ToInt32(ca.ContractFileId);
            Response.Redirect("DownLoadFile.aspx?fileid=" + fileid);

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
                    int cid = Convert.ToInt32(Request["ContractApplyId"].ToString());
                    ContractApplyInfo ca = new ContractApplyInfo(cid);
                    ca.SectionView = txtSectionView.Text.ToString();

                    if (rblOver.Items[0].Selected)
                    {
                        ca.State = 2;
                        ca.Save();
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('您让申请人修正！');</script>");
                    }
                    else if (rblOver.Items[1].Selected)
                    {

                        ca.State = 3;
                        ca.Save();
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
    }
}
