using System;
using System.Collections.Generic;
using System.Text;

using CanYou.OA.DAL;
using SubSonic;
using System.Data;

namespace CanYou.OA.BLL
{
    public partial class OutRegistInfo
    {
         public static DataTable getOutRegistApply(String EmName)
         {
             return SPs.OutRegistApply_Sp(EmName).GetDataSet().Tables[0];
             
         }

        public static void DelOutRegist(int id)
        {
            OutRegist.Delete(id);
        }

        public static DataTable getOutRegistApprove(String DepartName)
        {
            return SPs.OutRegistApprove_Sp(DepartName).GetDataSet().Tables[0];
        }

        public static DataTable getAllOut()
        {
            Query q = Vw_OutRegistAll.Query();
            return q.ExecuteDataSet().Tables[0];
        }
    }
}
