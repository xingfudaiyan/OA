// ======================================================================================================================================
// 类说明
//=======================================================================================================================================
// 创建者：sk @Copy Right 残友软件有限公司OA项目 
// 文件名：MessageInfo.cs
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
	///MessageInfo  Data
	/// </summary>
	[Serializable]
	public partial class MessageInfo:CanYou.EntityObject
	{
		#region 属性
		///<summary>
		///
		///</summary>
		private int messageId;
		///<summary>
		///
		///</summary>
		private string memo = String.Empty;
		///<summary>
		///
		///</summary>
		private int? recvEmployeeId;
		///<summary>
		///
		///</summary>
		private string msg = String.Empty;
		///<summary>
		///
		///</summary>
		private string url = String.Empty;
		///<summary>
		///
		///</summary>
		private string employeeName = String.Empty;
		///<summary>
		///
		///</summary>
		private string msgType = String.Empty;
		///<summary>
		///
		///</summary>
		private string msgTime = String.Empty;
		///<summary>
		///
		///</summary>
		private string msgTitle = String.Empty;
		
		
		///一对多关系,如果
		private bool m_Loaded=false;
		#endregion
		
		#region 属性枚举
		public struct Fields
		{
			public const string MessageId=@"MessageId";
			public const string Memo=@"Memo";
			public const string RecvEmployeeId=@"RecvEmployeeId";
			public const string Msg=@"Msg";
			public const string Url=@"Url";
			public const string EmployeeName=@"EmployeeName";
			public const string MsgType=@"MsgType";
			public const string MsgTime=@"MsgTime";
			public const string MsgTitle=@"MsgTitle";
						
		}

		#endregion
		
		
		#region 构造函数
		///<summary>
		///
		///</summary>
		public MessageInfo()
		{
		}
		///<summary>
		///
		///</summary>
		public MessageInfo(int pMessageId,string pMemo,int? pRecvEmployeeId,string pMsg,string pUrl,string pEmployeeName,string pMsgType,string pMsgTime,string pMsgTitle)
		{
			messageId      = pMessageId;
			memo           = pMemo;
			recvEmployeeId = pRecvEmployeeId;
			msg            = pMsg;
			url            = pUrl;
			employeeName   = pEmployeeName;
			msgType        = pMsgType;
			msgTime        = pMsgTime;
			msgTitle       = pMsgTitle;
			
		}
		
		
		///<summary>
		///
		///</summary>
		public MessageInfo(int messageId)
		{
			 LoadFromId(messageId);
		}
		
		private void LoadFromId(int messageId)
		{
		 
			if (CachedEntityCommander.IsTypeRegistered(typeof(MessageInfo)))
            {
				MessageInfo messageInfo=Find(GetList(), messageId);
				if(messageInfo==null)
					throw new AppException("未能在缓存中找到相应的键值对象");
                Copy(messageInfo, this);
            }
            else
            {	Message message=new Message( messageId);	
				if(message.IsNew)
				throw new AppException("尚未初始化");
               	LoadFromDAL(this, message);
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
        public static  MessageInfo Find(List< MessageInfo> list,  int messageId)
        {
             return list.Find(delegate( MessageInfo item) { return item. messageId==messageId; });
        }
		
		
		/// <summary>
        /// 得到缓存键
        /// </summary>
        /// <returns></returns>
        private static string GetCacheKey()
        {
            return string.Format(CachedEntityCommander.CacheKey, typeof( MessageInfo).ToString());
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
        public static void Copy(MessageInfo pMessageInfoFrom, MessageInfo pMessageInfoTo)
        {
	 		pMessageInfoTo.MessageId = pMessageInfoFrom.messageId;
	 		pMessageInfoTo.Memo = pMessageInfoFrom.memo;
	 		pMessageInfoTo.RecvEmployeeId = pMessageInfoFrom.recvEmployeeId;
	 		pMessageInfoTo.Msg = pMessageInfoFrom.msg;
	 		pMessageInfoTo.Url = pMessageInfoFrom.url;
	 		pMessageInfoTo.EmployeeName = pMessageInfoFrom.employeeName;
	 		pMessageInfoTo.MsgType = pMessageInfoFrom.msgType;
	 		pMessageInfoTo.MsgTime = pMessageInfoFrom.msgTime;
	 		pMessageInfoTo.MsgTitle = pMessageInfoFrom.msgTitle;
			pMessageInfoTo.Loaded=pMessageInfoFrom.Loaded;
        }
		
		/// <summary>
		/// 批量装载
		/// </summary>
		internal static void LoadFromDALPatch(List< MessageInfo> pList, MessageCollection pCollection)
        {
            foreach (Message message in pCollection)
            {
                MessageInfo messageInfo = new MessageInfo();
                LoadFromDAL(messageInfo, message );
                pList.Add(messageInfo);
            }
			
        }

		//从后台获取数据
		internal  static void  LoadFromDAL(MessageInfo pMessageInfo, Message  pMessage)
		{
	 		pMessageInfo.messageId = pMessage.MessageId;
	 		pMessageInfo.memo = pMessage.Memo;
	 		pMessageInfo.recvEmployeeId = pMessage.RecvEmployeeId;
	 		pMessageInfo.msg = pMessage.Msg;
	 		pMessageInfo.url = pMessage.Url;
	 		pMessageInfo.employeeName = pMessage.EmployeeName;
	 		pMessageInfo.msgType = pMessage.MsgType;
	 		pMessageInfo.msgTime = pMessage.MsgTime;
	 		pMessageInfo.msgTitle = pMessage.MsgTitle;
			pMessageInfo.Loaded=true;
			
			}
		
		//数据持久化
		internal  static void  SaveToDb(MessageInfo pMessageInfo, Message  pMessage,bool pIsNew)
		{
	 		pMessage.MessageId = pMessageInfo.messageId;
	 		pMessage.Memo = pMessageInfo.memo;
	 		pMessage.RecvEmployeeId = pMessageInfo.recvEmployeeId;
	 		pMessage.Msg = pMessageInfo.msg;
	 		pMessage.Url = pMessageInfo.url;
	 		pMessage.EmployeeName = pMessageInfo.employeeName;
	 		pMessage.MsgType = pMessageInfo.msgType;
	 		pMessage.MsgTime = pMessageInfo.msgTime;
	 		pMessage.MsgTitle = pMessageInfo.msgTitle;
			pMessage.IsNew=pIsNew;
			string UserName = SubsonicHelper.GetUserName();
			try
			{
				pMessage.Save(UserName);
			}
			catch(Exception ex)
			{
				LogManager.getInstance().getLogger(typeof(MessageInfo)).Error(ex);
				if(ex.Message.Contains("插入重复键"))//违反了唯一键
				{
					throw new AppException("此对象已经存在");//此处等待优化可以从唯一约束中直接取出提示来，如果没有的话，默认为原始的出错提示
				}
				throw new AppException("保存失败");
			}
			pMessageInfo.messageId = pMessage.MessageId;
			//如果缓存存在，更新缓存
			if (CachedEntityCommander.IsTypeRegistered(typeof(MessageInfo))) 
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
        public static List< MessageInfo> GetPagedList(int pPageIndex,int pPageSize,SortDirection pOrderBy,string pSortExpression,out int pRecordCount)
        {
			if(pPageIndex<=1)
			pPageIndex=1;
            List< MessageInfo> list = new List< MessageInfo>();
          
            Query q = Message .CreateQuery();
            q.PageIndex = pPageIndex;
            q.PageSize = pPageSize;
            q.ORDER_BY(pSortExpression,pOrderBy.ToString());
			MessageCollection  collection=new  MessageCollection();
		 	collection.LoadAndCloseReader(q.ExecuteReader());
          
            foreach (Message  message  in collection)
            {
                MessageInfo messageInfo = new MessageInfo();
                LoadFromDAL(messageInfo,   message);
                list.Add(messageInfo);
            }
			pRecordCount=q.GetRecordCount();
			
            return list;

        }
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		/// <returns></returns>
		public static List< MessageInfo> GetList()
		{
			string cacheKey = GetCacheKey();
			//本实体已经注册成缓存实体，并且缓存存在的时候，直接从缓存取
			if (CachedEntityCommander.IsTypeRegistered(typeof(MessageInfo)) && CachedEntityCommander.GetCache(cacheKey) != null)
            {
                return CachedEntityCommander.GetCache(cacheKey) as List< MessageInfo>;
            }
            else 
            {
				List< MessageInfo>  list =new List< MessageInfo>();
				MessageCollection  collection=new  MessageCollection();
				Query qry = new Query(Message.Schema);
				collection.LoadAndCloseReader(qry.ExecuteReader());
				foreach(Message message in collection)
				{
					MessageInfo messageInfo= new MessageInfo();
					LoadFromDAL(messageInfo,message);
					list.Add(messageInfo);
				}
			  	//生成缓存
                if (CachedEntityCommander.IsTypeRegistered(typeof(MessageInfo))) 
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
		public int MessageId
		{
			get {return messageId;}
			set {messageId = value;}
		}

		///<summary>
		///
		///</summary>
		public string Memo
		{
			get {return memo;}
			set {memo = value;}
		}

		///<summary>
		///
		///</summary>
		public int? RecvEmployeeId
		{
			get {return recvEmployeeId;}
			set {recvEmployeeId = value;}
		}

		///<summary>
		///
		///</summary>
		public string Msg
		{
			get {return msg;}
			set {msg = value;}
		}

		///<summary>
		///
		///</summary>
		public string Url
		{
			get {return url;}
			set {url = value;}
		}

		///<summary>
		///
		///</summary>
		public string EmployeeName
		{
			get {return employeeName;}
			set {employeeName = value;}
		}

		///<summary>
		///
		///</summary>
		public string MsgType
		{
			get {return msgType;}
			set {msgType = value;}
		}

		///<summary>
		///
		///</summary>
		public string MsgTime
		{
			get {return msgTime;}
			set {msgTime = value;}
		}

		///<summary>
		///
		///</summary>
		public string MsgTitle
		{
			get {return msgTitle;}
			set {msgTitle = value;}
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
			bool result=  (Message.Delete(MessageId) == 1);
			//更新缓存
			if (result&&CachedEntityCommander.IsTypeRegistered(typeof(MessageInfo))) 
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
        public void CopyTo(MessageInfo pMessageInfoTo)
        {
            Copy(this,  pMessageInfoTo);
        }
		
		
		
		
		
		/// <summary>
		/// 保存
		/// </summary>
		public override void Save()
		{
			if(!m_Loaded)//新增
			{
				Message message=new Message();	
				SaveToDb(this, message,true);
			}
			else//修改
			{
				Message message=new Message(messageId);	
				if(message.IsNew)
					throw new AppException("该数据已经不存在了");
				SaveToDb(this, message,false);
			}
			
		}
		 
		#endregion
		
	}
}
