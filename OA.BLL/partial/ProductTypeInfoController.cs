// =================================================================== 
// Class Description
//====================================================================
// creator:sk @Copy Right 中华残疾人服务网OA项目 
// file： ProductTypeInfo.cs
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
    /// ???ProductTypeInfoController?ObjectDataSource???
    /// </summary>
 	public partial class ProductTypeInfoController
	{
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public void DeleteById(ProductTypeInfo pProductTypeInfo)
		{
			ProductTypeInfo productTypeInfo = new ProductTypeInfo(pProductTypeInfo.ProductTypeId);
            productTypeInfo.Delete();
		}
		
		
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public ProductTypeInfo GetProductTypeInfoById(int ProductTypeId)
        {
			   
			ProductTypeInfo productTypeInfo  = null;//
            try
            {
                 productTypeInfo = new ProductTypeInfo(ProductTypeId);

            }
            catch (AppException)
            {
                return null;
            }

            return  productTypeInfo;
          
        }

		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<ProductTypeInfo> GetProductTypeInfoList()
        {
            return ProductTypeInfo.GetList();
        }
		
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
        public List<ProductTypeInfo> GetPagedList(int pPageIndex, int pPageSize, SortDirection pOrderBy, string pSortExpression, out int pRecordCount)
        {
            return ProductTypeInfo.GetPagedList(pPageIndex,pPageSize,pOrderBy,pSortExpression,out pRecordCount);
        }

	    [DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
        public object  SaveProductTypeInfo(ProductTypeInfo productTypeInfo)
        {
            productTypeInfo.Save();
			return productTypeInfo . ProductTypeId;
        }
		
	}
}
