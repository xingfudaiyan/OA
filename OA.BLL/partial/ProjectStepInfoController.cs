// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： ProjectStepInfo.cs
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
    /// ???ProjectStepInfoController?ObjectDataSource???
    /// </summary>
 	public partial class ProjectStepInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(ProjectStepInfo pProjectStepInfo)
		{
			ProjectStepInfo projectStepInfo = new ProjectStepInfo(pProjectStepInfo.ProjectStepId);
            projectStepInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public ProjectStepInfo GetProjectStepInfoById(int ProjectStepId)
        {
			   
			ProjectStepInfo projectStepInfo  = null;//
            try
            {
                 projectStepInfo = new ProjectStepInfo(ProjectStepId);

            }
            catch (AppException)
            {
                return null;
            }

            return  projectStepInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<ProjectStepInfo> GetProjectStepInfoList()
        {
            return ProjectStepInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<ProjectStepInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return ProjectStepInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveProjectStepInfo(ProjectStepInfo projectStepInfo)
        {
            projectStepInfo.Save();
			return projectStepInfo . ProjectStepId;
        }
		
	}
}
