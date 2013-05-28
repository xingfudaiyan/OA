// ======================================================================================================================================
// 类说明
//=======================================================================================================================================
// 创建者：sk @Copy Right 残友软件有限公司OA项目 
// 文件名：WeekSumInfo.cs
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
	///WeekSumInfo  Data
	/// </summary>
	[Serializable]
	public partial class WeekSumInfo:CanYou.EntityObject
	{
		#region 属性
		///<summary>
		///
		///</summary>
		private int weekSumId;
		///<summary>
		///
		///</summary>
		private string weekSumName = String.Empty;
		///<summary>
		///
		///</summary>
		private int? isApprove;
		///<summary>
		///
		///</summary>
		private int? isApply;
		///<summary>
		///
		///</summary>
		private int? isSend;
		///<summary>
		///
		///</summary>
		private DateTime? applyTime;
		///<summary>
		///
		///</summary>
		private DateTime? repplyTime;
		///<summary>
		///
		///</summary>
		private string applyView = String.Empty;
		///<summary>
		///
		///</summary>
		private int? sendEmployeeId;
		///<summary>
		///
		///</summary>
		private int? recvEmployeeId;
		
		
		///一对多关系,如果
		private bool m_Loaded=false;
		#endregion
		
		#region 属性枚举
		public struct Fields
		{
			public const string WeekSumId=@"WeekSumId";
			public const string WeekSumName=@"WeekSumName";
			public const string IsApprove=@"IsApprove";
			public const string IsApply=@"IsApply";
			public const string IsSend=@"IsSend";
			public const string ApplyTime=@"ApplyTime";
			public const string RepplyTime=@"RepplyTime";
			public const string ApplyView=@"ApplyView";
			public const string SendEmployeeId=@"SendEmployeeId";
			public const string RecvEmployeeId=@"RecvEmployeeId";
						
		}

		#endregion
		
		
		#region 构造函数
		///<summary>
		///
		///</summary>
		public WeekSumInfo()
		{
		}
		///<summary>
		///
		///</summary>
		public WeekSumInfo(int pWeekSumId,string pWeekSumName,int? pIsApprove,int? pIsApply,int? pIsSend,DateTime? pApplyTime,DateTime? pRepplyTime,string pApplyView,int? pSendEmployeeId,int? pRecvEmployeeId)
		{
			weekSumId      = pWeekSumId;
			weekSumName    = pWeekSumName;
			isApprove      = pIsApprove;
			isApply        = pIsApply;
			isSend         = pIsSend;
			applyTime      = pApplyTime;
			repplyTime     = pRepplyTime;
			applyView      = pApplyView;
			sendEmployeeId = pSendEmployeeId;
			recvEmployeeId = pRecvEmployeeId;
			
		}
		
		
		///<summary>
		///
		///</summary>
		public WeekSumInfo(int weekSumId)
		{
			 LoadFromId(weekSumId);
		}
		
		private void LoadFromId(int weekSumId)
		{
		 
			if (CachedEntityCommander.IsTypeRegistered(typeof(WeekSumInfo)))
            {
				WeekSumInfo weekSumInfo=Find(GetList(), weekSumId);
				if(weekSumInfo==null)
					throw new AppException("未能在缓存中找到相应的键值对象");
                Copy(weekSumInfo, this);
            }
            else
            {	WeekSum weekSum=new WeekSum( weekSumId);	
				if(weekSum.IsNew)
				throw new AppException("尚未初始化");
               	LoadFromDAL(this, weekSum);
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
        public static  WeekSumInfo Find(List< WeekSumInfo> list,  int weekSumId)
        {
             return list.Find(delegate( WeekSumInfo item) { return item. weekSumId==weekSumId; });
        }
		
		
		/// <summary>
        /// 得到缓存键
        /// </summary>
        /// <returns></returns>
        private static string GetCacheKey()
        {
            return string.Format(CachedEntityCommander.CacheKey, typeof( WeekSumInfo).ToString());
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
        public static void Copy(WeekSumInfo pWeekSumInfoFrom, WeekSumInfo pWeekSumInfoTo)
        {
	 		pWeekSumInfoTo.WeekSumId = pWeekSumInfoFrom.weekSumId;
	 		pWeekSumInfoTo.WeekSumName = pWeekSumInfoFrom.weekSumName;
	 		pWeekSumInfoTo.IsApprove = pWeekSumInfoFrom.isApprove;
	 		pWeekSumInfoTo.IsApply = pWeekSumInfoFrom.isApply;
	 		pWeekSumInfoTo.IsSend = pWeekSumInfoFrom.isSend;
	 		pWeekSumInfoTo.ApplyTime = pWeekSumInfoFrom.applyTime;
	 		pWeekSumInfoTo.RepplyTime = pWeekSumInfoFrom.repplyTime;
	 		pWeekSumInfoTo.ApplyView = pWeekSumInfoFrom.applyView;
	 		pWeekSumInfoTo.SendEmployeeId = pWeekSumInfoFrom.sendEmployeeId;
	 		pWeekSumInfoTo.RecvEmployeeId = pWeekSumInfoFrom.recvEmployeeId;
			pWeekSumInfoTo.Loaded=pWeekSumInfoFrom.Loaded;
        }
		
		/// <summary>
		/// 批量装载
		/// </summary>
		internal static void LoadFromDALPatch(List< WeekSumInfo> pList, WeekSumCollection pCollection)
        {
            foreach (WeekSum weekSum in pCollection)
            {
                WeekSumInfo weekSumInfo = new WeekSumInfo();
                LoadFromDAL(weekSumInfo, weekSum );
                pList.Add(weekSumInfo);
            }
			
        }

		//从后台获取数据
		internal  static void  LoadFromDAL(WeekSumInfo pWeekSumInfo, WeekSum  pWeekSum)
		{
	 		pWeekSumInfo.weekSumId = pWeekSum.WeekSumId;
	 		pWeekSumInfo.weekSumName = pWeekSum.WeekSumName;
	 		pWeekSumInfo.isApprove = pWeekSum.IsApprove;
	 		pWeekSumInfo.isApply = pWeekSum.IsApply;
	 		pWeekSumInfo.isSend = pWeekSum.IsSend;
	 		pWeekSumInfo.applyTime = pWeekSum.ApplyTime;
	 		pWeekSumInfo.repplyTime = pWeekSum.RepplyTime;
	 		pWeekSumInfo.applyView = pWeekSum.ApplyView;
	 		pWeekSumInfo.sendEmployeeId = pWeekSum.SendEmployeeId;
	 		pWeekSumInfo.recvEmployeeId = pWeekSum.RecvEmployeeId;
			pWeekSumInfo.Loaded=true;
			
			}
		
		//数据持久化
		internal  static void  SaveToDb(WeekSumInfo pWeekSumInfo, WeekSum  pWeekSum,bool pIsNew)
		{
	 		pWeekSum.WeekSumId = pWeekSumInfo.weekSumId;
	 		pWeekSum.WeekSumName = pWeekSumInfo.weekSumName;
	 		pWeekSum.IsApprove = pWeekSumInfo.isApprove;
	 		pWeekSum.IsApply = pWeekSumInfo.isApply;
	 		pWeekSum.IsSend = pWeekSumInfo.isSend;
	 		pWeekSum.ApplyTime = pWeekSumInfo.applyTime;
	 		pWeekSum.RepplyTime = pWeekSumInfo.repplyTime;
	 		pWeekSum.ApplyView = pWeekSumInfo.applyView;
	 		pWeekSum.SendEmployeeId = pWeekSumInfo.sendEmployeeId;
	 		pWeekSum.RecvEmployeeId = pWeekSumInfo.recvEmployeeId;
			pWeekSum.IsNew=pIsNew;
			string UserName = SubsonicHelper.GetUserName();
			try
			{
				pWeekSum.Save(UserName);
			}
			catch(Exception ex)
			{
				LogManager.getInstance().getLogger(typeof(WeekSumInfo)).Error(ex);
				if(ex.Message.Contains("插入重复键"))//违反了唯一键
				{
					throw new AppException("此对象已经存在");//此处等待优化可以从唯一约束中直接取出提示来，如果没有的话，默认为原始的出错提示
				}
				throw new AppException("保存失败");
			}
			pWeekSumInfo.weekSumId = pWeekSum.WeekSumId;
			//如果缓存存在，更新缓存
			if (CachedEntityCommander.IsTypeRegistered(typeof(WeekSumInfo))) 
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
        public static List< WeekSumInfo> GetPagedList(int pPageIndex,int pPageSize,SortDirection pOrderBy,string pSortExpression,out int pRecordCount)
        {
			if(pPageIndex<=1)
			pPageIndex=1;
            List< WeekSumInfo> list = new List< WeekSumInfo>();
          
            Query q = WeekSum .CreateQuery();
            q.PageIndex = pPageIndex;
            q.PageSize = pPageSize;
            q.ORDER_BY(pSortExpression,pOrderBy.ToString());
			WeekSumCollection  collection=new  WeekSumCollection();
		 	collection.LoadAndCloseReader(q.ExecuteReader());
          
            foreach (WeekSum  weekSum  in collection)
            {
                WeekSumInfo weekSumInfo = new WeekSumInfo();
                LoadFromDAL(weekSumInfo,   weekSum);
                list.Add(weekSumInfo);
            }
			pRecordCount=q.GetRecordCount();
			
            return list;

        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		/// <returns></returns>
		public static List< WeekSumInfo> GetList()
		{
			string cacheKey = GetCacheKey();
			//本实体已经注册成缓存实体，并且缓存存在的时候，直接从缓存取
			if (CachedEntityCommander.IsTypeRegistered(typeof(WeekSumInfo)) && CachedEntityCommander.GetCache(cacheKey) != null)
            {
                return CachedEntityCommander.GetCache(cacheKey) as List< WeekSumInfo>;
            }
            else 
            {
				List< WeekSumInfo>  list =new List< WeekSumInfo>();
				WeekSumCollection  collection=new  WeekSumCollection();
				Query qry = new Query(WeekSum.Schema);
				collection.LoadAndCloseReader(qry.ExecuteReader());
				foreach(WeekSum weekSum in collection)
				{
					WeekSumInfo weekSumInfo= new WeekSumInfo();
					LoadFromDAL(weekSumInfo,weekSum);
					list.Add(weekSumInfo);
				}
			  	//生成缓存
                if (CachedEntityCommander.IsTypeRegistered(typeof(WeekSumInfo))) 
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
		public int WeekSumId
		{
			get {return weekSumId;}
			set {weekSumId = value;}
		}

		///<summary>
		///
		///</summary>
		public string WeekSumName
		{
			get {return weekSumName;}
			set {weekSumName = value;}
		}

		///<summary>
		///
		///</summary>
		public int? IsApprove
		{
			get {return isApprove;}
			set {isApprove = value;}
		}

		///<summary>
		///
		///</summary>
		public int? IsApply
		{
			get {return isApply;}
			set {isApply = value;}
		}

		///<summary>
		///
		///</summary>
		public int? IsSend
		{
			get {return isSend;}
			set {isSend = value;}
		}

		///<summary>
		///
		///</summary>
		public DateTime? ApplyTime
		{
			get {return applyTime;}
			set {applyTime = value;}
		}

		///<summary>
		///
		///</summary>
		public DateTime? RepplyTime
		{
			get {return repplyTime;}
			set {repplyTime = value;}
		}

		///<summary>
		///
		///</summary>
		public string ApplyView
		{
			get {return applyView;}
			set {applyView = value;}
		}

		///<summary>
		///
		///</summary>
		public int? SendEmployeeId
		{
			get {return sendEmployeeId;}
			set {sendEmployeeId = value;}
		}

		///<summary>
		///
		///</summary>
		public int? RecvEmployeeId
		{
			get {return recvEmployeeId;}
			set {recvEmployeeId = value;}
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
			bool result=  (WeekSum.Delete(WeekSumId) == 1);
			//更新缓存
			if (result&&CachedEntityCommander.IsTypeRegistered(typeof(WeekSumInfo))) 
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
        public void CopyTo(WeekSumInfo pWeekSumInfoTo)
        {
            Copy(this,  pWeekSumInfoTo);
        }
		
		
		
		
		
		/// <summary>
		/// 保存
		/// </summary>
		public override void Save()
		{
			if(!m_Loaded)//新增
			{
				WeekSum weekSum=new WeekSum();	
				SaveToDb(this, weekSum,true);
			}
			else//修改
			{
				WeekSum weekSum=new WeekSum(weekSumId);	
				if(weekSum.IsNew)
					throw new AppException("该数据已经不存在了");
				SaveToDb(this, weekSum,false);
			}
			
		}
		 
		#endregion
		
	}
}
