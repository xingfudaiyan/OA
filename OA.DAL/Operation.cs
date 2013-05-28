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
	/// Strongly-typed collection for the Operation class.
	/// </summary>
    [Serializable]
	public partial class OperationCollection : ActiveList<Operation, OperationCollection>
	{	   
		public OperationCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>OperationCollection</returns>
		public OperationCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                Operation o = this[i];
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
	/// This is an ActiveRecord class which wraps the Operation_tb table.
	/// </summary>
	[Serializable]
	public partial class Operation : ActiveRecord<Operation>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public Operation()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public Operation(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public Operation(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public Operation(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("Operation_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarOperationId = new TableSchema.TableColumn(schema);
				colvarOperationId.ColumnName = "OperationId";
				colvarOperationId.DataType = DbType.Int32;
				colvarOperationId.MaxLength = 0;
				colvarOperationId.AutoIncrement = true;
				colvarOperationId.IsNullable = false;
				colvarOperationId.IsPrimaryKey = true;
				colvarOperationId.IsForeignKey = false;
				colvarOperationId.IsReadOnly = false;
				colvarOperationId.DefaultSetting = @"";
				colvarOperationId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOperationId);
				
				TableSchema.TableColumn colvarOperationName = new TableSchema.TableColumn(schema);
				colvarOperationName.ColumnName = "OperationName";
				colvarOperationName.DataType = DbType.String;
				colvarOperationName.MaxLength = 50;
				colvarOperationName.AutoIncrement = false;
				colvarOperationName.IsNullable = true;
				colvarOperationName.IsPrimaryKey = false;
				colvarOperationName.IsForeignKey = false;
				colvarOperationName.IsReadOnly = false;
				colvarOperationName.DefaultSetting = @"";
				colvarOperationName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOperationName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("Operation_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("OperationId")]
		[Bindable(true)]
		public int OperationId 
		{
			get { return GetColumnValue<int>(Columns.OperationId); }
			set { SetColumnValue(Columns.OperationId, value); }
		}
		  
		[XmlAttribute("OperationName")]
		[Bindable(true)]
		public string OperationName 
		{
			get { return GetColumnValue<string>(Columns.OperationName); }
			set { SetColumnValue(Columns.OperationName, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varOperationName)
		{
			Operation item = new Operation();
			
			item.OperationName = varOperationName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varOperationId,string varOperationName)
		{
			Operation item = new Operation();
			
				item.OperationId = varOperationId;
			
				item.OperationName = varOperationName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn OperationIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn OperationNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string OperationId = @"OperationId";
			 public static string OperationName = @"OperationName";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
