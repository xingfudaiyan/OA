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

namespace OA
{
    public partial class User : System.Web.UI.Page
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
            DataTable dt = MasterInfo.GetMasterList();
            
            if (dt.Rows.Count == 0)
            {
                dt.Rows.Add(dt.NewRow());
                UI.BindCtrl(dt.DefaultView, gvMaster, AspNetPager1);
                gvMaster.Rows[0].Visible = false;
            }
            else
            {
                UI.BindCtrl(dt.DefaultView, gvMaster, AspNetPager1);
            }
        }
        
        protected void btnAddMaster_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddMaster.aspx");
        }

        protected void gvMaster_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int msid = Convert.ToInt32(gvMaster.DataKeys[e.RowIndex].Value);
            MasterInfo.DelMaster(msid);
            gvDataBind();
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            gvDataBind();
        }

        protected void gvMaster_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvMaster.EditIndex = e.NewEditIndex;
            gvDataBind();
        }

        protected void gvMaster_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvMaster.EditIndex = -1;
            gvDataBind();
        }

        protected void gvMaster_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int masterid = Convert.ToInt32(gvMaster.DataKeys[e.RowIndex].Value);
            TextBox txtMasterName = gvMaster.Rows[e.RowIndex].FindControl("txtMasterName") as TextBox;
            try
            {
                
                MasterInfo master = new MasterInfo(masterid);
                master.MasterName = txtMasterName.Text.ToString();
                master.Save();
                gvMaster.EditIndex = -1;
                gvDataBind();
            }
            catch (Exception Ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Save", "alert('更新失败：" + Ex.Message + "');", true);
            }
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            int MasterId = Convert.ToInt32(((Button)sender).CommandArgument.ToString());
            Response.Redirect("SendRights.aspx?MasterId=" + MasterId);
        }

        protected void gvMaster_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if (!Convert.IsDBNull(gvMaster.DataKeys[e.Row.RowIndex].Value))
                {
                    int masterid = Convert.ToInt32(gvMaster.DataKeys[e.Row.RowIndex].Value);
                    MasterInfo master = new MasterInfo(masterid);
                    int stateid = Convert.ToInt32(master.State);

                    Label lblState = e.Row.FindControl("lblState") as Label;
                    if (stateid == 0)
                    {
                        lblState.Text = "未发送";
                    }
                    else if (stateid == 1)
                    {
                        lblState.Text = "已发送";
                    }
                    else if (stateid == 2)
                    {
                        lblState.Text = "通过";
                    }
                    else if (stateid == 3)
                    {
                        lblState.Text = "修正";
                    }

                }
            }
            
           
        }
    }
}
