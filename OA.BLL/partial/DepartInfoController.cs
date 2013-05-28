// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： DepartInfo.cs
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
    /// ???DepartInfoController?ObjectDataSource???
    /// </summary>
 	public partial class DepartInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(DepartInfo pDepartInfo)
		{
			DepartInfo departInfo = new DepartInfo(pDepartInfo.DepartId);
            departInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public DepartInfo GetDepartInfoById(int DepartId)
        {
			   
			DepartInfo departInfo  = null;//
            try
            {
                 departInfo = new DepartInfo(DepartId);

            }
            catch (AppException)
            {
                return null;
            }

            return  departInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<DepartInfo> GetDepartInfoList()
        {
            return DepartInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<DepartInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return DepartInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveDepartInfo(DepartInfo departInfo)
        {
            departInfo.Save();
			return departInfo . DepartId;
        }
		
	}
}
