// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： FileApplyInfo.cs
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
    /// ???FileApplyInfoController?ObjectDataSource???
    /// </summary>
 	public partial class FileApplyInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(FileApplyInfo pFileApplyInfo)
		{
			FileApplyInfo fileApplyInfo = new FileApplyInfo(pFileApplyInfo.FileApplyId);
            fileApplyInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public FileApplyInfo GetFileApplyInfoById(int FileApplyId)
        {
			   
			FileApplyInfo fileApplyInfo  = null;//
            try
            {
                 fileApplyInfo = new FileApplyInfo(FileApplyId);

            }
            catch (AppException)
            {
                return null;
            }

            return  fileApplyInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<FileApplyInfo> GetFileApplyInfoList()
        {
            return FileApplyInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<FileApplyInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return FileApplyInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveFileApplyInfo(FileApplyInfo fileApplyInfo)
        {
            fileApplyInfo.Save();
			return fileApplyInfo . FileApplyId;
        }
		
	}
}
