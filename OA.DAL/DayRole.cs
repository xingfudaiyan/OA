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
	/// Strongly-typed collection for the DayRole class.
	/// </summary>
    [Serializable]
	public partial class DayRoleCollection : ActiveList<DayRole, DayRoleCollection>
	{	   
		public DayRoleCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>DayRoleCollection</returns>
		public DayRoleCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                DayRole o = this[i];
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
	/// This is an ActiveRecord class which wraps the DayRole_tb table.
	/// </summary>
	[Serializable]
	public partial class DayRole : ActiveRecord<DayRole>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public DayRole()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public DayRole(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public DayRole(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public DayRole(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("DayRole_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarDayRoleId = new TableSchema.TableColumn(schema);
				colvarDayRoleId.ColumnName = "DayRoleId";
				colvarDayRoleId.DataType = DbType.Int32;
				colvarDayRoleId.MaxLength = 0;
				colvarDayRoleId.AutoIncrement = true;
				colvarDayRoleId.IsNullable = false;
				colvarDayRoleId.IsPrimaryKey = true;
				colvarDayRoleId.IsForeignKey = false;
				colvarDayRoleId.IsReadOnly = false;
				colvarDayRoleId.DefaultSetting = @"";
				colvarDayRoleId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDayRoleId);
				
				TableSchema.TableColumn colvarDayRoleName = new TableSchema.TableColumn(schema);
				colvarDayRoleName.ColumnName = "DayRoleName";
				colvarDayRoleName.DataType = DbType.String;
				colvarDayRoleName.MaxLength = 50;
				colvarDayRoleName.AutoIncrement = false;
				colvarDayRoleName.IsNullable = true;
				colvarDayRoleName.IsPrimaryKey = false;
				colvarDayRoleName.IsForeignKey = false;
				colvarDayRoleName.IsReadOnly = false;
				colvarDayRoleName.DefaultSetting = @"";
				colvarDayRoleName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDayRoleName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("DayRole_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("DayRoleId")]
		[Bindable(true)]
		public int DayRoleId 
		{
			get { return GetColumnValue<int>(Columns.DayRoleId); }
			set { SetColumnValue(Columns.DayRoleId, value); }
		}
		  
		[XmlAttribute("DayRoleName")]
		[Bindable(true)]
		public string DayRoleName 
		{
			get { return GetColumnValue<string>(Columns.DayRoleName); }
			set { SetColumnValue(Columns.DayRoleName, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varDayRoleName)
		{
			DayRole item = new DayRole();
			
			item.DayRoleName = varDayRoleName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varDayRoleId,string varDayRoleName)
		{
			DayRole item = new DayRole();
			
				item.DayRoleId = varDayRoleId;
			
				item.DayRoleName = varDayRoleName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn DayRoleIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn DayRoleNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string DayRoleId = @"DayRoleId";
			 public static string DayRoleName = @"DayRoleName";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
