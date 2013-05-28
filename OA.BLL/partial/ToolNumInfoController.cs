// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： ToolNumInfo.cs
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
    /// ???ToolNumInfoController?ObjectDataSource???
    /// </summary>
 	public partial class ToolNumInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(ToolNumInfo pToolNumInfo)
		{
			ToolNumInfo toolNumInfo = new ToolNumInfo(pToolNumInfo.ToolNumId);
            toolNumInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public ToolNumInfo GetToolNumInfoById(int ToolNumId)
        {
			   
			ToolNumInfo toolNumInfo  = null;//
            try
            {
                 toolNumInfo = new ToolNumInfo(ToolNumId);

            }
            catch (AppException)
            {
                return null;
            }

            return  toolNumInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<ToolNumInfo> GetToolNumInfoList()
        {
            return ToolNumInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<ToolNumInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return ToolNumInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveToolNumInfo(ToolNumInfo toolNumInfo)
        {
            toolNumInfo.Save();
			return toolNumInfo . ToolNumId;
        }
		
	}
}
