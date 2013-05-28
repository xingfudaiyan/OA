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
    public partial class AsistantScoreDetail : System.Web.UI.Page
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
            int asid = Convert.ToInt32(Request["AssistantScoreId"].ToString());
            AssistantScoreInfo at = new AssistantScoreInfo(asid);

            EmployeeInfo em = new EmployeeInfo(Convert.ToInt32(at.EmployeeId));
            lblName.Text = em.EmployeeName.ToString();
            PositionInfo position = new PositionInfo(Convert.ToInt32(em.PositionId));
            lblPosition.Text = position.PositionName.ToString();
            DepartInfo depart = new DepartInfo(Convert.ToInt32(em.DepartId));
            lblDepart.Text = depart.DepartName.ToString();

            //ddlYear.SelectedValue = at.YearId.ToString();
            //ddlMonth.SelectedValue = at.MonthId.ToString();

            YearInfo year = new YearInfo(Convert.ToInt32(at.YearId));
            MonthInfo month = new MonthInfo(Convert.ToInt32(at.MonthId));
            lblDate.Text = year.YearName + "Äê" + month.MonthNames + "ÔÂ";

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
         
            lblUpas1.Text = at.Upas1.ToString();
            lblUpas2.Text = at.Upas2.ToString();
            lblUpas3.Text = at.Upas3.ToString();
            lblUpas4.Text = at.Upas4.ToString();
            lblUpas5.Text = at.Upas5.ToString();
            lblUpas6.Text = at.Upas6.ToString();
            lblUpas7.Text = at.Upas7.ToString();
            lblUpas8.Text = at.Upas8.ToString();
            lblUpas9.Text = at.Upas9.ToString();
            lblUpas10.Text = at.Upas10.ToString();
            lblUpas11.Text = at.Upas11.ToString();
            lblUpas12.Text = at.Upas12.ToString();
            lblUpas13.Text = at.Upas13.ToString();
            lblUpas14.Text = at.Upas14.ToString();
            lblUpas15.Text = at.Upas15.ToString();
            lblUpas16.Text = at.Upas16.ToString();
            lblUpas17.Text = at.Upas17.ToString();
            lblUpas18.Text = at.Upas18.ToString();
            lblUpas19.Text = at.Upas19.ToString();
         
            lblSecas1.Text = at.Secas1.ToString();
            lblSecas2.Text = at.Secas2.ToString();
            lblSecas3.Text = at.Secas3.ToString();
            lblSecas4.Text = at.Secas4.ToString();
            lblSecas5.Text = at.Secas5.ToString();
            lblSecas6.Text = at.Secas6.ToString();
            lblSecas7.Text = at.Secas7.ToString();
            lblSecas8.Text = at.Secas8.ToString();
            lblSecas9.Text = at.Secas9.ToString();
            lblSecas10.Text = at.Secas10.ToString();
            lblSecas11.Text = at.Secas11.ToString();
            lblSecas12.Text = at.Secas12.ToString();
            lblSecas13.Text = at.Secas13.ToString();
            lblSecas14.Text = at.Secas14.ToString();
            lblSecas15.Text = at.Secas15.ToString();
            lblSecas16.Text = at.Secas16.ToString();
            lblSecas17.Text = at.Secas17.ToString();
            lblSecas18.Text = at.Secas18.ToString();
            lblSecas19.Text = at.Secas19.ToString();

            lblTotalScore.Text = at.TotalScore.ToString();
            if (at.EvaluateLevelId.ToString() != "")
            {
                EvaluateLevelInfo le = new EvaluateLevelInfo(Convert.ToInt32(at.EvaluateLevelId));
                lblLevel.Text = le.EvaluateName.ToString();
            }
            else
            {
                lblLevel.Text = "";
            }
            lblViews.Text = at.UpViews.ToString();
           

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(ViewState["BackUrl"].ToString());
        }
    }
}
