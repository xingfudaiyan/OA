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
	/// Strongly-typed collection for the OpProRole class.
	/// </summary>
    [Serializable]
	public partial class OpProRoleCollection : ActiveList<OpProRole, OpProRoleCollection>
	{	   
		public OpProRoleCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>OpProRoleCollection</returns>
		public OpProRoleCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                OpProRole o = this[i];
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
	/// This is an ActiveRecord class which wraps the OpProRole_tb table.
	/// </summary>
	[Serializable]
	public partial class OpProRole : ActiveRecord<OpProRole>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public OpProRole()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public OpProRole(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public OpProRole(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public OpProRole(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("OpProRole_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarOpProRoleId = new TableSchema.TableColumn(schema);
				colvarOpProRoleId.ColumnName = "OpProRoleId";
				colvarOpProRoleId.DataType = DbType.Int32;
				colvarOpProRoleId.MaxLength = 0;
				colvarOpProRoleId.AutoIncrement = true;
				colvarOpProRoleId.IsNullable = false;
				colvarOpProRoleId.IsPrimaryKey = true;
				colvarOpProRoleId.IsForeignKey = false;
				colvarOpProRoleId.IsReadOnly = false;
				colvarOpProRoleId.DefaultSetting = @"";
				colvarOpProRoleId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOpProRoleId);
				
				TableSchema.TableColumn colvarOperationId = new TableSchema.TableColumn(schema);
				colvarOperationId.ColumnName = "OperationId";
				colvarOperationId.DataType = DbType.Int32;
				colvarOperationId.MaxLength = 0;
				colvarOperationId.AutoIncrement = false;
				colvarOperationId.IsNullable = true;
				colvarOperationId.IsPrimaryKey = false;
				colvarOperationId.IsForeignKey = false;
				colvarOperationId.IsReadOnly = false;
				colvarOperationId.DefaultSetting = @"";
				colvarOperationId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOperationId);
				
				TableSchema.TableColumn colvarProcessId = new TableSchema.TableColumn(schema);
				colvarProcessId.ColumnName = "ProcessId";
				colvarProcessId.DataType = DbType.Int32;
				colvarProcessId.MaxLength = 0;
				colvarProcessId.AutoIncrement = false;
				colvarProcessId.IsNullable = true;
				colvarProcessId.IsPrimaryKey = false;
				colvarProcessId.IsForeignKey = false;
				colvarProcessId.IsReadOnly = false;
				colvarProcessId.DefaultSetting = @"";
				colvarProcessId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProcessId);
				
				TableSchema.TableColumn colvarRoleId = new TableSchema.TableColumn(schema);
				colvarRoleId.ColumnName = "RoleId";
				colvarRoleId.DataType = DbType.Int32;
				colvarRoleId.MaxLength = 0;
				colvarRoleId.AutoIncrement = false;
				colvarRoleId.IsNullable = true;
				colvarRoleId.IsPrimaryKey = false;
				colvarRoleId.IsForeignKey = false;
				colvarRoleId.IsReadOnly = false;
				colvarRoleId.DefaultSetting = @"";
				colvarRoleId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRoleId);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("OpProRole_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("OpProRoleId")]
		[Bindable(true)]
		public int OpProRoleId 
		{
			get { return GetColumnValue<int>(Columns.OpProRoleId); }
			set { SetColumnValue(Columns.OpProRoleId, value); }
		}
		  
		[XmlAttribute("OperationId")]
		[Bindable(true)]
		public int? OperationId 
		{
			get { return GetColumnValue<int?>(Columns.OperationId); }
			set { SetColumnValue(Columns.OperationId, value); }
		}
		  
		[XmlAttribute("ProcessId")]
		[Bindable(true)]
		public int? ProcessId 
		{
			get { return GetColumnValue<int?>(Columns.ProcessId); }
			set { SetColumnValue(Columns.ProcessId, value); }
		}
		  
		[XmlAttribute("RoleId")]
		[Bindable(true)]
		public int? RoleId 
		{
			get { return GetColumnValue<int?>(Columns.RoleId); }
			set { SetColumnValue(Columns.RoleId, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int? varOperationId,int? varProcessId,int? varRoleId)
		{
			OpProRole item = new OpProRole();
			
			item.OperationId = varOperationId;
			
			item.ProcessId = varProcessId;
			
			item.RoleId = varRoleId;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varOpProRoleId,int? varOperationId,int? varProcessId,int? varRoleId)
		{
			OpProRole item = new OpProRole();
			
				item.OpProRoleId = varOpProRoleId;
			
				item.OperationId = varOperationId;
			
				item.ProcessId = varProcessId;
			
				item.RoleId = varRoleId;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn OpProRoleIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn OperationIdColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn ProcessIdColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn RoleIdColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string OpProRoleId = @"OpProRoleId";
			 public static string OperationId = @"OperationId";
			 public static string ProcessId = @"ProcessId";
			 public static string RoleId = @"RoleId";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
