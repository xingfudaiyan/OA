// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： DayInfo.cs
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
    /// ???DayInfoController?ObjectDataSource???
    /// </summary>
 	public partial class DayInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(DayInfo pDayInfo)
		{
			DayInfo dayInfo = new DayInfo(pDayInfo.DayId);
            dayInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public DayInfo GetDayInfoById(int DayId)
        {
			   
			DayInfo dayInfo  = null;//
            try
            {
                 dayInfo = new DayInfo(DayId);

            }
            catch (AppException)
            {
                return null;
            }

            return  dayInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<DayInfo> GetDayInfoList()
        {
            return DayInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<DayInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return DayInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveDayInfo(DayInfo dayInfo)
        {
            dayInfo.Save();
			return dayInfo . DayId;
        }
		
	}
}
