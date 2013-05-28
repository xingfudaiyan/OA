// ======================================================================================================================================
// 类说明
//=======================================================================================================================================
// 创建者：sk @Copy Right 残友软件有限公司OA项目 
// 文件名：CarApplyInfo.cs
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
	///CarApplyInfo  Data
	/// </summary>
	[Serializable]
	public partial class CarApplyInfo:CanYou.EntityObject
	{
		#region 属性
		///<summary>
		///
		///</summary>
		private int carApplyId;
		///<summary>
		///
		///</summary>
		private string sheetNum = String.Empty;
		///<summary>
		///
		///</summary>
		private DateTime? applyTime;
		///<summary>
		///
		///</summary>
		private string beginSite = String.Empty;
		///<summary>
		///
		///</summary>
		private string endSite = String.Empty;
		///<summary>
		///
		///</summary>
		private string reason = String.Empty;
		///<summary>
		///
		///</summary>
		private string memo = String.Empty;
		///<summary>
		///
		///</summary>
		private int? stateId;
		
		
		///一对多关系,如果
		private bool m_Loaded=false;
		#endregion
		
		#region 属性枚举
		public struct Fields
		{
			public const string CarApplyId=@"CarApplyId";
			public const string SheetNum=@"SheetNum";
			public const string ApplyTime=@"ApplyTime";
			public const string BeginSite=@"BeginSite";
			public const string EndSite=@"EndSite";
			public const string Reason=@"Reason";
			public const string Memo=@"Memo";
			public const string StateId=@"StateId";
						
		}

		#endregion
		
		
		#region 构造函数
		///<summary>
		///
		///</summary>
		public CarApplyInfo()
		{
		}
		///<summary>
		///
		///</summary>
		public CarApplyInfo(int pCarApplyId,string pSheetNum,DateTime? pApplyTime,string pBeginSite,string pEndSite,string pReason,string pMemo,int? pStateId)
		{
			carApplyId = pCarApplyId;
			sheetNum   = pSheetNum;
			applyTime  = pApplyTime;
			beginSite  = pBeginSite;
			endSite    = pEndSite;
			reason     = pReason;
			memo       = pMemo;
			stateId    = pStateId;
			
		}
		
		
		///<summary>
		///
		///</summary>
		public CarApplyInfo(int carApplyId)
		{
			 LoadFromId(carApplyId);
		}
		
		private void LoadFromId(int carApplyId)
		{
		 
			if (CachedEntityCommander.IsTypeRegistered(typeof(CarApplyInfo)))
            {
				CarApplyInfo carApplyInfo=Find(GetList(), carApplyId);
				if(carApplyInfo==null)
					throw new AppException("未能在缓存中找到相应的键值对象");
                Copy(carApplyInfo, this);
            }
            else
            {	CarApply carApply=new CarApply( carApplyId);	
				if(carApply.IsNew)
				throw new AppException("尚未初始化");
               	LoadFromDAL(this, carApply);
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
        public static  CarApplyInfo Find(List< CarApplyInfo> list,  int carApplyId)
        {
             return list.Find(delegate( CarApplyInfo item) { return item. carApplyId==carApplyId; });
        }
		
		
		/// <summary>
        /// 得到缓存键
        /// </summary>
        /// <returns></returns>
        private static string GetCacheKey()
        {
            return string.Format(CachedEntityCommander.CacheKey, typeof( CarApplyInfo).ToString());
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
        public static void Copy(CarApplyInfo pCarApplyInfoFrom, CarApplyInfo pCarApplyInfoTo)
        {
	 		pCarApplyInfoTo.CarApplyId = pCarApplyInfoFrom.carApplyId;
	 		pCarApplyInfoTo.SheetNum = pCarApplyInfoFrom.sheetNum;
	 		pCarApplyInfoTo.ApplyTime = pCarApplyInfoFrom.applyTime;
	 		pCarApplyInfoTo.BeginSite = pCarApplyInfoFrom.beginSite;
	 		pCarApplyInfoTo.EndSite = pCarApplyInfoFrom.endSite;
	 		pCarApplyInfoTo.Reason = pCarApplyInfoFrom.reason;
	 		pCarApplyInfoTo.Memo = pCarApplyInfoFrom.memo;
	 		pCarApplyInfoTo.StateId = pCarApplyInfoFrom.stateId;
			pCarApplyInfoTo.Loaded=pCarApplyInfoFrom.Loaded;
        }
		
		/// <summary>
		/// 批量装载
		/// </summary>
		internal static void LoadFromDALPatch(List< CarApplyInfo> pList, CarApplyCollection pCollection)
        {
            foreach (CarApply carApply in pCollection)
            {
                CarApplyInfo carApplyInfo = new CarApplyInfo();
                LoadFromDAL(carApplyInfo, carApply );
                pList.Add(carApplyInfo);
            }
			
        }

		//从后台获取数据
		internal  static void  LoadFromDAL(CarApplyInfo pCarApplyInfo, CarApply  pCarApply)
		{
	 		pCarApplyInfo.carApplyId = pCarApply.CarApplyId;
	 		pCarApplyInfo.sheetNum = pCarApply.SheetNum;
	 		pCarApplyInfo.applyTime = pCarApply.ApplyTime;
	 		pCarApplyInfo.beginSite = pCarApply.BeginSite;
	 		pCarApplyInfo.endSite = pCarApply.EndSite;
	 		pCarApplyInfo.reason = pCarApply.Reason;
	 		pCarApplyInfo.memo = pCarApply.Memo;
	 		pCarApplyInfo.stateId = pCarApply.StateId;
			pCarApplyInfo.Loaded=true;
			
			}
		
		//数据持久化
		internal  static void  SaveToDb(CarApplyInfo pCarApplyInfo, CarApply  pCarApply,bool pIsNew)
		{
	 		pCarApply.CarApplyId = pCarApplyInfo.carApplyId;
	 		pCarApply.SheetNum = pCarApplyInfo.sheetNum;
	 		pCarApply.ApplyTime = pCarApplyInfo.applyTime;
	 		pCarApply.BeginSite = pCarApplyInfo.beginSite;
	 		pCarApply.EndSite = pCarApplyInfo.endSite;
	 		pCarApply.Reason = pCarApplyInfo.reason;
	 		pCarApply.Memo = pCarApplyInfo.memo;
	 		pCarApply.StateId = pCarApplyInfo.stateId;
			pCarApply.IsNew=pIsNew;
			string UserName = SubsonicHelper.GetUserName();
			try
			{
				pCarApply.Save(UserName);
			}
			catch(Exception ex)
			{
				LogManager.getInstance().getLogger(typeof(CarApplyInfo)).Error(ex);
				if(ex.Message.Contains("插入重复键"))//违反了唯一键
				{
					throw new AppException("此对象已经存在");//此处等待优化可以从唯一约束中直接取出提示来，如果没有的话，默认为原始的出错提示
				}
				throw new AppException("保存失败");
			}
			pCarApplyInfo.carApplyId = pCarApply.CarApplyId;
			//如果缓存存在，更新缓存
			if (CachedEntityCommander.IsTypeRegistered(typeof(CarApplyInfo))) 
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
        public static List< CarApplyInfo> GetPagedList(int pPageIndex,int pPageSize,SortDirection pOrderBy,string pSortExpression,out int pRecordCount)
        {
			if(pPageIndex<=1)
			pPageIndex=1;
            List< CarApplyInfo> list = new List< CarApplyInfo>();
          
            Query q = CarApply .CreateQuery();
            q.PageIndex = pPageIndex;
            q.PageSize = pPageSize;
            q.ORDER_BY(pSortExpression,pOrderBy.ToString());
			CarApplyCollection  collection=new  CarApplyCollection();
		 	collection.LoadAndCloseReader(q.ExecuteReader());
          
            foreach (CarApply  carApply  in collection)
            {
                CarApplyInfo carApplyInfo = new CarApplyInfo();
                LoadFromDAL(carApplyInfo,   carApply);
                list.Add(carApplyInfo);
            }
			pRecordCount=q.GetRecordCount();
			
            return list;

        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		/// <returns></returns>
		public static List< CarApplyInfo> GetList()
		{
			string cacheKey = GetCacheKey();
			//本实体已经注册成缓存实体，并且缓存存在的时候，直接从缓存取
			if (CachedEntityCommander.IsTypeRegistered(typeof(CarApplyInfo)) && CachedEntityCommander.GetCache(cacheKey) != null)
            {
                return CachedEntityCommander.GetCache(cacheKey) as List< CarApplyInfo>;
            }
            else 
            {
				List< CarApplyInfo>  list =new List< CarApplyInfo>();
				CarApplyCollection  collection=new  CarApplyCollection();
				Query qry = new Query(CarApply.Schema);
				collection.LoadAndCloseReader(qry.ExecuteReader());
				foreach(CarApply carApply in collection)
				{
					CarApplyInfo carApplyInfo= new CarApplyInfo();
					LoadFromDAL(carApplyInfo,carApply);
					list.Add(carApplyInfo);
				}
			  	//生成缓存
                if (CachedEntityCommander.IsTypeRegistered(typeof(CarApplyInfo))) 
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
		public int CarApplyId
		{
			get {return carApplyId;}
			set {carApplyId = value;}
		}

		///<summary>
		///
		///</summary>
		public string SheetNum
		{
			get {return sheetNum;}
			set {sheetNum = value;}
		}

		///<summary>
		///
		///</summary>
		public DateTime? ApplyTime
		{
			get {return applyTime;}
			set {applyTime = value;}
		}

		///<summary>
		///
		///</summary>
		public string BeginSite
		{
			get {return beginSite;}
			set {beginSite = value;}
		}

		///<summary>
		///
		///</summary>
		public string EndSite
		{
			get {return endSite;}
			set {endSite = value;}
		}

		///<summary>
		///
		///</summary>
		public string Reason
		{
			get {return reason;}
			set {reason = value;}
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
		public int? StateId
		{
			get {return stateId;}
			set {stateId = value;}
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
			bool result=  (CarApply.Delete(CarApplyId) == 1);
			//更新缓存
			if (result&&CachedEntityCommander.IsTypeRegistered(typeof(CarApplyInfo))) 
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
        public void CopyTo(CarApplyInfo pCarApplyInfoTo)
        {
            Copy(this,  pCarApplyInfoTo);
        }
		
		
		
		
		
		/// <summary>
		/// 保存
		/// </summary>
		public override void Save()
		{
			if(!m_Loaded)//新增
			{
				CarApply carApply=new CarApply();	
				SaveToDb(this, carApply,true);
			}
			else//修改
			{
				CarApply carApply=new CarApply(carApplyId);	
				if(carApply.IsNew)
					throw new AppException("该数据已经不存在了");
				SaveToDb(this, carApply,false);
			}
			
		}
		 
		#endregion
		
	}
}
