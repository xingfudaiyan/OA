// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： SpecialExpInfo.cs
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
    /// ???SpecialExpInfoController?ObjectDataSource???
    /// </summary>
 	public partial class SpecialExpInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(SpecialExpInfo pSpecialExpInfo)
		{
			SpecialExpInfo specialExpInfo = new SpecialExpInfo(pSpecialExpInfo.SpecialExpId);
            specialExpInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public SpecialExpInfo GetSpecialExpInfoById(int SpecialExpId)
        {
			   
			SpecialExpInfo specialExpInfo  = null;//
            try
            {
                 specialExpInfo = new SpecialExpInfo(SpecialExpId);

            }
            catch (AppException)
            {
                return null;
            }

            return  specialExpInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<SpecialExpInfo> GetSpecialExpInfoList()
        {
            return SpecialExpInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<SpecialExpInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return SpecialExpInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveSpecialExpInfo(SpecialExpInfo specialExpInfo)
        {
            specialExpInfo.Save();
			return specialExpInfo . SpecialExpId;
        }
		
	}
}
