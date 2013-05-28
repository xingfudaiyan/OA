// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： StampTypeInfo.cs
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
    /// ???StampTypeInfoController?ObjectDataSource???
    /// </summary>
 	public partial class StampTypeInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(StampTypeInfo pStampTypeInfo)
		{
			StampTypeInfo stampTypeInfo = new StampTypeInfo(pStampTypeInfo.StampTypeId);
            stampTypeInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public StampTypeInfo GetStampTypeInfoById(int StampTypeId)
        {
			   
			StampTypeInfo stampTypeInfo  = null;//
            try
            {
                 stampTypeInfo = new StampTypeInfo(StampTypeId);

            }
            catch (AppException)
            {
                return null;
            }

            return  stampTypeInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<StampTypeInfo> GetStampTypeInfoList()
        {
            return StampTypeInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<StampTypeInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return StampTypeInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveStampTypeInfo(StampTypeInfo stampTypeInfo)
        {
            stampTypeInfo.Save();
			return stampTypeInfo . StampTypeId;
        }
		
	}
}
