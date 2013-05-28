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
    public partial class AddUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlBind();
            }
        }

        protected void ddlBind()
        {
            //绑定ddlDepart
            DataTable dtDepart = EmployeeInfo.getDepartList();
            ddlDepart.DataTextField = "DepartName";
            ddlDepart.DataValueField = "DepartId";
            ddlDepart.DataSource = dtDepart;
            DataRow drDepart = dtDepart.NewRow();
            drDepart["DepartName"] = "请选择部门";
            dtDepart.Rows.InsertAt(drDepart, 0);
            ddlDepart.DataBind();
        }

        protected void ddlDepart_SelectedIndexChanged(object sender, EventArgs e)
        {
            int DepartId = Convert.ToInt32(ddlDepart.SelectedValue.ToString());
            DataTable dt = EmployeeInfo.getEmployeeOfDepart(DepartId);
            ddlEmployee.DataTextField = "EmployeeName";
            ddlEmployee.DataValueField = "EmployeeId";
            ddlEmployee.DataSource = dt;
            DataRow dr = dt.NewRow();
            dr["EmployeeName"] = "请选择姓名";
            dt.Rows.InsertAt(dr, 0);
            ddlEmployee.DataBind();
        }

        protected bool IsPageValid()
        {
            if (ddlEmployee.SelectedValue.ToString() == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('请选择姓名！');</script>");
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
                string strName = txtUserName.Text.ToString();
                bool isexit = MasterInfo.IsUserExit(strName);
                if (!isexit)
                {
                    try
                    {
                        MasterInfo master = new MasterInfo();
                        master.MasterName = txtUserName.Text.ToString();
                        master.MasterPsd = txtNewPsd.Text.ToString();
                        master.DepartId = Convert.ToInt32(ddlDepart.SelectedValue.ToString());
                        DateTime time = DateTime.Now;
                        master.CreateDate = time;
                        master.EmployeeId = Convert.ToInt32(ddlEmployee.SelectedValue.ToString());
                        master.State = 0;
                        master.IsApply = 0;
                        master.Save();
                        FileEmployee();
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('添加成功！');</script>");
                    }
                    catch (Exception Ex)
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "Save", "alert('更新失败：" + Ex.Message + "');", true);
                    }
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('用户名已存在，请重新添加！');</script>");
                }
                
            }
           
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Master.aspx");
        }

        protected void FileEmployee()
        {
            int Emid = Convert.ToInt32(ddlEmployee.SelectedValue.ToString());
            DataTable dt=FileInfo.UserFileEmployee(ddlDepart.SelectedValue.ToString());
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                FileEmployeeInfo FileEm = new FileEmployeeInfo();
                FileEm.EmployeeId = Emid;
                FileEm.FileId = Convert.ToInt32(dt.Rows[i]["FileId"].ToString());
                FileEm.IsDelete = 0;
                FileEm.IsMsg = 0;
                FileEm.Save();
            }
        }
    }
}
