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

namespace OA.Score
{
    public partial class AsistantScoreAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlDataBind();
                PageInit();
            }
        }

        protected void ddlDataBind()
        {
            DataTable dt = TechEmScoreInfo.getYearddl();
            ddlYear.DataSource = dt;
            ddlYear.DataTextField = "YearName";
            ddlYear.DataValueField = "YearId";
            DataRow row = dt.NewRow();
            row["YearName"] = "请选择年份";
            dt.Rows.InsertAt(row, 0);
            ddlYear.DataBind();

            DataTable dt1 = TechEmScoreInfo.getMonthddl();
            ddlMonth.DataSource = dt1;
            ddlMonth.DataTextField = "MonthNames";
            ddlMonth.DataValueField = "MonthId";
            DataRow row1 = dt1.NewRow();
            row1["MonthNames"] = "请选择月份";
            dt1.Rows.InsertAt(row1, 0);
            ddlMonth.DataBind();
        }

        protected void PageInit()
        {
            EmployeeInfo em = (EmployeeInfo)Session["Employee"];
            lblName.Text = em.EmployeeName.ToString();
            PositionInfo position = new PositionInfo(Convert.ToInt32(em.PositionId));
            lblPosition.Text = position.PositionName.ToString();
            DepartInfo depart = new DepartInfo(Convert.ToInt32(em.DepartId));
            lblDepart.Text = depart.DepartName.ToString();
        }

        protected bool IsPageValid()
        {
            if (ddlYear.SelectedValue.ToString() == "" || ddlMonth.SelectedValue.ToString() == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('请选择时间！');</script>");
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
                int emid = Convert.ToInt32(Session["EmployeeId"]);
                AssistantScoreInfo at = new AssistantScoreInfo();
                at.EmployeeId = emid;
                at.YearId = Convert.ToInt32(ddlYear.SelectedValue);
                at.MonthId = Convert.ToInt32(ddlMonth.SelectedValue);
                at.DateSpan = ddlYear.SelectedItem.Text + "年" + ddlMonth.SelectedItem.Text + "月";
                at.EvaluateLevelId = 6;
                at.TotalScore = "待评";
                at.IsSubmit = 0;

                at.Selfas1 = Request.Form["Selfas1"].ToString();
                at.Selfas2 = Request.Form["Selfas2"].ToString();
                at.Selfas3 = Request.Form["Selfas3"].ToString();
                at.Selfas4 = Request.Form["Selfas4"].ToString();
                at.Selfas5 = Request.Form["Selfas5"].ToString();
                at.Selfas6 = Request.Form["Selfas6"].ToString();
                at.Selfas7 = Request.Form["Selfas7"].ToString();
                at.Selfas8 = Request.Form["Selfas8"].ToString();
                at.Selfas9 = Request.Form["Selfas9"].ToString();
                at.Selfas10 = Request.Form["Selfas10"].ToString();
                at.Selfas11 = Request.Form["Selfas11"].ToString();
                at.Selfas12 = Request.Form["Selfas12"].ToString();
                at.Selfas13 = Request.Form["Selfas13"].ToString();
                at.Selfas14 = Request.Form["Selfas14"].ToString();
                at.Selfas15 = Request.Form["Selfas15"].ToString();
                at.Selfas16 = Request.Form["Selfas16"].ToString();
                at.Selfas17 = Request.Form["Selfas17"].ToString();
                at.Selfas18 = Request.Form["Selfas18"].ToString();
                at.Selfas19 = Request.Form["Selfas19"].ToString();
                at.Save();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('保存成功！');</script>");
            }
          
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("AsistantScoregv.aspx");
        }
    }
}
