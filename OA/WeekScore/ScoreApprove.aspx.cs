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
    public partial class ScoreApprove : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["SortExpression"] = "Today";
                ViewState["SortDir"] = "DESC";
                ViewState["BackUrl"] = Request.UrlReferrer.ToString();
                ViewState["wkid"] = Convert.ToInt32(Request["WeekScoreId"]);
                gvDataBind();

                WeekScoreInfo wk = new WeekScoreInfo(Convert.ToInt32(ViewState["wkid"]));
                EmployeeInfo em = new EmployeeInfo(Convert.ToInt32(wk.EmployeeId));
                lblNum.Text = wk.WeekScoreNum.ToString();
                lblEm.Text = em.EmployeeName.ToString();
            }
        }

        protected void gvDataBind()
        {

            DataTable dt = DayScoreInfo.getAddDayScore(Convert.ToInt32(ViewState["wkid"]));
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

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            gvDataBind();
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect(ViewState["BackUrl"].ToString());
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

        protected void btnSave_Click(object sender, EventArgs e)
        {
            WeekScoreInfo wk = new WeekScoreInfo(Convert.ToInt32(ViewState["wkid"]));
            float sum = 0;

            foreach(GridViewRow row in gvScore.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    int dayid = Convert.ToInt32(gvScore.DataKeys[row.RowIndex].Value);
                    DayScoreInfo days = new DayScoreInfo(dayid);

                    TextBox txtScore = gvScore.Rows[row.RowIndex].FindControl("txtScore") as TextBox;
                    days.Score = txtScore.Text.ToString();
                    days.Save();
                    if (txtScore.Text.ToString() != "")
                    {
                        sum = sum + float.Parse(txtScore.Text.ToString());
                    }
                   
                }
               
            }
            wk.TotalScore = sum.ToString();
            wk.IsSubmit = 2;
            wk.Save();

            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('保存成功！');</script>");
            
        }
    }
}
