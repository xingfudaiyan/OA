// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： YearInfo.cs
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
    /// ???YearInfoController?ObjectDataSource???
    /// </summary>
 	public partial class YearInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(YearInfo pYearInfo)
		{
			YearInfo yearInfo = new YearInfo(pYearInfo.YearId);
            yearInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public YearInfo GetYearInfoById(int YearId)
        {
			   
			YearInfo yearInfo  = null;//
            try
            {
                 yearInfo = new YearInfo(YearId);

            }
            catch (AppException)
            {
                return null;
            }

            return  yearInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<YearInfo> GetYearInfoList()
        {
            return YearInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<YearInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return YearInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveYearInfo(YearInfo yearInfo)
        {
            yearInfo.Save();
			return yearInfo . YearId;
        }
		
	}
}
