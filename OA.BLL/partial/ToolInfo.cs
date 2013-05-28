// ======================================================================================================================================
// 类说明
//=======================================================================================================================================
// 创建者：sk @Copy Right 残友软件有限公司OA项目 
// 文件名：ToolInfo.cs
// 创建时间：2012-11-2
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
	///ToolInfo  Data
	/// </summary>
	[Serializable]
	public partial class ToolInfo:CanYou.EntityObject
	{
		#region 属性
		///<summary>
		///
		///</summary>
		private int toolId;
		///<summary>
		///
		///</summary>
		private int? toolNumId;
		///<summary>
		///
		///</summary>
		private string applyTime = String.Empty;
		///<summary>
		///
		///</summary>
		private string departName = String.Empty;
		///<summary>
		///
		///</summary>
		private string applyName = String.Empty;
		///<summary>
		///
		///</summary>
		private int? state;
		///<summary>
		///
		///</summary>
		private string techMemo = String.Empty;
		///<summary>
		///
		///</summary>
		private string marketMemo = String.Empty;
		///<summary>
		///
		///</summary>
		private string zongHeMemo = String.Empty;
		///<summary>
		///
		///</summary>
		private string departView = String.Empty;
		///<summary>
		///
		///</summary>
		private string managerView = String.Empty;
		
		
		///一对多关系,如果
		private bool m_Loaded=false;
		#endregion
		
		#region 属性枚举
		public struct Fields
		{
			public const string ToolId=@"ToolId";
			public const string ToolNumId=@"ToolNumId";
			public const string ApplyTime=@"ApplyTime";
			public const string DepartName=@"DepartName";
			public const string ApplyName=@"ApplyName";
			public const string State=@"State";
			public const string TechMemo=@"TechMemo";
			public const string MarketMemo=@"MarketMemo";
			public const string ZongHeMemo=@"ZongHeMemo";
			public const string DepartView=@"DepartView";
			public const string ManagerView=@"ManagerView";
						
		}

		#endregion
		
		
		#region 构造函数
		///<summary>
		///
		///</summary>
		public ToolInfo()
		{
		}
		///<summary>
		///
		///</summary>
		public ToolInfo(int pToolId,int? pToolNumId,string pApplyTime,string pDepartName,string pApplyName,int? pState,string pTechMemo,string pMarketMemo,string pZongHeMemo,string pDepartView,string pManagerView)
		{
			toolId      = pToolId;
			toolNumId   = pToolNumId;
			applyTime   = pApplyTime;
			departName  = pDepartName;
			applyName   = pApplyName;
			state       = pState;
			techMemo    = pTechMemo;
			marketMemo  = pMarketMemo;
			zongHeMemo  = pZongHeMemo;
			departView  = pDepartView;
			managerView = pManagerView;
			
		}
		
		
		///<summary>
		///
		///</summary>
		public ToolInfo(int toolId)
		{
			 LoadFromId(toolId);
		}
		
		private void LoadFromId(int toolId)
		{
		 
			if (CachedEntityCommander.IsTypeRegistered(typeof(ToolInfo)))
            {
				ToolInfo toolInfo=Find(GetList(), toolId);
				if(toolInfo==null)
					throw new AppException("未能在缓存中找到相应的键值对象");
                Copy(toolInfo, this);
            }
            else
            {	Tool tool=new Tool( toolId);	
				if(tool.IsNew)
				throw new AppException("尚未初始化");
               	LoadFromDAL(this, tool);
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
        public static  ToolInfo Find(List< ToolInfo> list,  int toolId)
        {
             return list.Find(delegate( ToolInfo item) { return item. toolId==toolId; });
        }
		
		
		/// <summary>
        /// 得到缓存键
        /// </summary>
        /// <returns></returns>
        private static string GetCacheKey()
        {
            return string.Format(CachedEntityCommander.CacheKey, typeof( ToolInfo).ToString());
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
        public static void Copy(ToolInfo pToolInfoFrom, ToolInfo pToolInfoTo)
        {
	 		pToolInfoTo.ToolId = pToolInfoFrom.toolId;
	 		pToolInfoTo.ToolNumId = pToolInfoFrom.toolNumId;
	 		pToolInfoTo.ApplyTime = pToolInfoFrom.applyTime;
	 		pToolInfoTo.DepartName = pToolInfoFrom.departName;
	 		pToolInfoTo.ApplyName = pToolInfoFrom.applyName;
	 		pToolInfoTo.State = pToolInfoFrom.state;
	 		pToolInfoTo.TechMemo = pToolInfoFrom.techMemo;
	 		pToolInfoTo.MarketMemo = pToolInfoFrom.marketMemo;
	 		pToolInfoTo.ZongHeMemo = pToolInfoFrom.zongHeMemo;
	 		pToolInfoTo.DepartView = pToolInfoFrom.departView;
	 		pToolInfoTo.ManagerView = pToolInfoFrom.managerView;
			pToolInfoTo.Loaded=pToolInfoFrom.Loaded;
        }
		
		/// <summary>
		/// 批量装载
		/// </summary>
		internal static void LoadFromDALPatch(List< ToolInfo> pList, ToolCollection pCollection)
        {
            foreach (Tool tool in pCollection)
            {
                ToolInfo toolInfo = new ToolInfo();
                LoadFromDAL(toolInfo, tool );
                pList.Add(toolInfo);
            }
			
        }

		//从后台获取数据
		internal  static void  LoadFromDAL(ToolInfo pToolInfo, Tool  pTool)
		{
	 		pToolInfo.toolId = pTool.ToolId;
	 		pToolInfo.toolNumId = pTool.ToolNumId;
	 		pToolInfo.applyTime = pTool.ApplyTime;
	 		pToolInfo.departName = pTool.DepartName;
	 		pToolInfo.applyName = pTool.ApplyName;
	 		pToolInfo.state = pTool.State;
	 		pToolInfo.techMemo = pTool.TechMemo;
	 		pToolInfo.marketMemo = pTool.MarketMemo;
	 		pToolInfo.zongHeMemo = pTool.ZongHeMemo;
	 		pToolInfo.departView = pTool.DepartView;
	 		pToolInfo.managerView = pTool.ManagerView;
			pToolInfo.Loaded=true;
			
			}
		
		//数据持久化
		internal  static void  SaveToDb(ToolInfo pToolInfo, Tool  pTool,bool pIsNew)
		{
	 		pTool.ToolId = pToolInfo.toolId;
	 		pTool.ToolNumId = pToolInfo.toolNumId;
	 		pTool.ApplyTime = pToolInfo.applyTime;
	 		pTool.DepartName = pToolInfo.departName;
	 		pTool.ApplyName = pToolInfo.applyName;
	 		pTool.State = pToolInfo.state;
	 		pTool.TechMemo = pToolInfo.techMemo;
	 		pTool.MarketMemo = pToolInfo.marketMemo;
	 		pTool.ZongHeMemo = pToolInfo.zongHeMemo;
	 		pTool.DepartView = pToolInfo.departView;
	 		pTool.ManagerView = pToolInfo.managerView;
			pTool.IsNew=pIsNew;
			string UserName = SubsonicHelper.GetUserName();
			try
			{
				pTool.Save(UserName);
			}
			catch(Exception ex)
			{
				LogManager.getInstance().getLogger(typeof(ToolInfo)).Error(ex);
				if(ex.Message.Contains("插入重复键"))//违反了唯一键
				{
					throw new AppException("此对象已经存在");//此处等待优化可以从唯一约束中直接取出提示来，如果没有的话，默认为原始的出错提示
				}
				throw new AppException("保存失败");
			}
			pToolInfo.toolId = pTool.ToolId;
			//如果缓存存在，更新缓存
			if (CachedEntityCommander.IsTypeRegistered(typeof(ToolInfo))) 
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
        public static List< ToolInfo> GetPagedList(int pPageIndex,int pPageSize,SortDirection pOrderBy,string pSortExpression,out int pRecordCount)
        {
			if(pPageIndex<=1)
			pPageIndex=1;
            List< ToolInfo> list = new List< ToolInfo>();
          
            Query q = Tool .CreateQuery();
            q.PageIndex = pPageIndex;
            q.PageSize = pPageSize;
            q.ORDER_BY(pSortExpression,pOrderBy.ToString());
			ToolCollection  collection=new  ToolCollection();
		 	collection.LoadAndCloseReader(q.ExecuteReader());
          
            foreach (Tool  tool  in collection)
            {
                ToolInfo toolInfo = new ToolInfo();
                LoadFromDAL(toolInfo,   tool);
                list.Add(toolInfo);
            }
			pRecordCount=q.GetRecordCount();
			
            return list;

        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		/// <returns></returns>
		public static List< ToolInfo> GetList()
		{
			string cacheKey = GetCacheKey();
			//本实体已经注册成缓存实体，并且缓存存在的时候，直接从缓存取
			if (CachedEntityCommander.IsTypeRegistered(typeof(ToolInfo)) && CachedEntityCommander.GetCache(cacheKey) != null)
            {
                return CachedEntityCommander.GetCache(cacheKey) as List< ToolInfo>;
            }
            else 
            {
				List< ToolInfo>  list =new List< ToolInfo>();
				ToolCollection  collection=new  ToolCollection();
				Query qry = new Query(Tool.Schema);
				collection.LoadAndCloseReader(qry.ExecuteReader());
				foreach(Tool tool in collection)
				{
					ToolInfo toolInfo= new ToolInfo();
					LoadFromDAL(toolInfo,tool);
					list.Add(toolInfo);
				}
			  	//生成缓存
                if (CachedEntityCommander.IsTypeRegistered(typeof(ToolInfo))) 
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
		public int ToolId
		{
			get {return toolId;}
			set {toolId = value;}
		}

		///<summary>
		///
		///</summary>
		public int? ToolNumId
		{
			get {return toolNumId;}
			set {toolNumId = value;}
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
		public string DepartName
		{
			get {return departName;}
			set {departName = value;}
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
		public int? State
		{
			get {return state;}
			set {state = value;}
		}

		///<summary>
		///
		///</summary>
		public string TechMemo
		{
			get {return techMemo;}
			set {techMemo = value;}
		}

		///<summary>
		///
		///</summary>
		public string MarketMemo
		{
			get {return marketMemo;}
			set {marketMemo = value;}
		}

		///<summary>
		///
		///</summary>
		public string ZongHeMemo
		{
			get {return zongHeMemo;}
			set {zongHeMemo = value;}
		}

		///<summary>
		///
		///</summary>
		public string DepartView
		{
			get {return departView;}
			set {departView = value;}
		}

		///<summary>
		///
		///</summary>
		public string ManagerView
		{
			get {return managerView;}
			set {managerView = value;}
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
			bool result=  (Tool.Delete(ToolId) == 1);
			//更新缓存
			if (result&&CachedEntityCommander.IsTypeRegistered(typeof(ToolInfo))) 
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
        public void CopyTo(ToolInfo pToolInfoTo)
        {
            Copy(this,  pToolInfoTo);
        }
		
		
		
		
		
		/// <summary>
		/// 保存
		/// </summary>
		public override void Save()
		{
			if(!m_Loaded)//新增
			{
				Tool tool=new Tool();	
				SaveToDb(this, tool,true);
			}
			else//修改
			{
				Tool tool=new Tool(toolId);	
				if(tool.IsNew)
					throw new AppException("该数据已经不存在了");
				SaveToDb(this, tool,false);
			}
			
		}
		 
		#endregion
		
	}
}
