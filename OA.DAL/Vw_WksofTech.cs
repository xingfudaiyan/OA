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
    /// Strongly-typed collection for the Vw_WksofTech class.
    /// </summary>
    [Serializable]
    public partial class Vw_WksofTechCollection : ReadOnlyList<Vw_WksofTech, Vw_WksofTechCollection>
    {        
        public Vw_WksofTechCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the vw_WksofTech view.
    /// </summary>
    [Serializable]
    public partial class Vw_WksofTech : ReadOnlyRecord<Vw_WksofTech>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("vw_WksofTech", TableType.View, DataService.GetInstance("SubsonicProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarWeekScoreId = new TableSchema.TableColumn(schema);
                colvarWeekScoreId.ColumnName = "WeekScoreId";
                colvarWeekScoreId.DataType = DbType.Int32;
                colvarWeekScoreId.MaxLength = 0;
                colvarWeekScoreId.AutoIncrement = false;
                colvarWeekScoreId.IsNullable = false;
                colvarWeekScoreId.IsPrimaryKey = false;
                colvarWeekScoreId.IsForeignKey = false;
                colvarWeekScoreId.IsReadOnly = false;
                
                schema.Columns.Add(colvarWeekScoreId);
                
                TableSchema.TableColumn colvarWeekScoreNum = new TableSchema.TableColumn(schema);
                colvarWeekScoreNum.ColumnName = "WeekScoreNum";
                colvarWeekScoreNum.DataType = DbType.String;
                colvarWeekScoreNum.MaxLength = 50;
                colvarWeekScoreNum.AutoIncrement = false;
                colvarWeekScoreNum.IsNullable = true;
                colvarWeekScoreNum.IsPrimaryKey = false;
                colvarWeekScoreNum.IsForeignKey = false;
                colvarWeekScoreNum.IsReadOnly = false;
                
                schema.Columns.Add(colvarWeekScoreNum);
                
                TableSchema.TableColumn colvarIsSubmit = new TableSchema.TableColumn(schema);
                colvarIsSubmit.ColumnName = "IsSubmit";
                colvarIsSubmit.DataType = DbType.Int32;
                colvarIsSubmit.MaxLength = 0;
                colvarIsSubmit.AutoIncrement = false;
                colvarIsSubmit.IsNullable = true;
                colvarIsSubmit.IsPrimaryKey = false;
                colvarIsSubmit.IsForeignKey = false;
                colvarIsSubmit.IsReadOnly = false;
                
                schema.Columns.Add(colvarIsSubmit);
                
                TableSchema.TableColumn colvarEmployeeId = new TableSchema.TableColumn(schema);
                colvarEmployeeId.ColumnName = "EmployeeId";
                colvarEmployeeId.DataType = DbType.Int32;
                colvarEmployeeId.MaxLength = 0;
                colvarEmployeeId.AutoIncrement = false;
                colvarEmployeeId.IsNullable = true;
                colvarEmployeeId.IsPrimaryKey = false;
                colvarEmployeeId.IsForeignKey = false;
                colvarEmployeeId.IsReadOnly = false;
                
                schema.Columns.Add(colvarEmployeeId);
                
                TableSchema.TableColumn colvarTotalScore = new TableSchema.TableColumn(schema);
                colvarTotalScore.ColumnName = "TotalScore";
                colvarTotalScore.DataType = DbType.String;
                colvarTotalScore.MaxLength = 50;
                colvarTotalScore.AutoIncrement = false;
                colvarTotalScore.IsNullable = true;
                colvarTotalScore.IsPrimaryKey = false;
                colvarTotalScore.IsForeignKey = false;
                colvarTotalScore.IsReadOnly = false;
                
                schema.Columns.Add(colvarTotalScore);
                
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
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["SubsonicProvider"].AddSchema("vw_WksofTech",schema);
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
	    public Vw_WksofTech()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public Vw_WksofTech(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public Vw_WksofTech(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public Vw_WksofTech(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("WeekScoreId")]
        [Bindable(true)]
        public int WeekScoreId 
	    {
		    get
		    {
			    return GetColumnValue<int>("WeekScoreId");
		    }
            set 
		    {
			    SetColumnValue("WeekScoreId", value);
            }
        }
	      
        [XmlAttribute("WeekScoreNum")]
        [Bindable(true)]
        public string WeekScoreNum 
	    {
		    get
		    {
			    return GetColumnValue<string>("WeekScoreNum");
		    }
            set 
		    {
			    SetColumnValue("WeekScoreNum", value);
            }
        }
	      
        [XmlAttribute("IsSubmit")]
        [Bindable(true)]
        public int? IsSubmit 
	    {
		    get
		    {
			    return GetColumnValue<int?>("IsSubmit");
		    }
            set 
		    {
			    SetColumnValue("IsSubmit", value);
            }
        }
	      
        [XmlAttribute("EmployeeId")]
        [Bindable(true)]
        public int? EmployeeId 
	    {
		    get
		    {
			    return GetColumnValue<int?>("EmployeeId");
		    }
            set 
		    {
			    SetColumnValue("EmployeeId", value);
            }
        }
	      
        [XmlAttribute("TotalScore")]
        [Bindable(true)]
        public string TotalScore 
	    {
		    get
		    {
			    return GetColumnValue<string>("TotalScore");
		    }
            set 
		    {
			    SetColumnValue("TotalScore", value);
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
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string WeekScoreId = @"WeekScoreId";
            
            public static string WeekScoreNum = @"WeekScoreNum";
            
            public static string IsSubmit = @"IsSubmit";
            
            public static string EmployeeId = @"EmployeeId";
            
            public static string TotalScore = @"TotalScore";
            
            public static string EmployeeName = @"EmployeeName";
            
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
