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

namespace OA.ContractApply
{
    public partial class Detail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["BackUrl"] = Request.UrlReferrer.ToString();
                PageInit();
            }
        }

        protected void PageInit()
        {
            int cid = Convert.ToInt32(Request["ContractApplyId"].ToString());
            ContractApplyInfo ca = new ContractApplyInfo(cid);
            lblDepart.Text = ca.DepartName.ToString();
            lblEmployee.Text = ca.ApplyName.ToString();
            lblSignName.Text = ca.SignName.ToString();
            lblContractNum.Text = ca.ContractNum.ToString();
            lblSheetNum.Text = ca.SheetNum.ToString();
            lblContract.Text = ca.ContractName.ToString();
            lblBeginDate.Text = ca.BeginDate.ToString();
            lblApplyDate.Text = ca.ApplyDate.ToString();
            lblContractDes.Text = ca.ContractDes.ToString();
            lblBigMoney.Text = ca.BigMoney.ToString();
            lblSmallMoney.Text = ca.SmallMoney.ToString();
            lblSectionView.Text = ca.SectionView.ToString();
            lblManagerView.Text = ca.ManagerView.ToString();
            lblSheetNum.Text = ca.SheetNum.ToString();

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect(ViewState["BackUrl"].ToString());
        }


        protected void btnDownLoad_Click(object sender, EventArgs e)
        {
            int cid = Convert.ToInt32(Request["ContractApplyId"].ToString());
            ContractApplyInfo ca = new ContractApplyInfo(cid);
            int fileid = Convert.ToInt32(ca.ContractFileId);
            Response.Redirect("DownLoadFile.aspx?fileid=" + fileid);
        }
    }
}
