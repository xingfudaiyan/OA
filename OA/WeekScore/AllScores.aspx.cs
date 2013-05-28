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

namespace OA.WeekScore
{
    public partial class AllScores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["SortExpression"] = "EmployeeName";
                ViewState["SortDir"] = "ASC";
                ddlBind();
                gvDataBind();
            }
        }

        protected void ddlBind()
        {
            DataTable dt = EmployeeInfo.getEmployeeOfDepart(Convert.ToInt32(Session["DepartId"]));
            ddlEmployee.DataSource = dt;
            ddlEmployee.DataTextField = "EmployeeName";
            ddlEmployee.DataValueField = "EmployeeId";
            DataRow row = dt.NewRow();
            row["EmployeeName"] = "请选择姓名";
            dt.Rows.InsertAt(row, 0);
            ddlEmployee.DataBind();

        }

        protected void gvDataBind()
        {
            DataTable dt;
            if (ddlEmployee.SelectedValue == "" || txtDate1.Text == "" || txtDate2.Text == "")
            {
                dt = DayScoreInfo.getWksOfTm();
            }
            else
            {
                int emid = Convert.ToInt32(ddlEmployee.SelectedValue);
                dt = DayScoreInfo.getScoreByCondition(emid, txtDate1.Text, txtDate2.Text);
            }

            DataView view = dt.DefaultView;
            string sort = (string)ViewState["SortExpression"] + " " + (string)ViewState["SortDir"];
            view.Sort = sort;

            if (dt.Rows.Count == 0)
            {
                dt.Rows.Add(dt.NewRow());
                UI.BindCtrl(dt.DefaultView, gvScore, AspNetPager1);
                gvScore.Rows[0].Visible = false;
            }
            else
            {
                UI.BindCtrl(dt.DefaultView, gvScore, AspNetPager1);
            }
        }
        protected void lblDetail_Click(object sender, EventArgs e)
        {
            int WkId = Convert.ToInt32(((LinkButton)sender).CommandArgument.ToString());
            Response.Redirect("ScoreDetail.aspx?WeekScoreId=" + WkId);
        }

      

        protected void gvScore_RowDataBound(object sender, GridViewRowEventArgs e)
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

        protected void gvScore_Sorting(object sender, GridViewSortEventArgs e)
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

       
      
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (ddlEmployee.SelectedValue == "" || txtDate1.Text == "" || txtDate2.Text == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('请选择姓名、时间！');</script>");
            }
            else
            {
                int emid = Convert.ToInt32(ddlEmployee.SelectedValue);
                lblScore.Text = DayScoreInfo.getSumScore(emid, txtDate1.Text, txtDate2.Text);
                gvDataBind();
              
               
            }
            
        }
    }
}
