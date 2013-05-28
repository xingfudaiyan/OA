// ======================================================================================================================================
// 类说明
//=======================================================================================================================================
// 创建者：sk @Copy Right 残友软件有限公司OA项目 
// 文件名：AssistantScoreInfo.cs
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
	///AssistantScoreInfo  Data
	/// </summary>
	[Serializable]
	public partial class AssistantScoreInfo:CanYou.EntityObject
	{
		#region 属性
		///<summary>
		///
		///</summary>
		private int assistantScoreId;
		///<summary>
		///
		///</summary>
		private string dateSpan = String.Empty;
		///<summary>
		///
		///</summary>
		private int? evaluateLevelId;
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
		private int? yearId;
		///<summary>
		///
		///</summary>
		private int? monthId;
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
		private string selfas1 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfas2 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfas3 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfas4 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfas5 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfas6 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfas7 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfas8 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfas9 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfas10 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfas11 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfas12 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfas13 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfas14 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfas15 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfas16 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfas17 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfas18 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfas19 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upas1 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upas2 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upas3 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upas4 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upas5 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upas6 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upas7 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upas8 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upas9 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upas10 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upas11 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upas12 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upas13 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upas14 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upas15 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upas16 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upas17 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upas18 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upas19 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secas1 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secas2 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secas3 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secas4 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secas5 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secas6 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secas7 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secas8 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secas9 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secas10 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secas11 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secas12 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secas13 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secas14 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secas15 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secas16 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secas17 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secas18 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secas19 = String.Empty;
		
		
		///一对多关系,如果
		private bool m_Loaded=false;
		#endregion
		
		#region 属性枚举
		public struct Fields
		{
			public const string AssistantScoreId=@"AssistantScoreId";
			public const string DateSpan=@"DateSpan";
			public const string EvaluateLevelId=@"EvaluateLevelId";
			public const string TotalScore=@"TotalScore";
			public const string UpViews=@"UpViews";
			public const string YearId=@"YearId";
			public const string MonthId=@"MonthId";
			public const string EmployeeId=@"EmployeeId";
			public const string IsSubmit=@"IsSubmit";
			public const string Selfas1=@"Selfas1";
			public const string Selfas2=@"Selfas2";
			public const string Selfas3=@"Selfas3";
			public const string Selfas4=@"Selfas4";
			public const string Selfas5=@"Selfas5";
			public const string Selfas6=@"Selfas6";
			public const string Selfas7=@"Selfas7";
			public const string Selfas8=@"Selfas8";
			public const string Selfas9=@"Selfas9";
			public const string Selfas10=@"Selfas10";
			public const string Selfas11=@"Selfas11";
			public const string Selfas12=@"Selfas12";
			public const string Selfas13=@"Selfas13";
			public const string Selfas14=@"Selfas14";
			public const string Selfas15=@"Selfas15";
			public const string Selfas16=@"Selfas16";
			public const string Selfas17=@"Selfas17";
			public const string Selfas18=@"Selfas18";
			public const string Selfas19=@"Selfas19";
			public const string Upas1=@"Upas1";
			public const string Upas2=@"Upas2";
			public const string Upas3=@"Upas3";
			public const string Upas4=@"Upas4";
			public const string Upas5=@"Upas5";
			public const string Upas6=@"Upas6";
			public const string Upas7=@"Upas7";
			public const string Upas8=@"Upas8";
			public const string Upas9=@"Upas9";
			public const string Upas10=@"Upas10";
			public const string Upas11=@"Upas11";
			public const string Upas12=@"Upas12";
			public const string Upas13=@"Upas13";
			public const string Upas14=@"Upas14";
			public const string Upas15=@"Upas15";
			public const string Upas16=@"Upas16";
			public const string Upas17=@"Upas17";
			public const string Upas18=@"Upas18";
			public const string Upas19=@"Upas19";
			public const string Secas1=@"Secas1";
			public const string Secas2=@"Secas2";
			public const string Secas3=@"Secas3";
			public const string Secas4=@"Secas4";
			public const string Secas5=@"Secas5";
			public const string Secas6=@"Secas6";
			public const string Secas7=@"Secas7";
			public const string Secas8=@"Secas8";
			public const string Secas9=@"Secas9";
			public const string Secas10=@"Secas10";
			public const string Secas11=@"Secas11";
			public const string Secas12=@"Secas12";
			public const string Secas13=@"Secas13";
			public const string Secas14=@"Secas14";
			public const string Secas15=@"Secas15";
			public const string Secas16=@"Secas16";
			public const string Secas17=@"Secas17";
			public const string Secas18=@"Secas18";
			public const string Secas19=@"Secas19";
						
		}

		#endregion
		
		
		#region 构造函数
		///<summary>
		///
		///</summary>
		public AssistantScoreInfo()
		{
		}
		///<summary>
		///
		///</summary>
		public AssistantScoreInfo(int pAssistantScoreId,string pDateSpan,int? pEvaluateLevelId,string pTotalScore,string pUpViews,int? pYearId,int? pMonthId,int? pEmployeeId,int? pIsSubmit,string pSelfas1,string pSelfas2,string pSelfas3,string pSelfas4,string pSelfas5,string pSelfas6,string pSelfas7,string pSelfas8,string pSelfas9,string pSelfas10,string pSelfas11,string pSelfas12,string pSelfas13,string pSelfas14,string pSelfas15,string pSelfas16,string pSelfas17,string pSelfas18,string pSelfas19,string pUpas1,string pUpas2,string pUpas3,string pUpas4,string pUpas5,string pUpas6,string pUpas7,string pUpas8,string pUpas9,string pUpas10,string pUpas11,string pUpas12,string pUpas13,string pUpas14,string pUpas15,string pUpas16,string pUpas17,string pUpas18,string pUpas19,string pSecas1,string pSecas2,string pSecas3,string pSecas4,string pSecas5,string pSecas6,string pSecas7,string pSecas8,string pSecas9,string pSecas10,string pSecas11,string pSecas12,string pSecas13,string pSecas14,string pSecas15,string pSecas16,string pSecas17,string pSecas18,string pSecas19)
		{
			assistantScoreId = pAssistantScoreId;
			dateSpan         = pDateSpan;
			evaluateLevelId  = pEvaluateLevelId;
			totalScore       = pTotalScore;
			upViews          = pUpViews;
			yearId           = pYearId;
			monthId          = pMonthId;
			employeeId       = pEmployeeId;
			isSubmit         = pIsSubmit;
			selfas1          = pSelfas1;
			selfas2          = pSelfas2;
			selfas3          = pSelfas3;
			selfas4          = pSelfas4;
			selfas5          = pSelfas5;
			selfas6          = pSelfas6;
			selfas7          = pSelfas7;
			selfas8          = pSelfas8;
			selfas9          = pSelfas9;
			selfas10         = pSelfas10;
			selfas11         = pSelfas11;
			selfas12         = pSelfas12;
			selfas13         = pSelfas13;
			selfas14         = pSelfas14;
			selfas15         = pSelfas15;
			selfas16         = pSelfas16;
			selfas17         = pSelfas17;
			selfas18         = pSelfas18;
			selfas19         = pSelfas19;
			upas1            = pUpas1;
			upas2            = pUpas2;
			upas3            = pUpas3;
			upas4            = pUpas4;
			upas5            = pUpas5;
			upas6            = pUpas6;
			upas7            = pUpas7;
			upas8            = pUpas8;
			upas9            = pUpas9;
			upas10           = pUpas10;
			upas11           = pUpas11;
			upas12           = pUpas12;
			upas13           = pUpas13;
			upas14           = pUpas14;
			upas15           = pUpas15;
			upas16           = pUpas16;
			upas17           = pUpas17;
			upas18           = pUpas18;
			upas19           = pUpas19;
			secas1           = pSecas1;
			secas2           = pSecas2;
			secas3           = pSecas3;
			secas4           = pSecas4;
			secas5           = pSecas5;
			secas6           = pSecas6;
			secas7           = pSecas7;
			secas8           = pSecas8;
			secas9           = pSecas9;
			secas10          = pSecas10;
			secas11          = pSecas11;
			secas12          = pSecas12;
			secas13          = pSecas13;
			secas14          = pSecas14;
			secas15          = pSecas15;
			secas16          = pSecas16;
			secas17          = pSecas17;
			secas18          = pSecas18;
			secas19          = pSecas19;
			
		}
		
		
		///<summary>
		///
		///</summary>
		public AssistantScoreInfo(int assistantScoreId)
		{
			 LoadFromId(assistantScoreId);
		}
		
		private void LoadFromId(int assistantScoreId)
		{
		 
			if (CachedEntityCommander.IsTypeRegistered(typeof(AssistantScoreInfo)))
            {
				AssistantScoreInfo assistantScoreInfo=Find(GetList(), assistantScoreId);
				if(assistantScoreInfo==null)
					throw new AppException("未能在缓存中找到相应的键值对象");
                Copy(assistantScoreInfo, this);
            }
            else
            {	AssistantScore assistantScore=new AssistantScore( assistantScoreId);	
				if(assistantScore.IsNew)
				throw new AppException("尚未初始化");
               	LoadFromDAL(this, assistantScore);
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
        public static  AssistantScoreInfo Find(List< AssistantScoreInfo> list,  int assistantScoreId)
        {
             return list.Find(delegate( AssistantScoreInfo item) { return item. assistantScoreId==assistantScoreId; });
        }
		
		
		/// <summary>
        /// 得到缓存键
        /// </summary>
        /// <returns></returns>
        private static string GetCacheKey()
        {
            return string.Format(CachedEntityCommander.CacheKey, typeof( AssistantScoreInfo).ToString());
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
        public static void Copy(AssistantScoreInfo pAssistantScoreInfoFrom, AssistantScoreInfo pAssistantScoreInfoTo)
        {
	 		pAssistantScoreInfoTo.AssistantScoreId = pAssistantScoreInfoFrom.assistantScoreId;
	 		pAssistantScoreInfoTo.DateSpan = pAssistantScoreInfoFrom.dateSpan;
	 		pAssistantScoreInfoTo.EvaluateLevelId = pAssistantScoreInfoFrom.evaluateLevelId;
	 		pAssistantScoreInfoTo.TotalScore = pAssistantScoreInfoFrom.totalScore;
	 		pAssistantScoreInfoTo.UpViews = pAssistantScoreInfoFrom.upViews;
	 		pAssistantScoreInfoTo.YearId = pAssistantScoreInfoFrom.yearId;
	 		pAssistantScoreInfoTo.MonthId = pAssistantScoreInfoFrom.monthId;
	 		pAssistantScoreInfoTo.EmployeeId = pAssistantScoreInfoFrom.employeeId;
	 		pAssistantScoreInfoTo.IsSubmit = pAssistantScoreInfoFrom.isSubmit;
	 		pAssistantScoreInfoTo.Selfas1 = pAssistantScoreInfoFrom.selfas1;
	 		pAssistantScoreInfoTo.Selfas2 = pAssistantScoreInfoFrom.selfas2;
	 		pAssistantScoreInfoTo.Selfas3 = pAssistantScoreInfoFrom.selfas3;
	 		pAssistantScoreInfoTo.Selfas4 = pAssistantScoreInfoFrom.selfas4;
	 		pAssistantScoreInfoTo.Selfas5 = pAssistantScoreInfoFrom.selfas5;
	 		pAssistantScoreInfoTo.Selfas6 = pAssistantScoreInfoFrom.selfas6;
	 		pAssistantScoreInfoTo.Selfas7 = pAssistantScoreInfoFrom.selfas7;
	 		pAssistantScoreInfoTo.Selfas8 = pAssistantScoreInfoFrom.selfas8;
	 		pAssistantScoreInfoTo.Selfas9 = pAssistantScoreInfoFrom.selfas9;
	 		pAssistantScoreInfoTo.Selfas10 = pAssistantScoreInfoFrom.selfas10;
	 		pAssistantScoreInfoTo.Selfas11 = pAssistantScoreInfoFrom.selfas11;
	 		pAssistantScoreInfoTo.Selfas12 = pAssistantScoreInfoFrom.selfas12;
	 		pAssistantScoreInfoTo.Selfas13 = pAssistantScoreInfoFrom.selfas13;
	 		pAssistantScoreInfoTo.Selfas14 = pAssistantScoreInfoFrom.selfas14;
	 		pAssistantScoreInfoTo.Selfas15 = pAssistantScoreInfoFrom.selfas15;
	 		pAssistantScoreInfoTo.Selfas16 = pAssistantScoreInfoFrom.selfas16;
	 		pAssistantScoreInfoTo.Selfas17 = pAssistantScoreInfoFrom.selfas17;
	 		pAssistantScoreInfoTo.Selfas18 = pAssistantScoreInfoFrom.selfas18;
	 		pAssistantScoreInfoTo.Selfas19 = pAssistantScoreInfoFrom.selfas19;
	 		pAssistantScoreInfoTo.Upas1 = pAssistantScoreInfoFrom.upas1;
	 		pAssistantScoreInfoTo.Upas2 = pAssistantScoreInfoFrom.upas2;
	 		pAssistantScoreInfoTo.Upas3 = pAssistantScoreInfoFrom.upas3;
	 		pAssistantScoreInfoTo.Upas4 = pAssistantScoreInfoFrom.upas4;
	 		pAssistantScoreInfoTo.Upas5 = pAssistantScoreInfoFrom.upas5;
	 		pAssistantScoreInfoTo.Upas6 = pAssistantScoreInfoFrom.upas6;
	 		pAssistantScoreInfoTo.Upas7 = pAssistantScoreInfoFrom.upas7;
	 		pAssistantScoreInfoTo.Upas8 = pAssistantScoreInfoFrom.upas8;
	 		pAssistantScoreInfoTo.Upas9 = pAssistantScoreInfoFrom.upas9;
	 		pAssistantScoreInfoTo.Upas10 = pAssistantScoreInfoFrom.upas10;
	 		pAssistantScoreInfoTo.Upas11 = pAssistantScoreInfoFrom.upas11;
	 		pAssistantScoreInfoTo.Upas12 = pAssistantScoreInfoFrom.upas12;
	 		pAssistantScoreInfoTo.Upas13 = pAssistantScoreInfoFrom.upas13;
	 		pAssistantScoreInfoTo.Upas14 = pAssistantScoreInfoFrom.upas14;
	 		pAssistantScoreInfoTo.Upas15 = pAssistantScoreInfoFrom.upas15;
	 		pAssistantScoreInfoTo.Upas16 = pAssistantScoreInfoFrom.upas16;
	 		pAssistantScoreInfoTo.Upas17 = pAssistantScoreInfoFrom.upas17;
	 		pAssistantScoreInfoTo.Upas18 = pAssistantScoreInfoFrom.upas18;
	 		pAssistantScoreInfoTo.Upas19 = pAssistantScoreInfoFrom.upas19;
	 		pAssistantScoreInfoTo.Secas1 = pAssistantScoreInfoFrom.secas1;
	 		pAssistantScoreInfoTo.Secas2 = pAssistantScoreInfoFrom.secas2;
	 		pAssistantScoreInfoTo.Secas3 = pAssistantScoreInfoFrom.secas3;
	 		pAssistantScoreInfoTo.Secas4 = pAssistantScoreInfoFrom.secas4;
	 		pAssistantScoreInfoTo.Secas5 = pAssistantScoreInfoFrom.secas5;
	 		pAssistantScoreInfoTo.Secas6 = pAssistantScoreInfoFrom.secas6;
	 		pAssistantScoreInfoTo.Secas7 = pAssistantScoreInfoFrom.secas7;
	 		pAssistantScoreInfoTo.Secas8 = pAssistantScoreInfoFrom.secas8;
	 		pAssistantScoreInfoTo.Secas9 = pAssistantScoreInfoFrom.secas9;
	 		pAssistantScoreInfoTo.Secas10 = pAssistantScoreInfoFrom.secas10;
	 		pAssistantScoreInfoTo.Secas11 = pAssistantScoreInfoFrom.secas11;
	 		pAssistantScoreInfoTo.Secas12 = pAssistantScoreInfoFrom.secas12;
	 		pAssistantScoreInfoTo.Secas13 = pAssistantScoreInfoFrom.secas13;
	 		pAssistantScoreInfoTo.Secas14 = pAssistantScoreInfoFrom.secas14;
	 		pAssistantScoreInfoTo.Secas15 = pAssistantScoreInfoFrom.secas15;
	 		pAssistantScoreInfoTo.Secas16 = pAssistantScoreInfoFrom.secas16;
	 		pAssistantScoreInfoTo.Secas17 = pAssistantScoreInfoFrom.secas17;
	 		pAssistantScoreInfoTo.Secas18 = pAssistantScoreInfoFrom.secas18;
	 		pAssistantScoreInfoTo.Secas19 = pAssistantScoreInfoFrom.secas19;
			pAssistantScoreInfoTo.Loaded=pAssistantScoreInfoFrom.Loaded;
        }
		
		/// <summary>
		/// 批量装载
		/// </summary>
		internal static void LoadFromDALPatch(List< AssistantScoreInfo> pList, AssistantScoreCollection pCollection)
        {
            foreach (AssistantScore assistantScore in pCollection)
            {
                AssistantScoreInfo assistantScoreInfo = new AssistantScoreInfo();
                LoadFromDAL(assistantScoreInfo, assistantScore );
                pList.Add(assistantScoreInfo);
            }
			
        }

		//从后台获取数据
		internal  static void  LoadFromDAL(AssistantScoreInfo pAssistantScoreInfo, AssistantScore  pAssistantScore)
		{
	 		pAssistantScoreInfo.assistantScoreId = pAssistantScore.AssistantScoreId;
	 		pAssistantScoreInfo.dateSpan = pAssistantScore.DateSpan;
	 		pAssistantScoreInfo.evaluateLevelId = pAssistantScore.EvaluateLevelId;
	 		pAssistantScoreInfo.totalScore = pAssistantScore.TotalScore;
	 		pAssistantScoreInfo.upViews = pAssistantScore.UpViews;
	 		pAssistantScoreInfo.yearId = pAssistantScore.YearId;
	 		pAssistantScoreInfo.monthId = pAssistantScore.MonthId;
	 		pAssistantScoreInfo.employeeId = pAssistantScore.EmployeeId;
	 		pAssistantScoreInfo.isSubmit = pAssistantScore.IsSubmit;
	 		pAssistantScoreInfo.selfas1 = pAssistantScore.Selfas1;
	 		pAssistantScoreInfo.selfas2 = pAssistantScore.Selfas2;
	 		pAssistantScoreInfo.selfas3 = pAssistantScore.Selfas3;
	 		pAssistantScoreInfo.selfas4 = pAssistantScore.Selfas4;
	 		pAssistantScoreInfo.selfas5 = pAssistantScore.Selfas5;
	 		pAssistantScoreInfo.selfas6 = pAssistantScore.Selfas6;
	 		pAssistantScoreInfo.selfas7 = pAssistantScore.Selfas7;
	 		pAssistantScoreInfo.selfas8 = pAssistantScore.Selfas8;
	 		pAssistantScoreInfo.selfas9 = pAssistantScore.Selfas9;
	 		pAssistantScoreInfo.selfas10 = pAssistantScore.Selfas10;
	 		pAssistantScoreInfo.selfas11 = pAssistantScore.Selfas11;
	 		pAssistantScoreInfo.selfas12 = pAssistantScore.Selfas12;
	 		pAssistantScoreInfo.selfas13 = pAssistantScore.Selfas13;
	 		pAssistantScoreInfo.selfas14 = pAssistantScore.Selfas14;
	 		pAssistantScoreInfo.selfas15 = pAssistantScore.Selfas15;
	 		pAssistantScoreInfo.selfas16 = pAssistantScore.Selfas16;
	 		pAssistantScoreInfo.selfas17 = pAssistantScore.Selfas17;
	 		pAssistantScoreInfo.selfas18 = pAssistantScore.Selfas18;
	 		pAssistantScoreInfo.selfas19 = pAssistantScore.Selfas19;
	 		pAssistantScoreInfo.upas1 = pAssistantScore.Upas1;
	 		pAssistantScoreInfo.upas2 = pAssistantScore.Upas2;
	 		pAssistantScoreInfo.upas3 = pAssistantScore.Upas3;
	 		pAssistantScoreInfo.upas4 = pAssistantScore.Upas4;
	 		pAssistantScoreInfo.upas5 = pAssistantScore.Upas5;
	 		pAssistantScoreInfo.upas6 = pAssistantScore.Upas6;
	 		pAssistantScoreInfo.upas7 = pAssistantScore.Upas7;
	 		pAssistantScoreInfo.upas8 = pAssistantScore.Upas8;
	 		pAssistantScoreInfo.upas9 = pAssistantScore.Upas9;
	 		pAssistantScoreInfo.upas10 = pAssistantScore.Upas10;
	 		pAssistantScoreInfo.upas11 = pAssistantScore.Upas11;
	 		pAssistantScoreInfo.upas12 = pAssistantScore.Upas12;
	 		pAssistantScoreInfo.upas13 = pAssistantScore.Upas13;
	 		pAssistantScoreInfo.upas14 = pAssistantScore.Upas14;
	 		pAssistantScoreInfo.upas15 = pAssistantScore.Upas15;
	 		pAssistantScoreInfo.upas16 = pAssistantScore.Upas16;
	 		pAssistantScoreInfo.upas17 = pAssistantScore.Upas17;
	 		pAssistantScoreInfo.upas18 = pAssistantScore.Upas18;
	 		pAssistantScoreInfo.upas19 = pAssistantScore.Upas19;
	 		pAssistantScoreInfo.secas1 = pAssistantScore.Secas1;
	 		pAssistantScoreInfo.secas2 = pAssistantScore.Secas2;
	 		pAssistantScoreInfo.secas3 = pAssistantScore.Secas3;
	 		pAssistantScoreInfo.secas4 = pAssistantScore.Secas4;
	 		pAssistantScoreInfo.secas5 = pAssistantScore.Secas5;
	 		pAssistantScoreInfo.secas6 = pAssistantScore.Secas6;
	 		pAssistantScoreInfo.secas7 = pAssistantScore.Secas7;
	 		pAssistantScoreInfo.secas8 = pAssistantScore.Secas8;
	 		pAssistantScoreInfo.secas9 = pAssistantScore.Secas9;
	 		pAssistantScoreInfo.secas10 = pAssistantScore.Secas10;
	 		pAssistantScoreInfo.secas11 = pAssistantScore.Secas11;
	 		pAssistantScoreInfo.secas12 = pAssistantScore.Secas12;
	 		pAssistantScoreInfo.secas13 = pAssistantScore.Secas13;
	 		pAssistantScoreInfo.secas14 = pAssistantScore.Secas14;
	 		pAssistantScoreInfo.secas15 = pAssistantScore.Secas15;
	 		pAssistantScoreInfo.secas16 = pAssistantScore.Secas16;
	 		pAssistantScoreInfo.secas17 = pAssistantScore.Secas17;
	 		pAssistantScoreInfo.secas18 = pAssistantScore.Secas18;
	 		pAssistantScoreInfo.secas19 = pAssistantScore.Secas19;
			pAssistantScoreInfo.Loaded=true;
			
			}
		
		//数据持久化
		internal  static void  SaveToDb(AssistantScoreInfo pAssistantScoreInfo, AssistantScore  pAssistantScore,bool pIsNew)
		{
	 		pAssistantScore.AssistantScoreId = pAssistantScoreInfo.assistantScoreId;
	 		pAssistantScore.DateSpan = pAssistantScoreInfo.dateSpan;
	 		pAssistantScore.EvaluateLevelId = pAssistantScoreInfo.evaluateLevelId;
	 		pAssistantScore.TotalScore = pAssistantScoreInfo.totalScore;
	 		pAssistantScore.UpViews = pAssistantScoreInfo.upViews;
	 		pAssistantScore.YearId = pAssistantScoreInfo.yearId;
	 		pAssistantScore.MonthId = pAssistantScoreInfo.monthId;
	 		pAssistantScore.EmployeeId = pAssistantScoreInfo.employeeId;
	 		pAssistantScore.IsSubmit = pAssistantScoreInfo.isSubmit;
	 		pAssistantScore.Selfas1 = pAssistantScoreInfo.selfas1;
	 		pAssistantScore.Selfas2 = pAssistantScoreInfo.selfas2;
	 		pAssistantScore.Selfas3 = pAssistantScoreInfo.selfas3;
	 		pAssistantScore.Selfas4 = pAssistantScoreInfo.selfas4;
	 		pAssistantScore.Selfas5 = pAssistantScoreInfo.selfas5;
	 		pAssistantScore.Selfas6 = pAssistantScoreInfo.selfas6;
	 		pAssistantScore.Selfas7 = pAssistantScoreInfo.selfas7;
	 		pAssistantScore.Selfas8 = pAssistantScoreInfo.selfas8;
	 		pAssistantScore.Selfas9 = pAssistantScoreInfo.selfas9;
	 		pAssistantScore.Selfas10 = pAssistantScoreInfo.selfas10;
	 		pAssistantScore.Selfas11 = pAssistantScoreInfo.selfas11;
	 		pAssistantScore.Selfas12 = pAssistantScoreInfo.selfas12;
	 		pAssistantScore.Selfas13 = pAssistantScoreInfo.selfas13;
	 		pAssistantScore.Selfas14 = pAssistantScoreInfo.selfas14;
	 		pAssistantScore.Selfas15 = pAssistantScoreInfo.selfas15;
	 		pAssistantScore.Selfas16 = pAssistantScoreInfo.selfas16;
	 		pAssistantScore.Selfas17 = pAssistantScoreInfo.selfas17;
	 		pAssistantScore.Selfas18 = pAssistantScoreInfo.selfas18;
	 		pAssistantScore.Selfas19 = pAssistantScoreInfo.selfas19;
	 		pAssistantScore.Upas1 = pAssistantScoreInfo.upas1;
	 		pAssistantScore.Upas2 = pAssistantScoreInfo.upas2;
	 		pAssistantScore.Upas3 = pAssistantScoreInfo.upas3;
	 		pAssistantScore.Upas4 = pAssistantScoreInfo.upas4;
	 		pAssistantScore.Upas5 = pAssistantScoreInfo.upas5;
	 		pAssistantScore.Upas6 = pAssistantScoreInfo.upas6;
	 		pAssistantScore.Upas7 = pAssistantScoreInfo.upas7;
	 		pAssistantScore.Upas8 = pAssistantScoreInfo.upas8;
	 		pAssistantScore.Upas9 = pAssistantScoreInfo.upas9;
	 		pAssistantScore.Upas10 = pAssistantScoreInfo.upas10;
	 		pAssistantScore.Upas11 = pAssistantScoreInfo.upas11;
	 		pAssistantScore.Upas12 = pAssistantScoreInfo.upas12;
	 		pAssistantScore.Upas13 = pAssistantScoreInfo.upas13;
	 		pAssistantScore.Upas14 = pAssistantScoreInfo.upas14;
	 		pAssistantScore.Upas15 = pAssistantScoreInfo.upas15;
	 		pAssistantScore.Upas16 = pAssistantScoreInfo.upas16;
	 		pAssistantScore.Upas17 = pAssistantScoreInfo.upas17;
	 		pAssistantScore.Upas18 = pAssistantScoreInfo.upas18;
	 		pAssistantScore.Upas19 = pAssistantScoreInfo.upas19;
	 		pAssistantScore.Secas1 = pAssistantScoreInfo.secas1;
	 		pAssistantScore.Secas2 = pAssistantScoreInfo.secas2;
	 		pAssistantScore.Secas3 = pAssistantScoreInfo.secas3;
	 		pAssistantScore.Secas4 = pAssistantScoreInfo.secas4;
	 		pAssistantScore.Secas5 = pAssistantScoreInfo.secas5;
	 		pAssistantScore.Secas6 = pAssistantScoreInfo.secas6;
	 		pAssistantScore.Secas7 = pAssistantScoreInfo.secas7;
	 		pAssistantScore.Secas8 = pAssistantScoreInfo.secas8;
	 		pAssistantScore.Secas9 = pAssistantScoreInfo.secas9;
	 		pAssistantScore.Secas10 = pAssistantScoreInfo.secas10;
	 		pAssistantScore.Secas11 = pAssistantScoreInfo.secas11;
	 		pAssistantScore.Secas12 = pAssistantScoreInfo.secas12;
	 		pAssistantScore.Secas13 = pAssistantScoreInfo.secas13;
	 		pAssistantScore.Secas14 = pAssistantScoreInfo.secas14;
	 		pAssistantScore.Secas15 = pAssistantScoreInfo.secas15;
	 		pAssistantScore.Secas16 = pAssistantScoreInfo.secas16;
	 		pAssistantScore.Secas17 = pAssistantScoreInfo.secas17;
	 		pAssistantScore.Secas18 = pAssistantScoreInfo.secas18;
	 		pAssistantScore.Secas19 = pAssistantScoreInfo.secas19;
			pAssistantScore.IsNew=pIsNew;
			string UserName = SubsonicHelper.GetUserName();
			try
			{
				pAssistantScore.Save(UserName);
			}
			catch(Exception ex)
			{
				LogManager.getInstance().getLogger(typeof(AssistantScoreInfo)).Error(ex);
				if(ex.Message.Contains("插入重复键"))//违反了唯一键
				{
					throw new AppException("此对象已经存在");//此处等待优化可以从唯一约束中直接取出提示来，如果没有的话，默认为原始的出错提示
				}
				throw new AppException("保存失败");
			}
			pAssistantScoreInfo.assistantScoreId = pAssistantScore.AssistantScoreId;
			//如果缓存存在，更新缓存
			if (CachedEntityCommander.IsTypeRegistered(typeof(AssistantScoreInfo))) 
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
        public static List< AssistantScoreInfo> GetPagedList(int pPageIndex,int pPageSize,SortDirection pOrderBy,string pSortExpression,out int pRecordCount)
        {
			if(pPageIndex<=1)
			pPageIndex=1;
            List< AssistantScoreInfo> list = new List< AssistantScoreInfo>();
          
            Query q = AssistantScore .CreateQuery();
            q.PageIndex = pPageIndex;
            q.PageSize = pPageSize;
            q.ORDER_BY(pSortExpression,pOrderBy.ToString());
			AssistantScoreCollection  collection=new  AssistantScoreCollection();
		 	collection.LoadAndCloseReader(q.ExecuteReader());
          
            foreach (AssistantScore  assistantScore  in collection)
            {
                AssistantScoreInfo assistantScoreInfo = new AssistantScoreInfo();
                LoadFromDAL(assistantScoreInfo,   assistantScore);
                list.Add(assistantScoreInfo);
            }
			pRecordCount=q.GetRecordCount();
			
            return list;

        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		/// <returns></returns>
		public static List< AssistantScoreInfo> GetList()
		{
			string cacheKey = GetCacheKey();
			//本实体已经注册成缓存实体，并且缓存存在的时候，直接从缓存取
			if (CachedEntityCommander.IsTypeRegistered(typeof(AssistantScoreInfo)) && CachedEntityCommander.GetCache(cacheKey) != null)
            {
                return CachedEntityCommander.GetCache(cacheKey) as List< AssistantScoreInfo>;
            }
            else 
            {
				List< AssistantScoreInfo>  list =new List< AssistantScoreInfo>();
				AssistantScoreCollection  collection=new  AssistantScoreCollection();
				Query qry = new Query(AssistantScore.Schema);
				collection.LoadAndCloseReader(qry.ExecuteReader());
				foreach(AssistantScore assistantScore in collection)
				{
					AssistantScoreInfo assistantScoreInfo= new AssistantScoreInfo();
					LoadFromDAL(assistantScoreInfo,assistantScore);
					list.Add(assistantScoreInfo);
				}
			  	//生成缓存
                if (CachedEntityCommander.IsTypeRegistered(typeof(AssistantScoreInfo))) 
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
		public int AssistantScoreId
		{
			get {return assistantScoreId;}
			set {assistantScoreId = value;}
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
		public int? EvaluateLevelId
		{
			get {return evaluateLevelId;}
			set {evaluateLevelId = value;}
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
		public string Selfas1
		{
			get {return selfas1;}
			set {selfas1 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfas2
		{
			get {return selfas2;}
			set {selfas2 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfas3
		{
			get {return selfas3;}
			set {selfas3 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfas4
		{
			get {return selfas4;}
			set {selfas4 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfas5
		{
			get {return selfas5;}
			set {selfas5 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfas6
		{
			get {return selfas6;}
			set {selfas6 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfas7
		{
			get {return selfas7;}
			set {selfas7 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfas8
		{
			get {return selfas8;}
			set {selfas8 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfas9
		{
			get {return selfas9;}
			set {selfas9 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfas10
		{
			get {return selfas10;}
			set {selfas10 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfas11
		{
			get {return selfas11;}
			set {selfas11 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfas12
		{
			get {return selfas12;}
			set {selfas12 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfas13
		{
			get {return selfas13;}
			set {selfas13 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfas14
		{
			get {return selfas14;}
			set {selfas14 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfas15
		{
			get {return selfas15;}
			set {selfas15 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfas16
		{
			get {return selfas16;}
			set {selfas16 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfas17
		{
			get {return selfas17;}
			set {selfas17 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfas18
		{
			get {return selfas18;}
			set {selfas18 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfas19
		{
			get {return selfas19;}
			set {selfas19 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upas1
		{
			get {return upas1;}
			set {upas1 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upas2
		{
			get {return upas2;}
			set {upas2 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upas3
		{
			get {return upas3;}
			set {upas3 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upas4
		{
			get {return upas4;}
			set {upas4 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upas5
		{
			get {return upas5;}
			set {upas5 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upas6
		{
			get {return upas6;}
			set {upas6 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upas7
		{
			get {return upas7;}
			set {upas7 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upas8
		{
			get {return upas8;}
			set {upas8 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upas9
		{
			get {return upas9;}
			set {upas9 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upas10
		{
			get {return upas10;}
			set {upas10 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upas11
		{
			get {return upas11;}
			set {upas11 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upas12
		{
			get {return upas12;}
			set {upas12 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upas13
		{
			get {return upas13;}
			set {upas13 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upas14
		{
			get {return upas14;}
			set {upas14 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upas15
		{
			get {return upas15;}
			set {upas15 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upas16
		{
			get {return upas16;}
			set {upas16 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upas17
		{
			get {return upas17;}
			set {upas17 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upas18
		{
			get {return upas18;}
			set {upas18 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upas19
		{
			get {return upas19;}
			set {upas19 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secas1
		{
			get {return secas1;}
			set {secas1 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secas2
		{
			get {return secas2;}
			set {secas2 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secas3
		{
			get {return secas3;}
			set {secas3 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secas4
		{
			get {return secas4;}
			set {secas4 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secas5
		{
			get {return secas5;}
			set {secas5 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secas6
		{
			get {return secas6;}
			set {secas6 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secas7
		{
			get {return secas7;}
			set {secas7 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secas8
		{
			get {return secas8;}
			set {secas8 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secas9
		{
			get {return secas9;}
			set {secas9 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secas10
		{
			get {return secas10;}
			set {secas10 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secas11
		{
			get {return secas11;}
			set {secas11 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secas12
		{
			get {return secas12;}
			set {secas12 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secas13
		{
			get {return secas13;}
			set {secas13 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secas14
		{
			get {return secas14;}
			set {secas14 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secas15
		{
			get {return secas15;}
			set {secas15 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secas16
		{
			get {return secas16;}
			set {secas16 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secas17
		{
			get {return secas17;}
			set {secas17 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secas18
		{
			get {return secas18;}
			set {secas18 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secas19
		{
			get {return secas19;}
			set {secas19 = value;}
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
			bool result=  (AssistantScore.Delete(AssistantScoreId) == 1);
			//更新缓存
			if (result&&CachedEntityCommander.IsTypeRegistered(typeof(AssistantScoreInfo))) 
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
        public void CopyTo(AssistantScoreInfo pAssistantScoreInfoTo)
        {
            Copy(this,  pAssistantScoreInfoTo);
        }
		
		
		
		
		
		/// <summary>
		/// 保存
		/// </summary>
		public override void Save()
		{
			if(!m_Loaded)//新增
			{
				AssistantScore assistantScore=new AssistantScore();	
				SaveToDb(this, assistantScore,true);
			}
			else//修改
			{
				AssistantScore assistantScore=new AssistantScore(assistantScoreId);	
				if(assistantScore.IsNew)
					throw new AppException("该数据已经不存在了");
				SaveToDb(this, assistantScore,false);
			}
			
		}
		 
		#endregion
		
	}
}
