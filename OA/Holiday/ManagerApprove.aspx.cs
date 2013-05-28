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

namespace OA.Holiday
{
    public partial class ManagerApprove : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                rblDataBind();
                PageInit();
                ViewState["BackUrl"] = Request.UrlReferrer.ToString();
            }
        }

        protected void rblDataBind()
        {
            DataTable dt = HolidayApplyInfo.getHolidayTypeList();
            rblHoliydayType.DataSource = dt;
            rblHoliydayType.DataTextField = "HolidayTypeName";
            rblHoliydayType.DataValueField = "HolidayTypeId";
            rblHoliydayType.DataBind();
        }

        protected void PageInit()
        {
            int hoid = Convert.ToInt32(Request["HolidayApplyId"].ToString());
            HolidayApplyInfo holiday = new HolidayApplyInfo(hoid);

            lblApplyDate.Text = holiday.ApplyDate.ToString();
            lblPosition.Text = holiday.PositonName.ToString();
            lblEmployeeName.Text = holiday.ApplyName.ToString();
            lblApplyCompany.Text = holiday.Company2.ToString();
            lblApplyName.Text = holiday.Company2Name.ToString();
            rblHoliydayType.SelectedValue = holiday.HolidayTypeId.ToString();
            lblBeginTime.Text = holiday.BeginTime.ToString();
            lblEndTime.Text = holiday.EndTime.ToString();
            lblTimeSum.Text = holiday.TimeSum.ToString();
            lblReason.Text = holiday.Reason.ToString();
            txtUperView.Text = holiday.SectionView.ToString();
            txtHrView.Text = holiday.HrView.ToString();
            txtManagerView.Text = holiday.ManagerView.ToString();
            txtMemo.Text = holiday.Memo.ToString();
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
                    int hoid = Convert.ToInt32(Request["HolidayApplyId"].ToString());
                    HolidayApplyInfo holiday = new HolidayApplyInfo(hoid);
                    holiday.ManagerView = txtManagerView.Text.ToString();
                    if (rblOver.Items[0].Selected)
                    {
                        holiday.State =5;
                        holiday.Save();
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('您让申请人修正！');</script>");

                    }
                    else if (rblOver.Items[1].Selected)
                    {
                        holiday.State = 4;
                        holiday.Save();
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
