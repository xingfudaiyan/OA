// ======================================================================================================================================
// 类说明
//=======================================================================================================================================
// 创建者：sk @Copy Right 残友软件有限公司OA项目 
// 文件名：ProductTypeInfo.cs
// 创建时间：2012-3-29
// 版本说明：自动生成器版本1.1:本版本及以后版本不再扩展搜索排序功能，UI层要访问这些功能，都必须手工写逻辑层方法，以提高业务方法的重用性。
//			本版本距上个版本的改进有:缓存，基类,一对多关系，多对一关系，事务，强制规则（扩展日志和排序使用），Fix不支持objectdataSource的BUG,增加了对象的COPY和数据库对像的List整体转换的功能
//									解决了不选视图不能生成的问题
//			下个版本2.0将会增加多对多关系，完成ui界面的自动化生成
// 注意事项：请不要在此文件中写任何代码!!!请注意你的数据库命名必须依照规范，否则生成的代码不能确保可用!!!本系统中依赖于数据库中表的关系，和唯一关系，
//			因此删除使用了联级删除，请在数据库中配好相应的删除规则!!!本版本暂不支持GUID,只支持自增长主键!!!
//
// ======================================================================================================================================
using System;
using System.Web;
using System.Collections;
using System.Collections.Generic;
using CanYouLib;
using CanYouLib.Exceptions;
using CanYouLib.Common;
using CanYou.OA.DAL;
using SubSonic;
using CanYou;

namespace CanYou.OA.BLL
{
	/// <summary>
	///ProductTypeInfo  Data
	/// </summary>
	[Serializable]
	public partial class ProductTypeInfo:CanYou.EntityObject
	{
		#region 属性
		///<summary>
		///
		///</summary>
		private int productTypeId;
		///<summary>
		///
		///</summary>
		private string productName = String.Empty;
		///<summary>
		///
		///</summary>
		private int? offerPriceId;
		///<summary>
		///
		///</summary>
		private string model = String.Empty;
		///<summary>
		///
		///</summary>
		private string unit = String.Empty;
		///<summary>
		///
		///</summary>
		private string num = String.Empty;
		///<summary>
		///
		///</summary>
		private string price = String.Empty;
		///<summary>
		///
		///</summary>
		private string sums = String.Empty;
		
		
		///一对多关系,如果
		private bool m_Loaded=false;
		#endregion
		
		#region 属性枚举
		public struct Fields
		{
			public const string ProductTypeId=@"ProductTypeId";
			public const string ProductName=@"ProductName";
			public const string OfferPriceId=@"OfferPriceId";
			public const string Model=@"Model";
			public const string Unit=@"Unit";
			public const string Num=@"Num";
			public const string Price=@"Price";
			public const string Sums=@"Sums";
						
		}

		#endregion
		
		
		#region 构造函数
		///<summary>
		///
		///</summary>
		public ProductTypeInfo()
		{
		}
		///<summary>
		///
		///</summary>
		public ProductTypeInfo(int pProductTypeId,string pProductName,int? pOfferPriceId,string pModel,string pUnit,string pNum,string pPrice,string pSums)
		{
			productTypeId = pProductTypeId;
			productName   = pProductName;
			offerPriceId  = pOfferPriceId;
			model         = pModel;
			unit          = pUnit;
			num           = pNum;
			price         = pPrice;
			sums          = pSums;
			
		}
		
		
		///<summary>
		///
		///</summary>
		public ProductTypeInfo(int productTypeId)
		{
			 LoadFromId(productTypeId);
		}
		
		private void LoadFromId(int productTypeId)
		{
		 
			if (CachedEntityCommander.IsTypeRegistered(typeof(ProductTypeInfo)))
            {
				ProductTypeInfo productTypeInfo=Find(GetList(), productTypeId);
				if(productTypeInfo==null)
					throw new AppException("未能在缓存中找到相应的键值对象");
                Copy(productTypeInfo, this);
            }
            else
            {	ProductType productType=new ProductType( productTypeId);	
				if(productType.IsNew)
				throw new AppException("尚未初始化");
               	LoadFromDAL(this, productType);
            }
		}
		
		
		
		#endregion
		
	
		
		#region 静态方法
		
		/// <summary>
        /// 查找
        /// </summary>
        /// <param name="list"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        public static  ProductTypeInfo Find(List< ProductTypeInfo> list,  int productTypeId)
        {
             return list.Find(delegate( ProductTypeInfo item) { return item. productTypeId==productTypeId; });
        }
		
		
		/// <summary>
        /// 得到缓存键
        /// </summary>
        /// <returns></returns>
        private static string GetCacheKey()
        {
            return string.Format(CachedEntityCommander.CacheKey, typeof( ProductTypeInfo).ToString());
        }
		
		
        /// <summary>
        /// 清空缓存
        /// </summary>
        internal static void ResetCache()
        {
            string cacheKey = GetCacheKey();
            CachedEntityCommander.RemoveCache(cacheKey);
        }
		
      
		/// <summary>
        /// 复制一个对象，采用硬编码的方式，避免反射的低效
        /// </summary>
        /// <param name="pIndustryTypeInfoFrom"></param>
        /// <param name="pIndustryTypeInfoTo"></param>
        public static void Copy(ProductTypeInfo pProductTypeInfoFrom, ProductTypeInfo pProductTypeInfoTo)
        {
	 		pProductTypeInfoTo.ProductTypeId = pProductTypeInfoFrom.productTypeId;
	 		pProductTypeInfoTo.ProductName = pProductTypeInfoFrom.productName;
	 		pProductTypeInfoTo.OfferPriceId = pProductTypeInfoFrom.offerPriceId;
	 		pProductTypeInfoTo.Model = pProductTypeInfoFrom.model;
	 		pProductTypeInfoTo.Unit = pProductTypeInfoFrom.unit;
	 		pProductTypeInfoTo.Num = pProductTypeInfoFrom.num;
	 		pProductTypeInfoTo.Price = pProductTypeInfoFrom.price;
	 		pProductTypeInfoTo.Sums = pProductTypeInfoFrom.sums;
			pProductTypeInfoTo.Loaded=pProductTypeInfoFrom.Loaded;
        }
		
		/// <summary>
		/// 批量装载
		/// </summary>
		internal static void LoadFromDALPatch(List< ProductTypeInfo> pList, ProductTypeCollection pCollection)
        {
            foreach (ProductType productType in pCollection)
            {
                ProductTypeInfo productTypeInfo = new ProductTypeInfo();
                LoadFromDAL(productTypeInfo, productType );
                pList.Add(productTypeInfo);
            }
			
        }

		//从后台获取数据
		internal  static void  LoadFromDAL(ProductTypeInfo pProductTypeInfo, ProductType  pProductType)
		{
	 		pProductTypeInfo.productTypeId = pProductType.ProductTypeId;
	 		pProductTypeInfo.productName = pProductType.ProductName;
	 		pProductTypeInfo.offerPriceId = pProductType.OfferPriceId;
	 		pProductTypeInfo.model = pProductType.Model;
	 		pProductTypeInfo.unit = pProductType.Unit;
	 		pProductTypeInfo.num = pProductType.Num;
	 		pProductTypeInfo.price = pProductType.Price;
	 		pProductTypeInfo.sums = pProductType.Sums;
			pProductTypeInfo.Loaded=true;
			
			}
		
		//数据持久化
		internal  static void  SaveToDb(ProductTypeInfo pProductTypeInfo, ProductType  pProductType,bool pIsNew)
		{
	 		pProductType.ProductTypeId = pProductTypeInfo.productTypeId;
	 		pProductType.ProductName = pProductTypeInfo.productName;
	 		pProductType.OfferPriceId = pProductTypeInfo.offerPriceId;
	 		pProductType.Model = pProductTypeInfo.model;
	 		pProductType.Unit = pProductTypeInfo.unit;
	 		pProductType.Num = pProductTypeInfo.num;
	 		pProductType.Price = pProductTypeInfo.price;
	 		pProductType.Sums = pProductTypeInfo.sums;
			pProductType.IsNew=pIsNew;
			string UserName = SubsonicHelper.GetUserName();
			try
			{
				pProductType.Save(UserName);
			}
			catch(Exception ex)
			{
				LogManager.getInstance().getLogger(typeof(ProductTypeInfo)).Error(ex);
				if(ex.Message.Contains("插入重复键"))//违反了唯一键
				{
					throw new AppException("此对象已经存在");//此处等待优化可以从唯一约束中直接取出提示来，如果没有的话，默认为原始的出错提示
				}
				throw new AppException("保存失败");
			}
			pProductTypeInfo.productTypeId = pProductType.ProductTypeId;
			//如果缓存存在，更新缓存
			if (CachedEntityCommander.IsTypeRegistered(typeof(ProductTypeInfo))) 
            {
                ResetCache();
            }
		}
		
		/// <summary>
        /// 获得分页列表,无论是否是缓存实体都从数据库直接拿取数据
        /// </summary>
        /// <param name="pPageIndex">页数</param>
        /// <param name="pPageSize">每页列表</param>
        /// <param name="pOrderBy">排序</param>
		/// <param name="pSortExpression">排序字段</param>
		/// <param name="pRecordCount">列表行数</param>
        /// <returns>数据分页</returns>
        public static List< ProductTypeInfo> GetPagedList(int pPageIndex,int pPageSize,SortDirection pOrderBy,string pSortExpression,out int pRecordCount)
        {
			if(pPageIndex<=1)
			pPageIndex=1;
            List< ProductTypeInfo> list = new List< ProductTypeInfo>();
          
            Query q = ProductType .CreateQuery();
            q.PageIndex = pPageIndex;
            q.PageSize = pPageSize;
            q.ORDER_BY(pSortExpression,pOrderBy.ToString());
			ProductTypeCollection  collection=new  ProductTypeCollection();
		 	collection.LoadAndCloseReader(q.ExecuteReader());
          
            foreach (ProductType  productType  in collection)
            {
                ProductTypeInfo productTypeInfo = new ProductTypeInfo();
                LoadFromDAL(productTypeInfo,   productType);
                list.Add(productTypeInfo);
            }
			pRecordCount=q.GetRecordCount();
			
            return list;

        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		/// <returns></returns>
		public static List< ProductTypeInfo> GetList()
		{
			string cacheKey = GetCacheKey();
			//本实体已经注册成缓存实体，并且缓存存在的时候，直接从缓存取
			if (CachedEntityCommander.IsTypeRegistered(typeof(ProductTypeInfo)) && CachedEntityCommander.GetCache(cacheKey) != null)
            {
                return CachedEntityCommander.GetCache(cacheKey) as List< ProductTypeInfo>;
            }
            else 
            {
				List< ProductTypeInfo>  list =new List< ProductTypeInfo>();
				ProductTypeCollection  collection=new  ProductTypeCollection();
				Query qry = new Query(ProductType.Schema);
				collection.LoadAndCloseReader(qry.ExecuteReader());
				foreach(ProductType productType in collection)
				{
					ProductTypeInfo productTypeInfo= new ProductTypeInfo();
					LoadFromDAL(productTypeInfo,productType);
					list.Add(productTypeInfo);
				}
			  	//生成缓存
                if (CachedEntityCommander.IsTypeRegistered(typeof(ProductTypeInfo))) 
                {
                    CachedEntityCommander.SetCache(cacheKey, list);
                }
				return list;
			}
			
		
		}
		#endregion
		
		
		
		
		#region 公有属性
		
		///<summary>
		///
		///</summary>
		public int ProductTypeId
		{
			get {return productTypeId;}
			set {productTypeId = value;}
		}

		///<summary>
		///
		///</summary>
		public string ProductName
		{
			get {return productName;}
			set {productName = value;}
		}

		///<summary>
		///
		///</summary>
		public int? OfferPriceId
		{
			get {return offerPriceId;}
			set {offerPriceId = value;}
		}

		///<summary>
		///
		///</summary>
		public string Model
		{
			get {return model;}
			set {model = value;}
		}

		///<summary>
		///
		///</summary>
		public string Unit
		{
			get {return unit;}
			set {unit = value;}
		}

		///<summary>
		///
		///</summary>
		public string Num
		{
			get {return num;}
			set {num = value;}
		}

		///<summary>
		///
		///</summary>
		public string Price
		{
			get {return price;}
			set {price = value;}
		}

		///<summary>
		///
		///</summary>
		public string Sums
		{
			get {return sums;}
			set {sums = value;}
		}
	
		public bool Loaded
        {
            get
            {
                return m_Loaded;
            }
            set
            {
                m_Loaded = value;
            }
        }
		
		#endregion
		
		#region 公有方法
		/// <summary>
		/// 删除
		/// </summary>
		/// <returns>是否成功</returns>
		public  override void Delete()
		{
			if(!m_Loaded)
				throw new AppException("尚未初始化");
			bool result=  (ProductType.Delete(ProductTypeId) == 1);
			//更新缓存
			if (result&&CachedEntityCommander.IsTypeRegistered(typeof(ProductTypeInfo))) 
            {
                ResetCache();
            }
            if(!result)
			{
				throw new AppException("删除失败，数据可能被删除");
			}
		}
		
		
		/// <summary>
        /// 复制为另一个对象
        /// </summary>
        /// <param name="pIndustryTypeInfoTo"></param>
        public void CopyTo(ProductTypeInfo pProductTypeInfoTo)
        {
            Copy(this,  pProductTypeInfoTo);
        }
		
		
		
		
		
		/// <summary>
		/// 保存
		/// </summary>
		public override void Save()
		{
			if(!m_Loaded)//新增
			{
				ProductType productType=new ProductType();	
				SaveToDb(this, productType,true);
			}
			else//修改
			{
				ProductType productType=new ProductType(productTypeId);	
				if(productType.IsNew)
					throw new AppException("该数据已经不存在了");
				SaveToDb(this, productType,false);
			}
			
		}
		 
		#endregion
		
	}
}
