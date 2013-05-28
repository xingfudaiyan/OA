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
	/// Strongly-typed collection for the HolidayApply class.
	/// </summary>
    [Serializable]
	public partial class HolidayApplyCollection : ActiveList<HolidayApply, HolidayApplyCollection>
	{	   
		public HolidayApplyCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>HolidayApplyCollection</returns>
		public HolidayApplyCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                HolidayApply o = this[i];
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
	/// This is an ActiveRecord class which wraps the HolidayApply_tb table.
	/// </summary>
	[Serializable]
	public partial class HolidayApply : ActiveRecord<HolidayApply>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public HolidayApply()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public HolidayApply(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public HolidayApply(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public HolidayApply(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("HolidayApply_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarHolidayApplyId = new TableSchema.TableColumn(schema);
				colvarHolidayApplyId.ColumnName = "HolidayApplyId";
				colvarHolidayApplyId.DataType = DbType.Int32;
				colvarHolidayApplyId.MaxLength = 0;
				colvarHolidayApplyId.AutoIncrement = true;
				colvarHolidayApplyId.IsNullable = false;
				colvarHolidayApplyId.IsPrimaryKey = true;
				colvarHolidayApplyId.IsForeignKey = false;
				colvarHolidayApplyId.IsReadOnly = false;
				colvarHolidayApplyId.DefaultSetting = @"";
				colvarHolidayApplyId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarHolidayApplyId);
				
				TableSchema.TableColumn colvarCompany1 = new TableSchema.TableColumn(schema);
				colvarCompany1.ColumnName = "Company1";
				colvarCompany1.DataType = DbType.String;
				colvarCompany1.MaxLength = 50;
				colvarCompany1.AutoIncrement = false;
				colvarCompany1.IsNullable = true;
				colvarCompany1.IsPrimaryKey = false;
				colvarCompany1.IsForeignKey = false;
				colvarCompany1.IsReadOnly = false;
				colvarCompany1.DefaultSetting = @"";
				colvarCompany1.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCompany1);
				
				TableSchema.TableColumn colvarPositonName = new TableSchema.TableColumn(schema);
				colvarPositonName.ColumnName = "PositonName";
				colvarPositonName.DataType = DbType.String;
				colvarPositonName.MaxLength = 50;
				colvarPositonName.AutoIncrement = false;
				colvarPositonName.IsNullable = true;
				colvarPositonName.IsPrimaryKey = false;
				colvarPositonName.IsForeignKey = false;
				colvarPositonName.IsReadOnly = false;
				colvarPositonName.DefaultSetting = @"";
				colvarPositonName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPositonName);
				
				TableSchema.TableColumn colvarCompany2 = new TableSchema.TableColumn(schema);
				colvarCompany2.ColumnName = "Company2";
				colvarCompany2.DataType = DbType.String;
				colvarCompany2.MaxLength = 50;
				colvarCompany2.AutoIncrement = false;
				colvarCompany2.IsNullable = true;
				colvarCompany2.IsPrimaryKey = false;
				colvarCompany2.IsForeignKey = false;
				colvarCompany2.IsReadOnly = false;
				colvarCompany2.DefaultSetting = @"";
				colvarCompany2.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCompany2);
				
				TableSchema.TableColumn colvarCompany2Name = new TableSchema.TableColumn(schema);
				colvarCompany2Name.ColumnName = "Company2Name";
				colvarCompany2Name.DataType = DbType.String;
				colvarCompany2Name.MaxLength = 50;
				colvarCompany2Name.AutoIncrement = false;
				colvarCompany2Name.IsNullable = true;
				colvarCompany2Name.IsPrimaryKey = false;
				colvarCompany2Name.IsForeignKey = false;
				colvarCompany2Name.IsReadOnly = false;
				colvarCompany2Name.DefaultSetting = @"";
				colvarCompany2Name.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCompany2Name);
				
				TableSchema.TableColumn colvarHolidayTypeId = new TableSchema.TableColumn(schema);
				colvarHolidayTypeId.ColumnName = "HolidayTypeId";
				colvarHolidayTypeId.DataType = DbType.Int32;
				colvarHolidayTypeId.MaxLength = 0;
				colvarHolidayTypeId.AutoIncrement = false;
				colvarHolidayTypeId.IsNullable = true;
				colvarHolidayTypeId.IsPrimaryKey = false;
				colvarHolidayTypeId.IsForeignKey = false;
				colvarHolidayTypeId.IsReadOnly = false;
				colvarHolidayTypeId.DefaultSetting = @"";
				colvarHolidayTypeId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarHolidayTypeId);
				
				TableSchema.TableColumn colvarBeginTime = new TableSchema.TableColumn(schema);
				colvarBeginTime.ColumnName = "BeginTime";
				colvarBeginTime.DataType = DbType.String;
				colvarBeginTime.MaxLength = 50;
				colvarBeginTime.AutoIncrement = false;
				colvarBeginTime.IsNullable = true;
				colvarBeginTime.IsPrimaryKey = false;
				colvarBeginTime.IsForeignKey = false;
				colvarBeginTime.IsReadOnly = false;
				colvarBeginTime.DefaultSetting = @"";
				colvarBeginTime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBeginTime);
				
				TableSchema.TableColumn colvarEndTime = new TableSchema.TableColumn(schema);
				colvarEndTime.ColumnName = "EndTime";
				colvarEndTime.DataType = DbType.String;
				colvarEndTime.MaxLength = 50;
				colvarEndTime.AutoIncrement = false;
				colvarEndTime.IsNullable = true;
				colvarEndTime.IsPrimaryKey = false;
				colvarEndTime.IsForeignKey = false;
				colvarEndTime.IsReadOnly = false;
				colvarEndTime.DefaultSetting = @"";
				colvarEndTime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEndTime);
				
				TableSchema.TableColumn colvarTimeSum = new TableSchema.TableColumn(schema);
				colvarTimeSum.ColumnName = "TimeSum";
				colvarTimeSum.DataType = DbType.String;
				colvarTimeSum.MaxLength = 50;
				colvarTimeSum.AutoIncrement = false;
				colvarTimeSum.IsNullable = true;
				colvarTimeSum.IsPrimaryKey = false;
				colvarTimeSum.IsForeignKey = false;
				colvarTimeSum.IsReadOnly = false;
				colvarTimeSum.DefaultSetting = @"";
				colvarTimeSum.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTimeSum);
				
				TableSchema.TableColumn colvarReason = new TableSchema.TableColumn(schema);
				colvarReason.ColumnName = "Reason";
				colvarReason.DataType = DbType.String;
				colvarReason.MaxLength = 50;
				colvarReason.AutoIncrement = false;
				colvarReason.IsNullable = true;
				colvarReason.IsPrimaryKey = false;
				colvarReason.IsForeignKey = false;
				colvarReason.IsReadOnly = false;
				colvarReason.DefaultSetting = @"";
				colvarReason.ForeignKeyTableName = "";
				schema.Columns.Add(colvarReason);
				
				TableSchema.TableColumn colvarSectionView = new TableSchema.TableColumn(schema);
				colvarSectionView.ColumnName = "SectionView";
				colvarSectionView.DataType = DbType.String;
				colvarSectionView.MaxLength = 50;
				colvarSectionView.AutoIncrement = false;
				colvarSectionView.IsNullable = true;
				colvarSectionView.IsPrimaryKey = false;
				colvarSectionView.IsForeignKey = false;
				colvarSectionView.IsReadOnly = false;
				colvarSectionView.DefaultSetting = @"";
				colvarSectionView.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSectionView);
				
				TableSchema.TableColumn colvarHrView = new TableSchema.TableColumn(schema);
				colvarHrView.ColumnName = "HrView";
				colvarHrView.DataType = DbType.String;
				colvarHrView.MaxLength = 50;
				colvarHrView.AutoIncrement = false;
				colvarHrView.IsNullable = true;
				colvarHrView.IsPrimaryKey = false;
				colvarHrView.IsForeignKey = false;
				colvarHrView.IsReadOnly = false;
				colvarHrView.DefaultSetting = @"";
				colvarHrView.ForeignKeyTableName = "";
				schema.Columns.Add(colvarHrView);
				
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
				
				TableSchema.TableColumn colvarMemo = new TableSchema.TableColumn(schema);
				colvarMemo.ColumnName = "Memo";
				colvarMemo.DataType = DbType.String;
				colvarMemo.MaxLength = 50;
				colvarMemo.AutoIncrement = false;
				colvarMemo.IsNullable = true;
				colvarMemo.IsPrimaryKey = false;
				colvarMemo.IsForeignKey = false;
				colvarMemo.IsReadOnly = false;
				colvarMemo.DefaultSetting = @"";
				colvarMemo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMemo);
				
				TableSchema.TableColumn colvarApplyDate = new TableSchema.TableColumn(schema);
				colvarApplyDate.ColumnName = "ApplyDate";
				colvarApplyDate.DataType = DbType.String;
				colvarApplyDate.MaxLength = 50;
				colvarApplyDate.AutoIncrement = false;
				colvarApplyDate.IsNullable = true;
				colvarApplyDate.IsPrimaryKey = false;
				colvarApplyDate.IsForeignKey = false;
				colvarApplyDate.IsReadOnly = false;
				colvarApplyDate.DefaultSetting = @"";
				colvarApplyDate.ForeignKeyTableName = "";
				schema.Columns.Add(colvarApplyDate);
				
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
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("HolidayApply_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("HolidayApplyId")]
		[Bindable(true)]
		public int HolidayApplyId 
		{
			get { return GetColumnValue<int>(Columns.HolidayApplyId); }
			set { SetColumnValue(Columns.HolidayApplyId, value); }
		}
		  
		[XmlAttribute("Company1")]
		[Bindable(true)]
		public string Company1 
		{
			get { return GetColumnValue<string>(Columns.Company1); }
			set { SetColumnValue(Columns.Company1, value); }
		}
		  
		[XmlAttribute("PositonName")]
		[Bindable(true)]
		public string PositonName 
		{
			get { return GetColumnValue<string>(Columns.PositonName); }
			set { SetColumnValue(Columns.PositonName, value); }
		}
		  
		[XmlAttribute("Company2")]
		[Bindable(true)]
		public string Company2 
		{
			get { return GetColumnValue<string>(Columns.Company2); }
			set { SetColumnValue(Columns.Company2, value); }
		}
		  
		[XmlAttribute("Company2Name")]
		[Bindable(true)]
		public string Company2Name 
		{
			get { return GetColumnValue<string>(Columns.Company2Name); }
			set { SetColumnValue(Columns.Company2Name, value); }
		}
		  
		[XmlAttribute("HolidayTypeId")]
		[Bindable(true)]
		public int? HolidayTypeId 
		{
			get { return GetColumnValue<int?>(Columns.HolidayTypeId); }
			set { SetColumnValue(Columns.HolidayTypeId, value); }
		}
		  
		[XmlAttribute("BeginTime")]
		[Bindable(true)]
		public string BeginTime 
		{
			get { return GetColumnValue<string>(Columns.BeginTime); }
			set { SetColumnValue(Columns.BeginTime, value); }
		}
		  
		[XmlAttribute("EndTime")]
		[Bindable(true)]
		public string EndTime 
		{
			get { return GetColumnValue<string>(Columns.EndTime); }
			set { SetColumnValue(Columns.EndTime, value); }
		}
		  
		[XmlAttribute("TimeSum")]
		[Bindable(true)]
		public string TimeSum 
		{
			get { return GetColumnValue<string>(Columns.TimeSum); }
			set { SetColumnValue(Columns.TimeSum, value); }
		}
		  
		[XmlAttribute("Reason")]
		[Bindable(true)]
		public string Reason 
		{
			get { return GetColumnValue<string>(Columns.Reason); }
			set { SetColumnValue(Columns.Reason, value); }
		}
		  
		[XmlAttribute("SectionView")]
		[Bindable(true)]
		public string SectionView 
		{
			get { return GetColumnValue<string>(Columns.SectionView); }
			set { SetColumnValue(Columns.SectionView, value); }
		}
		  
		[XmlAttribute("HrView")]
		[Bindable(true)]
		public string HrView 
		{
			get { return GetColumnValue<string>(Columns.HrView); }
			set { SetColumnValue(Columns.HrView, value); }
		}
		  
		[XmlAttribute("ManagerView")]
		[Bindable(true)]
		public string ManagerView 
		{
			get { return GetColumnValue<string>(Columns.ManagerView); }
			set { SetColumnValue(Columns.ManagerView, value); }
		}
		  
		[XmlAttribute("Memo")]
		[Bindable(true)]
		public string Memo 
		{
			get { return GetColumnValue<string>(Columns.Memo); }
			set { SetColumnValue(Columns.Memo, value); }
		}
		  
		[XmlAttribute("ApplyDate")]
		[Bindable(true)]
		public string ApplyDate 
		{
			get { return GetColumnValue<string>(Columns.ApplyDate); }
			set { SetColumnValue(Columns.ApplyDate, value); }
		}
		  
		[XmlAttribute("ApplyTime")]
		[Bindable(true)]
		public string ApplyTime 
		{
			get { return GetColumnValue<string>(Columns.ApplyTime); }
			set { SetColumnValue(Columns.ApplyTime, value); }
		}
		  
		[XmlAttribute("ApplyName")]
		[Bindable(true)]
		public string ApplyName 
		{
			get { return GetColumnValue<string>(Columns.ApplyName); }
			set { SetColumnValue(Columns.ApplyName, value); }
		}
		  
		[XmlAttribute("DepartName")]
		[Bindable(true)]
		public string DepartName 
		{
			get { return GetColumnValue<string>(Columns.DepartName); }
			set { SetColumnValue(Columns.DepartName, value); }
		}
		  
		[XmlAttribute("State")]
		[Bindable(true)]
		public int? State 
		{
			get { return GetColumnValue<int?>(Columns.State); }
			set { SetColumnValue(Columns.State, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varCompany1,string varPositonName,string varCompany2,string varCompany2Name,int? varHolidayTypeId,string varBeginTime,string varEndTime,string varTimeSum,string varReason,string varSectionView,string varHrView,string varManagerView,string varMemo,string varApplyDate,string varApplyTime,string varApplyName,string varDepartName,int? varState)
		{
			HolidayApply item = new HolidayApply();
			
			item.Company1 = varCompany1;
			
			item.PositonName = varPositonName;
			
			item.Company2 = varCompany2;
			
			item.Company2Name = varCompany2Name;
			
			item.HolidayTypeId = varHolidayTypeId;
			
			item.BeginTime = varBeginTime;
			
			item.EndTime = varEndTime;
			
			item.TimeSum = varTimeSum;
			
			item.Reason = varReason;
			
			item.SectionView = varSectionView;
			
			item.HrView = varHrView;
			
			item.ManagerView = varManagerView;
			
			item.Memo = varMemo;
			
			item.ApplyDate = varApplyDate;
			
			item.ApplyTime = varApplyTime;
			
			item.ApplyName = varApplyName;
			
			item.DepartName = varDepartName;
			
			item.State = varState;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varHolidayApplyId,string varCompany1,string varPositonName,string varCompany2,string varCompany2Name,int? varHolidayTypeId,string varBeginTime,string varEndTime,string varTimeSum,string varReason,string varSectionView,string varHrView,string varManagerView,string varMemo,string varApplyDate,string varApplyTime,string varApplyName,string varDepartName,int? varState)
		{
			HolidayApply item = new HolidayApply();
			
				item.HolidayApplyId = varHolidayApplyId;
			
				item.Company1 = varCompany1;
			
				item.PositonName = varPositonName;
			
				item.Company2 = varCompany2;
			
				item.Company2Name = varCompany2Name;
			
				item.HolidayTypeId = varHolidayTypeId;
			
				item.BeginTime = varBeginTime;
			
				item.EndTime = varEndTime;
			
				item.TimeSum = varTimeSum;
			
				item.Reason = varReason;
			
				item.SectionView = varSectionView;
			
				item.HrView = varHrView;
			
				item.ManagerView = varManagerView;
			
				item.Memo = varMemo;
			
				item.ApplyDate = varApplyDate;
			
				item.ApplyTime = varApplyTime;
			
				item.ApplyName = varApplyName;
			
				item.DepartName = varDepartName;
			
				item.State = varState;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn HolidayApplyIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn Company1Column
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn PositonNameColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn Company2Column
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn Company2NameColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn HolidayTypeIdColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn BeginTimeColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn EndTimeColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn TimeSumColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn ReasonColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn SectionViewColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn HrViewColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn ManagerViewColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn MemoColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn ApplyDateColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn ApplyTimeColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn ApplyNameColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn DepartNameColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn StateColumn
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string HolidayApplyId = @"HolidayApplyId";
			 public static string Company1 = @"Company1";
			 public static string PositonName = @"PositonName";
			 public static string Company2 = @"Company2";
			 public static string Company2Name = @"Company2Name";
			 public static string HolidayTypeId = @"HolidayTypeId";
			 public static string BeginTime = @"BeginTime";
			 public static string EndTime = @"EndTime";
			 public static string TimeSum = @"TimeSum";
			 public static string Reason = @"Reason";
			 public static string SectionView = @"SectionView";
			 public static string HrView = @"HrView";
			 public static string ManagerView = @"ManagerView";
			 public static string Memo = @"Memo";
			 public static string ApplyDate = @"ApplyDate";
			 public static string ApplyTime = @"ApplyTime";
			 public static string ApplyName = @"ApplyName";
			 public static string DepartName = @"DepartName";
			 public static string State = @"State";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
