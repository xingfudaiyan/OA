// ======================================================================================================================================
// 类说明
//=======================================================================================================================================
// 创建者：sk @Copy Right 残友软件有限公司OA项目 
// 文件名：EmployeeInfo.cs
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
	///EmployeeInfo  Data
	/// </summary>
	[Serializable]
	public partial class EmployeeInfo:CanYou.EntityObject
	{
		#region 属性
		///<summary>
		///员工Id
		///</summary>
		private int employeeId;
		///<summary>
		///
		///</summary>
		private int contactId;
		///<summary>
		///员工名称
		///</summary>
		private string employeeName = String.Empty;
		///<summary>
		///
		///</summary>
		private int positionId;
		///<summary>
		///
		///</summary>
		private int sex;
		///<summary>
		///
		///</summary>
		private DateTime? birthday;
		///<summary>
		///
		///</summary>
		private int? marrage;
		///<summary>
		///
		///</summary>
		private string address = String.Empty;
		///<summary>
		///籍贯
		///</summary>
		private string nativePlace = String.Empty;
		///<summary>
		///
		///</summary>
		private int politicsId;
		///<summary>
		///身份证号
		///</summary>
		private string identyNum = String.Empty;
		///<summary>
		///毕业院校
		///</summary>
		private string school = String.Empty;
		///<summary>
		///专业
		///</summary>
		private string major = String.Empty;
		///<summary>
		///学历
		///</summary>
		private int educationId;
		///<summary>
		///外语等级
		///</summary>
		private int languageId;
		///<summary>
		///证书
		///</summary>
		private string certificate = String.Empty;
		///<summary>
		///参加工作时间
		///</summary>
		private DateTime? jobTime;
		///<summary>
		///入职时间
		///</summary>
		private DateTime? joinTime;
		///<summary>
		///
		///</summary>
		private int departId;
		///<summary>
		///
		///</summary>
		private int? state;
		///<summary>
		///
		///</summary>
		private DateTime? offJobTime;
		///<summary>
		///
		///</summary>
		private string image = String.Empty;
		///<summary>
		///
		///</summary>
		private string qq = String.Empty;
		///<summary>
		///
		///</summary>
		private string turnTime = String.Empty;
		///<summary>
		///
		///</summary>
		private int? emLevelId;
		///<summary>
		///
		///</summary>
		private int? emDangId;
		
		
		///一对多关系,如果
		private bool m_Loaded=false;
		#endregion
		
		#region 属性枚举
		public struct Fields
		{
			public const string EmployeeId=@"EmployeeId";
			public const string ContactId=@"ContactId";
			public const string EmployeeName=@"EmployeeName";
			public const string PositionId=@"PositionId";
			public const string Sex=@"Sex";
			public const string Birthday=@"Birthday";
			public const string Marrage=@"Marrage";
			public const string Address=@"Address";
			public const string NativePlace=@"NativePlace";
			public const string PoliticsId=@"PoliticsId";
			public const string IdentyNum=@"IdentyNum";
			public const string School=@"School";
			public const string Major=@"Major";
			public const string EducationId=@"EducationId";
			public const string LanguageId=@"LanguageId";
			public const string Certificate=@"Certificate";
			public const string JobTime=@"JobTime";
			public const string JoinTime=@"JoinTime";
			public const string DepartId=@"DepartId";
			public const string State=@"State";
			public const string OffJobTime=@"OffJobTime";
			public const string Image=@"Image";
			public const string Qq=@"Qq";
			public const string TurnTime=@"TurnTime";
			public const string EmLevelId=@"EmLevelId";
			public const string EmDangId=@"EmDangId";
						
		}

		#endregion
		
		
		#region 构造函数
		///<summary>
		///
		///</summary>
		public EmployeeInfo()
		{
		}
		///<summary>
		///
		///</summary>
		public EmployeeInfo(int pEmployeeId,int pContactId,string pEmployeeName,int pPositionId,int pSex,DateTime? pBirthday,int? pMarrage,string pAddress,string pNativePlace,int pPoliticsId,string pIdentyNum,string pSchool,string pMajor,int pEducationId,int pLanguageId,string pCertificate,DateTime? pJobTime,DateTime? pJoinTime,int pDepartId,int? pState,DateTime? pOffJobTime,string pImage,string pQq,string pTurnTime,int? pEmLevelId,int? pEmDangId)
		{
			employeeId   = pEmployeeId;
			contactId    = pContactId;
			employeeName = pEmployeeName;
			positionId   = pPositionId;
			sex          = pSex;
			birthday     = pBirthday;
			marrage      = pMarrage;
			address      = pAddress;
			nativePlace  = pNativePlace;
			politicsId   = pPoliticsId;
			identyNum    = pIdentyNum;
			school       = pSchool;
			major        = pMajor;
			educationId  = pEducationId;
			languageId   = pLanguageId;
			certificate  = pCertificate;
			jobTime      = pJobTime;
			joinTime     = pJoinTime;
			departId     = pDepartId;
			state        = pState;
			offJobTime   = pOffJobTime;
			image        = pImage;
			qq           = pQq;
			turnTime     = pTurnTime;
			emLevelId    = pEmLevelId;
			emDangId     = pEmDangId;
			
		}
		
		
		///<summary>
		///
		///</summary>
		public EmployeeInfo(int employeeId)
		{
			 LoadFromId(employeeId);
		}
		
		private void LoadFromId(int employeeId)
		{
		 
			if (CachedEntityCommander.IsTypeRegistered(typeof(EmployeeInfo)))
            {
				EmployeeInfo employeeInfo=Find(GetList(), employeeId);
				if(employeeInfo==null)
					throw new AppException("未能在缓存中找到相应的键值对象");
                Copy(employeeInfo, this);
            }
            else
            {	Employee employee=new Employee( employeeId);	
				if(employee.IsNew)
				throw new AppException("尚未初始化");
               	LoadFromDAL(this, employee);
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
        public static  EmployeeInfo Find(List< EmployeeInfo> list,  int employeeId)
        {
             return list.Find(delegate( EmployeeInfo item) { return item. employeeId==employeeId; });
        }
		
		
		/// <summary>
        /// 得到缓存键
        /// </summary>
        /// <returns></returns>
        private static string GetCacheKey()
        {
            return string.Format(CachedEntityCommander.CacheKey, typeof( EmployeeInfo).ToString());
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
        public static void Copy(EmployeeInfo pEmployeeInfoFrom, EmployeeInfo pEmployeeInfoTo)
        {
	 		pEmployeeInfoTo.EmployeeId = pEmployeeInfoFrom.employeeId;
	 		pEmployeeInfoTo.ContactId = pEmployeeInfoFrom.contactId;
	 		pEmployeeInfoTo.EmployeeName = pEmployeeInfoFrom.employeeName;
	 		pEmployeeInfoTo.PositionId = pEmployeeInfoFrom.positionId;
	 		pEmployeeInfoTo.Sex = pEmployeeInfoFrom.sex;
	 		pEmployeeInfoTo.Birthday = pEmployeeInfoFrom.birthday;
	 		pEmployeeInfoTo.Marrage = pEmployeeInfoFrom.marrage;
	 		pEmployeeInfoTo.Address = pEmployeeInfoFrom.address;
	 		pEmployeeInfoTo.NativePlace = pEmployeeInfoFrom.nativePlace;
	 		pEmployeeInfoTo.PoliticsId = pEmployeeInfoFrom.politicsId;
	 		pEmployeeInfoTo.IdentyNum = pEmployeeInfoFrom.identyNum;
	 		pEmployeeInfoTo.School = pEmployeeInfoFrom.school;
	 		pEmployeeInfoTo.Major = pEmployeeInfoFrom.major;
	 		pEmployeeInfoTo.EducationId = pEmployeeInfoFrom.educationId;
	 		pEmployeeInfoTo.LanguageId = pEmployeeInfoFrom.languageId;
	 		pEmployeeInfoTo.Certificate = pEmployeeInfoFrom.certificate;
	 		pEmployeeInfoTo.JobTime = pEmployeeInfoFrom.jobTime;
	 		pEmployeeInfoTo.JoinTime = pEmployeeInfoFrom.joinTime;
	 		pEmployeeInfoTo.DepartId = pEmployeeInfoFrom.departId;
	 		pEmployeeInfoTo.State = pEmployeeInfoFrom.state;
	 		pEmployeeInfoTo.OffJobTime = pEmployeeInfoFrom.offJobTime;
	 		pEmployeeInfoTo.Image = pEmployeeInfoFrom.image;
	 		pEmployeeInfoTo.Qq = pEmployeeInfoFrom.qq;
	 		pEmployeeInfoTo.TurnTime = pEmployeeInfoFrom.turnTime;
	 		pEmployeeInfoTo.EmLevelId = pEmployeeInfoFrom.emLevelId;
	 		pEmployeeInfoTo.EmDangId = pEmployeeInfoFrom.emDangId;
			pEmployeeInfoTo.Loaded=pEmployeeInfoFrom.Loaded;
        }
		
		/// <summary>
		/// 批量装载
		/// </summary>
		internal static void LoadFromDALPatch(List< EmployeeInfo> pList, EmployeeCollection pCollection)
        {
            foreach (Employee employee in pCollection)
            {
                EmployeeInfo employeeInfo = new EmployeeInfo();
                LoadFromDAL(employeeInfo, employee );
                pList.Add(employeeInfo);
            }
			
        }

		//从后台获取数据
		internal  static void  LoadFromDAL(EmployeeInfo pEmployeeInfo, Employee  pEmployee)
		{
	 		pEmployeeInfo.employeeId = pEmployee.EmployeeId;
	 		pEmployeeInfo.contactId = pEmployee.ContactId;
	 		pEmployeeInfo.employeeName = pEmployee.EmployeeName;
	 		pEmployeeInfo.positionId = pEmployee.PositionId;
	 		pEmployeeInfo.sex = pEmployee.Sex;
	 		pEmployeeInfo.birthday = pEmployee.Birthday;
	 		pEmployeeInfo.marrage = pEmployee.Marrage;
	 		pEmployeeInfo.address = pEmployee.Address;
	 		pEmployeeInfo.nativePlace = pEmployee.NativePlace;
	 		pEmployeeInfo.politicsId = pEmployee.PoliticsId;
	 		pEmployeeInfo.identyNum = pEmployee.IdentyNum;
	 		pEmployeeInfo.school = pEmployee.School;
	 		pEmployeeInfo.major = pEmployee.Major;
	 		pEmployeeInfo.educationId = pEmployee.EducationId;
	 		pEmployeeInfo.languageId = pEmployee.LanguageId;
	 		pEmployeeInfo.certificate = pEmployee.Certificate;
	 		pEmployeeInfo.jobTime = pEmployee.JobTime;
	 		pEmployeeInfo.joinTime = pEmployee.JoinTime;
	 		pEmployeeInfo.departId = pEmployee.DepartId;
	 		pEmployeeInfo.state = pEmployee.State;
	 		pEmployeeInfo.offJobTime = pEmployee.OffJobTime;
	 		pEmployeeInfo.image = pEmployee.Image;
	 		pEmployeeInfo.qq = pEmployee.Qq;
	 		pEmployeeInfo.turnTime = pEmployee.TurnTime;
	 		pEmployeeInfo.emLevelId = pEmployee.EmLevelId;
	 		pEmployeeInfo.emDangId = pEmployee.EmDangId;
			pEmployeeInfo.Loaded=true;
			
			}
		
		//数据持久化
		internal  static void  SaveToDb(EmployeeInfo pEmployeeInfo, Employee  pEmployee,bool pIsNew)
		{
	 		pEmployee.EmployeeId = pEmployeeInfo.employeeId;
	 		pEmployee.ContactId = pEmployeeInfo.contactId;
	 		pEmployee.EmployeeName = pEmployeeInfo.employeeName;
	 		pEmployee.PositionId = pEmployeeInfo.positionId;
	 		pEmployee.Sex = pEmployeeInfo.sex;
	 		pEmployee.Birthday = pEmployeeInfo.birthday;
	 		pEmployee.Marrage = pEmployeeInfo.marrage;
	 		pEmployee.Address = pEmployeeInfo.address;
	 		pEmployee.NativePlace = pEmployeeInfo.nativePlace;
	 		pEmployee.PoliticsId = pEmployeeInfo.politicsId;
	 		pEmployee.IdentyNum = pEmployeeInfo.identyNum;
	 		pEmployee.School = pEmployeeInfo.school;
	 		pEmployee.Major = pEmployeeInfo.major;
	 		pEmployee.EducationId = pEmployeeInfo.educationId;
	 		pEmployee.LanguageId = pEmployeeInfo.languageId;
	 		pEmployee.Certificate = pEmployeeInfo.certificate;
	 		pEmployee.JobTime = pEmployeeInfo.jobTime;
	 		pEmployee.JoinTime = pEmployeeInfo.joinTime;
	 		pEmployee.DepartId = pEmployeeInfo.departId;
	 		pEmployee.State = pEmployeeInfo.state;
	 		pEmployee.OffJobTime = pEmployeeInfo.offJobTime;
	 		pEmployee.Image = pEmployeeInfo.image;
	 		pEmployee.Qq = pEmployeeInfo.qq;
	 		pEmployee.TurnTime = pEmployeeInfo.turnTime;
	 		pEmployee.EmLevelId = pEmployeeInfo.emLevelId;
	 		pEmployee.EmDangId = pEmployeeInfo.emDangId;
			pEmployee.IsNew=pIsNew;
			string UserName = SubsonicHelper.GetUserName();
			try
			{
				pEmployee.Save(UserName);
			}
			catch(Exception ex)
			{
				LogManager.getInstance().getLogger(typeof(EmployeeInfo)).Error(ex);
				if(ex.Message.Contains("插入重复键"))//违反了唯一键
				{
					throw new AppException("此对象已经存在");//此处等待优化可以从唯一约束中直接取出提示来，如果没有的话，默认为原始的出错提示
				}
				throw new AppException("保存失败");
			}
			pEmployeeInfo.employeeId = pEmployee.EmployeeId;
			//如果缓存存在，更新缓存
			if (CachedEntityCommander.IsTypeRegistered(typeof(EmployeeInfo))) 
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
        public static List< EmployeeInfo> GetPagedList(int pPageIndex,int pPageSize,SortDirection pOrderBy,string pSortExpression,out int pRecordCount)
        {
			if(pPageIndex<=1)
			pPageIndex=1;
            List< EmployeeInfo> list = new List< EmployeeInfo>();
          
            Query q = Employee .CreateQuery();
            q.PageIndex = pPageIndex;
            q.PageSize = pPageSize;
            q.ORDER_BY(pSortExpression,pOrderBy.ToString());
			EmployeeCollection  collection=new  EmployeeCollection();
		 	collection.LoadAndCloseReader(q.ExecuteReader());
          
            foreach (Employee  employee  in collection)
            {
                EmployeeInfo employeeInfo = new EmployeeInfo();
                LoadFromDAL(employeeInfo,   employee);
                list.Add(employeeInfo);
            }
			pRecordCount=q.GetRecordCount();
			
            return list;

        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		/// <returns></returns>
		public static List< EmployeeInfo> GetList()
		{
			string cacheKey = GetCacheKey();
			//本实体已经注册成缓存实体，并且缓存存在的时候，直接从缓存取
			if (CachedEntityCommander.IsTypeRegistered(typeof(EmployeeInfo)) && CachedEntityCommander.GetCache(cacheKey) != null)
            {
                return CachedEntityCommander.GetCache(cacheKey) as List< EmployeeInfo>;
            }
            else 
            {
				List< EmployeeInfo>  list =new List< EmployeeInfo>();
				EmployeeCollection  collection=new  EmployeeCollection();
				Query qry = new Query(Employee.Schema);
				collection.LoadAndCloseReader(qry.ExecuteReader());
				foreach(Employee employee in collection)
				{
					EmployeeInfo employeeInfo= new EmployeeInfo();
					LoadFromDAL(employeeInfo,employee);
					list.Add(employeeInfo);
				}
			  	//生成缓存
                if (CachedEntityCommander.IsTypeRegistered(typeof(EmployeeInfo))) 
                {
                    CachedEntityCommander.SetCache(cacheKey, list);
                }
				return list;
			}
			
		
		}
		#endregion
		
		
		
		
		#region 公有属性
		
		///<summary>
		///员工Id
		///</summary>
		public int EmployeeId
		{
			get {return employeeId;}
			set {employeeId = value;}
		}

		///<summary>
		///
		///</summary>
		public int ContactId
		{
			get {return contactId;}
			set {contactId = value;}
		}

		///<summary>
		///员工名称
		///</summary>
		public string EmployeeName
		{
			get {return employeeName;}
			set {employeeName = value;}
		}

		///<summary>
		///
		///</summary>
		public int PositionId
		{
			get {return positionId;}
			set {positionId = value;}
		}

		///<summary>
		///
		///</summary>
		public int Sex
		{
			get {return sex;}
			set {sex = value;}
		}

		///<summary>
		///
		///</summary>
		public DateTime? Birthday
		{
			get {return birthday;}
			set {birthday = value;}
		}

		///<summary>
		///
		///</summary>
		public int? Marrage
		{
			get {return marrage;}
			set {marrage = value;}
		}

		///<summary>
		///
		///</summary>
		public string Address
		{
			get {return address;}
			set {address = value;}
		}

		///<summary>
		///籍贯
		///</summary>
		public string NativePlace
		{
			get {return nativePlace;}
			set {nativePlace = value;}
		}

		///<summary>
		///
		///</summary>
		public int PoliticsId
		{
			get {return politicsId;}
			set {politicsId = value;}
		}

		///<summary>
		///身份证号
		///</summary>
		public string IdentyNum
		{
			get {return identyNum;}
			set {identyNum = value;}
		}

		///<summary>
		///毕业院校
		///</summary>
		public string School
		{
			get {return school;}
			set {school = value;}
		}

		///<summary>
		///专业
		///</summary>
		public string Major
		{
			get {return major;}
			set {major = value;}
		}

		///<summary>
		///学历
		///</summary>
		public int EducationId
		{
			get {return educationId;}
			set {educationId = value;}
		}

		///<summary>
		///外语等级
		///</summary>
		public int LanguageId
		{
			get {return languageId;}
			set {languageId = value;}
		}

		///<summary>
		///证书
		///</summary>
		public string Certificate
		{
			get {return certificate;}
			set {certificate = value;}
		}

		///<summary>
		///参加工作时间
		///</summary>
		public DateTime? JobTime
		{
			get {return jobTime;}
			set {jobTime = value;}
		}

		///<summary>
		///入职时间
		///</summary>
		public DateTime? JoinTime
		{
			get {return joinTime;}
			set {joinTime = value;}
		}

		///<summary>
		///
		///</summary>
		public int DepartId
		{
			get {return departId;}
			set {departId = value;}
		}

		///<summary>
		///
		///</summary>
		public int? State
		{
			get {return state;}
			set {state = value;}
		}

		///<summary>
		///
		///</summary>
		public DateTime? OffJobTime
		{
			get {return offJobTime;}
			set {offJobTime = value;}
		}

		///<summary>
		///
		///</summary>
		public string Image
		{
			get {return image;}
			set {image = value;}
		}

		///<summary>
		///
		///</summary>
		public string Qq
		{
			get {return qq;}
			set {qq = value;}
		}

		///<summary>
		///
		///</summary>
		public string TurnTime
		{
			get {return turnTime;}
			set {turnTime = value;}
		}

		///<summary>
		///
		///</summary>
		public int? EmLevelId
		{
			get {return emLevelId;}
			set {emLevelId = value;}
		}

		///<summary>
		///
		///</summary>
		public int? EmDangId
		{
			get {return emDangId;}
			set {emDangId = value;}
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
			bool result=  (Employee.Delete(EmployeeId) == 1);
			//更新缓存
			if (result&&CachedEntityCommander.IsTypeRegistered(typeof(EmployeeInfo))) 
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
        public void CopyTo(EmployeeInfo pEmployeeInfoTo)
        {
            Copy(this,  pEmployeeInfoTo);
        }
		
		
		
		
		
		/// <summary>
		/// 保存
		/// </summary>
		public override void Save()
		{
			if(!m_Loaded)//新增
			{
				Employee employee=new Employee();	
				SaveToDb(this, employee,true);
			}
			else//修改
			{
				Employee employee=new Employee(employeeId);	
				if(employee.IsNew)
					throw new AppException("该数据已经不存在了");
				SaveToDb(this, employee,false);
			}
			
		}
		 
		#endregion
		
	}
}
