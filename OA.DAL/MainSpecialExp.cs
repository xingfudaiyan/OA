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
	/// Strongly-typed collection for the MainSpecialExp class.
	/// </summary>
    [Serializable]
	public partial class MainSpecialExpCollection : ActiveList<MainSpecialExp, MainSpecialExpCollection>
	{	   
		public MainSpecialExpCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>MainSpecialExpCollection</returns>
		public MainSpecialExpCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                MainSpecialExp o = this[i];
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
	/// This is an ActiveRecord class which wraps the MainSpecialExp_tb table.
	/// </summary>
	[Serializable]
	public partial class MainSpecialExp : ActiveRecord<MainSpecialExp>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public MainSpecialExp()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public MainSpecialExp(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public MainSpecialExp(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public MainSpecialExp(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("MainSpecialExp_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarMainSpecialExpId = new TableSchema.TableColumn(schema);
				colvarMainSpecialExpId.ColumnName = "MainSpecialExpId";
				colvarMainSpecialExpId.DataType = DbType.Int32;
				colvarMainSpecialExpId.MaxLength = 0;
				colvarMainSpecialExpId.AutoIncrement = true;
				colvarMainSpecialExpId.IsNullable = false;
				colvarMainSpecialExpId.IsPrimaryKey = true;
				colvarMainSpecialExpId.IsForeignKey = false;
				colvarMainSpecialExpId.IsReadOnly = false;
				colvarMainSpecialExpId.DefaultSetting = @"";
				colvarMainSpecialExpId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMainSpecialExpId);
				
				TableSchema.TableColumn colvarMainSpecialExpName = new TableSchema.TableColumn(schema);
				colvarMainSpecialExpName.ColumnName = "MainSpecialExpName";
				colvarMainSpecialExpName.DataType = DbType.String;
				colvarMainSpecialExpName.MaxLength = 50;
				colvarMainSpecialExpName.AutoIncrement = false;
				colvarMainSpecialExpName.IsNullable = true;
				colvarMainSpecialExpName.IsPrimaryKey = false;
				colvarMainSpecialExpName.IsForeignKey = false;
				colvarMainSpecialExpName.IsReadOnly = false;
				colvarMainSpecialExpName.DefaultSetting = @"";
				colvarMainSpecialExpName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMainSpecialExpName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("MainSpecialExp_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("MainSpecialExpId")]
		[Bindable(true)]
		public int MainSpecialExpId 
		{
			get { return GetColumnValue<int>(Columns.MainSpecialExpId); }
			set { SetColumnValue(Columns.MainSpecialExpId, value); }
		}
		  
		[XmlAttribute("MainSpecialExpName")]
		[Bindable(true)]
		public string MainSpecialExpName 
		{
			get { return GetColumnValue<string>(Columns.MainSpecialExpName); }
			set { SetColumnValue(Columns.MainSpecialExpName, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varMainSpecialExpName)
		{
			MainSpecialExp item = new MainSpecialExp();
			
			item.MainSpecialExpName = varMainSpecialExpName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varMainSpecialExpId,string varMainSpecialExpName)
		{
			MainSpecialExp item = new MainSpecialExp();
			
				item.MainSpecialExpId = varMainSpecialExpId;
			
				item.MainSpecialExpName = varMainSpecialExpName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn MainSpecialExpIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn MainSpecialExpNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string MainSpecialExpId = @"MainSpecialExpId";
			 public static string MainSpecialExpName = @"MainSpecialExpName";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
