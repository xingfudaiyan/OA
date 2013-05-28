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

namespace OA.ProjectCreate
{
    public partial class ProjectApproveIndex : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strRoleName = Session["RoleName"].ToString();
            string departName = Session["DepartName"].ToString();
            if (strRoleName == "总经理")
            {
                Response.Redirect("ManagerGv.aspx");
            }
            else if (strRoleName == "部门经理"&&departName!="技术部")
            {
                Response.Redirect("DepartGv.aspx");
            }
            else if (strRoleName == "部门经理" && departName == "技术部")
            {
                Response.Redirect("TechGv.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('员工角色不能审批');</script>");
            }
        }
    }
}
