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
    public partial class AddRole : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected bool IsPageValid()
        {
            if (txtRoleName.Text=="")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('请填写角色名称！');</script>");
                return false;
            }
            else
            {
                return true;
            }
        }

        protected void btnAddUser_Click(object sender, EventArgs e)
        {
            if (IsPageValid())
            {
                  try
                    {
                        RoleInfo role = new RoleInfo();
                        role.RoleName = txtRoleName.Text.ToString();
                        role.Save();
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('添加成功！');</script>");
                    }
                    catch (Exception Ex)
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "Save", "alert('更新失败：" + Ex.Message + "');", true);
                    }
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("RoleGv.aspx");
        }
    }
}
