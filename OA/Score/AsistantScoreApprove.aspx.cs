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
    public partial class AsistantScoreApprove : System.Web.UI.Page
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
            int asid = Convert.ToInt32(Request["AssistantScoreId"].ToString());
            AssistantScoreInfo at = new AssistantScoreInfo(asid);
            EmployeeInfo em = new EmployeeInfo(Convert.ToInt32(at.EmployeeId));
            lblName.Text = em.EmployeeName.ToString();
            PositionInfo position = new PositionInfo(Convert.ToInt32(em.PositionId));
            lblPosition.Text = position.PositionName.ToString();
            DepartInfo depart = new DepartInfo(Convert.ToInt32(em.DepartId));
            lblDepart.Text = depart.DepartName.ToString();

            YearInfo year = new YearInfo(Convert.ToInt32(at.YearId));
            MonthInfo month = new MonthInfo(Convert.ToInt32(at.MonthId));
            lblDate.Text = year.YearName + "年" + month.MonthNames + "月";

            lblSelfas1.Text = at.Selfas1.ToString();
            lblSelfas2.Text = at.Selfas2.ToString();
            lblSelfas3.Text = at.Selfas3.ToString();
            lblSelfas4.Text = at.Selfas4.ToString();
            lblSelfas5.Text = at.Selfas5.ToString();
            lblSelfas6.Text = at.Selfas6.ToString();
            lblSelfas7.Text = at.Selfas7.ToString();
            lblSelfas8.Text = at.Selfas8.ToString();
            lblSelfas9.Text = at.Selfas9.ToString();
            lblSelfas10.Text = at.Selfas10.ToString();
            lblSelfas11.Text = at.Selfas11.ToString();
            lblSelfas12.Text = at.Selfas12.ToString();
            lblSelfas13.Text = at.Selfas13.ToString();
            lblSelfas14.Text = at.Selfas14.ToString();
            lblSelfas15.Text = at.Selfas15.ToString();
            lblSelfas16.Text = at.Selfas16.ToString();
            lblSelfas17.Text = at.Selfas17.ToString();
            lblSelfas18.Text = at.Selfas18.ToString();
            lblSelfas19.Text = at.Selfas19.ToString();
            
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            int asid = Convert.ToInt32(Request["AssistantScoreId"].ToString());
            AssistantScoreInfo at = new AssistantScoreInfo(asid);

            at.Upas1 = Request.Form["Upas1"].ToString();
            at.Upas2 = Request.Form["Upas2"].ToString();
            at.Upas3 = Request.Form["Upas3"].ToString();
            at.Upas4 = Request.Form["Upas4"].ToString();
            at.Upas5 = Request.Form["Upas5"].ToString();
            at.Upas6 = Request.Form["Upas6"].ToString();
            at.Upas7 = Request.Form["Upas7"].ToString();
            at.Upas8 = Request.Form["Upas8"].ToString();
            at.Upas9 = Request.Form["Upas9"].ToString();
            at.Upas10 = Request.Form["Upas10"].ToString();
            at.Upas11 = Request.Form["Upas11"].ToString();
            at.Upas12 = Request.Form["Upas12"].ToString();
            at.Upas13 = Request.Form["Upas13"].ToString();
            at.Upas14 = Request.Form["Upas14"].ToString();
            at.Upas15 = Request.Form["Upas15"].ToString();
            at.Upas16 = Request.Form["Upas16"].ToString();
            at.Upas17 = Request.Form["Upas17"].ToString();
            at.Upas18 = Request.Form["Upas18"].ToString();
            at.Upas19 = Request.Form["Upas19"].ToString();


            at.Secas1 = Convert.ToString(Math.Round(float.Parse(lblSelfas1.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upas1"].ToString()), 2) * 0.6);
            at.Secas2 = Convert.ToString(Math.Round(float.Parse(lblSelfas2.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upas2"].ToString()), 2) * 0.6);
            at.Secas3 = Convert.ToString(Math.Round(float.Parse(lblSelfas3.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upas3"].ToString()), 2) * 0.6);
            at.Secas4 = Convert.ToString(Math.Round(float.Parse(lblSelfas4.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upas4"].ToString()), 2) * 0.6);
            at.Secas5 = Convert.ToString(Math.Round(float.Parse(lblSelfas5.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upas5"].ToString()), 2) * 0.6);
            at.Secas6 = Convert.ToString(Math.Round(float.Parse(lblSelfas6.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upas6"].ToString()), 2) * 0.6);
            at.Secas7 = Convert.ToString(Math.Round(float.Parse(lblSelfas7.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upas7"].ToString()), 2) * 0.6);
            at.Secas8 = Convert.ToString(Math.Round(float.Parse(lblSelfas8.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upas8"].ToString()), 2) * 0.6);
            at.Secas9 = Convert.ToString(Math.Round(float.Parse(lblSelfas9.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upas9"].ToString()), 2) * 0.6);
            at.Secas10 = Convert.ToString(Math.Round(float.Parse(lblSelfas10.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upas10"].ToString()), 2) * 0.6);
            at.Secas11 = Convert.ToString(Math.Round(float.Parse(lblSelfas11.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upas11"].ToString()), 2) * 0.6);
            at.Secas12 = Convert.ToString(Math.Round(float.Parse(lblSelfas12.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upas12"].ToString()), 2) * 0.6);
            at.Secas13 = Convert.ToString(Math.Round(float.Parse(lblSelfas13.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upas13"].ToString()), 2) * 0.6);
            at.Secas14 = Convert.ToString(Math.Round(float.Parse(lblSelfas14.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upas14"].ToString()), 2) * 0.6);
            at.Secas15 = Convert.ToString(Math.Round(float.Parse(lblSelfas15.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upas15"].ToString()), 2) * 0.6);
            at.Secas16 = Convert.ToString(Math.Round(float.Parse(lblSelfas16.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upas16"].ToString()), 2) * 0.6);
            at.Secas17 = Convert.ToString(Math.Round(float.Parse(lblSelfas17.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upas17"].ToString()), 2) * 0.6);
            at.Secas18 = Convert.ToString(Math.Round(float.Parse(lblSelfas18.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upas18"].ToString()), 2) * 0.6);
            at.Secas19 = Convert.ToString(Math.Round(float.Parse(lblSelfas19.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upas19"].ToString()), 2) * 0.6);

            at.TotalScore = Request.Form["hid"].ToString();

            float Score = float.Parse(Request.Form["hid"].ToString());
            if (Score > 90)
            {
                at.EvaluateLevelId = 2;
            }
            else if (Score > 75 && Score < 90)
            {
                at.EvaluateLevelId = 3;
            }
            else if (Score > 60 && Score < 75)
            {
                at.EvaluateLevelId = 4;
            }
            else if (Score < 60)
            {
                at.EvaluateLevelId = 5;
            }
            at.IsSubmit = 2;
            at.UpViews = Request.Form["UpViews"].ToString();
            at.Save();
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('保存成功！');</script>");
            
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManagerHelp.aspx");
        }
    }
}
