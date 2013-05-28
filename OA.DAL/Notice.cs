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
	/// Strongly-typed collection for the Notice class.
	/// </summary>
    [Serializable]
	public partial class NoticeCollection : ActiveList<Notice, NoticeCollection>
	{	   
		public NoticeCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>NoticeCollection</returns>
		public NoticeCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                Notice o = this[i];
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
	/// This is an ActiveRecord class which wraps the Notice_tb table.
	/// </summary>
	[Serializable]
	public partial class Notice : ActiveRecord<Notice>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public Notice()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public Notice(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public Notice(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public Notice(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("Notice_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarNoticeId = new TableSchema.TableColumn(schema);
				colvarNoticeId.ColumnName = "NoticeId";
				colvarNoticeId.DataType = DbType.Int32;
				colvarNoticeId.MaxLength = 0;
				colvarNoticeId.AutoIncrement = true;
				colvarNoticeId.IsNullable = false;
				colvarNoticeId.IsPrimaryKey = true;
				colvarNoticeId.IsForeignKey = false;
				colvarNoticeId.IsReadOnly = false;
				colvarNoticeId.DefaultSetting = @"";
				colvarNoticeId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNoticeId);
				
				TableSchema.TableColumn colvarNoticeContent = new TableSchema.TableColumn(schema);
				colvarNoticeContent.ColumnName = "NoticeContent";
				colvarNoticeContent.DataType = DbType.String;
				colvarNoticeContent.MaxLength = -1;
				colvarNoticeContent.AutoIncrement = false;
				colvarNoticeContent.IsNullable = true;
				colvarNoticeContent.IsPrimaryKey = false;
				colvarNoticeContent.IsForeignKey = false;
				colvarNoticeContent.IsReadOnly = false;
				colvarNoticeContent.DefaultSetting = @"";
				colvarNoticeContent.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNoticeContent);
				
				TableSchema.TableColumn colvarSignName = new TableSchema.TableColumn(schema);
				colvarSignName.ColumnName = "SignName";
				colvarSignName.DataType = DbType.String;
				colvarSignName.MaxLength = 50;
				colvarSignName.AutoIncrement = false;
				colvarSignName.IsNullable = true;
				colvarSignName.IsPrimaryKey = false;
				colvarSignName.IsForeignKey = false;
				colvarSignName.IsReadOnly = false;
				colvarSignName.DefaultSetting = @"";
				colvarSignName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSignName);
				
				TableSchema.TableColumn colvarNoticeTime = new TableSchema.TableColumn(schema);
				colvarNoticeTime.ColumnName = "NoticeTime";
				colvarNoticeTime.DataType = DbType.String;
				colvarNoticeTime.MaxLength = 50;
				colvarNoticeTime.AutoIncrement = false;
				colvarNoticeTime.IsNullable = true;
				colvarNoticeTime.IsPrimaryKey = false;
				colvarNoticeTime.IsForeignKey = false;
				colvarNoticeTime.IsReadOnly = false;
				colvarNoticeTime.DefaultSetting = @"";
				colvarNoticeTime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNoticeTime);
				
				TableSchema.TableColumn colvarNoticeTitle = new TableSchema.TableColumn(schema);
				colvarNoticeTitle.ColumnName = "NoticeTitle";
				colvarNoticeTitle.DataType = DbType.String;
				colvarNoticeTitle.MaxLength = 50;
				colvarNoticeTitle.AutoIncrement = false;
				colvarNoticeTitle.IsNullable = true;
				colvarNoticeTitle.IsPrimaryKey = false;
				colvarNoticeTitle.IsForeignKey = false;
				colvarNoticeTitle.IsReadOnly = false;
				colvarNoticeTitle.DefaultSetting = @"";
				colvarNoticeTitle.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNoticeTitle);
				
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
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("Notice_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("NoticeId")]
		[Bindable(true)]
		public int NoticeId 
		{
			get { return GetColumnValue<int>(Columns.NoticeId); }
			set { SetColumnValue(Columns.NoticeId, value); }
		}
		  
		[XmlAttribute("NoticeContent")]
		[Bindable(true)]
		public string NoticeContent 
		{
			get { return GetColumnValue<string>(Columns.NoticeContent); }
			set { SetColumnValue(Columns.NoticeContent, value); }
		}
		  
		[XmlAttribute("SignName")]
		[Bindable(true)]
		public string SignName 
		{
			get { return GetColumnValue<string>(Columns.SignName); }
			set { SetColumnValue(Columns.SignName, value); }
		}
		  
		[XmlAttribute("NoticeTime")]
		[Bindable(true)]
		public string NoticeTime 
		{
			get { return GetColumnValue<string>(Columns.NoticeTime); }
			set { SetColumnValue(Columns.NoticeTime, value); }
		}
		  
		[XmlAttribute("NoticeTitle")]
		[Bindable(true)]
		public string NoticeTitle 
		{
			get { return GetColumnValue<string>(Columns.NoticeTitle); }
			set { SetColumnValue(Columns.NoticeTitle, value); }
		}
		  
		[XmlAttribute("EmployeeName")]
		[Bindable(true)]
		public string EmployeeName 
		{
			get { return GetColumnValue<string>(Columns.EmployeeName); }
			set { SetColumnValue(Columns.EmployeeName, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varNoticeContent,string varSignName,string varNoticeTime,string varNoticeTitle,string varEmployeeName)
		{
			Notice item = new Notice();
			
			item.NoticeContent = varNoticeContent;
			
			item.SignName = varSignName;
			
			item.NoticeTime = varNoticeTime;
			
			item.NoticeTitle = varNoticeTitle;
			
			item.EmployeeName = varEmployeeName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varNoticeId,string varNoticeContent,string varSignName,string varNoticeTime,string varNoticeTitle,string varEmployeeName)
		{
			Notice item = new Notice();
			
				item.NoticeId = varNoticeId;
			
				item.NoticeContent = varNoticeContent;
			
				item.SignName = varSignName;
			
				item.NoticeTime = varNoticeTime;
			
				item.NoticeTitle = varNoticeTitle;
			
				item.EmployeeName = varEmployeeName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn NoticeIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn NoticeContentColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn SignNameColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn NoticeTimeColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn NoticeTitleColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn EmployeeNameColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string NoticeId = @"NoticeId";
			 public static string NoticeContent = @"NoticeContent";
			 public static string SignName = @"SignName";
			 public static string NoticeTime = @"NoticeTime";
			 public static string NoticeTitle = @"NoticeTitle";
			 public static string EmployeeName = @"EmployeeName";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
