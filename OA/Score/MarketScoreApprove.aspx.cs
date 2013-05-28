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
    public partial class MarketScoreApprove : System.Web.UI.Page
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
            int msid = Convert.ToInt32(Request["MarketScoreId"].ToString());
            MarketScoreInfo ms = new MarketScoreInfo(msid);
            EmployeeInfo em = new EmployeeInfo(Convert.ToInt32(ms.EmployeeId));
            lblName.Text = em.EmployeeName.ToString();
            PositionInfo position = new PositionInfo(Convert.ToInt32(em.PositionId));
            lblPosition.Text = position.PositionName.ToString();
           

            //ddlYear.SelectedValue = ms.YearId.ToString();
            //ddlMonth.SelectedValue = ms.MonthId.ToString();

            YearInfo year = new YearInfo(Convert.ToInt32(ms.YearId));
            MonthInfo month = new MonthInfo(Convert.ToInt32(ms.MonthId));
            lblDate.Text = year.YearName + "年" + month.MonthNames + "月";

            lblSelfms1.Text = ms.Selfms1.ToString();
            lblSelfms2.Text = ms.Selfms2.ToString();
            lblSelfms3.Text = ms.Selfms3.ToString();
            lblSelfms4.Text = ms.Selfms4.ToString();
            lblSelfms5.Text = ms.Selfms5.ToString();
            lblSelfms6.Text = ms.Selfms6.ToString();
            lblSelfms7.Text = ms.Selfms7.ToString();
            lblSelfms8.Text = ms.Selfms8.ToString();
            lblSelfms9.Text = ms.Selfms9.ToString();
            lblSelfms10.Text = ms.Selfms10.ToString();
            lblSelfms11.Text = ms.Selfms11.ToString();
            lblSelfms12.Text = ms.Selfms12.ToString();
            lblSelfms13.Text = ms.Selfms13.ToString();
            lblSelfms14.Text = ms.Selfms14.ToString();
            lblSelfms15.Text = ms.Selfms15.ToString();
            lblSelfms16.Text = ms.Selfms16.ToString();
            lblSelfms17.Text = ms.Selfms17.ToString();
            lblSelfms18.Text = ms.Selfms18.ToString();
            lblSelfms19.Text = ms.Selfms19.ToString();
            lblSelfms20.Text = ms.Selfms20.ToString();
            lblSelfms21.Text = ms.Selfms21.ToString();
            lblSelfms22.Text = ms.Selfms22.ToString();
            lblSelfms23.Text = ms.Selfms23.ToString();
            lblSelfms24.Text = ms.Selfms24.ToString();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            int msid = Convert.ToInt32(Request["MarketScoreId"].ToString());
            MarketScoreInfo ms = new MarketScoreInfo(msid);

            ms.Upms1 = Request.Form["Upms1"].ToString();
            ms.Upms2 = Request.Form["Upms2"].ToString();
            ms.Upms3 = Request.Form["Upms3"].ToString();
            ms.Upms4 = Request.Form["Upms4"].ToString();
            ms.Upms5 = Request.Form["Upms5"].ToString();
            ms.Upms6 = Request.Form["Upms6"].ToString();
            ms.Upms7 = Request.Form["Upms7"].ToString();
            ms.Upms8 = Request.Form["Upms8"].ToString();
            ms.Upms9 = Request.Form["Upms9"].ToString();
            ms.Upms10 = Request.Form["Upms10"].ToString();
            ms.Upms11 = Request.Form["Upms11"].ToString();
            ms.Upms12 = Request.Form["Upms12"].ToString();
            ms.Upms13 = Request.Form["Upms13"].ToString();
            ms.Upms14 = Request.Form["Upms14"].ToString();
            ms.Upms15 = Request.Form["Upms15"].ToString();
            ms.Upms16 = Request.Form["Upms16"].ToString();
            ms.Upms17 = Request.Form["Upms17"].ToString();
            ms.Upms18 = Request.Form["Upms18"].ToString();
            ms.Upms19 = Request.Form["Upms19"].ToString();
            ms.Upms20 = Request.Form["Upms20"].ToString();
            ms.Upms21 = Request.Form["Upms21"].ToString();
            ms.Upms22 = Request.Form["Upms22"].ToString();
            ms.Upms23 = Request.Form["Upms23"].ToString();
            ms.Upms24 = Request.Form["Upms24"].ToString();

            ms.Secms1 = Convert.ToString(Math.Round(float.Parse(lblSelfms1.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upms1"].ToString()), 2) * 0.6);
            ms.Secms2 = Convert.ToString(Math.Round(float.Parse(lblSelfms2.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upms2"].ToString()), 2) * 0.6);
            ms.Secms3 = Convert.ToString(Math.Round(float.Parse(lblSelfms3.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upms3"].ToString()), 2) * 0.6);
            ms.Secms4 = Convert.ToString(Math.Round(float.Parse(lblSelfms4.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upms4"].ToString()), 2) * 0.6);
            ms.Secms5 = Convert.ToString(Math.Round(float.Parse(lblSelfms5.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upms5"].ToString()), 2) * 0.6);
            ms.Secms6 = Convert.ToString(Math.Round(float.Parse(lblSelfms6.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upms6"].ToString()), 2) * 0.6);
            ms.Secms7 = Convert.ToString(Math.Round(float.Parse(lblSelfms7.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upms7"].ToString()), 2) * 0.6);
            ms.Secms8 = Convert.ToString(Math.Round(float.Parse(lblSelfms8.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upms8"].ToString()), 2) * 0.6);
            ms.Secms9 = Convert.ToString(Math.Round(float.Parse(lblSelfms9.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upms9"].ToString()), 2) * 0.6);
            ms.Secms10 = Convert.ToString(Math.Round(float.Parse(lblSelfms10.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upms10"].ToString()), 2) * 0.6);
            ms.Secms11 = Convert.ToString(Math.Round(float.Parse(lblSelfms11.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upms11"].ToString()), 2) * 0.6);
            ms.Secms12 = Convert.ToString(Math.Round(float.Parse(lblSelfms12.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upms12"].ToString()), 2) * 0.6);
            ms.Secms13 = Convert.ToString(Math.Round(float.Parse(lblSelfms13.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upms13"].ToString()), 2) * 0.6);
            ms.Secms14 = Convert.ToString(Math.Round(float.Parse(lblSelfms14.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upms14"].ToString()), 2) * 0.6);
            ms.Secms15 = Convert.ToString(Math.Round(float.Parse(lblSelfms15.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upms15"].ToString()), 2) * 0.6);
            ms.Secms16 = Convert.ToString(Math.Round(float.Parse(lblSelfms16.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upms16"].ToString()), 2) * 0.6);
            ms.Secms17 = Convert.ToString(Math.Round(float.Parse(lblSelfms17.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upms17"].ToString()), 2) * 0.6);
            ms.Secms18 = Convert.ToString(Math.Round(float.Parse(lblSelfms18.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upms18"].ToString()), 2) * 0.6);
            ms.Secms19 = Convert.ToString(Math.Round(float.Parse(lblSelfms19.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upms19"].ToString()), 2) * 0.6);
            ms.Secms20 = Convert.ToString(Math.Round(float.Parse(lblSelfms20.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upms20"].ToString()), 2) * 0.6);
            ms.Secms21 = Convert.ToString(Math.Round(float.Parse(lblSelfms21.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upms21"].ToString()), 2) * 0.6);
            ms.Secms22 = Convert.ToString(Math.Round(float.Parse(lblSelfms22.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upms22"].ToString()), 2) * 0.6);
            ms.Secms23 = Convert.ToString(Math.Round(float.Parse(lblSelfms23.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upms23"].ToString()), 2) * 0.6);
            ms.Secms24 = Convert.ToString(Math.Round(float.Parse(lblSelfms24.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upms24"].ToString()), 2) * 0.6);


            ms.TotalScore = Request.Form["hid"].ToString();
            ms.UpViews = Request.Form["tViews"].ToString();

            float Score = float.Parse(Request.Form["hid"].ToString());
            if (Score > 90)
            {
                
                ms.EvaluateLevelId = 2;
            }
            else if (Score > 75 && Score < 90)
            {
                ms.EvaluateLevelId = 3;
            }
            else if (Score > 60 && Score < 75)
            {
                ms.EvaluateLevelId = 4;
            }
            else if (Score < 60)
            {
                ms.EvaluateLevelId = 5;
            }

            ms.IsSubmit = 2;
            ms.Save();
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('保存成功！');</script>");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(ViewState["BackUrl"].ToString());
        }
    }
}
