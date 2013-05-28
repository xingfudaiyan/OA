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
    public partial class NurseScoreAdd : System.Web.UI.Page
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
                NurseScoreInfo ns = new NurseScoreInfo();
                ns.EmployeeId = emid;
                ns.YearId = Convert.ToInt32(ddlYear.SelectedValue);
                ns.MonthId = Convert.ToInt32(ddlMonth.SelectedValue);
                ns.DateSpan = ddlYear.SelectedItem.Text + "年" + ddlMonth.SelectedItem.Text + "月";
                ns.EvaluateLevelId = 6;
                ns.TotalScore = "待评";
                ns.IsSubmit = 0;

                ns.Selfns1 = Request.Form["Selfns1"].ToString();
                ns.Selfns2 = Request.Form["Selfns2"].ToString();
                ns.Selfns3 = Request.Form["Selfns3"].ToString();
                ns.Selfns4 = Request.Form["Selfns4"].ToString();
                ns.Selfns5 = Request.Form["Selfns5"].ToString();
                ns.Selfns6 = Request.Form["Selfns6"].ToString();
                ns.Selfns7 = Request.Form["Selfns7"].ToString();
                ns.Selfns8 = Request.Form["Selfns8"].ToString();
                ns.Selfns9 = Request.Form["Selfns9"].ToString();
                ns.Selfns10 = Request.Form["Selfns10"].ToString();
                ns.Selfns11 = Request.Form["Selfns11"].ToString();
                ns.Selfns12 = Request.Form["Selfns12"].ToString();
                ns.Selfns13 = Request.Form["Selfns13"].ToString();
                ns.Selfns14 = Request.Form["Selfns14"].ToString();
                ns.Selfns15 = Request.Form["Selfns15"].ToString();
                ns.Selfns16 = Request.Form["Selfns16"].ToString();
                ns.Selfns17 = Request.Form["Selfns17"].ToString();
                ns.Selfns18 = Request.Form["Selfns18"].ToString();
                ns.Selfns19 = Request.Form["Selfns19"].ToString();
                ns.Selfns20 = Request.Form["Selfns20"].ToString();
                ns.Selfns21 = Request.Form["Selfns21"].ToString();
                ns.Selfns22 = Request.Form["Selfns22"].ToString();
                ns.Selfns23 = Request.Form["Selfns23"].ToString();
                ns.Save();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('保存成功！');</script>");
            }
           
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("NurseScoregv.aspx");
        }
    }
}
