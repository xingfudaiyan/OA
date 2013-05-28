// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： OfferPriceInfo.cs
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
    /// ???OfferPriceInfoController?ObjectDataSource???
    /// </summary>
 	public partial class OfferPriceInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(OfferPriceInfo pOfferPriceInfo)
		{
			OfferPriceInfo offerPriceInfo = new OfferPriceInfo(pOfferPriceInfo.OfferPriceId);
            offerPriceInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public OfferPriceInfo GetOfferPriceInfoById(int OfferPriceId)
        {
			   
			OfferPriceInfo offerPriceInfo  = null;//
            try
            {
                 offerPriceInfo = new OfferPriceInfo(OfferPriceId);

            }
            catch (AppException)
            {
                return null;
            }

            return  offerPriceInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<OfferPriceInfo> GetOfferPriceInfoList()
        {
            return OfferPriceInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<OfferPriceInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return OfferPriceInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveOfferPriceInfo(OfferPriceInfo offerPriceInfo)
        {
            offerPriceInfo.Save();
			return offerPriceInfo . OfferPriceId;
        }
		
	}
}
