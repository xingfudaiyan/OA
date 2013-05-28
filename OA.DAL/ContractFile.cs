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
	/// Strongly-typed collection for the ContractFile class.
	/// </summary>
    [Serializable]
	public partial class ContractFileCollection : ActiveList<ContractFile, ContractFileCollection>
	{	   
		public ContractFileCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>ContractFileCollection</returns>
		public ContractFileCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                ContractFile o = this[i];
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
	/// This is an ActiveRecord class which wraps the ContractFile_tb table.
	/// </summary>
	[Serializable]
	public partial class ContractFile : ActiveRecord<ContractFile>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public ContractFile()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public ContractFile(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public ContractFile(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public ContractFile(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("ContractFile_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarContractFileId = new TableSchema.TableColumn(schema);
				colvarContractFileId.ColumnName = "ContractFileId";
				colvarContractFileId.DataType = DbType.Int32;
				colvarContractFileId.MaxLength = 0;
				colvarContractFileId.AutoIncrement = true;
				colvarContractFileId.IsNullable = false;
				colvarContractFileId.IsPrimaryKey = true;
				colvarContractFileId.IsForeignKey = false;
				colvarContractFileId.IsReadOnly = false;
				colvarContractFileId.DefaultSetting = @"";
				colvarContractFileId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarContractFileId);
				
				TableSchema.TableColumn colvarContractFileName = new TableSchema.TableColumn(schema);
				colvarContractFileName.ColumnName = "ContractFileName";
				colvarContractFileName.DataType = DbType.String;
				colvarContractFileName.MaxLength = 50;
				colvarContractFileName.AutoIncrement = false;
				colvarContractFileName.IsNullable = true;
				colvarContractFileName.IsPrimaryKey = false;
				colvarContractFileName.IsForeignKey = false;
				colvarContractFileName.IsReadOnly = false;
				colvarContractFileName.DefaultSetting = @"";
				colvarContractFileName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarContractFileName);
				
				TableSchema.TableColumn colvarPhyFileName = new TableSchema.TableColumn(schema);
				colvarPhyFileName.ColumnName = "PhyFileName";
				colvarPhyFileName.DataType = DbType.String;
				colvarPhyFileName.MaxLength = 50;
				colvarPhyFileName.AutoIncrement = false;
				colvarPhyFileName.IsNullable = true;
				colvarPhyFileName.IsPrimaryKey = false;
				colvarPhyFileName.IsForeignKey = false;
				colvarPhyFileName.IsReadOnly = false;
				colvarPhyFileName.DefaultSetting = @"";
				colvarPhyFileName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPhyFileName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("ContractFile_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("ContractFileId")]
		[Bindable(true)]
		public int ContractFileId 
		{
			get { return GetColumnValue<int>(Columns.ContractFileId); }
			set { SetColumnValue(Columns.ContractFileId, value); }
		}
		  
		[XmlAttribute("ContractFileName")]
		[Bindable(true)]
		public string ContractFileName 
		{
			get { return GetColumnValue<string>(Columns.ContractFileName); }
			set { SetColumnValue(Columns.ContractFileName, value); }
		}
		  
		[XmlAttribute("PhyFileName")]
		[Bindable(true)]
		public string PhyFileName 
		{
			get { return GetColumnValue<string>(Columns.PhyFileName); }
			set { SetColumnValue(Columns.PhyFileName, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varContractFileName,string varPhyFileName)
		{
			ContractFile item = new ContractFile();
			
			item.ContractFileName = varContractFileName;
			
			item.PhyFileName = varPhyFileName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varContractFileId,string varContractFileName,string varPhyFileName)
		{
			ContractFile item = new ContractFile();
			
				item.ContractFileId = varContractFileId;
			
				item.ContractFileName = varContractFileName;
			
				item.PhyFileName = varPhyFileName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn ContractFileIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ContractFileNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn PhyFileNameColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string ContractFileId = @"ContractFileId";
			 public static string ContractFileName = @"ContractFileName";
			 public static string PhyFileName = @"PhyFileName";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
