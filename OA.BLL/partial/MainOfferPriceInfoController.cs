// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： MainOfferPriceInfo.cs
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
    /// ???MainOfferPriceInfoController?ObjectDataSource???
    /// </summary>
 	public partial class MainOfferPriceInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(MainOfferPriceInfo pMainOfferPriceInfo)
		{
			MainOfferPriceInfo mainOfferPriceInfo = new MainOfferPriceInfo(pMainOfferPriceInfo.MainOfferPriceId);
            mainOfferPriceInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public MainOfferPriceInfo GetMainOfferPriceInfoById(int MainOfferPriceId)
        {
			   
			MainOfferPriceInfo mainOfferPriceInfo  = null;//
            try
            {
                 mainOfferPriceInfo = new MainOfferPriceInfo(MainOfferPriceId);

            }
            catch (AppException)
            {
                return null;
            }

            return  mainOfferPriceInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<MainOfferPriceInfo> GetMainOfferPriceInfoList()
        {
            return MainOfferPriceInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<MainOfferPriceInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return MainOfferPriceInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveMainOfferPriceInfo(MainOfferPriceInfo mainOfferPriceInfo)
        {
            mainOfferPriceInfo.Save();
			return mainOfferPriceInfo . MainOfferPriceId;
        }
		
	}
}
