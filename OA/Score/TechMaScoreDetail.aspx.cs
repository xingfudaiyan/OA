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
    public partial class TechMaScoreDetail : System.Web.UI.Page
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
            int TesId = Convert.ToInt32(Request["TechMaScoreId"].ToString());
            TechMaScoreInfo tms = new TechMaScoreInfo(TesId);
            lblSelfScore1.Text = tms.SelfScore1.ToString();
            lblSelfScore2.Text = tms.SelfScore2.ToString();
            lblSelfScore3.Text = tms.SelfScore3.ToString();
            lblSelfScore4.Text = tms.SelfScore4.ToString();
            lblSelfScore5.Text = tms.SelfScore5.ToString();
            lblSelfScore6.Text = tms.SelfScore6.ToString();
            lblSelfScore7.Text = tms.SelfScore7.ToString();
            lblSelfScore8.Text = tms.SelfScore8.ToString();
            lblSelfScore9.Text = tms.SelfScore9.ToString();
            lblSelfScore10.Text = tms.SelfScore10.ToString();
            lblSelfScore11.Text = tms.SelfScore11.ToString();
            lblSelfScore12.Text = tms.SelfScore12.ToString();
            lblSelfScore13.Text = tms.SelfScore13.ToString();

            lblUpScore1.Text = tms.UpScore1.ToString();
            lblUpScore2.Text = tms.UpScore2.ToString();
            lblUpScore3.Text = tms.UpScore3.ToString();
            lblUpScore4.Text = tms.UpScore4.ToString();
            lblUpScore5.Text = tms.UpScore5.ToString();
            lblUpScore6.Text = tms.UpScore6.ToString();
            lblUpScore7.Text = tms.UpScore7.ToString();
            lblUpScore8.Text = tms.UpScore8.ToString();
            lblUpScore9.Text = tms.UpScore9.ToString();
            lblUpScore10.Text = tms.UpScore10.ToString();
            lblUpScore11.Text = tms.UpScore11.ToString();
            lblUpScore12.Text = tms.UpScore12.ToString();
            lblUpScore13.Text = tms.UpScore13.ToString();


            lblSectScore1.Text = tms.SectScore1.ToString();
            lblSectScore2.Text = tms.SectScore2.ToString();
            lblSectScore3.Text = tms.SectScore3.ToString();
            lblSectScore4.Text = tms.SectScore4.ToString();
            lblSectScore5.Text = tms.SectScore5.ToString();
            lblSectScore6.Text = tms.SectScore6.ToString();
            lblSectScore7.Text = tms.SectScore7.ToString();
            lblSectScore8.Text = tms.SectScore8.ToString();
            lblSectScore9.Text = tms.SectScore9.ToString();
            lblSectScore10.Text = tms.SectScore10.ToString();
            lblSectScore11.Text = tms.SectScore11.ToString();
            lblSectScore12.Text = tms.SectScore12.ToString();
            lblSectScore13.Text = tms.SectScore13.ToString();

            //ddlYear.SelectedValue = tms.YearId.ToString();
            //ddlMonth.SelectedValue = tms.MonthId.ToString();
            
            YearInfo year = new YearInfo(Convert.ToInt32(tms.YearId));
            MonthInfo month = new MonthInfo(Convert.ToInt32(tms.MonthId));
            lblDate.Text = year.YearName + "Äê" + month.MonthNames + "ÔÂ";

            EmployeeInfo em = new EmployeeInfo(Convert.ToInt32(tms.EmployeeId));
            lblName.Text = em.EmployeeName.ToString();
            PositionInfo position = new PositionInfo(Convert.ToInt32(Convert.ToInt32(em.PositionId)));
            lblPosition.Text = position.PositionName;

          
            lblSumScore.Text = tms.TotalScore.ToString();
            lblViews.Text = tms.UpView.ToString();
            if (tms.EvaluateLevelId.ToString() != "")
            {
                EvaluateLevelInfo ev = new EvaluateLevelInfo(Convert.ToInt32(tms.EvaluateLevelId));
                lblLevel.Text = ev.EvaluateName.ToString();
            }
            else
            {
                lblLevel.Text = "";
            }
           
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(ViewState["BackUrl"].ToString());
        }
    }
}
