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
    public partial class TechMaScoreEdit : System.Web.UI.Page
    {
        public string strbind1;
        public string strbind2;
        public string strbind3;
        public string strbind4;
        public string strbind5;
        public string strbind6;
        public string strbind7;
        public string strbind8;
        public string strbind9;
        public string strbind10;
        public string strbind11;
        public string strbind12;
        public string strbind13;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PageInit();
                ddlDataBind();
            }
        }

        protected void PageInit()
        {
            int TesId = Convert.ToInt32(Request["TechMaScoreId"].ToString());
            TechMaScoreInfo tms = new TechMaScoreInfo(TesId);
            strbind1 = tms.SelfScore1.ToString();
            strbind2 = tms.SelfScore2.ToString();
            strbind3 = tms.SelfScore3.ToString();
            strbind4 = tms.SelfScore4.ToString();
            strbind5 = tms.SelfScore5.ToString();
            strbind6 = tms.SelfScore6.ToString();
            strbind7 = tms.SelfScore7.ToString();
            strbind8 = tms.SelfScore8.ToString();
            strbind9 = tms.SelfScore9.ToString();
            strbind10 = tms.SelfScore10.ToString();
            strbind11 = tms.SelfScore11.ToString();
            strbind12 = tms.SelfScore12.ToString();
            strbind13 = tms.SelfScore13.ToString();

            ddlYear.SelectedValue = tms.YearId.ToString();
            ddlMonth.SelectedValue = tms.MonthId.ToString();

            EmployeeInfo em = new EmployeeInfo(Convert.ToInt32(tms.EmployeeId));
            lblName.Text = em.EmployeeName.ToString();
            PositionInfo position = new PositionInfo(Convert.ToInt32(Convert.ToInt32(em.PositionId)));
            lblPosition.Text = position.PositionName;
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
                int TesId = Convert.ToInt32(Request["TechMaScoreId"].ToString());
                TechMaScoreInfo tms = new TechMaScoreInfo(TesId);

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
