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

namespace OA.ApplyManage
{
    public partial class WeekIndex : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strRoleName = Session["RoleName"].ToString();
            if (strRoleName == "员工")
            {
                Response.Redirect("WeekApply.aspx");
            }
            else if(strRoleName=="总经理"||strRoleName=="部门经理")
            {
                Response.Redirect("WeekApprove.aspx");
            }
        }
    }
}
