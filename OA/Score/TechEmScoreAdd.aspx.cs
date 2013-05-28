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
    public partial class TechEmScore : System.Web.UI.Page
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
                TechEmScoreInfo tes = new TechEmScoreInfo();
                tes.EmployeeId = emid;
                tes.DateSpan = ddlYear.SelectedItem.Text + "年" + ddlMonth.SelectedItem.Text + "月";
                tes.SelfPlan = Request.Form["SelfPlan"].ToString();
                tes.SelfWorkTotal = Request.Form["SelfWorkTotal"].ToString();
                tes.SelfWorkSpeed = Request.Form["SelfWorkSpeed"].ToString();
                tes.SelfCommunicate = Request.Form["SelfCommunicate"].ToString();
                tes.SelfDescipline = Request.Form["SelfDescipline"].ToString();
                tes.SelfExecute = Request.Form["SelfExecute"].ToString();
                tes.SelfRoute = Request.Form["SelfRoute"].ToString();
                tes.SelfProfession = Request.Form["SelfProfession"].ToString();
                tes.SelfAttitude = Request.Form["SelfAttitude"].ToString();
                tes.SelfComplex = Request.Form["SelfComplex"].ToString();
                tes.SelfSpeciality = Request.Form["SelfSpeciality"].ToString();
                tes.YearId = Convert.ToInt32(ddlYear.SelectedValue.ToString());
                tes.MonthId = Convert.ToInt32(ddlMonth.SelectedValue.ToString());
                tes.EvaluateLevelId = 6;
                tes.TotalScore = "待评";
                tes.IsSubmit = 0;
                tes.Save();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('保存成功！');</script>");
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("TechEmScoregv.aspx");
        }
    }
}
