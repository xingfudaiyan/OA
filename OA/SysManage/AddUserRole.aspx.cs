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
    public partial class AddUserRole : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlBind();
                cblBind();
                
            }
        }

        protected void ddlBind()
        {
            DataTable dt = MasterInfo.getMasterLists();
            ddlMaster.DataTextField = "MasterName";
            ddlMaster.DataValueField = "MasterId";
            ddlMaster.DataSource = dt;
            DataRow row = dt.NewRow();
            row["MasterName"] = "请选择用户名";
            dt.Rows.InsertAt(row, 0);
            ddlMaster.DataBind();
           
        }

        protected void cblBind()
        {
            DataTable dt = RoleInfo.getRole();
            ckblRole.DataTextField = "RoleName";
            ckblRole.DataValueField = "RoleId";
            ckblRole.DataSource = dt;
            ckblRole.DataBind();
        }

        protected void btnAddUser_Click(object sender, EventArgs e)
        {
            int masterid = Convert.ToInt32(ddlMaster.SelectedValue);
            try
            {
                AddRoleMaster(masterid);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('角色分配成功！');</script>");
            }
            catch (Exception Ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Save", "alert('配置失败：" + Ex.Message + "');", true);
            }
        }

        protected void AddRoleMaster(int masterid)
        {
            for (int i = 0; i < ckblRole.Items.Count; i++)
            {
                if (ckblRole.Items[i].Selected&&!RoleInfo.IsRoleMasters(masterid,Convert.ToInt32(ckblRole.Items[i].Value)))
                {//选中且rolemaster表中不存在
                    RoleMasterInfo role = new RoleMasterInfo();
                    role.MasterId = masterid;
                    role.RoleId = Convert.ToInt32(ckblRole.Items[i].Value);
                    role.Save();
                }
                else if (!ckblRole.Items[i].Selected && RoleInfo.IsRoleMasters(masterid, Convert.ToInt32(ckblRole.Items[i].Value)))
                {
                    RoleInfo.DelRoles(masterid, Convert.ToInt32(ckblRole.Items[i].Value));
                }
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserRoleList.aspx");
        }

        protected void ddlMaster_SelectedIndexChanged(object sender, EventArgs e)
        {
            int masterid = Convert.ToInt32(ddlMaster.SelectedValue);
            if (RoleInfo.isRoleMaster(masterid))
            {
                DataTable dt = RoleInfo.GetRoleFromMaster(masterid);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    this.ckblRole.Items.FindByValue(dt.Rows[i]["RoleId"].ToString()).Selected = true;
                }
            }
        }
    }
}
