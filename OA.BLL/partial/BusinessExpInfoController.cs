// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： BusinessExpInfo.cs
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
    /// ???BusinessExpInfoController?ObjectDataSource???
    /// </summary>
 	public partial class BusinessExpInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(BusinessExpInfo pBusinessExpInfo)
		{
			BusinessExpInfo businessExpInfo = new BusinessExpInfo(pBusinessExpInfo.BusinessExpId);
            businessExpInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public BusinessExpInfo GetBusinessExpInfoById(int BusinessExpId)
        {
			   
			BusinessExpInfo businessExpInfo  = null;//
            try
            {
                 businessExpInfo = new BusinessExpInfo(BusinessExpId);

            }
            catch (AppException)
            {
                return null;
            }

            return  businessExpInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<BusinessExpInfo> GetBusinessExpInfoList()
        {
            return BusinessExpInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<BusinessExpInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return BusinessExpInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveBusinessExpInfo(BusinessExpInfo businessExpInfo)
        {
            businessExpInfo.Save();
			return businessExpInfo . BusinessExpId;
        }
		
	}
}
