// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： EducationInfo.cs
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
    /// ???EducationInfoController?ObjectDataSource???
    /// </summary>
 	public partial class EducationInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(EducationInfo pEducationInfo)
		{
			EducationInfo educationInfo = new EducationInfo(pEducationInfo.EducationId);
            educationInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public EducationInfo GetEducationInfoById(int EducationId)
        {
			   
			EducationInfo educationInfo  = null;//
            try
            {
                 educationInfo = new EducationInfo(EducationId);

            }
            catch (AppException)
            {
                return null;
            }

            return  educationInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<EducationInfo> GetEducationInfoList()
        {
            return EducationInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<EducationInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return EducationInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveEducationInfo(EducationInfo educationInfo)
        {
            educationInfo.Save();
			return educationInfo . EducationId;
        }
		
	}
}
