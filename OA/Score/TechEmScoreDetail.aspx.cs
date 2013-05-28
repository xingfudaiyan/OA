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
    public partial class TechEmScoreDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PageInit();
                ViewState["BackUrl"] = Request.UrlReferrer.ToString();
            }
        }

      


        protected void PageInit()
        {
            int TesId = Convert.ToInt32(Request["TechEmScoreId"].ToString());
            TechEmScoreInfo tes = new TechEmScoreInfo(TesId);
            lblSelfPlan.Text=tes.SelfPlan.ToString();
            lblSelfWorkTotal.Text = tes.SelfWorkTotal.ToString();
            lblSelfWorkSpeed.Text = tes.SelfWorkSpeed.ToString();
            lblSelfCommunicate.Text = tes.SelfCommunicate.ToString();
            lblSelfDescipline.Text = tes.SelfDescipline.ToString();
            lblSelfExecute.Text = tes.SelfExecute.ToString();
            lblSelfRoute.Text = tes.SelfRoute.ToString();
            lblSelfProfession.Text = tes.SelfProfession.ToString();
            lblSelfAttitude.Text = tes.SelfAttitude.ToString();
            lblSelfComplex.Text = tes.SelfComplex.ToString();
            lblSelfSpeciality.Text = tes.SelfSpeciality.ToString();

            lblUpPlan.Text = tes.UpPlan.ToString();
            lblUpWorkTotal.Text = tes.UpWorkTotal.ToString();
            lblUpWorkSpeed.Text = tes.UpWorkSpeed.ToString();
            lblUpCommunicate.Text = tes.UpCommunicate.ToString();
            lblUpDescipline.Text = tes.UpDescipline.ToString();
            lblUpExecute.Text = tes.UpExecute.ToString();
            lblUpRoute.Text = tes.UpRoute.ToString();
            lblUpProfession.Text = tes.UpProfession.ToString();
            lblUpAttitude.Text = tes.UpAttitude.ToString();
            lblUpComplex.Text = tes.UpComplex.ToString();
            lblUpSpeciality.Text = tes.UpSpeciality.ToString();

            lblSecPlan.Text = tes.SectPlan.ToString();
            lblSecWorkTotal.Text = tes.SectWorkTotal.ToString();
            lblSecWorkSpeed.Text = tes.SectWorkSpeed.ToString();
            lblSecCommunicate.Text = tes.SectCommunicate.ToString();
            lblSecDescipline.Text = tes.SectDescipline.ToString();
            lblSecExecute.Text = tes.SectExecute.ToString();
            lblSecRoute.Text = tes.SectRoute.ToString();
            lblSecProfession.Text = tes.SectProfession.ToString();
            lblSecAttitude.Text = tes.SectAttitude.ToString();
            lblSecComplex.Text = tes.SectComplex.ToString();
            lblSecSpeciality.Text = tes.SectSpeciality.ToString();

            //ddlYear.SelectedValue = tes.YearId.ToString();
            //ddlMonth.SelectedValue = tes.MonthId.ToString();

            YearInfo year = new YearInfo(Convert.ToInt32(tes.YearId));
            MonthInfo month = new MonthInfo(Convert.ToInt32(tes.MonthId));
            lblDate.Text = year.YearName + "Äê" + month.MonthNames + "ÔÂ";

            EmployeeInfo em = new EmployeeInfo(Convert.ToInt32(tes.EmployeeId));
            lblName.Text = em.EmployeeName.ToString();
            PositionInfo position = new PositionInfo(Convert.ToInt32(Convert.ToInt32(em.PositionId)));
            lblPosition.Text = position.PositionName;

            lblReason.Text = tes.Reason.ToString();
            lblAddMinusScore.Text = tes.AddMinusSocre.ToString();
            lblSumScore.Text = tes.TotalScore.ToString();
            lblViews.Text = tes.UpViews.ToString();
            EvaluateLevelInfo el = new EvaluateLevelInfo(Convert.ToInt32(tes.EvaluateLevelId));
            lblLevels.Text = el.EvaluateName.ToString();

            lblPlan.Text = tes.PlanFinish.ToString();
            lblActual.Text = tes.ActualFinish.ToString();
            lblPercent.Text = tes.FinishRate.ToString();
            lblUp.Text = tes.FinishScore.ToString();
            lblUp1.Text = tes.FinishScore.ToString();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(ViewState["BackUrl"].ToString());
        }
    }
}
