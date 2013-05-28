// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： EmLevelInfo.cs
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
    /// ???EmLevelInfoController?ObjectDataSource???
    /// </summary>
 	public partial class EmLevelInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(EmLevelInfo pEmLevelInfo)
		{
			EmLevelInfo emLevelInfo = new EmLevelInfo(pEmLevelInfo.EmlevelId);
            emLevelInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public EmLevelInfo GetEmLevelInfoById(int EmlevelId)
        {
			   
			EmLevelInfo emLevelInfo  = null;//
            try
            {
                 emLevelInfo = new EmLevelInfo(EmlevelId);

            }
            catch (AppException)
            {
                return null;
            }

            return  emLevelInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<EmLevelInfo> GetEmLevelInfoList()
        {
            return EmLevelInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<EmLevelInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return EmLevelInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveEmLevelInfo(EmLevelInfo emLevelInfo)
        {
            emLevelInfo.Save();
			return emLevelInfo . EmlevelId;
        }
		
	}
}
