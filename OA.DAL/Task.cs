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
	/// Strongly-typed collection for the Task class.
	/// </summary>
    [Serializable]
	public partial class TaskCollection : ActiveList<Task, TaskCollection>
	{	   
		public TaskCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TaskCollection</returns>
		public TaskCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                Task o = this[i];
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
	/// This is an ActiveRecord class which wraps the Task_tb table.
	/// </summary>
	[Serializable]
	public partial class Task : ActiveRecord<Task>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public Task()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public Task(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public Task(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public Task(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("Task_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarTaskId = new TableSchema.TableColumn(schema);
				colvarTaskId.ColumnName = "TaskId";
				colvarTaskId.DataType = DbType.Int32;
				colvarTaskId.MaxLength = 0;
				colvarTaskId.AutoIncrement = true;
				colvarTaskId.IsNullable = false;
				colvarTaskId.IsPrimaryKey = true;
				colvarTaskId.IsForeignKey = false;
				colvarTaskId.IsReadOnly = false;
				colvarTaskId.DefaultSetting = @"";
				colvarTaskId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTaskId);
				
				TableSchema.TableColumn colvarTaskName = new TableSchema.TableColumn(schema);
				colvarTaskName.ColumnName = "TaskName";
				colvarTaskName.DataType = DbType.String;
				colvarTaskName.MaxLength = 50;
				colvarTaskName.AutoIncrement = false;
				colvarTaskName.IsNullable = true;
				colvarTaskName.IsPrimaryKey = false;
				colvarTaskName.IsForeignKey = false;
				colvarTaskName.IsReadOnly = false;
				colvarTaskName.DefaultSetting = @"";
				colvarTaskName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTaskName);
				
				TableSchema.TableColumn colvarEmployeeId = new TableSchema.TableColumn(schema);
				colvarEmployeeId.ColumnName = "EmployeeId";
				colvarEmployeeId.DataType = DbType.Int32;
				colvarEmployeeId.MaxLength = 0;
				colvarEmployeeId.AutoIncrement = false;
				colvarEmployeeId.IsNullable = true;
				colvarEmployeeId.IsPrimaryKey = false;
				colvarEmployeeId.IsForeignKey = false;
				colvarEmployeeId.IsReadOnly = false;
				colvarEmployeeId.DefaultSetting = @"";
				colvarEmployeeId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEmployeeId);
				
				TableSchema.TableColumn colvarWorkSheetId = new TableSchema.TableColumn(schema);
				colvarWorkSheetId.ColumnName = "WorkSheetId";
				colvarWorkSheetId.DataType = DbType.Int32;
				colvarWorkSheetId.MaxLength = 0;
				colvarWorkSheetId.AutoIncrement = false;
				colvarWorkSheetId.IsNullable = true;
				colvarWorkSheetId.IsPrimaryKey = false;
				colvarWorkSheetId.IsForeignKey = false;
				colvarWorkSheetId.IsReadOnly = false;
				colvarWorkSheetId.DefaultSetting = @"";
				colvarWorkSheetId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarWorkSheetId);
				
				TableSchema.TableColumn colvarRecvTime = new TableSchema.TableColumn(schema);
				colvarRecvTime.ColumnName = "RecvTime";
				colvarRecvTime.DataType = DbType.DateTime;
				colvarRecvTime.MaxLength = 0;
				colvarRecvTime.AutoIncrement = false;
				colvarRecvTime.IsNullable = true;
				colvarRecvTime.IsPrimaryKey = false;
				colvarRecvTime.IsForeignKey = false;
				colvarRecvTime.IsReadOnly = false;
				colvarRecvTime.DefaultSetting = @"";
				colvarRecvTime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRecvTime);
				
				TableSchema.TableColumn colvarIsFinish = new TableSchema.TableColumn(schema);
				colvarIsFinish.ColumnName = "IsFinish";
				colvarIsFinish.DataType = DbType.Int32;
				colvarIsFinish.MaxLength = 0;
				colvarIsFinish.AutoIncrement = false;
				colvarIsFinish.IsNullable = true;
				colvarIsFinish.IsPrimaryKey = false;
				colvarIsFinish.IsForeignKey = false;
				colvarIsFinish.IsReadOnly = false;
				colvarIsFinish.DefaultSetting = @"";
				colvarIsFinish.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIsFinish);
				
				TableSchema.TableColumn colvarFinishTime = new TableSchema.TableColumn(schema);
				colvarFinishTime.ColumnName = "FinishTime";
				colvarFinishTime.DataType = DbType.DateTime;
				colvarFinishTime.MaxLength = 0;
				colvarFinishTime.AutoIncrement = false;
				colvarFinishTime.IsNullable = true;
				colvarFinishTime.IsPrimaryKey = false;
				colvarFinishTime.IsForeignKey = false;
				colvarFinishTime.IsReadOnly = false;
				colvarFinishTime.DefaultSetting = @"";
				colvarFinishTime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFinishTime);
				
				TableSchema.TableColumn colvarBeginTime = new TableSchema.TableColumn(schema);
				colvarBeginTime.ColumnName = "BeginTime";
				colvarBeginTime.DataType = DbType.DateTime;
				colvarBeginTime.MaxLength = 0;
				colvarBeginTime.AutoIncrement = false;
				colvarBeginTime.IsNullable = true;
				colvarBeginTime.IsPrimaryKey = false;
				colvarBeginTime.IsForeignKey = false;
				colvarBeginTime.IsReadOnly = false;
				colvarBeginTime.DefaultSetting = @"";
				colvarBeginTime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBeginTime);
				
				TableSchema.TableColumn colvarIsMain = new TableSchema.TableColumn(schema);
				colvarIsMain.ColumnName = "IsMain";
				colvarIsMain.DataType = DbType.Int32;
				colvarIsMain.MaxLength = 0;
				colvarIsMain.AutoIncrement = false;
				colvarIsMain.IsNullable = true;
				colvarIsMain.IsPrimaryKey = false;
				colvarIsMain.IsForeignKey = false;
				colvarIsMain.IsReadOnly = false;
				colvarIsMain.DefaultSetting = @"";
				colvarIsMain.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIsMain);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("Task_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("TaskId")]
		[Bindable(true)]
		public int TaskId 
		{
			get { return GetColumnValue<int>(Columns.TaskId); }
			set { SetColumnValue(Columns.TaskId, value); }
		}
		  
		[XmlAttribute("TaskName")]
		[Bindable(true)]
		public string TaskName 
		{
			get { return GetColumnValue<string>(Columns.TaskName); }
			set { SetColumnValue(Columns.TaskName, value); }
		}
		  
		[XmlAttribute("EmployeeId")]
		[Bindable(true)]
		public int? EmployeeId 
		{
			get { return GetColumnValue<int?>(Columns.EmployeeId); }
			set { SetColumnValue(Columns.EmployeeId, value); }
		}
		  
		[XmlAttribute("WorkSheetId")]
		[Bindable(true)]
		public int? WorkSheetId 
		{
			get { return GetColumnValue<int?>(Columns.WorkSheetId); }
			set { SetColumnValue(Columns.WorkSheetId, value); }
		}
		  
		[XmlAttribute("RecvTime")]
		[Bindable(true)]
		public DateTime? RecvTime 
		{
			get { return GetColumnValue<DateTime?>(Columns.RecvTime); }
			set { SetColumnValue(Columns.RecvTime, value); }
		}
		  
		[XmlAttribute("IsFinish")]
		[Bindable(true)]
		public int? IsFinish 
		{
			get { return GetColumnValue<int?>(Columns.IsFinish); }
			set { SetColumnValue(Columns.IsFinish, value); }
		}
		  
		[XmlAttribute("FinishTime")]
		[Bindable(true)]
		public DateTime? FinishTime 
		{
			get { return GetColumnValue<DateTime?>(Columns.FinishTime); }
			set { SetColumnValue(Columns.FinishTime, value); }
		}
		  
		[XmlAttribute("BeginTime")]
		[Bindable(true)]
		public DateTime? BeginTime 
		{
			get { return GetColumnValue<DateTime?>(Columns.BeginTime); }
			set { SetColumnValue(Columns.BeginTime, value); }
		}
		  
		[XmlAttribute("IsMain")]
		[Bindable(true)]
		public int? IsMain 
		{
			get { return GetColumnValue<int?>(Columns.IsMain); }
			set { SetColumnValue(Columns.IsMain, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varTaskName,int? varEmployeeId,int? varWorkSheetId,DateTime? varRecvTime,int? varIsFinish,DateTime? varFinishTime,DateTime? varBeginTime,int? varIsMain)
		{
			Task item = new Task();
			
			item.TaskName = varTaskName;
			
			item.EmployeeId = varEmployeeId;
			
			item.WorkSheetId = varWorkSheetId;
			
			item.RecvTime = varRecvTime;
			
			item.IsFinish = varIsFinish;
			
			item.FinishTime = varFinishTime;
			
			item.BeginTime = varBeginTime;
			
			item.IsMain = varIsMain;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varTaskId,string varTaskName,int? varEmployeeId,int? varWorkSheetId,DateTime? varRecvTime,int? varIsFinish,DateTime? varFinishTime,DateTime? varBeginTime,int? varIsMain)
		{
			Task item = new Task();
			
				item.TaskId = varTaskId;
			
				item.TaskName = varTaskName;
			
				item.EmployeeId = varEmployeeId;
			
				item.WorkSheetId = varWorkSheetId;
			
				item.RecvTime = varRecvTime;
			
				item.IsFinish = varIsFinish;
			
				item.FinishTime = varFinishTime;
			
				item.BeginTime = varBeginTime;
			
				item.IsMain = varIsMain;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn TaskIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn TaskNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn EmployeeIdColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn WorkSheetIdColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn RecvTimeColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn IsFinishColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn FinishTimeColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn BeginTimeColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn IsMainColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string TaskId = @"TaskId";
			 public static string TaskName = @"TaskName";
			 public static string EmployeeId = @"EmployeeId";
			 public static string WorkSheetId = @"WorkSheetId";
			 public static string RecvTime = @"RecvTime";
			 public static string IsFinish = @"IsFinish";
			 public static string FinishTime = @"FinishTime";
			 public static string BeginTime = @"BeginTime";
			 public static string IsMain = @"IsMain";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
