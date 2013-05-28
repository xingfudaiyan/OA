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
	/// Strongly-typed collection for the MainWorkSheet class.
	/// </summary>
    [Serializable]
	public partial class MainWorkSheetCollection : ActiveList<MainWorkSheet, MainWorkSheetCollection>
	{	   
		public MainWorkSheetCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>MainWorkSheetCollection</returns>
		public MainWorkSheetCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                MainWorkSheet o = this[i];
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
	/// This is an ActiveRecord class which wraps the MainWorkSheet_tb table.
	/// </summary>
	[Serializable]
	public partial class MainWorkSheet : ActiveRecord<MainWorkSheet>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public MainWorkSheet()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public MainWorkSheet(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public MainWorkSheet(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public MainWorkSheet(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("MainWorkSheet_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarMainWorkSheetId = new TableSchema.TableColumn(schema);
				colvarMainWorkSheetId.ColumnName = "MainWorkSheetId";
				colvarMainWorkSheetId.DataType = DbType.Int32;
				colvarMainWorkSheetId.MaxLength = 0;
				colvarMainWorkSheetId.AutoIncrement = true;
				colvarMainWorkSheetId.IsNullable = false;
				colvarMainWorkSheetId.IsPrimaryKey = true;
				colvarMainWorkSheetId.IsForeignKey = false;
				colvarMainWorkSheetId.IsReadOnly = false;
				colvarMainWorkSheetId.DefaultSetting = @"";
				colvarMainWorkSheetId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMainWorkSheetId);
				
				TableSchema.TableColumn colvarMainWorkSheetName = new TableSchema.TableColumn(schema);
				colvarMainWorkSheetName.ColumnName = "MainWorkSheetName";
				colvarMainWorkSheetName.DataType = DbType.String;
				colvarMainWorkSheetName.MaxLength = 50;
				colvarMainWorkSheetName.AutoIncrement = false;
				colvarMainWorkSheetName.IsNullable = true;
				colvarMainWorkSheetName.IsPrimaryKey = false;
				colvarMainWorkSheetName.IsForeignKey = false;
				colvarMainWorkSheetName.IsReadOnly = false;
				colvarMainWorkSheetName.DefaultSetting = @"";
				colvarMainWorkSheetName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMainWorkSheetName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("MainWorkSheet_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("MainWorkSheetId")]
		[Bindable(true)]
		public int MainWorkSheetId 
		{
			get { return GetColumnValue<int>(Columns.MainWorkSheetId); }
			set { SetColumnValue(Columns.MainWorkSheetId, value); }
		}
		  
		[XmlAttribute("MainWorkSheetName")]
		[Bindable(true)]
		public string MainWorkSheetName 
		{
			get { return GetColumnValue<string>(Columns.MainWorkSheetName); }
			set { SetColumnValue(Columns.MainWorkSheetName, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varMainWorkSheetName)
		{
			MainWorkSheet item = new MainWorkSheet();
			
			item.MainWorkSheetName = varMainWorkSheetName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varMainWorkSheetId,string varMainWorkSheetName)
		{
			MainWorkSheet item = new MainWorkSheet();
			
				item.MainWorkSheetId = varMainWorkSheetId;
			
				item.MainWorkSheetName = varMainWorkSheetName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn MainWorkSheetIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn MainWorkSheetNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string MainWorkSheetId = @"MainWorkSheetId";
			 public static string MainWorkSheetName = @"MainWorkSheetName";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
