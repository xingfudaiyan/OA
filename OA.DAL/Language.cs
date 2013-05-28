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
	/// Strongly-typed collection for the Language class.
	/// </summary>
    [Serializable]
	public partial class LanguageCollection : ActiveList<Language, LanguageCollection>
	{	   
		public LanguageCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>LanguageCollection</returns>
		public LanguageCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                Language o = this[i];
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
	/// This is an ActiveRecord class which wraps the Language_tb table.
	/// </summary>
	[Serializable]
	public partial class Language : ActiveRecord<Language>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public Language()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public Language(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public Language(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public Language(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("Language_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarLanguageId = new TableSchema.TableColumn(schema);
				colvarLanguageId.ColumnName = "LanguageId";
				colvarLanguageId.DataType = DbType.Int32;
				colvarLanguageId.MaxLength = 0;
				colvarLanguageId.AutoIncrement = true;
				colvarLanguageId.IsNullable = false;
				colvarLanguageId.IsPrimaryKey = true;
				colvarLanguageId.IsForeignKey = false;
				colvarLanguageId.IsReadOnly = false;
				colvarLanguageId.DefaultSetting = @"";
				colvarLanguageId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarLanguageId);
				
				TableSchema.TableColumn colvarLanguageName = new TableSchema.TableColumn(schema);
				colvarLanguageName.ColumnName = "LanguageName";
				colvarLanguageName.DataType = DbType.String;
				colvarLanguageName.MaxLength = 50;
				colvarLanguageName.AutoIncrement = false;
				colvarLanguageName.IsNullable = true;
				colvarLanguageName.IsPrimaryKey = false;
				colvarLanguageName.IsForeignKey = false;
				colvarLanguageName.IsReadOnly = false;
				colvarLanguageName.DefaultSetting = @"";
				colvarLanguageName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarLanguageName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("Language_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("LanguageId")]
		[Bindable(true)]
		public int LanguageId 
		{
			get { return GetColumnValue<int>(Columns.LanguageId); }
			set { SetColumnValue(Columns.LanguageId, value); }
		}
		  
		[XmlAttribute("LanguageName")]
		[Bindable(true)]
		public string LanguageName 
		{
			get { return GetColumnValue<string>(Columns.LanguageName); }
			set { SetColumnValue(Columns.LanguageName, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		public CanYou.OA.DAL.EmployeeCollection EmployeeRecords()
		{
			return new CanYou.OA.DAL.EmployeeCollection().Where(Employee.Columns.LanguageId, LanguageId).Load();
		}
		#endregion
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varLanguageName)
		{
			Language item = new Language();
			
			item.LanguageName = varLanguageName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varLanguageId,string varLanguageName)
		{
			Language item = new Language();
			
				item.LanguageId = varLanguageId;
			
				item.LanguageName = varLanguageName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn LanguageIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn LanguageNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string LanguageId = @"LanguageId";
			 public static string LanguageName = @"LanguageName";
						
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
