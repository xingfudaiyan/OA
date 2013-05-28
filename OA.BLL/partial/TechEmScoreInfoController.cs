// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： TechEmScoreInfo.cs
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
    /// ???TechEmScoreInfoController?ObjectDataSource???
    /// </summary>
 	public partial class TechEmScoreInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(TechEmScoreInfo pTechEmScoreInfo)
		{
			TechEmScoreInfo techEmScoreInfo = new TechEmScoreInfo(pTechEmScoreInfo.TechEmScoreId);
            techEmScoreInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public TechEmScoreInfo GetTechEmScoreInfoById(int TechEmScoreId)
        {
			   
			TechEmScoreInfo techEmScoreInfo  = null;//
            try
            {
                 techEmScoreInfo = new TechEmScoreInfo(TechEmScoreId);

            }
            catch (AppException)
            {
                return null;
            }

            return  techEmScoreInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<TechEmScoreInfo> GetTechEmScoreInfoList()
        {
            return TechEmScoreInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<TechEmScoreInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return TechEmScoreInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveTechEmScoreInfo(TechEmScoreInfo techEmScoreInfo)
        {
            techEmScoreInfo.Save();
			return techEmScoreInfo . TechEmScoreId;
        }
		
	}
}
