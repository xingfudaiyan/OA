// ======================================================================================================================================
// 类说明
//=======================================================================================================================================
// 创建者：sk @Copy Right 残友软件有限公司OA项目 
// 文件名：OverTimeInfo.cs
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
	///OverTimeInfo  Data
	/// </summary>
	[Serializable]
	public partial class OverTimeInfo:CanYou.EntityObject
	{
		#region 属性
		///<summary>
		///
		///</summary>
		private int overTimeId;
		///<summary>
		///
		///</summary>
		private string applyDate = String.Empty;
		///<summary>
		///
		///</summary>
		private string timeFrom = String.Empty;
		///<summary>
		///
		///</summary>
		private string timeTo = String.Empty;
		///<summary>
		///
		///</summary>
		private string applyEmName = String.Empty;
		///<summary>
		///
		///</summary>
		private string reason = String.Empty;
		///<summary>
		///
		///</summary>
		private string isSubmit = String.Empty;
		///<summary>
		///
		///</summary>
		private string timeSpan = String.Empty;
		
		
		///一对多关系,如果
		private bool m_Loaded=false;
		#endregion
		
		#region 属性枚举
		public struct Fields
		{
			public const string OverTimeId=@"OverTimeId";
			public const string ApplyDate=@"ApplyDate";
			public const string TimeFrom=@"TimeFrom";
			public const string TimeTo=@"TimeTo";
			public const string ApplyEmName=@"ApplyEmName";
			public const string Reason=@"Reason";
			public const string IsSubmit=@"IsSubmit";
			public const string TimeSpan=@"TimeSpan";
						
		}

		#endregion
		
		
		#region 构造函数
		///<summary>
		///
		///</summary>
		public OverTimeInfo()
		{
		}
		///<summary>
		///
		///</summary>
		public OverTimeInfo(int pOverTimeId,string pApplyDate,string pTimeFrom,string pTimeTo,string pApplyEmName,string pReason,string pIsSubmit,string pTimeSpan)
		{
			overTimeId  = pOverTimeId;
			applyDate   = pApplyDate;
			timeFrom    = pTimeFrom;
			timeTo      = pTimeTo;
			applyEmName = pApplyEmName;
			reason      = pReason;
			isSubmit    = pIsSubmit;
			timeSpan    = pTimeSpan;
			
		}
		
		
		///<summary>
		///
		///</summary>
		public OverTimeInfo(int overTimeId)
		{
			 LoadFromId(overTimeId);
		}
		
		private void LoadFromId(int overTimeId)
		{
		 
			if (CachedEntityCommander.IsTypeRegistered(typeof(OverTimeInfo)))
            {
				OverTimeInfo overTimeInfo=Find(GetList(), overTimeId);
				if(overTimeInfo==null)
					throw new AppException("未能在缓存中找到相应的键值对象");
                Copy(overTimeInfo, this);
            }
            else
            {	OverTime overTime=new OverTime( overTimeId);	
				if(overTime.IsNew)
				throw new AppException("尚未初始化");
               	LoadFromDAL(this, overTime);
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
        public static  OverTimeInfo Find(List< OverTimeInfo> list,  int overTimeId)
        {
             return list.Find(delegate( OverTimeInfo item) { return item. overTimeId==overTimeId; });
        }
		
		
		/// <summary>
        /// 得到缓存键
        /// </summary>
        /// <returns></returns>
        private static string GetCacheKey()
        {
            return string.Format(CachedEntityCommander.CacheKey, typeof( OverTimeInfo).ToString());
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
        public static void Copy(OverTimeInfo pOverTimeInfoFrom, OverTimeInfo pOverTimeInfoTo)
        {
	 		pOverTimeInfoTo.OverTimeId = pOverTimeInfoFrom.overTimeId;
	 		pOverTimeInfoTo.ApplyDate = pOverTimeInfoFrom.applyDate;
	 		pOverTimeInfoTo.TimeFrom = pOverTimeInfoFrom.timeFrom;
	 		pOverTimeInfoTo.TimeTo = pOverTimeInfoFrom.timeTo;
	 		pOverTimeInfoTo.ApplyEmName = pOverTimeInfoFrom.applyEmName;
	 		pOverTimeInfoTo.Reason = pOverTimeInfoFrom.reason;
	 		pOverTimeInfoTo.IsSubmit = pOverTimeInfoFrom.isSubmit;
	 		pOverTimeInfoTo.TimeSpan = pOverTimeInfoFrom.timeSpan;
			pOverTimeInfoTo.Loaded=pOverTimeInfoFrom.Loaded;
        }
		
		/// <summary>
		/// 批量装载
		/// </summary>
		internal static void LoadFromDALPatch(List< OverTimeInfo> pList, OverTimeCollection pCollection)
        {
            foreach (OverTime overTime in pCollection)
            {
                OverTimeInfo overTimeInfo = new OverTimeInfo();
                LoadFromDAL(overTimeInfo, overTime );
                pList.Add(overTimeInfo);
            }
			
        }

		//从后台获取数据
		internal  static void  LoadFromDAL(OverTimeInfo pOverTimeInfo, OverTime  pOverTime)
		{
	 		pOverTimeInfo.overTimeId = pOverTime.OverTimeId;
	 		pOverTimeInfo.applyDate = pOverTime.ApplyDate;
	 		pOverTimeInfo.timeFrom = pOverTime.TimeFrom;
	 		pOverTimeInfo.timeTo = pOverTime.TimeTo;
	 		pOverTimeInfo.applyEmName = pOverTime.ApplyEmName;
	 		pOverTimeInfo.reason = pOverTime.Reason;
	 		pOverTimeInfo.isSubmit = pOverTime.IsSubmit;
	 		pOverTimeInfo.timeSpan = pOverTime.TimeSpan;
			pOverTimeInfo.Loaded=true;
			
			}
		
		//数据持久化
		internal  static void  SaveToDb(OverTimeInfo pOverTimeInfo, OverTime  pOverTime,bool pIsNew)
		{
	 		pOverTime.OverTimeId = pOverTimeInfo.overTimeId;
	 		pOverTime.ApplyDate = pOverTimeInfo.applyDate;
	 		pOverTime.TimeFrom = pOverTimeInfo.timeFrom;
	 		pOverTime.TimeTo = pOverTimeInfo.timeTo;
	 		pOverTime.ApplyEmName = pOverTimeInfo.applyEmName;
	 		pOverTime.Reason = pOverTimeInfo.reason;
	 		pOverTime.IsSubmit = pOverTimeInfo.isSubmit;
	 		pOverTime.TimeSpan = pOverTimeInfo.timeSpan;
			pOverTime.IsNew=pIsNew;
			string UserName = SubsonicHelper.GetUserName();
			try
			{
				pOverTime.Save(UserName);
			}
			catch(Exception ex)
			{
				LogManager.getInstance().getLogger(typeof(OverTimeInfo)).Error(ex);
				if(ex.Message.Contains("插入重复键"))//违反了唯一键
				{
					throw new AppException("此对象已经存在");//此处等待优化可以从唯一约束中直接取出提示来，如果没有的话，默认为原始的出错提示
				}
				throw new AppException("保存失败");
			}
			pOverTimeInfo.overTimeId = pOverTime.OverTimeId;
			//如果缓存存在，更新缓存
			if (CachedEntityCommander.IsTypeRegistered(typeof(OverTimeInfo))) 
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
        public static List< OverTimeInfo> GetPagedList(int pPageIndex,int pPageSize,SortDirection pOrderBy,string pSortExpression,out int pRecordCount)
        {
			if(pPageIndex<=1)
			pPageIndex=1;
            List< OverTimeInfo> list = new List< OverTimeInfo>();
          
            Query q = OverTime .CreateQuery();
            q.PageIndex = pPageIndex;
            q.PageSize = pPageSize;
            q.ORDER_BY(pSortExpression,pOrderBy.ToString());
			OverTimeCollection  collection=new  OverTimeCollection();
		 	collection.LoadAndCloseReader(q.ExecuteReader());
          
            foreach (OverTime  overTime  in collection)
            {
                OverTimeInfo overTimeInfo = new OverTimeInfo();
                LoadFromDAL(overTimeInfo,   overTime);
                list.Add(overTimeInfo);
            }
			pRecordCount=q.GetRecordCount();
			
            return list;

        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		/// <returns></returns>
		public static List< OverTimeInfo> GetList()
		{
			string cacheKey = GetCacheKey();
			//本实体已经注册成缓存实体，并且缓存存在的时候，直接从缓存取
			if (CachedEntityCommander.IsTypeRegistered(typeof(OverTimeInfo)) && CachedEntityCommander.GetCache(cacheKey) != null)
            {
                return CachedEntityCommander.GetCache(cacheKey) as List< OverTimeInfo>;
            }
            else 
            {
				List< OverTimeInfo>  list =new List< OverTimeInfo>();
				OverTimeCollection  collection=new  OverTimeCollection();
				Query qry = new Query(OverTime.Schema);
				collection.LoadAndCloseReader(qry.ExecuteReader());
				foreach(OverTime overTime in collection)
				{
					OverTimeInfo overTimeInfo= new OverTimeInfo();
					LoadFromDAL(overTimeInfo,overTime);
					list.Add(overTimeInfo);
				}
			  	//生成缓存
                if (CachedEntityCommander.IsTypeRegistered(typeof(OverTimeInfo))) 
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
		public int OverTimeId
		{
			get {return overTimeId;}
			set {overTimeId = value;}
		}

		///<summary>
		///
		///</summary>
		public string ApplyDate
		{
			get {return applyDate;}
			set {applyDate = value;}
		}

		///<summary>
		///
		///</summary>
		public string TimeFrom
		{
			get {return timeFrom;}
			set {timeFrom = value;}
		}

		///<summary>
		///
		///</summary>
		public string TimeTo
		{
			get {return timeTo;}
			set {timeTo = value;}
		}

		///<summary>
		///
		///</summary>
		public string ApplyEmName
		{
			get {return applyEmName;}
			set {applyEmName = value;}
		}

		///<summary>
		///
		///</summary>
		public string Reason
		{
			get {return reason;}
			set {reason = value;}
		}

		///<summary>
		///
		///</summary>
		public string IsSubmit
		{
			get {return isSubmit;}
			set {isSubmit = value;}
		}

		///<summary>
		///
		///</summary>
		public string TimeSpan
		{
			get {return timeSpan;}
			set {timeSpan = value;}
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
			bool result=  (OverTime.Delete(OverTimeId) == 1);
			//更新缓存
			if (result&&CachedEntityCommander.IsTypeRegistered(typeof(OverTimeInfo))) 
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
        public void CopyTo(OverTimeInfo pOverTimeInfoTo)
        {
            Copy(this,  pOverTimeInfoTo);
        }
		
		
		
		
		
		/// <summary>
		/// 保存
		/// </summary>
		public override void Save()
		{
			if(!m_Loaded)//新增
			{
				OverTime overTime=new OverTime();	
				SaveToDb(this, overTime,true);
			}
			else//修改
			{
				OverTime overTime=new OverTime(overTimeId);	
				if(overTime.IsNew)
					throw new AppException("该数据已经不存在了");
				SaveToDb(this, overTime,false);
			}
			
		}
		 
		#endregion
		
	}
}
