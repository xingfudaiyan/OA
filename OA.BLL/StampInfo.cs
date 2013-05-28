using System;
using System.Collections.Generic;
using System.Text;
using CanYou.OA.DAL;
using SubSonic;
using System.Data;

namespace CanYou.OA.BLL
{
   public partial  class StampInfo
    {
       public static DataTable getStampFileTypeList()
       {
           Query q = StampFileType.Query();
           return q.ExecuteDataSet().Tables[0];
       }

       public static DataTable getStampType()
       {
           Query q = StampType.Query();
           return q.ExecuteDataSet().Tables[0];
       }

       public static void DelStamp(int StampId)
       {
           Stamp.Delete(StampId);
       }

       public static DataTable getStampApplyList(String EmName)
       {
           return SPs.StampApply_Sp(EmName).GetDataSet().Tables[0];
       }

       public static DataTable getStampApproveList(String DepartName)
       {
           return SPs.StampApprove1_Sp(DepartName).GetDataSet().Tables[0];
       }


       public static DataTable StampManagerGv()
       {
           Query q = Vw_StampManager.Query();
           return q.ExecuteDataSet().Tables[0];
       }

       public static DataTable StampList()
       {
           Query q = Vw_StampList.Query();
           return q.ExecuteDataSet().Tables[0];
       }


    }
}
