// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： CarApplyInfo.cs
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
    /// ???CarApplyInfoController?ObjectDataSource???
    /// </summary>
 	public partial class CarApplyInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(CarApplyInfo pCarApplyInfo)
		{
			CarApplyInfo carApplyInfo = new CarApplyInfo(pCarApplyInfo.CarApplyId);
            carApplyInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public CarApplyInfo GetCarApplyInfoById(int CarApplyId)
        {
			   
			CarApplyInfo carApplyInfo  = null;//
            try
            {
                 carApplyInfo = new CarApplyInfo(CarApplyId);

            }
            catch (AppException)
            {
                return null;
            }

            return  carApplyInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<CarApplyInfo> GetCarApplyInfoList()
        {
            return CarApplyInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<CarApplyInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return CarApplyInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveCarApplyInfo(CarApplyInfo carApplyInfo)
        {
            carApplyInfo.Save();
			return carApplyInfo . CarApplyId;
        }
		
	}
}
