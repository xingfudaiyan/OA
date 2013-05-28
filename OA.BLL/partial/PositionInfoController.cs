// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： PositionInfo.cs
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
    /// ???PositionInfoController?ObjectDataSource???
    /// </summary>
 	public partial class PositionInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(PositionInfo pPositionInfo)
		{
			PositionInfo positionInfo = new PositionInfo(pPositionInfo.PositionId);
            positionInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public PositionInfo GetPositionInfoById(int PositionId)
        {
			   
			PositionInfo positionInfo  = null;//
            try
            {
                 positionInfo = new PositionInfo(PositionId);

            }
            catch (AppException)
            {
                return null;
            }

            return  positionInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<PositionInfo> GetPositionInfoList()
        {
            return PositionInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<PositionInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return PositionInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SavePositionInfo(PositionInfo positionInfo)
        {
            positionInfo.Save();
			return positionInfo . PositionId;
        }
		
	}
}
