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
    public partial class Detail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["BackUrl"] = Request.UrlReferrer.ToString();
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

            txtManagerView.Text = op.MangerView.ToString();
            txtSectionView.Text = op.SectionView.ToString();
            rblType.SelectedValue = op.OfferPriceTypeId.ToString();
            txtProjectDes.Text = op.ProjectDes.ToString();
            lblMoneySum.Text = op.ProductMoneySum.ToString();

            if (op.OfferFileId.ToString() == "")
            {
                btnDownLoad.Enabled = false;
            }
            if (op.MoneySum != null)
            {
                lblMoneySum.Text = op.MoneySum.ToString();
            }
           
            lblSheetNum.Text = op.SheetNum.ToString();
            if (op.MoneySum != null)
            {
                lblMoneySum.Text = op.MoneySum.ToString();
            }
            if (op.BigMoney != null)
            {
                lblBigMoney.Text = op.BigMoney.ToString();
            }


            if (op.IsSignName == 1)
            {
                imgMarket.Visible = true;
            }
            else if (op.IsSignName == 2)
            {
                imgMarket.Visible = true;
                imgManager.Visible = true;
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect(ViewState["BackUrl"].ToString());
        }

        protected void btnDownLoad_Click(object sender, EventArgs e)
        {
            int opId = Convert.ToInt32(Request["OfferPriceId"].ToString());
            OfferPriceInfo op = new OfferPriceInfo(opId);
            
            OfferFileInfo file = new OfferFileInfo(Convert.ToInt32(op.OfferFileId));
            int fileid = Convert.ToInt32(file.OfferFileId);
            Response.Redirect("DownLoadFile.aspx?fileid="+fileid);
        }
    }
}
