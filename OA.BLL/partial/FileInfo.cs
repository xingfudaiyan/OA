// ======================================================================================================================================
// 类说明
//=======================================================================================================================================
// 创建者：sk @Copy Right 残友软件有限公司OA项目 
// 文件名：FileInfo.cs
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
	///FileInfo  Data
	/// </summary>
	[Serializable]
	public partial class FileInfo:CanYou.EntityObject
	{
		#region 属性
		///<summary>
		///
		///</summary>
		private int fileId;
		///<summary>
		///
		///</summary>
		private int fileTypeId;
		///<summary>
		///
		///</summary>
		private string fileName = String.Empty;
		///<summary>
		///
		///</summary>
		private int sendEmployeeId;
		///<summary>
		///
		///</summary>
		private int? recvEmployeeId;
		///<summary>
		///
		///</summary>
		private DateTime sendTime;
		///<summary>
		///
		///</summary>
		private string memo = String.Empty;
		///<summary>
		///
		///</summary>
		private int? isCommon;
		///<summary>
		///
		///</summary>
		private int? isDelete;
		///<summary>
		///
		///</summary>
		private int? isMsg;
		///<summary>
		///
		///</summary>
		private int? filePermissionId;
		
		
		///一对多关系,如果
		private bool m_Loaded=false;
		#endregion
		
		#region 属性枚举
		public struct Fields
		{
			public const string FileId=@"FileId";
			public const string FileTypeId=@"FileTypeId";
			public const string FileName=@"FileName";
			public const string SendEmployeeId=@"SendEmployeeId";
			public const string RecvEmployeeId=@"RecvEmployeeId";
			public const string SendTime=@"SendTime";
			public const string Memo=@"Memo";
			public const string IsCommon=@"IsCommon";
			public const string IsDelete=@"IsDelete";
			public const string IsMsg=@"IsMsg";
			public const string FilePermissionId=@"FilePermissionId";
						
		}

		#endregion
		
		
		#region 构造函数
		///<summary>
		///
		///</summary>
		public FileInfo()
		{
		}
		///<summary>
		///
		///</summary>
		public FileInfo(int pFileId,int pFileTypeId,string pFileName,int pSendEmployeeId,int? pRecvEmployeeId,DateTime pSendTime,string pMemo,int? pIsCommon,int? pIsDelete,int? pIsMsg,int? pFilePermissionId)
		{
			fileId           = pFileId;
			fileTypeId       = pFileTypeId;
			fileName         = pFileName;
			sendEmployeeId   = pSendEmployeeId;
			recvEmployeeId   = pRecvEmployeeId;
			sendTime         = pSendTime;
			memo             = pMemo;
			isCommon         = pIsCommon;
			isDelete         = pIsDelete;
			isMsg            = pIsMsg;
			filePermissionId = pFilePermissionId;
			
		}
		
		
		///<summary>
		///
		///</summary>
		public FileInfo(int fileId)
		{
			 LoadFromId(fileId);
		}
		
		private void LoadFromId(int fileId)
		{
		 
			if (CachedEntityCommander.IsTypeRegistered(typeof(FileInfo)))
            {
				FileInfo fileInfo=Find(GetList(), fileId);
				if(fileInfo==null)
					throw new AppException("未能在缓存中找到相应的键值对象");
                Copy(fileInfo, this);
            }
            else
            {	File file=new File( fileId);	
				if(file.IsNew)
				throw new AppException("尚未初始化");
               	LoadFromDAL(this, file);
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
        public static  FileInfo Find(List< FileInfo> list,  int fileId)
        {
             return list.Find(delegate( FileInfo item) { return item. fileId==fileId; });
        }
		
		
		/// <summary>
        /// 得到缓存键
        /// </summary>
        /// <returns></returns>
        private static string GetCacheKey()
        {
            return string.Format(CachedEntityCommander.CacheKey, typeof( FileInfo).ToString());
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
        public static void Copy(FileInfo pFileInfoFrom, FileInfo pFileInfoTo)
        {
	 		pFileInfoTo.FileId = pFileInfoFrom.fileId;
	 		pFileInfoTo.FileTypeId = pFileInfoFrom.fileTypeId;
	 		pFileInfoTo.FileName = pFileInfoFrom.fileName;
	 		pFileInfoTo.SendEmployeeId = pFileInfoFrom.sendEmployeeId;
	 		pFileInfoTo.RecvEmployeeId = pFileInfoFrom.recvEmployeeId;
	 		pFileInfoTo.SendTime = pFileInfoFrom.sendTime;
	 		pFileInfoTo.Memo = pFileInfoFrom.memo;
	 		pFileInfoTo.IsCommon = pFileInfoFrom.isCommon;
	 		pFileInfoTo.IsDelete = pFileInfoFrom.isDelete;
	 		pFileInfoTo.IsMsg = pFileInfoFrom.isMsg;
	 		pFileInfoTo.FilePermissionId = pFileInfoFrom.filePermissionId;
			pFileInfoTo.Loaded=pFileInfoFrom.Loaded;
        }
		
		/// <summary>
		/// 批量装载
		/// </summary>
		internal static void LoadFromDALPatch(List< FileInfo> pList, FileCollection pCollection)
        {
            foreach (File file in pCollection)
            {
                FileInfo fileInfo = new FileInfo();
                LoadFromDAL(fileInfo, file );
                pList.Add(fileInfo);
            }
			
        }

		//从后台获取数据
		internal  static void  LoadFromDAL(FileInfo pFileInfo, File  pFile)
		{
	 		pFileInfo.fileId = pFile.FileId;
	 		pFileInfo.fileTypeId = pFile.FileTypeId;
	 		pFileInfo.fileName = pFile.FileName;
	 		pFileInfo.sendEmployeeId = pFile.SendEmployeeId;
	 		pFileInfo.recvEmployeeId = pFile.RecvEmployeeId;
	 		pFileInfo.sendTime = pFile.SendTime;
	 		pFileInfo.memo = pFile.Memo;
	 		pFileInfo.isCommon = pFile.IsCommon;
	 		pFileInfo.isDelete = pFile.IsDelete;
	 		pFileInfo.isMsg = pFile.IsMsg;
	 		pFileInfo.filePermissionId = pFile.FilePermissionId;
			pFileInfo.Loaded=true;
			
			}
		
		//数据持久化
		internal  static void  SaveToDb(FileInfo pFileInfo, File  pFile,bool pIsNew)
		{
	 		pFile.FileId = pFileInfo.fileId;
	 		pFile.FileTypeId = pFileInfo.fileTypeId;
	 		pFile.FileName = pFileInfo.fileName;
	 		pFile.SendEmployeeId = pFileInfo.sendEmployeeId;
	 		pFile.RecvEmployeeId = pFileInfo.recvEmployeeId;
	 		pFile.SendTime = pFileInfo.sendTime;
	 		pFile.Memo = pFileInfo.memo;
	 		pFile.IsCommon = pFileInfo.isCommon;
	 		pFile.IsDelete = pFileInfo.isDelete;
	 		pFile.IsMsg = pFileInfo.isMsg;
	 		pFile.FilePermissionId = pFileInfo.filePermissionId;
			pFile.IsNew=pIsNew;
			string UserName = SubsonicHelper.GetUserName();
			try
			{
				pFile.Save(UserName);
			}
			catch(Exception ex)
			{
				LogManager.getInstance().getLogger(typeof(FileInfo)).Error(ex);
				if(ex.Message.Contains("插入重复键"))//违反了唯一键
				{
					throw new AppException("此对象已经存在");//此处等待优化可以从唯一约束中直接取出提示来，如果没有的话，默认为原始的出错提示
				}
				throw new AppException("保存失败");
			}
			pFileInfo.fileId = pFile.FileId;
			//如果缓存存在，更新缓存
			if (CachedEntityCommander.IsTypeRegistered(typeof(FileInfo))) 
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
        public static List< FileInfo> GetPagedList(int pPageIndex,int pPageSize,SortDirection pOrderBy,string pSortExpression,out int pRecordCount)
        {
			if(pPageIndex<=1)
			pPageIndex=1;
            List< FileInfo> list = new List< FileInfo>();
          
            Query q = File .CreateQuery();
            q.PageIndex = pPageIndex;
            q.PageSize = pPageSize;
            q.ORDER_BY(pSortExpression,pOrderBy.ToString());
			FileCollection  collection=new  FileCollection();
		 	collection.LoadAndCloseReader(q.ExecuteReader());
          
            foreach (File  file  in collection)
            {
                FileInfo fileInfo = new FileInfo();
                LoadFromDAL(fileInfo,   file);
                list.Add(fileInfo);
            }
			pRecordCount=q.GetRecordCount();
			
            return list;

        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		/// <returns></returns>
		public static List< FileInfo> GetList()
		{
			string cacheKey = GetCacheKey();
			//本实体已经注册成缓存实体，并且缓存存在的时候，直接从缓存取
			if (CachedEntityCommander.IsTypeRegistered(typeof(FileInfo)) && CachedEntityCommander.GetCache(cacheKey) != null)
            {
                return CachedEntityCommander.GetCache(cacheKey) as List< FileInfo>;
            }
            else 
            {
				List< FileInfo>  list =new List< FileInfo>();
				FileCollection  collection=new  FileCollection();
				Query qry = new Query(File.Schema);
				collection.LoadAndCloseReader(qry.ExecuteReader());
				foreach(File file in collection)
				{
					FileInfo fileInfo= new FileInfo();
					LoadFromDAL(fileInfo,file);
					list.Add(fileInfo);
				}
			  	//生成缓存
                if (CachedEntityCommander.IsTypeRegistered(typeof(FileInfo))) 
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
		public int FileId
		{
			get {return fileId;}
			set {fileId = value;}
		}

		///<summary>
		///
		///</summary>
		public int FileTypeId
		{
			get {return fileTypeId;}
			set {fileTypeId = value;}
		}

		///<summary>
		///
		///</summary>
		public string FileName
		{
			get {return fileName;}
			set {fileName = value;}
		}

		///<summary>
		///
		///</summary>
		public int SendEmployeeId
		{
			get {return sendEmployeeId;}
			set {sendEmployeeId = value;}
		}

		///<summary>
		///
		///</summary>
		public int? RecvEmployeeId
		{
			get {return recvEmployeeId;}
			set {recvEmployeeId = value;}
		}

		///<summary>
		///
		///</summary>
		public DateTime SendTime
		{
			get {return sendTime;}
			set {sendTime = value;}
		}

		///<summary>
		///
		///</summary>
		public string Memo
		{
			get {return memo;}
			set {memo = value;}
		}

		///<summary>
		///
		///</summary>
		public int? IsCommon
		{
			get {return isCommon;}
			set {isCommon = value;}
		}

		///<summary>
		///
		///</summary>
		public int? IsDelete
		{
			get {return isDelete;}
			set {isDelete = value;}
		}

		///<summary>
		///
		///</summary>
		public int? IsMsg
		{
			get {return isMsg;}
			set {isMsg = value;}
		}

		///<summary>
		///
		///</summary>
		public int? FilePermissionId
		{
			get {return filePermissionId;}
			set {filePermissionId = value;}
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
			bool result=  (File.Delete(FileId) == 1);
			//更新缓存
			if (result&&CachedEntityCommander.IsTypeRegistered(typeof(FileInfo))) 
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
        public void CopyTo(FileInfo pFileInfoTo)
        {
            Copy(this,  pFileInfoTo);
        }
		
		
		
		
		
		/// <summary>
		/// 保存
		/// </summary>
		public override void Save()
		{
			if(!m_Loaded)//新增
			{
				File file=new File();	
				SaveToDb(this, file,true);
			}
			else//修改
			{
				File file=new File(fileId);	
				if(file.IsNew)
					throw new AppException("该数据已经不存在了");
				SaveToDb(this, file,false);
			}
			
		}
		 
		#endregion
		
	}
}
