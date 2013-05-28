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
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["SortExpression"] = "DepartName";
                ViewState["SortDir"] = "DESC";
                gvDataBind();
                ddlBind();

            }
        }

        protected void gvDataBind()
        {
            DataTable dt = ContactInfo.getContactListVW();
            DataView view = dt.DefaultView;
            string sort = (string)ViewState["SortExpression"] + " " + (string)ViewState["SortDir"];
            view.Sort = sort;
            
            if (dt.Rows.Count == 0)
            {
                dt.Rows.Add(dt.NewRow());
                UI.BindCtrl(view, gvContact, AspNetPager1);
                gvContact.Rows[0].Visible = false;
            }
            else
            {
                UI.BindCtrl(view, gvContact, AspNetPager1);
            }
        }

        protected void ddlBind()
        {
            //绑定ddlDepart
            DataTable dt4 = EmployeeInfo.getDepartList();
            ddlDepart.DataTextField = "DepartName";
            ddlDepart.DataValueField = "DepartId";
            ddlDepart.DataSource = dt4;
            DataRow dr4 = dt4.NewRow();
            dr4["DepartName"] = "请选择部门";
            dt4.Rows.InsertAt(dr4, 0);
            ddlDepart.DataBind();
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            gvDataBind();
        }

        protected void gvContact_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //鼠标移动到每项时颜色交替效果   
                e.Row.Attributes.Add("onmouseover", "e=this.style.backgroundColor; this.style.backgroundColor='#c1ebff'");
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=e");   

                //设置悬浮鼠标指针形状为"小手"   
                e.Row.Attributes["style"] = "Cursor:hand";
            }

        }

        protected void gvContact_Sorting(object sender, GridViewSortEventArgs e)
        {
            //首先判断当前的排序表达式（字段），是否为当前当前的表达式。。。
            if (ViewState["SortExpression"].ToString() == e.SortExpression.ToString())
            {
                //判断当前的排序方式是否为倒序（DESC），如果是则将排序方式设为升序（ASC），原因是：因为我们要做双向排序！
                if (ViewState["SortDir"].ToString() == "DESC")
                {
                    ViewState["SortDir"] = "ASC";
                }
                else
                {
                    ViewState["SortDir"] = "DESC";
                }
            }
            else
            {
                ViewState["SortExpression"] = e.SortExpression; //将触发到表达式赋值给ViewState["SortExpression"];
            }
            gvDataBind();

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string EmployeeName = txtName.Text.ToString();
            if (EmployeeName != ""&&ddlDepart.SelectedValue=="")
            {
                DataTable dt = ContactInfo.EmployeeIdOfName(EmployeeName);
                DataView view = dt.DefaultView;
                string sort = (string)ViewState["SortExpression"] + " " + (string)ViewState["SortDir"];
                view.Sort = sort;

                if (dt.Rows.Count == 0)
                {
                    dt.Rows.Add(dt.NewRow());
                    UI.BindCtrl(view, gvContact, AspNetPager1);
                    gvContact.Rows[0].Visible = false;
                }
                else
                {
                    UI.BindCtrl(view, gvContact, AspNetPager1);
                }

            }
            else if (ddlDepart.SelectedValue!=""&&EmployeeName=="")
            {
                int departid = Convert.ToInt32(ddlDepart.SelectedValue);
                DataTable dt = ContactInfo.ContactOfDepart(departid);
                DataView view = dt.DefaultView;
                string sort = (string)ViewState["SortExpression"] + " " + (string)ViewState["SortDir"];
                view.Sort = sort;

                if (dt.Rows.Count == 0)
                {
                    dt.Rows.Add(dt.NewRow());
                    UI.BindCtrl(view, gvContact, AspNetPager1);
                    gvContact.Rows[0].Visible = false;
                }
                else
                {
                    UI.BindCtrl(view, gvContact, AspNetPager1);
                }
            }
            else if (ddlDepart.SelectedValue != "" && EmployeeName != "")
            {
                string EmployeeN = txtName.Text.ToString();
                int deid = Convert.ToInt32(ddlDepart.SelectedValue);
                DataTable dt = ContactInfo.ContactOfBoth(deid, EmployeeN);
                DataView view = dt.DefaultView;
                string sort = (string)ViewState["SortExpression"] + " " + (string)ViewState["SortDir"];
                view.Sort = sort;

                if (dt.Rows.Count == 0)
                {
                    dt.Rows.Add(dt.NewRow());
                    UI.BindCtrl(view, gvContact, AspNetPager1);
                    gvContact.Rows[0].Visible = false;
                }
                else
                {
                    UI.BindCtrl(view, gvContact, AspNetPager1);
                }

            }
            else
            {
                gvDataBind();
            }

            
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            gvDataBind();
        }
    }
}
