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

namespace OA.SysManage
{
    public partial class RecvMaster : System.Web.UI.Page
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
            DataTable dt = MasterInfo.getRecvMasterList();

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
        

        protected void btnApply_Click(object sender, EventArgs e)
        {
            int MasterId = Convert.ToInt32(((Button)sender).CommandArgument.ToString());
            Response.Redirect("RecvRights.aspx?MasterId=" + MasterId);
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
                    if (stateid == 0 || stateid == 1)
                    {
                        lblState.Text = "未审批";
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

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            gvDataBind();
        }
    }
}
