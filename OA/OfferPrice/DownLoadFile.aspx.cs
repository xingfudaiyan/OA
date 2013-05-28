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
using System.Net;
using System.IO;

namespace OA.OfferPrice
{
    public partial class DownLoadFile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int fileid = Int32.Parse(Request.QueryString["fileid"].ToString());//获取文件的ID
            OfferFileInfo file = new OfferFileInfo(fileid);
            string fileName = file.OfferFileName.ToString();
            
            //获取桌面路径
            // string DeskPath = Convert.ToString(System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));
            //string DeskPath = Server.MapPath("~\\Files\\File");
            DownLoads(fileName);
        }

        protected void DownLoads(string fileName)
        {
            //FtpWebRequest reqFTP;
            try
            {
                string filePath = Server.MapPath("../Files/OfferPrice/") + fileName;
                if (File.Exists(filePath))
                {
                    //以字符流的形式下载文件
                    FileStream fs = new FileStream(filePath, FileMode.Open);
                    byte[] bytes = new byte[(int)fs.Length];
                    fs.Read(bytes, 0, bytes.Length);
                    fs.Close();
                    Response.ContentType = "application/octet-stream";
                    //通知浏览器下载文件而不是打开
                    Response.AddHeader("Content-Disposition", "attachment; filename=" + HttpUtility.UrlEncode(fileName, System.Text.Encoding.UTF8));
                    Response.BinaryWrite(bytes);
                    Response.Flush();
                    Response.End();
                }


                //while (readCount > 0)
                //{
                //    outputStream.Write(buffer, 0, readCount);
                //    readCount = ftpStream.Read(buffer, 0, bufferSize);


                //}

                //ftpStream.Close();
                //outputStream.Close();
                //response.Close();

                //FileStream fs = new FileStream(filePath + "\\" + fileName, FileMode.Open);
                //byte[] btFile = new byte[fs.Length];
                //fs.Read(btFile, 0, Convert.ToInt32(fs.Length));//将文件读到数组中
                //fs.Close();
                //string strFileName = "attachment;filename=" + HttpUtility.UrlEncode(fileName, System.Text.Encoding.UTF8);
                //this.Response.AddHeader("Content-disposition", strFileName);
                //this.Response.ContentType = "application/octet-staream";
                //this.Response.BinaryWrite(btFile);
                //string str = response.ResponseUri.ToString();
                //System.IO.File.Delete(filePath + "\\" + fileName);
                //this.Response.End();


            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Save", "alert('下载失败：" + ex.Message + "');", true);
            }

        }
    }
}
