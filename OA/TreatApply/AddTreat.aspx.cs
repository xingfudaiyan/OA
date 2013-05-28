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
    public partial class AddTreat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PageInit();
                ddlClientBind();
                ddlEmDataBind();
                ViewState["Isbtn"] = "0";
                SheetNum();
                ViewState["BackUrl"] = Request.UrlReferrer.ToString();
            }
        }

      

        protected void SheetNum()
        {
            DateTime date = DateTime.Now;
            string today = DateTime.Now.ToString("yyyyMMdd");
            string strtoday = today.Substring(2);
            if (SheetNums.IsSheetNumOfBE(strtoday))
            {

                txtSheetNum.Text = SheetNums.SheetNumOfBE("ZF", strtoday);
            }
            else
            {
                txtSheetNum.Text = "ZF" + strtoday + "001";
            }
        }

        protected void ddlClientBind()
        {
            DataTable dt = ClientInfo.getClientList();
            ddlClient.DataSource = dt;
            ddlClient.DataTextField = "ClientName";
            ddlClient.DataValueField = "ClientId";
            DataRow row = dt.NewRow();
            row["ClientName"] = "请选择客户名称";
            dt.Rows.InsertAt(row, 0);
            ddlClient.DataBind();

        }

        protected void ddlEmDataBind()
        {
            DataTable dt = EmployeeInfo.GetEmployeeList();
            ddlEmployee.DataSource = dt;
            ddlEmployee.DataTextField = "EmployeeName";
            ddlEmployee.DataValueField = "EmployeeId";
            DataRow row = dt.NewRow();
            row["EmployeeName"] = "请选择陪同人员";
            dt.Rows.InsertAt(row, 0);
            ddlEmployee.DataBind();

        }

        protected void  gvRelateDataBind()
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

            EmployeeInfo em = (EmployeeInfo)Session["Employee"];
            DateTime dt = DateTime.Now;
            txtApplyDate.Text = dt.ToString("yyyy-MM-dd");
            lblApplyPeople.Text = em.EmployeeName.ToString();
            DepartInfo depart = new DepartInfo(Convert.ToInt32(em.DepartId));
            lblDepart.Text = depart.DepartName.ToString();
            PositionInfo position = new PositionInfo(Convert.ToInt32(em.PositionId));

            string strRoleName = Session["RoleName"].ToString();
            

            lblPeopleNum.Text = "0人";
        }

        protected bool IsPageValid()
        {
            string strRoleName = Session["RoleName"].ToString();
            if (gvBEmployee.Rows.Count ==0)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('请添加陪同人员！');</script>");
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
                    EmployeeInfo em = (EmployeeInfo)Session["Employee"];
                     int emid = Convert.ToInt32(Session["EmployeeId"]);

                    MainBusinessExpInfo main = new MainBusinessExpInfo();
                    main.Save();

                    int bExpId = Convert.ToInt32(Request["BusinessExpId"].ToString());
                    BusinessExpInfo be = new BusinessExpInfo(bExpId);
                    be.MainBusinessExpId = main.MainBusinessExpId;

                    DateTime date = DateTime.Now;
                    string strtoday = DateTime.Now.ToString("yyyyMMdd").Substring(2);
                    be.Today = strtoday;
                    be.SheetNum = txtSheetNum.Text.ToString();

                    be.ApplyDate=Convert.ToDateTime(txtApplyDate.Text.ToString()) ;
                    be.ApplyPeople=lblApplyPeople.Text.ToString();
                    be.Depart=lblDepart.Text.ToString();
                    be.Memo=txtMemo.Text.ToString();
                    be.ReasonExp=txtReason.Text.ToString();

                    be.Item1 = txtItem1.Text.ToString();
                    be.Item2 = txtItem2.Text.ToString();
                    be.Item3 = txtItem3.Text.ToString();
                    be.Item4 = txtItem4.Text.ToString();
                    be.Money1 = txtMoney1.Text.ToString();
                    be.Money2 = txtMoney2.Text.ToString();
                    be.Money3 = txtMoney3.Text.ToString();
                    be.Money4 = txtMoney4.Text.ToString();
                    be.MoneySum = txtMoneySum.Text.ToString();

                    string strRoleName = Session["RoleName"].ToString();
                    if (strRoleName == "部门经理")
                    {
                        be.SendEmployeeName = em.EmployeeName;
                        be.SendEmployeeId = emid;
                        be.PreIsApply = 1;
                        be.PreIsOver = 1;
                        be.SignName = 1;
                    }
                    else
                    {
                        be.PreEmployeeId = em.EmployeeId;
                        be.PreEmployeeName = em.EmployeeName;
                        be.PreIsApply = 0;
                        be.PreIsOver = 0;
                        be.SignName = 0;
                    }
                    be.IsApply = 0;
                    be.IsApprove = 0;
                    be.IsApply1 = 0;
                    be.IsApply2 = 0;
                    be.IsOver1 = 0;
                    be.IsOver2 = 0;

                    //GridView嵌套判断
                    be.IsMain = 1;
                    be.IsMain1 = 1;
                    be.IsMain2 = 1;
                    be.IsMain3 = 1;
                    be.IsNewCreate = 0;
                    be.Save();

                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('添加成功！');</script>");
                    //ClearForms();
                    ViewState["Isbtn"] = "1";
                    txtSheetNum.Text = SheetNums.SheetNumOfBE("ZDFY", strtoday);
                }
                catch (Exception Ex)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Save", "alert('添加失败：" + Ex.Message + "');", true);
                }
            }
        }

       

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            if (ViewState["Isbtn"].ToString() == "0")
            {
                int bExpId = Convert.ToInt32(Request["BusinessExpId"].ToString());
                BusinessExpInfo.DelRBExp(bExpId);
                BusinessExpInfo.DelEBExp(bExpId);
                BusinessExpInfo.DelBExp(bExpId);

            }
            Response.Redirect(ViewState["BackUrl"].ToString());
            
        }

        protected void btnAddRelate_Click(object sender, EventArgs e)
        {
            if (ddlClient.SelectedValue.ToString() == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('请选择客户！');</script>");
            }
            if (ddlRelate.SelectedValue.ToString() == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('请选择联系人！');</script>");
            }
            else
            {
                int bExpId = Convert.ToInt32(Request["BusinessExpId"].ToString());
                int RelateId = Convert.ToInt32(ddlRelate.SelectedValue);
                RelateBExpInfo rb = new RelateBExpInfo();
                rb.RelateId = RelateId;
                rb.BusinessExpId = bExpId;
                rb.Save();
                gvRelateDataBind();
                ddlClient.SelectedIndex = -1;
                ddlRelate.SelectedIndex = -1;
                NumOfPeople();
            }
           
        }

        protected void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (ddlEmployee.SelectedValue.ToString() == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('请选择陪同人员！');</script>");
            }
            else
            {
                int bExpId = Convert.ToInt32(Request["BusinessExpId"].ToString());
                int Emid = Convert.ToInt32(ddlEmployee.SelectedValue);
                EmployeeBExpInfo eb = new EmployeeBExpInfo();
                eb.EmployeeId = Emid;
                eb.BusinessExpId = bExpId;
                eb.Save();
                gvEmployeeDataBind();
                ddlEmployee.SelectedValue = "";
                NumOfPeople();
            }

        }

        protected void ddlClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlClient.SelectedValue.ToString() != "")
            {
                int clientid = Convert.ToInt32(ddlClient.SelectedValue);
                DataTable dt = ClientInfo.getRelateOfClient(clientid);
                ddlRelate.DataSource = dt;
                ddlRelate.DataTextField = "RelateName";
                ddlRelate.DataValueField = "RelateId";
                DataRow row = dt.NewRow();
                row["RelateName"] = "请选择联系人";
                dt.Rows.InsertAt(row, 0);
                ddlRelate.DataBind();
            }
            else
            {
                ddlRelate.SelectedIndex = 0;
            }
        }

        protected void gvBRelate_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(gvBRelate.DataKeys[e.RowIndex].Value);
            BusinessExpInfo.DelRB(id);
            gvRelateDataBind();
            NumOfPeople();

        }

        protected void gvBEmployee_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(gvBEmployee.DataKeys[e.RowIndex].Value);
            BusinessExpInfo.DelEB(id);
            gvEmployeeDataBind();
            NumOfPeople();
        }

        protected void NumOfPeople()
        {
            int num = gvBEmployee.Rows.Count + gvBRelate.Rows.Count;
            lblPeopleNum.Text = num + "人";
        }

        protected void btnSum_Click(object sender, EventArgs e)
        {
            float m1, m2, m3, m4, sum;
            if (txtMoney1.Text != "")
            {
                m1 = float.Parse(txtMoney1.Text.ToString());
            }
            else
            {
                m1 = 0;
            }
            if (txtMoney2.Text != "")
            {
                m2 = float.Parse(txtMoney2.Text.ToString());
            }
            else
            {
                m2 = 0;
            }
            if (txtMoney3.Text != "")
            {
                m3 = float.Parse(txtMoney3.Text.ToString());
            }
            else
            {
                m3 = 0;
            }
            if (txtMoney4.Text != "")
            {
                m4 = float.Parse(txtMoney4.Text.ToString());
            }
            else
            {
                m4 = 0;
            }

            sum = m1 + m2 + m3 + m4;
            txtMoneySum.Text = sum.ToString();
        }

      
       
    }
}
