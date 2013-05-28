// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： MainProjectExecuteInfo.cs
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
    /// ???MainProjectExecuteInfoController?ObjectDataSource???
    /// </summary>
 	public partial class MainProjectExecuteInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(MainProjectExecuteInfo pMainProjectExecuteInfo)
		{
			MainProjectExecuteInfo mainProjectExecuteInfo = new MainProjectExecuteInfo(pMainProjectExecuteInfo.MainProjectExecuteId);
            mainProjectExecuteInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public MainProjectExecuteInfo GetMainProjectExecuteInfoById(int MainProjectExecuteId)
        {
			   
			MainProjectExecuteInfo mainProjectExecuteInfo  = null;//
            try
            {
                 mainProjectExecuteInfo = new MainProjectExecuteInfo(MainProjectExecuteId);

            }
            catch (AppException)
            {
                return null;
            }

            return  mainProjectExecuteInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<MainProjectExecuteInfo> GetMainProjectExecuteInfoList()
        {
            return MainProjectExecuteInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<MainProjectExecuteInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return MainProjectExecuteInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveMainProjectExecuteInfo(MainProjectExecuteInfo mainProjectExecuteInfo)
        {
            mainProjectExecuteInfo.Save();
			return mainProjectExecuteInfo . MainProjectExecuteId;
        }
		
	}
}
