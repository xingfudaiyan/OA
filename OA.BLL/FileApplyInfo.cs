using System;
using System.Collections.Generic;
using System.Text;
using CanYou.OA.DAL;
using SubSonic;
using System.Data;

namespace CanYou.OA.BLL
{
   public partial class FileApplyInfo
    {
       public static DataTable getFileApply(String EmName)
       {
           return SPs.GetFileApply_Sp(EmName).GetDataSet().Tables[0];
       }

       public static void FileApplyDel(int fileid)
       {
           FileApply.Delete(fileid);
       }

       public static DataTable DepartGv(String dname)
       {
           return SPs.DepartGv_Sp(dname).GetDataSet().Tables[0];
       }

       public static DataTable ManagerGv()
       {
           Query q = Vw_FileApplyManager.Query();
           return q.ExecuteDataSet().Tables[0];
       }

    }
}
