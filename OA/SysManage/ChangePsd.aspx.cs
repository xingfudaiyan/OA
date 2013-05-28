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
namespace OA
{
    public partial class ChangePsd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ViewState["BackUrl"] = Request.UrlReferrer.ToString();
            lblUserName.Text = Session["userName"].ToString();
        }

   
        protected void btnOk_Click(object sender, EventArgs e)
        {
            string strUserPsd = Session["userPsd"].ToString();
            string username = Session["userName"].ToString();
            string strOldPsd = txtOldUserPsd.Text.ToString();
            string strNewPsd = txtNewPsd.Text.ToString();
            //if (strUserPsd != strOldPsd)
            //{
            //    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('‘≠√‹¬Î¥ÌŒÛ£°');</script>");
            //}
           
                MasterInfo.ResetPsd(username, strOldPsd, strNewPsd);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('√‹¬Î–ﬁ∏ƒ≥…π¶£°');</script>");
            
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect(ViewState["BackUrl"].ToString());

        }
    }
}
