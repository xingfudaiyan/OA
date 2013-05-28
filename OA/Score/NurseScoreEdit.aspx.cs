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
    public partial class NurseScoreEdit : System.Web.UI.Page
    {
        public string Selfns1;
        public string Selfns2;
        public string Selfns3;
        public string Selfns4;
        public string Selfns5;
        public string Selfns6;
        public string Selfns7;
        public string Selfns8;
        public string Selfns9;
        public string Selfns10;
        public string Selfns11;
        public string Selfns12;
        public string Selfns13;
        public string Selfns14;
        public string Selfns15;
        public string Selfns16;
        public string Selfns17;
        public string Selfns18;
        public string Selfns19;
        public string Selfns20;
        public string Selfns21;
        public string Selfns22;
        public string Selfns23;
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
            int nsid = Convert.ToInt32(Request["NsScoreId"].ToString());
            NurseScoreInfo ns = new NurseScoreInfo(nsid);
            EmployeeInfo em = new EmployeeInfo(Convert.ToInt32(ns.EmployeeId));

            lblName.Text = em.EmployeeName.ToString();
            PositionInfo position = new PositionInfo(Convert.ToInt32(em.PositionId));
            lblPosition.Text = position.PositionName.ToString();
            DepartInfo depart = new DepartInfo(Convert.ToInt32(em.DepartId));
            lblDepart.Text = depart.DepartName.ToString();

            ddlYear.SelectedValue = ns.YearId.ToString();
            ddlMonth.SelectedValue = ns.MonthId.ToString();

            Selfns1 = ns.Selfns1.ToString();
            Selfns2 = ns.Selfns2.ToString();
            Selfns3 = ns.Selfns3.ToString();
            Selfns4 = ns.Selfns4.ToString();
            Selfns5 = ns.Selfns5.ToString();
            Selfns6 = ns.Selfns6.ToString();
            Selfns7 = ns.Selfns7.ToString();
            Selfns8 = ns.Selfns8.ToString();
            Selfns9 = ns.Selfns9.ToString();
            Selfns10 = ns.Selfns10.ToString();
            Selfns11 = ns.Selfns11.ToString();
            Selfns12 = ns.Selfns12.ToString();
            Selfns13 = ns.Selfns13.ToString();
            Selfns14 = ns.Selfns14.ToString();
            Selfns15 = ns.Selfns15.ToString();
            Selfns16 = ns.Selfns16.ToString();
            Selfns17 = ns.Selfns17.ToString();
            Selfns18 = ns.Selfns18.ToString();
            Selfns19 = ns.Selfns19.ToString();
            Selfns20 = ns.Selfns20.ToString();
            Selfns21 = ns.Selfns21.ToString();
            Selfns22 = ns.Selfns22.ToString();
            Selfns23 = ns.Selfns23.ToString();
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
                int nsid = Convert.ToInt32(Request.Form["NsScoreId"].ToString());
                NurseScoreInfo ns = new NurseScoreInfo(nsid);
                ns.YearId = Convert.ToInt32(ddlYear.SelectedValue);
                ns.MonthId = Convert.ToInt32(ddlMonth.SelectedValue);
                ns.DateSpan = ddlYear.SelectedItem.Text + "年" + ddlMonth.SelectedItem.Text + "月";

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
