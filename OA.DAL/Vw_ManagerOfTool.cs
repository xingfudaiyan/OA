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
    /// Strongly-typed collection for the Vw_ManagerOfTool class.
    /// </summary>
    [Serializable]
    public partial class Vw_ManagerOfToolCollection : ReadOnlyList<Vw_ManagerOfTool, Vw_ManagerOfToolCollection>
    {        
        public Vw_ManagerOfToolCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the vw_ManagerOfTool view.
    /// </summary>
    [Serializable]
    public partial class Vw_ManagerOfTool : ReadOnlyRecord<Vw_ManagerOfTool>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("vw_ManagerOfTool", TableType.View, DataService.GetInstance("SubsonicProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarToolId = new TableSchema.TableColumn(schema);
                colvarToolId.ColumnName = "ToolId";
                colvarToolId.DataType = DbType.Int32;
                colvarToolId.MaxLength = 0;
                colvarToolId.AutoIncrement = false;
                colvarToolId.IsNullable = false;
                colvarToolId.IsPrimaryKey = false;
                colvarToolId.IsForeignKey = false;
                colvarToolId.IsReadOnly = false;
                
                schema.Columns.Add(colvarToolId);
                
                TableSchema.TableColumn colvarToolNumId = new TableSchema.TableColumn(schema);
                colvarToolNumId.ColumnName = "ToolNumId";
                colvarToolNumId.DataType = DbType.Int32;
                colvarToolNumId.MaxLength = 0;
                colvarToolNumId.AutoIncrement = false;
                colvarToolNumId.IsNullable = true;
                colvarToolNumId.IsPrimaryKey = false;
                colvarToolNumId.IsForeignKey = false;
                colvarToolNumId.IsReadOnly = false;
                
                schema.Columns.Add(colvarToolNumId);
                
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
                
                TableSchema.TableColumn colvarTechMemo = new TableSchema.TableColumn(schema);
                colvarTechMemo.ColumnName = "TechMemo";
                colvarTechMemo.DataType = DbType.String;
                colvarTechMemo.MaxLength = 50;
                colvarTechMemo.AutoIncrement = false;
                colvarTechMemo.IsNullable = true;
                colvarTechMemo.IsPrimaryKey = false;
                colvarTechMemo.IsForeignKey = false;
                colvarTechMemo.IsReadOnly = false;
                
                schema.Columns.Add(colvarTechMemo);
                
                TableSchema.TableColumn colvarMarketMemo = new TableSchema.TableColumn(schema);
                colvarMarketMemo.ColumnName = "MarketMemo";
                colvarMarketMemo.DataType = DbType.String;
                colvarMarketMemo.MaxLength = 50;
                colvarMarketMemo.AutoIncrement = false;
                colvarMarketMemo.IsNullable = true;
                colvarMarketMemo.IsPrimaryKey = false;
                colvarMarketMemo.IsForeignKey = false;
                colvarMarketMemo.IsReadOnly = false;
                
                schema.Columns.Add(colvarMarketMemo);
                
                TableSchema.TableColumn colvarZongHeMemo = new TableSchema.TableColumn(schema);
                colvarZongHeMemo.ColumnName = "ZongHeMemo";
                colvarZongHeMemo.DataType = DbType.String;
                colvarZongHeMemo.MaxLength = 50;
                colvarZongHeMemo.AutoIncrement = false;
                colvarZongHeMemo.IsNullable = true;
                colvarZongHeMemo.IsPrimaryKey = false;
                colvarZongHeMemo.IsForeignKey = false;
                colvarZongHeMemo.IsReadOnly = false;
                
                schema.Columns.Add(colvarZongHeMemo);
                
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
                DataService.Providers["SubsonicProvider"].AddSchema("vw_ManagerOfTool",schema);
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
	    public Vw_ManagerOfTool()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public Vw_ManagerOfTool(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public Vw_ManagerOfTool(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public Vw_ManagerOfTool(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("ToolId")]
        [Bindable(true)]
        public int ToolId 
	    {
		    get
		    {
			    return GetColumnValue<int>("ToolId");
		    }
            set 
		    {
			    SetColumnValue("ToolId", value);
            }
        }
	      
        [XmlAttribute("ToolNumId")]
        [Bindable(true)]
        public int? ToolNumId 
	    {
		    get
		    {
			    return GetColumnValue<int?>("ToolNumId");
		    }
            set 
		    {
			    SetColumnValue("ToolNumId", value);
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
	      
        [XmlAttribute("TechMemo")]
        [Bindable(true)]
        public string TechMemo 
	    {
		    get
		    {
			    return GetColumnValue<string>("TechMemo");
		    }
            set 
		    {
			    SetColumnValue("TechMemo", value);
            }
        }
	      
        [XmlAttribute("MarketMemo")]
        [Bindable(true)]
        public string MarketMemo 
	    {
		    get
		    {
			    return GetColumnValue<string>("MarketMemo");
		    }
            set 
		    {
			    SetColumnValue("MarketMemo", value);
            }
        }
	      
        [XmlAttribute("ZongHeMemo")]
        [Bindable(true)]
        public string ZongHeMemo 
	    {
		    get
		    {
			    return GetColumnValue<string>("ZongHeMemo");
		    }
            set 
		    {
			    SetColumnValue("ZongHeMemo", value);
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
		    
		    
            public static string ToolId = @"ToolId";
            
            public static string ToolNumId = @"ToolNumId";
            
            public static string ApplyTime = @"ApplyTime";
            
            public static string DepartName = @"DepartName";
            
            public static string ApplyName = @"ApplyName";
            
            public static string State = @"State";
            
            public static string TechMemo = @"TechMemo";
            
            public static string MarketMemo = @"MarketMemo";
            
            public static string ZongHeMemo = @"ZongHeMemo";
            
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
