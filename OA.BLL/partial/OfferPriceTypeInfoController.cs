// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： OfferPriceTypeInfo.cs
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
    /// ???OfferPriceTypeInfoController?ObjectDataSource???
    /// </summary>
 	public partial class OfferPriceTypeInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(OfferPriceTypeInfo pOfferPriceTypeInfo)
		{
			OfferPriceTypeInfo offerPriceTypeInfo = new OfferPriceTypeInfo(pOfferPriceTypeInfo.OfferPriceTypeId);
            offerPriceTypeInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public OfferPriceTypeInfo GetOfferPriceTypeInfoById(int OfferPriceTypeId)
        {
			   
			OfferPriceTypeInfo offerPriceTypeInfo  = null;//
            try
            {
                 offerPriceTypeInfo = new OfferPriceTypeInfo(OfferPriceTypeId);

            }
            catch (AppException)
            {
                return null;
            }

            return  offerPriceTypeInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<OfferPriceTypeInfo> GetOfferPriceTypeInfoList()
        {
            return OfferPriceTypeInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<OfferPriceTypeInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return OfferPriceTypeInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveOfferPriceTypeInfo(OfferPriceTypeInfo offerPriceTypeInfo)
        {
            offerPriceTypeInfo.Save();
			return offerPriceTypeInfo . OfferPriceTypeId;
        }
		
	}
}
