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
	/// Strongly-typed collection for the FileEmployee class.
	/// </summary>
    [Serializable]
	public partial class FileEmployeeCollection : ActiveList<FileEmployee, FileEmployeeCollection>
	{	   
		public FileEmployeeCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>FileEmployeeCollection</returns>
		public FileEmployeeCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                FileEmployee o = this[i];
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
	/// This is an ActiveRecord class which wraps the FileEmployee_tb table.
	/// </summary>
	[Serializable]
	public partial class FileEmployee : ActiveRecord<FileEmployee>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public FileEmployee()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public FileEmployee(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public FileEmployee(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public FileEmployee(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("FileEmployee_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarFileEmployeeId = new TableSchema.TableColumn(schema);
				colvarFileEmployeeId.ColumnName = "FileEmployeeId";
				colvarFileEmployeeId.DataType = DbType.Int32;
				colvarFileEmployeeId.MaxLength = 0;
				colvarFileEmployeeId.AutoIncrement = true;
				colvarFileEmployeeId.IsNullable = false;
				colvarFileEmployeeId.IsPrimaryKey = true;
				colvarFileEmployeeId.IsForeignKey = false;
				colvarFileEmployeeId.IsReadOnly = false;
				colvarFileEmployeeId.DefaultSetting = @"";
				colvarFileEmployeeId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFileEmployeeId);
				
				TableSchema.TableColumn colvarFileId = new TableSchema.TableColumn(schema);
				colvarFileId.ColumnName = "FileId";
				colvarFileId.DataType = DbType.Int32;
				colvarFileId.MaxLength = 0;
				colvarFileId.AutoIncrement = false;
				colvarFileId.IsNullable = true;
				colvarFileId.IsPrimaryKey = false;
				colvarFileId.IsForeignKey = false;
				colvarFileId.IsReadOnly = false;
				colvarFileId.DefaultSetting = @"";
				colvarFileId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFileId);
				
				TableSchema.TableColumn colvarEmployeeId = new TableSchema.TableColumn(schema);
				colvarEmployeeId.ColumnName = "EmployeeId";
				colvarEmployeeId.DataType = DbType.Int32;
				colvarEmployeeId.MaxLength = 0;
				colvarEmployeeId.AutoIncrement = false;
				colvarEmployeeId.IsNullable = true;
				colvarEmployeeId.IsPrimaryKey = false;
				colvarEmployeeId.IsForeignKey = false;
				colvarEmployeeId.IsReadOnly = false;
				colvarEmployeeId.DefaultSetting = @"";
				colvarEmployeeId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEmployeeId);
				
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
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("FileEmployee_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("FileEmployeeId")]
		[Bindable(true)]
		public int FileEmployeeId 
		{
			get { return GetColumnValue<int>(Columns.FileEmployeeId); }
			set { SetColumnValue(Columns.FileEmployeeId, value); }
		}
		  
		[XmlAttribute("FileId")]
		[Bindable(true)]
		public int? FileId 
		{
			get { return GetColumnValue<int?>(Columns.FileId); }
			set { SetColumnValue(Columns.FileId, value); }
		}
		  
		[XmlAttribute("EmployeeId")]
		[Bindable(true)]
		public int? EmployeeId 
		{
			get { return GetColumnValue<int?>(Columns.EmployeeId); }
			set { SetColumnValue(Columns.EmployeeId, value); }
		}
		  
		[XmlAttribute("IsMsg")]
		[Bindable(true)]
		public int? IsMsg 
		{
			get { return GetColumnValue<int?>(Columns.IsMsg); }
			set { SetColumnValue(Columns.IsMsg, value); }
		}
		  
		[XmlAttribute("IsDelete")]
		[Bindable(true)]
		public int? IsDelete 
		{
			get { return GetColumnValue<int?>(Columns.IsDelete); }
			set { SetColumnValue(Columns.IsDelete, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int? varFileId,int? varEmployeeId,int? varIsMsg,int? varIsDelete)
		{
			FileEmployee item = new FileEmployee();
			
			item.FileId = varFileId;
			
			item.EmployeeId = varEmployeeId;
			
			item.IsMsg = varIsMsg;
			
			item.IsDelete = varIsDelete;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varFileEmployeeId,int? varFileId,int? varEmployeeId,int? varIsMsg,int? varIsDelete)
		{
			FileEmployee item = new FileEmployee();
			
				item.FileEmployeeId = varFileEmployeeId;
			
				item.FileId = varFileId;
			
				item.EmployeeId = varEmployeeId;
			
				item.IsMsg = varIsMsg;
			
				item.IsDelete = varIsDelete;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn FileEmployeeIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn FileIdColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn EmployeeIdColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn IsMsgColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn IsDeleteColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string FileEmployeeId = @"FileEmployeeId";
			 public static string FileId = @"FileId";
			 public static string EmployeeId = @"EmployeeId";
			 public static string IsMsg = @"IsMsg";
			 public static string IsDelete = @"IsDelete";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
