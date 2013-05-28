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

namespace OA.OfferPrice
{
    public partial class PreApp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PageInit();
                gvProductBind();
                rblDataBind();
            }
           
        }

        protected void gvProductBind()
        {
            int opId = Convert.ToInt32(Request["OfferPriceId"].ToString());
            DataTable dt = OfferPriceInfo.getProductTypeList(opId);
            gvProductType.DataSource = dt;
            gvProductType.DataBind();

        }

        protected void rblDataBind()
        {
            DataTable dt = OfferPriceInfo.getOfferPriceType();
            rblType.DataSource = dt;
            rblType.DataTextField = "OfferPriceTypeName";
            rblType.DataValueField = "OfferPriceTypeId";
            rblType.DataBind();
        }

        protected void PageInit()
        {
            int opid = Convert.ToInt32(Request["OfferPriceId"].ToString());
            OfferPriceInfo op = new OfferPriceInfo(opid);
            MainProjectCreateInfo project = new MainProjectCreateInfo(Convert.ToInt32(op.MainProjectCreateId));
            lblProject.Text = project.ProjectName;
            lblProjectNum.Text = project.SheetNum;
            EmployeeInfo em = new EmployeeInfo(Convert.ToInt32(op.EmployeeId));
            lblEmployee.Text = em.EmployeeName.ToString();
            lblFillTableDate.Text = op.FillTableDate.ToString();
            lblSheetNum.Text = op.SheetNum.ToString();
            
            txtManagerView.ReadOnly = true;
           
            txtManagerView.Text = op.MangerView.ToString();
            txtSectionView.Text = op.SectionView.ToString();
            rblType.SelectedValue = op.OfferPriceTypeId.ToString();
            txtProjectDes.Text = op.ProjectDes.ToString();
            lblMoneySum.Text = op.ProductMoneySum.ToString();
            if (op.OfferFileId.ToString() == "")
            {
                btnDownLoad.Enabled = false;
            }
            if (op.BigMoney != null)
            {
                lblBigMoney.Text = op.BigMoney.ToString();
            }
            if (op.MoneySum != null)
            {
                lblMoneySum.Text = op.MoneySum.ToString();
            }
        }

        protected bool IsPageValid()
        {
            if (imgMarket.Visible == false)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('请签名！');</script>");
                return false;
            }
            if (rblOver.SelectedIndex == -1)
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
                    
                    int wkid = Convert.ToInt32(Request["OfferPriceId"].ToString());
                    OfferPriceInfo pc = new OfferPriceInfo(wkid);

                    pc.SectionView = txtSectionView.Text.ToString();
                    pc.IsApprove = 1;
                    DateTime date = DateTime.Now;
                    pc.ApproveTime = date;
                    pc.IsSignName = 1;
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
                        //int emid = Convert.ToInt32(Common.getEmployeeIdOfFinaceManager());//财务部经理接收
                        //pc.Recv1EmployeeId = emid;
                        int emid = Convert.ToInt32(Common.getEmployeeIdOfManager());//总经理接收
                        pc.Recv2EmployeeId = emid;
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
            Response.Redirect("PrePriceApprove.aspx");
        }

        protected void btnDownLoad_Click(object sender, EventArgs e)
        {
            int opId = Convert.ToInt32(Request["OfferPriceId"].ToString());
            OfferPriceInfo op = new OfferPriceInfo(opId);

            OfferFileInfo file = new OfferFileInfo(Convert.ToInt32(op.OfferFileId));
            int fileid = Convert.ToInt32(file.OfferFileId);
            Response.Redirect("DownLoadFile.aspx?fileid=" + fileid);
        }

        protected void btnSign_Click(object sender, EventArgs e)
        {
            imgMarket.Visible = true;
            btnSign.Enabled = false;
        }
    }
}
