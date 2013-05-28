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
namespace OA.OfferPrice
{
    public partial class PriceApprove1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["SortExpression"] = "SheetNum";
                ViewState["SortDir"] = "DESC";
                ddlProjectBind();
                gvDataBind();
            }
        }

        protected void ddlProjectBind()
        {
            DataTable dt = MainProjectCreateInfo.getProjectList();
            ddlProject.DataSource = dt;
            ddlProject.DataTextField = "ProjectName";
            ddlProject.DataValueField = "MainProjectCreateId";
            DataRow row = dt.NewRow();
            row["ProjectName"] = "请选择项目名称";
            dt.Rows.InsertAt(row, 0);
            ddlProject.DataBind();
        }

        protected void gvDataBind()
        {
            int emid = Convert.ToInt32(Session["EmployeeId"]);
            DataTable dt = OfferPriceInfo.getOfferPriceListOfApprove1(emid);

            DataView view = dt.DefaultView;
            string sort = (string)ViewState["SortExpression"] + " " + (string)ViewState["SortDir"];
            view.Sort = sort;

            if (dt.Rows.Count == 0)
            {
                dt.Rows.Add(dt.NewRow());
                UI.BindCtrl(dt.DefaultView, gvPrice, AspNetPager1);
                gvPrice.Rows[0].Visible = false;
            }
            else
            {
                UI.BindCtrl(dt.DefaultView, gvPrice, AspNetPager1);
            }
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            gvDataBind();
        }

        //查看详细
        protected void btnDetail_Click(object sender, EventArgs e)
        {
            int wksumId = Convert.ToInt32(((LinkButton)sender).CommandArgument.ToString());
            Response.Redirect("Detail.aspx?OfferPriceId=" + wksumId);
        }


        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int wksumId = Convert.ToInt32(((Button)sender).CommandArgument.ToString());
            Response.Redirect("PriceAp1.aspx?OfferPriceId=" + wksumId);
        }

        protected void gvPrice_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //鼠标移动到每项时颜色交替效果   
                e.Row.Attributes.Add("onmouseover", "e=this.style.backgroundColor; this.style.backgroundColor='#c1ebff'");
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=e");

                //设置悬浮鼠标指针形状为"小手"   
                e.Row.Attributes["style"] = "Cursor:hand";

                //申请人、申请时间
                Label lblState = e.Row.FindControl("lblState") as Label;
                Button btnSubmit = e.Row.FindControl("btnSubmit") as Button;
                Label lblApplyName = e.Row.FindControl("lblApplyName") as Label;
                Label lblApplyTime = e.Row.FindControl("lblApplyTime") as Label;

                if (!Convert.IsDBNull(gvPrice.DataKeys[e.Row.RowIndex].Value))
                {
                    int SaleId = Convert.ToInt32(gvPrice.DataKeys[e.Row.RowIndex].Value);
                    OfferPriceInfo pc = new OfferPriceInfo(SaleId);

                    if (pc.SendEmployeeName == "")
                    {
                        lblApplyName.Text = pc.PreEmployeeName.ToString();//市场部员工
                        lblApplyTime.Text = pc.PreApplyTime.ToString();
                    }
                    else if (pc.PreEmployeeName == "")
                    {
                        lblApplyName.Text = pc.SendEmployeeName.ToString();//市场部经理
                        lblApplyTime.Text = pc.ApplyTime.ToString();
                    }
                    int emid = Convert.ToInt32(Session["EmployeeId"]);
                    //绑定子GridView
                    GridView gv = e.Row.FindControl("GridView2") as GridView;
                    int mainid = Convert.ToInt32(pc.MainOfferPriceId);
                    DataTable dt = OfferPriceInfo.getOfferPriceListOfApproves1(emid, mainid);
                    if (dt.Rows.Count == 0)
                    {
                        dt.Rows.Add(dt.NewRow());
                        UI.BindCtrl(dt.DefaultView, gv, AspNetPager2);
                        gv.Rows[0].Visible = false;
                    }
                    else
                    {
                        UI.BindCtrl(dt.DefaultView, gv, AspNetPager2);
                    }

                    //button控制
                    if (pc.IsApply1 == 1)
                    {
                        btnSubmit.Enabled = false;
                    }

                    //审批状态
                    if (pc.IsApply1 == 0)
                    {
                        lblState.Text = "财务部:待审 总经办:待审";
                    }
                    else if (pc.IsApply1 == 1 && pc.IsApply2 == 0)
                    {
                        if (pc.IsOver1 == 0)
                        {
                            lblState.Text = "财务部:修正 总经办:待审";
                        }
                        else
                        {
                            lblState.Text = "财务部:通过 总经办:待审";
                        }
                    }
                    else if (pc.IsApply2 == 1)
                    {
                        if (pc.IsOver2 == 0)
                        {
                            lblState.Text = "财务部:通过 总经办:修正";
                        }
                        else
                        {
                            lblState.Text = "财务部:通过 总经办:通过";
                        }
                    }

                }

            }

        }

        protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            //Check if this is our Blank Row being databound, if so make the row invisible
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if (((DataRowView)e.Row.DataItem)["OfferPriceId"].ToString() == String.Empty)
                    e.Row.Visible = false;
            }

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //鼠标移动到每项时颜色交替效果   
                e.Row.Attributes.Add("onmouseover", "e=this.style.backgroundColor; this.style.backgroundColor='#c1ebff'");
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=e");

                //设置悬浮鼠标指针形状为"小手"   
                e.Row.Attributes["style"] = "Cursor:hand";
            }

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Label lblState = e.Row.FindControl("lblState") as Label;
                GridView gvTemp = (GridView)sender;


                if (!Convert.IsDBNull(gvTemp.DataKeys[e.Row.RowIndex].Value))
                {
                    int SaleId = Convert.ToInt32(gvTemp.DataKeys[e.Row.RowIndex].Value);

                    OfferPriceInfo pc = new OfferPriceInfo(SaleId);
                    Label lblApplyName = e.Row.FindControl("lblApplyName") as Label;
                    Label lblApplyTime = e.Row.FindControl("lblApplyTime") as Label;
                    if (pc.SendEmployeeName == "")
                    {
                        lblApplyName.Text = pc.PreEmployeeName.ToString();//市场部员工
                        lblApplyTime.Text = pc.PreApplyTime.ToString();
                    }
                    else if (pc.PreEmployeeName == "")
                    {
                        lblApplyName.Text = pc.SendEmployeeName.ToString();//市场部经理
                        lblApplyTime.Text = pc.ApplyTime.ToString();
                    }


                    //审批状态
                    if (pc.IsApply1 == 0)
                    {
                        lblState.Text = "财务部:待审 总经办:待审";
                    }
                    else if (pc.IsApply1 == 1 && pc.IsApply2 == 0)
                    {
                        if (pc.IsOver1 == 0)
                        {
                            lblState.Text = "财务部:修正 总经办:待审";
                        }
                        else
                        {
                            lblState.Text = "财务部:通过 总经办:待审";
                        }
                    }
                    else if (pc.IsApply2 == 1)
                    {
                        if (pc.IsOver2 == 0)
                        {
                            lblState.Text = "财务部:通过 总经办:修正";
                        }
                        else
                        {
                            lblState.Text = "财务部:通过 总经办:通过";
                        }
                    }

                }
            }
        }


        protected void btnSearch_Click(object sender, EventArgs e)
        {
            EmployeeInfo em = (EmployeeInfo)Session["Employee"];
            string SheetNum = txtSheetNum.Text.ToString();
            if (SheetNum != "" && ddlProject.SelectedValue == "")
            {

                DataTable dt = OfferPriceInfo.getSheetNumOfPrice3(SheetNum, em.EmployeeId);
                DataView view = dt.DefaultView;
                string sort = (string)ViewState["SortExpression"] + " " + (string)ViewState["SortDir"];
                view.Sort = sort;

                if (dt.Rows.Count == 0)
                {
                    dt.Rows.Add(dt.NewRow());
                    UI.BindCtrl(view, gvPrice, AspNetPager1);
                    gvPrice.Rows[0].Visible = false;
                }
                else
                {
                    UI.BindCtrl(view, gvPrice, AspNetPager1);
                }

            }
            else if (ddlProject.SelectedValue != "" && SheetNum == "")
            {

                DataTable dt = OfferPriceInfo.getProjectOfPrice3(ddlProject.SelectedItem.Text, em.EmployeeId);
                DataView view = dt.DefaultView;
                string sort = (string)ViewState["SortExpression"] + " " + (string)ViewState["SortDir"];
                view.Sort = sort;

                if (dt.Rows.Count == 0)
                {
                    dt.Rows.Add(dt.NewRow());
                    UI.BindCtrl(view, gvPrice, AspNetPager1);
                    gvPrice.Rows[0].Visible = false;
                }
                else
                {
                    UI.BindCtrl(view, gvPrice, AspNetPager1);
                }
            }
            else if (ddlProject.SelectedValue != "" && SheetNum != "")
            {

                DataTable dt = OfferPriceInfo.getBothNameOfPrice3(txtSheetNum.Text.ToString(), ddlProject.SelectedItem.Text.ToString(), em.EmployeeId);
                DataView view = dt.DefaultView;
                string sort = (string)ViewState["SortExpression"] + " " + (string)ViewState["SortDir"];
                view.Sort = sort;

                if (dt.Rows.Count == 0)
                {
                    dt.Rows.Add(dt.NewRow());
                    UI.BindCtrl(view, gvPrice, AspNetPager1);
                    gvPrice.Rows[0].Visible = false;
                }
                else
                {
                    UI.BindCtrl(view, gvPrice, AspNetPager1);
                }
            }

            else
            {
                gvDataBind();
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("PriceApprove1.aspx");
        }

        protected void gvPrice_Sorting(object sender, GridViewSortEventArgs e)
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
    }
}
