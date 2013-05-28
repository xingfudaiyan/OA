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

namespace OA.tab
{
    public partial class tab : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ApplyInit();
                FileInit();
                NoticeInit();
            }
        }

        protected void ApplyInit()
        {


            int emid = Convert.ToInt32(Session["EmployeeId"]);
            DataTable dt = MessageInfo.getMsgOfEmAndType(emid, "daiban");
            if (dt.Rows.Count > 7)
            {
                for (int i = 0; i < 7; i++)
                {
                    string strUrl = dt.Rows[i]["Url"].ToString().Substring(2);
                    string strTitle = dt.Rows[i]["MsgTitle"].ToString();
                    string strTime = "[" + dt.Rows[i]["MsgTime"].ToString() + "]";

                    HtmlGenericControl li = new HtmlGenericControl();
                    li.InnerHtml = "<li> <a href='" + strUrl + "' style='text-decoration:none; color:Blank;'>" + strTitle + "</a> </li>";
                    uApply.Controls.Add((Control)li);

                    HtmlGenericControl lit = new HtmlGenericControl();
                    lit.InnerHtml = "<li> <a style='text-decoration:none'>" + strTime + "</a> </li>";
                    uTime1.Controls.Add((Control)lit);
                }
            }
            else
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string strUrl = dt.Rows[i]["Url"].ToString().Substring(2);
                    string strTitle = dt.Rows[i]["MsgTitle"].ToString();
                    string strTime = "[" + dt.Rows[i]["MsgTime"].ToString() + "]";

                    HtmlGenericControl li = new HtmlGenericControl();
                    li.InnerHtml = "<li> <a href='" + strUrl + "' style='text-decoration:none; color:Blank;'>" + strTitle + "</a> </li>";
                    uApply.Controls.Add((Control)li);

                    HtmlGenericControl lit = new HtmlGenericControl();
                    lit.InnerHtml = "<li> <a style='text-decoration:none'>" + strTime + "</a> </li>";
                    uTime1.Controls.Add((Control)lit);
                }
            }
            
        }


        protected void FileInit()
        {
            int emid = Convert.ToInt32(Session["EmployeeId"]);
            DataTable dt = MessageInfo.getMsgOfEmAndType(emid, "daiyue");
            if (dt.Rows.Count > 7)
            {
                for (int i = 0; i < 7; i++)
                {
                    string strUrl = dt.Rows[i]["Url"].ToString().Substring(2);
                    string strTitle = dt.Rows[i]["MsgTitle"].ToString();
                    string strTime = "[" + dt.Rows[i]["MsgTime"].ToString() + "]";

                    HtmlGenericControl li1 = new HtmlGenericControl();
                    li1.InnerHtml = "<li> <a href='" + strUrl + "' style='text-decoration:none; color:Blank;'>" + strTitle + "</a> </li>";
                    uFile.Controls.Add((Control)li1);

                    HtmlGenericControl lit1 = new HtmlGenericControl();
                    lit1.InnerHtml = "<li> <a style='text-decoration:none'>" + strTime + "</a> </li>";
                    uTime2.Controls.Add((Control)lit1);
                }
            }
            else
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string strUrl = dt.Rows[i]["Url"].ToString().Substring(2);
                    string strTitle = dt.Rows[i]["MsgTitle"].ToString();
                    string strTime = "[" + dt.Rows[i]["MsgTime"].ToString() + "]";

                    HtmlGenericControl li1 = new HtmlGenericControl();
                    li1.InnerHtml = "<li> <a href='" + strUrl + "' style='text-decoration:none; color:Blank;'>" + strTitle + "</a> </li>";
                    uFile.Controls.Add((Control)li1);

                    HtmlGenericControl lit1 = new HtmlGenericControl();
                    lit1.InnerHtml = "<li> <a style='text-decoration:none'>" + strTime + "</a> </li>";
                    uTime2.Controls.Add((Control)lit1);
                }
            }
          
        }

        protected void NoticeInit()
        {
            DataTable dt = NoticeInfo.getNoticeAsc();

            if (dt.Rows.Count > 7)
            {
                for (int i = 0; i < 7; i++)
                {
                    string strTitle = dt.Rows[i]["NoticeTitle"].ToString();
                    string strTime = "[" + dt.Rows[i]["NoticeTime"].ToString() + "]";
                    int NoticeId = Convert.ToInt32(dt.Rows[i]["NoticeId"].ToString());
                    string strUrl = "Notice/NoticeManage.aspx";

                    HtmlGenericControl li = new HtmlGenericControl();
                    li.InnerHtml = "<li> <a href='" + strUrl + "' style='text-decoration:none; color:Blank;'>" + strTitle + "</a> </li>";
                    uNotice.Controls.Add((Control)li);

                    HtmlGenericControl lit = new HtmlGenericControl();
                    lit.InnerHtml = "<li> <a style='text-decoration:none'>" + strTime + "</a> </li>";
                    uTime5.Controls.Add((Control)lit);
                }
            }
            else
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    string strTitle = dt.Rows[i]["NoticeTitle"].ToString();
                    string strTime = "[" + dt.Rows[i]["NoticeTime"].ToString() + "]";
                    int NoticeId = Convert.ToInt32(dt.Rows[i]["NoticeId"].ToString());
                    string strUrl = "Notice/NoticeManage.aspx";

                    HtmlGenericControl li = new HtmlGenericControl();
                    li.InnerHtml = "<li> <a href='" + strUrl + "' style='text-decoration:none; color:Blank;'>" + strTitle + "</a> </li>";
                    uNotice.Controls.Add((Control)li);

                    HtmlGenericControl lit = new HtmlGenericControl();
                    lit.InnerHtml = "<li> <a style='text-decoration:none'>" + strTime + "</a> </li>";
                    uTime5.Controls.Add((Control)lit);
                }
            }
           
        }

       
       
    }
}
