// ======================================================================================================================================
// 类说明
//=======================================================================================================================================
// 创建者：sk @Copy Right 残友软件有限公司OA项目 
// 文件名：MarketScoreInfo.cs
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
	///MarketScoreInfo  Data
	/// </summary>
	[Serializable]
	public partial class MarketScoreInfo:CanYou.EntityObject
	{
		#region 属性
		///<summary>
		///
		///</summary>
		private int marketScoreId;
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
		private string selfms1 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfms2 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfms3 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfms4 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfms5 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfms6 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfms7 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfms8 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfms9 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfms10 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfms11 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfms12 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfms13 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfms14 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfms15 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfms16 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfms17 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfms18 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfms19 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfms20 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfms21 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfms22 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfms23 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfms24 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upms1 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upms2 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upms3 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upms4 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upms5 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upms6 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upms7 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upms8 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upms9 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upms10 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upms11 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upms12 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upms13 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upms14 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upms15 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upms16 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upms17 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upms18 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upms19 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upms20 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upms21 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upms22 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upms23 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upms24 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secms1 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secms2 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secms3 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secms4 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secms5 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secms6 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secms7 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secms8 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secms9 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secms10 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secms11 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secms12 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secms13 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secms14 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secms15 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secms16 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secms17 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secms18 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secms19 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secms20 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secms21 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secms22 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secms23 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secms24 = String.Empty;
		
		
		///一对多关系,如果
		private bool m_Loaded=false;
		#endregion
		
		#region 属性枚举
		public struct Fields
		{
			public const string MarketScoreId=@"MarketScoreId";
			public const string DateSpan=@"DateSpan";
			public const string EvaluateLevelId=@"EvaluateLevelId";
			public const string TotalScore=@"TotalScore";
			public const string UpViews=@"UpViews";
			public const string YearId=@"YearId";
			public const string MonthId=@"MonthId";
			public const string EmployeeId=@"EmployeeId";
			public const string IsSubmit=@"IsSubmit";
			public const string Selfms1=@"Selfms1";
			public const string Selfms2=@"Selfms2";
			public const string Selfms3=@"Selfms3";
			public const string Selfms4=@"Selfms4";
			public const string Selfms5=@"Selfms5";
			public const string Selfms6=@"Selfms6";
			public const string Selfms7=@"Selfms7";
			public const string Selfms8=@"Selfms8";
			public const string Selfms9=@"Selfms9";
			public const string Selfms10=@"Selfms10";
			public const string Selfms11=@"Selfms11";
			public const string Selfms12=@"Selfms12";
			public const string Selfms13=@"Selfms13";
			public const string Selfms14=@"Selfms14";
			public const string Selfms15=@"Selfms15";
			public const string Selfms16=@"Selfms16";
			public const string Selfms17=@"Selfms17";
			public const string Selfms18=@"Selfms18";
			public const string Selfms19=@"Selfms19";
			public const string Selfms20=@"Selfms20";
			public const string Selfms21=@"Selfms21";
			public const string Selfms22=@"Selfms22";
			public const string Selfms23=@"Selfms23";
			public const string Selfms24=@"Selfms24";
			public const string Upms1=@"Upms1";
			public const string Upms2=@"Upms2";
			public const string Upms3=@"Upms3";
			public const string Upms4=@"Upms4";
			public const string Upms5=@"Upms5";
			public const string Upms6=@"Upms6";
			public const string Upms7=@"Upms7";
			public const string Upms8=@"Upms8";
			public const string Upms9=@"Upms9";
			public const string Upms10=@"Upms10";
			public const string Upms11=@"Upms11";
			public const string Upms12=@"Upms12";
			public const string Upms13=@"Upms13";
			public const string Upms14=@"Upms14";
			public const string Upms15=@"Upms15";
			public const string Upms16=@"Upms16";
			public const string Upms17=@"Upms17";
			public const string Upms18=@"Upms18";
			public const string Upms19=@"Upms19";
			public const string Upms20=@"Upms20";
			public const string Upms21=@"Upms21";
			public const string Upms22=@"Upms22";
			public const string Upms23=@"Upms23";
			public const string Upms24=@"Upms24";
			public const string Secms1=@"Secms1";
			public const string Secms2=@"Secms2";
			public const string Secms3=@"Secms3";
			public const string Secms4=@"Secms4";
			public const string Secms5=@"Secms5";
			public const string Secms6=@"Secms6";
			public const string Secms7=@"Secms7";
			public const string Secms8=@"Secms8";
			public const string Secms9=@"Secms9";
			public const string Secms10=@"Secms10";
			public const string Secms11=@"Secms11";
			public const string Secms12=@"Secms12";
			public const string Secms13=@"Secms13";
			public const string Secms14=@"Secms14";
			public const string Secms15=@"Secms15";
			public const string Secms16=@"Secms16";
			public const string Secms17=@"Secms17";
			public const string Secms18=@"Secms18";
			public const string Secms19=@"Secms19";
			public const string Secms20=@"Secms20";
			public const string Secms21=@"Secms21";
			public const string Secms22=@"Secms22";
			public const string Secms23=@"Secms23";
			public const string Secms24=@"Secms24";
						
		}

		#endregion
		
		
		#region 构造函数
		///<summary>
		///
		///</summary>
		public MarketScoreInfo()
		{
		}
		///<summary>
		///
		///</summary>
		public MarketScoreInfo(int pMarketScoreId,string pDateSpan,int? pEvaluateLevelId,string pTotalScore,string pUpViews,int? pYearId,int? pMonthId,int? pEmployeeId,int? pIsSubmit,string pSelfms1,string pSelfms2,string pSelfms3,string pSelfms4,string pSelfms5,string pSelfms6,string pSelfms7,string pSelfms8,string pSelfms9,string pSelfms10,string pSelfms11,string pSelfms12,string pSelfms13,string pSelfms14,string pSelfms15,string pSelfms16,string pSelfms17,string pSelfms18,string pSelfms19,string pSelfms20,string pSelfms21,string pSelfms22,string pSelfms23,string pSelfms24,string pUpms1,string pUpms2,string pUpms3,string pUpms4,string pUpms5,string pUpms6,string pUpms7,string pUpms8,string pUpms9,string pUpms10,string pUpms11,string pUpms12,string pUpms13,string pUpms14,string pUpms15,string pUpms16,string pUpms17,string pUpms18,string pUpms19,string pUpms20,string pUpms21,string pUpms22,string pUpms23,string pUpms24,string pSecms1,string pSecms2,string pSecms3,string pSecms4,string pSecms5,string pSecms6,string pSecms7,string pSecms8,string pSecms9,string pSecms10,string pSecms11,string pSecms12,string pSecms13,string pSecms14,string pSecms15,string pSecms16,string pSecms17,string pSecms18,string pSecms19,string pSecms20,string pSecms21,string pSecms22,string pSecms23,string pSecms24)
		{
			marketScoreId   = pMarketScoreId;
			dateSpan        = pDateSpan;
			evaluateLevelId = pEvaluateLevelId;
			totalScore      = pTotalScore;
			upViews         = pUpViews;
			yearId          = pYearId;
			monthId         = pMonthId;
			employeeId      = pEmployeeId;
			isSubmit        = pIsSubmit;
			selfms1         = pSelfms1;
			selfms2         = pSelfms2;
			selfms3         = pSelfms3;
			selfms4         = pSelfms4;
			selfms5         = pSelfms5;
			selfms6         = pSelfms6;
			selfms7         = pSelfms7;
			selfms8         = pSelfms8;
			selfms9         = pSelfms9;
			selfms10        = pSelfms10;
			selfms11        = pSelfms11;
			selfms12        = pSelfms12;
			selfms13        = pSelfms13;
			selfms14        = pSelfms14;
			selfms15        = pSelfms15;
			selfms16        = pSelfms16;
			selfms17        = pSelfms17;
			selfms18        = pSelfms18;
			selfms19        = pSelfms19;
			selfms20        = pSelfms20;
			selfms21        = pSelfms21;
			selfms22        = pSelfms22;
			selfms23        = pSelfms23;
			selfms24        = pSelfms24;
			upms1           = pUpms1;
			upms2           = pUpms2;
			upms3           = pUpms3;
			upms4           = pUpms4;
			upms5           = pUpms5;
			upms6           = pUpms6;
			upms7           = pUpms7;
			upms8           = pUpms8;
			upms9           = pUpms9;
			upms10          = pUpms10;
			upms11          = pUpms11;
			upms12          = pUpms12;
			upms13          = pUpms13;
			upms14          = pUpms14;
			upms15          = pUpms15;
			upms16          = pUpms16;
			upms17          = pUpms17;
			upms18          = pUpms18;
			upms19          = pUpms19;
			upms20          = pUpms20;
			upms21          = pUpms21;
			upms22          = pUpms22;
			upms23          = pUpms23;
			upms24          = pUpms24;
			secms1          = pSecms1;
			secms2          = pSecms2;
			secms3          = pSecms3;
			secms4          = pSecms4;
			secms5          = pSecms5;
			secms6          = pSecms6;
			secms7          = pSecms7;
			secms8          = pSecms8;
			secms9          = pSecms9;
			secms10         = pSecms10;
			secms11         = pSecms11;
			secms12         = pSecms12;
			secms13         = pSecms13;
			secms14         = pSecms14;
			secms15         = pSecms15;
			secms16         = pSecms16;
			secms17         = pSecms17;
			secms18         = pSecms18;
			secms19         = pSecms19;
			secms20         = pSecms20;
			secms21         = pSecms21;
			secms22         = pSecms22;
			secms23         = pSecms23;
			secms24         = pSecms24;
			
		}
		
		
		///<summary>
		///
		///</summary>
		public MarketScoreInfo(int marketScoreId)
		{
			 LoadFromId(marketScoreId);
		}
		
		private void LoadFromId(int marketScoreId)
		{
		 
			if (CachedEntityCommander.IsTypeRegistered(typeof(MarketScoreInfo)))
            {
				MarketScoreInfo marketScoreInfo=Find(GetList(), marketScoreId);
				if(marketScoreInfo==null)
					throw new AppException("未能在缓存中找到相应的键值对象");
                Copy(marketScoreInfo, this);
            }
            else
            {	MarketScore marketScore=new MarketScore( marketScoreId);	
				if(marketScore.IsNew)
				throw new AppException("尚未初始化");
               	LoadFromDAL(this, marketScore);
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
        public static  MarketScoreInfo Find(List< MarketScoreInfo> list,  int marketScoreId)
        {
             return list.Find(delegate( MarketScoreInfo item) { return item. marketScoreId==marketScoreId; });
        }
		
		
		/// <summary>
        /// 得到缓存键
        /// </summary>
        /// <returns></returns>
        private static string GetCacheKey()
        {
            return string.Format(CachedEntityCommander.CacheKey, typeof( MarketScoreInfo).ToString());
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
        public static void Copy(MarketScoreInfo pMarketScoreInfoFrom, MarketScoreInfo pMarketScoreInfoTo)
        {
	 		pMarketScoreInfoTo.MarketScoreId = pMarketScoreInfoFrom.marketScoreId;
	 		pMarketScoreInfoTo.DateSpan = pMarketScoreInfoFrom.dateSpan;
	 		pMarketScoreInfoTo.EvaluateLevelId = pMarketScoreInfoFrom.evaluateLevelId;
	 		pMarketScoreInfoTo.TotalScore = pMarketScoreInfoFrom.totalScore;
	 		pMarketScoreInfoTo.UpViews = pMarketScoreInfoFrom.upViews;
	 		pMarketScoreInfoTo.YearId = pMarketScoreInfoFrom.yearId;
	 		pMarketScoreInfoTo.MonthId = pMarketScoreInfoFrom.monthId;
	 		pMarketScoreInfoTo.EmployeeId = pMarketScoreInfoFrom.employeeId;
	 		pMarketScoreInfoTo.IsSubmit = pMarketScoreInfoFrom.isSubmit;
	 		pMarketScoreInfoTo.Selfms1 = pMarketScoreInfoFrom.selfms1;
	 		pMarketScoreInfoTo.Selfms2 = pMarketScoreInfoFrom.selfms2;
	 		pMarketScoreInfoTo.Selfms3 = pMarketScoreInfoFrom.selfms3;
	 		pMarketScoreInfoTo.Selfms4 = pMarketScoreInfoFrom.selfms4;
	 		pMarketScoreInfoTo.Selfms5 = pMarketScoreInfoFrom.selfms5;
	 		pMarketScoreInfoTo.Selfms6 = pMarketScoreInfoFrom.selfms6;
	 		pMarketScoreInfoTo.Selfms7 = pMarketScoreInfoFrom.selfms7;
	 		pMarketScoreInfoTo.Selfms8 = pMarketScoreInfoFrom.selfms8;
	 		pMarketScoreInfoTo.Selfms9 = pMarketScoreInfoFrom.selfms9;
	 		pMarketScoreInfoTo.Selfms10 = pMarketScoreInfoFrom.selfms10;
	 		pMarketScoreInfoTo.Selfms11 = pMarketScoreInfoFrom.selfms11;
	 		pMarketScoreInfoTo.Selfms12 = pMarketScoreInfoFrom.selfms12;
	 		pMarketScoreInfoTo.Selfms13 = pMarketScoreInfoFrom.selfms13;
	 		pMarketScoreInfoTo.Selfms14 = pMarketScoreInfoFrom.selfms14;
	 		pMarketScoreInfoTo.Selfms15 = pMarketScoreInfoFrom.selfms15;
	 		pMarketScoreInfoTo.Selfms16 = pMarketScoreInfoFrom.selfms16;
	 		pMarketScoreInfoTo.Selfms17 = pMarketScoreInfoFrom.selfms17;
	 		pMarketScoreInfoTo.Selfms18 = pMarketScoreInfoFrom.selfms18;
	 		pMarketScoreInfoTo.Selfms19 = pMarketScoreInfoFrom.selfms19;
	 		pMarketScoreInfoTo.Selfms20 = pMarketScoreInfoFrom.selfms20;
	 		pMarketScoreInfoTo.Selfms21 = pMarketScoreInfoFrom.selfms21;
	 		pMarketScoreInfoTo.Selfms22 = pMarketScoreInfoFrom.selfms22;
	 		pMarketScoreInfoTo.Selfms23 = pMarketScoreInfoFrom.selfms23;
	 		pMarketScoreInfoTo.Selfms24 = pMarketScoreInfoFrom.selfms24;
	 		pMarketScoreInfoTo.Upms1 = pMarketScoreInfoFrom.upms1;
	 		pMarketScoreInfoTo.Upms2 = pMarketScoreInfoFrom.upms2;
	 		pMarketScoreInfoTo.Upms3 = pMarketScoreInfoFrom.upms3;
	 		pMarketScoreInfoTo.Upms4 = pMarketScoreInfoFrom.upms4;
	 		pMarketScoreInfoTo.Upms5 = pMarketScoreInfoFrom.upms5;
	 		pMarketScoreInfoTo.Upms6 = pMarketScoreInfoFrom.upms6;
	 		pMarketScoreInfoTo.Upms7 = pMarketScoreInfoFrom.upms7;
	 		pMarketScoreInfoTo.Upms8 = pMarketScoreInfoFrom.upms8;
	 		pMarketScoreInfoTo.Upms9 = pMarketScoreInfoFrom.upms9;
	 		pMarketScoreInfoTo.Upms10 = pMarketScoreInfoFrom.upms10;
	 		pMarketScoreInfoTo.Upms11 = pMarketScoreInfoFrom.upms11;
	 		pMarketScoreInfoTo.Upms12 = pMarketScoreInfoFrom.upms12;
	 		pMarketScoreInfoTo.Upms13 = pMarketScoreInfoFrom.upms13;
	 		pMarketScoreInfoTo.Upms14 = pMarketScoreInfoFrom.upms14;
	 		pMarketScoreInfoTo.Upms15 = pMarketScoreInfoFrom.upms15;
	 		pMarketScoreInfoTo.Upms16 = pMarketScoreInfoFrom.upms16;
	 		pMarketScoreInfoTo.Upms17 = pMarketScoreInfoFrom.upms17;
	 		pMarketScoreInfoTo.Upms18 = pMarketScoreInfoFrom.upms18;
	 		pMarketScoreInfoTo.Upms19 = pMarketScoreInfoFrom.upms19;
	 		pMarketScoreInfoTo.Upms20 = pMarketScoreInfoFrom.upms20;
	 		pMarketScoreInfoTo.Upms21 = pMarketScoreInfoFrom.upms21;
	 		pMarketScoreInfoTo.Upms22 = pMarketScoreInfoFrom.upms22;
	 		pMarketScoreInfoTo.Upms23 = pMarketScoreInfoFrom.upms23;
	 		pMarketScoreInfoTo.Upms24 = pMarketScoreInfoFrom.upms24;
	 		pMarketScoreInfoTo.Secms1 = pMarketScoreInfoFrom.secms1;
	 		pMarketScoreInfoTo.Secms2 = pMarketScoreInfoFrom.secms2;
	 		pMarketScoreInfoTo.Secms3 = pMarketScoreInfoFrom.secms3;
	 		pMarketScoreInfoTo.Secms4 = pMarketScoreInfoFrom.secms4;
	 		pMarketScoreInfoTo.Secms5 = pMarketScoreInfoFrom.secms5;
	 		pMarketScoreInfoTo.Secms6 = pMarketScoreInfoFrom.secms6;
	 		pMarketScoreInfoTo.Secms7 = pMarketScoreInfoFrom.secms7;
	 		pMarketScoreInfoTo.Secms8 = pMarketScoreInfoFrom.secms8;
	 		pMarketScoreInfoTo.Secms9 = pMarketScoreInfoFrom.secms9;
	 		pMarketScoreInfoTo.Secms10 = pMarketScoreInfoFrom.secms10;
	 		pMarketScoreInfoTo.Secms11 = pMarketScoreInfoFrom.secms11;
	 		pMarketScoreInfoTo.Secms12 = pMarketScoreInfoFrom.secms12;
	 		pMarketScoreInfoTo.Secms13 = pMarketScoreInfoFrom.secms13;
	 		pMarketScoreInfoTo.Secms14 = pMarketScoreInfoFrom.secms14;
	 		pMarketScoreInfoTo.Secms15 = pMarketScoreInfoFrom.secms15;
	 		pMarketScoreInfoTo.Secms16 = pMarketScoreInfoFrom.secms16;
	 		pMarketScoreInfoTo.Secms17 = pMarketScoreInfoFrom.secms17;
	 		pMarketScoreInfoTo.Secms18 = pMarketScoreInfoFrom.secms18;
	 		pMarketScoreInfoTo.Secms19 = pMarketScoreInfoFrom.secms19;
	 		pMarketScoreInfoTo.Secms20 = pMarketScoreInfoFrom.secms20;
	 		pMarketScoreInfoTo.Secms21 = pMarketScoreInfoFrom.secms21;
	 		pMarketScoreInfoTo.Secms22 = pMarketScoreInfoFrom.secms22;
	 		pMarketScoreInfoTo.Secms23 = pMarketScoreInfoFrom.secms23;
	 		pMarketScoreInfoTo.Secms24 = pMarketScoreInfoFrom.secms24;
			pMarketScoreInfoTo.Loaded=pMarketScoreInfoFrom.Loaded;
        }
		
		/// <summary>
		/// 批量装载
		/// </summary>
		internal static void LoadFromDALPatch(List< MarketScoreInfo> pList, MarketScoreCollection pCollection)
        {
            foreach (MarketScore marketScore in pCollection)
            {
                MarketScoreInfo marketScoreInfo = new MarketScoreInfo();
                LoadFromDAL(marketScoreInfo, marketScore );
                pList.Add(marketScoreInfo);
            }
			
        }

		//从后台获取数据
		internal  static void  LoadFromDAL(MarketScoreInfo pMarketScoreInfo, MarketScore  pMarketScore)
		{
	 		pMarketScoreInfo.marketScoreId = pMarketScore.MarketScoreId;
	 		pMarketScoreInfo.dateSpan = pMarketScore.DateSpan;
	 		pMarketScoreInfo.evaluateLevelId = pMarketScore.EvaluateLevelId;
	 		pMarketScoreInfo.totalScore = pMarketScore.TotalScore;
	 		pMarketScoreInfo.upViews = pMarketScore.UpViews;
	 		pMarketScoreInfo.yearId = pMarketScore.YearId;
	 		pMarketScoreInfo.monthId = pMarketScore.MonthId;
	 		pMarketScoreInfo.employeeId = pMarketScore.EmployeeId;
	 		pMarketScoreInfo.isSubmit = pMarketScore.IsSubmit;
	 		pMarketScoreInfo.selfms1 = pMarketScore.Selfms1;
	 		pMarketScoreInfo.selfms2 = pMarketScore.Selfms2;
	 		pMarketScoreInfo.selfms3 = pMarketScore.Selfms3;
	 		pMarketScoreInfo.selfms4 = pMarketScore.Selfms4;
	 		pMarketScoreInfo.selfms5 = pMarketScore.Selfms5;
	 		pMarketScoreInfo.selfms6 = pMarketScore.Selfms6;
	 		pMarketScoreInfo.selfms7 = pMarketScore.Selfms7;
	 		pMarketScoreInfo.selfms8 = pMarketScore.Selfms8;
	 		pMarketScoreInfo.selfms9 = pMarketScore.Selfms9;
	 		pMarketScoreInfo.selfms10 = pMarketScore.Selfms10;
	 		pMarketScoreInfo.selfms11 = pMarketScore.Selfms11;
	 		pMarketScoreInfo.selfms12 = pMarketScore.Selfms12;
	 		pMarketScoreInfo.selfms13 = pMarketScore.Selfms13;
	 		pMarketScoreInfo.selfms14 = pMarketScore.Selfms14;
	 		pMarketScoreInfo.selfms15 = pMarketScore.Selfms15;
	 		pMarketScoreInfo.selfms16 = pMarketScore.Selfms16;
	 		pMarketScoreInfo.selfms17 = pMarketScore.Selfms17;
	 		pMarketScoreInfo.selfms18 = pMarketScore.Selfms18;
	 		pMarketScoreInfo.selfms19 = pMarketScore.Selfms19;
	 		pMarketScoreInfo.selfms20 = pMarketScore.Selfms20;
	 		pMarketScoreInfo.selfms21 = pMarketScore.Selfms21;
	 		pMarketScoreInfo.selfms22 = pMarketScore.Selfms22;
	 		pMarketScoreInfo.selfms23 = pMarketScore.Selfms23;
	 		pMarketScoreInfo.selfms24 = pMarketScore.Selfms24;
	 		pMarketScoreInfo.upms1 = pMarketScore.Upms1;
	 		pMarketScoreInfo.upms2 = pMarketScore.Upms2;
	 		pMarketScoreInfo.upms3 = pMarketScore.Upms3;
	 		pMarketScoreInfo.upms4 = pMarketScore.Upms4;
	 		pMarketScoreInfo.upms5 = pMarketScore.Upms5;
	 		pMarketScoreInfo.upms6 = pMarketScore.Upms6;
	 		pMarketScoreInfo.upms7 = pMarketScore.Upms7;
	 		pMarketScoreInfo.upms8 = pMarketScore.Upms8;
	 		pMarketScoreInfo.upms9 = pMarketScore.Upms9;
	 		pMarketScoreInfo.upms10 = pMarketScore.Upms10;
	 		pMarketScoreInfo.upms11 = pMarketScore.Upms11;
	 		pMarketScoreInfo.upms12 = pMarketScore.Upms12;
	 		pMarketScoreInfo.upms13 = pMarketScore.Upms13;
	 		pMarketScoreInfo.upms14 = pMarketScore.Upms14;
	 		pMarketScoreInfo.upms15 = pMarketScore.Upms15;
	 		pMarketScoreInfo.upms16 = pMarketScore.Upms16;
	 		pMarketScoreInfo.upms17 = pMarketScore.Upms17;
	 		pMarketScoreInfo.upms18 = pMarketScore.Upms18;
	 		pMarketScoreInfo.upms19 = pMarketScore.Upms19;
	 		pMarketScoreInfo.upms20 = pMarketScore.Upms20;
	 		pMarketScoreInfo.upms21 = pMarketScore.Upms21;
	 		pMarketScoreInfo.upms22 = pMarketScore.Upms22;
	 		pMarketScoreInfo.upms23 = pMarketScore.Upms23;
	 		pMarketScoreInfo.upms24 = pMarketScore.Upms24;
	 		pMarketScoreInfo.secms1 = pMarketScore.Secms1;
	 		pMarketScoreInfo.secms2 = pMarketScore.Secms2;
	 		pMarketScoreInfo.secms3 = pMarketScore.Secms3;
	 		pMarketScoreInfo.secms4 = pMarketScore.Secms4;
	 		pMarketScoreInfo.secms5 = pMarketScore.Secms5;
	 		pMarketScoreInfo.secms6 = pMarketScore.Secms6;
	 		pMarketScoreInfo.secms7 = pMarketScore.Secms7;
	 		pMarketScoreInfo.secms8 = pMarketScore.Secms8;
	 		pMarketScoreInfo.secms9 = pMarketScore.Secms9;
	 		pMarketScoreInfo.secms10 = pMarketScore.Secms10;
	 		pMarketScoreInfo.secms11 = pMarketScore.Secms11;
	 		pMarketScoreInfo.secms12 = pMarketScore.Secms12;
	 		pMarketScoreInfo.secms13 = pMarketScore.Secms13;
	 		pMarketScoreInfo.secms14 = pMarketScore.Secms14;
	 		pMarketScoreInfo.secms15 = pMarketScore.Secms15;
	 		pMarketScoreInfo.secms16 = pMarketScore.Secms16;
	 		pMarketScoreInfo.secms17 = pMarketScore.Secms17;
	 		pMarketScoreInfo.secms18 = pMarketScore.Secms18;
	 		pMarketScoreInfo.secms19 = pMarketScore.Secms19;
	 		pMarketScoreInfo.secms20 = pMarketScore.Secms20;
	 		pMarketScoreInfo.secms21 = pMarketScore.Secms21;
	 		pMarketScoreInfo.secms22 = pMarketScore.Secms22;
	 		pMarketScoreInfo.secms23 = pMarketScore.Secms23;
	 		pMarketScoreInfo.secms24 = pMarketScore.Secms24;
			pMarketScoreInfo.Loaded=true;
			
			}
		
		//数据持久化
		internal  static void  SaveToDb(MarketScoreInfo pMarketScoreInfo, MarketScore  pMarketScore,bool pIsNew)
		{
	 		pMarketScore.MarketScoreId = pMarketScoreInfo.marketScoreId;
	 		pMarketScore.DateSpan = pMarketScoreInfo.dateSpan;
	 		pMarketScore.EvaluateLevelId = pMarketScoreInfo.evaluateLevelId;
	 		pMarketScore.TotalScore = pMarketScoreInfo.totalScore;
	 		pMarketScore.UpViews = pMarketScoreInfo.upViews;
	 		pMarketScore.YearId = pMarketScoreInfo.yearId;
	 		pMarketScore.MonthId = pMarketScoreInfo.monthId;
	 		pMarketScore.EmployeeId = pMarketScoreInfo.employeeId;
	 		pMarketScore.IsSubmit = pMarketScoreInfo.isSubmit;
	 		pMarketScore.Selfms1 = pMarketScoreInfo.selfms1;
	 		pMarketScore.Selfms2 = pMarketScoreInfo.selfms2;
	 		pMarketScore.Selfms3 = pMarketScoreInfo.selfms3;
	 		pMarketScore.Selfms4 = pMarketScoreInfo.selfms4;
	 		pMarketScore.Selfms5 = pMarketScoreInfo.selfms5;
	 		pMarketScore.Selfms6 = pMarketScoreInfo.selfms6;
	 		pMarketScore.Selfms7 = pMarketScoreInfo.selfms7;
	 		pMarketScore.Selfms8 = pMarketScoreInfo.selfms8;
	 		pMarketScore.Selfms9 = pMarketScoreInfo.selfms9;
	 		pMarketScore.Selfms10 = pMarketScoreInfo.selfms10;
	 		pMarketScore.Selfms11 = pMarketScoreInfo.selfms11;
	 		pMarketScore.Selfms12 = pMarketScoreInfo.selfms12;
	 		pMarketScore.Selfms13 = pMarketScoreInfo.selfms13;
	 		pMarketScore.Selfms14 = pMarketScoreInfo.selfms14;
	 		pMarketScore.Selfms15 = pMarketScoreInfo.selfms15;
	 		pMarketScore.Selfms16 = pMarketScoreInfo.selfms16;
	 		pMarketScore.Selfms17 = pMarketScoreInfo.selfms17;
	 		pMarketScore.Selfms18 = pMarketScoreInfo.selfms18;
	 		pMarketScore.Selfms19 = pMarketScoreInfo.selfms19;
	 		pMarketScore.Selfms20 = pMarketScoreInfo.selfms20;
	 		pMarketScore.Selfms21 = pMarketScoreInfo.selfms21;
	 		pMarketScore.Selfms22 = pMarketScoreInfo.selfms22;
	 		pMarketScore.Selfms23 = pMarketScoreInfo.selfms23;
	 		pMarketScore.Selfms24 = pMarketScoreInfo.selfms24;
	 		pMarketScore.Upms1 = pMarketScoreInfo.upms1;
	 		pMarketScore.Upms2 = pMarketScoreInfo.upms2;
	 		pMarketScore.Upms3 = pMarketScoreInfo.upms3;
	 		pMarketScore.Upms4 = pMarketScoreInfo.upms4;
	 		pMarketScore.Upms5 = pMarketScoreInfo.upms5;
	 		pMarketScore.Upms6 = pMarketScoreInfo.upms6;
	 		pMarketScore.Upms7 = pMarketScoreInfo.upms7;
	 		pMarketScore.Upms8 = pMarketScoreInfo.upms8;
	 		pMarketScore.Upms9 = pMarketScoreInfo.upms9;
	 		pMarketScore.Upms10 = pMarketScoreInfo.upms10;
	 		pMarketScore.Upms11 = pMarketScoreInfo.upms11;
	 		pMarketScore.Upms12 = pMarketScoreInfo.upms12;
	 		pMarketScore.Upms13 = pMarketScoreInfo.upms13;
	 		pMarketScore.Upms14 = pMarketScoreInfo.upms14;
	 		pMarketScore.Upms15 = pMarketScoreInfo.upms15;
	 		pMarketScore.Upms16 = pMarketScoreInfo.upms16;
	 		pMarketScore.Upms17 = pMarketScoreInfo.upms17;
	 		pMarketScore.Upms18 = pMarketScoreInfo.upms18;
	 		pMarketScore.Upms19 = pMarketScoreInfo.upms19;
	 		pMarketScore.Upms20 = pMarketScoreInfo.upms20;
	 		pMarketScore.Upms21 = pMarketScoreInfo.upms21;
	 		pMarketScore.Upms22 = pMarketScoreInfo.upms22;
	 		pMarketScore.Upms23 = pMarketScoreInfo.upms23;
	 		pMarketScore.Upms24 = pMarketScoreInfo.upms24;
	 		pMarketScore.Secms1 = pMarketScoreInfo.secms1;
	 		pMarketScore.Secms2 = pMarketScoreInfo.secms2;
	 		pMarketScore.Secms3 = pMarketScoreInfo.secms3;
	 		pMarketScore.Secms4 = pMarketScoreInfo.secms4;
	 		pMarketScore.Secms5 = pMarketScoreInfo.secms5;
	 		pMarketScore.Secms6 = pMarketScoreInfo.secms6;
	 		pMarketScore.Secms7 = pMarketScoreInfo.secms7;
	 		pMarketScore.Secms8 = pMarketScoreInfo.secms8;
	 		pMarketScore.Secms9 = pMarketScoreInfo.secms9;
	 		pMarketScore.Secms10 = pMarketScoreInfo.secms10;
	 		pMarketScore.Secms11 = pMarketScoreInfo.secms11;
	 		pMarketScore.Secms12 = pMarketScoreInfo.secms12;
	 		pMarketScore.Secms13 = pMarketScoreInfo.secms13;
	 		pMarketScore.Secms14 = pMarketScoreInfo.secms14;
	 		pMarketScore.Secms15 = pMarketScoreInfo.secms15;
	 		pMarketScore.Secms16 = pMarketScoreInfo.secms16;
	 		pMarketScore.Secms17 = pMarketScoreInfo.secms17;
	 		pMarketScore.Secms18 = pMarketScoreInfo.secms18;
	 		pMarketScore.Secms19 = pMarketScoreInfo.secms19;
	 		pMarketScore.Secms20 = pMarketScoreInfo.secms20;
	 		pMarketScore.Secms21 = pMarketScoreInfo.secms21;
	 		pMarketScore.Secms22 = pMarketScoreInfo.secms22;
	 		pMarketScore.Secms23 = pMarketScoreInfo.secms23;
	 		pMarketScore.Secms24 = pMarketScoreInfo.secms24;
			pMarketScore.IsNew=pIsNew;
			string UserName = SubsonicHelper.GetUserName();
			try
			{
				pMarketScore.Save(UserName);
			}
			catch(Exception ex)
			{
				LogManager.getInstance().getLogger(typeof(MarketScoreInfo)).Error(ex);
				if(ex.Message.Contains("插入重复键"))//违反了唯一键
				{
					throw new AppException("此对象已经存在");//此处等待优化可以从唯一约束中直接取出提示来，如果没有的话，默认为原始的出错提示
				}
				throw new AppException("保存失败");
			}
			pMarketScoreInfo.marketScoreId = pMarketScore.MarketScoreId;
			//如果缓存存在，更新缓存
			if (CachedEntityCommander.IsTypeRegistered(typeof(MarketScoreInfo))) 
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
        public static List< MarketScoreInfo> GetPagedList(int pPageIndex,int pPageSize,SortDirection pOrderBy,string pSortExpression,out int pRecordCount)
        {
			if(pPageIndex<=1)
			pPageIndex=1;
            List< MarketScoreInfo> list = new List< MarketScoreInfo>();
          
            Query q = MarketScore .CreateQuery();
            q.PageIndex = pPageIndex;
            q.PageSize = pPageSize;
            q.ORDER_BY(pSortExpression,pOrderBy.ToString());
			MarketScoreCollection  collection=new  MarketScoreCollection();
		 	collection.LoadAndCloseReader(q.ExecuteReader());
          
            foreach (MarketScore  marketScore  in collection)
            {
                MarketScoreInfo marketScoreInfo = new MarketScoreInfo();
                LoadFromDAL(marketScoreInfo,   marketScore);
                list.Add(marketScoreInfo);
            }
			pRecordCount=q.GetRecordCount();
			
            return list;

        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		/// <returns></returns>
		public static List< MarketScoreInfo> GetList()
		{
			string cacheKey = GetCacheKey();
			//本实体已经注册成缓存实体，并且缓存存在的时候，直接从缓存取
			if (CachedEntityCommander.IsTypeRegistered(typeof(MarketScoreInfo)) && CachedEntityCommander.GetCache(cacheKey) != null)
            {
                return CachedEntityCommander.GetCache(cacheKey) as List< MarketScoreInfo>;
            }
            else 
            {
				List< MarketScoreInfo>  list =new List< MarketScoreInfo>();
				MarketScoreCollection  collection=new  MarketScoreCollection();
				Query qry = new Query(MarketScore.Schema);
				collection.LoadAndCloseReader(qry.ExecuteReader());
				foreach(MarketScore marketScore in collection)
				{
					MarketScoreInfo marketScoreInfo= new MarketScoreInfo();
					LoadFromDAL(marketScoreInfo,marketScore);
					list.Add(marketScoreInfo);
				}
			  	//生成缓存
                if (CachedEntityCommander.IsTypeRegistered(typeof(MarketScoreInfo))) 
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
		public int MarketScoreId
		{
			get {return marketScoreId;}
			set {marketScoreId = value;}
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
		public string Selfms1
		{
			get {return selfms1;}
			set {selfms1 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfms2
		{
			get {return selfms2;}
			set {selfms2 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfms3
		{
			get {return selfms3;}
			set {selfms3 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfms4
		{
			get {return selfms4;}
			set {selfms4 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfms5
		{
			get {return selfms5;}
			set {selfms5 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfms6
		{
			get {return selfms6;}
			set {selfms6 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfms7
		{
			get {return selfms7;}
			set {selfms7 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfms8
		{
			get {return selfms8;}
			set {selfms8 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfms9
		{
			get {return selfms9;}
			set {selfms9 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfms10
		{
			get {return selfms10;}
			set {selfms10 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfms11
		{
			get {return selfms11;}
			set {selfms11 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfms12
		{
			get {return selfms12;}
			set {selfms12 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfms13
		{
			get {return selfms13;}
			set {selfms13 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfms14
		{
			get {return selfms14;}
			set {selfms14 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfms15
		{
			get {return selfms15;}
			set {selfms15 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfms16
		{
			get {return selfms16;}
			set {selfms16 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfms17
		{
			get {return selfms17;}
			set {selfms17 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfms18
		{
			get {return selfms18;}
			set {selfms18 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfms19
		{
			get {return selfms19;}
			set {selfms19 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfms20
		{
			get {return selfms20;}
			set {selfms20 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfms21
		{
			get {return selfms21;}
			set {selfms21 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfms22
		{
			get {return selfms22;}
			set {selfms22 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfms23
		{
			get {return selfms23;}
			set {selfms23 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfms24
		{
			get {return selfms24;}
			set {selfms24 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upms1
		{
			get {return upms1;}
			set {upms1 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upms2
		{
			get {return upms2;}
			set {upms2 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upms3
		{
			get {return upms3;}
			set {upms3 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upms4
		{
			get {return upms4;}
			set {upms4 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upms5
		{
			get {return upms5;}
			set {upms5 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upms6
		{
			get {return upms6;}
			set {upms6 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upms7
		{
			get {return upms7;}
			set {upms7 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upms8
		{
			get {return upms8;}
			set {upms8 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upms9
		{
			get {return upms9;}
			set {upms9 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upms10
		{
			get {return upms10;}
			set {upms10 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upms11
		{
			get {return upms11;}
			set {upms11 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upms12
		{
			get {return upms12;}
			set {upms12 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upms13
		{
			get {return upms13;}
			set {upms13 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upms14
		{
			get {return upms14;}
			set {upms14 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upms15
		{
			get {return upms15;}
			set {upms15 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upms16
		{
			get {return upms16;}
			set {upms16 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upms17
		{
			get {return upms17;}
			set {upms17 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upms18
		{
			get {return upms18;}
			set {upms18 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upms19
		{
			get {return upms19;}
			set {upms19 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upms20
		{
			get {return upms20;}
			set {upms20 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upms21
		{
			get {return upms21;}
			set {upms21 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upms22
		{
			get {return upms22;}
			set {upms22 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upms23
		{
			get {return upms23;}
			set {upms23 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upms24
		{
			get {return upms24;}
			set {upms24 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secms1
		{
			get {return secms1;}
			set {secms1 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secms2
		{
			get {return secms2;}
			set {secms2 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secms3
		{
			get {return secms3;}
			set {secms3 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secms4
		{
			get {return secms4;}
			set {secms4 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secms5
		{
			get {return secms5;}
			set {secms5 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secms6
		{
			get {return secms6;}
			set {secms6 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secms7
		{
			get {return secms7;}
			set {secms7 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secms8
		{
			get {return secms8;}
			set {secms8 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secms9
		{
			get {return secms9;}
			set {secms9 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secms10
		{
			get {return secms10;}
			set {secms10 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secms11
		{
			get {return secms11;}
			set {secms11 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secms12
		{
			get {return secms12;}
			set {secms12 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secms13
		{
			get {return secms13;}
			set {secms13 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secms14
		{
			get {return secms14;}
			set {secms14 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secms15
		{
			get {return secms15;}
			set {secms15 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secms16
		{
			get {return secms16;}
			set {secms16 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secms17
		{
			get {return secms17;}
			set {secms17 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secms18
		{
			get {return secms18;}
			set {secms18 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secms19
		{
			get {return secms19;}
			set {secms19 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secms20
		{
			get {return secms20;}
			set {secms20 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secms21
		{
			get {return secms21;}
			set {secms21 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secms22
		{
			get {return secms22;}
			set {secms22 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secms23
		{
			get {return secms23;}
			set {secms23 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secms24
		{
			get {return secms24;}
			set {secms24 = value;}
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
			bool result=  (MarketScore.Delete(MarketScoreId) == 1);
			//更新缓存
			if (result&&CachedEntityCommander.IsTypeRegistered(typeof(MarketScoreInfo))) 
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
        public void CopyTo(MarketScoreInfo pMarketScoreInfoTo)
        {
            Copy(this,  pMarketScoreInfoTo);
        }
		
		
		
		
		
		/// <summary>
		/// 保存
		/// </summary>
		public override void Save()
		{
			if(!m_Loaded)//新增
			{
				MarketScore marketScore=new MarketScore();	
				SaveToDb(this, marketScore,true);
			}
			else//修改
			{
				MarketScore marketScore=new MarketScore(marketScoreId);	
				if(marketScore.IsNew)
					throw new AppException("该数据已经不存在了");
				SaveToDb(this, marketScore,false);
			}
			
		}
		 
		#endregion
		
	}
}
