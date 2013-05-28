// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： OverTimeInfo.cs
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
    /// ???OverTimeInfoController?ObjectDataSource???
    /// </summary>
 	public partial class OverTimeInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(OverTimeInfo pOverTimeInfo)
		{
			OverTimeInfo overTimeInfo = new OverTimeInfo(pOverTimeInfo.OverTimeId);
            overTimeInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public OverTimeInfo GetOverTimeInfoById(int OverTimeId)
        {
			   
			OverTimeInfo overTimeInfo  = null;//
            try
            {
                 overTimeInfo = new OverTimeInfo(OverTimeId);

            }
            catch (AppException)
            {
                return null;
            }

            return  overTimeInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<OverTimeInfo> GetOverTimeInfoList()
        {
            return OverTimeInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<OverTimeInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return OverTimeInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveOverTimeInfo(OverTimeInfo overTimeInfo)
        {
            overTimeInfo.Save();
			return overTimeInfo . OverTimeId;
        }
		
	}
}
