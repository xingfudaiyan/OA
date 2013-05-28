// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： SupplyInfo.cs
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
    /// ???SupplyInfoController?ObjectDataSource???
    /// </summary>
 	public partial class SupplyInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(SupplyInfo pSupplyInfo)
		{
			SupplyInfo supplyInfo = new SupplyInfo(pSupplyInfo.SupplyId);
            supplyInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public SupplyInfo GetSupplyInfoById(int SupplyId)
        {
			   
			SupplyInfo supplyInfo  = null;//
            try
            {
                 supplyInfo = new SupplyInfo(SupplyId);

            }
            catch (AppException)
            {
                return null;
            }

            return  supplyInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<SupplyInfo> GetSupplyInfoList()
        {
            return SupplyInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<SupplyInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return SupplyInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveSupplyInfo(SupplyInfo supplyInfo)
        {
            supplyInfo.Save();
			return supplyInfo . SupplyId;
        }
		
	}
}
