// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： StateInfo.cs
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
    /// ???StateInfoController?ObjectDataSource???
    /// </summary>
 	public partial class StateInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(StateInfo pStateInfo)
		{
			StateInfo stateInfo = new StateInfo(pStateInfo.StateId);
            stateInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public StateInfo GetStateInfoById(int StateId)
        {
			   
			StateInfo stateInfo  = null;//
            try
            {
                 stateInfo = new StateInfo(StateId);

            }
            catch (AppException)
            {
                return null;
            }

            return  stateInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<StateInfo> GetStateInfoList()
        {
            return StateInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<StateInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return StateInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveStateInfo(StateInfo stateInfo)
        {
            stateInfo.Save();
			return stateInfo . StateId;
        }
		
	}
}
