// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： ActionInfo.cs
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
    /// ???ActionInfoController?ObjectDataSource???
    /// </summary>
 	public partial class ActionInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(ActionInfo pActionInfo)
		{
			ActionInfo actionInfo = new ActionInfo(pActionInfo.ActionId);
            actionInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public ActionInfo GetActionInfoById(int ActionId)
        {
			   
			ActionInfo actionInfo  = null;//
            try
            {
                 actionInfo = new ActionInfo(ActionId);

            }
            catch (AppException)
            {
                return null;
            }

            return  actionInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<ActionInfo> GetActionInfoList()
        {
            return ActionInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<ActionInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return ActionInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveActionInfo(ActionInfo actionInfo)
        {
            actionInfo.Save();
			return actionInfo . ActionId;
        }
		
	}
}
