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
    public partial class Employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                IsRole();
                gvDataBind();
            }
        }

        protected void gvDataBind()
        {
            DataTable dt = EmployeeInfo.EmployeeList();
            if (dt.Rows.Count == 0)
            {
                dt.Rows.Add(dt.NewRow());
                UI.BindCtrl(dt.DefaultView, gvEmployee, AspNetPager1);
                gvEmployee.Rows[0].Visible = false;
            }
            else
            {
                UI.BindCtrl(dt.DefaultView, gvEmployee, AspNetPager1);
            }
           
           
        }

        protected void IsRole()
        {
            string strDepartName = Session["DepartName"].ToString();
            string strRoleName = Session["RoleName"].ToString();
            if ((strRoleName == "总经理") || (strRoleName == "部门经理" && strDepartName=="综合部"))
            {
                btnAddEmployee.Visible = true;
            }
            else
            {
                btnAddEmployee.Visible = false;
            }
            
        }

        protected void gvEmployee_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int emid = Convert.ToInt32(gvEmployee.DataKeys[e.RowIndex]["EmployeeId"]);
            EmployeeInfo em = new EmployeeInfo(emid);
            int contactid=em.ContactId;      
            try
            {         
                EmployeeInfo.EmployeeDel(Convert.ToInt32(gvEmployee.DataKeys[e.RowIndex]["EmployeeId"]));
                gvDataBind();
                if (Convert.ToString(contactid) !="")
                {
                    ContactInfo.DelContact(contactid);
                }
               
            }
            catch (Exception Ex)
            {
                lblMsg.Text = Ex.Message;
            }
        }

    

        protected void btnAddEmployee_Click(object sender, EventArgs e)
        {
           

            Response.Redirect("AddEmployee.aspx");
        }

        protected void gvEmployee_RowDataBound(object sender, GridViewRowEventArgs e)
        {

            for (int i = 0; i < gvEmployee.Rows.Count; i++)
            {
                string employeeid = gvEmployee.DataKeys[i]["EmployeeId"].ToString();
                ((HyperLink)gvEmployee.Rows[i].FindControl("hplEmployeeName")).Attributes.Add("onclick", "window.open('PerEmployee.aspx?param=" + employeeid + "','newwin','width=500,height=500');");
                ((HyperLink)gvEmployee.Rows[i].FindControl("hplEmployeeName")).Attributes.Add("onmouseover", "this.style.cursor='hand';");
            }

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                
                string strRoleName = Session["RoleName"].ToString();
                string strDepartName = Session["DepartName"].ToString();
                if ((strRoleName == "总经理") || (strRoleName == "部门经理" && strDepartName=="综合部"))
                {
                    gvEmployee.Columns[6].Visible = true;
                    gvEmployee.Columns[7].Visible = true;
                    e.Row.Cells[6].Visible = true;
                    e.Row.Cells[7].Visible = true;
                }
                else
                {
                    gvEmployee.Columns[6].Visible = false;
                    gvEmployee.Columns[7].Visible = false;
                    e.Row.Cells[6].Visible = false;
                    e.Row.Cells[7].Visible = false;
                }
            }

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //鼠标移动到每项时颜色交替效果   
                e.Row.Attributes.Add("onmouseover", "e=this.style.backgroundColor; this.style.backgroundColor='#c1ebff'");
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=e");

                //设置悬浮鼠标指针形状为"小手"   
                e.Row.Attributes["style"] = "Cursor:hand";
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            
            int emId = Convert.ToInt32(((Button)sender).CommandArgument.ToString());
            Response.Redirect("EditEmployee.aspx?Employeeid=" + emId);
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            gvDataBind();
        }

      

    }
}
