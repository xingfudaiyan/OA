// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： ProcessMasterInfo.cs
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
    /// ???ProcessMasterInfoController?ObjectDataSource???
    /// </summary>
 	public partial class ProcessMasterInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(ProcessMasterInfo pProcessMasterInfo)
		{
			ProcessMasterInfo processMasterInfo = new ProcessMasterInfo(pProcessMasterInfo.ProcessMasterId);
            processMasterInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public ProcessMasterInfo GetProcessMasterInfoById(int ProcessMasterId)
        {
			   
			ProcessMasterInfo processMasterInfo  = null;//
            try
            {
                 processMasterInfo = new ProcessMasterInfo(ProcessMasterId);

            }
            catch (AppException)
            {
                return null;
            }

            return  processMasterInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<ProcessMasterInfo> GetProcessMasterInfoList()
        {
            return ProcessMasterInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<ProcessMasterInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return ProcessMasterInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveProcessMasterInfo(ProcessMasterInfo processMasterInfo)
        {
            processMasterInfo.Save();
			return processMasterInfo . ProcessMasterId;
        }
		
	}
}
