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
    /// Strongly-typed collection for the Vw_ManagerOfOffice class.
    /// </summary>
    [Serializable]
    public partial class Vw_ManagerOfOfficeCollection : ReadOnlyList<Vw_ManagerOfOffice, Vw_ManagerOfOfficeCollection>
    {        
        public Vw_ManagerOfOfficeCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the vw_ManagerOfOffice view.
    /// </summary>
    [Serializable]
    public partial class Vw_ManagerOfOffice : ReadOnlyRecord<Vw_ManagerOfOffice>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("vw_ManagerOfOffice", TableType.View, DataService.GetInstance("SubsonicProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarWorkToolSumId = new TableSchema.TableColumn(schema);
                colvarWorkToolSumId.ColumnName = "WorkToolSumId";
                colvarWorkToolSumId.DataType = DbType.Int32;
                colvarWorkToolSumId.MaxLength = 0;
                colvarWorkToolSumId.AutoIncrement = false;
                colvarWorkToolSumId.IsNullable = false;
                colvarWorkToolSumId.IsPrimaryKey = false;
                colvarWorkToolSumId.IsForeignKey = false;
                colvarWorkToolSumId.IsReadOnly = false;
                
                schema.Columns.Add(colvarWorkToolSumId);
                
                TableSchema.TableColumn colvarDepartName = new TableSchema.TableColumn(schema);
                colvarDepartName.ColumnName = "DepartName";
                colvarDepartName.DataType = DbType.String;
                colvarDepartName.MaxLength = 50;
                colvarDepartName.AutoIncrement = false;
                colvarDepartName.IsNullable = true;
                colvarDepartName.IsPrimaryKey = false;
                colvarDepartName.IsForeignKey = false;
                colvarDepartName.IsReadOnly = false;
                
                schema.Columns.Add(colvarDepartName);
                
                TableSchema.TableColumn colvarReason = new TableSchema.TableColumn(schema);
                colvarReason.ColumnName = "Reason";
                colvarReason.DataType = DbType.String;
                colvarReason.MaxLength = -1;
                colvarReason.AutoIncrement = false;
                colvarReason.IsNullable = true;
                colvarReason.IsPrimaryKey = false;
                colvarReason.IsForeignKey = false;
                colvarReason.IsReadOnly = false;
                
                schema.Columns.Add(colvarReason);
                
                TableSchema.TableColumn colvarBigMoney = new TableSchema.TableColumn(schema);
                colvarBigMoney.ColumnName = "BigMoney";
                colvarBigMoney.DataType = DbType.String;
                colvarBigMoney.MaxLength = 50;
                colvarBigMoney.AutoIncrement = false;
                colvarBigMoney.IsNullable = true;
                colvarBigMoney.IsPrimaryKey = false;
                colvarBigMoney.IsForeignKey = false;
                colvarBigMoney.IsReadOnly = false;
                
                schema.Columns.Add(colvarBigMoney);
                
                TableSchema.TableColumn colvarSmaMoney = new TableSchema.TableColumn(schema);
                colvarSmaMoney.ColumnName = "SmaMoney";
                colvarSmaMoney.DataType = DbType.String;
                colvarSmaMoney.MaxLength = 50;
                colvarSmaMoney.AutoIncrement = false;
                colvarSmaMoney.IsNullable = true;
                colvarSmaMoney.IsPrimaryKey = false;
                colvarSmaMoney.IsForeignKey = false;
                colvarSmaMoney.IsReadOnly = false;
                
                schema.Columns.Add(colvarSmaMoney);
                
                TableSchema.TableColumn colvarMoneyStyle = new TableSchema.TableColumn(schema);
                colvarMoneyStyle.ColumnName = "MoneyStyle";
                colvarMoneyStyle.DataType = DbType.String;
                colvarMoneyStyle.MaxLength = 50;
                colvarMoneyStyle.AutoIncrement = false;
                colvarMoneyStyle.IsNullable = true;
                colvarMoneyStyle.IsPrimaryKey = false;
                colvarMoneyStyle.IsForeignKey = false;
                colvarMoneyStyle.IsReadOnly = false;
                
                schema.Columns.Add(colvarMoneyStyle);
                
                TableSchema.TableColumn colvarUseDepartName = new TableSchema.TableColumn(schema);
                colvarUseDepartName.ColumnName = "UseDepartName";
                colvarUseDepartName.DataType = DbType.String;
                colvarUseDepartName.MaxLength = 50;
                colvarUseDepartName.AutoIncrement = false;
                colvarUseDepartName.IsNullable = true;
                colvarUseDepartName.IsPrimaryKey = false;
                colvarUseDepartName.IsForeignKey = false;
                colvarUseDepartName.IsReadOnly = false;
                
                schema.Columns.Add(colvarUseDepartName);
                
                TableSchema.TableColumn colvarFuTime = new TableSchema.TableColumn(schema);
                colvarFuTime.ColumnName = "FuTime";
                colvarFuTime.DataType = DbType.String;
                colvarFuTime.MaxLength = 50;
                colvarFuTime.AutoIncrement = false;
                colvarFuTime.IsNullable = true;
                colvarFuTime.IsPrimaryKey = false;
                colvarFuTime.IsForeignKey = false;
                colvarFuTime.IsReadOnly = false;
                
                schema.Columns.Add(colvarFuTime);
                
                TableSchema.TableColumn colvarApplyName = new TableSchema.TableColumn(schema);
                colvarApplyName.ColumnName = "ApplyName";
                colvarApplyName.DataType = DbType.String;
                colvarApplyName.MaxLength = 50;
                colvarApplyName.AutoIncrement = false;
                colvarApplyName.IsNullable = true;
                colvarApplyName.IsPrimaryKey = false;
                colvarApplyName.IsForeignKey = false;
                colvarApplyName.IsReadOnly = false;
                
                schema.Columns.Add(colvarApplyName);
                
                TableSchema.TableColumn colvarState = new TableSchema.TableColumn(schema);
                colvarState.ColumnName = "State";
                colvarState.DataType = DbType.Int32;
                colvarState.MaxLength = 0;
                colvarState.AutoIncrement = false;
                colvarState.IsNullable = true;
                colvarState.IsPrimaryKey = false;
                colvarState.IsForeignKey = false;
                colvarState.IsReadOnly = false;
                
                schema.Columns.Add(colvarState);
                
                TableSchema.TableColumn colvarApplyTime = new TableSchema.TableColumn(schema);
                colvarApplyTime.ColumnName = "ApplyTime";
                colvarApplyTime.DataType = DbType.String;
                colvarApplyTime.MaxLength = 50;
                colvarApplyTime.AutoIncrement = false;
                colvarApplyTime.IsNullable = true;
                colvarApplyTime.IsPrimaryKey = false;
                colvarApplyTime.IsForeignKey = false;
                colvarApplyTime.IsReadOnly = false;
                
                schema.Columns.Add(colvarApplyTime);
                
                TableSchema.TableColumn colvarDepartView = new TableSchema.TableColumn(schema);
                colvarDepartView.ColumnName = "DepartView";
                colvarDepartView.DataType = DbType.String;
                colvarDepartView.MaxLength = 50;
                colvarDepartView.AutoIncrement = false;
                colvarDepartView.IsNullable = true;
                colvarDepartView.IsPrimaryKey = false;
                colvarDepartView.IsForeignKey = false;
                colvarDepartView.IsReadOnly = false;
                
                schema.Columns.Add(colvarDepartView);
                
                TableSchema.TableColumn colvarManagerView = new TableSchema.TableColumn(schema);
                colvarManagerView.ColumnName = "ManagerView";
                colvarManagerView.DataType = DbType.String;
                colvarManagerView.MaxLength = 50;
                colvarManagerView.AutoIncrement = false;
                colvarManagerView.IsNullable = true;
                colvarManagerView.IsPrimaryKey = false;
                colvarManagerView.IsForeignKey = false;
                colvarManagerView.IsReadOnly = false;
                
                schema.Columns.Add(colvarManagerView);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["SubsonicProvider"].AddSchema("vw_ManagerOfOffice",schema);
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
	    public Vw_ManagerOfOffice()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public Vw_ManagerOfOffice(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public Vw_ManagerOfOffice(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public Vw_ManagerOfOffice(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("WorkToolSumId")]
        [Bindable(true)]
        public int WorkToolSumId 
	    {
		    get
		    {
			    return GetColumnValue<int>("WorkToolSumId");
		    }
            set 
		    {
			    SetColumnValue("WorkToolSumId", value);
            }
        }
	      
        [XmlAttribute("DepartName")]
        [Bindable(true)]
        public string DepartName 
	    {
		    get
		    {
			    return GetColumnValue<string>("DepartName");
		    }
            set 
		    {
			    SetColumnValue("DepartName", value);
            }
        }
	      
        [XmlAttribute("Reason")]
        [Bindable(true)]
        public string Reason 
	    {
		    get
		    {
			    return GetColumnValue<string>("Reason");
		    }
            set 
		    {
			    SetColumnValue("Reason", value);
            }
        }
	      
        [XmlAttribute("BigMoney")]
        [Bindable(true)]
        public string BigMoney 
	    {
		    get
		    {
			    return GetColumnValue<string>("BigMoney");
		    }
            set 
		    {
			    SetColumnValue("BigMoney", value);
            }
        }
	      
        [XmlAttribute("SmaMoney")]
        [Bindable(true)]
        public string SmaMoney 
	    {
		    get
		    {
			    return GetColumnValue<string>("SmaMoney");
		    }
            set 
		    {
			    SetColumnValue("SmaMoney", value);
            }
        }
	      
        [XmlAttribute("MoneyStyle")]
        [Bindable(true)]
        public string MoneyStyle 
	    {
		    get
		    {
			    return GetColumnValue<string>("MoneyStyle");
		    }
            set 
		    {
			    SetColumnValue("MoneyStyle", value);
            }
        }
	      
        [XmlAttribute("UseDepartName")]
        [Bindable(true)]
        public string UseDepartName 
	    {
		    get
		    {
			    return GetColumnValue<string>("UseDepartName");
		    }
            set 
		    {
			    SetColumnValue("UseDepartName", value);
            }
        }
	      
        [XmlAttribute("FuTime")]
        [Bindable(true)]
        public string FuTime 
	    {
		    get
		    {
			    return GetColumnValue<string>("FuTime");
		    }
            set 
		    {
			    SetColumnValue("FuTime", value);
            }
        }
	      
        [XmlAttribute("ApplyName")]
        [Bindable(true)]
        public string ApplyName 
	    {
		    get
		    {
			    return GetColumnValue<string>("ApplyName");
		    }
            set 
		    {
			    SetColumnValue("ApplyName", value);
            }
        }
	      
        [XmlAttribute("State")]
        [Bindable(true)]
        public int? State 
	    {
		    get
		    {
			    return GetColumnValue<int?>("State");
		    }
            set 
		    {
			    SetColumnValue("State", value);
            }
        }
	      
        [XmlAttribute("ApplyTime")]
        [Bindable(true)]
        public string ApplyTime 
	    {
		    get
		    {
			    return GetColumnValue<string>("ApplyTime");
		    }
            set 
		    {
			    SetColumnValue("ApplyTime", value);
            }
        }
	      
        [XmlAttribute("DepartView")]
        [Bindable(true)]
        public string DepartView 
	    {
		    get
		    {
			    return GetColumnValue<string>("DepartView");
		    }
            set 
		    {
			    SetColumnValue("DepartView", value);
            }
        }
	      
        [XmlAttribute("ManagerView")]
        [Bindable(true)]
        public string ManagerView 
	    {
		    get
		    {
			    return GetColumnValue<string>("ManagerView");
		    }
            set 
		    {
			    SetColumnValue("ManagerView", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string WorkToolSumId = @"WorkToolSumId";
            
            public static string DepartName = @"DepartName";
            
            public static string Reason = @"Reason";
            
            public static string BigMoney = @"BigMoney";
            
            public static string SmaMoney = @"SmaMoney";
            
            public static string MoneyStyle = @"MoneyStyle";
            
            public static string UseDepartName = @"UseDepartName";
            
            public static string FuTime = @"FuTime";
            
            public static string ApplyName = @"ApplyName";
            
            public static string State = @"State";
            
            public static string ApplyTime = @"ApplyTime";
            
            public static string DepartView = @"DepartView";
            
            public static string ManagerView = @"ManagerView";
            
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
