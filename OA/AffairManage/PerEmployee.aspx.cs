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
    public partial class PerEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bool isaction = IsRole();
                if(isaction)
                {
                    EmployeeBind();
                }
            }
        }

        protected bool IsRole()
        {
            int emid = Convert.ToInt32(Session["EmployeeId"]);
           
            int RecvId = Convert.ToInt32(Request.QueryString["param"].ToString());
            if (RecvId == emid)
            {
                return true;
            }
            else
            {
                bool isaction = Common.IsActionNameOfMaster(emid, "查询员工信息");
                if (!isaction)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('您没有分配查看其他员工详细信息的权限！');</script>");
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }



        private void EmployeeBind()
        {
            int Employeeid = Convert.ToInt32(Request.QueryString["param"].ToString());
           

            DataTable dt = EmployeeInfo.getEmployeeList(Employeeid);
            lblName.Text= dt.Rows[0]["EmployeeName"].ToString();
            lblAddress.Text = dt.Rows[0]["Address"].ToString();
            lblBirthday.Text = dt.Rows[0]["Birthday"].ToString();
            lblCertificate.Text = dt.Rows[0]["Certificate"].ToString();
            lblDepart.Text = dt.Rows[0]["DepartName"].ToString();
            lblEducation.Text = dt.Rows[0]["EducationName"].ToString();
            
            
           
            lblIdentyNum.Text = dt.Rows[0]["IdentyNum"].ToString();
            lblJobtime.Text = dt.Rows[0]["JobTime"].ToString();
            lblJointime.Text = dt.Rows[0]["JoinTime"].ToString();
            lblLanguage.Text = dt.Rows[0]["LanguageName"].ToString();
            lblMajor.Text = dt.Rows[0]["Major"].ToString();
      
           
            lblNative.Text = dt.Rows[0]["NativePlace"].ToString();
            lblPolitics.Text = dt.Rows[0]["PoliticsName"].ToString();
            lblPosition.Text = dt.Rows[0]["PositionName"].ToString();
            lblSchool.Text = dt.Rows[0]["School"].ToString();
            if (dt.Rows[0]["Sex"].ToString() == "0")
            {
                lblSex.Text = "男";
            }
            else
            {
                lblSex.Text = "女";
            }
            if (dt.Rows[0]["Marrage"].ToString() == "0")
            {
                lblMarrage.Text = "未婚";
            }
            else
            {
                lblMarrage.Text = "已婚";
            }
            
            


        }

       
    }
}
