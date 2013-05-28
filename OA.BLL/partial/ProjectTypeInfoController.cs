// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： ProjectTypeInfo.cs
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
    /// ???ProjectTypeInfoController?ObjectDataSource???
    /// </summary>
 	public partial class ProjectTypeInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(ProjectTypeInfo pProjectTypeInfo)
		{
			ProjectTypeInfo projectTypeInfo = new ProjectTypeInfo(pProjectTypeInfo.ProjectTypeId);
            projectTypeInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public ProjectTypeInfo GetProjectTypeInfoById(int ProjectTypeId)
        {
			   
			ProjectTypeInfo projectTypeInfo  = null;//
            try
            {
                 projectTypeInfo = new ProjectTypeInfo(ProjectTypeId);

            }
            catch (AppException)
            {
                return null;
            }

            return  projectTypeInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<ProjectTypeInfo> GetProjectTypeInfoList()
        {
            return ProjectTypeInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<ProjectTypeInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return ProjectTypeInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveProjectTypeInfo(ProjectTypeInfo projectTypeInfo)
        {
            projectTypeInfo.Save();
			return projectTypeInfo . ProjectTypeId;
        }
		
	}
}
