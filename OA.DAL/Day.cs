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
	/// Strongly-typed collection for the Day class.
	/// </summary>
    [Serializable]
	public partial class DayCollection : ActiveList<Day, DayCollection>
	{	   
		public DayCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>DayCollection</returns>
		public DayCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                Day o = this[i];
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
	/// This is an ActiveRecord class which wraps the Day_tb table.
	/// </summary>
	[Serializable]
	public partial class Day : ActiveRecord<Day>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public Day()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public Day(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public Day(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public Day(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("Day_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarDayId = new TableSchema.TableColumn(schema);
				colvarDayId.ColumnName = "DayId";
				colvarDayId.DataType = DbType.Int32;
				colvarDayId.MaxLength = 0;
				colvarDayId.AutoIncrement = true;
				colvarDayId.IsNullable = false;
				colvarDayId.IsPrimaryKey = true;
				colvarDayId.IsForeignKey = false;
				colvarDayId.IsReadOnly = false;
				colvarDayId.DefaultSetting = @"";
				colvarDayId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDayId);
				
				TableSchema.TableColumn colvarWeekId = new TableSchema.TableColumn(schema);
				colvarWeekId.ColumnName = "WeekId";
				colvarWeekId.DataType = DbType.Int32;
				colvarWeekId.MaxLength = 0;
				colvarWeekId.AutoIncrement = false;
				colvarWeekId.IsNullable = false;
				colvarWeekId.IsPrimaryKey = false;
				colvarWeekId.IsForeignKey = true;
				colvarWeekId.IsReadOnly = false;
				colvarWeekId.DefaultSetting = @"";
				
					colvarWeekId.ForeignKeyTableName = "Week_tb";
				schema.Columns.Add(colvarWeekId);
				
				TableSchema.TableColumn colvarWorkContent = new TableSchema.TableColumn(schema);
				colvarWorkContent.ColumnName = "WorkContent";
				colvarWorkContent.DataType = DbType.String;
				colvarWorkContent.MaxLength = -1;
				colvarWorkContent.AutoIncrement = false;
				colvarWorkContent.IsNullable = true;
				colvarWorkContent.IsPrimaryKey = false;
				colvarWorkContent.IsForeignKey = false;
				colvarWorkContent.IsReadOnly = false;
				colvarWorkContent.DefaultSetting = @"";
				colvarWorkContent.ForeignKeyTableName = "";
				schema.Columns.Add(colvarWorkContent);
				
				TableSchema.TableColumn colvarWorkDate = new TableSchema.TableColumn(schema);
				colvarWorkDate.ColumnName = "WorkDate";
				colvarWorkDate.DataType = DbType.DateTime;
				colvarWorkDate.MaxLength = 0;
				colvarWorkDate.AutoIncrement = false;
				colvarWorkDate.IsNullable = true;
				colvarWorkDate.IsPrimaryKey = false;
				colvarWorkDate.IsForeignKey = false;
				colvarWorkDate.IsReadOnly = false;
				colvarWorkDate.DefaultSetting = @"";
				colvarWorkDate.ForeignKeyTableName = "";
				schema.Columns.Add(colvarWorkDate);
				
				TableSchema.TableColumn colvarResult = new TableSchema.TableColumn(schema);
				colvarResult.ColumnName = "Result";
				colvarResult.DataType = DbType.String;
				colvarResult.MaxLength = -1;
				colvarResult.AutoIncrement = false;
				colvarResult.IsNullable = true;
				colvarResult.IsPrimaryKey = false;
				colvarResult.IsForeignKey = false;
				colvarResult.IsReadOnly = false;
				colvarResult.DefaultSetting = @"";
				colvarResult.ForeignKeyTableName = "";
				schema.Columns.Add(colvarResult);
				
				TableSchema.TableColumn colvarWeekSumId = new TableSchema.TableColumn(schema);
				colvarWeekSumId.ColumnName = "WeekSumId";
				colvarWeekSumId.DataType = DbType.Int32;
				colvarWeekSumId.MaxLength = 0;
				colvarWeekSumId.AutoIncrement = false;
				colvarWeekSumId.IsNullable = false;
				colvarWeekSumId.IsPrimaryKey = false;
				colvarWeekSumId.IsForeignKey = true;
				colvarWeekSumId.IsReadOnly = false;
				colvarWeekSumId.DefaultSetting = @"";
				
					colvarWeekSumId.ForeignKeyTableName = "WeekSum_tb";
				schema.Columns.Add(colvarWeekSumId);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("Day_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("DayId")]
		[Bindable(true)]
		public int DayId 
		{
			get { return GetColumnValue<int>(Columns.DayId); }
			set { SetColumnValue(Columns.DayId, value); }
		}
		  
		[XmlAttribute("WeekId")]
		[Bindable(true)]
		public int WeekId 
		{
			get { return GetColumnValue<int>(Columns.WeekId); }
			set { SetColumnValue(Columns.WeekId, value); }
		}
		  
		[XmlAttribute("WorkContent")]
		[Bindable(true)]
		public string WorkContent 
		{
			get { return GetColumnValue<string>(Columns.WorkContent); }
			set { SetColumnValue(Columns.WorkContent, value); }
		}
		  
		[XmlAttribute("WorkDate")]
		[Bindable(true)]
		public DateTime? WorkDate 
		{
			get { return GetColumnValue<DateTime?>(Columns.WorkDate); }
			set { SetColumnValue(Columns.WorkDate, value); }
		}
		  
		[XmlAttribute("Result")]
		[Bindable(true)]
		public string Result 
		{
			get { return GetColumnValue<string>(Columns.Result); }
			set { SetColumnValue(Columns.Result, value); }
		}
		  
		[XmlAttribute("WeekSumId")]
		[Bindable(true)]
		public int WeekSumId 
		{
			get { return GetColumnValue<int>(Columns.WeekSumId); }
			set { SetColumnValue(Columns.WeekSumId, value); }
		}
		
		#endregion
		
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a Week ActiveRecord object related to this Day
		/// 
		/// </summary>
		public CanYou.OA.DAL.Week Week
		{
			get { return CanYou.OA.DAL.Week.FetchByID(this.WeekId); }
			set { SetColumnValue("WeekId", value.WeekId); }
		}
		
		
		/// <summary>
		/// Returns a WeekSum ActiveRecord object related to this Day
		/// 
		/// </summary>
		public CanYou.OA.DAL.WeekSum WeekSum
		{
			get { return CanYou.OA.DAL.WeekSum.FetchByID(this.WeekSumId); }
			set { SetColumnValue("WeekSumId", value.WeekSumId); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varWeekId,string varWorkContent,DateTime? varWorkDate,string varResult,int varWeekSumId)
		{
			Day item = new Day();
			
			item.WeekId = varWeekId;
			
			item.WorkContent = varWorkContent;
			
			item.WorkDate = varWorkDate;
			
			item.Result = varResult;
			
			item.WeekSumId = varWeekSumId;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varDayId,int varWeekId,string varWorkContent,DateTime? varWorkDate,string varResult,int varWeekSumId)
		{
			Day item = new Day();
			
				item.DayId = varDayId;
			
				item.WeekId = varWeekId;
			
				item.WorkContent = varWorkContent;
			
				item.WorkDate = varWorkDate;
			
				item.Result = varResult;
			
				item.WeekSumId = varWeekSumId;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn DayIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn WeekIdColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn WorkContentColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn WorkDateColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn ResultColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn WeekSumIdColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string DayId = @"DayId";
			 public static string WeekId = @"WeekId";
			 public static string WorkContent = @"WorkContent";
			 public static string WorkDate = @"WorkDate";
			 public static string Result = @"Result";
			 public static string WeekSumId = @"WeekSumId";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
