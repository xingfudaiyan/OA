// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： OpProRoleInfo.cs
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
    /// ???OpProRoleInfoController?ObjectDataSource???
    /// </summary>
 	public partial class OpProRoleInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(OpProRoleInfo pOpProRoleInfo)
		{
			OpProRoleInfo opProRoleInfo = new OpProRoleInfo(pOpProRoleInfo.OpProRoleId);
            opProRoleInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public OpProRoleInfo GetOpProRoleInfoById(int OpProRoleId)
        {
			   
			OpProRoleInfo opProRoleInfo  = null;//
            try
            {
                 opProRoleInfo = new OpProRoleInfo(OpProRoleId);

            }
            catch (AppException)
            {
                return null;
            }

            return  opProRoleInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<OpProRoleInfo> GetOpProRoleInfoList()
        {
            return OpProRoleInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<OpProRoleInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return OpProRoleInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveOpProRoleInfo(OpProRoleInfo opProRoleInfo)
        {
            opProRoleInfo.Save();
			return opProRoleInfo . OpProRoleId;
        }
		
	}
}
