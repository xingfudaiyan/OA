// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： SiteInfo.cs
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
    /// ???SiteInfoController?ObjectDataSource???
    /// </summary>
 	public partial class SiteInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(SiteInfo pSiteInfo)
		{
			SiteInfo siteInfo = new SiteInfo(pSiteInfo.SiteId);
            siteInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public SiteInfo GetSiteInfoById(int SiteId)
        {
			   
			SiteInfo siteInfo  = null;//
            try
            {
                 siteInfo = new SiteInfo(SiteId);

            }
            catch (AppException)
            {
                return null;
            }

            return  siteInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<SiteInfo> GetSiteInfoList()
        {
            return SiteInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<SiteInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return SiteInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveSiteInfo(SiteInfo siteInfo)
        {
            siteInfo.Save();
			return siteInfo . SiteId;
        }
		
	}
}
