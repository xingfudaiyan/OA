// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： FilePermissionInfo.cs
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
    /// ???FilePermissionInfoController?ObjectDataSource???
    /// </summary>
 	public partial class FilePermissionInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(FilePermissionInfo pFilePermissionInfo)
		{
			FilePermissionInfo filePermissionInfo = new FilePermissionInfo(pFilePermissionInfo.FilePermissionId);
            filePermissionInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public FilePermissionInfo GetFilePermissionInfoById(int FilePermissionId)
        {
			   
			FilePermissionInfo filePermissionInfo  = null;//
            try
            {
                 filePermissionInfo = new FilePermissionInfo(FilePermissionId);

            }
            catch (AppException)
            {
                return null;
            }

            return  filePermissionInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<FilePermissionInfo> GetFilePermissionInfoList()
        {
            return FilePermissionInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<FilePermissionInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return FilePermissionInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveFilePermissionInfo(FilePermissionInfo filePermissionInfo)
        {
            filePermissionInfo.Save();
			return filePermissionInfo . FilePermissionId;
        }
		
	}
}
