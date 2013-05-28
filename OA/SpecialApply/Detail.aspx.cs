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

namespace OA.SpecialApply
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
            int wkid = Convert.ToInt32(Request["SpecialExpId"].ToString());
            SpecialExpInfo sp = new SpecialExpInfo(wkid);
            lblApplyDate.Text = sp.ApplyDate.ToString();
            lblApplyPeople.Text = sp.ApplyPeople.ToString();
         
                MainProjectCreateInfo project = new MainProjectCreateInfo(Convert.ToInt32(sp.MainProjectCreateId));
                lblMoneyNum.Text = project.PreMoney.ToString();
                lblProject.Text = project.ProjectName.ToString();
        
            
            txtReason.Text = sp.ApplyReason.ToString();
            if (sp.ProjectStepId.ToString() != "")
            {
                ProjectStepInfo step = new ProjectStepInfo(Convert.ToInt32(sp.ProjectStepId));
                lblStep.Text = step.ProjectStepName.ToString();
            }
            lblApplyMoney.Text = sp.ApplyMoney.ToString();
            lblSheetNum.Text = sp.SheetNum.ToString();

            if (sp.SignName == 1)
            {
                imgMarket.Visible = true;
            }
            else if (sp.SignName == 2)
            {
                imgMarket.Visible = true;
                imgManager.Visible = true;
            }

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(ViewState["BackUrl"].ToString());
        }
    }
}
