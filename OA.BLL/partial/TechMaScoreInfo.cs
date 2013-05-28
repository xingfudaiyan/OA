// ======================================================================================================================================
// 类说明
//=======================================================================================================================================
// 创建者：sk @Copy Right 残友软件有限公司OA项目 
// 文件名：TechMaScoreInfo.cs
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
	///TechMaScoreInfo  Data
	/// </summary>
	[Serializable]
	public partial class TechMaScoreInfo:CanYou.EntityObject
	{
		#region 属性
		///<summary>
		///
		///</summary>
		private int techMaScoreId;
		///<summary>
		///
		///</summary>
		private string reason = String.Empty;
		///<summary>
		///
		///</summary>
		private string addMinusScore = String.Empty;
		///<summary>
		///
		///</summary>
		private string totalScore = String.Empty;
		///<summary>
		///
		///</summary>
		private string upView = String.Empty;
		///<summary>
		///
		///</summary>
		private int? evaluateLevelId;
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
		private string dateSpan = String.Empty;
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
		private string selfScore1 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfScore2 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfScore3 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfScore4 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfScore5 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfScore6 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfScore7 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfScore8 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfScore9 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfScore10 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfScore11 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfScore12 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfScore13 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upScore1 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upScore2 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upScore3 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upScore4 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upScore5 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upScore6 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upScore7 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upScore8 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upScore9 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upScore10 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upScore11 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upScore12 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upScore13 = String.Empty;
		///<summary>
		///
		///</summary>
		private string sectScore1 = String.Empty;
		///<summary>
		///
		///</summary>
		private string sectScore2 = String.Empty;
		///<summary>
		///
		///</summary>
		private string sectScore3 = String.Empty;
		///<summary>
		///
		///</summary>
		private string sectScore4 = String.Empty;
		///<summary>
		///
		///</summary>
		private string sectScore5 = String.Empty;
		///<summary>
		///
		///</summary>
		private string sectScore6 = String.Empty;
		///<summary>
		///
		///</summary>
		private string sectScore7 = String.Empty;
		///<summary>
		///
		///</summary>
		private string sectScore8 = String.Empty;
		///<summary>
		///
		///</summary>
		private string sectScore9 = String.Empty;
		///<summary>
		///
		///</summary>
		private string sectScore10 = String.Empty;
		///<summary>
		///
		///</summary>
		private string sectScore11 = String.Empty;
		///<summary>
		///
		///</summary>
		private string sectScore12 = String.Empty;
		///<summary>
		///
		///</summary>
		private string sectScore13 = String.Empty;
		
		
		///一对多关系,如果
		private bool m_Loaded=false;
		#endregion
		
		#region 属性枚举
		public struct Fields
		{
			public const string TechMaScoreId=@"TechMaScoreId";
			public const string Reason=@"Reason";
			public const string AddMinusScore=@"AddMinusScore";
			public const string TotalScore=@"TotalScore";
			public const string UpView=@"UpView";
			public const string EvaluateLevelId=@"EvaluateLevelId";
			public const string YearId=@"YearId";
			public const string MonthId=@"MonthId";
			public const string DateSpan=@"DateSpan";
			public const string EmployeeId=@"EmployeeId";
			public const string IsSubmit=@"IsSubmit";
			public const string SelfScore1=@"SelfScore1";
			public const string SelfScore2=@"SelfScore2";
			public const string SelfScore3=@"SelfScore3";
			public const string SelfScore4=@"SelfScore4";
			public const string SelfScore5=@"SelfScore5";
			public const string SelfScore6=@"SelfScore6";
			public const string SelfScore7=@"SelfScore7";
			public const string SelfScore8=@"SelfScore8";
			public const string SelfScore9=@"SelfScore9";
			public const string SelfScore10=@"SelfScore10";
			public const string SelfScore11=@"SelfScore11";
			public const string SelfScore12=@"SelfScore12";
			public const string SelfScore13=@"SelfScore13";
			public const string UpScore1=@"UpScore1";
			public const string UpScore2=@"UpScore2";
			public const string UpScore3=@"UpScore3";
			public const string UpScore4=@"UpScore4";
			public const string UpScore5=@"UpScore5";
			public const string UpScore6=@"UpScore6";
			public const string UpScore7=@"UpScore7";
			public const string UpScore8=@"UpScore8";
			public const string UpScore9=@"UpScore9";
			public const string UpScore10=@"UpScore10";
			public const string UpScore11=@"UpScore11";
			public const string UpScore12=@"UpScore12";
			public const string UpScore13=@"UpScore13";
			public const string SectScore1=@"SectScore1";
			public const string SectScore2=@"SectScore2";
			public const string SectScore3=@"SectScore3";
			public const string SectScore4=@"SectScore4";
			public const string SectScore5=@"SectScore5";
			public const string SectScore6=@"SectScore6";
			public const string SectScore7=@"SectScore7";
			public const string SectScore8=@"SectScore8";
			public const string SectScore9=@"SectScore9";
			public const string SectScore10=@"SectScore10";
			public const string SectScore11=@"SectScore11";
			public const string SectScore12=@"SectScore12";
			public const string SectScore13=@"SectScore13";
						
		}

		#endregion
		
		
		#region 构造函数
		///<summary>
		///
		///</summary>
		public TechMaScoreInfo()
		{
		}
		///<summary>
		///
		///</summary>
		public TechMaScoreInfo(int pTechMaScoreId,string pReason,string pAddMinusScore,string pTotalScore,string pUpView,int? pEvaluateLevelId,int? pYearId,int? pMonthId,string pDateSpan,int? pEmployeeId,int? pIsSubmit,string pSelfScore1,string pSelfScore2,string pSelfScore3,string pSelfScore4,string pSelfScore5,string pSelfScore6,string pSelfScore7,string pSelfScore8,string pSelfScore9,string pSelfScore10,string pSelfScore11,string pSelfScore12,string pSelfScore13,string pUpScore1,string pUpScore2,string pUpScore3,string pUpScore4,string pUpScore5,string pUpScore6,string pUpScore7,string pUpScore8,string pUpScore9,string pUpScore10,string pUpScore11,string pUpScore12,string pUpScore13,string pSectScore1,string pSectScore2,string pSectScore3,string pSectScore4,string pSectScore5,string pSectScore6,string pSectScore7,string pSectScore8,string pSectScore9,string pSectScore10,string pSectScore11,string pSectScore12,string pSectScore13)
		{
			techMaScoreId   = pTechMaScoreId;
			reason          = pReason;
			addMinusScore   = pAddMinusScore;
			totalScore      = pTotalScore;
			upView          = pUpView;
			evaluateLevelId = pEvaluateLevelId;
			yearId          = pYearId;
			monthId         = pMonthId;
			dateSpan        = pDateSpan;
			employeeId      = pEmployeeId;
			isSubmit        = pIsSubmit;
			selfScore1      = pSelfScore1;
			selfScore2      = pSelfScore2;
			selfScore3      = pSelfScore3;
			selfScore4      = pSelfScore4;
			selfScore5      = pSelfScore5;
			selfScore6      = pSelfScore6;
			selfScore7      = pSelfScore7;
			selfScore8      = pSelfScore8;
			selfScore9      = pSelfScore9;
			selfScore10     = pSelfScore10;
			selfScore11     = pSelfScore11;
			selfScore12     = pSelfScore12;
			selfScore13     = pSelfScore13;
			upScore1        = pUpScore1;
			upScore2        = pUpScore2;
			upScore3        = pUpScore3;
			upScore4        = pUpScore4;
			upScore5        = pUpScore5;
			upScore6        = pUpScore6;
			upScore7        = pUpScore7;
			upScore8        = pUpScore8;
			upScore9        = pUpScore9;
			upScore10       = pUpScore10;
			upScore11       = pUpScore11;
			upScore12       = pUpScore12;
			upScore13       = pUpScore13;
			sectScore1      = pSectScore1;
			sectScore2      = pSectScore2;
			sectScore3      = pSectScore3;
			sectScore4      = pSectScore4;
			sectScore5      = pSectScore5;
			sectScore6      = pSectScore6;
			sectScore7      = pSectScore7;
			sectScore8      = pSectScore8;
			sectScore9      = pSectScore9;
			sectScore10     = pSectScore10;
			sectScore11     = pSectScore11;
			sectScore12     = pSectScore12;
			sectScore13     = pSectScore13;
			
		}
		
		
		///<summary>
		///
		///</summary>
		public TechMaScoreInfo(int techMaScoreId)
		{
			 LoadFromId(techMaScoreId);
		}
		
		private void LoadFromId(int techMaScoreId)
		{
		 
			if (CachedEntityCommander.IsTypeRegistered(typeof(TechMaScoreInfo)))
            {
				TechMaScoreInfo techMaScoreInfo=Find(GetList(), techMaScoreId);
				if(techMaScoreInfo==null)
					throw new AppException("未能在缓存中找到相应的键值对象");
                Copy(techMaScoreInfo, this);
            }
            else
            {	TechMaScore techMaScore=new TechMaScore( techMaScoreId);	
				if(techMaScore.IsNew)
				throw new AppException("尚未初始化");
               	LoadFromDAL(this, techMaScore);
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
        public static  TechMaScoreInfo Find(List< TechMaScoreInfo> list,  int techMaScoreId)
        {
             return list.Find(delegate( TechMaScoreInfo item) { return item. techMaScoreId==techMaScoreId; });
        }
		
		
		/// <summary>
        /// 得到缓存键
        /// </summary>
        /// <returns></returns>
        private static string GetCacheKey()
        {
            return string.Format(CachedEntityCommander.CacheKey, typeof( TechMaScoreInfo).ToString());
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
        public static void Copy(TechMaScoreInfo pTechMaScoreInfoFrom, TechMaScoreInfo pTechMaScoreInfoTo)
        {
	 		pTechMaScoreInfoTo.TechMaScoreId = pTechMaScoreInfoFrom.techMaScoreId;
	 		pTechMaScoreInfoTo.Reason = pTechMaScoreInfoFrom.reason;
	 		pTechMaScoreInfoTo.AddMinusScore = pTechMaScoreInfoFrom.addMinusScore;
	 		pTechMaScoreInfoTo.TotalScore = pTechMaScoreInfoFrom.totalScore;
	 		pTechMaScoreInfoTo.UpView = pTechMaScoreInfoFrom.upView;
	 		pTechMaScoreInfoTo.EvaluateLevelId = pTechMaScoreInfoFrom.evaluateLevelId;
	 		pTechMaScoreInfoTo.YearId = pTechMaScoreInfoFrom.yearId;
	 		pTechMaScoreInfoTo.MonthId = pTechMaScoreInfoFrom.monthId;
	 		pTechMaScoreInfoTo.DateSpan = pTechMaScoreInfoFrom.dateSpan;
	 		pTechMaScoreInfoTo.EmployeeId = pTechMaScoreInfoFrom.employeeId;
	 		pTechMaScoreInfoTo.IsSubmit = pTechMaScoreInfoFrom.isSubmit;
	 		pTechMaScoreInfoTo.SelfScore1 = pTechMaScoreInfoFrom.selfScore1;
	 		pTechMaScoreInfoTo.SelfScore2 = pTechMaScoreInfoFrom.selfScore2;
	 		pTechMaScoreInfoTo.SelfScore3 = pTechMaScoreInfoFrom.selfScore3;
	 		pTechMaScoreInfoTo.SelfScore4 = pTechMaScoreInfoFrom.selfScore4;
	 		pTechMaScoreInfoTo.SelfScore5 = pTechMaScoreInfoFrom.selfScore5;
	 		pTechMaScoreInfoTo.SelfScore6 = pTechMaScoreInfoFrom.selfScore6;
	 		pTechMaScoreInfoTo.SelfScore7 = pTechMaScoreInfoFrom.selfScore7;
	 		pTechMaScoreInfoTo.SelfScore8 = pTechMaScoreInfoFrom.selfScore8;
	 		pTechMaScoreInfoTo.SelfScore9 = pTechMaScoreInfoFrom.selfScore9;
	 		pTechMaScoreInfoTo.SelfScore10 = pTechMaScoreInfoFrom.selfScore10;
	 		pTechMaScoreInfoTo.SelfScore11 = pTechMaScoreInfoFrom.selfScore11;
	 		pTechMaScoreInfoTo.SelfScore12 = pTechMaScoreInfoFrom.selfScore12;
	 		pTechMaScoreInfoTo.SelfScore13 = pTechMaScoreInfoFrom.selfScore13;
	 		pTechMaScoreInfoTo.UpScore1 = pTechMaScoreInfoFrom.upScore1;
	 		pTechMaScoreInfoTo.UpScore2 = pTechMaScoreInfoFrom.upScore2;
	 		pTechMaScoreInfoTo.UpScore3 = pTechMaScoreInfoFrom.upScore3;
	 		pTechMaScoreInfoTo.UpScore4 = pTechMaScoreInfoFrom.upScore4;
	 		pTechMaScoreInfoTo.UpScore5 = pTechMaScoreInfoFrom.upScore5;
	 		pTechMaScoreInfoTo.UpScore6 = pTechMaScoreInfoFrom.upScore6;
	 		pTechMaScoreInfoTo.UpScore7 = pTechMaScoreInfoFrom.upScore7;
	 		pTechMaScoreInfoTo.UpScore8 = pTechMaScoreInfoFrom.upScore8;
	 		pTechMaScoreInfoTo.UpScore9 = pTechMaScoreInfoFrom.upScore9;
	 		pTechMaScoreInfoTo.UpScore10 = pTechMaScoreInfoFrom.upScore10;
	 		pTechMaScoreInfoTo.UpScore11 = pTechMaScoreInfoFrom.upScore11;
	 		pTechMaScoreInfoTo.UpScore12 = pTechMaScoreInfoFrom.upScore12;
	 		pTechMaScoreInfoTo.UpScore13 = pTechMaScoreInfoFrom.upScore13;
	 		pTechMaScoreInfoTo.SectScore1 = pTechMaScoreInfoFrom.sectScore1;
	 		pTechMaScoreInfoTo.SectScore2 = pTechMaScoreInfoFrom.sectScore2;
	 		pTechMaScoreInfoTo.SectScore3 = pTechMaScoreInfoFrom.sectScore3;
	 		pTechMaScoreInfoTo.SectScore4 = pTechMaScoreInfoFrom.sectScore4;
	 		pTechMaScoreInfoTo.SectScore5 = pTechMaScoreInfoFrom.sectScore5;
	 		pTechMaScoreInfoTo.SectScore6 = pTechMaScoreInfoFrom.sectScore6;
	 		pTechMaScoreInfoTo.SectScore7 = pTechMaScoreInfoFrom.sectScore7;
	 		pTechMaScoreInfoTo.SectScore8 = pTechMaScoreInfoFrom.sectScore8;
	 		pTechMaScoreInfoTo.SectScore9 = pTechMaScoreInfoFrom.sectScore9;
	 		pTechMaScoreInfoTo.SectScore10 = pTechMaScoreInfoFrom.sectScore10;
	 		pTechMaScoreInfoTo.SectScore11 = pTechMaScoreInfoFrom.sectScore11;
	 		pTechMaScoreInfoTo.SectScore12 = pTechMaScoreInfoFrom.sectScore12;
	 		pTechMaScoreInfoTo.SectScore13 = pTechMaScoreInfoFrom.sectScore13;
			pTechMaScoreInfoTo.Loaded=pTechMaScoreInfoFrom.Loaded;
        }
		
		/// <summary>
		/// 批量装载
		/// </summary>
		internal static void LoadFromDALPatch(List< TechMaScoreInfo> pList, TechMaScoreCollection pCollection)
        {
            foreach (TechMaScore techMaScore in pCollection)
            {
                TechMaScoreInfo techMaScoreInfo = new TechMaScoreInfo();
                LoadFromDAL(techMaScoreInfo, techMaScore );
                pList.Add(techMaScoreInfo);
            }
			
        }

		//从后台获取数据
		internal  static void  LoadFromDAL(TechMaScoreInfo pTechMaScoreInfo, TechMaScore  pTechMaScore)
		{
	 		pTechMaScoreInfo.techMaScoreId = pTechMaScore.TechMaScoreId;
	 		pTechMaScoreInfo.reason = pTechMaScore.Reason;
	 		pTechMaScoreInfo.addMinusScore = pTechMaScore.AddMinusScore;
	 		pTechMaScoreInfo.totalScore = pTechMaScore.TotalScore;
	 		pTechMaScoreInfo.upView = pTechMaScore.UpView;
	 		pTechMaScoreInfo.evaluateLevelId = pTechMaScore.EvaluateLevelId;
	 		pTechMaScoreInfo.yearId = pTechMaScore.YearId;
	 		pTechMaScoreInfo.monthId = pTechMaScore.MonthId;
	 		pTechMaScoreInfo.dateSpan = pTechMaScore.DateSpan;
	 		pTechMaScoreInfo.employeeId = pTechMaScore.EmployeeId;
	 		pTechMaScoreInfo.isSubmit = pTechMaScore.IsSubmit;
	 		pTechMaScoreInfo.selfScore1 = pTechMaScore.SelfScore1;
	 		pTechMaScoreInfo.selfScore2 = pTechMaScore.SelfScore2;
	 		pTechMaScoreInfo.selfScore3 = pTechMaScore.SelfScore3;
	 		pTechMaScoreInfo.selfScore4 = pTechMaScore.SelfScore4;
	 		pTechMaScoreInfo.selfScore5 = pTechMaScore.SelfScore5;
	 		pTechMaScoreInfo.selfScore6 = pTechMaScore.SelfScore6;
	 		pTechMaScoreInfo.selfScore7 = pTechMaScore.SelfScore7;
	 		pTechMaScoreInfo.selfScore8 = pTechMaScore.SelfScore8;
	 		pTechMaScoreInfo.selfScore9 = pTechMaScore.SelfScore9;
	 		pTechMaScoreInfo.selfScore10 = pTechMaScore.SelfScore10;
	 		pTechMaScoreInfo.selfScore11 = pTechMaScore.SelfScore11;
	 		pTechMaScoreInfo.selfScore12 = pTechMaScore.SelfScore12;
	 		pTechMaScoreInfo.selfScore13 = pTechMaScore.SelfScore13;
	 		pTechMaScoreInfo.upScore1 = pTechMaScore.UpScore1;
	 		pTechMaScoreInfo.upScore2 = pTechMaScore.UpScore2;
	 		pTechMaScoreInfo.upScore3 = pTechMaScore.UpScore3;
	 		pTechMaScoreInfo.upScore4 = pTechMaScore.UpScore4;
	 		pTechMaScoreInfo.upScore5 = pTechMaScore.UpScore5;
	 		pTechMaScoreInfo.upScore6 = pTechMaScore.UpScore6;
	 		pTechMaScoreInfo.upScore7 = pTechMaScore.UpScore7;
	 		pTechMaScoreInfo.upScore8 = pTechMaScore.UpScore8;
	 		pTechMaScoreInfo.upScore9 = pTechMaScore.UpScore9;
	 		pTechMaScoreInfo.upScore10 = pTechMaScore.UpScore10;
	 		pTechMaScoreInfo.upScore11 = pTechMaScore.UpScore11;
	 		pTechMaScoreInfo.upScore12 = pTechMaScore.UpScore12;
	 		pTechMaScoreInfo.upScore13 = pTechMaScore.UpScore13;
	 		pTechMaScoreInfo.sectScore1 = pTechMaScore.SectScore1;
	 		pTechMaScoreInfo.sectScore2 = pTechMaScore.SectScore2;
	 		pTechMaScoreInfo.sectScore3 = pTechMaScore.SectScore3;
	 		pTechMaScoreInfo.sectScore4 = pTechMaScore.SectScore4;
	 		pTechMaScoreInfo.sectScore5 = pTechMaScore.SectScore5;
	 		pTechMaScoreInfo.sectScore6 = pTechMaScore.SectScore6;
	 		pTechMaScoreInfo.sectScore7 = pTechMaScore.SectScore7;
	 		pTechMaScoreInfo.sectScore8 = pTechMaScore.SectScore8;
	 		pTechMaScoreInfo.sectScore9 = pTechMaScore.SectScore9;
	 		pTechMaScoreInfo.sectScore10 = pTechMaScore.SectScore10;
	 		pTechMaScoreInfo.sectScore11 = pTechMaScore.SectScore11;
	 		pTechMaScoreInfo.sectScore12 = pTechMaScore.SectScore12;
	 		pTechMaScoreInfo.sectScore13 = pTechMaScore.SectScore13;
			pTechMaScoreInfo.Loaded=true;
			
			}
		
		//数据持久化
		internal  static void  SaveToDb(TechMaScoreInfo pTechMaScoreInfo, TechMaScore  pTechMaScore,bool pIsNew)
		{
	 		pTechMaScore.TechMaScoreId = pTechMaScoreInfo.techMaScoreId;
	 		pTechMaScore.Reason = pTechMaScoreInfo.reason;
	 		pTechMaScore.AddMinusScore = pTechMaScoreInfo.addMinusScore;
	 		pTechMaScore.TotalScore = pTechMaScoreInfo.totalScore;
	 		pTechMaScore.UpView = pTechMaScoreInfo.upView;
	 		pTechMaScore.EvaluateLevelId = pTechMaScoreInfo.evaluateLevelId;
	 		pTechMaScore.YearId = pTechMaScoreInfo.yearId;
	 		pTechMaScore.MonthId = pTechMaScoreInfo.monthId;
	 		pTechMaScore.DateSpan = pTechMaScoreInfo.dateSpan;
	 		pTechMaScore.EmployeeId = pTechMaScoreInfo.employeeId;
	 		pTechMaScore.IsSubmit = pTechMaScoreInfo.isSubmit;
	 		pTechMaScore.SelfScore1 = pTechMaScoreInfo.selfScore1;
	 		pTechMaScore.SelfScore2 = pTechMaScoreInfo.selfScore2;
	 		pTechMaScore.SelfScore3 = pTechMaScoreInfo.selfScore3;
	 		pTechMaScore.SelfScore4 = pTechMaScoreInfo.selfScore4;
	 		pTechMaScore.SelfScore5 = pTechMaScoreInfo.selfScore5;
	 		pTechMaScore.SelfScore6 = pTechMaScoreInfo.selfScore6;
	 		pTechMaScore.SelfScore7 = pTechMaScoreInfo.selfScore7;
	 		pTechMaScore.SelfScore8 = pTechMaScoreInfo.selfScore8;
	 		pTechMaScore.SelfScore9 = pTechMaScoreInfo.selfScore9;
	 		pTechMaScore.SelfScore10 = pTechMaScoreInfo.selfScore10;
	 		pTechMaScore.SelfScore11 = pTechMaScoreInfo.selfScore11;
	 		pTechMaScore.SelfScore12 = pTechMaScoreInfo.selfScore12;
	 		pTechMaScore.SelfScore13 = pTechMaScoreInfo.selfScore13;
	 		pTechMaScore.UpScore1 = pTechMaScoreInfo.upScore1;
	 		pTechMaScore.UpScore2 = pTechMaScoreInfo.upScore2;
	 		pTechMaScore.UpScore3 = pTechMaScoreInfo.upScore3;
	 		pTechMaScore.UpScore4 = pTechMaScoreInfo.upScore4;
	 		pTechMaScore.UpScore5 = pTechMaScoreInfo.upScore5;
	 		pTechMaScore.UpScore6 = pTechMaScoreInfo.upScore6;
	 		pTechMaScore.UpScore7 = pTechMaScoreInfo.upScore7;
	 		pTechMaScore.UpScore8 = pTechMaScoreInfo.upScore8;
	 		pTechMaScore.UpScore9 = pTechMaScoreInfo.upScore9;
	 		pTechMaScore.UpScore10 = pTechMaScoreInfo.upScore10;
	 		pTechMaScore.UpScore11 = pTechMaScoreInfo.upScore11;
	 		pTechMaScore.UpScore12 = pTechMaScoreInfo.upScore12;
	 		pTechMaScore.UpScore13 = pTechMaScoreInfo.upScore13;
	 		pTechMaScore.SectScore1 = pTechMaScoreInfo.sectScore1;
	 		pTechMaScore.SectScore2 = pTechMaScoreInfo.sectScore2;
	 		pTechMaScore.SectScore3 = pTechMaScoreInfo.sectScore3;
	 		pTechMaScore.SectScore4 = pTechMaScoreInfo.sectScore4;
	 		pTechMaScore.SectScore5 = pTechMaScoreInfo.sectScore5;
	 		pTechMaScore.SectScore6 = pTechMaScoreInfo.sectScore6;
	 		pTechMaScore.SectScore7 = pTechMaScoreInfo.sectScore7;
	 		pTechMaScore.SectScore8 = pTechMaScoreInfo.sectScore8;
	 		pTechMaScore.SectScore9 = pTechMaScoreInfo.sectScore9;
	 		pTechMaScore.SectScore10 = pTechMaScoreInfo.sectScore10;
	 		pTechMaScore.SectScore11 = pTechMaScoreInfo.sectScore11;
	 		pTechMaScore.SectScore12 = pTechMaScoreInfo.sectScore12;
	 		pTechMaScore.SectScore13 = pTechMaScoreInfo.sectScore13;
			pTechMaScore.IsNew=pIsNew;
			string UserName = SubsonicHelper.GetUserName();
			try
			{
				pTechMaScore.Save(UserName);
			}
			catch(Exception ex)
			{
				LogManager.getInstance().getLogger(typeof(TechMaScoreInfo)).Error(ex);
				if(ex.Message.Contains("插入重复键"))//违反了唯一键
				{
					throw new AppException("此对象已经存在");//此处等待优化可以从唯一约束中直接取出提示来，如果没有的话，默认为原始的出错提示
				}
				throw new AppException("保存失败");
			}
			pTechMaScoreInfo.techMaScoreId = pTechMaScore.TechMaScoreId;
			//如果缓存存在，更新缓存
			if (CachedEntityCommander.IsTypeRegistered(typeof(TechMaScoreInfo))) 
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
        public static List< TechMaScoreInfo> GetPagedList(int pPageIndex,int pPageSize,SortDirection pOrderBy,string pSortExpression,out int pRecordCount)
        {
			if(pPageIndex<=1)
			pPageIndex=1;
            List< TechMaScoreInfo> list = new List< TechMaScoreInfo>();
          
            Query q = TechMaScore .CreateQuery();
            q.PageIndex = pPageIndex;
            q.PageSize = pPageSize;
            q.ORDER_BY(pSortExpression,pOrderBy.ToString());
			TechMaScoreCollection  collection=new  TechMaScoreCollection();
		 	collection.LoadAndCloseReader(q.ExecuteReader());
          
            foreach (TechMaScore  techMaScore  in collection)
            {
                TechMaScoreInfo techMaScoreInfo = new TechMaScoreInfo();
                LoadFromDAL(techMaScoreInfo,   techMaScore);
                list.Add(techMaScoreInfo);
            }
			pRecordCount=q.GetRecordCount();
			
            return list;

        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		/// <returns></returns>
		public static List< TechMaScoreInfo> GetList()
		{
			string cacheKey = GetCacheKey();
			//本实体已经注册成缓存实体，并且缓存存在的时候，直接从缓存取
			if (CachedEntityCommander.IsTypeRegistered(typeof(TechMaScoreInfo)) && CachedEntityCommander.GetCache(cacheKey) != null)
            {
                return CachedEntityCommander.GetCache(cacheKey) as List< TechMaScoreInfo>;
            }
            else 
            {
				List< TechMaScoreInfo>  list =new List< TechMaScoreInfo>();
				TechMaScoreCollection  collection=new  TechMaScoreCollection();
				Query qry = new Query(TechMaScore.Schema);
				collection.LoadAndCloseReader(qry.ExecuteReader());
				foreach(TechMaScore techMaScore in collection)
				{
					TechMaScoreInfo techMaScoreInfo= new TechMaScoreInfo();
					LoadFromDAL(techMaScoreInfo,techMaScore);
					list.Add(techMaScoreInfo);
				}
			  	//生成缓存
                if (CachedEntityCommander.IsTypeRegistered(typeof(TechMaScoreInfo))) 
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
		public int TechMaScoreId
		{
			get {return techMaScoreId;}
			set {techMaScoreId = value;}
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
		public string AddMinusScore
		{
			get {return addMinusScore;}
			set {addMinusScore = value;}
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
		public string UpView
		{
			get {return upView;}
			set {upView = value;}
		}

		///<summary>
		///
		///</summary>
		public int? EvaluateLevelId
		{
			get {return evaluateLevelId;}
			set {evaluateLevelId = value;}
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
		public string DateSpan
		{
			get {return dateSpan;}
			set {dateSpan = value;}
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
		public string SelfScore1
		{
			get {return selfScore1;}
			set {selfScore1 = value;}
		}

		///<summary>
		///
		///</summary>
		public string SelfScore2
		{
			get {return selfScore2;}
			set {selfScore2 = value;}
		}

		///<summary>
		///
		///</summary>
		public string SelfScore3
		{
			get {return selfScore3;}
			set {selfScore3 = value;}
		}

		///<summary>
		///
		///</summary>
		public string SelfScore4
		{
			get {return selfScore4;}
			set {selfScore4 = value;}
		}

		///<summary>
		///
		///</summary>
		public string SelfScore5
		{
			get {return selfScore5;}
			set {selfScore5 = value;}
		}

		///<summary>
		///
		///</summary>
		public string SelfScore6
		{
			get {return selfScore6;}
			set {selfScore6 = value;}
		}

		///<summary>
		///
		///</summary>
		public string SelfScore7
		{
			get {return selfScore7;}
			set {selfScore7 = value;}
		}

		///<summary>
		///
		///</summary>
		public string SelfScore8
		{
			get {return selfScore8;}
			set {selfScore8 = value;}
		}

		///<summary>
		///
		///</summary>
		public string SelfScore9
		{
			get {return selfScore9;}
			set {selfScore9 = value;}
		}

		///<summary>
		///
		///</summary>
		public string SelfScore10
		{
			get {return selfScore10;}
			set {selfScore10 = value;}
		}

		///<summary>
		///
		///</summary>
		public string SelfScore11
		{
			get {return selfScore11;}
			set {selfScore11 = value;}
		}

		///<summary>
		///
		///</summary>
		public string SelfScore12
		{
			get {return selfScore12;}
			set {selfScore12 = value;}
		}

		///<summary>
		///
		///</summary>
		public string SelfScore13
		{
			get {return selfScore13;}
			set {selfScore13 = value;}
		}

		///<summary>
		///
		///</summary>
		public string UpScore1
		{
			get {return upScore1;}
			set {upScore1 = value;}
		}

		///<summary>
		///
		///</summary>
		public string UpScore2
		{
			get {return upScore2;}
			set {upScore2 = value;}
		}

		///<summary>
		///
		///</summary>
		public string UpScore3
		{
			get {return upScore3;}
			set {upScore3 = value;}
		}

		///<summary>
		///
		///</summary>
		public string UpScore4
		{
			get {return upScore4;}
			set {upScore4 = value;}
		}

		///<summary>
		///
		///</summary>
		public string UpScore5
		{
			get {return upScore5;}
			set {upScore5 = value;}
		}

		///<summary>
		///
		///</summary>
		public string UpScore6
		{
			get {return upScore6;}
			set {upScore6 = value;}
		}

		///<summary>
		///
		///</summary>
		public string UpScore7
		{
			get {return upScore7;}
			set {upScore7 = value;}
		}

		///<summary>
		///
		///</summary>
		public string UpScore8
		{
			get {return upScore8;}
			set {upScore8 = value;}
		}

		///<summary>
		///
		///</summary>
		public string UpScore9
		{
			get {return upScore9;}
			set {upScore9 = value;}
		}

		///<summary>
		///
		///</summary>
		public string UpScore10
		{
			get {return upScore10;}
			set {upScore10 = value;}
		}

		///<summary>
		///
		///</summary>
		public string UpScore11
		{
			get {return upScore11;}
			set {upScore11 = value;}
		}

		///<summary>
		///
		///</summary>
		public string UpScore12
		{
			get {return upScore12;}
			set {upScore12 = value;}
		}

		///<summary>
		///
		///</summary>
		public string UpScore13
		{
			get {return upScore13;}
			set {upScore13 = value;}
		}

		///<summary>
		///
		///</summary>
		public string SectScore1
		{
			get {return sectScore1;}
			set {sectScore1 = value;}
		}

		///<summary>
		///
		///</summary>
		public string SectScore2
		{
			get {return sectScore2;}
			set {sectScore2 = value;}
		}

		///<summary>
		///
		///</summary>
		public string SectScore3
		{
			get {return sectScore3;}
			set {sectScore3 = value;}
		}

		///<summary>
		///
		///</summary>
		public string SectScore4
		{
			get {return sectScore4;}
			set {sectScore4 = value;}
		}

		///<summary>
		///
		///</summary>
		public string SectScore5
		{
			get {return sectScore5;}
			set {sectScore5 = value;}
		}

		///<summary>
		///
		///</summary>
		public string SectScore6
		{
			get {return sectScore6;}
			set {sectScore6 = value;}
		}

		///<summary>
		///
		///</summary>
		public string SectScore7
		{
			get {return sectScore7;}
			set {sectScore7 = value;}
		}

		///<summary>
		///
		///</summary>
		public string SectScore8
		{
			get {return sectScore8;}
			set {sectScore8 = value;}
		}

		///<summary>
		///
		///</summary>
		public string SectScore9
		{
			get {return sectScore9;}
			set {sectScore9 = value;}
		}

		///<summary>
		///
		///</summary>
		public string SectScore10
		{
			get {return sectScore10;}
			set {sectScore10 = value;}
		}

		///<summary>
		///
		///</summary>
		public string SectScore11
		{
			get {return sectScore11;}
			set {sectScore11 = value;}
		}

		///<summary>
		///
		///</summary>
		public string SectScore12
		{
			get {return sectScore12;}
			set {sectScore12 = value;}
		}

		///<summary>
		///
		///</summary>
		public string SectScore13
		{
			get {return sectScore13;}
			set {sectScore13 = value;}
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
			bool result=  (TechMaScore.Delete(TechMaScoreId) == 1);
			//更新缓存
			if (result&&CachedEntityCommander.IsTypeRegistered(typeof(TechMaScoreInfo))) 
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
        public void CopyTo(TechMaScoreInfo pTechMaScoreInfoTo)
        {
            Copy(this,  pTechMaScoreInfoTo);
        }
		
		
		
		
		
		/// <summary>
		/// 保存
		/// </summary>
		public override void Save()
		{
			if(!m_Loaded)//新增
			{
				TechMaScore techMaScore=new TechMaScore();	
				SaveToDb(this, techMaScore,true);
			}
			else//修改
			{
				TechMaScore techMaScore=new TechMaScore(techMaScoreId);	
				if(techMaScore.IsNew)
					throw new AppException("该数据已经不存在了");
				SaveToDb(this, techMaScore,false);
			}
			
		}
		 
		#endregion
		
	}
}
