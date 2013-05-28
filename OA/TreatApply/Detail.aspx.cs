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
    public partial class Detail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["BackUrl"] = Request.UrlReferrer.ToString();
                PageInit();
                gvRelateDataBind();
                gvEmployeeDataBind();
                NumOfPeople();
            }
        }

        protected void NumOfPeople()
        {
            int num = gvBEmployee.Rows.Count + gvBRelate.Rows.Count;
            lblPeopleNum.Text = num + "»À";
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

            if (be.SignName == 1)
            {
                imgMarket.Visible = true;
            }
            else if (be.SignName == 2)
            {
                imgMarket.Visible = true;
                imgManager.Visible = true;
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect(ViewState["BackUrl"].ToString());
        }
    }
}
