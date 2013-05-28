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
	/// Strongly-typed collection for the Tool class.
	/// </summary>
    [Serializable]
	public partial class ToolCollection : ActiveList<Tool, ToolCollection>
	{	   
		public ToolCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>ToolCollection</returns>
		public ToolCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                Tool o = this[i];
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
	/// This is an ActiveRecord class which wraps the Tool_tb table.
	/// </summary>
	[Serializable]
	public partial class Tool : ActiveRecord<Tool>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public Tool()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public Tool(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public Tool(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public Tool(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("Tool_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarToolId = new TableSchema.TableColumn(schema);
				colvarToolId.ColumnName = "ToolId";
				colvarToolId.DataType = DbType.Int32;
				colvarToolId.MaxLength = 0;
				colvarToolId.AutoIncrement = true;
				colvarToolId.IsNullable = false;
				colvarToolId.IsPrimaryKey = true;
				colvarToolId.IsForeignKey = false;
				colvarToolId.IsReadOnly = false;
				colvarToolId.DefaultSetting = @"";
				colvarToolId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarToolId);
				
				TableSchema.TableColumn colvarToolNumId = new TableSchema.TableColumn(schema);
				colvarToolNumId.ColumnName = "ToolNumId";
				colvarToolNumId.DataType = DbType.Int32;
				colvarToolNumId.MaxLength = 0;
				colvarToolNumId.AutoIncrement = false;
				colvarToolNumId.IsNullable = true;
				colvarToolNumId.IsPrimaryKey = false;
				colvarToolNumId.IsForeignKey = false;
				colvarToolNumId.IsReadOnly = false;
				colvarToolNumId.DefaultSetting = @"";
				colvarToolNumId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarToolNumId);
				
				TableSchema.TableColumn colvarApplyTime = new TableSchema.TableColumn(schema);
				colvarApplyTime.ColumnName = "ApplyTime";
				colvarApplyTime.DataType = DbType.String;
				colvarApplyTime.MaxLength = 50;
				colvarApplyTime.AutoIncrement = false;
				colvarApplyTime.IsNullable = true;
				colvarApplyTime.IsPrimaryKey = false;
				colvarApplyTime.IsForeignKey = false;
				colvarApplyTime.IsReadOnly = false;
				colvarApplyTime.DefaultSetting = @"";
				colvarApplyTime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarApplyTime);
				
				TableSchema.TableColumn colvarDepartName = new TableSchema.TableColumn(schema);
				colvarDepartName.ColumnName = "DepartName";
				colvarDepartName.DataType = DbType.String;
				colvarDepartName.MaxLength = 50;
				colvarDepartName.AutoIncrement = false;
				colvarDepartName.IsNullable = true;
				colvarDepartName.IsPrimaryKey = false;
				colvarDepartName.IsForeignKey = false;
				colvarDepartName.IsReadOnly = false;
				colvarDepartName.DefaultSetting = @"";
				colvarDepartName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDepartName);
				
				TableSchema.TableColumn colvarApplyName = new TableSchema.TableColumn(schema);
				colvarApplyName.ColumnName = "ApplyName";
				colvarApplyName.DataType = DbType.String;
				colvarApplyName.MaxLength = 50;
				colvarApplyName.AutoIncrement = false;
				colvarApplyName.IsNullable = true;
				colvarApplyName.IsPrimaryKey = false;
				colvarApplyName.IsForeignKey = false;
				colvarApplyName.IsReadOnly = false;
				colvarApplyName.DefaultSetting = @"";
				colvarApplyName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarApplyName);
				
				TableSchema.TableColumn colvarState = new TableSchema.TableColumn(schema);
				colvarState.ColumnName = "State";
				colvarState.DataType = DbType.Int32;
				colvarState.MaxLength = 0;
				colvarState.AutoIncrement = false;
				colvarState.IsNullable = true;
				colvarState.IsPrimaryKey = false;
				colvarState.IsForeignKey = false;
				colvarState.IsReadOnly = false;
				colvarState.DefaultSetting = @"";
				colvarState.ForeignKeyTableName = "";
				schema.Columns.Add(colvarState);
				
				TableSchema.TableColumn colvarTechMemo = new TableSchema.TableColumn(schema);
				colvarTechMemo.ColumnName = "TechMemo";
				colvarTechMemo.DataType = DbType.String;
				colvarTechMemo.MaxLength = 50;
				colvarTechMemo.AutoIncrement = false;
				colvarTechMemo.IsNullable = true;
				colvarTechMemo.IsPrimaryKey = false;
				colvarTechMemo.IsForeignKey = false;
				colvarTechMemo.IsReadOnly = false;
				colvarTechMemo.DefaultSetting = @"";
				colvarTechMemo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTechMemo);
				
				TableSchema.TableColumn colvarMarketMemo = new TableSchema.TableColumn(schema);
				colvarMarketMemo.ColumnName = "MarketMemo";
				colvarMarketMemo.DataType = DbType.String;
				colvarMarketMemo.MaxLength = 50;
				colvarMarketMemo.AutoIncrement = false;
				colvarMarketMemo.IsNullable = true;
				colvarMarketMemo.IsPrimaryKey = false;
				colvarMarketMemo.IsForeignKey = false;
				colvarMarketMemo.IsReadOnly = false;
				colvarMarketMemo.DefaultSetting = @"";
				colvarMarketMemo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMarketMemo);
				
				TableSchema.TableColumn colvarZongHeMemo = new TableSchema.TableColumn(schema);
				colvarZongHeMemo.ColumnName = "ZongHeMemo";
				colvarZongHeMemo.DataType = DbType.String;
				colvarZongHeMemo.MaxLength = 50;
				colvarZongHeMemo.AutoIncrement = false;
				colvarZongHeMemo.IsNullable = true;
				colvarZongHeMemo.IsPrimaryKey = false;
				colvarZongHeMemo.IsForeignKey = false;
				colvarZongHeMemo.IsReadOnly = false;
				colvarZongHeMemo.DefaultSetting = @"";
				colvarZongHeMemo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarZongHeMemo);
				
				TableSchema.TableColumn colvarDepartView = new TableSchema.TableColumn(schema);
				colvarDepartView.ColumnName = "DepartView";
				colvarDepartView.DataType = DbType.String;
				colvarDepartView.MaxLength = 50;
				colvarDepartView.AutoIncrement = false;
				colvarDepartView.IsNullable = true;
				colvarDepartView.IsPrimaryKey = false;
				colvarDepartView.IsForeignKey = false;
				colvarDepartView.IsReadOnly = false;
				colvarDepartView.DefaultSetting = @"";
				colvarDepartView.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDepartView);
				
				TableSchema.TableColumn colvarManagerView = new TableSchema.TableColumn(schema);
				colvarManagerView.ColumnName = "ManagerView";
				colvarManagerView.DataType = DbType.String;
				colvarManagerView.MaxLength = 50;
				colvarManagerView.AutoIncrement = false;
				colvarManagerView.IsNullable = true;
				colvarManagerView.IsPrimaryKey = false;
				colvarManagerView.IsForeignKey = false;
				colvarManagerView.IsReadOnly = false;
				colvarManagerView.DefaultSetting = @"";
				colvarManagerView.ForeignKeyTableName = "";
				schema.Columns.Add(colvarManagerView);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("Tool_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("ToolId")]
		[Bindable(true)]
		public int ToolId 
		{
			get { return GetColumnValue<int>(Columns.ToolId); }
			set { SetColumnValue(Columns.ToolId, value); }
		}
		  
		[XmlAttribute("ToolNumId")]
		[Bindable(true)]
		public int? ToolNumId 
		{
			get { return GetColumnValue<int?>(Columns.ToolNumId); }
			set { SetColumnValue(Columns.ToolNumId, value); }
		}
		  
		[XmlAttribute("ApplyTime")]
		[Bindable(true)]
		public string ApplyTime 
		{
			get { return GetColumnValue<string>(Columns.ApplyTime); }
			set { SetColumnValue(Columns.ApplyTime, value); }
		}
		  
		[XmlAttribute("DepartName")]
		[Bindable(true)]
		public string DepartName 
		{
			get { return GetColumnValue<string>(Columns.DepartName); }
			set { SetColumnValue(Columns.DepartName, value); }
		}
		  
		[XmlAttribute("ApplyName")]
		[Bindable(true)]
		public string ApplyName 
		{
			get { return GetColumnValue<string>(Columns.ApplyName); }
			set { SetColumnValue(Columns.ApplyName, value); }
		}
		  
		[XmlAttribute("State")]
		[Bindable(true)]
		public int? State 
		{
			get { return GetColumnValue<int?>(Columns.State); }
			set { SetColumnValue(Columns.State, value); }
		}
		  
		[XmlAttribute("TechMemo")]
		[Bindable(true)]
		public string TechMemo 
		{
			get { return GetColumnValue<string>(Columns.TechMemo); }
			set { SetColumnValue(Columns.TechMemo, value); }
		}
		  
		[XmlAttribute("MarketMemo")]
		[Bindable(true)]
		public string MarketMemo 
		{
			get { return GetColumnValue<string>(Columns.MarketMemo); }
			set { SetColumnValue(Columns.MarketMemo, value); }
		}
		  
		[XmlAttribute("ZongHeMemo")]
		[Bindable(true)]
		public string ZongHeMemo 
		{
			get { return GetColumnValue<string>(Columns.ZongHeMemo); }
			set { SetColumnValue(Columns.ZongHeMemo, value); }
		}
		  
		[XmlAttribute("DepartView")]
		[Bindable(true)]
		public string DepartView 
		{
			get { return GetColumnValue<string>(Columns.DepartView); }
			set { SetColumnValue(Columns.DepartView, value); }
		}
		  
		[XmlAttribute("ManagerView")]
		[Bindable(true)]
		public string ManagerView 
		{
			get { return GetColumnValue<string>(Columns.ManagerView); }
			set { SetColumnValue(Columns.ManagerView, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int? varToolNumId,string varApplyTime,string varDepartName,string varApplyName,int? varState,string varTechMemo,string varMarketMemo,string varZongHeMemo,string varDepartView,string varManagerView)
		{
			Tool item = new Tool();
			
			item.ToolNumId = varToolNumId;
			
			item.ApplyTime = varApplyTime;
			
			item.DepartName = varDepartName;
			
			item.ApplyName = varApplyName;
			
			item.State = varState;
			
			item.TechMemo = varTechMemo;
			
			item.MarketMemo = varMarketMemo;
			
			item.ZongHeMemo = varZongHeMemo;
			
			item.DepartView = varDepartView;
			
			item.ManagerView = varManagerView;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varToolId,int? varToolNumId,string varApplyTime,string varDepartName,string varApplyName,int? varState,string varTechMemo,string varMarketMemo,string varZongHeMemo,string varDepartView,string varManagerView)
		{
			Tool item = new Tool();
			
				item.ToolId = varToolId;
			
				item.ToolNumId = varToolNumId;
			
				item.ApplyTime = varApplyTime;
			
				item.DepartName = varDepartName;
			
				item.ApplyName = varApplyName;
			
				item.State = varState;
			
				item.TechMemo = varTechMemo;
			
				item.MarketMemo = varMarketMemo;
			
				item.ZongHeMemo = varZongHeMemo;
			
				item.DepartView = varDepartView;
			
				item.ManagerView = varManagerView;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn ToolIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ToolNumIdColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn ApplyTimeColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn DepartNameColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn ApplyNameColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn StateColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn TechMemoColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn MarketMemoColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn ZongHeMemoColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn DepartViewColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn ManagerViewColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string ToolId = @"ToolId";
			 public static string ToolNumId = @"ToolNumId";
			 public static string ApplyTime = @"ApplyTime";
			 public static string DepartName = @"DepartName";
			 public static string ApplyName = @"ApplyName";
			 public static string State = @"State";
			 public static string TechMemo = @"TechMemo";
			 public static string MarketMemo = @"MarketMemo";
			 public static string ZongHeMemo = @"ZongHeMemo";
			 public static string DepartView = @"DepartView";
			 public static string ManagerView = @"ManagerView";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
