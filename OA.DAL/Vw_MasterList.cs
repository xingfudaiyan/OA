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
    /// Strongly-typed collection for the Vw_MasterList class.
    /// </summary>
    [Serializable]
    public partial class Vw_MasterListCollection : ReadOnlyList<Vw_MasterList, Vw_MasterListCollection>
    {        
        public Vw_MasterListCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the vw_MasterList view.
    /// </summary>
    [Serializable]
    public partial class Vw_MasterList : ReadOnlyRecord<Vw_MasterList>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("vw_MasterList", TableType.View, DataService.GetInstance("SubsonicProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarMasterId = new TableSchema.TableColumn(schema);
                colvarMasterId.ColumnName = "MasterId";
                colvarMasterId.DataType = DbType.Int32;
                colvarMasterId.MaxLength = 0;
                colvarMasterId.AutoIncrement = false;
                colvarMasterId.IsNullable = false;
                colvarMasterId.IsPrimaryKey = false;
                colvarMasterId.IsForeignKey = false;
                colvarMasterId.IsReadOnly = false;
                
                schema.Columns.Add(colvarMasterId);
                
                TableSchema.TableColumn colvarMasterName = new TableSchema.TableColumn(schema);
                colvarMasterName.ColumnName = "MasterName";
                colvarMasterName.DataType = DbType.String;
                colvarMasterName.MaxLength = 50;
                colvarMasterName.AutoIncrement = false;
                colvarMasterName.IsNullable = false;
                colvarMasterName.IsPrimaryKey = false;
                colvarMasterName.IsForeignKey = false;
                colvarMasterName.IsReadOnly = false;
                
                schema.Columns.Add(colvarMasterName);
                
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
                
                TableSchema.TableColumn colvarCreateDate = new TableSchema.TableColumn(schema);
                colvarCreateDate.ColumnName = "CreateDate";
                colvarCreateDate.DataType = DbType.DateTime;
                colvarCreateDate.MaxLength = 0;
                colvarCreateDate.AutoIncrement = false;
                colvarCreateDate.IsNullable = true;
                colvarCreateDate.IsPrimaryKey = false;
                colvarCreateDate.IsForeignKey = false;
                colvarCreateDate.IsReadOnly = false;
                
                schema.Columns.Add(colvarCreateDate);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["SubsonicProvider"].AddSchema("vw_MasterList",schema);
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
	    public Vw_MasterList()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public Vw_MasterList(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public Vw_MasterList(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public Vw_MasterList(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("MasterId")]
        [Bindable(true)]
        public int MasterId 
	    {
		    get
		    {
			    return GetColumnValue<int>("MasterId");
		    }
            set 
		    {
			    SetColumnValue("MasterId", value);
            }
        }
	      
        [XmlAttribute("MasterName")]
        [Bindable(true)]
        public string MasterName 
	    {
		    get
		    {
			    return GetColumnValue<string>("MasterName");
		    }
            set 
		    {
			    SetColumnValue("MasterName", value);
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
	      
        [XmlAttribute("CreateDate")]
        [Bindable(true)]
        public DateTime? CreateDate 
	    {
		    get
		    {
			    return GetColumnValue<DateTime?>("CreateDate");
		    }
            set 
		    {
			    SetColumnValue("CreateDate", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string MasterId = @"MasterId";
            
            public static string MasterName = @"MasterName";
            
            public static string EmployeeName = @"EmployeeName";
            
            public static string DepartName = @"DepartName";
            
            public static string CreateDate = @"CreateDate";
            
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
