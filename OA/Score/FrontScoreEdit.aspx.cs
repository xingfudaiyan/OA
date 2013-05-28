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
    public partial class FrontScoreEdit : System.Web.UI.Page
    {
        public string Selffs1;
        public string Selffs2;
        public string Selffs3;
        public string Selffs4;
        public string Selffs5;
        public string Selffs6;
        public string Selffs7;
        public string Selffs8;
        public string Selffs9;
        public string Selffs10;
        public string Selffs11;
        public string Selffs12;
        public string Selffs13;
        public string Selffs14;
        public string Selffs15;
        public string Selffs16;
        public string Selffs17;
        public string Selffs18;
        public string Selffs19;
        public string Selffs20;
        public string Selffs21;

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
            int fsid = Convert.ToInt32(Request["FsScoreId"].ToString());
            FrontScoreInfo fs = new FrontScoreInfo(fsid);
            EmployeeInfo em = new EmployeeInfo(Convert.ToInt32(fs.EmployeeId));

            lblName.Text = em.EmployeeName.ToString();
            PositionInfo position = new PositionInfo(Convert.ToInt32(em.PositionId));
            lblPosition.Text = position.PositionName.ToString();
            DepartInfo depart = new DepartInfo(Convert.ToInt32(em.DepartId));
            lblDepart.Text = depart.DepartName.ToString();

            ddlYear.SelectedValue = fs.YearId.ToString();
            ddlMonth.SelectedValue = fs.MonthId.ToString();

            Selffs1 = fs.Selffs1.ToString();
            Selffs2 = fs.Selffs2.ToString();
            Selffs3 = fs.Selffs3.ToString();
            Selffs4 = fs.Selffs4.ToString();
            Selffs5 = fs.Selffs5.ToString();
            Selffs6 = fs.Selffs6.ToString();
            Selffs7 = fs.Selffs7.ToString();
            Selffs8 = fs.Selffs8.ToString();
            Selffs9 = fs.Selffs9.ToString();
            Selffs10 = fs.Selffs10.ToString();
            Selffs11 = fs.Selffs11.ToString();
            Selffs12 = fs.Selffs12.ToString();
            Selffs13 = fs.Selffs13.ToString();
            Selffs14 = fs.Selffs14.ToString();
            Selffs15 = fs.Selffs15.ToString();
            Selffs16 = fs.Selffs16.ToString();
            Selffs17 = fs.Selffs17.ToString();
            Selffs18 = fs.Selffs18.ToString();
            Selffs19 = fs.Selffs19.ToString();
            Selffs20 = fs.Selffs20.ToString();
            Selffs21 = fs.Selffs21.ToString();
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
                int fsid = Convert.ToInt32(Request.Form["FsScoreId"].ToString());
                FrontScoreInfo fs = new FrontScoreInfo(fsid);
                fs.YearId = Convert.ToInt32(ddlYear.SelectedValue);
                fs.MonthId = Convert.ToInt32(ddlMonth.SelectedValue);
                fs.DateSpan = ddlYear.SelectedItem.Text + "年" + ddlMonth.SelectedItem.Text + "月";

                fs.Selffs1 = Request.Form["Selffs1"].ToString();
                fs.Selffs2 = Request.Form["Selffs2"].ToString();
                fs.Selffs3 = Request.Form["Selffs3"].ToString();
                fs.Selffs4 = Request.Form["Selffs4"].ToString();
                fs.Selffs5 = Request.Form["Selffs5"].ToString();
                fs.Selffs6 = Request.Form["Selffs6"].ToString();
                fs.Selffs7 = Request.Form["Selffs7"].ToString();
                fs.Selffs8 = Request.Form["Selffs8"].ToString();
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
