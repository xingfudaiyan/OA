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
    public partial class OutApply : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["SortExpression"] = "OutDate";
                ViewState["SortDir"] = "DESC";
                gvDataBind();
            }
        }

        protected void gvDataBind()
        {
            DataTable dt = OutRegistInfo.getOutRegistApply(Session["EmployeeName"].ToString());
            DataView view = dt.DefaultView;
            string sort = (string)ViewState["SortExpression"] + " " + (string)ViewState["SortDir"];
            view.Sort = sort;

            if (dt.Rows.Count == 0)
            {
                dt.Rows.Add(dt.NewRow());
                UI.BindCtrl(dt.DefaultView, gvOutRegist, AspNetPager1);
                gvOutRegist.Rows[0].Visible = false;
            }
            else
            {
                UI.BindCtrl(dt.DefaultView, gvOutRegist, AspNetPager1);
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            OutRegistInfo ore = new OutRegistInfo();
            ore.BackTime = "";
            ore.Memo = "";
            ore.OutContent = "";
            ore.OutDate = "";
            ore.OutTime = "";
            ore.OutTool = "";
            ore.State = 0;
            ore.DepartName = Session["DepartName"].ToString();
            ore.ApplyName = Session["EmployeeName"].ToString();
            ore.Save();
            gvDataBind();
        }

        protected void gvOutRegist_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvOutRegist.EditIndex = e.NewEditIndex;
            gvDataBind();
        }

        protected void gvOutRegist_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvOutRegist.EditIndex = -1;
            gvDataBind();
        }

        protected void gvOutRegist_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int outid = Convert.ToInt32(gvOutRegist.DataKeys[e.RowIndex].Value);
            OutRegistInfo.DelOutRegist(outid);
            gvDataBind();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int outid = Convert.ToInt32(((Button)sender).CommandArgument.ToString());
            OutRegistInfo ore = new OutRegistInfo(outid);
            ore.State = 1;
            ore.Save();
            gvDataBind();
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('提交成功！');</script>");
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            gvDataBind();
        }

        protected void gvOutRegist_Sorting(object sender, GridViewSortEventArgs e)
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

        protected void gvOutRegist_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int outid = Convert.ToInt32(gvOutRegist.DataKeys[e.RowIndex].Value);
            TextBox txtOutDate = gvOutRegist.Rows[e.RowIndex].FindControl("txtOutDate") as TextBox;
            TextBox txtOutContent = gvOutRegist.Rows[e.RowIndex].FindControl("txtOutContent") as TextBox;
            TextBox txtOutTime = gvOutRegist.Rows[e.RowIndex].FindControl("txtOutTime") as TextBox;
            TextBox txtBackTime = gvOutRegist.Rows[e.RowIndex].FindControl("txtBackTime") as TextBox;
            TextBox txtOutTool = gvOutRegist.Rows[e.RowIndex].FindControl("txtOutTool") as TextBox;
            TextBox txtMemo = gvOutRegist.Rows[e.RowIndex].FindControl("txtMemo") as TextBox;
            try
            {
                OutRegistInfo ore = new OutRegistInfo(outid);
                ore.BackTime = txtBackTime.Text.ToString();
                ore.Memo = txtMemo.Text.ToString();
                ore.OutContent = txtOutContent.Text.ToString();
                ore.OutDate = txtOutDate.Text.ToString();
                ore.OutTime = txtOutTime.Text.ToString();
                ore.OutTool = txtOutTool.Text.ToString();
                ore.Save();
                gvOutRegist.EditIndex = -1;
                gvDataBind();
            }
            catch (Exception Ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Save", "alert('更新失败：" + Ex.Message + "');", true);
            }
        }

        protected void gvOutRegist_RowDataBound(object sender, GridViewRowEventArgs e)
        {

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //鼠标移动到每项时颜色交替效果   
                e.Row.Attributes.Add("onmouseover", "e=this.style.backgroundColor; this.style.backgroundColor='#c1ebff'");
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=e");

                //设置悬浮鼠标指针形状为"小手"   
                e.Row.Attributes["style"] = "Cursor:hand";
                Button btnSubmit = e.Row.FindControl("btnSubmit") as Button;
                Button btnDelete = e.Row.FindControl("btnDelete") as Button;
                Button btnEdit = e.Row.FindControl("btnEdit") as Button;
                if(!Convert.IsDBNull(gvOutRegist.DataKeys[e.Row.RowIndex].Value))
                {
                int outid = Convert.ToInt32(gvOutRegist.DataKeys[e.Row.RowIndex].Value);
                OutRegistInfo ore = new OutRegistInfo(outid);
                if (ore.State != 0)
                    {
                        btnSubmit.Enabled = false;
                        btnDelete.Enabled = false;
                        btnEdit.Enabled = false;
                        Label lblState = e.Row.FindControl("lblState") as Label;

                        switch (ore.State)
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
                        //if (txtMemo != null)
                        //{
                        //    txtMemo.Enabled = false;
                        //}
                        //if (txtOutContent != null)
                        //{
                        //    txtOutContent.Enabled = false;
                        //}
                        //if (txtOutDate != null)
                        //{
                        //    txtOutDate.Enabled = false;
                        //}
                        //if (txtOutTime != null)
                        //{
                        //    txtOutTime.Enabled = false;
                        //}
                        //if (txtOutTool!= null)
                        //{
                        //    txtOutTool.Enabled = false;
                        //}
                       
                    }
                }

              
            }
        }
    }
}
