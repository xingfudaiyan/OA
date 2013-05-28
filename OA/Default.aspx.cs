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

namespace OA
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string strUserName = Request["textuser"].ToString();
            string strUserPsd = Request["password"].ToString();
            //Console.WriteLine("ok");
            
            //Console.WriteLine(strUserName + strUserName);
            //Response.Write("ok"); 

            if (strUserName == "" || strUserPsd == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('用户密码不为空!');</script>");
            }
            else
            {
                
                bool IsUserLogin = MasterInfo.IsUser(strUserName, strUserPsd);
                if (IsUserLogin)
                {
                    
                        int EmployeeId = Convert.ToInt32(EmployeeInfo.getEmployeeOfMaster(strUserName, strUserPsd));
                        EmployeeInfo em = new EmployeeInfo(EmployeeId);
                        string strRoleName = DayInfo.getRoleNameOfMaster(strUserName);
                    
                        DepartInfo depart = new DepartInfo(em.DepartId);
                    
                        Session["userName"] = strUserName;
                        Session["userPsd"] = strUserPsd;
                        Session["Employee"] = em;
                        Session["EmployeeId"] = em.EmployeeId;
                        Session["EmployeeName"] = em.EmployeeName;
                        Session["RoleName"] = strRoleName;
                        Session["DepartName"] = depart.DepartName.ToString();
                        Session["DepartId"] = em.DepartId;
                        Session["PositionId"] = em.PositionId;
                    
                   
                        Response.Redirect("main.aspx");
                    
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('用户密码错误!');</script>");

                }
            }
            
        }

    }
}
