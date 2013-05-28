// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： StampInfo.cs
// createDate：2012-9-12

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
    /// ???StampInfoController?ObjectDataSource???
    /// </summary>
 	public partial class StampInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(StampInfo pStampInfo)
		{
			StampInfo stampInfo = new StampInfo(pStampInfo.StampId);
            stampInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public StampInfo GetStampInfoById(int StampId)
        {
			   
			StampInfo stampInfo  = null;//
            try
            {
                 stampInfo = new StampInfo(StampId);

            }
            catch (AppException)
            {
                return null;
            }

            return  stampInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<StampInfo> GetStampInfoList()
        {
            return StampInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<StampInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return StampInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveStampInfo(StampInfo stampInfo)
        {
            stampInfo.Save();
			return stampInfo . StampId;
        }
		
	}
}
