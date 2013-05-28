// ======================================================================================================================================
// 类说明
//=======================================================================================================================================
// 创建者：sk @Copy Right 残友软件有限公司OA项目 
// 文件名：ContractApplyInfo.cs
// 创建时间：2012-9-21
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
	///ContractApplyInfo  Data
	/// </summary>
	[Serializable]
	public partial class ContractApplyInfo:CanYou.EntityObject
	{
		#region 属性
		///<summary>
		///
		///</summary>
		private int contractApplyId;
		///<summary>
		///
		///</summary>
		private int? contractFileId;
		///<summary>
		///
		///</summary>
		private string signName = String.Empty;
		///<summary>
		///
		///</summary>
		private string contractNum = String.Empty;
		///<summary>
		///
		///</summary>
		private string sheetNum = String.Empty;
		///<summary>
		///
		///</summary>
		private string today = String.Empty;
		///<summary>
		///
		///</summary>
		private string contractName = String.Empty;
		///<summary>
		///
		///</summary>
		private string beginDate = String.Empty;
		///<summary>
		///
		///</summary>
		private string applyDate = String.Empty;
		///<summary>
		///
		///</summary>
		private string contractDes = String.Empty;
		///<summary>
		///
		///</summary>
		private string bigMoney = String.Empty;
		///<summary>
		///
		///</summary>
		private string smallMoney = String.Empty;
		///<summary>
		///
		///</summary>
		private string useStampType = String.Empty;
		///<summary>
		///
		///</summary>
		private string sectionView = String.Empty;
		///<summary>
		///
		///</summary>
		private string managerView = String.Empty;
		///<summary>
		///
		///</summary>
		private int? isMoney;
		///<summary>
		///
		///</summary>
		private string applyTime = String.Empty;
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
			public const string ContractApplyId=@"ContractApplyId";
			public const string ContractFileId=@"ContractFileId";
			public const string SignName=@"SignName";
			public const string ContractNum=@"ContractNum";
			public const string SheetNum=@"SheetNum";
			public const string Today=@"Today";
			public const string ContractName=@"ContractName";
			public const string BeginDate=@"BeginDate";
			public const string ApplyDate=@"ApplyDate";
			public const string ContractDes=@"ContractDes";
			public const string BigMoney=@"BigMoney";
			public const string SmallMoney=@"SmallMoney";
			public const string UseStampType=@"UseStampType";
			public const string SectionView=@"SectionView";
			public const string ManagerView=@"ManagerView";
			public const string IsMoney=@"IsMoney";
			public const string ApplyTime=@"ApplyTime";
			public const string ApplyName=@"ApplyName";
			public const string DepartName=@"DepartName";
			public const string State=@"State";
						
		}

		#endregion
		
		
		#region 构造函数
		///<summary>
		///
		///</summary>
		public ContractApplyInfo()
		{
		}
		///<summary>
		///
		///</summary>
		public ContractApplyInfo(int pContractApplyId,int? pContractFileId,string pSignName,string pContractNum,string pSheetNum,string pToday,string pContractName,string pBeginDate,string pApplyDate,string pContractDes,string pBigMoney,string pSmallMoney,string pUseStampType,string pSectionView,string pManagerView,int? pIsMoney,string pApplyTime,string pApplyName,string pDepartName,int? pState)
		{
			contractApplyId = pContractApplyId;
			contractFileId  = pContractFileId;
			signName        = pSignName;
			contractNum     = pContractNum;
			sheetNum        = pSheetNum;
			today           = pToday;
			contractName    = pContractName;
			beginDate       = pBeginDate;
			applyDate       = pApplyDate;
			contractDes     = pContractDes;
			bigMoney        = pBigMoney;
			smallMoney      = pSmallMoney;
			useStampType    = pUseStampType;
			sectionView     = pSectionView;
			managerView     = pManagerView;
			isMoney         = pIsMoney;
			applyTime       = pApplyTime;
			applyName       = pApplyName;
			departName      = pDepartName;
			state           = pState;
			
		}
		
		
		///<summary>
		///
		///</summary>
		public ContractApplyInfo(int contractApplyId)
		{
			 LoadFromId(contractApplyId);
		}
		
		private void LoadFromId(int contractApplyId)
		{
		 
			if (CachedEntityCommander.IsTypeRegistered(typeof(ContractApplyInfo)))
            {
				ContractApplyInfo contractApplyInfo=Find(GetList(), contractApplyId);
				if(contractApplyInfo==null)
					throw new AppException("未能在缓存中找到相应的键值对象");
                Copy(contractApplyInfo, this);
            }
            else
            {	ContractApply contractApply=new ContractApply( contractApplyId);	
				if(contractApply.IsNew)
				throw new AppException("尚未初始化");
               	LoadFromDAL(this, contractApply);
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
        public static  ContractApplyInfo Find(List< ContractApplyInfo> list,  int contractApplyId)
        {
             return list.Find(delegate( ContractApplyInfo item) { return item. contractApplyId==contractApplyId; });
        }
		
		
		/// <summary>
        /// 得到缓存键
        /// </summary>
        /// <returns></returns>
        private static string GetCacheKey()
        {
            return string.Format(CachedEntityCommander.CacheKey, typeof( ContractApplyInfo).ToString());
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
        public static void Copy(ContractApplyInfo pContractApplyInfoFrom, ContractApplyInfo pContractApplyInfoTo)
        {
	 		pContractApplyInfoTo.ContractApplyId = pContractApplyInfoFrom.contractApplyId;
	 		pContractApplyInfoTo.ContractFileId = pContractApplyInfoFrom.contractFileId;
	 		pContractApplyInfoTo.SignName = pContractApplyInfoFrom.signName;
	 		pContractApplyInfoTo.ContractNum = pContractApplyInfoFrom.contractNum;
	 		pContractApplyInfoTo.SheetNum = pContractApplyInfoFrom.sheetNum;
	 		pContractApplyInfoTo.Today = pContractApplyInfoFrom.today;
	 		pContractApplyInfoTo.ContractName = pContractApplyInfoFrom.contractName;
	 		pContractApplyInfoTo.BeginDate = pContractApplyInfoFrom.beginDate;
	 		pContractApplyInfoTo.ApplyDate = pContractApplyInfoFrom.applyDate;
	 		pContractApplyInfoTo.ContractDes = pContractApplyInfoFrom.contractDes;
	 		pContractApplyInfoTo.BigMoney = pContractApplyInfoFrom.bigMoney;
	 		pContractApplyInfoTo.SmallMoney = pContractApplyInfoFrom.smallMoney;
	 		pContractApplyInfoTo.UseStampType = pContractApplyInfoFrom.useStampType;
	 		pContractApplyInfoTo.SectionView = pContractApplyInfoFrom.sectionView;
	 		pContractApplyInfoTo.ManagerView = pContractApplyInfoFrom.managerView;
	 		pContractApplyInfoTo.IsMoney = pContractApplyInfoFrom.isMoney;
	 		pContractApplyInfoTo.ApplyTime = pContractApplyInfoFrom.applyTime;
	 		pContractApplyInfoTo.ApplyName = pContractApplyInfoFrom.applyName;
	 		pContractApplyInfoTo.DepartName = pContractApplyInfoFrom.departName;
	 		pContractApplyInfoTo.State = pContractApplyInfoFrom.state;
			pContractApplyInfoTo.Loaded=pContractApplyInfoFrom.Loaded;
        }
		
		/// <summary>
		/// 批量装载
		/// </summary>
		internal static void LoadFromDALPatch(List< ContractApplyInfo> pList, ContractApplyCollection pCollection)
        {
            foreach (ContractApply contractApply in pCollection)
            {
                ContractApplyInfo contractApplyInfo = new ContractApplyInfo();
                LoadFromDAL(contractApplyInfo, contractApply );
                pList.Add(contractApplyInfo);
            }
			
        }

		//从后台获取数据
		internal  static void  LoadFromDAL(ContractApplyInfo pContractApplyInfo, ContractApply  pContractApply)
		{
	 		pContractApplyInfo.contractApplyId = pContractApply.ContractApplyId;
	 		pContractApplyInfo.contractFileId = pContractApply.ContractFileId;
	 		pContractApplyInfo.signName = pContractApply.SignName;
	 		pContractApplyInfo.contractNum = pContractApply.ContractNum;
	 		pContractApplyInfo.sheetNum = pContractApply.SheetNum;
	 		pContractApplyInfo.today = pContractApply.Today;
	 		pContractApplyInfo.contractName = pContractApply.ContractName;
	 		pContractApplyInfo.beginDate = pContractApply.BeginDate;
	 		pContractApplyInfo.applyDate = pContractApply.ApplyDate;
	 		pContractApplyInfo.contractDes = pContractApply.ContractDes;
	 		pContractApplyInfo.bigMoney = pContractApply.BigMoney;
	 		pContractApplyInfo.smallMoney = pContractApply.SmallMoney;
	 		pContractApplyInfo.useStampType = pContractApply.UseStampType;
	 		pContractApplyInfo.sectionView = pContractApply.SectionView;
	 		pContractApplyInfo.managerView = pContractApply.ManagerView;
	 		pContractApplyInfo.isMoney = pContractApply.IsMoney;
	 		pContractApplyInfo.applyTime = pContractApply.ApplyTime;
	 		pContractApplyInfo.applyName = pContractApply.ApplyName;
	 		pContractApplyInfo.departName = pContractApply.DepartName;
	 		pContractApplyInfo.state = pContractApply.State;
			pContractApplyInfo.Loaded=true;
			
			}
		
		//数据持久化
		internal  static void  SaveToDb(ContractApplyInfo pContractApplyInfo, ContractApply  pContractApply,bool pIsNew)
		{
	 		pContractApply.ContractApplyId = pContractApplyInfo.contractApplyId;
	 		pContractApply.ContractFileId = pContractApplyInfo.contractFileId;
	 		pContractApply.SignName = pContractApplyInfo.signName;
	 		pContractApply.ContractNum = pContractApplyInfo.contractNum;
	 		pContractApply.SheetNum = pContractApplyInfo.sheetNum;
	 		pContractApply.Today = pContractApplyInfo.today;
	 		pContractApply.ContractName = pContractApplyInfo.contractName;
	 		pContractApply.BeginDate = pContractApplyInfo.beginDate;
	 		pContractApply.ApplyDate = pContractApplyInfo.applyDate;
	 		pContractApply.ContractDes = pContractApplyInfo.contractDes;
	 		pContractApply.BigMoney = pContractApplyInfo.bigMoney;
	 		pContractApply.SmallMoney = pContractApplyInfo.smallMoney;
	 		pContractApply.UseStampType = pContractApplyInfo.useStampType;
	 		pContractApply.SectionView = pContractApplyInfo.sectionView;
	 		pContractApply.ManagerView = pContractApplyInfo.managerView;
	 		pContractApply.IsMoney = pContractApplyInfo.isMoney;
	 		pContractApply.ApplyTime = pContractApplyInfo.applyTime;
	 		pContractApply.ApplyName = pContractApplyInfo.applyName;
	 		pContractApply.DepartName = pContractApplyInfo.departName;
	 		pContractApply.State = pContractApplyInfo.state;
			pContractApply.IsNew=pIsNew;
			string UserName = SubsonicHelper.GetUserName();
			try
			{
				pContractApply.Save(UserName);
			}
			catch(Exception ex)
			{
				LogManager.getInstance().getLogger(typeof(ContractApplyInfo)).Error(ex);
				if(ex.Message.Contains("插入重复键"))//违反了唯一键
				{
					throw new AppException("此对象已经存在");//此处等待优化可以从唯一约束中直接取出提示来，如果没有的话，默认为原始的出错提示
				}
				throw new AppException("保存失败");
			}
			pContractApplyInfo.contractApplyId = pContractApply.ContractApplyId;
			//如果缓存存在，更新缓存
			if (CachedEntityCommander.IsTypeRegistered(typeof(ContractApplyInfo))) 
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
        public static List< ContractApplyInfo> GetPagedList(int pPageIndex,int pPageSize,SortDirection pOrderBy,string pSortExpression,out int pRecordCount)
        {
			if(pPageIndex<=1)
			pPageIndex=1;
            List< ContractApplyInfo> list = new List< ContractApplyInfo>();
          
            Query q = ContractApply .CreateQuery();
            q.PageIndex = pPageIndex;
            q.PageSize = pPageSize;
            q.ORDER_BY(pSortExpression,pOrderBy.ToString());
			ContractApplyCollection  collection=new  ContractApplyCollection();
		 	collection.LoadAndCloseReader(q.ExecuteReader());
          
            foreach (ContractApply  contractApply  in collection)
            {
                ContractApplyInfo contractApplyInfo = new ContractApplyInfo();
                LoadFromDAL(contractApplyInfo,   contractApply);
                list.Add(contractApplyInfo);
            }
			pRecordCount=q.GetRecordCount();
			
            return list;

        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		/// <returns></returns>
		public static List< ContractApplyInfo> GetList()
		{
			string cacheKey = GetCacheKey();
			//本实体已经注册成缓存实体，并且缓存存在的时候，直接从缓存取
			if (CachedEntityCommander.IsTypeRegistered(typeof(ContractApplyInfo)) && CachedEntityCommander.GetCache(cacheKey) != null)
            {
                return CachedEntityCommander.GetCache(cacheKey) as List< ContractApplyInfo>;
            }
            else 
            {
				List< ContractApplyInfo>  list =new List< ContractApplyInfo>();
				ContractApplyCollection  collection=new  ContractApplyCollection();
				Query qry = new Query(ContractApply.Schema);
				collection.LoadAndCloseReader(qry.ExecuteReader());
				foreach(ContractApply contractApply in collection)
				{
					ContractApplyInfo contractApplyInfo= new ContractApplyInfo();
					LoadFromDAL(contractApplyInfo,contractApply);
					list.Add(contractApplyInfo);
				}
			  	//生成缓存
                if (CachedEntityCommander.IsTypeRegistered(typeof(ContractApplyInfo))) 
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
		public int ContractApplyId
		{
			get {return contractApplyId;}
			set {contractApplyId = value;}
		}

		///<summary>
		///
		///</summary>
		public int? ContractFileId
		{
			get {return contractFileId;}
			set {contractFileId = value;}
		}

		///<summary>
		///
		///</summary>
		public string SignName
		{
			get {return signName;}
			set {signName = value;}
		}

		///<summary>
		///
		///</summary>
		public string ContractNum
		{
			get {return contractNum;}
			set {contractNum = value;}
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
		public string Today
		{
			get {return today;}
			set {today = value;}
		}

		///<summary>
		///
		///</summary>
		public string ContractName
		{
			get {return contractName;}
			set {contractName = value;}
		}

		///<summary>
		///
		///</summary>
		public string BeginDate
		{
			get {return beginDate;}
			set {beginDate = value;}
		}

		///<summary>
		///
		///</summary>
		public string ApplyDate
		{
			get {return applyDate;}
			set {applyDate = value;}
		}

		///<summary>
		///
		///</summary>
		public string ContractDes
		{
			get {return contractDes;}
			set {contractDes = value;}
		}

		///<summary>
		///
		///</summary>
		public string BigMoney
		{
			get {return bigMoney;}
			set {bigMoney = value;}
		}

		///<summary>
		///
		///</summary>
		public string SmallMoney
		{
			get {return smallMoney;}
			set {smallMoney = value;}
		}

		///<summary>
		///
		///</summary>
		public string UseStampType
		{
			get {return useStampType;}
			set {useStampType = value;}
		}

		///<summary>
		///
		///</summary>
		public string SectionView
		{
			get {return sectionView;}
			set {sectionView = value;}
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
		public int? IsMoney
		{
			get {return isMoney;}
			set {isMoney = value;}
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
			bool result=  (ContractApply.Delete(ContractApplyId) == 1);
			//更新缓存
			if (result&&CachedEntityCommander.IsTypeRegistered(typeof(ContractApplyInfo))) 
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
        public void CopyTo(ContractApplyInfo pContractApplyInfoTo)
        {
            Copy(this,  pContractApplyInfoTo);
        }
		
		
		
		
		
		/// <summary>
		/// 保存
		/// </summary>
		public override void Save()
		{
			if(!m_Loaded)//新增
			{
				ContractApply contractApply=new ContractApply();	
				SaveToDb(this, contractApply,true);
			}
			else//修改
			{
				ContractApply contractApply=new ContractApply(contractApplyId);	
				if(contractApply.IsNew)
					throw new AppException("该数据已经不存在了");
				SaveToDb(this, contractApply,false);
			}
			
		}
		 
		#endregion
		
	}
}
