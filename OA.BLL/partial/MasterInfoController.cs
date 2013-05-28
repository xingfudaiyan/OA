// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： MasterInfo.cs
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
    /// ???MasterInfoController?ObjectDataSource???
    /// </summary>
 	public partial class MasterInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(MasterInfo pMasterInfo)
		{
			MasterInfo masterInfo = new MasterInfo(pMasterInfo.MasterId);
            masterInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public MasterInfo GetMasterInfoById(int MasterId)
        {
			   
			MasterInfo masterInfo  = null;//
            try
            {
                 masterInfo = new MasterInfo(MasterId);

            }
            catch (AppException)
            {
                return null;
            }

            return  masterInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<MasterInfo> GetMasterInfoList()
        {
            return MasterInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<MasterInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return MasterInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveMasterInfo(MasterInfo masterInfo)
        {
            masterInfo.Save();
			return masterInfo . MasterId;
        }
		
	}
}
