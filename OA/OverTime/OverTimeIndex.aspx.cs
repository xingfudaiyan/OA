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

namespace OA.OverTime
{
    public partial class OverTime : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            string strDepartName = Session["DepartName"].ToString();
            string strRoleName = Session["RoleName"].ToString();
            if (strDepartName == "技术部")
            {
                if (strRoleName == "部门经理")
                {
                    Response.Redirect("OverTimeMagv.aspx");
                }
                else
                {
                    Response.Redirect("OverTimeEmgv.aspx");
                }
            }
            else
            {
                Response.Redirect("AllOverTime.aspx");
            }
           
        }
    }
}
