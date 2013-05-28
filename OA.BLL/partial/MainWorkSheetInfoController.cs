// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： MainWorkSheetInfo.cs
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
    /// ???MainWorkSheetInfoController?ObjectDataSource???
    /// </summary>
 	public partial class MainWorkSheetInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(MainWorkSheetInfo pMainWorkSheetInfo)
		{
			MainWorkSheetInfo mainWorkSheetInfo = new MainWorkSheetInfo(pMainWorkSheetInfo.MainWorkSheetId);
            mainWorkSheetInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public MainWorkSheetInfo GetMainWorkSheetInfoById(int MainWorkSheetId)
        {
			   
			MainWorkSheetInfo mainWorkSheetInfo  = null;//
            try
            {
                 mainWorkSheetInfo = new MainWorkSheetInfo(MainWorkSheetId);

            }
            catch (AppException)
            {
                return null;
            }

            return  mainWorkSheetInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<MainWorkSheetInfo> GetMainWorkSheetInfoList()
        {
            return MainWorkSheetInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<MainWorkSheetInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return MainWorkSheetInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveMainWorkSheetInfo(MainWorkSheetInfo mainWorkSheetInfo)
        {
            mainWorkSheetInfo.Save();
			return mainWorkSheetInfo . MainWorkSheetId;
        }
		
	}
}
