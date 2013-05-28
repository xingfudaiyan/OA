// ======================================================================================================================================
// 类说明
//=======================================================================================================================================
// 创建者：sk @Copy Right 残友软件有限公司OA项目 
// 文件名：DepartInfo.cs
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
	///DepartInfo  Data
	/// </summary>
	[Serializable]
	public partial class DepartInfo:CanYou.EntityObject
	{
		#region 属性
		///<summary>
		///部门Id
		///</summary>
		private int departId;
		///<summary>
		///部门名称
		///</summary>
		private string departName = String.Empty;
		
		
		///一对多关系,如果
		private bool m_Loaded=false;
		#endregion
		
		#region 属性枚举
		public struct Fields
		{
			public const string DepartId=@"DepartId";
			public const string DepartName=@"DepartName";
						
		}

		#endregion
		
		
		#region 构造函数
		///<summary>
		///
		///</summary>
		public DepartInfo()
		{
		}
		///<summary>
		///
		///</summary>
		public DepartInfo(int pDepartId,string pDepartName)
		{
			departId   = pDepartId;
			departName = pDepartName;
			
		}
		
		
		///<summary>
		///
		///</summary>
		public DepartInfo(int departId)
		{
			 LoadFromId(departId);
		}
		
		private void LoadFromId(int departId)
		{
		 
			if (CachedEntityCommander.IsTypeRegistered(typeof(DepartInfo)))
            {
				DepartInfo departInfo=Find(GetList(), departId);
				if(departInfo==null)
					throw new AppException("未能在缓存中找到相应的键值对象");
                Copy(departInfo, this);
            }
            else
            {	Depart depart=new Depart( departId);	
				if(depart.IsNew)
				throw new AppException("尚未初始化");
               	LoadFromDAL(this, depart);
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
        public static  DepartInfo Find(List< DepartInfo> list,  int departId)
        {
             return list.Find(delegate( DepartInfo item) { return item. departId==departId; });
        }
		
		
		/// <summary>
        /// 得到缓存键
        /// </summary>
        /// <returns></returns>
        private static string GetCacheKey()
        {
            return string.Format(CachedEntityCommander.CacheKey, typeof( DepartInfo).ToString());
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
        public static void Copy(DepartInfo pDepartInfoFrom, DepartInfo pDepartInfoTo)
        {
	 		pDepartInfoTo.DepartId = pDepartInfoFrom.departId;
	 		pDepartInfoTo.DepartName = pDepartInfoFrom.departName;
			pDepartInfoTo.Loaded=pDepartInfoFrom.Loaded;
        }
		
		/// <summary>
		/// 批量装载
		/// </summary>
		internal static void LoadFromDALPatch(List< DepartInfo> pList, DepartCollection pCollection)
        {
            foreach (Depart depart in pCollection)
            {
                DepartInfo departInfo = new DepartInfo();
                LoadFromDAL(departInfo, depart );
                pList.Add(departInfo);
            }
			
        }

		//从后台获取数据
		internal  static void  LoadFromDAL(DepartInfo pDepartInfo, Depart  pDepart)
		{
	 		pDepartInfo.departId = pDepart.DepartId;
	 		pDepartInfo.departName = pDepart.DepartName;
			pDepartInfo.Loaded=true;
			
			}
		
		//数据持久化
		internal  static void  SaveToDb(DepartInfo pDepartInfo, Depart  pDepart,bool pIsNew)
		{
	 		pDepart.DepartId = pDepartInfo.departId;
	 		pDepart.DepartName = pDepartInfo.departName;
			pDepart.IsNew=pIsNew;
			string UserName = SubsonicHelper.GetUserName();
			try
			{
				pDepart.Save(UserName);
			}
			catch(Exception ex)
			{
				LogManager.getInstance().getLogger(typeof(DepartInfo)).Error(ex);
				if(ex.Message.Contains("插入重复键"))//违反了唯一键
				{
					throw new AppException("此对象已经存在");//此处等待优化可以从唯一约束中直接取出提示来，如果没有的话，默认为原始的出错提示
				}
				throw new AppException("保存失败");
			}
			pDepartInfo.departId = pDepart.DepartId;
			//如果缓存存在，更新缓存
			if (CachedEntityCommander.IsTypeRegistered(typeof(DepartInfo))) 
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
        public static List< DepartInfo> GetPagedList(int pPageIndex,int pPageSize,SortDirection pOrderBy,string pSortExpression,out int pRecordCount)
        {
			if(pPageIndex<=1)
			pPageIndex=1;
            List< DepartInfo> list = new List< DepartInfo>();
          
            Query q = Depart .CreateQuery();
            q.PageIndex = pPageIndex;
            q.PageSize = pPageSize;
            q.ORDER_BY(pSortExpression,pOrderBy.ToString());
			DepartCollection  collection=new  DepartCollection();
		 	collection.LoadAndCloseReader(q.ExecuteReader());
          
            foreach (Depart  depart  in collection)
            {
                DepartInfo departInfo = new DepartInfo();
                LoadFromDAL(departInfo,   depart);
                list.Add(departInfo);
            }
			pRecordCount=q.GetRecordCount();
			
            return list;

        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		/// <returns></returns>
		public static List< DepartInfo> GetList()
		{
			string cacheKey = GetCacheKey();
			//本实体已经注册成缓存实体，并且缓存存在的时候，直接从缓存取
			if (CachedEntityCommander.IsTypeRegistered(typeof(DepartInfo)) && CachedEntityCommander.GetCache(cacheKey) != null)
            {
                return CachedEntityCommander.GetCache(cacheKey) as List< DepartInfo>;
            }
            else 
            {
				List< DepartInfo>  list =new List< DepartInfo>();
				DepartCollection  collection=new  DepartCollection();
				Query qry = new Query(Depart.Schema);
				collection.LoadAndCloseReader(qry.ExecuteReader());
				foreach(Depart depart in collection)
				{
					DepartInfo departInfo= new DepartInfo();
					LoadFromDAL(departInfo,depart);
					list.Add(departInfo);
				}
			  	//生成缓存
                if (CachedEntityCommander.IsTypeRegistered(typeof(DepartInfo))) 
                {
                    CachedEntityCommander.SetCache(cacheKey, list);
                }
				return list;
			}
			
		
		}
		#endregion
		
		
		
		
		#region 公有属性
		
		///<summary>
		///部门Id
		///</summary>
		public int DepartId
		{
			get {return departId;}
			set {departId = value;}
		}

		///<summary>
		///部门名称
		///</summary>
		public string DepartName
		{
			get {return departName;}
			set {departName = value;}
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
			bool result=  (Depart.Delete(DepartId) == 1);
			//更新缓存
			if (result&&CachedEntityCommander.IsTypeRegistered(typeof(DepartInfo))) 
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
        public void CopyTo(DepartInfo pDepartInfoTo)
        {
            Copy(this,  pDepartInfoTo);
        }
		
		
		
		
		
		/// <summary>
		/// 保存
		/// </summary>
		public override void Save()
		{
			if(!m_Loaded)//新增
			{
				Depart depart=new Depart();	
				SaveToDb(this, depart,true);
			}
			else//修改
			{
				Depart depart=new Depart(departId);	
				if(depart.IsNew)
					throw new AppException("该数据已经不存在了");
				SaveToDb(this, depart,false);
			}
			
		}
		 
		#endregion
		
	}
}
