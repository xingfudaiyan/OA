// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： OfferFileInfo.cs
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
    /// ???OfferFileInfoController?ObjectDataSource???
    /// </summary>
 	public partial class OfferFileInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(OfferFileInfo pOfferFileInfo)
		{
			OfferFileInfo offerFileInfo = new OfferFileInfo(pOfferFileInfo.OfferFileId);
            offerFileInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public OfferFileInfo GetOfferFileInfoById(int OfferFileId)
        {
			   
			OfferFileInfo offerFileInfo  = null;//
            try
            {
                 offerFileInfo = new OfferFileInfo(OfferFileId);

            }
            catch (AppException)
            {
                return null;
            }

            return  offerFileInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<OfferFileInfo> GetOfferFileInfoList()
        {
            return OfferFileInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<OfferFileInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return OfferFileInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveOfferFileInfo(OfferFileInfo offerFileInfo)
        {
            offerFileInfo.Save();
			return offerFileInfo . OfferFileId;
        }
		
	}
}
