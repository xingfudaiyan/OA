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
    public partial class SPApp2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SpecialBind();
            }
        }

        protected void SpecialBind()
        {
            int wkid = Convert.ToInt32(Request["SpecialExpId"].ToString());
            SpecialExpInfo sp = new SpecialExpInfo(wkid);
            lblApplyDate.Text = sp.ApplyDate.ToString();
            lblApplyPeople.Text = sp.ApplyPeople.ToString();
            lblApplyMoney.Text = sp.ApplyMoney.ToString();
            lblSheetNum.Text = sp.SheetNum.ToString();


    
                MainProjectCreateInfo project = new MainProjectCreateInfo(Convert.ToInt32(sp.MainProjectCreateId));
                lblMoneyNum.Text = project.PreMoney.ToString();
                lblProject.Text = project.ProjectName.ToString();
           
    
            lblReason.Text = sp.ApplyReason.ToString();
            if (sp.ProjectStepId.ToString() != "")
            {
                ProjectStepInfo step = new ProjectStepInfo(Convert.ToInt32(sp.ProjectStepId));
                lblStep.Text = step.ProjectStepName.ToString();
            }
           
           
        }
    
        protected void btnSave_Click(object sender, EventArgs e)
        {
                try
                {
                    int id = Convert.ToInt32(Request["SpecialExpId"].ToString());
                    SpecialExpInfo sp = new SpecialExpInfo(id);

                    sp.IsApply2 = 1;
                    DateTime dt = DateTime.Now;
                    sp.Apply2Time = dt;
                    if (rblOver.Items[0].Selected)
                    {
                        sp.IsOver2 = 0;
                        sp.IsNewCreate = 1;
                        sp.Save();
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('您让申请人修正！');</script>");
                    }
                    else
                    {
                        sp.IsOver2 = 1;
                        sp.Save();
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('审批通过！');</script>");
                    }
                }
                catch (Exception Ex)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Save", "alert('添加失败：" + Ex.Message + "');", true);
                }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("SpecialApprove2.aspx");
        }
    }
}
