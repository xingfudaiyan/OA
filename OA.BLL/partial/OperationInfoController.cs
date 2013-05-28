// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： OperationInfo.cs
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
    /// ???OperationInfoController?ObjectDataSource???
    /// </summary>
 	public partial class OperationInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(OperationInfo pOperationInfo)
		{
			OperationInfo operationInfo = new OperationInfo(pOperationInfo.OperationId);
            operationInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public OperationInfo GetOperationInfoById(int OperationId)
        {
			   
			OperationInfo operationInfo  = null;//
            try
            {
                 operationInfo = new OperationInfo(OperationId);

            }
            catch (AppException)
            {
                return null;
            }

            return  operationInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<OperationInfo> GetOperationInfoList()
        {
            return OperationInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<OperationInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return OperationInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveOperationInfo(OperationInfo operationInfo)
        {
            operationInfo.Save();
			return operationInfo . OperationId;
        }
		
	}
}
