// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： MainSpecialExpInfo.cs
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
    /// ???MainSpecialExpInfoController?ObjectDataSource???
    /// </summary>
 	public partial class MainSpecialExpInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(MainSpecialExpInfo pMainSpecialExpInfo)
		{
			MainSpecialExpInfo mainSpecialExpInfo = new MainSpecialExpInfo(pMainSpecialExpInfo.MainSpecialExpId);
            mainSpecialExpInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public MainSpecialExpInfo GetMainSpecialExpInfoById(int MainSpecialExpId)
        {
			   
			MainSpecialExpInfo mainSpecialExpInfo  = null;//
            try
            {
                 mainSpecialExpInfo = new MainSpecialExpInfo(MainSpecialExpId);

            }
            catch (AppException)
            {
                return null;
            }

            return  mainSpecialExpInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<MainSpecialExpInfo> GetMainSpecialExpInfoList()
        {
            return MainSpecialExpInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<MainSpecialExpInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return MainSpecialExpInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveMainSpecialExpInfo(MainSpecialExpInfo mainSpecialExpInfo)
        {
            mainSpecialExpInfo.Save();
			return mainSpecialExpInfo . MainSpecialExpId;
        }
		
	}
}
