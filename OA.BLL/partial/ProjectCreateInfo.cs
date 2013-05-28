// ======================================================================================================================================
// 类说明
//=======================================================================================================================================
// 创建者：sk @Copy Right 残友软件有限公司OA项目 
// 文件名：ProjectCreateInfo.cs
// 创建时间：2012-9-24
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
	///ProjectCreateInfo  Data
	/// </summary>
	[Serializable]
	public partial class ProjectCreateInfo:CanYou.EntityObject
	{
		#region 属性
		///<summary>
		///
		///</summary>
		private int projectCreateId;
		///<summary>
		///
		///</summary>
		private int? clientId;
		///<summary>
		///
		///</summary>
		private int? projectLevelId;
		///<summary>
		///
		///</summary>
		private int? projectTypeId;
		///<summary>
		///
		///</summary>
		private int? yeWuId;
		///<summary>
		///
		///</summary>
		private string projectName = String.Empty;
		///<summary>
		///
		///</summary>
		private string preMoney = String.Empty;
		///<summary>
		///
		///</summary>
		private string preProfit = String.Empty;
		///<summary>
		///
		///</summary>
		private string applyDate = String.Empty;
		///<summary>
		///
		///</summary>
		private string createPhaseExp = String.Empty;
		///<summary>
		///
		///</summary>
		private string proposePhaseExp = String.Empty;
		///<summary>
		///
		///</summary>
		private string callbidPhaseExp = String.Empty;
		///<summary>
		///
		///</summary>
		private string talkPhaseExp = String.Empty;
		///<summary>
		///
		///</summary>
		private string carryPhaseExp = String.Empty;
		///<summary>
		///
		///</summary>
		private string needDescribe = String.Empty;
		///<summary>
		///
		///</summary>
		private string compitDescribe = String.Empty;
		///<summary>
		///
		///</summary>
		private string clientDescribe = String.Empty;
		///<summary>
		///
		///</summary>
		private string techDescribe = String.Empty;
		///<summary>
		///
		///</summary>
		private string businessDescribe = String.Empty;
		///<summary>
		///
		///</summary>
		private string riskDescribe = String.Empty;
		///<summary>
		///
		///</summary>
		private string strategyDesribe = String.Empty;
		///<summary>
		///
		///</summary>
		private string memo = String.Empty;
		///<summary>
		///
		///</summary>
		private string marketView = String.Empty;
		///<summary>
		///
		///</summary>
		private string techView = String.Empty;
		///<summary>
		///
		///</summary>
		private string managerView = String.Empty;
		///<summary>
		///
		///</summary>
		private string sheetNum = String.Empty;
		///<summary>
		///
		///</summary>
		private string today = String.Empty;
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
			public const string ProjectCreateId=@"ProjectCreateId";
			public const string ClientId=@"ClientId";
			public const string ProjectLevelId=@"ProjectLevelId";
			public const string ProjectTypeId=@"ProjectTypeId";
			public const string YeWuId=@"YeWuId";
			public const string ProjectName=@"ProjectName";
			public const string PreMoney=@"PreMoney";
			public const string PreProfit=@"PreProfit";
			public const string ApplyDate=@"ApplyDate";
			public const string CreatePhaseExp=@"CreatePhaseExp";
			public const string ProposePhaseExp=@"ProposePhaseExp";
			public const string CallbidPhaseExp=@"CallbidPhaseExp";
			public const string TalkPhaseExp=@"TalkPhaseExp";
			public const string CarryPhaseExp=@"CarryPhaseExp";
			public const string NeedDescribe=@"NeedDescribe";
			public const string CompitDescribe=@"CompitDescribe";
			public const string ClientDescribe=@"ClientDescribe";
			public const string TechDescribe=@"TechDescribe";
			public const string BusinessDescribe=@"BusinessDescribe";
			public const string RiskDescribe=@"RiskDescribe";
			public const string StrategyDesribe=@"StrategyDesribe";
			public const string Memo=@"Memo";
			public const string MarketView=@"MarketView";
			public const string TechView=@"TechView";
			public const string ManagerView=@"ManagerView";
			public const string SheetNum=@"SheetNum";
			public const string Today=@"Today";
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
		public ProjectCreateInfo()
		{
		}
		///<summary>
		///
		///</summary>
		public ProjectCreateInfo(int pProjectCreateId,int? pClientId,int? pProjectLevelId,int? pProjectTypeId,int? pYeWuId,string pProjectName,string pPreMoney,string pPreProfit,string pApplyDate,string pCreatePhaseExp,string pProposePhaseExp,string pCallbidPhaseExp,string pTalkPhaseExp,string pCarryPhaseExp,string pNeedDescribe,string pCompitDescribe,string pClientDescribe,string pTechDescribe,string pBusinessDescribe,string pRiskDescribe,string pStrategyDesribe,string pMemo,string pMarketView,string pTechView,string pManagerView,string pSheetNum,string pToday,string pApplyName,string pDepartName,int? pState,string pApplyTime)
		{
			projectCreateId  = pProjectCreateId;
			clientId         = pClientId;
			projectLevelId   = pProjectLevelId;
			projectTypeId    = pProjectTypeId;
			yeWuId           = pYeWuId;
			projectName      = pProjectName;
			preMoney         = pPreMoney;
			preProfit        = pPreProfit;
			applyDate        = pApplyDate;
			createPhaseExp   = pCreatePhaseExp;
			proposePhaseExp  = pProposePhaseExp;
			callbidPhaseExp  = pCallbidPhaseExp;
			talkPhaseExp     = pTalkPhaseExp;
			carryPhaseExp    = pCarryPhaseExp;
			needDescribe     = pNeedDescribe;
			compitDescribe   = pCompitDescribe;
			clientDescribe   = pClientDescribe;
			techDescribe     = pTechDescribe;
			businessDescribe = pBusinessDescribe;
			riskDescribe     = pRiskDescribe;
			strategyDesribe  = pStrategyDesribe;
			memo             = pMemo;
			marketView       = pMarketView;
			techView         = pTechView;
			managerView      = pManagerView;
			sheetNum         = pSheetNum;
			today            = pToday;
			applyName        = pApplyName;
			departName       = pDepartName;
			state            = pState;
			applyTime        = pApplyTime;
			
		}
		
		
		///<summary>
		///
		///</summary>
		public ProjectCreateInfo(int projectCreateId)
		{
			 LoadFromId(projectCreateId);
		}
		
		private void LoadFromId(int projectCreateId)
		{
		 
			if (CachedEntityCommander.IsTypeRegistered(typeof(ProjectCreateInfo)))
            {
				ProjectCreateInfo projectCreateInfo=Find(GetList(), projectCreateId);
				if(projectCreateInfo==null)
					throw new AppException("未能在缓存中找到相应的键值对象");
                Copy(projectCreateInfo, this);
            }
            else
            {	ProjectCreate projectCreate=new ProjectCreate( projectCreateId);	
				if(projectCreate.IsNew)
				throw new AppException("尚未初始化");
               	LoadFromDAL(this, projectCreate);
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
        public static  ProjectCreateInfo Find(List< ProjectCreateInfo> list,  int projectCreateId)
        {
             return list.Find(delegate( ProjectCreateInfo item) { return item. projectCreateId==projectCreateId; });
        }
		
		
		/// <summary>
        /// 得到缓存键
        /// </summary>
        /// <returns></returns>
        private static string GetCacheKey()
        {
            return string.Format(CachedEntityCommander.CacheKey, typeof( ProjectCreateInfo).ToString());
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
        public static void Copy(ProjectCreateInfo pProjectCreateInfoFrom, ProjectCreateInfo pProjectCreateInfoTo)
        {
	 		pProjectCreateInfoTo.ProjectCreateId = pProjectCreateInfoFrom.projectCreateId;
	 		pProjectCreateInfoTo.ClientId = pProjectCreateInfoFrom.clientId;
	 		pProjectCreateInfoTo.ProjectLevelId = pProjectCreateInfoFrom.projectLevelId;
	 		pProjectCreateInfoTo.ProjectTypeId = pProjectCreateInfoFrom.projectTypeId;
	 		pProjectCreateInfoTo.YeWuId = pProjectCreateInfoFrom.yeWuId;
	 		pProjectCreateInfoTo.ProjectName = pProjectCreateInfoFrom.projectName;
	 		pProjectCreateInfoTo.PreMoney = pProjectCreateInfoFrom.preMoney;
	 		pProjectCreateInfoTo.PreProfit = pProjectCreateInfoFrom.preProfit;
	 		pProjectCreateInfoTo.ApplyDate = pProjectCreateInfoFrom.applyDate;
	 		pProjectCreateInfoTo.CreatePhaseExp = pProjectCreateInfoFrom.createPhaseExp;
	 		pProjectCreateInfoTo.ProposePhaseExp = pProjectCreateInfoFrom.proposePhaseExp;
	 		pProjectCreateInfoTo.CallbidPhaseExp = pProjectCreateInfoFrom.callbidPhaseExp;
	 		pProjectCreateInfoTo.TalkPhaseExp = pProjectCreateInfoFrom.talkPhaseExp;
	 		pProjectCreateInfoTo.CarryPhaseExp = pProjectCreateInfoFrom.carryPhaseExp;
	 		pProjectCreateInfoTo.NeedDescribe = pProjectCreateInfoFrom.needDescribe;
	 		pProjectCreateInfoTo.CompitDescribe = pProjectCreateInfoFrom.compitDescribe;
	 		pProjectCreateInfoTo.ClientDescribe = pProjectCreateInfoFrom.clientDescribe;
	 		pProjectCreateInfoTo.TechDescribe = pProjectCreateInfoFrom.techDescribe;
	 		pProjectCreateInfoTo.BusinessDescribe = pProjectCreateInfoFrom.businessDescribe;
	 		pProjectCreateInfoTo.RiskDescribe = pProjectCreateInfoFrom.riskDescribe;
	 		pProjectCreateInfoTo.StrategyDesribe = pProjectCreateInfoFrom.strategyDesribe;
	 		pProjectCreateInfoTo.Memo = pProjectCreateInfoFrom.memo;
	 		pProjectCreateInfoTo.MarketView = pProjectCreateInfoFrom.marketView;
	 		pProjectCreateInfoTo.TechView = pProjectCreateInfoFrom.techView;
	 		pProjectCreateInfoTo.ManagerView = pProjectCreateInfoFrom.managerView;
	 		pProjectCreateInfoTo.SheetNum = pProjectCreateInfoFrom.sheetNum;
	 		pProjectCreateInfoTo.Today = pProjectCreateInfoFrom.today;
	 		pProjectCreateInfoTo.ApplyName = pProjectCreateInfoFrom.applyName;
	 		pProjectCreateInfoTo.DepartName = pProjectCreateInfoFrom.departName;
	 		pProjectCreateInfoTo.State = pProjectCreateInfoFrom.state;
	 		pProjectCreateInfoTo.ApplyTime = pProjectCreateInfoFrom.applyTime;
			pProjectCreateInfoTo.Loaded=pProjectCreateInfoFrom.Loaded;
        }
		
		/// <summary>
		/// 批量装载
		/// </summary>
		internal static void LoadFromDALPatch(List< ProjectCreateInfo> pList, ProjectCreateCollection pCollection)
        {
            foreach (ProjectCreate projectCreate in pCollection)
            {
                ProjectCreateInfo projectCreateInfo = new ProjectCreateInfo();
                LoadFromDAL(projectCreateInfo, projectCreate );
                pList.Add(projectCreateInfo);
            }
			
        }

		//从后台获取数据
		internal  static void  LoadFromDAL(ProjectCreateInfo pProjectCreateInfo, ProjectCreate  pProjectCreate)
		{
	 		pProjectCreateInfo.projectCreateId = pProjectCreate.ProjectCreateId;
	 		pProjectCreateInfo.clientId = pProjectCreate.ClientId;
	 		pProjectCreateInfo.projectLevelId = pProjectCreate.ProjectLevelId;
	 		pProjectCreateInfo.projectTypeId = pProjectCreate.ProjectTypeId;
	 		pProjectCreateInfo.yeWuId = pProjectCreate.YeWuId;
	 		pProjectCreateInfo.projectName = pProjectCreate.ProjectName;
	 		pProjectCreateInfo.preMoney = pProjectCreate.PreMoney;
	 		pProjectCreateInfo.preProfit = pProjectCreate.PreProfit;
	 		pProjectCreateInfo.applyDate = pProjectCreate.ApplyDate;
	 		pProjectCreateInfo.createPhaseExp = pProjectCreate.CreatePhaseExp;
	 		pProjectCreateInfo.proposePhaseExp = pProjectCreate.ProposePhaseExp;
	 		pProjectCreateInfo.callbidPhaseExp = pProjectCreate.CallbidPhaseExp;
	 		pProjectCreateInfo.talkPhaseExp = pProjectCreate.TalkPhaseExp;
	 		pProjectCreateInfo.carryPhaseExp = pProjectCreate.CarryPhaseExp;
	 		pProjectCreateInfo.needDescribe = pProjectCreate.NeedDescribe;
	 		pProjectCreateInfo.compitDescribe = pProjectCreate.CompitDescribe;
	 		pProjectCreateInfo.clientDescribe = pProjectCreate.ClientDescribe;
	 		pProjectCreateInfo.techDescribe = pProjectCreate.TechDescribe;
	 		pProjectCreateInfo.businessDescribe = pProjectCreate.BusinessDescribe;
	 		pProjectCreateInfo.riskDescribe = pProjectCreate.RiskDescribe;
	 		pProjectCreateInfo.strategyDesribe = pProjectCreate.StrategyDesribe;
	 		pProjectCreateInfo.memo = pProjectCreate.Memo;
	 		pProjectCreateInfo.marketView = pProjectCreate.MarketView;
	 		pProjectCreateInfo.techView = pProjectCreate.TechView;
	 		pProjectCreateInfo.managerView = pProjectCreate.ManagerView;
	 		pProjectCreateInfo.sheetNum = pProjectCreate.SheetNum;
	 		pProjectCreateInfo.today = pProjectCreate.Today;
	 		pProjectCreateInfo.applyName = pProjectCreate.ApplyName;
	 		pProjectCreateInfo.departName = pProjectCreate.DepartName;
	 		pProjectCreateInfo.state = pProjectCreate.State;
	 		pProjectCreateInfo.applyTime = pProjectCreate.ApplyTime;
			pProjectCreateInfo.Loaded=true;
			
			}
		
		//数据持久化
		internal  static void  SaveToDb(ProjectCreateInfo pProjectCreateInfo, ProjectCreate  pProjectCreate,bool pIsNew)
		{
	 		pProjectCreate.ProjectCreateId = pProjectCreateInfo.projectCreateId;
	 		pProjectCreate.ClientId = pProjectCreateInfo.clientId;
	 		pProjectCreate.ProjectLevelId = pProjectCreateInfo.projectLevelId;
	 		pProjectCreate.ProjectTypeId = pProjectCreateInfo.projectTypeId;
	 		pProjectCreate.YeWuId = pProjectCreateInfo.yeWuId;
	 		pProjectCreate.ProjectName = pProjectCreateInfo.projectName;
	 		pProjectCreate.PreMoney = pProjectCreateInfo.preMoney;
	 		pProjectCreate.PreProfit = pProjectCreateInfo.preProfit;
	 		pProjectCreate.ApplyDate = pProjectCreateInfo.applyDate;
	 		pProjectCreate.CreatePhaseExp = pProjectCreateInfo.createPhaseExp;
	 		pProjectCreate.ProposePhaseExp = pProjectCreateInfo.proposePhaseExp;
	 		pProjectCreate.CallbidPhaseExp = pProjectCreateInfo.callbidPhaseExp;
	 		pProjectCreate.TalkPhaseExp = pProjectCreateInfo.talkPhaseExp;
	 		pProjectCreate.CarryPhaseExp = pProjectCreateInfo.carryPhaseExp;
	 		pProjectCreate.NeedDescribe = pProjectCreateInfo.needDescribe;
	 		pProjectCreate.CompitDescribe = pProjectCreateInfo.compitDescribe;
	 		pProjectCreate.ClientDescribe = pProjectCreateInfo.clientDescribe;
	 		pProjectCreate.TechDescribe = pProjectCreateInfo.techDescribe;
	 		pProjectCreate.BusinessDescribe = pProjectCreateInfo.businessDescribe;
	 		pProjectCreate.RiskDescribe = pProjectCreateInfo.riskDescribe;
	 		pProjectCreate.StrategyDesribe = pProjectCreateInfo.strategyDesribe;
	 		pProjectCreate.Memo = pProjectCreateInfo.memo;
	 		pProjectCreate.MarketView = pProjectCreateInfo.marketView;
	 		pProjectCreate.TechView = pProjectCreateInfo.techView;
	 		pProjectCreate.ManagerView = pProjectCreateInfo.managerView;
	 		pProjectCreate.SheetNum = pProjectCreateInfo.sheetNum;
	 		pProjectCreate.Today = pProjectCreateInfo.today;
	 		pProjectCreate.ApplyName = pProjectCreateInfo.applyName;
	 		pProjectCreate.DepartName = pProjectCreateInfo.departName;
	 		pProjectCreate.State = pProjectCreateInfo.state;
	 		pProjectCreate.ApplyTime = pProjectCreateInfo.applyTime;
			pProjectCreate.IsNew=pIsNew;
			string UserName = SubsonicHelper.GetUserName();
			try
			{
				pProjectCreate.Save(UserName);
			}
			catch(Exception ex)
			{
				LogManager.getInstance().getLogger(typeof(ProjectCreateInfo)).Error(ex);
				if(ex.Message.Contains("插入重复键"))//违反了唯一键
				{
					throw new AppException("此对象已经存在");//此处等待优化可以从唯一约束中直接取出提示来，如果没有的话，默认为原始的出错提示
				}
				throw new AppException("保存失败");
			}
			pProjectCreateInfo.projectCreateId = pProjectCreate.ProjectCreateId;
			//如果缓存存在，更新缓存
			if (CachedEntityCommander.IsTypeRegistered(typeof(ProjectCreateInfo))) 
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
        public static List< ProjectCreateInfo> GetPagedList(int pPageIndex,int pPageSize,SortDirection pOrderBy,string pSortExpression,out int pRecordCount)
        {
			if(pPageIndex<=1)
			pPageIndex=1;
            List< ProjectCreateInfo> list = new List< ProjectCreateInfo>();
          
            Query q = ProjectCreate .CreateQuery();
            q.PageIndex = pPageIndex;
            q.PageSize = pPageSize;
            q.ORDER_BY(pSortExpression,pOrderBy.ToString());
			ProjectCreateCollection  collection=new  ProjectCreateCollection();
		 	collection.LoadAndCloseReader(q.ExecuteReader());
          
            foreach (ProjectCreate  projectCreate  in collection)
            {
                ProjectCreateInfo projectCreateInfo = new ProjectCreateInfo();
                LoadFromDAL(projectCreateInfo,   projectCreate);
                list.Add(projectCreateInfo);
            }
			pRecordCount=q.GetRecordCount();
			
            return list;

        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		/// <returns></returns>
		public static List< ProjectCreateInfo> GetList()
		{
			string cacheKey = GetCacheKey();
			//本实体已经注册成缓存实体，并且缓存存在的时候，直接从缓存取
			if (CachedEntityCommander.IsTypeRegistered(typeof(ProjectCreateInfo)) && CachedEntityCommander.GetCache(cacheKey) != null)
            {
                return CachedEntityCommander.GetCache(cacheKey) as List< ProjectCreateInfo>;
            }
            else 
            {
				List< ProjectCreateInfo>  list =new List< ProjectCreateInfo>();
				ProjectCreateCollection  collection=new  ProjectCreateCollection();
				Query qry = new Query(ProjectCreate.Schema);
				collection.LoadAndCloseReader(qry.ExecuteReader());
				foreach(ProjectCreate projectCreate in collection)
				{
					ProjectCreateInfo projectCreateInfo= new ProjectCreateInfo();
					LoadFromDAL(projectCreateInfo,projectCreate);
					list.Add(projectCreateInfo);
				}
			  	//生成缓存
                if (CachedEntityCommander.IsTypeRegistered(typeof(ProjectCreateInfo))) 
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
		public int ProjectCreateId
		{
			get {return projectCreateId;}
			set {projectCreateId = value;}
		}

		///<summary>
		///
		///</summary>
		public int? ClientId
		{
			get {return clientId;}
			set {clientId = value;}
		}

		///<summary>
		///
		///</summary>
		public int? ProjectLevelId
		{
			get {return projectLevelId;}
			set {projectLevelId = value;}
		}

		///<summary>
		///
		///</summary>
		public int? ProjectTypeId
		{
			get {return projectTypeId;}
			set {projectTypeId = value;}
		}

		///<summary>
		///
		///</summary>
		public int? YeWuId
		{
			get {return yeWuId;}
			set {yeWuId = value;}
		}

		///<summary>
		///
		///</summary>
		public string ProjectName
		{
			get {return projectName;}
			set {projectName = value;}
		}

		///<summary>
		///
		///</summary>
		public string PreMoney
		{
			get {return preMoney;}
			set {preMoney = value;}
		}

		///<summary>
		///
		///</summary>
		public string PreProfit
		{
			get {return preProfit;}
			set {preProfit = value;}
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
		public string CreatePhaseExp
		{
			get {return createPhaseExp;}
			set {createPhaseExp = value;}
		}

		///<summary>
		///
		///</summary>
		public string ProposePhaseExp
		{
			get {return proposePhaseExp;}
			set {proposePhaseExp = value;}
		}

		///<summary>
		///
		///</summary>
		public string CallbidPhaseExp
		{
			get {return callbidPhaseExp;}
			set {callbidPhaseExp = value;}
		}

		///<summary>
		///
		///</summary>
		public string TalkPhaseExp
		{
			get {return talkPhaseExp;}
			set {talkPhaseExp = value;}
		}

		///<summary>
		///
		///</summary>
		public string CarryPhaseExp
		{
			get {return carryPhaseExp;}
			set {carryPhaseExp = value;}
		}

		///<summary>
		///
		///</summary>
		public string NeedDescribe
		{
			get {return needDescribe;}
			set {needDescribe = value;}
		}

		///<summary>
		///
		///</summary>
		public string CompitDescribe
		{
			get {return compitDescribe;}
			set {compitDescribe = value;}
		}

		///<summary>
		///
		///</summary>
		public string ClientDescribe
		{
			get {return clientDescribe;}
			set {clientDescribe = value;}
		}

		///<summary>
		///
		///</summary>
		public string TechDescribe
		{
			get {return techDescribe;}
			set {techDescribe = value;}
		}

		///<summary>
		///
		///</summary>
		public string BusinessDescribe
		{
			get {return businessDescribe;}
			set {businessDescribe = value;}
		}

		///<summary>
		///
		///</summary>
		public string RiskDescribe
		{
			get {return riskDescribe;}
			set {riskDescribe = value;}
		}

		///<summary>
		///
		///</summary>
		public string StrategyDesribe
		{
			get {return strategyDesribe;}
			set {strategyDesribe = value;}
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
		public string MarketView
		{
			get {return marketView;}
			set {marketView = value;}
		}

		///<summary>
		///
		///</summary>
		public string TechView
		{
			get {return techView;}
			set {techView = value;}
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
		public string SheetNum
		{
			get {return sheetNum;}
			set {sheetNum = value;}
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
			bool result=  (ProjectCreate.Delete(ProjectCreateId) == 1);
			//更新缓存
			if (result&&CachedEntityCommander.IsTypeRegistered(typeof(ProjectCreateInfo))) 
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
        public void CopyTo(ProjectCreateInfo pProjectCreateInfoTo)
        {
            Copy(this,  pProjectCreateInfoTo);
        }
		
		
		
		
		
		/// <summary>
		/// 保存
		/// </summary>
		public override void Save()
		{
			if(!m_Loaded)//新增
			{
				ProjectCreate projectCreate=new ProjectCreate();	
				SaveToDb(this, projectCreate,true);
			}
			else//修改
			{
				ProjectCreate projectCreate=new ProjectCreate(projectCreateId);	
				if(projectCreate.IsNew)
					throw new AppException("该数据已经不存在了");
				SaveToDb(this, projectCreate,false);
			}
			
		}
		 
		#endregion
		
	}
}
