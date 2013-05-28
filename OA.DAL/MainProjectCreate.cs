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
	/// Strongly-typed collection for the MainProjectCreate class.
	/// </summary>
    [Serializable]
	public partial class MainProjectCreateCollection : ActiveList<MainProjectCreate, MainProjectCreateCollection>
	{	   
		public MainProjectCreateCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>MainProjectCreateCollection</returns>
		public MainProjectCreateCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                MainProjectCreate o = this[i];
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
	/// This is an ActiveRecord class which wraps the MainProjectCreate_tb table.
	/// </summary>
	[Serializable]
	public partial class MainProjectCreate : ActiveRecord<MainProjectCreate>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public MainProjectCreate()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public MainProjectCreate(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public MainProjectCreate(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public MainProjectCreate(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("MainProjectCreate_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarMainProjectCreateId = new TableSchema.TableColumn(schema);
				colvarMainProjectCreateId.ColumnName = "MainProjectCreateId";
				colvarMainProjectCreateId.DataType = DbType.Int32;
				colvarMainProjectCreateId.MaxLength = 0;
				colvarMainProjectCreateId.AutoIncrement = true;
				colvarMainProjectCreateId.IsNullable = false;
				colvarMainProjectCreateId.IsPrimaryKey = true;
				colvarMainProjectCreateId.IsForeignKey = false;
				colvarMainProjectCreateId.IsReadOnly = false;
				colvarMainProjectCreateId.DefaultSetting = @"";
				colvarMainProjectCreateId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMainProjectCreateId);
				
				TableSchema.TableColumn colvarClientId = new TableSchema.TableColumn(schema);
				colvarClientId.ColumnName = "ClientId";
				colvarClientId.DataType = DbType.Int32;
				colvarClientId.MaxLength = 0;
				colvarClientId.AutoIncrement = false;
				colvarClientId.IsNullable = true;
				colvarClientId.IsPrimaryKey = false;
				colvarClientId.IsForeignKey = false;
				colvarClientId.IsReadOnly = false;
				colvarClientId.DefaultSetting = @"";
				colvarClientId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarClientId);
				
				TableSchema.TableColumn colvarProjectLevelId = new TableSchema.TableColumn(schema);
				colvarProjectLevelId.ColumnName = "ProjectLevelId";
				colvarProjectLevelId.DataType = DbType.Int32;
				colvarProjectLevelId.MaxLength = 0;
				colvarProjectLevelId.AutoIncrement = false;
				colvarProjectLevelId.IsNullable = true;
				colvarProjectLevelId.IsPrimaryKey = false;
				colvarProjectLevelId.IsForeignKey = false;
				colvarProjectLevelId.IsReadOnly = false;
				colvarProjectLevelId.DefaultSetting = @"";
				colvarProjectLevelId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProjectLevelId);
				
				TableSchema.TableColumn colvarProjectTypeId = new TableSchema.TableColumn(schema);
				colvarProjectTypeId.ColumnName = "ProjectTypeId";
				colvarProjectTypeId.DataType = DbType.Int32;
				colvarProjectTypeId.MaxLength = 0;
				colvarProjectTypeId.AutoIncrement = false;
				colvarProjectTypeId.IsNullable = true;
				colvarProjectTypeId.IsPrimaryKey = false;
				colvarProjectTypeId.IsForeignKey = false;
				colvarProjectTypeId.IsReadOnly = false;
				colvarProjectTypeId.DefaultSetting = @"";
				colvarProjectTypeId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProjectTypeId);
				
				TableSchema.TableColumn colvarYeWuId = new TableSchema.TableColumn(schema);
				colvarYeWuId.ColumnName = "YeWuId";
				colvarYeWuId.DataType = DbType.Int32;
				colvarYeWuId.MaxLength = 0;
				colvarYeWuId.AutoIncrement = false;
				colvarYeWuId.IsNullable = true;
				colvarYeWuId.IsPrimaryKey = false;
				colvarYeWuId.IsForeignKey = false;
				colvarYeWuId.IsReadOnly = false;
				colvarYeWuId.DefaultSetting = @"";
				colvarYeWuId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarYeWuId);
				
				TableSchema.TableColumn colvarSheetNum = new TableSchema.TableColumn(schema);
				colvarSheetNum.ColumnName = "SheetNum";
				colvarSheetNum.DataType = DbType.String;
				colvarSheetNum.MaxLength = 50;
				colvarSheetNum.AutoIncrement = false;
				colvarSheetNum.IsNullable = true;
				colvarSheetNum.IsPrimaryKey = false;
				colvarSheetNum.IsForeignKey = false;
				colvarSheetNum.IsReadOnly = false;
				colvarSheetNum.DefaultSetting = @"";
				colvarSheetNum.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSheetNum);
				
				TableSchema.TableColumn colvarProjectName = new TableSchema.TableColumn(schema);
				colvarProjectName.ColumnName = "ProjectName";
				colvarProjectName.DataType = DbType.String;
				colvarProjectName.MaxLength = 50;
				colvarProjectName.AutoIncrement = false;
				colvarProjectName.IsNullable = true;
				colvarProjectName.IsPrimaryKey = false;
				colvarProjectName.IsForeignKey = false;
				colvarProjectName.IsReadOnly = false;
				colvarProjectName.DefaultSetting = @"";
				colvarProjectName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProjectName);
				
				TableSchema.TableColumn colvarPreMoney = new TableSchema.TableColumn(schema);
				colvarPreMoney.ColumnName = "PreMoney";
				colvarPreMoney.DataType = DbType.String;
				colvarPreMoney.MaxLength = 50;
				colvarPreMoney.AutoIncrement = false;
				colvarPreMoney.IsNullable = true;
				colvarPreMoney.IsPrimaryKey = false;
				colvarPreMoney.IsForeignKey = false;
				colvarPreMoney.IsReadOnly = false;
				colvarPreMoney.DefaultSetting = @"";
				colvarPreMoney.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPreMoney);
				
				TableSchema.TableColumn colvarPreProfit = new TableSchema.TableColumn(schema);
				colvarPreProfit.ColumnName = "PreProfit";
				colvarPreProfit.DataType = DbType.String;
				colvarPreProfit.MaxLength = 50;
				colvarPreProfit.AutoIncrement = false;
				colvarPreProfit.IsNullable = true;
				colvarPreProfit.IsPrimaryKey = false;
				colvarPreProfit.IsForeignKey = false;
				colvarPreProfit.IsReadOnly = false;
				colvarPreProfit.DefaultSetting = @"";
				colvarPreProfit.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPreProfit);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("MainProjectCreate_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("MainProjectCreateId")]
		[Bindable(true)]
		public int MainProjectCreateId 
		{
			get { return GetColumnValue<int>(Columns.MainProjectCreateId); }
			set { SetColumnValue(Columns.MainProjectCreateId, value); }
		}
		  
		[XmlAttribute("ClientId")]
		[Bindable(true)]
		public int? ClientId 
		{
			get { return GetColumnValue<int?>(Columns.ClientId); }
			set { SetColumnValue(Columns.ClientId, value); }
		}
		  
		[XmlAttribute("ProjectLevelId")]
		[Bindable(true)]
		public int? ProjectLevelId 
		{
			get { return GetColumnValue<int?>(Columns.ProjectLevelId); }
			set { SetColumnValue(Columns.ProjectLevelId, value); }
		}
		  
		[XmlAttribute("ProjectTypeId")]
		[Bindable(true)]
		public int? ProjectTypeId 
		{
			get { return GetColumnValue<int?>(Columns.ProjectTypeId); }
			set { SetColumnValue(Columns.ProjectTypeId, value); }
		}
		  
		[XmlAttribute("YeWuId")]
		[Bindable(true)]
		public int? YeWuId 
		{
			get { return GetColumnValue<int?>(Columns.YeWuId); }
			set { SetColumnValue(Columns.YeWuId, value); }
		}
		  
		[XmlAttribute("SheetNum")]
		[Bindable(true)]
		public string SheetNum 
		{
			get { return GetColumnValue<string>(Columns.SheetNum); }
			set { SetColumnValue(Columns.SheetNum, value); }
		}
		  
		[XmlAttribute("ProjectName")]
		[Bindable(true)]
		public string ProjectName 
		{
			get { return GetColumnValue<string>(Columns.ProjectName); }
			set { SetColumnValue(Columns.ProjectName, value); }
		}
		  
		[XmlAttribute("PreMoney")]
		[Bindable(true)]
		public string PreMoney 
		{
			get { return GetColumnValue<string>(Columns.PreMoney); }
			set { SetColumnValue(Columns.PreMoney, value); }
		}
		  
		[XmlAttribute("PreProfit")]
		[Bindable(true)]
		public string PreProfit 
		{
			get { return GetColumnValue<string>(Columns.PreProfit); }
			set { SetColumnValue(Columns.PreProfit, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int? varClientId,int? varProjectLevelId,int? varProjectTypeId,int? varYeWuId,string varSheetNum,string varProjectName,string varPreMoney,string varPreProfit)
		{
			MainProjectCreate item = new MainProjectCreate();
			
			item.ClientId = varClientId;
			
			item.ProjectLevelId = varProjectLevelId;
			
			item.ProjectTypeId = varProjectTypeId;
			
			item.YeWuId = varYeWuId;
			
			item.SheetNum = varSheetNum;
			
			item.ProjectName = varProjectName;
			
			item.PreMoney = varPreMoney;
			
			item.PreProfit = varPreProfit;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varMainProjectCreateId,int? varClientId,int? varProjectLevelId,int? varProjectTypeId,int? varYeWuId,string varSheetNum,string varProjectName,string varPreMoney,string varPreProfit)
		{
			MainProjectCreate item = new MainProjectCreate();
			
				item.MainProjectCreateId = varMainProjectCreateId;
			
				item.ClientId = varClientId;
			
				item.ProjectLevelId = varProjectLevelId;
			
				item.ProjectTypeId = varProjectTypeId;
			
				item.YeWuId = varYeWuId;
			
				item.SheetNum = varSheetNum;
			
				item.ProjectName = varProjectName;
			
				item.PreMoney = varPreMoney;
			
				item.PreProfit = varPreProfit;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn MainProjectCreateIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ClientIdColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn ProjectLevelIdColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn ProjectTypeIdColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn YeWuIdColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn SheetNumColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn ProjectNameColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn PreMoneyColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn PreProfitColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string MainProjectCreateId = @"MainProjectCreateId";
			 public static string ClientId = @"ClientId";
			 public static string ProjectLevelId = @"ProjectLevelId";
			 public static string ProjectTypeId = @"ProjectTypeId";
			 public static string YeWuId = @"YeWuId";
			 public static string SheetNum = @"SheetNum";
			 public static string ProjectName = @"ProjectName";
			 public static string PreMoney = @"PreMoney";
			 public static string PreProfit = @"PreProfit";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
