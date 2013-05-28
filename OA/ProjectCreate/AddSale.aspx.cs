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

namespace OA.ProjectCreate
{
    public partial class AddSale : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                PageInit();
                ViewState["BackUrl"] = Request.UrlReferrer.ToString();
            }
        }

        protected void PageInit()
        {
            lblApplyDepart.Text = Session["DepartName"].ToString();
            lblApplyName.Text = Session["EmployeeName"].ToString();
            txtApplyDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            SheetNum();
            ddlDataBind();
        }

        protected void SheetNum()
        {
            string strtoday = DateTime.Now.ToString("yyyyMMdd").Substring(2);
            if (ProjectCreateInfo.IsSheetNumOfPC(strtoday))
            {
                txtSheetNum.Text = ProjectCreateInfo.SheetNumOfPC("LX", strtoday);
            }
            else
            {
                txtSheetNum.Text = "LX" + strtoday + "001";
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

            DataTable dt3 = ProjectCreateInfo.getYewu();
            ddlYewu.DataSource = dt3;
            ddlYewu.DataTextField = "YeWuName";
            ddlYewu.DataValueField = "YeWuId";
            DataRow row3 = dt3.NewRow();
            row3["YeWuName"] = "请选择业务类型";
            dt3.Rows.InsertAt(row3, 0);
            ddlYewu.DataBind();

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
            if (ddlYewu.SelectedValue == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('请选择业务类型！');</script>");
                return false;
            }
            else
            {
                return true;
            }
        }

        protected void ddlClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ClientId = Convert.ToInt32(ddlClient.SelectedValue);
            ClientInfo client = new ClientInfo(ClientId);
            string sheetnum = client.SheetNum.ToString();
            string strtoday = DateTime.Now.ToString("yyyyMMdd").Substring(2);
            if (SheetNums.IsSheetNumOfProject())
            {
                lblProjectNum.Text = SheetNums.SheetNumOfProject("XM", sheetnum, strtoday);
            }
            else
            {
                lblProjectNum.Text = "XM" + sheetnum + strtoday + "001";
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (IsPageValid())
            {
                try
                {
                    ProjectCreateInfo pc = new ProjectCreateInfo();
                    pc.ApplyName = Session["EmployeeName"].ToString();
                    pc.DepartName = Session["DepartName"].ToString();
                    pc.State = 0;
                    pc.ApplyDate = txtApplyDate.Text.ToString();
                    pc.ApplyTime = "";
                    pc.ClientDescribe = txtClientDes.Text.ToString();
                    pc.CompitDescribe = txtCompitDes.Text.ToString();
                    pc.BusinessDescribe = txtBusinessDes.Text.ToString();
                    pc.NeedDescribe = txtNeedDes.Text.ToString();
                    pc.RiskDescribe = txtRiskDes.Text.ToString();
                    pc.StrategyDesribe = txtStrategyDes.Text.ToString();
                    pc.TechDescribe = txtTechDes.Text.ToString();
                    pc.CallbidPhaseExp = txtCallBidPhaseExp.Text.ToString();
                    pc.CarryPhaseExp = txtCarryPhaseExp.Text.ToString();
                    pc.CreatePhaseExp = txtCratePhaseExp.Text.ToString();
                    pc.ProposePhaseExp = txtProposePhaseExp.Text.ToString();
                    pc.TalkPhaseExp = txtTalkPhaseExp.Text.ToString();
                    pc.ClientId=Convert.ToInt32(ddlClient.SelectedValue);
                    pc.MarketView = txtMarketView.Text.ToString();
                    pc.Memo = txtMemo.Text.ToString();
                    pc.PreMoney = txtPreMoney.Text.ToString();
                    pc.PreProfit = txtPreProfit.Text.ToString();
                    pc.ProjectLevelId = Convert.ToInt32(ddlProjectLevel.SelectedValue);
                    pc.ProjectName = txtProjectName.Text.ToString();
                    pc.ProjectTypeId = Convert.ToInt32(ddlProjectType.SelectedValue);
                    pc.SheetNum = lblProjectNum.Text.ToString();
                    pc.TechView = txtTechView.Text.ToString();
                    pc.Today = DateTime.Now.ToString("yyyyMMdd").Substring(2);
                    pc.YeWuId = Convert.ToInt32(ddlYewu.SelectedValue);
                    pc.Save();
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
            Response.Redirect(ViewState["BackUrl"].ToString());
        }
    }
}
