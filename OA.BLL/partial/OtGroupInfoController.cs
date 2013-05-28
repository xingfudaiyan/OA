// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： OtGroupInfo.cs
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
    /// ???OtGroupInfoController?ObjectDataSource???
    /// </summary>
 	public partial class OtGroupInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(OtGroupInfo pOtGroupInfo)
		{
			OtGroupInfo otGroupInfo = new OtGroupInfo(pOtGroupInfo.OtGroupId);
            otGroupInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public OtGroupInfo GetOtGroupInfoById(int OtGroupId)
        {
			   
			OtGroupInfo otGroupInfo  = null;//
            try
            {
                 otGroupInfo = new OtGroupInfo(OtGroupId);

            }
            catch (AppException)
            {
                return null;
            }

            return  otGroupInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<OtGroupInfo> GetOtGroupInfoList()
        {
            return OtGroupInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<OtGroupInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return OtGroupInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveOtGroupInfo(OtGroupInfo otGroupInfo)
        {
            otGroupInfo.Save();
			return otGroupInfo . OtGroupId;
        }
		
	}
}
