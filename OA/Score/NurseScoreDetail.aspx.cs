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
    public partial class NurseScoreDetail : System.Web.UI.Page
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
            lblDate.Text = year.YearName + "Äê" + month.MonthNames + "ÔÂ";

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

            lblUpns1.Text = ns.Upns1.ToString();
            lblUpns2.Text = ns.Upns2.ToString();
            lblUpns3.Text = ns.Upns3.ToString();
            lblUpns4.Text = ns.Upns4.ToString();
            lblUpns5.Text = ns.Upns5.ToString();
            lblUpns6.Text = ns.Upns6.ToString();
            lblUpns7.Text = ns.Upns7.ToString();
            lblUpns8.Text = ns.Upns8.ToString();
            lblUpns9.Text = ns.Upns9.ToString();
            lblUpns10.Text = ns.Upns10.ToString();
            lblUpns11.Text = ns.Upns11.ToString();
            lblUpns12.Text = ns.Upns12.ToString();
            lblUpns13.Text = ns.Upns13.ToString();
            lblUpns14.Text = ns.Upns14.ToString();
            lblUpns15.Text = ns.Upns15.ToString();
            lblUpns16.Text = ns.Upns16.ToString();
            lblUpns17.Text = ns.Upns17.ToString();
            lblUpns18.Text = ns.Upns18.ToString();
            lblUpns19.Text = ns.Upns19.ToString();
            lblUpns20.Text = ns.Upns20.ToString();
            lblUpns21.Text = ns.Upns21.ToString();
            lblUpns22.Text = ns.Upns22.ToString();
            lblUpns23.Text = ns.Upns23.ToString();

            lblSectns1.Text = ns.Secns1.ToString();
            lblSectns2.Text = ns.Secns2.ToString();
            lblSectns3.Text = ns.Secns3.ToString();
            lblSectns4.Text = ns.Secns4.ToString();
            lblSectns5.Text = ns.Secns5.ToString();
            lblSectns6.Text = ns.Secns6.ToString();
            lblSectns7.Text = ns.Secns7.ToString();
            lblSectns8.Text = ns.Secns8.ToString();
            lblSectns9.Text = ns.Secns9.ToString();
            lblSectns10.Text = ns.Secns10.ToString();
            lblSectns11.Text = ns.Secns11.ToString();
            lblSectns12.Text = ns.Secns12.ToString();
            lblSectns13.Text = ns.Secns13.ToString();
            lblSectns14.Text = ns.Secns14.ToString();
            lblSectns15.Text = ns.Secns15.ToString();
            lblSectns16.Text = ns.Secns16.ToString();
            lblSectns17.Text = ns.Secns17.ToString();
            lblSectns18.Text = ns.Secns18.ToString();
            lblSectns19.Text = ns.Secns19.ToString();
            lblSectns20.Text = ns.Secns20.ToString();
            lblSectns21.Text = ns.Secns21.ToString();
            lblSectns22.Text = ns.Secns22.ToString();
            lblSectns23.Text = ns.Secns23.ToString();

            lblTotalScore.Text = ns.TotalScore.ToString();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(ViewState["BackUrl"].ToString());
        }
    }
}
