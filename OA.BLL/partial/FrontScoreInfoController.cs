// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： FrontScoreInfo.cs
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
    /// ???FrontScoreInfoController?ObjectDataSource???
    /// </summary>
 	public partial class FrontScoreInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(FrontScoreInfo pFrontScoreInfo)
		{
			FrontScoreInfo frontScoreInfo = new FrontScoreInfo(pFrontScoreInfo.FrontScoreId);
            frontScoreInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public FrontScoreInfo GetFrontScoreInfoById(int FrontScoreId)
        {
			   
			FrontScoreInfo frontScoreInfo  = null;//
            try
            {
                 frontScoreInfo = new FrontScoreInfo(FrontScoreId);

            }
            catch (AppException)
            {
                return null;
            }

            return  frontScoreInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<FrontScoreInfo> GetFrontScoreInfoList()
        {
            return FrontScoreInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<FrontScoreInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return FrontScoreInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveFrontScoreInfo(FrontScoreInfo frontScoreInfo)
        {
            frontScoreInfo.Save();
			return frontScoreInfo . FrontScoreId;
        }
		
	}
}
