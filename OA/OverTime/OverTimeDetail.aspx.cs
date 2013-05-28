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

namespace OA.OverTime
{
    public partial class OverTimeDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PageBind();
                gvDataBind();
                ViewState["BackUrl"] = Request.UrlReferrer.ToString();
            }
        }

        protected void PageBind()
        {
            int otid = Convert.ToInt32(Request["OverTimeId"].ToString());
            OverTimeInfo ot = new OverTimeInfo(otid);
            lblEmName.Text = ot.ApplyEmName.ToString();
            lblApplyEmName.Text = ot.ApplyEmName.ToString();
            lblTimeFrom.Text = ot.TimeFrom.ToString();
            lblTimeTo.Text = ot.TimeTo.ToString();
            lblReason.Text = ot.Reason.ToString();
            lblTimeSpan.Text = ot.TimeSpan.ToString();
            lblApplyDate.Text = ot.ApplyDate.ToString();
        }

        protected void gvDataBind()
        {
            int otid = Convert.ToInt32(Request["OverTimeId"].ToString());
            OverTimeInfo ot = new OverTimeInfo(otid);

            DataTable dt = OverTimeInfo.getOtGroup(otid);


            if (dt.Rows.Count == 0)
            {
                dt.Rows.Add(dt.NewRow());
                UI.BindCtrl(dt.DefaultView, gvOtGroup, AspNetPager1);
                gvOtGroup.Rows[0].Visible = false;
            }
            else
            {
                UI.BindCtrl(dt.DefaultView, gvOtGroup, AspNetPager1);
            }
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            gvDataBind();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(ViewState["BackUrl"].ToString());
        }

        protected void gvOtGroup_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //鼠标移动到每项时颜色交替效果   
                e.Row.Attributes.Add("onmouseover", "e=this.style.backgroundColor; this.style.backgroundColor='#c1ebff'");
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=e");
                //设置悬浮鼠标指针形状为"小手"   

            }
        }
    }
}
