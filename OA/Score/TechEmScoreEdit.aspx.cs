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
    public partial class TechEmScoreEdit : System.Web.UI.Page
    {
        public string selfplan;
        public string selfworktotal;
        public string selfworkspeed;
        public string selfcommunicate;
        public string selfdescipline;
        public string selfexecute;
        public string selfroute;
        public string selfprofession;
        public string selfattitude;
        public string selfcomplex;
        public string selfspeciality;
       
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

        public void PageInit()
        {
           int TesId = Convert.ToInt32(Request["TechEmScoreId"].ToString());
           TechEmScoreInfo tes = new TechEmScoreInfo(TesId);
           selfplan = tes.SelfPlan.ToString();
           selfworktotal = tes.SelfWorkTotal.ToString();
           selfworkspeed = tes.SelfWorkSpeed.ToString();
           selfcommunicate = tes.SelfCommunicate.ToString();
           selfdescipline = tes.SelfDescipline.ToString();
           selfexecute = tes.SelfExecute.ToString();
           selfroute = tes.SelfRoute.ToString();
           selfprofession = tes.SelfProfession.ToString();
           selfattitude = tes.SelfAttitude.ToString();
           selfcomplex = tes.SelfComplex.ToString();
           selfspeciality = tes.SelfSpeciality.ToString();
           ddlYear.SelectedValue = tes.YearId.ToString();
           ddlMonth.SelectedValue = tes.MonthId.ToString();

           EmployeeInfo em = new EmployeeInfo(Convert.ToInt32(tes.EmployeeId));
           lblName.Text = em.EmployeeName.ToString();
           PositionInfo position = new PositionInfo(Convert.ToInt32(Convert.ToInt32(em.PositionId)));
           lblPosition.Text = position.PositionName;

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
                int TesId = Convert.ToInt32(Request["TechEmScoreId"].ToString());
                TechEmScoreInfo tes = new TechEmScoreInfo(TesId);

                tes.DateSpan = ddlYear.SelectedItem.Text + "年" + ddlMonth.SelectedItem.Text + "月";
                tes.YearId = Convert.ToInt32(ddlYear.SelectedValue.ToString());
                tes.MonthId = Convert.ToInt32(ddlMonth.SelectedValue.ToString());
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
