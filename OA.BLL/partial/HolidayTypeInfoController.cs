// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： HolidayTypeInfo.cs
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
    /// ???HolidayTypeInfoController?ObjectDataSource???
    /// </summary>
 	public partial class HolidayTypeInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(HolidayTypeInfo pHolidayTypeInfo)
		{
			HolidayTypeInfo holidayTypeInfo = new HolidayTypeInfo(pHolidayTypeInfo.HolidayTypeId);
            holidayTypeInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public HolidayTypeInfo GetHolidayTypeInfoById(int HolidayTypeId)
        {
			   
			HolidayTypeInfo holidayTypeInfo  = null;//
            try
            {
                 holidayTypeInfo = new HolidayTypeInfo(HolidayTypeId);

            }
            catch (AppException)
            {
                return null;
            }

            return  holidayTypeInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<HolidayTypeInfo> GetHolidayTypeInfoList()
        {
            return HolidayTypeInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<HolidayTypeInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return HolidayTypeInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveHolidayTypeInfo(HolidayTypeInfo holidayTypeInfo)
        {
            holidayTypeInfo.Save();
			return holidayTypeInfo . HolidayTypeId;
        }
		
	}
}
