// ======================================================================================================================================
// 类说明
//=======================================================================================================================================
// 创建者：sk @Copy Right 残友软件有限公司OA项目 
// 文件名：DriverScoreInfo.cs
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
	///DriverScoreInfo  Data
	/// </summary>
	[Serializable]
	public partial class DriverScoreInfo:CanYou.EntityObject
	{
		#region 属性
		///<summary>
		///
		///</summary>
		private int driverScoreId;
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
		private string selfds1 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfds2 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfds3 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfds4 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfds5 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfds6 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfds7 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfds8 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfds9 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfds10 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfds11 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfds12 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfds13 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfds14 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfds15 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfds16 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfds17 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfds18 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfds19 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfds20 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfds21 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfds22 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfds23 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upds1 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upds2 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upds3 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upds4 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upds5 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upds6 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upds7 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upds8 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upds9 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upds10 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upds11 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upds12 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upds13 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upds14 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upds15 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upds16 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upds17 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upds18 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upds19 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upds20 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upds21 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upds22 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upds23 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secds1 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secds2 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secds3 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secds4 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secds5 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secds6 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secds7 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secds8 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secds9 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secds10 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secds11 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secds12 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secds13 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secds14 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secds15 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secds16 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secds17 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secds18 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secds19 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secds20 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secds21 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secds22 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secds23 = String.Empty;
		
		
		///一对多关系,如果
		private bool m_Loaded=false;
		#endregion
		
		#region 属性枚举
		public struct Fields
		{
			public const string DriverScoreId=@"DriverScoreId";
			public const string DateSpan=@"DateSpan";
			public const string EvaluateLevelId=@"EvaluateLevelId";
			public const string TotalScore=@"TotalScore";
			public const string UpViews=@"UpViews";
			public const string YearId=@"YearId";
			public const string MonthId=@"MonthId";
			public const string EmployeeId=@"EmployeeId";
			public const string IsSubmit=@"IsSubmit";
			public const string Selfds1=@"Selfds1";
			public const string Selfds2=@"Selfds2";
			public const string Selfds3=@"Selfds3";
			public const string Selfds4=@"Selfds4";
			public const string Selfds5=@"Selfds5";
			public const string Selfds6=@"Selfds6";
			public const string Selfds7=@"Selfds7";
			public const string Selfds8=@"Selfds8";
			public const string Selfds9=@"Selfds9";
			public const string Selfds10=@"Selfds10";
			public const string Selfds11=@"Selfds11";
			public const string Selfds12=@"Selfds12";
			public const string Selfds13=@"Selfds13";
			public const string Selfds14=@"Selfds14";
			public const string Selfds15=@"Selfds15";
			public const string Selfds16=@"Selfds16";
			public const string Selfds17=@"Selfds17";
			public const string Selfds18=@"Selfds18";
			public const string Selfds19=@"Selfds19";
			public const string Selfds20=@"Selfds20";
			public const string Selfds21=@"Selfds21";
			public const string Selfds22=@"Selfds22";
			public const string Selfds23=@"Selfds23";
			public const string Upds1=@"Upds1";
			public const string Upds2=@"Upds2";
			public const string Upds3=@"Upds3";
			public const string Upds4=@"Upds4";
			public const string Upds5=@"Upds5";
			public const string Upds6=@"Upds6";
			public const string Upds7=@"Upds7";
			public const string Upds8=@"Upds8";
			public const string Upds9=@"Upds9";
			public const string Upds10=@"Upds10";
			public const string Upds11=@"Upds11";
			public const string Upds12=@"Upds12";
			public const string Upds13=@"Upds13";
			public const string Upds14=@"Upds14";
			public const string Upds15=@"Upds15";
			public const string Upds16=@"Upds16";
			public const string Upds17=@"Upds17";
			public const string Upds18=@"Upds18";
			public const string Upds19=@"Upds19";
			public const string Upds20=@"Upds20";
			public const string Upds21=@"Upds21";
			public const string Upds22=@"Upds22";
			public const string Upds23=@"Upds23";
			public const string Secds1=@"Secds1";
			public const string Secds2=@"Secds2";
			public const string Secds3=@"Secds3";
			public const string Secds4=@"Secds4";
			public const string Secds5=@"Secds5";
			public const string Secds6=@"Secds6";
			public const string Secds7=@"Secds7";
			public const string Secds8=@"Secds8";
			public const string Secds9=@"Secds9";
			public const string Secds10=@"Secds10";
			public const string Secds11=@"Secds11";
			public const string Secds12=@"Secds12";
			public const string Secds13=@"Secds13";
			public const string Secds14=@"Secds14";
			public const string Secds15=@"Secds15";
			public const string Secds16=@"Secds16";
			public const string Secds17=@"Secds17";
			public const string Secds18=@"Secds18";
			public const string Secds19=@"Secds19";
			public const string Secds20=@"Secds20";
			public const string Secds21=@"Secds21";
			public const string Secds22=@"Secds22";
			public const string Secds23=@"Secds23";
						
		}

		#endregion
		
		
		#region 构造函数
		///<summary>
		///
		///</summary>
		public DriverScoreInfo()
		{
		}
		///<summary>
		///
		///</summary>
		public DriverScoreInfo(int pDriverScoreId,string pDateSpan,int? pEvaluateLevelId,string pTotalScore,string pUpViews,int? pYearId,int? pMonthId,int? pEmployeeId,int? pIsSubmit,string pSelfds1,string pSelfds2,string pSelfds3,string pSelfds4,string pSelfds5,string pSelfds6,string pSelfds7,string pSelfds8,string pSelfds9,string pSelfds10,string pSelfds11,string pSelfds12,string pSelfds13,string pSelfds14,string pSelfds15,string pSelfds16,string pSelfds17,string pSelfds18,string pSelfds19,string pSelfds20,string pSelfds21,string pSelfds22,string pSelfds23,string pUpds1,string pUpds2,string pUpds3,string pUpds4,string pUpds5,string pUpds6,string pUpds7,string pUpds8,string pUpds9,string pUpds10,string pUpds11,string pUpds12,string pUpds13,string pUpds14,string pUpds15,string pUpds16,string pUpds17,string pUpds18,string pUpds19,string pUpds20,string pUpds21,string pUpds22,string pUpds23,string pSecds1,string pSecds2,string pSecds3,string pSecds4,string pSecds5,string pSecds6,string pSecds7,string pSecds8,string pSecds9,string pSecds10,string pSecds11,string pSecds12,string pSecds13,string pSecds14,string pSecds15,string pSecds16,string pSecds17,string pSecds18,string pSecds19,string pSecds20,string pSecds21,string pSecds22,string pSecds23)
		{
			driverScoreId   = pDriverScoreId;
			dateSpan        = pDateSpan;
			evaluateLevelId = pEvaluateLevelId;
			totalScore      = pTotalScore;
			upViews         = pUpViews;
			yearId          = pYearId;
			monthId         = pMonthId;
			employeeId      = pEmployeeId;
			isSubmit        = pIsSubmit;
			selfds1         = pSelfds1;
			selfds2         = pSelfds2;
			selfds3         = pSelfds3;
			selfds4         = pSelfds4;
			selfds5         = pSelfds5;
			selfds6         = pSelfds6;
			selfds7         = pSelfds7;
			selfds8         = pSelfds8;
			selfds9         = pSelfds9;
			selfds10        = pSelfds10;
			selfds11        = pSelfds11;
			selfds12        = pSelfds12;
			selfds13        = pSelfds13;
			selfds14        = pSelfds14;
			selfds15        = pSelfds15;
			selfds16        = pSelfds16;
			selfds17        = pSelfds17;
			selfds18        = pSelfds18;
			selfds19        = pSelfds19;
			selfds20        = pSelfds20;
			selfds21        = pSelfds21;
			selfds22        = pSelfds22;
			selfds23        = pSelfds23;
			upds1           = pUpds1;
			upds2           = pUpds2;
			upds3           = pUpds3;
			upds4           = pUpds4;
			upds5           = pUpds5;
			upds6           = pUpds6;
			upds7           = pUpds7;
			upds8           = pUpds8;
			upds9           = pUpds9;
			upds10          = pUpds10;
			upds11          = pUpds11;
			upds12          = pUpds12;
			upds13          = pUpds13;
			upds14          = pUpds14;
			upds15          = pUpds15;
			upds16          = pUpds16;
			upds17          = pUpds17;
			upds18          = pUpds18;
			upds19          = pUpds19;
			upds20          = pUpds20;
			upds21          = pUpds21;
			upds22          = pUpds22;
			upds23          = pUpds23;
			secds1          = pSecds1;
			secds2          = pSecds2;
			secds3          = pSecds3;
			secds4          = pSecds4;
			secds5          = pSecds5;
			secds6          = pSecds6;
			secds7          = pSecds7;
			secds8          = pSecds8;
			secds9          = pSecds9;
			secds10         = pSecds10;
			secds11         = pSecds11;
			secds12         = pSecds12;
			secds13         = pSecds13;
			secds14         = pSecds14;
			secds15         = pSecds15;
			secds16         = pSecds16;
			secds17         = pSecds17;
			secds18         = pSecds18;
			secds19         = pSecds19;
			secds20         = pSecds20;
			secds21         = pSecds21;
			secds22         = pSecds22;
			secds23         = pSecds23;
			
		}
		
		
		///<summary>
		///
		///</summary>
		public DriverScoreInfo(int driverScoreId)
		{
			 LoadFromId(driverScoreId);
		}
		
		private void LoadFromId(int driverScoreId)
		{
		 
			if (CachedEntityCommander.IsTypeRegistered(typeof(DriverScoreInfo)))
            {
				DriverScoreInfo driverScoreInfo=Find(GetList(), driverScoreId);
				if(driverScoreInfo==null)
					throw new AppException("未能在缓存中找到相应的键值对象");
                Copy(driverScoreInfo, this);
            }
            else
            {	DriverScore driverScore=new DriverScore( driverScoreId);	
				if(driverScore.IsNew)
				throw new AppException("尚未初始化");
               	LoadFromDAL(this, driverScore);
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
        public static  DriverScoreInfo Find(List< DriverScoreInfo> list,  int driverScoreId)
        {
             return list.Find(delegate( DriverScoreInfo item) { return item. driverScoreId==driverScoreId; });
        }
		
		
		/// <summary>
        /// 得到缓存键
        /// </summary>
        /// <returns></returns>
        private static string GetCacheKey()
        {
            return string.Format(CachedEntityCommander.CacheKey, typeof( DriverScoreInfo).ToString());
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
        public static void Copy(DriverScoreInfo pDriverScoreInfoFrom, DriverScoreInfo pDriverScoreInfoTo)
        {
	 		pDriverScoreInfoTo.DriverScoreId = pDriverScoreInfoFrom.driverScoreId;
	 		pDriverScoreInfoTo.DateSpan = pDriverScoreInfoFrom.dateSpan;
	 		pDriverScoreInfoTo.EvaluateLevelId = pDriverScoreInfoFrom.evaluateLevelId;
	 		pDriverScoreInfoTo.TotalScore = pDriverScoreInfoFrom.totalScore;
	 		pDriverScoreInfoTo.UpViews = pDriverScoreInfoFrom.upViews;
	 		pDriverScoreInfoTo.YearId = pDriverScoreInfoFrom.yearId;
	 		pDriverScoreInfoTo.MonthId = pDriverScoreInfoFrom.monthId;
	 		pDriverScoreInfoTo.EmployeeId = pDriverScoreInfoFrom.employeeId;
	 		pDriverScoreInfoTo.IsSubmit = pDriverScoreInfoFrom.isSubmit;
	 		pDriverScoreInfoTo.Selfds1 = pDriverScoreInfoFrom.selfds1;
	 		pDriverScoreInfoTo.Selfds2 = pDriverScoreInfoFrom.selfds2;
	 		pDriverScoreInfoTo.Selfds3 = pDriverScoreInfoFrom.selfds3;
	 		pDriverScoreInfoTo.Selfds4 = pDriverScoreInfoFrom.selfds4;
	 		pDriverScoreInfoTo.Selfds5 = pDriverScoreInfoFrom.selfds5;
	 		pDriverScoreInfoTo.Selfds6 = pDriverScoreInfoFrom.selfds6;
	 		pDriverScoreInfoTo.Selfds7 = pDriverScoreInfoFrom.selfds7;
	 		pDriverScoreInfoTo.Selfds8 = pDriverScoreInfoFrom.selfds8;
	 		pDriverScoreInfoTo.Selfds9 = pDriverScoreInfoFrom.selfds9;
	 		pDriverScoreInfoTo.Selfds10 = pDriverScoreInfoFrom.selfds10;
	 		pDriverScoreInfoTo.Selfds11 = pDriverScoreInfoFrom.selfds11;
	 		pDriverScoreInfoTo.Selfds12 = pDriverScoreInfoFrom.selfds12;
	 		pDriverScoreInfoTo.Selfds13 = pDriverScoreInfoFrom.selfds13;
	 		pDriverScoreInfoTo.Selfds14 = pDriverScoreInfoFrom.selfds14;
	 		pDriverScoreInfoTo.Selfds15 = pDriverScoreInfoFrom.selfds15;
	 		pDriverScoreInfoTo.Selfds16 = pDriverScoreInfoFrom.selfds16;
	 		pDriverScoreInfoTo.Selfds17 = pDriverScoreInfoFrom.selfds17;
	 		pDriverScoreInfoTo.Selfds18 = pDriverScoreInfoFrom.selfds18;
	 		pDriverScoreInfoTo.Selfds19 = pDriverScoreInfoFrom.selfds19;
	 		pDriverScoreInfoTo.Selfds20 = pDriverScoreInfoFrom.selfds20;
	 		pDriverScoreInfoTo.Selfds21 = pDriverScoreInfoFrom.selfds21;
	 		pDriverScoreInfoTo.Selfds22 = pDriverScoreInfoFrom.selfds22;
	 		pDriverScoreInfoTo.Selfds23 = pDriverScoreInfoFrom.selfds23;
	 		pDriverScoreInfoTo.Upds1 = pDriverScoreInfoFrom.upds1;
	 		pDriverScoreInfoTo.Upds2 = pDriverScoreInfoFrom.upds2;
	 		pDriverScoreInfoTo.Upds3 = pDriverScoreInfoFrom.upds3;
	 		pDriverScoreInfoTo.Upds4 = pDriverScoreInfoFrom.upds4;
	 		pDriverScoreInfoTo.Upds5 = pDriverScoreInfoFrom.upds5;
	 		pDriverScoreInfoTo.Upds6 = pDriverScoreInfoFrom.upds6;
	 		pDriverScoreInfoTo.Upds7 = pDriverScoreInfoFrom.upds7;
	 		pDriverScoreInfoTo.Upds8 = pDriverScoreInfoFrom.upds8;
	 		pDriverScoreInfoTo.Upds9 = pDriverScoreInfoFrom.upds9;
	 		pDriverScoreInfoTo.Upds10 = pDriverScoreInfoFrom.upds10;
	 		pDriverScoreInfoTo.Upds11 = pDriverScoreInfoFrom.upds11;
	 		pDriverScoreInfoTo.Upds12 = pDriverScoreInfoFrom.upds12;
	 		pDriverScoreInfoTo.Upds13 = pDriverScoreInfoFrom.upds13;
	 		pDriverScoreInfoTo.Upds14 = pDriverScoreInfoFrom.upds14;
	 		pDriverScoreInfoTo.Upds15 = pDriverScoreInfoFrom.upds15;
	 		pDriverScoreInfoTo.Upds16 = pDriverScoreInfoFrom.upds16;
	 		pDriverScoreInfoTo.Upds17 = pDriverScoreInfoFrom.upds17;
	 		pDriverScoreInfoTo.Upds18 = pDriverScoreInfoFrom.upds18;
	 		pDriverScoreInfoTo.Upds19 = pDriverScoreInfoFrom.upds19;
	 		pDriverScoreInfoTo.Upds20 = pDriverScoreInfoFrom.upds20;
	 		pDriverScoreInfoTo.Upds21 = pDriverScoreInfoFrom.upds21;
	 		pDriverScoreInfoTo.Upds22 = pDriverScoreInfoFrom.upds22;
	 		pDriverScoreInfoTo.Upds23 = pDriverScoreInfoFrom.upds23;
	 		pDriverScoreInfoTo.Secds1 = pDriverScoreInfoFrom.secds1;
	 		pDriverScoreInfoTo.Secds2 = pDriverScoreInfoFrom.secds2;
	 		pDriverScoreInfoTo.Secds3 = pDriverScoreInfoFrom.secds3;
	 		pDriverScoreInfoTo.Secds4 = pDriverScoreInfoFrom.secds4;
	 		pDriverScoreInfoTo.Secds5 = pDriverScoreInfoFrom.secds5;
	 		pDriverScoreInfoTo.Secds6 = pDriverScoreInfoFrom.secds6;
	 		pDriverScoreInfoTo.Secds7 = pDriverScoreInfoFrom.secds7;
	 		pDriverScoreInfoTo.Secds8 = pDriverScoreInfoFrom.secds8;
	 		pDriverScoreInfoTo.Secds9 = pDriverScoreInfoFrom.secds9;
	 		pDriverScoreInfoTo.Secds10 = pDriverScoreInfoFrom.secds10;
	 		pDriverScoreInfoTo.Secds11 = pDriverScoreInfoFrom.secds11;
	 		pDriverScoreInfoTo.Secds12 = pDriverScoreInfoFrom.secds12;
	 		pDriverScoreInfoTo.Secds13 = pDriverScoreInfoFrom.secds13;
	 		pDriverScoreInfoTo.Secds14 = pDriverScoreInfoFrom.secds14;
	 		pDriverScoreInfoTo.Secds15 = pDriverScoreInfoFrom.secds15;
	 		pDriverScoreInfoTo.Secds16 = pDriverScoreInfoFrom.secds16;
	 		pDriverScoreInfoTo.Secds17 = pDriverScoreInfoFrom.secds17;
	 		pDriverScoreInfoTo.Secds18 = pDriverScoreInfoFrom.secds18;
	 		pDriverScoreInfoTo.Secds19 = pDriverScoreInfoFrom.secds19;
	 		pDriverScoreInfoTo.Secds20 = pDriverScoreInfoFrom.secds20;
	 		pDriverScoreInfoTo.Secds21 = pDriverScoreInfoFrom.secds21;
	 		pDriverScoreInfoTo.Secds22 = pDriverScoreInfoFrom.secds22;
	 		pDriverScoreInfoTo.Secds23 = pDriverScoreInfoFrom.secds23;
			pDriverScoreInfoTo.Loaded=pDriverScoreInfoFrom.Loaded;
        }
		
		/// <summary>
		/// 批量装载
		/// </summary>
		internal static void LoadFromDALPatch(List< DriverScoreInfo> pList, DriverScoreCollection pCollection)
        {
            foreach (DriverScore driverScore in pCollection)
            {
                DriverScoreInfo driverScoreInfo = new DriverScoreInfo();
                LoadFromDAL(driverScoreInfo, driverScore );
                pList.Add(driverScoreInfo);
            }
			
        }

		//从后台获取数据
		internal  static void  LoadFromDAL(DriverScoreInfo pDriverScoreInfo, DriverScore  pDriverScore)
		{
	 		pDriverScoreInfo.driverScoreId = pDriverScore.DriverScoreId;
	 		pDriverScoreInfo.dateSpan = pDriverScore.DateSpan;
	 		pDriverScoreInfo.evaluateLevelId = pDriverScore.EvaluateLevelId;
	 		pDriverScoreInfo.totalScore = pDriverScore.TotalScore;
	 		pDriverScoreInfo.upViews = pDriverScore.UpViews;
	 		pDriverScoreInfo.yearId = pDriverScore.YearId;
	 		pDriverScoreInfo.monthId = pDriverScore.MonthId;
	 		pDriverScoreInfo.employeeId = pDriverScore.EmployeeId;
	 		pDriverScoreInfo.isSubmit = pDriverScore.IsSubmit;
	 		pDriverScoreInfo.selfds1 = pDriverScore.Selfds1;
	 		pDriverScoreInfo.selfds2 = pDriverScore.Selfds2;
	 		pDriverScoreInfo.selfds3 = pDriverScore.Selfds3;
	 		pDriverScoreInfo.selfds4 = pDriverScore.Selfds4;
	 		pDriverScoreInfo.selfds5 = pDriverScore.Selfds5;
	 		pDriverScoreInfo.selfds6 = pDriverScore.Selfds6;
	 		pDriverScoreInfo.selfds7 = pDriverScore.Selfds7;
	 		pDriverScoreInfo.selfds8 = pDriverScore.Selfds8;
	 		pDriverScoreInfo.selfds9 = pDriverScore.Selfds9;
	 		pDriverScoreInfo.selfds10 = pDriverScore.Selfds10;
	 		pDriverScoreInfo.selfds11 = pDriverScore.Selfds11;
	 		pDriverScoreInfo.selfds12 = pDriverScore.Selfds12;
	 		pDriverScoreInfo.selfds13 = pDriverScore.Selfds13;
	 		pDriverScoreInfo.selfds14 = pDriverScore.Selfds14;
	 		pDriverScoreInfo.selfds15 = pDriverScore.Selfds15;
	 		pDriverScoreInfo.selfds16 = pDriverScore.Selfds16;
	 		pDriverScoreInfo.selfds17 = pDriverScore.Selfds17;
	 		pDriverScoreInfo.selfds18 = pDriverScore.Selfds18;
	 		pDriverScoreInfo.selfds19 = pDriverScore.Selfds19;
	 		pDriverScoreInfo.selfds20 = pDriverScore.Selfds20;
	 		pDriverScoreInfo.selfds21 = pDriverScore.Selfds21;
	 		pDriverScoreInfo.selfds22 = pDriverScore.Selfds22;
	 		pDriverScoreInfo.selfds23 = pDriverScore.Selfds23;
	 		pDriverScoreInfo.upds1 = pDriverScore.Upds1;
	 		pDriverScoreInfo.upds2 = pDriverScore.Upds2;
	 		pDriverScoreInfo.upds3 = pDriverScore.Upds3;
	 		pDriverScoreInfo.upds4 = pDriverScore.Upds4;
	 		pDriverScoreInfo.upds5 = pDriverScore.Upds5;
	 		pDriverScoreInfo.upds6 = pDriverScore.Upds6;
	 		pDriverScoreInfo.upds7 = pDriverScore.Upds7;
	 		pDriverScoreInfo.upds8 = pDriverScore.Upds8;
	 		pDriverScoreInfo.upds9 = pDriverScore.Upds9;
	 		pDriverScoreInfo.upds10 = pDriverScore.Upds10;
	 		pDriverScoreInfo.upds11 = pDriverScore.Upds11;
	 		pDriverScoreInfo.upds12 = pDriverScore.Upds12;
	 		pDriverScoreInfo.upds13 = pDriverScore.Upds13;
	 		pDriverScoreInfo.upds14 = pDriverScore.Upds14;
	 		pDriverScoreInfo.upds15 = pDriverScore.Upds15;
	 		pDriverScoreInfo.upds16 = pDriverScore.Upds16;
	 		pDriverScoreInfo.upds17 = pDriverScore.Upds17;
	 		pDriverScoreInfo.upds18 = pDriverScore.Upds18;
	 		pDriverScoreInfo.upds19 = pDriverScore.Upds19;
	 		pDriverScoreInfo.upds20 = pDriverScore.Upds20;
	 		pDriverScoreInfo.upds21 = pDriverScore.Upds21;
	 		pDriverScoreInfo.upds22 = pDriverScore.Upds22;
	 		pDriverScoreInfo.upds23 = pDriverScore.Upds23;
	 		pDriverScoreInfo.secds1 = pDriverScore.Secds1;
	 		pDriverScoreInfo.secds2 = pDriverScore.Secds2;
	 		pDriverScoreInfo.secds3 = pDriverScore.Secds3;
	 		pDriverScoreInfo.secds4 = pDriverScore.Secds4;
	 		pDriverScoreInfo.secds5 = pDriverScore.Secds5;
	 		pDriverScoreInfo.secds6 = pDriverScore.Secds6;
	 		pDriverScoreInfo.secds7 = pDriverScore.Secds7;
	 		pDriverScoreInfo.secds8 = pDriverScore.Secds8;
	 		pDriverScoreInfo.secds9 = pDriverScore.Secds9;
	 		pDriverScoreInfo.secds10 = pDriverScore.Secds10;
	 		pDriverScoreInfo.secds11 = pDriverScore.Secds11;
	 		pDriverScoreInfo.secds12 = pDriverScore.Secds12;
	 		pDriverScoreInfo.secds13 = pDriverScore.Secds13;
	 		pDriverScoreInfo.secds14 = pDriverScore.Secds14;
	 		pDriverScoreInfo.secds15 = pDriverScore.Secds15;
	 		pDriverScoreInfo.secds16 = pDriverScore.Secds16;
	 		pDriverScoreInfo.secds17 = pDriverScore.Secds17;
	 		pDriverScoreInfo.secds18 = pDriverScore.Secds18;
	 		pDriverScoreInfo.secds19 = pDriverScore.Secds19;
	 		pDriverScoreInfo.secds20 = pDriverScore.Secds20;
	 		pDriverScoreInfo.secds21 = pDriverScore.Secds21;
	 		pDriverScoreInfo.secds22 = pDriverScore.Secds22;
	 		pDriverScoreInfo.secds23 = pDriverScore.Secds23;
			pDriverScoreInfo.Loaded=true;
			
			}
		
		//数据持久化
		internal  static void  SaveToDb(DriverScoreInfo pDriverScoreInfo, DriverScore  pDriverScore,bool pIsNew)
		{
	 		pDriverScore.DriverScoreId = pDriverScoreInfo.driverScoreId;
	 		pDriverScore.DateSpan = pDriverScoreInfo.dateSpan;
	 		pDriverScore.EvaluateLevelId = pDriverScoreInfo.evaluateLevelId;
	 		pDriverScore.TotalScore = pDriverScoreInfo.totalScore;
	 		pDriverScore.UpViews = pDriverScoreInfo.upViews;
	 		pDriverScore.YearId = pDriverScoreInfo.yearId;
	 		pDriverScore.MonthId = pDriverScoreInfo.monthId;
	 		pDriverScore.EmployeeId = pDriverScoreInfo.employeeId;
	 		pDriverScore.IsSubmit = pDriverScoreInfo.isSubmit;
	 		pDriverScore.Selfds1 = pDriverScoreInfo.selfds1;
	 		pDriverScore.Selfds2 = pDriverScoreInfo.selfds2;
	 		pDriverScore.Selfds3 = pDriverScoreInfo.selfds3;
	 		pDriverScore.Selfds4 = pDriverScoreInfo.selfds4;
	 		pDriverScore.Selfds5 = pDriverScoreInfo.selfds5;
	 		pDriverScore.Selfds6 = pDriverScoreInfo.selfds6;
	 		pDriverScore.Selfds7 = pDriverScoreInfo.selfds7;
	 		pDriverScore.Selfds8 = pDriverScoreInfo.selfds8;
	 		pDriverScore.Selfds9 = pDriverScoreInfo.selfds9;
	 		pDriverScore.Selfds10 = pDriverScoreInfo.selfds10;
	 		pDriverScore.Selfds11 = pDriverScoreInfo.selfds11;
	 		pDriverScore.Selfds12 = pDriverScoreInfo.selfds12;
	 		pDriverScore.Selfds13 = pDriverScoreInfo.selfds13;
	 		pDriverScore.Selfds14 = pDriverScoreInfo.selfds14;
	 		pDriverScore.Selfds15 = pDriverScoreInfo.selfds15;
	 		pDriverScore.Selfds16 = pDriverScoreInfo.selfds16;
	 		pDriverScore.Selfds17 = pDriverScoreInfo.selfds17;
	 		pDriverScore.Selfds18 = pDriverScoreInfo.selfds18;
	 		pDriverScore.Selfds19 = pDriverScoreInfo.selfds19;
	 		pDriverScore.Selfds20 = pDriverScoreInfo.selfds20;
	 		pDriverScore.Selfds21 = pDriverScoreInfo.selfds21;
	 		pDriverScore.Selfds22 = pDriverScoreInfo.selfds22;
	 		pDriverScore.Selfds23 = pDriverScoreInfo.selfds23;
	 		pDriverScore.Upds1 = pDriverScoreInfo.upds1;
	 		pDriverScore.Upds2 = pDriverScoreInfo.upds2;
	 		pDriverScore.Upds3 = pDriverScoreInfo.upds3;
	 		pDriverScore.Upds4 = pDriverScoreInfo.upds4;
	 		pDriverScore.Upds5 = pDriverScoreInfo.upds5;
	 		pDriverScore.Upds6 = pDriverScoreInfo.upds6;
	 		pDriverScore.Upds7 = pDriverScoreInfo.upds7;
	 		pDriverScore.Upds8 = pDriverScoreInfo.upds8;
	 		pDriverScore.Upds9 = pDriverScoreInfo.upds9;
	 		pDriverScore.Upds10 = pDriverScoreInfo.upds10;
	 		pDriverScore.Upds11 = pDriverScoreInfo.upds11;
	 		pDriverScore.Upds12 = pDriverScoreInfo.upds12;
	 		pDriverScore.Upds13 = pDriverScoreInfo.upds13;
	 		pDriverScore.Upds14 = pDriverScoreInfo.upds14;
	 		pDriverScore.Upds15 = pDriverScoreInfo.upds15;
	 		pDriverScore.Upds16 = pDriverScoreInfo.upds16;
	 		pDriverScore.Upds17 = pDriverScoreInfo.upds17;
	 		pDriverScore.Upds18 = pDriverScoreInfo.upds18;
	 		pDriverScore.Upds19 = pDriverScoreInfo.upds19;
	 		pDriverScore.Upds20 = pDriverScoreInfo.upds20;
	 		pDriverScore.Upds21 = pDriverScoreInfo.upds21;
	 		pDriverScore.Upds22 = pDriverScoreInfo.upds22;
	 		pDriverScore.Upds23 = pDriverScoreInfo.upds23;
	 		pDriverScore.Secds1 = pDriverScoreInfo.secds1;
	 		pDriverScore.Secds2 = pDriverScoreInfo.secds2;
	 		pDriverScore.Secds3 = pDriverScoreInfo.secds3;
	 		pDriverScore.Secds4 = pDriverScoreInfo.secds4;
	 		pDriverScore.Secds5 = pDriverScoreInfo.secds5;
	 		pDriverScore.Secds6 = pDriverScoreInfo.secds6;
	 		pDriverScore.Secds7 = pDriverScoreInfo.secds7;
	 		pDriverScore.Secds8 = pDriverScoreInfo.secds8;
	 		pDriverScore.Secds9 = pDriverScoreInfo.secds9;
	 		pDriverScore.Secds10 = pDriverScoreInfo.secds10;
	 		pDriverScore.Secds11 = pDriverScoreInfo.secds11;
	 		pDriverScore.Secds12 = pDriverScoreInfo.secds12;
	 		pDriverScore.Secds13 = pDriverScoreInfo.secds13;
	 		pDriverScore.Secds14 = pDriverScoreInfo.secds14;
	 		pDriverScore.Secds15 = pDriverScoreInfo.secds15;
	 		pDriverScore.Secds16 = pDriverScoreInfo.secds16;
	 		pDriverScore.Secds17 = pDriverScoreInfo.secds17;
	 		pDriverScore.Secds18 = pDriverScoreInfo.secds18;
	 		pDriverScore.Secds19 = pDriverScoreInfo.secds19;
	 		pDriverScore.Secds20 = pDriverScoreInfo.secds20;
	 		pDriverScore.Secds21 = pDriverScoreInfo.secds21;
	 		pDriverScore.Secds22 = pDriverScoreInfo.secds22;
	 		pDriverScore.Secds23 = pDriverScoreInfo.secds23;
			pDriverScore.IsNew=pIsNew;
			string UserName = SubsonicHelper.GetUserName();
			try
			{
				pDriverScore.Save(UserName);
			}
			catch(Exception ex)
			{
				LogManager.getInstance().getLogger(typeof(DriverScoreInfo)).Error(ex);
				if(ex.Message.Contains("插入重复键"))//违反了唯一键
				{
					throw new AppException("此对象已经存在");//此处等待优化可以从唯一约束中直接取出提示来，如果没有的话，默认为原始的出错提示
				}
				throw new AppException("保存失败");
			}
			pDriverScoreInfo.driverScoreId = pDriverScore.DriverScoreId;
			//如果缓存存在，更新缓存
			if (CachedEntityCommander.IsTypeRegistered(typeof(DriverScoreInfo))) 
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
        public static List< DriverScoreInfo> GetPagedList(int pPageIndex,int pPageSize,SortDirection pOrderBy,string pSortExpression,out int pRecordCount)
        {
			if(pPageIndex<=1)
			pPageIndex=1;
            List< DriverScoreInfo> list = new List< DriverScoreInfo>();
          
            Query q = DriverScore .CreateQuery();
            q.PageIndex = pPageIndex;
            q.PageSize = pPageSize;
            q.ORDER_BY(pSortExpression,pOrderBy.ToString());
			DriverScoreCollection  collection=new  DriverScoreCollection();
		 	collection.LoadAndCloseReader(q.ExecuteReader());
          
            foreach (DriverScore  driverScore  in collection)
            {
                DriverScoreInfo driverScoreInfo = new DriverScoreInfo();
                LoadFromDAL(driverScoreInfo,   driverScore);
                list.Add(driverScoreInfo);
            }
			pRecordCount=q.GetRecordCount();
			
            return list;

        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		/// <returns></returns>
		public static List< DriverScoreInfo> GetList()
		{
			string cacheKey = GetCacheKey();
			//本实体已经注册成缓存实体，并且缓存存在的时候，直接从缓存取
			if (CachedEntityCommander.IsTypeRegistered(typeof(DriverScoreInfo)) && CachedEntityCommander.GetCache(cacheKey) != null)
            {
                return CachedEntityCommander.GetCache(cacheKey) as List< DriverScoreInfo>;
            }
            else 
            {
				List< DriverScoreInfo>  list =new List< DriverScoreInfo>();
				DriverScoreCollection  collection=new  DriverScoreCollection();
				Query qry = new Query(DriverScore.Schema);
				collection.LoadAndCloseReader(qry.ExecuteReader());
				foreach(DriverScore driverScore in collection)
				{
					DriverScoreInfo driverScoreInfo= new DriverScoreInfo();
					LoadFromDAL(driverScoreInfo,driverScore);
					list.Add(driverScoreInfo);
				}
			  	//生成缓存
                if (CachedEntityCommander.IsTypeRegistered(typeof(DriverScoreInfo))) 
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
		public int DriverScoreId
		{
			get {return driverScoreId;}
			set {driverScoreId = value;}
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
		public string Selfds1
		{
			get {return selfds1;}
			set {selfds1 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfds2
		{
			get {return selfds2;}
			set {selfds2 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfds3
		{
			get {return selfds3;}
			set {selfds3 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfds4
		{
			get {return selfds4;}
			set {selfds4 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfds5
		{
			get {return selfds5;}
			set {selfds5 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfds6
		{
			get {return selfds6;}
			set {selfds6 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfds7
		{
			get {return selfds7;}
			set {selfds7 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfds8
		{
			get {return selfds8;}
			set {selfds8 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfds9
		{
			get {return selfds9;}
			set {selfds9 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfds10
		{
			get {return selfds10;}
			set {selfds10 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfds11
		{
			get {return selfds11;}
			set {selfds11 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfds12
		{
			get {return selfds12;}
			set {selfds12 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfds13
		{
			get {return selfds13;}
			set {selfds13 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfds14
		{
			get {return selfds14;}
			set {selfds14 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfds15
		{
			get {return selfds15;}
			set {selfds15 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfds16
		{
			get {return selfds16;}
			set {selfds16 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfds17
		{
			get {return selfds17;}
			set {selfds17 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfds18
		{
			get {return selfds18;}
			set {selfds18 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfds19
		{
			get {return selfds19;}
			set {selfds19 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfds20
		{
			get {return selfds20;}
			set {selfds20 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfds21
		{
			get {return selfds21;}
			set {selfds21 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfds22
		{
			get {return selfds22;}
			set {selfds22 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfds23
		{
			get {return selfds23;}
			set {selfds23 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upds1
		{
			get {return upds1;}
			set {upds1 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upds2
		{
			get {return upds2;}
			set {upds2 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upds3
		{
			get {return upds3;}
			set {upds3 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upds4
		{
			get {return upds4;}
			set {upds4 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upds5
		{
			get {return upds5;}
			set {upds5 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upds6
		{
			get {return upds6;}
			set {upds6 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upds7
		{
			get {return upds7;}
			set {upds7 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upds8
		{
			get {return upds8;}
			set {upds8 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upds9
		{
			get {return upds9;}
			set {upds9 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upds10
		{
			get {return upds10;}
			set {upds10 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upds11
		{
			get {return upds11;}
			set {upds11 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upds12
		{
			get {return upds12;}
			set {upds12 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upds13
		{
			get {return upds13;}
			set {upds13 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upds14
		{
			get {return upds14;}
			set {upds14 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upds15
		{
			get {return upds15;}
			set {upds15 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upds16
		{
			get {return upds16;}
			set {upds16 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upds17
		{
			get {return upds17;}
			set {upds17 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upds18
		{
			get {return upds18;}
			set {upds18 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upds19
		{
			get {return upds19;}
			set {upds19 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upds20
		{
			get {return upds20;}
			set {upds20 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upds21
		{
			get {return upds21;}
			set {upds21 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upds22
		{
			get {return upds22;}
			set {upds22 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upds23
		{
			get {return upds23;}
			set {upds23 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secds1
		{
			get {return secds1;}
			set {secds1 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secds2
		{
			get {return secds2;}
			set {secds2 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secds3
		{
			get {return secds3;}
			set {secds3 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secds4
		{
			get {return secds4;}
			set {secds4 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secds5
		{
			get {return secds5;}
			set {secds5 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secds6
		{
			get {return secds6;}
			set {secds6 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secds7
		{
			get {return secds7;}
			set {secds7 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secds8
		{
			get {return secds8;}
			set {secds8 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secds9
		{
			get {return secds9;}
			set {secds9 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secds10
		{
			get {return secds10;}
			set {secds10 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secds11
		{
			get {return secds11;}
			set {secds11 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secds12
		{
			get {return secds12;}
			set {secds12 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secds13
		{
			get {return secds13;}
			set {secds13 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secds14
		{
			get {return secds14;}
			set {secds14 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secds15
		{
			get {return secds15;}
			set {secds15 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secds16
		{
			get {return secds16;}
			set {secds16 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secds17
		{
			get {return secds17;}
			set {secds17 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secds18
		{
			get {return secds18;}
			set {secds18 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secds19
		{
			get {return secds19;}
			set {secds19 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secds20
		{
			get {return secds20;}
			set {secds20 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secds21
		{
			get {return secds21;}
			set {secds21 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secds22
		{
			get {return secds22;}
			set {secds22 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secds23
		{
			get {return secds23;}
			set {secds23 = value;}
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
			bool result=  (DriverScore.Delete(DriverScoreId) == 1);
			//更新缓存
			if (result&&CachedEntityCommander.IsTypeRegistered(typeof(DriverScoreInfo))) 
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
        public void CopyTo(DriverScoreInfo pDriverScoreInfoTo)
        {
            Copy(this,  pDriverScoreInfoTo);
        }
		
		
		
		
		
		/// <summary>
		/// 保存
		/// </summary>
		public override void Save()
		{
			if(!m_Loaded)//新增
			{
				DriverScore driverScore=new DriverScore();	
				SaveToDb(this, driverScore,true);
			}
			else//修改
			{
				DriverScore driverScore=new DriverScore(driverScoreId);	
				if(driverScore.IsNew)
					throw new AppException("该数据已经不存在了");
				SaveToDb(this, driverScore,false);
			}
			
		}
		 
		#endregion
		
	}
}
