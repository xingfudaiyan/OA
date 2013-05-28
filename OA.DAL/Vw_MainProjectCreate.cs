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
    /// Strongly-typed collection for the Vw_MainProjectCreate class.
    /// </summary>
    [Serializable]
    public partial class Vw_MainProjectCreateCollection : ReadOnlyList<Vw_MainProjectCreate, Vw_MainProjectCreateCollection>
    {        
        public Vw_MainProjectCreateCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the vw_MainProjectCreate view.
    /// </summary>
    [Serializable]
    public partial class Vw_MainProjectCreate : ReadOnlyRecord<Vw_MainProjectCreate>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("vw_MainProjectCreate", TableType.View, DataService.GetInstance("SubsonicProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarMainProjectCreateId = new TableSchema.TableColumn(schema);
                colvarMainProjectCreateId.ColumnName = "MainProjectCreateId";
                colvarMainProjectCreateId.DataType = DbType.Int32;
                colvarMainProjectCreateId.MaxLength = 0;
                colvarMainProjectCreateId.AutoIncrement = false;
                colvarMainProjectCreateId.IsNullable = false;
                colvarMainProjectCreateId.IsPrimaryKey = false;
                colvarMainProjectCreateId.IsForeignKey = false;
                colvarMainProjectCreateId.IsReadOnly = false;
                
                schema.Columns.Add(colvarMainProjectCreateId);
                
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
                
                TableSchema.TableColumn colvarProjectName = new TableSchema.TableColumn(schema);
                colvarProjectName.ColumnName = "ProjectName";
                colvarProjectName.DataType = DbType.String;
                colvarProjectName.MaxLength = 50;
                colvarProjectName.AutoIncrement = false;
                colvarProjectName.IsNullable = true;
                colvarProjectName.IsPrimaryKey = false;
                colvarProjectName.IsForeignKey = false;
                colvarProjectName.IsReadOnly = false;
                
                schema.Columns.Add(colvarProjectName);
                
                TableSchema.TableColumn colvarPreMoney = new TableSchema.TableColumn(schema);
                colvarPreMoney.ColumnName = "PreMoney";
                colvarPreMoney.DataType = DbType.String;
                colvarPreMoney.MaxLength = 50;
                colvarPreMoney.AutoIncrement = false;
                colvarPreMoney.IsNullable = true;
                colvarPreMoney.IsPrimaryKey = false;
                colvarPreMoney.IsForeignKey = false;
                colvarPreMoney.IsReadOnly = false;
                
                schema.Columns.Add(colvarPreMoney);
                
                TableSchema.TableColumn colvarPreProfit = new TableSchema.TableColumn(schema);
                colvarPreProfit.ColumnName = "PreProfit";
                colvarPreProfit.DataType = DbType.String;
                colvarPreProfit.MaxLength = 50;
                colvarPreProfit.AutoIncrement = false;
                colvarPreProfit.IsNullable = true;
                colvarPreProfit.IsPrimaryKey = false;
                colvarPreProfit.IsForeignKey = false;
                colvarPreProfit.IsReadOnly = false;
                
                schema.Columns.Add(colvarPreProfit);
                
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
                
                TableSchema.TableColumn colvarProjectLevelName = new TableSchema.TableColumn(schema);
                colvarProjectLevelName.ColumnName = "ProjectLevelName";
                colvarProjectLevelName.DataType = DbType.String;
                colvarProjectLevelName.MaxLength = 50;
                colvarProjectLevelName.AutoIncrement = false;
                colvarProjectLevelName.IsNullable = true;
                colvarProjectLevelName.IsPrimaryKey = false;
                colvarProjectLevelName.IsForeignKey = false;
                colvarProjectLevelName.IsReadOnly = false;
                
                schema.Columns.Add(colvarProjectLevelName);
                
                TableSchema.TableColumn colvarProjectTypeName = new TableSchema.TableColumn(schema);
                colvarProjectTypeName.ColumnName = "ProjectTypeName";
                colvarProjectTypeName.DataType = DbType.String;
                colvarProjectTypeName.MaxLength = 50;
                colvarProjectTypeName.AutoIncrement = false;
                colvarProjectTypeName.IsNullable = true;
                colvarProjectTypeName.IsPrimaryKey = false;
                colvarProjectTypeName.IsForeignKey = false;
                colvarProjectTypeName.IsReadOnly = false;
                
                schema.Columns.Add(colvarProjectTypeName);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["SubsonicProvider"].AddSchema("vw_MainProjectCreate",schema);
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
	    public Vw_MainProjectCreate()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public Vw_MainProjectCreate(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public Vw_MainProjectCreate(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public Vw_MainProjectCreate(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("MainProjectCreateId")]
        [Bindable(true)]
        public int MainProjectCreateId 
	    {
		    get
		    {
			    return GetColumnValue<int>("MainProjectCreateId");
		    }
            set 
		    {
			    SetColumnValue("MainProjectCreateId", value);
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
	      
        [XmlAttribute("ProjectName")]
        [Bindable(true)]
        public string ProjectName 
	    {
		    get
		    {
			    return GetColumnValue<string>("ProjectName");
		    }
            set 
		    {
			    SetColumnValue("ProjectName", value);
            }
        }
	      
        [XmlAttribute("PreMoney")]
        [Bindable(true)]
        public string PreMoney 
	    {
		    get
		    {
			    return GetColumnValue<string>("PreMoney");
		    }
            set 
		    {
			    SetColumnValue("PreMoney", value);
            }
        }
	      
        [XmlAttribute("PreProfit")]
        [Bindable(true)]
        public string PreProfit 
	    {
		    get
		    {
			    return GetColumnValue<string>("PreProfit");
		    }
            set 
		    {
			    SetColumnValue("PreProfit", value);
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
	      
        [XmlAttribute("ProjectLevelName")]
        [Bindable(true)]
        public string ProjectLevelName 
	    {
		    get
		    {
			    return GetColumnValue<string>("ProjectLevelName");
		    }
            set 
		    {
			    SetColumnValue("ProjectLevelName", value);
            }
        }
	      
        [XmlAttribute("ProjectTypeName")]
        [Bindable(true)]
        public string ProjectTypeName 
	    {
		    get
		    {
			    return GetColumnValue<string>("ProjectTypeName");
		    }
            set 
		    {
			    SetColumnValue("ProjectTypeName", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string MainProjectCreateId = @"MainProjectCreateId";
            
            public static string SheetNum = @"SheetNum";
            
            public static string ProjectName = @"ProjectName";
            
            public static string PreMoney = @"PreMoney";
            
            public static string PreProfit = @"PreProfit";
            
            public static string ClientName = @"ClientName";
            
            public static string ProjectLevelName = @"ProjectLevelName";
            
            public static string ProjectTypeName = @"ProjectTypeName";
            
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
