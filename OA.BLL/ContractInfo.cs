using System;
using System.Collections.Generic;
using System.Text;
using CanYou.OA.DAL;
using System.Data;
using SubSonic;

namespace CanYou.OA.BLL
{
    public partial class ContractInfo
    {
        //获取所有合同列表
        public static DataTable getContractList()
        {
            Query q = Contract.Query();
            return q.ExecuteDataSet().Tables[0];
        }
        //删除合同
        public static void DelContract(int contractid)
        {
            Contract.Delete(contractid);
        }
        //查询合同类型
        public static DataTable getContractTypeList()
        {
            Query q = ContractType.Query();
            return q.ExecuteDataSet().Tables[0];
        }
       
    }
}
