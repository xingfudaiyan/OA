// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： ProjectLevelInfo.cs
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
    /// ???ProjectLevelInfoController?ObjectDataSource???
    /// </summary>
 	public partial class ProjectLevelInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(ProjectLevelInfo pProjectLevelInfo)
		{
			ProjectLevelInfo projectLevelInfo = new ProjectLevelInfo(pProjectLevelInfo.ProjectLevelId);
            projectLevelInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public ProjectLevelInfo GetProjectLevelInfoById(int ProjectLevelId)
        {
			   
			ProjectLevelInfo projectLevelInfo  = null;//
            try
            {
                 projectLevelInfo = new ProjectLevelInfo(ProjectLevelId);

            }
            catch (AppException)
            {
                return null;
            }

            return  projectLevelInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<ProjectLevelInfo> GetProjectLevelInfoList()
        {
            return ProjectLevelInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<ProjectLevelInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return ProjectLevelInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveProjectLevelInfo(ProjectLevelInfo projectLevelInfo)
        {
            projectLevelInfo.Save();
			return projectLevelInfo . ProjectLevelId;
        }
		
	}
}
