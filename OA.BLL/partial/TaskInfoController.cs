// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： TaskInfo.cs
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
    /// ???TaskInfoController?ObjectDataSource???
    /// </summary>
 	public partial class TaskInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(TaskInfo pTaskInfo)
		{
			TaskInfo taskInfo = new TaskInfo(pTaskInfo.TaskId);
            taskInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public TaskInfo GetTaskInfoById(int TaskId)
        {
			   
			TaskInfo taskInfo  = null;//
            try
            {
                 taskInfo = new TaskInfo(TaskId);

            }
            catch (AppException)
            {
                return null;
            }

            return  taskInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<TaskInfo> GetTaskInfoList()
        {
            return TaskInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<TaskInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return TaskInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveTaskInfo(TaskInfo taskInfo)
        {
            taskInfo.Save();
			return taskInfo . TaskId;
        }
		
	}
}
