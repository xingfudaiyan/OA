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

namespace OA.FileApply
{
    public partial class DepartApply : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["SortExpression"] = "FileType";
                ViewState["SortDir"] = "ASC";
                gvDataBind();
            }
        }

        protected void gvDataBind()
        {
            DataTable dt = FileApplyInfo.getFileApply(Session["EmployeeName"].ToString());
            DataView view = dt.DefaultView;
            string sort = (string)ViewState["SortExpression"] + " " + (string)ViewState["SortDir"];
            view.Sort = sort;

            if (dt.Rows.Count == 0)
            {
                dt.Rows.Add(dt.NewRow());
                UI.BindCtrl(dt.DefaultView, gvFileApply, AspNetPager1);
                gvFileApply.Rows[0].Visible = false;
            }
            else
            {
                UI.BindCtrl(dt.DefaultView, gvFileApply, AspNetPager1);
            }
        }


        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddFile.aspx");
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            gvDataBind();
        }

        protected void gvFileApply_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //鼠标移动到每项时颜色交替效果   
                e.Row.Attributes.Add("onmouseover", "e=this.style.backgroundColor; this.style.backgroundColor='#c1ebff'");
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=e");
                //设置悬浮鼠标指针形状为"小手"   
                e.Row.Attributes["style"] = "Cursor:hand";

                if (!Convert.IsDBNull(gvFileApply.DataKeys[e.Row.RowIndex].Value))
                {
                    int fid = Convert.ToInt32(gvFileApply.DataKeys[e.Row.RowIndex].Value);

                    FileApplyInfo fa = new FileApplyInfo(fid);
                    if (fa.State != 0)
                    {
                        Button btnSubmit = e.Row.FindControl("btnSubmit") as Button;
                        Button btnEdit = e.Row.FindControl("btnEdit") as Button;
                        Button btnDelete = e.Row.FindControl("btnDelete") as Button;
                        btnSubmit.Enabled = false;
                        btnEdit.Enabled = false;
                        btnDelete.Enabled = false;
                    }

                    Label lblState = e.Row.FindControl("lblState") as Label;

                    switch (fa.State)
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
                        default:
                            lblState.Text = "其他状态";
                            break;
                    }
                }
            }
        }

        protected void gvFileApply_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int FileApplyId = Convert.ToInt32(gvFileApply.DataKeys[e.RowIndex].Value);
            FileApplyInfo.FileApplyDel(FileApplyId);
            gvDataBind();
        }

        protected void gvFileApply_Sorting(object sender, GridViewSortEventArgs e)
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

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
           
            int fid = Convert.ToInt32(((Button)sender).CommandArgument.ToString());
            FileApplyInfo fa = new FileApplyInfo(fid);
            fa.State = 3;
            fa.Save();
            gvDataBind();
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            int FileId = Convert.ToInt32(((Button)sender).CommandArgument.ToString());
            Response.Redirect("EditFile.aspx?FileApplyId=" + FileId);
        }
    }
}
