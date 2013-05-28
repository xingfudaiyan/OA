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
    public partial class PreApp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PageInit();
              
            }
        }


        protected void PageInit()
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
            if (imgMarket.Visible == false)
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
                    EmployeeInfo em = (EmployeeInfo)Session["Employee"];
                    int wkid = Convert.ToInt32(Request["SpecialExpId"].ToString());
                    SpecialExpInfo pc = new SpecialExpInfo(wkid);
                    pc.IsApprove = 1;
                    pc.SignName = 1;
                    DateTime date = DateTime.Now;
                    pc.ApproveTime = date;
                    if (rblOver.Items[0].Selected)
                    {
                        pc.PreIsOver = 0;
                        pc.IsNewCreate = 1;
                        pc.Save();
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('您让申请人修正！');</script>");
                       
                    }
                    else if (rblOver.Items[1].Selected)
                    {
                        pc.PreIsOver = 1;
                        int emid = Convert.ToInt32(Common.getEmployeeIdOfManager());//总经理接收
                        pc.Recv1EmployeeId = emid;
                        pc.Save();
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('审批通过！');</script>");
                       
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
            Response.Redirect("PreSpecialExpApprove.aspx");
        }

        protected void btnSign_Click(object sender, EventArgs e)
        {
            imgMarket.Visible = true;
            btnSign.Enabled = false;
        }
    }
}
