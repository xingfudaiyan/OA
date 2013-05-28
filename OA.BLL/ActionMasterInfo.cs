// ======================================================================================================================================
// 类说明
//=======================================================================================================================================
// 创建者：sk @Copy Right 残友软件有限公司OA项目 
// 文件名：ActionMasterInfo.cs
// 创建时间：2012-3-28
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
	///ActionMasterInfo  Data
	/// </summary>
	[Serializable]
	public partial class ActionMasterInfo:CanYou.EntityObject
	{
		#region 属性
		///<summary>
		///
		///</summary>
		private int actionMasterId;
		///<summary>
		///
		///</summary>
		private int actionId;
		///<summary>
		///
		///</summary>
		private int masterId;
		///<summary>
		///
		///</summary>
		private int? isPass;
		
		
		///一对多关系,如果
		private bool m_Loaded=false;
		#endregion
		
		#region 属性枚举
		public struct Fields
		{
			public const string ActionMasterId=@"ActionMasterId";
			public const string ActionId=@"ActionId";
			public const string MasterId=@"MasterId";
			public const string IsPass=@"IsPass";
						
		}

		#endregion
		
		
		#region 构造函数
		///<summary>
		///
		///</summary>
		public ActionMasterInfo()
		{
		}
		///<summary>
		///
		///</summary>
		public ActionMasterInfo(int pActionMasterId,int pActionId,int pMasterId,int? pIsPass)
		{
			actionMasterId = pActionMasterId;
			actionId       = pActionId;
			masterId       = pMasterId;
			isPass         = pIsPass;
			
		}
		
		
		///<summary>
		///
		///</summary>
		public ActionMasterInfo(int actionMasterId)
		{
			 LoadFromId(actionMasterId);
		}
		
		private void LoadFromId(int actionMasterId)
		{
		 
			if (CachedEntityCommander.IsTypeRegistered(typeof(ActionMasterInfo)))
            {
				ActionMasterInfo actionMasterInfo=Find(GetList(), actionMasterId);
				if(actionMasterInfo==null)
					throw new AppException("未能在缓存中找到相应的键值对象");
                Copy(actionMasterInfo, this);
            }
            else
            {	ActionMaster actionMaster=new ActionMaster( actionMasterId);	
				if(actionMaster.IsNew)
				throw new AppException("尚未初始化");
               	LoadFromDAL(this, actionMaster);
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
        public static  ActionMasterInfo Find(List< ActionMasterInfo> list,  int actionMasterId)
        {
             return list.Find(delegate( ActionMasterInfo item) { return item. actionMasterId==actionMasterId; });
        }
		
		
		/// <summary>
        /// 得到缓存键
        /// </summary>
        /// <returns></returns>
        private static string GetCacheKey()
        {
            return string.Format(CachedEntityCommander.CacheKey, typeof( ActionMasterInfo).ToString());
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
        public static void Copy(ActionMasterInfo pActionMasterInfoFrom, ActionMasterInfo pActionMasterInfoTo)
        {
	 		pActionMasterInfoTo.ActionMasterId = pActionMasterInfoFrom.actionMasterId;
	 		pActionMasterInfoTo.ActionId = pActionMasterInfoFrom.actionId;
	 		pActionMasterInfoTo.MasterId = pActionMasterInfoFrom.masterId;
	 		pActionMasterInfoTo.IsPass = pActionMasterInfoFrom.isPass;
			pActionMasterInfoTo.Loaded=pActionMasterInfoFrom.Loaded;
        }
		
		/// <summary>
		/// 批量装载
		/// </summary>
		internal static void LoadFromDALPatch(List< ActionMasterInfo> pList, ActionMasterCollection pCollection)
        {
            foreach (ActionMaster actionMaster in pCollection)
            {
                ActionMasterInfo actionMasterInfo = new ActionMasterInfo();
                LoadFromDAL(actionMasterInfo, actionMaster );
                pList.Add(actionMasterInfo);
            }
			
        }

		//从后台获取数据
		internal  static void  LoadFromDAL(ActionMasterInfo pActionMasterInfo, ActionMaster  pActionMaster)
		{
	 		pActionMasterInfo.actionMasterId = pActionMaster.ActionMasterId;
	 		pActionMasterInfo.actionId = pActionMaster.ActionId;
	 		pActionMasterInfo.masterId = pActionMaster.MasterId;
	 		pActionMasterInfo.isPass = pActionMaster.IsPass;
			pActionMasterInfo.Loaded=true;
			
			}
		
		//数据持久化
		internal  static void  SaveToDb(ActionMasterInfo pActionMasterInfo, ActionMaster  pActionMaster,bool pIsNew)
		{
	 		pActionMaster.ActionMasterId = pActionMasterInfo.actionMasterId;
	 		pActionMaster.ActionId = pActionMasterInfo.actionId;
	 		pActionMaster.MasterId = pActionMasterInfo.masterId;
	 		pActionMaster.IsPass = pActionMasterInfo.isPass;
			pActionMaster.IsNew=pIsNew;
			string UserName = SubsonicHelper.GetUserName();
			try
			{
				pActionMaster.Save(UserName);
			}
			catch(Exception ex)
			{
				LogManager.getInstance().getLogger(typeof(ActionMasterInfo)).Error(ex);
				if(ex.Message.Contains("插入重复键"))//违反了唯一键
				{
					throw new AppException("此对象已经存在");//此处等待优化可以从唯一约束中直接取出提示来，如果没有的话，默认为原始的出错提示
				}
				throw new AppException("保存失败");
			}
			pActionMasterInfo.actionMasterId = pActionMaster.ActionMasterId;
			//如果缓存存在，更新缓存
			if (CachedEntityCommander.IsTypeRegistered(typeof(ActionMasterInfo))) 
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
        public static List< ActionMasterInfo> GetPagedList(int pPageIndex,int pPageSize,SortDirection pOrderBy,string pSortExpression,out int pRecordCount)
        {
			if(pPageIndex<=1)
			pPageIndex=1;
            List< ActionMasterInfo> list = new List< ActionMasterInfo>();
          
            Query q = ActionMaster .CreateQuery();
            q.PageIndex = pPageIndex;
            q.PageSize = pPageSize;
            q.ORDER_BY(pSortExpression,pOrderBy.ToString());
			ActionMasterCollection  collection=new  ActionMasterCollection();
		 	collection.LoadAndCloseReader(q.ExecuteReader());
          
            foreach (ActionMaster  actionMaster  in collection)
            {
                ActionMasterInfo actionMasterInfo = new ActionMasterInfo();
                LoadFromDAL(actionMasterInfo,   actionMaster);
                list.Add(actionMasterInfo);
            }
			pRecordCount=q.GetRecordCount();
			
            return list;

        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		/// <returns></returns>
		public static List< ActionMasterInfo> GetList()
		{
			string cacheKey = GetCacheKey();
			//本实体已经注册成缓存实体，并且缓存存在的时候，直接从缓存取
			if (CachedEntityCommander.IsTypeRegistered(typeof(ActionMasterInfo)) && CachedEntityCommander.GetCache(cacheKey) != null)
            {
                return CachedEntityCommander.GetCache(cacheKey) as List< ActionMasterInfo>;
            }
            else 
            {
				List< ActionMasterInfo>  list =new List< ActionMasterInfo>();
				ActionMasterCollection  collection=new  ActionMasterCollection();
				Query qry = new Query(ActionMaster.Schema);
				collection.LoadAndCloseReader(qry.ExecuteReader());
				foreach(ActionMaster actionMaster in collection)
				{
					ActionMasterInfo actionMasterInfo= new ActionMasterInfo();
					LoadFromDAL(actionMasterInfo,actionMaster);
					list.Add(actionMasterInfo);
				}
			  	//生成缓存
                if (CachedEntityCommander.IsTypeRegistered(typeof(ActionMasterInfo))) 
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
		public int ActionMasterId
		{
			get {return actionMasterId;}
			set {actionMasterId = value;}
		}

		///<summary>
		///
		///</summary>
		public int ActionId
		{
			get {return actionId;}
			set {actionId = value;}
		}

		///<summary>
		///
		///</summary>
		public int MasterId
		{
			get {return masterId;}
			set {masterId = value;}
		}

		///<summary>
		///
		///</summary>
		public int? IsPass
		{
			get {return isPass;}
			set {isPass = value;}
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
			bool result=  (ActionMaster.Delete(ActionMasterId) == 1);
			//更新缓存
			if (result&&CachedEntityCommander.IsTypeRegistered(typeof(ActionMasterInfo))) 
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
        public void CopyTo(ActionMasterInfo pActionMasterInfoTo)
        {
            Copy(this,  pActionMasterInfoTo);
        }
		
		
		
		
		
		/// <summary>
		/// 保存
		/// </summary>
		public override void Save()
		{
			if(!m_Loaded)//新增
			{
				ActionMaster actionMaster=new ActionMaster();	
				SaveToDb(this, actionMaster,true);
			}
			else//修改
			{
				ActionMaster actionMaster=new ActionMaster(actionMasterId);	
				if(actionMaster.IsNew)
					throw new AppException("该数据已经不存在了");
				SaveToDb(this, actionMaster,false);
			}
			
		}
		 
		#endregion
		
	}
}
