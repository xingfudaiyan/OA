// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： RoleInfo.cs
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
    /// ???RoleInfoController?ObjectDataSource???
    /// </summary>
 	public partial class RoleInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(RoleInfo pRoleInfo)
		{
			RoleInfo roleInfo = new RoleInfo(pRoleInfo.RoleId);
            roleInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public RoleInfo GetRoleInfoById(int RoleId)
        {
			   
			RoleInfo roleInfo  = null;//
            try
            {
                 roleInfo = new RoleInfo(RoleId);

            }
            catch (AppException)
            {
                return null;
            }

            return  roleInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<RoleInfo> GetRoleInfoList()
        {
            return RoleInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<RoleInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return RoleInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveRoleInfo(RoleInfo roleInfo)
        {
            roleInfo.Save();
			return roleInfo . RoleId;
        }
		
	}
}
