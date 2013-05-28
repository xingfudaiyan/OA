// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： MonthInfo.cs
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
    /// ???MonthInfoController?ObjectDataSource???
    /// </summary>
 	public partial class MonthInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(MonthInfo pMonthInfo)
		{
			MonthInfo monthInfo = new MonthInfo(pMonthInfo.MonthId);
            monthInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public MonthInfo GetMonthInfoById(int MonthId)
        {
			   
			MonthInfo monthInfo  = null;//
            try
            {
                 monthInfo = new MonthInfo(MonthId);

            }
            catch (AppException)
            {
                return null;
            }

            return  monthInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<MonthInfo> GetMonthInfoList()
        {
            return MonthInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<MonthInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return MonthInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveMonthInfo(MonthInfo monthInfo)
        {
            monthInfo.Save();
			return monthInfo . MonthId;
        }
		
	}
}
