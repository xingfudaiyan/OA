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
	/// Strongly-typed collection for the WorkToolSum class.
	/// </summary>
    [Serializable]
	public partial class WorkToolSumCollection : ActiveList<WorkToolSum, WorkToolSumCollection>
	{	   
		public WorkToolSumCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>WorkToolSumCollection</returns>
		public WorkToolSumCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                WorkToolSum o = this[i];
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
	/// This is an ActiveRecord class which wraps the WorkToolSum_tb table.
	/// </summary>
	[Serializable]
	public partial class WorkToolSum : ActiveRecord<WorkToolSum>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public WorkToolSum()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public WorkToolSum(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public WorkToolSum(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public WorkToolSum(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("WorkToolSum_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarWorkToolSumId = new TableSchema.TableColumn(schema);
				colvarWorkToolSumId.ColumnName = "WorkToolSumId";
				colvarWorkToolSumId.DataType = DbType.Int32;
				colvarWorkToolSumId.MaxLength = 0;
				colvarWorkToolSumId.AutoIncrement = true;
				colvarWorkToolSumId.IsNullable = false;
				colvarWorkToolSumId.IsPrimaryKey = true;
				colvarWorkToolSumId.IsForeignKey = false;
				colvarWorkToolSumId.IsReadOnly = false;
				colvarWorkToolSumId.DefaultSetting = @"";
				colvarWorkToolSumId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarWorkToolSumId);
				
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
				
				TableSchema.TableColumn colvarReason = new TableSchema.TableColumn(schema);
				colvarReason.ColumnName = "Reason";
				colvarReason.DataType = DbType.String;
				colvarReason.MaxLength = -1;
				colvarReason.AutoIncrement = false;
				colvarReason.IsNullable = true;
				colvarReason.IsPrimaryKey = false;
				colvarReason.IsForeignKey = false;
				colvarReason.IsReadOnly = false;
				colvarReason.DefaultSetting = @"";
				colvarReason.ForeignKeyTableName = "";
				schema.Columns.Add(colvarReason);
				
				TableSchema.TableColumn colvarBigMoney = new TableSchema.TableColumn(schema);
				colvarBigMoney.ColumnName = "BigMoney";
				colvarBigMoney.DataType = DbType.String;
				colvarBigMoney.MaxLength = 50;
				colvarBigMoney.AutoIncrement = false;
				colvarBigMoney.IsNullable = true;
				colvarBigMoney.IsPrimaryKey = false;
				colvarBigMoney.IsForeignKey = false;
				colvarBigMoney.IsReadOnly = false;
				colvarBigMoney.DefaultSetting = @"";
				colvarBigMoney.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBigMoney);
				
				TableSchema.TableColumn colvarSmaMoney = new TableSchema.TableColumn(schema);
				colvarSmaMoney.ColumnName = "SmaMoney";
				colvarSmaMoney.DataType = DbType.String;
				colvarSmaMoney.MaxLength = 50;
				colvarSmaMoney.AutoIncrement = false;
				colvarSmaMoney.IsNullable = true;
				colvarSmaMoney.IsPrimaryKey = false;
				colvarSmaMoney.IsForeignKey = false;
				colvarSmaMoney.IsReadOnly = false;
				colvarSmaMoney.DefaultSetting = @"";
				colvarSmaMoney.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSmaMoney);
				
				TableSchema.TableColumn colvarMoneyStyle = new TableSchema.TableColumn(schema);
				colvarMoneyStyle.ColumnName = "MoneyStyle";
				colvarMoneyStyle.DataType = DbType.String;
				colvarMoneyStyle.MaxLength = 50;
				colvarMoneyStyle.AutoIncrement = false;
				colvarMoneyStyle.IsNullable = true;
				colvarMoneyStyle.IsPrimaryKey = false;
				colvarMoneyStyle.IsForeignKey = false;
				colvarMoneyStyle.IsReadOnly = false;
				colvarMoneyStyle.DefaultSetting = @"";
				colvarMoneyStyle.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMoneyStyle);
				
				TableSchema.TableColumn colvarUseDepartName = new TableSchema.TableColumn(schema);
				colvarUseDepartName.ColumnName = "UseDepartName";
				colvarUseDepartName.DataType = DbType.String;
				colvarUseDepartName.MaxLength = 50;
				colvarUseDepartName.AutoIncrement = false;
				colvarUseDepartName.IsNullable = true;
				colvarUseDepartName.IsPrimaryKey = false;
				colvarUseDepartName.IsForeignKey = false;
				colvarUseDepartName.IsReadOnly = false;
				colvarUseDepartName.DefaultSetting = @"";
				colvarUseDepartName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUseDepartName);
				
				TableSchema.TableColumn colvarFuTime = new TableSchema.TableColumn(schema);
				colvarFuTime.ColumnName = "FuTime";
				colvarFuTime.DataType = DbType.String;
				colvarFuTime.MaxLength = 50;
				colvarFuTime.AutoIncrement = false;
				colvarFuTime.IsNullable = true;
				colvarFuTime.IsPrimaryKey = false;
				colvarFuTime.IsForeignKey = false;
				colvarFuTime.IsReadOnly = false;
				colvarFuTime.DefaultSetting = @"";
				colvarFuTime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFuTime);
				
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
				DataService.Providers["SubsonicProvider"].AddSchema("WorkToolSum_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("WorkToolSumId")]
		[Bindable(true)]
		public int WorkToolSumId 
		{
			get { return GetColumnValue<int>(Columns.WorkToolSumId); }
			set { SetColumnValue(Columns.WorkToolSumId, value); }
		}
		  
		[XmlAttribute("DepartName")]
		[Bindable(true)]
		public string DepartName 
		{
			get { return GetColumnValue<string>(Columns.DepartName); }
			set { SetColumnValue(Columns.DepartName, value); }
		}
		  
		[XmlAttribute("Reason")]
		[Bindable(true)]
		public string Reason 
		{
			get { return GetColumnValue<string>(Columns.Reason); }
			set { SetColumnValue(Columns.Reason, value); }
		}
		  
		[XmlAttribute("BigMoney")]
		[Bindable(true)]
		public string BigMoney 
		{
			get { return GetColumnValue<string>(Columns.BigMoney); }
			set { SetColumnValue(Columns.BigMoney, value); }
		}
		  
		[XmlAttribute("SmaMoney")]
		[Bindable(true)]
		public string SmaMoney 
		{
			get { return GetColumnValue<string>(Columns.SmaMoney); }
			set { SetColumnValue(Columns.SmaMoney, value); }
		}
		  
		[XmlAttribute("MoneyStyle")]
		[Bindable(true)]
		public string MoneyStyle 
		{
			get { return GetColumnValue<string>(Columns.MoneyStyle); }
			set { SetColumnValue(Columns.MoneyStyle, value); }
		}
		  
		[XmlAttribute("UseDepartName")]
		[Bindable(true)]
		public string UseDepartName 
		{
			get { return GetColumnValue<string>(Columns.UseDepartName); }
			set { SetColumnValue(Columns.UseDepartName, value); }
		}
		  
		[XmlAttribute("FuTime")]
		[Bindable(true)]
		public string FuTime 
		{
			get { return GetColumnValue<string>(Columns.FuTime); }
			set { SetColumnValue(Columns.FuTime, value); }
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
		  
		[XmlAttribute("ApplyTime")]
		[Bindable(true)]
		public string ApplyTime 
		{
			get { return GetColumnValue<string>(Columns.ApplyTime); }
			set { SetColumnValue(Columns.ApplyTime, value); }
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
		public static void Insert(string varDepartName,string varReason,string varBigMoney,string varSmaMoney,string varMoneyStyle,string varUseDepartName,string varFuTime,string varApplyName,int? varState,string varApplyTime,string varDepartView,string varManagerView)
		{
			WorkToolSum item = new WorkToolSum();
			
			item.DepartName = varDepartName;
			
			item.Reason = varReason;
			
			item.BigMoney = varBigMoney;
			
			item.SmaMoney = varSmaMoney;
			
			item.MoneyStyle = varMoneyStyle;
			
			item.UseDepartName = varUseDepartName;
			
			item.FuTime = varFuTime;
			
			item.ApplyName = varApplyName;
			
			item.State = varState;
			
			item.ApplyTime = varApplyTime;
			
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
		public static void Update(int varWorkToolSumId,string varDepartName,string varReason,string varBigMoney,string varSmaMoney,string varMoneyStyle,string varUseDepartName,string varFuTime,string varApplyName,int? varState,string varApplyTime,string varDepartView,string varManagerView)
		{
			WorkToolSum item = new WorkToolSum();
			
				item.WorkToolSumId = varWorkToolSumId;
			
				item.DepartName = varDepartName;
			
				item.Reason = varReason;
			
				item.BigMoney = varBigMoney;
			
				item.SmaMoney = varSmaMoney;
			
				item.MoneyStyle = varMoneyStyle;
			
				item.UseDepartName = varUseDepartName;
			
				item.FuTime = varFuTime;
			
				item.ApplyName = varApplyName;
			
				item.State = varState;
			
				item.ApplyTime = varApplyTime;
			
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
        
        
        public static TableSchema.TableColumn WorkToolSumIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn DepartNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn ReasonColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn BigMoneyColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn SmaMoneyColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn MoneyStyleColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn UseDepartNameColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn FuTimeColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn ApplyNameColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn StateColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn ApplyTimeColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn DepartViewColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn ManagerViewColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string WorkToolSumId = @"WorkToolSumId";
			 public static string DepartName = @"DepartName";
			 public static string Reason = @"Reason";
			 public static string BigMoney = @"BigMoney";
			 public static string SmaMoney = @"SmaMoney";
			 public static string MoneyStyle = @"MoneyStyle";
			 public static string UseDepartName = @"UseDepartName";
			 public static string FuTime = @"FuTime";
			 public static string ApplyName = @"ApplyName";
			 public static string State = @"State";
			 public static string ApplyTime = @"ApplyTime";
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
