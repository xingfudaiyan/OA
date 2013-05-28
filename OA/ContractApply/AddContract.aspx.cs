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
    public partial class AddContract : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ViewState["BackUrl"] = Request.UrlReferrer.ToString();
                PageInit();
            }
        }

        protected void PageInit()
        {
            lblDepart.Text=Session["DepartName"].ToString();
            lblEmployee.Text=Session["EmployeeName"].ToString();
            ddlDataBind();

            string strtoday = DateTime.Now.ToString("yyyyMMdd").Substring(2);
            if (SheetNums.IsSheetNumOfCA(strtoday))
            {

                txtSheetNum.Text = SheetNums.SheetNumOfCA("HT", strtoday);
            }
            else
            {
                txtSheetNum.Text = "HT" + strtoday + "001";
            }

        }

        protected void ddlDataBind()
        {
            DataTable dt = ContractInfo.getContractTypeList();
            ddlContractType.DataSource = dt;
            ddlContractType.DataTextField = "ContractTypeName";
            ddlContractType.DataValueField = "ContractTypeId";
            DataRow row = dt.NewRow();
            row["ContractTypeName"] = "请选择合同类型";
            dt.Rows.InsertAt(row, 0);
            ddlContractType.DataBind();
        }

        protected void ddlContractType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlContractType.SelectedItem.Text == "销售合同")
            {
                DataTable dt = ClientInfo.getClientList();
                ddlAuto.DataSource = dt;
                ddlAuto.DataTextField = "ClientName";
                ddlAuto.DataValueField = "ClientId";
                DataRow row = dt.NewRow();
                row["ClientName"] = "请选择客户名称";
                dt.Rows.InsertAt(row, 0);
                ddlAuto.DataBind();
            }
            else if (ddlContractType.SelectedItem.Text == "采购合同")
            {
                DataTable dt = ClientInfo.getSupplyList();
                ddlAuto.DataSource = dt;
                ddlAuto.DataTextField = "SupplyName";
                ddlAuto.DataValueField = "SupplyId";
                DataRow row = dt.NewRow();
                row["SupplyName"] = "请选择供应商";
                dt.Rows.InsertAt(row, 0);
                ddlAuto.DataBind();
            }
            else if (ddlContractType.SelectedItem.Text == "协议")
            {
                
                DataTable dt = ClientInfo.getSupplyList();
                ddlAuto.DataSource = dt;
                ddlAuto.DataTextField = "SupplyName";
                ddlAuto.DataValueField = "SupplyId";
                DataRow row = dt.NewRow();
                row["SupplyName"] = "请选择供应商或客户名称";
                dt.Rows.InsertAt(row, 0);
 /*             dt = ClientInfo.getClientList();
                ddlAuto.DataTextField = "ClientName";
                ddlAuto.DataValueField = "ClientId";
                dt.Rows.InsertAt(row, 15);
  */

                ddlAuto.DataBind();
                //ddlAuto.DataMember();
                /*
                DataTable dt1 = ClientInfo.getClientList();
                ddlAuto.DataSource = dt1;
                ddlAuto.DataTextField = "ClientName";
                ddlAuto.DataValueField = "ClientId";
                DataRow row1 = dt.NewRow();
                dt.Rows.InsertAt(row1, 10);
                ddlAuto.DataBind();
                 */
                 
            }
            txtContractNum.Text = "";
        }

        protected void ddlAuto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strtoday = DateTime.Now.ToString("yyyyMMdd").Substring(2);
            if (ddlContractType.SelectedItem.Text == "销售合同")
            {
                ClientInfo client = new ClientInfo(Convert.ToInt32(ddlAuto.SelectedValue));
                if (SheetNums.IsNumOfContract(client.ClientName.ToString()))
                {
                    txtContractNum.Text = SheetNums.NumOfContract("XS", client.SheetNum.ToString(), strtoday, client.ClientName.ToString());
                }
                else
                {
                    txtContractNum.Text = "XS" + client.SheetNum.ToString() + strtoday + "001";
                }
            }
            else if (ddlContractType.SelectedItem.Text == "采购合同")
            {
                SupplyInfo supply = new SupplyInfo(Convert.ToInt32(ddlAuto.SelectedValue));
                if (SheetNums.IsNumOfContract(supply.SheetNum.ToString()))
                {
                    txtContractNum.Text = SheetNums.NumOfContract("CG", supply.SheetNum.ToString(), strtoday, supply.SheetNum.ToString());
                }
                else
                {
                    txtContractNum.Text = "CG" + supply.SheetNum.ToString() + strtoday + "001";
                }
            }
            else if (ddlContractType.SelectedItem.Text == "协议")
            {
                SupplyInfo supply = new SupplyInfo(Convert.ToInt32(ddlAuto.SelectedValue));
                string sheetnum = supply.SheetNum.ToString();
                if (SheetNums.IsNumOfContract(supply.SheetNum.ToString()))
                {
                    txtContractNum.Text = SheetNums.NumOfContract("XY", sheetnum, strtoday, supply.SheetNum.ToString());
                }
                else
                {
                    txtContractNum.Text = "XY" + supply.SheetNum.ToString() + strtoday + "001";
                }
            }
        }

         protected bool IsPageValid()
        {
            string strRoleName = Session["RoleName"].ToString();
            if (UpFile.HasFile == false)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('请上传合同附件！');</script>");
                return false;
            }
            if (ddlContractType.SelectedValue == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('请选择合同类型！');</script>");
                return false;
            }
            if (ddlAuto.SelectedValue == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('请选择签约方！');</script>");
                return false;
            }
            if (rblSignType.SelectedValue.ToString() == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('用章类型必填！');</script>");
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
                    ContractApplyInfo CA = new ContractApplyInfo();
                    ContractFileInfo cf = new ContractFileInfo();
                    if (UpFile.HasFile)
                    {
                        this.UpFile.PostedFile.SaveAs(Server.MapPath("~/Files/Contract/" + UpFile.FileName));
                       // cf.PhyFileName = UpFile.PostedFile.FileName;
                        cf.ContractFileName = UpFile.FileName.ToString();
                        cf.Save();
                        CA.ContractFileId = Convert.ToInt32(cf.ContractFileId);
                    }
                    CA.BeginDate = txtBeginDate.Text.ToString();
                    CA.SignName=ddlAuto.SelectedItem.Text.ToString();
                    CA.ContractName = txtContractName.Text.ToString();
                    CA.ContractNum=txtContractNum.Text.ToString();
                    CA.SheetNum = txtSheetNum.Text.ToString();
                    CA.Today = DateTime.Now.ToString("yyyyMMdd").Substring(2);
                    CA.BeginDate=txtBeginDate.Text.ToString();
                    CA.ApplyDate=txtApplyDate.Text.ToString();
                    CA.ContractDes=txtContractDes.Text.ToString();
                    CA.BigMoney=txtBigMoney.Text.ToString();
                    CA.SmallMoney=txtSmallMoney.Text.ToString();
                    CA.UseStampType=rblSignType.SelectedItem.Text.ToString();
                    CA.IsMoney=0;
                    if (ckbIsMoney.Checked)
                    {
                        CA.IsMoney = 1;
                    }
                    CA.ApplyName=lblEmployee.Text.ToString();
                    CA.DepartName=lblDepart.Text.ToString();
                    CA.State=0;
                    CA.Save();
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
            Response.Redirect(ViewState["BackUrl"].ToString());
        }
    }
}
