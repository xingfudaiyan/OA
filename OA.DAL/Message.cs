using System; 
using System.Text; 
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration; 
using System.Xml; 
using System.Xml.Serialization;
using SubSonic; 
using SubSonic.Utilities;
namespace CanYou.OA.DAL
{
	/// <summary>
	/// Strongly-typed collection for the Message class.
	/// </summary>
    [Serializable]
	public partial class MessageCollection : ActiveList<Message, MessageCollection>
	{	   
		public MessageCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>MessageCollection</returns>
		public MessageCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                Message o = this[i];
                foreach (SubSonic.Where w in this.wheres)
                {
                    bool remove = false;
                    System.Reflection.PropertyInfo pi = o.GetType().GetProperty(w.ColumnName);
                    if (pi.CanRead)
                    {
                        object val = pi.GetValue(o, null);
                        switch (w.Comparison)
                        {
                            case SubSonic.Comparison.Equals:
                                if (!val.Equals(w.ParameterValue))
                                {
                                    remove = true;
                                }
                                break;
                        }
                    }
                    if (remove)
                    {
                        this.Remove(o);
                        break;
                    }
                }
            }
            return this;
        }
		
		
	}
	/// <summary>
	/// This is an ActiveRecord class which wraps the Message_tb table.
	/// </summary>
	[Serializable]
	public partial class Message : ActiveRecord<Message>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public Message()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public Message(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public Message(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public Message(string columnName, object columnValue)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByParam(columnName,columnValue);
		}
		
		protected static void SetSQLProps() { GetTableSchema(); }
		
		#endregion
		
		#region Schema and Query Accessor	
		public static Query CreateQuery() { return new Query(Schema); }
		public static TableSchema.Table Schema
		{
			get
			{
				if (BaseSchema == null)
					SetSQLProps();
				return BaseSchema;
			}
		}
		
		private static void GetTableSchema() 
		{
			if(!IsSchemaInitialized)
			{
				//Schema declaration
				TableSchema.Table schema = new TableSchema.Table("Message_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarMessageId = new TableSchema.TableColumn(schema);
				colvarMessageId.ColumnName = "MessageId";
				colvarMessageId.DataType = DbType.Int32;
				colvarMessageId.MaxLength = 0;
				colvarMessageId.AutoIncrement = true;
				colvarMessageId.IsNullable = false;
				colvarMessageId.IsPrimaryKey = true;
				colvarMessageId.IsForeignKey = false;
				colvarMessageId.IsReadOnly = false;
				colvarMessageId.DefaultSetting = @"";
				colvarMessageId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMessageId);
				
				TableSchema.TableColumn colvarMemo = new TableSchema.TableColumn(schema);
				colvarMemo.ColumnName = "Memo";
				colvarMemo.DataType = DbType.String;
				colvarMemo.MaxLength = 50;
				colvarMemo.AutoIncrement = false;
				colvarMemo.IsNullable = true;
				colvarMemo.IsPrimaryKey = false;
				colvarMemo.IsForeignKey = false;
				colvarMemo.IsReadOnly = false;
				colvarMemo.DefaultSetting = @"";
				colvarMemo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMemo);
				
				TableSchema.TableColumn colvarRecvEmployeeId = new TableSchema.TableColumn(schema);
				colvarRecvEmployeeId.ColumnName = "RecvEmployeeId";
				colvarRecvEmployeeId.DataType = DbType.Int32;
				colvarRecvEmployeeId.MaxLength = 0;
				colvarRecvEmployeeId.AutoIncrement = false;
				colvarRecvEmployeeId.IsNullable = true;
				colvarRecvEmployeeId.IsPrimaryKey = false;
				colvarRecvEmployeeId.IsForeignKey = false;
				colvarRecvEmployeeId.IsReadOnly = false;
				colvarRecvEmployeeId.DefaultSetting = @"";
				colvarRecvEmployeeId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRecvEmployeeId);
				
				TableSchema.TableColumn colvarMsg = new TableSchema.TableColumn(schema);
				colvarMsg.ColumnName = "Msg";
				colvarMsg.DataType = DbType.String;
				colvarMsg.MaxLength = 50;
				colvarMsg.AutoIncrement = false;
				colvarMsg.IsNullable = true;
				colvarMsg.IsPrimaryKey = false;
				colvarMsg.IsForeignKey = false;
				colvarMsg.IsReadOnly = false;
				colvarMsg.DefaultSetting = @"";
				colvarMsg.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMsg);
				
				TableSchema.TableColumn colvarUrl = new TableSchema.TableColumn(schema);
				colvarUrl.ColumnName = "Url";
				colvarUrl.DataType = DbType.String;
				colvarUrl.MaxLength = 50;
				colvarUrl.AutoIncrement = false;
				colvarUrl.IsNullable = true;
				colvarUrl.IsPrimaryKey = false;
				colvarUrl.IsForeignKey = false;
				colvarUrl.IsReadOnly = false;
				colvarUrl.DefaultSetting = @"";
				colvarUrl.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUrl);
				
				TableSchema.TableColumn colvarEmployeeName = new TableSchema.TableColumn(schema);
				colvarEmployeeName.ColumnName = "EmployeeName";
				colvarEmployeeName.DataType = DbType.String;
				colvarEmployeeName.MaxLength = 50;
				colvarEmployeeName.AutoIncrement = false;
				colvarEmployeeName.IsNullable = true;
				colvarEmployeeName.IsPrimaryKey = false;
				colvarEmployeeName.IsForeignKey = false;
				colvarEmployeeName.IsReadOnly = false;
				colvarEmployeeName.DefaultSetting = @"";
				colvarEmployeeName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEmployeeName);
				
				TableSchema.TableColumn colvarMsgType = new TableSchema.TableColumn(schema);
				colvarMsgType.ColumnName = "MsgType";
				colvarMsgType.DataType = DbType.String;
				colvarMsgType.MaxLength = 50;
				colvarMsgType.AutoIncrement = false;
				colvarMsgType.IsNullable = true;
				colvarMsgType.IsPrimaryKey = false;
				colvarMsgType.IsForeignKey = false;
				colvarMsgType.IsReadOnly = false;
				colvarMsgType.DefaultSetting = @"";
				colvarMsgType.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMsgType);
				
				TableSchema.TableColumn colvarMsgTime = new TableSchema.TableColumn(schema);
				colvarMsgTime.ColumnName = "MsgTime";
				colvarMsgTime.DataType = DbType.String;
				colvarMsgTime.MaxLength = 50;
				colvarMsgTime.AutoIncrement = false;
				colvarMsgTime.IsNullable = true;
				colvarMsgTime.IsPrimaryKey = false;
				colvarMsgTime.IsForeignKey = false;
				colvarMsgTime.IsReadOnly = false;
				colvarMsgTime.DefaultSetting = @"";
				colvarMsgTime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMsgTime);
				
				TableSchema.TableColumn colvarMsgTitle = new TableSchema.TableColumn(schema);
				colvarMsgTitle.ColumnName = "MsgTitle";
				colvarMsgTitle.DataType = DbType.String;
				colvarMsgTitle.MaxLength = 50;
				colvarMsgTitle.AutoIncrement = false;
				colvarMsgTitle.IsNullable = true;
				colvarMsgTitle.IsPrimaryKey = false;
				colvarMsgTitle.IsForeignKey = false;
				colvarMsgTitle.IsReadOnly = false;
				colvarMsgTitle.DefaultSetting = @"";
				colvarMsgTitle.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMsgTitle);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("Message_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("MessageId")]
		[Bindable(true)]
		public int MessageId 
		{
			get { return GetColumnValue<int>(Columns.MessageId); }
			set { SetColumnValue(Columns.MessageId, value); }
		}
		  
		[XmlAttribute("Memo")]
		[Bindable(true)]
		public string Memo 
		{
			get { return GetColumnValue<string>(Columns.Memo); }
			set { SetColumnValue(Columns.Memo, value); }
		}
		  
		[XmlAttribute("RecvEmployeeId")]
		[Bindable(true)]
		public int? RecvEmployeeId 
		{
			get { return GetColumnValue<int?>(Columns.RecvEmployeeId); }
			set { SetColumnValue(Columns.RecvEmployeeId, value); }
		}
		  
		[XmlAttribute("Msg")]
		[Bindable(true)]
		public string Msg 
		{
			get { return GetColumnValue<string>(Columns.Msg); }
			set { SetColumnValue(Columns.Msg, value); }
		}
		  
		[XmlAttribute("Url")]
		[Bindable(true)]
		public string Url 
		{
			get { return GetColumnValue<string>(Columns.Url); }
			set { SetColumnValue(Columns.Url, value); }
		}
		  
		[XmlAttribute("EmployeeName")]
		[Bindable(true)]
		public string EmployeeName 
		{
			get { return GetColumnValue<string>(Columns.EmployeeName); }
			set { SetColumnValue(Columns.EmployeeName, value); }
		}
		  
		[XmlAttribute("MsgType")]
		[Bindable(true)]
		public string MsgType 
		{
			get { return GetColumnValue<string>(Columns.MsgType); }
			set { SetColumnValue(Columns.MsgType, value); }
		}
		  
		[XmlAttribute("MsgTime")]
		[Bindable(true)]
		public string MsgTime 
		{
			get { return GetColumnValue<string>(Columns.MsgTime); }
			set { SetColumnValue(Columns.MsgTime, value); }
		}
		  
		[XmlAttribute("MsgTitle")]
		[Bindable(true)]
		public string MsgTitle 
		{
			get { return GetColumnValue<string>(Columns.MsgTitle); }
			set { SetColumnValue(Columns.MsgTitle, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varMemo,int? varRecvEmployeeId,string varMsg,string varUrl,string varEmployeeName,string varMsgType,string varMsgTime,string varMsgTitle)
		{
			Message item = new Message();
			
			item.Memo = varMemo;
			
			item.RecvEmployeeId = varRecvEmployeeId;
			
			item.Msg = varMsg;
			
			item.Url = varUrl;
			
			item.EmployeeName = varEmployeeName;
			
			item.MsgType = varMsgType;
			
			item.MsgTime = varMsgTime;
			
			item.MsgTitle = varMsgTitle;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varMessageId,string varMemo,int? varRecvEmployeeId,string varMsg,string varUrl,string varEmployeeName,string varMsgType,string varMsgTime,string varMsgTitle)
		{
			Message item = new Message();
			
				item.MessageId = varMessageId;
			
				item.Memo = varMemo;
			
				item.RecvEmployeeId = varRecvEmployeeId;
			
				item.Msg = varMsg;
			
				item.Url = varUrl;
			
				item.EmployeeName = varEmployeeName;
			
				item.MsgType = varMsgType;
			
				item.MsgTime = varMsgTime;
			
				item.MsgTitle = varMsgTitle;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn MessageIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn MemoColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn RecvEmployeeIdColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn MsgColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn UrlColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn EmployeeNameColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn MsgTypeColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn MsgTimeColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn MsgTitleColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string MessageId = @"MessageId";
			 public static string Memo = @"Memo";
			 public static string RecvEmployeeId = @"RecvEmployeeId";
			 public static string Msg = @"Msg";
			 public static string Url = @"Url";
			 public static string EmployeeName = @"EmployeeName";
			 public static string MsgType = @"MsgType";
			 public static string MsgTime = @"MsgTime";
			 public static string MsgTitle = @"MsgTitle";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
