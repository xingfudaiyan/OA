// ======================================================================================================================================
// 类说明
//=======================================================================================================================================
// 创建者：sk @Copy Right 残友软件有限公司OA项目 
// 文件名：FileApplyInfo.cs
// 创建时间：2012-10-23
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
	///FileApplyInfo  Data
	/// </summary>
	[Serializable]
	public partial class FileApplyInfo:CanYou.EntityObject
	{
		#region 属性
		///<summary>
		///
		///</summary>
		private int fileApplyId;
		///<summary>
		///
		///</summary>
		private string applyTime = String.Empty;
		///<summary>
		///
		///</summary>
		private string filesName = String.Empty;
		///<summary>
		///
		///</summary>
		private string fileType = String.Empty;
		///<summary>
		///
		///</summary>
		private string fileDes = String.Empty;
		///<summary>
		///
		///</summary>
		private string departView = String.Empty;
		///<summary>
		///
		///</summary>
		private string managerView = String.Empty;
		///<summary>
		///
		///</summary>
		private int? fileOfApplyId;
		///<summary>
		///
		///</summary>
		private int? state;
		///<summary>
		///
		///</summary>
		private string departName = String.Empty;
		///<summary>
		///
		///</summary>
		private string applyName = String.Empty;
		
		
		///一对多关系,如果
		private bool m_Loaded=false;
		#endregion
		
		#region 属性枚举
		public struct Fields
		{
			public const string FileApplyId=@"FileApplyId";
			public const string ApplyTime=@"ApplyTime";
			public const string FilesName=@"FilesName";
			public const string FileType=@"FileType";
			public const string FileDes=@"FileDes";
			public const string DepartView=@"DepartView";
			public const string ManagerView=@"ManagerView";
			public const string FileOfApplyId=@"FileOfApplyId";
			public const string State=@"State";
			public const string DepartName=@"DepartName";
			public const string ApplyName=@"ApplyName";
						
		}

		#endregion
		
		
		#region 构造函数
		///<summary>
		///
		///</summary>
		public FileApplyInfo()
		{
		}
		///<summary>
		///
		///</summary>
		public FileApplyInfo(int pFileApplyId,string pApplyTime,string pFilesName,string pFileType,string pFileDes,string pDepartView,string pManagerView,int? pFileOfApplyId,int? pState,string pDepartName,string pApplyName)
		{
			fileApplyId   = pFileApplyId;
			applyTime     = pApplyTime;
			filesName     = pFilesName;
			fileType      = pFileType;
			fileDes       = pFileDes;
			departView    = pDepartView;
			managerView   = pManagerView;
			fileOfApplyId = pFileOfApplyId;
			state         = pState;
			departName    = pDepartName;
			applyName     = pApplyName;
			
		}
		
		
		///<summary>
		///
		///</summary>
		public FileApplyInfo(int fileApplyId)
		{
			 LoadFromId(fileApplyId);
		}
		
		private void LoadFromId(int fileApplyId)
		{
		 
			if (CachedEntityCommander.IsTypeRegistered(typeof(FileApplyInfo)))
            {
				FileApplyInfo fileApplyInfo=Find(GetList(), fileApplyId);
				if(fileApplyInfo==null)
					throw new AppException("未能在缓存中找到相应的键值对象");
                Copy(fileApplyInfo, this);
            }
            else
            {	FileApply fileApply=new FileApply( fileApplyId);	
				if(fileApply.IsNew)
				throw new AppException("尚未初始化");
               	LoadFromDAL(this, fileApply);
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
        public static  FileApplyInfo Find(List< FileApplyInfo> list,  int fileApplyId)
        {
             return list.Find(delegate( FileApplyInfo item) { return item. fileApplyId==fileApplyId; });
        }
		
		
		/// <summary>
        /// 得到缓存键
        /// </summary>
        /// <returns></returns>
        private static string GetCacheKey()
        {
            return string.Format(CachedEntityCommander.CacheKey, typeof( FileApplyInfo).ToString());
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
        public static void Copy(FileApplyInfo pFileApplyInfoFrom, FileApplyInfo pFileApplyInfoTo)
        {
	 		pFileApplyInfoTo.FileApplyId = pFileApplyInfoFrom.fileApplyId;
	 		pFileApplyInfoTo.ApplyTime = pFileApplyInfoFrom.applyTime;
	 		pFileApplyInfoTo.FilesName = pFileApplyInfoFrom.filesName;
	 		pFileApplyInfoTo.FileType = pFileApplyInfoFrom.fileType;
	 		pFileApplyInfoTo.FileDes = pFileApplyInfoFrom.fileDes;
	 		pFileApplyInfoTo.DepartView = pFileApplyInfoFrom.departView;
	 		pFileApplyInfoTo.ManagerView = pFileApplyInfoFrom.managerView;
	 		pFileApplyInfoTo.FileOfApplyId = pFileApplyInfoFrom.fileOfApplyId;
	 		pFileApplyInfoTo.State = pFileApplyInfoFrom.state;
	 		pFileApplyInfoTo.DepartName = pFileApplyInfoFrom.departName;
	 		pFileApplyInfoTo.ApplyName = pFileApplyInfoFrom.applyName;
			pFileApplyInfoTo.Loaded=pFileApplyInfoFrom.Loaded;
        }
		
		/// <summary>
		/// 批量装载
		/// </summary>
		internal static void LoadFromDALPatch(List< FileApplyInfo> pList, FileApplyCollection pCollection)
        {
            foreach (FileApply fileApply in pCollection)
            {
                FileApplyInfo fileApplyInfo = new FileApplyInfo();
                LoadFromDAL(fileApplyInfo, fileApply );
                pList.Add(fileApplyInfo);
            }
			
        }

		//从后台获取数据
		internal  static void  LoadFromDAL(FileApplyInfo pFileApplyInfo, FileApply  pFileApply)
		{
	 		pFileApplyInfo.fileApplyId = pFileApply.FileApplyId;
	 		pFileApplyInfo.applyTime = pFileApply.ApplyTime;
	 		pFileApplyInfo.filesName = pFileApply.FilesName;
	 		pFileApplyInfo.fileType = pFileApply.FileType;
	 		pFileApplyInfo.fileDes = pFileApply.FileDes;
	 		pFileApplyInfo.departView = pFileApply.DepartView;
	 		pFileApplyInfo.managerView = pFileApply.ManagerView;
	 		pFileApplyInfo.fileOfApplyId = pFileApply.FileOfApplyId;
	 		pFileApplyInfo.state = pFileApply.State;
	 		pFileApplyInfo.departName = pFileApply.DepartName;
	 		pFileApplyInfo.applyName = pFileApply.ApplyName;
			pFileApplyInfo.Loaded=true;
			
			}
		
		//数据持久化
		internal  static void  SaveToDb(FileApplyInfo pFileApplyInfo, FileApply  pFileApply,bool pIsNew)
		{
	 		pFileApply.FileApplyId = pFileApplyInfo.fileApplyId;
	 		pFileApply.ApplyTime = pFileApplyInfo.applyTime;
	 		pFileApply.FilesName = pFileApplyInfo.filesName;
	 		pFileApply.FileType = pFileApplyInfo.fileType;
	 		pFileApply.FileDes = pFileApplyInfo.fileDes;
	 		pFileApply.DepartView = pFileApplyInfo.departView;
	 		pFileApply.ManagerView = pFileApplyInfo.managerView;
	 		pFileApply.FileOfApplyId = pFileApplyInfo.fileOfApplyId;
	 		pFileApply.State = pFileApplyInfo.state;
	 		pFileApply.DepartName = pFileApplyInfo.departName;
	 		pFileApply.ApplyName = pFileApplyInfo.applyName;
			pFileApply.IsNew=pIsNew;
			string UserName = SubsonicHelper.GetUserName();
			try
			{
				pFileApply.Save(UserName);
			}
			catch(Exception ex)
			{
				LogManager.getInstance().getLogger(typeof(FileApplyInfo)).Error(ex);
				if(ex.Message.Contains("插入重复键"))//违反了唯一键
				{
					throw new AppException("此对象已经存在");//此处等待优化可以从唯一约束中直接取出提示来，如果没有的话，默认为原始的出错提示
				}
				throw new AppException("保存失败");
			}
			pFileApplyInfo.fileApplyId = pFileApply.FileApplyId;
			//如果缓存存在，更新缓存
			if (CachedEntityCommander.IsTypeRegistered(typeof(FileApplyInfo))) 
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
        public static List< FileApplyInfo> GetPagedList(int pPageIndex,int pPageSize,SortDirection pOrderBy,string pSortExpression,out int pRecordCount)
        {
			if(pPageIndex<=1)
			pPageIndex=1;
            List< FileApplyInfo> list = new List< FileApplyInfo>();
          
            Query q = FileApply .CreateQuery();
            q.PageIndex = pPageIndex;
            q.PageSize = pPageSize;
            q.ORDER_BY(pSortExpression,pOrderBy.ToString());
			FileApplyCollection  collection=new  FileApplyCollection();
		 	collection.LoadAndCloseReader(q.ExecuteReader());
          
            foreach (FileApply  fileApply  in collection)
            {
                FileApplyInfo fileApplyInfo = new FileApplyInfo();
                LoadFromDAL(fileApplyInfo,   fileApply);
                list.Add(fileApplyInfo);
            }
			pRecordCount=q.GetRecordCount();
			
            return list;

        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		/// <returns></returns>
		public static List< FileApplyInfo> GetList()
		{
			string cacheKey = GetCacheKey();
			//本实体已经注册成缓存实体，并且缓存存在的时候，直接从缓存取
			if (CachedEntityCommander.IsTypeRegistered(typeof(FileApplyInfo)) && CachedEntityCommander.GetCache(cacheKey) != null)
            {
                return CachedEntityCommander.GetCache(cacheKey) as List< FileApplyInfo>;
            }
            else 
            {
				List< FileApplyInfo>  list =new List< FileApplyInfo>();
				FileApplyCollection  collection=new  FileApplyCollection();
				Query qry = new Query(FileApply.Schema);
				collection.LoadAndCloseReader(qry.ExecuteReader());
				foreach(FileApply fileApply in collection)
				{
					FileApplyInfo fileApplyInfo= new FileApplyInfo();
					LoadFromDAL(fileApplyInfo,fileApply);
					list.Add(fileApplyInfo);
				}
			  	//生成缓存
                if (CachedEntityCommander.IsTypeRegistered(typeof(FileApplyInfo))) 
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
		public int FileApplyId
		{
			get {return fileApplyId;}
			set {fileApplyId = value;}
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
		public string FilesName
		{
			get {return filesName;}
			set {filesName = value;}
		}

		///<summary>
		///
		///</summary>
		public string FileType
		{
			get {return fileType;}
			set {fileType = value;}
		}

		///<summary>
		///
		///</summary>
		public string FileDes
		{
			get {return fileDes;}
			set {fileDes = value;}
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

		///<summary>
		///
		///</summary>
		public int? FileOfApplyId
		{
			get {return fileOfApplyId;}
			set {fileOfApplyId = value;}
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
			bool result=  (FileApply.Delete(FileApplyId) == 1);
			//更新缓存
			if (result&&CachedEntityCommander.IsTypeRegistered(typeof(FileApplyInfo))) 
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
        public void CopyTo(FileApplyInfo pFileApplyInfoTo)
        {
            Copy(this,  pFileApplyInfoTo);
        }
		
		
		
		
		
		/// <summary>
		/// 保存
		/// </summary>
		public override void Save()
		{
			if(!m_Loaded)//新增
			{
				FileApply fileApply=new FileApply();	
				SaveToDb(this, fileApply,true);
			}
			else//修改
			{
				FileApply fileApply=new FileApply(fileApplyId);	
				if(fileApply.IsNew)
					throw new AppException("该数据已经不存在了");
				SaveToDb(this, fileApply,false);
			}
			
		}
		 
		#endregion
		
	}
}
