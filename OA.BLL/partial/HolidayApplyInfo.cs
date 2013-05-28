// ======================================================================================================================================
// 类说明
//=======================================================================================================================================
// 创建者：sk @Copy Right 残友软件有限公司OA项目 
// 文件名：HolidayApplyInfo.cs
// 创建时间：2012-10-23
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
	///HolidayApplyInfo  Data
	/// </summary>
	[Serializable]
	public partial class HolidayApplyInfo:CanYou.EntityObject
	{
		#region 属性
		///<summary>
		///
		///</summary>
		private int holidayApplyId;
		///<summary>
		///
		///</summary>
		private string company1 = String.Empty;
		///<summary>
		///
		///</summary>
		private string positonName = String.Empty;
		///<summary>
		///
		///</summary>
		private string company2 = String.Empty;
		///<summary>
		///
		///</summary>
		private string company2Name = String.Empty;
		///<summary>
		///
		///</summary>
		private int? holidayTypeId;
		///<summary>
		///
		///</summary>
		private string beginTime = String.Empty;
		///<summary>
		///
		///</summary>
		private string endTime = String.Empty;
		///<summary>
		///
		///</summary>
		private string timeSum = String.Empty;
		///<summary>
		///
		///</summary>
		private string reason = String.Empty;
		///<summary>
		///
		///</summary>
		private string sectionView = String.Empty;
		///<summary>
		///
		///</summary>
		private string hrView = String.Empty;
		///<summary>
		///
		///</summary>
		private string managerView = String.Empty;
		///<summary>
		///
		///</summary>
		private string memo = String.Empty;
		///<summary>
		///
		///</summary>
		private string applyDate = String.Empty;
		///<summary>
		///
		///</summary>
		private string applyTime = String.Empty;
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
		
		
		///一对多关系,如果
		private bool m_Loaded=false;
		#endregion
		
		#region 属性枚举
		public struct Fields
		{
			public const string HolidayApplyId=@"HolidayApplyId";
			public const string Company1=@"Company1";
			public const string PositonName=@"PositonName";
			public const string Company2=@"Company2";
			public const string Company2Name=@"Company2Name";
			public const string HolidayTypeId=@"HolidayTypeId";
			public const string BeginTime=@"BeginTime";
			public const string EndTime=@"EndTime";
			public const string TimeSum=@"TimeSum";
			public const string Reason=@"Reason";
			public const string SectionView=@"SectionView";
			public const string HrView=@"HrView";
			public const string ManagerView=@"ManagerView";
			public const string Memo=@"Memo";
			public const string ApplyDate=@"ApplyDate";
			public const string ApplyTime=@"ApplyTime";
			public const string ApplyName=@"ApplyName";
			public const string DepartName=@"DepartName";
			public const string State=@"State";
						
		}

		#endregion
		
		
		#region 构造函数
		///<summary>
		///
		///</summary>
		public HolidayApplyInfo()
		{
		}
		///<summary>
		///
		///</summary>
		public HolidayApplyInfo(int pHolidayApplyId,string pCompany1,string pPositonName,string pCompany2,string pCompany2Name,int? pHolidayTypeId,string pBeginTime,string pEndTime,string pTimeSum,string pReason,string pSectionView,string pHrView,string pManagerView,string pMemo,string pApplyDate,string pApplyTime,string pApplyName,string pDepartName,int? pState)
		{
			holidayApplyId = pHolidayApplyId;
			company1       = pCompany1;
			positonName    = pPositonName;
			company2       = pCompany2;
			company2Name   = pCompany2Name;
			holidayTypeId  = pHolidayTypeId;
			beginTime      = pBeginTime;
			endTime        = pEndTime;
			timeSum        = pTimeSum;
			reason         = pReason;
			sectionView    = pSectionView;
			hrView         = pHrView;
			managerView    = pManagerView;
			memo           = pMemo;
			applyDate      = pApplyDate;
			applyTime      = pApplyTime;
			applyName      = pApplyName;
			departName     = pDepartName;
			state          = pState;
			
		}
		
		
		///<summary>
		///
		///</summary>
		public HolidayApplyInfo(int holidayApplyId)
		{
			 LoadFromId(holidayApplyId);
		}
		
		private void LoadFromId(int holidayApplyId)
		{
		 
			if (CachedEntityCommander.IsTypeRegistered(typeof(HolidayApplyInfo)))
            {
				HolidayApplyInfo holidayApplyInfo=Find(GetList(), holidayApplyId);
				if(holidayApplyInfo==null)
					throw new AppException("未能在缓存中找到相应的键值对象");
                Copy(holidayApplyInfo, this);
            }
            else
            {	HolidayApply holidayApply=new HolidayApply( holidayApplyId);	
				if(holidayApply.IsNew)
				throw new AppException("尚未初始化");
               	LoadFromDAL(this, holidayApply);
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
        public static  HolidayApplyInfo Find(List< HolidayApplyInfo> list,  int holidayApplyId)
        {
             return list.Find(delegate( HolidayApplyInfo item) { return item. holidayApplyId==holidayApplyId; });
        }
		
		
		/// <summary>
        /// 得到缓存键
        /// </summary>
        /// <returns></returns>
        private static string GetCacheKey()
        {
            return string.Format(CachedEntityCommander.CacheKey, typeof( HolidayApplyInfo).ToString());
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
        public static void Copy(HolidayApplyInfo pHolidayApplyInfoFrom, HolidayApplyInfo pHolidayApplyInfoTo)
        {
	 		pHolidayApplyInfoTo.HolidayApplyId = pHolidayApplyInfoFrom.holidayApplyId;
	 		pHolidayApplyInfoTo.Company1 = pHolidayApplyInfoFrom.company1;
	 		pHolidayApplyInfoTo.PositonName = pHolidayApplyInfoFrom.positonName;
	 		pHolidayApplyInfoTo.Company2 = pHolidayApplyInfoFrom.company2;
	 		pHolidayApplyInfoTo.Company2Name = pHolidayApplyInfoFrom.company2Name;
	 		pHolidayApplyInfoTo.HolidayTypeId = pHolidayApplyInfoFrom.holidayTypeId;
	 		pHolidayApplyInfoTo.BeginTime = pHolidayApplyInfoFrom.beginTime;
	 		pHolidayApplyInfoTo.EndTime = pHolidayApplyInfoFrom.endTime;
	 		pHolidayApplyInfoTo.TimeSum = pHolidayApplyInfoFrom.timeSum;
	 		pHolidayApplyInfoTo.Reason = pHolidayApplyInfoFrom.reason;
	 		pHolidayApplyInfoTo.SectionView = pHolidayApplyInfoFrom.sectionView;
	 		pHolidayApplyInfoTo.HrView = pHolidayApplyInfoFrom.hrView;
	 		pHolidayApplyInfoTo.ManagerView = pHolidayApplyInfoFrom.managerView;
	 		pHolidayApplyInfoTo.Memo = pHolidayApplyInfoFrom.memo;
	 		pHolidayApplyInfoTo.ApplyDate = pHolidayApplyInfoFrom.applyDate;
	 		pHolidayApplyInfoTo.ApplyTime = pHolidayApplyInfoFrom.applyTime;
	 		pHolidayApplyInfoTo.ApplyName = pHolidayApplyInfoFrom.applyName;
	 		pHolidayApplyInfoTo.DepartName = pHolidayApplyInfoFrom.departName;
	 		pHolidayApplyInfoTo.State = pHolidayApplyInfoFrom.state;
			pHolidayApplyInfoTo.Loaded=pHolidayApplyInfoFrom.Loaded;
        }
		
		/// <summary>
		/// 批量装载
		/// </summary>
		internal static void LoadFromDALPatch(List< HolidayApplyInfo> pList, HolidayApplyCollection pCollection)
        {
            foreach (HolidayApply holidayApply in pCollection)
            {
                HolidayApplyInfo holidayApplyInfo = new HolidayApplyInfo();
                LoadFromDAL(holidayApplyInfo, holidayApply );
                pList.Add(holidayApplyInfo);
            }
			
        }

		//从后台获取数据
		internal  static void  LoadFromDAL(HolidayApplyInfo pHolidayApplyInfo, HolidayApply  pHolidayApply)
		{
	 		pHolidayApplyInfo.holidayApplyId = pHolidayApply.HolidayApplyId;
	 		pHolidayApplyInfo.company1 = pHolidayApply.Company1;
	 		pHolidayApplyInfo.positonName = pHolidayApply.PositonName;
	 		pHolidayApplyInfo.company2 = pHolidayApply.Company2;
	 		pHolidayApplyInfo.company2Name = pHolidayApply.Company2Name;
	 		pHolidayApplyInfo.holidayTypeId = pHolidayApply.HolidayTypeId;
	 		pHolidayApplyInfo.beginTime = pHolidayApply.BeginTime;
	 		pHolidayApplyInfo.endTime = pHolidayApply.EndTime;
	 		pHolidayApplyInfo.timeSum = pHolidayApply.TimeSum;
	 		pHolidayApplyInfo.reason = pHolidayApply.Reason;
	 		pHolidayApplyInfo.sectionView = pHolidayApply.SectionView;
	 		pHolidayApplyInfo.hrView = pHolidayApply.HrView;
	 		pHolidayApplyInfo.managerView = pHolidayApply.ManagerView;
	 		pHolidayApplyInfo.memo = pHolidayApply.Memo;
	 		pHolidayApplyInfo.applyDate = pHolidayApply.ApplyDate;
	 		pHolidayApplyInfo.applyTime = pHolidayApply.ApplyTime;
	 		pHolidayApplyInfo.applyName = pHolidayApply.ApplyName;
	 		pHolidayApplyInfo.departName = pHolidayApply.DepartName;
	 		pHolidayApplyInfo.state = pHolidayApply.State;
			pHolidayApplyInfo.Loaded=true;
			
			}
		
		//数据持久化
		internal  static void  SaveToDb(HolidayApplyInfo pHolidayApplyInfo, HolidayApply  pHolidayApply,bool pIsNew)
		{
	 		pHolidayApply.HolidayApplyId = pHolidayApplyInfo.holidayApplyId;
	 		pHolidayApply.Company1 = pHolidayApplyInfo.company1;
	 		pHolidayApply.PositonName = pHolidayApplyInfo.positonName;
	 		pHolidayApply.Company2 = pHolidayApplyInfo.company2;
	 		pHolidayApply.Company2Name = pHolidayApplyInfo.company2Name;
	 		pHolidayApply.HolidayTypeId = pHolidayApplyInfo.holidayTypeId;
	 		pHolidayApply.BeginTime = pHolidayApplyInfo.beginTime;
	 		pHolidayApply.EndTime = pHolidayApplyInfo.endTime;
	 		pHolidayApply.TimeSum = pHolidayApplyInfo.timeSum;
	 		pHolidayApply.Reason = pHolidayApplyInfo.reason;
	 		pHolidayApply.SectionView = pHolidayApplyInfo.sectionView;
	 		pHolidayApply.HrView = pHolidayApplyInfo.hrView;
	 		pHolidayApply.ManagerView = pHolidayApplyInfo.managerView;
	 		pHolidayApply.Memo = pHolidayApplyInfo.memo;
	 		pHolidayApply.ApplyDate = pHolidayApplyInfo.applyDate;
	 		pHolidayApply.ApplyTime = pHolidayApplyInfo.applyTime;
	 		pHolidayApply.ApplyName = pHolidayApplyInfo.applyName;
	 		pHolidayApply.DepartName = pHolidayApplyInfo.departName;
	 		pHolidayApply.State = pHolidayApplyInfo.state;
			pHolidayApply.IsNew=pIsNew;
			string UserName = SubsonicHelper.GetUserName();
			try
			{
				pHolidayApply.Save(UserName);
			}
			catch(Exception ex)
			{
				LogManager.getInstance().getLogger(typeof(HolidayApplyInfo)).Error(ex);
				if(ex.Message.Contains("插入重复键"))//违反了唯一键
				{
					throw new AppException("此对象已经存在");//此处等待优化可以从唯一约束中直接取出提示来，如果没有的话，默认为原始的出错提示
				}
				throw new AppException("保存失败");
			}
			pHolidayApplyInfo.holidayApplyId = pHolidayApply.HolidayApplyId;
			//如果缓存存在，更新缓存
			if (CachedEntityCommander.IsTypeRegistered(typeof(HolidayApplyInfo))) 
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
        public static List< HolidayApplyInfo> GetPagedList(int pPageIndex,int pPageSize,SortDirection pOrderBy,string pSortExpression,out int pRecordCount)
        {
			if(pPageIndex<=1)
			pPageIndex=1;
            List< HolidayApplyInfo> list = new List< HolidayApplyInfo>();
          
            Query q = HolidayApply .CreateQuery();
            q.PageIndex = pPageIndex;
            q.PageSize = pPageSize;
            q.ORDER_BY(pSortExpression,pOrderBy.ToString());
			HolidayApplyCollection  collection=new  HolidayApplyCollection();
		 	collection.LoadAndCloseReader(q.ExecuteReader());
          
            foreach (HolidayApply  holidayApply  in collection)
            {
                HolidayApplyInfo holidayApplyInfo = new HolidayApplyInfo();
                LoadFromDAL(holidayApplyInfo,   holidayApply);
                list.Add(holidayApplyInfo);
            }
			pRecordCount=q.GetRecordCount();
			
            return list;

        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		/// <returns></returns>
		public static List< HolidayApplyInfo> GetList()
		{
			string cacheKey = GetCacheKey();
			//本实体已经注册成缓存实体，并且缓存存在的时候，直接从缓存取
			if (CachedEntityCommander.IsTypeRegistered(typeof(HolidayApplyInfo)) && CachedEntityCommander.GetCache(cacheKey) != null)
            {
                return CachedEntityCommander.GetCache(cacheKey) as List< HolidayApplyInfo>;
            }
            else 
            {
				List< HolidayApplyInfo>  list =new List< HolidayApplyInfo>();
				HolidayApplyCollection  collection=new  HolidayApplyCollection();
				Query qry = new Query(HolidayApply.Schema);
				collection.LoadAndCloseReader(qry.ExecuteReader());
				foreach(HolidayApply holidayApply in collection)
				{
					HolidayApplyInfo holidayApplyInfo= new HolidayApplyInfo();
					LoadFromDAL(holidayApplyInfo,holidayApply);
					list.Add(holidayApplyInfo);
				}
			  	//生成缓存
                if (CachedEntityCommander.IsTypeRegistered(typeof(HolidayApplyInfo))) 
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
		public int HolidayApplyId
		{
			get {return holidayApplyId;}
			set {holidayApplyId = value;}
		}

		///<summary>
		///
		///</summary>
		public string Company1
		{
			get {return company1;}
			set {company1 = value;}
		}

		///<summary>
		///
		///</summary>
		public string PositonName
		{
			get {return positonName;}
			set {positonName = value;}
		}

		///<summary>
		///
		///</summary>
		public string Company2
		{
			get {return company2;}
			set {company2 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Company2Name
		{
			get {return company2Name;}
			set {company2Name = value;}
		}

		///<summary>
		///
		///</summary>
		public int? HolidayTypeId
		{
			get {return holidayTypeId;}
			set {holidayTypeId = value;}
		}

		///<summary>
		///
		///</summary>
		public string BeginTime
		{
			get {return beginTime;}
			set {beginTime = value;}
		}

		///<summary>
		///
		///</summary>
		public string EndTime
		{
			get {return endTime;}
			set {endTime = value;}
		}

		///<summary>
		///
		///</summary>
		public string TimeSum
		{
			get {return timeSum;}
			set {timeSum = value;}
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
		public string SectionView
		{
			get {return sectionView;}
			set {sectionView = value;}
		}

		///<summary>
		///
		///</summary>
		public string HrView
		{
			get {return hrView;}
			set {hrView = value;}
		}

		///<summary>
		///
		///</summary>
		public string ManagerView
		{
			get {return managerView;}
			set {managerView = value;}
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
		public string ApplyDate
		{
			get {return applyDate;}
			set {applyDate = value;}
		}

		///<summary>
		///
		///</summary>
		public string ApplyTime
		{
			get {return applyTime;}
			set {applyTime = value;}
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
			bool result=  (HolidayApply.Delete(HolidayApplyId) == 1);
			//更新缓存
			if (result&&CachedEntityCommander.IsTypeRegistered(typeof(HolidayApplyInfo))) 
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
        public void CopyTo(HolidayApplyInfo pHolidayApplyInfoTo)
        {
            Copy(this,  pHolidayApplyInfoTo);
        }
		
		
		
		
		
		/// <summary>
		/// 保存
		/// </summary>
		public override void Save()
		{
			if(!m_Loaded)//新增
			{
				HolidayApply holidayApply=new HolidayApply();	
				SaveToDb(this, holidayApply,true);
			}
			else//修改
			{
				HolidayApply holidayApply=new HolidayApply(holidayApplyId);	
				if(holidayApply.IsNew)
					throw new AppException("该数据已经不存在了");
				SaveToDb(this, holidayApply,false);
			}
			
		}
		 
		#endregion
		
	}
}
