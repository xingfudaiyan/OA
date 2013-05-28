// ======================================================================================================================================
// 类说明
//=======================================================================================================================================
// 创建者：sk @Copy Right 残友软件有限公司OA项目 
// 文件名：AssetInfo.cs
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
	///AssetInfo  Data
	/// </summary>
	[Serializable]
	public partial class AssetInfo:CanYou.EntityObject
	{
		#region 属性
		///<summary>
		///
		///</summary>
		private int assetId;
		///<summary>
		///
		///</summary>
		private string assetName = String.Empty;
		///<summary>
		///
		///</summary>
		private string type = String.Empty;
		///<summary>
		///
		///</summary>
		private string departName = String.Empty;
		///<summary>
		///
		///</summary>
		private string siteName = String.Empty;
		///<summary>
		///
		///</summary>
		private string unitName = String.Empty;
		///<summary>
		///
		///</summary>
		private string amount = String.Empty;
		///<summary>
		///
		///</summary>
		private string price = String.Empty;
		///<summary>
		///
		///</summary>
		private string memo = String.Empty;
		
		
		///一对多关系,如果
		private bool m_Loaded=false;
		#endregion
		
		#region 属性枚举
		public struct Fields
		{
			public const string AssetId=@"AssetId";
			public const string AssetName=@"AssetName";
			public const string Type=@"Type";
			public const string DepartName=@"DepartName";
			public const string SiteName=@"SiteName";
			public const string UnitName=@"UnitName";
			public const string Amount=@"Amount";
			public const string Price=@"Price";
			public const string Memo=@"Memo";
						
		}

		#endregion
		
		
		#region 构造函数
		///<summary>
		///
		///</summary>
		public AssetInfo()
		{
		}
		///<summary>
		///
		///</summary>
		public AssetInfo(int pAssetId,string pAssetName,string pType,string pDepartName,string pSiteName,string pUnitName,string pAmount,string pPrice,string pMemo)
		{
			assetId    = pAssetId;
			assetName  = pAssetName;
			type       = pType;
			departName = pDepartName;
			siteName   = pSiteName;
			unitName   = pUnitName;
			amount     = pAmount;
			price      = pPrice;
			memo       = pMemo;
			
		}
		
		
		///<summary>
		///
		///</summary>
		public AssetInfo(int assetId)
		{
			 LoadFromId(assetId);
		}
		
		private void LoadFromId(int assetId)
		{
		 
			if (CachedEntityCommander.IsTypeRegistered(typeof(AssetInfo)))
            {
				AssetInfo assetInfo=Find(GetList(), assetId);
				if(assetInfo==null)
					throw new AppException("未能在缓存中找到相应的键值对象");
                Copy(assetInfo, this);
            }
            else
            {	Asset asset=new Asset( assetId);	
				if(asset.IsNew)
				throw new AppException("尚未初始化");
               	LoadFromDAL(this, asset);
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
        public static  AssetInfo Find(List< AssetInfo> list,  int assetId)
        {
             return list.Find(delegate( AssetInfo item) { return item. assetId==assetId; });
        }
		
		
		/// <summary>
        /// 得到缓存键
        /// </summary>
        /// <returns></returns>
        private static string GetCacheKey()
        {
            return string.Format(CachedEntityCommander.CacheKey, typeof( AssetInfo).ToString());
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
        public static void Copy(AssetInfo pAssetInfoFrom, AssetInfo pAssetInfoTo)
        {
	 		pAssetInfoTo.AssetId = pAssetInfoFrom.assetId;
	 		pAssetInfoTo.AssetName = pAssetInfoFrom.assetName;
	 		pAssetInfoTo.Type = pAssetInfoFrom.type;
	 		pAssetInfoTo.DepartName = pAssetInfoFrom.departName;
	 		pAssetInfoTo.SiteName = pAssetInfoFrom.siteName;
	 		pAssetInfoTo.UnitName = pAssetInfoFrom.unitName;
	 		pAssetInfoTo.Amount = pAssetInfoFrom.amount;
	 		pAssetInfoTo.Price = pAssetInfoFrom.price;
	 		pAssetInfoTo.Memo = pAssetInfoFrom.memo;
			pAssetInfoTo.Loaded=pAssetInfoFrom.Loaded;
        }
		
		/// <summary>
		/// 批量装载
		/// </summary>
		internal static void LoadFromDALPatch(List< AssetInfo> pList, AssetCollection pCollection)
        {
            foreach (Asset asset in pCollection)
            {
                AssetInfo assetInfo = new AssetInfo();
                LoadFromDAL(assetInfo, asset );
                pList.Add(assetInfo);
            }
			
        }

		//从后台获取数据
		internal  static void  LoadFromDAL(AssetInfo pAssetInfo, Asset  pAsset)
		{
	 		pAssetInfo.assetId = pAsset.AssetId;
	 		pAssetInfo.assetName = pAsset.AssetName;
	 		pAssetInfo.type = pAsset.Type;
	 		pAssetInfo.departName = pAsset.DepartName;
	 		pAssetInfo.siteName = pAsset.SiteName;
	 		pAssetInfo.unitName = pAsset.UnitName;
	 		pAssetInfo.amount = pAsset.Amount;
	 		pAssetInfo.price = pAsset.Price;
	 		pAssetInfo.memo = pAsset.Memo;
			pAssetInfo.Loaded=true;
			
			}
		
		//数据持久化
		internal  static void  SaveToDb(AssetInfo pAssetInfo, Asset  pAsset,bool pIsNew)
		{
	 		pAsset.AssetId = pAssetInfo.assetId;
	 		pAsset.AssetName = pAssetInfo.assetName;
	 		pAsset.Type = pAssetInfo.type;
	 		pAsset.DepartName = pAssetInfo.departName;
	 		pAsset.SiteName = pAssetInfo.siteName;
	 		pAsset.UnitName = pAssetInfo.unitName;
	 		pAsset.Amount = pAssetInfo.amount;
	 		pAsset.Price = pAssetInfo.price;
	 		pAsset.Memo = pAssetInfo.memo;
			pAsset.IsNew=pIsNew;
			string UserName = SubsonicHelper.GetUserName();
			try
			{
				pAsset.Save(UserName);
			}
			catch(Exception ex)
			{
				LogManager.getInstance().getLogger(typeof(AssetInfo)).Error(ex);
				if(ex.Message.Contains("插入重复键"))//违反了唯一键
				{
					throw new AppException("此对象已经存在");//此处等待优化可以从唯一约束中直接取出提示来，如果没有的话，默认为原始的出错提示
				}
				throw new AppException("保存失败");
			}
			pAssetInfo.assetId = pAsset.AssetId;
			//如果缓存存在，更新缓存
			if (CachedEntityCommander.IsTypeRegistered(typeof(AssetInfo))) 
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
        public static List< AssetInfo> GetPagedList(int pPageIndex,int pPageSize,SortDirection pOrderBy,string pSortExpression,out int pRecordCount)
        {
			if(pPageIndex<=1)
			pPageIndex=1;
            List< AssetInfo> list = new List< AssetInfo>();
          
            Query q = Asset .CreateQuery();
            q.PageIndex = pPageIndex;
            q.PageSize = pPageSize;
            q.ORDER_BY(pSortExpression,pOrderBy.ToString());
			AssetCollection  collection=new  AssetCollection();
		 	collection.LoadAndCloseReader(q.ExecuteReader());
          
            foreach (Asset  asset  in collection)
            {
                AssetInfo assetInfo = new AssetInfo();
                LoadFromDAL(assetInfo,   asset);
                list.Add(assetInfo);
            }
			pRecordCount=q.GetRecordCount();
			
            return list;

        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		/// <returns></returns>
		public static List< AssetInfo> GetList()
		{
			string cacheKey = GetCacheKey();
			//本实体已经注册成缓存实体，并且缓存存在的时候，直接从缓存取
			if (CachedEntityCommander.IsTypeRegistered(typeof(AssetInfo)) && CachedEntityCommander.GetCache(cacheKey) != null)
            {
                return CachedEntityCommander.GetCache(cacheKey) as List< AssetInfo>;
            }
            else 
            {
				List< AssetInfo>  list =new List< AssetInfo>();
				AssetCollection  collection=new  AssetCollection();
				Query qry = new Query(Asset.Schema);
				collection.LoadAndCloseReader(qry.ExecuteReader());
				foreach(Asset asset in collection)
				{
					AssetInfo assetInfo= new AssetInfo();
					LoadFromDAL(assetInfo,asset);
					list.Add(assetInfo);
				}
			  	//生成缓存
                if (CachedEntityCommander.IsTypeRegistered(typeof(AssetInfo))) 
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
		public int AssetId
		{
			get {return assetId;}
			set {assetId = value;}
		}

		///<summary>
		///
		///</summary>
		public string AssetName
		{
			get {return assetName;}
			set {assetName = value;}
		}

		///<summary>
		///
		///</summary>
		public string Type
		{
			get {return type;}
			set {type = value;}
		}

		///<summary>
		///
		///</summary>
		public string DepartName
		{
			get {return departName;}
			set {departName = value;}
		}

		///<summary>
		///
		///</summary>
		public string SiteName
		{
			get {return siteName;}
			set {siteName = value;}
		}

		///<summary>
		///
		///</summary>
		public string UnitName
		{
			get {return unitName;}
			set {unitName = value;}
		}

		///<summary>
		///
		///</summary>
		public string Amount
		{
			get {return amount;}
			set {amount = value;}
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
		public string Memo
		{
			get {return memo;}
			set {memo = value;}
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
			bool result=  (Asset.Delete(AssetId) == 1);
			//更新缓存
			if (result&&CachedEntityCommander.IsTypeRegistered(typeof(AssetInfo))) 
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
        public void CopyTo(AssetInfo pAssetInfoTo)
        {
            Copy(this,  pAssetInfoTo);
        }
		
		
		
		
		
		/// <summary>
		/// 保存
		/// </summary>
		public override void Save()
		{
			if(!m_Loaded)//新增
			{
				Asset asset=new Asset();	
				SaveToDb(this, asset,true);
			}
			else//修改
			{
				Asset asset=new Asset(assetId);	
				if(asset.IsNew)
					throw new AppException("该数据已经不存在了");
				SaveToDb(this, asset,false);
			}
			
		}
		 
		#endregion
		
	}
}
