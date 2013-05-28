// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： TechMaScoreInfo.cs
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
    /// ???TechMaScoreInfoController?ObjectDataSource???
    /// </summary>
 	public partial class TechMaScoreInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(TechMaScoreInfo pTechMaScoreInfo)
		{
			TechMaScoreInfo techMaScoreInfo = new TechMaScoreInfo(pTechMaScoreInfo.TechMaScoreId);
            techMaScoreInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public TechMaScoreInfo GetTechMaScoreInfoById(int TechMaScoreId)
        {
			   
			TechMaScoreInfo techMaScoreInfo  = null;//
            try
            {
                 techMaScoreInfo = new TechMaScoreInfo(TechMaScoreId);

            }
            catch (AppException)
            {
                return null;
            }

            return  techMaScoreInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<TechMaScoreInfo> GetTechMaScoreInfoList()
        {
            return TechMaScoreInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<TechMaScoreInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return TechMaScoreInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveTechMaScoreInfo(TechMaScoreInfo techMaScoreInfo)
        {
            techMaScoreInfo.Save();
			return techMaScoreInfo . TechMaScoreId;
        }
		
	}
}
