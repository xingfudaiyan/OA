// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： MainProjectCreateInfo.cs
// createDate：2012-9-24

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
    /// ???MainProjectCreateInfoController?ObjectDataSource???
    /// </summary>
 	public partial class MainProjectCreateInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(MainProjectCreateInfo pMainProjectCreateInfo)
		{
			MainProjectCreateInfo mainProjectCreateInfo = new MainProjectCreateInfo(pMainProjectCreateInfo.MainProjectCreateId);
            mainProjectCreateInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public MainProjectCreateInfo GetMainProjectCreateInfoById(int MainProjectCreateId)
        {
			   
			MainProjectCreateInfo mainProjectCreateInfo  = null;//
            try
            {
                 mainProjectCreateInfo = new MainProjectCreateInfo(MainProjectCreateId);

            }
            catch (AppException)
            {
                return null;
            }

            return  mainProjectCreateInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<MainProjectCreateInfo> GetMainProjectCreateInfoList()
        {
            return MainProjectCreateInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<MainProjectCreateInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return MainProjectCreateInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveMainProjectCreateInfo(MainProjectCreateInfo mainProjectCreateInfo)
        {
            mainProjectCreateInfo.Save();
			return mainProjectCreateInfo . MainProjectCreateId;
        }
		
	}
}
