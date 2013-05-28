// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： EmployeeInfo.cs
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
    /// ???EmployeeInfoController?ObjectDataSource???
    /// </summary>
 	public partial class EmployeeInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(EmployeeInfo pEmployeeInfo)
		{
			EmployeeInfo employeeInfo = new EmployeeInfo(pEmployeeInfo.EmployeeId);
            employeeInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public EmployeeInfo GetEmployeeInfoById(int EmployeeId)
        {
			   
			EmployeeInfo employeeInfo  = null;//
            try
            {
                 employeeInfo = new EmployeeInfo(EmployeeId);

            }
            catch (AppException)
            {
                return null;
            }

            return  employeeInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<EmployeeInfo> GetEmployeeInfoList()
        {
            return EmployeeInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<EmployeeInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return EmployeeInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveEmployeeInfo(EmployeeInfo employeeInfo)
        {
            employeeInfo.Save();
			return employeeInfo . EmployeeId;
        }
		
	}
}
