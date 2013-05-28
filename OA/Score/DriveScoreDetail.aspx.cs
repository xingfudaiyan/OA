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
    public partial class DriveScoreDetail : System.Web.UI.Page
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
            int dsid=Convert.ToInt32(Request["DriverScoreId"].ToString());
            DriverScoreInfo ds=new DriverScoreInfo(dsid);

            EmployeeInfo em=new EmployeeInfo(Convert.ToInt32(ds.EmployeeId));
            lblName.Text = em.EmployeeName.ToString();
            PositionInfo position = new PositionInfo(Convert.ToInt32(em.PositionId));
            lblPosition.Text = position.PositionName.ToString();
            DepartInfo depart = new DepartInfo(Convert.ToInt32(em.DepartId));
            lblDepart.Text = depart.DepartName.ToString();

            //ddlYear.SelectedValue=ds.YearId.ToString();
            //ddlMonth.SelectedValue=ds.MonthId.ToString();

            YearInfo year = new YearInfo(Convert.ToInt32(ds.YearId));
            MonthInfo month = new MonthInfo(Convert.ToInt32(ds.MonthId));
            lblDate.Text = year.YearName + "Äê" + month.MonthNames + "ÔÂ";

            lblSelfds1.Text=ds.Selfds1.ToString();
            lblSelfds2.Text=ds.Selfds2.ToString();
            lblSelfds3.Text=ds.Selfds3.ToString();
            lblSelfds4.Text=ds.Selfds4.ToString();
            lblSelfds5.Text=ds.Selfds5.ToString();
            lblSelfds6.Text=ds.Selfds6.ToString();
            lblSelfds7.Text=ds.Selfds7.ToString();
            lblSelfds8.Text=ds.Selfds8.ToString();
            lblSelfds9.Text=ds.Selfds9.ToString();
            lblSelfds10.Text=ds.Selfds10.ToString();
            lblSelfds11.Text=ds.Selfds11.ToString();
            lblSelfds12.Text=ds.Selfds12.ToString();
            lblSelfds13.Text=ds.Selfds13.ToString();
            lblSelfds14.Text=ds.Selfds14.ToString();
            lblSelfds15.Text=ds.Selfds15.ToString();
            lblSelfds16.Text=ds.Selfds16.ToString();
            lblSelfds17.Text=ds.Selfds17.ToString();
            lblSelfds18.Text=ds.Selfds18.ToString();
            lblSelfds19.Text=ds.Selfds19.ToString();
            lblSelfds20.Text=ds.Selfds20.ToString();
            lblSelfds21.Text=ds.Selfds21.ToString();
            lblSelfds22.Text=ds.Selfds22.ToString();
            lblSelfds23.Text=ds.Selfds23.ToString();

            lblUpds1.Text=ds.Upds1.ToString();
            lblUpds2.Text=ds.Upds2.ToString();
            lblUpds3.Text=ds.Upds3.ToString();
            lblUpds4.Text=ds.Upds4.ToString();
            lblUpds5.Text=ds.Upds5.ToString();
            lblUpds6.Text=ds.Upds6.ToString();
            lblUpds7.Text=ds.Upds7.ToString();
            lblUpds8.Text=ds.Upds8.ToString();
            lblUpds9.Text=ds.Upds9.ToString();
            lblUpds10.Text=ds.Upds10.ToString();
            lblUpds11.Text=ds.Upds11.ToString();
            lblUpds12.Text=ds.Upds12.ToString();
            lblUpds13.Text=ds.Upds13.ToString();
            lblUpds14.Text=ds.Upds14.ToString();
            lblUpds15.Text=ds.Upds15.ToString();
            lblUpds16.Text=ds.Upds16.ToString();
            lblUpds17.Text=ds.Upds17.ToString();
            lblUpds18.Text=ds.Upds18.ToString();
            lblUpds19.Text=ds.Upds19.ToString();
            lblUpds20.Text=ds.Upds20.ToString();
            lblUpds21.Text=ds.Upds21.ToString();
            lblUpds22.Text=ds.Upds22.ToString();
            lblUpds23.Text=ds.Upds23.ToString();

            lblSectds1.Text=ds.Secds1.ToString();
            lblSectds2.Text=ds.Secds2.ToString();
            lblSectds3.Text=ds.Secds3.ToString();
            lblSectds4.Text=ds.Secds4.ToString();
            lblSectds5.Text=ds.Secds5.ToString();
            lblSectds6.Text=ds.Secds6.ToString();
            lblSectds7.Text=ds.Secds7.ToString();
            lblSectds8.Text=ds.Secds8.ToString();
            lblSectds9.Text=ds.Secds9.ToString();
            lblSectds10.Text=ds.Secds10.ToString();
            lblSectds11.Text=ds.Secds11.ToString();
            lblSectds12.Text=ds.Secds12.ToString();
            lblSectds13.Text=ds.Secds13.ToString();
            lblSectds14.Text=ds.Secds14.ToString();
            lblSectds15.Text=ds.Secds15.ToString();
            lblSectds16.Text=ds.Secds16.ToString();
            lblSectds17.Text=ds.Secds17.ToString();
            lblSectds18.Text=ds.Secds18.ToString();
            lblSectds19.Text=ds.Secds19.ToString();
            lblSectds20.Text=ds.Secds20.ToString();
            lblSectds21.Text=ds.Secds21.ToString();
            lblSectds22.Text=ds.Secds22.ToString();
            lblSectds23.Text=ds.Secds23.ToString();

            lblTotalScore.Text = ds.TotalScore.ToString();

            

        }
       
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(ViewState["BackUrl"].ToString());
        }
    }
}
