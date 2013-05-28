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
	/// Strongly-typed collection for the RoleMaster class.
	/// </summary>
    [Serializable]
	public partial class RoleMasterCollection : ActiveList<RoleMaster, RoleMasterCollection>
	{	   
		public RoleMasterCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>RoleMasterCollection</returns>
		public RoleMasterCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                RoleMaster o = this[i];
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
	/// This is an ActiveRecord class which wraps the RoleMaster_tb table.
	/// </summary>
	[Serializable]
	public partial class RoleMaster : ActiveRecord<RoleMaster>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public RoleMaster()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public RoleMaster(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public RoleMaster(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public RoleMaster(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("RoleMaster_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarRoleMasterId = new TableSchema.TableColumn(schema);
				colvarRoleMasterId.ColumnName = "RoleMasterId";
				colvarRoleMasterId.DataType = DbType.Int32;
				colvarRoleMasterId.MaxLength = 0;
				colvarRoleMasterId.AutoIncrement = true;
				colvarRoleMasterId.IsNullable = false;
				colvarRoleMasterId.IsPrimaryKey = true;
				colvarRoleMasterId.IsForeignKey = false;
				colvarRoleMasterId.IsReadOnly = false;
				colvarRoleMasterId.DefaultSetting = @"";
				colvarRoleMasterId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRoleMasterId);
				
				TableSchema.TableColumn colvarRoleId = new TableSchema.TableColumn(schema);
				colvarRoleId.ColumnName = "RoleId";
				colvarRoleId.DataType = DbType.Int32;
				colvarRoleId.MaxLength = 0;
				colvarRoleId.AutoIncrement = false;
				colvarRoleId.IsNullable = false;
				colvarRoleId.IsPrimaryKey = false;
				colvarRoleId.IsForeignKey = false;
				colvarRoleId.IsReadOnly = false;
				colvarRoleId.DefaultSetting = @"";
				colvarRoleId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRoleId);
				
				TableSchema.TableColumn colvarMasterId = new TableSchema.TableColumn(schema);
				colvarMasterId.ColumnName = "MasterId";
				colvarMasterId.DataType = DbType.Int32;
				colvarMasterId.MaxLength = 0;
				colvarMasterId.AutoIncrement = false;
				colvarMasterId.IsNullable = false;
				colvarMasterId.IsPrimaryKey = false;
				colvarMasterId.IsForeignKey = false;
				colvarMasterId.IsReadOnly = false;
				colvarMasterId.DefaultSetting = @"";
				colvarMasterId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMasterId);
				
				TableSchema.TableColumn colvarIsPass = new TableSchema.TableColumn(schema);
				colvarIsPass.ColumnName = "IsPass";
				colvarIsPass.DataType = DbType.Int32;
				colvarIsPass.MaxLength = 0;
				colvarIsPass.AutoIncrement = false;
				colvarIsPass.IsNullable = true;
				colvarIsPass.IsPrimaryKey = false;
				colvarIsPass.IsForeignKey = false;
				colvarIsPass.IsReadOnly = false;
				colvarIsPass.DefaultSetting = @"";
				colvarIsPass.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIsPass);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("RoleMaster_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("RoleMasterId")]
		[Bindable(true)]
		public int RoleMasterId 
		{
			get { return GetColumnValue<int>(Columns.RoleMasterId); }
			set { SetColumnValue(Columns.RoleMasterId, value); }
		}
		  
		[XmlAttribute("RoleId")]
		[Bindable(true)]
		public int RoleId 
		{
			get { return GetColumnValue<int>(Columns.RoleId); }
			set { SetColumnValue(Columns.RoleId, value); }
		}
		  
		[XmlAttribute("MasterId")]
		[Bindable(true)]
		public int MasterId 
		{
			get { return GetColumnValue<int>(Columns.MasterId); }
			set { SetColumnValue(Columns.MasterId, value); }
		}
		  
		[XmlAttribute("IsPass")]
		[Bindable(true)]
		public int? IsPass 
		{
			get { return GetColumnValue<int?>(Columns.IsPass); }
			set { SetColumnValue(Columns.IsPass, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varRoleId,int varMasterId,int? varIsPass)
		{
			RoleMaster item = new RoleMaster();
			
			item.RoleId = varRoleId;
			
			item.MasterId = varMasterId;
			
			item.IsPass = varIsPass;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varRoleMasterId,int varRoleId,int varMasterId,int? varIsPass)
		{
			RoleMaster item = new RoleMaster();
			
				item.RoleMasterId = varRoleMasterId;
			
				item.RoleId = varRoleId;
			
				item.MasterId = varMasterId;
			
				item.IsPass = varIsPass;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn RoleMasterIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn RoleIdColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn MasterIdColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn IsPassColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string RoleMasterId = @"RoleMasterId";
			 public static string RoleId = @"RoleId";
			 public static string MasterId = @"MasterId";
			 public static string IsPass = @"IsPass";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
