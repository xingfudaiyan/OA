using System;
using System.Collections.Generic;
using System.Text;
using SubSonic;
using CanYou.OA.DAL;
using System.Data;

namespace CanYou.OA.BLL
{
    public partial  class WorkToolSumInfo
    {
        public static void DelWt(int id)
        {
            WorkToolSum.Delete(id);
        }

        public static DataTable getOfficeApply(string emName)
        {
            return SPs.GetOfficeApply_Sp(emName).GetDataSet().Tables[0];
        }

        public static DataTable getDepartApply(string departName)
        {
            return SPs.DepartGvOfOffice_Sp(departName).GetDataSet().Tables[0];
        }

        public static DataTable getManagerList()
        {
            return Vw_ManagerOfOffice.Query().ExecuteDataSet().Tables[0];
        }

        public static DataTable getList()
        {
            return Vw_ListOffice.Query().ExecuteDataSet().Tables[0];
        } 

    }
}
