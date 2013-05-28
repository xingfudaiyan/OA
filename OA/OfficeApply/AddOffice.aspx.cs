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

namespace OA.OfficeApply
{
    public partial class AddOffice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PageInit();
                ViewState["BackUrl"] = Request.UrlReferrer.ToString();
            }
        }

        protected void PageInit()
        {
            lblJieDepart.Text = Session["DepartName"].ToString();
            lblBanDepart.Text = Session["DepartName"].ToString();
            lblJinEmployee.Text = Session["EmployeeName"].ToString();
            
        }
   

      
        protected void btnSave_Click(object sender, EventArgs e)
        {
               try
                {
                    WorkToolSumInfo wt = new WorkToolSumInfo();
                    wt.DepartName = Session["DepartName"].ToString();
                    wt.ApplyName = Session["EmployeeName"].ToString();
                    wt.State = 0;
                    wt.FuTime = txtFuTime.Text.ToString();
                    wt.UseDepartName = txtUseDepart.Text.ToString();
                    wt.Reason = txtReason.Text.ToString();
                    wt.BigMoney = txtBigMoney.Text.ToString();
                    wt.SmaMoney = txtSmallMoney.Text.ToString();
                    wt.MoneyStyle = txtFuMoney.Text.ToString();
                    wt.DepartView = txtDepartView.Text.ToString();
                    wt.Save();
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('添加成功！');</script>");
                }
                catch (Exception Ex)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Save", "alert('添加失败：" + Ex.Message + "');", true);
                }
            
        }

      

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(ViewState["BackUrl"].ToString());
        }
    }
}
