// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： RelateBExpInfo.cs
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
    /// ???RelateBExpInfoController?ObjectDataSource???
    /// </summary>
 	public partial class RelateBExpInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(RelateBExpInfo pRelateBExpInfo)
		{
			RelateBExpInfo relateBExpInfo = new RelateBExpInfo(pRelateBExpInfo.RelateBExpId);
            relateBExpInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public RelateBExpInfo GetRelateBExpInfoById(int RelateBExpId)
        {
			   
			RelateBExpInfo relateBExpInfo  = null;//
            try
            {
                 relateBExpInfo = new RelateBExpInfo(RelateBExpId);

            }
            catch (AppException)
            {
                return null;
            }

            return  relateBExpInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<RelateBExpInfo> GetRelateBExpInfoList()
        {
            return RelateBExpInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<RelateBExpInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return RelateBExpInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveRelateBExpInfo(RelateBExpInfo relateBExpInfo)
        {
            relateBExpInfo.Save();
			return relateBExpInfo . RelateBExpId;
        }
		
	}
}
