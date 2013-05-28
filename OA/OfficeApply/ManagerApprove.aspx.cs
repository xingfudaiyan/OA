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

namespace OA.OfficeApply
{
    public partial class ManagerApprove : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PageInit();
                ViewState["BackUrl"] = Request.UrlReferrer.ToString();
            }
        }

        protected void PageInit()
        {
            int wtid = Convert.ToInt32(Request["OfficeApplyId"].ToString());
            WorkToolSumInfo wt = new WorkToolSumInfo(wtid);
            lblFuTime.Text = wt.FuTime.ToString();
            lblBanDepart.Text = wt.DepartName.ToString();
            lblBigMoney.Text = wt.BigMoney.ToString();
            lblJieDepart.Text = wt.DepartName.ToString();
            lblJinEmployee.Text = wt.ApplyName.ToString();
            lblMoneyStyle.Text = wt.MoneyStyle.ToString();
            lblSmallMoney.Text = wt.SmaMoney.ToString();
            lblUseDepart.Text = wt.UseDepartName.ToString();
            lblReason.Text = wt.Reason.ToString();
            lblDepartView.Text = wt.DepartView.ToString();
        }

        protected bool IsPageValid()
        {
            if (rblOver.SelectedIndex == -1)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('请选择修正或通过！');</script>");
                return false;
            }
            else
            {
                return true;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (IsPageValid())
            {
                try
                {
                    int wtid = Convert.ToInt32(Request["OfficeApplyId"].ToString());
                    WorkToolSumInfo wt = new WorkToolSumInfo(wtid);

                    wt.ManagerView = txtManagerView.Text.ToString();

                    if (rblOver.Items[0].Selected)
                    {
                        wt.State = 5;
                        wt.Save();
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('您让申请人修正！');</script>");

                    }
                    else if (rblOver.Items[1].Selected)
                    {
                        wt.State = 4;
                        wt.Save();
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
