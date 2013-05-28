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
	/// Strongly-typed collection for the MainBusinessExp class.
	/// </summary>
    [Serializable]
	public partial class MainBusinessExpCollection : ActiveList<MainBusinessExp, MainBusinessExpCollection>
	{	   
		public MainBusinessExpCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>MainBusinessExpCollection</returns>
		public MainBusinessExpCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                MainBusinessExp o = this[i];
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
	/// This is an ActiveRecord class which wraps the MainBusinessExp_tb table.
	/// </summary>
	[Serializable]
	public partial class MainBusinessExp : ActiveRecord<MainBusinessExp>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public MainBusinessExp()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public MainBusinessExp(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public MainBusinessExp(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public MainBusinessExp(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("MainBusinessExp_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarMainBusinessExpId = new TableSchema.TableColumn(schema);
				colvarMainBusinessExpId.ColumnName = "MainBusinessExpId";
				colvarMainBusinessExpId.DataType = DbType.Int32;
				colvarMainBusinessExpId.MaxLength = 0;
				colvarMainBusinessExpId.AutoIncrement = true;
				colvarMainBusinessExpId.IsNullable = false;
				colvarMainBusinessExpId.IsPrimaryKey = true;
				colvarMainBusinessExpId.IsForeignKey = false;
				colvarMainBusinessExpId.IsReadOnly = false;
				colvarMainBusinessExpId.DefaultSetting = @"";
				colvarMainBusinessExpId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMainBusinessExpId);
				
				TableSchema.TableColumn colvarMainBusinessExpName = new TableSchema.TableColumn(schema);
				colvarMainBusinessExpName.ColumnName = "MainBusinessExpName";
				colvarMainBusinessExpName.DataType = DbType.String;
				colvarMainBusinessExpName.MaxLength = 50;
				colvarMainBusinessExpName.AutoIncrement = false;
				colvarMainBusinessExpName.IsNullable = true;
				colvarMainBusinessExpName.IsPrimaryKey = false;
				colvarMainBusinessExpName.IsForeignKey = false;
				colvarMainBusinessExpName.IsReadOnly = false;
				colvarMainBusinessExpName.DefaultSetting = @"";
				colvarMainBusinessExpName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMainBusinessExpName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("MainBusinessExp_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("MainBusinessExpId")]
		[Bindable(true)]
		public int MainBusinessExpId 
		{
			get { return GetColumnValue<int>(Columns.MainBusinessExpId); }
			set { SetColumnValue(Columns.MainBusinessExpId, value); }
		}
		  
		[XmlAttribute("MainBusinessExpName")]
		[Bindable(true)]
		public string MainBusinessExpName 
		{
			get { return GetColumnValue<string>(Columns.MainBusinessExpName); }
			set { SetColumnValue(Columns.MainBusinessExpName, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varMainBusinessExpName)
		{
			MainBusinessExp item = new MainBusinessExp();
			
			item.MainBusinessExpName = varMainBusinessExpName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varMainBusinessExpId,string varMainBusinessExpName)
		{
			MainBusinessExp item = new MainBusinessExp();
			
				item.MainBusinessExpId = varMainBusinessExpId;
			
				item.MainBusinessExpName = varMainBusinessExpName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn MainBusinessExpIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn MainBusinessExpNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string MainBusinessExpId = @"MainBusinessExpId";
			 public static string MainBusinessExpName = @"MainBusinessExpName";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
