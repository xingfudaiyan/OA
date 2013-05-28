// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： AssistantScoreInfo.cs
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
    /// ???AssistantScoreInfoController?ObjectDataSource???
    /// </summary>
 	public partial class AssistantScoreInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(AssistantScoreInfo pAssistantScoreInfo)
		{
			AssistantScoreInfo assistantScoreInfo = new AssistantScoreInfo(pAssistantScoreInfo.AssistantScoreId);
            assistantScoreInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public AssistantScoreInfo GetAssistantScoreInfoById(int AssistantScoreId)
        {
			   
			AssistantScoreInfo assistantScoreInfo  = null;//
            try
            {
                 assistantScoreInfo = new AssistantScoreInfo(AssistantScoreId);

            }
            catch (AppException)
            {
                return null;
            }

            return  assistantScoreInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<AssistantScoreInfo> GetAssistantScoreInfoList()
        {
            return AssistantScoreInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<AssistantScoreInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return AssistantScoreInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveAssistantScoreInfo(AssistantScoreInfo assistantScoreInfo)
        {
            assistantScoreInfo.Save();
			return assistantScoreInfo . AssistantScoreId;
        }
		
	}
}
