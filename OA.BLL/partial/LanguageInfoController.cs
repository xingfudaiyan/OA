// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： LanguageInfo.cs
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
    /// ???LanguageInfoController?ObjectDataSource???
    /// </summary>
 	public partial class LanguageInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(LanguageInfo pLanguageInfo)
		{
			LanguageInfo languageInfo = new LanguageInfo(pLanguageInfo.LanguageId);
            languageInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public LanguageInfo GetLanguageInfoById(int LanguageId)
        {
			   
			LanguageInfo languageInfo  = null;//
            try
            {
                 languageInfo = new LanguageInfo(LanguageId);

            }
            catch (AppException)
            {
                return null;
            }

            return  languageInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<LanguageInfo> GetLanguageInfoList()
        {
            return LanguageInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<LanguageInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return LanguageInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveLanguageInfo(LanguageInfo languageInfo)
        {
            languageInfo.Save();
			return languageInfo . LanguageId;
        }
		
	}
}
