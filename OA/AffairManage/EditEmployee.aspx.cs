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
    public partial class EditEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlBind();
                ddlBind1();
                EmployeeBind();
            }
            
        }

        //级别、档次绑定
        protected void ddlBind1()
        {
            DataTable dt1 = EmployeeInfo.getEmLevel();
            ddlLevel.DataTextField = "EmLevelName";
            ddlLevel.DataValueField = "EmLevelId";
            ddlLevel.DataSource = dt1;
            DataRow dr1 = dt1.NewRow();
            dr1["EmLevelName"] = "请选择级别";
            dt1.Rows.InsertAt(dr1, 0);
            ddlLevel.DataBind();

            DataTable dt2 = EmployeeInfo.getEmDang();
            ddlDang.DataTextField = "EmDangName";
            ddlDang.DataValueField = "EmDangId";
            ddlDang.DataSource = dt2;
            DataRow dr2 = dt2.NewRow();
            dr2["EmDangName"] = "请选择档次";
            dt2.Rows.InsertAt(dr2, 0);
            ddlDang.DataBind();

        }

        //绑定ddl控件
        protected void ddlBind()
        {
            //绑定ddlEducation
            DataTable dt1 = EmployeeInfo.getEducationList();
            ddlEducation.DataTextField = "EducationName";
            ddlEducation.DataValueField = "EducationId";
            ddlEducation.DataSource = dt1;
            DataRow dr1 = dt1.NewRow();
            dr1["EducationName"] = "请选择学历";
            dt1.Rows.InsertAt(dr1, 0);
            ddlEducation.DataBind();
            //绑定ddlLanguage
            DataTable dt2 = EmployeeInfo.getLanguageList();
            ddlLanguage.DataTextField = "LanguageName";
            ddlLanguage.DataValueField = "LanguageId";
            ddlLanguage.DataSource = dt2;
            DataRow dr2 = dt2.NewRow();
            dr2["LanguageName"] = "请选择英语等级";
            dt2.Rows.InsertAt(dr2, 0);
            ddlLanguage.DataBind();
            //绑定ddlPolitics
            DataTable dt3 = EmployeeInfo.getPoliticsList();
            ddlPolitics.DataTextField = "PoliticsName";
            ddlPolitics.DataValueField = "PoliticsId";
            ddlPolitics.DataSource = dt3;
            DataRow dr3 = dt3.NewRow();
            dr3["PoliticsName"] = "请选择政治面貌";
            dt3.Rows.InsertAt(dr3, 0);
            ddlPolitics.DataBind();
            //绑定ddlDepart
            DataTable dt4 = EmployeeInfo.getDepartList();
            ddlDepart.DataTextField = "DepartName";
            ddlDepart.DataValueField = "DepartId";
            ddlDepart.DataSource = dt4;
            DataRow dr4 = dt4.NewRow();
            dr4["DepartName"] = "请选择部门";
            dt4.Rows.InsertAt(dr4, 0);
            ddlDepart.DataBind();
            //绑定ddlPosition
            DataTable dt5 = EmployeeInfo.getPositionList();
            ddlPosition.DataTextField = "PositionName";
            ddlPosition.DataValueField = "PositionId";
            ddlPosition.DataSource = dt5;
            DataRow dr5 = dt5.NewRow();
            dr5["PositionName"] = "请选择职位";
            dt5.Rows.InsertAt(dr5, 0);
            ddlPosition.DataBind();

        }

        private void EmployeeBind()
        {
            int Employeeid = Convert.ToInt32(Request.QueryString["Employeeid"].ToString());
            DataTable dt = EmployeeInfo.getEmployeeList(Employeeid);

            txtEmployeeName.Text = dt.Rows[0]["EmployeeName"].ToString();
            txtAddress.Text = dt.Rows[0]["Address"].ToString();
            txtBirthday.Text = dt.Rows[0]["Birthday"].ToString();
            txtCertificate.Text = dt.Rows[0]["Certificate"].ToString();  
            txtIdentyNum.Text = dt.Rows[0]["IdentyNum"].ToString();
            txtJobTime.Text = dt.Rows[0]["JobTime"].ToString();
            txtJoinTime.Text =dt.Rows[0]["JoinTime"].ToString();  
            txtMajor.Text = dt.Rows[0]["Major"].ToString(); 
            txtNativePlace.Text = dt.Rows[0]["NativePlace"].ToString();
            txtSchool.Text = dt.Rows[0]["School"].ToString();
            txtQq.Text = dt.Rows[0]["Qq"].ToString();
            ddlPolitics.SelectedValue = dt.Rows[0]["PoliticsId"].ToString();
            ddlPosition.SelectedValue = dt.Rows[0]["PositionId"].ToString();
            ddlDepart.SelectedValue = dt.Rows[0]["DepartId"].ToString();
            ddlEducation.SelectedValue = dt.Rows[0]["EducationId"].ToString();
            ddlLanguage.SelectedValue = dt.Rows[0]["LanguageId"].ToString();
            ddlLevel.SelectedValue = dt.Rows[0]["EmLevelId"].ToString();
            ddlDang.SelectedValue = dt.Rows[0]["EmDangId"].ToString();

            rblSex.SelectedValue=dt.Rows[0]["Sex"].ToString();
            rbtnMarrage.SelectedValue=dt.Rows[0]["Marrage"].ToString();
            rblState.SelectedValue = dt.Rows[0]["State"].ToString();
            int iState = Convert.ToInt32(dt.Rows[0]["State"].ToString());
            if (iState == 1)
            {
                txtLeaveDate.Text = dt.Rows[0]["OffJobTime"].ToString();
                txtLeaveDate.Enabled = true;
                txtLeaveDate.Visible = true;
            }

           Image1.ImageUrl = dt.Rows[0]["Image"].ToString();
           EmployeeInfo em=new EmployeeInfo(Employeeid);
           ContactInfo contact = new ContactInfo(Convert.ToInt32(em.ContactId));
           txtMobile.Text = contact.Mobile.ToString();
           txtHomephone.Text = contact.Homephone.ToString();
           txtOfficephone.Text = contact.Officephone.ToString();
           txtEmail.Text = contact.Email.ToString();
           txtPhoneExt.Text = contact.PhoneExt.ToString();
           

        }

        protected bool IsPageValid()
        {
            if (rblSex.SelectedValue.ToString() == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('性别必选！');</script>");
                return false;
            }
            if (rblState.SelectedValue.ToString() == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('在职状态必选！');</script>");
                return false;
            }
            if (ddlDepart.SelectedValue.ToString() == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('所在部门必选！');</script>");
                return false;
            }
            if (ddlEducation.SelectedValue.ToString() == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('学历必选！');</script>");
                return false;
            }
            if (ddlLanguage.SelectedValue.ToString() == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('外用必选！');</script>");
                return false;
            }
            if (ddlPolitics.SelectedValue.ToString() == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('政治面貌必选！');</script>");
                return false;
            }
            if (ddlPosition.SelectedValue.ToString() == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('职位必选！');</script>");
                return false;
            }
            if (ddlLevel.SelectedValue.ToString() == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('级别必选！');</script>");
                return false;
            }
            if (ddlDang.SelectedValue.ToString() == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('档次必选！');</script>");
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
                int Employeeid = Convert.ToInt32(Request.QueryString["Employeeid"].ToString());
                try
                {
                    string strAddress = txtAddress.Text.Trim();
                    string strCertificate = txtCertificate.Text.Trim();
                    string strEmployeeName = txtEmployeeName.Text.Trim();
                    string strIdentyNum = txtIdentyNum.Text.Trim();
                    string strMajor = txtMajor.Text.Trim();         
                    string strNativePlace = txtNativePlace.Text.Trim();
                    string strSchool = txtSchool.Text.Trim();
                    DateTime dtBirthday = DateTime.Parse(txtBirthday.Text.Trim());
                    DateTime dtJobTime = DateTime.Parse(txtJobTime.Text.Trim());
                    DateTime dtJoinTime = DateTime.Parse(txtJoinTime.Text.Trim());

                    EmployeeInfo Em = new EmployeeInfo(Employeeid);
                    if (ddlDepart.SelectedValue != "")
                    {
                        Em.DepartId  = Convert.ToInt32(ddlDepart.SelectedValue.ToString());
                    }
                    if (ddlEducation.SelectedValue != "")
                    {
                         Em.EducationId  = Convert.ToInt32(ddlEducation.SelectedValue);
                    }
                    if (ddlLanguage.SelectedValue != "")
                    {
                         Em.LanguageId  = Convert.ToInt32(ddlLanguage.SelectedValue.ToString());
                    }
                    if (ddlPolitics.SelectedValue != "")
                    {
                       Em.PoliticsId = Convert.ToInt32(ddlPolitics.SelectedValue.ToString());
                    }
                    if (ddlPosition.SelectedValue != "")
                    {
                        Em.PositionId   = Convert.ToInt32(ddlPosition.SelectedValue.ToString());
                    }

                    if (rblSex.SelectedValue != "")
                    {
                        Em.Sex = Convert.ToInt32(rblSex.SelectedValue.ToString());
                    }
                    if (rbtnMarrage.SelectedValue != "")
                    {
                        Em.Marrage  = Convert.ToInt32(rbtnMarrage.SelectedValue.ToString());
                    }
                    if (rblState.SelectedValue != "")
                    {
                        int iState = Convert.ToInt32(rblState.SelectedValue.ToString());
                        Em.State = iState;
                        if (iState == 1)
                        {

                            Em.OffJobTime = Convert.ToDateTime(txtLeaveDate.Text.ToString());

                        }
                    }

                    Em.EmLevelId = Convert.ToInt32(ddlLevel.SelectedValue.ToString());
                    Em.EmDangId = Convert.ToInt32(ddlDang.SelectedValue.ToString());
                    Em.Address = strAddress;
                    Em.Birthday = dtBirthday;
                    Em.Certificate = strCertificate;
                    Em.EmployeeName = strEmployeeName;
                    Em.IdentyNum = strIdentyNum;
                    Em.JobTime = dtJobTime;
                    Em.JoinTime = dtJoinTime;
                    Em.Major = strMajor;
                    Em.NativePlace = strNativePlace;
                    Em.School = strSchool;
                    Em.Image = this.Image1.ImageUrl;
                    Em.Qq = txtQq.Text.ToString();
                    Em.TurnTime = txtTurntime.Text.ToString();


                    string strEmail = txtEmail.Text.Trim();
                    string strHomephone = txtHomephone.Text.Trim();
                    string strMobile = txtMobile.Text.Trim();
                    string strPhoneExt = txtPhoneExt.Text.Trim();
                    string strOfficephone = txtOfficephone.Text.Trim();
                    ContactInfo contact = new ContactInfo(Convert.ToInt32(Em.ContactId));
                    contact.Email = strEmail;
                    contact.Homephone = strHomephone;
                    contact.Mobile = strMobile;
                    contact.PhoneExt = strPhoneExt;
                    contact.Officephone = strOfficephone;
                    contact.Save();

                    Em.Save();
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('修改成功！');</script>");
                    Response.Write("<script>opener.window.location.href = opener.window.location.href;</script>");  

                }
                catch (Exception Ex)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Save", "alert('保存失败：" + Ex.Message + "');", true);
                }
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Employee.aspx");
        }

        protected void btnImgUp_Click(object sender, EventArgs e)
        {
            string strImgeName = this.UpImage.PostedFile.FileName.ToString();
            string ImgeType = strImgeName.Substring(strImgeName.LastIndexOf("."));
            if (ImgeType == ".jpg" || ImgeType == ".bmp" || ImgeType == ".gif" || ImgeType == ".jpeg" || ImgeType == ".png")
            {
                ViewState["ImgUrl"] = txtEmployeeName.Text + ImgeType;
                this.UpImage.PostedFile.SaveAs(Server.MapPath("~/Photo/") + ViewState["ImgUrl"]);
                this.Image1.ImageUrl = "~/Photo/" + ViewState["ImgUrl"];
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('只能上传jpg、jpeg、png、gif、bmp格式图片!');</script>");
            }
        }

        protected void rblState_SelectedIndexChanged(object sender, EventArgs e)
        {
            int istate = Convert.ToInt32(rblState.SelectedValue.ToString());
            if (istate == 1)
            {
                txtLeaveDate.Enabled = true;
                txtLeaveDate.Visible = true;
            }
            else
            {
                txtLeaveDate.Visible = false;
                txtLeaveDate.Enabled = false;
                txtLeaveDate.Text = "";
            }
        }
    }
}
