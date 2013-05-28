// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： PoliticsInfo.cs
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
    /// ???PoliticsInfoController?ObjectDataSource???
    /// </summary>
 	public partial class PoliticsInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(PoliticsInfo pPoliticsInfo)
		{
			PoliticsInfo politicsInfo = new PoliticsInfo(pPoliticsInfo.PoliticsId);
            politicsInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public PoliticsInfo GetPoliticsInfoById(int PoliticsId)
        {
			   
			PoliticsInfo politicsInfo  = null;//
            try
            {
                 politicsInfo = new PoliticsInfo(PoliticsId);

            }
            catch (AppException)
            {
                return null;
            }

            return  politicsInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<PoliticsInfo> GetPoliticsInfoList()
        {
            return PoliticsInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<PoliticsInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return PoliticsInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SavePoliticsInfo(PoliticsInfo politicsInfo)
        {
            politicsInfo.Save();
			return politicsInfo . PoliticsId;
        }
		
	}
}
