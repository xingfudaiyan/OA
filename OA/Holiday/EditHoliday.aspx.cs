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
    public partial class EditHoliday : System.Web.UI.Page
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
            int hoid = Convert.ToInt32(Request["HolidayApplyId"].ToString());
            HolidayApplyInfo holiday = new HolidayApplyInfo(hoid);

            txtApplyDate.Text = holiday.ApplyDate.ToString();
            lblPosition.Text = holiday.PositonName.ToString();
            lblEmployeeName.Text = holiday.ApplyName.ToString();
            txtApplyCompany.Text = holiday.Company2.ToString();
            txtApplyName.Text = holiday.Company2Name.ToString();
            rblHoliydayType.SelectedValue = holiday.HolidayTypeId.ToString();
            txtBeginTime.Text = holiday.BeginTime.ToString();
            txtEndTime.Text = holiday.EndTime.ToString();
            txtTimeSum.Text = holiday.TimeSum.ToString();
            txtReason.Text = holiday.Reason.ToString();
            txtUperView.Text = holiday.SectionView.ToString();
            txtMemo.Text = holiday.Memo.ToString();
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
             try
                {
                   
                    int hoid = Convert.ToInt32(Request["HolidayApplyId"].ToString());
                    HolidayApplyInfo holiday=new HolidayApplyInfo(hoid);
                
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
                            holiday.Save();
                            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('编辑成功！');</script>");
                    
                }
                catch (Exception Ex)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Save", "alert('保存失败：" + Ex.Message + "');", true);
                }
            }
        

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(ViewState["BackUrl"].ToString());
        }
   }
}
