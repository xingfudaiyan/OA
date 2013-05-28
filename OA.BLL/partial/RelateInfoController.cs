// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： RelateInfo.cs
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
    /// ???RelateInfoController?ObjectDataSource???
    /// </summary>
 	public partial class RelateInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(RelateInfo pRelateInfo)
		{
			RelateInfo relateInfo = new RelateInfo(pRelateInfo.RelateId);
            relateInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public RelateInfo GetRelateInfoById(int RelateId)
        {
			   
			RelateInfo relateInfo  = null;//
            try
            {
                 relateInfo = new RelateInfo(RelateId);

            }
            catch (AppException)
            {
                return null;
            }

            return  relateInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<RelateInfo> GetRelateInfoList()
        {
            return RelateInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<RelateInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return RelateInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveRelateInfo(RelateInfo relateInfo)
        {
            relateInfo.Save();
			return relateInfo . RelateId;
        }
		
	}
}
