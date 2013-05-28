// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： ClientTypeInfo.cs
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
    /// ???ClientTypeInfoController?ObjectDataSource???
    /// </summary>
 	public partial class ClientTypeInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(ClientTypeInfo pClientTypeInfo)
		{
			ClientTypeInfo clientTypeInfo = new ClientTypeInfo(pClientTypeInfo.ClientTypeId);
            clientTypeInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public ClientTypeInfo GetClientTypeInfoById(int ClientTypeId)
        {
			   
			ClientTypeInfo clientTypeInfo  = null;//
            try
            {
                 clientTypeInfo = new ClientTypeInfo(ClientTypeId);

            }
            catch (AppException)
            {
                return null;
            }

            return  clientTypeInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<ClientTypeInfo> GetClientTypeInfoList()
        {
            return ClientTypeInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<ClientTypeInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return ClientTypeInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveClientTypeInfo(ClientTypeInfo clientTypeInfo)
        {
            clientTypeInfo.Save();
			return clientTypeInfo . ClientTypeId;
        }
		
	}
}
