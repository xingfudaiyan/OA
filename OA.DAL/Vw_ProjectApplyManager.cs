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
    /// Strongly-typed collection for the Vw_ProjectApplyManager class.
    /// </summary>
    [Serializable]
    public partial class Vw_ProjectApplyManagerCollection : ReadOnlyList<Vw_ProjectApplyManager, Vw_ProjectApplyManagerCollection>
    {        
        public Vw_ProjectApplyManagerCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the vw_ProjectApplyManager view.
    /// </summary>
    [Serializable]
    public partial class Vw_ProjectApplyManager : ReadOnlyRecord<Vw_ProjectApplyManager>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("vw_ProjectApplyManager", TableType.View, DataService.GetInstance("SubsonicProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarProjectCreateId = new TableSchema.TableColumn(schema);
                colvarProjectCreateId.ColumnName = "ProjectCreateId";
                colvarProjectCreateId.DataType = DbType.Int32;
                colvarProjectCreateId.MaxLength = 0;
                colvarProjectCreateId.AutoIncrement = false;
                colvarProjectCreateId.IsNullable = false;
                colvarProjectCreateId.IsPrimaryKey = false;
                colvarProjectCreateId.IsForeignKey = false;
                colvarProjectCreateId.IsReadOnly = false;
                
                schema.Columns.Add(colvarProjectCreateId);
                
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
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["SubsonicProvider"].AddSchema("vw_ProjectApplyManager",schema);
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
	    public Vw_ProjectApplyManager()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public Vw_ProjectApplyManager(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public Vw_ProjectApplyManager(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public Vw_ProjectApplyManager(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("ProjectCreateId")]
        [Bindable(true)]
        public int ProjectCreateId 
	    {
		    get
		    {
			    return GetColumnValue<int>("ProjectCreateId");
		    }
            set 
		    {
			    SetColumnValue("ProjectCreateId", value);
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
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string ProjectCreateId = @"ProjectCreateId";
            
            public static string ProjectName = @"ProjectName";
            
            public static string SheetNum = @"SheetNum";
            
            public static string ApplyName = @"ApplyName";
            
            public static string DepartName = @"DepartName";
            
            public static string State = @"State";
            
            public static string ApplyTime = @"ApplyTime";
            
            public static string ClientName = @"ClientName";
            
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
