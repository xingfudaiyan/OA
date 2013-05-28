// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： ProjectCreateInfo.cs
// createDate：2012-9-24

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
    /// ???ProjectCreateInfoController?ObjectDataSource???
    /// </summary>
 	public partial class ProjectCreateInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(ProjectCreateInfo pProjectCreateInfo)
		{
			ProjectCreateInfo projectCreateInfo = new ProjectCreateInfo(pProjectCreateInfo.ProjectCreateId);
            projectCreateInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public ProjectCreateInfo GetProjectCreateInfoById(int ProjectCreateId)
        {
			   
			ProjectCreateInfo projectCreateInfo  = null;//
            try
            {
                 projectCreateInfo = new ProjectCreateInfo(ProjectCreateId);

            }
            catch (AppException)
            {
                return null;
            }

            return  projectCreateInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<ProjectCreateInfo> GetProjectCreateInfoList()
        {
            return ProjectCreateInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<ProjectCreateInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return ProjectCreateInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveProjectCreateInfo(ProjectCreateInfo projectCreateInfo)
        {
            projectCreateInfo.Save();
			return projectCreateInfo . ProjectCreateId;
        }
		
	}
}
