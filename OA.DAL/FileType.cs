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
	/// Strongly-typed collection for the FileType class.
	/// </summary>
    [Serializable]
	public partial class FileTypeCollection : ActiveList<FileType, FileTypeCollection>
	{	   
		public FileTypeCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>FileTypeCollection</returns>
		public FileTypeCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                FileType o = this[i];
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
	/// This is an ActiveRecord class which wraps the FileType_tb table.
	/// </summary>
	[Serializable]
	public partial class FileType : ActiveRecord<FileType>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public FileType()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public FileType(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public FileType(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public FileType(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("FileType_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarFileTypeId = new TableSchema.TableColumn(schema);
				colvarFileTypeId.ColumnName = "FileTypeId";
				colvarFileTypeId.DataType = DbType.Int32;
				colvarFileTypeId.MaxLength = 0;
				colvarFileTypeId.AutoIncrement = true;
				colvarFileTypeId.IsNullable = false;
				colvarFileTypeId.IsPrimaryKey = true;
				colvarFileTypeId.IsForeignKey = false;
				colvarFileTypeId.IsReadOnly = false;
				colvarFileTypeId.DefaultSetting = @"";
				colvarFileTypeId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFileTypeId);
				
				TableSchema.TableColumn colvarFileTypeName = new TableSchema.TableColumn(schema);
				colvarFileTypeName.ColumnName = "FileTypeName";
				colvarFileTypeName.DataType = DbType.String;
				colvarFileTypeName.MaxLength = 50;
				colvarFileTypeName.AutoIncrement = false;
				colvarFileTypeName.IsNullable = true;
				colvarFileTypeName.IsPrimaryKey = false;
				colvarFileTypeName.IsForeignKey = false;
				colvarFileTypeName.IsReadOnly = false;
				colvarFileTypeName.DefaultSetting = @"";
				colvarFileTypeName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFileTypeName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("FileType_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("FileTypeId")]
		[Bindable(true)]
		public int FileTypeId 
		{
			get { return GetColumnValue<int>(Columns.FileTypeId); }
			set { SetColumnValue(Columns.FileTypeId, value); }
		}
		  
		[XmlAttribute("FileTypeName")]
		[Bindable(true)]
		public string FileTypeName 
		{
			get { return GetColumnValue<string>(Columns.FileTypeName); }
			set { SetColumnValue(Columns.FileTypeName, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		public CanYou.OA.DAL.FileCollection FileRecords()
		{
			return new CanYou.OA.DAL.FileCollection().Where(File.Columns.FileTypeId, FileTypeId).Load();
		}
		#endregion
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varFileTypeName)
		{
			FileType item = new FileType();
			
			item.FileTypeName = varFileTypeName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varFileTypeId,string varFileTypeName)
		{
			FileType item = new FileType();
			
				item.FileTypeId = varFileTypeId;
			
				item.FileTypeName = varFileTypeName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn FileTypeIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn FileTypeNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string FileTypeId = @"FileTypeId";
			 public static string FileTypeName = @"FileTypeName";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
}
        #endregion
	}
}
