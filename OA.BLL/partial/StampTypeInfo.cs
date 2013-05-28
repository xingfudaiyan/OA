// ======================================================================================================================================
// 类说明
//=======================================================================================================================================
// 创建者：sk @Copy Right 残友软件有限公司OA项目 
// 文件名：StampTypeInfo.cs
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
	///StampTypeInfo  Data
	/// </summary>
	[Serializable]
	public partial class StampTypeInfo:CanYou.EntityObject
	{
		#region 属性
		///<summary>
		///
		///</summary>
		private int stampTypeId;
		///<summary>
		///
		///</summary>
		private string stampName = String.Empty;
		
		
		///一对多关系,如果
		private bool m_Loaded=false;
		#endregion
		
		#region 属性枚举
		public struct Fields
		{
			public const string StampTypeId=@"StampTypeId";
			public const string StampName=@"StampName";
						
		}

		#endregion
		
		
		#region 构造函数
		///<summary>
		///
		///</summary>
		public StampTypeInfo()
		{
		}
		///<summary>
		///
		///</summary>
		public StampTypeInfo(int pStampTypeId,string pStampName)
		{
			stampTypeId = pStampTypeId;
			stampName   = pStampName;
			
		}
		
		
		///<summary>
		///
		///</summary>
		public StampTypeInfo(int stampTypeId)
		{
			 LoadFromId(stampTypeId);
		}
		
		private void LoadFromId(int stampTypeId)
		{
		 
			if (CachedEntityCommander.IsTypeRegistered(typeof(StampTypeInfo)))
            {
				StampTypeInfo stampTypeInfo=Find(GetList(), stampTypeId);
				if(stampTypeInfo==null)
					throw new AppException("未能在缓存中找到相应的键值对象");
                Copy(stampTypeInfo, this);
            }
            else
            {	StampType stampType=new StampType( stampTypeId);	
				if(stampType.IsNew)
				throw new AppException("尚未初始化");
               	LoadFromDAL(this, stampType);
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
        public static  StampTypeInfo Find(List< StampTypeInfo> list,  int stampTypeId)
        {
             return list.Find(delegate( StampTypeInfo item) { return item. stampTypeId==stampTypeId; });
        }
		
		
		/// <summary>
        /// 得到缓存键
        /// </summary>
        /// <returns></returns>
        private static string GetCacheKey()
        {
            return string.Format(CachedEntityCommander.CacheKey, typeof( StampTypeInfo).ToString());
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
        public static void Copy(StampTypeInfo pStampTypeInfoFrom, StampTypeInfo pStampTypeInfoTo)
        {
	 		pStampTypeInfoTo.StampTypeId = pStampTypeInfoFrom.stampTypeId;
	 		pStampTypeInfoTo.StampName = pStampTypeInfoFrom.stampName;
			pStampTypeInfoTo.Loaded=pStampTypeInfoFrom.Loaded;
        }
		
		/// <summary>
		/// 批量装载
		/// </summary>
		internal static void LoadFromDALPatch(List< StampTypeInfo> pList, StampTypeCollection pCollection)
        {
            foreach (StampType stampType in pCollection)
            {
                StampTypeInfo stampTypeInfo = new StampTypeInfo();
                LoadFromDAL(stampTypeInfo, stampType );
                pList.Add(stampTypeInfo);
            }
			
        }

		//从后台获取数据
		internal  static void  LoadFromDAL(StampTypeInfo pStampTypeInfo, StampType  pStampType)
		{
	 		pStampTypeInfo.stampTypeId = pStampType.StampTypeId;
	 		pStampTypeInfo.stampName = pStampType.StampName;
			pStampTypeInfo.Loaded=true;
			
			}
		
		//数据持久化
		internal  static void  SaveToDb(StampTypeInfo pStampTypeInfo, StampType  pStampType,bool pIsNew)
		{
	 		pStampType.StampTypeId = pStampTypeInfo.stampTypeId;
	 		pStampType.StampName = pStampTypeInfo.stampName;
			pStampType.IsNew=pIsNew;
			string UserName = SubsonicHelper.GetUserName();
			try
			{
				pStampType.Save(UserName);
			}
			catch(Exception ex)
			{
				LogManager.getInstance().getLogger(typeof(StampTypeInfo)).Error(ex);
				if(ex.Message.Contains("插入重复键"))//违反了唯一键
				{
					throw new AppException("此对象已经存在");//此处等待优化可以从唯一约束中直接取出提示来，如果没有的话，默认为原始的出错提示
				}
				throw new AppException("保存失败");
			}
			pStampTypeInfo.stampTypeId = pStampType.StampTypeId;
			//如果缓存存在，更新缓存
			if (CachedEntityCommander.IsTypeRegistered(typeof(StampTypeInfo))) 
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
        public static List< StampTypeInfo> GetPagedList(int pPageIndex,int pPageSize,SortDirection pOrderBy,string pSortExpression,out int pRecordCount)
        {
			if(pPageIndex<=1)
			pPageIndex=1;
            List< StampTypeInfo> list = new List< StampTypeInfo>();
          
            Query q = StampType .CreateQuery();
            q.PageIndex = pPageIndex;
            q.PageSize = pPageSize;
            q.ORDER_BY(pSortExpression,pOrderBy.ToString());
			StampTypeCollection  collection=new  StampTypeCollection();
		 	collection.LoadAndCloseReader(q.ExecuteReader());
          
            foreach (StampType  stampType  in collection)
            {
                StampTypeInfo stampTypeInfo = new StampTypeInfo();
                LoadFromDAL(stampTypeInfo,   stampType);
                list.Add(stampTypeInfo);
            }
			pRecordCount=q.GetRecordCount();
			
            return list;

        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		/// <returns></returns>
		public static List< StampTypeInfo> GetList()
		{
			string cacheKey = GetCacheKey();
			//本实体已经注册成缓存实体，并且缓存存在的时候，直接从缓存取
			if (CachedEntityCommander.IsTypeRegistered(typeof(StampTypeInfo)) && CachedEntityCommander.GetCache(cacheKey) != null)
            {
                return CachedEntityCommander.GetCache(cacheKey) as List< StampTypeInfo>;
            }
            else 
            {
				List< StampTypeInfo>  list =new List< StampTypeInfo>();
				StampTypeCollection  collection=new  StampTypeCollection();
				Query qry = new Query(StampType.Schema);
				collection.LoadAndCloseReader(qry.ExecuteReader());
				foreach(StampType stampType in collection)
				{
					StampTypeInfo stampTypeInfo= new StampTypeInfo();
					LoadFromDAL(stampTypeInfo,stampType);
					list.Add(stampTypeInfo);
				}
			  	//生成缓存
                if (CachedEntityCommander.IsTypeRegistered(typeof(StampTypeInfo))) 
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
		public int StampTypeId
		{
			get {return stampTypeId;}
			set {stampTypeId = value;}
		}

		///<summary>
		///
		///</summary>
		public string StampName
		{
			get {return stampName;}
			set {stampName = value;}
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
			bool result=  (StampType.Delete(StampTypeId) == 1);
			//更新缓存
			if (result&&CachedEntityCommander.IsTypeRegistered(typeof(StampTypeInfo))) 
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
        public void CopyTo(StampTypeInfo pStampTypeInfoTo)
        {
            Copy(this,  pStampTypeInfoTo);
        }
		
		
		
		
		
		/// <summary>
		/// 保存
		/// </summary>
		public override void Save()
		{
			if(!m_Loaded)//新增
			{
				StampType stampType=new StampType();	
				SaveToDb(this, stampType,true);
			}
			else//修改
			{
				StampType stampType=new StampType(stampTypeId);	
				if(stampType.IsNew)
					throw new AppException("该数据已经不存在了");
				SaveToDb(this, stampType,false);
			}
			
		}
		 
		#endregion
		
	}
}
