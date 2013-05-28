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
	/// Strongly-typed collection for the WeekSum class.
	/// </summary>
    [Serializable]
	public partial class WeekSumCollection : ActiveList<WeekSum, WeekSumCollection>
	{	   
		public WeekSumCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>WeekSumCollection</returns>
		public WeekSumCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                WeekSum o = this[i];
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
	/// This is an ActiveRecord class which wraps the WeekSum_tb table.
	/// </summary>
	[Serializable]
	public partial class WeekSum : ActiveRecord<WeekSum>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public WeekSum()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public WeekSum(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public WeekSum(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public WeekSum(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("WeekSum_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarWeekSumId = new TableSchema.TableColumn(schema);
				colvarWeekSumId.ColumnName = "WeekSumId";
				colvarWeekSumId.DataType = DbType.Int32;
				colvarWeekSumId.MaxLength = 0;
				colvarWeekSumId.AutoIncrement = true;
				colvarWeekSumId.IsNullable = false;
				colvarWeekSumId.IsPrimaryKey = true;
				colvarWeekSumId.IsForeignKey = false;
				colvarWeekSumId.IsReadOnly = false;
				colvarWeekSumId.DefaultSetting = @"";
				colvarWeekSumId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarWeekSumId);
				
				TableSchema.TableColumn colvarWeekSumName = new TableSchema.TableColumn(schema);
				colvarWeekSumName.ColumnName = "WeekSumName";
				colvarWeekSumName.DataType = DbType.String;
				colvarWeekSumName.MaxLength = 50;
				colvarWeekSumName.AutoIncrement = false;
				colvarWeekSumName.IsNullable = true;
				colvarWeekSumName.IsPrimaryKey = false;
				colvarWeekSumName.IsForeignKey = false;
				colvarWeekSumName.IsReadOnly = false;
				colvarWeekSumName.DefaultSetting = @"";
				colvarWeekSumName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarWeekSumName);
				
				TableSchema.TableColumn colvarIsApprove = new TableSchema.TableColumn(schema);
				colvarIsApprove.ColumnName = "IsApprove";
				colvarIsApprove.DataType = DbType.Int32;
				colvarIsApprove.MaxLength = 0;
				colvarIsApprove.AutoIncrement = false;
				colvarIsApprove.IsNullable = true;
				colvarIsApprove.IsPrimaryKey = false;
				colvarIsApprove.IsForeignKey = false;
				colvarIsApprove.IsReadOnly = false;
				colvarIsApprove.DefaultSetting = @"";
				colvarIsApprove.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIsApprove);
				
				TableSchema.TableColumn colvarIsApply = new TableSchema.TableColumn(schema);
				colvarIsApply.ColumnName = "IsApply";
				colvarIsApply.DataType = DbType.Int32;
				colvarIsApply.MaxLength = 0;
				colvarIsApply.AutoIncrement = false;
				colvarIsApply.IsNullable = true;
				colvarIsApply.IsPrimaryKey = false;
				colvarIsApply.IsForeignKey = false;
				colvarIsApply.IsReadOnly = false;
				colvarIsApply.DefaultSetting = @"";
				colvarIsApply.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIsApply);
				
				TableSchema.TableColumn colvarIsSend = new TableSchema.TableColumn(schema);
				colvarIsSend.ColumnName = "IsSend";
				colvarIsSend.DataType = DbType.Int32;
				colvarIsSend.MaxLength = 0;
				colvarIsSend.AutoIncrement = false;
				colvarIsSend.IsNullable = true;
				colvarIsSend.IsPrimaryKey = false;
				colvarIsSend.IsForeignKey = false;
				colvarIsSend.IsReadOnly = false;
				colvarIsSend.DefaultSetting = @"";
				colvarIsSend.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIsSend);
				
				TableSchema.TableColumn colvarApplyTime = new TableSchema.TableColumn(schema);
				colvarApplyTime.ColumnName = "ApplyTime";
				colvarApplyTime.DataType = DbType.DateTime;
				colvarApplyTime.MaxLength = 0;
				colvarApplyTime.AutoIncrement = false;
				colvarApplyTime.IsNullable = true;
				colvarApplyTime.IsPrimaryKey = false;
				colvarApplyTime.IsForeignKey = false;
				colvarApplyTime.IsReadOnly = false;
				colvarApplyTime.DefaultSetting = @"";
				colvarApplyTime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarApplyTime);
				
				TableSchema.TableColumn colvarRepplyTime = new TableSchema.TableColumn(schema);
				colvarRepplyTime.ColumnName = "RepplyTime";
				colvarRepplyTime.DataType = DbType.DateTime;
				colvarRepplyTime.MaxLength = 0;
				colvarRepplyTime.AutoIncrement = false;
				colvarRepplyTime.IsNullable = true;
				colvarRepplyTime.IsPrimaryKey = false;
				colvarRepplyTime.IsForeignKey = false;
				colvarRepplyTime.IsReadOnly = false;
				colvarRepplyTime.DefaultSetting = @"";
				colvarRepplyTime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRepplyTime);
				
				TableSchema.TableColumn colvarApplyView = new TableSchema.TableColumn(schema);
				colvarApplyView.ColumnName = "ApplyView";
				colvarApplyView.DataType = DbType.String;
				colvarApplyView.MaxLength = 50;
				colvarApplyView.AutoIncrement = false;
				colvarApplyView.IsNullable = true;
				colvarApplyView.IsPrimaryKey = false;
				colvarApplyView.IsForeignKey = false;
				colvarApplyView.IsReadOnly = false;
				colvarApplyView.DefaultSetting = @"";
				colvarApplyView.ForeignKeyTableName = "";
				schema.Columns.Add(colvarApplyView);
				
				TableSchema.TableColumn colvarSendEmployeeId = new TableSchema.TableColumn(schema);
				colvarSendEmployeeId.ColumnName = "SendEmployeeId";
				colvarSendEmployeeId.DataType = DbType.Int32;
				colvarSendEmployeeId.MaxLength = 0;
				colvarSendEmployeeId.AutoIncrement = false;
				colvarSendEmployeeId.IsNullable = true;
				colvarSendEmployeeId.IsPrimaryKey = false;
				colvarSendEmployeeId.IsForeignKey = true;
				colvarSendEmployeeId.IsReadOnly = false;
				colvarSendEmployeeId.DefaultSetting = @"";
				
					colvarSendEmployeeId.ForeignKeyTableName = "Employee_tb";
				schema.Columns.Add(colvarSendEmployeeId);
				
				TableSchema.TableColumn colvarRecvEmployeeId = new TableSchema.TableColumn(schema);
				colvarRecvEmployeeId.ColumnName = "RecvEmployeeId";
				colvarRecvEmployeeId.DataType = DbType.Int32;
				colvarRecvEmployeeId.MaxLength = 0;
				colvarRecvEmployeeId.AutoIncrement = false;
				colvarRecvEmployeeId.IsNullable = true;
				colvarRecvEmployeeId.IsPrimaryKey = false;
				colvarRecvEmployeeId.IsForeignKey = false;
				colvarRecvEmployeeId.IsReadOnly = false;
				colvarRecvEmployeeId.DefaultSetting = @"";
				colvarRecvEmployeeId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRecvEmployeeId);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("WeekSum_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("WeekSumId")]
		[Bindable(true)]
		public int WeekSumId 
		{
			get { return GetColumnValue<int>(Columns.WeekSumId); }
			set { SetColumnValue(Columns.WeekSumId, value); }
		}
		  
		[XmlAttribute("WeekSumName")]
		[Bindable(true)]
		public string WeekSumName 
		{
			get { return GetColumnValue<string>(Columns.WeekSumName); }
			set { SetColumnValue(Columns.WeekSumName, value); }
		}
		  
		[XmlAttribute("IsApprove")]
		[Bindable(true)]
		public int? IsApprove 
		{
			get { return GetColumnValue<int?>(Columns.IsApprove); }
			set { SetColumnValue(Columns.IsApprove, value); }
		}
		  
		[XmlAttribute("IsApply")]
		[Bindable(true)]
		public int? IsApply 
		{
			get { return GetColumnValue<int?>(Columns.IsApply); }
			set { SetColumnValue(Columns.IsApply, value); }
		}
		  
		[XmlAttribute("IsSend")]
		[Bindable(true)]
		public int? IsSend 
		{
			get { return GetColumnValue<int?>(Columns.IsSend); }
			set { SetColumnValue(Columns.IsSend, value); }
		}
		  
		[XmlAttribute("ApplyTime")]
		[Bindable(true)]
		public DateTime? ApplyTime 
		{
			get { return GetColumnValue<DateTime?>(Columns.ApplyTime); }
			set { SetColumnValue(Columns.ApplyTime, value); }
		}
		  
		[XmlAttribute("RepplyTime")]
		[Bindable(true)]
		public DateTime? RepplyTime 
		{
			get { return GetColumnValue<DateTime?>(Columns.RepplyTime); }
			set { SetColumnValue(Columns.RepplyTime, value); }
		}
		  
		[XmlAttribute("ApplyView")]
		[Bindable(true)]
		public string ApplyView 
		{
			get { return GetColumnValue<string>(Columns.ApplyView); }
			set { SetColumnValue(Columns.ApplyView, value); }
		}
		  
		[XmlAttribute("SendEmployeeId")]
		[Bindable(true)]
		public int? SendEmployeeId 
		{
			get { return GetColumnValue<int?>(Columns.SendEmployeeId); }
			set { SetColumnValue(Columns.SendEmployeeId, value); }
		}
		  
		[XmlAttribute("RecvEmployeeId")]
		[Bindable(true)]
		public int? RecvEmployeeId 
		{
			get { return GetColumnValue<int?>(Columns.RecvEmployeeId); }
			set { SetColumnValue(Columns.RecvEmployeeId, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		public CanYou.OA.DAL.DayCollection DayRecords()
		{
			return new CanYou.OA.DAL.DayCollection().Where(Day.Columns.WeekSumId, WeekSumId).Load();
		}
		#endregion
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a Employee ActiveRecord object related to this WeekSum
		/// 
		/// </summary>
		public CanYou.OA.DAL.Employee Employee
		{
			get { return CanYou.OA.DAL.Employee.FetchByID(this.SendEmployeeId); }
			set { SetColumnValue("SendEmployeeId", value.EmployeeId); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varWeekSumName,int? varIsApprove,int? varIsApply,int? varIsSend,DateTime? varApplyTime,DateTime? varRepplyTime,string varApplyView,int? varSendEmployeeId,int? varRecvEmployeeId)
		{
			WeekSum item = new WeekSum();
			
			item.WeekSumName = varWeekSumName;
			
			item.IsApprove = varIsApprove;
			
			item.IsApply = varIsApply;
			
			item.IsSend = varIsSend;
			
			item.ApplyTime = varApplyTime;
			
			item.RepplyTime = varRepplyTime;
			
			item.ApplyView = varApplyView;
			
			item.SendEmployeeId = varSendEmployeeId;
			
			item.RecvEmployeeId = varRecvEmployeeId;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varWeekSumId,string varWeekSumName,int? varIsApprove,int? varIsApply,int? varIsSend,DateTime? varApplyTime,DateTime? varRepplyTime,string varApplyView,int? varSendEmployeeId,int? varRecvEmployeeId)
		{
			WeekSum item = new WeekSum();
			
				item.WeekSumId = varWeekSumId;
			
				item.WeekSumName = varWeekSumName;
			
				item.IsApprove = varIsApprove;
			
				item.IsApply = varIsApply;
			
				item.IsSend = varIsSend;
			
				item.ApplyTime = varApplyTime;
			
				item.RepplyTime = varRepplyTime;
			
				item.ApplyView = varApplyView;
			
				item.SendEmployeeId = varSendEmployeeId;
			
				item.RecvEmployeeId = varRecvEmployeeId;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn WeekSumIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn WeekSumNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn IsApproveColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn IsApplyColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn IsSendColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn ApplyTimeColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn RepplyTimeColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn ApplyViewColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn SendEmployeeIdColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn RecvEmployeeIdColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string WeekSumId = @"WeekSumId";
			 public static string WeekSumName = @"WeekSumName";
			 public static string IsApprove = @"IsApprove";
			 public static string IsApply = @"IsApply";
			 public static string IsSend = @"IsSend";
			 public static string ApplyTime = @"ApplyTime";
			 public static string RepplyTime = @"RepplyTime";
			 public static string ApplyView = @"ApplyView";
			 public static string SendEmployeeId = @"SendEmployeeId";
			 public static string RecvEmployeeId = @"RecvEmployeeId";
						
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
