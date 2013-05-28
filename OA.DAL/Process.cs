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
	/// Strongly-typed collection for the Process class.
	/// </summary>
    [Serializable]
	public partial class ProcessCollection : ActiveList<Process, ProcessCollection>
	{	   
		public ProcessCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>ProcessCollection</returns>
		public ProcessCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                Process o = this[i];
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
	/// This is an ActiveRecord class which wraps the Process_tb table.
	/// </summary>
	[Serializable]
	public partial class Process : ActiveRecord<Process>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public Process()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public Process(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public Process(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public Process(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("Process_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarProcessId = new TableSchema.TableColumn(schema);
				colvarProcessId.ColumnName = "ProcessId";
				colvarProcessId.DataType = DbType.Int32;
				colvarProcessId.MaxLength = 0;
				colvarProcessId.AutoIncrement = true;
				colvarProcessId.IsNullable = false;
				colvarProcessId.IsPrimaryKey = true;
				colvarProcessId.IsForeignKey = false;
				colvarProcessId.IsReadOnly = false;
				colvarProcessId.DefaultSetting = @"";
				colvarProcessId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProcessId);
				
				TableSchema.TableColumn colvarProcessName = new TableSchema.TableColumn(schema);
				colvarProcessName.ColumnName = "ProcessName";
				colvarProcessName.DataType = DbType.String;
				colvarProcessName.MaxLength = 50;
				colvarProcessName.AutoIncrement = false;
				colvarProcessName.IsNullable = true;
				colvarProcessName.IsPrimaryKey = false;
				colvarProcessName.IsForeignKey = false;
				colvarProcessName.IsReadOnly = false;
				colvarProcessName.DefaultSetting = @"";
				colvarProcessName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProcessName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("Process_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("ProcessId")]
		[Bindable(true)]
		public int ProcessId 
		{
			get { return GetColumnValue<int>(Columns.ProcessId); }
			set { SetColumnValue(Columns.ProcessId, value); }
		}
		  
		[XmlAttribute("ProcessName")]
		[Bindable(true)]
		public string ProcessName 
		{
			get { return GetColumnValue<string>(Columns.ProcessName); }
			set { SetColumnValue(Columns.ProcessName, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varProcessName)
		{
			Process item = new Process();
			
			item.ProcessName = varProcessName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varProcessId,string varProcessName)
		{
			Process item = new Process();
			
				item.ProcessId = varProcessId;
			
				item.ProcessName = varProcessName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn ProcessIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ProcessNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string ProcessId = @"ProcessId";
			 public static string ProcessName = @"ProcessName";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
