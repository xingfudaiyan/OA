// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： DayRoleInfo.cs
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
    /// ???DayRoleInfoController?ObjectDataSource???
    /// </summary>
 	public partial class DayRoleInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(DayRoleInfo pDayRoleInfo)
		{
			DayRoleInfo dayRoleInfo = new DayRoleInfo(pDayRoleInfo.DayRoleId);
            dayRoleInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public DayRoleInfo GetDayRoleInfoById(int DayRoleId)
        {
			   
			DayRoleInfo dayRoleInfo  = null;//
            try
            {
                 dayRoleInfo = new DayRoleInfo(DayRoleId);

            }
            catch (AppException)
            {
                return null;
            }

            return  dayRoleInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<DayRoleInfo> GetDayRoleInfoList()
        {
            return DayRoleInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<DayRoleInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return DayRoleInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveDayRoleInfo(DayRoleInfo dayRoleInfo)
        {
            dayRoleInfo.Save();
			return dayRoleInfo . DayRoleId;
        }
		
	}
}
