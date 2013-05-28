// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： BasEmScoreInfo.cs
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
    /// ???BasEmScoreInfoController?ObjectDataSource???
    /// </summary>
 	public partial class BasEmScoreInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(BasEmScoreInfo pBasEmScoreInfo)
		{
			BasEmScoreInfo basEmScoreInfo = new BasEmScoreInfo(pBasEmScoreInfo.BasEmScoreId);
            basEmScoreInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public BasEmScoreInfo GetBasEmScoreInfoById(int BasEmScoreId)
        {
			   
			BasEmScoreInfo basEmScoreInfo  = null;//
            try
            {
                 basEmScoreInfo = new BasEmScoreInfo(BasEmScoreId);

            }
            catch (AppException)
            {
                return null;
            }

            return  basEmScoreInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<BasEmScoreInfo> GetBasEmScoreInfoList()
        {
            return BasEmScoreInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<BasEmScoreInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return BasEmScoreInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveBasEmScoreInfo(BasEmScoreInfo basEmScoreInfo)
        {
            basEmScoreInfo.Save();
			return basEmScoreInfo . BasEmScoreId;
        }
		
	}
}
