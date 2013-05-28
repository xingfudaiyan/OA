// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： ContractApplyInfo.cs
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
    /// ???ContractApplyInfoController?ObjectDataSource???
    /// </summary>
 	public partial class ContractApplyInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(ContractApplyInfo pContractApplyInfo)
		{
			ContractApplyInfo contractApplyInfo = new ContractApplyInfo(pContractApplyInfo.ContractApplyId);
            contractApplyInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public ContractApplyInfo GetContractApplyInfoById(int ContractApplyId)
        {
			   
			ContractApplyInfo contractApplyInfo  = null;//
            try
            {
                 contractApplyInfo = new ContractApplyInfo(ContractApplyId);

            }
            catch (AppException)
            {
                return null;
            }

            return  contractApplyInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<ContractApplyInfo> GetContractApplyInfoList()
        {
            return ContractApplyInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<ContractApplyInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return ContractApplyInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveContractApplyInfo(ContractApplyInfo contractApplyInfo)
        {
            contractApplyInfo.Save();
			return contractApplyInfo . ContractApplyId;
        }
		
	}
}
