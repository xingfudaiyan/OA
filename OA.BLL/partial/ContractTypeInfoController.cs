// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： ContractTypeInfo.cs
// createDate：2012-3-29

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
    /// ???ContractTypeInfoController?ObjectDataSource???
    /// </summary>
 	public partial class ContractTypeInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(ContractTypeInfo pContractTypeInfo)
		{
			ContractTypeInfo contractTypeInfo = new ContractTypeInfo(pContractTypeInfo.ContractTypeId);
            contractTypeInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public ContractTypeInfo GetContractTypeInfoById(int ContractTypeId)
        {
			   
			ContractTypeInfo contractTypeInfo  = null;//
            try
            {
                 contractTypeInfo = new ContractTypeInfo(ContractTypeId);

            }
            catch (AppException)
            {
                return null;
            }

            return  contractTypeInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<ContractTypeInfo> GetContractTypeInfoList()
        {
            return ContractTypeInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<ContractTypeInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return ContractTypeInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveContractTypeInfo(ContractTypeInfo contractTypeInfo)
        {
            contractTypeInfo.Save();
			return contractTypeInfo . ContractTypeId;
        }
		
	}
}
