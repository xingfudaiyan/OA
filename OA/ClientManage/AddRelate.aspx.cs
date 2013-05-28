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

namespace OA.ClientManage
{
    public partial class AddRelate : System.Web.UI.Page
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
            int ClientId = Convert.ToInt32(Request["ClientId"].ToString());
            ClientInfo client = new ClientInfo(ClientId);
            lblAddress.Text = client.Address.ToString();
           
            lblClientName.Text = client.ClientName.ToString();
            lblClientNum.Text = client.SheetNum.ToString();
            lblFax.Text = client.Fax.ToString();
            lblMailNo.Text = client.MailNo.ToString();
            lblTelephone.Text = client.Telephone.ToString();
            int clientlevelid = Convert.ToInt32(client.ClientLevelId);
            ClientLevelInfo clientlevel = new ClientLevelInfo(clientlevelid);
            lblClientLevel.Text = clientlevel.ClientLevelName.ToString();

        }


        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int ClientId = Convert.ToInt32(Request["ClientId"].ToString());

                RelateInfo relate = new RelateInfo();
                relate.ClientId = ClientId;
                relate.Email = txtEmail.Text.ToString();
                relate.Memo = txtMemo.Text.ToString();
                relate.Mobile = txtMobile.Text.ToString();
                relate.RelateName = txtRelateName.Text.ToString();
                relate.Position = txtPosition.Text.ToString();
                relate.Save();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('添加成功！');</script>");

                ClearForms();
            }
            catch(Exception Ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Save", "alert('保存失败：" + Ex.Message + "');", true); 
            }
            

        }

        //清空控件值
        private void ClearForms()
        {
            foreach (Control ct in this.FindControl("form1").Controls)
            {

                if (ct is TextBox)
                {
                    TextBox tb = ct as TextBox;
                    tb.Text = "";
                }

                if (ct is RadioButtonList)
                {
                    RadioButtonList rbl = ct as RadioButtonList;
                    rbl.SelectedIndex = 0;
                }

                if (ct is DropDownList)
                {
                    DropDownList ddl = ct as DropDownList;
                    ddl.SelectedIndex = 0;
                }
            }
        }


        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Client.aspx");
        }
    }
}
