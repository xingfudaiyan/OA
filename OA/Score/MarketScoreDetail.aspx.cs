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
    public partial class MarketScoreDetail : System.Web.UI.Page
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
            lblDate.Text = year.YearName + "Äê" + month.MonthNames + "ÔÂ";

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

            lblUpms1.Text = ms.Upms1.ToString();
            lblUpms2.Text = ms.Upms2.ToString();
            lblUpms3.Text = ms.Upms3.ToString();
            lblUpms4.Text = ms.Upms4.ToString();
            lblUpms5.Text = ms.Upms5.ToString();
            lblUpms6.Text = ms.Upms6.ToString();
            lblUpms7.Text = ms.Upms7.ToString();
            lblUpms8.Text = ms.Upms8.ToString();
            lblUpms9.Text = ms.Upms9.ToString();
            lblUpms10.Text = ms.Upms10.ToString();
            lblUpms11.Text = ms.Upms11.ToString();
            lblUpms12.Text = ms.Upms12.ToString();
            lblUpms13.Text = ms.Upms13.ToString();
            lblUpms14.Text = ms.Upms14.ToString();
            lblUpms15.Text = ms.Upms15.ToString();
            lblUpms16.Text = ms.Upms16.ToString();
            lblUpms17.Text = ms.Upms17.ToString();
            lblUpms18.Text = ms.Upms18.ToString();
            lblUpms19.Text = ms.Upms19.ToString();
            lblUpms20.Text = ms.Upms20.ToString();
            lblUpms21.Text = ms.Upms21.ToString();
            lblUpms22.Text = ms.Upms22.ToString();
            lblUpms23.Text = ms.Upms23.ToString();
            lblUpms24.Text = ms.Upms24.ToString();

            lblSecms1.Text = ms.Secms1.ToString();
            lblSecms2.Text = ms.Secms2.ToString();
            lblSecms3.Text = ms.Secms3.ToString();
            lblSecms4.Text = ms.Secms4.ToString();
            lblSecms5.Text = ms.Secms5.ToString();
            lblSecms6.Text = ms.Secms6.ToString();
            lblSecms7.Text = ms.Secms7.ToString();
            lblSecms8.Text = ms.Secms8.ToString();
            lblSecms9.Text = ms.Secms9.ToString();
            lblSecms10.Text = ms.Secms10.ToString();
            lblSecms11.Text = ms.Secms11.ToString();
            lblSecms12.Text = ms.Secms12.ToString();
            lblSecms13.Text = ms.Secms13.ToString();
            lblSecms14.Text = ms.Secms14.ToString();
            lblSecms15.Text = ms.Secms15.ToString();
            lblSecms16.Text = ms.Secms16.ToString();
            lblSecms17.Text = ms.Secms17.ToString();
            lblSecms18.Text = ms.Secms18.ToString();
            lblSecms19.Text = ms.Secms19.ToString();
            lblSecms20.Text = ms.Secms10.ToString();
            lblSecms21.Text = ms.Secms1.ToString();
            lblSecms22.Text = ms.Secms2.ToString();
            lblSecms23.Text = ms.Secms3.ToString();
            lblSecms24.Text = ms.Secms4.ToString();

            lblTotalScore.Text = ms.TotalScore.ToString();
            lblViews.Text = ms.UpViews.ToString();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(ViewState["BackUrl"].ToString());
        }
    }
}
