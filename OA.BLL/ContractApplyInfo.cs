using System;
using System.Collections.Generic;
using System.Text;
using CanYou.OA.DAL;
using SubSonic;
using System.Data;

namespace CanYou.OA.BLL
{
    public partial class ContractApplyInfo
    {
       

        //申请记录
        public static DataTable getContractApplyOfEm(String ApplyName)
        {
            return SPs.ContractApplyOfEm(ApplyName).GetDataSet().Tables[0];
        }
        //部门审批记录
        public static DataTable getContractApplyOfDepart(String departName)
        {
            return SPs.ContractOfDepart(departName).GetDataSet().Tables[0];
        }
        //总经理审批记录
        public static DataTable getContractApplyOfManager()
        {
            Query q = Vw_ContractApplyManager.Query();
            return q.ExecuteDataSet().Tables[0];
        }
        //删除记录
        public static void DelContractApply(int cid)
        {
            ContractApply.Delete(cid);
        }

        //是否存在相同文件名
        public static bool IsContractFileSame(string FileName)
        {
            DataTable dt = SPs.ConctractFileSame_Sp(FileName).GetDataSet().Tables[0];
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
