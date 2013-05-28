// ======================================================================================================================================
// 类说明
//=======================================================================================================================================
// 创建者：sk @Copy Right 残友软件有限公司OA项目 
// 文件名：BusinessExpInfo.cs
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
	///BusinessExpInfo  Data
	/// </summary>
	[Serializable]
	public partial class BusinessExpInfo:CanYou.EntityObject
	{
		#region 属性
		///<summary>
		///
		///</summary>
		private int businessExpId;
		///<summary>
		///
		///</summary>
		private int? mainBusinessExpId;
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
		private string depart = String.Empty;
		///<summary>
		///
		///</summary>
		private string memo = String.Empty;
		///<summary>
		///
		///</summary>
		private int? employee1Id;
		///<summary>
		///
		///</summary>
		private int? employee2Id;
		///<summary>
		///
		///</summary>
		private string reasonExp = String.Empty;
		///<summary>
		///
		///</summary>
		private DateTime? applyDate;
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
		private string sendEmployeeName = String.Empty;
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
		private string preEmployeeName = String.Empty;
		///<summary>
		///
		///</summary>
		private string recvEmployeeName = String.Empty;
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
		private string moneySum = String.Empty;
		///<summary>
		///
		///</summary>
		private string today = String.Empty;
		///<summary>
		///
		///</summary>
		private int? signName;
		///<summary>
		///
		///</summary>
		private string item1 = String.Empty;
		///<summary>
		///
		///</summary>
		private string item2 = String.Empty;
		///<summary>
		///
		///</summary>
		private string item3 = String.Empty;
		///<summary>
		///
		///</summary>
		private string item4 = String.Empty;
		///<summary>
		///
		///</summary>
		private string money1 = String.Empty;
		///<summary>
		///
		///</summary>
		private string money2 = String.Empty;
		///<summary>
		///
		///</summary>
		private string money3 = String.Empty;
		///<summary>
		///
		///</summary>
		private string money4 = String.Empty;
		
		
		///一对多关系,如果
		private bool m_Loaded=false;
		#endregion
		
		#region 属性枚举
		public struct Fields
		{
			public const string BusinessExpId=@"BusinessExpId";
			public const string MainBusinessExpId=@"MainBusinessExpId";
			public const string SheetNum=@"SheetNum";
			public const string ApplyPeople=@"ApplyPeople";
			public const string Depart=@"Depart";
			public const string Memo=@"Memo";
			public const string Employee1Id=@"Employee1Id";
			public const string Employee2Id=@"Employee2Id";
			public const string ReasonExp=@"ReasonExp";
			public const string ApplyDate=@"ApplyDate";
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
			public const string SendEmployeeName=@"SendEmployeeName";
			public const string Recv1EmployeeName=@"Recv1EmployeeName";
			public const string Recv2EmployeeName=@"Recv2EmployeeName";
			public const string PreEmployeeName=@"PreEmployeeName";
			public const string RecvEmployeeName=@"RecvEmployeeName";
			public const string IsNewCreate=@"IsNewCreate";
			public const string IsMain=@"IsMain";
			public const string IsMain1=@"IsMain1";
			public const string IsMain2=@"IsMain2";
			public const string IsMain3=@"IsMain3";
			public const string MoneySum=@"MoneySum";
			public const string Today=@"Today";
			public const string SignName=@"SignName";
			public const string Item1=@"Item1";
			public const string Item2=@"Item2";
			public const string Item3=@"Item3";
			public const string Item4=@"Item4";
			public const string Money1=@"Money1";
			public const string Money2=@"Money2";
			public const string Money3=@"Money3";
			public const string Money4=@"Money4";
						
		}

		#endregion
		
		
		#region 构造函数
		///<summary>
		///
		///</summary>
		public BusinessExpInfo()
		{
		}
		///<summary>
		///
		///</summary>
		public BusinessExpInfo(int pBusinessExpId,int? pMainBusinessExpId,string pSheetNum,string pApplyPeople,string pDepart,string pMemo,int? pEmployee1Id,int? pEmployee2Id,string pReasonExp,DateTime? pApplyDate,int? pPreIsApply,int? pIsApprove,int? pIsApply,int? pIsApply1,int? pIsApply2,int? pPreIsOver,int? pIsOver1,int? pIsOver2,DateTime? pPreApplyTime,DateTime? pApproveTime,DateTime? pApplyTime,DateTime? pApply1Time,DateTime? pApply2Time,int? pPreEmployeeId,int? pSendEmployeeId,int? pRecvEmployeeId,int? pRecv1EmployeeId,int? pRecv2EmployeeId,string pSendEmployeeName,string pRecv1EmployeeName,string pRecv2EmployeeName,string pPreEmployeeName,string pRecvEmployeeName,int? pIsNewCreate,int? pIsMain,int? pIsMain1,int? pIsMain2,int? pIsMain3,string pMoneySum,string pToday,int? pSignName,string pItem1,string pItem2,string pItem3,string pItem4,string pMoney1,string pMoney2,string pMoney3,string pMoney4)
		{
			businessExpId     = pBusinessExpId;
			mainBusinessExpId = pMainBusinessExpId;
			sheetNum          = pSheetNum;
			applyPeople       = pApplyPeople;
			depart            = pDepart;
			memo              = pMemo;
			employee1Id       = pEmployee1Id;
			employee2Id       = pEmployee2Id;
			reasonExp         = pReasonExp;
			applyDate         = pApplyDate;
			preIsApply        = pPreIsApply;
			isApprove         = pIsApprove;
			isApply           = pIsApply;
			isApply1          = pIsApply1;
			isApply2          = pIsApply2;
			preIsOver         = pPreIsOver;
			isOver1           = pIsOver1;
			isOver2           = pIsOver2;
			preApplyTime      = pPreApplyTime;
			approveTime       = pApproveTime;
			applyTime         = pApplyTime;
			apply1Time        = pApply1Time;
			apply2Time        = pApply2Time;
			preEmployeeId     = pPreEmployeeId;
			sendEmployeeId    = pSendEmployeeId;
			recvEmployeeId    = pRecvEmployeeId;
			recv1EmployeeId   = pRecv1EmployeeId;
			recv2EmployeeId   = pRecv2EmployeeId;
			sendEmployeeName  = pSendEmployeeName;
			recv1EmployeeName = pRecv1EmployeeName;
			recv2EmployeeName = pRecv2EmployeeName;
			preEmployeeName   = pPreEmployeeName;
			recvEmployeeName  = pRecvEmployeeName;
			isNewCreate       = pIsNewCreate;
			isMain            = pIsMain;
			isMain1           = pIsMain1;
			isMain2           = pIsMain2;
			isMain3           = pIsMain3;
			moneySum          = pMoneySum;
			today             = pToday;
			signName          = pSignName;
			item1             = pItem1;
			item2             = pItem2;
			item3             = pItem3;
			item4             = pItem4;
			money1            = pMoney1;
			money2            = pMoney2;
			money3            = pMoney3;
			money4            = pMoney4;
			
		}
		
		
		///<summary>
		///
		///</summary>
		public BusinessExpInfo(int businessExpId)
		{
			 LoadFromId(businessExpId);
		}
		
		private void LoadFromId(int businessExpId)
		{
		 
			if (CachedEntityCommander.IsTypeRegistered(typeof(BusinessExpInfo)))
            {
				BusinessExpInfo businessExpInfo=Find(GetList(), businessExpId);
				if(businessExpInfo==null)
					throw new AppException("未能在缓存中找到相应的键值对象");
                Copy(businessExpInfo, this);
            }
            else
            {	BusinessExp businessExp=new BusinessExp( businessExpId);	
				if(businessExp.IsNew)
				throw new AppException("尚未初始化");
               	LoadFromDAL(this, businessExp);
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
        public static  BusinessExpInfo Find(List< BusinessExpInfo> list,  int businessExpId)
        {
             return list.Find(delegate( BusinessExpInfo item) { return item. businessExpId==businessExpId; });
        }
		
		
		/// <summary>
        /// 得到缓存键
        /// </summary>
        /// <returns></returns>
        private static string GetCacheKey()
        {
            return string.Format(CachedEntityCommander.CacheKey, typeof( BusinessExpInfo).ToString());
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
        public static void Copy(BusinessExpInfo pBusinessExpInfoFrom, BusinessExpInfo pBusinessExpInfoTo)
        {
	 		pBusinessExpInfoTo.BusinessExpId = pBusinessExpInfoFrom.businessExpId;
	 		pBusinessExpInfoTo.MainBusinessExpId = pBusinessExpInfoFrom.mainBusinessExpId;
	 		pBusinessExpInfoTo.SheetNum = pBusinessExpInfoFrom.sheetNum;
	 		pBusinessExpInfoTo.ApplyPeople = pBusinessExpInfoFrom.applyPeople;
	 		pBusinessExpInfoTo.Depart = pBusinessExpInfoFrom.depart;
	 		pBusinessExpInfoTo.Memo = pBusinessExpInfoFrom.memo;
	 		pBusinessExpInfoTo.Employee1Id = pBusinessExpInfoFrom.employee1Id;
	 		pBusinessExpInfoTo.Employee2Id = pBusinessExpInfoFrom.employee2Id;
	 		pBusinessExpInfoTo.ReasonExp = pBusinessExpInfoFrom.reasonExp;
	 		pBusinessExpInfoTo.ApplyDate = pBusinessExpInfoFrom.applyDate;
	 		pBusinessExpInfoTo.PreIsApply = pBusinessExpInfoFrom.preIsApply;
	 		pBusinessExpInfoTo.IsApprove = pBusinessExpInfoFrom.isApprove;
	 		pBusinessExpInfoTo.IsApply = pBusinessExpInfoFrom.isApply;
	 		pBusinessExpInfoTo.IsApply1 = pBusinessExpInfoFrom.isApply1;
	 		pBusinessExpInfoTo.IsApply2 = pBusinessExpInfoFrom.isApply2;
	 		pBusinessExpInfoTo.PreIsOver = pBusinessExpInfoFrom.preIsOver;
	 		pBusinessExpInfoTo.IsOver1 = pBusinessExpInfoFrom.isOver1;
	 		pBusinessExpInfoTo.IsOver2 = pBusinessExpInfoFrom.isOver2;
	 		pBusinessExpInfoTo.PreApplyTime = pBusinessExpInfoFrom.preApplyTime;
	 		pBusinessExpInfoTo.ApproveTime = pBusinessExpInfoFrom.approveTime;
	 		pBusinessExpInfoTo.ApplyTime = pBusinessExpInfoFrom.applyTime;
	 		pBusinessExpInfoTo.Apply1Time = pBusinessExpInfoFrom.apply1Time;
	 		pBusinessExpInfoTo.Apply2Time = pBusinessExpInfoFrom.apply2Time;
	 		pBusinessExpInfoTo.PreEmployeeId = pBusinessExpInfoFrom.preEmployeeId;
	 		pBusinessExpInfoTo.SendEmployeeId = pBusinessExpInfoFrom.sendEmployeeId;
	 		pBusinessExpInfoTo.RecvEmployeeId = pBusinessExpInfoFrom.recvEmployeeId;
	 		pBusinessExpInfoTo.Recv1EmployeeId = pBusinessExpInfoFrom.recv1EmployeeId;
	 		pBusinessExpInfoTo.Recv2EmployeeId = pBusinessExpInfoFrom.recv2EmployeeId;
	 		pBusinessExpInfoTo.SendEmployeeName = pBusinessExpInfoFrom.sendEmployeeName;
	 		pBusinessExpInfoTo.Recv1EmployeeName = pBusinessExpInfoFrom.recv1EmployeeName;
	 		pBusinessExpInfoTo.Recv2EmployeeName = pBusinessExpInfoFrom.recv2EmployeeName;
	 		pBusinessExpInfoTo.PreEmployeeName = pBusinessExpInfoFrom.preEmployeeName;
	 		pBusinessExpInfoTo.RecvEmployeeName = pBusinessExpInfoFrom.recvEmployeeName;
	 		pBusinessExpInfoTo.IsNewCreate = pBusinessExpInfoFrom.isNewCreate;
	 		pBusinessExpInfoTo.IsMain = pBusinessExpInfoFrom.isMain;
	 		pBusinessExpInfoTo.IsMain1 = pBusinessExpInfoFrom.isMain1;
	 		pBusinessExpInfoTo.IsMain2 = pBusinessExpInfoFrom.isMain2;
	 		pBusinessExpInfoTo.IsMain3 = pBusinessExpInfoFrom.isMain3;
	 		pBusinessExpInfoTo.MoneySum = pBusinessExpInfoFrom.moneySum;
	 		pBusinessExpInfoTo.Today = pBusinessExpInfoFrom.today;
	 		pBusinessExpInfoTo.SignName = pBusinessExpInfoFrom.signName;
	 		pBusinessExpInfoTo.Item1 = pBusinessExpInfoFrom.item1;
	 		pBusinessExpInfoTo.Item2 = pBusinessExpInfoFrom.item2;
	 		pBusinessExpInfoTo.Item3 = pBusinessExpInfoFrom.item3;
	 		pBusinessExpInfoTo.Item4 = pBusinessExpInfoFrom.item4;
	 		pBusinessExpInfoTo.Money1 = pBusinessExpInfoFrom.money1;
	 		pBusinessExpInfoTo.Money2 = pBusinessExpInfoFrom.money2;
	 		pBusinessExpInfoTo.Money3 = pBusinessExpInfoFrom.money3;
	 		pBusinessExpInfoTo.Money4 = pBusinessExpInfoFrom.money4;
			pBusinessExpInfoTo.Loaded=pBusinessExpInfoFrom.Loaded;
        }
		
		/// <summary>
		/// 批量装载
		/// </summary>
		internal static void LoadFromDALPatch(List< BusinessExpInfo> pList, BusinessExpCollection pCollection)
        {
            foreach (BusinessExp businessExp in pCollection)
            {
                BusinessExpInfo businessExpInfo = new BusinessExpInfo();
                LoadFromDAL(businessExpInfo, businessExp );
                pList.Add(businessExpInfo);
            }
			
        }

		//从后台获取数据
		internal  static void  LoadFromDAL(BusinessExpInfo pBusinessExpInfo, BusinessExp  pBusinessExp)
		{
	 		pBusinessExpInfo.businessExpId = pBusinessExp.BusinessExpId;
	 		pBusinessExpInfo.mainBusinessExpId = pBusinessExp.MainBusinessExpId;
	 		pBusinessExpInfo.sheetNum = pBusinessExp.SheetNum;
	 		pBusinessExpInfo.applyPeople = pBusinessExp.ApplyPeople;
	 		pBusinessExpInfo.depart = pBusinessExp.Depart;
	 		pBusinessExpInfo.memo = pBusinessExp.Memo;
	 		pBusinessExpInfo.employee1Id = pBusinessExp.Employee1Id;
	 		pBusinessExpInfo.employee2Id = pBusinessExp.Employee2Id;
	 		pBusinessExpInfo.reasonExp = pBusinessExp.ReasonExp;
	 		pBusinessExpInfo.applyDate = pBusinessExp.ApplyDate;
	 		pBusinessExpInfo.preIsApply = pBusinessExp.PreIsApply;
	 		pBusinessExpInfo.isApprove = pBusinessExp.IsApprove;
	 		pBusinessExpInfo.isApply = pBusinessExp.IsApply;
	 		pBusinessExpInfo.isApply1 = pBusinessExp.IsApply1;
	 		pBusinessExpInfo.isApply2 = pBusinessExp.IsApply2;
	 		pBusinessExpInfo.preIsOver = pBusinessExp.PreIsOver;
	 		pBusinessExpInfo.isOver1 = pBusinessExp.IsOver1;
	 		pBusinessExpInfo.isOver2 = pBusinessExp.IsOver2;
	 		pBusinessExpInfo.preApplyTime = pBusinessExp.PreApplyTime;
	 		pBusinessExpInfo.approveTime = pBusinessExp.ApproveTime;
	 		pBusinessExpInfo.applyTime = pBusinessExp.ApplyTime;
	 		pBusinessExpInfo.apply1Time = pBusinessExp.Apply1Time;
	 		pBusinessExpInfo.apply2Time = pBusinessExp.Apply2Time;
	 		pBusinessExpInfo.preEmployeeId = pBusinessExp.PreEmployeeId;
	 		pBusinessExpInfo.sendEmployeeId = pBusinessExp.SendEmployeeId;
	 		pBusinessExpInfo.recvEmployeeId = pBusinessExp.RecvEmployeeId;
	 		pBusinessExpInfo.recv1EmployeeId = pBusinessExp.Recv1EmployeeId;
	 		pBusinessExpInfo.recv2EmployeeId = pBusinessExp.Recv2EmployeeId;
	 		pBusinessExpInfo.sendEmployeeName = pBusinessExp.SendEmployeeName;
	 		pBusinessExpInfo.recv1EmployeeName = pBusinessExp.Recv1EmployeeName;
	 		pBusinessExpInfo.recv2EmployeeName = pBusinessExp.Recv2EmployeeName;
	 		pBusinessExpInfo.preEmployeeName = pBusinessExp.PreEmployeeName;
	 		pBusinessExpInfo.recvEmployeeName = pBusinessExp.RecvEmployeeName;
	 		pBusinessExpInfo.isNewCreate = pBusinessExp.IsNewCreate;
	 		pBusinessExpInfo.isMain = pBusinessExp.IsMain;
	 		pBusinessExpInfo.isMain1 = pBusinessExp.IsMain1;
	 		pBusinessExpInfo.isMain2 = pBusinessExp.IsMain2;
	 		pBusinessExpInfo.isMain3 = pBusinessExp.IsMain3;
	 		pBusinessExpInfo.moneySum = pBusinessExp.MoneySum;
	 		pBusinessExpInfo.today = pBusinessExp.Today;
	 		pBusinessExpInfo.signName = pBusinessExp.SignName;
	 		pBusinessExpInfo.item1 = pBusinessExp.Item1;
	 		pBusinessExpInfo.item2 = pBusinessExp.Item2;
	 		pBusinessExpInfo.item3 = pBusinessExp.Item3;
	 		pBusinessExpInfo.item4 = pBusinessExp.Item4;
	 		pBusinessExpInfo.money1 = pBusinessExp.Money1;
	 		pBusinessExpInfo.money2 = pBusinessExp.Money2;
	 		pBusinessExpInfo.money3 = pBusinessExp.Money3;
	 		pBusinessExpInfo.money4 = pBusinessExp.Money4;
			pBusinessExpInfo.Loaded=true;
			
			}
		
		//数据持久化
		internal  static void  SaveToDb(BusinessExpInfo pBusinessExpInfo, BusinessExp  pBusinessExp,bool pIsNew)
		{
	 		pBusinessExp.BusinessExpId = pBusinessExpInfo.businessExpId;
	 		pBusinessExp.MainBusinessExpId = pBusinessExpInfo.mainBusinessExpId;
	 		pBusinessExp.SheetNum = pBusinessExpInfo.sheetNum;
	 		pBusinessExp.ApplyPeople = pBusinessExpInfo.applyPeople;
	 		pBusinessExp.Depart = pBusinessExpInfo.depart;
	 		pBusinessExp.Memo = pBusinessExpInfo.memo;
	 		pBusinessExp.Employee1Id = pBusinessExpInfo.employee1Id;
	 		pBusinessExp.Employee2Id = pBusinessExpInfo.employee2Id;
	 		pBusinessExp.ReasonExp = pBusinessExpInfo.reasonExp;
	 		pBusinessExp.ApplyDate = pBusinessExpInfo.applyDate;
	 		pBusinessExp.PreIsApply = pBusinessExpInfo.preIsApply;
	 		pBusinessExp.IsApprove = pBusinessExpInfo.isApprove;
	 		pBusinessExp.IsApply = pBusinessExpInfo.isApply;
	 		pBusinessExp.IsApply1 = pBusinessExpInfo.isApply1;
	 		pBusinessExp.IsApply2 = pBusinessExpInfo.isApply2;
	 		pBusinessExp.PreIsOver = pBusinessExpInfo.preIsOver;
	 		pBusinessExp.IsOver1 = pBusinessExpInfo.isOver1;
	 		pBusinessExp.IsOver2 = pBusinessExpInfo.isOver2;
	 		pBusinessExp.PreApplyTime = pBusinessExpInfo.preApplyTime;
	 		pBusinessExp.ApproveTime = pBusinessExpInfo.approveTime;
	 		pBusinessExp.ApplyTime = pBusinessExpInfo.applyTime;
	 		pBusinessExp.Apply1Time = pBusinessExpInfo.apply1Time;
	 		pBusinessExp.Apply2Time = pBusinessExpInfo.apply2Time;
	 		pBusinessExp.PreEmployeeId = pBusinessExpInfo.preEmployeeId;
	 		pBusinessExp.SendEmployeeId = pBusinessExpInfo.sendEmployeeId;
	 		pBusinessExp.RecvEmployeeId = pBusinessExpInfo.recvEmployeeId;
	 		pBusinessExp.Recv1EmployeeId = pBusinessExpInfo.recv1EmployeeId;
	 		pBusinessExp.Recv2EmployeeId = pBusinessExpInfo.recv2EmployeeId;
	 		pBusinessExp.SendEmployeeName = pBusinessExpInfo.sendEmployeeName;
	 		pBusinessExp.Recv1EmployeeName = pBusinessExpInfo.recv1EmployeeName;
	 		pBusinessExp.Recv2EmployeeName = pBusinessExpInfo.recv2EmployeeName;
	 		pBusinessExp.PreEmployeeName = pBusinessExpInfo.preEmployeeName;
	 		pBusinessExp.RecvEmployeeName = pBusinessExpInfo.recvEmployeeName;
	 		pBusinessExp.IsNewCreate = pBusinessExpInfo.isNewCreate;
	 		pBusinessExp.IsMain = pBusinessExpInfo.isMain;
	 		pBusinessExp.IsMain1 = pBusinessExpInfo.isMain1;
	 		pBusinessExp.IsMain2 = pBusinessExpInfo.isMain2;
	 		pBusinessExp.IsMain3 = pBusinessExpInfo.isMain3;
	 		pBusinessExp.MoneySum = pBusinessExpInfo.moneySum;
	 		pBusinessExp.Today = pBusinessExpInfo.today;
	 		pBusinessExp.SignName = pBusinessExpInfo.signName;
	 		pBusinessExp.Item1 = pBusinessExpInfo.item1;
	 		pBusinessExp.Item2 = pBusinessExpInfo.item2;
	 		pBusinessExp.Item3 = pBusinessExpInfo.item3;
	 		pBusinessExp.Item4 = pBusinessExpInfo.item4;
	 		pBusinessExp.Money1 = pBusinessExpInfo.money1;
	 		pBusinessExp.Money2 = pBusinessExpInfo.money2;
	 		pBusinessExp.Money3 = pBusinessExpInfo.money3;
	 		pBusinessExp.Money4 = pBusinessExpInfo.money4;
			pBusinessExp.IsNew=pIsNew;
			string UserName = SubsonicHelper.GetUserName();
			try
			{
				pBusinessExp.Save(UserName);
			}
			catch(Exception ex)
			{
				LogManager.getInstance().getLogger(typeof(BusinessExpInfo)).Error(ex);
				if(ex.Message.Contains("插入重复键"))//违反了唯一键
				{
					throw new AppException("此对象已经存在");//此处等待优化可以从唯一约束中直接取出提示来，如果没有的话，默认为原始的出错提示
				}
				throw new AppException("保存失败");
			}
			pBusinessExpInfo.businessExpId = pBusinessExp.BusinessExpId;
			//如果缓存存在，更新缓存
			if (CachedEntityCommander.IsTypeRegistered(typeof(BusinessExpInfo))) 
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
        public static List< BusinessExpInfo> GetPagedList(int pPageIndex,int pPageSize,SortDirection pOrderBy,string pSortExpression,out int pRecordCount)
        {
			if(pPageIndex<=1)
			pPageIndex=1;
            List< BusinessExpInfo> list = new List< BusinessExpInfo>();
          
            Query q = BusinessExp .CreateQuery();
            q.PageIndex = pPageIndex;
            q.PageSize = pPageSize;
            q.ORDER_BY(pSortExpression,pOrderBy.ToString());
			BusinessExpCollection  collection=new  BusinessExpCollection();
		 	collection.LoadAndCloseReader(q.ExecuteReader());
          
            foreach (BusinessExp  businessExp  in collection)
            {
                BusinessExpInfo businessExpInfo = new BusinessExpInfo();
                LoadFromDAL(businessExpInfo,   businessExp);
                list.Add(businessExpInfo);
            }
			pRecordCount=q.GetRecordCount();
			
            return list;

        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		/// <returns></returns>
		public static List< BusinessExpInfo> GetList()
		{
			string cacheKey = GetCacheKey();
			//本实体已经注册成缓存实体，并且缓存存在的时候，直接从缓存取
			if (CachedEntityCommander.IsTypeRegistered(typeof(BusinessExpInfo)) && CachedEntityCommander.GetCache(cacheKey) != null)
            {
                return CachedEntityCommander.GetCache(cacheKey) as List< BusinessExpInfo>;
            }
            else 
            {
				List< BusinessExpInfo>  list =new List< BusinessExpInfo>();
				BusinessExpCollection  collection=new  BusinessExpCollection();
				Query qry = new Query(BusinessExp.Schema);
				collection.LoadAndCloseReader(qry.ExecuteReader());
				foreach(BusinessExp businessExp in collection)
				{
					BusinessExpInfo businessExpInfo= new BusinessExpInfo();
					LoadFromDAL(businessExpInfo,businessExp);
					list.Add(businessExpInfo);
				}
			  	//生成缓存
                if (CachedEntityCommander.IsTypeRegistered(typeof(BusinessExpInfo))) 
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
		public int BusinessExpId
		{
			get {return businessExpId;}
			set {businessExpId = value;}
		}

		///<summary>
		///
		///</summary>
		public int? MainBusinessExpId
		{
			get {return mainBusinessExpId;}
			set {mainBusinessExpId = value;}
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
		public string Depart
		{
			get {return depart;}
			set {depart = value;}
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
		public int? Employee1Id
		{
			get {return employee1Id;}
			set {employee1Id = value;}
		}

		///<summary>
		///
		///</summary>
		public int? Employee2Id
		{
			get {return employee2Id;}
			set {employee2Id = value;}
		}

		///<summary>
		///
		///</summary>
		public string ReasonExp
		{
			get {return reasonExp;}
			set {reasonExp = value;}
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
		public string SendEmployeeName
		{
			get {return sendEmployeeName;}
			set {sendEmployeeName = value;}
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
		public string PreEmployeeName
		{
			get {return preEmployeeName;}
			set {preEmployeeName = value;}
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
		public string MoneySum
		{
			get {return moneySum;}
			set {moneySum = value;}
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

		///<summary>
		///
		///</summary>
		public string Item1
		{
			get {return item1;}
			set {item1 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Item2
		{
			get {return item2;}
			set {item2 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Item3
		{
			get {return item3;}
			set {item3 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Item4
		{
			get {return item4;}
			set {item4 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Money1
		{
			get {return money1;}
			set {money1 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Money2
		{
			get {return money2;}
			set {money2 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Money3
		{
			get {return money3;}
			set {money3 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Money4
		{
			get {return money4;}
			set {money4 = value;}
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
			bool result=  (BusinessExp.Delete(BusinessExpId) == 1);
			//更新缓存
			if (result&&CachedEntityCommander.IsTypeRegistered(typeof(BusinessExpInfo))) 
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
        public void CopyTo(BusinessExpInfo pBusinessExpInfoTo)
        {
            Copy(this,  pBusinessExpInfoTo);
        }
		
		
		
		
		
		/// <summary>
		/// 保存
		/// </summary>
		public override void Save()
		{
			if(!m_Loaded)//新增
			{
				BusinessExp businessExp=new BusinessExp();	
				SaveToDb(this, businessExp,true);
			}
			else//修改
			{
				BusinessExp businessExp=new BusinessExp(businessExpId);	
				if(businessExp.IsNew)
					throw new AppException("该数据已经不存在了");
				SaveToDb(this, businessExp,false);
			}
			
		}
		 
		#endregion
		
	}
}
