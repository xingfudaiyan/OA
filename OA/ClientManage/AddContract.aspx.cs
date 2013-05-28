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
using System.IO;
using System.Net;

namespace OA.ClientManage
{
    public partial class AddContract : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["BackUrl"] = Request.UrlReferrer.ToString();
                ddlDataBind();
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

        protected bool IsPageValid()
        {
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
            if(ContractApplyInfo.IsContractFileSame(UpFile.FileName))
            {
                  Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('该文件名已存在，请重命名！');</script>");
                  return false;
            }
            else
            {
                return true;
            }

        }

      

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsPageValid())
            {
                try
                {
                    ContractInfo contract = new ContractInfo();
                    contract.BeginDate = txtBeginDate.Text.ToString();
                    contract.SignName = ddlAuto.SelectedItem.Text.ToString();
                    if (UpFile.HasFile)
                    {
                        this.UpFile.PostedFile.SaveAs(Server.MapPath("~/Files/Contract/" + UpFile.FileName));
                        ContractFileInfo cf = new ContractFileInfo();
                        cf.PhyFileName = UpFile.PostedFile.FileName;
                        cf.ContractFileName = UpFile.FileName.ToString();
                        cf.Save();
                        contract.ContractFileId = Convert.ToInt32(cf.ContractFileId);
                    }

                    contract.SignName = ddlAuto.SelectedItem.Text.ToString();
                    contract.ContractName = txtContractName.Text.ToString();
                    contract.ContractNum = txtContractNum.Text.ToString();
                    contract.MoneySum = txtMoney.Text.ToString();
                    contract.Save();
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('添加成功！');</script>");
                   
                }
                catch (Exception Ex)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Save", "alert('添加失败：" + Ex.Message + "');", true);
                }
            }

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(ViewState["BackUrl"].ToString());
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
                row["SupplyName"] = "请选择供应商";
                dt.Rows.InsertAt(row, 0);
                ddlAuto.DataBind();
                /*
                DataTable dt1 = ClientInfo.getClientList();
                ddlAuto.DataSource = dt1;
                ddlAuto.DataTextField = "ClientName";
                ddlAuto.DataValueField = "ClientId";
                DataRow row1 = dt.NewRow();
                dt.Rows.InsertAt(row1, 0);
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
    }
}
