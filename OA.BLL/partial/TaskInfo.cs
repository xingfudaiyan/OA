// ======================================================================================================================================
// 类说明
//=======================================================================================================================================
// 创建者：sk @Copy Right 残友软件有限公司OA项目 
// 文件名：TaskInfo.cs
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
	///TaskInfo  Data
	/// </summary>
	[Serializable]
	public partial class TaskInfo:CanYou.EntityObject
	{
		#region 属性
		///<summary>
		///
		///</summary>
		private int taskId;
		///<summary>
		///
		///</summary>
		private string taskName = String.Empty;
		///<summary>
		///
		///</summary>
		private int? employeeId;
		///<summary>
		///
		///</summary>
		private int? workSheetId;
		///<summary>
		///
		///</summary>
		private DateTime? recvTime;
		///<summary>
		///
		///</summary>
		private int? isFinish;
		///<summary>
		///
		///</summary>
		private DateTime? finishTime;
		///<summary>
		///
		///</summary>
		private DateTime? beginTime;
		///<summary>
		///
		///</summary>
		private int? isMain;
		
		
		///一对多关系,如果
		private bool m_Loaded=false;
		#endregion
		
		#region 属性枚举
		public struct Fields
		{
			public const string TaskId=@"TaskId";
			public const string TaskName=@"TaskName";
			public const string EmployeeId=@"EmployeeId";
			public const string WorkSheetId=@"WorkSheetId";
			public const string RecvTime=@"RecvTime";
			public const string IsFinish=@"IsFinish";
			public const string FinishTime=@"FinishTime";
			public const string BeginTime=@"BeginTime";
			public const string IsMain=@"IsMain";
						
		}

		#endregion
		
		
		#region 构造函数
		///<summary>
		///
		///</summary>
		public TaskInfo()
		{
		}
		///<summary>
		///
		///</summary>
		public TaskInfo(int pTaskId,string pTaskName,int? pEmployeeId,int? pWorkSheetId,DateTime? pRecvTime,int? pIsFinish,DateTime? pFinishTime,DateTime? pBeginTime,int? pIsMain)
		{
			taskId      = pTaskId;
			taskName    = pTaskName;
			employeeId  = pEmployeeId;
			workSheetId = pWorkSheetId;
			recvTime    = pRecvTime;
			isFinish    = pIsFinish;
			finishTime  = pFinishTime;
			beginTime   = pBeginTime;
			isMain      = pIsMain;
			
		}
		
		
		///<summary>
		///
		///</summary>
		public TaskInfo(int taskId)
		{
			 LoadFromId(taskId);
		}
		
		private void LoadFromId(int taskId)
		{
		 
			if (CachedEntityCommander.IsTypeRegistered(typeof(TaskInfo)))
            {
				TaskInfo taskInfo=Find(GetList(), taskId);
				if(taskInfo==null)
					throw new AppException("未能在缓存中找到相应的键值对象");
                Copy(taskInfo, this);
            }
            else
            {	Task task=new Task( taskId);	
				if(task.IsNew)
				throw new AppException("尚未初始化");
               	LoadFromDAL(this, task);
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
        public static  TaskInfo Find(List< TaskInfo> list,  int taskId)
        {
             return list.Find(delegate( TaskInfo item) { return item. taskId==taskId; });
        }
		
		
		/// <summary>
        /// 得到缓存键
        /// </summary>
        /// <returns></returns>
        private static string GetCacheKey()
        {
            return string.Format(CachedEntityCommander.CacheKey, typeof( TaskInfo).ToString());
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
        public static void Copy(TaskInfo pTaskInfoFrom, TaskInfo pTaskInfoTo)
        {
	 		pTaskInfoTo.TaskId = pTaskInfoFrom.taskId;
	 		pTaskInfoTo.TaskName = pTaskInfoFrom.taskName;
	 		pTaskInfoTo.EmployeeId = pTaskInfoFrom.employeeId;
	 		pTaskInfoTo.WorkSheetId = pTaskInfoFrom.workSheetId;
	 		pTaskInfoTo.RecvTime = pTaskInfoFrom.recvTime;
	 		pTaskInfoTo.IsFinish = pTaskInfoFrom.isFinish;
	 		pTaskInfoTo.FinishTime = pTaskInfoFrom.finishTime;
	 		pTaskInfoTo.BeginTime = pTaskInfoFrom.beginTime;
	 		pTaskInfoTo.IsMain = pTaskInfoFrom.isMain;
			pTaskInfoTo.Loaded=pTaskInfoFrom.Loaded;
        }
		
		/// <summary>
		/// 批量装载
		/// </summary>
		internal static void LoadFromDALPatch(List< TaskInfo> pList, TaskCollection pCollection)
        {
            foreach (Task task in pCollection)
            {
                TaskInfo taskInfo = new TaskInfo();
                LoadFromDAL(taskInfo, task );
                pList.Add(taskInfo);
            }
			
        }

		//从后台获取数据
		internal  static void  LoadFromDAL(TaskInfo pTaskInfo, Task  pTask)
		{
	 		pTaskInfo.taskId = pTask.TaskId;
	 		pTaskInfo.taskName = pTask.TaskName;
	 		pTaskInfo.employeeId = pTask.EmployeeId;
	 		pTaskInfo.workSheetId = pTask.WorkSheetId;
	 		pTaskInfo.recvTime = pTask.RecvTime;
	 		pTaskInfo.isFinish = pTask.IsFinish;
	 		pTaskInfo.finishTime = pTask.FinishTime;
	 		pTaskInfo.beginTime = pTask.BeginTime;
	 		pTaskInfo.isMain = pTask.IsMain;
			pTaskInfo.Loaded=true;
			
			}
		
		//数据持久化
		internal  static void  SaveToDb(TaskInfo pTaskInfo, Task  pTask,bool pIsNew)
		{
	 		pTask.TaskId = pTaskInfo.taskId;
	 		pTask.TaskName = pTaskInfo.taskName;
	 		pTask.EmployeeId = pTaskInfo.employeeId;
	 		pTask.WorkSheetId = pTaskInfo.workSheetId;
	 		pTask.RecvTime = pTaskInfo.recvTime;
	 		pTask.IsFinish = pTaskInfo.isFinish;
	 		pTask.FinishTime = pTaskInfo.finishTime;
	 		pTask.BeginTime = pTaskInfo.beginTime;
	 		pTask.IsMain = pTaskInfo.isMain;
			pTask.IsNew=pIsNew;
			string UserName = SubsonicHelper.GetUserName();
			try
			{
				pTask.Save(UserName);
			}
			catch(Exception ex)
			{
				LogManager.getInstance().getLogger(typeof(TaskInfo)).Error(ex);
				if(ex.Message.Contains("插入重复键"))//违反了唯一键
				{
					throw new AppException("此对象已经存在");//此处等待优化可以从唯一约束中直接取出提示来，如果没有的话，默认为原始的出错提示
				}
				throw new AppException("保存失败");
			}
			pTaskInfo.taskId = pTask.TaskId;
			//如果缓存存在，更新缓存
			if (CachedEntityCommander.IsTypeRegistered(typeof(TaskInfo))) 
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
        public static List< TaskInfo> GetPagedList(int pPageIndex,int pPageSize,SortDirection pOrderBy,string pSortExpression,out int pRecordCount)
        {
			if(pPageIndex<=1)
			pPageIndex=1;
            List< TaskInfo> list = new List< TaskInfo>();
          
            Query q = Task .CreateQuery();
            q.PageIndex = pPageIndex;
            q.PageSize = pPageSize;
            q.ORDER_BY(pSortExpression,pOrderBy.ToString());
			TaskCollection  collection=new  TaskCollection();
		 	collection.LoadAndCloseReader(q.ExecuteReader());
          
            foreach (Task  task  in collection)
            {
                TaskInfo taskInfo = new TaskInfo();
                LoadFromDAL(taskInfo,   task);
                list.Add(taskInfo);
            }
			pRecordCount=q.GetRecordCount();
			
            return list;

        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		/// <returns></returns>
		public static List< TaskInfo> GetList()
		{
			string cacheKey = GetCacheKey();
			//本实体已经注册成缓存实体，并且缓存存在的时候，直接从缓存取
			if (CachedEntityCommander.IsTypeRegistered(typeof(TaskInfo)) && CachedEntityCommander.GetCache(cacheKey) != null)
            {
                return CachedEntityCommander.GetCache(cacheKey) as List< TaskInfo>;
            }
            else 
            {
				List< TaskInfo>  list =new List< TaskInfo>();
				TaskCollection  collection=new  TaskCollection();
				Query qry = new Query(Task.Schema);
				collection.LoadAndCloseReader(qry.ExecuteReader());
				foreach(Task task in collection)
				{
					TaskInfo taskInfo= new TaskInfo();
					LoadFromDAL(taskInfo,task);
					list.Add(taskInfo);
				}
			  	//生成缓存
                if (CachedEntityCommander.IsTypeRegistered(typeof(TaskInfo))) 
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
		public int TaskId
		{
			get {return taskId;}
			set {taskId = value;}
		}

		///<summary>
		///
		///</summary>
		public string TaskName
		{
			get {return taskName;}
			set {taskName = value;}
		}

		///<summary>
		///
		///</summary>
		public int? EmployeeId
		{
			get {return employeeId;}
			set {employeeId = value;}
		}

		///<summary>
		///
		///</summary>
		public int? WorkSheetId
		{
			get {return workSheetId;}
			set {workSheetId = value;}
		}

		///<summary>
		///
		///</summary>
		public DateTime? RecvTime
		{
			get {return recvTime;}
			set {recvTime = value;}
		}

		///<summary>
		///
		///</summary>
		public int? IsFinish
		{
			get {return isFinish;}
			set {isFinish = value;}
		}

		///<summary>
		///
		///</summary>
		public DateTime? FinishTime
		{
			get {return finishTime;}
			set {finishTime = value;}
		}

		///<summary>
		///
		///</summary>
		public DateTime? BeginTime
		{
			get {return beginTime;}
			set {beginTime = value;}
		}

		///<summary>
		///
		///</summary>
		public int? IsMain
		{
			get {return isMain;}
			set {isMain = value;}
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
			bool result=  (Task.Delete(TaskId) == 1);
			//更新缓存
			if (result&&CachedEntityCommander.IsTypeRegistered(typeof(TaskInfo))) 
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
        public void CopyTo(TaskInfo pTaskInfoTo)
        {
            Copy(this,  pTaskInfoTo);
        }
		
		
		
		
		
		/// <summary>
		/// 保存
		/// </summary>
		public override void Save()
		{
			if(!m_Loaded)//新增
			{
				Task task=new Task();	
				SaveToDb(this, task,true);
			}
			else//修改
			{
				Task task=new Task(taskId);	
				if(task.IsNew)
					throw new AppException("该数据已经不存在了");
				SaveToDb(this, task,false);
			}
			
		}
		 
		#endregion
		
	}
}
