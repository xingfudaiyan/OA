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
    public partial class TechMaSocre : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlDataBind();
                PageInit();
            }
        }

        protected void PageInit()
        {
            EmployeeInfo em = (EmployeeInfo)Session["Employee"];
            lblName.Text = em.EmployeeName.ToString();
            PositionInfo position = new PositionInfo(Convert.ToInt32(em.PositionId));
            lblPosition.Text = position.PositionName.ToString();
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

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (ddlYear.SelectedValue == "" || ddlMonth.SelectedValue == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('请选择评价时间！');</script>");
            }
            else
            {
                int emid = Convert.ToInt32(Session["EmployeeId"]);
                TechMaScoreInfo tms = new TechMaScoreInfo();
                tms.EmployeeId = emid;
                tms.DateSpan = ddlYear.SelectedItem.Text + "年" + ddlMonth.SelectedItem.Text + "月";
                tms.YearId = Convert.ToInt32(ddlYear.SelectedValue.ToString());
                tms.MonthId = Convert.ToInt32(ddlMonth.SelectedValue.ToString());
                tms.SelfScore1 = Request.Form["Project1"].ToString();
                tms.SelfScore2 = Request.Form["Project2"].ToString();
                tms.SelfScore3 = Request.Form["Project3"].ToString();
                tms.SelfScore4 = Request.Form["Project4"].ToString();
                tms.SelfScore5 = Request.Form["Project5"].ToString();
                tms.SelfScore6 = Request.Form["Project6"].ToString();
                tms.SelfScore7 = Request.Form["Project7"].ToString();
                tms.SelfScore8 = Request.Form["Project8"].ToString();
                tms.SelfScore9 = Request.Form["Project9"].ToString();
                tms.SelfScore10 = Request.Form["Project10"].ToString();
                tms.SelfScore11 = Request.Form["Project11"].ToString();
                tms.SelfScore12 = Request.Form["Project12"].ToString();
                tms.SelfScore13 = Request.Form["Project13"].ToString();
                tms.EvaluateLevelId = 6;
                tms.IsSubmit = 0;
                tms.Save();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('保存成功！');</script>");
            }
           
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("TechMaScoreGv.aspx");
        }
    }
}
