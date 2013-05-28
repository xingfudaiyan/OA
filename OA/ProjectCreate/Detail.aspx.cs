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
    public partial class Detail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["BackUrl"] = Request.UrlReferrer.ToString();
                ProjectCreateBind();
            }

        }
       
        protected void ProjectCreateBind()
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
            txtMemo.Text = pc.Memo.ToString();
            txtNeedDes.Text = pc.NeedDescribe.ToString();
            lblProjectFullName.Text = pc.ProjectName;
            lblProposePhaseExp.Text = pc.ProposePhaseExp.ToString();
            txtRiskDes.Text = pc.RiskDescribe.ToString();
            txtStrategyDes.Text = pc.StrategyDesribe.ToString();
            lblTalkPhaseExp.Text = pc.TalkPhaseExp.ToString();
            txtTechDes.Text = pc.TechDescribe.ToString();
            lblTechView.Text = pc.TechView.ToString();
            lblMarketView.Text = pc.MarketView.ToString();
            lblManagerView.Text = pc.ManagerView.ToString();
          
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect(ViewState["BackUrl"].ToString());

        }

       
    }
}
