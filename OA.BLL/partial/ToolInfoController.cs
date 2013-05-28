// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： ToolInfo.cs
// createDate：2012-11-2

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
    /// ???ToolInfoController?ObjectDataSource???
    /// </summary>
 	public partial class ToolInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(ToolInfo pToolInfo)
		{
			ToolInfo toolInfo = new ToolInfo(pToolInfo.ToolId);
            toolInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public ToolInfo GetToolInfoById(int ToolId)
        {
			   
			ToolInfo toolInfo  = null;//
            try
            {
                 toolInfo = new ToolInfo(ToolId);

            }
            catch (AppException)
            {
                return null;
            }

            return  toolInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<ToolInfo> GetToolInfoList()
        {
            return ToolInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<ToolInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return ToolInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveToolInfo(ToolInfo toolInfo)
        {
            toolInfo.Save();
			return toolInfo . ToolId;
        }
		
	}
}
