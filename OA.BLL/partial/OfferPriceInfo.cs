// ======================================================================================================================================
// 类说明
//=======================================================================================================================================
// 创建者：sk @Copy Right 残友软件有限公司OA项目 
// 文件名：OfferPriceInfo.cs
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
	///OfferPriceInfo  Data
	/// </summary>
	[Serializable]
	public partial class OfferPriceInfo:CanYou.EntityObject
	{
		#region 属性
		///<summary>
		///
		///</summary>
		private int offerPriceId;
		///<summary>
		///
		///</summary>
		private int? employeeId;
		///<summary>
		///
		///</summary>
		private int? mainProjectCreateId;
		///<summary>
		///
		///</summary>
		private int? mainOfferPriceId;
		///<summary>
		///
		///</summary>
		private string projectDes = String.Empty;
		///<summary>
		///
		///</summary>
		private string sheetNum = String.Empty;
		///<summary>
		///
		///</summary>
		private DateTime? fillTableDate;
		///<summary>
		///
		///</summary>
		private string finaceView = String.Empty;
		///<summary>
		///
		///</summary>
		private string sectionView = String.Empty;
		///<summary>
		///
		///</summary>
		private string mangerView = String.Empty;
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
		private int? isOver1;
		///<summary>
		///
		///</summary>
		private int? isOver2;
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
		private int? sendEmployeeId;
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
		private int preEmployeeId;
		///<summary>
		///
		///</summary>
		private string preEmployeeName = String.Empty;
		///<summary>
		///
		///</summary>
		private int? preIsApply;
		///<summary>
		///
		///</summary>
		private int? preIsOver;
		///<summary>
		///
		///</summary>
		private DateTime? preApplyTime;
		///<summary>
		///
		///</summary>
		private int? recvEmployeeId;
		///<summary>
		///
		///</summary>
		private int? isMain;
		///<summary>
		///
		///</summary>
		private int isMain1;
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
		private int? isNewCreate;
		///<summary>
		///
		///</summary>
		private int? isApprove;
		///<summary>
		///
		///</summary>
		private DateTime? approveTime;
		///<summary>
		///
		///</summary>
		private string today = String.Empty;
		///<summary>
		///
		///</summary>
		private int? offerPriceTypeId;
		///<summary>
		///
		///</summary>
		private int? offerFileId;
		///<summary>
		///
		///</summary>
		private string moneySum = String.Empty;
		///<summary>
		///
		///</summary>
		private string bigMoney = String.Empty;
		///<summary>
		///
		///</summary>
		private string productMoneySum = String.Empty;
		///<summary>
		///
		///</summary>
		private int? isSignName;
		
		
		///一对多关系,如果
		private bool m_Loaded=false;
		#endregion
		
		#region 属性枚举
		public struct Fields
		{
			public const string OfferPriceId=@"OfferPriceId";
			public const string EmployeeId=@"EmployeeId";
			public const string MainProjectCreateId=@"MainProjectCreateId";
			public const string MainOfferPriceId=@"MainOfferPriceId";
			public const string ProjectDes=@"ProjectDes";
			public const string SheetNum=@"SheetNum";
			public const string FillTableDate=@"FillTableDate";
			public const string FinaceView=@"FinaceView";
			public const string SectionView=@"SectionView";
			public const string MangerView=@"MangerView";
			public const string IsApply=@"IsApply";
			public const string IsApply1=@"IsApply1";
			public const string IsApply2=@"IsApply2";
			public const string IsOver1=@"IsOver1";
			public const string IsOver2=@"IsOver2";
			public const string ApplyTime=@"ApplyTime";
			public const string Apply1Time=@"Apply1Time";
			public const string Apply2Time=@"Apply2Time";
			public const string SendEmployeeId=@"SendEmployeeId";
			public const string Recv1EmployeeId=@"Recv1EmployeeId";
			public const string Recv2EmployeeId=@"Recv2EmployeeId";
			public const string SendEmployeeName=@"SendEmployeeName";
			public const string Recv1EmployeeName=@"Recv1EmployeeName";
			public const string Recv2EmployeeName=@"Recv2EmployeeName";
			public const string PreEmployeeId=@"PreEmployeeId";
			public const string PreEmployeeName=@"PreEmployeeName";
			public const string PreIsApply=@"PreIsApply";
			public const string PreIsOver=@"PreIsOver";
			public const string PreApplyTime=@"PreApplyTime";
			public const string RecvEmployeeId=@"RecvEmployeeId";
			public const string IsMain=@"IsMain";
			public const string IsMain1=@"IsMain1";
			public const string IsMain2=@"IsMain2";
			public const string IsMain3=@"IsMain3";
			public const string IsNewCreate=@"IsNewCreate";
			public const string IsApprove=@"IsApprove";
			public const string ApproveTime=@"ApproveTime";
			public const string Today=@"Today";
			public const string OfferPriceTypeId=@"OfferPriceTypeId";
			public const string OfferFileId=@"OfferFileId";
			public const string MoneySum=@"MoneySum";
			public const string BigMoney=@"BigMoney";
			public const string ProductMoneySum=@"ProductMoneySum";
			public const string IsSignName=@"IsSignName";
						
		}

		#endregion
		
		
		#region 构造函数
		///<summary>
		///
		///</summary>
		public OfferPriceInfo()
		{
		}
		///<summary>
		///
		///</summary>
		public OfferPriceInfo(int pOfferPriceId,int? pEmployeeId,int? pMainProjectCreateId,int? pMainOfferPriceId,string pProjectDes,string pSheetNum,DateTime? pFillTableDate,string pFinaceView,string pSectionView,string pMangerView,int? pIsApply,int? pIsApply1,int? pIsApply2,int? pIsOver1,int? pIsOver2,DateTime? pApplyTime,DateTime? pApply1Time,DateTime? pApply2Time,int? pSendEmployeeId,int? pRecv1EmployeeId,int? pRecv2EmployeeId,string pSendEmployeeName,string pRecv1EmployeeName,string pRecv2EmployeeName,int pPreEmployeeId,string pPreEmployeeName,int? pPreIsApply,int? pPreIsOver,DateTime? pPreApplyTime,int? pRecvEmployeeId,int? pIsMain,int pIsMain1,int? pIsMain2,int? pIsMain3,int? pIsNewCreate,int? pIsApprove,DateTime? pApproveTime,string pToday,int? pOfferPriceTypeId,int? pOfferFileId,string pMoneySum,string pBigMoney,string pProductMoneySum,int? pIsSignName)
		{
			offerPriceId        = pOfferPriceId;
			employeeId          = pEmployeeId;
			mainProjectCreateId = pMainProjectCreateId;
			mainOfferPriceId    = pMainOfferPriceId;
			projectDes          = pProjectDes;
			sheetNum            = pSheetNum;
			fillTableDate       = pFillTableDate;
			finaceView          = pFinaceView;
			sectionView         = pSectionView;
			mangerView          = pMangerView;
			isApply             = pIsApply;
			isApply1            = pIsApply1;
			isApply2            = pIsApply2;
			isOver1             = pIsOver1;
			isOver2             = pIsOver2;
			applyTime           = pApplyTime;
			apply1Time          = pApply1Time;
			apply2Time          = pApply2Time;
			sendEmployeeId      = pSendEmployeeId;
			recv1EmployeeId     = pRecv1EmployeeId;
			recv2EmployeeId     = pRecv2EmployeeId;
			sendEmployeeName    = pSendEmployeeName;
			recv1EmployeeName   = pRecv1EmployeeName;
			recv2EmployeeName   = pRecv2EmployeeName;
			preEmployeeId       = pPreEmployeeId;
			preEmployeeName     = pPreEmployeeName;
			preIsApply          = pPreIsApply;
			preIsOver           = pPreIsOver;
			preApplyTime        = pPreApplyTime;
			recvEmployeeId      = pRecvEmployeeId;
			isMain              = pIsMain;
			isMain1             = pIsMain1;
			isMain2             = pIsMain2;
			isMain3             = pIsMain3;
			isNewCreate         = pIsNewCreate;
			isApprove           = pIsApprove;
			approveTime         = pApproveTime;
			today               = pToday;
			offerPriceTypeId    = pOfferPriceTypeId;
			offerFileId         = pOfferFileId;
			moneySum            = pMoneySum;
			bigMoney            = pBigMoney;
			productMoneySum     = pProductMoneySum;
			isSignName          = pIsSignName;
			
		}
		
		
		///<summary>
		///
		///</summary>
		public OfferPriceInfo(int offerPriceId)
		{
			 LoadFromId(offerPriceId);
		}
		
		private void LoadFromId(int offerPriceId)
		{
		 
			if (CachedEntityCommander.IsTypeRegistered(typeof(OfferPriceInfo)))
            {
				OfferPriceInfo offerPriceInfo=Find(GetList(), offerPriceId);
				if(offerPriceInfo==null)
					throw new AppException("未能在缓存中找到相应的键值对象");
                Copy(offerPriceInfo, this);
            }
            else
            {	OfferPrice offerPrice=new OfferPrice( offerPriceId);	
				if(offerPrice.IsNew)
				throw new AppException("尚未初始化");
               	LoadFromDAL(this, offerPrice);
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
        public static  OfferPriceInfo Find(List< OfferPriceInfo> list,  int offerPriceId)
        {
             return list.Find(delegate( OfferPriceInfo item) { return item. offerPriceId==offerPriceId; });
        }
		
		
		/// <summary>
        /// 得到缓存键
        /// </summary>
        /// <returns></returns>
        private static string GetCacheKey()
        {
            return string.Format(CachedEntityCommander.CacheKey, typeof( OfferPriceInfo).ToString());
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
        public static void Copy(OfferPriceInfo pOfferPriceInfoFrom, OfferPriceInfo pOfferPriceInfoTo)
        {
	 		pOfferPriceInfoTo.OfferPriceId = pOfferPriceInfoFrom.offerPriceId;
	 		pOfferPriceInfoTo.EmployeeId = pOfferPriceInfoFrom.employeeId;
	 		pOfferPriceInfoTo.MainProjectCreateId = pOfferPriceInfoFrom.mainProjectCreateId;
	 		pOfferPriceInfoTo.MainOfferPriceId = pOfferPriceInfoFrom.mainOfferPriceId;
	 		pOfferPriceInfoTo.ProjectDes = pOfferPriceInfoFrom.projectDes;
	 		pOfferPriceInfoTo.SheetNum = pOfferPriceInfoFrom.sheetNum;
	 		pOfferPriceInfoTo.FillTableDate = pOfferPriceInfoFrom.fillTableDate;
	 		pOfferPriceInfoTo.FinaceView = pOfferPriceInfoFrom.finaceView;
	 		pOfferPriceInfoTo.SectionView = pOfferPriceInfoFrom.sectionView;
	 		pOfferPriceInfoTo.MangerView = pOfferPriceInfoFrom.mangerView;
	 		pOfferPriceInfoTo.IsApply = pOfferPriceInfoFrom.isApply;
	 		pOfferPriceInfoTo.IsApply1 = pOfferPriceInfoFrom.isApply1;
	 		pOfferPriceInfoTo.IsApply2 = pOfferPriceInfoFrom.isApply2;
	 		pOfferPriceInfoTo.IsOver1 = pOfferPriceInfoFrom.isOver1;
	 		pOfferPriceInfoTo.IsOver2 = pOfferPriceInfoFrom.isOver2;
	 		pOfferPriceInfoTo.ApplyTime = pOfferPriceInfoFrom.applyTime;
	 		pOfferPriceInfoTo.Apply1Time = pOfferPriceInfoFrom.apply1Time;
	 		pOfferPriceInfoTo.Apply2Time = pOfferPriceInfoFrom.apply2Time;
	 		pOfferPriceInfoTo.SendEmployeeId = pOfferPriceInfoFrom.sendEmployeeId;
	 		pOfferPriceInfoTo.Recv1EmployeeId = pOfferPriceInfoFrom.recv1EmployeeId;
	 		pOfferPriceInfoTo.Recv2EmployeeId = pOfferPriceInfoFrom.recv2EmployeeId;
	 		pOfferPriceInfoTo.SendEmployeeName = pOfferPriceInfoFrom.sendEmployeeName;
	 		pOfferPriceInfoTo.Recv1EmployeeName = pOfferPriceInfoFrom.recv1EmployeeName;
	 		pOfferPriceInfoTo.Recv2EmployeeName = pOfferPriceInfoFrom.recv2EmployeeName;
	 		pOfferPriceInfoTo.PreEmployeeId = pOfferPriceInfoFrom.preEmployeeId;
	 		pOfferPriceInfoTo.PreEmployeeName = pOfferPriceInfoFrom.preEmployeeName;
	 		pOfferPriceInfoTo.PreIsApply = pOfferPriceInfoFrom.preIsApply;
	 		pOfferPriceInfoTo.PreIsOver = pOfferPriceInfoFrom.preIsOver;
	 		pOfferPriceInfoTo.PreApplyTime = pOfferPriceInfoFrom.preApplyTime;
	 		pOfferPriceInfoTo.RecvEmployeeId = pOfferPriceInfoFrom.recvEmployeeId;
	 		pOfferPriceInfoTo.IsMain = pOfferPriceInfoFrom.isMain;
	 		pOfferPriceInfoTo.IsMain1 = pOfferPriceInfoFrom.isMain1;
	 		pOfferPriceInfoTo.IsMain2 = pOfferPriceInfoFrom.isMain2;
	 		pOfferPriceInfoTo.IsMain3 = pOfferPriceInfoFrom.isMain3;
	 		pOfferPriceInfoTo.IsNewCreate = pOfferPriceInfoFrom.isNewCreate;
	 		pOfferPriceInfoTo.IsApprove = pOfferPriceInfoFrom.isApprove;
	 		pOfferPriceInfoTo.ApproveTime = pOfferPriceInfoFrom.approveTime;
	 		pOfferPriceInfoTo.Today = pOfferPriceInfoFrom.today;
	 		pOfferPriceInfoTo.OfferPriceTypeId = pOfferPriceInfoFrom.offerPriceTypeId;
	 		pOfferPriceInfoTo.OfferFileId = pOfferPriceInfoFrom.offerFileId;
	 		pOfferPriceInfoTo.MoneySum = pOfferPriceInfoFrom.moneySum;
	 		pOfferPriceInfoTo.BigMoney = pOfferPriceInfoFrom.bigMoney;
	 		pOfferPriceInfoTo.ProductMoneySum = pOfferPriceInfoFrom.productMoneySum;
	 		pOfferPriceInfoTo.IsSignName = pOfferPriceInfoFrom.isSignName;
			pOfferPriceInfoTo.Loaded=pOfferPriceInfoFrom.Loaded;
        }
		
		/// <summary>
		/// 批量装载
		/// </summary>
		internal static void LoadFromDALPatch(List< OfferPriceInfo> pList, OfferPriceCollection pCollection)
        {
            foreach (OfferPrice offerPrice in pCollection)
            {
                OfferPriceInfo offerPriceInfo = new OfferPriceInfo();
                LoadFromDAL(offerPriceInfo, offerPrice );
                pList.Add(offerPriceInfo);
            }
			
        }

		//从后台获取数据
		internal  static void  LoadFromDAL(OfferPriceInfo pOfferPriceInfo, OfferPrice  pOfferPrice)
		{
	 		pOfferPriceInfo.offerPriceId = pOfferPrice.OfferPriceId;
	 		pOfferPriceInfo.employeeId = pOfferPrice.EmployeeId;
	 		pOfferPriceInfo.mainProjectCreateId = pOfferPrice.MainProjectCreateId;
	 		pOfferPriceInfo.mainOfferPriceId = pOfferPrice.MainOfferPriceId;
	 		pOfferPriceInfo.projectDes = pOfferPrice.ProjectDes;
	 		pOfferPriceInfo.sheetNum = pOfferPrice.SheetNum;
	 		pOfferPriceInfo.fillTableDate = pOfferPrice.FillTableDate;
	 		pOfferPriceInfo.finaceView = pOfferPrice.FinaceView;
	 		pOfferPriceInfo.sectionView = pOfferPrice.SectionView;
	 		pOfferPriceInfo.mangerView = pOfferPrice.MangerView;
	 		pOfferPriceInfo.isApply = pOfferPrice.IsApply;
	 		pOfferPriceInfo.isApply1 = pOfferPrice.IsApply1;
	 		pOfferPriceInfo.isApply2 = pOfferPrice.IsApply2;
	 		pOfferPriceInfo.isOver1 = pOfferPrice.IsOver1;
	 		pOfferPriceInfo.isOver2 = pOfferPrice.IsOver2;
	 		pOfferPriceInfo.applyTime = pOfferPrice.ApplyTime;
	 		pOfferPriceInfo.apply1Time = pOfferPrice.Apply1Time;
	 		pOfferPriceInfo.apply2Time = pOfferPrice.Apply2Time;
	 		pOfferPriceInfo.sendEmployeeId = pOfferPrice.SendEmployeeId;
	 		pOfferPriceInfo.recv1EmployeeId = pOfferPrice.Recv1EmployeeId;
	 		pOfferPriceInfo.recv2EmployeeId = pOfferPrice.Recv2EmployeeId;
	 		pOfferPriceInfo.sendEmployeeName = pOfferPrice.SendEmployeeName;
	 		pOfferPriceInfo.recv1EmployeeName = pOfferPrice.Recv1EmployeeName;
	 		pOfferPriceInfo.recv2EmployeeName = pOfferPrice.Recv2EmployeeName;
	 		pOfferPriceInfo.preEmployeeId = pOfferPrice.PreEmployeeId;
	 		pOfferPriceInfo.preEmployeeName = pOfferPrice.PreEmployeeName;
	 		pOfferPriceInfo.preIsApply = pOfferPrice.PreIsApply;
	 		pOfferPriceInfo.preIsOver = pOfferPrice.PreIsOver;
	 		pOfferPriceInfo.preApplyTime = pOfferPrice.PreApplyTime;
	 		pOfferPriceInfo.recvEmployeeId = pOfferPrice.RecvEmployeeId;
	 		pOfferPriceInfo.isMain = pOfferPrice.IsMain;
	 		pOfferPriceInfo.isMain1 = pOfferPrice.IsMain1;
	 		pOfferPriceInfo.isMain2 = pOfferPrice.IsMain2;
	 		pOfferPriceInfo.isMain3 = pOfferPrice.IsMain3;
	 		pOfferPriceInfo.isNewCreate = pOfferPrice.IsNewCreate;
	 		pOfferPriceInfo.isApprove = pOfferPrice.IsApprove;
	 		pOfferPriceInfo.approveTime = pOfferPrice.ApproveTime;
	 		pOfferPriceInfo.today = pOfferPrice.Today;
	 		pOfferPriceInfo.offerPriceTypeId = pOfferPrice.OfferPriceTypeId;
	 		pOfferPriceInfo.offerFileId = pOfferPrice.OfferFileId;
	 		pOfferPriceInfo.moneySum = pOfferPrice.MoneySum;
	 		pOfferPriceInfo.bigMoney = pOfferPrice.BigMoney;
	 		pOfferPriceInfo.productMoneySum = pOfferPrice.ProductMoneySum;
	 		pOfferPriceInfo.isSignName = pOfferPrice.IsSignName;
			pOfferPriceInfo.Loaded=true;
			
			}
		
		//数据持久化
		internal  static void  SaveToDb(OfferPriceInfo pOfferPriceInfo, OfferPrice  pOfferPrice,bool pIsNew)
		{
	 		pOfferPrice.OfferPriceId = pOfferPriceInfo.offerPriceId;
	 		pOfferPrice.EmployeeId = pOfferPriceInfo.employeeId;
	 		pOfferPrice.MainProjectCreateId = pOfferPriceInfo.mainProjectCreateId;
	 		pOfferPrice.MainOfferPriceId = pOfferPriceInfo.mainOfferPriceId;
	 		pOfferPrice.ProjectDes = pOfferPriceInfo.projectDes;
	 		pOfferPrice.SheetNum = pOfferPriceInfo.sheetNum;
	 		pOfferPrice.FillTableDate = pOfferPriceInfo.fillTableDate;
	 		pOfferPrice.FinaceView = pOfferPriceInfo.finaceView;
	 		pOfferPrice.SectionView = pOfferPriceInfo.sectionView;
	 		pOfferPrice.MangerView = pOfferPriceInfo.mangerView;
	 		pOfferPrice.IsApply = pOfferPriceInfo.isApply;
	 		pOfferPrice.IsApply1 = pOfferPriceInfo.isApply1;
	 		pOfferPrice.IsApply2 = pOfferPriceInfo.isApply2;
	 		pOfferPrice.IsOver1 = pOfferPriceInfo.isOver1;
	 		pOfferPrice.IsOver2 = pOfferPriceInfo.isOver2;
	 		pOfferPrice.ApplyTime = pOfferPriceInfo.applyTime;
	 		pOfferPrice.Apply1Time = pOfferPriceInfo.apply1Time;
	 		pOfferPrice.Apply2Time = pOfferPriceInfo.apply2Time;
	 		pOfferPrice.SendEmployeeId = pOfferPriceInfo.sendEmployeeId;
	 		pOfferPrice.Recv1EmployeeId = pOfferPriceInfo.recv1EmployeeId;
	 		pOfferPrice.Recv2EmployeeId = pOfferPriceInfo.recv2EmployeeId;
	 		pOfferPrice.SendEmployeeName = pOfferPriceInfo.sendEmployeeName;
	 		pOfferPrice.Recv1EmployeeName = pOfferPriceInfo.recv1EmployeeName;
	 		pOfferPrice.Recv2EmployeeName = pOfferPriceInfo.recv2EmployeeName;
	 		pOfferPrice.PreEmployeeId = pOfferPriceInfo.preEmployeeId;
	 		pOfferPrice.PreEmployeeName = pOfferPriceInfo.preEmployeeName;
	 		pOfferPrice.PreIsApply = pOfferPriceInfo.preIsApply;
	 		pOfferPrice.PreIsOver = pOfferPriceInfo.preIsOver;
	 		pOfferPrice.PreApplyTime = pOfferPriceInfo.preApplyTime;
	 		pOfferPrice.RecvEmployeeId = pOfferPriceInfo.recvEmployeeId;
	 		pOfferPrice.IsMain = pOfferPriceInfo.isMain;
	 		pOfferPrice.IsMain1 = pOfferPriceInfo.isMain1;
	 		pOfferPrice.IsMain2 = pOfferPriceInfo.isMain2;
	 		pOfferPrice.IsMain3 = pOfferPriceInfo.isMain3;
	 		pOfferPrice.IsNewCreate = pOfferPriceInfo.isNewCreate;
	 		pOfferPrice.IsApprove = pOfferPriceInfo.isApprove;
	 		pOfferPrice.ApproveTime = pOfferPriceInfo.approveTime;
	 		pOfferPrice.Today = pOfferPriceInfo.today;
	 		pOfferPrice.OfferPriceTypeId = pOfferPriceInfo.offerPriceTypeId;
	 		pOfferPrice.OfferFileId = pOfferPriceInfo.offerFileId;
	 		pOfferPrice.MoneySum = pOfferPriceInfo.moneySum;
	 		pOfferPrice.BigMoney = pOfferPriceInfo.bigMoney;
	 		pOfferPrice.ProductMoneySum = pOfferPriceInfo.productMoneySum;
	 		pOfferPrice.IsSignName = pOfferPriceInfo.isSignName;
			pOfferPrice.IsNew=pIsNew;
			string UserName = SubsonicHelper.GetUserName();
			try
			{
				pOfferPrice.Save(UserName);
			}
			catch(Exception ex)
			{
				LogManager.getInstance().getLogger(typeof(OfferPriceInfo)).Error(ex);
				if(ex.Message.Contains("插入重复键"))//违反了唯一键
				{
					throw new AppException("此对象已经存在");//此处等待优化可以从唯一约束中直接取出提示来，如果没有的话，默认为原始的出错提示
				}
				throw new AppException("保存失败");
			}
			pOfferPriceInfo.offerPriceId = pOfferPrice.OfferPriceId;
			//如果缓存存在，更新缓存
			if (CachedEntityCommander.IsTypeRegistered(typeof(OfferPriceInfo))) 
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
        public static List< OfferPriceInfo> GetPagedList(int pPageIndex,int pPageSize,SortDirection pOrderBy,string pSortExpression,out int pRecordCount)
        {
			if(pPageIndex<=1)
			pPageIndex=1;
            List< OfferPriceInfo> list = new List< OfferPriceInfo>();
          
            Query q = OfferPrice .CreateQuery();
            q.PageIndex = pPageIndex;
            q.PageSize = pPageSize;
            q.ORDER_BY(pSortExpression,pOrderBy.ToString());
			OfferPriceCollection  collection=new  OfferPriceCollection();
		 	collection.LoadAndCloseReader(q.ExecuteReader());
          
            foreach (OfferPrice  offerPrice  in collection)
            {
                OfferPriceInfo offerPriceInfo = new OfferPriceInfo();
                LoadFromDAL(offerPriceInfo,   offerPrice);
                list.Add(offerPriceInfo);
            }
			pRecordCount=q.GetRecordCount();
			
            return list;

        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		/// <returns></returns>
		public static List< OfferPriceInfo> GetList()
		{
			string cacheKey = GetCacheKey();
			//本实体已经注册成缓存实体，并且缓存存在的时候，直接从缓存取
			if (CachedEntityCommander.IsTypeRegistered(typeof(OfferPriceInfo)) && CachedEntityCommander.GetCache(cacheKey) != null)
            {
                return CachedEntityCommander.GetCache(cacheKey) as List< OfferPriceInfo>;
            }
            else 
            {
				List< OfferPriceInfo>  list =new List< OfferPriceInfo>();
				OfferPriceCollection  collection=new  OfferPriceCollection();
				Query qry = new Query(OfferPrice.Schema);
				collection.LoadAndCloseReader(qry.ExecuteReader());
				foreach(OfferPrice offerPrice in collection)
				{
					OfferPriceInfo offerPriceInfo= new OfferPriceInfo();
					LoadFromDAL(offerPriceInfo,offerPrice);
					list.Add(offerPriceInfo);
				}
			  	//生成缓存
                if (CachedEntityCommander.IsTypeRegistered(typeof(OfferPriceInfo))) 
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
		public int OfferPriceId
		{
			get {return offerPriceId;}
			set {offerPriceId = value;}
		}

		///<summary>
		///
		///</summary>
		public int? EmployeeId
		{
			get {return employeeId;}
			set {employeeId = value;}
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
		public int? MainOfferPriceId
		{
			get {return mainOfferPriceId;}
			set {mainOfferPriceId = value;}
		}

		///<summary>
		///
		///</summary>
		public string ProjectDes
		{
			get {return projectDes;}
			set {projectDes = value;}
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
		public DateTime? FillTableDate
		{
			get {return fillTableDate;}
			set {fillTableDate = value;}
		}

		///<summary>
		///
		///</summary>
		public string FinaceView
		{
			get {return finaceView;}
			set {finaceView = value;}
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
		public string MangerView
		{
			get {return mangerView;}
			set {mangerView = value;}
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
		public int? SendEmployeeId
		{
			get {return sendEmployeeId;}
			set {sendEmployeeId = value;}
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
		public int PreEmployeeId
		{
			get {return preEmployeeId;}
			set {preEmployeeId = value;}
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
		public int? PreIsApply
		{
			get {return preIsApply;}
			set {preIsApply = value;}
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
		public DateTime? PreApplyTime
		{
			get {return preApplyTime;}
			set {preApplyTime = value;}
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
		public int? IsMain
		{
			get {return isMain;}
			set {isMain = value;}
		}

		///<summary>
		///
		///</summary>
		public int IsMain1
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
		public int? IsNewCreate
		{
			get {return isNewCreate;}
			set {isNewCreate = value;}
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
		public DateTime? ApproveTime
		{
			get {return approveTime;}
			set {approveTime = value;}
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
		public int? OfferPriceTypeId
		{
			get {return offerPriceTypeId;}
			set {offerPriceTypeId = value;}
		}

		///<summary>
		///
		///</summary>
		public int? OfferFileId
		{
			get {return offerFileId;}
			set {offerFileId = value;}
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
		public string BigMoney
		{
			get {return bigMoney;}
			set {bigMoney = value;}
		}

		///<summary>
		///
		///</summary>
		public string ProductMoneySum
		{
			get {return productMoneySum;}
			set {productMoneySum = value;}
		}

		///<summary>
		///
		///</summary>
		public int? IsSignName
		{
			get {return isSignName;}
			set {isSignName = value;}
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
			bool result=  (OfferPrice.Delete(OfferPriceId) == 1);
			//更新缓存
			if (result&&CachedEntityCommander.IsTypeRegistered(typeof(OfferPriceInfo))) 
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
        public void CopyTo(OfferPriceInfo pOfferPriceInfoTo)
        {
            Copy(this,  pOfferPriceInfoTo);
        }
		
		
		
		
		
		/// <summary>
		/// 保存
		/// </summary>
		public override void Save()
		{
			if(!m_Loaded)//新增
			{
				OfferPrice offerPrice=new OfferPrice();	
				SaveToDb(this, offerPrice,true);
			}
			else//修改
			{
				OfferPrice offerPrice=new OfferPrice(offerPriceId);	
				if(offerPrice.IsNew)
					throw new AppException("该数据已经不存在了");
				SaveToDb(this, offerPrice,false);
			}
			
		}
		 
		#endregion
		
	}
}
