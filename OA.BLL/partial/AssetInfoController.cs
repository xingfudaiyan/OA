// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： AssetInfo.cs
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
    /// ???AssetInfoController?ObjectDataSource???
    /// </summary>
 	public partial class AssetInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(AssetInfo pAssetInfo)
		{
			AssetInfo assetInfo = new AssetInfo(pAssetInfo.AssetId);
            assetInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public AssetInfo GetAssetInfoById(int AssetId)
        {
			   
			AssetInfo assetInfo  = null;//
            try
            {
                 assetInfo = new AssetInfo(AssetId);

            }
            catch (AppException)
            {
                return null;
            }

            return  assetInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<AssetInfo> GetAssetInfoList()
        {
            return AssetInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<AssetInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return AssetInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveAssetInfo(AssetInfo assetInfo)
        {
            assetInfo.Save();
			return assetInfo . AssetId;
        }
		
	}
}
