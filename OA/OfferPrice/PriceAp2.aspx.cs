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
    public partial class PriceAp2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PageInit();
                rblDataBind();
                gvProductBind();
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
            txtSectionView.ReadOnly = true;
            txtManagerView.Text = op.MangerView.ToString();
            txtSectionView.Text = op.SectionView.ToString();
            rblType.SelectedValue = op.OfferPriceTypeId.ToString();
            txtProjectDes.Text = op.ProjectDes.ToString();
            if (op.OfferFileId.ToString() == "")
            {
                btnDownLoad.Enabled = false;
            }
            if (op.MoneySum != null)
            {
                lblMoneySum.Text = op.MoneySum.ToString();
            }
            if (op.BigMoney != null)
            {
                lblBigMoney.Text = op.BigMoney.ToString();
            }
         
        }

        protected bool IsPageValid()
        {
            if (imgManager.Visible==false)
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
                    int opid = Convert.ToInt32(Request["OfferPriceId"].ToString());
                    OfferPriceInfo op = new OfferPriceInfo(opid);
                    op.MangerView = txtManagerView.Text.ToString();

                    op.IsApply2 = 1;
                    DateTime date = DateTime.Now;
                    op.Apply2Time = date;
                    op.IsSignName = 2;
                    if (rblOver.Items[0].Selected)
                    {
                        op.IsOver2 = 0;
                        op.IsNewCreate = 1;
                        op.Save();
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('您让申请人修正！');</script>");
                        MessageInfo.DelMessageOfMemo(opid.ToString());
                    }
                    else if (rblOver.Items[1].Selected)
                    {
                        op.IsOver2 = 1;
                        op.Save();
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('保存成功！');</script>");
                        MessageInfo.DelMessageOfMemo(opid.ToString());
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
            Response.Redirect("PriceAprove2.aspx");
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
            imgManager.Visible = true;
            btnSign.Enabled = false;
        }
    }
}
