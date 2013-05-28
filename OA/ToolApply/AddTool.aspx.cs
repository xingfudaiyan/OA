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
    public partial class AddTool : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["BackUrl"] = Request.UrlReferrer.ToString();
                lblDepartName.Text = Session["DepartName"].ToString();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
                try
                {

                    ToolNumInfo toolnum = new ToolNumInfo();
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

                    ToolInfo tool=new ToolInfo();
                    tool.ToolNumId = toolnum.ToolNumId;
                    tool.MarketMemo = txtMarketMemo.Text.ToString();
                    tool.TechMemo = txtTechMemo.Text.ToString();
                    tool.ZongHeMemo = txtHrMemo.Text.ToString();
                    tool.DepartView = txtDepartView.Text.ToString();
                    tool.ApplyName = Session["EmployeeName"].ToString();
                    tool.State = 0;
                    tool.DepartName = Session["DepartName"].ToString();
                    tool.Save();
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('添加成功！');</script>");
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
