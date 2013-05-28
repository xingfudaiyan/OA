// ======================================================================================================================================
// 类说明
//=======================================================================================================================================
// 创建者：sk @Copy Right 残友软件有限公司OA项目 
// 文件名：EvaluateLevelInfo.cs
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
	///EvaluateLevelInfo  Data
	/// </summary>
	[Serializable]
	public partial class EvaluateLevelInfo:CanYou.EntityObject
	{
		#region 属性
		///<summary>
		///
		///</summary>
		private int evaluateLevelId;
		///<summary>
		///
		///</summary>
		private string evaluateName = String.Empty;
		
		
		///一对多关系,如果
		private bool m_Loaded=false;
		#endregion
		
		#region 属性枚举
		public struct Fields
		{
			public const string EvaluateLevelId=@"EvaluateLevelId";
			public const string EvaluateName=@"EvaluateName";
						
		}

		#endregion
		
		
		#region 构造函数
		///<summary>
		///
		///</summary>
		public EvaluateLevelInfo()
		{
		}
		///<summary>
		///
		///</summary>
		public EvaluateLevelInfo(int pEvaluateLevelId,string pEvaluateName)
		{
			evaluateLevelId = pEvaluateLevelId;
			evaluateName    = pEvaluateName;
			
		}
		
		
		///<summary>
		///
		///</summary>
		public EvaluateLevelInfo(int evaluateLevelId)
		{
			 LoadFromId(evaluateLevelId);
		}
		
		private void LoadFromId(int evaluateLevelId)
		{
		 
			if (CachedEntityCommander.IsTypeRegistered(typeof(EvaluateLevelInfo)))
            {
				EvaluateLevelInfo evaluateLevelInfo=Find(GetList(), evaluateLevelId);
				if(evaluateLevelInfo==null)
					throw new AppException("未能在缓存中找到相应的键值对象");
                Copy(evaluateLevelInfo, this);
            }
            else
            {	EvaluateLevel evaluateLevel=new EvaluateLevel( evaluateLevelId);	
				if(evaluateLevel.IsNew)
				throw new AppException("尚未初始化");
               	LoadFromDAL(this, evaluateLevel);
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
        public static  EvaluateLevelInfo Find(List< EvaluateLevelInfo> list,  int evaluateLevelId)
        {
             return list.Find(delegate( EvaluateLevelInfo item) { return item. evaluateLevelId==evaluateLevelId; });
        }
		
		
		/// <summary>
        /// 得到缓存键
        /// </summary>
        /// <returns></returns>
        private static string GetCacheKey()
        {
            return string.Format(CachedEntityCommander.CacheKey, typeof( EvaluateLevelInfo).ToString());
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
        public static void Copy(EvaluateLevelInfo pEvaluateLevelInfoFrom, EvaluateLevelInfo pEvaluateLevelInfoTo)
        {
	 		pEvaluateLevelInfoTo.EvaluateLevelId = pEvaluateLevelInfoFrom.evaluateLevelId;
	 		pEvaluateLevelInfoTo.EvaluateName = pEvaluateLevelInfoFrom.evaluateName;
			pEvaluateLevelInfoTo.Loaded=pEvaluateLevelInfoFrom.Loaded;
        }
		
		/// <summary>
		/// 批量装载
		/// </summary>
		internal static void LoadFromDALPatch(List< EvaluateLevelInfo> pList, EvaluateLevelCollection pCollection)
        {
            foreach (EvaluateLevel evaluateLevel in pCollection)
            {
                EvaluateLevelInfo evaluateLevelInfo = new EvaluateLevelInfo();
                LoadFromDAL(evaluateLevelInfo, evaluateLevel );
                pList.Add(evaluateLevelInfo);
            }
			
        }

		//从后台获取数据
		internal  static void  LoadFromDAL(EvaluateLevelInfo pEvaluateLevelInfo, EvaluateLevel  pEvaluateLevel)
		{
	 		pEvaluateLevelInfo.evaluateLevelId = pEvaluateLevel.EvaluateLevelId;
	 		pEvaluateLevelInfo.evaluateName = pEvaluateLevel.EvaluateName;
			pEvaluateLevelInfo.Loaded=true;
			
			}
		
		//数据持久化
		internal  static void  SaveToDb(EvaluateLevelInfo pEvaluateLevelInfo, EvaluateLevel  pEvaluateLevel,bool pIsNew)
		{
	 		pEvaluateLevel.EvaluateLevelId = pEvaluateLevelInfo.evaluateLevelId;
	 		pEvaluateLevel.EvaluateName = pEvaluateLevelInfo.evaluateName;
			pEvaluateLevel.IsNew=pIsNew;
			string UserName = SubsonicHelper.GetUserName();
			try
			{
				pEvaluateLevel.Save(UserName);
			}
			catch(Exception ex)
			{
				LogManager.getInstance().getLogger(typeof(EvaluateLevelInfo)).Error(ex);
				if(ex.Message.Contains("插入重复键"))//违反了唯一键
				{
					throw new AppException("此对象已经存在");//此处等待优化可以从唯一约束中直接取出提示来，如果没有的话，默认为原始的出错提示
				}
				throw new AppException("保存失败");
			}
			pEvaluateLevelInfo.evaluateLevelId = pEvaluateLevel.EvaluateLevelId;
			//如果缓存存在，更新缓存
			if (CachedEntityCommander.IsTypeRegistered(typeof(EvaluateLevelInfo))) 
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
        public static List< EvaluateLevelInfo> GetPagedList(int pPageIndex,int pPageSize,SortDirection pOrderBy,string pSortExpression,out int pRecordCount)
        {
			if(pPageIndex<=1)
			pPageIndex=1;
            List< EvaluateLevelInfo> list = new List< EvaluateLevelInfo>();
          
            Query q = EvaluateLevel .CreateQuery();
            q.PageIndex = pPageIndex;
            q.PageSize = pPageSize;
            q.ORDER_BY(pSortExpression,pOrderBy.ToString());
			EvaluateLevelCollection  collection=new  EvaluateLevelCollection();
		 	collection.LoadAndCloseReader(q.ExecuteReader());
          
            foreach (EvaluateLevel  evaluateLevel  in collection)
            {
                EvaluateLevelInfo evaluateLevelInfo = new EvaluateLevelInfo();
                LoadFromDAL(evaluateLevelInfo,   evaluateLevel);
                list.Add(evaluateLevelInfo);
            }
			pRecordCount=q.GetRecordCount();
			
            return list;

        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		/// <returns></returns>
		public static List< EvaluateLevelInfo> GetList()
		{
			string cacheKey = GetCacheKey();
			//本实体已经注册成缓存实体，并且缓存存在的时候，直接从缓存取
			if (CachedEntityCommander.IsTypeRegistered(typeof(EvaluateLevelInfo)) && CachedEntityCommander.GetCache(cacheKey) != null)
            {
                return CachedEntityCommander.GetCache(cacheKey) as List< EvaluateLevelInfo>;
            }
            else 
            {
				List< EvaluateLevelInfo>  list =new List< EvaluateLevelInfo>();
				EvaluateLevelCollection  collection=new  EvaluateLevelCollection();
				Query qry = new Query(EvaluateLevel.Schema);
				collection.LoadAndCloseReader(qry.ExecuteReader());
				foreach(EvaluateLevel evaluateLevel in collection)
				{
					EvaluateLevelInfo evaluateLevelInfo= new EvaluateLevelInfo();
					LoadFromDAL(evaluateLevelInfo,evaluateLevel);
					list.Add(evaluateLevelInfo);
				}
			  	//生成缓存
                if (CachedEntityCommander.IsTypeRegistered(typeof(EvaluateLevelInfo))) 
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
		public int EvaluateLevelId
		{
			get {return evaluateLevelId;}
			set {evaluateLevelId = value;}
		}

		///<summary>
		///
		///</summary>
		public string EvaluateName
		{
			get {return evaluateName;}
			set {evaluateName = value;}
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
			bool result=  (EvaluateLevel.Delete(EvaluateLevelId) == 1);
			//更新缓存
			if (result&&CachedEntityCommander.IsTypeRegistered(typeof(EvaluateLevelInfo))) 
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
        public void CopyTo(EvaluateLevelInfo pEvaluateLevelInfoTo)
        {
            Copy(this,  pEvaluateLevelInfoTo);
        }
		
		
		
		
		
		/// <summary>
		/// 保存
		/// </summary>
		public override void Save()
		{
			if(!m_Loaded)//新增
			{
				EvaluateLevel evaluateLevel=new EvaluateLevel();	
				SaveToDb(this, evaluateLevel,true);
			}
			else//修改
			{
				EvaluateLevel evaluateLevel=new EvaluateLevel(evaluateLevelId);	
				if(evaluateLevel.IsNew)
					throw new AppException("该数据已经不存在了");
				SaveToDb(this, evaluateLevel,false);
			}
			
		}
		 
		#endregion
		
	}
}
