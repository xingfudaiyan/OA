// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： FileTypeInfo.cs
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
    /// ???FileTypeInfoController?ObjectDataSource???
    /// </summary>
 	public partial class FileTypeInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(FileTypeInfo pFileTypeInfo)
		{
			FileTypeInfo fileTypeInfo = new FileTypeInfo(pFileTypeInfo.FileTypeId);
            fileTypeInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public FileTypeInfo GetFileTypeInfoById(int FileTypeId)
        {
			   
			FileTypeInfo fileTypeInfo  = null;//
            try
            {
                 fileTypeInfo = new FileTypeInfo(FileTypeId);

            }
            catch (AppException)
            {
                return null;
            }

            return  fileTypeInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<FileTypeInfo> GetFileTypeInfoList()
        {
            return FileTypeInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<FileTypeInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return FileTypeInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveFileTypeInfo(FileTypeInfo fileTypeInfo)
        {
            fileTypeInfo.Save();
			return fileTypeInfo . FileTypeId;
        }
		
	}
}
