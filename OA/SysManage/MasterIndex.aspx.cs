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

namespace OA.SysManage
{
    public partial class MasterIndex : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int emid = Convert.ToInt32(Session["EmployeeId"]);
            bool IsAction = Common.IsActionNameOfMaster(emid, "提交用户权限");

            
                string strRoleName = Session["RoleName"].ToString();
                if(strRoleName=="总经理")
                {
                    Response.Redirect("RecvMaster.aspx");
                }
                else if(IsAction)
                {
                    Response.Redirect("Master.aspx");
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('当前角色没有操作权限');</script>");
                }
            }
          
    }
}
