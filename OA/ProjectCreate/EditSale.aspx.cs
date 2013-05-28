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
    public partial class EditSale : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlDataBind();
                ProjectCreateBind();
                ViewState["BackUrl"] = Request.UrlReferrer.ToString();
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

        protected void ProjectCreateBind()
        {
                int wkid = Convert.ToInt32(Request["ProjectCreateId"].ToString());
                ProjectCreateInfo pc = new ProjectCreateInfo(wkid);

                ddlClient.SelectedValue = pc.ClientId.ToString();
                ddlYewu.SelectedValue = pc.YeWuId.ToString();
                ddlProjectType.SelectedValue = pc.ProjectTypeId.ToString();
                ddlProjectLevel.SelectedValue = pc.ProjectLevelId.ToString();

                lblApplyName.Text = pc.ApplyName.ToString();
                lblApplyDepart.Text = pc.DepartName.ToString();
                lblProjectNum.Text = pc.SheetNum.ToString();
                txtProjectName.Text = pc.ProjectName.ToString();
                txtPreMoney.Text = pc.PreMoney.ToString();
                txtPreProfit.Text = pc.PreProfit.ToString();
                txtSheetNum.Text = pc.SheetNum.ToString();
                txtApplyDate.Text = pc.ApplyDate.ToString();
                txtBusinessDes.Text = pc.BusinessDescribe.ToString();
                txtCallBidPhaseExp.Text = pc.CallbidPhaseExp.ToString();
                txtCarryPhaseExp.Text = pc.CarryPhaseExp.ToString();
                txtClientDes.Text = pc.ClientDescribe.ToString();
                txtCompitDes.Text = pc.CompitDescribe.ToString();
                txtCratePhaseExp.Text = pc.CreatePhaseExp.ToString();
                txtManagerView.Text = pc.ManagerView.ToString();
                txtMarketView.Text = pc.MarketView.ToString();
                txtMemo.Text = pc.Memo.ToString();
                txtNeedDes.Text = pc.NeedDescribe.ToString();
                txtProposePhaseExp.Text = pc.ProposePhaseExp.ToString();
                txtRiskDes.Text = pc.RiskDescribe.ToString();
                txtStrategyDes.Text = pc.StrategyDesribe.ToString();
                txtTalkPhaseExp.Text = pc.TalkPhaseExp.ToString();
                txtTechDes.Text = pc.TechDescribe.ToString();
                txtTechView.Text = pc.TechView.ToString();
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
            DateTime today = DateTime.Now;
            string strtoday = today.ToString("yyyyMMdd").Substring(2);
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
                    int pcid = Convert.ToInt32(Request["ProjectCreateId"].ToString());
                    ProjectCreateInfo pc = new ProjectCreateInfo(pcid);
                    pc.ApplyDate = txtApplyDate.Text.ToString();
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
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('编辑成功！');</script>");
                 }
                catch (Exception Ex)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Save", "alert('保存失败：" + Ex.Message + "');", true);
                }
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(ViewState["BackUrl"].ToString());
            
        }


    }
}
