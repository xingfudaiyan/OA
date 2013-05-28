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
    public partial class ScoreIndex : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EmployeeInfo em = (EmployeeInfo)Session["Employee"];
            string strDepartName = Session["DepartName"].ToString();
            string strRoleName = Session["RoleName"].ToString();
            //获取登陆用户的角色
            switch (strDepartName)
            {
                case "技术部":
                    if (strRoleName == "部门经理")
                        Response.Redirect("TechMaScoreGv.aspx");
                    else
                        Response.Redirect("TechEmScoregv.aspx");
                    break;
                case "总经办":
                    if (strRoleName == "总经理")
                        Response.Redirect("ManagerGv.aspx");
                    break;
                case "市场部":
                    if (em.EmployeeName == "王娇")
                        Response.Redirect("BASEmScoregv.aspx");
                    else if (em.EmployeeName == "何春")
                        Response.Redirect("MarketScoregv.aspx");
                    break;
                case "综合部":
                    if (em.EmployeeName == "马琪")
                        Response.Redirect("FrontScoregv.aspx");
                    else if (em.EmployeeName == "白杨")
                        Response.Redirect("AsistantScoregv.aspx");
                    else if (em.EmployeeName == "宋红祥")
                        Response.Redirect("DriveScoregv.aspx");
                    else if (em.EmployeeName == "张彩")
                        Response.Redirect("NurseScoregv.aspx");
                    break;
                default:
                    Response.Redirect("tab.aspx");
                    break;


            }
        }
    }
}
