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
    public partial class top : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.lblDate.Text = DateTime.Now.Year.ToString() + "年" + DateTime.Now.Month.ToString() + "月" + DateTime.Now.Day.ToString() + "日      " + this.GetWeekDay();
                //获取登陆名
                string strLoginName = Session["userName"].ToString();
                lblMaster.Text = strLoginName.ToString();

                Notice();
            }

        }
        protected string GetWeekDay()
        {
            string Temp = "";
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    Temp = "星期天";
                    break;
                case DayOfWeek.Monday:
                    Temp = "星期一";
                    break;
                case DayOfWeek.Tuesday:
                    Temp = "星期二";
                    break;
                case DayOfWeek.Wednesday:
                    Temp = "星期三";
                    break;
                case DayOfWeek.Thursday:
                    Temp = "星期四";
                    break;
                case DayOfWeek.Friday:
                    Temp = "星期五";
                    break;
                case DayOfWeek.Saturday:
                    Temp = "星期六";
                    break;
            }
            return Temp;
        }

        protected int getNoticeId()
        {
            int noticeid=NoticeInfo.getMaxNoticeId();
            return noticeid;
        }

        protected void Notice()
        {
            
            int noticeid = NoticeInfo.getMaxNoticeId();
            if (noticeid == 0)
            {
                lblNotice.Text = "";
            }
            else
            {
                NoticeInfo notice = new NoticeInfo(noticeid);
                lblNotice.Text = notice.NoticeTitle.ToString() + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + notice.NoticeTime.ToString();
            }
           
        }
    }
}
