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
	/// Strongly-typed collection for the OverTime class.
	/// </summary>
    [Serializable]
	public partial class OverTimeCollection : ActiveList<OverTime, OverTimeCollection>
	{	   
		public OverTimeCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>OverTimeCollection</returns>
		public OverTimeCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                OverTime o = this[i];
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
	/// This is an ActiveRecord class which wraps the OverTime_tb table.
	/// </summary>
	[Serializable]
	public partial class OverTime : ActiveRecord<OverTime>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public OverTime()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public OverTime(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public OverTime(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public OverTime(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("OverTime_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarOverTimeId = new TableSchema.TableColumn(schema);
				colvarOverTimeId.ColumnName = "OverTimeId";
				colvarOverTimeId.DataType = DbType.Int32;
				colvarOverTimeId.MaxLength = 0;
				colvarOverTimeId.AutoIncrement = true;
				colvarOverTimeId.IsNullable = false;
				colvarOverTimeId.IsPrimaryKey = true;
				colvarOverTimeId.IsForeignKey = false;
				colvarOverTimeId.IsReadOnly = false;
				colvarOverTimeId.DefaultSetting = @"";
				colvarOverTimeId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOverTimeId);
				
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
				
				TableSchema.TableColumn colvarTimeFrom = new TableSchema.TableColumn(schema);
				colvarTimeFrom.ColumnName = "TimeFrom";
				colvarTimeFrom.DataType = DbType.String;
				colvarTimeFrom.MaxLength = 50;
				colvarTimeFrom.AutoIncrement = false;
				colvarTimeFrom.IsNullable = true;
				colvarTimeFrom.IsPrimaryKey = false;
				colvarTimeFrom.IsForeignKey = false;
				colvarTimeFrom.IsReadOnly = false;
				colvarTimeFrom.DefaultSetting = @"";
				colvarTimeFrom.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTimeFrom);
				
				TableSchema.TableColumn colvarTimeTo = new TableSchema.TableColumn(schema);
				colvarTimeTo.ColumnName = "TimeTo";
				colvarTimeTo.DataType = DbType.String;
				colvarTimeTo.MaxLength = 50;
				colvarTimeTo.AutoIncrement = false;
				colvarTimeTo.IsNullable = true;
				colvarTimeTo.IsPrimaryKey = false;
				colvarTimeTo.IsForeignKey = false;
				colvarTimeTo.IsReadOnly = false;
				colvarTimeTo.DefaultSetting = @"";
				colvarTimeTo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTimeTo);
				
				TableSchema.TableColumn colvarApplyEmName = new TableSchema.TableColumn(schema);
				colvarApplyEmName.ColumnName = "ApplyEmName";
				colvarApplyEmName.DataType = DbType.String;
				colvarApplyEmName.MaxLength = 50;
				colvarApplyEmName.AutoIncrement = false;
				colvarApplyEmName.IsNullable = true;
				colvarApplyEmName.IsPrimaryKey = false;
				colvarApplyEmName.IsForeignKey = false;
				colvarApplyEmName.IsReadOnly = false;
				colvarApplyEmName.DefaultSetting = @"";
				colvarApplyEmName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarApplyEmName);
				
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
				
				TableSchema.TableColumn colvarIsSubmit = new TableSchema.TableColumn(schema);
				colvarIsSubmit.ColumnName = "IsSubmit";
				colvarIsSubmit.DataType = DbType.String;
				colvarIsSubmit.MaxLength = 10;
				colvarIsSubmit.AutoIncrement = false;
				colvarIsSubmit.IsNullable = true;
				colvarIsSubmit.IsPrimaryKey = false;
				colvarIsSubmit.IsForeignKey = false;
				colvarIsSubmit.IsReadOnly = false;
				colvarIsSubmit.DefaultSetting = @"";
				colvarIsSubmit.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIsSubmit);
				
				TableSchema.TableColumn colvarTimeSpan = new TableSchema.TableColumn(schema);
				colvarTimeSpan.ColumnName = "TimeSpan";
				colvarTimeSpan.DataType = DbType.String;
				colvarTimeSpan.MaxLength = 50;
				colvarTimeSpan.AutoIncrement = false;
				colvarTimeSpan.IsNullable = true;
				colvarTimeSpan.IsPrimaryKey = false;
				colvarTimeSpan.IsForeignKey = false;
				colvarTimeSpan.IsReadOnly = false;
				colvarTimeSpan.DefaultSetting = @"";
				colvarTimeSpan.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTimeSpan);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("OverTime_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("OverTimeId")]
		[Bindable(true)]
		public int OverTimeId 
		{
			get { return GetColumnValue<int>(Columns.OverTimeId); }
			set { SetColumnValue(Columns.OverTimeId, value); }
		}
		  
		[XmlAttribute("ApplyDate")]
		[Bindable(true)]
		public string ApplyDate 
		{
			get { return GetColumnValue<string>(Columns.ApplyDate); }
			set { SetColumnValue(Columns.ApplyDate, value); }
		}
		  
		[XmlAttribute("TimeFrom")]
		[Bindable(true)]
		public string TimeFrom 
		{
			get { return GetColumnValue<string>(Columns.TimeFrom); }
			set { SetColumnValue(Columns.TimeFrom, value); }
		}
		  
		[XmlAttribute("TimeTo")]
		[Bindable(true)]
		public string TimeTo 
		{
			get { return GetColumnValue<string>(Columns.TimeTo); }
			set { SetColumnValue(Columns.TimeTo, value); }
		}
		  
		[XmlAttribute("ApplyEmName")]
		[Bindable(true)]
		public string ApplyEmName 
		{
			get { return GetColumnValue<string>(Columns.ApplyEmName); }
			set { SetColumnValue(Columns.ApplyEmName, value); }
		}
		  
		[XmlAttribute("Reason")]
		[Bindable(true)]
		public string Reason 
		{
			get { return GetColumnValue<string>(Columns.Reason); }
			set { SetColumnValue(Columns.Reason, value); }
		}
		  
		[XmlAttribute("IsSubmit")]
		[Bindable(true)]
		public string IsSubmit 
		{
			get { return GetColumnValue<string>(Columns.IsSubmit); }
			set { SetColumnValue(Columns.IsSubmit, value); }
		}
		  
		[XmlAttribute("TimeSpan")]
		[Bindable(true)]
		public string TimeSpan 
		{
			get { return GetColumnValue<string>(Columns.TimeSpan); }
			set { SetColumnValue(Columns.TimeSpan, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varApplyDate,string varTimeFrom,string varTimeTo,string varApplyEmName,string varReason,string varIsSubmit,string varTimeSpan)
		{
			OverTime item = new OverTime();
			
			item.ApplyDate = varApplyDate;
			
			item.TimeFrom = varTimeFrom;
			
			item.TimeTo = varTimeTo;
			
			item.ApplyEmName = varApplyEmName;
			
			item.Reason = varReason;
			
			item.IsSubmit = varIsSubmit;
			
			item.TimeSpan = varTimeSpan;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varOverTimeId,string varApplyDate,string varTimeFrom,string varTimeTo,string varApplyEmName,string varReason,string varIsSubmit,string varTimeSpan)
		{
			OverTime item = new OverTime();
			
				item.OverTimeId = varOverTimeId;
			
				item.ApplyDate = varApplyDate;
			
				item.TimeFrom = varTimeFrom;
			
				item.TimeTo = varTimeTo;
			
				item.ApplyEmName = varApplyEmName;
			
				item.Reason = varReason;
			
				item.IsSubmit = varIsSubmit;
			
				item.TimeSpan = varTimeSpan;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn OverTimeIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ApplyDateColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn TimeFromColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn TimeToColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn ApplyEmNameColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn ReasonColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn IsSubmitColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn TimeSpanColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string OverTimeId = @"OverTimeId";
			 public static string ApplyDate = @"ApplyDate";
			 public static string TimeFrom = @"TimeFrom";
			 public static string TimeTo = @"TimeTo";
			 public static string ApplyEmName = @"ApplyEmName";
			 public static string Reason = @"Reason";
			 public static string IsSubmit = @"IsSubmit";
			 public static string TimeSpan = @"TimeSpan";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
