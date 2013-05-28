// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： NurseScoreInfo.cs
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
    /// ???NurseScoreInfoController?ObjectDataSource???
    /// </summary>
 	public partial class NurseScoreInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(NurseScoreInfo pNurseScoreInfo)
		{
			NurseScoreInfo nurseScoreInfo = new NurseScoreInfo(pNurseScoreInfo.NurseScoreId);
            nurseScoreInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public NurseScoreInfo GetNurseScoreInfoById(int NurseScoreId)
        {
			   
			NurseScoreInfo nurseScoreInfo  = null;//
            try
            {
                 nurseScoreInfo = new NurseScoreInfo(NurseScoreId);

            }
            catch (AppException)
            {
                return null;
            }

            return  nurseScoreInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<NurseScoreInfo> GetNurseScoreInfoList()
        {
            return NurseScoreInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<NurseScoreInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return NurseScoreInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveNurseScoreInfo(NurseScoreInfo nurseScoreInfo)
        {
            nurseScoreInfo.Save();
			return nurseScoreInfo . NurseScoreId;
        }
		
	}
}
