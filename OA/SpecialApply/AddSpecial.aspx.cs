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


namespace OA.SpecialApply
{
    public partial class AddSpecial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlProjectBind();
                ddlStepBind();
                PageInit();
                SheetNum();
                ViewState["BackUrl"] = Request.UrlReferrer.ToString();
            }
        }

        protected void SheetNum()
        {
            DateTime date = DateTime.Now;
            string strtoday = DateTime.Now.ToString("yyyyMMdd").Substring(2);
            if (SheetNums.IsSheetNumOfSE(strtoday))
            {

                txtSheetNum.Text = SheetNums.SheetNumOfSE("TF", strtoday);
            }
            else
            {
                txtSheetNum.Text = "TF" + strtoday + "001";
            }
        }

        protected void ddlProjectBind()
        {
            DataTable dt = MainProjectCreateInfo.getProjectList();
            ddlProject.DataSource = dt;
            ddlProject.DataTextField = "ProjectName";
            ddlProject.DataValueField = "MainProjectCreateId";
            DataRow row = dt.NewRow();
            row["ProjectName"] = "请选择项目名称";
            dt.Rows.InsertAt(row, 0);
            ddlProject.DataBind();
        }

        protected void ddlStepBind()
        {
            DataTable dt = SpecialExpInfo.getProjectStepList();
            ddlProjectStep.DataSource = dt;
            ddlProjectStep.DataTextField = "ProjectStepName";
            ddlProjectStep.DataValueField = "ProjectStepId";
            DataRow row = dt.NewRow();
            row["ProjectStepName"] = "请选择项目阶段";
            dt.Rows.InsertAt(row, 0);
            ddlProjectStep.DataBind();
        }

        protected void PageInit()
        {
            EmployeeInfo em = (EmployeeInfo)Session["Employee"];
            lblApplyPeople.Text = em.EmployeeName;
            DateTime date = DateTime.Now;
            txtApplyDate.Text = date.ToString("yyyy-MM-dd");

            string strRoleName = Session["RoleName"].ToString();
             PositionInfo position = new PositionInfo(Convert.ToInt32(em.PositionId));
             if (strRoleName == "员工" || position.PositionName == "综合主管")
             {
                 btnSign.Enabled = false;
                 btnSign.Visible = false;
             }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(ViewState["BackUrl"].ToString());
        }

      

        protected bool IsPageValid()
        {
            string strRoleName = Session["RoleName"].ToString();
            if (strRoleName == "部门经理" && imgMarket.Visible == false)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('请签名！');</script>");
                return false;
            }
            if(ddlProject.SelectedValue.ToString()=="")
            {
                 Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('请选择项目名称！');</script>");
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


                    int emid = Convert.ToInt32(Session["EmployeeId"]);
                    EmployeeInfo em = (EmployeeInfo)Session["Employee"];
                    MainSpecialExpInfo main = new MainSpecialExpInfo();
                    main.Save();
                    SpecialExpInfo sp = new SpecialExpInfo();
                    sp.MainSpecialExpId = main.MainSpecialExpId;


                        DateTime date = DateTime.Now;
                        string strtoday = DateTime.Now.ToString("yyyyMMdd").Substring(2);
                        sp.Today = strtoday;

                        sp.SheetNum = txtSheetNum.Text.ToString();

                        sp.ApplyDate = Convert.ToDateTime(txtApplyDate.Text.ToString());
                        sp.ApplyPeople = lblApplyPeople.Text.ToString();
                        sp.ApplyReason = txtReason.Text.ToString();
                        sp.ApplyMoney = txtApplyMoney.Text.ToString();

                        if (ddlProject.SelectedValue != "")
                        {
                            sp.MainProjectCreateId = Convert.ToInt32(ddlProject.SelectedValue);
                        }
                        if (ddlProjectStep.SelectedValue.ToString() != "")
                        {
                            sp.ProjectStepId = Convert.ToInt32(ddlProjectStep.SelectedValue);
                        }


                        string strRoleName = Session["RoleName"].ToString();
                        if (strRoleName == "部门经理")
                        {
                            sp.SendEmployeeName = em.EmployeeName;
                            sp.SendEmployeeId = emid;
                            sp.PreIsApply = 1;
                            sp.PreIsOver = 1;
                            sp.SignName = 1;
                        }
                        else
                        {
                            sp.PreEmployeeId = em.EmployeeId;
                            sp.PreEmployeeName = em.EmployeeName;
                            sp.PreIsApply = 0;
                            sp.PreIsOver = 0;
                            sp.SignName = 0;
                        }
                        sp.IsApply = 0;
                        sp.IsApprove = 0;
                        sp.IsApply1 = 0;
                        sp.IsApply2 = 0;
                        sp.IsOver1 = 0;
                        sp.IsOver2 = 0;

                        //GridView嵌套判断
                        sp.IsMain = 1;
                        sp.IsMain1 = 1;
                        sp.IsMain2 = 1;
                        sp.IsMain3 = 1;
                        sp.IsNewCreate = 0;
                        sp.Save();

                        Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('添加成功！');</script>");
                        txtSheetNum.Text = SheetNums.SheetNumOfSE("TSFY", strtoday);
                    }
                   
             
                catch (Exception Ex)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Save", "alert('添加失败：" + Ex.Message + "');", true);
                }
            }


        }

        protected void ddlProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlProject.SelectedItem.Text == "请选择项目名称")
            {
                lblMoneyNum.Text = "";
            }
            else
            {
                MainProjectCreateInfo project = new MainProjectCreateInfo(Convert.ToInt32(ddlProject.SelectedValue));
                lblMoneyNum.Text = project.PreMoney.ToString();
            }
        }



        protected void btnSign_Click(object sender, EventArgs e)
        {
            imgMarket.Visible = true;
            btnSign.Enabled = false;
        }
    }
}
