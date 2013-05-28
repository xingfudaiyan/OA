// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： StampFileTypeInfo.cs
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
    /// ???StampFileTypeInfoController?ObjectDataSource???
    /// </summary>
 	public partial class StampFileTypeInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(StampFileTypeInfo pStampFileTypeInfo)
		{
			StampFileTypeInfo stampFileTypeInfo = new StampFileTypeInfo(pStampFileTypeInfo.StampFileTypeId);
            stampFileTypeInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public StampFileTypeInfo GetStampFileTypeInfoById(int StampFileTypeId)
        {
			   
			StampFileTypeInfo stampFileTypeInfo  = null;//
            try
            {
                 stampFileTypeInfo = new StampFileTypeInfo(StampFileTypeId);

            }
            catch (AppException)
            {
                return null;
            }

            return  stampFileTypeInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<StampFileTypeInfo> GetStampFileTypeInfoList()
        {
            return StampFileTypeInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<StampFileTypeInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return StampFileTypeInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveStampFileTypeInfo(StampFileTypeInfo stampFileTypeInfo)
        {
            stampFileTypeInfo.Save();
			return stampFileTypeInfo . StampFileTypeId;
        }
		
	}
}
