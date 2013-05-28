// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： FileInfo.cs
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
    /// ???FileInfoController?ObjectDataSource???
    /// </summary>
 	public partial class FileInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(FileInfo pFileInfo)
		{
			FileInfo fileInfo = new FileInfo(pFileInfo.FileId);
            fileInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public FileInfo GetFileInfoById(int FileId)
        {
			   
			FileInfo fileInfo  = null;//
            try
            {
                 fileInfo = new FileInfo(FileId);

            }
            catch (AppException)
            {
                return null;
            }

            return  fileInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<FileInfo> GetFileInfoList()
        {
            return FileInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<FileInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return FileInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveFileInfo(FileInfo fileInfo)
        {
            fileInfo.Save();
			return fileInfo . FileId;
        }
		
	}
}
