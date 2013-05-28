// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： EmployeeBExpInfo.cs
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
    /// ???EmployeeBExpInfoController?ObjectDataSource???
    /// </summary>
 	public partial class EmployeeBExpInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(EmployeeBExpInfo pEmployeeBExpInfo)
		{
			EmployeeBExpInfo employeeBExpInfo = new EmployeeBExpInfo(pEmployeeBExpInfo.EmployeeBExpId);
            employeeBExpInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public EmployeeBExpInfo GetEmployeeBExpInfoById(int EmployeeBExpId)
        {
			   
			EmployeeBExpInfo employeeBExpInfo  = null;//
            try
            {
                 employeeBExpInfo = new EmployeeBExpInfo(EmployeeBExpId);

            }
            catch (AppException)
            {
                return null;
            }

            return  employeeBExpInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<EmployeeBExpInfo> GetEmployeeBExpInfoList()
        {
            return EmployeeBExpInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<EmployeeBExpInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return EmployeeBExpInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveEmployeeBExpInfo(EmployeeBExpInfo employeeBExpInfo)
        {
            employeeBExpInfo.Save();
			return employeeBExpInfo . EmployeeBExpId;
        }
		
	}
}
