// ======================================================================================================================================
// 类说明
//=======================================================================================================================================
// 创建者：sk @Copy Right 残友软件有限公司OA项目 
// 文件名：SpecialExpInfo.cs
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
	///SpecialExpInfo  Data
	/// </summary>
	[Serializable]
	public partial class SpecialExpInfo:CanYou.EntityObject
	{
		#region 属性
		///<summary>
		///
		///</summary>
		private int specialExpId;
		///<summary>
		///
		///</summary>
		private int? mainSpecialExpId;
		///<summary>
		///
		///</summary>
		private int? projectStepId;
		///<summary>
		///
		///</summary>
		private int? mainProjectCreateId;
		///<summary>
		///
		///</summary>
		private string sheetNum = String.Empty;
		///<summary>
		///
		///</summary>
		private string applyPeople = String.Empty;
		///<summary>
		///
		///</summary>
		private DateTime? applyDate;
		///<summary>
		///
		///</summary>
		private string applyReason = String.Empty;
		///<summary>
		///
		///</summary>
		private int? preIsApply;
		///<summary>
		///
		///</summary>
		private int? isApprove;
		///<summary>
		///
		///</summary>
		private int? isApply;
		///<summary>
		///
		///</summary>
		private int? isApply1;
		///<summary>
		///
		///</summary>
		private int? isApply2;
		///<summary>
		///
		///</summary>
		private int? preIsOver;
		///<summary>
		///
		///</summary>
		private int? isOver1;
		///<summary>
		///
		///</summary>
		private int? isOver2;
		///<summary>
		///
		///</summary>
		private DateTime? preApplyTime;
		///<summary>
		///
		///</summary>
		private DateTime? approveTime;
		///<summary>
		///
		///</summary>
		private DateTime? applyTime;
		///<summary>
		///
		///</summary>
		private DateTime? apply1Time;
		///<summary>
		///
		///</summary>
		private DateTime? apply2Time;
		///<summary>
		///
		///</summary>
		private int? preEmployeeId;
		///<summary>
		///
		///</summary>
		private int? sendEmployeeId;
		///<summary>
		///
		///</summary>
		private int? recvEmployeeId;
		///<summary>
		///
		///</summary>
		private int? recv1EmployeeId;
		///<summary>
		///
		///</summary>
		private int? recv2EmployeeId;
		///<summary>
		///
		///</summary>
		private string preEmployeeName = String.Empty;
		///<summary>
		///
		///</summary>
		private string sendEmployeeName = String.Empty;
		///<summary>
		///
		///</summary>
		private string recvEmployeeName = String.Empty;
		///<summary>
		///
		///</summary>
		private string recv1EmployeeName = String.Empty;
		///<summary>
		///
		///</summary>
		private string recv2EmployeeName = String.Empty;
		///<summary>
		///
		///</summary>
		private int? isNewCreate;
		///<summary>
		///
		///</summary>
		private int? isMain;
		///<summary>
		///
		///</summary>
		private int? isMain1;
		///<summary>
		///
		///</summary>
		private int? isMain2;
		///<summary>
		///
		///</summary>
		private int? isMain3;
		///<summary>
		///
		///</summary>
		private string applyMoney = String.Empty;
		///<summary>
		///
		///</summary>
		private string today = String.Empty;
		///<summary>
		///
		///</summary>
		private int? signName;
		
		
		///一对多关系,如果
		private bool m_Loaded=false;
		#endregion
		
		#region 属性枚举
		public struct Fields
		{
			public const string SpecialExpId=@"SpecialExpId";
			public const string MainSpecialExpId=@"MainSpecialExpId";
			public const string ProjectStepId=@"ProjectStepId";
			public const string MainProjectCreateId=@"MainProjectCreateId";
			public const string SheetNum=@"SheetNum";
			public const string ApplyPeople=@"ApplyPeople";
			public const string ApplyDate=@"ApplyDate";
			public const string ApplyReason=@"ApplyReason";
			public const string PreIsApply=@"PreIsApply";
			public const string IsApprove=@"IsApprove";
			public const string IsApply=@"IsApply";
			public const string IsApply1=@"IsApply1";
			public const string IsApply2=@"IsApply2";
			public const string PreIsOver=@"PreIsOver";
			public const string IsOver1=@"IsOver1";
			public const string IsOver2=@"IsOver2";
			public const string PreApplyTime=@"PreApplyTime";
			public const string ApproveTime=@"ApproveTime";
			public const string ApplyTime=@"ApplyTime";
			public const string Apply1Time=@"Apply1Time";
			public const string Apply2Time=@"Apply2Time";
			public const string PreEmployeeId=@"PreEmployeeId";
			public const string SendEmployeeId=@"SendEmployeeId";
			public const string RecvEmployeeId=@"RecvEmployeeId";
			public const string Recv1EmployeeId=@"Recv1EmployeeId";
			public const string Recv2EmployeeId=@"Recv2EmployeeId";
			public const string PreEmployeeName=@"PreEmployeeName";
			public const string SendEmployeeName=@"SendEmployeeName";
			public const string RecvEmployeeName=@"RecvEmployeeName";
			public const string Recv1EmployeeName=@"Recv1EmployeeName";
			public const string Recv2EmployeeName=@"Recv2EmployeeName";
			public const string IsNewCreate=@"IsNewCreate";
			public const string IsMain=@"IsMain";
			public const string IsMain1=@"IsMain1";
			public const string IsMain2=@"IsMain2";
			public const string IsMain3=@"IsMain3";
			public const string ApplyMoney=@"ApplyMoney";
			public const string Today=@"Today";
			public const string SignName=@"SignName";
						
		}

		#endregion
		
		
		#region 构造函数
		///<summary>
		///
		///</summary>
		public SpecialExpInfo()
		{
		}
		///<summary>
		///
		///</summary>
		public SpecialExpInfo(int pSpecialExpId,int? pMainSpecialExpId,int? pProjectStepId,int? pMainProjectCreateId,string pSheetNum,string pApplyPeople,DateTime? pApplyDate,string pApplyReason,int? pPreIsApply,int? pIsApprove,int? pIsApply,int? pIsApply1,int? pIsApply2,int? pPreIsOver,int? pIsOver1,int? pIsOver2,DateTime? pPreApplyTime,DateTime? pApproveTime,DateTime? pApplyTime,DateTime? pApply1Time,DateTime? pApply2Time,int? pPreEmployeeId,int? pSendEmployeeId,int? pRecvEmployeeId,int? pRecv1EmployeeId,int? pRecv2EmployeeId,string pPreEmployeeName,string pSendEmployeeName,string pRecvEmployeeName,string pRecv1EmployeeName,string pRecv2EmployeeName,int? pIsNewCreate,int? pIsMain,int? pIsMain1,int? pIsMain2,int? pIsMain3,string pApplyMoney,string pToday,int? pSignName)
		{
			specialExpId        = pSpecialExpId;
			mainSpecialExpId    = pMainSpecialExpId;
			projectStepId       = pProjectStepId;
			mainProjectCreateId = pMainProjectCreateId;
			sheetNum            = pSheetNum;
			applyPeople         = pApplyPeople;
			applyDate           = pApplyDate;
			applyReason         = pApplyReason;
			preIsApply          = pPreIsApply;
			isApprove           = pIsApprove;
			isApply             = pIsApply;
			isApply1            = pIsApply1;
			isApply2            = pIsApply2;
			preIsOver           = pPreIsOver;
			isOver1             = pIsOver1;
			isOver2             = pIsOver2;
			preApplyTime        = pPreApplyTime;
			approveTime         = pApproveTime;
			applyTime           = pApplyTime;
			apply1Time          = pApply1Time;
			apply2Time          = pApply2Time;
			preEmployeeId       = pPreEmployeeId;
			sendEmployeeId      = pSendEmployeeId;
			recvEmployeeId      = pRecvEmployeeId;
			recv1EmployeeId     = pRecv1EmployeeId;
			recv2EmployeeId     = pRecv2EmployeeId;
			preEmployeeName     = pPreEmployeeName;
			sendEmployeeName    = pSendEmployeeName;
			recvEmployeeName    = pRecvEmployeeName;
			recv1EmployeeName   = pRecv1EmployeeName;
			recv2EmployeeName   = pRecv2EmployeeName;
			isNewCreate         = pIsNewCreate;
			isMain              = pIsMain;
			isMain1             = pIsMain1;
			isMain2             = pIsMain2;
			isMain3             = pIsMain3;
			applyMoney          = pApplyMoney;
			today               = pToday;
			signName            = pSignName;
			
		}
		
		
		///<summary>
		///
		///</summary>
		public SpecialExpInfo(int specialExpId)
		{
			 LoadFromId(specialExpId);
		}
		
		private void LoadFromId(int specialExpId)
		{
		 
			if (CachedEntityCommander.IsTypeRegistered(typeof(SpecialExpInfo)))
            {
				SpecialExpInfo specialExpInfo=Find(GetList(), specialExpId);
				if(specialExpInfo==null)
					throw new AppException("未能在缓存中找到相应的键值对象");
                Copy(specialExpInfo, this);
            }
            else
            {	SpecialExp specialExp=new SpecialExp( specialExpId);	
				if(specialExp.IsNew)
				throw new AppException("尚未初始化");
               	LoadFromDAL(this, specialExp);
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
        public static  SpecialExpInfo Find(List< SpecialExpInfo> list,  int specialExpId)
        {
             return list.Find(delegate( SpecialExpInfo item) { return item. specialExpId==specialExpId; });
        }
		
		
		/// <summary>
        /// 得到缓存键
        /// </summary>
        /// <returns></returns>
        private static string GetCacheKey()
        {
            return string.Format(CachedEntityCommander.CacheKey, typeof( SpecialExpInfo).ToString());
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
        public static void Copy(SpecialExpInfo pSpecialExpInfoFrom, SpecialExpInfo pSpecialExpInfoTo)
        {
	 		pSpecialExpInfoTo.SpecialExpId = pSpecialExpInfoFrom.specialExpId;
	 		pSpecialExpInfoTo.MainSpecialExpId = pSpecialExpInfoFrom.mainSpecialExpId;
	 		pSpecialExpInfoTo.ProjectStepId = pSpecialExpInfoFrom.projectStepId;
	 		pSpecialExpInfoTo.MainProjectCreateId = pSpecialExpInfoFrom.mainProjectCreateId;
	 		pSpecialExpInfoTo.SheetNum = pSpecialExpInfoFrom.sheetNum;
	 		pSpecialExpInfoTo.ApplyPeople = pSpecialExpInfoFrom.applyPeople;
	 		pSpecialExpInfoTo.ApplyDate = pSpecialExpInfoFrom.applyDate;
	 		pSpecialExpInfoTo.ApplyReason = pSpecialExpInfoFrom.applyReason;
	 		pSpecialExpInfoTo.PreIsApply = pSpecialExpInfoFrom.preIsApply;
	 		pSpecialExpInfoTo.IsApprove = pSpecialExpInfoFrom.isApprove;
	 		pSpecialExpInfoTo.IsApply = pSpecialExpInfoFrom.isApply;
	 		pSpecialExpInfoTo.IsApply1 = pSpecialExpInfoFrom.isApply1;
	 		pSpecialExpInfoTo.IsApply2 = pSpecialExpInfoFrom.isApply2;
	 		pSpecialExpInfoTo.PreIsOver = pSpecialExpInfoFrom.preIsOver;
	 		pSpecialExpInfoTo.IsOver1 = pSpecialExpInfoFrom.isOver1;
	 		pSpecialExpInfoTo.IsOver2 = pSpecialExpInfoFrom.isOver2;
	 		pSpecialExpInfoTo.PreApplyTime = pSpecialExpInfoFrom.preApplyTime;
	 		pSpecialExpInfoTo.ApproveTime = pSpecialExpInfoFrom.approveTime;
	 		pSpecialExpInfoTo.ApplyTime = pSpecialExpInfoFrom.applyTime;
	 		pSpecialExpInfoTo.Apply1Time = pSpecialExpInfoFrom.apply1Time;
	 		pSpecialExpInfoTo.Apply2Time = pSpecialExpInfoFrom.apply2Time;
	 		pSpecialExpInfoTo.PreEmployeeId = pSpecialExpInfoFrom.preEmployeeId;
	 		pSpecialExpInfoTo.SendEmployeeId = pSpecialExpInfoFrom.sendEmployeeId;
	 		pSpecialExpInfoTo.RecvEmployeeId = pSpecialExpInfoFrom.recvEmployeeId;
	 		pSpecialExpInfoTo.Recv1EmployeeId = pSpecialExpInfoFrom.recv1EmployeeId;
	 		pSpecialExpInfoTo.Recv2EmployeeId = pSpecialExpInfoFrom.recv2EmployeeId;
	 		pSpecialExpInfoTo.PreEmployeeName = pSpecialExpInfoFrom.preEmployeeName;
	 		pSpecialExpInfoTo.SendEmployeeName = pSpecialExpInfoFrom.sendEmployeeName;
	 		pSpecialExpInfoTo.RecvEmployeeName = pSpecialExpInfoFrom.recvEmployeeName;
	 		pSpecialExpInfoTo.Recv1EmployeeName = pSpecialExpInfoFrom.recv1EmployeeName;
	 		pSpecialExpInfoTo.Recv2EmployeeName = pSpecialExpInfoFrom.recv2EmployeeName;
	 		pSpecialExpInfoTo.IsNewCreate = pSpecialExpInfoFrom.isNewCreate;
	 		pSpecialExpInfoTo.IsMain = pSpecialExpInfoFrom.isMain;
	 		pSpecialExpInfoTo.IsMain1 = pSpecialExpInfoFrom.isMain1;
	 		pSpecialExpInfoTo.IsMain2 = pSpecialExpInfoFrom.isMain2;
	 		pSpecialExpInfoTo.IsMain3 = pSpecialExpInfoFrom.isMain3;
	 		pSpecialExpInfoTo.ApplyMoney = pSpecialExpInfoFrom.applyMoney;
	 		pSpecialExpInfoTo.Today = pSpecialExpInfoFrom.today;
	 		pSpecialExpInfoTo.SignName = pSpecialExpInfoFrom.signName;
			pSpecialExpInfoTo.Loaded=pSpecialExpInfoFrom.Loaded;
        }
		
		/// <summary>
		/// 批量装载
		/// </summary>
		internal static void LoadFromDALPatch(List< SpecialExpInfo> pList, SpecialExpCollection pCollection)
        {
            foreach (SpecialExp specialExp in pCollection)
            {
                SpecialExpInfo specialExpInfo = new SpecialExpInfo();
                LoadFromDAL(specialExpInfo, specialExp );
                pList.Add(specialExpInfo);
            }
			
        }

		//从后台获取数据
		internal  static void  LoadFromDAL(SpecialExpInfo pSpecialExpInfo, SpecialExp  pSpecialExp)
		{
	 		pSpecialExpInfo.specialExpId = pSpecialExp.SpecialExpId;
	 		pSpecialExpInfo.mainSpecialExpId = pSpecialExp.MainSpecialExpId;
	 		pSpecialExpInfo.projectStepId = pSpecialExp.ProjectStepId;
	 		pSpecialExpInfo.mainProjectCreateId = pSpecialExp.MainProjectCreateId;
	 		pSpecialExpInfo.sheetNum = pSpecialExp.SheetNum;
	 		pSpecialExpInfo.applyPeople = pSpecialExp.ApplyPeople;
	 		pSpecialExpInfo.applyDate = pSpecialExp.ApplyDate;
	 		pSpecialExpInfo.applyReason = pSpecialExp.ApplyReason;
	 		pSpecialExpInfo.preIsApply = pSpecialExp.PreIsApply;
	 		pSpecialExpInfo.isApprove = pSpecialExp.IsApprove;
	 		pSpecialExpInfo.isApply = pSpecialExp.IsApply;
	 		pSpecialExpInfo.isApply1 = pSpecialExp.IsApply1;
	 		pSpecialExpInfo.isApply2 = pSpecialExp.IsApply2;
	 		pSpecialExpInfo.preIsOver = pSpecialExp.PreIsOver;
	 		pSpecialExpInfo.isOver1 = pSpecialExp.IsOver1;
	 		pSpecialExpInfo.isOver2 = pSpecialExp.IsOver2;
	 		pSpecialExpInfo.preApplyTime = pSpecialExp.PreApplyTime;
	 		pSpecialExpInfo.approveTime = pSpecialExp.ApproveTime;
	 		pSpecialExpInfo.applyTime = pSpecialExp.ApplyTime;
	 		pSpecialExpInfo.apply1Time = pSpecialExp.Apply1Time;
	 		pSpecialExpInfo.apply2Time = pSpecialExp.Apply2Time;
	 		pSpecialExpInfo.preEmployeeId = pSpecialExp.PreEmployeeId;
	 		pSpecialExpInfo.sendEmployeeId = pSpecialExp.SendEmployeeId;
	 		pSpecialExpInfo.recvEmployeeId = pSpecialExp.RecvEmployeeId;
	 		pSpecialExpInfo.recv1EmployeeId = pSpecialExp.Recv1EmployeeId;
	 		pSpecialExpInfo.recv2EmployeeId = pSpecialExp.Recv2EmployeeId;
	 		pSpecialExpInfo.preEmployeeName = pSpecialExp.PreEmployeeName;
	 		pSpecialExpInfo.sendEmployeeName = pSpecialExp.SendEmployeeName;
	 		pSpecialExpInfo.recvEmployeeName = pSpecialExp.RecvEmployeeName;
	 		pSpecialExpInfo.recv1EmployeeName = pSpecialExp.Recv1EmployeeName;
	 		pSpecialExpInfo.recv2EmployeeName = pSpecialExp.Recv2EmployeeName;
	 		pSpecialExpInfo.isNewCreate = pSpecialExp.IsNewCreate;
	 		pSpecialExpInfo.isMain = pSpecialExp.IsMain;
	 		pSpecialExpInfo.isMain1 = pSpecialExp.IsMain1;
	 		pSpecialExpInfo.isMain2 = pSpecialExp.IsMain2;
	 		pSpecialExpInfo.isMain3 = pSpecialExp.IsMain3;
	 		pSpecialExpInfo.applyMoney = pSpecialExp.ApplyMoney;
	 		pSpecialExpInfo.today = pSpecialExp.Today;
	 		pSpecialExpInfo.signName = pSpecialExp.SignName;
			pSpecialExpInfo.Loaded=true;
			
			}
		
		//数据持久化
		internal  static void  SaveToDb(SpecialExpInfo pSpecialExpInfo, SpecialExp  pSpecialExp,bool pIsNew)
		{
	 		pSpecialExp.SpecialExpId = pSpecialExpInfo.specialExpId;
	 		pSpecialExp.MainSpecialExpId = pSpecialExpInfo.mainSpecialExpId;
	 		pSpecialExp.ProjectStepId = pSpecialExpInfo.projectStepId;
	 		pSpecialExp.MainProjectCreateId = pSpecialExpInfo.mainProjectCreateId;
	 		pSpecialExp.SheetNum = pSpecialExpInfo.sheetNum;
	 		pSpecialExp.ApplyPeople = pSpecialExpInfo.applyPeople;
	 		pSpecialExp.ApplyDate = pSpecialExpInfo.applyDate;
	 		pSpecialExp.ApplyReason = pSpecialExpInfo.applyReason;
	 		pSpecialExp.PreIsApply = pSpecialExpInfo.preIsApply;
	 		pSpecialExp.IsApprove = pSpecialExpInfo.isApprove;
	 		pSpecialExp.IsApply = pSpecialExpInfo.isApply;
	 		pSpecialExp.IsApply1 = pSpecialExpInfo.isApply1;
	 		pSpecialExp.IsApply2 = pSpecialExpInfo.isApply2;
	 		pSpecialExp.PreIsOver = pSpecialExpInfo.preIsOver;
	 		pSpecialExp.IsOver1 = pSpecialExpInfo.isOver1;
	 		pSpecialExp.IsOver2 = pSpecialExpInfo.isOver2;
	 		pSpecialExp.PreApplyTime = pSpecialExpInfo.preApplyTime;
	 		pSpecialExp.ApproveTime = pSpecialExpInfo.approveTime;
	 		pSpecialExp.ApplyTime = pSpecialExpInfo.applyTime;
	 		pSpecialExp.Apply1Time = pSpecialExpInfo.apply1Time;
	 		pSpecialExp.Apply2Time = pSpecialExpInfo.apply2Time;
	 		pSpecialExp.PreEmployeeId = pSpecialExpInfo.preEmployeeId;
	 		pSpecialExp.SendEmployeeId = pSpecialExpInfo.sendEmployeeId;
	 		pSpecialExp.RecvEmployeeId = pSpecialExpInfo.recvEmployeeId;
	 		pSpecialExp.Recv1EmployeeId = pSpecialExpInfo.recv1EmployeeId;
	 		pSpecialExp.Recv2EmployeeId = pSpecialExpInfo.recv2EmployeeId;
	 		pSpecialExp.PreEmployeeName = pSpecialExpInfo.preEmployeeName;
	 		pSpecialExp.SendEmployeeName = pSpecialExpInfo.sendEmployeeName;
	 		pSpecialExp.RecvEmployeeName = pSpecialExpInfo.recvEmployeeName;
	 		pSpecialExp.Recv1EmployeeName = pSpecialExpInfo.recv1EmployeeName;
	 		pSpecialExp.Recv2EmployeeName = pSpecialExpInfo.recv2EmployeeName;
	 		pSpecialExp.IsNewCreate = pSpecialExpInfo.isNewCreate;
	 		pSpecialExp.IsMain = pSpecialExpInfo.isMain;
	 		pSpecialExp.IsMain1 = pSpecialExpInfo.isMain1;
	 		pSpecialExp.IsMain2 = pSpecialExpInfo.isMain2;
	 		pSpecialExp.IsMain3 = pSpecialExpInfo.isMain3;
	 		pSpecialExp.ApplyMoney = pSpecialExpInfo.applyMoney;
	 		pSpecialExp.Today = pSpecialExpInfo.today;
	 		pSpecialExp.SignName = pSpecialExpInfo.signName;
			pSpecialExp.IsNew=pIsNew;
			string UserName = SubsonicHelper.GetUserName();
			try
			{
				pSpecialExp.Save(UserName);
			}
			catch(Exception ex)
			{
				LogManager.getInstance().getLogger(typeof(SpecialExpInfo)).Error(ex);
				if(ex.Message.Contains("插入重复键"))//违反了唯一键
				{
					throw new AppException("此对象已经存在");//此处等待优化可以从唯一约束中直接取出提示来，如果没有的话，默认为原始的出错提示
				}
				throw new AppException("保存失败");
			}
			pSpecialExpInfo.specialExpId = pSpecialExp.SpecialExpId;
			//如果缓存存在，更新缓存
			if (CachedEntityCommander.IsTypeRegistered(typeof(SpecialExpInfo))) 
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
        public static List< SpecialExpInfo> GetPagedList(int pPageIndex,int pPageSize,SortDirection pOrderBy,string pSortExpression,out int pRecordCount)
        {
			if(pPageIndex<=1)
			pPageIndex=1;
            List< SpecialExpInfo> list = new List< SpecialExpInfo>();
          
            Query q = SpecialExp .CreateQuery();
            q.PageIndex = pPageIndex;
            q.PageSize = pPageSize;
            q.ORDER_BY(pSortExpression,pOrderBy.ToString());
			SpecialExpCollection  collection=new  SpecialExpCollection();
		 	collection.LoadAndCloseReader(q.ExecuteReader());
          
            foreach (SpecialExp  specialExp  in collection)
            {
                SpecialExpInfo specialExpInfo = new SpecialExpInfo();
                LoadFromDAL(specialExpInfo,   specialExp);
                list.Add(specialExpInfo);
            }
			pRecordCount=q.GetRecordCount();
			
            return list;

        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		/// <returns></returns>
		public static List< SpecialExpInfo> GetList()
		{
			string cacheKey = GetCacheKey();
			//本实体已经注册成缓存实体，并且缓存存在的时候，直接从缓存取
			if (CachedEntityCommander.IsTypeRegistered(typeof(SpecialExpInfo)) && CachedEntityCommander.GetCache(cacheKey) != null)
            {
                return CachedEntityCommander.GetCache(cacheKey) as List< SpecialExpInfo>;
            }
            else 
            {
				List< SpecialExpInfo>  list =new List< SpecialExpInfo>();
				SpecialExpCollection  collection=new  SpecialExpCollection();
				Query qry = new Query(SpecialExp.Schema);
				collection.LoadAndCloseReader(qry.ExecuteReader());
				foreach(SpecialExp specialExp in collection)
				{
					SpecialExpInfo specialExpInfo= new SpecialExpInfo();
					LoadFromDAL(specialExpInfo,specialExp);
					list.Add(specialExpInfo);
				}
			  	//生成缓存
                if (CachedEntityCommander.IsTypeRegistered(typeof(SpecialExpInfo))) 
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
		public int SpecialExpId
		{
			get {return specialExpId;}
			set {specialExpId = value;}
		}

		///<summary>
		///
		///</summary>
		public int? MainSpecialExpId
		{
			get {return mainSpecialExpId;}
			set {mainSpecialExpId = value;}
		}

		///<summary>
		///
		///</summary>
		public int? ProjectStepId
		{
			get {return projectStepId;}
			set {projectStepId = value;}
		}

		///<summary>
		///
		///</summary>
		public int? MainProjectCreateId
		{
			get {return mainProjectCreateId;}
			set {mainProjectCreateId = value;}
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
		public string ApplyPeople
		{
			get {return applyPeople;}
			set {applyPeople = value;}
		}

		///<summary>
		///
		///</summary>
		public DateTime? ApplyDate
		{
			get {return applyDate;}
			set {applyDate = value;}
		}

		///<summary>
		///
		///</summary>
		public string ApplyReason
		{
			get {return applyReason;}
			set {applyReason = value;}
		}

		///<summary>
		///
		///</summary>
		public int? PreIsApply
		{
			get {return preIsApply;}
			set {preIsApply = value;}
		}

		///<summary>
		///
		///</summary>
		public int? IsApprove
		{
			get {return isApprove;}
			set {isApprove = value;}
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
		public int? IsApply1
		{
			get {return isApply1;}
			set {isApply1 = value;}
		}

		///<summary>
		///
		///</summary>
		public int? IsApply2
		{
			get {return isApply2;}
			set {isApply2 = value;}
		}

		///<summary>
		///
		///</summary>
		public int? PreIsOver
		{
			get {return preIsOver;}
			set {preIsOver = value;}
		}

		///<summary>
		///
		///</summary>
		public int? IsOver1
		{
			get {return isOver1;}
			set {isOver1 = value;}
		}

		///<summary>
		///
		///</summary>
		public int? IsOver2
		{
			get {return isOver2;}
			set {isOver2 = value;}
		}

		///<summary>
		///
		///</summary>
		public DateTime? PreApplyTime
		{
			get {return preApplyTime;}
			set {preApplyTime = value;}
		}

		///<summary>
		///
		///</summary>
		public DateTime? ApproveTime
		{
			get {return approveTime;}
			set {approveTime = value;}
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
		public DateTime? Apply1Time
		{
			get {return apply1Time;}
			set {apply1Time = value;}
		}

		///<summary>
		///
		///</summary>
		public DateTime? Apply2Time
		{
			get {return apply2Time;}
			set {apply2Time = value;}
		}

		///<summary>
		///
		///</summary>
		public int? PreEmployeeId
		{
			get {return preEmployeeId;}
			set {preEmployeeId = value;}
		}

		///<summary>
		///
		///</summary>
		public int? SendEmployeeId
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
		public int? Recv1EmployeeId
		{
			get {return recv1EmployeeId;}
			set {recv1EmployeeId = value;}
		}

		///<summary>
		///
		///</summary>
		public int? Recv2EmployeeId
		{
			get {return recv2EmployeeId;}
			set {recv2EmployeeId = value;}
		}

		///<summary>
		///
		///</summary>
		public string PreEmployeeName
		{
			get {return preEmployeeName;}
			set {preEmployeeName = value;}
		}

		///<summary>
		///
		///</summary>
		public string SendEmployeeName
		{
			get {return sendEmployeeName;}
			set {sendEmployeeName = value;}
		}

		///<summary>
		///
		///</summary>
		public string RecvEmployeeName
		{
			get {return recvEmployeeName;}
			set {recvEmployeeName = value;}
		}

		///<summary>
		///
		///</summary>
		public string Recv1EmployeeName
		{
			get {return recv1EmployeeName;}
			set {recv1EmployeeName = value;}
		}

		///<summary>
		///
		///</summary>
		public string Recv2EmployeeName
		{
			get {return recv2EmployeeName;}
			set {recv2EmployeeName = value;}
		}

		///<summary>
		///
		///</summary>
		public int? IsNewCreate
		{
			get {return isNewCreate;}
			set {isNewCreate = value;}
		}

		///<summary>
		///
		///</summary>
		public int? IsMain
		{
			get {return isMain;}
			set {isMain = value;}
		}

		///<summary>
		///
		///</summary>
		public int? IsMain1
		{
			get {return isMain1;}
			set {isMain1 = value;}
		}

		///<summary>
		///
		///</summary>
		public int? IsMain2
		{
			get {return isMain2;}
			set {isMain2 = value;}
		}

		///<summary>
		///
		///</summary>
		public int? IsMain3
		{
			get {return isMain3;}
			set {isMain3 = value;}
		}

		///<summary>
		///
		///</summary>
		public string ApplyMoney
		{
			get {return applyMoney;}
			set {applyMoney = value;}
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
		public int? SignName
		{
			get {return signName;}
			set {signName = value;}
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
			bool result=  (SpecialExp.Delete(SpecialExpId) == 1);
			//更新缓存
			if (result&&CachedEntityCommander.IsTypeRegistered(typeof(SpecialExpInfo))) 
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
        public void CopyTo(SpecialExpInfo pSpecialExpInfoTo)
        {
            Copy(this,  pSpecialExpInfoTo);
        }
		
		
		
		
		
		/// <summary>
		/// 保存
		/// </summary>
		public override void Save()
		{
			if(!m_Loaded)//新增
			{
				SpecialExp specialExp=new SpecialExp();	
				SaveToDb(this, specialExp,true);
			}
			else//修改
			{
				SpecialExp specialExp=new SpecialExp(specialExpId);	
				if(specialExp.IsNew)
					throw new AppException("该数据已经不存在了");
				SaveToDb(this, specialExp,false);
			}
			
		}
		 
		#endregion
		
	}
}
