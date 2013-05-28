// ======================================================================================================================================
// 类说明
//=======================================================================================================================================
// 创建者：sk @Copy Right 残友软件有限公司OA项目 
// 文件名：StampInfo.cs
// 创建时间：2012-9-12
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
	///StampInfo  Data
	/// </summary>
	[Serializable]
	public partial class StampInfo:CanYou.EntityObject
	{
		#region 属性
		///<summary>
		///
		///</summary>
		private int stampId;
		///<summary>
		///
		///</summary>
		private string useDate = String.Empty;
		///<summary>
		///
		///</summary>
		private int? stampFileTypeId;
		///<summary>
		///
		///</summary>
		private int? stampTypeId;
		///<summary>
		///
		///</summary>
		private string stampuse = String.Empty;
		///<summary>
		///
		///</summary>
		private string memo = String.Empty;
		///<summary>
		///
		///</summary>
		private string applyName = String.Empty;
		///<summary>
		///
		///</summary>
		private string departName = String.Empty;
		///<summary>
		///
		///</summary>
		private int? state;
		///<summary>
		///
		///</summary>
		private string applyTime = String.Empty;
		
		
		///一对多关系,如果
		private bool m_Loaded=false;
		#endregion
		
		#region 属性枚举
		public struct Fields
		{
			public const string StampId=@"StampId";
			public const string UseDate=@"UseDate";
			public const string StampFileTypeId=@"StampFileTypeId";
			public const string StampTypeId=@"StampTypeId";
			public const string Stampuse=@"Stampuse";
			public const string Memo=@"Memo";
			public const string ApplyName=@"ApplyName";
			public const string DepartName=@"DepartName";
			public const string State=@"State";
			public const string ApplyTime=@"ApplyTime";
						
		}

		#endregion
		
		
		#region 构造函数
		///<summary>
		///
		///</summary>
		public StampInfo()
		{
		}
		///<summary>
		///
		///</summary>
		public StampInfo(int pStampId,string pUseDate,int? pStampFileTypeId,int? pStampTypeId,string pStampuse,string pMemo,string pApplyName,string pDepartName,int? pState,string pApplyTime)
		{
			stampId         = pStampId;
			useDate         = pUseDate;
			stampFileTypeId = pStampFileTypeId;
			stampTypeId     = pStampTypeId;
			stampuse        = pStampuse;
			memo            = pMemo;
			applyName       = pApplyName;
			departName      = pDepartName;
			state           = pState;
			applyTime       = pApplyTime;
			
		}
		
		
		///<summary>
		///
		///</summary>
		public StampInfo(int stampId)
		{
			 LoadFromId(stampId);
		}
		
		private void LoadFromId(int stampId)
		{
		 
			if (CachedEntityCommander.IsTypeRegistered(typeof(StampInfo)))
            {
				StampInfo stampInfo=Find(GetList(), stampId);
				if(stampInfo==null)
					throw new AppException("未能在缓存中找到相应的键值对象");
                Copy(stampInfo, this);
            }
            else
            {	Stamp stamp=new Stamp( stampId);	
				if(stamp.IsNew)
				throw new AppException("尚未初始化");
               	LoadFromDAL(this, stamp);
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
        public static  StampInfo Find(List< StampInfo> list,  int stampId)
        {
             return list.Find(delegate( StampInfo item) { return item. stampId==stampId; });
        }
		
		
		/// <summary>
        /// 得到缓存键
        /// </summary>
        /// <returns></returns>
        private static string GetCacheKey()
        {
            return string.Format(CachedEntityCommander.CacheKey, typeof( StampInfo).ToString());
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
        public static void Copy(StampInfo pStampInfoFrom, StampInfo pStampInfoTo)
        {
	 		pStampInfoTo.StampId = pStampInfoFrom.stampId;
	 		pStampInfoTo.UseDate = pStampInfoFrom.useDate;
	 		pStampInfoTo.StampFileTypeId = pStampInfoFrom.stampFileTypeId;
	 		pStampInfoTo.StampTypeId = pStampInfoFrom.stampTypeId;
	 		pStampInfoTo.Stampuse = pStampInfoFrom.stampuse;
	 		pStampInfoTo.Memo = pStampInfoFrom.memo;
	 		pStampInfoTo.ApplyName = pStampInfoFrom.applyName;
	 		pStampInfoTo.DepartName = pStampInfoFrom.departName;
	 		pStampInfoTo.State = pStampInfoFrom.state;
	 		pStampInfoTo.ApplyTime = pStampInfoFrom.applyTime;
			pStampInfoTo.Loaded=pStampInfoFrom.Loaded;
        }
		
		/// <summary>
		/// 批量装载
		/// </summary>
		internal static void LoadFromDALPatch(List< StampInfo> pList, StampCollection pCollection)
        {
            foreach (Stamp stamp in pCollection)
            {
                StampInfo stampInfo = new StampInfo();
                LoadFromDAL(stampInfo, stamp );
                pList.Add(stampInfo);
            }
			
        }

		//从后台获取数据
		internal  static void  LoadFromDAL(StampInfo pStampInfo, Stamp  pStamp)
		{
	 		pStampInfo.stampId = pStamp.StampId;
	 		pStampInfo.useDate = pStamp.UseDate;
	 		pStampInfo.stampFileTypeId = pStamp.StampFileTypeId;
	 		pStampInfo.stampTypeId = pStamp.StampTypeId;
	 		pStampInfo.stampuse = pStamp.Stampuse;
	 		pStampInfo.memo = pStamp.Memo;
	 		pStampInfo.applyName = pStamp.ApplyName;
	 		pStampInfo.departName = pStamp.DepartName;
	 		pStampInfo.state = pStamp.State;
	 		pStampInfo.applyTime = pStamp.ApplyTime;
			pStampInfo.Loaded=true;
			
			}
		
		//数据持久化
		internal  static void  SaveToDb(StampInfo pStampInfo, Stamp  pStamp,bool pIsNew)
		{
	 		pStamp.StampId = pStampInfo.stampId;
	 		pStamp.UseDate = pStampInfo.useDate;
	 		pStamp.StampFileTypeId = pStampInfo.stampFileTypeId;
	 		pStamp.StampTypeId = pStampInfo.stampTypeId;
	 		pStamp.Stampuse = pStampInfo.stampuse;
	 		pStamp.Memo = pStampInfo.memo;
	 		pStamp.ApplyName = pStampInfo.applyName;
	 		pStamp.DepartName = pStampInfo.departName;
	 		pStamp.State = pStampInfo.state;
	 		pStamp.ApplyTime = pStampInfo.applyTime;
			pStamp.IsNew=pIsNew;
			string UserName = SubsonicHelper.GetUserName();
			try
			{
				pStamp.Save(UserName);
			}
			catch(Exception ex)
			{
				LogManager.getInstance().getLogger(typeof(StampInfo)).Error(ex);
				if(ex.Message.Contains("插入重复键"))//违反了唯一键
				{
					throw new AppException("此对象已经存在");//此处等待优化可以从唯一约束中直接取出提示来，如果没有的话，默认为原始的出错提示
				}
				throw new AppException("保存失败");
			}
			pStampInfo.stampId = pStamp.StampId;
			//如果缓存存在，更新缓存
			if (CachedEntityCommander.IsTypeRegistered(typeof(StampInfo))) 
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
        public static List< StampInfo> GetPagedList(int pPageIndex,int pPageSize,SortDirection pOrderBy,string pSortExpression,out int pRecordCount)
        {
			if(pPageIndex<=1)
			pPageIndex=1;
            List< StampInfo> list = new List< StampInfo>();
          
            Query q = Stamp .CreateQuery();
            q.PageIndex = pPageIndex;
            q.PageSize = pPageSize;
            q.ORDER_BY(pSortExpression,pOrderBy.ToString());
			StampCollection  collection=new  StampCollection();
		 	collection.LoadAndCloseReader(q.ExecuteReader());
          
            foreach (Stamp  stamp  in collection)
            {
                StampInfo stampInfo = new StampInfo();
                LoadFromDAL(stampInfo,   stamp);
                list.Add(stampInfo);
            }
			pRecordCount=q.GetRecordCount();
			
            return list;

        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		/// <returns></returns>
		public static List< StampInfo> GetList()
		{
			string cacheKey = GetCacheKey();
			//本实体已经注册成缓存实体，并且缓存存在的时候，直接从缓存取
			if (CachedEntityCommander.IsTypeRegistered(typeof(StampInfo)) && CachedEntityCommander.GetCache(cacheKey) != null)
            {
                return CachedEntityCommander.GetCache(cacheKey) as List< StampInfo>;
            }
            else 
            {
				List< StampInfo>  list =new List< StampInfo>();
				StampCollection  collection=new  StampCollection();
				Query qry = new Query(Stamp.Schema);
				collection.LoadAndCloseReader(qry.ExecuteReader());
				foreach(Stamp stamp in collection)
				{
					StampInfo stampInfo= new StampInfo();
					LoadFromDAL(stampInfo,stamp);
					list.Add(stampInfo);
				}
			  	//生成缓存
                if (CachedEntityCommander.IsTypeRegistered(typeof(StampInfo))) 
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
		public int StampId
		{
			get {return stampId;}
			set {stampId = value;}
		}

		///<summary>
		///
		///</summary>
		public string UseDate
		{
			get {return useDate;}
			set {useDate = value;}
		}

		///<summary>
		///
		///</summary>
		public int? StampFileTypeId
		{
			get {return stampFileTypeId;}
			set {stampFileTypeId = value;}
		}

		///<summary>
		///
		///</summary>
		public int? StampTypeId
		{
			get {return stampTypeId;}
			set {stampTypeId = value;}
		}

		///<summary>
		///
		///</summary>
		public string Stampuse
		{
			get {return stampuse;}
			set {stampuse = value;}
		}

		///<summary>
		///
		///</summary>
		public string Memo
		{
			get {return memo;}
			set {memo = value;}
		}

		///<summary>
		///
		///</summary>
		public string ApplyName
		{
			get {return applyName;}
			set {applyName = value;}
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
		public int? State
		{
			get {return state;}
			set {state = value;}
		}

		///<summary>
		///
		///</summary>
		public string ApplyTime
		{
			get {return applyTime;}
			set {applyTime = value;}
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
			bool result=  (Stamp.Delete(StampId) == 1);
			//更新缓存
			if (result&&CachedEntityCommander.IsTypeRegistered(typeof(StampInfo))) 
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
        public void CopyTo(StampInfo pStampInfoTo)
        {
            Copy(this,  pStampInfoTo);
        }
		
		
		
		
		
		/// <summary>
		/// 保存
		/// </summary>
		public override void Save()
		{
			if(!m_Loaded)//新增
			{
				Stamp stamp=new Stamp();	
				SaveToDb(this, stamp,true);
			}
			else//修改
			{
				Stamp stamp=new Stamp(stampId);	
				if(stamp.IsNew)
					throw new AppException("该数据已经不存在了");
				SaveToDb(this, stamp,false);
			}
			
		}
		 
		#endregion
		
	}
}
