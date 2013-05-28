using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using SubSonic;
using CanYou.OA.DAL;

namespace CanYou.OA.BLL
{
     public partial  class FileInfo
    {
        //获取Recv文件信息表
        public static DataTable getFile(int recvEmployeeid)
        {
            return SPs.RecvFile_Sp(recvEmployeeid).GetDataSet().Tables[0];
        }

         public static DataTable getSendFile(int EmId)
         {
             return SPs.SendFile_Sp(EmId).GetDataSet().Tables[0];
         }

         public static bool IsFileSame(string FileName)
         {
             DataTable dt = SPs.IsFileExit_Sp(FileName).GetDataSet().Tables[0];
             if (dt.Rows.Count > 0)
             {
                 return true;
             }
             else
             {
                 return false;
             }
         }

         public static DataTable getUploadDocument(int EmId)
         {
             return SPs.UploadDocument_Sp(EmId).GetDataSet().Tables[0];
         }

         public static bool IsDocumentSame(string FileName)
         {
             DataTable dt = SPs.IsDocumentExit_Sp(FileName).GetDataSet().Tables[0];
             if (dt.Rows.Count > 0)
             {
                 return true;
             }
             else
             {
                 return false;
             }
         }

         public static DataTable FilePermission()
         {
             Query q = CanYou.OA.DAL.FilePermission.Query();
             return q.ExecuteDataSet().Tables[0];
         }

         public static DataTable getDocument(string PermissionName,int EmId)
         {
             return SPs.Document_Sp(PermissionName,EmId).GetDataSet().Tables[0];
         }

         public static void UpdateDocument(int FileId, int EmId)
         {
             Query q = FileEmployee.Query();
             q.AddWhere(FileEmployee.Columns.FileId, FileId);
             q.AddWhere(FileEmployee.Columns.EmployeeId, EmId);
             q.QueryType = QueryType.Update;
             q.AddUpdateSetting(FileEmployee.Columns.IsMsg, "1");
             q.Execute();
         }

         public static void DelFileEmployee(int FileId)
         {
             Query q = FileEmployee.Query();
             q.AddWhere(FileEmployee.Columns.FileId, FileId);
             q.QueryType = QueryType.Delete;
             q.Execute();
         }
        

         public static void DelDocumentOf(int FileId, int EmId)
         {
             SPs.DelDocumentOf_Sp(FileId, EmId).Execute();
         }

         public static DataTable UserFileEmployee(string PermissionName)
         {
             return SPs.UserFileEmployee_Sp(PermissionName).GetDataSet().Tables[0];
         }
    }
}
