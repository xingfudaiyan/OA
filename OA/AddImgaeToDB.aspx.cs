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
using System.Data.SqlClient;
using System.Drawing;

namespace OA
{
    public partial class AddImgaeToDB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string imgPath = Server.MapPath("~/Files/Help/hechun.jpg");
            SavePhotoToDB(imgPath, "34");
        }

        public static void SavePhotoToDB(string imgPath, string id)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["strconn"].ToString());
            string strSql = "UPDATE SpecialExp_tb SET SignName = @BLOBData WHERE SpecialExpId = " + id;
            SqlCommand cmd = new SqlCommand();
            conn.Open();

            FileStream fsBLOBFile = null;
            Byte[] bytBLOBData = null;

            fsBLOBFile = new FileStream(imgPath, FileMode.Open, FileAccess.Read); //文件流对象 
            bytBLOBData = new Byte[fsBLOBFile.Length]; //二进制数组
            fsBLOBFile.Read(bytBLOBData, 0, bytBLOBData.Length); //从流中读取字符，放到缓冲区中
            fsBLOBFile.Close(); //关闭
            SqlParameter prm = new SqlParameter("@BLOBData", SqlDbType.VarBinary,
            bytBLOBData.Length, ParameterDirection.Input, false, 0, 0,
            null, DataRowVersion.Current, bytBLOBData);

            cmd.Parameters.Add(prm);
            cmd.CommandText = strSql;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
            System.Windows.Forms.MessageBox.Show("OK");
        }

        

        protected void btnShow_Click1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["strconn"].ToString());
            string strSql = "SELECT SignName from SpecialExp_tb where SpecialExpId=" + 34;

            SqlCommand cmd = new SqlCommand(strSql, conn);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            MemoryStream ms = new MemoryStream((byte[])reader["SignName"]);  //创建一个内存   读取数据流，将读取的数据库的图片以二进制的byte[]流存入内存中。

            reader.Close();
            conn.Close();

            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true); //从刚才存储到内存的数据流中创建Image对象。
            
        }




    }
}
