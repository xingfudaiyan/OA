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
	/// Strongly-typed collection for the DayScore class.
	/// </summary>
    [Serializable]
	public partial class DayScoreCollection : ActiveList<DayScore, DayScoreCollection>
	{	   
		public DayScoreCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>DayScoreCollection</returns>
		public DayScoreCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                DayScore o = this[i];
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
	/// This is an ActiveRecord class which wraps the DayScore_tb table.
	/// </summary>
	[Serializable]
	public partial class DayScore : ActiveRecord<DayScore>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public DayScore()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public DayScore(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public DayScore(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public DayScore(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("DayScore_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarDayScoreId = new TableSchema.TableColumn(schema);
				colvarDayScoreId.ColumnName = "DayScoreId";
				colvarDayScoreId.DataType = DbType.Int32;
				colvarDayScoreId.MaxLength = 0;
				colvarDayScoreId.AutoIncrement = true;
				colvarDayScoreId.IsNullable = false;
				colvarDayScoreId.IsPrimaryKey = true;
				colvarDayScoreId.IsForeignKey = false;
				colvarDayScoreId.IsReadOnly = false;
				colvarDayScoreId.DefaultSetting = @"";
				colvarDayScoreId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDayScoreId);
				
				TableSchema.TableColumn colvarToday = new TableSchema.TableColumn(schema);
				colvarToday.ColumnName = "Today";
				colvarToday.DataType = DbType.String;
				colvarToday.MaxLength = 50;
				colvarToday.AutoIncrement = false;
				colvarToday.IsNullable = true;
				colvarToday.IsPrimaryKey = false;
				colvarToday.IsForeignKey = false;
				colvarToday.IsReadOnly = false;
				colvarToday.DefaultSetting = @"";
				colvarToday.ForeignKeyTableName = "";
				schema.Columns.Add(colvarToday);
				
				TableSchema.TableColumn colvarItem = new TableSchema.TableColumn(schema);
				colvarItem.ColumnName = "Item";
				colvarItem.DataType = DbType.String;
				colvarItem.MaxLength = -1;
				colvarItem.AutoIncrement = false;
				colvarItem.IsNullable = true;
				colvarItem.IsPrimaryKey = false;
				colvarItem.IsForeignKey = false;
				colvarItem.IsReadOnly = false;
				colvarItem.DefaultSetting = @"";
				colvarItem.ForeignKeyTableName = "";
				schema.Columns.Add(colvarItem);
				
				TableSchema.TableColumn colvarFinishTime = new TableSchema.TableColumn(schema);
				colvarFinishTime.ColumnName = "FinishTime";
				colvarFinishTime.DataType = DbType.String;
				colvarFinishTime.MaxLength = 50;
				colvarFinishTime.AutoIncrement = false;
				colvarFinishTime.IsNullable = true;
				colvarFinishTime.IsPrimaryKey = false;
				colvarFinishTime.IsForeignKey = false;
				colvarFinishTime.IsReadOnly = false;
				colvarFinishTime.DefaultSetting = @"";
				colvarFinishTime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFinishTime);
				
				TableSchema.TableColumn colvarRoles = new TableSchema.TableColumn(schema);
				colvarRoles.ColumnName = "Roles";
				colvarRoles.DataType = DbType.String;
				colvarRoles.MaxLength = 50;
				colvarRoles.AutoIncrement = false;
				colvarRoles.IsNullable = true;
				colvarRoles.IsPrimaryKey = false;
				colvarRoles.IsForeignKey = false;
				colvarRoles.IsReadOnly = false;
				colvarRoles.DefaultSetting = @"";
				colvarRoles.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRoles);
				
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
				
				TableSchema.TableColumn colvarMemo = new TableSchema.TableColumn(schema);
				colvarMemo.ColumnName = "Memo";
				colvarMemo.DataType = DbType.String;
				colvarMemo.MaxLength = -1;
				colvarMemo.AutoIncrement = false;
				colvarMemo.IsNullable = true;
				colvarMemo.IsPrimaryKey = false;
				colvarMemo.IsForeignKey = false;
				colvarMemo.IsReadOnly = false;
				colvarMemo.DefaultSetting = @"";
				colvarMemo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMemo);
				
				TableSchema.TableColumn colvarScore = new TableSchema.TableColumn(schema);
				colvarScore.ColumnName = "Score";
				colvarScore.DataType = DbType.String;
				colvarScore.MaxLength = 50;
				colvarScore.AutoIncrement = false;
				colvarScore.IsNullable = true;
				colvarScore.IsPrimaryKey = false;
				colvarScore.IsForeignKey = false;
				colvarScore.IsReadOnly = false;
				colvarScore.DefaultSetting = @"";
				colvarScore.ForeignKeyTableName = "";
				schema.Columns.Add(colvarScore);
				
				TableSchema.TableColumn colvarWeekScoreId = new TableSchema.TableColumn(schema);
				colvarWeekScoreId.ColumnName = "WeekScoreId";
				colvarWeekScoreId.DataType = DbType.Int32;
				colvarWeekScoreId.MaxLength = 0;
				colvarWeekScoreId.AutoIncrement = false;
				colvarWeekScoreId.IsNullable = true;
				colvarWeekScoreId.IsPrimaryKey = false;
				colvarWeekScoreId.IsForeignKey = false;
				colvarWeekScoreId.IsReadOnly = false;
				colvarWeekScoreId.DefaultSetting = @"";
				colvarWeekScoreId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarWeekScoreId);
				
				TableSchema.TableColumn colvarDayRoleId = new TableSchema.TableColumn(schema);
				colvarDayRoleId.ColumnName = "DayRoleId";
				colvarDayRoleId.DataType = DbType.Int32;
				colvarDayRoleId.MaxLength = 0;
				colvarDayRoleId.AutoIncrement = false;
				colvarDayRoleId.IsNullable = true;
				colvarDayRoleId.IsPrimaryKey = false;
				colvarDayRoleId.IsForeignKey = false;
				colvarDayRoleId.IsReadOnly = false;
				colvarDayRoleId.DefaultSetting = @"";
				colvarDayRoleId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDayRoleId);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("DayScore_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("DayScoreId")]
		[Bindable(true)]
		public int DayScoreId 
		{
			get { return GetColumnValue<int>(Columns.DayScoreId); }
			set { SetColumnValue(Columns.DayScoreId, value); }
		}
		  
		[XmlAttribute("Today")]
		[Bindable(true)]
		public string Today 
		{
			get { return GetColumnValue<string>(Columns.Today); }
			set { SetColumnValue(Columns.Today, value); }
		}
		  
		[XmlAttribute("Item")]
		[Bindable(true)]
		public string Item 
		{
			get { return GetColumnValue<string>(Columns.Item); }
			set { SetColumnValue(Columns.Item, value); }
		}
		  
		[XmlAttribute("FinishTime")]
		[Bindable(true)]
		public string FinishTime 
		{
			get { return GetColumnValue<string>(Columns.FinishTime); }
			set { SetColumnValue(Columns.FinishTime, value); }
		}
		  
		[XmlAttribute("Roles")]
		[Bindable(true)]
		public string Roles 
		{
			get { return GetColumnValue<string>(Columns.Roles); }
			set { SetColumnValue(Columns.Roles, value); }
		}
		  
		[XmlAttribute("TimeSpan")]
		[Bindable(true)]
		public string TimeSpan 
		{
			get { return GetColumnValue<string>(Columns.TimeSpan); }
			set { SetColumnValue(Columns.TimeSpan, value); }
		}
		  
		[XmlAttribute("Memo")]
		[Bindable(true)]
		public string Memo 
		{
			get { return GetColumnValue<string>(Columns.Memo); }
			set { SetColumnValue(Columns.Memo, value); }
		}
		  
		[XmlAttribute("Score")]
		[Bindable(true)]
		public string Score 
		{
			get { return GetColumnValue<string>(Columns.Score); }
			set { SetColumnValue(Columns.Score, value); }
		}
		  
		[XmlAttribute("WeekScoreId")]
		[Bindable(true)]
		public int? WeekScoreId 
		{
			get { return GetColumnValue<int?>(Columns.WeekScoreId); }
			set { SetColumnValue(Columns.WeekScoreId, value); }
		}
		  
		[XmlAttribute("DayRoleId")]
		[Bindable(true)]
		public int? DayRoleId 
		{
			get { return GetColumnValue<int?>(Columns.DayRoleId); }
			set { SetColumnValue(Columns.DayRoleId, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varToday,string varItem,string varFinishTime,string varRoles,string varTimeSpan,string varMemo,string varScore,int? varWeekScoreId,int? varDayRoleId)
		{
			DayScore item = new DayScore();
			
			item.Today = varToday;
			
			item.Item = varItem;
			
			item.FinishTime = varFinishTime;
			
			item.Roles = varRoles;
			
			item.TimeSpan = varTimeSpan;
			
			item.Memo = varMemo;
			
			item.Score = varScore;
			
			item.WeekScoreId = varWeekScoreId;
			
			item.DayRoleId = varDayRoleId;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varDayScoreId,string varToday,string varItem,string varFinishTime,string varRoles,string varTimeSpan,string varMemo,string varScore,int? varWeekScoreId,int? varDayRoleId)
		{
			DayScore item = new DayScore();
			
				item.DayScoreId = varDayScoreId;
			
				item.Today = varToday;
			
				item.Item = varItem;
			
				item.FinishTime = varFinishTime;
			
				item.Roles = varRoles;
			
				item.TimeSpan = varTimeSpan;
			
				item.Memo = varMemo;
			
				item.Score = varScore;
			
				item.WeekScoreId = varWeekScoreId;
			
				item.DayRoleId = varDayRoleId;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn DayScoreIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn TodayColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn ItemColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn FinishTimeColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn RolesColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn TimeSpanColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn MemoColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn ScoreColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn WeekScoreIdColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn DayRoleIdColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string DayScoreId = @"DayScoreId";
			 public static string Today = @"Today";
			 public static string Item = @"Item";
			 public static string FinishTime = @"FinishTime";
			 public static string Roles = @"Roles";
			 public static string TimeSpan = @"TimeSpan";
			 public static string Memo = @"Memo";
			 public static string Score = @"Score";
			 public static string WeekScoreId = @"WeekScoreId";
			 public static string DayRoleId = @"DayRoleId";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
