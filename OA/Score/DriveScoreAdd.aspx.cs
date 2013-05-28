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
    public partial class DriveScoreAdd : System.Web.UI.Page
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
                DriverScoreInfo ds = new DriverScoreInfo();
                ds.EmployeeId = emid;
                ds.YearId = Convert.ToInt32(ddlYear.SelectedValue);
                ds.MonthId = Convert.ToInt32(ddlMonth.SelectedValue);
                ds.DateSpan = ddlYear.SelectedItem.Text + "年" + ddlMonth.SelectedItem.Text + "月";
                ds.EvaluateLevelId = 6;
                ds.TotalScore = "待评";
                ds.IsSubmit = 0;

                ds.Selfds1 = Request.Form["Selfds1"].ToString();
                ds.Selfds2 = Request.Form["Selfds2"].ToString();
                ds.Selfds3 = Request.Form["Selfds3"].ToString();
                ds.Selfds4 = Request.Form["Selfds4"].ToString();
                ds.Selfds5 = Request.Form["Selfds5"].ToString();
                ds.Selfds6 = Request.Form["Selfds6"].ToString();
                ds.Selfds7 = Request.Form["Selfds7"].ToString();
                ds.Selfds8 = Request.Form["Selfds8"].ToString();
                ds.Selfds9 = Request.Form["Selfds9"].ToString();
                ds.Selfds10 = Request.Form["Selfds10"].ToString();
                ds.Selfds11 = Request.Form["Selfds11"].ToString();
                ds.Selfds12 = Request.Form["Selfds12"].ToString();
                ds.Selfds13 = Request.Form["Selfds13"].ToString();
                ds.Selfds14 = Request.Form["Selfds14"].ToString();
                ds.Selfds15 = Request.Form["Selfds15"].ToString();
                ds.Selfds16 = Request.Form["Selfds16"].ToString();
                ds.Selfds17 = Request.Form["Selfds17"].ToString();
                ds.Selfds18 = Request.Form["Selfds18"].ToString();
                ds.Selfds19 = Request.Form["Selfds19"].ToString();
                ds.Selfds20 = Request.Form["Selfds20"].ToString();
                ds.Selfds21 = Request.Form["Selfds21"].ToString();
                ds.Selfds22 = Request.Form["Selfds22"].ToString();
                ds.Selfds23 = Request.Form["Selfds23"].ToString();
                ds.Save();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('保存成功！');</script>");

            }
           
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("DriveScoregv.aspx");
        }
    }
}
