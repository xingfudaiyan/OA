// ======================================================================================================================================
// 类说明
//=======================================================================================================================================
// 创建者：sk @Copy Right 残友软件有限公司OA项目 
// 文件名：ClientInfo.cs
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
	///ClientInfo  Data
	/// </summary>
	[Serializable]
	public partial class ClientInfo:CanYou.EntityObject
	{
		#region 属性
		///<summary>
		///
		///</summary>
		private int clientId;
		///<summary>
		///
		///</summary>
		private string clientName = String.Empty;
		///<summary>
		///
		///</summary>
		private int? clientLevelId;
		///<summary>
		///
		///</summary>
		private string address = String.Empty;
		///<summary>
		///
		///</summary>
		private string telephone = String.Empty;
		///<summary>
		///
		///</summary>
		private string mailNo = String.Empty;
		///<summary>
		///
		///</summary>
		private string fax = String.Empty;
		///<summary>
		///
		///</summary>
		private int? employeeId;
		///<summary>
		///
		///</summary>
		private int? clientTypeId;
		///<summary>
		///
		///</summary>
		private string sheetNum = String.Empty;
		
		
		///一对多关系,如果
		private bool m_Loaded=false;
		#endregion
		
		#region 属性枚举
		public struct Fields
		{
			public const string ClientId=@"ClientId";
			public const string ClientName=@"ClientName";
			public const string ClientLevelId=@"ClientLevelId";
			public const string Address=@"Address";
			public const string Telephone=@"Telephone";
			public const string MailNo=@"MailNo";
			public const string Fax=@"Fax";
			public const string EmployeeId=@"EmployeeId";
			public const string ClientTypeId=@"ClientTypeId";
			public const string SheetNum=@"SheetNum";
						
		}

		#endregion
		
		
		#region 构造函数
		///<summary>
		///
		///</summary>
		public ClientInfo()
		{
		}
		///<summary>
		///
		///</summary>
		public ClientInfo(int pClientId,string pClientName,int? pClientLevelId,string pAddress,string pTelephone,string pMailNo,string pFax,int? pEmployeeId,int? pClientTypeId,string pSheetNum)
		{
			clientId      = pClientId;
			clientName    = pClientName;
			clientLevelId = pClientLevelId;
			address       = pAddress;
			telephone     = pTelephone;
			mailNo        = pMailNo;
			fax           = pFax;
			employeeId    = pEmployeeId;
			clientTypeId  = pClientTypeId;
			sheetNum      = pSheetNum;
			
		}
		
		
		///<summary>
		///
		///</summary>
		public ClientInfo(int clientId)
		{
			 LoadFromId(clientId);
		}
		
		private void LoadFromId(int clientId)
		{
		 
			if (CachedEntityCommander.IsTypeRegistered(typeof(ClientInfo)))
            {
				ClientInfo clientInfo=Find(GetList(), clientId);
				if(clientInfo==null)
					throw new AppException("未能在缓存中找到相应的键值对象");
                Copy(clientInfo, this);
            }
            else
            {	Client client=new Client( clientId);	
				if(client.IsNew)
				throw new AppException("尚未初始化");
               	LoadFromDAL(this, client);
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
        public static  ClientInfo Find(List< ClientInfo> list,  int clientId)
        {
             return list.Find(delegate( ClientInfo item) { return item. clientId==clientId; });
        }
		
		
		/// <summary>
        /// 得到缓存键
        /// </summary>
        /// <returns></returns>
        private static string GetCacheKey()
        {
            return string.Format(CachedEntityCommander.CacheKey, typeof( ClientInfo).ToString());
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
        public static void Copy(ClientInfo pClientInfoFrom, ClientInfo pClientInfoTo)
        {
	 		pClientInfoTo.ClientId = pClientInfoFrom.clientId;
	 		pClientInfoTo.ClientName = pClientInfoFrom.clientName;
	 		pClientInfoTo.ClientLevelId = pClientInfoFrom.clientLevelId;
	 		pClientInfoTo.Address = pClientInfoFrom.address;
	 		pClientInfoTo.Telephone = pClientInfoFrom.telephone;
	 		pClientInfoTo.MailNo = pClientInfoFrom.mailNo;
	 		pClientInfoTo.Fax = pClientInfoFrom.fax;
	 		pClientInfoTo.EmployeeId = pClientInfoFrom.employeeId;
	 		pClientInfoTo.ClientTypeId = pClientInfoFrom.clientTypeId;
	 		pClientInfoTo.SheetNum = pClientInfoFrom.sheetNum;
			pClientInfoTo.Loaded=pClientInfoFrom.Loaded;
        }
		
		/// <summary>
		/// 批量装载
		/// </summary>
		internal static void LoadFromDALPatch(List< ClientInfo> pList, ClientCollection pCollection)
        {
            foreach (Client client in pCollection)
            {
                ClientInfo clientInfo = new ClientInfo();
                LoadFromDAL(clientInfo, client );
                pList.Add(clientInfo);
            }
			
        }

		//从后台获取数据
		internal  static void  LoadFromDAL(ClientInfo pClientInfo, Client  pClient)
		{
	 		pClientInfo.clientId = pClient.ClientId;
	 		pClientInfo.clientName = pClient.ClientName;
	 		pClientInfo.clientLevelId = pClient.ClientLevelId;
	 		pClientInfo.address = pClient.Address;
	 		pClientInfo.telephone = pClient.Telephone;
	 		pClientInfo.mailNo = pClient.MailNo;
	 		pClientInfo.fax = pClient.Fax;
	 		pClientInfo.employeeId = pClient.EmployeeId;
	 		pClientInfo.clientTypeId = pClient.ClientTypeId;
	 		pClientInfo.sheetNum = pClient.SheetNum;
			pClientInfo.Loaded=true;
			
			}
		
		//数据持久化
		internal  static void  SaveToDb(ClientInfo pClientInfo, Client  pClient,bool pIsNew)
		{
	 		pClient.ClientId = pClientInfo.clientId;
	 		pClient.ClientName = pClientInfo.clientName;
	 		pClient.ClientLevelId = pClientInfo.clientLevelId;
	 		pClient.Address = pClientInfo.address;
	 		pClient.Telephone = pClientInfo.telephone;
	 		pClient.MailNo = pClientInfo.mailNo;
	 		pClient.Fax = pClientInfo.fax;
	 		pClient.EmployeeId = pClientInfo.employeeId;
	 		pClient.ClientTypeId = pClientInfo.clientTypeId;
	 		pClient.SheetNum = pClientInfo.sheetNum;
			pClient.IsNew=pIsNew;
			string UserName = SubsonicHelper.GetUserName();
			try
			{
				pClient.Save(UserName);
			}
			catch(Exception ex)
			{
				LogManager.getInstance().getLogger(typeof(ClientInfo)).Error(ex);
				if(ex.Message.Contains("插入重复键"))//违反了唯一键
				{
					throw new AppException("此对象已经存在");//此处等待优化可以从唯一约束中直接取出提示来，如果没有的话，默认为原始的出错提示
				}
				throw new AppException("保存失败");
			}
			pClientInfo.clientId = pClient.ClientId;
			//如果缓存存在，更新缓存
			if (CachedEntityCommander.IsTypeRegistered(typeof(ClientInfo))) 
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
        public static List< ClientInfo> GetPagedList(int pPageIndex,int pPageSize,SortDirection pOrderBy,string pSortExpression,out int pRecordCount)
        {
			if(pPageIndex<=1)
			pPageIndex=1;
            List< ClientInfo> list = new List< ClientInfo>();
          
            Query q = Client .CreateQuery();
            q.PageIndex = pPageIndex;
            q.PageSize = pPageSize;
            q.ORDER_BY(pSortExpression,pOrderBy.ToString());
			ClientCollection  collection=new  ClientCollection();
		 	collection.LoadAndCloseReader(q.ExecuteReader());
          
            foreach (Client  client  in collection)
            {
                ClientInfo clientInfo = new ClientInfo();
                LoadFromDAL(clientInfo,   client);
                list.Add(clientInfo);
            }
			pRecordCount=q.GetRecordCount();
			
            return list;

        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		/// <returns></returns>
		public static List< ClientInfo> GetList()
		{
			string cacheKey = GetCacheKey();
			//本实体已经注册成缓存实体，并且缓存存在的时候，直接从缓存取
			if (CachedEntityCommander.IsTypeRegistered(typeof(ClientInfo)) && CachedEntityCommander.GetCache(cacheKey) != null)
            {
                return CachedEntityCommander.GetCache(cacheKey) as List< ClientInfo>;
            }
            else 
            {
				List< ClientInfo>  list =new List< ClientInfo>();
				ClientCollection  collection=new  ClientCollection();
				Query qry = new Query(Client.Schema);
				collection.LoadAndCloseReader(qry.ExecuteReader());
				foreach(Client client in collection)
				{
					ClientInfo clientInfo= new ClientInfo();
					LoadFromDAL(clientInfo,client);
					list.Add(clientInfo);
				}
			  	//生成缓存
                if (CachedEntityCommander.IsTypeRegistered(typeof(ClientInfo))) 
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
		public int ClientId
		{
			get {return clientId;}
			set {clientId = value;}
		}

		///<summary>
		///
		///</summary>
		public string ClientName
		{
			get {return clientName;}
			set {clientName = value;}
		}

		///<summary>
		///
		///</summary>
		public int? ClientLevelId
		{
			get {return clientLevelId;}
			set {clientLevelId = value;}
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
		///
		///</summary>
		public string Telephone
		{
			get {return telephone;}
			set {telephone = value;}
		}

		///<summary>
		///
		///</summary>
		public string MailNo
		{
			get {return mailNo;}
			set {mailNo = value;}
		}

		///<summary>
		///
		///</summary>
		public string Fax
		{
			get {return fax;}
			set {fax = value;}
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
		public int? ClientTypeId
		{
			get {return clientTypeId;}
			set {clientTypeId = value;}
		}

		///<summary>
		///
		///</summary>
		public string SheetNum
		{
			get {return sheetNum;}
			set {sheetNum = value;}
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
			bool result=  (Client.Delete(ClientId) == 1);
			//更新缓存
			if (result&&CachedEntityCommander.IsTypeRegistered(typeof(ClientInfo))) 
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
        public void CopyTo(ClientInfo pClientInfoTo)
        {
            Copy(this,  pClientInfoTo);
        }
		
		
		
		
		
		/// <summary>
		/// 保存
		/// </summary>
		public override void Save()
		{
			if(!m_Loaded)//新增
			{
				Client client=new Client();	
				SaveToDb(this, client,true);
			}
			else//修改
			{
				Client client=new Client(clientId);	
				if(client.IsNew)
					throw new AppException("该数据已经不存在了");
				SaveToDb(this, client,false);
			}
			
		}
		 
		#endregion
		
	}
}
