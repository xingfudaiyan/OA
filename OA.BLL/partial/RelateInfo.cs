// ======================================================================================================================================
// 类说明
//=======================================================================================================================================
// 创建者：sk @Copy Right 残友软件有限公司OA项目 
// 文件名：RelateInfo.cs
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
	///RelateInfo  Data
	/// </summary>
	[Serializable]
	public partial class RelateInfo:CanYou.EntityObject
	{
		#region 属性
		///<summary>
		///
		///</summary>
		private int relateId;
		///<summary>
		///
		///</summary>
		private string relateName = String.Empty;
		///<summary>
		///
		///</summary>
		private string mobile = String.Empty;
		///<summary>
		///
		///</summary>
		private string email = String.Empty;
		///<summary>
		///
		///</summary>
		private string memo = String.Empty;
		///<summary>
		///
		///</summary>
		private int? clientId;
		///<summary>
		///
		///</summary>
		private string position = String.Empty;
		
		
		///一对多关系,如果
		private bool m_Loaded=false;
		#endregion
		
		#region 属性枚举
		public struct Fields
		{
			public const string RelateId=@"RelateId";
			public const string RelateName=@"RelateName";
			public const string Mobile=@"Mobile";
			public const string Email=@"Email";
			public const string Memo=@"Memo";
			public const string ClientId=@"ClientId";
			public const string Position=@"Position";
						
		}

		#endregion
		
		
		#region 构造函数
		///<summary>
		///
		///</summary>
		public RelateInfo()
		{
		}
		///<summary>
		///
		///</summary>
		public RelateInfo(int pRelateId,string pRelateName,string pMobile,string pEmail,string pMemo,int? pClientId,string pPosition)
		{
			relateId   = pRelateId;
			relateName = pRelateName;
			mobile     = pMobile;
			email      = pEmail;
			memo       = pMemo;
			clientId   = pClientId;
			position   = pPosition;
			
		}
		
		
		///<summary>
		///
		///</summary>
		public RelateInfo(int relateId)
		{
			 LoadFromId(relateId);
		}
		
		private void LoadFromId(int relateId)
		{
		 
			if (CachedEntityCommander.IsTypeRegistered(typeof(RelateInfo)))
            {
				RelateInfo relateInfo=Find(GetList(), relateId);
				if(relateInfo==null)
					throw new AppException("未能在缓存中找到相应的键值对象");
                Copy(relateInfo, this);
            }
            else
            {	Relate relate=new Relate( relateId);	
				if(relate.IsNew)
				throw new AppException("尚未初始化");
               	LoadFromDAL(this, relate);
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
        public static  RelateInfo Find(List< RelateInfo> list,  int relateId)
        {
             return list.Find(delegate( RelateInfo item) { return item. relateId==relateId; });
        }
		
		
		/// <summary>
        /// 得到缓存键
        /// </summary>
        /// <returns></returns>
        private static string GetCacheKey()
        {
            return string.Format(CachedEntityCommander.CacheKey, typeof( RelateInfo).ToString());
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
        public static void Copy(RelateInfo pRelateInfoFrom, RelateInfo pRelateInfoTo)
        {
	 		pRelateInfoTo.RelateId = pRelateInfoFrom.relateId;
	 		pRelateInfoTo.RelateName = pRelateInfoFrom.relateName;
	 		pRelateInfoTo.Mobile = pRelateInfoFrom.mobile;
	 		pRelateInfoTo.Email = pRelateInfoFrom.email;
	 		pRelateInfoTo.Memo = pRelateInfoFrom.memo;
	 		pRelateInfoTo.ClientId = pRelateInfoFrom.clientId;
	 		pRelateInfoTo.Position = pRelateInfoFrom.position;
			pRelateInfoTo.Loaded=pRelateInfoFrom.Loaded;
        }
		
		/// <summary>
		/// 批量装载
		/// </summary>
		internal static void LoadFromDALPatch(List< RelateInfo> pList, RelateCollection pCollection)
        {
            foreach (Relate relate in pCollection)
            {
                RelateInfo relateInfo = new RelateInfo();
                LoadFromDAL(relateInfo, relate );
                pList.Add(relateInfo);
            }
			
        }

		//从后台获取数据
		internal  static void  LoadFromDAL(RelateInfo pRelateInfo, Relate  pRelate)
		{
	 		pRelateInfo.relateId = pRelate.RelateId;
	 		pRelateInfo.relateName = pRelate.RelateName;
	 		pRelateInfo.mobile = pRelate.Mobile;
	 		pRelateInfo.email = pRelate.Email;
	 		pRelateInfo.memo = pRelate.Memo;
	 		pRelateInfo.clientId = pRelate.ClientId;
	 		pRelateInfo.position = pRelate.Position;
			pRelateInfo.Loaded=true;
			
			}
		
		//数据持久化
		internal  static void  SaveToDb(RelateInfo pRelateInfo, Relate  pRelate,bool pIsNew)
		{
	 		pRelate.RelateId = pRelateInfo.relateId;
	 		pRelate.RelateName = pRelateInfo.relateName;
	 		pRelate.Mobile = pRelateInfo.mobile;
	 		pRelate.Email = pRelateInfo.email;
	 		pRelate.Memo = pRelateInfo.memo;
	 		pRelate.ClientId = pRelateInfo.clientId;
	 		pRelate.Position = pRelateInfo.position;
			pRelate.IsNew=pIsNew;
			string UserName = SubsonicHelper.GetUserName();
			try
			{
				pRelate.Save(UserName);
			}
			catch(Exception ex)
			{
				LogManager.getInstance().getLogger(typeof(RelateInfo)).Error(ex);
				if(ex.Message.Contains("插入重复键"))//违反了唯一键
				{
					throw new AppException("此对象已经存在");//此处等待优化可以从唯一约束中直接取出提示来，如果没有的话，默认为原始的出错提示
				}
				throw new AppException("保存失败");
			}
			pRelateInfo.relateId = pRelate.RelateId;
			//如果缓存存在，更新缓存
			if (CachedEntityCommander.IsTypeRegistered(typeof(RelateInfo))) 
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
        public static List< RelateInfo> GetPagedList(int pPageIndex,int pPageSize,SortDirection pOrderBy,string pSortExpression,out int pRecordCount)
        {
			if(pPageIndex<=1)
			pPageIndex=1;
            List< RelateInfo> list = new List< RelateInfo>();
          
            Query q = Relate .CreateQuery();
            q.PageIndex = pPageIndex;
            q.PageSize = pPageSize;
            q.ORDER_BY(pSortExpression,pOrderBy.ToString());
			RelateCollection  collection=new  RelateCollection();
		 	collection.LoadAndCloseReader(q.ExecuteReader());
          
            foreach (Relate  relate  in collection)
            {
                RelateInfo relateInfo = new RelateInfo();
                LoadFromDAL(relateInfo,   relate);
                list.Add(relateInfo);
            }
			pRecordCount=q.GetRecordCount();
			
            return list;

        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		/// <returns></returns>
		public static List< RelateInfo> GetList()
		{
			string cacheKey = GetCacheKey();
			//本实体已经注册成缓存实体，并且缓存存在的时候，直接从缓存取
			if (CachedEntityCommander.IsTypeRegistered(typeof(RelateInfo)) && CachedEntityCommander.GetCache(cacheKey) != null)
            {
                return CachedEntityCommander.GetCache(cacheKey) as List< RelateInfo>;
            }
            else 
            {
				List< RelateInfo>  list =new List< RelateInfo>();
				RelateCollection  collection=new  RelateCollection();
				Query qry = new Query(Relate.Schema);
				collection.LoadAndCloseReader(qry.ExecuteReader());
				foreach(Relate relate in collection)
				{
					RelateInfo relateInfo= new RelateInfo();
					LoadFromDAL(relateInfo,relate);
					list.Add(relateInfo);
				}
			  	//生成缓存
                if (CachedEntityCommander.IsTypeRegistered(typeof(RelateInfo))) 
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
		public int RelateId
		{
			get {return relateId;}
			set {relateId = value;}
		}

		///<summary>
		///
		///</summary>
		public string RelateName
		{
			get {return relateName;}
			set {relateName = value;}
		}

		///<summary>
		///
		///</summary>
		public string Mobile
		{
			get {return mobile;}
			set {mobile = value;}
		}

		///<summary>
		///
		///</summary>
		public string Email
		{
			get {return email;}
			set {email = value;}
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
		public int? ClientId
		{
			get {return clientId;}
			set {clientId = value;}
		}

		///<summary>
		///
		///</summary>
		public string Position
		{
			get {return position;}
			set {position = value;}
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
			bool result=  (Relate.Delete(RelateId) == 1);
			//更新缓存
			if (result&&CachedEntityCommander.IsTypeRegistered(typeof(RelateInfo))) 
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
        public void CopyTo(RelateInfo pRelateInfoTo)
        {
            Copy(this,  pRelateInfoTo);
        }
		
		
		
		
		
		/// <summary>
		/// 保存
		/// </summary>
		public override void Save()
		{
			if(!m_Loaded)//新增
			{
				Relate relate=new Relate();	
				SaveToDb(this, relate,true);
			}
			else//修改
			{
				Relate relate=new Relate(relateId);	
				if(relate.IsNew)
					throw new AppException("该数据已经不存在了");
				SaveToDb(this, relate,false);
			}
			
		}
		 
		#endregion
		
	}
}
