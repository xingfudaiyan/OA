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
    public partial class FrontScoreAdd : System.Web.UI.Page
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
                FrontScoreInfo fs = new FrontScoreInfo();
                fs.EmployeeId = emid;
                fs.YearId = Convert.ToInt32(ddlYear.SelectedValue);
                fs.MonthId = Convert.ToInt32(ddlMonth.SelectedValue);
                fs.DateSpan = ddlYear.SelectedItem.Text + "年" + ddlMonth.SelectedItem.Text + "月";
                fs.EvaluateLevelId = 6;
                fs.TotalScore = "待评";
                fs.IsSubmit = 0;

                fs.Selffs1 = Request.Form["Selffs1"].ToString();
                fs.Selffs2 = Request.Form["Selffs2"].ToString();
                fs.Selffs3 = Request.Form["Selffs3"].ToString();
                fs.Selffs4 = Request.Form["Selffs4"].ToString();
                fs.Selffs5 = Request.Form["Selffs5"].ToString();
                fs.Selffs6 = Request.Form["Selffs6"].ToString();
                fs.Selffs7 = Request.Form["Selffs7"].ToString();
               
                fs.Selffs9 = Request.Form["Selffs9"].ToString();
                fs.Selffs10 = Request.Form["Selffs10"].ToString();
                fs.Selffs11 = Request.Form["Selffs11"].ToString();
                fs.Selffs12 = Request.Form["Selffs12"].ToString();
                fs.Selffs13 = Request.Form["Selffs13"].ToString();
                fs.Selffs14 = Request.Form["Selffs14"].ToString();
                fs.Selffs15 = Request.Form["Selffs15"].ToString();
                fs.Selffs16 = Request.Form["Selffs16"].ToString();
                fs.Selffs17 = Request.Form["Selffs17"].ToString();
                fs.Selffs18 = Request.Form["Selffs18"].ToString();
                fs.Selffs19 = Request.Form["Selffs19"].ToString();
                fs.Selffs20 = Request.Form["Selffs20"].ToString();
                fs.Selffs21 = Request.Form["Selffs21"].ToString();
                fs.Save();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('保存成功！');</script>");
            }
           
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrontScoregv.aspx");
        }
    }
}
