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
	/// Strongly-typed collection for the Master class.
	/// </summary>
    [Serializable]
	public partial class MasterCollection : ActiveList<Master, MasterCollection>
	{	   
		public MasterCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>MasterCollection</returns>
		public MasterCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                Master o = this[i];
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
	/// This is an ActiveRecord class which wraps the Master_tb table.
	/// </summary>
	[Serializable]
	public partial class Master : ActiveRecord<Master>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public Master()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public Master(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public Master(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public Master(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("Master_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarMasterId = new TableSchema.TableColumn(schema);
				colvarMasterId.ColumnName = "MasterId";
				colvarMasterId.DataType = DbType.Int32;
				colvarMasterId.MaxLength = 0;
				colvarMasterId.AutoIncrement = true;
				colvarMasterId.IsNullable = false;
				colvarMasterId.IsPrimaryKey = true;
				colvarMasterId.IsForeignKey = false;
				colvarMasterId.IsReadOnly = false;
				colvarMasterId.DefaultSetting = @"";
				colvarMasterId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMasterId);
				
				TableSchema.TableColumn colvarMasterName = new TableSchema.TableColumn(schema);
				colvarMasterName.ColumnName = "MasterName";
				colvarMasterName.DataType = DbType.String;
				colvarMasterName.MaxLength = 50;
				colvarMasterName.AutoIncrement = false;
				colvarMasterName.IsNullable = false;
				colvarMasterName.IsPrimaryKey = false;
				colvarMasterName.IsForeignKey = false;
				colvarMasterName.IsReadOnly = false;
				colvarMasterName.DefaultSetting = @"";
				colvarMasterName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMasterName);
				
				TableSchema.TableColumn colvarMasterPsd = new TableSchema.TableColumn(schema);
				colvarMasterPsd.ColumnName = "MasterPsd";
				colvarMasterPsd.DataType = DbType.String;
				colvarMasterPsd.MaxLength = 50;
				colvarMasterPsd.AutoIncrement = false;
				colvarMasterPsd.IsNullable = false;
				colvarMasterPsd.IsPrimaryKey = false;
				colvarMasterPsd.IsForeignKey = false;
				colvarMasterPsd.IsReadOnly = false;
				colvarMasterPsd.DefaultSetting = @"";
				colvarMasterPsd.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMasterPsd);
				
				TableSchema.TableColumn colvarDepartId = new TableSchema.TableColumn(schema);
				colvarDepartId.ColumnName = "DepartId";
				colvarDepartId.DataType = DbType.Int32;
				colvarDepartId.MaxLength = 0;
				colvarDepartId.AutoIncrement = false;
				colvarDepartId.IsNullable = false;
				colvarDepartId.IsPrimaryKey = false;
				colvarDepartId.IsForeignKey = false;
				colvarDepartId.IsReadOnly = false;
				colvarDepartId.DefaultSetting = @"";
				colvarDepartId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDepartId);
				
				TableSchema.TableColumn colvarCreateDate = new TableSchema.TableColumn(schema);
				colvarCreateDate.ColumnName = "CreateDate";
				colvarCreateDate.DataType = DbType.DateTime;
				colvarCreateDate.MaxLength = 0;
				colvarCreateDate.AutoIncrement = false;
				colvarCreateDate.IsNullable = true;
				colvarCreateDate.IsPrimaryKey = false;
				colvarCreateDate.IsForeignKey = false;
				colvarCreateDate.IsReadOnly = false;
				colvarCreateDate.DefaultSetting = @"";
				colvarCreateDate.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCreateDate);
				
				TableSchema.TableColumn colvarEmployeeId = new TableSchema.TableColumn(schema);
				colvarEmployeeId.ColumnName = "EmployeeId";
				colvarEmployeeId.DataType = DbType.Int32;
				colvarEmployeeId.MaxLength = 0;
				colvarEmployeeId.AutoIncrement = false;
				colvarEmployeeId.IsNullable = false;
				colvarEmployeeId.IsPrimaryKey = false;
				colvarEmployeeId.IsForeignKey = true;
				colvarEmployeeId.IsReadOnly = false;
				colvarEmployeeId.DefaultSetting = @"";
				
					colvarEmployeeId.ForeignKeyTableName = "Employee_tb";
				schema.Columns.Add(colvarEmployeeId);
				
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
				DataService.Providers["SubsonicProvider"].AddSchema("Master_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("MasterId")]
		[Bindable(true)]
		public int MasterId 
		{
			get { return GetColumnValue<int>(Columns.MasterId); }
			set { SetColumnValue(Columns.MasterId, value); }
		}
		  
		[XmlAttribute("MasterName")]
		[Bindable(true)]
		public string MasterName 
		{
			get { return GetColumnValue<string>(Columns.MasterName); }
			set { SetColumnValue(Columns.MasterName, value); }
		}
		  
		[XmlAttribute("MasterPsd")]
		[Bindable(true)]
		public string MasterPsd 
		{
			get { return GetColumnValue<string>(Columns.MasterPsd); }
			set { SetColumnValue(Columns.MasterPsd, value); }
		}
		  
		[XmlAttribute("DepartId")]
		[Bindable(true)]
		public int DepartId 
		{
			get { return GetColumnValue<int>(Columns.DepartId); }
			set { SetColumnValue(Columns.DepartId, value); }
		}
		  
		[XmlAttribute("CreateDate")]
		[Bindable(true)]
		public DateTime? CreateDate 
		{
			get { return GetColumnValue<DateTime?>(Columns.CreateDate); }
			set { SetColumnValue(Columns.CreateDate, value); }
		}
		  
		[XmlAttribute("EmployeeId")]
		[Bindable(true)]
		public int EmployeeId 
		{
			get { return GetColumnValue<int>(Columns.EmployeeId); }
			set { SetColumnValue(Columns.EmployeeId, value); }
		}
		  
		[XmlAttribute("IsApply")]
		[Bindable(true)]
		public int? IsApply 
		{
			get { return GetColumnValue<int?>(Columns.IsApply); }
			set { SetColumnValue(Columns.IsApply, value); }
		}
		  
		[XmlAttribute("State")]
		[Bindable(true)]
		public int? State 
		{
			get { return GetColumnValue<int?>(Columns.State); }
			set { SetColumnValue(Columns.State, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		public CanYou.OA.DAL.ActionMasterCollection ActionMasterRecords()
		{
			return new CanYou.OA.DAL.ActionMasterCollection().Where(ActionMaster.Columns.MasterId, MasterId).Load();
		}
		#endregion
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a Employee ActiveRecord object related to this Master
		/// 
		/// </summary>
		public CanYou.OA.DAL.Employee Employee
		{
			get { return CanYou.OA.DAL.Employee.FetchByID(this.EmployeeId); }
			set { SetColumnValue("EmployeeId", value.EmployeeId); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varMasterName,string varMasterPsd,int varDepartId,DateTime? varCreateDate,int varEmployeeId,int? varIsApply,int? varState)
		{
			Master item = new Master();
			
			item.MasterName = varMasterName;
			
			item.MasterPsd = varMasterPsd;
			
			item.DepartId = varDepartId;
			
			item.CreateDate = varCreateDate;
			
			item.EmployeeId = varEmployeeId;
			
			item.IsApply = varIsApply;
			
			item.State = varState;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varMasterId,string varMasterName,string varMasterPsd,int varDepartId,DateTime? varCreateDate,int varEmployeeId,int? varIsApply,int? varState)
		{
			Master item = new Master();
			
				item.MasterId = varMasterId;
			
				item.MasterName = varMasterName;
			
				item.MasterPsd = varMasterPsd;
			
				item.DepartId = varDepartId;
			
				item.CreateDate = varCreateDate;
			
				item.EmployeeId = varEmployeeId;
			
				item.IsApply = varIsApply;
			
				item.State = varState;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn MasterIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn MasterNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn MasterPsdColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn DepartIdColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn CreateDateColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn EmployeeIdColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn IsApplyColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn StateColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string MasterId = @"MasterId";
			 public static string MasterName = @"MasterName";
			 public static string MasterPsd = @"MasterPsd";
			 public static string DepartId = @"DepartId";
			 public static string CreateDate = @"CreateDate";
			 public static string EmployeeId = @"EmployeeId";
			 public static string IsApply = @"IsApply";
			 public static string State = @"State";
						
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
