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
    public partial class BASEmScoreEdit : System.Web.UI.Page
    {
        public string Selfbas1;
        public string Selfbas2;
        public string Selfbas3;
        public string Selfbas4;
        public string Selfbas5;
        public string Selfbas6;
        public string Selfbas7;
        public string Selfbas8;
        public string Selfbas9;
        public string Selfbas10;
        public string Selfbas11;
        public string Selfbas12;
        public string Selfbas13;
        public string Selfbas14;
        public string Selfbas15;
        public string Selfbas16;
        public string Selfbas17;

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
            int besid = Convert.ToInt32(Request["BasEmScoreId"].ToString());
            BasEmScoreInfo bes = new BasEmScoreInfo(besid);
            EmployeeInfo em = new EmployeeInfo(Convert.ToInt32(bes.EmployeeId));

            lblName.Text = em.EmployeeName.ToString();
            PositionInfo position = new PositionInfo(Convert.ToInt32(em.PositionId));
            lblPosition.Text = position.PositionName.ToString();
            DepartInfo depart = new DepartInfo(Convert.ToInt32(em.DepartId));
            lblDepart.Text = depart.DepartName.ToString();

            ddlYear.SelectedValue = bes.YearId.ToString();
            ddlMonth.SelectedValue = bes.MonthId.ToString();

            Selfbas1 = bes.Selfbas1.ToString();
            Selfbas2 = bes.Selfbas2.ToString();
            Selfbas3 = bes.Selfbas3.ToString();
            Selfbas4 = bes.Selfbas4.ToString();
            Selfbas5 = bes.Selfbas5.ToString();
            Selfbas6 = bes.Selfbas6.ToString();
            Selfbas7 = bes.Selfbas7.ToString();
            Selfbas8 = bes.Selfbas8.ToString();
            Selfbas9 = bes.Selfbas9.ToString();
            Selfbas10 = bes.Selfbas10.ToString();
            Selfbas11 = bes.Selfbas11.ToString();
            Selfbas12 = bes.Selfbas12.ToString();
            Selfbas13 = bes.Selfbas13.ToString();
            Selfbas14 = bes.Selfbas14.ToString();
            Selfbas15 = bes.Selfbas15.ToString();
            Selfbas16 = bes.Selfbas16.ToString();
            Selfbas17 = bes.Selfbas17.ToString();
           
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
                int besid = Convert.ToInt32(Request["BasEmScoreId"].ToString());
                BasEmScoreInfo bes = new BasEmScoreInfo(besid);
                bes.DateSpan = ddlYear.SelectedItem.Text + "年" + ddlMonth.SelectedItem.Text + "月";
                bes.YearId = Convert.ToInt32(ddlYear.SelectedValue);
                bes.MonthId = Convert.ToInt32(ddlMonth.SelectedValue);
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
