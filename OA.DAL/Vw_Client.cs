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
namespace CanYou.OA.DAL{
    /// <summary>
    /// Strongly-typed collection for the Vw_Client class.
    /// </summary>
    [Serializable]
    public partial class Vw_ClientCollection : ReadOnlyList<Vw_Client, Vw_ClientCollection>
    {        
        public Vw_ClientCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the vw_Client view.
    /// </summary>
    [Serializable]
    public partial class Vw_Client : ReadOnlyRecord<Vw_Client>, IReadOnlyRecord
    {
    
	    #region Default Settings
	    protected static void SetSQLProps() 
	    {
		    GetTableSchema();
	    }
	    #endregion
        #region Schema Accessor
	    public static TableSchema.Table Schema
        {
            get
            {
                if (BaseSchema == null)
                {
                    SetSQLProps();
                }
                return BaseSchema;
            }
        }
    	
        private static void GetTableSchema() 
        {
            if(!IsSchemaInitialized)
            {
                //Schema declaration
                TableSchema.Table schema = new TableSchema.Table("vw_Client", TableType.View, DataService.GetInstance("SubsonicProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarClientId = new TableSchema.TableColumn(schema);
                colvarClientId.ColumnName = "ClientId";
                colvarClientId.DataType = DbType.Int32;
                colvarClientId.MaxLength = 0;
                colvarClientId.AutoIncrement = false;
                colvarClientId.IsNullable = false;
                colvarClientId.IsPrimaryKey = false;
                colvarClientId.IsForeignKey = false;
                colvarClientId.IsReadOnly = false;
                
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
                
                schema.Columns.Add(colvarFax);
                
                TableSchema.TableColumn colvarEmployeeId = new TableSchema.TableColumn(schema);
                colvarEmployeeId.ColumnName = "EmployeeId";
                colvarEmployeeId.DataType = DbType.Int32;
                colvarEmployeeId.MaxLength = 0;
                colvarEmployeeId.AutoIncrement = false;
                colvarEmployeeId.IsNullable = false;
                colvarEmployeeId.IsPrimaryKey = false;
                colvarEmployeeId.IsForeignKey = false;
                colvarEmployeeId.IsReadOnly = false;
                
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
                
                schema.Columns.Add(colvarSheetNum);
                
                TableSchema.TableColumn colvarClientLevelName = new TableSchema.TableColumn(schema);
                colvarClientLevelName.ColumnName = "ClientLevelName";
                colvarClientLevelName.DataType = DbType.String;
                colvarClientLevelName.MaxLength = 50;
                colvarClientLevelName.AutoIncrement = false;
                colvarClientLevelName.IsNullable = true;
                colvarClientLevelName.IsPrimaryKey = false;
                colvarClientLevelName.IsForeignKey = false;
                colvarClientLevelName.IsReadOnly = false;
                
                schema.Columns.Add(colvarClientLevelName);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["SubsonicProvider"].AddSchema("vw_Client",schema);
            }
        }
        #endregion
        
        #region Query Accessor
	    public static Query CreateQuery()
	    {
		    return new Query(Schema);
	    }
	    #endregion
	    
	    #region .ctors
	    public Vw_Client()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public Vw_Client(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public Vw_Client(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public Vw_Client(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("ClientId")]
        [Bindable(true)]
        public int ClientId 
	    {
		    get
		    {
			    return GetColumnValue<int>("ClientId");
		    }
            set 
		    {
			    SetColumnValue("ClientId", value);
            }
        }
	      
        [XmlAttribute("ClientName")]
        [Bindable(true)]
        public string ClientName 
	    {
		    get
		    {
			    return GetColumnValue<string>("ClientName");
		    }
            set 
		    {
			    SetColumnValue("ClientName", value);
            }
        }
	      
        [XmlAttribute("ClientLevelId")]
        [Bindable(true)]
        public int? ClientLevelId 
	    {
		    get
		    {
			    return GetColumnValue<int?>("ClientLevelId");
		    }
            set 
		    {
			    SetColumnValue("ClientLevelId", value);
            }
        }
	      
        [XmlAttribute("Address")]
        [Bindable(true)]
        public string Address 
	    {
		    get
		    {
			    return GetColumnValue<string>("Address");
		    }
            set 
		    {
			    SetColumnValue("Address", value);
            }
        }
	      
        [XmlAttribute("Telephone")]
        [Bindable(true)]
        public string Telephone 
	    {
		    get
		    {
			    return GetColumnValue<string>("Telephone");
		    }
            set 
		    {
			    SetColumnValue("Telephone", value);
            }
        }
	      
        [XmlAttribute("MailNo")]
        [Bindable(true)]
        public string MailNo 
	    {
		    get
		    {
			    return GetColumnValue<string>("MailNo");
		    }
            set 
		    {
			    SetColumnValue("MailNo", value);
            }
        }
	      
        [XmlAttribute("Fax")]
        [Bindable(true)]
        public string Fax 
	    {
		    get
		    {
			    return GetColumnValue<string>("Fax");
		    }
            set 
		    {
			    SetColumnValue("Fax", value);
            }
        }
	      
        [XmlAttribute("EmployeeId")]
        [Bindable(true)]
        public int EmployeeId 
	    {
		    get
		    {
			    return GetColumnValue<int>("EmployeeId");
		    }
            set 
		    {
			    SetColumnValue("EmployeeId", value);
            }
        }
	      
        [XmlAttribute("ClientTypeId")]
        [Bindable(true)]
        public int? ClientTypeId 
	    {
		    get
		    {
			    return GetColumnValue<int?>("ClientTypeId");
		    }
            set 
		    {
			    SetColumnValue("ClientTypeId", value);
            }
        }
	      
        [XmlAttribute("SheetNum")]
        [Bindable(true)]
        public string SheetNum 
	    {
		    get
		    {
			    return GetColumnValue<string>("SheetNum");
		    }
            set 
		    {
			    SetColumnValue("SheetNum", value);
            }
        }
	      
        [XmlAttribute("ClientLevelName")]
        [Bindable(true)]
        public string ClientLevelName 
	    {
		    get
		    {
			    return GetColumnValue<string>("ClientLevelName");
		    }
            set 
		    {
			    SetColumnValue("ClientLevelName", value);
            }
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
            
            public static string ClientLevelName = @"ClientLevelName";
            
	    }
	    #endregion
	    
	    
	    #region IAbstractRecord Members
        public new CT GetColumnValue<CT>(string columnName) {
            return base.GetColumnValue<CT>(columnName);
        }
        public object GetColumnValue(string columnName) {
            return base.GetColumnValue<object>(columnName);
        }
        #endregion
	    
    }
}
