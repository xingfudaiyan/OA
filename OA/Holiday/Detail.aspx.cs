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
    public partial class Detail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["BackUrl"] = Request.UrlReferrer.ToString();
                rblDataBind();
                PageInit();
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

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect(ViewState["BackUrl"].ToString());

        }
    }

}
