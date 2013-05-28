// ======================================================================================================================================
// 类说明
//=======================================================================================================================================
// 创建者：sk @Copy Right 残友软件有限公司OA项目 
// 文件名：MasterInfo.cs
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
	///MasterInfo  Data
	/// </summary>
	[Serializable]
	public partial class MasterInfo:CanYou.EntityObject
	{
		#region 属性
		///<summary>
		///用户Id
		///</summary>
		private int masterId;
		///<summary>
		///用户名
		///</summary>
		private string masterName = String.Empty;
		///<summary>
		///用户密码
		///</summary>
		private string masterPsd = String.Empty;
		///<summary>
		///所属部门
		///</summary>
		private int departId;
		///<summary>
		///创建日期
		///</summary>
		private DateTime? createDate;
		///<summary>
		///
		///</summary>
		private int employeeId;
		///<summary>
		///
		///</summary>
		private int? isApply;
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
			public const string MasterId=@"MasterId";
			public const string MasterName=@"MasterName";
			public const string MasterPsd=@"MasterPsd";
			public const string DepartId=@"DepartId";
			public const string CreateDate=@"CreateDate";
			public const string EmployeeId=@"EmployeeId";
			public const string IsApply=@"IsApply";
			public const string State=@"State";
						
		}

		#endregion
		
		
		#region 构造函数
		///<summary>
		///
		///</summary>
		public MasterInfo()
		{
		}
		///<summary>
		///
		///</summary>
		public MasterInfo(int pMasterId,string pMasterName,string pMasterPsd,int pDepartId,DateTime? pCreateDate,int pEmployeeId,int? pIsApply,int? pState)
		{
			masterId   = pMasterId;
			masterName = pMasterName;
			masterPsd  = pMasterPsd;
			departId   = pDepartId;
			createDate = pCreateDate;
			employeeId = pEmployeeId;
			isApply    = pIsApply;
			state      = pState;
			
		}
		
		
		///<summary>
		///
		///</summary>
		public MasterInfo(int masterId)
		{
			 LoadFromId(masterId);
		}
		
		private void LoadFromId(int masterId)
		{
		 
			if (CachedEntityCommander.IsTypeRegistered(typeof(MasterInfo)))
            {
				MasterInfo masterInfo=Find(GetList(), masterId);
				if(masterInfo==null)
					throw new AppException("未能在缓存中找到相应的键值对象");
                Copy(masterInfo, this);
            }
            else
            {	Master master=new Master( masterId);	
				if(master.IsNew)
				throw new AppException("尚未初始化");
               	LoadFromDAL(this, master);
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
        public static  MasterInfo Find(List< MasterInfo> list,  int masterId)
        {
             return list.Find(delegate( MasterInfo item) { return item. masterId==masterId; });
        }
		
		
		/// <summary>
        /// 得到缓存键
        /// </summary>
        /// <returns></returns>
        private static string GetCacheKey()
        {
            return string.Format(CachedEntityCommander.CacheKey, typeof( MasterInfo).ToString());
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
        public static void Copy(MasterInfo pMasterInfoFrom, MasterInfo pMasterInfoTo)
        {
	 		pMasterInfoTo.MasterId = pMasterInfoFrom.masterId;
	 		pMasterInfoTo.MasterName = pMasterInfoFrom.masterName;
	 		pMasterInfoTo.MasterPsd = pMasterInfoFrom.masterPsd;
	 		pMasterInfoTo.DepartId = pMasterInfoFrom.departId;
	 		pMasterInfoTo.CreateDate = pMasterInfoFrom.createDate;
	 		pMasterInfoTo.EmployeeId = pMasterInfoFrom.employeeId;
	 		pMasterInfoTo.IsApply = pMasterInfoFrom.isApply;
	 		pMasterInfoTo.State = pMasterInfoFrom.state;
			pMasterInfoTo.Loaded=pMasterInfoFrom.Loaded;
        }
		
		/// <summary>
		/// 批量装载
		/// </summary>
		internal static void LoadFromDALPatch(List< MasterInfo> pList, MasterCollection pCollection)
        {
            foreach (Master master in pCollection)
            {
                MasterInfo masterInfo = new MasterInfo();
                LoadFromDAL(masterInfo, master );
                pList.Add(masterInfo);
            }
			
        }

		//从后台获取数据
		internal  static void  LoadFromDAL(MasterInfo pMasterInfo, Master  pMaster)
		{
	 		pMasterInfo.masterId = pMaster.MasterId;
	 		pMasterInfo.masterName = pMaster.MasterName;
	 		pMasterInfo.masterPsd = pMaster.MasterPsd;
	 		pMasterInfo.departId = pMaster.DepartId;
	 		pMasterInfo.createDate = pMaster.CreateDate;
	 		pMasterInfo.employeeId = pMaster.EmployeeId;
	 		pMasterInfo.isApply = pMaster.IsApply;
	 		pMasterInfo.state = pMaster.State;
			pMasterInfo.Loaded=true;
			
			}
		
		//数据持久化
		internal  static void  SaveToDb(MasterInfo pMasterInfo, Master  pMaster,bool pIsNew)
		{
	 		pMaster.MasterId = pMasterInfo.masterId;
	 		pMaster.MasterName = pMasterInfo.masterName;
	 		pMaster.MasterPsd = pMasterInfo.masterPsd;
	 		pMaster.DepartId = pMasterInfo.departId;
	 		pMaster.CreateDate = pMasterInfo.createDate;
	 		pMaster.EmployeeId = pMasterInfo.employeeId;
	 		pMaster.IsApply = pMasterInfo.isApply;
	 		pMaster.State = pMasterInfo.state;
			pMaster.IsNew=pIsNew;
			string UserName = SubsonicHelper.GetUserName();
			try
			{
				pMaster.Save(UserName);
			}
			catch(Exception ex)
			{
				LogManager.getInstance().getLogger(typeof(MasterInfo)).Error(ex);
				if(ex.Message.Contains("插入重复键"))//违反了唯一键
				{
					throw new AppException("此对象已经存在");//此处等待优化可以从唯一约束中直接取出提示来，如果没有的话，默认为原始的出错提示
				}
				throw new AppException("保存失败");
			}
			pMasterInfo.masterId = pMaster.MasterId;
			//如果缓存存在，更新缓存
			if (CachedEntityCommander.IsTypeRegistered(typeof(MasterInfo))) 
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
        public static List< MasterInfo> GetPagedList(int pPageIndex,int pPageSize,SortDirection pOrderBy,string pSortExpression,out int pRecordCount)
        {
			if(pPageIndex<=1)
			pPageIndex=1;
            List< MasterInfo> list = new List< MasterInfo>();
          
            Query q = Master .CreateQuery();
            q.PageIndex = pPageIndex;
            q.PageSize = pPageSize;
            q.ORDER_BY(pSortExpression,pOrderBy.ToString());
			MasterCollection  collection=new  MasterCollection();
		 	collection.LoadAndCloseReader(q.ExecuteReader());
          
            foreach (Master  master  in collection)
            {
                MasterInfo masterInfo = new MasterInfo();
                LoadFromDAL(masterInfo,   master);
                list.Add(masterInfo);
            }
			pRecordCount=q.GetRecordCount();
			
            return list;

        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		/// <returns></returns>
		public static List< MasterInfo> GetList()
		{
			string cacheKey = GetCacheKey();
			//本实体已经注册成缓存实体，并且缓存存在的时候，直接从缓存取
			if (CachedEntityCommander.IsTypeRegistered(typeof(MasterInfo)) && CachedEntityCommander.GetCache(cacheKey) != null)
            {
                return CachedEntityCommander.GetCache(cacheKey) as List< MasterInfo>;
            }
            else 
            {
				List< MasterInfo>  list =new List< MasterInfo>();
				MasterCollection  collection=new  MasterCollection();
				Query qry = new Query(Master.Schema);
				collection.LoadAndCloseReader(qry.ExecuteReader());
				foreach(Master master in collection)
				{
					MasterInfo masterInfo= new MasterInfo();
					LoadFromDAL(masterInfo,master);
					list.Add(masterInfo);
				}
			  	//生成缓存
                if (CachedEntityCommander.IsTypeRegistered(typeof(MasterInfo))) 
                {
                    CachedEntityCommander.SetCache(cacheKey, list);
                }
				return list;
			}
			
		
		}
		#endregion
		
		
		
		
		#region 公有属性
		
		///<summary>
		///用户Id
		///</summary>
		public int MasterId
		{
			get {return masterId;}
			set {masterId = value;}
		}

		///<summary>
		///用户名
		///</summary>
		public string MasterName
		{
			get {return masterName;}
			set {masterName = value;}
		}

		///<summary>
		///用户密码
		///</summary>
		public string MasterPsd
		{
			get {return masterPsd;}
			set {masterPsd = value;}
		}

		///<summary>
		///所属部门
		///</summary>
		public int DepartId
		{
			get {return departId;}
			set {departId = value;}
		}

		///<summary>
		///创建日期
		///</summary>
		public DateTime? CreateDate
		{
			get {return createDate;}
			set {createDate = value;}
		}

		///<summary>
		///
		///</summary>
		public int EmployeeId
		{
			get {return employeeId;}
			set {employeeId = value;}
		}

		///<summary>
		///
		///</summary>
		public int? IsApply
		{
			get {return isApply;}
			set {isApply = value;}
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
			bool result=  (Master.Delete(MasterId) == 1);
			//更新缓存
			if (result&&CachedEntityCommander.IsTypeRegistered(typeof(MasterInfo))) 
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
        public void CopyTo(MasterInfo pMasterInfoTo)
        {
            Copy(this,  pMasterInfoTo);
        }
		
		
		
		
		
		/// <summary>
		/// 保存
		/// </summary>
		public override void Save()
		{
			if(!m_Loaded)//新增
			{
				Master master=new Master();	
				SaveToDb(this, master,true);
			}
			else//修改
			{
				Master master=new Master(masterId);	
				if(master.IsNew)
					throw new AppException("该数据已经不存在了");
				SaveToDb(this, master,false);
			}
			
		}
		 
		#endregion
		
	}
}
