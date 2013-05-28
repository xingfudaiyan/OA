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

namespace OA.Supply
{
    public partial class SupplyManage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["SortExpression"] = "SheetNum";
                ViewState["SortDir"] = "DESC";
                gvDataBind();
            }
        }

        protected void gvDataBind()
        {
           
            DataTable dt = SupplyInfo.getSupply();
            
            DataView view = dt.DefaultView;
            string sort = (string)ViewState["SortExpression"] + " " + (string)ViewState["SortDir"];
            view.Sort = sort;

            if (dt.Rows.Count == 0)
            {
                dt.Rows.Add(dt.NewRow());
                UI.BindCtrl(dt.DefaultView, gvSupply, AspNetPager1);
                gvSupply.Rows[0].Visible = false;
            }
            else
            {
                UI.BindCtrl(dt.DefaultView, gvSupply, AspNetPager1);
            }
        }


        protected void gvSupply_Sorting(object sender, GridViewSortEventArgs e)
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

        protected void gvSupply_RowDataBound(object sender, GridViewRowEventArgs e)
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


        protected void gvSupply_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int assetid = Convert.ToInt32(gvSupply.DataKeys[e.RowIndex].Value);
            SupplyInfo.DelSp(assetid);
            gvDataBind();
        }

        protected void gvSupply_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvSupply.EditIndex = e.NewEditIndex;
            gvDataBind();
        }

        protected bool PageInit(string txtNum,string lblNum)
        {
            if (txtNum!=lblNum&&SupplyInfo.IsSheetNum(txtNum))
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('该编号已存在！');</script>");
                return false;
            }
            else
            {
                return true;
            }
        }

        protected void gvSupply_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int spid = Convert.ToInt32(gvSupply.DataKeys[e.RowIndex].Value);
            SupplyInfo sp = new SupplyInfo(spid);

            TextBox txtSheetNum = gvSupply.Rows[e.RowIndex].FindControl("txtSheetNum") as TextBox;
            TextBox txtSupplyName = gvSupply.Rows[e.RowIndex].FindControl("txtSpName") as TextBox;
            if (PageInit(txtSheetNum.Text.ToString(),sp.SheetNum.ToString()))
            {
                try
                {
                    SupplyInfo sps = new SupplyInfo(spid);
                    sps.SheetNum = txtSheetNum.Text.ToString();
                    sps.SupplyName = txtSupplyName.Text.ToString();
                    sps.Save();
                    gvSupply.EditIndex = -1;
                    gvDataBind();
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('编辑成功！');</script>");

                }
                catch (Exception Ex)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Save", "alert('更新失败：" + Ex.Message + "');", true);
                }
            }
            
        }

        protected void gvSupply_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvSupply.EditIndex = -1;
            gvDataBind();
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            gvDataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddSupply.aspx");
        }
    }
}
