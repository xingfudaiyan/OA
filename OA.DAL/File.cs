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
	/// Strongly-typed collection for the File class.
	/// </summary>
    [Serializable]
	public partial class FileCollection : ActiveList<File, FileCollection>
	{	   
		public FileCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>FileCollection</returns>
		public FileCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                File o = this[i];
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
	/// This is an ActiveRecord class which wraps the File_tb table.
	/// </summary>
	[Serializable]
	public partial class File : ActiveRecord<File>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public File()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public File(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public File(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public File(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("File_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarFileId = new TableSchema.TableColumn(schema);
				colvarFileId.ColumnName = "FileId";
				colvarFileId.DataType = DbType.Int32;
				colvarFileId.MaxLength = 0;
				colvarFileId.AutoIncrement = true;
				colvarFileId.IsNullable = false;
				colvarFileId.IsPrimaryKey = true;
				colvarFileId.IsForeignKey = false;
				colvarFileId.IsReadOnly = false;
				colvarFileId.DefaultSetting = @"";
				colvarFileId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFileId);
				
				TableSchema.TableColumn colvarFileTypeId = new TableSchema.TableColumn(schema);
				colvarFileTypeId.ColumnName = "FileTypeId";
				colvarFileTypeId.DataType = DbType.Int32;
				colvarFileTypeId.MaxLength = 0;
				colvarFileTypeId.AutoIncrement = false;
				colvarFileTypeId.IsNullable = false;
				colvarFileTypeId.IsPrimaryKey = false;
				colvarFileTypeId.IsForeignKey = true;
				colvarFileTypeId.IsReadOnly = false;
				colvarFileTypeId.DefaultSetting = @"";
				
					colvarFileTypeId.ForeignKeyTableName = "FileType_tb";
				schema.Columns.Add(colvarFileTypeId);
				
				TableSchema.TableColumn colvarFileName = new TableSchema.TableColumn(schema);
				colvarFileName.ColumnName = "FileName";
				colvarFileName.DataType = DbType.String;
				colvarFileName.MaxLength = 50;
				colvarFileName.AutoIncrement = false;
				colvarFileName.IsNullable = false;
				colvarFileName.IsPrimaryKey = false;
				colvarFileName.IsForeignKey = false;
				colvarFileName.IsReadOnly = false;
				colvarFileName.DefaultSetting = @"";
				colvarFileName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFileName);
				
				TableSchema.TableColumn colvarSendEmployeeId = new TableSchema.TableColumn(schema);
				colvarSendEmployeeId.ColumnName = "SendEmployeeId";
				colvarSendEmployeeId.DataType = DbType.Int32;
				colvarSendEmployeeId.MaxLength = 0;
				colvarSendEmployeeId.AutoIncrement = false;
				colvarSendEmployeeId.IsNullable = false;
				colvarSendEmployeeId.IsPrimaryKey = false;
				colvarSendEmployeeId.IsForeignKey = true;
				colvarSendEmployeeId.IsReadOnly = false;
				colvarSendEmployeeId.DefaultSetting = @"";
				
					colvarSendEmployeeId.ForeignKeyTableName = "Employee_tb";
				schema.Columns.Add(colvarSendEmployeeId);
				
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
				
				TableSchema.TableColumn colvarSendTime = new TableSchema.TableColumn(schema);
				colvarSendTime.ColumnName = "SendTime";
				colvarSendTime.DataType = DbType.DateTime;
				colvarSendTime.MaxLength = 0;
				colvarSendTime.AutoIncrement = false;
				colvarSendTime.IsNullable = false;
				colvarSendTime.IsPrimaryKey = false;
				colvarSendTime.IsForeignKey = false;
				colvarSendTime.IsReadOnly = false;
				colvarSendTime.DefaultSetting = @"";
				colvarSendTime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSendTime);
				
				TableSchema.TableColumn colvarMemo = new TableSchema.TableColumn(schema);
				colvarMemo.ColumnName = "Memo";
				colvarMemo.DataType = DbType.String;
				colvarMemo.MaxLength = -1;
				colvarMemo.AutoIncrement = false;
				colvarMemo.IsNullable = true;
				colvarMemo.IsPrimaryKey = false;
				colvarMemo.IsForeignKey = false;
				colvarMemo.IsReadOnly = false;
				colvarMemo.DefaultSetting = @"";
				colvarMemo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMemo);
				
				TableSchema.TableColumn colvarIsCommon = new TableSchema.TableColumn(schema);
				colvarIsCommon.ColumnName = "IsCommon";
				colvarIsCommon.DataType = DbType.Int32;
				colvarIsCommon.MaxLength = 0;
				colvarIsCommon.AutoIncrement = false;
				colvarIsCommon.IsNullable = true;
				colvarIsCommon.IsPrimaryKey = false;
				colvarIsCommon.IsForeignKey = false;
				colvarIsCommon.IsReadOnly = false;
				colvarIsCommon.DefaultSetting = @"";
				colvarIsCommon.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIsCommon);
				
				TableSchema.TableColumn colvarIsDelete = new TableSchema.TableColumn(schema);
				colvarIsDelete.ColumnName = "IsDelete";
				colvarIsDelete.DataType = DbType.Int32;
				colvarIsDelete.MaxLength = 0;
				colvarIsDelete.AutoIncrement = false;
				colvarIsDelete.IsNullable = true;
				colvarIsDelete.IsPrimaryKey = false;
				colvarIsDelete.IsForeignKey = false;
				colvarIsDelete.IsReadOnly = false;
				colvarIsDelete.DefaultSetting = @"";
				colvarIsDelete.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIsDelete);
				
				TableSchema.TableColumn colvarIsMsg = new TableSchema.TableColumn(schema);
				colvarIsMsg.ColumnName = "IsMsg";
				colvarIsMsg.DataType = DbType.Int32;
				colvarIsMsg.MaxLength = 0;
				colvarIsMsg.AutoIncrement = false;
				colvarIsMsg.IsNullable = true;
				colvarIsMsg.IsPrimaryKey = false;
				colvarIsMsg.IsForeignKey = false;
				colvarIsMsg.IsReadOnly = false;
				colvarIsMsg.DefaultSetting = @"";
				colvarIsMsg.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIsMsg);
				
				TableSchema.TableColumn colvarFilePermissionId = new TableSchema.TableColumn(schema);
				colvarFilePermissionId.ColumnName = "FilePermissionId";
				colvarFilePermissionId.DataType = DbType.Int32;
				colvarFilePermissionId.MaxLength = 0;
				colvarFilePermissionId.AutoIncrement = false;
				colvarFilePermissionId.IsNullable = true;
				colvarFilePermissionId.IsPrimaryKey = false;
				colvarFilePermissionId.IsForeignKey = false;
				colvarFilePermissionId.IsReadOnly = false;
				colvarFilePermissionId.DefaultSetting = @"";
				colvarFilePermissionId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFilePermissionId);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("File_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("FileId")]
		[Bindable(true)]
		public int FileId 
		{
			get { return GetColumnValue<int>(Columns.FileId); }
			set { SetColumnValue(Columns.FileId, value); }
		}
		  
		[XmlAttribute("FileTypeId")]
		[Bindable(true)]
		public int FileTypeId 
		{
			get { return GetColumnValue<int>(Columns.FileTypeId); }
			set { SetColumnValue(Columns.FileTypeId, value); }
		}
		  
		[XmlAttribute("FileName")]
		[Bindable(true)]
		public string FileName 
		{
			get { return GetColumnValue<string>(Columns.FileName); }
			set { SetColumnValue(Columns.FileName, value); }
		}
		  
		[XmlAttribute("SendEmployeeId")]
		[Bindable(true)]
		public int SendEmployeeId 
		{
			get { return GetColumnValue<int>(Columns.SendEmployeeId); }
			set { SetColumnValue(Columns.SendEmployeeId, value); }
		}
		  
		[XmlAttribute("RecvEmployeeId")]
		[Bindable(true)]
		public int? RecvEmployeeId 
		{
			get { return GetColumnValue<int?>(Columns.RecvEmployeeId); }
			set { SetColumnValue(Columns.RecvEmployeeId, value); }
		}
		  
		[XmlAttribute("SendTime")]
		[Bindable(true)]
		public DateTime SendTime 
		{
			get { return GetColumnValue<DateTime>(Columns.SendTime); }
			set { SetColumnValue(Columns.SendTime, value); }
		}
		  
		[XmlAttribute("Memo")]
		[Bindable(true)]
		public string Memo 
		{
			get { return GetColumnValue<string>(Columns.Memo); }
			set { SetColumnValue(Columns.Memo, value); }
		}
		  
		[XmlAttribute("IsCommon")]
		[Bindable(true)]
		public int? IsCommon 
		{
			get { return GetColumnValue<int?>(Columns.IsCommon); }
			set { SetColumnValue(Columns.IsCommon, value); }
		}
		  
		[XmlAttribute("IsDelete")]
		[Bindable(true)]
		public int? IsDelete 
		{
			get { return GetColumnValue<int?>(Columns.IsDelete); }
			set { SetColumnValue(Columns.IsDelete, value); }
		}
		  
		[XmlAttribute("IsMsg")]
		[Bindable(true)]
		public int? IsMsg 
		{
			get { return GetColumnValue<int?>(Columns.IsMsg); }
			set { SetColumnValue(Columns.IsMsg, value); }
		}
		  
		[XmlAttribute("FilePermissionId")]
		[Bindable(true)]
		public int? FilePermissionId 
		{
			get { return GetColumnValue<int?>(Columns.FilePermissionId); }
			set { SetColumnValue(Columns.FilePermissionId, value); }
		}
		
		#endregion
		
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a Employee ActiveRecord object related to this File
		/// 
		/// </summary>
		public CanYou.OA.DAL.Employee Employee
		{
			get { return CanYou.OA.DAL.Employee.FetchByID(this.SendEmployeeId); }
			set { SetColumnValue("SendEmployeeId", value.EmployeeId); }
		}
		
		
		/// <summary>
		/// Returns a FileType ActiveRecord object related to this File
		/// 
		/// </summary>
		public CanYou.OA.DAL.FileType FileType
		{
			get { return CanYou.OA.DAL.FileType.FetchByID(this.FileTypeId); }
			set { SetColumnValue("FileTypeId", value.FileTypeId); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varFileTypeId,string varFileName,int varSendEmployeeId,int? varRecvEmployeeId,DateTime varSendTime,string varMemo,int? varIsCommon,int? varIsDelete,int? varIsMsg,int? varFilePermissionId)
		{
			File item = new File();
			
			item.FileTypeId = varFileTypeId;
			
			item.FileName = varFileName;
			
			item.SendEmployeeId = varSendEmployeeId;
			
			item.RecvEmployeeId = varRecvEmployeeId;
			
			item.SendTime = varSendTime;
			
			item.Memo = varMemo;
			
			item.IsCommon = varIsCommon;
			
			item.IsDelete = varIsDelete;
			
			item.IsMsg = varIsMsg;
			
			item.FilePermissionId = varFilePermissionId;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varFileId,int varFileTypeId,string varFileName,int varSendEmployeeId,int? varRecvEmployeeId,DateTime varSendTime,string varMemo,int? varIsCommon,int? varIsDelete,int? varIsMsg,int? varFilePermissionId)
		{
			File item = new File();
			
				item.FileId = varFileId;
			
				item.FileTypeId = varFileTypeId;
			
				item.FileName = varFileName;
			
				item.SendEmployeeId = varSendEmployeeId;
			
				item.RecvEmployeeId = varRecvEmployeeId;
			
				item.SendTime = varSendTime;
			
				item.Memo = varMemo;
			
				item.IsCommon = varIsCommon;
			
				item.IsDelete = varIsDelete;
			
				item.IsMsg = varIsMsg;
			
				item.FilePermissionId = varFilePermissionId;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn FileIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn FileTypeIdColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn FileNameColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn SendEmployeeIdColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn RecvEmployeeIdColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn SendTimeColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn MemoColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn IsCommonColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn IsDeleteColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn IsMsgColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn FilePermissionIdColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string FileId = @"FileId";
			 public static string FileTypeId = @"FileTypeId";
			 public static string FileName = @"FileName";
			 public static string SendEmployeeId = @"SendEmployeeId";
			 public static string RecvEmployeeId = @"RecvEmployeeId";
			 public static string SendTime = @"SendTime";
			 public static string Memo = @"Memo";
			 public static string IsCommon = @"IsCommon";
			 public static string IsDelete = @"IsDelete";
			 public static string IsMsg = @"IsMsg";
			 public static string FilePermissionId = @"FilePermissionId";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
