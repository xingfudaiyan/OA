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
    public partial class WkApprove : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int wksumid = Convert.ToInt32(Request["WeekSumId"].ToString());
                WeekSumInfo sum = new WeekSumInfo(wksumid);
                txtSumName.Text = sum.WeekSumName.ToString();
                gvDataBind();
            }
        }

        protected void gvDataBind()
        {
            int wksumid = Convert.ToInt32(Request["WeekSumId"].ToString());
            DataTable dt = DayInfo.getDayList(wksumid);
            
            if (dt.Rows.Count == 0)
            {
                dt.Rows.Add(dt.NewRow());
                UI.BindCtrl(dt.DefaultView, gvwDay, AspNetPager1);
                gvwDay.Rows[0].Visible = false;
            }
            else
            {
                UI.BindCtrl(dt.DefaultView, gvwDay, AspNetPager1);
            }
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            gvDataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            int wksumid = Convert.ToInt32(Request["WeekSumId"].ToString());
            WeekSumInfo wksum = new WeekSumInfo(wksumid);
            DateTime time = DateTime.Now;
            wksum.IsApply = 1;
            wksum.RepplyTime = time;
            wksum.ApplyView = txtView.Text.ToString();
            if (rblApprove.Items[0].Selected)
            {
                wksum.IsApprove = 0;
            }
            else if (rblApprove.Items[1].Selected)
            {
                wksum.IsApprove = 1;
            }
            wksum.Save();
            Response.Redirect("WeekApprove.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("WeekApprove.aspx");
        }

        protected void gvwDay_RowDataBound(object sender, GridViewRowEventArgs e)
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
