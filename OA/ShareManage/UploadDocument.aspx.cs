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

namespace OA.ShareManage
{
    public partial class UploadDocument : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlBind();
                ddl2Bind();
            }
        }

        protected void ddlBind()
        {
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

        protected void ddl2Bind()
        {
            DataTable dt = CanYou.OA.BLL.FileInfo.FilePermission();
            ddlFilePermit.DataTextField = "FilePermissionName";
            ddlFilePermit.DataValueField = "FilePermissionId";
            ddlFilePermit.DataSource = dt;
            DataRow row = dt.NewRow();
            row["FilePermissionName"] = "请选择文件权限";
            dt.Rows.InsertAt(row, 0);
            ddlFilePermit.DataBind();
        }
        protected bool IsPageValid()
        {
            if (!UpFile.HasFile)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('请选择要上传的文档！');</script>");
                return false;
            }
            if (ddlFileType.SelectedValue.ToString() == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('请选择文档类型！');</script>");
                return false;
            }
            if (ddlFilePermit.SelectedValue.ToString() == "")
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('请选择文档权限！');</script>");
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
                    if (!CanYou.OA.BLL.FileInfo.IsDocumentSame(name))
                    {
                        CanYou.OA.BLL.FileInfo file = new CanYou.OA.BLL.FileInfo();
                        file.FileName = name;
                        file.FileTypeId = Convert.ToInt32(ddlFileType.SelectedValue.ToString());
                        file.SendEmployeeId = emid;
                        file.Memo = txtMemo.Text.ToString();
                        file.SendTime = sendtime;
                        file.IsCommon = 1;
                        file.FilePermissionId=Convert.ToInt32(ddlFilePermit.SelectedValue);
                        file.Save();

                        if (ddlFilePermit.SelectedItem.Text.ToString() == "公用")
                        {
                                DataTable EmTb = MessageInfo.getEmployeeId(emid);
                                string[] strto = new String[EmTb.Rows.Count];
                                for (int i = 0; i < EmTb.Rows.Count; i++)
                                {
                                    MessageInfo.Msgs1(Convert.ToInt32(EmTb.Rows[i]["EmployeeId"]), file.FileId, "~/ShareManage/DownloadDocument.aspx", "您有共享文档:"+name, em.EmployeeName,"daiyue",name);
                                    EmployeeInfo ems = new EmployeeInfo(Convert.ToInt32(EmTb.Rows[i]["EmployeeId"]));
                                    strto[i] = ems.Qq.ToString();
                                }
                                //MessageInfo.SendMailS(strto, "OA新的消息", "您有共享文档:"+name);

                            DataTable dt=MessageInfo.getEmployeeId1();
                            for (int j = 0; j < dt.Rows.Count; j++)
                            {
                                FileEmployeeInfo fileem = new FileEmployeeInfo();
                                fileem.FileId = file.FileId;
                                fileem.EmployeeId = Convert.ToInt32(dt.Rows[j]["EmployeeId"]);
                                fileem.IsMsg = 0;
                                fileem.IsDelete = 0;
                                fileem.Save();
                            }
                        }
                        else
                        {
                            DataTable EmTb = MessageInfo.getEmployeeIdOf(emid, ddlFilePermit.SelectedItem.Text.ToString());
                            string[] strto = new String[EmTb.Rows.Count];
                            for (int i = 0; i < EmTb.Rows.Count; i++)
                            {
                                MessageInfo.Msgs1(Convert.ToInt32(EmTb.Rows[i]["EmployeeId"]), file.FileId, "~/ShareManage/DownloadDocument.aspx", "您有共享文档:" + name, em.EmployeeName, "daiyue", name);
                                EmployeeInfo ems = new EmployeeInfo(Convert.ToInt32(EmTb.Rows[i]["EmployeeId"]));
                                strto[i] = ems.Qq.ToString();
                            }
                            MessageInfo.SendMailS(strto, "OA新的消息", "您有共享文档:"+name);

                            DataTable dt = MessageInfo.getEmployeeIdOf1(ddlFilePermit.SelectedItem.Text.ToString());
                            {
                                for (int j = 0; j < dt.Rows.Count; j++)
                                {
                                    FileEmployeeInfo fileem = new FileEmployeeInfo();
                                    fileem.FileId = file.FileId;
                                    fileem.EmployeeId = Convert.ToInt32(dt.Rows[j]["EmployeeId"]);
                                    fileem.IsMsg = 0;
                                    fileem.IsDelete = 0;
                                    fileem.Save();
                                }
                               
                            }
                        }
                        //文件上传地址根目录，这里通过IIS架设本地主机为FTP服务器  
                        //string FileSaveUri = @"ftp://192.168.11.70/www/Files/Documents/";
                        ////FTP用户名密码，就是本机的用户名密码  
                        //string ftpUser = "test1";
                        //string ftpPassWord = "123";
                        //SendFiles(FileSaveUri, ftpUser, ftpPassWord);
                        this.UpFile.PostedFile.SaveAs(Server.MapPath("~/Files/Documents/" + UpFile.FileName));
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('上传成功！');</script>");
                    }
                    else
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('该文档名已存在，请重命名！');</script>");
                    }

                   
                }
                catch (Exception ex)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Save", "alert('上传失败：" + ex.Message + "');", true);
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
            Response.Redirect("Upload.aspx");
        }
    }
}
