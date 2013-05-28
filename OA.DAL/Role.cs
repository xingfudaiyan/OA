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
	/// Strongly-typed collection for the Role class.
	/// </summary>
    [Serializable]
	public partial class RoleCollection : ActiveList<Role, RoleCollection>
	{	   
		public RoleCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>RoleCollection</returns>
		public RoleCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                Role o = this[i];
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
	/// This is an ActiveRecord class which wraps the Role_tb table.
	/// </summary>
	[Serializable]
	public partial class Role : ActiveRecord<Role>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public Role()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public Role(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public Role(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public Role(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("Role_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarRoleId = new TableSchema.TableColumn(schema);
				colvarRoleId.ColumnName = "RoleId";
				colvarRoleId.DataType = DbType.Int32;
				colvarRoleId.MaxLength = 0;
				colvarRoleId.AutoIncrement = true;
				colvarRoleId.IsNullable = false;
				colvarRoleId.IsPrimaryKey = true;
				colvarRoleId.IsForeignKey = false;
				colvarRoleId.IsReadOnly = false;
				colvarRoleId.DefaultSetting = @"";
				colvarRoleId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRoleId);
				
				TableSchema.TableColumn colvarRoleName = new TableSchema.TableColumn(schema);
				colvarRoleName.ColumnName = "RoleName";
				colvarRoleName.DataType = DbType.String;
				colvarRoleName.MaxLength = 50;
				colvarRoleName.AutoIncrement = false;
				colvarRoleName.IsNullable = true;
				colvarRoleName.IsPrimaryKey = false;
				colvarRoleName.IsForeignKey = false;
				colvarRoleName.IsReadOnly = false;
				colvarRoleName.DefaultSetting = @"";
				colvarRoleName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRoleName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("Role_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("RoleId")]
		[Bindable(true)]
		public int RoleId 
		{
			get { return GetColumnValue<int>(Columns.RoleId); }
			set { SetColumnValue(Columns.RoleId, value); }
		}
		  
		[XmlAttribute("RoleName")]
		[Bindable(true)]
		public string RoleName 
		{
			get { return GetColumnValue<string>(Columns.RoleName); }
			set { SetColumnValue(Columns.RoleName, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varRoleName)
		{
			Role item = new Role();
			
			item.RoleName = varRoleName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varRoleId,string varRoleName)
		{
			Role item = new Role();
			
				item.RoleId = varRoleId;
			
				item.RoleName = varRoleName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn RoleIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn RoleNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string RoleId = @"RoleId";
			 public static string RoleName = @"RoleName";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
