// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： OutRegistInfo.cs
// createDate：2012-9-12

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
    /// ???OutRegistInfoController?ObjectDataSource???
    /// </summary>
 	public partial class OutRegistInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(OutRegistInfo pOutRegistInfo)
		{
			OutRegistInfo outRegistInfo = new OutRegistInfo(pOutRegistInfo.OutRegistId);
            outRegistInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public OutRegistInfo GetOutRegistInfoById(int OutRegistId)
        {
			   
			OutRegistInfo outRegistInfo  = null;//
            try
            {
                 outRegistInfo = new OutRegistInfo(OutRegistId);

            }
            catch (AppException)
            {
                return null;
            }

            return  outRegistInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<OutRegistInfo> GetOutRegistInfoList()
        {
            return OutRegistInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<OutRegistInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return OutRegistInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveOutRegistInfo(OutRegistInfo outRegistInfo)
        {
            outRegistInfo.Save();
			return outRegistInfo . OutRegistId;
        }
		
	}
}
