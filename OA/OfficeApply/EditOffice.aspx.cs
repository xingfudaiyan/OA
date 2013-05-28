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
    public partial class EditOffice : System.Web.UI.Page
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
            txtFuTime.Text = wt.FuTime.ToString();
            txtUseDepart.Text = wt.UseDepartName.ToString();
            txtBigMoney.Text = wt.BigMoney.ToString();
            txtFuMoney.Text = wt.MoneyStyle.ToString();
            txtReason.Text = wt.Reason.ToString();
            txtSmallMoney.Text = wt.SmaMoney.ToString();
            lblBanDepart.Text = wt.DepartName.ToString();
            lblJieDepart.Text = wt.DepartName.ToString();
            lblJinEmployee.Text = wt.ApplyName.ToString();
          

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            
                try
                {
                    int wtid = Convert.ToInt32(Request["OfficeApplyId"].ToString());
                    WorkToolSumInfo wt = new WorkToolSumInfo(wtid);
                    wt.FuTime = txtFuTime.Text.ToString();
                    wt.UseDepartName = txtUseDepart.Text.ToString();
                    wt.Reason = txtReason.Text.ToString();
                    wt.BigMoney = txtBigMoney.Text.ToString();
                    wt.SmaMoney = txtSmallMoney.Text.ToString();
                    wt.MoneyStyle = txtFuMoney.Text.ToString();
                    wt.DepartView = txtDepartView.Text.ToString();
                    wt.Save();
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('±à¼­³É¹¦£¡');</script>");
                    
                }
                catch (Exception Ex)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Save", "alert('±à¼­Ê§°Ü£º" + Ex.Message + "');", true);
                }
           
        }


        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(ViewState["BackUrl"].ToString());
        }
    }
}
