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


namespace OA.TreatApply
{
    public partial class PreApp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvRelateDataBind();
                gvEmployeeDataBind();
                PageInit();
                NumOfPeople();
            }
        }
        protected void NumOfPeople()
        {
            int num = gvBEmployee.Rows.Count + gvBRelate.Rows.Count;
            lblPeopleNum.Text = num + "人";
        }

        protected void gvRelateDataBind()
        {
            int bExpId = Convert.ToInt32(Request["BusinessExpId"].ToString());
            DataTable dt = BusinessExpInfo.getRelateBExp(bExpId);
            gvBRelate.DataSource = dt;
            gvBRelate.DataBind();
        }

        protected void gvEmployeeDataBind()
        {
            int bExpId = Convert.ToInt32(Request["BusinessExpId"].ToString());
            DataTable dt = BusinessExpInfo.getEmployeeBExp(bExpId);
            gvBEmployee.DataSource = dt;
            gvBEmployee.DataBind();
        }

        protected void PageInit()
        {
            int id = Convert.ToInt32(Request["BusinessExpId"].ToString());
            BusinessExpInfo be = new BusinessExpInfo(id);
            lblApplyDate.Text = be.ApplyDate.ToString();
            lblApplyPeople.Text = be.ApplyPeople.ToString();
            lblDepart.Text = be.Depart.ToString();
            lblMemo.Text = be.Memo.ToString();
            txtReason.Text = be.ReasonExp.ToString();
            lblItem1.Text = be.Item1.ToString();
            lblItem2.Text = be.Item2.ToString();
            lblItem3.Text = be.Item3.ToString();
            lblItem4.Text = be.Item4.ToString();
            lblMoney1.Text = be.Money1.ToString();
            lblMoney2.Text = be.Money2.ToString();
            lblMoney3.Text = be.Money3.ToString();
            lblMoney4.Text = be.Money4.ToString();
            lblMoneySum.Text = be.MoneySum.ToString();
            lblSheetNum.Text = be.SheetNum.ToString();
        }

        protected bool IsPageValid()
        {
            if (imgMarket.Visible == false)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('请签名！');</script>");
                return false;
            }
            else if (rblOver.SelectedIndex == -1)
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
                    

                    int wkid = Convert.ToInt32(Request["BusinessExpId"].ToString());
                    BusinessExpInfo pc = new BusinessExpInfo(wkid);

                    pc.IsApprove = 1;
                    pc.SignName = 1;
                    DateTime date = DateTime.Now;
                    pc.ApproveTime = date;
                    if (rblOver.Items[0].Selected)
                    {
                        pc.PreIsOver = 0;
                        pc.IsNewCreate = 1;
                        pc.Save();
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('您让申请人修正！');</script>");
                      
                    }
                    else if (rblOver.Items[1].Selected)
                    {
                        pc.PreIsOver = 1;
                        int emid = Convert.ToInt32(Common.getEmployeeIdOfManager());//经理接收
                        pc.Recv1EmployeeId = emid;
                        pc.Save();
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
            Response.Redirect("PreTreatApprove.aspx");
        }

        protected void btnSign_Click(object sender, EventArgs e)
        {
            imgMarket.Visible = true;
            btnSign.Enabled = false;
        }
    }
}
