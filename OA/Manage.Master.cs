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
    public partial class Manage : System.Web.UI.MasterPage
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
            int emid = Convert.ToInt32(Session["EmployeeId"]);
            DataTable dtMsg = MessageInfo.getMessageOfEm(emid);
            if (dtMsg.Rows.Count > 0)
            {
               
                Page.ClientScript.RegisterStartupScript(Page.ClientScript.GetType(), "myscript", "<script>window.onload=function(){ setTimeout('show_pop()', 800);}</script>");
                switch (dtMsg.Rows.Count)
                {
                    case 1:
                        hr1.Text = "1." + dtMsg.Rows[0]["Msg"].ToString();
                        hr1.NavigateUrl = dtMsg.Rows[0]["Url"].ToString();
                        break;
                    case 2:
                        hr1.Text = "1." + dtMsg.Rows[0]["Msg"].ToString();
                        hr1.NavigateUrl = dtMsg.Rows[0]["Url"].ToString();
                        hr2.Text = "2." + dtMsg.Rows[1]["Msg"].ToString();
                        hr2.NavigateUrl = dtMsg.Rows[1]["Url"].ToString();
                        break;
                    case 3:
                        hr1.Text = "1." + dtMsg.Rows[0]["Msg"].ToString();
                        hr1.NavigateUrl = dtMsg.Rows[0]["Url"].ToString();
                        hr2.Text = "2." + dtMsg.Rows[1]["Msg"].ToString();
                        hr2.NavigateUrl = dtMsg.Rows[1]["Url"].ToString();
                        hr3.Text = "3." + dtMsg.Rows[2]["Msg"].ToString();
                        hr3.NavigateUrl = dtMsg.Rows[2]["Url"].ToString();
                        break;
                    case 4:
                        hr1.Text = "1." + dtMsg.Rows[0]["Msg"].ToString();
                        hr1.NavigateUrl = dtMsg.Rows[0]["Url"].ToString();
                        hr2.Text = "2." + dtMsg.Rows[1]["Msg"].ToString();
                        hr2.NavigateUrl = dtMsg.Rows[1]["Url"].ToString();
                        hr3.Text = "3." + dtMsg.Rows[2]["Msg"].ToString();
                        hr3.NavigateUrl = dtMsg.Rows[2]["Url"].ToString();
                        hr4.Text = "4." + dtMsg.Rows[3]["Msg"].ToString();
                        hr4.NavigateUrl = dtMsg.Rows[3]["Url"].ToString();
                        break;
                    case 5:
                        hr1.Text = "1." + dtMsg.Rows[0]["Msg"].ToString();
                        hr1.NavigateUrl = dtMsg.Rows[0]["Url"].ToString();
                        hr2.Text = "2." + dtMsg.Rows[1]["Msg"].ToString();
                        hr2.NavigateUrl = dtMsg.Rows[1]["Url"].ToString();
                        hr3.Text = "3." + dtMsg.Rows[2]["Msg"].ToString();
                        hr3.NavigateUrl = dtMsg.Rows[2]["Url"].ToString();
                        hr4.Text = "4." + dtMsg.Rows[3]["Msg"].ToString();
                        hr4.NavigateUrl = dtMsg.Rows[3]["Url"].ToString();
                        hr5.Text = "5." + dtMsg.Rows[4]["Msg"].ToString();
                        hr5.NavigateUrl = dtMsg.Rows[4]["Url"].ToString();
                        break;
                    case 6:
                        hr1.Text = "1." + dtMsg.Rows[0]["Msg"].ToString();
                        hr1.NavigateUrl = dtMsg.Rows[0]["Url"].ToString();
                        hr2.Text = "2." + dtMsg.Rows[1]["Msg"].ToString();
                        hr2.NavigateUrl = dtMsg.Rows[1]["Url"].ToString();
                        hr3.Text = "3." + dtMsg.Rows[2]["Msg"].ToString();
                        hr3.NavigateUrl = dtMsg.Rows[2]["Url"].ToString();
                        hr4.Text = "4." + dtMsg.Rows[3]["Msg"].ToString();
                        hr4.NavigateUrl = dtMsg.Rows[3]["Url"].ToString();
                        hr5.Text = "5." + dtMsg.Rows[4]["Msg"].ToString();
                        hr5.NavigateUrl = dtMsg.Rows[4]["Url"].ToString();
                        hr6.Text = "6." + dtMsg.Rows[5]["Msg"].ToString();
                        hr6.NavigateUrl = dtMsg.Rows[5]["Url"].ToString();
                        break;
                    default:
                        hr1.Text = "1." + dtMsg.Rows[0]["Msg"].ToString();
                        hr1.NavigateUrl = dtMsg.Rows[0]["Url"].ToString();
                        hr2.Text = "2." + dtMsg.Rows[1]["Msg"].ToString();
                        hr2.NavigateUrl = dtMsg.Rows[1]["Url"].ToString();
                        hr3.Text = "3." + dtMsg.Rows[2]["Msg"].ToString();
                        hr3.NavigateUrl = dtMsg.Rows[2]["Url"].ToString();
                        hr4.Text = "4." + dtMsg.Rows[3]["Msg"].ToString();
                        hr4.NavigateUrl = dtMsg.Rows[3]["Url"].ToString();
                        hr5.Text = "5." + dtMsg.Rows[4]["Msg"].ToString();
                        hr5.NavigateUrl = dtMsg.Rows[4]["Url"].ToString();
                        hr6.Text = "6." + dtMsg.Rows[5]["Msg"].ToString();
                        hr6.NavigateUrl = dtMsg.Rows[5]["Url"].ToString();
                        hr7.Text = "7." + dtMsg.Rows[6]["Msg"].ToString();
                        hr7.NavigateUrl = dtMsg.Rows[6]["Url"].ToString();
                        break;

                }
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(Page.ClientScript.GetType(), "myscript", "<script>displayDIV();</script>");
            }

            
        }
    }
}
