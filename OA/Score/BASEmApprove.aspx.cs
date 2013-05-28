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
    public partial class BASEmApprove : System.Web.UI.Page
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
            int basid = Convert.ToInt32(Request["BasEmScoreId"].ToString());
            BasEmScoreInfo bas = new BasEmScoreInfo(basid);
            EmployeeInfo em = new EmployeeInfo(Convert.ToInt32(bas.EmployeeId));
            lblName.Text = em.EmployeeName.ToString();
            PositionInfo position = new PositionInfo(Convert.ToInt32(em.PositionId));
            lblPosition.Text = position.PositionName.ToString();
            DepartInfo depart = new DepartInfo(Convert.ToInt32(em.DepartId));
            lblDepart.Text = depart.DepartName.ToString();

            //ddlYear.SelectedValue = bas.YearId.ToString();
            //ddlMonth.SelectedValue = bas.MonthId.ToString();

            YearInfo year = new YearInfo(Convert.ToInt32(bas.YearId));
            MonthInfo month = new MonthInfo(Convert.ToInt32(bas.MonthId));
            lblDate.Text = year.YearName + "年" + month.MonthNames + "月";

            lblSelfbas1.Text = bas.Selfbas1.ToString();
            lblSelfbas2.Text = bas.Selfbas2.ToString();
            lblSelfbas3.Text = bas.Selfbas3.ToString();
            lblSelfbas4.Text = bas.Selfbas4.ToString();
            lblSelfbas5.Text = bas.Selfbas5.ToString();
            lblSelfbas6.Text = bas.Selfbas6.ToString();
            lblSelfbas7.Text = bas.Selfbas7.ToString();
            lblSelfbas8.Text = bas.Selfbas8.ToString();
            lblSelfbas9.Text = bas.Selfbas9.ToString();
            lblSelfbas10.Text = bas.Selfbas10.ToString();
            lblSelfbas11.Text = bas.Selfbas11.ToString();
            lblSelfbas12.Text = bas.Selfbas12.ToString();
            lblSelfbas13.Text = bas.Selfbas13.ToString();
            lblSelfbas14.Text = bas.Selfbas14.ToString();
            lblSelfbas15.Text = bas.Selfbas15.ToString();
            lblSelfbas16.Text = bas.Selfbas16.ToString();
            lblSelfbas17.Text = bas.Selfbas17.ToString();

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            int basid = Convert.ToInt32(Request["BasEmScoreId"].ToString());
            BasEmScoreInfo bas = new BasEmScoreInfo(basid);

            bas.Upbas1 = Request.Form["Upbas1"].ToString();
            bas.Upbas2 = Request.Form["Upbas2"].ToString();
            bas.Upbas3 = Request.Form["Upbas3"].ToString();
            bas.Upbas4 = Request.Form["Upbas4"].ToString();
            bas.Upbas5 = Request.Form["Upbas5"].ToString();
            bas.Upbas6 = Request.Form["Upbas6"].ToString();
            bas.Upbas7 = Request.Form["Upbas7"].ToString();
            bas.Upbas8 = Request.Form["Upbas8"].ToString();
            bas.Upbas9 = Request.Form["Upbas9"].ToString();
            bas.Upbas10 = Request.Form["Upbas10"].ToString();
            bas.Upbas11 = Request.Form["Upbas11"].ToString();
            bas.Upbas12 = Request.Form["Upbas12"].ToString();
            bas.Upbas13 = Request.Form["Upbas13"].ToString();
            bas.Upbas14 = Request.Form["Upbas14"].ToString();
            bas.Upbas15 = Request.Form["Upbas15"].ToString();
            bas.Upbas16 = Request.Form["Upbas16"].ToString();
            bas.Upbas17 = Request.Form["Upbas17"].ToString();

            bas.Secbas1 = Convert.ToString(Math.Round(float.Parse(lblSelfbas1.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upbas1"].ToString()), 2) * 0.6);
            bas.Secbas2 = Convert.ToString(Math.Round(float.Parse(lblSelfbas2.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upbas2"].ToString()), 2) * 0.6);
            bas.Secbas3 = Convert.ToString(Math.Round(float.Parse(lblSelfbas3.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upbas3"].ToString()), 2) * 0.6);
            bas.Secbas4 = Convert.ToString(Math.Round(float.Parse(lblSelfbas4.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upbas4"].ToString()), 2) * 0.6);
            bas.Secbas5 = Convert.ToString(Math.Round(float.Parse(lblSelfbas5.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upbas5"].ToString()), 2) * 0.6);
            bas.Secbas6 = Convert.ToString(Math.Round(float.Parse(lblSelfbas6.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upbas6"].ToString()), 2) * 0.6);
            bas.Secbas7 = Convert.ToString(Math.Round(float.Parse(lblSelfbas7.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upbas7"].ToString()), 2) * 0.6);
            bas.Secbas8 = Convert.ToString(Math.Round(float.Parse(lblSelfbas8.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upbas8"].ToString()), 2) * 0.6);
            bas.Secbas9 = Convert.ToString(Math.Round(float.Parse(lblSelfbas9.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upbas9"].ToString()), 2) * 0.6);
            bas.Secbas10 = Convert.ToString(Math.Round(float.Parse(lblSelfbas10.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upbas10"].ToString()), 2) * 0.6);
            bas.Secbas11 = Convert.ToString(Math.Round(float.Parse(lblSelfbas11.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upbas11"].ToString()), 2) * 0.6);
            bas.Secbas12 = Convert.ToString(Math.Round(float.Parse(lblSelfbas12.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upbas12"].ToString()), 2) * 0.6);
            bas.Secbas13 = Convert.ToString(Math.Round(float.Parse(lblSelfbas13.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upbas13"].ToString()), 2) * 0.6);
            bas.Secbas14 = Convert.ToString(Math.Round(float.Parse(lblSelfbas14.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upbas14"].ToString()), 2) * 0.6);
            bas.Secbas15 = Convert.ToString(Math.Round(float.Parse(lblSelfbas15.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upbas15"].ToString()), 2) * 0.6);
            bas.Secbas16 = Convert.ToString(Math.Round(float.Parse(lblSelfbas16.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upbas16"].ToString()), 2) * 0.6);
            bas.Secbas17 = Convert.ToString(Math.Round(float.Parse(lblSelfbas17.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upbas17"].ToString()), 2) * 0.6);
            
            bas.TotalScore = Request.Form["hid"].ToString();

            float Score = float.Parse(Request.Form["hid"].ToString());
            if (Score > 90)
            {
                bas.EvaluateLevelId = 2;
            }
            else if (Score > 75 && Score < 90)
            {
                bas.EvaluateLevelId = 3;
            }
            else if (Score > 60 && Score < 75)
            {
                bas.EvaluateLevelId = 4;
            }
            else if (Score < 60)
            {
                bas.EvaluateLevelId = 5;
            }
            bas.IsSubmit = 2;
            bas.UpViews = Request.Form["UpViews"].ToString();
            bas.Save();
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('保存成功！');</script>");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManagerHelp.aspx");
        }
    }
}
