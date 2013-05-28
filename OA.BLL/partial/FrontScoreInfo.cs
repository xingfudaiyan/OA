// ======================================================================================================================================
// 类说明
//=======================================================================================================================================
// 创建者：sk @Copy Right 残友软件有限公司OA项目 
// 文件名：FrontScoreInfo.cs
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
	///FrontScoreInfo  Data
	/// </summary>
	[Serializable]
	public partial class FrontScoreInfo:CanYou.EntityObject
	{
		#region 属性
		///<summary>
		///
		///</summary>
		private int frontScoreId;
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
		private string selffs1 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selffs2 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selffs3 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selffs4 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selffs5 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selffs6 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selffs7 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selffs8 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selffs9 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selffs10 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selffs11 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selffs12 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selffs13 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selffs14 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selffs15 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selffs16 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selffs17 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selffs18 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selffs19 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selffs20 = String.Empty;
		///<summary>
		///
		///</summary>
		private string selffs21 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upfs1 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upfs2 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upfs3 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upfs4 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upfs5 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upfs6 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upfs7 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upfs8 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upfs9 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upfs10 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upfs11 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upfs12 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upfs13 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upfs14 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upfs15 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upfs16 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upfs17 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upfs18 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upfs19 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upfs20 = String.Empty;
		///<summary>
		///
		///</summary>
		private string upfs21 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secfs1 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secfs2 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secfs3 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secfs4 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secfs5 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secfs6 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secfs7 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secfs8 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secfs9 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secfs10 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secfs11 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secfs12 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secfs13 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secfs14 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secfs15 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secfs16 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secfs17 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secfs18 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secfs19 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secfs20 = String.Empty;
		///<summary>
		///
		///</summary>
		private string secfs21 = String.Empty;
		
		
		///一对多关系,如果
		private bool m_Loaded=false;
		#endregion
		
		#region 属性枚举
		public struct Fields
		{
			public const string FrontScoreId=@"FrontScoreId";
			public const string DateSpan=@"DateSpan";
			public const string EvaluateLevelId=@"EvaluateLevelId";
			public const string TotalScore=@"TotalScore";
			public const string UpViews=@"UpViews";
			public const string YearId=@"YearId";
			public const string MonthId=@"MonthId";
			public const string EmployeeId=@"EmployeeId";
			public const string IsSubmit=@"IsSubmit";
			public const string Selffs1=@"Selffs1";
			public const string Selffs2=@"Selffs2";
			public const string Selffs3=@"Selffs3";
			public const string Selffs4=@"Selffs4";
			public const string Selffs5=@"Selffs5";
			public const string Selffs6=@"Selffs6";
			public const string Selffs7=@"Selffs7";
			public const string Selffs8=@"Selffs8";
			public const string Selffs9=@"Selffs9";
			public const string Selffs10=@"Selffs10";
			public const string Selffs11=@"Selffs11";
			public const string Selffs12=@"Selffs12";
			public const string Selffs13=@"Selffs13";
			public const string Selffs14=@"Selffs14";
			public const string Selffs15=@"Selffs15";
			public const string Selffs16=@"Selffs16";
			public const string Selffs17=@"Selffs17";
			public const string Selffs18=@"Selffs18";
			public const string Selffs19=@"Selffs19";
			public const string Selffs20=@"Selffs20";
			public const string Selffs21=@"Selffs21";
			public const string Upfs1=@"Upfs1";
			public const string Upfs2=@"Upfs2";
			public const string Upfs3=@"Upfs3";
			public const string Upfs4=@"Upfs4";
			public const string Upfs5=@"Upfs5";
			public const string Upfs6=@"Upfs6";
			public const string Upfs7=@"Upfs7";
			public const string Upfs8=@"Upfs8";
			public const string Upfs9=@"Upfs9";
			public const string Upfs10=@"Upfs10";
			public const string Upfs11=@"Upfs11";
			public const string Upfs12=@"Upfs12";
			public const string Upfs13=@"Upfs13";
			public const string Upfs14=@"Upfs14";
			public const string Upfs15=@"Upfs15";
			public const string Upfs16=@"Upfs16";
			public const string Upfs17=@"Upfs17";
			public const string Upfs18=@"Upfs18";
			public const string Upfs19=@"Upfs19";
			public const string Upfs20=@"Upfs20";
			public const string Upfs21=@"Upfs21";
			public const string Secfs1=@"Secfs1";
			public const string Secfs2=@"Secfs2";
			public const string Secfs3=@"Secfs3";
			public const string Secfs4=@"Secfs4";
			public const string Secfs5=@"Secfs5";
			public const string Secfs6=@"Secfs6";
			public const string Secfs7=@"Secfs7";
			public const string Secfs8=@"Secfs8";
			public const string Secfs9=@"Secfs9";
			public const string Secfs10=@"Secfs10";
			public const string Secfs11=@"Secfs11";
			public const string Secfs12=@"Secfs12";
			public const string Secfs13=@"Secfs13";
			public const string Secfs14=@"Secfs14";
			public const string Secfs15=@"Secfs15";
			public const string Secfs16=@"Secfs16";
			public const string Secfs17=@"Secfs17";
			public const string Secfs18=@"Secfs18";
			public const string Secfs19=@"Secfs19";
			public const string Secfs20=@"Secfs20";
			public const string Secfs21=@"Secfs21";
						
		}

		#endregion
		
		
		#region 构造函数
		///<summary>
		///
		///</summary>
		public FrontScoreInfo()
		{
		}
		///<summary>
		///
		///</summary>
		public FrontScoreInfo(int pFrontScoreId,string pDateSpan,int? pEvaluateLevelId,string pTotalScore,string pUpViews,int? pYearId,int? pMonthId,int? pEmployeeId,int? pIsSubmit,string pSelffs1,string pSelffs2,string pSelffs3,string pSelffs4,string pSelffs5,string pSelffs6,string pSelffs7,string pSelffs8,string pSelffs9,string pSelffs10,string pSelffs11,string pSelffs12,string pSelffs13,string pSelffs14,string pSelffs15,string pSelffs16,string pSelffs17,string pSelffs18,string pSelffs19,string pSelffs20,string pSelffs21,string pUpfs1,string pUpfs2,string pUpfs3,string pUpfs4,string pUpfs5,string pUpfs6,string pUpfs7,string pUpfs8,string pUpfs9,string pUpfs10,string pUpfs11,string pUpfs12,string pUpfs13,string pUpfs14,string pUpfs15,string pUpfs16,string pUpfs17,string pUpfs18,string pUpfs19,string pUpfs20,string pUpfs21,string pSecfs1,string pSecfs2,string pSecfs3,string pSecfs4,string pSecfs5,string pSecfs6,string pSecfs7,string pSecfs8,string pSecfs9,string pSecfs10,string pSecfs11,string pSecfs12,string pSecfs13,string pSecfs14,string pSecfs15,string pSecfs16,string pSecfs17,string pSecfs18,string pSecfs19,string pSecfs20,string pSecfs21)
		{
			frontScoreId    = pFrontScoreId;
			dateSpan        = pDateSpan;
			evaluateLevelId = pEvaluateLevelId;
			totalScore      = pTotalScore;
			upViews         = pUpViews;
			yearId          = pYearId;
			monthId         = pMonthId;
			employeeId      = pEmployeeId;
			isSubmit        = pIsSubmit;
			selffs1         = pSelffs1;
			selffs2         = pSelffs2;
			selffs3         = pSelffs3;
			selffs4         = pSelffs4;
			selffs5         = pSelffs5;
			selffs6         = pSelffs6;
			selffs7         = pSelffs7;
			selffs8         = pSelffs8;
			selffs9         = pSelffs9;
			selffs10        = pSelffs10;
			selffs11        = pSelffs11;
			selffs12        = pSelffs12;
			selffs13        = pSelffs13;
			selffs14        = pSelffs14;
			selffs15        = pSelffs15;
			selffs16        = pSelffs16;
			selffs17        = pSelffs17;
			selffs18        = pSelffs18;
			selffs19        = pSelffs19;
			selffs20        = pSelffs20;
			selffs21        = pSelffs21;
			upfs1           = pUpfs1;
			upfs2           = pUpfs2;
			upfs3           = pUpfs3;
			upfs4           = pUpfs4;
			upfs5           = pUpfs5;
			upfs6           = pUpfs6;
			upfs7           = pUpfs7;
			upfs8           = pUpfs8;
			upfs9           = pUpfs9;
			upfs10          = pUpfs10;
			upfs11          = pUpfs11;
			upfs12          = pUpfs12;
			upfs13          = pUpfs13;
			upfs14          = pUpfs14;
			upfs15          = pUpfs15;
			upfs16          = pUpfs16;
			upfs17          = pUpfs17;
			upfs18          = pUpfs18;
			upfs19          = pUpfs19;
			upfs20          = pUpfs20;
			upfs21          = pUpfs21;
			secfs1          = pSecfs1;
			secfs2          = pSecfs2;
			secfs3          = pSecfs3;
			secfs4          = pSecfs4;
			secfs5          = pSecfs5;
			secfs6          = pSecfs6;
			secfs7          = pSecfs7;
			secfs8          = pSecfs8;
			secfs9          = pSecfs9;
			secfs10         = pSecfs10;
			secfs11         = pSecfs11;
			secfs12         = pSecfs12;
			secfs13         = pSecfs13;
			secfs14         = pSecfs14;
			secfs15         = pSecfs15;
			secfs16         = pSecfs16;
			secfs17         = pSecfs17;
			secfs18         = pSecfs18;
			secfs19         = pSecfs19;
			secfs20         = pSecfs20;
			secfs21         = pSecfs21;
			
		}
		
		
		///<summary>
		///
		///</summary>
		public FrontScoreInfo(int frontScoreId)
		{
			 LoadFromId(frontScoreId);
		}
		
		private void LoadFromId(int frontScoreId)
		{
		 
			if (CachedEntityCommander.IsTypeRegistered(typeof(FrontScoreInfo)))
            {
				FrontScoreInfo frontScoreInfo=Find(GetList(), frontScoreId);
				if(frontScoreInfo==null)
					throw new AppException("未能在缓存中找到相应的键值对象");
                Copy(frontScoreInfo, this);
            }
            else
            {	FrontScore frontScore=new FrontScore( frontScoreId);	
				if(frontScore.IsNew)
				throw new AppException("尚未初始化");
               	LoadFromDAL(this, frontScore);
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
        public static  FrontScoreInfo Find(List< FrontScoreInfo> list,  int frontScoreId)
        {
             return list.Find(delegate( FrontScoreInfo item) { return item. frontScoreId==frontScoreId; });
        }
		
		
		/// <summary>
        /// 得到缓存键
        /// </summary>
        /// <returns></returns>
        private static string GetCacheKey()
        {
            return string.Format(CachedEntityCommander.CacheKey, typeof( FrontScoreInfo).ToString());
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
        public static void Copy(FrontScoreInfo pFrontScoreInfoFrom, FrontScoreInfo pFrontScoreInfoTo)
        {
	 		pFrontScoreInfoTo.FrontScoreId = pFrontScoreInfoFrom.frontScoreId;
	 		pFrontScoreInfoTo.DateSpan = pFrontScoreInfoFrom.dateSpan;
	 		pFrontScoreInfoTo.EvaluateLevelId = pFrontScoreInfoFrom.evaluateLevelId;
	 		pFrontScoreInfoTo.TotalScore = pFrontScoreInfoFrom.totalScore;
	 		pFrontScoreInfoTo.UpViews = pFrontScoreInfoFrom.upViews;
	 		pFrontScoreInfoTo.YearId = pFrontScoreInfoFrom.yearId;
	 		pFrontScoreInfoTo.MonthId = pFrontScoreInfoFrom.monthId;
	 		pFrontScoreInfoTo.EmployeeId = pFrontScoreInfoFrom.employeeId;
	 		pFrontScoreInfoTo.IsSubmit = pFrontScoreInfoFrom.isSubmit;
	 		pFrontScoreInfoTo.Selffs1 = pFrontScoreInfoFrom.selffs1;
	 		pFrontScoreInfoTo.Selffs2 = pFrontScoreInfoFrom.selffs2;
	 		pFrontScoreInfoTo.Selffs3 = pFrontScoreInfoFrom.selffs3;
	 		pFrontScoreInfoTo.Selffs4 = pFrontScoreInfoFrom.selffs4;
	 		pFrontScoreInfoTo.Selffs5 = pFrontScoreInfoFrom.selffs5;
	 		pFrontScoreInfoTo.Selffs6 = pFrontScoreInfoFrom.selffs6;
	 		pFrontScoreInfoTo.Selffs7 = pFrontScoreInfoFrom.selffs7;
	 		pFrontScoreInfoTo.Selffs8 = pFrontScoreInfoFrom.selffs8;
	 		pFrontScoreInfoTo.Selffs9 = pFrontScoreInfoFrom.selffs9;
	 		pFrontScoreInfoTo.Selffs10 = pFrontScoreInfoFrom.selffs10;
	 		pFrontScoreInfoTo.Selffs11 = pFrontScoreInfoFrom.selffs11;
	 		pFrontScoreInfoTo.Selffs12 = pFrontScoreInfoFrom.selffs12;
	 		pFrontScoreInfoTo.Selffs13 = pFrontScoreInfoFrom.selffs13;
	 		pFrontScoreInfoTo.Selffs14 = pFrontScoreInfoFrom.selffs14;
	 		pFrontScoreInfoTo.Selffs15 = pFrontScoreInfoFrom.selffs15;
	 		pFrontScoreInfoTo.Selffs16 = pFrontScoreInfoFrom.selffs16;
	 		pFrontScoreInfoTo.Selffs17 = pFrontScoreInfoFrom.selffs17;
	 		pFrontScoreInfoTo.Selffs18 = pFrontScoreInfoFrom.selffs18;
	 		pFrontScoreInfoTo.Selffs19 = pFrontScoreInfoFrom.selffs19;
	 		pFrontScoreInfoTo.Selffs20 = pFrontScoreInfoFrom.selffs20;
	 		pFrontScoreInfoTo.Selffs21 = pFrontScoreInfoFrom.selffs21;
	 		pFrontScoreInfoTo.Upfs1 = pFrontScoreInfoFrom.upfs1;
	 		pFrontScoreInfoTo.Upfs2 = pFrontScoreInfoFrom.upfs2;
	 		pFrontScoreInfoTo.Upfs3 = pFrontScoreInfoFrom.upfs3;
	 		pFrontScoreInfoTo.Upfs4 = pFrontScoreInfoFrom.upfs4;
	 		pFrontScoreInfoTo.Upfs5 = pFrontScoreInfoFrom.upfs5;
	 		pFrontScoreInfoTo.Upfs6 = pFrontScoreInfoFrom.upfs6;
	 		pFrontScoreInfoTo.Upfs7 = pFrontScoreInfoFrom.upfs7;
	 		pFrontScoreInfoTo.Upfs8 = pFrontScoreInfoFrom.upfs8;
	 		pFrontScoreInfoTo.Upfs9 = pFrontScoreInfoFrom.upfs9;
	 		pFrontScoreInfoTo.Upfs10 = pFrontScoreInfoFrom.upfs10;
	 		pFrontScoreInfoTo.Upfs11 = pFrontScoreInfoFrom.upfs11;
	 		pFrontScoreInfoTo.Upfs12 = pFrontScoreInfoFrom.upfs12;
	 		pFrontScoreInfoTo.Upfs13 = pFrontScoreInfoFrom.upfs13;
	 		pFrontScoreInfoTo.Upfs14 = pFrontScoreInfoFrom.upfs14;
	 		pFrontScoreInfoTo.Upfs15 = pFrontScoreInfoFrom.upfs15;
	 		pFrontScoreInfoTo.Upfs16 = pFrontScoreInfoFrom.upfs16;
	 		pFrontScoreInfoTo.Upfs17 = pFrontScoreInfoFrom.upfs17;
	 		pFrontScoreInfoTo.Upfs18 = pFrontScoreInfoFrom.upfs18;
	 		pFrontScoreInfoTo.Upfs19 = pFrontScoreInfoFrom.upfs19;
	 		pFrontScoreInfoTo.Upfs20 = pFrontScoreInfoFrom.upfs20;
	 		pFrontScoreInfoTo.Upfs21 = pFrontScoreInfoFrom.upfs21;
	 		pFrontScoreInfoTo.Secfs1 = pFrontScoreInfoFrom.secfs1;
	 		pFrontScoreInfoTo.Secfs2 = pFrontScoreInfoFrom.secfs2;
	 		pFrontScoreInfoTo.Secfs3 = pFrontScoreInfoFrom.secfs3;
	 		pFrontScoreInfoTo.Secfs4 = pFrontScoreInfoFrom.secfs4;
	 		pFrontScoreInfoTo.Secfs5 = pFrontScoreInfoFrom.secfs5;
	 		pFrontScoreInfoTo.Secfs6 = pFrontScoreInfoFrom.secfs6;
	 		pFrontScoreInfoTo.Secfs7 = pFrontScoreInfoFrom.secfs7;
	 		pFrontScoreInfoTo.Secfs8 = pFrontScoreInfoFrom.secfs8;
	 		pFrontScoreInfoTo.Secfs9 = pFrontScoreInfoFrom.secfs9;
	 		pFrontScoreInfoTo.Secfs10 = pFrontScoreInfoFrom.secfs10;
	 		pFrontScoreInfoTo.Secfs11 = pFrontScoreInfoFrom.secfs11;
	 		pFrontScoreInfoTo.Secfs12 = pFrontScoreInfoFrom.secfs12;
	 		pFrontScoreInfoTo.Secfs13 = pFrontScoreInfoFrom.secfs13;
	 		pFrontScoreInfoTo.Secfs14 = pFrontScoreInfoFrom.secfs14;
	 		pFrontScoreInfoTo.Secfs15 = pFrontScoreInfoFrom.secfs15;
	 		pFrontScoreInfoTo.Secfs16 = pFrontScoreInfoFrom.secfs16;
	 		pFrontScoreInfoTo.Secfs17 = pFrontScoreInfoFrom.secfs17;
	 		pFrontScoreInfoTo.Secfs18 = pFrontScoreInfoFrom.secfs18;
	 		pFrontScoreInfoTo.Secfs19 = pFrontScoreInfoFrom.secfs19;
	 		pFrontScoreInfoTo.Secfs20 = pFrontScoreInfoFrom.secfs20;
	 		pFrontScoreInfoTo.Secfs21 = pFrontScoreInfoFrom.secfs21;
			pFrontScoreInfoTo.Loaded=pFrontScoreInfoFrom.Loaded;
        }
		
		/// <summary>
		/// 批量装载
		/// </summary>
		internal static void LoadFromDALPatch(List< FrontScoreInfo> pList, FrontScoreCollection pCollection)
        {
            foreach (FrontScore frontScore in pCollection)
            {
                FrontScoreInfo frontScoreInfo = new FrontScoreInfo();
                LoadFromDAL(frontScoreInfo, frontScore );
                pList.Add(frontScoreInfo);
            }
			
        }

		//从后台获取数据
		internal  static void  LoadFromDAL(FrontScoreInfo pFrontScoreInfo, FrontScore  pFrontScore)
		{
	 		pFrontScoreInfo.frontScoreId = pFrontScore.FrontScoreId;
	 		pFrontScoreInfo.dateSpan = pFrontScore.DateSpan;
	 		pFrontScoreInfo.evaluateLevelId = pFrontScore.EvaluateLevelId;
	 		pFrontScoreInfo.totalScore = pFrontScore.TotalScore;
	 		pFrontScoreInfo.upViews = pFrontScore.UpViews;
	 		pFrontScoreInfo.yearId = pFrontScore.YearId;
	 		pFrontScoreInfo.monthId = pFrontScore.MonthId;
	 		pFrontScoreInfo.employeeId = pFrontScore.EmployeeId;
	 		pFrontScoreInfo.isSubmit = pFrontScore.IsSubmit;
	 		pFrontScoreInfo.selffs1 = pFrontScore.Selffs1;
	 		pFrontScoreInfo.selffs2 = pFrontScore.Selffs2;
	 		pFrontScoreInfo.selffs3 = pFrontScore.Selffs3;
	 		pFrontScoreInfo.selffs4 = pFrontScore.Selffs4;
	 		pFrontScoreInfo.selffs5 = pFrontScore.Selffs5;
	 		pFrontScoreInfo.selffs6 = pFrontScore.Selffs6;
	 		pFrontScoreInfo.selffs7 = pFrontScore.Selffs7;
	 		pFrontScoreInfo.selffs8 = pFrontScore.Selffs8;
	 		pFrontScoreInfo.selffs9 = pFrontScore.Selffs9;
	 		pFrontScoreInfo.selffs10 = pFrontScore.Selffs10;
	 		pFrontScoreInfo.selffs11 = pFrontScore.Selffs11;
	 		pFrontScoreInfo.selffs12 = pFrontScore.Selffs12;
	 		pFrontScoreInfo.selffs13 = pFrontScore.Selffs13;
	 		pFrontScoreInfo.selffs14 = pFrontScore.Selffs14;
	 		pFrontScoreInfo.selffs15 = pFrontScore.Selffs15;
	 		pFrontScoreInfo.selffs16 = pFrontScore.Selffs16;
	 		pFrontScoreInfo.selffs17 = pFrontScore.Selffs17;
	 		pFrontScoreInfo.selffs18 = pFrontScore.Selffs18;
	 		pFrontScoreInfo.selffs19 = pFrontScore.Selffs19;
	 		pFrontScoreInfo.selffs20 = pFrontScore.Selffs20;
	 		pFrontScoreInfo.selffs21 = pFrontScore.Selffs21;
	 		pFrontScoreInfo.upfs1 = pFrontScore.Upfs1;
	 		pFrontScoreInfo.upfs2 = pFrontScore.Upfs2;
	 		pFrontScoreInfo.upfs3 = pFrontScore.Upfs3;
	 		pFrontScoreInfo.upfs4 = pFrontScore.Upfs4;
	 		pFrontScoreInfo.upfs5 = pFrontScore.Upfs5;
	 		pFrontScoreInfo.upfs6 = pFrontScore.Upfs6;
	 		pFrontScoreInfo.upfs7 = pFrontScore.Upfs7;
	 		pFrontScoreInfo.upfs8 = pFrontScore.Upfs8;
	 		pFrontScoreInfo.upfs9 = pFrontScore.Upfs9;
	 		pFrontScoreInfo.upfs10 = pFrontScore.Upfs10;
	 		pFrontScoreInfo.upfs11 = pFrontScore.Upfs11;
	 		pFrontScoreInfo.upfs12 = pFrontScore.Upfs12;
	 		pFrontScoreInfo.upfs13 = pFrontScore.Upfs13;
	 		pFrontScoreInfo.upfs14 = pFrontScore.Upfs14;
	 		pFrontScoreInfo.upfs15 = pFrontScore.Upfs15;
	 		pFrontScoreInfo.upfs16 = pFrontScore.Upfs16;
	 		pFrontScoreInfo.upfs17 = pFrontScore.Upfs17;
	 		pFrontScoreInfo.upfs18 = pFrontScore.Upfs18;
	 		pFrontScoreInfo.upfs19 = pFrontScore.Upfs19;
	 		pFrontScoreInfo.upfs20 = pFrontScore.Upfs20;
	 		pFrontScoreInfo.upfs21 = pFrontScore.Upfs21;
	 		pFrontScoreInfo.secfs1 = pFrontScore.Secfs1;
	 		pFrontScoreInfo.secfs2 = pFrontScore.Secfs2;
	 		pFrontScoreInfo.secfs3 = pFrontScore.Secfs3;
	 		pFrontScoreInfo.secfs4 = pFrontScore.Secfs4;
	 		pFrontScoreInfo.secfs5 = pFrontScore.Secfs5;
	 		pFrontScoreInfo.secfs6 = pFrontScore.Secfs6;
	 		pFrontScoreInfo.secfs7 = pFrontScore.Secfs7;
	 		pFrontScoreInfo.secfs8 = pFrontScore.Secfs8;
	 		pFrontScoreInfo.secfs9 = pFrontScore.Secfs9;
	 		pFrontScoreInfo.secfs10 = pFrontScore.Secfs10;
	 		pFrontScoreInfo.secfs11 = pFrontScore.Secfs11;
	 		pFrontScoreInfo.secfs12 = pFrontScore.Secfs12;
	 		pFrontScoreInfo.secfs13 = pFrontScore.Secfs13;
	 		pFrontScoreInfo.secfs14 = pFrontScore.Secfs14;
	 		pFrontScoreInfo.secfs15 = pFrontScore.Secfs15;
	 		pFrontScoreInfo.secfs16 = pFrontScore.Secfs16;
	 		pFrontScoreInfo.secfs17 = pFrontScore.Secfs17;
	 		pFrontScoreInfo.secfs18 = pFrontScore.Secfs18;
	 		pFrontScoreInfo.secfs19 = pFrontScore.Secfs19;
	 		pFrontScoreInfo.secfs20 = pFrontScore.Secfs20;
	 		pFrontScoreInfo.secfs21 = pFrontScore.Secfs21;
			pFrontScoreInfo.Loaded=true;
			
			}
		
		//数据持久化
		internal  static void  SaveToDb(FrontScoreInfo pFrontScoreInfo, FrontScore  pFrontScore,bool pIsNew)
		{
	 		pFrontScore.FrontScoreId = pFrontScoreInfo.frontScoreId;
	 		pFrontScore.DateSpan = pFrontScoreInfo.dateSpan;
	 		pFrontScore.EvaluateLevelId = pFrontScoreInfo.evaluateLevelId;
	 		pFrontScore.TotalScore = pFrontScoreInfo.totalScore;
	 		pFrontScore.UpViews = pFrontScoreInfo.upViews;
	 		pFrontScore.YearId = pFrontScoreInfo.yearId;
	 		pFrontScore.MonthId = pFrontScoreInfo.monthId;
	 		pFrontScore.EmployeeId = pFrontScoreInfo.employeeId;
	 		pFrontScore.IsSubmit = pFrontScoreInfo.isSubmit;
	 		pFrontScore.Selffs1 = pFrontScoreInfo.selffs1;
	 		pFrontScore.Selffs2 = pFrontScoreInfo.selffs2;
	 		pFrontScore.Selffs3 = pFrontScoreInfo.selffs3;
	 		pFrontScore.Selffs4 = pFrontScoreInfo.selffs4;
	 		pFrontScore.Selffs5 = pFrontScoreInfo.selffs5;
	 		pFrontScore.Selffs6 = pFrontScoreInfo.selffs6;
	 		pFrontScore.Selffs7 = pFrontScoreInfo.selffs7;
	 		pFrontScore.Selffs8 = pFrontScoreInfo.selffs8;
	 		pFrontScore.Selffs9 = pFrontScoreInfo.selffs9;
	 		pFrontScore.Selffs10 = pFrontScoreInfo.selffs10;
	 		pFrontScore.Selffs11 = pFrontScoreInfo.selffs11;
	 		pFrontScore.Selffs12 = pFrontScoreInfo.selffs12;
	 		pFrontScore.Selffs13 = pFrontScoreInfo.selffs13;
	 		pFrontScore.Selffs14 = pFrontScoreInfo.selffs14;
	 		pFrontScore.Selffs15 = pFrontScoreInfo.selffs15;
	 		pFrontScore.Selffs16 = pFrontScoreInfo.selffs16;
	 		pFrontScore.Selffs17 = pFrontScoreInfo.selffs17;
	 		pFrontScore.Selffs18 = pFrontScoreInfo.selffs18;
	 		pFrontScore.Selffs19 = pFrontScoreInfo.selffs19;
	 		pFrontScore.Selffs20 = pFrontScoreInfo.selffs20;
	 		pFrontScore.Selffs21 = pFrontScoreInfo.selffs21;
	 		pFrontScore.Upfs1 = pFrontScoreInfo.upfs1;
	 		pFrontScore.Upfs2 = pFrontScoreInfo.upfs2;
	 		pFrontScore.Upfs3 = pFrontScoreInfo.upfs3;
	 		pFrontScore.Upfs4 = pFrontScoreInfo.upfs4;
	 		pFrontScore.Upfs5 = pFrontScoreInfo.upfs5;
	 		pFrontScore.Upfs6 = pFrontScoreInfo.upfs6;
	 		pFrontScore.Upfs7 = pFrontScoreInfo.upfs7;
	 		pFrontScore.Upfs8 = pFrontScoreInfo.upfs8;
	 		pFrontScore.Upfs9 = pFrontScoreInfo.upfs9;
	 		pFrontScore.Upfs10 = pFrontScoreInfo.upfs10;
	 		pFrontScore.Upfs11 = pFrontScoreInfo.upfs11;
	 		pFrontScore.Upfs12 = pFrontScoreInfo.upfs12;
	 		pFrontScore.Upfs13 = pFrontScoreInfo.upfs13;
	 		pFrontScore.Upfs14 = pFrontScoreInfo.upfs14;
	 		pFrontScore.Upfs15 = pFrontScoreInfo.upfs15;
	 		pFrontScore.Upfs16 = pFrontScoreInfo.upfs16;
	 		pFrontScore.Upfs17 = pFrontScoreInfo.upfs17;
	 		pFrontScore.Upfs18 = pFrontScoreInfo.upfs18;
	 		pFrontScore.Upfs19 = pFrontScoreInfo.upfs19;
	 		pFrontScore.Upfs20 = pFrontScoreInfo.upfs20;
	 		pFrontScore.Upfs21 = pFrontScoreInfo.upfs21;
	 		pFrontScore.Secfs1 = pFrontScoreInfo.secfs1;
	 		pFrontScore.Secfs2 = pFrontScoreInfo.secfs2;
	 		pFrontScore.Secfs3 = pFrontScoreInfo.secfs3;
	 		pFrontScore.Secfs4 = pFrontScoreInfo.secfs4;
	 		pFrontScore.Secfs5 = pFrontScoreInfo.secfs5;
	 		pFrontScore.Secfs6 = pFrontScoreInfo.secfs6;
	 		pFrontScore.Secfs7 = pFrontScoreInfo.secfs7;
	 		pFrontScore.Secfs8 = pFrontScoreInfo.secfs8;
	 		pFrontScore.Secfs9 = pFrontScoreInfo.secfs9;
	 		pFrontScore.Secfs10 = pFrontScoreInfo.secfs10;
	 		pFrontScore.Secfs11 = pFrontScoreInfo.secfs11;
	 		pFrontScore.Secfs12 = pFrontScoreInfo.secfs12;
	 		pFrontScore.Secfs13 = pFrontScoreInfo.secfs13;
	 		pFrontScore.Secfs14 = pFrontScoreInfo.secfs14;
	 		pFrontScore.Secfs15 = pFrontScoreInfo.secfs15;
	 		pFrontScore.Secfs16 = pFrontScoreInfo.secfs16;
	 		pFrontScore.Secfs17 = pFrontScoreInfo.secfs17;
	 		pFrontScore.Secfs18 = pFrontScoreInfo.secfs18;
	 		pFrontScore.Secfs19 = pFrontScoreInfo.secfs19;
	 		pFrontScore.Secfs20 = pFrontScoreInfo.secfs20;
	 		pFrontScore.Secfs21 = pFrontScoreInfo.secfs21;
			pFrontScore.IsNew=pIsNew;
			string UserName = SubsonicHelper.GetUserName();
			try
			{
				pFrontScore.Save(UserName);
			}
			catch(Exception ex)
			{
				LogManager.getInstance().getLogger(typeof(FrontScoreInfo)).Error(ex);
				if(ex.Message.Contains("插入重复键"))//违反了唯一键
				{
					throw new AppException("此对象已经存在");//此处等待优化可以从唯一约束中直接取出提示来，如果没有的话，默认为原始的出错提示
				}
				throw new AppException("保存失败");
			}
			pFrontScoreInfo.frontScoreId = pFrontScore.FrontScoreId;
			//如果缓存存在，更新缓存
			if (CachedEntityCommander.IsTypeRegistered(typeof(FrontScoreInfo))) 
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
        public static List< FrontScoreInfo> GetPagedList(int pPageIndex,int pPageSize,SortDirection pOrderBy,string pSortExpression,out int pRecordCount)
        {
			if(pPageIndex<=1)
			pPageIndex=1;
            List< FrontScoreInfo> list = new List< FrontScoreInfo>();
          
            Query q = FrontScore .CreateQuery();
            q.PageIndex = pPageIndex;
            q.PageSize = pPageSize;
            q.ORDER_BY(pSortExpression,pOrderBy.ToString());
			FrontScoreCollection  collection=new  FrontScoreCollection();
		 	collection.LoadAndCloseReader(q.ExecuteReader());
          
            foreach (FrontScore  frontScore  in collection)
            {
                FrontScoreInfo frontScoreInfo = new FrontScoreInfo();
                LoadFromDAL(frontScoreInfo,   frontScore);
                list.Add(frontScoreInfo);
            }
			pRecordCount=q.GetRecordCount();
			
            return list;

        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		/// <returns></returns>
		public static List< FrontScoreInfo> GetList()
		{
			string cacheKey = GetCacheKey();
			//本实体已经注册成缓存实体，并且缓存存在的时候，直接从缓存取
			if (CachedEntityCommander.IsTypeRegistered(typeof(FrontScoreInfo)) && CachedEntityCommander.GetCache(cacheKey) != null)
            {
                return CachedEntityCommander.GetCache(cacheKey) as List< FrontScoreInfo>;
            }
            else 
            {
				List< FrontScoreInfo>  list =new List< FrontScoreInfo>();
				FrontScoreCollection  collection=new  FrontScoreCollection();
				Query qry = new Query(FrontScore.Schema);
				collection.LoadAndCloseReader(qry.ExecuteReader());
				foreach(FrontScore frontScore in collection)
				{
					FrontScoreInfo frontScoreInfo= new FrontScoreInfo();
					LoadFromDAL(frontScoreInfo,frontScore);
					list.Add(frontScoreInfo);
				}
			  	//生成缓存
                if (CachedEntityCommander.IsTypeRegistered(typeof(FrontScoreInfo))) 
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
		public int FrontScoreId
		{
			get {return frontScoreId;}
			set {frontScoreId = value;}
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
		public string Selffs1
		{
			get {return selffs1;}
			set {selffs1 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selffs2
		{
			get {return selffs2;}
			set {selffs2 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selffs3
		{
			get {return selffs3;}
			set {selffs3 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selffs4
		{
			get {return selffs4;}
			set {selffs4 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selffs5
		{
			get {return selffs5;}
			set {selffs5 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selffs6
		{
			get {return selffs6;}
			set {selffs6 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selffs7
		{
			get {return selffs7;}
			set {selffs7 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selffs8
		{
			get {return selffs8;}
			set {selffs8 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selffs9
		{
			get {return selffs9;}
			set {selffs9 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selffs10
		{
			get {return selffs10;}
			set {selffs10 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selffs11
		{
			get {return selffs11;}
			set {selffs11 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selffs12
		{
			get {return selffs12;}
			set {selffs12 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selffs13
		{
			get {return selffs13;}
			set {selffs13 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selffs14
		{
			get {return selffs14;}
			set {selffs14 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selffs15
		{
			get {return selffs15;}
			set {selffs15 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selffs16
		{
			get {return selffs16;}
			set {selffs16 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selffs17
		{
			get {return selffs17;}
			set {selffs17 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selffs18
		{
			get {return selffs18;}
			set {selffs18 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selffs19
		{
			get {return selffs19;}
			set {selffs19 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selffs20
		{
			get {return selffs20;}
			set {selffs20 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Selffs21
		{
			get {return selffs21;}
			set {selffs21 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upfs1
		{
			get {return upfs1;}
			set {upfs1 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upfs2
		{
			get {return upfs2;}
			set {upfs2 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upfs3
		{
			get {return upfs3;}
			set {upfs3 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upfs4
		{
			get {return upfs4;}
			set {upfs4 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upfs5
		{
			get {return upfs5;}
			set {upfs5 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upfs6
		{
			get {return upfs6;}
			set {upfs6 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upfs7
		{
			get {return upfs7;}
			set {upfs7 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upfs8
		{
			get {return upfs8;}
			set {upfs8 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upfs9
		{
			get {return upfs9;}
			set {upfs9 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upfs10
		{
			get {return upfs10;}
			set {upfs10 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upfs11
		{
			get {return upfs11;}
			set {upfs11 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upfs12
		{
			get {return upfs12;}
			set {upfs12 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upfs13
		{
			get {return upfs13;}
			set {upfs13 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upfs14
		{
			get {return upfs14;}
			set {upfs14 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upfs15
		{
			get {return upfs15;}
			set {upfs15 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upfs16
		{
			get {return upfs16;}
			set {upfs16 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upfs17
		{
			get {return upfs17;}
			set {upfs17 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upfs18
		{
			get {return upfs18;}
			set {upfs18 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upfs19
		{
			get {return upfs19;}
			set {upfs19 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upfs20
		{
			get {return upfs20;}
			set {upfs20 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Upfs21
		{
			get {return upfs21;}
			set {upfs21 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secfs1
		{
			get {return secfs1;}
			set {secfs1 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secfs2
		{
			get {return secfs2;}
			set {secfs2 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secfs3
		{
			get {return secfs3;}
			set {secfs3 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secfs4
		{
			get {return secfs4;}
			set {secfs4 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secfs5
		{
			get {return secfs5;}
			set {secfs5 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secfs6
		{
			get {return secfs6;}
			set {secfs6 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secfs7
		{
			get {return secfs7;}
			set {secfs7 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secfs8
		{
			get {return secfs8;}
			set {secfs8 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secfs9
		{
			get {return secfs9;}
			set {secfs9 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secfs10
		{
			get {return secfs10;}
			set {secfs10 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secfs11
		{
			get {return secfs11;}
			set {secfs11 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secfs12
		{
			get {return secfs12;}
			set {secfs12 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secfs13
		{
			get {return secfs13;}
			set {secfs13 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secfs14
		{
			get {return secfs14;}
			set {secfs14 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secfs15
		{
			get {return secfs15;}
			set {secfs15 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secfs16
		{
			get {return secfs16;}
			set {secfs16 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secfs17
		{
			get {return secfs17;}
			set {secfs17 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secfs18
		{
			get {return secfs18;}
			set {secfs18 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secfs19
		{
			get {return secfs19;}
			set {secfs19 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secfs20
		{
			get {return secfs20;}
			set {secfs20 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Secfs21
		{
			get {return secfs21;}
			set {secfs21 = value;}
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
			bool result=  (FrontScore.Delete(FrontScoreId) == 1);
			//更新缓存
			if (result&&CachedEntityCommander.IsTypeRegistered(typeof(FrontScoreInfo))) 
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
        public void CopyTo(FrontScoreInfo pFrontScoreInfoTo)
        {
            Copy(this,  pFrontScoreInfoTo);
        }
		
		
		
		
		
		/// <summary>
		/// 保存
		/// </summary>
		public override void Save()
		{
			if(!m_Loaded)//新增
			{
				FrontScore frontScore=new FrontScore();	
				SaveToDb(this, frontScore,true);
			}
			else//修改
			{
				FrontScore frontScore=new FrontScore(frontScoreId);	
				if(frontScore.IsNew)
					throw new AppException("该数据已经不存在了");
				SaveToDb(this, frontScore,false);
			}
			
		}
		 
		#endregion
		
	}
}
