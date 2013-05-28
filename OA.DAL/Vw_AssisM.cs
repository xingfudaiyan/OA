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
    /// Strongly-typed collection for the Vw_AssisM class.
    /// </summary>
    [Serializable]
    public partial class Vw_AssisMCollection : ReadOnlyList<Vw_AssisM, Vw_AssisMCollection>
    {        
        public Vw_AssisMCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the vw_AssisM view.
    /// </summary>
    [Serializable]
    public partial class Vw_AssisM : ReadOnlyRecord<Vw_AssisM>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("vw_AssisM", TableType.View, DataService.GetInstance("SubsonicProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarAssistantScoreId = new TableSchema.TableColumn(schema);
                colvarAssistantScoreId.ColumnName = "AssistantScoreId";
                colvarAssistantScoreId.DataType = DbType.Int32;
                colvarAssistantScoreId.MaxLength = 0;
                colvarAssistantScoreId.AutoIncrement = false;
                colvarAssistantScoreId.IsNullable = false;
                colvarAssistantScoreId.IsPrimaryKey = false;
                colvarAssistantScoreId.IsForeignKey = false;
                colvarAssistantScoreId.IsReadOnly = false;
                
                schema.Columns.Add(colvarAssistantScoreId);
                
                TableSchema.TableColumn colvarDateSpan = new TableSchema.TableColumn(schema);
                colvarDateSpan.ColumnName = "DateSpan";
                colvarDateSpan.DataType = DbType.String;
                colvarDateSpan.MaxLength = 10;
                colvarDateSpan.AutoIncrement = false;
                colvarDateSpan.IsNullable = true;
                colvarDateSpan.IsPrimaryKey = false;
                colvarDateSpan.IsForeignKey = false;
                colvarDateSpan.IsReadOnly = false;
                
                schema.Columns.Add(colvarDateSpan);
                
                TableSchema.TableColumn colvarTotalScore = new TableSchema.TableColumn(schema);
                colvarTotalScore.ColumnName = "TotalScore";
                colvarTotalScore.DataType = DbType.String;
                colvarTotalScore.MaxLength = 10;
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
                
                TableSchema.TableColumn colvarEvaluateName = new TableSchema.TableColumn(schema);
                colvarEvaluateName.ColumnName = "EvaluateName";
                colvarEvaluateName.DataType = DbType.String;
                colvarEvaluateName.MaxLength = 15;
                colvarEvaluateName.AutoIncrement = false;
                colvarEvaluateName.IsNullable = true;
                colvarEvaluateName.IsPrimaryKey = false;
                colvarEvaluateName.IsForeignKey = false;
                colvarEvaluateName.IsReadOnly = false;
                
                schema.Columns.Add(colvarEvaluateName);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["SubsonicProvider"].AddSchema("vw_AssisM",schema);
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
	    public Vw_AssisM()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public Vw_AssisM(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public Vw_AssisM(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public Vw_AssisM(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("AssistantScoreId")]
        [Bindable(true)]
        public int AssistantScoreId 
	    {
		    get
		    {
			    return GetColumnValue<int>("AssistantScoreId");
		    }
            set 
		    {
			    SetColumnValue("AssistantScoreId", value);
            }
        }
	      
        [XmlAttribute("DateSpan")]
        [Bindable(true)]
        public string DateSpan 
	    {
		    get
		    {
			    return GetColumnValue<string>("DateSpan");
		    }
            set 
		    {
			    SetColumnValue("DateSpan", value);
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
	      
        [XmlAttribute("EvaluateName")]
        [Bindable(true)]
        public string EvaluateName 
	    {
		    get
		    {
			    return GetColumnValue<string>("EvaluateName");
		    }
            set 
		    {
			    SetColumnValue("EvaluateName", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string AssistantScoreId = @"AssistantScoreId";
            
            public static string DateSpan = @"DateSpan";
            
            public static string TotalScore = @"TotalScore";
            
            public static string EmployeeName = @"EmployeeName";
            
            public static string EvaluateName = @"EvaluateName";
            
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
