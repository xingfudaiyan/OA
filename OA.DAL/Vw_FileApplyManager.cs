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
    /// Strongly-typed collection for the Vw_FileApplyManager class.
    /// </summary>
    [Serializable]
    public partial class Vw_FileApplyManagerCollection : ReadOnlyList<Vw_FileApplyManager, Vw_FileApplyManagerCollection>
    {        
        public Vw_FileApplyManagerCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the vw_FileApplyManager view.
    /// </summary>
    [Serializable]
    public partial class Vw_FileApplyManager : ReadOnlyRecord<Vw_FileApplyManager>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("vw_FileApplyManager", TableType.View, DataService.GetInstance("SubsonicProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarFileApplyId = new TableSchema.TableColumn(schema);
                colvarFileApplyId.ColumnName = "FileApplyId";
                colvarFileApplyId.DataType = DbType.Int32;
                colvarFileApplyId.MaxLength = 0;
                colvarFileApplyId.AutoIncrement = false;
                colvarFileApplyId.IsNullable = false;
                colvarFileApplyId.IsPrimaryKey = false;
                colvarFileApplyId.IsForeignKey = false;
                colvarFileApplyId.IsReadOnly = false;
                
                schema.Columns.Add(colvarFileApplyId);
                
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
                
                TableSchema.TableColumn colvarFilesName = new TableSchema.TableColumn(schema);
                colvarFilesName.ColumnName = "FilesName";
                colvarFilesName.DataType = DbType.String;
                colvarFilesName.MaxLength = 50;
                colvarFilesName.AutoIncrement = false;
                colvarFilesName.IsNullable = true;
                colvarFilesName.IsPrimaryKey = false;
                colvarFilesName.IsForeignKey = false;
                colvarFilesName.IsReadOnly = false;
                
                schema.Columns.Add(colvarFilesName);
                
                TableSchema.TableColumn colvarFileType = new TableSchema.TableColumn(schema);
                colvarFileType.ColumnName = "FileType";
                colvarFileType.DataType = DbType.String;
                colvarFileType.MaxLength = 50;
                colvarFileType.AutoIncrement = false;
                colvarFileType.IsNullable = true;
                colvarFileType.IsPrimaryKey = false;
                colvarFileType.IsForeignKey = false;
                colvarFileType.IsReadOnly = false;
                
                schema.Columns.Add(colvarFileType);
                
                TableSchema.TableColumn colvarFileDes = new TableSchema.TableColumn(schema);
                colvarFileDes.ColumnName = "FileDes";
                colvarFileDes.DataType = DbType.String;
                colvarFileDes.MaxLength = -1;
                colvarFileDes.AutoIncrement = false;
                colvarFileDes.IsNullable = true;
                colvarFileDes.IsPrimaryKey = false;
                colvarFileDes.IsForeignKey = false;
                colvarFileDes.IsReadOnly = false;
                
                schema.Columns.Add(colvarFileDes);
                
                TableSchema.TableColumn colvarDepartView = new TableSchema.TableColumn(schema);
                colvarDepartView.ColumnName = "DepartView";
                colvarDepartView.DataType = DbType.String;
                colvarDepartView.MaxLength = -1;
                colvarDepartView.AutoIncrement = false;
                colvarDepartView.IsNullable = true;
                colvarDepartView.IsPrimaryKey = false;
                colvarDepartView.IsForeignKey = false;
                colvarDepartView.IsReadOnly = false;
                
                schema.Columns.Add(colvarDepartView);
                
                TableSchema.TableColumn colvarManagerView = new TableSchema.TableColumn(schema);
                colvarManagerView.ColumnName = "ManagerView";
                colvarManagerView.DataType = DbType.String;
                colvarManagerView.MaxLength = -1;
                colvarManagerView.AutoIncrement = false;
                colvarManagerView.IsNullable = true;
                colvarManagerView.IsPrimaryKey = false;
                colvarManagerView.IsForeignKey = false;
                colvarManagerView.IsReadOnly = false;
                
                schema.Columns.Add(colvarManagerView);
                
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
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["SubsonicProvider"].AddSchema("vw_FileApplyManager",schema);
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
	    public Vw_FileApplyManager()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public Vw_FileApplyManager(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public Vw_FileApplyManager(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public Vw_FileApplyManager(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("FileApplyId")]
        [Bindable(true)]
        public int FileApplyId 
	    {
		    get
		    {
			    return GetColumnValue<int>("FileApplyId");
		    }
            set 
		    {
			    SetColumnValue("FileApplyId", value);
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
	      
        [XmlAttribute("FilesName")]
        [Bindable(true)]
        public string FilesName 
	    {
		    get
		    {
			    return GetColumnValue<string>("FilesName");
		    }
            set 
		    {
			    SetColumnValue("FilesName", value);
            }
        }
	      
        [XmlAttribute("FileType")]
        [Bindable(true)]
        public string FileType 
	    {
		    get
		    {
			    return GetColumnValue<string>("FileType");
		    }
            set 
		    {
			    SetColumnValue("FileType", value);
            }
        }
	      
        [XmlAttribute("FileDes")]
        [Bindable(true)]
        public string FileDes 
	    {
		    get
		    {
			    return GetColumnValue<string>("FileDes");
		    }
            set 
		    {
			    SetColumnValue("FileDes", value);
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
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string FileApplyId = @"FileApplyId";
            
            public static string ApplyTime = @"ApplyTime";
            
            public static string FilesName = @"FilesName";
            
            public static string FileType = @"FileType";
            
            public static string FileDes = @"FileDes";
            
            public static string DepartView = @"DepartView";
            
            public static string ManagerView = @"ManagerView";
            
            public static string State = @"State";
            
            public static string DepartName = @"DepartName";
            
            public static string ApplyName = @"ApplyName";
            
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
