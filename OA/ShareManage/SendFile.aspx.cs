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
using System.IO;
using System.Net;

namespace OA.Document
{
    public partial class SendFile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ddlBind();
            }
        }

        protected void ddlBind()
        {
            //绑定ddlDepart
            DataTable dtDepart = EmployeeInfo.getDepartList();
            ddlDepart.DataTextField = "DepartName";
            ddlDepart.DataValueField = "DepartId";
            ddlDepart.DataSource = dtDepart;
            DataRow drDepart = dtDepart.NewRow();
            drDepart["DepartName"] = "请选择部门";
            dtDepart.Rows.InsertAt(drDepart, 0);
            ddlDepart.DataBind();
            //绑定ddlFileType
            DataTable dt = EmployeeInfo.getFileType();
            ddlFileType.DataTextField = "FileTypeName";
            ddlFileType.DataValueField = "FileTypeId";
            ddlFileType.DataSource = dt;
            DataRow row = dt.NewRow();
            row["FileTypeName"] = "请选择文件类型";
            dt.Rows.InsertAt(row, 0);
            ddlFileType.DataBind();
        }

        protected bool IsPageValid()
        {
            if (lbxRecv.Rows == 0)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('接收人不为空！');</script>");
                return false;
            }
            if (!UpFile.HasFile)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('请选择要发送的文件！');</script>");
                return false;
            }
            if (ddlFileType.SelectedValue.ToString()=="")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('请选择文件类型！');</script>");
                return false;
            }
           
            else
            {
                return true;
            }
        }

        protected void btnSendFile_Click(object sender, EventArgs e)
        {
            if (IsPageValid())
            {
                try
                {
                    int emid = Convert.ToInt32(Session["EmployeeId"]);
                    EmployeeInfo em = (EmployeeInfo)Session["Employee"];
                    //获取文件名
                    string name = this.UpFile.FileName;
                    DateTime sendtime = DateTime.Now;
                    if (!CanYou.OA.BLL.FileInfo.IsFileSame(name))
                    {
                        string[] strto = new String[lbxRecv.Items.Count];
                        for (int i = 0; i < lbxRecv.Items.Count; i++)
                        {
                            CanYou.OA.BLL.FileInfo file = new CanYou.OA.BLL.FileInfo();
                            file.RecvEmployeeId = Convert.ToInt32(lbxRecv.Items[i].Value);
                            file.FileName = name;
                            file.FileTypeId = Convert.ToInt32(ddlFileType.SelectedValue.ToString());
                            file.SendEmployeeId = emid;
                            file.Memo = txtMemo.Text.ToString();
                            file.SendTime = sendtime;
                            file.IsCommon = 0;
                            file.IsDelete = 0;
                            file.IsMsg = 0;
                            file.Save();

                            MessageInfo Msg = new MessageInfo();
                            Msg.Msg = "您收到新文件:"+name;
                            Msg.Url = "~/ShareManage/RecvFile.aspx";
                            Msg.RecvEmployeeId = Convert.ToInt32(lbxRecv.Items[i].Value);
                            Msg.Memo = file.FileId.ToString();
                            Msg.EmployeeName = em.EmployeeName;
                            Msg.MsgType = "daiyue";
                            Msg.MsgTime = DateTime.Now.ToString("yyyy-MM-dd");
                            Msg.MsgTitle = name;
                            Msg.Save();

                            EmployeeInfo ems = new EmployeeInfo(Convert.ToInt32(lbxRecv.Items[0].Value));
                            strto[i] = ems.Qq.ToString();
                        }


                        //文件上传地址根目录，这里通过IIS架设本地主机为FTP服务器  
                        //string FileSaveUri = @"ftp://192.168.11.70/www/Files/File/";
                        ////FTP用户名密码，就是本机的用户名密码  
                        //string ftpUser = "test1";
                        //string ftpPassWord = "123";
                        //SendFiles(FileSaveUri, ftpUser, ftpPassWord);
                        this.UpFile.PostedFile.SaveAs(Server.MapPath("~/Files/File/" + UpFile.FileName));
                        MessageInfo.SendMailS(strto, "OA新消息", "您收到新文件");
                      
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('发送成功！');</script>");
                    }
                    else
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('该文件名已存在，请重命名！');</script>");
                    }
                }
                catch (Exception ex)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Save", "alert('发送失败：" + ex.Message + "');", true);
                }
            }
        }

       
        //protected void SendFiles(string FileSaveUri, string ftpUser, string ftpPassWord)
        //{
            
        //    Stream requestStream = null;
        //    Stream fileStream = null;
        //    FtpWebResponse uploadResponse = null;//创建FtpWebResponse实例uploadResponse  
        //    if (UpFile.HasFile)
        //    {
        //        //获取文件长度  
        //        int FileLength = UpFile.PostedFile.ContentLength;
        //        //限制上传文件最大不能超过500M  
        //        if (FileLength < 512 * 1024 * 1024)
        //        {
        //            try
        //            {
        //                //格式化为URI  
                       
        //                Uri uri = new Uri(FileSaveUri + Path.GetFileName(UpFile.PostedFile.FileName));
        //                FtpWebRequest uploadRequest = (FtpWebRequest)WebRequest.Create(uri);//创建FtpWebRequest实例uploadRequest  
        //                uploadRequest.Method = WebRequestMethods.Ftp.UploadFile;//将FtpWebRequest属性设置为上传文件  
        //                uploadRequest.Credentials = new NetworkCredential(ftpUser, ftpPassWord);//认证FTP用户名密码  
        //                requestStream = uploadRequest.GetRequestStream();//获得用于上传FTP的流  
        //                byte[] buffer = new byte[FileLength];
        //                fileStream = UpFile.PostedFile.InputStream;//截取FileUpload获取的文件流，作为上传FTP的流  
        //                fileStream.Read(buffer, 0, FileLength);
        //                requestStream.Write(buffer, 0, FileLength);//将buffer写入流  
        //                requestStream.Close();
        //                uploadResponse = (FtpWebResponse)uploadRequest.GetResponse();//返回FTP服务器响应，上传完成  

        //            }
        //            catch (Exception ex)
        //            {
        //                ClientScript.RegisterStartupScript(this.GetType(), "Save", "alert('上传失败：" + ex.Message + "');", true);
        //                //    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('无法上传！');</script>");
        //            }
        //            finally
        //            {
        //                if (uploadResponse != null)
        //                    uploadResponse.Close();
        //                if (fileStream != null)
        //                    fileStream.Close();
        //                if (requestStream != null)
        //                    requestStream.Close();
        //            }
        //        }
        //        else
        //        {
        //            Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('上传文件过大！');</script>");
        //        }
        //    }
        //    else
        //    {
        //        Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('未选择文件或文件内容为空！');</script>");
        //    }
        //}

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Send.aspx");
        }

        protected void ddlDepart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlDepart.SelectedValue != "")
            {
                int DepartId = Convert.ToInt32(ddlDepart.SelectedValue.ToString());
                DataTable dt = EmployeeInfo.getEmployeeOfDepart(DepartId);
                ddlRecvEmployee.DataTextField = "EmployeeName";
                ddlRecvEmployee.DataValueField = "EmployeeId";
                DataRow row = dt.NewRow();
                row["EmployeeName"] = "请选择接收人";
                dt.Rows.InsertAt(row, 0);
                ddlRecvEmployee.DataSource = dt;
                ddlRecvEmployee.DataBind();
               
            }
           
        }

       

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbxRecv.SelectedItem==null)
            {

                lblMsg1.Text = "请选中后再删除~";
            }
            else
            {
                lbxRecv.Items.Remove(new ListItem(lbxRecv.SelectedItem.Text, lbxRecv.SelectedValue));
                
            }
           
        }

        protected void ddlRecvEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isExit = false;
            for (int i = 0; i < lbxRecv.Items.Count; i++)
            {
                if (lbxRecv.Items[i].Text == ddlRecvEmployee.SelectedItem.Text)
                {
                    isExit = true;
                }
            }
            if (isExit == false && ddlRecvEmployee.SelectedItem.Text != "请选择接收人")
            {
                lbxRecv.Items.Add(new ListItem(ddlRecvEmployee.SelectedItem.Text, ddlRecvEmployee.SelectedValue));
            }
        }

        protected void lbxRecv_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMsg1.Text = "";
        }

    }
}
