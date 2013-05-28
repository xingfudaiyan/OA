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
    public partial class PriceAp1 : System.Web.UI.Page
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

        protected void rblDataBind()
        {
            DataTable dt = OfferPriceInfo.getOfferPriceType();
            rblType.DataSource = dt;
            rblType.DataTextField = "OfferPriceTypeName";
            rblType.DataValueField = "OfferPriceTypeId";
            rblType.DataBind();
        }

        protected void gvProductBind()
        {
            int opId = Convert.ToInt32(Request["OfferPriceId"].ToString());
            DataTable dt = OfferPriceInfo.getProductTypeList(opId);
            gvProductType.DataSource = dt;
            gvProductType.DataBind();

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
            
            txtSectionView.ReadOnly = true;
           
            txtManagerView.Text = op.MangerView.ToString();
            txtSectionView.Text = op.SectionView.ToString();
            rblType.SelectedValue = op.OfferPriceTypeId.ToString();
            txtProjectDes.Text = op.ProjectDes.ToString();
            lblMoneySum.Text = op.ProductMoneySum.ToString();
            if (op.OfferFileId.ToString() == "")
            {
                btnDownLoad.Enabled = false;
            }
            lblSheetNum.Text = op.SheetNum.ToString();
            if (op.MoneySum!=null)
            {
                lblMoneySum.Text = op.MoneySum.ToString();
            }
            if (op.BigMoney != null)
            {
                lblBigMoney.Text = op.BigMoney.ToString();
            }
          
        }


        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                try
                {
                    int opid = Convert.ToInt32(Request["OfferPriceId"].ToString());
                    OfferPriceInfo op = new OfferPriceInfo(opid);
                  
                    op.IsApply1 = 1;
                    DateTime date = DateTime.Now;
                    op.Apply1Time = date;
                    MessageInfo.DelMessageOfMemo(opid.ToString());
                    if (rblOver.Items[0].Selected)
                    {
                        op.IsOver1 = 0;
                        op.IsNewCreate = 1;
                        op.Save();
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('您让申请人修正！');</script>");
                        
                       
                    }
                    else if (rblOver.Items[1].Selected)
                    {
                        op.IsOver1 = 1;
                        //int emid = Convert.ToInt32(Common.getEmployeeIdOfManager());
                        //op.Recv2EmployeeId = emid;
                        op.Save();
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('审批通过！');</script>");
                    }
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('保存成功！');</script>");
                  
                }
                catch (Exception Ex)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Save", "alert('保存失败：" + Ex.Message + "');", true);
                }
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("PriceApprove1.aspx");
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
