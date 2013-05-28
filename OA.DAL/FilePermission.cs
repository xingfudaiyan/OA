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
	/// Strongly-typed collection for the FilePermission class.
	/// </summary>
    [Serializable]
	public partial class FilePermissionCollection : ActiveList<FilePermission, FilePermissionCollection>
	{	   
		public FilePermissionCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>FilePermissionCollection</returns>
		public FilePermissionCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                FilePermission o = this[i];
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
	/// This is an ActiveRecord class which wraps the FilePermission_tb table.
	/// </summary>
	[Serializable]
	public partial class FilePermission : ActiveRecord<FilePermission>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public FilePermission()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public FilePermission(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public FilePermission(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public FilePermission(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("FilePermission_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarFilePermissionId = new TableSchema.TableColumn(schema);
				colvarFilePermissionId.ColumnName = "FilePermissionId";
				colvarFilePermissionId.DataType = DbType.Int32;
				colvarFilePermissionId.MaxLength = 0;
				colvarFilePermissionId.AutoIncrement = true;
				colvarFilePermissionId.IsNullable = false;
				colvarFilePermissionId.IsPrimaryKey = true;
				colvarFilePermissionId.IsForeignKey = false;
				colvarFilePermissionId.IsReadOnly = false;
				colvarFilePermissionId.DefaultSetting = @"";
				colvarFilePermissionId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFilePermissionId);
				
				TableSchema.TableColumn colvarFilePermissionName = new TableSchema.TableColumn(schema);
				colvarFilePermissionName.ColumnName = "FilePermissionName";
				colvarFilePermissionName.DataType = DbType.String;
				colvarFilePermissionName.MaxLength = 20;
				colvarFilePermissionName.AutoIncrement = false;
				colvarFilePermissionName.IsNullable = true;
				colvarFilePermissionName.IsPrimaryKey = false;
				colvarFilePermissionName.IsForeignKey = false;
				colvarFilePermissionName.IsReadOnly = false;
				colvarFilePermissionName.DefaultSetting = @"";
				colvarFilePermissionName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFilePermissionName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("FilePermission_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("FilePermissionId")]
		[Bindable(true)]
		public int FilePermissionId 
		{
			get { return GetColumnValue<int>(Columns.FilePermissionId); }
			set { SetColumnValue(Columns.FilePermissionId, value); }
		}
		  
		[XmlAttribute("FilePermissionName")]
		[Bindable(true)]
		public string FilePermissionName 
		{
			get { return GetColumnValue<string>(Columns.FilePermissionName); }
			set { SetColumnValue(Columns.FilePermissionName, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varFilePermissionName)
		{
			FilePermission item = new FilePermission();
			
			item.FilePermissionName = varFilePermissionName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varFilePermissionId,string varFilePermissionName)
		{
			FilePermission item = new FilePermission();
			
				item.FilePermissionId = varFilePermissionId;
			
				item.FilePermissionName = varFilePermissionName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn FilePermissionIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn FilePermissionNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string FilePermissionId = @"FilePermissionId";
			 public static string FilePermissionName = @"FilePermissionName";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
