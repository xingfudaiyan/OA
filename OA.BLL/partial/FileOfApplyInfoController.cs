// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： FileOfApplyInfo.cs
// createDate：2012-10-23

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
    /// ???FileOfApplyInfoController?ObjectDataSource???
    /// </summary>
 	public partial class FileOfApplyInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(FileOfApplyInfo pFileOfApplyInfo)
		{
			FileOfApplyInfo fileOfApplyInfo = new FileOfApplyInfo(pFileOfApplyInfo.FileOfApplyId);
            fileOfApplyInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public FileOfApplyInfo GetFileOfApplyInfoById(int FileOfApplyId)
        {
			   
			FileOfApplyInfo fileOfApplyInfo  = null;//
            try
            {
                 fileOfApplyInfo = new FileOfApplyInfo(FileOfApplyId);

            }
            catch (AppException)
            {
                return null;
            }

            return  fileOfApplyInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<FileOfApplyInfo> GetFileOfApplyInfoList()
        {
            return FileOfApplyInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<FileOfApplyInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return FileOfApplyInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveFileOfApplyInfo(FileOfApplyInfo fileOfApplyInfo)
        {
            fileOfApplyInfo.Save();
			return fileOfApplyInfo . FileOfApplyId;
        }
		
	}
}
