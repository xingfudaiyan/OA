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
    public partial class DayScore : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["SortExpression"] = "Today";
                ViewState["SortDir"] = "ASC";
                ViewState["BackUrl"] = Request.UrlReferrer.ToString();
                Init();
                gvDataBind();
            }
        }

        protected void Init()
        {
            WeekScoreInfo weekscore = new WeekScoreInfo();
            weekscore.IsSubmit = 0;
            int emid = Convert.ToInt32(Request["EmployeeId"]);
            weekscore.EmployeeId = emid;
            weekscore.Save();
            WeekScoreInfo wk = new WeekScoreInfo(weekscore.WeekScoreId);
            wk.WeekScoreNum = DateTime.Now.Date.ToString("yyyyMMdd") + weekscore.WeekScoreId.ToString();
            wk.Save();
            ViewState["wksid"] = weekscore.WeekScoreId;
            for (int i = 0; i < 5; i++)
            {
                DayScoreInfo dayscore = new DayScoreInfo();
                dayscore.WeekScoreId =(int)ViewState["wksid"];
                dayscore.DayRoleId = Convert.ToInt32("1");
                dayscore.Save();
            }
        }

        protected void gvDataBind()
        {
           
            DataTable dt = DayScoreInfo.getAddDayScore(Convert.ToInt32(ViewState["wksid"]));
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

        
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            DayScoreInfo das = new DayScoreInfo();
            das.WeekScoreId = Convert.ToInt32(ViewState["wksid"]);
            das.DayRoleId = Convert.ToInt32("1");
            das.Save();
            gvDataBind();
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            gvDataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            WeekScoreInfo wks = new WeekScoreInfo(Convert.ToInt32(ViewState["wksid"]));
            wks.IsSubmit = 1;
            wks.Save();
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('提交成功！');</script>");
            
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

                DropDownList ddlRole = e.Row.FindControl("ddlRole") as DropDownList;
                if (ddlRole != null)
                {
                    DataTable dt = DayScoreInfo.getDayRole();
                    ddlRole.DataSource = dt;
                    ddlRole.DataTextField = "DayRoleName";
                    ddlRole.DataValueField = "DayRoleId";
                    ddlRole.DataBind();
                }

            }
        }

        protected void gvScore_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int dayscoreid = Convert.ToInt32(gvScore.DataKeys[e.RowIndex].Value);
            DayScoreInfo.DelDayScore(dayscoreid);
            gvDataBind();
        }

        protected void gvScore_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvScore.EditIndex = e.NewEditIndex;
            gvDataBind();
        }

        protected void gvScore_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int daysid = Convert.ToInt32(gvScore.DataKeys[e.RowIndex].Value);
            DayScoreInfo days = new DayScoreInfo(daysid);
            TextBox txtToday = gvScore.Rows[e.RowIndex].FindControl("txtToday") as TextBox;
            TextBox txtItem = gvScore.Rows[e.RowIndex].FindControl("txtItem") as TextBox;
            TextBox txtFinishTime = gvScore.Rows[e.RowIndex].FindControl("txtFinishTime") as TextBox;
            TextBox txtTimeSpan = gvScore.Rows[e.RowIndex].FindControl("txtTimeSpan") as TextBox;
            TextBox txtMemo = gvScore.Rows[e.RowIndex].FindControl("txtMemo") as TextBox;
            DropDownList ddlRole = gvScore.Rows[e.RowIndex].FindControl("ddlRole") as DropDownList;
           
            try
            {
                days.Today = txtToday.Text.ToString();
                days.Item = txtItem.Text.ToString();
                days.FinishTime = txtFinishTime.Text.ToString();
                days.TimeSpan = txtTimeSpan.Text.ToString();
                days.Memo = txtMemo.Text.ToString();
                days.DayRoleId = Convert.ToInt32(ddlRole.SelectedValue);
                days.Save();
                gvScore.EditIndex = -1;
                gvDataBind();
                
            }
            catch(Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Save", "alert('更新失败：" + ex.Message + "');", true); 
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

        protected void gvScore_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvScore.EditIndex = -1;
            gvDataBind();
        }

       
    }
}
