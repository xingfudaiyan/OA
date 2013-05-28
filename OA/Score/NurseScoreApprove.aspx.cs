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
    public partial class NurseScoreApprove : System.Web.UI.Page
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
            int nsid = Convert.ToInt32(Request["NurseScoreId"].ToString());
            NurseScoreInfo ns = new NurseScoreInfo(nsid);
            EmployeeInfo em = new EmployeeInfo(Convert.ToInt32(ns.EmployeeId));
            lblName.Text = em.EmployeeName.ToString();
            PositionInfo position = new PositionInfo(Convert.ToInt32(em.PositionId));
            lblPosition.Text = position.PositionName.ToString();
            DepartInfo depart = new DepartInfo(Convert.ToInt32(em.DepartId));
            lblDepart.Text = depart.DepartName.ToString();

            //ddlYear.SelectedValue = ns.YearId.ToString();
            //ddlMonth.SelectedValue = ns.MonthId.ToString();
            YearInfo year = new YearInfo(Convert.ToInt32(ns.YearId));
            MonthInfo month = new MonthInfo(Convert.ToInt32(ns.MonthId));
            lblDate.Text = year.YearName + "年" + month.MonthNames + "月";

            lblSelfns1.Text = ns.Selfns1.ToString();
            lblSelfns2.Text = ns.Selfns2.ToString();
            lblSelfns3.Text = ns.Selfns3.ToString();
            lblSelfns4.Text = ns.Selfns4.ToString();
            lblSelfns5.Text = ns.Selfns5.ToString();
            lblSelfns6.Text = ns.Selfns6.ToString();
            lblSelfns7.Text = ns.Selfns7.ToString();
            lblSelfns8.Text = ns.Selfns8.ToString();
            lblSelfns9.Text = ns.Selfns9.ToString();
            lblSelfns10.Text = ns.Selfns10.ToString();
            lblSelfns11.Text = ns.Selfns11.ToString();
            lblSelfns12.Text = ns.Selfns12.ToString();
            lblSelfns13.Text = ns.Selfns13.ToString();
            lblSelfns14.Text = ns.Selfns14.ToString();
            lblSelfns15.Text = ns.Selfns15.ToString();
            lblSelfns16.Text = ns.Selfns16.ToString();
            lblSelfns17.Text = ns.Selfns17.ToString();
            lblSelfns18.Text = ns.Selfns18.ToString();
            lblSelfns19.Text = ns.Selfns19.ToString();
            lblSelfns20.Text = ns.Selfns20.ToString();
            lblSelfns21.Text = ns.Selfns21.ToString();
            lblSelfns22.Text = ns.Selfns22.ToString();
            lblSelfns23.Text = ns.Selfns23.ToString();

        }


        protected void btnSave_Click(object sender, EventArgs e)
        {
            int nsid = Convert.ToInt32(Request["NurseScoreId"].ToString());
            NurseScoreInfo ns = new NurseScoreInfo(nsid);

            ns.Upns1 = Request.Form["Upns1"].ToString();
            ns.Upns2 = Request.Form["Upns2"].ToString();
            ns.Upns3 = Request.Form["Upns3"].ToString();
            ns.Upns4 = Request.Form["Upns4"].ToString();
            ns.Upns5 = Request.Form["Upns5"].ToString();
            ns.Upns6 = Request.Form["Upns6"].ToString();
            ns.Upns7 = Request.Form["Upns7"].ToString();
            ns.Upns8 = Request.Form["Upns8"].ToString();
            ns.Upns9 = Request.Form["Upns9"].ToString();
            ns.Upns10 = Request.Form["Upns10"].ToString();
            ns.Upns11 = Request.Form["Upns11"].ToString();
            ns.Upns12 = Request.Form["Upns12"].ToString();
            ns.Upns13 = Request.Form["Upns13"].ToString();
            ns.Upns14 = Request.Form["Upns14"].ToString();
            ns.Upns15 = Request.Form["Upns15"].ToString();
            ns.Upns16 = Request.Form["Upns16"].ToString();
            ns.Upns17 = Request.Form["Upns17"].ToString();
            ns.Upns18 = Request.Form["Upns18"].ToString();
            ns.Upns19 = Request.Form["Upns19"].ToString();
            ns.Upns20 = Request.Form["Upns20"].ToString();
            ns.Upns21 = Request.Form["Upns21"].ToString();
            ns.Upns22 = Request.Form["Upns22"].ToString();
            ns.Upns23 = Request.Form["Upns23"].ToString();

            ns.Secns1 = Convert.ToString(Math.Round(float.Parse(lblSelfns1.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upns1"].ToString()), 2) * 0.6);
            ns.Secns2 = Convert.ToString(Math.Round(float.Parse(lblSelfns2.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upns2"].ToString()), 2) * 0.6);
            ns.Secns3 = Convert.ToString(Math.Round(float.Parse(lblSelfns3.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upns3"].ToString()), 2) * 0.6);
            ns.Secns4 = Convert.ToString(Math.Round(float.Parse(lblSelfns4.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upns4"].ToString()), 2) * 0.6);
            ns.Secns5 = Convert.ToString(Math.Round(float.Parse(lblSelfns5.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upns5"].ToString()), 2) * 0.6);
            ns.Secns6 = Convert.ToString(Math.Round(float.Parse(lblSelfns6.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upns6"].ToString()), 2) * 0.6);
            ns.Secns7 = Convert.ToString(Math.Round(float.Parse(lblSelfns7.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upns7"].ToString()), 2) * 0.6);
            ns.Secns8 = Convert.ToString(Math.Round(float.Parse(lblSelfns8.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upns8"].ToString()), 2) * 0.6);
            ns.Secns9 = Convert.ToString(Math.Round(float.Parse(lblSelfns9.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upns9"].ToString()), 2) * 0.6);
            ns.Secns10 = Convert.ToString(Math.Round(float.Parse(lblSelfns10.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upns10"].ToString()), 2) * 0.6);
            ns.Secns11 = Convert.ToString(Math.Round(float.Parse(lblSelfns11.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upns11"].ToString()), 2) * 0.6);
            ns.Secns12 = Convert.ToString(Math.Round(float.Parse(lblSelfns12.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upns12"].ToString()), 2) * 0.6);
            ns.Secns13 = Convert.ToString(Math.Round(float.Parse(lblSelfns13.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upns13"].ToString()), 2) * 0.6);
            ns.Secns14 = Convert.ToString(Math.Round(float.Parse(lblSelfns14.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upns14"].ToString()), 2) * 0.6);
            ns.Secns15 = Convert.ToString(Math.Round(float.Parse(lblSelfns15.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upns15"].ToString()), 2) * 0.6);
            ns.Secns16 = Convert.ToString(Math.Round(float.Parse(lblSelfns16.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upns16"].ToString()), 2) * 0.6);
            ns.Secns17 = Convert.ToString(Math.Round(float.Parse(lblSelfns17.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upns17"].ToString()), 2) * 0.6);
            ns.Secns18 = Convert.ToString(Math.Round(float.Parse(lblSelfns18.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upns18"].ToString()), 2) * 0.6);
            ns.Secns19 = Convert.ToString(Math.Round(float.Parse(lblSelfns19.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upns19"].ToString()), 2) * 0.6);
            ns.Secns20 = Convert.ToString(Math.Round(float.Parse(lblSelfns20.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upns20"].ToString()), 2) * 0.6);
            ns.Secns21 = Convert.ToString(Math.Round(float.Parse(lblSelfns21.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upns21"].ToString()), 2) * 0.6);
            ns.Secns22 = Convert.ToString(Math.Round(float.Parse(lblSelfns22.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upns22"].ToString()), 2) * 0.6);
            ns.Secns23 = Convert.ToString(Math.Round(float.Parse(lblSelfns23.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upns23"].ToString()), 2) * 0.6);

            float Score = float.Parse(Request.Form["hid"].ToString());
            if (Score > 90)
            {
                ns.EvaluateLevelId = 2;
            }
            else if (Score > 75 && Score < 90)
            {
                ns.EvaluateLevelId = 3;
            }
            else if (Score > 60 && Score < 75)
            {
                ns.EvaluateLevelId = 4;
            }
            else if (Score < 60)
            {
                ns.EvaluateLevelId = 5;
            }
            ns.TotalScore = Request.Form["hid"].ToString();
            ns.IsSubmit = 2;
            ns.UpViews = Request.Form["UpViews"].ToString();
            ns.Save();
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('保存成功！');</script>");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Assistantgv.aspx");
        }
    }
}
