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

namespace OA.Supply
{
    public partial class AddSupply : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected bool PageInit()
        {
            if (SupplyInfo.IsSheetNum(txtSheetNum.Text.ToString()))
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('该编号已存在！');</script>");
                return false;
            }
            else
            {
                
                return true;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (PageInit())
            {
                try
                {
                    SupplyInfo sp = new SupplyInfo();
                    sp.SheetNum = txtSheetNum.Text.ToString();
                    sp.SupplyName = txtName.Text.ToString();
                    sp.Save();
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
            Response.Redirect("SupplyManage.aspx");
        }
    }
}
