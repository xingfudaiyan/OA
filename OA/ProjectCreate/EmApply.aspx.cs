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

namespace OA.ProjectCreate
{
    public partial class EmApply : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["SortExpression"] = "State";
                ViewState["SortDir"] = "ASC";
                ddlBind();
                gvDataBind();
            }
        }

        protected void ddlBind()
        {
            DataTable dt = ClientInfo.getClientList();
            ddlClient.DataSource = dt;
            ddlClient.DataTextField = "ClientName";
            ddlClient.DataValueField = "ClientId";
            DataRow row = dt.NewRow();
            row["ClientName"] = "请选择客户名称:";
            dt.Rows.InsertAt(row, 0);
            ddlClient.DataBind();

        }

        protected void gvDataBind()
        {
            DataTable dt = ProjectCreateInfo.getProjectApply(Session["EmployeeName"].ToString());
            DataView view = dt.DefaultView;
            string sort = (string)ViewState["SortExpression"] + " " + (string)ViewState["SortDir"];
            view.Sort = sort;
            if (dt.Rows.Count == 0)
            {
                dt.Rows.Add(dt.NewRow());
                UI.BindCtrl(dt.DefaultView, gvSale, AspNetPager1);
                gvSale.Rows[0].Visible = false;
            }
            else
            {
                UI.BindCtrl(dt.DefaultView, gvSale, AspNetPager1);
            }
        }


        protected void btnSearch_Click(object sender, EventArgs e)
        {

                DataTable dt = ProjectCreateInfo.getProjectApplyOfClient(ddlClient.SelectedItem.Text, Session["EmployeeName"].ToString());
                DataView view = dt.DefaultView;
                string sort = (string)ViewState["SortExpression"] + " " + (string)ViewState["SortDir"];
                view.Sort = sort;

                if (dt.Rows.Count == 0)
                {
                    dt.Rows.Add(dt.NewRow());
                    UI.BindCtrl(view, gvSale, AspNetPager1);
                    gvSale.Rows[0].Visible = false;
                }
                else
                {
                    UI.BindCtrl(view, gvSale, AspNetPager1);
                }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("EmApply.aspx");
        }

        protected void btnAddSale_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddSale.aspx");
        }

        protected void gvSale_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //鼠标移动到每项时颜色交替效果   
                e.Row.Attributes.Add("onmouseover", "e=this.style.backgroundColor; this.style.backgroundColor='#c1ebff'");
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=e");
                //设置悬浮鼠标指针形状为"小手"   
                e.Row.Attributes["style"] = "Cursor:hand";

                if (!Convert.IsDBNull(gvSale.DataKeys[e.Row.RowIndex].Value))
                {
                    int cid = Convert.ToInt32(gvSale.DataKeys[e.Row.RowIndex].Value);
                    ProjectCreateInfo pc = new ProjectCreateInfo(cid);
                    if (pc.State != 0)
                    {
                        Button btnSubmit = e.Row.FindControl("btnSubmit") as Button;
                        Button btnEdit = e.Row.FindControl("btnEdit") as Button;
                        Button btnDelete = e.Row.FindControl("btnDelete") as Button;
                        btnSubmit.Enabled = false;
                        btnEdit.Enabled = false;
                        btnDelete.Enabled = false;
                    }

                    Label lblState = e.Row.FindControl("lblState") as Label;
                    switch (pc.State)
                    {
                        case 0:
                            lblState.Text = "未提交";
                            break;
                        case 1:
                            lblState.Text = "待部门领导审批";
                            break;
                        case 2:
                            lblState.Text = "部门:修正";
                            break;
                        case 3:
                            lblState.Text = "待总经理审批";
                            break;
                        case 4:
                            lblState.Text = "通过";
                            break;
                        case 5:
                            lblState.Text = "总经理:修正";
                            break;
                        case 6:
                            lblState.Text = "待技术部审批";
                            break;
                        case 7:
                            lblState.Text = "技术部修正";
                            break;
                        default:
                            lblState.Text = "其他状态";
                            break;
                    }
                }
            }
        }

        protected void gvSale_Sorting(object sender, GridViewSortEventArgs e)
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

        protected void gvSale_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int cid = Convert.ToInt32(gvSale.DataKeys[e.RowIndex].Value);
            ProjectCreateInfo.DelProjectApply(cid);
            gvDataBind();
        }

        protected void lbtnDetail_Click(object sender, EventArgs e)
        {
            int fid = Convert.ToInt32(((LinkButton)sender).CommandArgument.ToString());
            Response.Redirect("Detail.aspx?ProjectCreateId=" + fid);
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int fid = Convert.ToInt32(((Button)sender).CommandArgument.ToString());
            ProjectCreateInfo pc = new ProjectCreateInfo(fid);
            pc.ApplyTime = DateTime.Now.ToString();
            pc.State = 1;
            pc.Save();
            gvDataBind();
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            int cId = Convert.ToInt32(((Button)sender).CommandArgument.ToString());
            Response.Redirect("EditSale.aspx?ProjectCreateId=" + cId);
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            gvDataBind();
        }
    }
}
