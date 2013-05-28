// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： ContractInfo.cs
// createDate：2012-9-21

// ===================================================================
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using CanYouLib.Exceptions;
using CanYou.OA.DAL;
using SubSonic;
using CanYouLib;


namespace CanYou.OA.BLL
{
   /// <summary>
    /// ???ContractInfoController?ObjectDataSource???
    /// </summary>
 	public partial class ContractInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(ContractInfo pContractInfo)
		{
			ContractInfo contractInfo = new ContractInfo(pContractInfo.ContractId);
            contractInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public ContractInfo GetContractInfoById(int ContractId)
        {
			   
			ContractInfo contractInfo  = null;//
            try
            {
                 contractInfo = new ContractInfo(ContractId);

            }
            catch (AppException)
            {
                return null;
            }

            return  contractInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<ContractInfo> GetContractInfoList()
        {
            return ContractInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<ContractInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return ContractInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveContractInfo(ContractInfo contractInfo)
        {
            contractInfo.Save();
			return contractInfo . ContractId;
        }
		
	}
}
