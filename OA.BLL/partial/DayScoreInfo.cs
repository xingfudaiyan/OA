// ======================================================================================================================================
// 类说明
//=======================================================================================================================================
// 创建者：sk @Copy Right 残友软件有限公司OA项目 
// 文件名：DayScoreInfo.cs
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
	///DayScoreInfo  Data
	/// </summary>
	[Serializable]
	public partial class DayScoreInfo:CanYou.EntityObject
	{
		#region 属性
		///<summary>
		///
		///</summary>
		private int dayScoreId;
		///<summary>
		///
		///</summary>
		private string today = String.Empty;
		///<summary>
		///
		///</summary>
		private string item = String.Empty;
		///<summary>
		///
		///</summary>
		private string finishTime = String.Empty;
		///<summary>
		///
		///</summary>
		private string roles = String.Empty;
		///<summary>
		///
		///</summary>
		private string timeSpan = String.Empty;
		///<summary>
		///
		///</summary>
		private string memo = String.Empty;
		///<summary>
		///
		///</summary>
		private string score = String.Empty;
		///<summary>
		///
		///</summary>
		private int? weekScoreId;
		///<summary>
		///
		///</summary>
		private int? dayRoleId;
		
		
		///一对多关系,如果
		private bool m_Loaded=false;
		#endregion
		
		#region 属性枚举
		public struct Fields
		{
			public const string DayScoreId=@"DayScoreId";
			public const string Today=@"Today";
			public const string Item=@"Item";
			public const string FinishTime=@"FinishTime";
			public const string Roles=@"Roles";
			public const string TimeSpan=@"TimeSpan";
			public const string Memo=@"Memo";
			public const string Score=@"Score";
			public const string WeekScoreId=@"WeekScoreId";
			public const string DayRoleId=@"DayRoleId";
						
		}

		#endregion
		
		
		#region 构造函数
		///<summary>
		///
		///</summary>
		public DayScoreInfo()
		{
		}
		///<summary>
		///
		///</summary>
		public DayScoreInfo(int pDayScoreId,string pToday,string pItem,string pFinishTime,string pRoles,string pTimeSpan,string pMemo,string pScore,int? pWeekScoreId,int? pDayRoleId)
		{
			dayScoreId  = pDayScoreId;
			today       = pToday;
			item        = pItem;
			finishTime  = pFinishTime;
			roles       = pRoles;
			timeSpan    = pTimeSpan;
			memo        = pMemo;
			score       = pScore;
			weekScoreId = pWeekScoreId;
			dayRoleId   = pDayRoleId;
			
		}
		
		
		///<summary>
		///
		///</summary>
		public DayScoreInfo(int dayScoreId)
		{
			 LoadFromId(dayScoreId);
		}
		
		private void LoadFromId(int dayScoreId)
		{
		 
			if (CachedEntityCommander.IsTypeRegistered(typeof(DayScoreInfo)))
            {
				DayScoreInfo dayScoreInfo=Find(GetList(), dayScoreId);
				if(dayScoreInfo==null)
					throw new AppException("未能在缓存中找到相应的键值对象");
                Copy(dayScoreInfo, this);
            }
            else
            {	DayScore dayScore=new DayScore( dayScoreId);	
				if(dayScore.IsNew)
				throw new AppException("尚未初始化");
               	LoadFromDAL(this, dayScore);
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
        public static  DayScoreInfo Find(List< DayScoreInfo> list,  int dayScoreId)
        {
             return list.Find(delegate( DayScoreInfo item) { return item. dayScoreId==dayScoreId; });
        }
		
		
		/// <summary>
        /// 得到缓存键
        /// </summary>
        /// <returns></returns>
        private static string GetCacheKey()
        {
            return string.Format(CachedEntityCommander.CacheKey, typeof( DayScoreInfo).ToString());
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
        public static void Copy(DayScoreInfo pDayScoreInfoFrom, DayScoreInfo pDayScoreInfoTo)
        {
	 		pDayScoreInfoTo.DayScoreId = pDayScoreInfoFrom.dayScoreId;
	 		pDayScoreInfoTo.Today = pDayScoreInfoFrom.today;
	 		pDayScoreInfoTo.Item = pDayScoreInfoFrom.item;
	 		pDayScoreInfoTo.FinishTime = pDayScoreInfoFrom.finishTime;
	 		pDayScoreInfoTo.Roles = pDayScoreInfoFrom.roles;
	 		pDayScoreInfoTo.TimeSpan = pDayScoreInfoFrom.timeSpan;
	 		pDayScoreInfoTo.Memo = pDayScoreInfoFrom.memo;
	 		pDayScoreInfoTo.Score = pDayScoreInfoFrom.score;
	 		pDayScoreInfoTo.WeekScoreId = pDayScoreInfoFrom.weekScoreId;
	 		pDayScoreInfoTo.DayRoleId = pDayScoreInfoFrom.dayRoleId;
			pDayScoreInfoTo.Loaded=pDayScoreInfoFrom.Loaded;
        }
		
		/// <summary>
		/// 批量装载
		/// </summary>
		internal static void LoadFromDALPatch(List< DayScoreInfo> pList, DayScoreCollection pCollection)
        {
            foreach (DayScore dayScore in pCollection)
            {
                DayScoreInfo dayScoreInfo = new DayScoreInfo();
                LoadFromDAL(dayScoreInfo, dayScore );
                pList.Add(dayScoreInfo);
            }
			
        }

		//从后台获取数据
		internal  static void  LoadFromDAL(DayScoreInfo pDayScoreInfo, DayScore  pDayScore)
		{
	 		pDayScoreInfo.dayScoreId = pDayScore.DayScoreId;
	 		pDayScoreInfo.today = pDayScore.Today;
	 		pDayScoreInfo.item = pDayScore.Item;
	 		pDayScoreInfo.finishTime = pDayScore.FinishTime;
	 		pDayScoreInfo.roles = pDayScore.Roles;
	 		pDayScoreInfo.timeSpan = pDayScore.TimeSpan;
	 		pDayScoreInfo.memo = pDayScore.Memo;
	 		pDayScoreInfo.score = pDayScore.Score;
	 		pDayScoreInfo.weekScoreId = pDayScore.WeekScoreId;
	 		pDayScoreInfo.dayRoleId = pDayScore.DayRoleId;
			pDayScoreInfo.Loaded=true;
			
			}
		
		//数据持久化
		internal  static void  SaveToDb(DayScoreInfo pDayScoreInfo, DayScore  pDayScore,bool pIsNew)
		{
	 		pDayScore.DayScoreId = pDayScoreInfo.dayScoreId;
	 		pDayScore.Today = pDayScoreInfo.today;
	 		pDayScore.Item = pDayScoreInfo.item;
	 		pDayScore.FinishTime = pDayScoreInfo.finishTime;
	 		pDayScore.Roles = pDayScoreInfo.roles;
	 		pDayScore.TimeSpan = pDayScoreInfo.timeSpan;
	 		pDayScore.Memo = pDayScoreInfo.memo;
	 		pDayScore.Score = pDayScoreInfo.score;
	 		pDayScore.WeekScoreId = pDayScoreInfo.weekScoreId;
	 		pDayScore.DayRoleId = pDayScoreInfo.dayRoleId;
			pDayScore.IsNew=pIsNew;
			string UserName = SubsonicHelper.GetUserName();
			try
			{
				pDayScore.Save(UserName);
			}
			catch(Exception ex)
			{
				LogManager.getInstance().getLogger(typeof(DayScoreInfo)).Error(ex);
				if(ex.Message.Contains("插入重复键"))//违反了唯一键
				{
					throw new AppException("此对象已经存在");//此处等待优化可以从唯一约束中直接取出提示来，如果没有的话，默认为原始的出错提示
				}
				throw new AppException("保存失败");
			}
			pDayScoreInfo.dayScoreId = pDayScore.DayScoreId;
			//如果缓存存在，更新缓存
			if (CachedEntityCommander.IsTypeRegistered(typeof(DayScoreInfo))) 
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
        public static List< DayScoreInfo> GetPagedList(int pPageIndex,int pPageSize,SortDirection pOrderBy,string pSortExpression,out int pRecordCount)
        {
			if(pPageIndex<=1)
			pPageIndex=1;
            List< DayScoreInfo> list = new List< DayScoreInfo>();
          
            Query q = DayScore .CreateQuery();
            q.PageIndex = pPageIndex;
            q.PageSize = pPageSize;
            q.ORDER_BY(pSortExpression,pOrderBy.ToString());
			DayScoreCollection  collection=new  DayScoreCollection();
		 	collection.LoadAndCloseReader(q.ExecuteReader());
          
            foreach (DayScore  dayScore  in collection)
            {
                DayScoreInfo dayScoreInfo = new DayScoreInfo();
                LoadFromDAL(dayScoreInfo,   dayScore);
                list.Add(dayScoreInfo);
            }
			pRecordCount=q.GetRecordCount();
			
            return list;

        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		/// <returns></returns>
		public static List< DayScoreInfo> GetList()
		{
			string cacheKey = GetCacheKey();
			//本实体已经注册成缓存实体，并且缓存存在的时候，直接从缓存取
			if (CachedEntityCommander.IsTypeRegistered(typeof(DayScoreInfo)) && CachedEntityCommander.GetCache(cacheKey) != null)
            {
                return CachedEntityCommander.GetCache(cacheKey) as List< DayScoreInfo>;
            }
            else 
            {
				List< DayScoreInfo>  list =new List< DayScoreInfo>();
				DayScoreCollection  collection=new  DayScoreCollection();
				Query qry = new Query(DayScore.Schema);
				collection.LoadAndCloseReader(qry.ExecuteReader());
				foreach(DayScore dayScore in collection)
				{
					DayScoreInfo dayScoreInfo= new DayScoreInfo();
					LoadFromDAL(dayScoreInfo,dayScore);
					list.Add(dayScoreInfo);
				}
			  	//生成缓存
                if (CachedEntityCommander.IsTypeRegistered(typeof(DayScoreInfo))) 
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
		public int DayScoreId
		{
			get {return dayScoreId;}
			set {dayScoreId = value;}
		}

		///<summary>
		///
		///</summary>
		public string Today
		{
			get {return today;}
			set {today = value;}
		}

		///<summary>
		///
		///</summary>
		public string Item
		{
			get {return item;}
			set {item = value;}
		}

		///<summary>
		///
		///</summary>
		public string FinishTime
		{
			get {return finishTime;}
			set {finishTime = value;}
		}

		///<summary>
		///
		///</summary>
		public string Roles
		{
			get {return roles;}
			set {roles = value;}
		}

		///<summary>
		///
		///</summary>
		public string TimeSpan
		{
			get {return timeSpan;}
			set {timeSpan = value;}
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
		public string Score
		{
			get {return score;}
			set {score = value;}
		}

		///<summary>
		///
		///</summary>
		public int? WeekScoreId
		{
			get {return weekScoreId;}
			set {weekScoreId = value;}
		}

		///<summary>
		///
		///</summary>
		public int? DayRoleId
		{
			get {return dayRoleId;}
			set {dayRoleId = value;}
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
			bool result=  (DayScore.Delete(DayScoreId) == 1);
			//更新缓存
			if (result&&CachedEntityCommander.IsTypeRegistered(typeof(DayScoreInfo))) 
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
        public void CopyTo(DayScoreInfo pDayScoreInfoTo)
        {
            Copy(this,  pDayScoreInfoTo);
        }
		
		
		
		
		
		/// <summary>
		/// 保存
		/// </summary>
		public override void Save()
		{
			if(!m_Loaded)//新增
			{
				DayScore dayScore=new DayScore();	
				SaveToDb(this, dayScore,true);
			}
			else//修改
			{
				DayScore dayScore=new DayScore(dayScoreId);	
				if(dayScore.IsNew)
					throw new AppException("该数据已经不存在了");
				SaveToDb(this, dayScore,false);
			}
			
		}
		 
		#endregion
		
	}
}
