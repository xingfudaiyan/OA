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
    public partial class BASEmScoreDetail : System.Web.UI.Page
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
            EmployeeInfo em = (EmployeeInfo)Session["Employee"];
            lblName.Text = em.EmployeeName.ToString();
            PositionInfo position = new PositionInfo(Convert.ToInt32(em.PositionId));
            lblPosition.Text = position.PositionName.ToString();
            DepartInfo depart = new DepartInfo(Convert.ToInt32(em.DepartId));
            lblDepart.Text = depart.DepartName.ToString();
       
            int basid = Convert.ToInt32(Request["BasEmScoreId"].ToString());
            BasEmScoreInfo bas = new BasEmScoreInfo(basid);
         
         
            YearInfo year = new YearInfo(Convert.ToInt32(bas.YearId));
            MonthInfo month = new MonthInfo(Convert.ToInt32(bas.MonthId));
            lblDate.Text = year.YearName + "Äê" + month.MonthNames + "ÔÂ";
          
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

            lblUpbas1.Text = bas.Upbas1.ToString();
            lblUpbas2.Text = bas.Upbas2.ToString();
            lblUpbas3.Text = bas.Upbas3.ToString();
            lblUpbas4.Text = bas.Upbas4.ToString();
            lblUpbas5.Text = bas.Upbas5.ToString();
            lblUpbas6.Text = bas.Upbas6.ToString();
            lblUpbas7.Text = bas.Upbas7.ToString();
            lblUpbas8.Text = bas.Upbas8.ToString();
            lblUpbas9.Text = bas.Upbas9.ToString();
            lblUpbas10.Text = bas.Upbas10.ToString();
            lblUpbas11.Text = bas.Upbas11.ToString();
            lblUpbas12.Text = bas.Upbas12.ToString();
            lblUpbas13.Text = bas.Upbas13.ToString();
            lblUpbas14.Text = bas.Upbas14.ToString();
            lblUpbas15.Text = bas.Upbas15.ToString();
            lblUpbas16.Text = bas.Upbas16.ToString();
            lblUpbas17.Text = bas.Upbas17.ToString();

            lblSecbas1.Text = bas.Secbas1.ToString();
            lblSecbas2.Text = bas.Secbas2.ToString();
            lblSecbas3.Text = bas.Secbas3.ToString();
            lblSecbas4.Text = bas.Secbas4.ToString();
            lblSecbas5.Text = bas.Secbas5.ToString();
            lblSecbas6.Text = bas.Secbas6.ToString();
            lblSecbas7.Text = bas.Secbas7.ToString();
            lblSecbas8.Text = bas.Secbas8.ToString();
            lblSecbas9.Text = bas.Secbas9.ToString();
            lblSecbas10.Text = bas.Secbas10.ToString();
            lblSecbas11.Text = bas.Secbas11.ToString();
            lblSecbas12.Text = bas.Secbas12.ToString();
            lblSecbas13.Text = bas.Secbas13.ToString();
            lblSecbas14.Text = bas.Secbas14.ToString();
            lblSecbas15.Text = bas.Secbas15.ToString();
            lblSecbas16.Text = bas.Secbas16.ToString();
            lblSecbas17.Text = bas.Secbas17.ToString();

            lblTotalScore.Text = bas.TotalScore.ToString();
            if (bas.EvaluateLevelId.ToString() != "")
            {
                EvaluateLevelInfo le = new EvaluateLevelInfo(Convert.ToInt32(bas.EvaluateLevelId));
                lblLevel.Text = le.EvaluateName.ToString();
            }
            else
            {
                lblLevel.Text = "";
            }
            lblViews.Text = bas.UpViews.ToString();


        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(ViewState["BackUrl"].ToString());
        }
    }
}
