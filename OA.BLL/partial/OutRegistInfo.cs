// ======================================================================================================================================
// 类说明
//=======================================================================================================================================
// 创建者：sk @Copy Right 残友软件有限公司OA项目 
// 文件名：OutRegistInfo.cs
// 创建时间：2012-9-12
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
	///OutRegistInfo  Data
	/// </summary>
	[Serializable]
	public partial class OutRegistInfo:CanYou.EntityObject
	{
		#region 属性
		///<summary>
		///
		///</summary>
		private int outRegistId;
		///<summary>
		///
		///</summary>
		private string outDate = String.Empty;
		///<summary>
		///
		///</summary>
		private string outTime = String.Empty;
		///<summary>
		///
		///</summary>
		private string outContent = String.Empty;
		///<summary>
		///
		///</summary>
		private string backTime = String.Empty;
		///<summary>
		///
		///</summary>
		private string outTool = String.Empty;
		///<summary>
		///
		///</summary>
		private string memo = String.Empty;
		///<summary>
		///
		///</summary>
		private string applyName = String.Empty;
		///<summary>
		///
		///</summary>
		private string departName = String.Empty;
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
			public const string OutRegistId=@"OutRegistId";
			public const string OutDate=@"OutDate";
			public const string OutTime=@"OutTime";
			public const string OutContent=@"OutContent";
			public const string BackTime=@"BackTime";
			public const string OutTool=@"OutTool";
			public const string Memo=@"Memo";
			public const string ApplyName=@"ApplyName";
			public const string DepartName=@"DepartName";
			public const string State=@"State";
						
		}

		#endregion
		
		
		#region 构造函数
		///<summary>
		///
		///</summary>
		public OutRegistInfo()
		{
		}
		///<summary>
		///
		///</summary>
		public OutRegistInfo(int pOutRegistId,string pOutDate,string pOutTime,string pOutContent,string pBackTime,string pOutTool,string pMemo,string pApplyName,string pDepartName,int? pState)
		{
			outRegistId = pOutRegistId;
			outDate     = pOutDate;
			outTime     = pOutTime;
			outContent  = pOutContent;
			backTime    = pBackTime;
			outTool     = pOutTool;
			memo        = pMemo;
			applyName   = pApplyName;
			departName  = pDepartName;
			state       = pState;
			
		}
		
		
		///<summary>
		///
		///</summary>
		public OutRegistInfo(int outRegistId)
		{
			 LoadFromId(outRegistId);
		}
		
		private void LoadFromId(int outRegistId)
		{
		 
			if (CachedEntityCommander.IsTypeRegistered(typeof(OutRegistInfo)))
            {
				OutRegistInfo outRegistInfo=Find(GetList(), outRegistId);
				if(outRegistInfo==null)
					throw new AppException("未能在缓存中找到相应的键值对象");
                Copy(outRegistInfo, this);
            }
            else
            {	OutRegist outRegist=new OutRegist( outRegistId);	
				if(outRegist.IsNew)
				throw new AppException("尚未初始化");
               	LoadFromDAL(this, outRegist);
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
        public static  OutRegistInfo Find(List< OutRegistInfo> list,  int outRegistId)
        {
             return list.Find(delegate( OutRegistInfo item) { return item. outRegistId==outRegistId; });
        }
		
		
		/// <summary>
        /// 得到缓存键
        /// </summary>
        /// <returns></returns>
        private static string GetCacheKey()
        {
            return string.Format(CachedEntityCommander.CacheKey, typeof( OutRegistInfo).ToString());
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
        public static void Copy(OutRegistInfo pOutRegistInfoFrom, OutRegistInfo pOutRegistInfoTo)
        {
	 		pOutRegistInfoTo.OutRegistId = pOutRegistInfoFrom.outRegistId;
	 		pOutRegistInfoTo.OutDate = pOutRegistInfoFrom.outDate;
	 		pOutRegistInfoTo.OutTime = pOutRegistInfoFrom.outTime;
	 		pOutRegistInfoTo.OutContent = pOutRegistInfoFrom.outContent;
	 		pOutRegistInfoTo.BackTime = pOutRegistInfoFrom.backTime;
	 		pOutRegistInfoTo.OutTool = pOutRegistInfoFrom.outTool;
	 		pOutRegistInfoTo.Memo = pOutRegistInfoFrom.memo;
	 		pOutRegistInfoTo.ApplyName = pOutRegistInfoFrom.applyName;
	 		pOutRegistInfoTo.DepartName = pOutRegistInfoFrom.departName;
	 		pOutRegistInfoTo.State = pOutRegistInfoFrom.state;
			pOutRegistInfoTo.Loaded=pOutRegistInfoFrom.Loaded;
        }
		
		/// <summary>
		/// 批量装载
		/// </summary>
		internal static void LoadFromDALPatch(List< OutRegistInfo> pList, OutRegistCollection pCollection)
        {
            foreach (OutRegist outRegist in pCollection)
            {
                OutRegistInfo outRegistInfo = new OutRegistInfo();
                LoadFromDAL(outRegistInfo, outRegist );
                pList.Add(outRegistInfo);
            }
			
        }

		//从后台获取数据
		internal  static void  LoadFromDAL(OutRegistInfo pOutRegistInfo, OutRegist  pOutRegist)
		{
	 		pOutRegistInfo.outRegistId = pOutRegist.OutRegistId;
	 		pOutRegistInfo.outDate = pOutRegist.OutDate;
	 		pOutRegistInfo.outTime = pOutRegist.OutTime;
	 		pOutRegistInfo.outContent = pOutRegist.OutContent;
	 		pOutRegistInfo.backTime = pOutRegist.BackTime;
	 		pOutRegistInfo.outTool = pOutRegist.OutTool;
	 		pOutRegistInfo.memo = pOutRegist.Memo;
	 		pOutRegistInfo.applyName = pOutRegist.ApplyName;
	 		pOutRegistInfo.departName = pOutRegist.DepartName;
	 		pOutRegistInfo.state = pOutRegist.State;
			pOutRegistInfo.Loaded=true;
			
			}
		
		//数据持久化
		internal  static void  SaveToDb(OutRegistInfo pOutRegistInfo, OutRegist  pOutRegist,bool pIsNew)
		{
	 		pOutRegist.OutRegistId = pOutRegistInfo.outRegistId;
	 		pOutRegist.OutDate = pOutRegistInfo.outDate;
	 		pOutRegist.OutTime = pOutRegistInfo.outTime;
	 		pOutRegist.OutContent = pOutRegistInfo.outContent;
	 		pOutRegist.BackTime = pOutRegistInfo.backTime;
	 		pOutRegist.OutTool = pOutRegistInfo.outTool;
	 		pOutRegist.Memo = pOutRegistInfo.memo;
	 		pOutRegist.ApplyName = pOutRegistInfo.applyName;
	 		pOutRegist.DepartName = pOutRegistInfo.departName;
	 		pOutRegist.State = pOutRegistInfo.state;
			pOutRegist.IsNew=pIsNew;
			string UserName = SubsonicHelper.GetUserName();
			try
			{
				pOutRegist.Save(UserName);
			}
			catch(Exception ex)
			{
				LogManager.getInstance().getLogger(typeof(OutRegistInfo)).Error(ex);
				if(ex.Message.Contains("插入重复键"))//违反了唯一键
				{
					throw new AppException("此对象已经存在");//此处等待优化可以从唯一约束中直接取出提示来，如果没有的话，默认为原始的出错提示
				}
				throw new AppException("保存失败");
			}
			pOutRegistInfo.outRegistId = pOutRegist.OutRegistId;
			//如果缓存存在，更新缓存
			if (CachedEntityCommander.IsTypeRegistered(typeof(OutRegistInfo))) 
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
        public static List< OutRegistInfo> GetPagedList(int pPageIndex,int pPageSize,SortDirection pOrderBy,string pSortExpression,out int pRecordCount)
        {
			if(pPageIndex<=1)
			pPageIndex=1;
            List< OutRegistInfo> list = new List< OutRegistInfo>();
          
            Query q = OutRegist .CreateQuery();
            q.PageIndex = pPageIndex;
            q.PageSize = pPageSize;
            q.ORDER_BY(pSortExpression,pOrderBy.ToString());
			OutRegistCollection  collection=new  OutRegistCollection();
		 	collection.LoadAndCloseReader(q.ExecuteReader());
          
            foreach (OutRegist  outRegist  in collection)
            {
                OutRegistInfo outRegistInfo = new OutRegistInfo();
                LoadFromDAL(outRegistInfo,   outRegist);
                list.Add(outRegistInfo);
            }
			pRecordCount=q.GetRecordCount();
			
            return list;

        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		/// <returns></returns>
		public static List< OutRegistInfo> GetList()
		{
			string cacheKey = GetCacheKey();
			//本实体已经注册成缓存实体，并且缓存存在的时候，直接从缓存取
			if (CachedEntityCommander.IsTypeRegistered(typeof(OutRegistInfo)) && CachedEntityCommander.GetCache(cacheKey) != null)
            {
                return CachedEntityCommander.GetCache(cacheKey) as List< OutRegistInfo>;
            }
            else 
            {
				List< OutRegistInfo>  list =new List< OutRegistInfo>();
				OutRegistCollection  collection=new  OutRegistCollection();
				Query qry = new Query(OutRegist.Schema);
				collection.LoadAndCloseReader(qry.ExecuteReader());
				foreach(OutRegist outRegist in collection)
				{
					OutRegistInfo outRegistInfo= new OutRegistInfo();
					LoadFromDAL(outRegistInfo,outRegist);
					list.Add(outRegistInfo);
				}
			  	//生成缓存
                if (CachedEntityCommander.IsTypeRegistered(typeof(OutRegistInfo))) 
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
		public int OutRegistId
		{
			get {return outRegistId;}
			set {outRegistId = value;}
		}

		///<summary>
		///
		///</summary>
		public string OutDate
		{
			get {return outDate;}
			set {outDate = value;}
		}

		///<summary>
		///
		///</summary>
		public string OutTime
		{
			get {return outTime;}
			set {outTime = value;}
		}

		///<summary>
		///
		///</summary>
		public string OutContent
		{
			get {return outContent;}
			set {outContent = value;}
		}

		///<summary>
		///
		///</summary>
		public string BackTime
		{
			get {return backTime;}
			set {backTime = value;}
		}

		///<summary>
		///
		///</summary>
		public string OutTool
		{
			get {return outTool;}
			set {outTool = value;}
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
		public string ApplyName
		{
			get {return applyName;}
			set {applyName = value;}
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
			bool result=  (OutRegist.Delete(OutRegistId) == 1);
			//更新缓存
			if (result&&CachedEntityCommander.IsTypeRegistered(typeof(OutRegistInfo))) 
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
        public void CopyTo(OutRegistInfo pOutRegistInfoTo)
        {
            Copy(this,  pOutRegistInfoTo);
        }
		
		
		
		
		
		/// <summary>
		/// 保存
		/// </summary>
		public override void Save()
		{
			if(!m_Loaded)//新增
			{
				OutRegist outRegist=new OutRegist();	
				SaveToDb(this, outRegist,true);
			}
			else//修改
			{
				OutRegist outRegist=new OutRegist(outRegistId);	
				if(outRegist.IsNew)
					throw new AppException("该数据已经不存在了");
				SaveToDb(this, outRegist,false);
			}
			
		}
		 
		#endregion
		
	}
}
