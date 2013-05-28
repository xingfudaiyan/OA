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
namespace OA.TreatApply
{
    public partial class TreatIndex : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            int emid = Convert.ToInt32(Session["EmployeeId"]);
            bool ist1 = Common.IsActionNameOfMaster(emid, "审批招待费用");
            bool ist2 = Common.IsActionNameOfMaster(emid, "申请招待费用");

            string strRoleName = Session["RoleName"].ToString();
            string strDepartName = Session["DepartName"].ToString();
               //获取登陆用户的角色
                if (strDepartName=="财务部"&& ist1)
                {
                    Response.Redirect("TreatApprove2.aspx");
                }
                else if (ist2)
                {
                    if (strDepartName == "市场部" && strRoleName == "部门经理")
                    {
                        Response.Redirect("PreTreatApprove.aspx"); ;//市场部经理审批页面
                    }
                    else
                    {
                        Response.Redirect("PreTreatApply.aspx");//市场部员工
                    }

                  
                }
                else if (strRoleName == "总经理" && ist1)
                {
                    Response.Redirect("TreatApprove1.aspx");
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('当前角色没有操作权限');</script>");
                }
            }
          
    }
}
