// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： RoleMasterInfo.cs
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
    /// ???RoleMasterInfoController?ObjectDataSource???
    /// </summary>
 	public partial class RoleMasterInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(RoleMasterInfo pRoleMasterInfo)
		{
			RoleMasterInfo roleMasterInfo = new RoleMasterInfo(pRoleMasterInfo.RoleMasterId);
            roleMasterInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public RoleMasterInfo GetRoleMasterInfoById(int RoleMasterId)
        {
			   
			RoleMasterInfo roleMasterInfo  = null;//
            try
            {
                 roleMasterInfo = new RoleMasterInfo(RoleMasterId);

            }
            catch (AppException)
            {
                return null;
            }

            return  roleMasterInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<RoleMasterInfo> GetRoleMasterInfoList()
        {
            return RoleMasterInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<RoleMasterInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return RoleMasterInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveRoleMasterInfo(RoleMasterInfo roleMasterInfo)
        {
            roleMasterInfo.Save();
			return roleMasterInfo . RoleMasterId;
        }
		
	}
}
