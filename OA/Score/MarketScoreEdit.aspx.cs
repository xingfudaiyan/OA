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
    public partial class MarketScoreEdit : System.Web.UI.Page
    {
        public string Selfms1;
        public string Selfms2;
        public string Selfms3;
        public string Selfms4;
        public string Selfms5;
        public string Selfms6;
        public string Selfms7;
        public string Selfms8;
        public string Selfms9;
        public string Selfms10;
        public string Selfms11;
        public string Selfms12;
        public string Selfms13;
        public string Selfms14;
        public string Selfms15;
        public string Selfms16;
        public string Selfms17;
        public string Selfms18;
        public string Selfms19;
        public string Selfms20;
        public string Selfms21;
        public string Selfms22;
        public string Selfms23;
        public string Selfms24;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
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
            int msid = Convert.ToInt32(Request["MsScoreId"].ToString());
            MarketScoreInfo ms = new MarketScoreInfo(msid);
            EmployeeInfo em = new EmployeeInfo(Convert.ToInt32(ms.EmployeeId));

            lblName.Text = em.EmployeeName.ToString();
            PositionInfo position = new PositionInfo(Convert.ToInt32(em.PositionId));
            lblPosition.Text = position.PositionName.ToString();
            

            ddlYear.SelectedValue = ms.YearId.ToString();
            ddlMonth.SelectedValue = ms.MonthId.ToString();

            Selfms1 = ms.Selfms1.ToString();
            Selfms2 = ms.Selfms2.ToString();
            Selfms3 = ms.Selfms3.ToString();
            Selfms4 = ms.Selfms4.ToString();
            Selfms5 = ms.Selfms5.ToString();
            Selfms6 = ms.Selfms6.ToString();
            Selfms7 = ms.Selfms7.ToString();
            Selfms8 = ms.Selfms8.ToString();
            Selfms9 = ms.Selfms9.ToString();
            Selfms10 = ms.Selfms10.ToString();
            Selfms11 = ms.Selfms11.ToString();
            Selfms12 = ms.Selfms12.ToString();
            Selfms13 = ms.Selfms13.ToString();
            Selfms14 = ms.Selfms14.ToString();
            Selfms15 = ms.Selfms15.ToString();
            Selfms16 = ms.Selfms16.ToString();
            Selfms17 = ms.Selfms17.ToString();
            Selfms18 = ms.Selfms18.ToString();
            Selfms19 = ms.Selfms19.ToString();
            Selfms20 = ms.Selfms20.ToString();
            Selfms21 = ms.Selfms21.ToString();
            Selfms22 = ms.Selfms22.ToString();
            Selfms23 = ms.Selfms23.ToString();
            Selfms24 = ms.Selfms24.ToString();
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
                int msid = Convert.ToInt32(Request.Form["MsScoreId"].ToString());
                MarketScoreInfo ms = new MarketScoreInfo(msid);
                ms.YearId = Convert.ToInt32(ddlYear.SelectedValue);
                ms.MonthId = Convert.ToInt32(ddlMonth.SelectedValue);
                ms.DateSpan = ddlYear.SelectedItem.Text + "年" + ddlMonth.SelectedItem.Text + "月";

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
            Response.Redirect("MarketSocregv.aspx");
        }
    }
}
