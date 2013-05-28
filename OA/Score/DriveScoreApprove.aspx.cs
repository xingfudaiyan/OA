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
    public partial class DriveScoreApprove : System.Web.UI.Page
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
            int dsid = Convert.ToInt32(Request["DriverScoreId"].ToString());
            DriverScoreInfo ds = new DriverScoreInfo(dsid);
            EmployeeInfo em = new EmployeeInfo(Convert.ToInt32(ds.EmployeeId));
            lblName.Text = em.EmployeeName.ToString();
            PositionInfo position = new PositionInfo(Convert.ToInt32(em.PositionId));
            lblPosition.Text = position.PositionName.ToString();
            DepartInfo depart = new DepartInfo(Convert.ToInt32(em.DepartId));
            lblDepart.Text = depart.DepartName.ToString();

            //ddlYear.SelectedValue = ds.YearId.ToString();
            //ddlMonth.SelectedValue = ds.MonthId.ToString();

            YearInfo year = new YearInfo(Convert.ToInt32(ds.YearId));
            MonthInfo month = new MonthInfo(Convert.ToInt32(ds.MonthId));
            lblDate.Text = year.YearName + "年" + month.MonthNames + "月";

            lblSelfds1.Text = ds.Selfds1.ToString();
            lblSelfds2.Text = ds.Selfds2.ToString();
            lblSelfds3.Text = ds.Selfds3.ToString();
            lblSelfds4.Text = ds.Selfds4.ToString();
            lblSelfds5.Text = ds.Selfds5.ToString();
            lblSelfds6.Text = ds.Selfds6.ToString();
            lblSelfds7.Text = ds.Selfds7.ToString();
            lblSelfds8.Text = ds.Selfds8.ToString();
            lblSelfds9.Text = ds.Selfds9.ToString();
            lblSelfds10.Text = ds.Selfds10.ToString();
            lblSelfds11.Text = ds.Selfds11.ToString();
            lblSelfds12.Text = ds.Selfds12.ToString();
            lblSelfds13.Text = ds.Selfds13.ToString();
            lblSelfds14.Text = ds.Selfds14.ToString();
            lblSelfds15.Text = ds.Selfds15.ToString();
            lblSelfds16.Text = ds.Selfds16.ToString();
            lblSelfds17.Text = ds.Selfds17.ToString();
            lblSelfds18.Text = ds.Selfds18.ToString();
            lblSelfds19.Text = ds.Selfds19.ToString();
            lblSelfds20.Text = ds.Selfds20.ToString();
            lblSelfds21.Text = ds.Selfds21.ToString();
            lblSelfds22.Text = ds.Selfds22.ToString();
            lblSelfds23.Text = ds.Selfds23.ToString();

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            int dsid = Convert.ToInt32(Request["DriverScoreId"].ToString());
            DriverScoreInfo ds = new DriverScoreInfo(dsid);

            ds.Upds1 = Request.Form["Upds1"].ToString();
            ds.Upds2 = Request.Form["Upds2"].ToString();
            ds.Upds3 = Request.Form["Upds3"].ToString();
            ds.Upds4 = Request.Form["Upds4"].ToString();
            ds.Upds5 = Request.Form["Upds5"].ToString();
            ds.Upds6 = Request.Form["Upds6"].ToString();
            ds.Upds7 = Request.Form["Upds7"].ToString();
            ds.Upds8 = Request.Form["Upds8"].ToString();
            ds.Upds9 = Request.Form["Upds9"].ToString();
            ds.Upds10 = Request.Form["Upds10"].ToString();
            ds.Upds11 = Request.Form["Upds11"].ToString();
            ds.Upds12 = Request.Form["Upds12"].ToString();
            ds.Upds13 = Request.Form["Upds13"].ToString();
            ds.Upds14 = Request.Form["Upds14"].ToString();
            ds.Upds15 = Request.Form["Upds15"].ToString();
            ds.Upds16 = Request.Form["Upds16"].ToString();
            ds.Upds17 = Request.Form["Upds17"].ToString();
            ds.Upds18 = Request.Form["Upds18"].ToString();
            ds.Upds19 = Request.Form["Upds19"].ToString();
            ds.Upds20 = Request.Form["Upds20"].ToString();
            ds.Upds21 = Request.Form["Upds21"].ToString();
            ds.Upds22 = Request.Form["Upds22"].ToString();
            ds.Upds23 = Request.Form["Upds23"].ToString();

            ds.Secds1 = Convert.ToString(Math.Round(float.Parse(lblSelfds1.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upds1"].ToString()), 2) * 0.6);
            ds.Secds2 = Convert.ToString(Math.Round(float.Parse(lblSelfds2.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upds2"].ToString()), 2) * 0.6);
            ds.Secds3 = Convert.ToString(Math.Round(float.Parse(lblSelfds3.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upds3"].ToString()), 2) * 0.6);
            ds.Secds4 = Convert.ToString(Math.Round(float.Parse(lblSelfds4.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upds4"].ToString()), 2) * 0.6);
            ds.Secds5 = Convert.ToString(Math.Round(float.Parse(lblSelfds5.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upds5"].ToString()), 2) * 0.6);
            ds.Secds6 = Convert.ToString(Math.Round(float.Parse(lblSelfds6.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upds6"].ToString()), 2) * 0.6);
            ds.Secds7 = Convert.ToString(Math.Round(float.Parse(lblSelfds7.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upds7"].ToString()), 2) * 0.6);
            ds.Secds8 = Convert.ToString(Math.Round(float.Parse(lblSelfds8.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upds8"].ToString()), 2) * 0.6);
            ds.Secds9 = Convert.ToString(Math.Round(float.Parse(lblSelfds9.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upds9"].ToString()), 2) * 0.6);
            ds.Secds10 = Convert.ToString(Math.Round(float.Parse(lblSelfds10.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upds10"].ToString()), 2) * 0.6);
            ds.Secds11 = Convert.ToString(Math.Round(float.Parse(lblSelfds11.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upds11"].ToString()), 2) * 0.6);
            ds.Secds12 = Convert.ToString(Math.Round(float.Parse(lblSelfds12.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upds12"].ToString()), 2) * 0.6);
            ds.Secds13 = Convert.ToString(Math.Round(float.Parse(lblSelfds13.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upds13"].ToString()), 2) * 0.6);
            ds.Secds14 = Convert.ToString(Math.Round(float.Parse(lblSelfds14.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upds14"].ToString()), 2) * 0.6);
            ds.Secds15 = Convert.ToString(Math.Round(float.Parse(lblSelfds15.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upds15"].ToString()), 2) * 0.6);
            ds.Secds16 = Convert.ToString(Math.Round(float.Parse(lblSelfds16.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upds16"].ToString()), 2) * 0.6);
            ds.Secds17 = Convert.ToString(Math.Round(float.Parse(lblSelfds17.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upds17"].ToString()), 2) * 0.6);
            ds.Secds18 = Convert.ToString(Math.Round(float.Parse(lblSelfds18.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upds18"].ToString()), 2) * 0.6);
            ds.Secds19 = Convert.ToString(Math.Round(float.Parse(lblSelfds19.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upds19"].ToString()), 2) * 0.6);
            ds.Secds20 = Convert.ToString(Math.Round(float.Parse(lblSelfds20.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upds20"].ToString()), 2) * 0.6);
            ds.Secds21 = Convert.ToString(Math.Round(float.Parse(lblSelfds21.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upds21"].ToString()), 2) * 0.6);
            ds.Secds22 = Convert.ToString(Math.Round(float.Parse(lblSelfds22.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upds22"].ToString()), 2) * 0.6);
            ds.Secds23 = Convert.ToString(Math.Round(float.Parse(lblSelfds23.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upds23"].ToString()), 2) * 0.6);

            ds.TotalScore = Request.Form["hid"].ToString();

            float Score = float.Parse(Request.Form["hid"].ToString());
            if (Score > 90)
            {
                ds.EvaluateLevelId = 2;
            }
            else if (Score > 75 && Score < 90)
            {
                ds.EvaluateLevelId = 3;
            }
            else if (Score > 60 && Score < 75)
            {
                ds.EvaluateLevelId = 4;
            }
            else if (Score < 60)
            {
                ds.EvaluateLevelId = 5;
            }
            ds.IsSubmit = 2;
            ds.UpViews = Request.Form["UpViews"].ToString();
            ds.Save();
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('保存成功！');</script>");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Assistantgv.aspx");
        }
    }
}
