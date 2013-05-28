// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： MarketScoreInfo.cs
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
    /// ???MarketScoreInfoController?ObjectDataSource???
    /// </summary>
 	public partial class MarketScoreInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(MarketScoreInfo pMarketScoreInfo)
		{
			MarketScoreInfo marketScoreInfo = new MarketScoreInfo(pMarketScoreInfo.MarketScoreId);
            marketScoreInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public MarketScoreInfo GetMarketScoreInfoById(int MarketScoreId)
        {
			   
			MarketScoreInfo marketScoreInfo  = null;//
            try
            {
                 marketScoreInfo = new MarketScoreInfo(MarketScoreId);

            }
            catch (AppException)
            {
                return null;
            }

            return  marketScoreInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<MarketScoreInfo> GetMarketScoreInfoList()
        {
            return MarketScoreInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<MarketScoreInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return MarketScoreInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveMarketScoreInfo(MarketScoreInfo marketScoreInfo)
        {
            marketScoreInfo.Save();
			return marketScoreInfo . MarketScoreId;
        }
		
	}
}
