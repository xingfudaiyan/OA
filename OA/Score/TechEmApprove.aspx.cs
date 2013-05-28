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
    public partial class TechMaApprove : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PageInit();
            }
        }

       
        protected void PageInit()
        {
            int tmsid = Convert.ToInt32(Request["TechEmScoreId"].ToString());
            TechEmScoreInfo tms = new TechEmScoreInfo(tmsid);
            lblSelfPlan.Text = tms.SelfPlan.ToString();
            lblSelfWorkTotal.Text = tms.SelfWorkTotal.ToString();
            lblSelfWorkSpeed.Text = tms.SelfWorkSpeed.ToString();
            lblSelfCommunicate.Text = tms.SelfCommunicate.ToString();
            lblSelfDescipline.Text = tms.SelfDescipline.ToString();
            lblSelfExecute.Text = tms.SelfExecute.ToString();
            lblSelfRoute.Text = tms.SelfRoute.ToString();
            lblSelfProfession.Text = tms.SelfProfession.ToString();
            lblSelfAttitude.Text = tms.SelfAttitude.ToString();
            lblSelfComplex.Text = tms.SelfComplex.ToString();
            lblSelfSpeciality.Text = tms.SelfSpeciality.ToString();

            //ddlYear.SelectedValue = tms.YearId.ToString();
            //ddlMonth.SelectedValue = tms.MonthId.ToString();

            YearInfo year = new YearInfo(Convert.ToInt32(tms.YearId));
            MonthInfo month = new MonthInfo(Convert.ToInt32(tms.MonthId));
            lblDate.Text = year.YearName + "年" + month.MonthNames + "月";

            EmployeeInfo em = new EmployeeInfo(Convert.ToInt32(tms.EmployeeId));
            lblName.Text = em.EmployeeName.ToString();
            PositionInfo position = new PositionInfo(Convert.ToInt32(Convert.ToInt32(em.PositionId)));
            lblPosition.Text = position.PositionName;
            rblAddScore.SelectedValue = "0";
            
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            int tmsid = Convert.ToInt32(Request["TechEmScoreId"].ToString());
            TechEmScoreInfo tms = new TechEmScoreInfo(tmsid);

            tms.PlanFinish = Request.Form["iPlanFinish"].ToString();
            tms.ActualFinish = Request.Form["iActualFinish"].ToString();
            tms.FinishRate = Convert.ToString(float.Parse(Request.Form["iActualFinish"].ToString()) / float.Parse(Request.Form["iPlanFinish"].ToString()));

            tms.FinishScore = Request.Form["iUp"].ToString();
            tms.UpPlan = Request.Form["Upplan"].ToString();
            tms.UpWorkTotal = Request.Form["UpWorkTotal"].ToString();
            tms.UpWorkSpeed = Request.Form["UpWorkSpeed"].ToString();
            tms.UpCommunicate = Request.Form["UpCommunicate"].ToString();
            tms.UpDescipline = Request.Form["UpDescipline"].ToString();
            tms.UpExecute = Request.Form["UpExecute"].ToString();
            tms.UpRoute = Request.Form["UpRoute"].ToString();
            tms.UpProfession = Request.Form["UpProfession"].ToString();
            tms.UpAttitude = Request.Form["UpAttitude"].ToString();
            tms.UpComplex = Request.Form["UpComplex"].ToString();
            tms.UpSpeciality = Request.Form["UpSpeciality"].ToString();

            tms.SectPlan = Convert.ToString(Math.Round(float.Parse(lblSelfPlan.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upplan"].ToString()), 2)* 0.6);
            tms.SectWorkTotal =Convert.ToString( Math.Round(float.Parse(lblSelfWorkTotal.Text.ToString()), 2) * 0.4 +Math.Round(float.Parse(Request.Form["UpWorkTotal"].ToString()), 2) * 0.6) ;
            tms.SectWorkSpeed =Convert.ToString(Math.Round(float.Parse(lblSelfWorkSpeed.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["UpWorkSpeed"].ToString()), 2)* 0.6) ;
            tms.SectCommunicate =Convert.ToString(Math.Round(float.Parse(lblSelfCommunicate.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["UpCommunicate"].ToString()), 2)* 0.6) ;
            tms.SectDescipline =Convert.ToString(Math.Round(float.Parse(lblSelfDescipline.Text.ToString()), 2) * 0.4 +Math.Round(float.Parse(Request.Form["UpDescipline"].ToString()), 2)* 0.6) ;
            tms.SectExecute =Convert.ToString(Math.Round(float.Parse(lblSelfExecute.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["UpExecute"].ToString()), 2) * 0.6) ;
            tms.SectRoute =Convert.ToString(Math.Round(float.Parse(lblSelfRoute.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["UpRoute"].ToString()), 2) * 0.6);
            tms.SectProfession =Convert.ToString(Math.Round(float.Parse(lblSelfProfession.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["UpProfession"].ToString()), 2) * 0.6) ;
            tms.SectAttitude =Convert.ToString(Math.Round(float.Parse(lblSelfAttitude.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["UpAttitude"].ToString()), 2)  * 0.6) ;
            tms.SectComplex =Convert.ToString(Math.Round(float.Parse(lblSelfComplex.Text.ToString()), 2) * 0.4 * 0.4 + Math.Round(float.Parse(Request.Form["UpComplex"].ToString()), 2)  * 0.6) ;
            tms.SectSpeciality = Convert.ToString(Math.Round(float.Parse(lblSelfSpeciality.Text.ToString()), 2) * 0.4 * 0.4 + Math.Round(float.Parse(Request.Form["UpSpeciality"].ToString()), 2) * 0.6);

            tms.Reason = Request.Form["iReason"].ToString();
            tms.AddMinusSocre = Request.Form["iAddMinusScore"].ToString();
            tms.TotalScore = lblSumScore.Text.ToString();
            tms.UpViews = Request.Form["tViews"].ToString();
            tms.TotalScore = Request.Form["hid"].ToString();

            float Score = float.Parse(Request.Form["hid"].ToString());
            if (Score > 90)
            {
                tms.EvaluateLevelId = 2;
            }
            else if (Score > 75 && Score < 90)
            {
                tms.EvaluateLevelId = 3;
            }
            else if (Score > 60 && Score < 75)
            {
                tms.EvaluateLevelId = 4;
            }
            else if (Score < 60)
            {
                tms.EvaluateLevelId = 5;
            }
            tms.IsSubmit = 2;
            tms.Save();
            
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('保存成功！');</script>");
            
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("TechMagv.aspx");
        }
    }
}
