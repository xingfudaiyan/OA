// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： ClientInfo.cs
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
    /// ???ClientInfoController?ObjectDataSource???
    /// </summary>
 	public partial class ClientInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(ClientInfo pClientInfo)
		{
			ClientInfo clientInfo = new ClientInfo(pClientInfo.ClientId);
            clientInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public ClientInfo GetClientInfoById(int ClientId)
        {
			   
			ClientInfo clientInfo  = null;//
            try
            {
                 clientInfo = new ClientInfo(ClientId);

            }
            catch (AppException)
            {
                return null;
            }

            return  clientInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<ClientInfo> GetClientInfoList()
        {
            return ClientInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<ClientInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return ClientInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveClientInfo(ClientInfo clientInfo)
        {
            clientInfo.Save();
			return clientInfo . ClientId;
        }
		
	}
}
