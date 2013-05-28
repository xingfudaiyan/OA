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
    /// Strongly-typed collection for the Vw_OutRegistAll class.
    /// </summary>
    [Serializable]
    public partial class Vw_OutRegistAllCollection : ReadOnlyList<Vw_OutRegistAll, Vw_OutRegistAllCollection>
    {        
        public Vw_OutRegistAllCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the vw_OutRegistAll view.
    /// </summary>
    [Serializable]
    public partial class Vw_OutRegistAll : ReadOnlyRecord<Vw_OutRegistAll>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("vw_OutRegistAll", TableType.View, DataService.GetInstance("SubsonicProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarOutRegistId = new TableSchema.TableColumn(schema);
                colvarOutRegistId.ColumnName = "OutRegistId";
                colvarOutRegistId.DataType = DbType.Int32;
                colvarOutRegistId.MaxLength = 0;
                colvarOutRegistId.AutoIncrement = false;
                colvarOutRegistId.IsNullable = false;
                colvarOutRegistId.IsPrimaryKey = false;
                colvarOutRegistId.IsForeignKey = false;
                colvarOutRegistId.IsReadOnly = false;
                
                schema.Columns.Add(colvarOutRegistId);
                
                TableSchema.TableColumn colvarOutDate = new TableSchema.TableColumn(schema);
                colvarOutDate.ColumnName = "OutDate";
                colvarOutDate.DataType = DbType.String;
                colvarOutDate.MaxLength = 50;
                colvarOutDate.AutoIncrement = false;
                colvarOutDate.IsNullable = true;
                colvarOutDate.IsPrimaryKey = false;
                colvarOutDate.IsForeignKey = false;
                colvarOutDate.IsReadOnly = false;
                
                schema.Columns.Add(colvarOutDate);
                
                TableSchema.TableColumn colvarOutTime = new TableSchema.TableColumn(schema);
                colvarOutTime.ColumnName = "OutTime";
                colvarOutTime.DataType = DbType.String;
                colvarOutTime.MaxLength = 50;
                colvarOutTime.AutoIncrement = false;
                colvarOutTime.IsNullable = true;
                colvarOutTime.IsPrimaryKey = false;
                colvarOutTime.IsForeignKey = false;
                colvarOutTime.IsReadOnly = false;
                
                schema.Columns.Add(colvarOutTime);
                
                TableSchema.TableColumn colvarOutContent = new TableSchema.TableColumn(schema);
                colvarOutContent.ColumnName = "OutContent";
                colvarOutContent.DataType = DbType.String;
                colvarOutContent.MaxLength = -1;
                colvarOutContent.AutoIncrement = false;
                colvarOutContent.IsNullable = true;
                colvarOutContent.IsPrimaryKey = false;
                colvarOutContent.IsForeignKey = false;
                colvarOutContent.IsReadOnly = false;
                
                schema.Columns.Add(colvarOutContent);
                
                TableSchema.TableColumn colvarBackTime = new TableSchema.TableColumn(schema);
                colvarBackTime.ColumnName = "BackTime";
                colvarBackTime.DataType = DbType.String;
                colvarBackTime.MaxLength = 50;
                colvarBackTime.AutoIncrement = false;
                colvarBackTime.IsNullable = true;
                colvarBackTime.IsPrimaryKey = false;
                colvarBackTime.IsForeignKey = false;
                colvarBackTime.IsReadOnly = false;
                
                schema.Columns.Add(colvarBackTime);
                
                TableSchema.TableColumn colvarOutTool = new TableSchema.TableColumn(schema);
                colvarOutTool.ColumnName = "OutTool";
                colvarOutTool.DataType = DbType.String;
                colvarOutTool.MaxLength = 50;
                colvarOutTool.AutoIncrement = false;
                colvarOutTool.IsNullable = true;
                colvarOutTool.IsPrimaryKey = false;
                colvarOutTool.IsForeignKey = false;
                colvarOutTool.IsReadOnly = false;
                
                schema.Columns.Add(colvarOutTool);
                
                TableSchema.TableColumn colvarMemo = new TableSchema.TableColumn(schema);
                colvarMemo.ColumnName = "Memo";
                colvarMemo.DataType = DbType.String;
                colvarMemo.MaxLength = -1;
                colvarMemo.AutoIncrement = false;
                colvarMemo.IsNullable = true;
                colvarMemo.IsPrimaryKey = false;
                colvarMemo.IsForeignKey = false;
                colvarMemo.IsReadOnly = false;
                
                schema.Columns.Add(colvarMemo);
                
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
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["SubsonicProvider"].AddSchema("vw_OutRegistAll",schema);
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
	    public Vw_OutRegistAll()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public Vw_OutRegistAll(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public Vw_OutRegistAll(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public Vw_OutRegistAll(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("OutRegistId")]
        [Bindable(true)]
        public int OutRegistId 
	    {
		    get
		    {
			    return GetColumnValue<int>("OutRegistId");
		    }
            set 
		    {
			    SetColumnValue("OutRegistId", value);
            }
        }
	      
        [XmlAttribute("OutDate")]
        [Bindable(true)]
        public string OutDate 
	    {
		    get
		    {
			    return GetColumnValue<string>("OutDate");
		    }
            set 
		    {
			    SetColumnValue("OutDate", value);
            }
        }
	      
        [XmlAttribute("OutTime")]
        [Bindable(true)]
        public string OutTime 
	    {
		    get
		    {
			    return GetColumnValue<string>("OutTime");
		    }
            set 
		    {
			    SetColumnValue("OutTime", value);
            }
        }
	      
        [XmlAttribute("OutContent")]
        [Bindable(true)]
        public string OutContent 
	    {
		    get
		    {
			    return GetColumnValue<string>("OutContent");
		    }
            set 
		    {
			    SetColumnValue("OutContent", value);
            }
        }
	      
        [XmlAttribute("BackTime")]
        [Bindable(true)]
        public string BackTime 
	    {
		    get
		    {
			    return GetColumnValue<string>("BackTime");
		    }
            set 
		    {
			    SetColumnValue("BackTime", value);
            }
        }
	      
        [XmlAttribute("OutTool")]
        [Bindable(true)]
        public string OutTool 
	    {
		    get
		    {
			    return GetColumnValue<string>("OutTool");
		    }
            set 
		    {
			    SetColumnValue("OutTool", value);
            }
        }
	      
        [XmlAttribute("Memo")]
        [Bindable(true)]
        public string Memo 
	    {
		    get
		    {
			    return GetColumnValue<string>("Memo");
		    }
            set 
		    {
			    SetColumnValue("Memo", value);
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
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string OutRegistId = @"OutRegistId";
            
            public static string OutDate = @"OutDate";
            
            public static string OutTime = @"OutTime";
            
            public static string OutContent = @"OutContent";
            
            public static string BackTime = @"BackTime";
            
            public static string OutTool = @"OutTool";
            
            public static string Memo = @"Memo";
            
            public static string ApplyName = @"ApplyName";
            
            public static string DepartName = @"DepartName";
            
            public static string State = @"State";
            
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
