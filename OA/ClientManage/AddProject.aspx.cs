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
namespace OA.ClientManage
{
    public partial class AddProject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlDataBind();
            }
        }

        protected void ddlDataBind()
        {
            DataTable dt = ProjectCreateInfo.getProjectLevel();
            ddlProjectLevel.DataSource = dt;
            ddlProjectLevel.DataTextField = "ProjectLevelName";
            ddlProjectLevel.DataValueField = "ProjectLevelId";
            DataRow row = dt.NewRow();
            row["ProjectLevelName"] = "请选择项目级别";
            dt.Rows.InsertAt(row, 0);
            ddlProjectLevel.DataBind();
          
            DataTable dt1 = ProjectCreateInfo.getProjectType();
            ddlProjectType.DataSource = dt1;
            ddlProjectType.DataTextField = "ProjectTypeName";
            ddlProjectType.DataValueField = "ProjectTypeId";
            DataRow row1 = dt1.NewRow();
            row1["ProjectTypeName"] = "请选择项目类别";
            dt1.Rows.InsertAt(row1, 0);
            ddlProjectType.DataBind();

            DataTable dt2 = ClientInfo.getClientList();
            ddlClient.DataSource = dt2;
            ddlClient.DataTextField = "ClientName";
            ddlClient.DataValueField = "ClientId";
            DataRow row2 = dt2.NewRow();
            row2["ClientName"] = "请选择客户名称";
            dt2.Rows.InsertAt(row2, 0);
            ddlClient.DataBind();
        }

        protected bool IsPageValid()
        {
            if (ddlClient.SelectedValue == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('请选择客户名称！');</script>");
                return false;
            }
            if (ddlProjectLevel.SelectedValue == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('请选择客户等级！');</script>");
                return false;
            }
            if (ddlProjectType.SelectedValue == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('请选择客户类型！');</script>");
                return false;
            }
            else
            {
                return true;
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsPageValid())
            {
                try
                {
                    MainProjectCreateInfo project = new MainProjectCreateInfo();
                    project.PreMoney = txtPreMoney.Text.ToString();
                    project.PreProfit = txtPreProfit.Text.ToString();
                    project.ProjectLevelId = Convert.ToInt32(ddlProjectLevel.SelectedValue);
                    project.ProjectTypeId = Convert.ToInt32(ddlProjectType.SelectedValue);
                    project.ClientId = Convert.ToInt32(ddlClient.SelectedValue);
                    project.ProjectName = txtProjectName.Text.ToString();
                    project.SheetNum = txtSheetNum.Text.ToString();
                    project.Save();
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('添加成功！');</script>");
                }
                catch (Exception Ex)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Save", "alert('添加失败：" + Ex.Message + "');", true);
                }
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Project.aspx");
        }

        protected void ddlClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ClientId = Convert.ToInt32(ddlClient.SelectedValue);
            ClientInfo client=new ClientInfo(ClientId);
            string sheetnum=client.SheetNum.ToString();
            DateTime today=DateTime.Now;
            string strtoday = today.ToString("yyyyMMdd").Substring(2);
            if (SheetNums.IsSheetNumOfProject())
            {
                txtSheetNum.Text = SheetNums.SheetNumOfProject("XM", sheetnum, strtoday);
            }
            else
            {
                txtSheetNum.Text = "XM" + sheetnum + strtoday + "001";
            }
        }
    }
}
