// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： EvaluateLevelInfo.cs
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
    /// ???EvaluateLevelInfoController?ObjectDataSource???
    /// </summary>
 	public partial class EvaluateLevelInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(EvaluateLevelInfo pEvaluateLevelInfo)
		{
			EvaluateLevelInfo evaluateLevelInfo = new EvaluateLevelInfo(pEvaluateLevelInfo.EvaluateLevelId);
            evaluateLevelInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public EvaluateLevelInfo GetEvaluateLevelInfoById(int EvaluateLevelId)
        {
			   
			EvaluateLevelInfo evaluateLevelInfo  = null;//
            try
            {
                 evaluateLevelInfo = new EvaluateLevelInfo(EvaluateLevelId);

            }
            catch (AppException)
            {
                return null;
            }

            return  evaluateLevelInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<EvaluateLevelInfo> GetEvaluateLevelInfoList()
        {
            return EvaluateLevelInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<EvaluateLevelInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return EvaluateLevelInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveEvaluateLevelInfo(EvaluateLevelInfo evaluateLevelInfo)
        {
            evaluateLevelInfo.Save();
			return evaluateLevelInfo . EvaluateLevelId;
        }
		
	}
}
