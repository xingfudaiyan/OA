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
    public partial class BASEmScoreAdd : System.Web.UI.Page
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
                BasEmScoreInfo bes = new BasEmScoreInfo();
                bes.EmployeeId = emid;
                bes.DateSpan = ddlYear.SelectedItem.Text + "年" + ddlMonth.SelectedItem.Text + "月";
                bes.YearId = Convert.ToInt32(ddlYear.SelectedValue);
                bes.MonthId = Convert.ToInt32(ddlMonth.SelectedValue);
                bes.EvaluateLevelId = 6;
                bes.TotalScore = "待评";
                bes.IsSubmit = 0;
                bes.Selfbas1 = Request.Form["iSelfbas1"].ToString();
                bes.Selfbas2 = Request.Form["iSelfbas2"].ToString();
                bes.Selfbas3 = Request.Form["iSelfbas3"].ToString();
                bes.Selfbas4 = Request.Form["iSelfbas4"].ToString();
                bes.Selfbas5 = Request.Form["iSelfbas5"].ToString();
                bes.Selfbas6 = Request.Form["iSelfbas6"].ToString();
                bes.Selfbas7 = Request.Form["iSelfbas7"].ToString();
                bes.Selfbas8 = Request.Form["iSelfbas8"].ToString();
                bes.Selfbas9 = Request.Form["iSelfbas9"].ToString();
                bes.Selfbas10 = Request.Form["iSelfbas10"].ToString();
                bes.Selfbas11 = Request.Form["iSelfbas11"].ToString();
                bes.Selfbas12 = Request.Form["iSelfbas12"].ToString();
                bes.Selfbas13 = Request.Form["iSelfbas13"].ToString();
                bes.Selfbas14 = Request.Form["iSelfbas14"].ToString();
                bes.Selfbas15 = Request.Form["iSelfbas15"].ToString();
                bes.Selfbas16 = Request.Form["iSelfbas16"].ToString();
                bes.Selfbas17 = Request.Form["iSelfbas17"].ToString();
                bes.Save();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('保存成功！');</script>");

            }
           
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("BASEmScoregv.aspx");
        }
    }
}
