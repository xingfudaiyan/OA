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

namespace OA.ApplyManage
{
    public partial class WeekApprove : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvDataBind();
            }
        }

        protected void gvDataBind()
        {
            int emid = Convert.ToInt32(Session["EmployeeId"]);
            DataTable dt = DayInfo.getWeekSumOfApprove(emid);
            if (dt.Rows.Count == 0)
            {
                dt.Rows.Add(dt.NewRow());
                UI.BindCtrl(dt.DefaultView, gvwWeekSum, AspNetPager1);
                gvwWeekSum.Rows[0].Visible = false;
            }
            else
            {
                UI.BindCtrl(dt.DefaultView, gvwWeekSum, AspNetPager1);
            }
        }
        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            gvDataBind();
        }

        protected void gvwWeekSum_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int wksumid = Convert.ToInt32(gvwWeekSum.DataKeys[e.RowIndex].Value);
            try
            {
                WeekSumInfo wksum = new WeekSumInfo(wksumid);
                wksum.RecvEmployeeId = -1;
                gvDataBind();
            }
            catch(Exception Ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Save", "alert('删除失败：" + Ex.Message + "');", true);
            }
        }

        protected void btnApprove_Click(object sender, EventArgs e)
        {
            int wksumId = Convert.ToInt32(((Button)sender).CommandArgument.ToString());
            Response.Redirect("WkApprove.aspx?WeekSumId="+wksumId);
        }

        protected void gvwWeekSum_RowDataBound(object sender, GridViewRowEventArgs e)
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
    }
}
