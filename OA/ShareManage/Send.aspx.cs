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
    public partial class Send : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["SortExpression"] = "SendTime";
                ViewState["SortDir"] = "DESC";
                gvDataBind();
            }
        }

        protected void gvDataBind()
        {
            int emid = Convert.ToInt32(Session["EmployeeId"]);
            //获取接收文件信息表
            DataTable dt = CanYou.OA.BLL.FileInfo.getSendFile(emid);

            DataView view = dt.DefaultView;
            string sort = (string)ViewState["SortExpression"] + " " + (string)ViewState["SortDir"];
            view.Sort = sort;

            if (dt.Rows.Count == 0)
            {
                dt.Rows.Add(dt.NewRow());
                UI.BindCtrl(dt.DefaultView, gvFile, AspNetPager1);
                gvFile.Rows[0].Visible = false;
            }
            else
            {
                UI.BindCtrl(dt.DefaultView, gvFile, AspNetPager1);
            }
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            gvDataBind();
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            Response.Redirect("SendFile.aspx");
        }

        //删除文件
        public void DeleteFile(string fileName)
        {
            try
            {

                //string uri = "ftp://192.168.11.70/www/Files/File/" + fileName;
                ////连接          
                //// 根据uri创建FtpWebRequest对象
                //FtpWebRequest reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(uri));
                //// 指定数据传输类型
                //reqFTP.UseBinary = true;
                //// ftp用户名和密码
                //reqFTP.Credentials = new NetworkCredential("test1", "123");
                //// 默认为true，连接不会被关闭
                //// 在一个命令之后被执行
                //reqFTP.KeepAlive = false;
                //// 指定执行什么命令
                //reqFTP.Method = WebRequestMethods.Ftp.DeleteFile;
                //FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                //response.Close();
                System.IO.File.Delete(Server.MapPath(("~/Files/File/"+ fileName)));

            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Save", "alert('错误信息:" + ex.Message + "');", true);
            }
        }

        protected void gvFile_Sorting(object sender, GridViewSortEventArgs e)
        {
            //首先判断当前的排序表达式（字段），是否为当前当前的表达式。。。
            if (ViewState["SortExpression"].ToString() == e.SortExpression.ToString())
            {
                //判断当前的排序方式是否为倒序（DESC），如果是则将排序方式设为升序（ASC），原因是：因为我们要做双向排序！
                if (ViewState["SortDir"].ToString() == "DESC")
                {
                    ViewState["SortDir"] = "ASC";
                }
                else
                {
                    ViewState["SortDir"] = "DESC";
                }
            }
            else
            {
                ViewState["SortExpression"] = e.SortExpression; //将触发到表达式赋值给ViewState["SortExpression"];
            }
            gvDataBind();
        }

        protected void ckbAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < gvFile.Rows.Count; i++)
            {
                CheckBox ckb = gvFile.Rows[i].FindControl("ckbChoose") as CheckBox;
                if (ckbAll.Checked == true)
                {
                    ckb.Checked = true;
                }
                else
                {
                    ckb.Checked = false;
                }
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int j = 0;
                string[] filearray = new String[11];
                filearray[0] = " ";
                for (int i = 0; i < gvFile.Rows.Count; i++)
                {
                    CheckBox ckb = gvFile.Rows[i].FindControl("ckbChoose") as CheckBox;
                    if (ckb.Checked == true)
                    {
                        int fileid = Convert.ToInt32(gvFile.DataKeys[i].Value);
                        CanYou.OA.BLL.FileInfo file = new CanYou.OA.BLL.FileInfo(fileid);
                        if (filearray[j] != file.FileName)
                        {
                            j = j + 1;
                            filearray[j] = file.FileName;
                           
                        }
                        file.Delete();
                        if (MessageInfo.IsMessageOfFile(file.FileId.ToString()))
                        {
                            //删除消息
                            MessageInfo.DelMessageOfMemo(fileid.ToString());
                        }
                    }
                }
                for (int k = 1; k < j+1; k++)
                {
                    DeleteFile(filearray[k]);
                }
                gvDataBind();
            }
            catch (Exception Ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Save", "alert('错误信息:" + Ex.Message + "');", true);
            }
           
        }
    }
}
