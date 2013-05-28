// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： WeekSumInfo.cs
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
    /// ???WeekSumInfoController?ObjectDataSource???
    /// </summary>
 	public partial class WeekSumInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(WeekSumInfo pWeekSumInfo)
		{
			WeekSumInfo weekSumInfo = new WeekSumInfo(pWeekSumInfo.WeekSumId);
            weekSumInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public WeekSumInfo GetWeekSumInfoById(int WeekSumId)
        {
			   
			WeekSumInfo weekSumInfo  = null;//
            try
            {
                 weekSumInfo = new WeekSumInfo(WeekSumId);

            }
            catch (AppException)
            {
                return null;
            }

            return  weekSumInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<WeekSumInfo> GetWeekSumInfoList()
        {
            return WeekSumInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<WeekSumInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return WeekSumInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveWeekSumInfo(WeekSumInfo weekSumInfo)
        {
            weekSumInfo.Save();
			return weekSumInfo . WeekSumId;
        }
		
	}
}
