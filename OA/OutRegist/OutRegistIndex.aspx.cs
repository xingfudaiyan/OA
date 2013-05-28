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

namespace OA.OutRegist
{
    public partial class OutRegistIndex : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String strRoleName = Session["RoleName"].ToString();
            if (strRoleName == "员工")
            {
                Response.Redirect("OutApply.aspx");
            }
            else if (strRoleName == "部门经理")
            {
                Response.Redirect("OutApprove.aspx");
            }
            else
            {
                Response.Redirect("OutAll.aspx");
            }
        }
    }
}
