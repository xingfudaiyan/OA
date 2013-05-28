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
    /// Strongly-typed collection for the Vw_EmployeeInfo class.
    /// </summary>
    [Serializable]
    public partial class Vw_EmployeeInfoCollection : ReadOnlyList<Vw_EmployeeInfo, Vw_EmployeeInfoCollection>
    {        
        public Vw_EmployeeInfoCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the vw_EmployeeInfo view.
    /// </summary>
    [Serializable]
    public partial class Vw_EmployeeInfo : ReadOnlyRecord<Vw_EmployeeInfo>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("vw_EmployeeInfo", TableType.View, DataService.GetInstance("SubsonicProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
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
                
                TableSchema.TableColumn colvarEmployeeName = new TableSchema.TableColumn(schema);
                colvarEmployeeName.ColumnName = "EmployeeName";
                colvarEmployeeName.DataType = DbType.String;
                colvarEmployeeName.MaxLength = 50;
                colvarEmployeeName.AutoIncrement = false;
                colvarEmployeeName.IsNullable = false;
                colvarEmployeeName.IsPrimaryKey = false;
                colvarEmployeeName.IsForeignKey = false;
                colvarEmployeeName.IsReadOnly = false;
                
                schema.Columns.Add(colvarEmployeeName);
                
                TableSchema.TableColumn colvarSex = new TableSchema.TableColumn(schema);
                colvarSex.ColumnName = "Sex";
                colvarSex.DataType = DbType.Int32;
                colvarSex.MaxLength = 0;
                colvarSex.AutoIncrement = false;
                colvarSex.IsNullable = false;
                colvarSex.IsPrimaryKey = false;
                colvarSex.IsForeignKey = false;
                colvarSex.IsReadOnly = false;
                
                schema.Columns.Add(colvarSex);
                
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
                
                TableSchema.TableColumn colvarPositionName = new TableSchema.TableColumn(schema);
                colvarPositionName.ColumnName = "PositionName";
                colvarPositionName.DataType = DbType.String;
                colvarPositionName.MaxLength = 50;
                colvarPositionName.AutoIncrement = false;
                colvarPositionName.IsNullable = true;
                colvarPositionName.IsPrimaryKey = false;
                colvarPositionName.IsForeignKey = false;
                colvarPositionName.IsReadOnly = false;
                
                schema.Columns.Add(colvarPositionName);
                
                TableSchema.TableColumn colvarDepartName = new TableSchema.TableColumn(schema);
                colvarDepartName.ColumnName = "DepartName";
                colvarDepartName.DataType = DbType.String;
                colvarDepartName.MaxLength = 50;
                colvarDepartName.AutoIncrement = false;
                colvarDepartName.IsNullable = false;
                colvarDepartName.IsPrimaryKey = false;
                colvarDepartName.IsForeignKey = false;
                colvarDepartName.IsReadOnly = false;
                
                schema.Columns.Add(colvarDepartName);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["SubsonicProvider"].AddSchema("vw_EmployeeInfo",schema);
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
	    public Vw_EmployeeInfo()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public Vw_EmployeeInfo(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public Vw_EmployeeInfo(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public Vw_EmployeeInfo(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
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
	      
        [XmlAttribute("EmployeeName")]
        [Bindable(true)]
        public string EmployeeName 
	    {
		    get
		    {
			    return GetColumnValue<string>("EmployeeName");
		    }
            set 
		    {
			    SetColumnValue("EmployeeName", value);
            }
        }
	      
        [XmlAttribute("Sex")]
        [Bindable(true)]
        public int Sex 
	    {
		    get
		    {
			    return GetColumnValue<int>("Sex");
		    }
            set 
		    {
			    SetColumnValue("Sex", value);
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
	      
        [XmlAttribute("PositionName")]
        [Bindable(true)]
        public string PositionName 
	    {
		    get
		    {
			    return GetColumnValue<string>("PositionName");
		    }
            set 
		    {
			    SetColumnValue("PositionName", value);
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
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string EmployeeId = @"EmployeeId";
            
            public static string EmployeeName = @"EmployeeName";
            
            public static string Sex = @"Sex";
            
            public static string State = @"State";
            
            public static string PositionName = @"PositionName";
            
            public static string DepartName = @"DepartName";
            
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
