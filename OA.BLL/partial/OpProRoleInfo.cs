// ======================================================================================================================================
// 类说明
//=======================================================================================================================================
// 创建者：sk @Copy Right 残友软件有限公司OA项目 
// 文件名：OpProRoleInfo.cs
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
	///OpProRoleInfo  Data
	/// </summary>
	[Serializable]
	public partial class OpProRoleInfo:CanYou.EntityObject
	{
		#region 属性
		///<summary>
		///
		///</summary>
		private int opProRoleId;
		///<summary>
		///
		///</summary>
		private int? operationId;
		///<summary>
		///
		///</summary>
		private int? processId;
		///<summary>
		///
		///</summary>
		private int? roleId;
		
		
		///一对多关系,如果
		private bool m_Loaded=false;
		#endregion
		
		#region 属性枚举
		public struct Fields
		{
			public const string OpProRoleId=@"OpProRoleId";
			public const string OperationId=@"OperationId";
			public const string ProcessId=@"ProcessId";
			public const string RoleId=@"RoleId";
						
		}

		#endregion
		
		
		#region 构造函数
		///<summary>
		///
		///</summary>
		public OpProRoleInfo()
		{
		}
		///<summary>
		///
		///</summary>
		public OpProRoleInfo(int pOpProRoleId,int? pOperationId,int? pProcessId,int? pRoleId)
		{
			opProRoleId = pOpProRoleId;
			operationId = pOperationId;
			processId   = pProcessId;
			roleId      = pRoleId;
			
		}
		
		
		///<summary>
		///
		///</summary>
		public OpProRoleInfo(int opProRoleId)
		{
			 LoadFromId(opProRoleId);
		}
		
		private void LoadFromId(int opProRoleId)
		{
		 
			if (CachedEntityCommander.IsTypeRegistered(typeof(OpProRoleInfo)))
            {
				OpProRoleInfo opProRoleInfo=Find(GetList(), opProRoleId);
				if(opProRoleInfo==null)
					throw new AppException("未能在缓存中找到相应的键值对象");
                Copy(opProRoleInfo, this);
            }
            else
            {	OpProRole opProRole=new OpProRole( opProRoleId);	
				if(opProRole.IsNew)
				throw new AppException("尚未初始化");
               	LoadFromDAL(this, opProRole);
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
        public static  OpProRoleInfo Find(List< OpProRoleInfo> list,  int opProRoleId)
        {
             return list.Find(delegate( OpProRoleInfo item) { return item. opProRoleId==opProRoleId; });
        }
		
		
		/// <summary>
        /// 得到缓存键
        /// </summary>
        /// <returns></returns>
        private static string GetCacheKey()
        {
            return string.Format(CachedEntityCommander.CacheKey, typeof( OpProRoleInfo).ToString());
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
        public static void Copy(OpProRoleInfo pOpProRoleInfoFrom, OpProRoleInfo pOpProRoleInfoTo)
        {
	 		pOpProRoleInfoTo.OpProRoleId = pOpProRoleInfoFrom.opProRoleId;
	 		pOpProRoleInfoTo.OperationId = pOpProRoleInfoFrom.operationId;
	 		pOpProRoleInfoTo.ProcessId = pOpProRoleInfoFrom.processId;
	 		pOpProRoleInfoTo.RoleId = pOpProRoleInfoFrom.roleId;
			pOpProRoleInfoTo.Loaded=pOpProRoleInfoFrom.Loaded;
        }
		
		/// <summary>
		/// 批量装载
		/// </summary>
		internal static void LoadFromDALPatch(List< OpProRoleInfo> pList, OpProRoleCollection pCollection)
        {
            foreach (OpProRole opProRole in pCollection)
            {
                OpProRoleInfo opProRoleInfo = new OpProRoleInfo();
                LoadFromDAL(opProRoleInfo, opProRole );
                pList.Add(opProRoleInfo);
            }
			
        }

		//从后台获取数据
		internal  static void  LoadFromDAL(OpProRoleInfo pOpProRoleInfo, OpProRole  pOpProRole)
		{
	 		pOpProRoleInfo.opProRoleId = pOpProRole.OpProRoleId;
	 		pOpProRoleInfo.operationId = pOpProRole.OperationId;
	 		pOpProRoleInfo.processId = pOpProRole.ProcessId;
	 		pOpProRoleInfo.roleId = pOpProRole.RoleId;
			pOpProRoleInfo.Loaded=true;
			
			}
		
		//数据持久化
		internal  static void  SaveToDb(OpProRoleInfo pOpProRoleInfo, OpProRole  pOpProRole,bool pIsNew)
		{
	 		pOpProRole.OpProRoleId = pOpProRoleInfo.opProRoleId;
	 		pOpProRole.OperationId = pOpProRoleInfo.operationId;
	 		pOpProRole.ProcessId = pOpProRoleInfo.processId;
	 		pOpProRole.RoleId = pOpProRoleInfo.roleId;
			pOpProRole.IsNew=pIsNew;
			string UserName = SubsonicHelper.GetUserName();
			try
			{
				pOpProRole.Save(UserName);
			}
			catch(Exception ex)
			{
				LogManager.getInstance().getLogger(typeof(OpProRoleInfo)).Error(ex);
				if(ex.Message.Contains("插入重复键"))//违反了唯一键
				{
					throw new AppException("此对象已经存在");//此处等待优化可以从唯一约束中直接取出提示来，如果没有的话，默认为原始的出错提示
				}
				throw new AppException("保存失败");
			}
			pOpProRoleInfo.opProRoleId = pOpProRole.OpProRoleId;
			//如果缓存存在，更新缓存
			if (CachedEntityCommander.IsTypeRegistered(typeof(OpProRoleInfo))) 
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
        public static List< OpProRoleInfo> GetPagedList(int pPageIndex,int pPageSize,SortDirection pOrderBy,string pSortExpression,out int pRecordCount)
        {
			if(pPageIndex<=1)
			pPageIndex=1;
            List< OpProRoleInfo> list = new List< OpProRoleInfo>();
          
            Query q = OpProRole .CreateQuery();
            q.PageIndex = pPageIndex;
            q.PageSize = pPageSize;
            q.ORDER_BY(pSortExpression,pOrderBy.ToString());
			OpProRoleCollection  collection=new  OpProRoleCollection();
		 	collection.LoadAndCloseReader(q.ExecuteReader());
          
            foreach (OpProRole  opProRole  in collection)
            {
                OpProRoleInfo opProRoleInfo = new OpProRoleInfo();
                LoadFromDAL(opProRoleInfo,   opProRole);
                list.Add(opProRoleInfo);
            }
			pRecordCount=q.GetRecordCount();
			
            return list;

        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		/// <returns></returns>
		public static List< OpProRoleInfo> GetList()
		{
			string cacheKey = GetCacheKey();
			//本实体已经注册成缓存实体，并且缓存存在的时候，直接从缓存取
			if (CachedEntityCommander.IsTypeRegistered(typeof(OpProRoleInfo)) && CachedEntityCommander.GetCache(cacheKey) != null)
            {
                return CachedEntityCommander.GetCache(cacheKey) as List< OpProRoleInfo>;
            }
            else 
            {
				List< OpProRoleInfo>  list =new List< OpProRoleInfo>();
				OpProRoleCollection  collection=new  OpProRoleCollection();
				Query qry = new Query(OpProRole.Schema);
				collection.LoadAndCloseReader(qry.ExecuteReader());
				foreach(OpProRole opProRole in collection)
				{
					OpProRoleInfo opProRoleInfo= new OpProRoleInfo();
					LoadFromDAL(opProRoleInfo,opProRole);
					list.Add(opProRoleInfo);
				}
			  	//生成缓存
                if (CachedEntityCommander.IsTypeRegistered(typeof(OpProRoleInfo))) 
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
		public int OpProRoleId
		{
			get {return opProRoleId;}
			set {opProRoleId = value;}
		}

		///<summary>
		///
		///</summary>
		public int? OperationId
		{
			get {return operationId;}
			set {operationId = value;}
		}

		///<summary>
		///
		///</summary>
		public int? ProcessId
		{
			get {return processId;}
			set {processId = value;}
		}

		///<summary>
		///
		///</summary>
		public int? RoleId
		{
			get {return roleId;}
			set {roleId = value;}
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
			bool result=  (OpProRole.Delete(OpProRoleId) == 1);
			//更新缓存
			if (result&&CachedEntityCommander.IsTypeRegistered(typeof(OpProRoleInfo))) 
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
        public void CopyTo(OpProRoleInfo pOpProRoleInfoTo)
        {
            Copy(this,  pOpProRoleInfoTo);
        }
		
		
		
		
		
		/// <summary>
		/// 保存
		/// </summary>
		public override void Save()
		{
			if(!m_Loaded)//新增
			{
				OpProRole opProRole=new OpProRole();	
				SaveToDb(this, opProRole,true);
			}
			else//修改
			{
				OpProRole opProRole=new OpProRole(opProRoleId);	
				if(opProRole.IsNew)
					throw new AppException("该数据已经不存在了");
				SaveToDb(this, opProRole,false);
			}
			
		}
		 
		#endregion
		
	}
}
