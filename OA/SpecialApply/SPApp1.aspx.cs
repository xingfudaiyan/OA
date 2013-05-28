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
    public partial class SPApp1 : System.Web.UI.Page
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
            txtReason.Text = sp.ApplyReason.ToString();
            if (sp.ProjectStepId.ToString() != "")
            {
                ProjectStepInfo step = new ProjectStepInfo(Convert.ToInt32(sp.ProjectStepId));
                lblStep.Text = step.ProjectStepName.ToString();
            }
        }


        protected bool IsPageValid()
        {
            if (imgManager.Visible == false)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('请签名！');</script>");
                return false;
            }
            else if (rblOver.SelectedIndex == -1)
            {

                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('请选择修正或通过！');</script>");
                return false;
            }
            else
            {
                return true;
            }
        }


        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (IsPageValid())
            {
                try
                {
                    int id = Convert.ToInt32(Request["SpecialExpId"].ToString());
                    SpecialExpInfo sp = new SpecialExpInfo(id);

                    sp.IsApply1 = 1;
                    DateTime dt = DateTime.Now;
                    sp.Apply1Time = dt;
                    sp.SignName = 2;
                    if (rblOver.Items[0].Selected)
                    {
                        sp.IsOver1 = 0;
                        sp.IsNewCreate = 1;
                        sp.Save();
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('您让申请人修正！');</script>");
                    }
                    else
                    {
                        sp.IsOver1 = 1;
                        sp.Save();
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('审批通过！');</script>");
                    }

                }
                catch (Exception Ex)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Save", "alert('添加失败：" + Ex.Message + "');", true);
                }
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("SpecialApprove1.aspx");
        }

        protected void btnSign_Click(object sender, EventArgs e)
        {
            imgManager.Visible = true;
            btnSign.Enabled = false;
        }
    }
}
