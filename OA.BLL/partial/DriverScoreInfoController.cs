// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： DriverScoreInfo.cs
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
    /// ???DriverScoreInfoController?ObjectDataSource???
    /// </summary>
 	public partial class DriverScoreInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(DriverScoreInfo pDriverScoreInfo)
		{
			DriverScoreInfo driverScoreInfo = new DriverScoreInfo(pDriverScoreInfo.DriverScoreId);
            driverScoreInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public DriverScoreInfo GetDriverScoreInfoById(int DriverScoreId)
        {
			   
			DriverScoreInfo driverScoreInfo  = null;//
            try
            {
                 driverScoreInfo = new DriverScoreInfo(DriverScoreId);

            }
            catch (AppException)
            {
                return null;
            }

            return  driverScoreInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<DriverScoreInfo> GetDriverScoreInfoList()
        {
            return DriverScoreInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<DriverScoreInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return DriverScoreInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveDriverScoreInfo(DriverScoreInfo driverScoreInfo)
        {
            driverScoreInfo.Save();
			return driverScoreInfo . DriverScoreId;
        }
		
	}
}
