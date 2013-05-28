// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： WeekInfo.cs
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
    /// ???WeekInfoController?ObjectDataSource???
    /// </summary>
 	public partial class WeekInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(WeekInfo pWeekInfo)
		{
			WeekInfo weekInfo = new WeekInfo(pWeekInfo.WeekId);
            weekInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public WeekInfo GetWeekInfoById(int WeekId)
        {
			   
			WeekInfo weekInfo  = null;//
            try
            {
                 weekInfo = new WeekInfo(WeekId);

            }
            catch (AppException)
            {
                return null;
            }

            return  weekInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<WeekInfo> GetWeekInfoList()
        {
            return WeekInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<WeekInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return WeekInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveWeekInfo(WeekInfo weekInfo)
        {
            weekInfo.Save();
			return weekInfo . WeekId;
        }
		
	}
}
