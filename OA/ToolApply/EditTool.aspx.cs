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
    public partial class EditTool : System.Web.UI.Page
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
            int toolid = Convert.ToInt32(Request["ToolApplyId"].ToString());
            ToolInfo tool = new ToolInfo(toolid);
          
            txtMarketMemo.Text = tool.MarketMemo.ToString();
            txtTechMemo.Text = tool.TechMemo.ToString();
            txtHrMemo.Text = tool.ZongHeMemo.ToString();
            txtDepartView.Text = tool.DepartView.ToString();
            lblDepartName.Text = tool.DepartName.ToString();

            ToolNumInfo toolnum = new ToolNumInfo(Convert.ToInt32(tool.ToolNumId));
            txt1.Text = toolnum.Num1.ToString();
            txt2.Text = toolnum.Num2.ToString();
            txt3.Text = toolnum.Num3.ToString();
            txt4.Text = toolnum.Num4.ToString();
            txt5.Text = toolnum.Num5.ToString();
            txt6.Text = toolnum.Num6.ToString();
            txt7.Text = toolnum.Num7.ToString();
            txt8.Text = toolnum.Num8.ToString();
            txt9.Text = toolnum.Num9.ToString();
            txt10.Text = toolnum.Num10.ToString();
            txt11.Text = toolnum.Num11.ToString();
            txt12.Text = toolnum.Num12.ToString();
            txt13.Text = toolnum.Num13.ToString();
            txt14.Text = toolnum.Num14.ToString();
            txt15.Text = toolnum.Num15.ToString();
            txt16.Text = toolnum.Num16.ToString();
            txt17.Text = toolnum.Num17.ToString();
            txt18.Text = toolnum.Num18.ToString();
            txt19.Text = toolnum.Num19.ToString();
            txt20.Text = toolnum.Num20.ToString();
            txt21.Text = toolnum.Num21.ToString();
            txt22.Text = toolnum.Num22.ToString();
            txt23.Text = toolnum.Num23.ToString();
            txt24.Text = toolnum.Num24.ToString();
            txt25.Text = toolnum.Num25.ToString();
            txt26.Text = toolnum.Num26.ToString();
            txt27.Text = toolnum.Num27.ToString();
            txt28.Text = toolnum.Num28.ToString();
            txt29.Text = toolnum.Num29.ToString();
            txt30.Text = toolnum.Num30.ToString();
            txt31.Text = toolnum.Num31.ToString();
            txt32.Text = toolnum.Num32.ToString();
            txt33.Text = toolnum.Num33.ToString();
            txt34.Text = toolnum.Num34.ToString();
            txt35.Text = toolnum.Num35.ToString();
            txt36.Text = toolnum.Num36.ToString();
            txt37.Text = toolnum.Num37.ToString();
            txt38.Text = toolnum.Num38.ToString();
            txt39.Text = toolnum.Num39.ToString();
            txt40.Text = toolnum.Num40.ToString();
        }
       
    

        protected void btnAdd_Click(object sender, EventArgs e)
        {
          
                try
                {

                    int toolid = Convert.ToInt32(Request["ToolApplyId"].ToString());
                        ToolInfo tool = new ToolInfo(toolid);

                        ToolNumInfo toolnum = new ToolNumInfo(Convert.ToInt32(tool.ToolNumId));
                        toolnum.Num1 = txt1.Text.ToString();
                        toolnum.Num2 = txt2.Text.ToString();
                        toolnum.Num3 = txt3.Text.ToString();
                        toolnum.Num4 = txt4.Text.ToString();
                        toolnum.Num5 = txt5.Text.ToString();
                        toolnum.Num6 = txt6.Text.ToString();
                        toolnum.Num7 = txt7.Text.ToString();
                        toolnum.Num8 = txt8.Text.ToString();
                        toolnum.Num9 = txt9.Text.ToString();
                        toolnum.Num10 = txt10.Text.ToString();
                        toolnum.Num11 = txt11.Text.ToString();
                        toolnum.Num12 = txt12.Text.ToString();
                        toolnum.Num13 = txt13.Text.ToString();
                        toolnum.Num14 = txt14.Text.ToString();
                        toolnum.Num15 = txt15.Text.ToString();
                        toolnum.Num16 = txt16.Text.ToString();
                        toolnum.Num17 = txt17.Text.ToString();
                        toolnum.Num18 = txt18.Text.ToString();
                        toolnum.Num19 = txt19.Text.ToString();
                        toolnum.Num20 = txt20.Text.ToString();
                        toolnum.Num21 = txt21.Text.ToString();
                        toolnum.Num22 = txt22.Text.ToString();
                        toolnum.Num23 = txt23.Text.ToString();
                        toolnum.Num24 = txt24.Text.ToString();
                        toolnum.Num25 = txt25.Text.ToString();
                        toolnum.Num26 = txt26.Text.ToString();
                        toolnum.Num27 = txt27.Text.ToString();
                        toolnum.Num28 = txt28.Text.ToString();
                        toolnum.Num29 = txt29.Text.ToString();
                        toolnum.Num30 = txt30.Text.ToString();
                        toolnum.Num31 = txt31.Text.ToString();
                        toolnum.Num32 = txt32.Text.ToString();
                        toolnum.Num33 = txt33.Text.ToString();
                        toolnum.Num34 = txt34.Text.ToString();
                        toolnum.Num35 = txt35.Text.ToString();
                        toolnum.Num36 = txt36.Text.ToString();
                        toolnum.Num37 = txt37.Text.ToString();
                        toolnum.Num38 = txt38.Text.ToString();
                        toolnum.Num39 = txt39.Text.ToString();
                        toolnum.Num40 = txt40.Text.ToString();
                        toolnum.Save();
                       
                        tool.MarketMemo = txtMarketMemo.Text.ToString();
                        tool.TechMemo = txtTechMemo.Text.ToString();
                        tool.ZongHeMemo = txtHrMemo.Text.ToString();
                        tool.DepartView = txtDepartView.Text.ToString();
                        tool.Save();
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('保存成功！');</script>");
                    

                }
                catch (Exception Ex)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Save", "alert('保存失败：" + Ex.Message + "');", true);
                }
            
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(ViewState["BackUrl"].ToString());
        }
    }
}
