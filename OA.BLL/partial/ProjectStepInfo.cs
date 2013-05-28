// ======================================================================================================================================
// 类说明
//=======================================================================================================================================
// 创建者：sk @Copy Right 残友软件有限公司OA项目 
// 文件名：ProjectStepInfo.cs
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
	///ProjectStepInfo  Data
	/// </summary>
	[Serializable]
	public partial class ProjectStepInfo:CanYou.EntityObject
	{
		#region 属性
		///<summary>
		///
		///</summary>
		private int projectStepId;
		///<summary>
		///
		///</summary>
		private string projectStepName = String.Empty;
		
		
		///一对多关系,如果
		private bool m_Loaded=false;
		#endregion
		
		#region 属性枚举
		public struct Fields
		{
			public const string ProjectStepId=@"ProjectStepId";
			public const string ProjectStepName=@"ProjectStepName";
						
		}

		#endregion
		
		
		#region 构造函数
		///<summary>
		///
		///</summary>
		public ProjectStepInfo()
		{
		}
		///<summary>
		///
		///</summary>
		public ProjectStepInfo(int pProjectStepId,string pProjectStepName)
		{
			projectStepId   = pProjectStepId;
			projectStepName = pProjectStepName;
			
		}
		
		
		///<summary>
		///
		///</summary>
		public ProjectStepInfo(int projectStepId)
		{
			 LoadFromId(projectStepId);
		}
		
		private void LoadFromId(int projectStepId)
		{
		 
			if (CachedEntityCommander.IsTypeRegistered(typeof(ProjectStepInfo)))
            {
				ProjectStepInfo projectStepInfo=Find(GetList(), projectStepId);
				if(projectStepInfo==null)
					throw new AppException("未能在缓存中找到相应的键值对象");
                Copy(projectStepInfo, this);
            }
            else
            {	ProjectStep projectStep=new ProjectStep( projectStepId);	
				if(projectStep.IsNew)
				throw new AppException("尚未初始化");
               	LoadFromDAL(this, projectStep);
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
        public static  ProjectStepInfo Find(List< ProjectStepInfo> list,  int projectStepId)
        {
             return list.Find(delegate( ProjectStepInfo item) { return item. projectStepId==projectStepId; });
        }
		
		
		/// <summary>
        /// 得到缓存键
        /// </summary>
        /// <returns></returns>
        private static string GetCacheKey()
        {
            return string.Format(CachedEntityCommander.CacheKey, typeof( ProjectStepInfo).ToString());
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
        public static void Copy(ProjectStepInfo pProjectStepInfoFrom, ProjectStepInfo pProjectStepInfoTo)
        {
	 		pProjectStepInfoTo.ProjectStepId = pProjectStepInfoFrom.projectStepId;
	 		pProjectStepInfoTo.ProjectStepName = pProjectStepInfoFrom.projectStepName;
			pProjectStepInfoTo.Loaded=pProjectStepInfoFrom.Loaded;
        }
		
		/// <summary>
		/// 批量装载
		/// </summary>
		internal static void LoadFromDALPatch(List< ProjectStepInfo> pList, ProjectStepCollection pCollection)
        {
            foreach (ProjectStep projectStep in pCollection)
            {
                ProjectStepInfo projectStepInfo = new ProjectStepInfo();
                LoadFromDAL(projectStepInfo, projectStep );
                pList.Add(projectStepInfo);
            }
			
        }

		//从后台获取数据
		internal  static void  LoadFromDAL(ProjectStepInfo pProjectStepInfo, ProjectStep  pProjectStep)
		{
	 		pProjectStepInfo.projectStepId = pProjectStep.ProjectStepId;
	 		pProjectStepInfo.projectStepName = pProjectStep.ProjectStepName;
			pProjectStepInfo.Loaded=true;
			
			}
		
		//数据持久化
		internal  static void  SaveToDb(ProjectStepInfo pProjectStepInfo, ProjectStep  pProjectStep,bool pIsNew)
		{
	 		pProjectStep.ProjectStepId = pProjectStepInfo.projectStepId;
	 		pProjectStep.ProjectStepName = pProjectStepInfo.projectStepName;
			pProjectStep.IsNew=pIsNew;
			string UserName = SubsonicHelper.GetUserName();
			try
			{
				pProjectStep.Save(UserName);
			}
			catch(Exception ex)
			{
				LogManager.getInstance().getLogger(typeof(ProjectStepInfo)).Error(ex);
				if(ex.Message.Contains("插入重复键"))//违反了唯一键
				{
					throw new AppException("此对象已经存在");//此处等待优化可以从唯一约束中直接取出提示来，如果没有的话，默认为原始的出错提示
				}
				throw new AppException("保存失败");
			}
			pProjectStepInfo.projectStepId = pProjectStep.ProjectStepId;
			//如果缓存存在，更新缓存
			if (CachedEntityCommander.IsTypeRegistered(typeof(ProjectStepInfo))) 
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
        public static List< ProjectStepInfo> GetPagedList(int pPageIndex,int pPageSize,SortDirection pOrderBy,string pSortExpression,out int pRecordCount)
        {
			if(pPageIndex<=1)
			pPageIndex=1;
            List< ProjectStepInfo> list = new List< ProjectStepInfo>();
          
            Query q = ProjectStep .CreateQuery();
            q.PageIndex = pPageIndex;
            q.PageSize = pPageSize;
            q.ORDER_BY(pSortExpression,pOrderBy.ToString());
			ProjectStepCollection  collection=new  ProjectStepCollection();
		 	collection.LoadAndCloseReader(q.ExecuteReader());
          
            foreach (ProjectStep  projectStep  in collection)
            {
                ProjectStepInfo projectStepInfo = new ProjectStepInfo();
                LoadFromDAL(projectStepInfo,   projectStep);
                list.Add(projectStepInfo);
            }
			pRecordCount=q.GetRecordCount();
			
            return list;

        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		/// <returns></returns>
		public static List< ProjectStepInfo> GetList()
		{
			string cacheKey = GetCacheKey();
			//本实体已经注册成缓存实体，并且缓存存在的时候，直接从缓存取
			if (CachedEntityCommander.IsTypeRegistered(typeof(ProjectStepInfo)) && CachedEntityCommander.GetCache(cacheKey) != null)
            {
                return CachedEntityCommander.GetCache(cacheKey) as List< ProjectStepInfo>;
            }
            else 
            {
				List< ProjectStepInfo>  list =new List< ProjectStepInfo>();
				ProjectStepCollection  collection=new  ProjectStepCollection();
				Query qry = new Query(ProjectStep.Schema);
				collection.LoadAndCloseReader(qry.ExecuteReader());
				foreach(ProjectStep projectStep in collection)
				{
					ProjectStepInfo projectStepInfo= new ProjectStepInfo();
					LoadFromDAL(projectStepInfo,projectStep);
					list.Add(projectStepInfo);
				}
			  	//生成缓存
                if (CachedEntityCommander.IsTypeRegistered(typeof(ProjectStepInfo))) 
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
		public int ProjectStepId
		{
			get {return projectStepId;}
			set {projectStepId = value;}
		}

		///<summary>
		///
		///</summary>
		public string ProjectStepName
		{
			get {return projectStepName;}
			set {projectStepName = value;}
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
			bool result=  (ProjectStep.Delete(ProjectStepId) == 1);
			//更新缓存
			if (result&&CachedEntityCommander.IsTypeRegistered(typeof(ProjectStepInfo))) 
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
        public void CopyTo(ProjectStepInfo pProjectStepInfoTo)
        {
            Copy(this,  pProjectStepInfoTo);
        }
		
		
		
		
		
		/// <summary>
		/// 保存
		/// </summary>
		public override void Save()
		{
			if(!m_Loaded)//新增
			{
				ProjectStep projectStep=new ProjectStep();	
				SaveToDb(this, projectStep,true);
			}
			else//修改
			{
				ProjectStep projectStep=new ProjectStep(projectStepId);	
				if(projectStep.IsNew)
					throw new AppException("该数据已经不存在了");
				SaveToDb(this, projectStep,false);
			}
			
		}
		 
		#endregion
		
	}
}
