// ======================================================================================================================================
// 类说明
//=======================================================================================================================================
// 创建者：sk @Copy Right 残友软件有限公司OA项目 
// 文件名：TechEmScoreInfo.cs
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
	///TechEmScoreInfo  Data
	/// </summary>
	[Serializable]
	public partial class TechEmScoreInfo:CanYou.EntityObject
	{
		#region 属性
		///<summary>
		///
		///</summary>
		private int techEmScoreId;
		///<summary>
		///
		///</summary>
		private string selfPlan = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfWorkTotal = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfWorkSpeed = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfCommunicate = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfDescipline = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfExecute = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfRoute = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfProfession = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfAttitude = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfComplex = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfSpeciality = String.Empty;
		///<summary>
		///
		///</summary>
		private string upPlan = String.Empty;
		///<summary>
		///
		///</summary>
		private string upWorkTotal = String.Empty;
		///<summary>
		///
		///</summary>
		private string upWorkSpeed = String.Empty;
		///<summary>
		///
		///</summary>
		private string upCommunicate = String.Empty;
		///<summary>
		///
		///</summary>
		private string upDescipline = String.Empty;
		///<summary>
		///
		///</summary>
		private string upExecute = String.Empty;
		///<summary>
		///
		///</summary>
		private string upRoute = String.Empty;
		///<summary>
		///
		///</summary>
		private string upProfession = String.Empty;
		///<summary>
		///
		///</summary>
		private string upAttitude = String.Empty;
		///<summary>
		///
		///</summary>
		private string upComplex = String.Empty;
		///<summary>
		///
		///</summary>
		private string upSpeciality = String.Empty;
		///<summary>
		///
		///</summary>
		private string sectPlan = String.Empty;
		///<summary>
		///
		///</summary>
		private string sectWorkTotal = String.Empty;
		///<summary>
		///
		///</summary>
		private string sectWorkSpeed = String.Empty;
		///<summary>
		///
		///</summary>
		private string sectCommunicate = String.Empty;
		///<summary>
		///
		///</summary>
		private string sectDescipline = String.Empty;
		///<summary>
		///
		///</summary>
		private string sectExecute = String.Empty;
		///<summary>
		///
		///</summary>
		private string sectRoute = String.Empty;
		///<summary>
		///
		///</summary>
		private string sectProfession = String.Empty;
		///<summary>
		///
		///</summary>
		private string sectAttitude = String.Empty;
		///<summary>
		///
		///</summary>
		private string sectComplex = String.Empty;
		///<summary>
		///
		///</summary>
		private string sectSpeciality = String.Empty;
		///<summary>
		///
		///</summary>
		private string planFinish = String.Empty;
		///<summary>
		///
		///</summary>
		private string actualFinish = String.Empty;
		///<summary>
		///
		///</summary>
		private string finishRate = String.Empty;
		///<summary>
		///
		///</summary>
		private string finishScore = String.Empty;
		///<summary>
		///
		///</summary>
		private string reason = String.Empty;
		///<summary>
		///
		///</summary>
		private string addMinusSocre = String.Empty;
		///<summary>
		///
		///</summary>
		private string totalScore = String.Empty;
		///<summary>
		///
		///</summary>
		private string upViews = String.Empty;
		///<summary>
		///
		///</summary>
		private int? employeeId;
		///<summary>
		///
		///</summary>
		private int? isSubmit;
		///<summary>
		///
		///</summary>
		private string dateSpan = String.Empty;
		///<summary>
		///
		///</summary>
		private int? yearId;
		///<summary>
		///
		///</summary>
		private int? monthId;
		///<summary>
		///
		///</summary>
		private int? evaluateLevelId;
		
		
		///一对多关系,如果
		private bool m_Loaded=false;
		#endregion
		
		#region 属性枚举
		public struct Fields
		{
			public const string TechEmScoreId=@"TechEmScoreId";
			public const string SelfPlan=@"SelfPlan";
			public const string SelfWorkTotal=@"SelfWorkTotal";
			public const string SelfWorkSpeed=@"SelfWorkSpeed";
			public const string SelfCommunicate=@"SelfCommunicate";
			public const string SelfDescipline=@"SelfDescipline";
			public const string SelfExecute=@"SelfExecute";
			public const string SelfRoute=@"SelfRoute";
			public const string SelfProfession=@"SelfProfession";
			public const string SelfAttitude=@"SelfAttitude";
			public const string SelfComplex=@"SelfComplex";
			public const string SelfSpeciality=@"SelfSpeciality";
			public const string UpPlan=@"UpPlan";
			public const string UpWorkTotal=@"UpWorkTotal";
			public const string UpWorkSpeed=@"UpWorkSpeed";
			public const string UpCommunicate=@"UpCommunicate";
			public const string UpDescipline=@"UpDescipline";
			public const string UpExecute=@"UpExecute";
			public const string UpRoute=@"UpRoute";
			public const string UpProfession=@"UpProfession";
			public const string UpAttitude=@"UpAttitude";
			public const string UpComplex=@"UpComplex";
			public const string UpSpeciality=@"UpSpeciality";
			public const string SectPlan=@"SectPlan";
			public const string SectWorkTotal=@"SectWorkTotal";
			public const string SectWorkSpeed=@"SectWorkSpeed";
			public const string SectCommunicate=@"SectCommunicate";
			public const string SectDescipline=@"SectDescipline";
			public const string SectExecute=@"SectExecute";
			public const string SectRoute=@"SectRoute";
			public const string SectProfession=@"SectProfession";
			public const string SectAttitude=@"SectAttitude";
			public const string SectComplex=@"SectComplex";
			public const string SectSpeciality=@"SectSpeciality";
			public const string PlanFinish=@"PlanFinish";
			public const string ActualFinish=@"ActualFinish";
			public const string FinishRate=@"FinishRate";
			public const string FinishScore=@"FinishScore";
			public const string Reason=@"Reason";
			public const string AddMinusSocre=@"AddMinusSocre";
			public const string TotalScore=@"TotalScore";
			public const string UpViews=@"UpViews";
			public const string EmployeeId=@"EmployeeId";
			public const string IsSubmit=@"IsSubmit";
			public const string DateSpan=@"DateSpan";
			public const string YearId=@"YearId";
			public const string MonthId=@"MonthId";
			public const string EvaluateLevelId=@"EvaluateLevelId";
						
		}

		#endregion
		
		
		#region 构造函数
		///<summary>
		///
		///</summary>
		public TechEmScoreInfo()
		{
		}
		///<summary>
		///
		///</summary>
		public TechEmScoreInfo(int pTechEmScoreId,string pSelfPlan,string pSelfWorkTotal,string pSelfWorkSpeed,string pSelfCommunicate,string pSelfDescipline,string pSelfExecute,string pSelfRoute,string pSelfProfession,string pSelfAttitude,string pSelfComplex,string pSelfSpeciality,string pUpPlan,string pUpWorkTotal,string pUpWorkSpeed,string pUpCommunicate,string pUpDescipline,string pUpExecute,string pUpRoute,string pUpProfession,string pUpAttitude,string pUpComplex,string pUpSpeciality,string pSectPlan,string pSectWorkTotal,string pSectWorkSpeed,string pSectCommunicate,string pSectDescipline,string pSectExecute,string pSectRoute,string pSectProfession,string pSectAttitude,string pSectComplex,string pSectSpeciality,string pPlanFinish,string pActualFinish,string pFinishRate,string pFinishScore,string pReason,string pAddMinusSocre,string pTotalScore,string pUpViews,int? pEmployeeId,int? pIsSubmit,string pDateSpan,int? pYearId,int? pMonthId,int? pEvaluateLevelId)
		{
			techEmScoreId   = pTechEmScoreId;
			selfPlan        = pSelfPlan;
			selfWorkTotal   = pSelfWorkTotal;
			selfWorkSpeed   = pSelfWorkSpeed;
			selfCommunicate = pSelfCommunicate;
			selfDescipline  = pSelfDescipline;
			selfExecute     = pSelfExecute;
			selfRoute       = pSelfRoute;
			selfProfession  = pSelfProfession;
			selfAttitude    = pSelfAttitude;
			selfComplex     = pSelfComplex;
			selfSpeciality  = pSelfSpeciality;
			upPlan          = pUpPlan;
			upWorkTotal     = pUpWorkTotal;
			upWorkSpeed     = pUpWorkSpeed;
			upCommunicate   = pUpCommunicate;
			upDescipline    = pUpDescipline;
			upExecute       = pUpExecute;
			upRoute         = pUpRoute;
			upProfession    = pUpProfession;
			upAttitude      = pUpAttitude;
			upComplex       = pUpComplex;
			upSpeciality    = pUpSpeciality;
			sectPlan        = pSectPlan;
			sectWorkTotal   = pSectWorkTotal;
			sectWorkSpeed   = pSectWorkSpeed;
			sectCommunicate = pSectCommunicate;
			sectDescipline  = pSectDescipline;
			sectExecute     = pSectExecute;
			sectRoute       = pSectRoute;
			sectProfession  = pSectProfession;
			sectAttitude    = pSectAttitude;
			sectComplex     = pSectComplex;
			sectSpeciality  = pSectSpeciality;
			planFinish      = pPlanFinish;
			actualFinish    = pActualFinish;
			finishRate      = pFinishRate;
			finishScore     = pFinishScore;
			reason          = pReason;
			addMinusSocre   = pAddMinusSocre;
			totalScore      = pTotalScore;
			upViews         = pUpViews;
			employeeId      = pEmployeeId;
			isSubmit        = pIsSubmit;
			dateSpan        = pDateSpan;
			yearId          = pYearId;
			monthId         = pMonthId;
			evaluateLevelId = pEvaluateLevelId;
			
		}
		
		
		///<summary>
		///
		///</summary>
		public TechEmScoreInfo(int techEmScoreId)
		{
			 LoadFromId(techEmScoreId);
		}
		
		private void LoadFromId(int techEmScoreId)
		{
		 
			if (CachedEntityCommander.IsTypeRegistered(typeof(TechEmScoreInfo)))
            {
				TechEmScoreInfo techEmScoreInfo=Find(GetList(), techEmScoreId);
				if(techEmScoreInfo==null)
					throw new AppException("未能在缓存中找到相应的键值对象");
                Copy(techEmScoreInfo, this);
            }
            else
            {	TechEmScore techEmScore=new TechEmScore( techEmScoreId);	
				if(techEmScore.IsNew)
				throw new AppException("尚未初始化");
               	LoadFromDAL(this, techEmScore);
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
        public static  TechEmScoreInfo Find(List< TechEmScoreInfo> list,  int techEmScoreId)
        {
             return list.Find(delegate( TechEmScoreInfo item) { return item. techEmScoreId==techEmScoreId; });
        }
		
		
		/// <summary>
        /// 得到缓存键
        /// </summary>
        /// <returns></returns>
        private static string GetCacheKey()
        {
            return string.Format(CachedEntityCommander.CacheKey, typeof( TechEmScoreInfo).ToString());
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
        public static void Copy(TechEmScoreInfo pTechEmScoreInfoFrom, TechEmScoreInfo pTechEmScoreInfoTo)
        {
	 		pTechEmScoreInfoTo.TechEmScoreId = pTechEmScoreInfoFrom.techEmScoreId;
	 		pTechEmScoreInfoTo.SelfPlan = pTechEmScoreInfoFrom.selfPlan;
	 		pTechEmScoreInfoTo.SelfWorkTotal = pTechEmScoreInfoFrom.selfWorkTotal;
	 		pTechEmScoreInfoTo.SelfWorkSpeed = pTechEmScoreInfoFrom.selfWorkSpeed;
	 		pTechEmScoreInfoTo.SelfCommunicate = pTechEmScoreInfoFrom.selfCommunicate;
	 		pTechEmScoreInfoTo.SelfDescipline = pTechEmScoreInfoFrom.selfDescipline;
	 		pTechEmScoreInfoTo.SelfExecute = pTechEmScoreInfoFrom.selfExecute;
	 		pTechEmScoreInfoTo.SelfRoute = pTechEmScoreInfoFrom.selfRoute;
	 		pTechEmScoreInfoTo.SelfProfession = pTechEmScoreInfoFrom.selfProfession;
	 		pTechEmScoreInfoTo.SelfAttitude = pTechEmScoreInfoFrom.selfAttitude;
	 		pTechEmScoreInfoTo.SelfComplex = pTechEmScoreInfoFrom.selfComplex;
	 		pTechEmScoreInfoTo.SelfSpeciality = pTechEmScoreInfoFrom.selfSpeciality;
	 		pTechEmScoreInfoTo.UpPlan = pTechEmScoreInfoFrom.upPlan;
	 		pTechEmScoreInfoTo.UpWorkTotal = pTechEmScoreInfoFrom.upWorkTotal;
	 		pTechEmScoreInfoTo.UpWorkSpeed = pTechEmScoreInfoFrom.upWorkSpeed;
	 		pTechEmScoreInfoTo.UpCommunicate = pTechEmScoreInfoFrom.upCommunicate;
	 		pTechEmScoreInfoTo.UpDescipline = pTechEmScoreInfoFrom.upDescipline;
	 		pTechEmScoreInfoTo.UpExecute = pTechEmScoreInfoFrom.upExecute;
	 		pTechEmScoreInfoTo.UpRoute = pTechEmScoreInfoFrom.upRoute;
	 		pTechEmScoreInfoTo.UpProfession = pTechEmScoreInfoFrom.upProfession;
	 		pTechEmScoreInfoTo.UpAttitude = pTechEmScoreInfoFrom.upAttitude;
	 		pTechEmScoreInfoTo.UpComplex = pTechEmScoreInfoFrom.upComplex;
	 		pTechEmScoreInfoTo.UpSpeciality = pTechEmScoreInfoFrom.upSpeciality;
	 		pTechEmScoreInfoTo.SectPlan = pTechEmScoreInfoFrom.sectPlan;
	 		pTechEmScoreInfoTo.SectWorkTotal = pTechEmScoreInfoFrom.sectWorkTotal;
	 		pTechEmScoreInfoTo.SectWorkSpeed = pTechEmScoreInfoFrom.sectWorkSpeed;
	 		pTechEmScoreInfoTo.SectCommunicate = pTechEmScoreInfoFrom.sectCommunicate;
	 		pTechEmScoreInfoTo.SectDescipline = pTechEmScoreInfoFrom.sectDescipline;
	 		pTechEmScoreInfoTo.SectExecute = pTechEmScoreInfoFrom.sectExecute;
	 		pTechEmScoreInfoTo.SectRoute = pTechEmScoreInfoFrom.sectRoute;
	 		pTechEmScoreInfoTo.SectProfession = pTechEmScoreInfoFrom.sectProfession;
	 		pTechEmScoreInfoTo.SectAttitude = pTechEmScoreInfoFrom.sectAttitude;
	 		pTechEmScoreInfoTo.SectComplex = pTechEmScoreInfoFrom.sectComplex;
	 		pTechEmScoreInfoTo.SectSpeciality = pTechEmScoreInfoFrom.sectSpeciality;
	 		pTechEmScoreInfoTo.PlanFinish = pTechEmScoreInfoFrom.planFinish;
	 		pTechEmScoreInfoTo.ActualFinish = pTechEmScoreInfoFrom.actualFinish;
	 		pTechEmScoreInfoTo.FinishRate = pTechEmScoreInfoFrom.finishRate;
	 		pTechEmScoreInfoTo.FinishScore = pTechEmScoreInfoFrom.finishScore;
	 		pTechEmScoreInfoTo.Reason = pTechEmScoreInfoFrom.reason;
	 		pTechEmScoreInfoTo.AddMinusSocre = pTechEmScoreInfoFrom.addMinusSocre;
	 		pTechEmScoreInfoTo.TotalScore = pTechEmScoreInfoFrom.totalScore;
	 		pTechEmScoreInfoTo.UpViews = pTechEmScoreInfoFrom.upViews;
	 		pTechEmScoreInfoTo.EmployeeId = pTechEmScoreInfoFrom.employeeId;
	 		pTechEmScoreInfoTo.IsSubmit = pTechEmScoreInfoFrom.isSubmit;
	 		pTechEmScoreInfoTo.DateSpan = pTechEmScoreInfoFrom.dateSpan;
	 		pTechEmScoreInfoTo.YearId = pTechEmScoreInfoFrom.yearId;
	 		pTechEmScoreInfoTo.MonthId = pTechEmScoreInfoFrom.monthId;
	 		pTechEmScoreInfoTo.EvaluateLevelId = pTechEmScoreInfoFrom.evaluateLevelId;
			pTechEmScoreInfoTo.Loaded=pTechEmScoreInfoFrom.Loaded;
        }
		
		/// <summary>
		/// 批量装载
		/// </summary>
		internal static void LoadFromDALPatch(List< TechEmScoreInfo> pList, TechEmScoreCollection pCollection)
        {
            foreach (TechEmScore techEmScore in pCollection)
            {
                TechEmScoreInfo techEmScoreInfo = new TechEmScoreInfo();
                LoadFromDAL(techEmScoreInfo, techEmScore );
                pList.Add(techEmScoreInfo);
            }
			
        }

		//从后台获取数据
		internal  static void  LoadFromDAL(TechEmScoreInfo pTechEmScoreInfo, TechEmScore  pTechEmScore)
		{
	 		pTechEmScoreInfo.techEmScoreId = pTechEmScore.TechEmScoreId;
	 		pTechEmScoreInfo.selfPlan = pTechEmScore.SelfPlan;
	 		pTechEmScoreInfo.selfWorkTotal = pTechEmScore.SelfWorkTotal;
	 		pTechEmScoreInfo.selfWorkSpeed = pTechEmScore.SelfWorkSpeed;
	 		pTechEmScoreInfo.selfCommunicate = pTechEmScore.SelfCommunicate;
	 		pTechEmScoreInfo.selfDescipline = pTechEmScore.SelfDescipline;
	 		pTechEmScoreInfo.selfExecute = pTechEmScore.SelfExecute;
	 		pTechEmScoreInfo.selfRoute = pTechEmScore.SelfRoute;
	 		pTechEmScoreInfo.selfProfession = pTechEmScore.SelfProfession;
	 		pTechEmScoreInfo.selfAttitude = pTechEmScore.SelfAttitude;
	 		pTechEmScoreInfo.selfComplex = pTechEmScore.SelfComplex;
	 		pTechEmScoreInfo.selfSpeciality = pTechEmScore.SelfSpeciality;
	 		pTechEmScoreInfo.upPlan = pTechEmScore.UpPlan;
	 		pTechEmScoreInfo.upWorkTotal = pTechEmScore.UpWorkTotal;
	 		pTechEmScoreInfo.upWorkSpeed = pTechEmScore.UpWorkSpeed;
	 		pTechEmScoreInfo.upCommunicate = pTechEmScore.UpCommunicate;
	 		pTechEmScoreInfo.upDescipline = pTechEmScore.UpDescipline;
	 		pTechEmScoreInfo.upExecute = pTechEmScore.UpExecute;
	 		pTechEmScoreInfo.upRoute = pTechEmScore.UpRoute;
	 		pTechEmScoreInfo.upProfession = pTechEmScore.UpProfession;
	 		pTechEmScoreInfo.upAttitude = pTechEmScore.UpAttitude;
	 		pTechEmScoreInfo.upComplex = pTechEmScore.UpComplex;
	 		pTechEmScoreInfo.upSpeciality = pTechEmScore.UpSpeciality;
	 		pTechEmScoreInfo.sectPlan = pTechEmScore.SectPlan;
	 		pTechEmScoreInfo.sectWorkTotal = pTechEmScore.SectWorkTotal;
	 		pTechEmScoreInfo.sectWorkSpeed = pTechEmScore.SectWorkSpeed;
	 		pTechEmScoreInfo.sectCommunicate = pTechEmScore.SectCommunicate;
	 		pTechEmScoreInfo.sectDescipline = pTechEmScore.SectDescipline;
	 		pTechEmScoreInfo.sectExecute = pTechEmScore.SectExecute;
	 		pTechEmScoreInfo.sectRoute = pTechEmScore.SectRoute;
	 		pTechEmScoreInfo.sectProfession = pTechEmScore.SectProfession;
	 		pTechEmScoreInfo.sectAttitude = pTechEmScore.SectAttitude;
	 		pTechEmScoreInfo.sectComplex = pTechEmScore.SectComplex;
	 		pTechEmScoreInfo.sectSpeciality = pTechEmScore.SectSpeciality;
	 		pTechEmScoreInfo.planFinish = pTechEmScore.PlanFinish;
	 		pTechEmScoreInfo.actualFinish = pTechEmScore.ActualFinish;
	 		pTechEmScoreInfo.finishRate = pTechEmScore.FinishRate;
	 		pTechEmScoreInfo.finishScore = pTechEmScore.FinishScore;
	 		pTechEmScoreInfo.reason = pTechEmScore.Reason;
	 		pTechEmScoreInfo.addMinusSocre = pTechEmScore.AddMinusSocre;
	 		pTechEmScoreInfo.totalScore = pTechEmScore.TotalScore;
	 		pTechEmScoreInfo.upViews = pTechEmScore.UpViews;
	 		pTechEmScoreInfo.employeeId = pTechEmScore.EmployeeId;
	 		pTechEmScoreInfo.isSubmit = pTechEmScore.IsSubmit;
	 		pTechEmScoreInfo.dateSpan = pTechEmScore.DateSpan;
	 		pTechEmScoreInfo.yearId = pTechEmScore.YearId;
	 		pTechEmScoreInfo.monthId = pTechEmScore.MonthId;
	 		pTechEmScoreInfo.evaluateLevelId = pTechEmScore.EvaluateLevelId;
			pTechEmScoreInfo.Loaded=true;
			
			}
		
		//数据持久化
		internal  static void  SaveToDb(TechEmScoreInfo pTechEmScoreInfo, TechEmScore  pTechEmScore,bool pIsNew)
		{
	 		pTechEmScore.TechEmScoreId = pTechEmScoreInfo.techEmScoreId;
	 		pTechEmScore.SelfPlan = pTechEmScoreInfo.selfPlan;
	 		pTechEmScore.SelfWorkTotal = pTechEmScoreInfo.selfWorkTotal;
	 		pTechEmScore.SelfWorkSpeed = pTechEmScoreInfo.selfWorkSpeed;
	 		pTechEmScore.SelfCommunicate = pTechEmScoreInfo.selfCommunicate;
	 		pTechEmScore.SelfDescipline = pTechEmScoreInfo.selfDescipline;
	 		pTechEmScore.SelfExecute = pTechEmScoreInfo.selfExecute;
	 		pTechEmScore.SelfRoute = pTechEmScoreInfo.selfRoute;
	 		pTechEmScore.SelfProfession = pTechEmScoreInfo.selfProfession;
	 		pTechEmScore.SelfAttitude = pTechEmScoreInfo.selfAttitude;
	 		pTechEmScore.SelfComplex = pTechEmScoreInfo.selfComplex;
	 		pTechEmScore.SelfSpeciality = pTechEmScoreInfo.selfSpeciality;
	 		pTechEmScore.UpPlan = pTechEmScoreInfo.upPlan;
	 		pTechEmScore.UpWorkTotal = pTechEmScoreInfo.upWorkTotal;
	 		pTechEmScore.UpWorkSpeed = pTechEmScoreInfo.upWorkSpeed;
	 		pTechEmScore.UpCommunicate = pTechEmScoreInfo.upCommunicate;
	 		pTechEmScore.UpDescipline = pTechEmScoreInfo.upDescipline;
	 		pTechEmScore.UpExecute = pTechEmScoreInfo.upExecute;
	 		pTechEmScore.UpRoute = pTechEmScoreInfo.upRoute;
	 		pTechEmScore.UpProfession = pTechEmScoreInfo.upProfession;
	 		pTechEmScore.UpAttitude = pTechEmScoreInfo.upAttitude;
	 		pTechEmScore.UpComplex = pTechEmScoreInfo.upComplex;
	 		pTechEmScore.UpSpeciality = pTechEmScoreInfo.upSpeciality;
	 		pTechEmScore.SectPlan = pTechEmScoreInfo.sectPlan;
	 		pTechEmScore.SectWorkTotal = pTechEmScoreInfo.sectWorkTotal;
	 		pTechEmScore.SectWorkSpeed = pTechEmScoreInfo.sectWorkSpeed;
	 		pTechEmScore.SectCommunicate = pTechEmScoreInfo.sectCommunicate;
	 		pTechEmScore.SectDescipline = pTechEmScoreInfo.sectDescipline;
	 		pTechEmScore.SectExecute = pTechEmScoreInfo.sectExecute;
	 		pTechEmScore.SectRoute = pTechEmScoreInfo.sectRoute;
	 		pTechEmScore.SectProfession = pTechEmScoreInfo.sectProfession;
	 		pTechEmScore.SectAttitude = pTechEmScoreInfo.sectAttitude;
	 		pTechEmScore.SectComplex = pTechEmScoreInfo.sectComplex;
	 		pTechEmScore.SectSpeciality = pTechEmScoreInfo.sectSpeciality;
	 		pTechEmScore.PlanFinish = pTechEmScoreInfo.planFinish;
	 		pTechEmScore.ActualFinish = pTechEmScoreInfo.actualFinish;
	 		pTechEmScore.FinishRate = pTechEmScoreInfo.finishRate;
	 		pTechEmScore.FinishScore = pTechEmScoreInfo.finishScore;
	 		pTechEmScore.Reason = pTechEmScoreInfo.reason;
	 		pTechEmScore.AddMinusSocre = pTechEmScoreInfo.addMinusSocre;
	 		pTechEmScore.TotalScore = pTechEmScoreInfo.totalScore;
	 		pTechEmScore.UpViews = pTechEmScoreInfo.upViews;
	 		pTechEmScore.EmployeeId = pTechEmScoreInfo.employeeId;
	 		pTechEmScore.IsSubmit = pTechEmScoreInfo.isSubmit;
	 		pTechEmScore.DateSpan = pTechEmScoreInfo.dateSpan;
	 		pTechEmScore.YearId = pTechEmScoreInfo.yearId;
	 		pTechEmScore.MonthId = pTechEmScoreInfo.monthId;
	 		pTechEmScore.EvaluateLevelId = pTechEmScoreInfo.evaluateLevelId;
			pTechEmScore.IsNew=pIsNew;
			string UserName = SubsonicHelper.GetUserName();
			try
			{
				pTechEmScore.Save(UserName);
			}
			catch(Exception ex)
			{
				LogManager.getInstance().getLogger(typeof(TechEmScoreInfo)).Error(ex);
				if(ex.Message.Contains("插入重复键"))//违反了唯一键
				{
					throw new AppException("此对象已经存在");//此处等待优化可以从唯一约束中直接取出提示来，如果没有的话，默认为原始的出错提示
				}
				throw new AppException("保存失败");
			}
			pTechEmScoreInfo.techEmScoreId = pTechEmScore.TechEmScoreId;
			//如果缓存存在，更新缓存
			if (CachedEntityCommander.IsTypeRegistered(typeof(TechEmScoreInfo))) 
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
        public static List< TechEmScoreInfo> GetPagedList(int pPageIndex,int pPageSize,SortDirection pOrderBy,string pSortExpression,out int pRecordCount)
        {
			if(pPageIndex<=1)
			pPageIndex=1;
            List< TechEmScoreInfo> list = new List< TechEmScoreInfo>();
          
            Query q = TechEmScore .CreateQuery();
            q.PageIndex = pPageIndex;
            q.PageSize = pPageSize;
            q.ORDER_BY(pSortExpression,pOrderBy.ToString());
			TechEmScoreCollection  collection=new  TechEmScoreCollection();
		 	collection.LoadAndCloseReader(q.ExecuteReader());
          
            foreach (TechEmScore  techEmScore  in collection)
            {
                TechEmScoreInfo techEmScoreInfo = new TechEmScoreInfo();
                LoadFromDAL(techEmScoreInfo,   techEmScore);
                list.Add(techEmScoreInfo);
            }
			pRecordCount=q.GetRecordCount();
			
            return list;

        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		/// <returns></returns>
		public static List< TechEmScoreInfo> GetList()
		{
			string cacheKey = GetCacheKey();
			//本实体已经注册成缓存实体，并且缓存存在的时候，直接从缓存取
			if (CachedEntityCommander.IsTypeRegistered(typeof(TechEmScoreInfo)) && CachedEntityCommander.GetCache(cacheKey) != null)
            {
                return CachedEntityCommander.GetCache(cacheKey) as List< TechEmScoreInfo>;
            }
            else 
            {
				List< TechEmScoreInfo>  list =new List< TechEmScoreInfo>();
				TechEmScoreCollection  collection=new  TechEmScoreCollection();
				Query qry = new Query(TechEmScore.Schema);
				collection.LoadAndCloseReader(qry.ExecuteReader());
				foreach(TechEmScore techEmScore in collection)
				{
					TechEmScoreInfo techEmScoreInfo= new TechEmScoreInfo();
					LoadFromDAL(techEmScoreInfo,techEmScore);
					list.Add(techEmScoreInfo);
				}
			  	//生成缓存
                if (CachedEntityCommander.IsTypeRegistered(typeof(TechEmScoreInfo))) 
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
		public int TechEmScoreId
		{
			get {return techEmScoreId;}
			set {techEmScoreId = value;}
		}

		///<summary>
		///
		///</summary>
		public string SelfPlan
		{
			get {return selfPlan;}
			set {selfPlan = value;}
		}

		///<summary>
		///
		///</summary>
		public string SelfWorkTotal
		{
			get {return selfWorkTotal;}
			set {selfWorkTotal = value;}
		}

		///<summary>
		///
		///</summary>
		public string SelfWorkSpeed
		{
			get {return selfWorkSpeed;}
			set {selfWorkSpeed = value;}
		}

		///<summary>
		///
		///</summary>
		public string SelfCommunicate
		{
			get {return selfCommunicate;}
			set {selfCommunicate = value;}
		}

		///<summary>
		///
		///</summary>
		public string SelfDescipline
		{
			get {return selfDescipline;}
			set {selfDescipline = value;}
		}

		///<summary>
		///
		///</summary>
		public string SelfExecute
		{
			get {return selfExecute;}
			set {selfExecute = value;}
		}

		///<summary>
		///
		///</summary>
		public string SelfRoute
		{
			get {return selfRoute;}
			set {selfRoute = value;}
		}

		///<summary>
		///
		///</summary>
		public string SelfProfession
		{
			get {return selfProfession;}
			set {selfProfession = value;}
		}

		///<summary>
		///
		///</summary>
		public string SelfAttitude
		{
			get {return selfAttitude;}
			set {selfAttitude = value;}
		}

		///<summary>
		///
		///</summary>
		public string SelfComplex
		{
			get {return selfComplex;}
			set {selfComplex = value;}
		}

		///<summary>
		///
		///</summary>
		public string SelfSpeciality
		{
			get {return selfSpeciality;}
			set {selfSpeciality = value;}
		}

		///<summary>
		///
		///</summary>
		public string UpPlan
		{
			get {return upPlan;}
			set {upPlan = value;}
		}

		///<summary>
		///
		///</summary>
		public string UpWorkTotal
		{
			get {return upWorkTotal;}
			set {upWorkTotal = value;}
		}

		///<summary>
		///
		///</summary>
		public string UpWorkSpeed
		{
			get {return upWorkSpeed;}
			set {upWorkSpeed = value;}
		}

		///<summary>
		///
		///</summary>
		public string UpCommunicate
		{
			get {return upCommunicate;}
			set {upCommunicate = value;}
		}

		///<summary>
		///
		///</summary>
		public string UpDescipline
		{
			get {return upDescipline;}
			set {upDescipline = value;}
		}

		///<summary>
		///
		///</summary>
		public string UpExecute
		{
			get {return upExecute;}
			set {upExecute = value;}
		}

		///<summary>
		///
		///</summary>
		public string UpRoute
		{
			get {return upRoute;}
			set {upRoute = value;}
		}

		///<summary>
		///
		///</summary>
		public string UpProfession
		{
			get {return upProfession;}
			set {upProfession = value;}
		}

		///<summary>
		///
		///</summary>
		public string UpAttitude
		{
			get {return upAttitude;}
			set {upAttitude = value;}
		}

		///<summary>
		///
		///</summary>
		public string UpComplex
		{
			get {return upComplex;}
			set {upComplex = value;}
		}

		///<summary>
		///
		///</summary>
		public string UpSpeciality
		{
			get {return upSpeciality;}
			set {upSpeciality = value;}
		}

		///<summary>
		///
		///</summary>
		public string SectPlan
		{
			get {return sectPlan;}
			set {sectPlan = value;}
		}

		///<summary>
		///
		///</summary>
		public string SectWorkTotal
		{
			get {return sectWorkTotal;}
			set {sectWorkTotal = value;}
		}

		///<summary>
		///
		///</summary>
		public string SectWorkSpeed
		{
			get {return sectWorkSpeed;}
			set {sectWorkSpeed = value;}
		}

		///<summary>
		///
		///</summary>
		public string SectCommunicate
		{
			get {return sectCommunicate;}
			set {sectCommunicate = value;}
		}

		///<summary>
		///
		///</summary>
		public string SectDescipline
		{
			get {return sectDescipline;}
			set {sectDescipline = value;}
		}

		///<summary>
		///
		///</summary>
		public string SectExecute
		{
			get {return sectExecute;}
			set {sectExecute = value;}
		}

		///<summary>
		///
		///</summary>
		public string SectRoute
		{
			get {return sectRoute;}
			set {sectRoute = value;}
		}

		///<summary>
		///
		///</summary>
		public string SectProfession
		{
			get {return sectProfession;}
			set {sectProfession = value;}
		}

		///<summary>
		///
		///</summary>
		public string SectAttitude
		{
			get {return sectAttitude;}
			set {sectAttitude = value;}
		}

		///<summary>
		///
		///</summary>
		public string SectComplex
		{
			get {return sectComplex;}
			set {sectComplex = value;}
		}

		///<summary>
		///
		///</summary>
		public string SectSpeciality
		{
			get {return sectSpeciality;}
			set {sectSpeciality = value;}
		}

		///<summary>
		///
		///</summary>
		public string PlanFinish
		{
			get {return planFinish;}
			set {planFinish = value;}
		}

		///<summary>
		///
		///</summary>
		public string ActualFinish
		{
			get {return actualFinish;}
			set {actualFinish = value;}
		}

		///<summary>
		///
		///</summary>
		public string FinishRate
		{
			get {return finishRate;}
			set {finishRate = value;}
		}

		///<summary>
		///
		///</summary>
		public string FinishScore
		{
			get {return finishScore;}
			set {finishScore = value;}
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
		public string AddMinusSocre
		{
			get {return addMinusSocre;}
			set {addMinusSocre = value;}
		}

		///<summary>
		///
		///</summary>
		public string TotalScore
		{
			get {return totalScore;}
			set {totalScore = value;}
		}

		///<summary>
		///
		///</summary>
		public string UpViews
		{
			get {return upViews;}
			set {upViews = value;}
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
		public int? IsSubmit
		{
			get {return isSubmit;}
			set {isSubmit = value;}
		}

		///<summary>
		///
		///</summary>
		public string DateSpan
		{
			get {return dateSpan;}
			set {dateSpan = value;}
		}

		///<summary>
		///
		///</summary>
		public int? YearId
		{
			get {return yearId;}
			set {yearId = value;}
		}

		///<summary>
		///
		///</summary>
		public int? MonthId
		{
			get {return monthId;}
			set {monthId = value;}
		}

		///<summary>
		///
		///</summary>
		public int? EvaluateLevelId
		{
			get {return evaluateLevelId;}
			set {evaluateLevelId = value;}
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
			bool result=  (TechEmScore.Delete(TechEmScoreId) == 1);
			//更新缓存
			if (result&&CachedEntityCommander.IsTypeRegistered(typeof(TechEmScoreInfo))) 
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
        public void CopyTo(TechEmScoreInfo pTechEmScoreInfoTo)
        {
            Copy(this,  pTechEmScoreInfoTo);
        }
		
		
		
		
		
		/// <summary>
		/// 保存
		/// </summary>
		public override void Save()
		{
			if(!m_Loaded)//新增
			{
				TechEmScore techEmScore=new TechEmScore();	
				SaveToDb(this, techEmScore,true);
			}
			else//修改
			{
				TechEmScore techEmScore=new TechEmScore(techEmScoreId);	
				if(techEmScore.IsNew)
					throw new AppException("该数据已经不存在了");
				SaveToDb(this, techEmScore,false);
			}
			
		}
		 
		#endregion
		
	}
}
