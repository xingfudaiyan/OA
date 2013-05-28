// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： FileEmployeeInfo.cs
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
    /// ???FileEmployeeInfoController?ObjectDataSource???
    /// </summary>
 	public partial class FileEmployeeInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(FileEmployeeInfo pFileEmployeeInfo)
		{
			FileEmployeeInfo fileEmployeeInfo = new FileEmployeeInfo(pFileEmployeeInfo.FileEmployeeId);
            fileEmployeeInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public FileEmployeeInfo GetFileEmployeeInfoById(int FileEmployeeId)
        {
			   
			FileEmployeeInfo fileEmployeeInfo  = null;//
            try
            {
                 fileEmployeeInfo = new FileEmployeeInfo(FileEmployeeId);

            }
            catch (AppException)
            {
                return null;
            }

            return  fileEmployeeInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<FileEmployeeInfo> GetFileEmployeeInfoList()
        {
            return FileEmployeeInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<FileEmployeeInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return FileEmployeeInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveFileEmployeeInfo(FileEmployeeInfo fileEmployeeInfo)
        {
            fileEmployeeInfo.Save();
			return fileEmployeeInfo . FileEmployeeId;
        }
		
	}
}
