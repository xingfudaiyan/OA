// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： NoticeInfo.cs
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
    /// ???NoticeInfoController?ObjectDataSource???
    /// </summary>
 	public partial class NoticeInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(NoticeInfo pNoticeInfo)
		{
			NoticeInfo noticeInfo = new NoticeInfo(pNoticeInfo.NoticeId);
            noticeInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public NoticeInfo GetNoticeInfoById(int NoticeId)
        {
			   
			NoticeInfo noticeInfo  = null;//
            try
            {
                 noticeInfo = new NoticeInfo(NoticeId);

            }
            catch (AppException)
            {
                return null;
            }

            return  noticeInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<NoticeInfo> GetNoticeInfoList()
        {
            return NoticeInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<NoticeInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return NoticeInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveNoticeInfo(NoticeInfo noticeInfo)
        {
            noticeInfo.Save();
			return noticeInfo . NoticeId;
        }
		
	}
}
