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

namespace OA.Notice
{
    public partial class PerNotice : System.Web.UI.Page
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
            int noticeid=Convert.ToInt32(Request["NoticeId"].ToString());
            if (noticeid == 0)
            {
                hTitle.InnerText = "";
                lblContent.Text = "";
                sName.InnerText = "";
                sTime.InnerText = "";
            }
            else
            {
                NoticeInfo notice = new NoticeInfo(noticeid);
                hTitle.InnerText = notice.NoticeTitle.ToString();
                lblContent.Text = notice.NoticeContent.ToString();
                lblContent.Text = lblContent.Text.Replace(" ", "&nbsp;");
                lblContent.Text = lblContent.Text.Replace("\r\n", "<br>");
                sName.InnerText = notice.SignName.ToString();
                sTime.InnerText = notice.NoticeTime.ToString();
            }
           
        }
    }
}
