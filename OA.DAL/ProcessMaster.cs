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
	/// Strongly-typed collection for the ProcessMaster class.
	/// </summary>
    [Serializable]
	public partial class ProcessMasterCollection : ActiveList<ProcessMaster, ProcessMasterCollection>
	{	   
		public ProcessMasterCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>ProcessMasterCollection</returns>
		public ProcessMasterCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                ProcessMaster o = this[i];
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
	/// This is an ActiveRecord class which wraps the ProcessMaster_tb table.
	/// </summary>
	[Serializable]
	public partial class ProcessMaster : ActiveRecord<ProcessMaster>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public ProcessMaster()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public ProcessMaster(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public ProcessMaster(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public ProcessMaster(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("ProcessMaster_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarProcessMasterId = new TableSchema.TableColumn(schema);
				colvarProcessMasterId.ColumnName = "ProcessMasterId";
				colvarProcessMasterId.DataType = DbType.Int32;
				colvarProcessMasterId.MaxLength = 0;
				colvarProcessMasterId.AutoIncrement = true;
				colvarProcessMasterId.IsNullable = false;
				colvarProcessMasterId.IsPrimaryKey = true;
				colvarProcessMasterId.IsForeignKey = false;
				colvarProcessMasterId.IsReadOnly = false;
				colvarProcessMasterId.DefaultSetting = @"";
				colvarProcessMasterId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProcessMasterId);
				
				TableSchema.TableColumn colvarApplyMasterId = new TableSchema.TableColumn(schema);
				colvarApplyMasterId.ColumnName = "ApplyMasterId";
				colvarApplyMasterId.DataType = DbType.Int32;
				colvarApplyMasterId.MaxLength = 0;
				colvarApplyMasterId.AutoIncrement = false;
				colvarApplyMasterId.IsNullable = true;
				colvarApplyMasterId.IsPrimaryKey = false;
				colvarApplyMasterId.IsForeignKey = false;
				colvarApplyMasterId.IsReadOnly = false;
				colvarApplyMasterId.DefaultSetting = @"";
				colvarApplyMasterId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarApplyMasterId);
				
				TableSchema.TableColumn colvarFirstApproveMasterId = new TableSchema.TableColumn(schema);
				colvarFirstApproveMasterId.ColumnName = "FirstApproveMasterId";
				colvarFirstApproveMasterId.DataType = DbType.Int32;
				colvarFirstApproveMasterId.MaxLength = 0;
				colvarFirstApproveMasterId.AutoIncrement = false;
				colvarFirstApproveMasterId.IsNullable = true;
				colvarFirstApproveMasterId.IsPrimaryKey = false;
				colvarFirstApproveMasterId.IsForeignKey = false;
				colvarFirstApproveMasterId.IsReadOnly = false;
				colvarFirstApproveMasterId.DefaultSetting = @"";
				colvarFirstApproveMasterId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFirstApproveMasterId);
				
				TableSchema.TableColumn colvarSecondApproveMasterId = new TableSchema.TableColumn(schema);
				colvarSecondApproveMasterId.ColumnName = "SecondApproveMasterId";
				colvarSecondApproveMasterId.DataType = DbType.Int32;
				colvarSecondApproveMasterId.MaxLength = 0;
				colvarSecondApproveMasterId.AutoIncrement = false;
				colvarSecondApproveMasterId.IsNullable = true;
				colvarSecondApproveMasterId.IsPrimaryKey = false;
				colvarSecondApproveMasterId.IsForeignKey = false;
				colvarSecondApproveMasterId.IsReadOnly = false;
				colvarSecondApproveMasterId.DefaultSetting = @"";
				colvarSecondApproveMasterId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecondApproveMasterId);
				
				TableSchema.TableColumn colvarThirdApproveMasterId = new TableSchema.TableColumn(schema);
				colvarThirdApproveMasterId.ColumnName = "ThirdApproveMasterId";
				colvarThirdApproveMasterId.DataType = DbType.Int32;
				colvarThirdApproveMasterId.MaxLength = 0;
				colvarThirdApproveMasterId.AutoIncrement = false;
				colvarThirdApproveMasterId.IsNullable = true;
				colvarThirdApproveMasterId.IsPrimaryKey = false;
				colvarThirdApproveMasterId.IsForeignKey = false;
				colvarThirdApproveMasterId.IsReadOnly = false;
				colvarThirdApproveMasterId.DefaultSetting = @"";
				colvarThirdApproveMasterId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarThirdApproveMasterId);
				
				TableSchema.TableColumn colvarProId = new TableSchema.TableColumn(schema);
				colvarProId.ColumnName = "ProId";
				colvarProId.DataType = DbType.Int32;
				colvarProId.MaxLength = 0;
				colvarProId.AutoIncrement = false;
				colvarProId.IsNullable = true;
				colvarProId.IsPrimaryKey = false;
				colvarProId.IsForeignKey = false;
				colvarProId.IsReadOnly = false;
				colvarProId.DefaultSetting = @"";
				colvarProId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProId);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("ProcessMaster_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("ProcessMasterId")]
		[Bindable(true)]
		public int ProcessMasterId 
		{
			get { return GetColumnValue<int>(Columns.ProcessMasterId); }
			set { SetColumnValue(Columns.ProcessMasterId, value); }
		}
		  
		[XmlAttribute("ApplyMasterId")]
		[Bindable(true)]
		public int? ApplyMasterId 
		{
			get { return GetColumnValue<int?>(Columns.ApplyMasterId); }
			set { SetColumnValue(Columns.ApplyMasterId, value); }
		}
		  
		[XmlAttribute("FirstApproveMasterId")]
		[Bindable(true)]
		public int? FirstApproveMasterId 
		{
			get { return GetColumnValue<int?>(Columns.FirstApproveMasterId); }
			set { SetColumnValue(Columns.FirstApproveMasterId, value); }
		}
		  
		[XmlAttribute("SecondApproveMasterId")]
		[Bindable(true)]
		public int? SecondApproveMasterId 
		{
			get { return GetColumnValue<int?>(Columns.SecondApproveMasterId); }
			set { SetColumnValue(Columns.SecondApproveMasterId, value); }
		}
		  
		[XmlAttribute("ThirdApproveMasterId")]
		[Bindable(true)]
		public int? ThirdApproveMasterId 
		{
			get { return GetColumnValue<int?>(Columns.ThirdApproveMasterId); }
			set { SetColumnValue(Columns.ThirdApproveMasterId, value); }
		}
		  
		[XmlAttribute("ProId")]
		[Bindable(true)]
		public int? ProId 
		{
			get { return GetColumnValue<int?>(Columns.ProId); }
			set { SetColumnValue(Columns.ProId, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int? varApplyMasterId,int? varFirstApproveMasterId,int? varSecondApproveMasterId,int? varThirdApproveMasterId,int? varProId)
		{
			ProcessMaster item = new ProcessMaster();
			
			item.ApplyMasterId = varApplyMasterId;
			
			item.FirstApproveMasterId = varFirstApproveMasterId;
			
			item.SecondApproveMasterId = varSecondApproveMasterId;
			
			item.ThirdApproveMasterId = varThirdApproveMasterId;
			
			item.ProId = varProId;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varProcessMasterId,int? varApplyMasterId,int? varFirstApproveMasterId,int? varSecondApproveMasterId,int? varThirdApproveMasterId,int? varProId)
		{
			ProcessMaster item = new ProcessMaster();
			
				item.ProcessMasterId = varProcessMasterId;
			
				item.ApplyMasterId = varApplyMasterId;
			
				item.FirstApproveMasterId = varFirstApproveMasterId;
			
				item.SecondApproveMasterId = varSecondApproveMasterId;
			
				item.ThirdApproveMasterId = varThirdApproveMasterId;
			
				item.ProId = varProId;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn ProcessMasterIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ApplyMasterIdColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn FirstApproveMasterIdColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn SecondApproveMasterIdColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn ThirdApproveMasterIdColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn ProIdColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string ProcessMasterId = @"ProcessMasterId";
			 public static string ApplyMasterId = @"ApplyMasterId";
			 public static string FirstApproveMasterId = @"FirstApproveMasterId";
			 public static string SecondApproveMasterId = @"SecondApproveMasterId";
			 public static string ThirdApproveMasterId = @"ThirdApproveMasterId";
			 public static string ProId = @"ProId";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
