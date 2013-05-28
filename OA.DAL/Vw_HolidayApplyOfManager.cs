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
    /// Strongly-typed collection for the Vw_HolidayApplyOfManager class.
    /// </summary>
    [Serializable]
    public partial class Vw_HolidayApplyOfManagerCollection : ReadOnlyList<Vw_HolidayApplyOfManager, Vw_HolidayApplyOfManagerCollection>
    {        
        public Vw_HolidayApplyOfManagerCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the vw_HolidayApplyOfManager view.
    /// </summary>
    [Serializable]
    public partial class Vw_HolidayApplyOfManager : ReadOnlyRecord<Vw_HolidayApplyOfManager>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("vw_HolidayApplyOfManager", TableType.View, DataService.GetInstance("SubsonicProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarHolidayApplyId = new TableSchema.TableColumn(schema);
                colvarHolidayApplyId.ColumnName = "HolidayApplyId";
                colvarHolidayApplyId.DataType = DbType.Int32;
                colvarHolidayApplyId.MaxLength = 0;
                colvarHolidayApplyId.AutoIncrement = false;
                colvarHolidayApplyId.IsNullable = false;
                colvarHolidayApplyId.IsPrimaryKey = false;
                colvarHolidayApplyId.IsForeignKey = false;
                colvarHolidayApplyId.IsReadOnly = false;
                
                schema.Columns.Add(colvarHolidayApplyId);
                
                TableSchema.TableColumn colvarCompany1 = new TableSchema.TableColumn(schema);
                colvarCompany1.ColumnName = "Company1";
                colvarCompany1.DataType = DbType.String;
                colvarCompany1.MaxLength = 50;
                colvarCompany1.AutoIncrement = false;
                colvarCompany1.IsNullable = true;
                colvarCompany1.IsPrimaryKey = false;
                colvarCompany1.IsForeignKey = false;
                colvarCompany1.IsReadOnly = false;
                
                schema.Columns.Add(colvarCompany1);
                
                TableSchema.TableColumn colvarPositonName = new TableSchema.TableColumn(schema);
                colvarPositonName.ColumnName = "PositonName";
                colvarPositonName.DataType = DbType.String;
                colvarPositonName.MaxLength = 50;
                colvarPositonName.AutoIncrement = false;
                colvarPositonName.IsNullable = true;
                colvarPositonName.IsPrimaryKey = false;
                colvarPositonName.IsForeignKey = false;
                colvarPositonName.IsReadOnly = false;
                
                schema.Columns.Add(colvarPositonName);
                
                TableSchema.TableColumn colvarCompany2 = new TableSchema.TableColumn(schema);
                colvarCompany2.ColumnName = "Company2";
                colvarCompany2.DataType = DbType.String;
                colvarCompany2.MaxLength = 50;
                colvarCompany2.AutoIncrement = false;
                colvarCompany2.IsNullable = true;
                colvarCompany2.IsPrimaryKey = false;
                colvarCompany2.IsForeignKey = false;
                colvarCompany2.IsReadOnly = false;
                
                schema.Columns.Add(colvarCompany2);
                
                TableSchema.TableColumn colvarCompany2Name = new TableSchema.TableColumn(schema);
                colvarCompany2Name.ColumnName = "Company2Name";
                colvarCompany2Name.DataType = DbType.String;
                colvarCompany2Name.MaxLength = 50;
                colvarCompany2Name.AutoIncrement = false;
                colvarCompany2Name.IsNullable = true;
                colvarCompany2Name.IsPrimaryKey = false;
                colvarCompany2Name.IsForeignKey = false;
                colvarCompany2Name.IsReadOnly = false;
                
                schema.Columns.Add(colvarCompany2Name);
                
                TableSchema.TableColumn colvarHolidayTypeId = new TableSchema.TableColumn(schema);
                colvarHolidayTypeId.ColumnName = "HolidayTypeId";
                colvarHolidayTypeId.DataType = DbType.Int32;
                colvarHolidayTypeId.MaxLength = 0;
                colvarHolidayTypeId.AutoIncrement = false;
                colvarHolidayTypeId.IsNullable = true;
                colvarHolidayTypeId.IsPrimaryKey = false;
                colvarHolidayTypeId.IsForeignKey = false;
                colvarHolidayTypeId.IsReadOnly = false;
                
                schema.Columns.Add(colvarHolidayTypeId);
                
                TableSchema.TableColumn colvarBeginTime = new TableSchema.TableColumn(schema);
                colvarBeginTime.ColumnName = "BeginTime";
                colvarBeginTime.DataType = DbType.String;
                colvarBeginTime.MaxLength = 50;
                colvarBeginTime.AutoIncrement = false;
                colvarBeginTime.IsNullable = true;
                colvarBeginTime.IsPrimaryKey = false;
                colvarBeginTime.IsForeignKey = false;
                colvarBeginTime.IsReadOnly = false;
                
                schema.Columns.Add(colvarBeginTime);
                
                TableSchema.TableColumn colvarEndTime = new TableSchema.TableColumn(schema);
                colvarEndTime.ColumnName = "EndTime";
                colvarEndTime.DataType = DbType.String;
                colvarEndTime.MaxLength = 50;
                colvarEndTime.AutoIncrement = false;
                colvarEndTime.IsNullable = true;
                colvarEndTime.IsPrimaryKey = false;
                colvarEndTime.IsForeignKey = false;
                colvarEndTime.IsReadOnly = false;
                
                schema.Columns.Add(colvarEndTime);
                
                TableSchema.TableColumn colvarTimeSum = new TableSchema.TableColumn(schema);
                colvarTimeSum.ColumnName = "TimeSum";
                colvarTimeSum.DataType = DbType.String;
                colvarTimeSum.MaxLength = 50;
                colvarTimeSum.AutoIncrement = false;
                colvarTimeSum.IsNullable = true;
                colvarTimeSum.IsPrimaryKey = false;
                colvarTimeSum.IsForeignKey = false;
                colvarTimeSum.IsReadOnly = false;
                
                schema.Columns.Add(colvarTimeSum);
                
                TableSchema.TableColumn colvarReason = new TableSchema.TableColumn(schema);
                colvarReason.ColumnName = "Reason";
                colvarReason.DataType = DbType.String;
                colvarReason.MaxLength = 50;
                colvarReason.AutoIncrement = false;
                colvarReason.IsNullable = true;
                colvarReason.IsPrimaryKey = false;
                colvarReason.IsForeignKey = false;
                colvarReason.IsReadOnly = false;
                
                schema.Columns.Add(colvarReason);
                
                TableSchema.TableColumn colvarSectionView = new TableSchema.TableColumn(schema);
                colvarSectionView.ColumnName = "SectionView";
                colvarSectionView.DataType = DbType.String;
                colvarSectionView.MaxLength = 50;
                colvarSectionView.AutoIncrement = false;
                colvarSectionView.IsNullable = true;
                colvarSectionView.IsPrimaryKey = false;
                colvarSectionView.IsForeignKey = false;
                colvarSectionView.IsReadOnly = false;
                
                schema.Columns.Add(colvarSectionView);
                
                TableSchema.TableColumn colvarHrView = new TableSchema.TableColumn(schema);
                colvarHrView.ColumnName = "HrView";
                colvarHrView.DataType = DbType.String;
                colvarHrView.MaxLength = 50;
                colvarHrView.AutoIncrement = false;
                colvarHrView.IsNullable = true;
                colvarHrView.IsPrimaryKey = false;
                colvarHrView.IsForeignKey = false;
                colvarHrView.IsReadOnly = false;
                
                schema.Columns.Add(colvarHrView);
                
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
                
                TableSchema.TableColumn colvarApplyDate = new TableSchema.TableColumn(schema);
                colvarApplyDate.ColumnName = "ApplyDate";
                colvarApplyDate.DataType = DbType.String;
                colvarApplyDate.MaxLength = 50;
                colvarApplyDate.AutoIncrement = false;
                colvarApplyDate.IsNullable = true;
                colvarApplyDate.IsPrimaryKey = false;
                colvarApplyDate.IsForeignKey = false;
                colvarApplyDate.IsReadOnly = false;
                
                schema.Columns.Add(colvarApplyDate);
                
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
                
                TableSchema.TableColumn colvarHolidayTypeName = new TableSchema.TableColumn(schema);
                colvarHolidayTypeName.ColumnName = "HolidayTypeName";
                colvarHolidayTypeName.DataType = DbType.String;
                colvarHolidayTypeName.MaxLength = 50;
                colvarHolidayTypeName.AutoIncrement = false;
                colvarHolidayTypeName.IsNullable = false;
                colvarHolidayTypeName.IsPrimaryKey = false;
                colvarHolidayTypeName.IsForeignKey = false;
                colvarHolidayTypeName.IsReadOnly = false;
                
                schema.Columns.Add(colvarHolidayTypeName);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["SubsonicProvider"].AddSchema("vw_HolidayApplyOfManager",schema);
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
	    public Vw_HolidayApplyOfManager()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public Vw_HolidayApplyOfManager(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public Vw_HolidayApplyOfManager(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public Vw_HolidayApplyOfManager(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("HolidayApplyId")]
        [Bindable(true)]
        public int HolidayApplyId 
	    {
		    get
		    {
			    return GetColumnValue<int>("HolidayApplyId");
		    }
            set 
		    {
			    SetColumnValue("HolidayApplyId", value);
            }
        }
	      
        [XmlAttribute("Company1")]
        [Bindable(true)]
        public string Company1 
	    {
		    get
		    {
			    return GetColumnValue<string>("Company1");
		    }
            set 
		    {
			    SetColumnValue("Company1", value);
            }
        }
	      
        [XmlAttribute("PositonName")]
        [Bindable(true)]
        public string PositonName 
	    {
		    get
		    {
			    return GetColumnValue<string>("PositonName");
		    }
            set 
		    {
			    SetColumnValue("PositonName", value);
            }
        }
	      
        [XmlAttribute("Company2")]
        [Bindable(true)]
        public string Company2 
	    {
		    get
		    {
			    return GetColumnValue<string>("Company2");
		    }
            set 
		    {
			    SetColumnValue("Company2", value);
            }
        }
	      
        [XmlAttribute("Company2Name")]
        [Bindable(true)]
        public string Company2Name 
	    {
		    get
		    {
			    return GetColumnValue<string>("Company2Name");
		    }
            set 
		    {
			    SetColumnValue("Company2Name", value);
            }
        }
	      
        [XmlAttribute("HolidayTypeId")]
        [Bindable(true)]
        public int? HolidayTypeId 
	    {
		    get
		    {
			    return GetColumnValue<int?>("HolidayTypeId");
		    }
            set 
		    {
			    SetColumnValue("HolidayTypeId", value);
            }
        }
	      
        [XmlAttribute("BeginTime")]
        [Bindable(true)]
        public string BeginTime 
	    {
		    get
		    {
			    return GetColumnValue<string>("BeginTime");
		    }
            set 
		    {
			    SetColumnValue("BeginTime", value);
            }
        }
	      
        [XmlAttribute("EndTime")]
        [Bindable(true)]
        public string EndTime 
	    {
		    get
		    {
			    return GetColumnValue<string>("EndTime");
		    }
            set 
		    {
			    SetColumnValue("EndTime", value);
            }
        }
	      
        [XmlAttribute("TimeSum")]
        [Bindable(true)]
        public string TimeSum 
	    {
		    get
		    {
			    return GetColumnValue<string>("TimeSum");
		    }
            set 
		    {
			    SetColumnValue("TimeSum", value);
            }
        }
	      
        [XmlAttribute("Reason")]
        [Bindable(true)]
        public string Reason 
	    {
		    get
		    {
			    return GetColumnValue<string>("Reason");
		    }
            set 
		    {
			    SetColumnValue("Reason", value);
            }
        }
	      
        [XmlAttribute("SectionView")]
        [Bindable(true)]
        public string SectionView 
	    {
		    get
		    {
			    return GetColumnValue<string>("SectionView");
		    }
            set 
		    {
			    SetColumnValue("SectionView", value);
            }
        }
	      
        [XmlAttribute("HrView")]
        [Bindable(true)]
        public string HrView 
	    {
		    get
		    {
			    return GetColumnValue<string>("HrView");
		    }
            set 
		    {
			    SetColumnValue("HrView", value);
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
	      
        [XmlAttribute("ApplyDate")]
        [Bindable(true)]
        public string ApplyDate 
	    {
		    get
		    {
			    return GetColumnValue<string>("ApplyDate");
		    }
            set 
		    {
			    SetColumnValue("ApplyDate", value);
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
	      
        [XmlAttribute("HolidayTypeName")]
        [Bindable(true)]
        public string HolidayTypeName 
	    {
		    get
		    {
			    return GetColumnValue<string>("HolidayTypeName");
		    }
            set 
		    {
			    SetColumnValue("HolidayTypeName", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string HolidayApplyId = @"HolidayApplyId";
            
            public static string Company1 = @"Company1";
            
            public static string PositonName = @"PositonName";
            
            public static string Company2 = @"Company2";
            
            public static string Company2Name = @"Company2Name";
            
            public static string HolidayTypeId = @"HolidayTypeId";
            
            public static string BeginTime = @"BeginTime";
            
            public static string EndTime = @"EndTime";
            
            public static string TimeSum = @"TimeSum";
            
            public static string Reason = @"Reason";
            
            public static string SectionView = @"SectionView";
            
            public static string HrView = @"HrView";
            
            public static string ManagerView = @"ManagerView";
            
            public static string Memo = @"Memo";
            
            public static string ApplyDate = @"ApplyDate";
            
            public static string ApplyTime = @"ApplyTime";
            
            public static string ApplyName = @"ApplyName";
            
            public static string DepartName = @"DepartName";
            
            public static string State = @"State";
            
            public static string HolidayTypeName = @"HolidayTypeName";
            
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
