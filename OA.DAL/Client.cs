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
	/// Strongly-typed collection for the Client class.
	/// </summary>
    [Serializable]
	public partial class ClientCollection : ActiveList<Client, ClientCollection>
	{	   
		public ClientCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>ClientCollection</returns>
		public ClientCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                Client o = this[i];
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
	/// This is an ActiveRecord class which wraps the Client_tb table.
	/// </summary>
	[Serializable]
	public partial class Client : ActiveRecord<Client>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public Client()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public Client(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public Client(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public Client(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("Client_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarClientId = new TableSchema.TableColumn(schema);
				colvarClientId.ColumnName = "ClientId";
				colvarClientId.DataType = DbType.Int32;
				colvarClientId.MaxLength = 0;
				colvarClientId.AutoIncrement = true;
				colvarClientId.IsNullable = false;
				colvarClientId.IsPrimaryKey = true;
				colvarClientId.IsForeignKey = false;
				colvarClientId.IsReadOnly = false;
				colvarClientId.DefaultSetting = @"";
				colvarClientId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarClientId);
				
				TableSchema.TableColumn colvarClientName = new TableSchema.TableColumn(schema);
				colvarClientName.ColumnName = "ClientName";
				colvarClientName.DataType = DbType.String;
				colvarClientName.MaxLength = 50;
				colvarClientName.AutoIncrement = false;
				colvarClientName.IsNullable = true;
				colvarClientName.IsPrimaryKey = false;
				colvarClientName.IsForeignKey = false;
				colvarClientName.IsReadOnly = false;
				colvarClientName.DefaultSetting = @"";
				colvarClientName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarClientName);
				
				TableSchema.TableColumn colvarClientLevelId = new TableSchema.TableColumn(schema);
				colvarClientLevelId.ColumnName = "ClientLevelId";
				colvarClientLevelId.DataType = DbType.Int32;
				colvarClientLevelId.MaxLength = 0;
				colvarClientLevelId.AutoIncrement = false;
				colvarClientLevelId.IsNullable = true;
				colvarClientLevelId.IsPrimaryKey = false;
				colvarClientLevelId.IsForeignKey = false;
				colvarClientLevelId.IsReadOnly = false;
				colvarClientLevelId.DefaultSetting = @"";
				colvarClientLevelId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarClientLevelId);
				
				TableSchema.TableColumn colvarAddress = new TableSchema.TableColumn(schema);
				colvarAddress.ColumnName = "Address";
				colvarAddress.DataType = DbType.String;
				colvarAddress.MaxLength = 50;
				colvarAddress.AutoIncrement = false;
				colvarAddress.IsNullable = true;
				colvarAddress.IsPrimaryKey = false;
				colvarAddress.IsForeignKey = false;
				colvarAddress.IsReadOnly = false;
				colvarAddress.DefaultSetting = @"";
				colvarAddress.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAddress);
				
				TableSchema.TableColumn colvarTelephone = new TableSchema.TableColumn(schema);
				colvarTelephone.ColumnName = "Telephone";
				colvarTelephone.DataType = DbType.String;
				colvarTelephone.MaxLength = 50;
				colvarTelephone.AutoIncrement = false;
				colvarTelephone.IsNullable = true;
				colvarTelephone.IsPrimaryKey = false;
				colvarTelephone.IsForeignKey = false;
				colvarTelephone.IsReadOnly = false;
				colvarTelephone.DefaultSetting = @"";
				colvarTelephone.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTelephone);
				
				TableSchema.TableColumn colvarMailNo = new TableSchema.TableColumn(schema);
				colvarMailNo.ColumnName = "MailNo";
				colvarMailNo.DataType = DbType.String;
				colvarMailNo.MaxLength = 50;
				colvarMailNo.AutoIncrement = false;
				colvarMailNo.IsNullable = true;
				colvarMailNo.IsPrimaryKey = false;
				colvarMailNo.IsForeignKey = false;
				colvarMailNo.IsReadOnly = false;
				colvarMailNo.DefaultSetting = @"";
				colvarMailNo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMailNo);
				
				TableSchema.TableColumn colvarFax = new TableSchema.TableColumn(schema);
				colvarFax.ColumnName = "Fax";
				colvarFax.DataType = DbType.String;
				colvarFax.MaxLength = 50;
				colvarFax.AutoIncrement = false;
				colvarFax.IsNullable = true;
				colvarFax.IsPrimaryKey = false;
				colvarFax.IsForeignKey = false;
				colvarFax.IsReadOnly = false;
				colvarFax.DefaultSetting = @"";
				colvarFax.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFax);
				
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
				
				TableSchema.TableColumn colvarClientTypeId = new TableSchema.TableColumn(schema);
				colvarClientTypeId.ColumnName = "ClientTypeId";
				colvarClientTypeId.DataType = DbType.Int32;
				colvarClientTypeId.MaxLength = 0;
				colvarClientTypeId.AutoIncrement = false;
				colvarClientTypeId.IsNullable = true;
				colvarClientTypeId.IsPrimaryKey = false;
				colvarClientTypeId.IsForeignKey = false;
				colvarClientTypeId.IsReadOnly = false;
				colvarClientTypeId.DefaultSetting = @"";
				colvarClientTypeId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarClientTypeId);
				
				TableSchema.TableColumn colvarSheetNum = new TableSchema.TableColumn(schema);
				colvarSheetNum.ColumnName = "SheetNum";
				colvarSheetNum.DataType = DbType.String;
				colvarSheetNum.MaxLength = 50;
				colvarSheetNum.AutoIncrement = false;
				colvarSheetNum.IsNullable = true;
				colvarSheetNum.IsPrimaryKey = false;
				colvarSheetNum.IsForeignKey = false;
				colvarSheetNum.IsReadOnly = false;
				colvarSheetNum.DefaultSetting = @"";
				colvarSheetNum.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSheetNum);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("Client_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("ClientId")]
		[Bindable(true)]
		public int ClientId 
		{
			get { return GetColumnValue<int>(Columns.ClientId); }
			set { SetColumnValue(Columns.ClientId, value); }
		}
		  
		[XmlAttribute("ClientName")]
		[Bindable(true)]
		public string ClientName 
		{
			get { return GetColumnValue<string>(Columns.ClientName); }
			set { SetColumnValue(Columns.ClientName, value); }
		}
		  
		[XmlAttribute("ClientLevelId")]
		[Bindable(true)]
		public int? ClientLevelId 
		{
			get { return GetColumnValue<int?>(Columns.ClientLevelId); }
			set { SetColumnValue(Columns.ClientLevelId, value); }
		}
		  
		[XmlAttribute("Address")]
		[Bindable(true)]
		public string Address 
		{
			get { return GetColumnValue<string>(Columns.Address); }
			set { SetColumnValue(Columns.Address, value); }
		}
		  
		[XmlAttribute("Telephone")]
		[Bindable(true)]
		public string Telephone 
		{
			get { return GetColumnValue<string>(Columns.Telephone); }
			set { SetColumnValue(Columns.Telephone, value); }
		}
		  
		[XmlAttribute("MailNo")]
		[Bindable(true)]
		public string MailNo 
		{
			get { return GetColumnValue<string>(Columns.MailNo); }
			set { SetColumnValue(Columns.MailNo, value); }
		}
		  
		[XmlAttribute("Fax")]
		[Bindable(true)]
		public string Fax 
		{
			get { return GetColumnValue<string>(Columns.Fax); }
			set { SetColumnValue(Columns.Fax, value); }
		}
		  
		[XmlAttribute("EmployeeId")]
		[Bindable(true)]
		public int? EmployeeId 
		{
			get { return GetColumnValue<int?>(Columns.EmployeeId); }
			set { SetColumnValue(Columns.EmployeeId, value); }
		}
		  
		[XmlAttribute("ClientTypeId")]
		[Bindable(true)]
		public int? ClientTypeId 
		{
			get { return GetColumnValue<int?>(Columns.ClientTypeId); }
			set { SetColumnValue(Columns.ClientTypeId, value); }
		}
		  
		[XmlAttribute("SheetNum")]
		[Bindable(true)]
		public string SheetNum 
		{
			get { return GetColumnValue<string>(Columns.SheetNum); }
			set { SetColumnValue(Columns.SheetNum, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varClientName,int? varClientLevelId,string varAddress,string varTelephone,string varMailNo,string varFax,int? varEmployeeId,int? varClientTypeId,string varSheetNum)
		{
			Client item = new Client();
			
			item.ClientName = varClientName;
			
			item.ClientLevelId = varClientLevelId;
			
			item.Address = varAddress;
			
			item.Telephone = varTelephone;
			
			item.MailNo = varMailNo;
			
			item.Fax = varFax;
			
			item.EmployeeId = varEmployeeId;
			
			item.ClientTypeId = varClientTypeId;
			
			item.SheetNum = varSheetNum;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varClientId,string varClientName,int? varClientLevelId,string varAddress,string varTelephone,string varMailNo,string varFax,int? varEmployeeId,int? varClientTypeId,string varSheetNum)
		{
			Client item = new Client();
			
				item.ClientId = varClientId;
			
				item.ClientName = varClientName;
			
				item.ClientLevelId = varClientLevelId;
			
				item.Address = varAddress;
			
				item.Telephone = varTelephone;
			
				item.MailNo = varMailNo;
			
				item.Fax = varFax;
			
				item.EmployeeId = varEmployeeId;
			
				item.ClientTypeId = varClientTypeId;
			
				item.SheetNum = varSheetNum;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn ClientIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ClientNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn ClientLevelIdColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn AddressColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn TelephoneColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn MailNoColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn FaxColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn EmployeeIdColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn ClientTypeIdColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn SheetNumColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string ClientId = @"ClientId";
			 public static string ClientName = @"ClientName";
			 public static string ClientLevelId = @"ClientLevelId";
			 public static string Address = @"Address";
			 public static string Telephone = @"Telephone";
			 public static string MailNo = @"MailNo";
			 public static string Fax = @"Fax";
			 public static string EmployeeId = @"EmployeeId";
			 public static string ClientTypeId = @"ClientTypeId";
			 public static string SheetNum = @"SheetNum";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
