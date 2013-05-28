// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： ActionMasterInfo.cs
// createDate：2012-3-28

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
    /// ???ActionMasterInfoController?ObjectDataSource???
    /// </summary>
 	public partial class ActionMasterInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(ActionMasterInfo pActionMasterInfo)
		{
			ActionMasterInfo actionMasterInfo = new ActionMasterInfo(pActionMasterInfo.ActionMasterId);
            actionMasterInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public ActionMasterInfo GetActionMasterInfoById(int ActionMasterId)
        {
			   
			ActionMasterInfo actionMasterInfo  = null;//
            try
            {
                 actionMasterInfo = new ActionMasterInfo(ActionMasterId);

            }
            catch (AppException)
            {
                return null;
            }

            return  actionMasterInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<ActionMasterInfo> GetActionMasterInfoList()
        {
            return ActionMasterInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<ActionMasterInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return ActionMasterInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveActionMasterInfo(ActionMasterInfo actionMasterInfo)
        {
            actionMasterInfo.Save();
			return actionMasterInfo . ActionMasterId;
        }
		
	}
}
