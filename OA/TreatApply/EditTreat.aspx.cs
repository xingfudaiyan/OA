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
    public partial class EditTreat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BusinessBind();
                ddlClientBind();
                ddlEmDataBind();
                gvRelateDataBind();
                gvEmployeeDataBind();
                NumOfPeople();
                ViewState["BackUrl"] = Request.UrlReferrer.ToString();
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
            row["EmployeeName"] = "请选择负责人";
            dt.Rows.InsertAt(row, 0);
            ddlEmployee.DataBind();

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

        protected void BusinessBind()
        {
            int id = Convert.ToInt32(Request["BusinessExpId"].ToString());
            BusinessExpInfo be = new BusinessExpInfo(id);

            txtSheetNum.Text = be.SheetNum.ToString();
            txtApplyDate.Text = be.ApplyDate.ToString();
            lblApplyPeople.Text = be.ApplyPeople.ToString();
            lblDepart.Text = be.Depart.ToString();
            txtMemo.Text = be.Memo.ToString();
            txtReason.Text = be.ReasonExp.ToString();
            txtItem1.Text = be.Item1.ToString();
            txtItem2.Text = be.Item2.ToString();
            txtItem3.Text = be.Item3.ToString();
            txtItem4.Text = be.Item4.ToString();
            txtMoney1.Text = be.Money1.ToString();
            txtMoney2.Text = be.Money2.ToString();
            txtMoney3.Text = be.Money3.ToString();
            txtMoney4.Text = be.Money4.ToString();
            txtMoneySum.Text = be.MoneySum.ToString();
            EmployeeInfo em = (EmployeeInfo)Session["Employee"];
            PositionInfo position = new PositionInfo(Convert.ToInt32(em.PositionId));

            string strRoleName = Session["RoleName"].ToString();
            if (strRoleName == "员工" || position.PositionName == "综合主管")
            {
                btnSign.Enabled = false;
                btnSign.Visible = false;
            }

        }

        protected bool IsPageValid()
        {
            string strRoleName = Session["RoleName"].ToString();
            if (gvBEmployee.Rows.Count == 0)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('请添加陪同人员！');</script>");
                return false;
            }
            if (imgMarket.Visible == false&&strRoleName=="部门经理")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('请签名！');</script>");
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
                   
                    int id = Convert.ToInt32(Request["BusinessExpId"].ToString());
                    BusinessExpInfo be = new BusinessExpInfo(id);
                    if (be.IsNewCreate == 1)
                    {
                        be.IsMain = 0;
                        be.IsMain1 = 0;
                        be.IsMain2 = 0;
                        be.IsMain3 = 0;
                        BusinessExpInfo benew = new BusinessExpInfo();
                        benew.IsNewCreate = 0;
                        benew.IsMain = 1;
                        benew.IsMain1 = 1;
                        benew.IsMain2 = 1;
                        benew.IsMain3 = 1;
                        benew.MainBusinessExpId = be.MainBusinessExpId;

                        string strRoleName = Session["RoleName"].ToString();
                        if (strRoleName == "部门经理")
                        {
                            benew.SendEmployeeId = be.SendEmployeeId;
                            benew.SendEmployeeName = be.SendEmployeeName;
                            benew.PreIsApply = 1;
                            benew.PreIsOver = 1;
                            benew.SignName = 1;
                        }
                        else
                        {
                            benew.PreEmployeeId = be.PreEmployeeId;
                            benew.PreEmployeeName = be.PreEmployeeName;
                            benew.PreIsApply = 0;
                            benew.PreIsOver = 0;
                            benew.SignName = 0;
                        }

                        benew.IsApply = 0;
                        benew.IsApprove = 0;
                        benew.IsApply1 = 0;
                        benew.IsApply2 = 0;
                        benew.IsOver1 = 0;
                        benew.IsOver2 = 0;
                        benew.SignName = 0;

                        DateTime date = DateTime.Now;
                        string strtoday = DateTime.Now.ToString("yyyyMMdd").Substring(2);
                        benew.Today = strtoday;
                        benew.SheetNum = txtSheetNum.Text.ToString();

                        benew.ApplyDate = Convert.ToDateTime(txtApplyDate.Text.ToString());
                        benew.ApplyPeople = lblApplyPeople.Text.ToString();
                        benew.Depart = lblDepart.Text.ToString();
                        benew.Memo = txtMemo.Text.ToString();
                        benew.ReasonExp = txtReason.Text.ToString();

                        benew.Item1 = txtItem1.Text.ToString();
                        benew.Item2 = txtItem2.Text.ToString();
                        benew.Item3 = txtItem3.Text.ToString();
                        benew.Item4 = txtItem4.Text.ToString();
                        benew.Money1 = txtMoney1.Text.ToString();
                        benew.Money2 = txtMoney2.Text.ToString();
                        benew.Money3 = txtMoney3.Text.ToString();
                        benew.Money4 = txtMoney4.Text.ToString();
                        benew.MoneySum = txtMoneySum.Text.ToString();
                        benew.Save();
                        be.Save();
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('修正成功！');</script>");
                    }
                    else
                    {
                        
                        be.ApplyDate = Convert.ToDateTime(txtApplyDate.Text.ToString());
                        be.ApplyPeople = lblApplyPeople.Text.ToString();
                        be.Depart = lblDepart.Text.ToString();
                        be.Memo = txtMemo.Text.ToString();
                        be.ReasonExp = txtReason.Text.ToString();
                        be.Item1 = txtItem1.Text.ToString();
                        be.Item2 = txtItem2.Text.ToString();
                        be.Item3 = txtItem3.Text.ToString();
                        be.Item4 = txtItem4.Text.ToString();
                        be.Money1 = txtMoney1.Text.ToString();
                        be.Money2 = txtMoney2.Text.ToString();
                        be.Money3 = txtMoney3.Text.ToString();
                        be.Money4 = txtMoney4.Text.ToString();
                        be.MoneySum = txtMoneySum.Text.ToString();
                        be.Save();
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('编辑成功！');</script>");
                    }  
                }
                catch (Exception Ex)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Save", "alert('添加失败：" + Ex.Message + "');", true);
                }
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
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
                NumOfPeople();
            }

        }

        protected void ddlClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlClient.SelectedItem.Text != "")
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

        protected void btnSign_Click(object sender, EventArgs e)
        {
            imgMarket.Visible = true;
            btnSign.Enabled = false;
        }
    }
}
