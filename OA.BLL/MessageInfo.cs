using System;
using System.Collections.Generic;
using System.Text;
using CanYou.OA.DAL;
using SubSonic;
using System.Data;
using System.Net.Mail;
using System.Net;
using System.Web.Mail;
namespace CanYou.OA.BLL
{
    public partial class MessageInfo
    {
        public static DataTable getMessageOfEm(int EmId)
        {
            return SPs.MessageOfEm_Sp(EmId).GetDataSet().Tables[0];
        }

        public static DataTable getMsgOfEmAndType(int EmId, string strType)
        {
            return SPs.MsgOfEmAndType_Sp(EmId, strType).GetDataSet().Tables[0];
        }

        public static void DelMessageOfMemo(string  strId)
        {
            Query q = Message.Query();
            q.AddWhere(Message.Columns.Memo, strId);
            q.QueryType = QueryType.Delete;
            q.Execute();
        }

        public static void DelMsgOfBoth(string strId, int EmId)
        {
            Query q = Message.Query();
            q.AddWhere(Message.Columns.Memo, strId);
            q.AddWhere(Message.Columns.RecvEmployeeId, EmId);
            q.QueryType = QueryType.Delete;
            q.Execute();
        }


        public static bool IsMessageOfFile(string strFileId)
        {
            Query q = Message.Query();
            q.AddWhere(Message.Columns.Memo, strFileId);
            q.QueryType = QueryType.Select;
            DataTable dt = q.ExecuteDataSet().Tables[0];
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Msgs(int EmId, int ApplyId, string Url, string Msgs, string EmName)
        {
            MessageInfo msgs = new MessageInfo();
            //msgs.Msg = Msgs;
            //msgs.Url = Url;
            //msgs.RecvEmployeeId = EmId;
            //msgs.Memo = ApplyId.ToString();
            //msgs.employeeName = EmName;
            //msgs.Save();
        }

        public static void Msgs1(int EmId, int ApplyId, string Url, string Msgs, string EmName, string strTypeName, string strTitle)
        {
            //MessageInfo msgs = new MessageInfo();
            //msgs.Msg = Msgs;
            //msgs.Url = Url;
            //msgs.RecvEmployeeId = EmId;
            //msgs.Memo = ApplyId.ToString();
            //msgs.employeeName = EmName;
            //msgs.MsgType = strTypeName;
            //msgs.MsgTime = DateTime.Now.ToString("yyyy-MM-dd");
            //msgs.MsgTitle = strTitle;
            //msgs.Save();
        }

        public static DataTable MsgGv()
        {
            Query q = Vw_MsgGv.Query();
            return q.ExecuteDataSet().Tables[0];
        }

        public static DataTable getEmployeeId(int EmId)
        {
            return SPs.EmployeeAll_Sp(EmId).GetDataSet().Tables[0];
        }

        public static DataTable getEmployeeIdOf(int Emid, string DepartName)
        {
            return SPs.EmployeePermission_Sp(Emid, DepartName).GetDataSet().Tables[0];
        }


        public static DataTable getEmployeeId1()
        {

            Query q = Employee.Query();
            q.QueryType = QueryType.Select;
            return q.ExecuteDataSet().Tables[0];
        }

        public static DataTable getEmployeeIdOf1(string DepartName)
        {
            return SPs.EmployeePermission1_Sp(DepartName).GetDataSet().Tables[0];
        }

        public static void SendMail(string strto, string subject, string msg)
        {
            ////邮件发送人地址
            //System.Net.Mail.MailAddress from = new System.Net.Mail.MailAddress("itliubingju@163.com");
            ////如test@163.com,初步测试，用test@sina.com不行，用163的邮件服务器，就必须用163邮箱的用户名
            //System.Net.Mail.MailAddress to = new System.Net.Mail.MailAddress(strto);//如test@tom.com
            //System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage(from,to);
           
            //mail.Subject = subject;
            //mail.Body = msg;
            ////以下设置服务器
            //try
            //{
            //    System.Net.Mail.SmtpClient mySmth = new System.Net.Mail.SmtpClient();
            //    //以下为增加附件
            //    mySmth.Send(mail);
            //    mail.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
        }

        public static void SendMailS(string[] strto,string subject,string msg)
        {
           ////邮件发送人地址
           //    System.Net.Mail.MailAddress from = new System.Net.Mail.MailAddress("itliubingju@163.com");
           //    System.Net.Mail.MailAddress to = new System.Net.Mail.MailAddress(strto[0]);//如test@tom.com
           //    System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage(from,to);

           //     //收件人地址
           //    if (strto.Length > 1)
           //    {
           //        for (int i = 1; i < strto.Length; i++)
           //        {
           //            mail.To.Add(strto[i]);

           //        }
           //    }
               
           //     mail.Subject = subject;
           //     mail.Body = msg;
           //     //以下设置服务器
           //     try
           //     {
           //         System.Net.Mail.SmtpClient mySmth = new System.Net.Mail.SmtpClient();
           //         //以下为增加附件
           //         mySmth.Send(mail);
           //         mail.Dispose();
           //     }
           //     catch (Exception ex)
           //     {
           //         throw ex;
           //     }
        }
  
    }
}
