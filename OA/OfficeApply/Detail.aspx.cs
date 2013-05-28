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
    public partial class Detail : System.Web.UI.Page
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
            lblManagerView.Text = wt.ManagerView.ToString();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(ViewState["BackUrl"].ToString());
        }
    }
}
