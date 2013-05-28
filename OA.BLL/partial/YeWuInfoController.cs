// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： YeWuInfo.cs
// createDate：2012-9-11

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
    /// ???YeWuInfoController?ObjectDataSource???
    /// </summary>
 	public partial class YeWuInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(YeWuInfo pYeWuInfo)
		{
			YeWuInfo yeWuInfo = new YeWuInfo(pYeWuInfo.YeWuId);
            yeWuInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public YeWuInfo GetYeWuInfoById(int YeWuId)
        {
			   
			YeWuInfo yeWuInfo  = null;//
            try
            {
                 yeWuInfo = new YeWuInfo(YeWuId);

            }
            catch (AppException)
            {
                return null;
            }

            return  yeWuInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<YeWuInfo> GetYeWuInfoList()
        {
            return YeWuInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<YeWuInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return YeWuInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveYeWuInfo(YeWuInfo yeWuInfo)
        {
            yeWuInfo.Save();
			return yeWuInfo . YeWuId;
        }
		
	}
}
