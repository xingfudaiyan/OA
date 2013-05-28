using System;
using System.Collections.Generic;
using System.Text;
using CanYou.OA.DAL;
using SubSonic;
using System.Data;


namespace CanYou.OA.BLL
{
   public partial class HolidayApplyInfo
    {
       public static DataTable getHolidayApply(string emName)
       {
           return SPs.GetHolidayApply_Sp(emName).GetDataSet().Tables[0];
       }

       public static void DelHoliday(int hid)
       {
           HolidayApply.Delete(hid);
       }

       public static DataTable DepartGv(string name)
       {
           return SPs.DepartGvOfHoliday_Sp(name).GetDataSet().Tables[0];
       }

       public static DataTable ManagerGv()
       {
           return Vw_HolidayApplyOfManager.Query().ExecuteDataSet().Tables[0];
       }


       public static DataTable getHolidayTypeList()
       {
           Query q = HolidayType.Query();
           return q.ExecuteDataSet().Tables[0];
       }

       public static DataTable getHolidayList()
       {
           return Vw_HolidayList.Query().ExecuteDataSet().Tables[0];
       }

    }
}
