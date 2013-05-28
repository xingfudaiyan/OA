// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： MessageInfo.cs
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
    /// ???MessageInfoController?ObjectDataSource???
    /// </summary>
 	public partial class MessageInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(MessageInfo pMessageInfo)
		{
			MessageInfo messageInfo = new MessageInfo(pMessageInfo.MessageId);
            messageInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public MessageInfo GetMessageInfoById(int MessageId)
        {
			   
			MessageInfo messageInfo  = null;//
            try
            {
                 messageInfo = new MessageInfo(MessageId);

            }
            catch (AppException)
            {
                return null;
            }

            return  messageInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<MessageInfo> GetMessageInfoList()
        {
            return MessageInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<MessageInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return MessageInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveMessageInfo(MessageInfo messageInfo)
        {
            messageInfo.Save();
			return messageInfo . MessageId;
        }
		
	}
}
