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
    public partial class AddHoliday : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PageInit();
                rblDataBind();
                ViewState["BackUrl"] = Request.UrlReferrer.ToString();
            }
        }

        protected void PageInit()
        {
            string strRoleName = Session["RoleName"].ToString();

            txtApplyDate.Text = DateTime.Now.ToString();
            lblEmployeeName.Text = Session["EmployeeName"].ToString();
            PositionInfo position = new PositionInfo(Convert.ToInt32(Session["PositionId"].ToString()));
            lblPosition.Text = position.PositionName.ToString();
        }

        protected void rblDataBind()
        {
            DataTable dt = HolidayApplyInfo.getHolidayTypeList();
            rblHoliydayType.DataSource = dt;
            rblHoliydayType.DataTextField = "HolidayTypeName";
            rblHoliydayType.DataValueField = "HolidayTypeId";
            rblHoliydayType.DataBind();
        }

        protected bool IsPageValid()
        {
            if (rblHoliydayType.SelectedIndex == -1)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('请选择请假种类！');</script>");
                return false;
            }
            
            else
            {
                return true;
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsPageValid())
            {
                try
                {
                   

                    HolidayApplyInfo holiday = new HolidayApplyInfo();
                    holiday.ApplyDate = txtApplyDate.Text.ToString();
                    holiday.Company1 = lblCompany.Text.ToString();
                    holiday.PositonName = lblPosition.Text.ToString();
                    holiday.Company2 = txtApplyCompany.Text.ToString();
                    holiday.Company2Name = txtApplyName.Text.ToString();
                    holiday.HolidayTypeId = Convert.ToInt32(rblHoliydayType.SelectedValue.ToString());
                    holiday.BeginTime = txtBeginTime.Text.ToString();
                    holiday.EndTime = txtEndTime.Text.ToString();
                    holiday.TimeSum = txtTimeSum.Text.ToString();
                    holiday.Reason = txtReason.Text.ToString();
                    holiday.SectionView = txtUperView.Text.ToString();
                    holiday.HrView = txtHrView.Text.ToString();
                    holiday.ManagerView = txtManagerView.Text.ToString();
                    holiday.Memo = txtMemo.Text.ToString();

                    holiday.ApplyName = Session["EmployeeName"].ToString();
                    holiday.DepartName = Session["DepartName"].ToString();
                    holiday.State = 0;
                 
                    holiday.Save();
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('添加成功！');</script>");
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
