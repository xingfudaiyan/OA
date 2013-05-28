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
    public partial class EditWeek : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int wksumid = Convert.ToInt32(Request["WeekSumId"].ToString());
                WeekSumInfo sum = new WeekSumInfo(wksumid);
                txtSumName.Text = sum.WeekSumName.ToString();
                gvwBind();
               
            }
        }

        protected void gvwBind()
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

      
       
        protected void gvwDay_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int dayid = Convert.ToInt32(gvwDay.DataKeys[e.RowIndex].Value);
            DayInfo.DelDay(dayid);
            gvwBind();
        }

        protected void gvwDay_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvwDay.EditIndex = e.NewEditIndex;
            gvwBind();

            DropDownList ddl = gvwDay.Rows[e.NewEditIndex].FindControl("ddlWeek") as DropDownList;
            DataTable dt = DayInfo.getWeek();
            ddl.DataTextField = "WeekName";
            ddl.DataValueField = "WeekId";
            ddl.DataSource = dt;
            ddl.DataBind();
            int wksumid = Convert.ToInt32(Request["WeekSumId"].ToString());
            DataTable dt1 = DayInfo.getDayList(wksumid);
            ddl.SelectedValue = dt1.Rows[0]["WeekId"].ToString();
        }

        protected void gvwDay_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
 
           if (Page.IsValid)
            {
                int dayid = Convert.ToInt32(gvwDay.DataKeys[e.RowIndex].Value);
                DropDownList ddlwk = gvwDay.Rows[e.RowIndex].FindControl("ddlWeek") as DropDownList;
                TextBox txtwd = gvwDay.Rows[e.RowIndex].FindControl("txtDate") as TextBox;
                TextBox txtwc = gvwDay.Rows[e.RowIndex].FindControl("txtWorkContent") as TextBox;
                TextBox txtrs = gvwDay.Rows[e.RowIndex].FindControl("txtResult") as TextBox;
                try
                {
                    DayInfo day = new DayInfo(dayid);
                    day.WeekId = Convert.ToInt32(ddlwk.SelectedValue.ToString());
                    day.WorkDate = DateTime.Parse(txtwd.Text.Trim());
                    day.WorkContent = txtwc.Text.ToString();
                    day.Result = txtrs.Text.ToString();
                    day.Save();
                    gvwDay.EditIndex = -1;
                    gvwBind();
                }
                catch (Exception Ex)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Save", "alert('更新失败：" + Ex.Message + "');", true);
                }
            }
        }

        protected void gvwDay_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvwDay.EditIndex = -1;
            gvwBind();
        }

      

        protected void btnSaveWkSum_Click(object sender, EventArgs e)
        {
            int wksumid = Convert.ToInt32(Request["WeekSumId"].ToString());
            if (gvwDay.Rows.Count == 0)
            {
                DayInfo.DelWeekSum(wksumid);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('周总结为空，已删除！');</script>");
            }
            else
            {

                WeekSumInfo wksum = new WeekSumInfo(wksumid);
                wksum.WeekSumName = txtSumName.Text.ToString();
                wksum.Save();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('编辑成功！');</script>");

            }
            Response.Redirect("WeekApply.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("WeekApply.aspx");
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            gvwBind();
        }
    }
}
