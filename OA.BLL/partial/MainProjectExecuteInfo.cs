// ======================================================================================================================================
// 类说明
//=======================================================================================================================================
// 创建者：sk @Copy Right 残友软件有限公司OA项目 
// 文件名：MainProjectExecuteInfo.cs
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
	///MainProjectExecuteInfo  Data
	/// </summary>
	[Serializable]
	public partial class MainProjectExecuteInfo:CanYou.EntityObject
	{
		#region 属性
		///<summary>
		///
		///</summary>
		private int mainProjectExecuteId;
		///<summary>
		///
		///</summary>
		private string mainProjectExecuteName = String.Empty;
		
		
		///一对多关系,如果
		private bool m_Loaded=false;
		#endregion
		
		#region 属性枚举
		public struct Fields
		{
			public const string MainProjectExecuteId=@"MainProjectExecuteId";
			public const string MainProjectExecuteName=@"MainProjectExecuteName";
						
		}

		#endregion
		
		
		#region 构造函数
		///<summary>
		///
		///</summary>
		public MainProjectExecuteInfo()
		{
		}
		///<summary>
		///
		///</summary>
		public MainProjectExecuteInfo(int pMainProjectExecuteId,string pMainProjectExecuteName)
		{
			mainProjectExecuteId   = pMainProjectExecuteId;
			mainProjectExecuteName = pMainProjectExecuteName;
			
		}
		
		
		///<summary>
		///
		///</summary>
		public MainProjectExecuteInfo(int mainProjectExecuteId)
		{
			 LoadFromId(mainProjectExecuteId);
		}
		
		private void LoadFromId(int mainProjectExecuteId)
		{
		 
			if (CachedEntityCommander.IsTypeRegistered(typeof(MainProjectExecuteInfo)))
            {
				MainProjectExecuteInfo mainProjectExecuteInfo=Find(GetList(), mainProjectExecuteId);
				if(mainProjectExecuteInfo==null)
					throw new AppException("未能在缓存中找到相应的键值对象");
                Copy(mainProjectExecuteInfo, this);
            }
            else
            {	MainProjectExecute mainProjectExecute=new MainProjectExecute( mainProjectExecuteId);	
				if(mainProjectExecute.IsNew)
				throw new AppException("尚未初始化");
               	LoadFromDAL(this, mainProjectExecute);
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
        public static  MainProjectExecuteInfo Find(List< MainProjectExecuteInfo> list,  int mainProjectExecuteId)
        {
             return list.Find(delegate( MainProjectExecuteInfo item) { return item. mainProjectExecuteId==mainProjectExecuteId; });
        }
		
		
		/// <summary>
        /// 得到缓存键
        /// </summary>
        /// <returns></returns>
        private static string GetCacheKey()
        {
            return string.Format(CachedEntityCommander.CacheKey, typeof( MainProjectExecuteInfo).ToString());
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
        public static void Copy(MainProjectExecuteInfo pMainProjectExecuteInfoFrom, MainProjectExecuteInfo pMainProjectExecuteInfoTo)
        {
	 		pMainProjectExecuteInfoTo.MainProjectExecuteId = pMainProjectExecuteInfoFrom.mainProjectExecuteId;
	 		pMainProjectExecuteInfoTo.MainProjectExecuteName = pMainProjectExecuteInfoFrom.mainProjectExecuteName;
			pMainProjectExecuteInfoTo.Loaded=pMainProjectExecuteInfoFrom.Loaded;
        }
		
		/// <summary>
		/// 批量装载
		/// </summary>
		internal static void LoadFromDALPatch(List< MainProjectExecuteInfo> pList, MainProjectExecuteCollection pCollection)
        {
            foreach (MainProjectExecute mainProjectExecute in pCollection)
            {
                MainProjectExecuteInfo mainProjectExecuteInfo = new MainProjectExecuteInfo();
                LoadFromDAL(mainProjectExecuteInfo, mainProjectExecute );
                pList.Add(mainProjectExecuteInfo);
            }
			
        }

		//从后台获取数据
		internal  static void  LoadFromDAL(MainProjectExecuteInfo pMainProjectExecuteInfo, MainProjectExecute  pMainProjectExecute)
		{
	 		pMainProjectExecuteInfo.mainProjectExecuteId = pMainProjectExecute.MainProjectExecuteId;
	 		pMainProjectExecuteInfo.mainProjectExecuteName = pMainProjectExecute.MainProjectExecuteName;
			pMainProjectExecuteInfo.Loaded=true;
			
			}
		
		//数据持久化
		internal  static void  SaveToDb(MainProjectExecuteInfo pMainProjectExecuteInfo, MainProjectExecute  pMainProjectExecute,bool pIsNew)
		{
	 		pMainProjectExecute.MainProjectExecuteId = pMainProjectExecuteInfo.mainProjectExecuteId;
	 		pMainProjectExecute.MainProjectExecuteName = pMainProjectExecuteInfo.mainProjectExecuteName;
			pMainProjectExecute.IsNew=pIsNew;
			string UserName = SubsonicHelper.GetUserName();
			try
			{
				pMainProjectExecute.Save(UserName);
			}
			catch(Exception ex)
			{
				LogManager.getInstance().getLogger(typeof(MainProjectExecuteInfo)).Error(ex);
				if(ex.Message.Contains("插入重复键"))//违反了唯一键
				{
					throw new AppException("此对象已经存在");//此处等待优化可以从唯一约束中直接取出提示来，如果没有的话，默认为原始的出错提示
				}
				throw new AppException("保存失败");
			}
			pMainProjectExecuteInfo.mainProjectExecuteId = pMainProjectExecute.MainProjectExecuteId;
			//如果缓存存在，更新缓存
			if (CachedEntityCommander.IsTypeRegistered(typeof(MainProjectExecuteInfo))) 
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
        public static List< MainProjectExecuteInfo> GetPagedList(int pPageIndex,int pPageSize,SortDirection pOrderBy,string pSortExpression,out int pRecordCount)
        {
			if(pPageIndex<=1)
			pPageIndex=1;
            List< MainProjectExecuteInfo> list = new List< MainProjectExecuteInfo>();
          
            Query q = MainProjectExecute .CreateQuery();
            q.PageIndex = pPageIndex;
            q.PageSize = pPageSize;
            q.ORDER_BY(pSortExpression,pOrderBy.ToString());
			MainProjectExecuteCollection  collection=new  MainProjectExecuteCollection();
		 	collection.LoadAndCloseReader(q.ExecuteReader());
          
            foreach (MainProjectExecute  mainProjectExecute  in collection)
            {
                MainProjectExecuteInfo mainProjectExecuteInfo = new MainProjectExecuteInfo();
                LoadFromDAL(mainProjectExecuteInfo,   mainProjectExecute);
                list.Add(mainProjectExecuteInfo);
            }
			pRecordCount=q.GetRecordCount();
			
            return list;

        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		/// <returns></returns>
		public static List< MainProjectExecuteInfo> GetList()
		{
			string cacheKey = GetCacheKey();
			//本实体已经注册成缓存实体，并且缓存存在的时候，直接从缓存取
			if (CachedEntityCommander.IsTypeRegistered(typeof(MainProjectExecuteInfo)) && CachedEntityCommander.GetCache(cacheKey) != null)
            {
                return CachedEntityCommander.GetCache(cacheKey) as List< MainProjectExecuteInfo>;
            }
            else 
            {
				List< MainProjectExecuteInfo>  list =new List< MainProjectExecuteInfo>();
				MainProjectExecuteCollection  collection=new  MainProjectExecuteCollection();
				Query qry = new Query(MainProjectExecute.Schema);
				collection.LoadAndCloseReader(qry.ExecuteReader());
				foreach(MainProjectExecute mainProjectExecute in collection)
				{
					MainProjectExecuteInfo mainProjectExecuteInfo= new MainProjectExecuteInfo();
					LoadFromDAL(mainProjectExecuteInfo,mainProjectExecute);
					list.Add(mainProjectExecuteInfo);
				}
			  	//生成缓存
                if (CachedEntityCommander.IsTypeRegistered(typeof(MainProjectExecuteInfo))) 
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
		public int MainProjectExecuteId
		{
			get {return mainProjectExecuteId;}
			set {mainProjectExecuteId = value;}
		}

		///<summary>
		///
		///</summary>
		public string MainProjectExecuteName
		{
			get {return mainProjectExecuteName;}
			set {mainProjectExecuteName = value;}
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
			bool result=  (MainProjectExecute.Delete(MainProjectExecuteId) == 1);
			//更新缓存
			if (result&&CachedEntityCommander.IsTypeRegistered(typeof(MainProjectExecuteInfo))) 
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
        public void CopyTo(MainProjectExecuteInfo pMainProjectExecuteInfoTo)
        {
            Copy(this,  pMainProjectExecuteInfoTo);
        }
		
		
		
		
		
		/// <summary>
		/// 保存
		/// </summary>
		public override void Save()
		{
			if(!m_Loaded)//新增
			{
				MainProjectExecute mainProjectExecute=new MainProjectExecute();	
				SaveToDb(this, mainProjectExecute,true);
			}
			else//修改
			{
				MainProjectExecute mainProjectExecute=new MainProjectExecute(mainProjectExecuteId);	
				if(mainProjectExecute.IsNew)
					throw new AppException("该数据已经不存在了");
				SaveToDb(this, mainProjectExecute,false);
			}
			
		}
		 
		#endregion
		
	}
}
