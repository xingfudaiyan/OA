// ======================================================================================================================================
// 类说明
//=======================================================================================================================================
// 创建者：sk @Copy Right 残友软件有限公司OA项目 
// 文件名：NurseScoreInfo.cs
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
	///NurseScoreInfo  Data
	/// </summary>
	[Serializable]
	public partial class NurseScoreInfo:CanYou.EntityObject
	{
		#region 属性
		///<summary>
		///
		///</summary>
		private int nurseScoreId;
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
		private string selfns1 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfns2 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfns3 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfns4 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfns5 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfns6 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfns7 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfns8 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfns9 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfns10 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfns11 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfns12 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfns13 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfns14 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfns15 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfns16 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfns17 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfns18 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfns19 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfns20 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfns21 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfns22 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfns23 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upns1 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upns2 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upns3 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upns4 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upns5 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upns6 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upns7 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upns8 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upns9 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upns10 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upns11 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upns12 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upns13 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upns14 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upns15 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upns16 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upns17 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upns18 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upns19 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upns20 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upns21 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upns22 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upns23 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secns1 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secns2 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secns3 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secns4 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secns5 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secns6 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secns7 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secns8 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secns9 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secns10 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secns11 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secns12 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secns13 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secns14 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secns15 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secns16 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secns17 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secns18 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secns19 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secns20 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secns21 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secns22 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secns23 = String.Empty;
		
		
		///一对多关系,如果
		private bool m_Loaded=false;
		#endregion
		
		#region 属性枚举
		public struct Fields
		{
			public const string NurseScoreId=@"NurseScoreId";
			public const string DateSpan=@"DateSpan";
			public const string EvaluateLevelId=@"EvaluateLevelId";
			public const string TotalScore=@"TotalScore";
			public const string UpViews=@"UpViews";
			public const string YearId=@"YearId";
			public const string MonthId=@"MonthId";
			public const string EmployeeId=@"EmployeeId";
			public const string IsSubmit=@"IsSubmit";
			public const string Selfns1=@"Selfns1";
			public const string Selfns2=@"Selfns2";
			public const string Selfns3=@"Selfns3";
			public const string Selfns4=@"Selfns4";
			public const string Selfns5=@"Selfns5";
			public const string Selfns6=@"Selfns6";
			public const string Selfns7=@"Selfns7";
			public const string Selfns8=@"Selfns8";
			public const string Selfns9=@"Selfns9";
			public const string Selfns10=@"Selfns10";
			public const string Selfns11=@"Selfns11";
			public const string Selfns12=@"Selfns12";
			public const string Selfns13=@"Selfns13";
			public const string Selfns14=@"Selfns14";
			public const string Selfns15=@"Selfns15";
			public const string Selfns16=@"Selfns16";
			public const string Selfns17=@"Selfns17";
			public const string Selfns18=@"Selfns18";
			public const string Selfns19=@"Selfns19";
			public const string Selfns20=@"Selfns20";
			public const string Selfns21=@"Selfns21";
			public const string Selfns22=@"Selfns22";
			public const string Selfns23=@"Selfns23";
			public const string Upns1=@"Upns1";
			public const string Upns2=@"Upns2";
			public const string Upns3=@"Upns3";
			public const string Upns4=@"Upns4";
			public const string Upns5=@"Upns5";
			public const string Upns6=@"Upns6";
			public const string Upns7=@"Upns7";
			public const string Upns8=@"Upns8";
			public const string Upns9=@"Upns9";
			public const string Upns10=@"Upns10";
			public const string Upns11=@"Upns11";
			public const string Upns12=@"Upns12";
			public const string Upns13=@"Upns13";
			public const string Upns14=@"Upns14";
			public const string Upns15=@"Upns15";
			public const string Upns16=@"Upns16";
			public const string Upns17=@"Upns17";
			public const string Upns18=@"Upns18";
			public const string Upns19=@"Upns19";
			public const string Upns20=@"Upns20";
			public const string Upns21=@"Upns21";
			public const string Upns22=@"Upns22";
			public const string Upns23=@"Upns23";
			public const string Secns1=@"Secns1";
			public const string Secns2=@"Secns2";
			public const string Secns3=@"Secns3";
			public const string Secns4=@"Secns4";
			public const string Secns5=@"Secns5";
			public const string Secns6=@"Secns6";
			public const string Secns7=@"Secns7";
			public const string Secns8=@"Secns8";
			public const string Secns9=@"Secns9";
			public const string Secns10=@"Secns10";
			public const string Secns11=@"Secns11";
			public const string Secns12=@"Secns12";
			public const string Secns13=@"Secns13";
			public const string Secns14=@"Secns14";
			public const string Secns15=@"Secns15";
			public const string Secns16=@"Secns16";
			public const string Secns17=@"Secns17";
			public const string Secns18=@"Secns18";
			public const string Secns19=@"Secns19";
			public const string Secns20=@"Secns20";
			public const string Secns21=@"Secns21";
			public const string Secns22=@"Secns22";
			public const string Secns23=@"Secns23";
						
		}

		#endregion
		
		
		#region 构造函数
		///<summary>
		///
		///</summary>
		public NurseScoreInfo()
		{
		}
		///<summary>
		///
		///</summary>
		public NurseScoreInfo(int pNurseScoreId,string pDateSpan,int? pEvaluateLevelId,string pTotalScore,string pUpViews,int? pYearId,int? pMonthId,int? pEmployeeId,int? pIsSubmit,string pSelfns1,string pSelfns2,string pSelfns3,string pSelfns4,string pSelfns5,string pSelfns6,string pSelfns7,string pSelfns8,string pSelfns9,string pSelfns10,string pSelfns11,string pSelfns12,string pSelfns13,string pSelfns14,string pSelfns15,string pSelfns16,string pSelfns17,string pSelfns18,string pSelfns19,string pSelfns20,string pSelfns21,string pSelfns22,string pSelfns23,string pUpns1,string pUpns2,string pUpns3,string pUpns4,string pUpns5,string pUpns6,string pUpns7,string pUpns8,string pUpns9,string pUpns10,string pUpns11,string pUpns12,string pUpns13,string pUpns14,string pUpns15,string pUpns16,string pUpns17,string pUpns18,string pUpns19,string pUpns20,string pUpns21,string pUpns22,string pUpns23,string pSecns1,string pSecns2,string pSecns3,string pSecns4,string pSecns5,string pSecns6,string pSecns7,string pSecns8,string pSecns9,string pSecns10,string pSecns11,string pSecns12,string pSecns13,string pSecns14,string pSecns15,string pSecns16,string pSecns17,string pSecns18,string pSecns19,string pSecns20,string pSecns21,string pSecns22,string pSecns23)
		{
			nurseScoreId    = pNurseScoreId;
			dateSpan        = pDateSpan;
			evaluateLevelId = pEvaluateLevelId;
			totalScore      = pTotalScore;
			upViews         = pUpViews;
			yearId          = pYearId;
			monthId         = pMonthId;
			employeeId      = pEmployeeId;
			isSubmit        = pIsSubmit;
			selfns1         = pSelfns1;
			selfns2         = pSelfns2;
			selfns3         = pSelfns3;
			selfns4         = pSelfns4;
			selfns5         = pSelfns5;
			selfns6         = pSelfns6;
			selfns7         = pSelfns7;
			selfns8         = pSelfns8;
			selfns9         = pSelfns9;
			selfns10        = pSelfns10;
			selfns11        = pSelfns11;
			selfns12        = pSelfns12;
			selfns13        = pSelfns13;
			selfns14        = pSelfns14;
			selfns15        = pSelfns15;
			selfns16        = pSelfns16;
			selfns17        = pSelfns17;
			selfns18        = pSelfns18;
			selfns19        = pSelfns19;
			selfns20        = pSelfns20;
			selfns21        = pSelfns21;
			selfns22        = pSelfns22;
			selfns23        = pSelfns23;
			upns1           = pUpns1;
			upns2           = pUpns2;
			upns3           = pUpns3;
			upns4           = pUpns4;
			upns5           = pUpns5;
			upns6           = pUpns6;
			upns7           = pUpns7;
			upns8           = pUpns8;
			upns9           = pUpns9;
			upns10          = pUpns10;
			upns11          = pUpns11;
			upns12          = pUpns12;
			upns13          = pUpns13;
			upns14          = pUpns14;
			upns15          = pUpns15;
			upns16          = pUpns16;
			upns17          = pUpns17;
			upns18          = pUpns18;
			upns19          = pUpns19;
			upns20          = pUpns20;
			upns21          = pUpns21;
			upns22          = pUpns22;
			upns23          = pUpns23;
			secns1          = pSecns1;
			secns2          = pSecns2;
			secns3          = pSecns3;
			secns4          = pSecns4;
			secns5          = pSecns5;
			secns6          = pSecns6;
			secns7          = pSecns7;
			secns8          = pSecns8;
			secns9          = pSecns9;
			secns10         = pSecns10;
			secns11         = pSecns11;
			secns12         = pSecns12;
			secns13         = pSecns13;
			secns14         = pSecns14;
			secns15         = pSecns15;
			secns16         = pSecns16;
			secns17         = pSecns17;
			secns18         = pSecns18;
			secns19         = pSecns19;
			secns20         = pSecns20;
			secns21         = pSecns21;
			secns22         = pSecns22;
			secns23         = pSecns23;
			
		}
		
		
		///<summary>
		///
		///</summary>
		public NurseScoreInfo(int nurseScoreId)
		{
			 LoadFromId(nurseScoreId);
		}
		
		private void LoadFromId(int nurseScoreId)
		{
		 
			if (CachedEntityCommander.IsTypeRegistered(typeof(NurseScoreInfo)))
            {
				NurseScoreInfo nurseScoreInfo=Find(GetList(), nurseScoreId);
				if(nurseScoreInfo==null)
					throw new AppException("未能在缓存中找到相应的键值对象");
                Copy(nurseScoreInfo, this);
            }
            else
            {	NurseScore nurseScore=new NurseScore( nurseScoreId);	
				if(nurseScore.IsNew)
				throw new AppException("尚未初始化");
               	LoadFromDAL(this, nurseScore);
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
        public static  NurseScoreInfo Find(List< NurseScoreInfo> list,  int nurseScoreId)
        {
             return list.Find(delegate( NurseScoreInfo item) { return item. nurseScoreId==nurseScoreId; });
        }
		
		
		/// <summary>
        /// 得到缓存键
        /// </summary>
        /// <returns></returns>
        private static string GetCacheKey()
        {
            return string.Format(CachedEntityCommander.CacheKey, typeof( NurseScoreInfo).ToString());
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
        public static void Copy(NurseScoreInfo pNurseScoreInfoFrom, NurseScoreInfo pNurseScoreInfoTo)
        {
	 		pNurseScoreInfoTo.NurseScoreId = pNurseScoreInfoFrom.nurseScoreId;
	 		pNurseScoreInfoTo.DateSpan = pNurseScoreInfoFrom.dateSpan;
	 		pNurseScoreInfoTo.EvaluateLevelId = pNurseScoreInfoFrom.evaluateLevelId;
	 		pNurseScoreInfoTo.TotalScore = pNurseScoreInfoFrom.totalScore;
	 		pNurseScoreInfoTo.UpViews = pNurseScoreInfoFrom.upViews;
	 		pNurseScoreInfoTo.YearId = pNurseScoreInfoFrom.yearId;
	 		pNurseScoreInfoTo.MonthId = pNurseScoreInfoFrom.monthId;
	 		pNurseScoreInfoTo.EmployeeId = pNurseScoreInfoFrom.employeeId;
	 		pNurseScoreInfoTo.IsSubmit = pNurseScoreInfoFrom.isSubmit;
	 		pNurseScoreInfoTo.Selfns1 = pNurseScoreInfoFrom.selfns1;
	 		pNurseScoreInfoTo.Selfns2 = pNurseScoreInfoFrom.selfns2;
	 		pNurseScoreInfoTo.Selfns3 = pNurseScoreInfoFrom.selfns3;
	 		pNurseScoreInfoTo.Selfns4 = pNurseScoreInfoFrom.selfns4;
	 		pNurseScoreInfoTo.Selfns5 = pNurseScoreInfoFrom.selfns5;
	 		pNurseScoreInfoTo.Selfns6 = pNurseScoreInfoFrom.selfns6;
	 		pNurseScoreInfoTo.Selfns7 = pNurseScoreInfoFrom.selfns7;
	 		pNurseScoreInfoTo.Selfns8 = pNurseScoreInfoFrom.selfns8;
	 		pNurseScoreInfoTo.Selfns9 = pNurseScoreInfoFrom.selfns9;
	 		pNurseScoreInfoTo.Selfns10 = pNurseScoreInfoFrom.selfns10;
	 		pNurseScoreInfoTo.Selfns11 = pNurseScoreInfoFrom.selfns11;
	 		pNurseScoreInfoTo.Selfns12 = pNurseScoreInfoFrom.selfns12;
	 		pNurseScoreInfoTo.Selfns13 = pNurseScoreInfoFrom.selfns13;
	 		pNurseScoreInfoTo.Selfns14 = pNurseScoreInfoFrom.selfns14;
	 		pNurseScoreInfoTo.Selfns15 = pNurseScoreInfoFrom.selfns15;
	 		pNurseScoreInfoTo.Selfns16 = pNurseScoreInfoFrom.selfns16;
	 		pNurseScoreInfoTo.Selfns17 = pNurseScoreInfoFrom.selfns17;
	 		pNurseScoreInfoTo.Selfns18 = pNurseScoreInfoFrom.selfns18;
	 		pNurseScoreInfoTo.Selfns19 = pNurseScoreInfoFrom.selfns19;
	 		pNurseScoreInfoTo.Selfns20 = pNurseScoreInfoFrom.selfns20;
	 		pNurseScoreInfoTo.Selfns21 = pNurseScoreInfoFrom.selfns21;
	 		pNurseScoreInfoTo.Selfns22 = pNurseScoreInfoFrom.selfns22;
	 		pNurseScoreInfoTo.Selfns23 = pNurseScoreInfoFrom.selfns23;
	 		pNurseScoreInfoTo.Upns1 = pNurseScoreInfoFrom.upns1;
	 		pNurseScoreInfoTo.Upns2 = pNurseScoreInfoFrom.upns2;
	 		pNurseScoreInfoTo.Upns3 = pNurseScoreInfoFrom.upns3;
	 		pNurseScoreInfoTo.Upns4 = pNurseScoreInfoFrom.upns4;
	 		pNurseScoreInfoTo.Upns5 = pNurseScoreInfoFrom.upns5;
	 		pNurseScoreInfoTo.Upns6 = pNurseScoreInfoFrom.upns6;
	 		pNurseScoreInfoTo.Upns7 = pNurseScoreInfoFrom.upns7;
	 		pNurseScoreInfoTo.Upns8 = pNurseScoreInfoFrom.upns8;
	 		pNurseScoreInfoTo.Upns9 = pNurseScoreInfoFrom.upns9;
	 		pNurseScoreInfoTo.Upns10 = pNurseScoreInfoFrom.upns10;
	 		pNurseScoreInfoTo.Upns11 = pNurseScoreInfoFrom.upns11;
	 		pNurseScoreInfoTo.Upns12 = pNurseScoreInfoFrom.upns12;
	 		pNurseScoreInfoTo.Upns13 = pNurseScoreInfoFrom.upns13;
	 		pNurseScoreInfoTo.Upns14 = pNurseScoreInfoFrom.upns14;
	 		pNurseScoreInfoTo.Upns15 = pNurseScoreInfoFrom.upns15;
	 		pNurseScoreInfoTo.Upns16 = pNurseScoreInfoFrom.upns16;
	 		pNurseScoreInfoTo.Upns17 = pNurseScoreInfoFrom.upns17;
	 		pNurseScoreInfoTo.Upns18 = pNurseScoreInfoFrom.upns18;
	 		pNurseScoreInfoTo.Upns19 = pNurseScoreInfoFrom.upns19;
	 		pNurseScoreInfoTo.Upns20 = pNurseScoreInfoFrom.upns20;
	 		pNurseScoreInfoTo.Upns21 = pNurseScoreInfoFrom.upns21;
	 		pNurseScoreInfoTo.Upns22 = pNurseScoreInfoFrom.upns22;
	 		pNurseScoreInfoTo.Upns23 = pNurseScoreInfoFrom.upns23;
	 		pNurseScoreInfoTo.Secns1 = pNurseScoreInfoFrom.secns1;
	 		pNurseScoreInfoTo.Secns2 = pNurseScoreInfoFrom.secns2;
	 		pNurseScoreInfoTo.Secns3 = pNurseScoreInfoFrom.secns3;
	 		pNurseScoreInfoTo.Secns4 = pNurseScoreInfoFrom.secns4;
	 		pNurseScoreInfoTo.Secns5 = pNurseScoreInfoFrom.secns5;
	 		pNurseScoreInfoTo.Secns6 = pNurseScoreInfoFrom.secns6;
	 		pNurseScoreInfoTo.Secns7 = pNurseScoreInfoFrom.secns7;
	 		pNurseScoreInfoTo.Secns8 = pNurseScoreInfoFrom.secns8;
	 		pNurseScoreInfoTo.Secns9 = pNurseScoreInfoFrom.secns9;
	 		pNurseScoreInfoTo.Secns10 = pNurseScoreInfoFrom.secns10;
	 		pNurseScoreInfoTo.Secns11 = pNurseScoreInfoFrom.secns11;
	 		pNurseScoreInfoTo.Secns12 = pNurseScoreInfoFrom.secns12;
	 		pNurseScoreInfoTo.Secns13 = pNurseScoreInfoFrom.secns13;
	 		pNurseScoreInfoTo.Secns14 = pNurseScoreInfoFrom.secns14;
	 		pNurseScoreInfoTo.Secns15 = pNurseScoreInfoFrom.secns15;
	 		pNurseScoreInfoTo.Secns16 = pNurseScoreInfoFrom.secns16;
	 		pNurseScoreInfoTo.Secns17 = pNurseScoreInfoFrom.secns17;
	 		pNurseScoreInfoTo.Secns18 = pNurseScoreInfoFrom.secns18;
	 		pNurseScoreInfoTo.Secns19 = pNurseScoreInfoFrom.secns19;
	 		pNurseScoreInfoTo.Secns20 = pNurseScoreInfoFrom.secns20;
	 		pNurseScoreInfoTo.Secns21 = pNurseScoreInfoFrom.secns21;
	 		pNurseScoreInfoTo.Secns22 = pNurseScoreInfoFrom.secns22;
	 		pNurseScoreInfoTo.Secns23 = pNurseScoreInfoFrom.secns23;
			pNurseScoreInfoTo.Loaded=pNurseScoreInfoFrom.Loaded;
        }
		
		/// <summary>
		/// 批量装载
		/// </summary>
		internal static void LoadFromDALPatch(List< NurseScoreInfo> pList, NurseScoreCollection pCollection)
        {
            foreach (NurseScore nurseScore in pCollection)
            {
                NurseScoreInfo nurseScoreInfo = new NurseScoreInfo();
                LoadFromDAL(nurseScoreInfo, nurseScore );
                pList.Add(nurseScoreInfo);
            }
			
        }

		//从后台获取数据
		internal  static void  LoadFromDAL(NurseScoreInfo pNurseScoreInfo, NurseScore  pNurseScore)
		{
	 		pNurseScoreInfo.nurseScoreId = pNurseScore.NurseScoreId;
	 		pNurseScoreInfo.dateSpan = pNurseScore.DateSpan;
	 		pNurseScoreInfo.evaluateLevelId = pNurseScore.EvaluateLevelId;
	 		pNurseScoreInfo.totalScore = pNurseScore.TotalScore;
	 		pNurseScoreInfo.upViews = pNurseScore.UpViews;
	 		pNurseScoreInfo.yearId = pNurseScore.YearId;
	 		pNurseScoreInfo.monthId = pNurseScore.MonthId;
	 		pNurseScoreInfo.employeeId = pNurseScore.EmployeeId;
	 		pNurseScoreInfo.isSubmit = pNurseScore.IsSubmit;
	 		pNurseScoreInfo.selfns1 = pNurseScore.Selfns1;
	 		pNurseScoreInfo.selfns2 = pNurseScore.Selfns2;
	 		pNurseScoreInfo.selfns3 = pNurseScore.Selfns3;
	 		pNurseScoreInfo.selfns4 = pNurseScore.Selfns4;
	 		pNurseScoreInfo.selfns5 = pNurseScore.Selfns5;
	 		pNurseScoreInfo.selfns6 = pNurseScore.Selfns6;
	 		pNurseScoreInfo.selfns7 = pNurseScore.Selfns7;
	 		pNurseScoreInfo.selfns8 = pNurseScore.Selfns8;
	 		pNurseScoreInfo.selfns9 = pNurseScore.Selfns9;
	 		pNurseScoreInfo.selfns10 = pNurseScore.Selfns10;
	 		pNurseScoreInfo.selfns11 = pNurseScore.Selfns11;
	 		pNurseScoreInfo.selfns12 = pNurseScore.Selfns12;
	 		pNurseScoreInfo.selfns13 = pNurseScore.Selfns13;
	 		pNurseScoreInfo.selfns14 = pNurseScore.Selfns14;
	 		pNurseScoreInfo.selfns15 = pNurseScore.Selfns15;
	 		pNurseScoreInfo.selfns16 = pNurseScore.Selfns16;
	 		pNurseScoreInfo.selfns17 = pNurseScore.Selfns17;
	 		pNurseScoreInfo.selfns18 = pNurseScore.Selfns18;
	 		pNurseScoreInfo.selfns19 = pNurseScore.Selfns19;
	 		pNurseScoreInfo.selfns20 = pNurseScore.Selfns20;
	 		pNurseScoreInfo.selfns21 = pNurseScore.Selfns21;
	 		pNurseScoreInfo.selfns22 = pNurseScore.Selfns22;
	 		pNurseScoreInfo.selfns23 = pNurseScore.Selfns23;
	 		pNurseScoreInfo.upns1 = pNurseScore.Upns1;
	 		pNurseScoreInfo.upns2 = pNurseScore.Upns2;
	 		pNurseScoreInfo.upns3 = pNurseScore.Upns3;
	 		pNurseScoreInfo.upns4 = pNurseScore.Upns4;
	 		pNurseScoreInfo.upns5 = pNurseScore.Upns5;
	 		pNurseScoreInfo.upns6 = pNurseScore.Upns6;
	 		pNurseScoreInfo.upns7 = pNurseScore.Upns7;
	 		pNurseScoreInfo.upns8 = pNurseScore.Upns8;
	 		pNurseScoreInfo.upns9 = pNurseScore.Upns9;
	 		pNurseScoreInfo.upns10 = pNurseScore.Upns10;
	 		pNurseScoreInfo.upns11 = pNurseScore.Upns11;
	 		pNurseScoreInfo.upns12 = pNurseScore.Upns12;
	 		pNurseScoreInfo.upns13 = pNurseScore.Upns13;
	 		pNurseScoreInfo.upns14 = pNurseScore.Upns14;
	 		pNurseScoreInfo.upns15 = pNurseScore.Upns15;
	 		pNurseScoreInfo.upns16 = pNurseScore.Upns16;
	 		pNurseScoreInfo.upns17 = pNurseScore.Upns17;
	 		pNurseScoreInfo.upns18 = pNurseScore.Upns18;
	 		pNurseScoreInfo.upns19 = pNurseScore.Upns19;
	 		pNurseScoreInfo.upns20 = pNurseScore.Upns20;
	 		pNurseScoreInfo.upns21 = pNurseScore.Upns21;
	 		pNurseScoreInfo.upns22 = pNurseScore.Upns22;
	 		pNurseScoreInfo.upns23 = pNurseScore.Upns23;
	 		pNurseScoreInfo.secns1 = pNurseScore.Secns1;
	 		pNurseScoreInfo.secns2 = pNurseScore.Secns2;
	 		pNurseScoreInfo.secns3 = pNurseScore.Secns3;
	 		pNurseScoreInfo.secns4 = pNurseScore.Secns4;
	 		pNurseScoreInfo.secns5 = pNurseScore.Secns5;
	 		pNurseScoreInfo.secns6 = pNurseScore.Secns6;
	 		pNurseScoreInfo.secns7 = pNurseScore.Secns7;
	 		pNurseScoreInfo.secns8 = pNurseScore.Secns8;
	 		pNurseScoreInfo.secns9 = pNurseScore.Secns9;
	 		pNurseScoreInfo.secns10 = pNurseScore.Secns10;
	 		pNurseScoreInfo.secns11 = pNurseScore.Secns11;
	 		pNurseScoreInfo.secns12 = pNurseScore.Secns12;
	 		pNurseScoreInfo.secns13 = pNurseScore.Secns13;
	 		pNurseScoreInfo.secns14 = pNurseScore.Secns14;
	 		pNurseScoreInfo.secns15 = pNurseScore.Secns15;
	 		pNurseScoreInfo.secns16 = pNurseScore.Secns16;
	 		pNurseScoreInfo.secns17 = pNurseScore.Secns17;
	 		pNurseScoreInfo.secns18 = pNurseScore.Secns18;
	 		pNurseScoreInfo.secns19 = pNurseScore.Secns19;
	 		pNurseScoreInfo.secns20 = pNurseScore.Secns20;
	 		pNurseScoreInfo.secns21 = pNurseScore.Secns21;
	 		pNurseScoreInfo.secns22 = pNurseScore.Secns22;
	 		pNurseScoreInfo.secns23 = pNurseScore.Secns23;
			pNurseScoreInfo.Loaded=true;
			
			}
		
		//数据持久化
		internal  static void  SaveToDb(NurseScoreInfo pNurseScoreInfo, NurseScore  pNurseScore,bool pIsNew)
		{
	 		pNurseScore.NurseScoreId = pNurseScoreInfo.nurseScoreId;
	 		pNurseScore.DateSpan = pNurseScoreInfo.dateSpan;
	 		pNurseScore.EvaluateLevelId = pNurseScoreInfo.evaluateLevelId;
	 		pNurseScore.TotalScore = pNurseScoreInfo.totalScore;
	 		pNurseScore.UpViews = pNurseScoreInfo.upViews;
	 		pNurseScore.YearId = pNurseScoreInfo.yearId;
	 		pNurseScore.MonthId = pNurseScoreInfo.monthId;
	 		pNurseScore.EmployeeId = pNurseScoreInfo.employeeId;
	 		pNurseScore.IsSubmit = pNurseScoreInfo.isSubmit;
	 		pNurseScore.Selfns1 = pNurseScoreInfo.selfns1;
	 		pNurseScore.Selfns2 = pNurseScoreInfo.selfns2;
	 		pNurseScore.Selfns3 = pNurseScoreInfo.selfns3;
	 		pNurseScore.Selfns4 = pNurseScoreInfo.selfns4;
	 		pNurseScore.Selfns5 = pNurseScoreInfo.selfns5;
	 		pNurseScore.Selfns6 = pNurseScoreInfo.selfns6;
	 		pNurseScore.Selfns7 = pNurseScoreInfo.selfns7;
	 		pNurseScore.Selfns8 = pNurseScoreInfo.selfns8;
	 		pNurseScore.Selfns9 = pNurseScoreInfo.selfns9;
	 		pNurseScore.Selfns10 = pNurseScoreInfo.selfns10;
	 		pNurseScore.Selfns11 = pNurseScoreInfo.selfns11;
	 		pNurseScore.Selfns12 = pNurseScoreInfo.selfns12;
	 		pNurseScore.Selfns13 = pNurseScoreInfo.selfns13;
	 		pNurseScore.Selfns14 = pNurseScoreInfo.selfns14;
	 		pNurseScore.Selfns15 = pNurseScoreInfo.selfns15;
	 		pNurseScore.Selfns16 = pNurseScoreInfo.selfns16;
	 		pNurseScore.Selfns17 = pNurseScoreInfo.selfns17;
	 		pNurseScore.Selfns18 = pNurseScoreInfo.selfns18;
	 		pNurseScore.Selfns19 = pNurseScoreInfo.selfns19;
	 		pNurseScore.Selfns20 = pNurseScoreInfo.selfns20;
	 		pNurseScore.Selfns21 = pNurseScoreInfo.selfns21;
	 		pNurseScore.Selfns22 = pNurseScoreInfo.selfns22;
	 		pNurseScore.Selfns23 = pNurseScoreInfo.selfns23;
	 		pNurseScore.Upns1 = pNurseScoreInfo.upns1;
	 		pNurseScore.Upns2 = pNurseScoreInfo.upns2;
	 		pNurseScore.Upns3 = pNurseScoreInfo.upns3;
	 		pNurseScore.Upns4 = pNurseScoreInfo.upns4;
	 		pNurseScore.Upns5 = pNurseScoreInfo.upns5;
	 		pNurseScore.Upns6 = pNurseScoreInfo.upns6;
	 		pNurseScore.Upns7 = pNurseScoreInfo.upns7;
	 		pNurseScore.Upns8 = pNurseScoreInfo.upns8;
	 		pNurseScore.Upns9 = pNurseScoreInfo.upns9;
	 		pNurseScore.Upns10 = pNurseScoreInfo.upns10;
	 		pNurseScore.Upns11 = pNurseScoreInfo.upns11;
	 		pNurseScore.Upns12 = pNurseScoreInfo.upns12;
	 		pNurseScore.Upns13 = pNurseScoreInfo.upns13;
	 		pNurseScore.Upns14 = pNurseScoreInfo.upns14;
	 		pNurseScore.Upns15 = pNurseScoreInfo.upns15;
	 		pNurseScore.Upns16 = pNurseScoreInfo.upns16;
	 		pNurseScore.Upns17 = pNurseScoreInfo.upns17;
	 		pNurseScore.Upns18 = pNurseScoreInfo.upns18;
	 		pNurseScore.Upns19 = pNurseScoreInfo.upns19;
	 		pNurseScore.Upns20 = pNurseScoreInfo.upns20;
	 		pNurseScore.Upns21 = pNurseScoreInfo.upns21;
	 		pNurseScore.Upns22 = pNurseScoreInfo.upns22;
	 		pNurseScore.Upns23 = pNurseScoreInfo.upns23;
	 		pNurseScore.Secns1 = pNurseScoreInfo.secns1;
	 		pNurseScore.Secns2 = pNurseScoreInfo.secns2;
	 		pNurseScore.Secns3 = pNurseScoreInfo.secns3;
	 		pNurseScore.Secns4 = pNurseScoreInfo.secns4;
	 		pNurseScore.Secns5 = pNurseScoreInfo.secns5;
	 		pNurseScore.Secns6 = pNurseScoreInfo.secns6;
	 		pNurseScore.Secns7 = pNurseScoreInfo.secns7;
	 		pNurseScore.Secns8 = pNurseScoreInfo.secns8;
	 		pNurseScore.Secns9 = pNurseScoreInfo.secns9;
	 		pNurseScore.Secns10 = pNurseScoreInfo.secns10;
	 		pNurseScore.Secns11 = pNurseScoreInfo.secns11;
	 		pNurseScore.Secns12 = pNurseScoreInfo.secns12;
	 		pNurseScore.Secns13 = pNurseScoreInfo.secns13;
	 		pNurseScore.Secns14 = pNurseScoreInfo.secns14;
	 		pNurseScore.Secns15 = pNurseScoreInfo.secns15;
	 		pNurseScore.Secns16 = pNurseScoreInfo.secns16;
	 		pNurseScore.Secns17 = pNurseScoreInfo.secns17;
	 		pNurseScore.Secns18 = pNurseScoreInfo.secns18;
	 		pNurseScore.Secns19 = pNurseScoreInfo.secns19;
	 		pNurseScore.Secns20 = pNurseScoreInfo.secns20;
	 		pNurseScore.Secns21 = pNurseScoreInfo.secns21;
	 		pNurseScore.Secns22 = pNurseScoreInfo.secns22;
	 		pNurseScore.Secns23 = pNurseScoreInfo.secns23;
			pNurseScore.IsNew=pIsNew;
			string UserName = SubsonicHelper.GetUserName();
			try
			{
				pNurseScore.Save(UserName);
			}
			catch(Exception ex)
			{
				LogManager.getInstance().getLogger(typeof(NurseScoreInfo)).Error(ex);
				if(ex.Message.Contains("插入重复键"))//违反了唯一键
				{
					throw new AppException("此对象已经存在");//此处等待优化可以从唯一约束中直接取出提示来，如果没有的话，默认为原始的出错提示
				}
				throw new AppException("保存失败");
			}
			pNurseScoreInfo.nurseScoreId = pNurseScore.NurseScoreId;
			//如果缓存存在，更新缓存
			if (CachedEntityCommander.IsTypeRegistered(typeof(NurseScoreInfo))) 
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
        public static List< NurseScoreInfo> GetPagedList(int pPageIndex,int pPageSize,SortDirection pOrderBy,string pSortExpression,out int pRecordCount)
        {
			if(pPageIndex<=1)
			pPageIndex=1;
            List< NurseScoreInfo> list = new List< NurseScoreInfo>();
          
            Query q = NurseScore .CreateQuery();
            q.PageIndex = pPageIndex;
            q.PageSize = pPageSize;
            q.ORDER_BY(pSortExpression,pOrderBy.ToString());
			NurseScoreCollection  collection=new  NurseScoreCollection();
		 	collection.LoadAndCloseReader(q.ExecuteReader());
          
            foreach (NurseScore  nurseScore  in collection)
            {
                NurseScoreInfo nurseScoreInfo = new NurseScoreInfo();
                LoadFromDAL(nurseScoreInfo,   nurseScore);
                list.Add(nurseScoreInfo);
            }
			pRecordCount=q.GetRecordCount();
			
            return list;

        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		/// <returns></returns>
		public static List< NurseScoreInfo> GetList()
		{
			string cacheKey = GetCacheKey();
			//本实体已经注册成缓存实体，并且缓存存在的时候，直接从缓存取
			if (CachedEntityCommander.IsTypeRegistered(typeof(NurseScoreInfo)) && CachedEntityCommander.GetCache(cacheKey) != null)
            {
                return CachedEntityCommander.GetCache(cacheKey) as List< NurseScoreInfo>;
            }
            else 
            {
				List< NurseScoreInfo>  list =new List< NurseScoreInfo>();
				NurseScoreCollection  collection=new  NurseScoreCollection();
				Query qry = new Query(NurseScore.Schema);
				collection.LoadAndCloseReader(qry.ExecuteReader());
				foreach(NurseScore nurseScore in collection)
				{
					NurseScoreInfo nurseScoreInfo= new NurseScoreInfo();
					LoadFromDAL(nurseScoreInfo,nurseScore);
					list.Add(nurseScoreInfo);
				}
			  	//生成缓存
                if (CachedEntityCommander.IsTypeRegistered(typeof(NurseScoreInfo))) 
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
		public int NurseScoreId
		{
			get {return nurseScoreId;}
			set {nurseScoreId = value;}
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
		public string Selfns1
		{
			get {return selfns1;}
			set {selfns1 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfns2
		{
			get {return selfns2;}
			set {selfns2 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfns3
		{
			get {return selfns3;}
			set {selfns3 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfns4
		{
			get {return selfns4;}
			set {selfns4 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfns5
		{
			get {return selfns5;}
			set {selfns5 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfns6
		{
			get {return selfns6;}
			set {selfns6 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfns7
		{
			get {return selfns7;}
			set {selfns7 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfns8
		{
			get {return selfns8;}
			set {selfns8 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfns9
		{
			get {return selfns9;}
			set {selfns9 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfns10
		{
			get {return selfns10;}
			set {selfns10 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfns11
		{
			get {return selfns11;}
			set {selfns11 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfns12
		{
			get {return selfns12;}
			set {selfns12 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfns13
		{
			get {return selfns13;}
			set {selfns13 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfns14
		{
			get {return selfns14;}
			set {selfns14 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfns15
		{
			get {return selfns15;}
			set {selfns15 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfns16
		{
			get {return selfns16;}
			set {selfns16 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfns17
		{
			get {return selfns17;}
			set {selfns17 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfns18
		{
			get {return selfns18;}
			set {selfns18 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfns19
		{
			get {return selfns19;}
			set {selfns19 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfns20
		{
			get {return selfns20;}
			set {selfns20 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfns21
		{
			get {return selfns21;}
			set {selfns21 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfns22
		{
			get {return selfns22;}
			set {selfns22 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfns23
		{
			get {return selfns23;}
			set {selfns23 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upns1
		{
			get {return upns1;}
			set {upns1 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upns2
		{
			get {return upns2;}
			set {upns2 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upns3
		{
			get {return upns3;}
			set {upns3 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upns4
		{
			get {return upns4;}
			set {upns4 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upns5
		{
			get {return upns5;}
			set {upns5 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upns6
		{
			get {return upns6;}
			set {upns6 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upns7
		{
			get {return upns7;}
			set {upns7 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upns8
		{
			get {return upns8;}
			set {upns8 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upns9
		{
			get {return upns9;}
			set {upns9 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upns10
		{
			get {return upns10;}
			set {upns10 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upns11
		{
			get {return upns11;}
			set {upns11 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upns12
		{
			get {return upns12;}
			set {upns12 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upns13
		{
			get {return upns13;}
			set {upns13 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upns14
		{
			get {return upns14;}
			set {upns14 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upns15
		{
			get {return upns15;}
			set {upns15 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upns16
		{
			get {return upns16;}
			set {upns16 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upns17
		{
			get {return upns17;}
			set {upns17 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upns18
		{
			get {return upns18;}
			set {upns18 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upns19
		{
			get {return upns19;}
			set {upns19 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upns20
		{
			get {return upns20;}
			set {upns20 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upns21
		{
			get {return upns21;}
			set {upns21 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upns22
		{
			get {return upns22;}
			set {upns22 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upns23
		{
			get {return upns23;}
			set {upns23 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secns1
		{
			get {return secns1;}
			set {secns1 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secns2
		{
			get {return secns2;}
			set {secns2 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secns3
		{
			get {return secns3;}
			set {secns3 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secns4
		{
			get {return secns4;}
			set {secns4 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secns5
		{
			get {return secns5;}
			set {secns5 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secns6
		{
			get {return secns6;}
			set {secns6 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secns7
		{
			get {return secns7;}
			set {secns7 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secns8
		{
			get {return secns8;}
			set {secns8 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secns9
		{
			get {return secns9;}
			set {secns9 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secns10
		{
			get {return secns10;}
			set {secns10 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secns11
		{
			get {return secns11;}
			set {secns11 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secns12
		{
			get {return secns12;}
			set {secns12 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secns13
		{
			get {return secns13;}
			set {secns13 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secns14
		{
			get {return secns14;}
			set {secns14 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secns15
		{
			get {return secns15;}
			set {secns15 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secns16
		{
			get {return secns16;}
			set {secns16 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secns17
		{
			get {return secns17;}
			set {secns17 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secns18
		{
			get {return secns18;}
			set {secns18 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secns19
		{
			get {return secns19;}
			set {secns19 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secns20
		{
			get {return secns20;}
			set {secns20 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secns21
		{
			get {return secns21;}
			set {secns21 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secns22
		{
			get {return secns22;}
			set {secns22 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secns23
		{
			get {return secns23;}
			set {secns23 = value;}
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
			bool result=  (NurseScore.Delete(NurseScoreId) == 1);
			//更新缓存
			if (result&&CachedEntityCommander.IsTypeRegistered(typeof(NurseScoreInfo))) 
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
        public void CopyTo(NurseScoreInfo pNurseScoreInfoTo)
        {
            Copy(this,  pNurseScoreInfoTo);
        }
		
		
		
		
		
		/// <summary>
		/// 保存
		/// </summary>
		public override void Save()
		{
			if(!m_Loaded)//新增
			{
				NurseScore nurseScore=new NurseScore();	
				SaveToDb(this, nurseScore,true);
			}
			else//修改
			{
				NurseScore nurseScore=new NurseScore(nurseScoreId);	
				if(nurseScore.IsNew)
					throw new AppException("该数据已经不存在了");
				SaveToDb(this, nurseScore,false);
			}
			
		}
		 
		#endregion
		
	}
}
