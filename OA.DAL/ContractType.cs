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
	/// Strongly-typed collection for the ContractType class.
	/// </summary>
    [Serializable]
	public partial class ContractTypeCollection : ActiveList<ContractType, ContractTypeCollection>
	{	   
		public ContractTypeCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>ContractTypeCollection</returns>
		public ContractTypeCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                ContractType o = this[i];
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
	/// This is an ActiveRecord class which wraps the ContractType_tb table.
	/// </summary>
	[Serializable]
	public partial class ContractType : ActiveRecord<ContractType>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public ContractType()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public ContractType(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public ContractType(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public ContractType(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("ContractType_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarContractTypeId = new TableSchema.TableColumn(schema);
				colvarContractTypeId.ColumnName = "ContractTypeId";
				colvarContractTypeId.DataType = DbType.Int32;
				colvarContractTypeId.MaxLength = 0;
				colvarContractTypeId.AutoIncrement = true;
				colvarContractTypeId.IsNullable = false;
				colvarContractTypeId.IsPrimaryKey = true;
				colvarContractTypeId.IsForeignKey = false;
				colvarContractTypeId.IsReadOnly = false;
				colvarContractTypeId.DefaultSetting = @"";
				colvarContractTypeId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarContractTypeId);
				
				TableSchema.TableColumn colvarContractTypeName = new TableSchema.TableColumn(schema);
				colvarContractTypeName.ColumnName = "ContractTypeName";
				colvarContractTypeName.DataType = DbType.String;
				colvarContractTypeName.MaxLength = 50;
				colvarContractTypeName.AutoIncrement = false;
				colvarContractTypeName.IsNullable = true;
				colvarContractTypeName.IsPrimaryKey = false;
				colvarContractTypeName.IsForeignKey = false;
				colvarContractTypeName.IsReadOnly = false;
				colvarContractTypeName.DefaultSetting = @"";
				colvarContractTypeName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarContractTypeName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("ContractType_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("ContractTypeId")]
		[Bindable(true)]
		public int ContractTypeId 
		{
			get { return GetColumnValue<int>(Columns.ContractTypeId); }
			set { SetColumnValue(Columns.ContractTypeId, value); }
		}
		  
		[XmlAttribute("ContractTypeName")]
		[Bindable(true)]
		public string ContractTypeName 
		{
			get { return GetColumnValue<string>(Columns.ContractTypeName); }
			set { SetColumnValue(Columns.ContractTypeName, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varContractTypeName)
		{
			ContractType item = new ContractType();
			
			item.ContractTypeName = varContractTypeName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varContractTypeId,string varContractTypeName)
		{
			ContractType item = new ContractType();
			
				item.ContractTypeId = varContractTypeId;
			
				item.ContractTypeName = varContractTypeName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn ContractTypeIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ContractTypeNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string ContractTypeId = @"ContractTypeId";
			 public static string ContractTypeName = @"ContractTypeName";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
