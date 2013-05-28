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
    public partial class WeekApply : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            { 
                gvwBind();
            }
        }

        protected void gvwBind()
        {
            int emid = Convert.ToInt32(Session["EmployeeId"]);
            int departid = Convert.ToInt32(Session["DepartId"]);

            int recvEmployeeId = Convert.ToInt32(DayInfo.getRecvEmployeeId(departid));
            EmployeeInfo em = new EmployeeInfo(recvEmployeeId);
            lblRecvEmployee.Text = em.EmployeeName.ToString();

            DataTable dt = DayInfo.getWeekSumListOfEmployee(emid);
            
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

        protected void btnAddWeek_Click(object sender, EventArgs e)
        {
            WeekSumInfo wksum = new WeekSumInfo();
            wksum.Save();
            Response.Redirect("AddWeek.aspx?sumId="+wksum.WeekSumId);
        }

        protected void gvwWeekSum_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int wksmid = Convert.ToInt32(gvwWeekSum.DataKeys[e.RowIndex].Value);
            try
            {
                DayInfo.DelDaysOfWeekSum(wksmid);
                DayInfo.DelWeekSum(wksmid);
                gvwBind();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('删除成功！');</script>");
            }
            catch (Exception Ex)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('删除失败：" + Ex.Message + "');</script>", true); 
            }
        }

   

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            int departid = Convert.ToInt32(Session["DepartId"]);
            int recvEmployeeId = Convert.ToInt32(DayInfo.getRecvEmployeeId(departid));
            int wksumId = Convert.ToInt32(((Button)sender).CommandArgument.ToString());
            WeekSumInfo wksum = new WeekSumInfo(wksumId);
            wksum.IsApply = 0;
            wksum.IsSend = 1;
            wksum.ApplyTime = date;
            wksum.RecvEmployeeId = recvEmployeeId;
            wksum.Save();
            gvwBind();
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('发送成功！');</script>");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            int wksumId = Convert.ToInt32(((Button)sender).CommandArgument.ToString());
            Response.Redirect("EditWeek.aspx?WeekSumId=" + wksumId);
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            gvwBind();
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
