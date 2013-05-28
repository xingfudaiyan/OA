// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： HolidayApplyInfo.cs
// createDate：2012-10-23

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
    /// ???HolidayApplyInfoController?ObjectDataSource???
    /// </summary>
 	public partial class HolidayApplyInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(HolidayApplyInfo pHolidayApplyInfo)
		{
			HolidayApplyInfo holidayApplyInfo = new HolidayApplyInfo(pHolidayApplyInfo.HolidayApplyId);
            holidayApplyInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public HolidayApplyInfo GetHolidayApplyInfoById(int HolidayApplyId)
        {
			   
			HolidayApplyInfo holidayApplyInfo  = null;//
            try
            {
                 holidayApplyInfo = new HolidayApplyInfo(HolidayApplyId);

            }
            catch (AppException)
            {
                return null;
            }

            return  holidayApplyInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<HolidayApplyInfo> GetHolidayApplyInfoList()
        {
            return HolidayApplyInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<HolidayApplyInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return HolidayApplyInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveHolidayApplyInfo(HolidayApplyInfo holidayApplyInfo)
        {
            holidayApplyInfo.Save();
			return holidayApplyInfo . HolidayApplyId;
        }
		
	}
}
