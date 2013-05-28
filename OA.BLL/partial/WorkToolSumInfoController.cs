// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： WorkToolSumInfo.cs
// createDate：2012-10-30

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
    /// ???WorkToolSumInfoController?ObjectDataSource???
    /// </summary>
 	public partial class WorkToolSumInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(WorkToolSumInfo pWorkToolSumInfo)
		{
			WorkToolSumInfo workToolSumInfo = new WorkToolSumInfo(pWorkToolSumInfo.WorkToolSumId);
            workToolSumInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public WorkToolSumInfo GetWorkToolSumInfoById(int WorkToolSumId)
        {
			   
			WorkToolSumInfo workToolSumInfo  = null;//
            try
            {
                 workToolSumInfo = new WorkToolSumInfo(WorkToolSumId);

            }
            catch (AppException)
            {
                return null;
            }

            return  workToolSumInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<WorkToolSumInfo> GetWorkToolSumInfoList()
        {
            return WorkToolSumInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<WorkToolSumInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return WorkToolSumInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveWorkToolSumInfo(WorkToolSumInfo workToolSumInfo)
        {
            workToolSumInfo.Save();
			return workToolSumInfo . WorkToolSumId;
        }
		
	}
}
