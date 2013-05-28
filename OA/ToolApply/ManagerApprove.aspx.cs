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

namespace OA.ToolApply
{
    public partial class ManagerApprove : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["BackUrl"] = Request.UrlReferrer.ToString();
                PageInit();
            }
        }

        protected void PageInit()
        {
            int toolid = Convert.ToInt32(Request["ToolApplyId"].ToString());
            ToolInfo tool = new ToolInfo(toolid);
            txtMarketMemo.Text = tool.MarketMemo.ToString();
            txtTechMemo.Text = tool.TechMemo.ToString();
            txtHrMemo.Text = tool.ZongHeMemo.ToString();
            lblDepartName.Text = tool.DepartName.ToString();
            lblDepartView.Text = tool.DepartView.ToString();
          
            ToolNumInfo toolnum = new ToolNumInfo(Convert.ToInt32(tool.ToolNumId));
            lbl1.Text = toolnum.Num1.ToString();
            lbl2.Text = toolnum.Num2.ToString();
            lbl3.Text = toolnum.Num3.ToString();
            lbl4.Text = toolnum.Num4.ToString();
            lbl5.Text = toolnum.Num5.ToString();
            lbl6.Text = toolnum.Num6.ToString();
            lbl7.Text = toolnum.Num7.ToString();
            lbl8.Text = toolnum.Num8.ToString();
            lbl9.Text = toolnum.Num9.ToString();
            lbl10.Text = toolnum.Num10.ToString();
            lbl11.Text = toolnum.Num11.ToString();
            lbl12.Text = toolnum.Num12.ToString();
            lbl13.Text = toolnum.Num13.ToString();
            lbl14.Text = toolnum.Num14.ToString();
            lbl15.Text = toolnum.Num15.ToString();
            lbl16.Text = toolnum.Num16.ToString();
            lbl17.Text = toolnum.Num17.ToString();
            lbl18.Text = toolnum.Num18.ToString();
            lbl19.Text = toolnum.Num19.ToString();
            lbl20.Text = toolnum.Num20.ToString();
            lbl21.Text = toolnum.Num21.ToString();
            lbl22.Text = toolnum.Num22.ToString();
            lbl23.Text = toolnum.Num23.ToString();
            lbl24.Text = toolnum.Num24.ToString();
            lbl25.Text = toolnum.Num25.ToString();
            lbl26.Text = toolnum.Num26.ToString();
            lbl27.Text = toolnum.Num27.ToString();
            lbl28.Text = toolnum.Num28.ToString();
            lbl29.Text = toolnum.Num29.ToString();
            lbl30.Text = toolnum.Num30.ToString();
            lbl31.Text = toolnum.Num31.ToString();
            lbl32.Text = toolnum.Num32.ToString();
            lbl33.Text = toolnum.Num33.ToString();
            lbl34.Text = toolnum.Num34.ToString();
            lbl35.Text = toolnum.Num35.ToString();
            lbl36.Text = toolnum.Num36.ToString();
            lbl37.Text = toolnum.Num37.ToString();
            lbl38.Text = toolnum.Num38.ToString();
            lbl39.Text = toolnum.Num39.ToString();
            lbl40.Text = toolnum.Num40.ToString();

        }

        protected bool IsPageValid()
        {
            if (rblOver.SelectedIndex == -1)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('请选择修正或通过！');</script>");
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
                    int id = Convert.ToInt32(Request["ToolApplyId"].ToString());
                    ToolInfo t = new ToolInfo(id);
                    t.ManagerView = txtManagerView.Text.ToString();
                    if (rblOver.Items[0].Selected)
                    {
                        t.State = 5;
                        t.Save();
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('您让申请人修正！');</script>");

                    }
                    else if (rblOver.Items[1].Selected)
                    {
                        t.State = 4;
                        t.Save();
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('审批通过！');</script>");

                    }


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
