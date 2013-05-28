// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： MainBusinessExpInfo.cs
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
    /// ???MainBusinessExpInfoController?ObjectDataSource???
    /// </summary>
 	public partial class MainBusinessExpInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(MainBusinessExpInfo pMainBusinessExpInfo)
		{
			MainBusinessExpInfo mainBusinessExpInfo = new MainBusinessExpInfo(pMainBusinessExpInfo.MainBusinessExpId);
            mainBusinessExpInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public MainBusinessExpInfo GetMainBusinessExpInfoById(int MainBusinessExpId)
        {
			   
			MainBusinessExpInfo mainBusinessExpInfo  = null;//
            try
            {
                 mainBusinessExpInfo = new MainBusinessExpInfo(MainBusinessExpId);

            }
            catch (AppException)
            {
                return null;
            }

            return  mainBusinessExpInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<MainBusinessExpInfo> GetMainBusinessExpInfoList()
        {
            return MainBusinessExpInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<MainBusinessExpInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return MainBusinessExpInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveMainBusinessExpInfo(MainBusinessExpInfo mainBusinessExpInfo)
        {
            mainBusinessExpInfo.Save();
			return mainBusinessExpInfo . MainBusinessExpId;
        }
		
	}
}
