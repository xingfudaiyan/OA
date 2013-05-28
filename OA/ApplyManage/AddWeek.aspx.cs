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
    public partial class AddWeek : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvwBind();
                ddlBind();
            }
        }

        protected void gvwBind()
        {
            int wksumid = Convert.ToInt32(Request["sumId"].ToString());
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

        protected void ddlBind()
        {
            DataTable dt = DayInfo.getWeek();
            ddlWeek.DataSource = dt;
            ddlWeek.DataTextField = "WeekName";
            ddlWeek.DataValueField = "WeekId";
            DataRow row = dt.NewRow();
            row["WeekName"] = "请选择星期";
            dt.Rows.InsertAt(row, 0);
            ddlWeek.DataBind();


        }
       
        protected void gvwDay_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                int dayid = Convert.ToInt32(gvwDay.DataKeys[e.RowIndex].Value);
                DayInfo.DelDay(dayid);
                gvwBind();
               
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('删除成功！');</script>");
            }
            catch (Exception Ex)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('删除失败：" + Ex.Message + "');</script>", true); 
            }
            
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
            int wksumid = Convert.ToInt32(Request["sumId"].ToString());
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
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('修改成功！');</script>");
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


     
        protected void btnAddDay_Click(object sender, EventArgs e)
        {
                int wksumid = Convert.ToInt32(Request["sumId"].ToString());
                DayInfo day = new DayInfo();
                day.WeekSumId = wksumid;

                day.WorkDate = Convert.ToDateTime(txtDate.Text.ToString());
                day.WorkContent = txtWorkContent.Text.ToString();
                day.Result = txtResult.Text.ToString();
                if (ddlWeek.SelectedValue == "")
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('请选择星期');</script>");

                }
                else
                {
                    day.WeekId = Convert.ToInt32(ddlWeek.SelectedValue);
                    day.Save();
                    gvwBind();
                }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            int wksumid = Convert.ToInt32(Request["sumId"].ToString());
            if (gvwDay.Rows.Count == 0)
            {
                DayInfo.DelWeekSum(wksumid);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('请添加日志');</script>");
            }
            else
            {
                int emid = Convert.ToInt32(Session["EmployeeId"]);
                WeekSumInfo wksum = new WeekSumInfo(wksumid);
                wksum.WeekSumName = txtSumName.Text.ToString();
                wksum.SendEmployeeId = emid;
                wksum.IsSend = 0;
                wksum.IsApply = 0;
                wksum.IsApprove = 0;
                wksum.Save();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('添加成功');</script>");

            }
            Response.Redirect("WeekApply.aspx");
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            int wksumid = Convert.ToInt32(Request["sumId"].ToString());
            DayInfo.DelDaysOfWeekSum(wksumid);
            DayInfo.DelWeekSum(wksumid);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('您未添加日志');</script>");
            Response.Redirect("WeekApply.aspx");
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            gvwBind();
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
