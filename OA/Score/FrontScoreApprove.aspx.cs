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
    public partial class FrontScoreApprove : System.Web.UI.Page
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
            
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            int fsid = Convert.ToInt32(Request["FrontScoreId"].ToString());
            FrontScoreInfo fs = new FrontScoreInfo(fsid);
            fs.Upfs1 = Request.Form["Upfs1"].ToString();
            fs.Upfs2 = Request.Form["Upfs2"].ToString();
            fs.Upfs3 = Request.Form["Upfs3"].ToString();
            fs.Upfs4 = Request.Form["Upfs4"].ToString();
            fs.Upfs5 = Request.Form["Upfs5"].ToString();
            fs.Upfs6 = Request.Form["Upfs6"].ToString();
            fs.Upfs7 = Request.Form["Upfs7"].ToString();
            fs.Upfs8 = Request.Form["Upfs8"].ToString();
            fs.Upfs9 = Request.Form["Upfs9"].ToString();
            fs.Upfs10 = Request.Form["Upfs10"].ToString();
            fs.Upfs11 = Request.Form["Upfs11"].ToString();
            fs.Upfs12 = Request.Form["Upfs12"].ToString();
            fs.Upfs13 = Request.Form["Upfs13"].ToString();
            fs.Upfs14 = Request.Form["Upfs14"].ToString();
            fs.Upfs15 = Request.Form["Upfs15"].ToString();
            fs.Upfs16 = Request.Form["Upfs16"].ToString();
            fs.Upfs17 = Request.Form["Upfs17"].ToString();
            fs.Upfs18 = Request.Form["Upfs18"].ToString();
            fs.Upfs19 = Request.Form["Upfs19"].ToString();
            fs.Upfs20 = Request.Form["Upfs20"].ToString();
            fs.Upfs21 = Request.Form["Upfs21"].ToString();

            fs.Secfs1 = Convert.ToString(Math.Round(float.Parse(lblSelffs1.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upfs1"].ToString()), 2) * 0.6);
            fs.Secfs2 = Convert.ToString(Math.Round(float.Parse(lblSelffs2.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upfs2"].ToString()), 2) * 0.6);
            fs.Secfs3 = Convert.ToString(Math.Round(float.Parse(lblSelffs3.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upfs3"].ToString()), 2) * 0.6);
            fs.Secfs4 = Convert.ToString(Math.Round(float.Parse(lblSelffs4.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upfs4"].ToString()), 2) * 0.6);
            fs.Secfs5 = Convert.ToString(Math.Round(float.Parse(lblSelffs5.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upfs5"].ToString()), 2) * 0.6);
            fs.Secfs6 = Convert.ToString(Math.Round(float.Parse(lblSelffs6.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upfs6"].ToString()), 2) * 0.6);
            fs.Secfs7 = Convert.ToString(Math.Round(float.Parse(lblSelffs7.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upfs7"].ToString()), 2) * 0.6);

            fs.Secfs9 = Convert.ToString(Math.Round(float.Parse(lblSelffs9.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upfs9"].ToString()), 2) * 0.6);
            fs.Secfs10 = Convert.ToString(Math.Round(float.Parse(lblSelffs10.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upfs10"].ToString()), 2) * 0.6);
            fs.Secfs11 = Convert.ToString(Math.Round(float.Parse(lblSelffs11.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upfs11"].ToString()), 2) * 0.6);
            fs.Secfs12 = Convert.ToString(Math.Round(float.Parse(lblSelffs12.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upfs12"].ToString()), 2) * 0.6);
            fs.Secfs13 = Convert.ToString(Math.Round(float.Parse(lblSelffs13.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upfs13"].ToString()), 2) * 0.6);
            fs.Secfs14 = Convert.ToString(Math.Round(float.Parse(lblSelffs14.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upfs14"].ToString()), 2) * 0.6);
            fs.Secfs15 = Convert.ToString(Math.Round(float.Parse(lblSelffs15.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upfs15"].ToString()), 2) * 0.6);
            fs.Secfs16 = Convert.ToString(Math.Round(float.Parse(lblSelffs16.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upfs16"].ToString()), 2) * 0.6);
            fs.Secfs17 = Convert.ToString(Math.Round(float.Parse(lblSelffs17.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upfs17"].ToString()), 2) * 0.6);
            fs.Secfs18 = Convert.ToString(Math.Round(float.Parse(lblSelffs18.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upfs18"].ToString()), 2) * 0.6);
            fs.Secfs19 = Convert.ToString(Math.Round(float.Parse(lblSelffs19.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upfs19"].ToString()), 2) * 0.6);
            fs.Secfs20 = Convert.ToString(Math.Round(float.Parse(lblSelffs20.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upfs20"].ToString()), 2) * 0.6);
            fs.Secfs21 = Convert.ToString(Math.Round(float.Parse(lblSelffs21.Text.ToString()), 2) * 0.4 + Math.Round(float.Parse(Request.Form["Upfs21"].ToString()), 2) * 0.6);


            fs.TotalScore = Request.Form["hid"].ToString();

            float Score = float.Parse(Request.Form["hid"].ToString());
            if (Score > 90)
            {
                fs.EvaluateLevelId = 2;
            }
            else if (Score > 75 && Score < 90)
            {
                fs.EvaluateLevelId = 3;
            }
            else if (Score > 60 && Score < 75)
            {
                fs.EvaluateLevelId = 4;
            }
            else if (Score < 60)
            {
                fs.EvaluateLevelId = 5;
            }
            fs.IsSubmit = 2;
            fs.UpViews = Request.Form["UpViews"].ToString();
            fs.Save();
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('保存成功！');</script>");
            
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManagerHelp.aspx");
        }
    }
}
