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
    public partial class ManagerApprove : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["BackUrl"] = Request.UrlReferrer.ToString();
                PageBind();
            }
        }

        private void PageBind()
        {
            int pid = Convert.ToInt32(Request["ProjectCreateId"].ToString());
            ProjectCreateInfo pc = new ProjectCreateInfo(pid);

            ClientInfo client = new ClientInfo(Convert.ToInt32(pc.ClientId));
            ProjectTypeInfo type = new ProjectTypeInfo(Convert.ToInt32(pc.ProjectTypeId));
            ProjectLevelInfo level = new ProjectLevelInfo(Convert.ToInt32(pc.ProjectLevelId));
            YeWuInfo yw = new YeWuInfo(Convert.ToInt32(pc.YeWuId));
            lblClientName.Text = client.ClientName.ToString();
            lblProjectType.Text = type.ProjectTypeName.ToString();
            lblProjectLevel.Text = level.ProjectLevelName.ToString();
            lblYewu.Text = yw.YeWuName.ToString();

            lblSheetNums.Text = pc.SheetNum.ToString();
            lblProjectFullName.Text = pc.ProjectName.ToString();
            lblProjectNum.Text = pc.SheetNum.ToString();
            lblPredictMoney.Text = pc.PreMoney.ToString();
            lblPredictProfit.Text = pc.PreProfit.ToString();
            lblApplyDate.Text = pc.ApplyDate.ToString();
            lblApplyName.Text = pc.ApplyName.ToString();
            lblApplyDepart.Text = pc.DepartName.ToString();
            txtBusinessDes.Text = pc.BusinessDescribe.ToString();
            lblCallBidPhaseExp.Text = pc.CallbidPhaseExp.ToString();
            lblCarryPhaseExp.Text = pc.CarryPhaseExp.ToString();
            txtClientDes.Text = pc.ClientDescribe.ToString();
            txtCompitDes.Text = pc.CompitDescribe.ToString();
            lblCratePhaseExp.Text = pc.CreatePhaseExp.ToString();
            txtManagerView.Text = pc.ManagerView.ToString();
            txtMemo.Text = pc.Memo.ToString();
            txtNeedDes.Text = pc.NeedDescribe.ToString();
            lblProjectFullName.Text = pc.ProjectName;
            lblProposePhaseExp.Text = pc.ProposePhaseExp.ToString();
            txtRiskDes.Text = pc.RiskDescribe.ToString();
            txtStrategyDes.Text = pc.StrategyDesribe.ToString();
            lblTalkPhaseExp.Text = pc.TalkPhaseExp.ToString();
            txtTechDes.Text = pc.TechDescribe.ToString();
            txtTechView.Text = pc.TechView.ToString();
            txtMarketView.Text = pc.MarketView.ToString();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (rblOver.SelectedIndex == -1)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('请选择修正或通过！');</script>");
            }
            else
            {
                try
                {
                    int cid = Convert.ToInt32(Request["ProjectCreateId"].ToString());
                    ProjectCreateInfo pc = new ProjectCreateInfo(cid);
                    pc.ManagerView = txtManagerView.Text.ToString();
                    if (rblOver.Items[0].Selected)
                    {
                        pc.State =5;
                        pc.Save();
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('您让申请人修正！');</script>");
                    }
                    else if (rblOver.Items[1].Selected)
                    {

                        pc.State = 4;
                        pc.Save();
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('审批通过！');</script>");
                        MainProjectCreateInfo p = new MainProjectCreateInfo();
                        p.ClientId = Convert.ToInt32(pc.ClientId);
                        p.PreMoney = pc.PreMoney.ToString();
                        p.PreProfit = pc.PreProfit.ToString();
                        p.ProjectLevelId = Convert.ToInt32(pc.ProjectLevelId);
                        p.ProjectName = pc.ProjectName.ToString();
                        p.ProjectTypeId = Convert.ToInt32(pc.ProjectTypeId);
                        p.SheetNum = pc.SheetNum.ToString();
                        p.YeWuId = Convert.ToInt32(pc.YeWuId);
                        p.Save();
                    }


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
