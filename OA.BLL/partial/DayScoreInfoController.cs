// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： DayScoreInfo.cs
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
    /// ???DayScoreInfoController?ObjectDataSource???
    /// </summary>
 	public partial class DayScoreInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(DayScoreInfo pDayScoreInfo)
		{
			DayScoreInfo dayScoreInfo = new DayScoreInfo(pDayScoreInfo.DayScoreId);
            dayScoreInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public DayScoreInfo GetDayScoreInfoById(int DayScoreId)
        {
			   
			DayScoreInfo dayScoreInfo  = null;//
            try
            {
                 dayScoreInfo = new DayScoreInfo(DayScoreId);

            }
            catch (AppException)
            {
                return null;
            }

            return  dayScoreInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<DayScoreInfo> GetDayScoreInfoList()
        {
            return DayScoreInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<DayScoreInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return DayScoreInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveDayScoreInfo(DayScoreInfo dayScoreInfo)
        {
            dayScoreInfo.Save();
			return dayScoreInfo . DayScoreId;
        }
		
	}
}
