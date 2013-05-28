// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： ContractFileInfo.cs
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
    /// ???ContractFileInfoController?ObjectDataSource???
    /// </summary>
 	public partial class ContractFileInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(ContractFileInfo pContractFileInfo)
		{
			ContractFileInfo contractFileInfo = new ContractFileInfo(pContractFileInfo.ContractFileId);
            contractFileInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public ContractFileInfo GetContractFileInfoById(int ContractFileId)
        {
			   
			ContractFileInfo contractFileInfo  = null;//
            try
            {
                 contractFileInfo = new ContractFileInfo(ContractFileId);

            }
            catch (AppException)
            {
                return null;
            }

            return  contractFileInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<ContractFileInfo> GetContractFileInfoList()
        {
            return ContractFileInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<ContractFileInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return ContractFileInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveContractFileInfo(ContractFileInfo contractFileInfo)
        {
            contractFileInfo.Save();
			return contractFileInfo . ContractFileId;
        }
		
	}
}
