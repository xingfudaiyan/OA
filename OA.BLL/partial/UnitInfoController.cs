// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： UnitInfo.cs
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
    /// ???UnitInfoController?ObjectDataSource???
    /// </summary>
 	public partial class UnitInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(UnitInfo pUnitInfo)
		{
			UnitInfo unitInfo = new UnitInfo(pUnitInfo.UnitId);
            unitInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public UnitInfo GetUnitInfoById(int UnitId)
        {
			   
			UnitInfo unitInfo  = null;//
            try
            {
                 unitInfo = new UnitInfo(UnitId);

            }
            catch (AppException)
            {
                return null;
            }

            return  unitInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<UnitInfo> GetUnitInfoList()
        {
            return UnitInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<UnitInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return UnitInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveUnitInfo(UnitInfo unitInfo)
        {
            unitInfo.Save();
			return unitInfo . UnitId;
        }
		
	}
}
