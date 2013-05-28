// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： ClientLevelInfo.cs
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
    /// ???ClientLevelInfoController?ObjectDataSource???
    /// </summary>
 	public partial class ClientLevelInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(ClientLevelInfo pClientLevelInfo)
		{
			ClientLevelInfo clientLevelInfo = new ClientLevelInfo(pClientLevelInfo.ClientLevelId);
            clientLevelInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public ClientLevelInfo GetClientLevelInfoById(int ClientLevelId)
        {
			   
			ClientLevelInfo clientLevelInfo  = null;//
            try
            {
                 clientLevelInfo = new ClientLevelInfo(ClientLevelId);

            }
            catch (AppException)
            {
                return null;
            }

            return  clientLevelInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<ClientLevelInfo> GetClientLevelInfoList()
        {
            return ClientLevelInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<ClientLevelInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return ClientLevelInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveClientLevelInfo(ClientLevelInfo clientLevelInfo)
        {
            clientLevelInfo.Save();
			return clientLevelInfo . ClientLevelId;
        }
		
	}
}
