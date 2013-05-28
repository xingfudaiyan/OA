// ======================================================================================================================================
// 类说明
//=======================================================================================================================================
// 创建者：sk @Copy Right 残友软件有限公司OA项目 
// 文件名：MainProjectCreateInfo.cs
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
	///MainProjectCreateInfo  Data
	/// </summary>
	[Serializable]
	public partial class MainProjectCreateInfo:CanYou.EntityObject
	{
		#region 属性
		///<summary>
		///
		///</summary>
		private int mainProjectCreateId;
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
		private string sheetNum = String.Empty;
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
		
		
		///一对多关系,如果
		private bool m_Loaded=false;
		#endregion
		
		#region 属性枚举
		public struct Fields
		{
			public const string MainProjectCreateId=@"MainProjectCreateId";
			public const string ClientId=@"ClientId";
			public const string ProjectLevelId=@"ProjectLevelId";
			public const string ProjectTypeId=@"ProjectTypeId";
			public const string YeWuId=@"YeWuId";
			public const string SheetNum=@"SheetNum";
			public const string ProjectName=@"ProjectName";
			public const string PreMoney=@"PreMoney";
			public const string PreProfit=@"PreProfit";
						
		}

		#endregion
		
		
		#region 构造函数
		///<summary>
		///
		///</summary>
		public MainProjectCreateInfo()
		{
		}
		///<summary>
		///
		///</summary>
		public MainProjectCreateInfo(int pMainProjectCreateId,int? pClientId,int? pProjectLevelId,int? pProjectTypeId,int? pYeWuId,string pSheetNum,string pProjectName,string pPreMoney,string pPreProfit)
		{
			mainProjectCreateId = pMainProjectCreateId;
			clientId            = pClientId;
			projectLevelId      = pProjectLevelId;
			projectTypeId       = pProjectTypeId;
			yeWuId              = pYeWuId;
			sheetNum            = pSheetNum;
			projectName         = pProjectName;
			preMoney            = pPreMoney;
			preProfit           = pPreProfit;
			
		}
		
		
		///<summary>
		///
		///</summary>
		public MainProjectCreateInfo(int mainProjectCreateId)
		{
			 LoadFromId(mainProjectCreateId);
		}
		
		private void LoadFromId(int mainProjectCreateId)
		{
		 
			if (CachedEntityCommander.IsTypeRegistered(typeof(MainProjectCreateInfo)))
            {
				MainProjectCreateInfo mainProjectCreateInfo=Find(GetList(), mainProjectCreateId);
				if(mainProjectCreateInfo==null)
					throw new AppException("未能在缓存中找到相应的键值对象");
                Copy(mainProjectCreateInfo, this);
            }
            else
            {	MainProjectCreate mainProjectCreate=new MainProjectCreate( mainProjectCreateId);	
				if(mainProjectCreate.IsNew)
				throw new AppException("尚未初始化");
               	LoadFromDAL(this, mainProjectCreate);
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
        public static  MainProjectCreateInfo Find(List< MainProjectCreateInfo> list,  int mainProjectCreateId)
        {
             return list.Find(delegate( MainProjectCreateInfo item) { return item. mainProjectCreateId==mainProjectCreateId; });
        }
		
		
		/// <summary>
        /// 得到缓存键
        /// </summary>
        /// <returns></returns>
        private static string GetCacheKey()
        {
            return string.Format(CachedEntityCommander.CacheKey, typeof( MainProjectCreateInfo).ToString());
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
        public static void Copy(MainProjectCreateInfo pMainProjectCreateInfoFrom, MainProjectCreateInfo pMainProjectCreateInfoTo)
        {
	 		pMainProjectCreateInfoTo.MainProjectCreateId = pMainProjectCreateInfoFrom.mainProjectCreateId;
	 		pMainProjectCreateInfoTo.ClientId = pMainProjectCreateInfoFrom.clientId;
	 		pMainProjectCreateInfoTo.ProjectLevelId = pMainProjectCreateInfoFrom.projectLevelId;
	 		pMainProjectCreateInfoTo.ProjectTypeId = pMainProjectCreateInfoFrom.projectTypeId;
	 		pMainProjectCreateInfoTo.YeWuId = pMainProjectCreateInfoFrom.yeWuId;
	 		pMainProjectCreateInfoTo.SheetNum = pMainProjectCreateInfoFrom.sheetNum;
	 		pMainProjectCreateInfoTo.ProjectName = pMainProjectCreateInfoFrom.projectName;
	 		pMainProjectCreateInfoTo.PreMoney = pMainProjectCreateInfoFrom.preMoney;
	 		pMainProjectCreateInfoTo.PreProfit = pMainProjectCreateInfoFrom.preProfit;
			pMainProjectCreateInfoTo.Loaded=pMainProjectCreateInfoFrom.Loaded;
        }
		
		/// <summary>
		/// 批量装载
		/// </summary>
		internal static void LoadFromDALPatch(List< MainProjectCreateInfo> pList, MainProjectCreateCollection pCollection)
        {
            foreach (MainProjectCreate mainProjectCreate in pCollection)
            {
                MainProjectCreateInfo mainProjectCreateInfo = new MainProjectCreateInfo();
                LoadFromDAL(mainProjectCreateInfo, mainProjectCreate );
                pList.Add(mainProjectCreateInfo);
            }
			
        }

		//从后台获取数据
		internal  static void  LoadFromDAL(MainProjectCreateInfo pMainProjectCreateInfo, MainProjectCreate  pMainProjectCreate)
		{
	 		pMainProjectCreateInfo.mainProjectCreateId = pMainProjectCreate.MainProjectCreateId;
	 		pMainProjectCreateInfo.clientId = pMainProjectCreate.ClientId;
	 		pMainProjectCreateInfo.projectLevelId = pMainProjectCreate.ProjectLevelId;
	 		pMainProjectCreateInfo.projectTypeId = pMainProjectCreate.ProjectTypeId;
	 		pMainProjectCreateInfo.yeWuId = pMainProjectCreate.YeWuId;
	 		pMainProjectCreateInfo.sheetNum = pMainProjectCreate.SheetNum;
	 		pMainProjectCreateInfo.projectName = pMainProjectCreate.ProjectName;
	 		pMainProjectCreateInfo.preMoney = pMainProjectCreate.PreMoney;
	 		pMainProjectCreateInfo.preProfit = pMainProjectCreate.PreProfit;
			pMainProjectCreateInfo.Loaded=true;
			
			}
		
		//数据持久化
		internal  static void  SaveToDb(MainProjectCreateInfo pMainProjectCreateInfo, MainProjectCreate  pMainProjectCreate,bool pIsNew)
		{
	 		pMainProjectCreate.MainProjectCreateId = pMainProjectCreateInfo.mainProjectCreateId;
	 		pMainProjectCreate.ClientId = pMainProjectCreateInfo.clientId;
	 		pMainProjectCreate.ProjectLevelId = pMainProjectCreateInfo.projectLevelId;
	 		pMainProjectCreate.ProjectTypeId = pMainProjectCreateInfo.projectTypeId;
	 		pMainProjectCreate.YeWuId = pMainProjectCreateInfo.yeWuId;
	 		pMainProjectCreate.SheetNum = pMainProjectCreateInfo.sheetNum;
	 		pMainProjectCreate.ProjectName = pMainProjectCreateInfo.projectName;
	 		pMainProjectCreate.PreMoney = pMainProjectCreateInfo.preMoney;
	 		pMainProjectCreate.PreProfit = pMainProjectCreateInfo.preProfit;
			pMainProjectCreate.IsNew=pIsNew;
			string UserName = SubsonicHelper.GetUserName();
			try
			{
				pMainProjectCreate.Save(UserName);
			}
			catch(Exception ex)
			{
				LogManager.getInstance().getLogger(typeof(MainProjectCreateInfo)).Error(ex);
				if(ex.Message.Contains("插入重复键"))//违反了唯一键
				{
					throw new AppException("此对象已经存在");//此处等待优化可以从唯一约束中直接取出提示来，如果没有的话，默认为原始的出错提示
				}
				throw new AppException("保存失败");
			}
			pMainProjectCreateInfo.mainProjectCreateId = pMainProjectCreate.MainProjectCreateId;
			//如果缓存存在，更新缓存
			if (CachedEntityCommander.IsTypeRegistered(typeof(MainProjectCreateInfo))) 
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
        public static List< MainProjectCreateInfo> GetPagedList(int pPageIndex,int pPageSize,SortDirection pOrderBy,string pSortExpression,out int pRecordCount)
        {
			if(pPageIndex<=1)
			pPageIndex=1;
            List< MainProjectCreateInfo> list = new List< MainProjectCreateInfo>();
          
            Query q = MainProjectCreate .CreateQuery();
            q.PageIndex = pPageIndex;
            q.PageSize = pPageSize;
            q.ORDER_BY(pSortExpression,pOrderBy.ToString());
			MainProjectCreateCollection  collection=new  MainProjectCreateCollection();
		 	collection.LoadAndCloseReader(q.ExecuteReader());
          
            foreach (MainProjectCreate  mainProjectCreate  in collection)
            {
                MainProjectCreateInfo mainProjectCreateInfo = new MainProjectCreateInfo();
                LoadFromDAL(mainProjectCreateInfo,   mainProjectCreate);
                list.Add(mainProjectCreateInfo);
            }
			pRecordCount=q.GetRecordCount();
			
            return list;

        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		/// <returns></returns>
		public static List< MainProjectCreateInfo> GetList()
		{
			string cacheKey = GetCacheKey();
			//本实体已经注册成缓存实体，并且缓存存在的时候，直接从缓存取
			if (CachedEntityCommander.IsTypeRegistered(typeof(MainProjectCreateInfo)) && CachedEntityCommander.GetCache(cacheKey) != null)
            {
                return CachedEntityCommander.GetCache(cacheKey) as List< MainProjectCreateInfo>;
            }
            else 
            {
				List< MainProjectCreateInfo>  list =new List< MainProjectCreateInfo>();
				MainProjectCreateCollection  collection=new  MainProjectCreateCollection();
				Query qry = new Query(MainProjectCreate.Schema);
				collection.LoadAndCloseReader(qry.ExecuteReader());
				foreach(MainProjectCreate mainProjectCreate in collection)
				{
					MainProjectCreateInfo mainProjectCreateInfo= new MainProjectCreateInfo();
					LoadFromDAL(mainProjectCreateInfo,mainProjectCreate);
					list.Add(mainProjectCreateInfo);
				}
			  	//生成缓存
                if (CachedEntityCommander.IsTypeRegistered(typeof(MainProjectCreateInfo))) 
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
		public int MainProjectCreateId
		{
			get {return mainProjectCreateId;}
			set {mainProjectCreateId = value;}
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
		public string SheetNum
		{
			get {return sheetNum;}
			set {sheetNum = value;}
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
			bool result=  (MainProjectCreate.Delete(MainProjectCreateId) == 1);
			//更新缓存
			if (result&&CachedEntityCommander.IsTypeRegistered(typeof(MainProjectCreateInfo))) 
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
        public void CopyTo(MainProjectCreateInfo pMainProjectCreateInfoTo)
        {
            Copy(this,  pMainProjectCreateInfoTo);
        }
		
		
		
		
		
		/// <summary>
		/// 保存
		/// </summary>
		public override void Save()
		{
			if(!m_Loaded)//新增
			{
				MainProjectCreate mainProjectCreate=new MainProjectCreate();	
				SaveToDb(this, mainProjectCreate,true);
			}
			else//修改
			{
				MainProjectCreate mainProjectCreate=new MainProjectCreate(mainProjectCreateId);	
				if(mainProjectCreate.IsNew)
					throw new AppException("该数据已经不存在了");
				SaveToDb(this, mainProjectCreate,false);
			}
			
		}
		 
		#endregion
		
	}
}
