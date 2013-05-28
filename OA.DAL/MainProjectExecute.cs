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
	/// Strongly-typed collection for the MainProjectExecute class.
	/// </summary>
    [Serializable]
	public partial class MainProjectExecuteCollection : ActiveList<MainProjectExecute, MainProjectExecuteCollection>
	{	   
		public MainProjectExecuteCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>MainProjectExecuteCollection</returns>
		public MainProjectExecuteCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                MainProjectExecute o = this[i];
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
	/// This is an ActiveRecord class which wraps the MainProjectExecute_tb table.
	/// </summary>
	[Serializable]
	public partial class MainProjectExecute : ActiveRecord<MainProjectExecute>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public MainProjectExecute()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public MainProjectExecute(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public MainProjectExecute(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public MainProjectExecute(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("MainProjectExecute_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarMainProjectExecuteId = new TableSchema.TableColumn(schema);
				colvarMainProjectExecuteId.ColumnName = "MainProjectExecuteId";
				colvarMainProjectExecuteId.DataType = DbType.Int32;
				colvarMainProjectExecuteId.MaxLength = 0;
				colvarMainProjectExecuteId.AutoIncrement = true;
				colvarMainProjectExecuteId.IsNullable = false;
				colvarMainProjectExecuteId.IsPrimaryKey = true;
				colvarMainProjectExecuteId.IsForeignKey = false;
				colvarMainProjectExecuteId.IsReadOnly = false;
				colvarMainProjectExecuteId.DefaultSetting = @"";
				colvarMainProjectExecuteId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMainProjectExecuteId);
				
				TableSchema.TableColumn colvarMainProjectExecuteName = new TableSchema.TableColumn(schema);
				colvarMainProjectExecuteName.ColumnName = "MainProjectExecuteName";
				colvarMainProjectExecuteName.DataType = DbType.String;
				colvarMainProjectExecuteName.MaxLength = 50;
				colvarMainProjectExecuteName.AutoIncrement = false;
				colvarMainProjectExecuteName.IsNullable = true;
				colvarMainProjectExecuteName.IsPrimaryKey = false;
				colvarMainProjectExecuteName.IsForeignKey = false;
				colvarMainProjectExecuteName.IsReadOnly = false;
				colvarMainProjectExecuteName.DefaultSetting = @"";
				colvarMainProjectExecuteName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMainProjectExecuteName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("MainProjectExecute_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("MainProjectExecuteId")]
		[Bindable(true)]
		public int MainProjectExecuteId 
		{
			get { return GetColumnValue<int>(Columns.MainProjectExecuteId); }
			set { SetColumnValue(Columns.MainProjectExecuteId, value); }
		}
		  
		[XmlAttribute("MainProjectExecuteName")]
		[Bindable(true)]
		public string MainProjectExecuteName 
		{
			get { return GetColumnValue<string>(Columns.MainProjectExecuteName); }
			set { SetColumnValue(Columns.MainProjectExecuteName, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varMainProjectExecuteName)
		{
			MainProjectExecute item = new MainProjectExecute();
			
			item.MainProjectExecuteName = varMainProjectExecuteName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varMainProjectExecuteId,string varMainProjectExecuteName)
		{
			MainProjectExecute item = new MainProjectExecute();
			
				item.MainProjectExecuteId = varMainProjectExecuteId;
			
				item.MainProjectExecuteName = varMainProjectExecuteName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn MainProjectExecuteIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn MainProjectExecuteNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string MainProjectExecuteId = @"MainProjectExecuteId";
			 public static string MainProjectExecuteName = @"MainProjectExecuteName";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
