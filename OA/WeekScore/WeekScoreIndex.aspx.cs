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
namespace OA.WeekScore
{
    public partial class WeekScoreIndex : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strDepartName = Session["DepartName"].ToString();
            string strRoleName = Session["RoleName"].ToString();
            if (strDepartName == "技术部")
            {
                if (strRoleName == "部门经理")
                {
                    Response.Redirect("ScoreApprovegv.aspx");
                }
                else
                {
                    Response.Redirect("WeekScore.aspx");
                }
            }
            else if (strRoleName == "总经理")
            {
                Response.Redirect("AllScores.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('您没有操作权限');</script>");
            }
           
        }
    }
}
