// ======================================================================================================================================
// 类说明
//=======================================================================================================================================
// 创建者：sk @Copy Right 残友软件有限公司OA项目 
// 文件名：BasEmScoreInfo.cs
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
	///BasEmScoreInfo  Data
	/// </summary>
	[Serializable]
	public partial class BasEmScoreInfo:CanYou.EntityObject
	{
		#region 属性
		///<summary>
		///
		///</summary>
		private int basEmScoreId;
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
		private string selfbas1 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfbas2 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfbas3 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfbas4 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfbas5 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfbas6 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfbas7 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfbas8 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfbas9 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfbas10 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfbas11 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfbas12 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfbas13 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfbas14 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfbas15 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfbas16 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selfbas17 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upbas1 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upbas2 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upbas3 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upbas4 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upbas5 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upbas6 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upbas7 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upbas8 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upbas9 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upbas10 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upbas11 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upbas12 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upbas13 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upbas14 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upbas15 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upbas16 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upbas17 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secbas1 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secbas2 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secbas3 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secbas4 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secbas5 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secbas6 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secbas7 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secbas8 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secbas9 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secbas10 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secbas11 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secbas12 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secbas13 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secbas14 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secbas15 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secbas16 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secbas17 = String.Empty;
		
		
		///一对多关系,如果
		private bool m_Loaded=false;
		#endregion
		
		#region 属性枚举
		public struct Fields
		{
			public const string BasEmScoreId=@"BasEmScoreId";
			public const string DateSpan=@"DateSpan";
			public const string EvaluateLevelId=@"EvaluateLevelId";
			public const string TotalScore=@"TotalScore";
			public const string UpViews=@"UpViews";
			public const string YearId=@"YearId";
			public const string MonthId=@"MonthId";
			public const string EmployeeId=@"EmployeeId";
			public const string IsSubmit=@"IsSubmit";
			public const string Selfbas1=@"Selfbas1";
			public const string Selfbas2=@"Selfbas2";
			public const string Selfbas3=@"Selfbas3";
			public const string Selfbas4=@"Selfbas4";
			public const string Selfbas5=@"Selfbas5";
			public const string Selfbas6=@"Selfbas6";
			public const string Selfbas7=@"Selfbas7";
			public const string Selfbas8=@"Selfbas8";
			public const string Selfbas9=@"Selfbas9";
			public const string Selfbas10=@"Selfbas10";
			public const string Selfbas11=@"Selfbas11";
			public const string Selfbas12=@"Selfbas12";
			public const string Selfbas13=@"Selfbas13";
			public const string Selfbas14=@"Selfbas14";
			public const string Selfbas15=@"Selfbas15";
			public const string Selfbas16=@"Selfbas16";
			public const string Selfbas17=@"Selfbas17";
			public const string Upbas1=@"Upbas1";
			public const string Upbas2=@"Upbas2";
			public const string Upbas3=@"Upbas3";
			public const string Upbas4=@"Upbas4";
			public const string Upbas5=@"Upbas5";
			public const string Upbas6=@"Upbas6";
			public const string Upbas7=@"Upbas7";
			public const string Upbas8=@"Upbas8";
			public const string Upbas9=@"Upbas9";
			public const string Upbas10=@"Upbas10";
			public const string Upbas11=@"Upbas11";
			public const string Upbas12=@"Upbas12";
			public const string Upbas13=@"Upbas13";
			public const string Upbas14=@"Upbas14";
			public const string Upbas15=@"Upbas15";
			public const string Upbas16=@"Upbas16";
			public const string Upbas17=@"Upbas17";
			public const string Secbas1=@"Secbas1";
			public const string Secbas2=@"Secbas2";
			public const string Secbas3=@"Secbas3";
			public const string Secbas4=@"Secbas4";
			public const string Secbas5=@"Secbas5";
			public const string Secbas6=@"Secbas6";
			public const string Secbas7=@"Secbas7";
			public const string Secbas8=@"Secbas8";
			public const string Secbas9=@"Secbas9";
			public const string Secbas10=@"Secbas10";
			public const string Secbas11=@"Secbas11";
			public const string Secbas12=@"Secbas12";
			public const string Secbas13=@"Secbas13";
			public const string Secbas14=@"Secbas14";
			public const string Secbas15=@"Secbas15";
			public const string Secbas16=@"Secbas16";
			public const string Secbas17=@"Secbas17";
						
		}

		#endregion
		
		
		#region 构造函数
		///<summary>
		///
		///</summary>
		public BasEmScoreInfo()
		{
		}
		///<summary>
		///
		///</summary>
		public BasEmScoreInfo(int pBasEmScoreId,string pDateSpan,int? pEvaluateLevelId,string pTotalScore,string pUpViews,int? pYearId,int? pMonthId,int? pEmployeeId,int? pIsSubmit,string pSelfbas1,string pSelfbas2,string pSelfbas3,string pSelfbas4,string pSelfbas5,string pSelfbas6,string pSelfbas7,string pSelfbas8,string pSelfbas9,string pSelfbas10,string pSelfbas11,string pSelfbas12,string pSelfbas13,string pSelfbas14,string pSelfbas15,string pSelfbas16,string pSelfbas17,string pUpbas1,string pUpbas2,string pUpbas3,string pUpbas4,string pUpbas5,string pUpbas6,string pUpbas7,string pUpbas8,string pUpbas9,string pUpbas10,string pUpbas11,string pUpbas12,string pUpbas13,string pUpbas14,string pUpbas15,string pUpbas16,string pUpbas17,string pSecbas1,string pSecbas2,string pSecbas3,string pSecbas4,string pSecbas5,string pSecbas6,string pSecbas7,string pSecbas8,string pSecbas9,string pSecbas10,string pSecbas11,string pSecbas12,string pSecbas13,string pSecbas14,string pSecbas15,string pSecbas16,string pSecbas17)
		{
			basEmScoreId    = pBasEmScoreId;
			dateSpan        = pDateSpan;
			evaluateLevelId = pEvaluateLevelId;
			totalScore      = pTotalScore;
			upViews         = pUpViews;
			yearId          = pYearId;
			monthId         = pMonthId;
			employeeId      = pEmployeeId;
			isSubmit        = pIsSubmit;
			selfbas1        = pSelfbas1;
			selfbas2        = pSelfbas2;
			selfbas3        = pSelfbas3;
			selfbas4        = pSelfbas4;
			selfbas5        = pSelfbas5;
			selfbas6        = pSelfbas6;
			selfbas7        = pSelfbas7;
			selfbas8        = pSelfbas8;
			selfbas9        = pSelfbas9;
			selfbas10       = pSelfbas10;
			selfbas11       = pSelfbas11;
			selfbas12       = pSelfbas12;
			selfbas13       = pSelfbas13;
			selfbas14       = pSelfbas14;
			selfbas15       = pSelfbas15;
			selfbas16       = pSelfbas16;
			selfbas17       = pSelfbas17;
			upbas1          = pUpbas1;
			upbas2          = pUpbas2;
			upbas3          = pUpbas3;
			upbas4          = pUpbas4;
			upbas5          = pUpbas5;
			upbas6          = pUpbas6;
			upbas7          = pUpbas7;
			upbas8          = pUpbas8;
			upbas9          = pUpbas9;
			upbas10         = pUpbas10;
			upbas11         = pUpbas11;
			upbas12         = pUpbas12;
			upbas13         = pUpbas13;
			upbas14         = pUpbas14;
			upbas15         = pUpbas15;
			upbas16         = pUpbas16;
			upbas17         = pUpbas17;
			secbas1         = pSecbas1;
			secbas2         = pSecbas2;
			secbas3         = pSecbas3;
			secbas4         = pSecbas4;
			secbas5         = pSecbas5;
			secbas6         = pSecbas6;
			secbas7         = pSecbas7;
			secbas8         = pSecbas8;
			secbas9         = pSecbas9;
			secbas10        = pSecbas10;
			secbas11        = pSecbas11;
			secbas12        = pSecbas12;
			secbas13        = pSecbas13;
			secbas14        = pSecbas14;
			secbas15        = pSecbas15;
			secbas16        = pSecbas16;
			secbas17        = pSecbas17;
			
		}
		
		
		///<summary>
		///
		///</summary>
		public BasEmScoreInfo(int basEmScoreId)
		{
			 LoadFromId(basEmScoreId);
		}
		
		private void LoadFromId(int basEmScoreId)
		{
		 
			if (CachedEntityCommander.IsTypeRegistered(typeof(BasEmScoreInfo)))
            {
				BasEmScoreInfo basEmScoreInfo=Find(GetList(), basEmScoreId);
				if(basEmScoreInfo==null)
					throw new AppException("未能在缓存中找到相应的键值对象");
                Copy(basEmScoreInfo, this);
            }
            else
            {	BasEmScore basEmScore=new BasEmScore( basEmScoreId);	
				if(basEmScore.IsNew)
				throw new AppException("尚未初始化");
               	LoadFromDAL(this, basEmScore);
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
        public static  BasEmScoreInfo Find(List< BasEmScoreInfo> list,  int basEmScoreId)
        {
             return list.Find(delegate( BasEmScoreInfo item) { return item. basEmScoreId==basEmScoreId; });
        }
		
		
		/// <summary>
        /// 得到缓存键
        /// </summary>
        /// <returns></returns>
        private static string GetCacheKey()
        {
            return string.Format(CachedEntityCommander.CacheKey, typeof( BasEmScoreInfo).ToString());
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
        public static void Copy(BasEmScoreInfo pBasEmScoreInfoFrom, BasEmScoreInfo pBasEmScoreInfoTo)
        {
	 		pBasEmScoreInfoTo.BasEmScoreId = pBasEmScoreInfoFrom.basEmScoreId;
	 		pBasEmScoreInfoTo.DateSpan = pBasEmScoreInfoFrom.dateSpan;
	 		pBasEmScoreInfoTo.EvaluateLevelId = pBasEmScoreInfoFrom.evaluateLevelId;
	 		pBasEmScoreInfoTo.TotalScore = pBasEmScoreInfoFrom.totalScore;
	 		pBasEmScoreInfoTo.UpViews = pBasEmScoreInfoFrom.upViews;
	 		pBasEmScoreInfoTo.YearId = pBasEmScoreInfoFrom.yearId;
	 		pBasEmScoreInfoTo.MonthId = pBasEmScoreInfoFrom.monthId;
	 		pBasEmScoreInfoTo.EmployeeId = pBasEmScoreInfoFrom.employeeId;
	 		pBasEmScoreInfoTo.IsSubmit = pBasEmScoreInfoFrom.isSubmit;
	 		pBasEmScoreInfoTo.Selfbas1 = pBasEmScoreInfoFrom.selfbas1;
	 		pBasEmScoreInfoTo.Selfbas2 = pBasEmScoreInfoFrom.selfbas2;
	 		pBasEmScoreInfoTo.Selfbas3 = pBasEmScoreInfoFrom.selfbas3;
	 		pBasEmScoreInfoTo.Selfbas4 = pBasEmScoreInfoFrom.selfbas4;
	 		pBasEmScoreInfoTo.Selfbas5 = pBasEmScoreInfoFrom.selfbas5;
	 		pBasEmScoreInfoTo.Selfbas6 = pBasEmScoreInfoFrom.selfbas6;
	 		pBasEmScoreInfoTo.Selfbas7 = pBasEmScoreInfoFrom.selfbas7;
	 		pBasEmScoreInfoTo.Selfbas8 = pBasEmScoreInfoFrom.selfbas8;
	 		pBasEmScoreInfoTo.Selfbas9 = pBasEmScoreInfoFrom.selfbas9;
	 		pBasEmScoreInfoTo.Selfbas10 = pBasEmScoreInfoFrom.selfbas10;
	 		pBasEmScoreInfoTo.Selfbas11 = pBasEmScoreInfoFrom.selfbas11;
	 		pBasEmScoreInfoTo.Selfbas12 = pBasEmScoreInfoFrom.selfbas12;
	 		pBasEmScoreInfoTo.Selfbas13 = pBasEmScoreInfoFrom.selfbas13;
	 		pBasEmScoreInfoTo.Selfbas14 = pBasEmScoreInfoFrom.selfbas14;
	 		pBasEmScoreInfoTo.Selfbas15 = pBasEmScoreInfoFrom.selfbas15;
	 		pBasEmScoreInfoTo.Selfbas16 = pBasEmScoreInfoFrom.selfbas16;
	 		pBasEmScoreInfoTo.Selfbas17 = pBasEmScoreInfoFrom.selfbas17;
	 		pBasEmScoreInfoTo.Upbas1 = pBasEmScoreInfoFrom.upbas1;
	 		pBasEmScoreInfoTo.Upbas2 = pBasEmScoreInfoFrom.upbas2;
	 		pBasEmScoreInfoTo.Upbas3 = pBasEmScoreInfoFrom.upbas3;
	 		pBasEmScoreInfoTo.Upbas4 = pBasEmScoreInfoFrom.upbas4;
	 		pBasEmScoreInfoTo.Upbas5 = pBasEmScoreInfoFrom.upbas5;
	 		pBasEmScoreInfoTo.Upbas6 = pBasEmScoreInfoFrom.upbas6;
	 		pBasEmScoreInfoTo.Upbas7 = pBasEmScoreInfoFrom.upbas7;
	 		pBasEmScoreInfoTo.Upbas8 = pBasEmScoreInfoFrom.upbas8;
	 		pBasEmScoreInfoTo.Upbas9 = pBasEmScoreInfoFrom.upbas9;
	 		pBasEmScoreInfoTo.Upbas10 = pBasEmScoreInfoFrom.upbas10;
	 		pBasEmScoreInfoTo.Upbas11 = pBasEmScoreInfoFrom.upbas11;
	 		pBasEmScoreInfoTo.Upbas12 = pBasEmScoreInfoFrom.upbas12;
	 		pBasEmScoreInfoTo.Upbas13 = pBasEmScoreInfoFrom.upbas13;
	 		pBasEmScoreInfoTo.Upbas14 = pBasEmScoreInfoFrom.upbas14;
	 		pBasEmScoreInfoTo.Upbas15 = pBasEmScoreInfoFrom.upbas15;
	 		pBasEmScoreInfoTo.Upbas16 = pBasEmScoreInfoFrom.upbas16;
	 		pBasEmScoreInfoTo.Upbas17 = pBasEmScoreInfoFrom.upbas17;
	 		pBasEmScoreInfoTo.Secbas1 = pBasEmScoreInfoFrom.secbas1;
	 		pBasEmScoreInfoTo.Secbas2 = pBasEmScoreInfoFrom.secbas2;
	 		pBasEmScoreInfoTo.Secbas3 = pBasEmScoreInfoFrom.secbas3;
	 		pBasEmScoreInfoTo.Secbas4 = pBasEmScoreInfoFrom.secbas4;
	 		pBasEmScoreInfoTo.Secbas5 = pBasEmScoreInfoFrom.secbas5;
	 		pBasEmScoreInfoTo.Secbas6 = pBasEmScoreInfoFrom.secbas6;
	 		pBasEmScoreInfoTo.Secbas7 = pBasEmScoreInfoFrom.secbas7;
	 		pBasEmScoreInfoTo.Secbas8 = pBasEmScoreInfoFrom.secbas8;
	 		pBasEmScoreInfoTo.Secbas9 = pBasEmScoreInfoFrom.secbas9;
	 		pBasEmScoreInfoTo.Secbas10 = pBasEmScoreInfoFrom.secbas10;
	 		pBasEmScoreInfoTo.Secbas11 = pBasEmScoreInfoFrom.secbas11;
	 		pBasEmScoreInfoTo.Secbas12 = pBasEmScoreInfoFrom.secbas12;
	 		pBasEmScoreInfoTo.Secbas13 = pBasEmScoreInfoFrom.secbas13;
	 		pBasEmScoreInfoTo.Secbas14 = pBasEmScoreInfoFrom.secbas14;
	 		pBasEmScoreInfoTo.Secbas15 = pBasEmScoreInfoFrom.secbas15;
	 		pBasEmScoreInfoTo.Secbas16 = pBasEmScoreInfoFrom.secbas16;
	 		pBasEmScoreInfoTo.Secbas17 = pBasEmScoreInfoFrom.secbas17;
			pBasEmScoreInfoTo.Loaded=pBasEmScoreInfoFrom.Loaded;
        }
		
		/// <summary>
		/// 批量装载
		/// </summary>
		internal static void LoadFromDALPatch(List< BasEmScoreInfo> pList, BasEmScoreCollection pCollection)
        {
            foreach (BasEmScore basEmScore in pCollection)
            {
                BasEmScoreInfo basEmScoreInfo = new BasEmScoreInfo();
                LoadFromDAL(basEmScoreInfo, basEmScore );
                pList.Add(basEmScoreInfo);
            }
			
        }

		//从后台获取数据
		internal  static void  LoadFromDAL(BasEmScoreInfo pBasEmScoreInfo, BasEmScore  pBasEmScore)
		{
	 		pBasEmScoreInfo.basEmScoreId = pBasEmScore.BasEmScoreId;
	 		pBasEmScoreInfo.dateSpan = pBasEmScore.DateSpan;
	 		pBasEmScoreInfo.evaluateLevelId = pBasEmScore.EvaluateLevelId;
	 		pBasEmScoreInfo.totalScore = pBasEmScore.TotalScore;
	 		pBasEmScoreInfo.upViews = pBasEmScore.UpViews;
	 		pBasEmScoreInfo.yearId = pBasEmScore.YearId;
	 		pBasEmScoreInfo.monthId = pBasEmScore.MonthId;
	 		pBasEmScoreInfo.employeeId = pBasEmScore.EmployeeId;
	 		pBasEmScoreInfo.isSubmit = pBasEmScore.IsSubmit;
	 		pBasEmScoreInfo.selfbas1 = pBasEmScore.Selfbas1;
	 		pBasEmScoreInfo.selfbas2 = pBasEmScore.Selfbas2;
	 		pBasEmScoreInfo.selfbas3 = pBasEmScore.Selfbas3;
	 		pBasEmScoreInfo.selfbas4 = pBasEmScore.Selfbas4;
	 		pBasEmScoreInfo.selfbas5 = pBasEmScore.Selfbas5;
	 		pBasEmScoreInfo.selfbas6 = pBasEmScore.Selfbas6;
	 		pBasEmScoreInfo.selfbas7 = pBasEmScore.Selfbas7;
	 		pBasEmScoreInfo.selfbas8 = pBasEmScore.Selfbas8;
	 		pBasEmScoreInfo.selfbas9 = pBasEmScore.Selfbas9;
	 		pBasEmScoreInfo.selfbas10 = pBasEmScore.Selfbas10;
	 		pBasEmScoreInfo.selfbas11 = pBasEmScore.Selfbas11;
	 		pBasEmScoreInfo.selfbas12 = pBasEmScore.Selfbas12;
	 		pBasEmScoreInfo.selfbas13 = pBasEmScore.Selfbas13;
	 		pBasEmScoreInfo.selfbas14 = pBasEmScore.Selfbas14;
	 		pBasEmScoreInfo.selfbas15 = pBasEmScore.Selfbas15;
	 		pBasEmScoreInfo.selfbas16 = pBasEmScore.Selfbas16;
	 		pBasEmScoreInfo.selfbas17 = pBasEmScore.Selfbas17;
	 		pBasEmScoreInfo.upbas1 = pBasEmScore.Upbas1;
	 		pBasEmScoreInfo.upbas2 = pBasEmScore.Upbas2;
	 		pBasEmScoreInfo.upbas3 = pBasEmScore.Upbas3;
	 		pBasEmScoreInfo.upbas4 = pBasEmScore.Upbas4;
	 		pBasEmScoreInfo.upbas5 = pBasEmScore.Upbas5;
	 		pBasEmScoreInfo.upbas6 = pBasEmScore.Upbas6;
	 		pBasEmScoreInfo.upbas7 = pBasEmScore.Upbas7;
	 		pBasEmScoreInfo.upbas8 = pBasEmScore.Upbas8;
	 		pBasEmScoreInfo.upbas9 = pBasEmScore.Upbas9;
	 		pBasEmScoreInfo.upbas10 = pBasEmScore.Upbas10;
	 		pBasEmScoreInfo.upbas11 = pBasEmScore.Upbas11;
	 		pBasEmScoreInfo.upbas12 = pBasEmScore.Upbas12;
	 		pBasEmScoreInfo.upbas13 = pBasEmScore.Upbas13;
	 		pBasEmScoreInfo.upbas14 = pBasEmScore.Upbas14;
	 		pBasEmScoreInfo.upbas15 = pBasEmScore.Upbas15;
	 		pBasEmScoreInfo.upbas16 = pBasEmScore.Upbas16;
	 		pBasEmScoreInfo.upbas17 = pBasEmScore.Upbas17;
	 		pBasEmScoreInfo.secbas1 = pBasEmScore.Secbas1;
	 		pBasEmScoreInfo.secbas2 = pBasEmScore.Secbas2;
	 		pBasEmScoreInfo.secbas3 = pBasEmScore.Secbas3;
	 		pBasEmScoreInfo.secbas4 = pBasEmScore.Secbas4;
	 		pBasEmScoreInfo.secbas5 = pBasEmScore.Secbas5;
	 		pBasEmScoreInfo.secbas6 = pBasEmScore.Secbas6;
	 		pBasEmScoreInfo.secbas7 = pBasEmScore.Secbas7;
	 		pBasEmScoreInfo.secbas8 = pBasEmScore.Secbas8;
	 		pBasEmScoreInfo.secbas9 = pBasEmScore.Secbas9;
	 		pBasEmScoreInfo.secbas10 = pBasEmScore.Secbas10;
	 		pBasEmScoreInfo.secbas11 = pBasEmScore.Secbas11;
	 		pBasEmScoreInfo.secbas12 = pBasEmScore.Secbas12;
	 		pBasEmScoreInfo.secbas13 = pBasEmScore.Secbas13;
	 		pBasEmScoreInfo.secbas14 = pBasEmScore.Secbas14;
	 		pBasEmScoreInfo.secbas15 = pBasEmScore.Secbas15;
	 		pBasEmScoreInfo.secbas16 = pBasEmScore.Secbas16;
	 		pBasEmScoreInfo.secbas17 = pBasEmScore.Secbas17;
			pBasEmScoreInfo.Loaded=true;
			
			}
		
		//数据持久化
		internal  static void  SaveToDb(BasEmScoreInfo pBasEmScoreInfo, BasEmScore  pBasEmScore,bool pIsNew)
		{
	 		pBasEmScore.BasEmScoreId = pBasEmScoreInfo.basEmScoreId;
	 		pBasEmScore.DateSpan = pBasEmScoreInfo.dateSpan;
	 		pBasEmScore.EvaluateLevelId = pBasEmScoreInfo.evaluateLevelId;
	 		pBasEmScore.TotalScore = pBasEmScoreInfo.totalScore;
	 		pBasEmScore.UpViews = pBasEmScoreInfo.upViews;
	 		pBasEmScore.YearId = pBasEmScoreInfo.yearId;
	 		pBasEmScore.MonthId = pBasEmScoreInfo.monthId;
	 		pBasEmScore.EmployeeId = pBasEmScoreInfo.employeeId;
	 		pBasEmScore.IsSubmit = pBasEmScoreInfo.isSubmit;
	 		pBasEmScore.Selfbas1 = pBasEmScoreInfo.selfbas1;
	 		pBasEmScore.Selfbas2 = pBasEmScoreInfo.selfbas2;
	 		pBasEmScore.Selfbas3 = pBasEmScoreInfo.selfbas3;
	 		pBasEmScore.Selfbas4 = pBasEmScoreInfo.selfbas4;
	 		pBasEmScore.Selfbas5 = pBasEmScoreInfo.selfbas5;
	 		pBasEmScore.Selfbas6 = pBasEmScoreInfo.selfbas6;
	 		pBasEmScore.Selfbas7 = pBasEmScoreInfo.selfbas7;
	 		pBasEmScore.Selfbas8 = pBasEmScoreInfo.selfbas8;
	 		pBasEmScore.Selfbas9 = pBasEmScoreInfo.selfbas9;
	 		pBasEmScore.Selfbas10 = pBasEmScoreInfo.selfbas10;
	 		pBasEmScore.Selfbas11 = pBasEmScoreInfo.selfbas11;
	 		pBasEmScore.Selfbas12 = pBasEmScoreInfo.selfbas12;
	 		pBasEmScore.Selfbas13 = pBasEmScoreInfo.selfbas13;
	 		pBasEmScore.Selfbas14 = pBasEmScoreInfo.selfbas14;
	 		pBasEmScore.Selfbas15 = pBasEmScoreInfo.selfbas15;
	 		pBasEmScore.Selfbas16 = pBasEmScoreInfo.selfbas16;
	 		pBasEmScore.Selfbas17 = pBasEmScoreInfo.selfbas17;
	 		pBasEmScore.Upbas1 = pBasEmScoreInfo.upbas1;
	 		pBasEmScore.Upbas2 = pBasEmScoreInfo.upbas2;
	 		pBasEmScore.Upbas3 = pBasEmScoreInfo.upbas3;
	 		pBasEmScore.Upbas4 = pBasEmScoreInfo.upbas4;
	 		pBasEmScore.Upbas5 = pBasEmScoreInfo.upbas5;
	 		pBasEmScore.Upbas6 = pBasEmScoreInfo.upbas6;
	 		pBasEmScore.Upbas7 = pBasEmScoreInfo.upbas7;
	 		pBasEmScore.Upbas8 = pBasEmScoreInfo.upbas8;
	 		pBasEmScore.Upbas9 = pBasEmScoreInfo.upbas9;
	 		pBasEmScore.Upbas10 = pBasEmScoreInfo.upbas10;
	 		pBasEmScore.Upbas11 = pBasEmScoreInfo.upbas11;
	 		pBasEmScore.Upbas12 = pBasEmScoreInfo.upbas12;
	 		pBasEmScore.Upbas13 = pBasEmScoreInfo.upbas13;
	 		pBasEmScore.Upbas14 = pBasEmScoreInfo.upbas14;
	 		pBasEmScore.Upbas15 = pBasEmScoreInfo.upbas15;
	 		pBasEmScore.Upbas16 = pBasEmScoreInfo.upbas16;
	 		pBasEmScore.Upbas17 = pBasEmScoreInfo.upbas17;
	 		pBasEmScore.Secbas1 = pBasEmScoreInfo.secbas1;
	 		pBasEmScore.Secbas2 = pBasEmScoreInfo.secbas2;
	 		pBasEmScore.Secbas3 = pBasEmScoreInfo.secbas3;
	 		pBasEmScore.Secbas4 = pBasEmScoreInfo.secbas4;
	 		pBasEmScore.Secbas5 = pBasEmScoreInfo.secbas5;
	 		pBasEmScore.Secbas6 = pBasEmScoreInfo.secbas6;
	 		pBasEmScore.Secbas7 = pBasEmScoreInfo.secbas7;
	 		pBasEmScore.Secbas8 = pBasEmScoreInfo.secbas8;
	 		pBasEmScore.Secbas9 = pBasEmScoreInfo.secbas9;
	 		pBasEmScore.Secbas10 = pBasEmScoreInfo.secbas10;
	 		pBasEmScore.Secbas11 = pBasEmScoreInfo.secbas11;
	 		pBasEmScore.Secbas12 = pBasEmScoreInfo.secbas12;
	 		pBasEmScore.Secbas13 = pBasEmScoreInfo.secbas13;
	 		pBasEmScore.Secbas14 = pBasEmScoreInfo.secbas14;
	 		pBasEmScore.Secbas15 = pBasEmScoreInfo.secbas15;
	 		pBasEmScore.Secbas16 = pBasEmScoreInfo.secbas16;
	 		pBasEmScore.Secbas17 = pBasEmScoreInfo.secbas17;
			pBasEmScore.IsNew=pIsNew;
			string UserName = SubsonicHelper.GetUserName();
			try
			{
				pBasEmScore.Save(UserName);
			}
			catch(Exception ex)
			{
				LogManager.getInstance().getLogger(typeof(BasEmScoreInfo)).Error(ex);
				if(ex.Message.Contains("插入重复键"))//违反了唯一键
				{
					throw new AppException("此对象已经存在");//此处等待优化可以从唯一约束中直接取出提示来，如果没有的话，默认为原始的出错提示
				}
				throw new AppException("保存失败");
			}
			pBasEmScoreInfo.basEmScoreId = pBasEmScore.BasEmScoreId;
			//如果缓存存在，更新缓存
			if (CachedEntityCommander.IsTypeRegistered(typeof(BasEmScoreInfo))) 
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
        public static List< BasEmScoreInfo> GetPagedList(int pPageIndex,int pPageSize,SortDirection pOrderBy,string pSortExpression,out int pRecordCount)
        {
			if(pPageIndex<=1)
			pPageIndex=1;
            List< BasEmScoreInfo> list = new List< BasEmScoreInfo>();
          
            Query q = BasEmScore .CreateQuery();
            q.PageIndex = pPageIndex;
            q.PageSize = pPageSize;
            q.ORDER_BY(pSortExpression,pOrderBy.ToString());
			BasEmScoreCollection  collection=new  BasEmScoreCollection();
		 	collection.LoadAndCloseReader(q.ExecuteReader());
          
            foreach (BasEmScore  basEmScore  in collection)
            {
                BasEmScoreInfo basEmScoreInfo = new BasEmScoreInfo();
                LoadFromDAL(basEmScoreInfo,   basEmScore);
                list.Add(basEmScoreInfo);
            }
			pRecordCount=q.GetRecordCount();
			
            return list;

        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		/// <returns></returns>
		public static List< BasEmScoreInfo> GetList()
		{
			string cacheKey = GetCacheKey();
			//本实体已经注册成缓存实体，并且缓存存在的时候，直接从缓存取
			if (CachedEntityCommander.IsTypeRegistered(typeof(BasEmScoreInfo)) && CachedEntityCommander.GetCache(cacheKey) != null)
            {
                return CachedEntityCommander.GetCache(cacheKey) as List< BasEmScoreInfo>;
            }
            else 
            {
				List< BasEmScoreInfo>  list =new List< BasEmScoreInfo>();
				BasEmScoreCollection  collection=new  BasEmScoreCollection();
				Query qry = new Query(BasEmScore.Schema);
				collection.LoadAndCloseReader(qry.ExecuteReader());
				foreach(BasEmScore basEmScore in collection)
				{
					BasEmScoreInfo basEmScoreInfo= new BasEmScoreInfo();
					LoadFromDAL(basEmScoreInfo,basEmScore);
					list.Add(basEmScoreInfo);
				}
			  	//生成缓存
                if (CachedEntityCommander.IsTypeRegistered(typeof(BasEmScoreInfo))) 
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
		public int BasEmScoreId
		{
			get {return basEmScoreId;}
			set {basEmScoreId = value;}
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
		public string Selfbas1
		{
			get {return selfbas1;}
			set {selfbas1 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfbas2
		{
			get {return selfbas2;}
			set {selfbas2 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfbas3
		{
			get {return selfbas3;}
			set {selfbas3 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfbas4
		{
			get {return selfbas4;}
			set {selfbas4 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfbas5
		{
			get {return selfbas5;}
			set {selfbas5 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfbas6
		{
			get {return selfbas6;}
			set {selfbas6 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfbas7
		{
			get {return selfbas7;}
			set {selfbas7 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfbas8
		{
			get {return selfbas8;}
			set {selfbas8 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfbas9
		{
			get {return selfbas9;}
			set {selfbas9 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfbas10
		{
			get {return selfbas10;}
			set {selfbas10 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfbas11
		{
			get {return selfbas11;}
			set {selfbas11 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfbas12
		{
			get {return selfbas12;}
			set {selfbas12 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfbas13
		{
			get {return selfbas13;}
			set {selfbas13 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfbas14
		{
			get {return selfbas14;}
			set {selfbas14 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfbas15
		{
			get {return selfbas15;}
			set {selfbas15 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfbas16
		{
			get {return selfbas16;}
			set {selfbas16 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selfbas17
		{
			get {return selfbas17;}
			set {selfbas17 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upbas1
		{
			get {return upbas1;}
			set {upbas1 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upbas2
		{
			get {return upbas2;}
			set {upbas2 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upbas3
		{
			get {return upbas3;}
			set {upbas3 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upbas4
		{
			get {return upbas4;}
			set {upbas4 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upbas5
		{
			get {return upbas5;}
			set {upbas5 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upbas6
		{
			get {return upbas6;}
			set {upbas6 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upbas7
		{
			get {return upbas7;}
			set {upbas7 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upbas8
		{
			get {return upbas8;}
			set {upbas8 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upbas9
		{
			get {return upbas9;}
			set {upbas9 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upbas10
		{
			get {return upbas10;}
			set {upbas10 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upbas11
		{
			get {return upbas11;}
			set {upbas11 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upbas12
		{
			get {return upbas12;}
			set {upbas12 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upbas13
		{
			get {return upbas13;}
			set {upbas13 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upbas14
		{
			get {return upbas14;}
			set {upbas14 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upbas15
		{
			get {return upbas15;}
			set {upbas15 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upbas16
		{
			get {return upbas16;}
			set {upbas16 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upbas17
		{
			get {return upbas17;}
			set {upbas17 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secbas1
		{
			get {return secbas1;}
			set {secbas1 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secbas2
		{
			get {return secbas2;}
			set {secbas2 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secbas3
		{
			get {return secbas3;}
			set {secbas3 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secbas4
		{
			get {return secbas4;}
			set {secbas4 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secbas5
		{
			get {return secbas5;}
			set {secbas5 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secbas6
		{
			get {return secbas6;}
			set {secbas6 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secbas7
		{
			get {return secbas7;}
			set {secbas7 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secbas8
		{
			get {return secbas8;}
			set {secbas8 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secbas9
		{
			get {return secbas9;}
			set {secbas9 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secbas10
		{
			get {return secbas10;}
			set {secbas10 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secbas11
		{
			get {return secbas11;}
			set {secbas11 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secbas12
		{
			get {return secbas12;}
			set {secbas12 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secbas13
		{
			get {return secbas13;}
			set {secbas13 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secbas14
		{
			get {return secbas14;}
			set {secbas14 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secbas15
		{
			get {return secbas15;}
			set {secbas15 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secbas16
		{
			get {return secbas16;}
			set {secbas16 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secbas17
		{
			get {return secbas17;}
			set {secbas17 = value;}
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
			bool result=  (BasEmScore.Delete(BasEmScoreId) == 1);
			//更新缓存
			if (result&&CachedEntityCommander.IsTypeRegistered(typeof(BasEmScoreInfo))) 
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
        public void CopyTo(BasEmScoreInfo pBasEmScoreInfoTo)
        {
            Copy(this,  pBasEmScoreInfoTo);
        }
		
		
		
		
		
		/// <summary>
		/// 保存
		/// </summary>
		public override void Save()
		{
			if(!m_Loaded)//新增
			{
				BasEmScore basEmScore=new BasEmScore();	
				SaveToDb(this, basEmScore,true);
			}
			else//修改
			{
				BasEmScore basEmScore=new BasEmScore(basEmScoreId);	
				if(basEmScore.IsNew)
					throw new AppException("该数据已经不存在了");
				SaveToDb(this, basEmScore,false);
			}
			
		}
		 
		#endregion
		
	}
}
