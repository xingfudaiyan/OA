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
	/// Strongly-typed collection for the Contract class.
	/// </summary>
    [Serializable]
	public partial class ContractCollection : ActiveList<Contract, ContractCollection>
	{	   
		public ContractCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>ContractCollection</returns>
		public ContractCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                Contract o = this[i];
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
	/// This is an ActiveRecord class which wraps the Contract_tb table.
	/// </summary>
	[Serializable]
	public partial class Contract : ActiveRecord<Contract>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public Contract()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public Contract(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public Contract(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public Contract(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("Contract_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarContractId = new TableSchema.TableColumn(schema);
				colvarContractId.ColumnName = "ContractId";
				colvarContractId.DataType = DbType.Int32;
				colvarContractId.MaxLength = 0;
				colvarContractId.AutoIncrement = true;
				colvarContractId.IsNullable = false;
				colvarContractId.IsPrimaryKey = true;
				colvarContractId.IsForeignKey = false;
				colvarContractId.IsReadOnly = false;
				colvarContractId.DefaultSetting = @"";
				colvarContractId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarContractId);
				
				TableSchema.TableColumn colvarContractFileId = new TableSchema.TableColumn(schema);
				colvarContractFileId.ColumnName = "ContractFileId";
				colvarContractFileId.DataType = DbType.Int32;
				colvarContractFileId.MaxLength = 0;
				colvarContractFileId.AutoIncrement = false;
				colvarContractFileId.IsNullable = true;
				colvarContractFileId.IsPrimaryKey = false;
				colvarContractFileId.IsForeignKey = false;
				colvarContractFileId.IsReadOnly = false;
				colvarContractFileId.DefaultSetting = @"";
				colvarContractFileId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarContractFileId);
				
				TableSchema.TableColumn colvarSignName = new TableSchema.TableColumn(schema);
				colvarSignName.ColumnName = "SignName";
				colvarSignName.DataType = DbType.String;
				colvarSignName.MaxLength = 50;
				colvarSignName.AutoIncrement = false;
				colvarSignName.IsNullable = true;
				colvarSignName.IsPrimaryKey = false;
				colvarSignName.IsForeignKey = false;
				colvarSignName.IsReadOnly = false;
				colvarSignName.DefaultSetting = @"";
				colvarSignName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSignName);
				
				TableSchema.TableColumn colvarContractNum = new TableSchema.TableColumn(schema);
				colvarContractNum.ColumnName = "ContractNum";
				colvarContractNum.DataType = DbType.String;
				colvarContractNum.MaxLength = 50;
				colvarContractNum.AutoIncrement = false;
				colvarContractNum.IsNullable = true;
				colvarContractNum.IsPrimaryKey = false;
				colvarContractNum.IsForeignKey = false;
				colvarContractNum.IsReadOnly = false;
				colvarContractNum.DefaultSetting = @"";
				colvarContractNum.ForeignKeyTableName = "";
				schema.Columns.Add(colvarContractNum);
				
				TableSchema.TableColumn colvarContractName = new TableSchema.TableColumn(schema);
				colvarContractName.ColumnName = "ContractName";
				colvarContractName.DataType = DbType.String;
				colvarContractName.MaxLength = 50;
				colvarContractName.AutoIncrement = false;
				colvarContractName.IsNullable = true;
				colvarContractName.IsPrimaryKey = false;
				colvarContractName.IsForeignKey = false;
				colvarContractName.IsReadOnly = false;
				colvarContractName.DefaultSetting = @"";
				colvarContractName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarContractName);
				
				TableSchema.TableColumn colvarBeginDate = new TableSchema.TableColumn(schema);
				colvarBeginDate.ColumnName = "BeginDate";
				colvarBeginDate.DataType = DbType.String;
				colvarBeginDate.MaxLength = 50;
				colvarBeginDate.AutoIncrement = false;
				colvarBeginDate.IsNullable = true;
				colvarBeginDate.IsPrimaryKey = false;
				colvarBeginDate.IsForeignKey = false;
				colvarBeginDate.IsReadOnly = false;
				colvarBeginDate.DefaultSetting = @"";
				colvarBeginDate.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBeginDate);
				
				TableSchema.TableColumn colvarMoneySum = new TableSchema.TableColumn(schema);
				colvarMoneySum.ColumnName = "MoneySum";
				colvarMoneySum.DataType = DbType.String;
				colvarMoneySum.MaxLength = 50;
				colvarMoneySum.AutoIncrement = false;
				colvarMoneySum.IsNullable = true;
				colvarMoneySum.IsPrimaryKey = false;
				colvarMoneySum.IsForeignKey = false;
				colvarMoneySum.IsReadOnly = false;
				colvarMoneySum.DefaultSetting = @"";
				colvarMoneySum.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMoneySum);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("Contract_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("ContractId")]
		[Bindable(true)]
		public int ContractId 
		{
			get { return GetColumnValue<int>(Columns.ContractId); }
			set { SetColumnValue(Columns.ContractId, value); }
		}
		  
		[XmlAttribute("ContractFileId")]
		[Bindable(true)]
		public int? ContractFileId 
		{
			get { return GetColumnValue<int?>(Columns.ContractFileId); }
			set { SetColumnValue(Columns.ContractFileId, value); }
		}
		  
		[XmlAttribute("SignName")]
		[Bindable(true)]
		public string SignName 
		{
			get { return GetColumnValue<string>(Columns.SignName); }
			set { SetColumnValue(Columns.SignName, value); }
		}
		  
		[XmlAttribute("ContractNum")]
		[Bindable(true)]
		public string ContractNum 
		{
			get { return GetColumnValue<string>(Columns.ContractNum); }
			set { SetColumnValue(Columns.ContractNum, value); }
		}
		  
		[XmlAttribute("ContractName")]
		[Bindable(true)]
		public string ContractName 
		{
			get { return GetColumnValue<string>(Columns.ContractName); }
			set { SetColumnValue(Columns.ContractName, value); }
		}
		  
		[XmlAttribute("BeginDate")]
		[Bindable(true)]
		public string BeginDate 
		{
			get { return GetColumnValue<string>(Columns.BeginDate); }
			set { SetColumnValue(Columns.BeginDate, value); }
		}
		  
		[XmlAttribute("MoneySum")]
		[Bindable(true)]
		public string MoneySum 
		{
			get { return GetColumnValue<string>(Columns.MoneySum); }
			set { SetColumnValue(Columns.MoneySum, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int? varContractFileId,string varSignName,string varContractNum,string varContractName,string varBeginDate,string varMoneySum)
		{
			Contract item = new Contract();
			
			item.ContractFileId = varContractFileId;
			
			item.SignName = varSignName;
			
			item.ContractNum = varContractNum;
			
			item.ContractName = varContractName;
			
			item.BeginDate = varBeginDate;
			
			item.MoneySum = varMoneySum;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varContractId,int? varContractFileId,string varSignName,string varContractNum,string varContractName,string varBeginDate,string varMoneySum)
		{
			Contract item = new Contract();
			
				item.ContractId = varContractId;
			
				item.ContractFileId = varContractFileId;
			
				item.SignName = varSignName;
			
				item.ContractNum = varContractNum;
			
				item.ContractName = varContractName;
			
				item.BeginDate = varBeginDate;
			
				item.MoneySum = varMoneySum;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn ContractIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ContractFileIdColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn SignNameColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn ContractNumColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn ContractNameColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn BeginDateColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn MoneySumColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string ContractId = @"ContractId";
			 public static string ContractFileId = @"ContractFileId";
			 public static string SignName = @"SignName";
			 public static string ContractNum = @"ContractNum";
			 public static string ContractName = @"ContractName";
			 public static string BeginDate = @"BeginDate";
			 public static string MoneySum = @"MoneySum";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
