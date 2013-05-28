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
	/// Strongly-typed collection for the FileOfApply class.
	/// </summary>
    [Serializable]
	public partial class FileOfApplyCollection : ActiveList<FileOfApply, FileOfApplyCollection>
	{	   
		public FileOfApplyCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>FileOfApplyCollection</returns>
		public FileOfApplyCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                FileOfApply o = this[i];
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
	/// This is an ActiveRecord class which wraps the FileOfApply_tb table.
	/// </summary>
	[Serializable]
	public partial class FileOfApply : ActiveRecord<FileOfApply>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public FileOfApply()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public FileOfApply(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public FileOfApply(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public FileOfApply(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("FileOfApply_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarFileOfApplyId = new TableSchema.TableColumn(schema);
				colvarFileOfApplyId.ColumnName = "FileOfApplyId";
				colvarFileOfApplyId.DataType = DbType.Int32;
				colvarFileOfApplyId.MaxLength = 0;
				colvarFileOfApplyId.AutoIncrement = true;
				colvarFileOfApplyId.IsNullable = false;
				colvarFileOfApplyId.IsPrimaryKey = true;
				colvarFileOfApplyId.IsForeignKey = false;
				colvarFileOfApplyId.IsReadOnly = false;
				colvarFileOfApplyId.DefaultSetting = @"";
				colvarFileOfApplyId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFileOfApplyId);
				
				TableSchema.TableColumn colvarFileOfName = new TableSchema.TableColumn(schema);
				colvarFileOfName.ColumnName = "FileOfName";
				colvarFileOfName.DataType = DbType.String;
				colvarFileOfName.MaxLength = 100;
				colvarFileOfName.AutoIncrement = false;
				colvarFileOfName.IsNullable = true;
				colvarFileOfName.IsPrimaryKey = false;
				colvarFileOfName.IsForeignKey = false;
				colvarFileOfName.IsReadOnly = false;
				colvarFileOfName.DefaultSetting = @"";
				colvarFileOfName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFileOfName);
				
				TableSchema.TableColumn colvarPhysicalName = new TableSchema.TableColumn(schema);
				colvarPhysicalName.ColumnName = "PhysicalName";
				colvarPhysicalName.DataType = DbType.String;
				colvarPhysicalName.MaxLength = 100;
				colvarPhysicalName.AutoIncrement = false;
				colvarPhysicalName.IsNullable = true;
				colvarPhysicalName.IsPrimaryKey = false;
				colvarPhysicalName.IsForeignKey = false;
				colvarPhysicalName.IsReadOnly = false;
				colvarPhysicalName.DefaultSetting = @"";
				colvarPhysicalName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPhysicalName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("FileOfApply_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("FileOfApplyId")]
		[Bindable(true)]
		public int FileOfApplyId 
		{
			get { return GetColumnValue<int>(Columns.FileOfApplyId); }
			set { SetColumnValue(Columns.FileOfApplyId, value); }
		}
		  
		[XmlAttribute("FileOfName")]
		[Bindable(true)]
		public string FileOfName 
		{
			get { return GetColumnValue<string>(Columns.FileOfName); }
			set { SetColumnValue(Columns.FileOfName, value); }
		}
		  
		[XmlAttribute("PhysicalName")]
		[Bindable(true)]
		public string PhysicalName 
		{
			get { return GetColumnValue<string>(Columns.PhysicalName); }
			set { SetColumnValue(Columns.PhysicalName, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varFileOfName,string varPhysicalName)
		{
			FileOfApply item = new FileOfApply();
			
			item.FileOfName = varFileOfName;
			
			item.PhysicalName = varPhysicalName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varFileOfApplyId,string varFileOfName,string varPhysicalName)
		{
			FileOfApply item = new FileOfApply();
			
				item.FileOfApplyId = varFileOfApplyId;
			
				item.FileOfName = varFileOfName;
			
				item.PhysicalName = varPhysicalName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn FileOfApplyIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn FileOfNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn PhysicalNameColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string FileOfApplyId = @"FileOfApplyId";
			 public static string FileOfName = @"FileOfName";
			 public static string PhysicalName = @"PhysicalName";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
