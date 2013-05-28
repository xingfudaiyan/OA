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
	/// Strongly-typed collection for the EmployeeBExp class.
	/// </summary>
    [Serializable]
	public partial class EmployeeBExpCollection : ActiveList<EmployeeBExp, EmployeeBExpCollection>
	{	   
		public EmployeeBExpCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>EmployeeBExpCollection</returns>
		public EmployeeBExpCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                EmployeeBExp o = this[i];
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
	/// This is an ActiveRecord class which wraps the EmployeeBExp_tb table.
	/// </summary>
	[Serializable]
	public partial class EmployeeBExp : ActiveRecord<EmployeeBExp>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public EmployeeBExp()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public EmployeeBExp(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public EmployeeBExp(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public EmployeeBExp(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("EmployeeBExp_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarEmployeeBExpId = new TableSchema.TableColumn(schema);
				colvarEmployeeBExpId.ColumnName = "EmployeeBExpId";
				colvarEmployeeBExpId.DataType = DbType.Int32;
				colvarEmployeeBExpId.MaxLength = 0;
				colvarEmployeeBExpId.AutoIncrement = true;
				colvarEmployeeBExpId.IsNullable = false;
				colvarEmployeeBExpId.IsPrimaryKey = true;
				colvarEmployeeBExpId.IsForeignKey = false;
				colvarEmployeeBExpId.IsReadOnly = false;
				colvarEmployeeBExpId.DefaultSetting = @"";
				colvarEmployeeBExpId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEmployeeBExpId);
				
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
				
				TableSchema.TableColumn colvarBusinessExpId = new TableSchema.TableColumn(schema);
				colvarBusinessExpId.ColumnName = "BusinessExpId";
				colvarBusinessExpId.DataType = DbType.Int32;
				colvarBusinessExpId.MaxLength = 0;
				colvarBusinessExpId.AutoIncrement = false;
				colvarBusinessExpId.IsNullable = true;
				colvarBusinessExpId.IsPrimaryKey = false;
				colvarBusinessExpId.IsForeignKey = false;
				colvarBusinessExpId.IsReadOnly = false;
				colvarBusinessExpId.DefaultSetting = @"";
				colvarBusinessExpId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBusinessExpId);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("EmployeeBExp_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("EmployeeBExpId")]
		[Bindable(true)]
		public int EmployeeBExpId 
		{
			get { return GetColumnValue<int>(Columns.EmployeeBExpId); }
			set { SetColumnValue(Columns.EmployeeBExpId, value); }
		}
		  
		[XmlAttribute("EmployeeId")]
		[Bindable(true)]
		public int? EmployeeId 
		{
			get { return GetColumnValue<int?>(Columns.EmployeeId); }
			set { SetColumnValue(Columns.EmployeeId, value); }
		}
		  
		[XmlAttribute("BusinessExpId")]
		[Bindable(true)]
		public int? BusinessExpId 
		{
			get { return GetColumnValue<int?>(Columns.BusinessExpId); }
			set { SetColumnValue(Columns.BusinessExpId, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int? varEmployeeId,int? varBusinessExpId)
		{
			EmployeeBExp item = new EmployeeBExp();
			
			item.EmployeeId = varEmployeeId;
			
			item.BusinessExpId = varBusinessExpId;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varEmployeeBExpId,int? varEmployeeId,int? varBusinessExpId)
		{
			EmployeeBExp item = new EmployeeBExp();
			
				item.EmployeeBExpId = varEmployeeBExpId;
			
				item.EmployeeId = varEmployeeId;
			
				item.BusinessExpId = varBusinessExpId;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn EmployeeBExpIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn EmployeeIdColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn BusinessExpIdColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string EmployeeBExpId = @"EmployeeBExpId";
			 public static string EmployeeId = @"EmployeeId";
			 public static string BusinessExpId = @"BusinessExpId";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
