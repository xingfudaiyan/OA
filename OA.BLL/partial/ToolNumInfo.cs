// ======================================================================================================================================
// 类说明
//=======================================================================================================================================
// 创建者：sk @Copy Right 残友软件有限公司OA项目 
// 文件名：ToolNumInfo.cs
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
	///ToolNumInfo  Data
	/// </summary>
	[Serializable]
	public partial class ToolNumInfo:CanYou.EntityObject
	{
		#region 属性
		///<summary>
		///
		///</summary>
		private int toolNumId;
		///<summary>
		///
		///</summary>
		private string num1 = String.Empty;
		///<summary>
		///
		///</summary>
		private string num2 = String.Empty;
		///<summary>
		///
		///</summary>
		private string num3 = String.Empty;
		///<summary>
		///
		///</summary>
		private string num4 = String.Empty;
		///<summary>
		///
		///</summary>
		private string num5 = String.Empty;
		///<summary>
		///
		///</summary>
		private string num6 = String.Empty;
		///<summary>
		///
		///</summary>
		private string num7 = String.Empty;
		///<summary>
		///
		///</summary>
		private string num8 = String.Empty;
		///<summary>
		///
		///</summary>
		private string num9 = String.Empty;
		///<summary>
		///
		///</summary>
		private string num10 = String.Empty;
		///<summary>
		///
		///</summary>
		private string num11 = String.Empty;
		///<summary>
		///
		///</summary>
		private string num12 = String.Empty;
		///<summary>
		///
		///</summary>
		private string num13 = String.Empty;
		///<summary>
		///
		///</summary>
		private string num14 = String.Empty;
		///<summary>
		///
		///</summary>
		private string num15 = String.Empty;
		///<summary>
		///
		///</summary>
		private string num16 = String.Empty;
		///<summary>
		///
		///</summary>
		private string num17 = String.Empty;
		///<summary>
		///
		///</summary>
		private string num18 = String.Empty;
		///<summary>
		///
		///</summary>
		private string num19 = String.Empty;
		///<summary>
		///
		///</summary>
		private string num20 = String.Empty;
		///<summary>
		///
		///</summary>
		private string num21 = String.Empty;
		///<summary>
		///
		///</summary>
		private string num22 = String.Empty;
		///<summary>
		///
		///</summary>
		private string num23 = String.Empty;
		///<summary>
		///
		///</summary>
		private string num24 = String.Empty;
		///<summary>
		///
		///</summary>
		private string num25 = String.Empty;
		///<summary>
		///
		///</summary>
		private string num26 = String.Empty;
		///<summary>
		///
		///</summary>
		private string num27 = String.Empty;
		///<summary>
		///
		///</summary>
		private string num28 = String.Empty;
		///<summary>
		///
		///</summary>
		private string num29 = String.Empty;
		///<summary>
		///
		///</summary>
		private string num30 = String.Empty;
		///<summary>
		///
		///</summary>
		private string num31 = String.Empty;
		///<summary>
		///
		///</summary>
		private string num32 = String.Empty;
		///<summary>
		///
		///</summary>
		private string num33 = String.Empty;
		///<summary>
		///
		///</summary>
		private string num34 = String.Empty;
		///<summary>
		///
		///</summary>
		private string num35 = String.Empty;
		///<summary>
		///
		///</summary>
		private string num36 = String.Empty;
		///<summary>
		///
		///</summary>
		private string num37 = String.Empty;
		///<summary>
		///
		///</summary>
		private string num38 = String.Empty;
		///<summary>
		///
		///</summary>
		private string num39 = String.Empty;
		///<summary>
		///
		///</summary>
		private string num40 = String.Empty;
		
		
		///一对多关系,如果
		private bool m_Loaded=false;
		#endregion
		
		#region 属性枚举
		public struct Fields
		{
			public const string ToolNumId=@"ToolNumId";
			public const string Num1=@"Num1";
			public const string Num2=@"Num2";
			public const string Num3=@"Num3";
			public const string Num4=@"Num4";
			public const string Num5=@"Num5";
			public const string Num6=@"Num6";
			public const string Num7=@"Num7";
			public const string Num8=@"Num8";
			public const string Num9=@"Num9";
			public const string Num10=@"Num10";
			public const string Num11=@"Num11";
			public const string Num12=@"Num12";
			public const string Num13=@"Num13";
			public const string Num14=@"Num14";
			public const string Num15=@"Num15";
			public const string Num16=@"Num16";
			public const string Num17=@"Num17";
			public const string Num18=@"Num18";
			public const string Num19=@"Num19";
			public const string Num20=@"Num20";
			public const string Num21=@"Num21";
			public const string Num22=@"Num22";
			public const string Num23=@"Num23";
			public const string Num24=@"Num24";
			public const string Num25=@"Num25";
			public const string Num26=@"Num26";
			public const string Num27=@"Num27";
			public const string Num28=@"Num28";
			public const string Num29=@"Num29";
			public const string Num30=@"Num30";
			public const string Num31=@"Num31";
			public const string Num32=@"Num32";
			public const string Num33=@"Num33";
			public const string Num34=@"Num34";
			public const string Num35=@"Num35";
			public const string Num36=@"Num36";
			public const string Num37=@"Num37";
			public const string Num38=@"Num38";
			public const string Num39=@"Num39";
			public const string Num40=@"Num40";
						
		}

		#endregion
		
		
		#region 构造函数
		///<summary>
		///
		///</summary>
		public ToolNumInfo()
		{
		}
		///<summary>
		///
		///</summary>
		public ToolNumInfo(int pToolNumId,string pNum1,string pNum2,string pNum3,string pNum4,string pNum5,string pNum6,string pNum7,string pNum8,string pNum9,string pNum10,string pNum11,string pNum12,string pNum13,string pNum14,string pNum15,string pNum16,string pNum17,string pNum18,string pNum19,string pNum20,string pNum21,string pNum22,string pNum23,string pNum24,string pNum25,string pNum26,string pNum27,string pNum28,string pNum29,string pNum30,string pNum31,string pNum32,string pNum33,string pNum34,string pNum35,string pNum36,string pNum37,string pNum38,string pNum39,string pNum40)
		{
			toolNumId = pToolNumId;
			num1      = pNum1;
			num2      = pNum2;
			num3      = pNum3;
			num4      = pNum4;
			num5      = pNum5;
			num6      = pNum6;
			num7      = pNum7;
			num8      = pNum8;
			num9      = pNum9;
			num10     = pNum10;
			num11     = pNum11;
			num12     = pNum12;
			num13     = pNum13;
			num14     = pNum14;
			num15     = pNum15;
			num16     = pNum16;
			num17     = pNum17;
			num18     = pNum18;
			num19     = pNum19;
			num20     = pNum20;
			num21     = pNum21;
			num22     = pNum22;
			num23     = pNum23;
			num24     = pNum24;
			num25     = pNum25;
			num26     = pNum26;
			num27     = pNum27;
			num28     = pNum28;
			num29     = pNum29;
			num30     = pNum30;
			num31     = pNum31;
			num32     = pNum32;
			num33     = pNum33;
			num34     = pNum34;
			num35     = pNum35;
			num36     = pNum36;
			num37     = pNum37;
			num38     = pNum38;
			num39     = pNum39;
			num40     = pNum40;
			
		}
		
		
		///<summary>
		///
		///</summary>
		public ToolNumInfo(int toolNumId)
		{
			 LoadFromId(toolNumId);
		}
		
		private void LoadFromId(int toolNumId)
		{
		 
			if (CachedEntityCommander.IsTypeRegistered(typeof(ToolNumInfo)))
            {
				ToolNumInfo toolNumInfo=Find(GetList(), toolNumId);
				if(toolNumInfo==null)
					throw new AppException("未能在缓存中找到相应的键值对象");
                Copy(toolNumInfo, this);
            }
            else
            {	ToolNum toolNum=new ToolNum( toolNumId);	
				if(toolNum.IsNew)
				throw new AppException("尚未初始化");
               	LoadFromDAL(this, toolNum);
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
        public static  ToolNumInfo Find(List< ToolNumInfo> list,  int toolNumId)
        {
             return list.Find(delegate( ToolNumInfo item) { return item. toolNumId==toolNumId; });
        }
		
		
		/// <summary>
        /// 得到缓存键
        /// </summary>
        /// <returns></returns>
        private static string GetCacheKey()
        {
            return string.Format(CachedEntityCommander.CacheKey, typeof( ToolNumInfo).ToString());
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
        public static void Copy(ToolNumInfo pToolNumInfoFrom, ToolNumInfo pToolNumInfoTo)
        {
	 		pToolNumInfoTo.ToolNumId = pToolNumInfoFrom.toolNumId;
	 		pToolNumInfoTo.Num1 = pToolNumInfoFrom.num1;
	 		pToolNumInfoTo.Num2 = pToolNumInfoFrom.num2;
	 		pToolNumInfoTo.Num3 = pToolNumInfoFrom.num3;
	 		pToolNumInfoTo.Num4 = pToolNumInfoFrom.num4;
	 		pToolNumInfoTo.Num5 = pToolNumInfoFrom.num5;
	 		pToolNumInfoTo.Num6 = pToolNumInfoFrom.num6;
	 		pToolNumInfoTo.Num7 = pToolNumInfoFrom.num7;
	 		pToolNumInfoTo.Num8 = pToolNumInfoFrom.num8;
	 		pToolNumInfoTo.Num9 = pToolNumInfoFrom.num9;
	 		pToolNumInfoTo.Num10 = pToolNumInfoFrom.num10;
	 		pToolNumInfoTo.Num11 = pToolNumInfoFrom.num11;
	 		pToolNumInfoTo.Num12 = pToolNumInfoFrom.num12;
	 		pToolNumInfoTo.Num13 = pToolNumInfoFrom.num13;
	 		pToolNumInfoTo.Num14 = pToolNumInfoFrom.num14;
	 		pToolNumInfoTo.Num15 = pToolNumInfoFrom.num15;
	 		pToolNumInfoTo.Num16 = pToolNumInfoFrom.num16;
	 		pToolNumInfoTo.Num17 = pToolNumInfoFrom.num17;
	 		pToolNumInfoTo.Num18 = pToolNumInfoFrom.num18;
	 		pToolNumInfoTo.Num19 = pToolNumInfoFrom.num19;
	 		pToolNumInfoTo.Num20 = pToolNumInfoFrom.num20;
	 		pToolNumInfoTo.Num21 = pToolNumInfoFrom.num21;
	 		pToolNumInfoTo.Num22 = pToolNumInfoFrom.num22;
	 		pToolNumInfoTo.Num23 = pToolNumInfoFrom.num23;
	 		pToolNumInfoTo.Num24 = pToolNumInfoFrom.num24;
	 		pToolNumInfoTo.Num25 = pToolNumInfoFrom.num25;
	 		pToolNumInfoTo.Num26 = pToolNumInfoFrom.num26;
	 		pToolNumInfoTo.Num27 = pToolNumInfoFrom.num27;
	 		pToolNumInfoTo.Num28 = pToolNumInfoFrom.num28;
	 		pToolNumInfoTo.Num29 = pToolNumInfoFrom.num29;
	 		pToolNumInfoTo.Num30 = pToolNumInfoFrom.num30;
	 		pToolNumInfoTo.Num31 = pToolNumInfoFrom.num31;
	 		pToolNumInfoTo.Num32 = pToolNumInfoFrom.num32;
	 		pToolNumInfoTo.Num33 = pToolNumInfoFrom.num33;
	 		pToolNumInfoTo.Num34 = pToolNumInfoFrom.num34;
	 		pToolNumInfoTo.Num35 = pToolNumInfoFrom.num35;
	 		pToolNumInfoTo.Num36 = pToolNumInfoFrom.num36;
	 		pToolNumInfoTo.Num37 = pToolNumInfoFrom.num37;
	 		pToolNumInfoTo.Num38 = pToolNumInfoFrom.num38;
	 		pToolNumInfoTo.Num39 = pToolNumInfoFrom.num39;
	 		pToolNumInfoTo.Num40 = pToolNumInfoFrom.num40;
			pToolNumInfoTo.Loaded=pToolNumInfoFrom.Loaded;
        }
		
		/// <summary>
		/// 批量装载
		/// </summary>
		internal static void LoadFromDALPatch(List< ToolNumInfo> pList, ToolNumCollection pCollection)
        {
            foreach (ToolNum toolNum in pCollection)
            {
                ToolNumInfo toolNumInfo = new ToolNumInfo();
                LoadFromDAL(toolNumInfo, toolNum );
                pList.Add(toolNumInfo);
            }
			
        }

		//从后台获取数据
		internal  static void  LoadFromDAL(ToolNumInfo pToolNumInfo, ToolNum  pToolNum)
		{
	 		pToolNumInfo.toolNumId = pToolNum.ToolNumId;
	 		pToolNumInfo.num1 = pToolNum.Num1;
	 		pToolNumInfo.num2 = pToolNum.Num2;
	 		pToolNumInfo.num3 = pToolNum.Num3;
	 		pToolNumInfo.num4 = pToolNum.Num4;
	 		pToolNumInfo.num5 = pToolNum.Num5;
	 		pToolNumInfo.num6 = pToolNum.Num6;
	 		pToolNumInfo.num7 = pToolNum.Num7;
	 		pToolNumInfo.num8 = pToolNum.Num8;
	 		pToolNumInfo.num9 = pToolNum.Num9;
	 		pToolNumInfo.num10 = pToolNum.Num10;
	 		pToolNumInfo.num11 = pToolNum.Num11;
	 		pToolNumInfo.num12 = pToolNum.Num12;
	 		pToolNumInfo.num13 = pToolNum.Num13;
	 		pToolNumInfo.num14 = pToolNum.Num14;
	 		pToolNumInfo.num15 = pToolNum.Num15;
	 		pToolNumInfo.num16 = pToolNum.Num16;
	 		pToolNumInfo.num17 = pToolNum.Num17;
	 		pToolNumInfo.num18 = pToolNum.Num18;
	 		pToolNumInfo.num19 = pToolNum.Num19;
	 		pToolNumInfo.num20 = pToolNum.Num20;
	 		pToolNumInfo.num21 = pToolNum.Num21;
	 		pToolNumInfo.num22 = pToolNum.Num22;
	 		pToolNumInfo.num23 = pToolNum.Num23;
	 		pToolNumInfo.num24 = pToolNum.Num24;
	 		pToolNumInfo.num25 = pToolNum.Num25;
	 		pToolNumInfo.num26 = pToolNum.Num26;
	 		pToolNumInfo.num27 = pToolNum.Num27;
	 		pToolNumInfo.num28 = pToolNum.Num28;
	 		pToolNumInfo.num29 = pToolNum.Num29;
	 		pToolNumInfo.num30 = pToolNum.Num30;
	 		pToolNumInfo.num31 = pToolNum.Num31;
	 		pToolNumInfo.num32 = pToolNum.Num32;
	 		pToolNumInfo.num33 = pToolNum.Num33;
	 		pToolNumInfo.num34 = pToolNum.Num34;
	 		pToolNumInfo.num35 = pToolNum.Num35;
	 		pToolNumInfo.num36 = pToolNum.Num36;
	 		pToolNumInfo.num37 = pToolNum.Num37;
	 		pToolNumInfo.num38 = pToolNum.Num38;
	 		pToolNumInfo.num39 = pToolNum.Num39;
	 		pToolNumInfo.num40 = pToolNum.Num40;
			pToolNumInfo.Loaded=true;
			
			}
		
		//数据持久化
		internal  static void  SaveToDb(ToolNumInfo pToolNumInfo, ToolNum  pToolNum,bool pIsNew)
		{
	 		pToolNum.ToolNumId = pToolNumInfo.toolNumId;
	 		pToolNum.Num1 = pToolNumInfo.num1;
	 		pToolNum.Num2 = pToolNumInfo.num2;
	 		pToolNum.Num3 = pToolNumInfo.num3;
	 		pToolNum.Num4 = pToolNumInfo.num4;
	 		pToolNum.Num5 = pToolNumInfo.num5;
	 		pToolNum.Num6 = pToolNumInfo.num6;
	 		pToolNum.Num7 = pToolNumInfo.num7;
	 		pToolNum.Num8 = pToolNumInfo.num8;
	 		pToolNum.Num9 = pToolNumInfo.num9;
	 		pToolNum.Num10 = pToolNumInfo.num10;
	 		pToolNum.Num11 = pToolNumInfo.num11;
	 		pToolNum.Num12 = pToolNumInfo.num12;
	 		pToolNum.Num13 = pToolNumInfo.num13;
	 		pToolNum.Num14 = pToolNumInfo.num14;
	 		pToolNum.Num15 = pToolNumInfo.num15;
	 		pToolNum.Num16 = pToolNumInfo.num16;
	 		pToolNum.Num17 = pToolNumInfo.num17;
	 		pToolNum.Num18 = pToolNumInfo.num18;
	 		pToolNum.Num19 = pToolNumInfo.num19;
	 		pToolNum.Num20 = pToolNumInfo.num20;
	 		pToolNum.Num21 = pToolNumInfo.num21;
	 		pToolNum.Num22 = pToolNumInfo.num22;
	 		pToolNum.Num23 = pToolNumInfo.num23;
	 		pToolNum.Num24 = pToolNumInfo.num24;
	 		pToolNum.Num25 = pToolNumInfo.num25;
	 		pToolNum.Num26 = pToolNumInfo.num26;
	 		pToolNum.Num27 = pToolNumInfo.num27;
	 		pToolNum.Num28 = pToolNumInfo.num28;
	 		pToolNum.Num29 = pToolNumInfo.num29;
	 		pToolNum.Num30 = pToolNumInfo.num30;
	 		pToolNum.Num31 = pToolNumInfo.num31;
	 		pToolNum.Num32 = pToolNumInfo.num32;
	 		pToolNum.Num33 = pToolNumInfo.num33;
	 		pToolNum.Num34 = pToolNumInfo.num34;
	 		pToolNum.Num35 = pToolNumInfo.num35;
	 		pToolNum.Num36 = pToolNumInfo.num36;
	 		pToolNum.Num37 = pToolNumInfo.num37;
	 		pToolNum.Num38 = pToolNumInfo.num38;
	 		pToolNum.Num39 = pToolNumInfo.num39;
	 		pToolNum.Num40 = pToolNumInfo.num40;
			pToolNum.IsNew=pIsNew;
			string UserName = SubsonicHelper.GetUserName();
			try
			{
				pToolNum.Save(UserName);
			}
			catch(Exception ex)
			{
				LogManager.getInstance().getLogger(typeof(ToolNumInfo)).Error(ex);
				if(ex.Message.Contains("插入重复键"))//违反了唯一键
				{
					throw new AppException("此对象已经存在");//此处等待优化可以从唯一约束中直接取出提示来，如果没有的话，默认为原始的出错提示
				}
				throw new AppException("保存失败");
			}
			pToolNumInfo.toolNumId = pToolNum.ToolNumId;
			//如果缓存存在，更新缓存
			if (CachedEntityCommander.IsTypeRegistered(typeof(ToolNumInfo))) 
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
        public static List< ToolNumInfo> GetPagedList(int pPageIndex,int pPageSize,SortDirection pOrderBy,string pSortExpression,out int pRecordCount)
        {
			if(pPageIndex<=1)
			pPageIndex=1;
            List< ToolNumInfo> list = new List< ToolNumInfo>();
          
            Query q = ToolNum .CreateQuery();
            q.PageIndex = pPageIndex;
            q.PageSize = pPageSize;
            q.ORDER_BY(pSortExpression,pOrderBy.ToString());
			ToolNumCollection  collection=new  ToolNumCollection();
		 	collection.LoadAndCloseReader(q.ExecuteReader());
          
            foreach (ToolNum  toolNum  in collection)
            {
                ToolNumInfo toolNumInfo = new ToolNumInfo();
                LoadFromDAL(toolNumInfo,   toolNum);
                list.Add(toolNumInfo);
            }
			pRecordCount=q.GetRecordCount();
			
            return list;

        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		/// <returns></returns>
		public static List< ToolNumInfo> GetList()
		{
			string cacheKey = GetCacheKey();
			//本实体已经注册成缓存实体，并且缓存存在的时候，直接从缓存取
			if (CachedEntityCommander.IsTypeRegistered(typeof(ToolNumInfo)) && CachedEntityCommander.GetCache(cacheKey) != null)
            {
                return CachedEntityCommander.GetCache(cacheKey) as List< ToolNumInfo>;
            }
            else 
            {
				List< ToolNumInfo>  list =new List< ToolNumInfo>();
				ToolNumCollection  collection=new  ToolNumCollection();
				Query qry = new Query(ToolNum.Schema);
				collection.LoadAndCloseReader(qry.ExecuteReader());
				foreach(ToolNum toolNum in collection)
				{
					ToolNumInfo toolNumInfo= new ToolNumInfo();
					LoadFromDAL(toolNumInfo,toolNum);
					list.Add(toolNumInfo);
				}
			  	//生成缓存
                if (CachedEntityCommander.IsTypeRegistered(typeof(ToolNumInfo))) 
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
		public int ToolNumId
		{
			get {return toolNumId;}
			set {toolNumId = value;}
		}

		///<summary>
		///
		///</summary>
		public string Num1
		{
			get {return num1;}
			set {num1 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Num2
		{
			get {return num2;}
			set {num2 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Num3
		{
			get {return num3;}
			set {num3 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Num4
		{
			get {return num4;}
			set {num4 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Num5
		{
			get {return num5;}
			set {num5 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Num6
		{
			get {return num6;}
			set {num6 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Num7
		{
			get {return num7;}
			set {num7 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Num8
		{
			get {return num8;}
			set {num8 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Num9
		{
			get {return num9;}
			set {num9 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Num10
		{
			get {return num10;}
			set {num10 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Num11
		{
			get {return num11;}
			set {num11 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Num12
		{
			get {return num12;}
			set {num12 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Num13
		{
			get {return num13;}
			set {num13 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Num14
		{
			get {return num14;}
			set {num14 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Num15
		{
			get {return num15;}
			set {num15 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Num16
		{
			get {return num16;}
			set {num16 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Num17
		{
			get {return num17;}
			set {num17 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Num18
		{
			get {return num18;}
			set {num18 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Num19
		{
			get {return num19;}
			set {num19 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Num20
		{
			get {return num20;}
			set {num20 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Num21
		{
			get {return num21;}
			set {num21 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Num22
		{
			get {return num22;}
			set {num22 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Num23
		{
			get {return num23;}
			set {num23 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Num24
		{
			get {return num24;}
			set {num24 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Num25
		{
			get {return num25;}
			set {num25 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Num26
		{
			get {return num26;}
			set {num26 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Num27
		{
			get {return num27;}
			set {num27 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Num28
		{
			get {return num28;}
			set {num28 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Num29
		{
			get {return num29;}
			set {num29 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Num30
		{
			get {return num30;}
			set {num30 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Num31
		{
			get {return num31;}
			set {num31 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Num32
		{
			get {return num32;}
			set {num32 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Num33
		{
			get {return num33;}
			set {num33 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Num34
		{
			get {return num34;}
			set {num34 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Num35
		{
			get {return num35;}
			set {num35 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Num36
		{
			get {return num36;}
			set {num36 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Num37
		{
			get {return num37;}
			set {num37 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Num38
		{
			get {return num38;}
			set {num38 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Num39
		{
			get {return num39;}
			set {num39 = value;}
		}

		///<summary>
		///
		///</summary>
		public string Num40
		{
			get {return num40;}
			set {num40 = value;}
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
			bool result=  (ToolNum.Delete(ToolNumId) == 1);
			//更新缓存
			if (result&&CachedEntityCommander.IsTypeRegistered(typeof(ToolNumInfo))) 
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
        public void CopyTo(ToolNumInfo pToolNumInfoTo)
        {
            Copy(this,  pToolNumInfoTo);
        }
		
		
		
		
		
		/// <summary>
		/// 保存
		/// </summary>
		public override void Save()
		{
			if(!m_Loaded)//新增
			{
				ToolNum toolNum=new ToolNum();	
				SaveToDb(this, toolNum,true);
			}
			else//修改
			{
				ToolNum toolNum=new ToolNum(toolNumId);	
				if(toolNum.IsNew)
					throw new AppException("该数据已经不存在了");
				SaveToDb(this, toolNum,false);
			}
			
		}
		 
		#endregion
		
	}
}
