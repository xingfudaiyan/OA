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
    public partial class RoleGv : System.Web.UI.Page
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
            DataTable dt = RoleInfo.getRole();
            if (dt.Rows.Count == 0)
            {
                dt.Rows.Add(dt.NewRow());
                UI.BindCtrl(dt.DefaultView, gvRole, AspNetPager1);
                gvRole.Rows[0].Visible = false;
            }
            else
            {
                UI.BindCtrl(dt.DefaultView, gvRole, AspNetPager1);
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddRole.aspx");
        }


        protected void gvRole_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int roleid=Convert.ToInt32(gvRole.DataKeys[e.RowIndex].Value);
            RoleInfo.DelRole(roleid);
            gvDataBind();

        }

        protected void gvRole_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvRole.EditIndex = e.NewEditIndex;
            gvDataBind();
        }

        protected void gvRole_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int roleid = Convert.ToInt32(gvRole.DataKeys[e.RowIndex].Value);
            TextBox txtRoleName = gvRole.Rows[e.RowIndex].FindControl("txtRoleName") as TextBox;
            try
            {
                RoleInfo role = new RoleInfo(roleid);
                role.RoleName = txtRoleName.Text.ToString();
                role.Save();
                gvRole.EditIndex = -1;
                gvDataBind();
            }
            catch (Exception Ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Save", "alert('¸üÐÂÊ§°Ü£º" + Ex.Message + "');", true);
            }
        }

        protected void gvRole_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvRole.EditIndex = -1;
            gvDataBind();
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            gvDataBind();
        }

        
    }
}
