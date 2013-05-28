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
    public partial class MarketScoreAdd : System.Web.UI.Page
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
                MarketScoreInfo ms = new MarketScoreInfo();
                ms.EmployeeId = emid;
                ms.YearId = Convert.ToInt32(ddlYear.SelectedValue);
                ms.MonthId = Convert.ToInt32(ddlMonth.SelectedValue);
                ms.DateSpan = ddlYear.SelectedItem.Text + "年" + ddlMonth.SelectedItem.Text + "月";
                ms.EvaluateLevelId = 6;
                ms.TotalScore = "待评";
                ms.IsSubmit = 0;

                ms.Selfms1 = Request.Form["Selfms1"].ToString();
                ms.Selfms2 = Request.Form["Selfms2"].ToString();
                ms.Selfms3 = Request.Form["Selfms3"].ToString();
                ms.Selfms4 = Request.Form["Selfms4"].ToString();
                ms.Selfms5 = Request.Form["Selfms5"].ToString();
                ms.Selfms6 = Request.Form["Selfms6"].ToString();
                ms.Selfms7 = Request.Form["Selfms7"].ToString();
                ms.Selfms8 = Request.Form["Selfms8"].ToString();
                ms.Selfms9 = Request.Form["Selfms9"].ToString();
                ms.Selfms10 = Request.Form["Selfms10"].ToString();
                ms.Selfms11 = Request.Form["Selfms11"].ToString();
                ms.Selfms12 = Request.Form["Selfms12"].ToString();
                ms.Selfms13 = Request.Form["Selfms13"].ToString();
                ms.Selfms14 = Request.Form["Selfms14"].ToString();
                ms.Selfms15 = Request.Form["Selfms15"].ToString();
                ms.Selfms16 = Request.Form["Selfms16"].ToString();
                ms.Selfms17 = Request.Form["Selfms17"].ToString();
                ms.Selfms18 = Request.Form["Selfms18"].ToString();
                ms.Selfms19 = Request.Form["Selfms19"].ToString();
                ms.Selfms20 = Request.Form["Selfms20"].ToString();
                ms.Selfms21 = Request.Form["Selfms21"].ToString();
                ms.Selfms22 = Request.Form["Selfms22"].ToString();
                ms.Selfms23 = Request.Form["Selfms23"].ToString();
                ms.Selfms24 = Request.Form["Selfms24"].ToString();
                ms.Save();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('保存成功！');</script>");
            }
           
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("MarketScoregv.aspx");
        }
    }
}
