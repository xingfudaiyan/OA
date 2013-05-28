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
    /// Strongly-typed collection for the Vw_StampList class.
    /// </summary>
    [Serializable]
    public partial class Vw_StampListCollection : ReadOnlyList<Vw_StampList, Vw_StampListCollection>
    {        
        public Vw_StampListCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the vw_StampList view.
    /// </summary>
    [Serializable]
    public partial class Vw_StampList : ReadOnlyRecord<Vw_StampList>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("vw_StampList", TableType.View, DataService.GetInstance("SubsonicProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarStampId = new TableSchema.TableColumn(schema);
                colvarStampId.ColumnName = "StampId";
                colvarStampId.DataType = DbType.Int32;
                colvarStampId.MaxLength = 0;
                colvarStampId.AutoIncrement = false;
                colvarStampId.IsNullable = false;
                colvarStampId.IsPrimaryKey = false;
                colvarStampId.IsForeignKey = false;
                colvarStampId.IsReadOnly = false;
                
                schema.Columns.Add(colvarStampId);
                
                TableSchema.TableColumn colvarUseDate = new TableSchema.TableColumn(schema);
                colvarUseDate.ColumnName = "UseDate";
                colvarUseDate.DataType = DbType.String;
                colvarUseDate.MaxLength = 50;
                colvarUseDate.AutoIncrement = false;
                colvarUseDate.IsNullable = true;
                colvarUseDate.IsPrimaryKey = false;
                colvarUseDate.IsForeignKey = false;
                colvarUseDate.IsReadOnly = false;
                
                schema.Columns.Add(colvarUseDate);
                
                TableSchema.TableColumn colvarStampFileTypeId = new TableSchema.TableColumn(schema);
                colvarStampFileTypeId.ColumnName = "StampFileTypeId";
                colvarStampFileTypeId.DataType = DbType.Int32;
                colvarStampFileTypeId.MaxLength = 0;
                colvarStampFileTypeId.AutoIncrement = false;
                colvarStampFileTypeId.IsNullable = true;
                colvarStampFileTypeId.IsPrimaryKey = false;
                colvarStampFileTypeId.IsForeignKey = false;
                colvarStampFileTypeId.IsReadOnly = false;
                
                schema.Columns.Add(colvarStampFileTypeId);
                
                TableSchema.TableColumn colvarStampTypeId = new TableSchema.TableColumn(schema);
                colvarStampTypeId.ColumnName = "StampTypeId";
                colvarStampTypeId.DataType = DbType.Int32;
                colvarStampTypeId.MaxLength = 0;
                colvarStampTypeId.AutoIncrement = false;
                colvarStampTypeId.IsNullable = true;
                colvarStampTypeId.IsPrimaryKey = false;
                colvarStampTypeId.IsForeignKey = false;
                colvarStampTypeId.IsReadOnly = false;
                
                schema.Columns.Add(colvarStampTypeId);
                
                TableSchema.TableColumn colvarStampuse = new TableSchema.TableColumn(schema);
                colvarStampuse.ColumnName = "Stampuse";
                colvarStampuse.DataType = DbType.String;
                colvarStampuse.MaxLength = 50;
                colvarStampuse.AutoIncrement = false;
                colvarStampuse.IsNullable = true;
                colvarStampuse.IsPrimaryKey = false;
                colvarStampuse.IsForeignKey = false;
                colvarStampuse.IsReadOnly = false;
                
                schema.Columns.Add(colvarStampuse);
                
                TableSchema.TableColumn colvarMemo = new TableSchema.TableColumn(schema);
                colvarMemo.ColumnName = "Memo";
                colvarMemo.DataType = DbType.String;
                colvarMemo.MaxLength = 50;
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
                
                TableSchema.TableColumn colvarStampFileTypeName = new TableSchema.TableColumn(schema);
                colvarStampFileTypeName.ColumnName = "StampFileTypeName";
                colvarStampFileTypeName.DataType = DbType.String;
                colvarStampFileTypeName.MaxLength = 50;
                colvarStampFileTypeName.AutoIncrement = false;
                colvarStampFileTypeName.IsNullable = true;
                colvarStampFileTypeName.IsPrimaryKey = false;
                colvarStampFileTypeName.IsForeignKey = false;
                colvarStampFileTypeName.IsReadOnly = false;
                
                schema.Columns.Add(colvarStampFileTypeName);
                
                TableSchema.TableColumn colvarStampName = new TableSchema.TableColumn(schema);
                colvarStampName.ColumnName = "StampName";
                colvarStampName.DataType = DbType.String;
                colvarStampName.MaxLength = 50;
                colvarStampName.AutoIncrement = false;
                colvarStampName.IsNullable = true;
                colvarStampName.IsPrimaryKey = false;
                colvarStampName.IsForeignKey = false;
                colvarStampName.IsReadOnly = false;
                
                schema.Columns.Add(colvarStampName);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["SubsonicProvider"].AddSchema("vw_StampList",schema);
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
	    public Vw_StampList()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public Vw_StampList(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public Vw_StampList(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public Vw_StampList(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("StampId")]
        [Bindable(true)]
        public int StampId 
	    {
		    get
		    {
			    return GetColumnValue<int>("StampId");
		    }
            set 
		    {
			    SetColumnValue("StampId", value);
            }
        }
	      
        [XmlAttribute("UseDate")]
        [Bindable(true)]
        public string UseDate 
	    {
		    get
		    {
			    return GetColumnValue<string>("UseDate");
		    }
            set 
		    {
			    SetColumnValue("UseDate", value);
            }
        }
	      
        [XmlAttribute("StampFileTypeId")]
        [Bindable(true)]
        public int? StampFileTypeId 
	    {
		    get
		    {
			    return GetColumnValue<int?>("StampFileTypeId");
		    }
            set 
		    {
			    SetColumnValue("StampFileTypeId", value);
            }
        }
	      
        [XmlAttribute("StampTypeId")]
        [Bindable(true)]
        public int? StampTypeId 
	    {
		    get
		    {
			    return GetColumnValue<int?>("StampTypeId");
		    }
            set 
		    {
			    SetColumnValue("StampTypeId", value);
            }
        }
	      
        [XmlAttribute("Stampuse")]
        [Bindable(true)]
        public string Stampuse 
	    {
		    get
		    {
			    return GetColumnValue<string>("Stampuse");
		    }
            set 
		    {
			    SetColumnValue("Stampuse", value);
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
	      
        [XmlAttribute("StampFileTypeName")]
        [Bindable(true)]
        public string StampFileTypeName 
	    {
		    get
		    {
			    return GetColumnValue<string>("StampFileTypeName");
		    }
            set 
		    {
			    SetColumnValue("StampFileTypeName", value);
            }
        }
	      
        [XmlAttribute("StampName")]
        [Bindable(true)]
        public string StampName 
	    {
		    get
		    {
			    return GetColumnValue<string>("StampName");
		    }
            set 
		    {
			    SetColumnValue("StampName", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string StampId = @"StampId";
            
            public static string UseDate = @"UseDate";
            
            public static string StampFileTypeId = @"StampFileTypeId";
            
            public static string StampTypeId = @"StampTypeId";
            
            public static string Stampuse = @"Stampuse";
            
            public static string Memo = @"Memo";
            
            public static string ApplyName = @"ApplyName";
            
            public static string DepartName = @"DepartName";
            
            public static string State = @"State";
            
            public static string ApplyTime = @"ApplyTime";
            
            public static string StampFileTypeName = @"StampFileTypeName";
            
            public static string StampName = @"StampName";
            
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
