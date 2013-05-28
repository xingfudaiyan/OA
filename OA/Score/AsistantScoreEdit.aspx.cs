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
    public partial class AsistantScoreEdit : System.Web.UI.Page
    {
        public string Selfas1;
        public string Selfas2;
        public string Selfas3;
        public string Selfas4;
        public string Selfas5;
        public string Selfas6;
        public string Selfas7;
        public string Selfas8;
        public string Selfas9;
        public string Selfas10;
        public string Selfas11;
        public string Selfas12;
        public string Selfas13;
        public string Selfas14;
        public string Selfas15;
        public string Selfas16;
        public string Selfas17;
        public string Selfas18;
        public string Selfas19;
       
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
            int asid = Convert.ToInt32(Request["AsScoreId"].ToString());
            AssistantScoreInfo fs = new AssistantScoreInfo(asid);
            EmployeeInfo em = new EmployeeInfo(Convert.ToInt32(fs.EmployeeId));

            lblName.Text = em.EmployeeName.ToString();
            PositionInfo position = new PositionInfo(Convert.ToInt32(em.PositionId));
            lblPosition.Text = position.PositionName.ToString();
            DepartInfo depart = new DepartInfo(Convert.ToInt32(em.DepartId));
            lblDepart.Text = depart.DepartName.ToString();

            ddlYear.SelectedValue = fs.YearId.ToString();
            ddlMonth.SelectedValue = fs.MonthId.ToString();

            Selfas1 = fs.Selfas1.ToString();
            Selfas2 = fs.Selfas2.ToString();
            Selfas3 = fs.Selfas3.ToString();
            Selfas4 = fs.Selfas4.ToString();
            Selfas5 = fs.Selfas5.ToString();
            Selfas6 = fs.Selfas6.ToString();
            Selfas7 = fs.Selfas7.ToString();
            Selfas8 = fs.Selfas8.ToString();
            Selfas9 = fs.Selfas9.ToString();
            Selfas10 = fs.Selfas10.ToString();
            Selfas11 = fs.Selfas11.ToString();
            Selfas12 = fs.Selfas12.ToString();
            Selfas13 = fs.Selfas13.ToString();
            Selfas14 = fs.Selfas14.ToString();
            Selfas15 = fs.Selfas15.ToString();
            Selfas16 = fs.Selfas16.ToString();
            Selfas17 = fs.Selfas17.ToString();
            Selfas18 = fs.Selfas18.ToString();
            Selfas19 = fs.Selfas19.ToString();
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
                int fsid = Convert.ToInt32(Request.Form["AsScoreId"].ToString());
                AssistantScoreInfo fs = new AssistantScoreInfo(fsid);
                fs.YearId = Convert.ToInt32(ddlYear.SelectedValue);
                fs.MonthId = Convert.ToInt32(ddlMonth.SelectedValue);
                fs.DateSpan = ddlYear.SelectedItem.Text + "年" + ddlMonth.SelectedItem.Text + "月";

                fs.Selfas1 = Request.Form["Selfas1"].ToString();
                fs.Selfas2 = Request.Form["Selfas2"].ToString();
                fs.Selfas3 = Request.Form["Selfas3"].ToString();
                fs.Selfas4 = Request.Form["Selfas4"].ToString();
                fs.Selfas5 = Request.Form["Selfas5"].ToString();
                fs.Selfas6 = Request.Form["Selfas6"].ToString();
                fs.Selfas7 = Request.Form["Selfas7"].ToString();
                fs.Selfas8 = Request.Form["Selfas8"].ToString();
                fs.Selfas9 = Request.Form["Selfas9"].ToString();
                fs.Selfas10 = Request.Form["Selfas10"].ToString();
                fs.Selfas11 = Request.Form["Selfas11"].ToString();
                fs.Selfas12 = Request.Form["Selfas12"].ToString();
                fs.Selfas13 = Request.Form["Selfas13"].ToString();
                fs.Selfas14 = Request.Form["Selfas14"].ToString();
                fs.Selfas15 = Request.Form["Selfas15"].ToString();
                fs.Selfas16 = Request.Form["Selfas16"].ToString();
                fs.Selfas17 = Request.Form["Selfas17"].ToString();
                fs.Selfas18 = Request.Form["Selfas18"].ToString();
                fs.Selfas19 = Request.Form["Selfas19"].ToString();
                fs.Save();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('保存成功！');</script>");
            }
          
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("AsistantScoregv.aspx");
        }
    }
}
