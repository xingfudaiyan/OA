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
    public partial class FrontScoreDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //ddlDataBind();
                PageInit();
                ViewState["BackUrl"] = Request.UrlReferrer.ToString();
            }
        }

        //protected void ddlDataBind()
        //{
        //    DataTable dt = TechEmScoreInfo.getYearddl();
        //    ddlYear.DataSource = dt;
        //    ddlYear.DataTextField = "YearName";
        //    ddlYear.DataValueField = "YearId";
        //    DataRow row = dt.NewRow();
        //    row["YearName"] = "请选择年份";
        //    dt.Rows.InsertAt(row, 0);
        //    ddlYear.DataBind();

        //    DataTable dt1 = TechEmScoreInfo.getMonthddl();
        //    ddlMonth.DataSource = dt1;
        //    ddlMonth.DataTextField = "MonthNames";
        //    ddlMonth.DataValueField = "MonthId";
        //    DataRow row1 = dt1.NewRow();
        //    row1["MonthNames"] = "请选择月份";
        //    dt1.Rows.InsertAt(row1, 0);
        //    ddlMonth.DataBind();
        //}

        protected void PageInit()
        {
            int fsid = Convert.ToInt32(Request["FrontScoreId"].ToString());
            FrontScoreInfo fs = new FrontScoreInfo(fsid);

            EmployeeInfo em = new EmployeeInfo(Convert.ToInt32(fs.EmployeeId));
            lblName.Text = em.EmployeeName.ToString();
            PositionInfo position = new PositionInfo(Convert.ToInt32(em.PositionId));
            lblPosition.Text = position.PositionName.ToString();
            DepartInfo depart = new DepartInfo(Convert.ToInt32(em.DepartId));
            lblDepart.Text = depart.DepartName.ToString();

            //ddlYear.SelectedValue = fs.YearId.ToString();
            //ddlMonth.SelectedValue = fs.MonthId.ToString();

            YearInfo year = new YearInfo(Convert.ToInt32(fs.YearId));
            MonthInfo month = new MonthInfo(Convert.ToInt32(fs.MonthId));
            lblDate.Text = year.YearName + "年" + month.MonthNames + "月";

            lblSelffs1.Text = fs.Selffs1.ToString();
            lblSelffs2.Text = fs.Selffs2.ToString();
            lblSelffs3.Text = fs.Selffs3.ToString();
            lblSelffs4.Text = fs.Selffs4.ToString();
            lblSelffs5.Text = fs.Selffs5.ToString();
            lblSelffs6.Text = fs.Selffs6.ToString();
            lblSelffs7.Text = fs.Selffs7.ToString();
           
            lblSelffs9.Text = fs.Selffs9.ToString();
            lblSelffs10.Text = fs.Selffs10.ToString();
            lblSelffs11.Text = fs.Selffs11.ToString();
            lblSelffs12.Text = fs.Selffs12.ToString();
            lblSelffs13.Text = fs.Selffs13.ToString();
            lblSelffs14.Text = fs.Selffs14.ToString();
            lblSelffs15.Text = fs.Selffs15.ToString();
            lblSelffs16.Text = fs.Selffs16.ToString();
            lblSelffs17.Text = fs.Selffs17.ToString();
            lblSelffs18.Text = fs.Selffs18.ToString();
            lblSelffs19.Text = fs.Selffs19.ToString();
            lblSelffs20.Text = fs.Selffs20.ToString();
            lblSelffs21.Text = fs.Selffs21.ToString();
          

            lblUpfs1.Text = fs.Upfs1.ToString();
            lblUpfs2.Text = fs.Upfs2.ToString();
            lblUpfs3.Text = fs.Upfs3.ToString();
            lblUpfs4.Text = fs.Upfs4.ToString();
            lblUpfs5.Text = fs.Upfs5.ToString();
            lblUpfs6.Text = fs.Upfs6.ToString();
            lblUpfs7.Text = fs.Upfs7.ToString();
          
            lblUpfs9.Text = fs.Upfs9.ToString();
            lblUpfs10.Text = fs.Upfs10.ToString();
            lblUpfs11.Text = fs.Upfs11.ToString();
            lblUpfs12.Text = fs.Upfs12.ToString();
            lblUpfs13.Text = fs.Upfs13.ToString();
            lblUpfs14.Text = fs.Upfs14.ToString();
            lblUpfs15.Text = fs.Upfs15.ToString();
            lblUpfs16.Text = fs.Upfs16.ToString();
            lblUpfs17.Text = fs.Upfs17.ToString();
            lblUpfs18.Text = fs.Upfs18.ToString();
            lblUpfs19.Text = fs.Upfs19.ToString();
            lblUpfs20.Text = fs.Upfs20.ToString();
            lblUpfs21.Text = fs.Upfs21.ToString();
          

            lblSectfs1.Text = fs.Secfs1.ToString();
            lblSectfs2.Text = fs.Secfs2.ToString();
            lblSectfs3.Text = fs.Secfs3.ToString();
            lblSectfs4.Text = fs.Secfs4.ToString();
            lblSectfs5.Text = fs.Secfs5.ToString();
            lblSectfs6.Text = fs.Secfs6.ToString();
            lblSectfs7.Text = fs.Secfs7.ToString();
          
            lblSectfs9.Text = fs.Secfs9.ToString();
            lblSectfs10.Text = fs.Secfs10.ToString();
            lblSectfs11.Text = fs.Secfs11.ToString();
            lblSectfs12.Text = fs.Secfs12.ToString();
            lblSectfs13.Text = fs.Secfs13.ToString();
            lblSectfs14.Text = fs.Secfs14.ToString();
            lblSectfs15.Text = fs.Secfs15.ToString();
            lblSectfs16.Text = fs.Secfs16.ToString();
            lblSectfs17.Text = fs.Secfs17.ToString();
            lblSectfs18.Text = fs.Secfs18.ToString();
            lblSectfs19.Text = fs.Secfs19.ToString();
            lblSectfs20.Text = fs.Secfs20.ToString();
            lblSectfs21.Text = fs.Secfs21.ToString();

            lblTotalScore.Text = fs.TotalScore.ToString();

            
            if (fs.EvaluateLevelId.ToString() != "")
            {
                EvaluateLevelInfo le = new EvaluateLevelInfo(Convert.ToInt32(fs.EvaluateLevelId));
                lblLevel.Text = le.EvaluateName.ToString();
            }
            else
            {
                lblLevel.Text = "";
            }
            lblViews.Text = fs.UpViews.ToString();
         
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(ViewState["BackUrl"].ToString());
        }
    }
}
