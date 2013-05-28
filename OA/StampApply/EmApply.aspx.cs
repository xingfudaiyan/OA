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

namespace OA.StampApply
{
    public partial class StampApply : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["SortExpression"] = "ApplyTime";
                ViewState["SortDir"] = "DESC";
                gvDataBind();
            }
        }

      

        protected void gvDataBind()
        {
            DataTable dt = StampInfo.getStampApplyList(Session["EmployeeName"].ToString());
            DataView view = dt.DefaultView;
            string sort = (string)ViewState["SortExpression"] + " " + (string)ViewState["SortDir"];
            view.Sort = sort;

            if (dt.Rows.Count == 0)
            {
                dt.Rows.Add(dt.NewRow());
                UI.BindCtrl(dt.DefaultView, gvStamp, AspNetPager1);
                gvStamp.Rows[0].Visible = false;
            }
            else
            {
                UI.BindCtrl(dt.DefaultView, gvStamp, AspNetPager1);
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            StampInfo stamp = new StampInfo();
            stamp.ApplyName = Session["EmployeeName"].ToString();
            stamp.DepartName = Session["DepartName"].ToString();
            stamp.UseDate = DateTime.Now.ToString("yyyy-MM-dd");
            stamp.StampFileTypeId =1;
            stamp.StampTypeId = 1;
            stamp.Stampuse = "";
            stamp.Memo = "";
            stamp.ApplyTime = "";
            stamp.State = 0;
            stamp.Save();
            gvDataBind();
           
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int StampId = Convert.ToInt32(((Button)sender).CommandArgument.ToString());
            StampInfo stamp = new StampInfo(StampId);
            stamp.State = 1;
            stamp.ApplyTime = DateTime.Now.ToString("yyyy-MM-dd");
            stamp.Save();
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('提交成功！');</script>");
            gvDataBind();
            
        }

        protected void gvStamp_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Label lblState = e.Row.FindControl("lblState") as Label;
                Button btnSubmit = e.Row.FindControl("btnSubmit") as Button;
                Button btnDelete = e.Row.FindControl("btnDelete") as Button;
                Button btnEdit = e.Row.FindControl("btnEdit") as Button;
                if (!Convert.IsDBNull(gvStamp.DataKeys[e.Row.RowIndex].Value))
                {
                    StampInfo stamp = new StampInfo(Convert.ToInt32(gvStamp.DataKeys[e.Row.RowIndex].Value));
                    if (stamp.State != 0)
                    {
                        btnSubmit.Enabled = false;
                        btnDelete.Enabled = false;
                        btnEdit.Enabled = false;
                    }

                    switch (stamp.State)
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
                    DropDownList ddlFileType = e.Row.FindControl("ddlFileType") as DropDownList;
                    if (ddlFileType != null)
                    {
                        DataTable dt = StampInfo.getStampFileTypeList();
                        ddlFileType.DataSource = dt;
                        ddlFileType.DataTextField = "StampFileTypeName";
                        ddlFileType.DataValueField = "StampFileTypeId";
                        ddlFileType.DataBind();
                    }

                    DropDownList ddlStampType = e.Row.FindControl("ddlStampType") as DropDownList;
                    if (ddlStampType != null)
                    {
                        DataTable dt1 = StampInfo.getStampType();
                        ddlStampType.DataSource = dt1;
                        ddlStampType.DataTextField = "StampName";
                        ddlStampType.DataValueField = "StampTypeId";
                        ddlStampType.DataBind();
                    }

                    //鼠标移动到每项时颜色交替效果   
                    e.Row.Attributes.Add("onmouseover", "e=this.style.backgroundColor; this.style.backgroundColor='#c1ebff'");
                    e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=e");

                    //设置悬浮鼠标指针形状为"小手"   
                    e.Row.Attributes["style"] = "Cursor:hand";
                }
            
        }

    


        protected void gvStamp_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvStamp.EditIndex = e.NewEditIndex;
            gvDataBind();
        }

        protected void gvStamp_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int StampId = Convert.ToInt32(gvStamp.DataKeys[e.RowIndex].Value);
            TextBox txtApplyDate = gvStamp.Rows[e.RowIndex].FindControl("txtApplyDate") as TextBox;
            DropDownList ddlFileType = gvStamp.Rows[e.RowIndex].FindControl("ddlFileType") as DropDownList;
            DropDownList ddlStampType = gvStamp.Rows[e.RowIndex].FindControl("ddlStampType") as DropDownList;
            TextBox txtUse = gvStamp.Rows[e.RowIndex].FindControl("txtUse") as TextBox;
            TextBox txtMemo = gvStamp.Rows[e.RowIndex].FindControl("txtMemo") as TextBox;
            try
            {
                    StampInfo stamp = new StampInfo(StampId);
                   
                    stamp.UseDate = txtApplyDate.Text.ToString();
                    stamp.StampFileTypeId = Convert.ToInt32(ddlFileType.SelectedValue);
                    stamp.StampTypeId = Convert.ToInt32(ddlStampType.SelectedValue);
                    stamp.Stampuse = txtUse.Text.ToString();
                    stamp.Memo = txtMemo.Text.ToString();
                    stamp.Save();
                    gvStamp.EditIndex = -1;
                    gvDataBind();
            }
            catch (Exception Ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Save", "alert('更新失败：" + Ex.Message + "');", true);
            }
        }

        protected void gvStamp_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvStamp.EditIndex = -1;
            gvDataBind();
        }

        protected void gvStamp_Sorting(object sender, GridViewSortEventArgs e)
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

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            gvDataBind();
        }

        protected void gvStamp_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int StampId = Convert.ToInt32(gvStamp.DataKeys[e.RowIndex].Value);
            StampInfo.DelStamp(StampId);
            gvDataBind();
        }
    }
}
