// ======================================================================================================================================
// 类说明
//=======================================================================================================================================
// 创建者：sk @Copy Right 残友软件有限公司OA项目 
// 文件名：DayInfo.cs
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
	///DayInfo  Data
	/// </summary>
	[Serializable]
	public partial class DayInfo:CanYou.EntityObject
	{
		#region 属性
		///<summary>
		///
		///</summary>
		private int dayId;
		///<summary>
		///
		///</summary>
		private int weekId;
		///<summary>
		///
		///</summary>
		private string workContent = String.Empty;
		///<summary>
		///
		///</summary>
		private DateTime? workDate;
		///<summary>
		///
		///</summary>
		private string result = String.Empty;
		///<summary>
		///
		///</summary>
		private int weekSumId;
		
		
		///一对多关系,如果
		private bool m_Loaded=false;
		#endregion
		
		#region 属性枚举
		public struct Fields
		{
			public const string DayId=@"DayId";
			public const string WeekId=@"WeekId";
			public const string WorkContent=@"WorkContent";
			public const string WorkDate=@"WorkDate";
			public const string Result=@"Result";
			public const string WeekSumId=@"WeekSumId";
						
		}

		#endregion
		
		
		#region 构造函数
		///<summary>
		///
		///</summary>
		public DayInfo()
		{
		}
		///<summary>
		///
		///</summary>
		public DayInfo(int pDayId,int pWeekId,string pWorkContent,DateTime? pWorkDate,string pResult,int pWeekSumId)
		{
			dayId       = pDayId;
			weekId      = pWeekId;
			workContent = pWorkContent;
			workDate    = pWorkDate;
			result      = pResult;
			weekSumId   = pWeekSumId;
			
		}
		
		
		///<summary>
		///
		///</summary>
		public DayInfo(int dayId)
		{
			 LoadFromId(dayId);
		}
		
		private void LoadFromId(int dayId)
		{
		 
			if (CachedEntityCommander.IsTypeRegistered(typeof(DayInfo)))
            {
				DayInfo dayInfo=Find(GetList(), dayId);
				if(dayInfo==null)
					throw new AppException("未能在缓存中找到相应的键值对象");
                Copy(dayInfo, this);
            }
            else
            {	Day day=new Day( dayId);	
				if(day.IsNew)
				throw new AppException("尚未初始化");
               	LoadFromDAL(this, day);
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
        public static  DayInfo Find(List< DayInfo> list,  int dayId)
        {
             return list.Find(delegate( DayInfo item) { return item. dayId==dayId; });
        }
		
		
		/// <summary>
        /// 得到缓存键
        /// </summary>
        /// <returns></returns>
        private static string GetCacheKey()
        {
            return string.Format(CachedEntityCommander.CacheKey, typeof( DayInfo).ToString());
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
        public static void Copy(DayInfo pDayInfoFrom, DayInfo pDayInfoTo)
        {
	 		pDayInfoTo.DayId = pDayInfoFrom.dayId;
	 		pDayInfoTo.WeekId = pDayInfoFrom.weekId;
	 		pDayInfoTo.WorkContent = pDayInfoFrom.workContent;
	 		pDayInfoTo.WorkDate = pDayInfoFrom.workDate;
	 		pDayInfoTo.Result = pDayInfoFrom.result;
	 		pDayInfoTo.WeekSumId = pDayInfoFrom.weekSumId;
			pDayInfoTo.Loaded=pDayInfoFrom.Loaded;
        }
		
		/// <summary>
		/// 批量装载
		/// </summary>
		internal static void LoadFromDALPatch(List< DayInfo> pList, DayCollection pCollection)
        {
            foreach (Day day in pCollection)
            {
                DayInfo dayInfo = new DayInfo();
                LoadFromDAL(dayInfo, day );
                pList.Add(dayInfo);
            }
			
        }

		//从后台获取数据
		internal  static void  LoadFromDAL(DayInfo pDayInfo, Day  pDay)
		{
	 		pDayInfo.dayId = pDay.DayId;
	 		pDayInfo.weekId = pDay.WeekId;
	 		pDayInfo.workContent = pDay.WorkContent;
	 		pDayInfo.workDate = pDay.WorkDate;
	 		pDayInfo.result = pDay.Result;
	 		pDayInfo.weekSumId = pDay.WeekSumId;
			pDayInfo.Loaded=true;
			
			}
		
		//数据持久化
		internal  static void  SaveToDb(DayInfo pDayInfo, Day  pDay,bool pIsNew)
		{
	 		pDay.DayId = pDayInfo.dayId;
	 		pDay.WeekId = pDayInfo.weekId;
	 		pDay.WorkContent = pDayInfo.workContent;
	 		pDay.WorkDate = pDayInfo.workDate;
	 		pDay.Result = pDayInfo.result;
	 		pDay.WeekSumId = pDayInfo.weekSumId;
			pDay.IsNew=pIsNew;
			string UserName = SubsonicHelper.GetUserName();
			try
			{
				pDay.Save(UserName);
			}
			catch(Exception ex)
			{
				LogManager.getInstance().getLogger(typeof(DayInfo)).Error(ex);
				if(ex.Message.Contains("插入重复键"))//违反了唯一键
				{
					throw new AppException("此对象已经存在");//此处等待优化可以从唯一约束中直接取出提示来，如果没有的话，默认为原始的出错提示
				}
				throw new AppException("保存失败");
			}
			pDayInfo.dayId = pDay.DayId;
			//如果缓存存在，更新缓存
			if (CachedEntityCommander.IsTypeRegistered(typeof(DayInfo))) 
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
        public static List< DayInfo> GetPagedList(int pPageIndex,int pPageSize,SortDirection pOrderBy,string pSortExpression,out int pRecordCount)
        {
			if(pPageIndex<=1)
			pPageIndex=1;
            List< DayInfo> list = new List< DayInfo>();
          
            Query q = Day .CreateQuery();
            q.PageIndex = pPageIndex;
            q.PageSize = pPageSize;
            q.ORDER_BY(pSortExpression,pOrderBy.ToString());
			DayCollection  collection=new  DayCollection();
		 	collection.LoadAndCloseReader(q.ExecuteReader());
          
            foreach (Day  day  in collection)
            {
                DayInfo dayInfo = new DayInfo();
                LoadFromDAL(dayInfo,   day);
                list.Add(dayInfo);
            }
			pRecordCount=q.GetRecordCount();
			
            return list;

        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		/// <returns></returns>
		public static List< DayInfo> GetList()
		{
			string cacheKey = GetCacheKey();
			//本实体已经注册成缓存实体，并且缓存存在的时候，直接从缓存取
			if (CachedEntityCommander.IsTypeRegistered(typeof(DayInfo)) && CachedEntityCommander.GetCache(cacheKey) != null)
            {
                return CachedEntityCommander.GetCache(cacheKey) as List< DayInfo>;
            }
            else 
            {
				List< DayInfo>  list =new List< DayInfo>();
				DayCollection  collection=new  DayCollection();
				Query qry = new Query(Day.Schema);
				collection.LoadAndCloseReader(qry.ExecuteReader());
				foreach(Day day in collection)
				{
					DayInfo dayInfo= new DayInfo();
					LoadFromDAL(dayInfo,day);
					list.Add(dayInfo);
				}
			  	//生成缓存
                if (CachedEntityCommander.IsTypeRegistered(typeof(DayInfo))) 
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
		public int DayId
		{
			get {return dayId;}
			set {dayId = value;}
		}

		///<summary>
		///
		///</summary>
		public int WeekId
		{
			get {return weekId;}
			set {weekId = value;}
		}

		///<summary>
		///
		///</summary>
		public string WorkContent
		{
			get {return workContent;}
			set {workContent = value;}
		}

		///<summary>
		///
		///</summary>
		public DateTime? WorkDate
		{
			get {return workDate;}
			set {workDate = value;}
		}

		///<summary>
		///
		///</summary>
		public string Result
		{
			get {return result;}
			set {result = value;}
		}

		///<summary>
		///
		///</summary>
		public int WeekSumId
		{
			get {return weekSumId;}
			set {weekSumId = value;}
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
			bool result=  (Day.Delete(DayId) == 1);
			//更新缓存
			if (result&&CachedEntityCommander.IsTypeRegistered(typeof(DayInfo))) 
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
        public void CopyTo(DayInfo pDayInfoTo)
        {
            Copy(this,  pDayInfoTo);
        }
		
		
		
		
		
		/// <summary>
		/// 保存
		/// </summary>
		public override void Save()
		{
			if(!m_Loaded)//新增
			{
				Day day=new Day();	
				SaveToDb(this, day,true);
			}
			else//修改
			{
				Day day=new Day(dayId);	
				if(day.IsNew)
					throw new AppException("该数据已经不存在了");
				SaveToDb(this, day,false);
			}
			
		}
		 
		#endregion
		
	}
}
