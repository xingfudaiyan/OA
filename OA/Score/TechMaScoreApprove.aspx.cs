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
    public partial class ManagerTechAdd : System.Web.UI.Page
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
            int tmsid = Convert.ToInt32(Request["TechMaScoreId"].ToString());
            TechMaScoreInfo tms = new TechMaScoreInfo(tmsid);

            lblSelfProject1.Text = tms.SelfScore1.ToString();
            lblSelfProject2.Text = tms.SelfScore2.ToString();
            lblSelfProject3.Text = tms.SelfScore3.ToString();
            lblSelfProject4.Text = tms.SelfScore4.ToString();
            lblSelfProject5.Text = tms.SelfScore5.ToString();
            lblSelfProject6.Text = tms.SelfScore6.ToString();
            lblSelfProject7.Text = tms.SelfScore7.ToString();
            lblSelfProject8.Text = tms.SelfScore8.ToString();
            lblSelfProject9.Text = tms.SelfScore9.ToString();
            lblSelfProject10.Text = tms.SelfScore10.ToString();
            lblSelfProject11.Text = tms.SelfScore11.ToString();
            lblSelfProject12.Text = tms.SelfScore12.ToString();
            lblSelfProject13.Text = tms.SelfScore13.ToString();

            //ddlYear.SelectedValue = tms.YearId.ToString();
            //ddlMonth.SelectedValue = tms.MonthId.ToString();

            YearInfo year = new YearInfo(Convert.ToInt32(tms.YearId));
            MonthInfo month = new MonthInfo(Convert.ToInt32(tms.MonthId));
            lblDate.Text = year.YearName + "年" + month.MonthNames + "月";

            EmployeeInfo em = new EmployeeInfo(Convert.ToInt32(tms.EmployeeId));
            lblName.Text = em.EmployeeName.ToString();
            PositionInfo position = new PositionInfo(Convert.ToInt32(Convert.ToInt32(em.PositionId)));
            lblPosition.Text = position.PositionName;

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            int tmsid = Convert.ToInt32(Request["TechMaScoreId"].ToString());
            TechMaScoreInfo tms = new TechMaScoreInfo(tmsid);

            tms.UpScore1 = Request.Form["project1"].ToString();
            tms.UpScore2 = Request.Form["project2"].ToString();
            tms.UpScore3 = Request.Form["project3"].ToString();
            tms.UpScore4 = Request.Form["project4"].ToString();
            tms.UpScore5 = Request.Form["project5"].ToString();
            tms.UpScore6 = Request.Form["project6"].ToString();
            tms.UpScore7 = Request.Form["project7"].ToString();
            tms.UpScore8 = Request.Form["project8"].ToString();
            tms.UpScore9 = Request.Form["project9"].ToString();
            tms.UpScore10 = Request.Form["project10"].ToString();
            tms.UpScore11 = Request.Form["project11"].ToString();
            tms.UpScore12 = Request.Form["project12"].ToString();
            tms.UpScore13 = Request.Form["project13"].ToString();


            tms.SectScore1 = Convert.ToString(Math.Round(float.Parse(lblSelfProject1.Text.ToString()),2) * 0.4 + Math.Round(float.Parse(Request.Form["project1"].ToString()), 2) * 0.6);
            tms.SectScore2 = Convert.ToString(Math.Round(float.Parse(lblSelfProject2.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["project2"].ToString()), 2) * 0.6);
            tms.SectScore3 = Convert.ToString(Math.Round(float.Parse(lblSelfProject3.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["project3"].ToString()), 2) * 0.6);
            tms.SectScore4 = Convert.ToString(Math.Round(float.Parse(lblSelfProject4.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["project4"].ToString()), 2) * 0.6);
            tms.SectScore5 = Convert.ToString(Math.Round(float.Parse(lblSelfProject5.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["project5"].ToString()), 2) * 0.6);
            tms.SectScore6 = Convert.ToString(Math.Round(float.Parse(lblSelfProject6.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["project6"].ToString()), 2) * 0.6);
            tms.SectScore7 = Convert.ToString(Math.Round(float.Parse(lblSelfProject7.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["project7"].ToString()), 2) * 0.6);
            tms.SectScore8 = Convert.ToString(Math.Round(float.Parse(lblSelfProject8.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["project8"].ToString()), 2) * 0.6);
            tms.SectScore9 = Convert.ToString(Math.Round(float.Parse(lblSelfProject9.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["project9"].ToString()), 2) * 0.6);
            tms.SectScore10 = Convert.ToString(Math.Round(float.Parse(lblSelfProject10.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["project10"].ToString()), 2) * 0.6);
            tms.SectScore11 = Convert.ToString(Math.Round(float.Parse(lblSelfProject11.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["project11"].ToString()), 2) * 0.6);
            tms.SectScore12 = Convert.ToString(Math.Round(float.Parse(lblSelfProject12.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["project12"].ToString()), 2) * 0.6);
            tms.SectScore13 = Convert.ToString(Math.Round(float.Parse(lblSelfProject13.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["project13"].ToString()), 2) * 0.6);
         
            
            tms.TotalScore = Request.Form["hid"].ToString();
            tms.UpView = Request.Form["tViews"].ToString();
         

            float Score =float.Parse(Request.Form["hid"].ToString());
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
            Response.Redirect("ManagerGv.aspx");
        }
    }
}
