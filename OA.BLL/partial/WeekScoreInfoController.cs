// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： WeekScoreInfo.cs
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
    /// ???WeekScoreInfoController?ObjectDataSource???
    /// </summary>
 	public partial class WeekScoreInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(WeekScoreInfo pWeekScoreInfo)
		{
			WeekScoreInfo weekScoreInfo = new WeekScoreInfo(pWeekScoreInfo.WeekScoreId);
            weekScoreInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public WeekScoreInfo GetWeekScoreInfoById(int WeekScoreId)
        {
			   
			WeekScoreInfo weekScoreInfo  = null;//
            try
            {
                 weekScoreInfo = new WeekScoreInfo(WeekScoreId);

            }
            catch (AppException)
            {
                return null;
            }

            return  weekScoreInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<WeekScoreInfo> GetWeekScoreInfoList()
        {
            return WeekScoreInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<WeekScoreInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return WeekScoreInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveWeekScoreInfo(WeekScoreInfo weekScoreInfo)
        {
            weekScoreInfo.Save();
			return weekScoreInfo . WeekScoreId;
        }
		
	}
}
