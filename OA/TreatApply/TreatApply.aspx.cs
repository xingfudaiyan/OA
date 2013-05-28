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

namespace OA.TreatApply
{
    public partial class TreatApply : System.Web.UI.Page
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


            int emid = Convert.ToInt32(Session["EmployeeId"]);
            DataTable dt = BusinessExpInfo.getBusinessExpListOfEmployee(emid);
            
            DataView view = dt.DefaultView;
            string sort = (string)ViewState["SortExpression"] + " " + (string)ViewState["SortDir"];
            view.Sort = sort;

            if (dt.Rows.Count == 0)
            {
                dt.Rows.Add(dt.NewRow());
                UI.BindCtrl(dt.DefaultView, gvBusiness, AspNetPager1);
                gvBusiness.Rows[0].Visible = false;
            }
            else
            {
                UI.BindCtrl(dt.DefaultView, gvBusiness, AspNetPager1);
            }
        }

        protected void btnAddBusiness_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddTreat.aspx");
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            gvDataBind();
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            int wksumId = Convert.ToInt32(((Button)sender).CommandArgument.ToString());
            Response.Redirect("EditTreat.aspx?BusinessExpId=" + wksumId);
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
           
            int wksumId = Convert.ToInt32(((Button)sender).CommandArgument.ToString());
            BusinessExpInfo wksum = new BusinessExpInfo(wksumId);

            wksum.IsApply = 1;
            DateTime date = DateTime.Now;
            wksum.ApplyTime = date;

            int recvemid = Convert.ToInt32(Common.getEmployeeIdOfManager());//只有总经理能接收费用申请表
            wksum.Recv1EmployeeId = recvemid;
            wksum.Save();
            gvDataBind();
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('申请成功！');</script>");
           
        }

        //查看详细
        protected void btnDetail_Click(object sender, EventArgs e)
        {
            int wksumId = Convert.ToInt32(((LinkButton)sender).CommandArgument.ToString());
            Response.Redirect("Detail.aspx?BusinessExpId=" + wksumId);
        }

        protected void gvBusiness_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {

                Label lblState = e.Row.FindControl("lblState") as Label;
                Button btnSubmit = e.Row.FindControl("btnSubmit") as Button;
                Button btnEdit = e.Row.FindControl("btnEdit") as Button;

                if (!Convert.IsDBNull(gvBusiness.DataKeys[e.Row.RowIndex].Value))
                {

                    //绑定子GridView
                    GridView gv = e.Row.FindControl("GridView2") as GridView;

                    int emid = Convert.ToInt32(Session["EmployeeId"]);
                    int SaleId = Convert.ToInt32(gvBusiness.DataKeys[e.Row.RowIndex].Value);

                    BusinessExpInfo pc = new BusinessExpInfo(SaleId);
                    int mainid = Convert.ToInt32(pc.MainBusinessExpId);

                    DataTable dt = BusinessExpInfo.getBusinessExpListOfEmployee2(emid, mainid);

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
                    if (pc.IsApply == 1)
                    {
                        btnSubmit.Enabled = false;

                        if (pc.IsNewCreate == 1)//审批未通过，修正。
                        {
                            btnEdit.Enabled = true;
                        }
                        else//默认IsNewCreate==0，已申请，编辑按钮不可用。
                        {
                            btnEdit.Enabled = false;
                        }

                    }


                    if (pc.IsApply == 1 && pc.IsApply1 == 0)
                    {
                        lblState.Text = "总经办:待审";
                    }
                    else if (pc.IsApply1 == 1 && pc.IsApply2 == 0)
                    {
                        if (pc.IsOver1 == 1)
                        {
                            lblState.Text = "总经办:通过";
                        }
                        else
                        {
                            lblState.Text = "总经办:修正";
                        }
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
        }

        protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            //Check if this is our Blank Row being databound, if so make the row invisible
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if (((DataRowView)e.Row.DataItem)["BusinessExpId"].ToString() == String.Empty)
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
                    BusinessExpInfo pc = new BusinessExpInfo(SaleId);

                    if (pc.IsApply == 1 && pc.IsApply1 == 0)
                    {
                        lblState.Text = "总经办:待审";
                    }
                    else if (pc.IsApply1 == 1 && pc.IsApply2 == 0)
                    {
                        if (pc.IsOver1 == 1)
                        {
                            lblState.Text = "总经办:通过";
                        }
                        else
                        {
                            lblState.Text = "总经办:修正";
                        }
                    }
                    
                }
            }
        }


        protected void gvBusiness_Sorting(object sender, GridViewSortEventArgs e)
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

        protected void btnAddSheet_Click(object sender, EventArgs e)
        {
            BusinessExpInfo bExp = new BusinessExpInfo();
            bExp.Save();
            int bExpId = Convert.ToInt32(bExp.BusinessExpId);
            Response.Redirect("AddTreat.aspx?BusinessExpId="+bExpId);
        }

       

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("PreTreatApprove.aspx");
        }
    }
}
