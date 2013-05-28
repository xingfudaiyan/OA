// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： EmDangInfo.cs
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
    /// ???EmDangInfoController?ObjectDataSource???
    /// </summary>
 	public partial class EmDangInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(EmDangInfo pEmDangInfo)
		{
			EmDangInfo emDangInfo = new EmDangInfo(pEmDangInfo.EmDangId);
            emDangInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public EmDangInfo GetEmDangInfoById(int EmDangId)
        {
			   
			EmDangInfo emDangInfo  = null;//
            try
            {
                 emDangInfo = new EmDangInfo(EmDangId);

            }
            catch (AppException)
            {
                return null;
            }

            return  emDangInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<EmDangInfo> GetEmDangInfoList()
        {
            return EmDangInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<EmDangInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return EmDangInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveEmDangInfo(EmDangInfo emDangInfo)
        {
            emDangInfo.Save();
			return emDangInfo . EmDangId;
        }
		
	}
}
