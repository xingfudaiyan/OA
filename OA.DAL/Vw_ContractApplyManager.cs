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
    /// Strongly-typed collection for the Vw_ContractApplyManager class.
    /// </summary>
    [Serializable]
    public partial class Vw_ContractApplyManagerCollection : ReadOnlyList<Vw_ContractApplyManager, Vw_ContractApplyManagerCollection>
    {        
        public Vw_ContractApplyManagerCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the vw_ContractApplyManager view.
    /// </summary>
    [Serializable]
    public partial class Vw_ContractApplyManager : ReadOnlyRecord<Vw_ContractApplyManager>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("vw_ContractApplyManager", TableType.View, DataService.GetInstance("SubsonicProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarContractApplyId = new TableSchema.TableColumn(schema);
                colvarContractApplyId.ColumnName = "ContractApplyId";
                colvarContractApplyId.DataType = DbType.Int32;
                colvarContractApplyId.MaxLength = 0;
                colvarContractApplyId.AutoIncrement = false;
                colvarContractApplyId.IsNullable = false;
                colvarContractApplyId.IsPrimaryKey = false;
                colvarContractApplyId.IsForeignKey = false;
                colvarContractApplyId.IsReadOnly = false;
                
                schema.Columns.Add(colvarContractApplyId);
                
                TableSchema.TableColumn colvarContractFileId = new TableSchema.TableColumn(schema);
                colvarContractFileId.ColumnName = "ContractFileId";
                colvarContractFileId.DataType = DbType.Int32;
                colvarContractFileId.MaxLength = 0;
                colvarContractFileId.AutoIncrement = false;
                colvarContractFileId.IsNullable = true;
                colvarContractFileId.IsPrimaryKey = false;
                colvarContractFileId.IsForeignKey = false;
                colvarContractFileId.IsReadOnly = false;
                
                schema.Columns.Add(colvarContractFileId);
                
                TableSchema.TableColumn colvarSignName = new TableSchema.TableColumn(schema);
                colvarSignName.ColumnName = "SignName";
                colvarSignName.DataType = DbType.String;
                colvarSignName.MaxLength = 50;
                colvarSignName.AutoIncrement = false;
                colvarSignName.IsNullable = true;
                colvarSignName.IsPrimaryKey = false;
                colvarSignName.IsForeignKey = false;
                colvarSignName.IsReadOnly = false;
                
                schema.Columns.Add(colvarSignName);
                
                TableSchema.TableColumn colvarContractNum = new TableSchema.TableColumn(schema);
                colvarContractNum.ColumnName = "ContractNum";
                colvarContractNum.DataType = DbType.String;
                colvarContractNum.MaxLength = 50;
                colvarContractNum.AutoIncrement = false;
                colvarContractNum.IsNullable = true;
                colvarContractNum.IsPrimaryKey = false;
                colvarContractNum.IsForeignKey = false;
                colvarContractNum.IsReadOnly = false;
                
                schema.Columns.Add(colvarContractNum);
                
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
                
                TableSchema.TableColumn colvarToday = new TableSchema.TableColumn(schema);
                colvarToday.ColumnName = "Today";
                colvarToday.DataType = DbType.String;
                colvarToday.MaxLength = 50;
                colvarToday.AutoIncrement = false;
                colvarToday.IsNullable = true;
                colvarToday.IsPrimaryKey = false;
                colvarToday.IsForeignKey = false;
                colvarToday.IsReadOnly = false;
                
                schema.Columns.Add(colvarToday);
                
                TableSchema.TableColumn colvarContractName = new TableSchema.TableColumn(schema);
                colvarContractName.ColumnName = "ContractName";
                colvarContractName.DataType = DbType.String;
                colvarContractName.MaxLength = 50;
                colvarContractName.AutoIncrement = false;
                colvarContractName.IsNullable = true;
                colvarContractName.IsPrimaryKey = false;
                colvarContractName.IsForeignKey = false;
                colvarContractName.IsReadOnly = false;
                
                schema.Columns.Add(colvarContractName);
                
                TableSchema.TableColumn colvarBeginDate = new TableSchema.TableColumn(schema);
                colvarBeginDate.ColumnName = "BeginDate";
                colvarBeginDate.DataType = DbType.String;
                colvarBeginDate.MaxLength = 50;
                colvarBeginDate.AutoIncrement = false;
                colvarBeginDate.IsNullable = true;
                colvarBeginDate.IsPrimaryKey = false;
                colvarBeginDate.IsForeignKey = false;
                colvarBeginDate.IsReadOnly = false;
                
                schema.Columns.Add(colvarBeginDate);
                
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
                
                TableSchema.TableColumn colvarContractDes = new TableSchema.TableColumn(schema);
                colvarContractDes.ColumnName = "ContractDes";
                colvarContractDes.DataType = DbType.String;
                colvarContractDes.MaxLength = -1;
                colvarContractDes.AutoIncrement = false;
                colvarContractDes.IsNullable = true;
                colvarContractDes.IsPrimaryKey = false;
                colvarContractDes.IsForeignKey = false;
                colvarContractDes.IsReadOnly = false;
                
                schema.Columns.Add(colvarContractDes);
                
                TableSchema.TableColumn colvarBigMoney = new TableSchema.TableColumn(schema);
                colvarBigMoney.ColumnName = "BigMoney";
                colvarBigMoney.DataType = DbType.String;
                colvarBigMoney.MaxLength = 50;
                colvarBigMoney.AutoIncrement = false;
                colvarBigMoney.IsNullable = true;
                colvarBigMoney.IsPrimaryKey = false;
                colvarBigMoney.IsForeignKey = false;
                colvarBigMoney.IsReadOnly = false;
                
                schema.Columns.Add(colvarBigMoney);
                
                TableSchema.TableColumn colvarSmallMoney = new TableSchema.TableColumn(schema);
                colvarSmallMoney.ColumnName = "SmallMoney";
                colvarSmallMoney.DataType = DbType.String;
                colvarSmallMoney.MaxLength = 50;
                colvarSmallMoney.AutoIncrement = false;
                colvarSmallMoney.IsNullable = true;
                colvarSmallMoney.IsPrimaryKey = false;
                colvarSmallMoney.IsForeignKey = false;
                colvarSmallMoney.IsReadOnly = false;
                
                schema.Columns.Add(colvarSmallMoney);
                
                TableSchema.TableColumn colvarUseStampType = new TableSchema.TableColumn(schema);
                colvarUseStampType.ColumnName = "UseStampType";
                colvarUseStampType.DataType = DbType.String;
                colvarUseStampType.MaxLength = 50;
                colvarUseStampType.AutoIncrement = false;
                colvarUseStampType.IsNullable = true;
                colvarUseStampType.IsPrimaryKey = false;
                colvarUseStampType.IsForeignKey = false;
                colvarUseStampType.IsReadOnly = false;
                
                schema.Columns.Add(colvarUseStampType);
                
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
                
                TableSchema.TableColumn colvarIsMoney = new TableSchema.TableColumn(schema);
                colvarIsMoney.ColumnName = "IsMoney";
                colvarIsMoney.DataType = DbType.Int32;
                colvarIsMoney.MaxLength = 0;
                colvarIsMoney.AutoIncrement = false;
                colvarIsMoney.IsNullable = true;
                colvarIsMoney.IsPrimaryKey = false;
                colvarIsMoney.IsForeignKey = false;
                colvarIsMoney.IsReadOnly = false;
                
                schema.Columns.Add(colvarIsMoney);
                
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
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["SubsonicProvider"].AddSchema("vw_ContractApplyManager",schema);
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
	    public Vw_ContractApplyManager()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public Vw_ContractApplyManager(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public Vw_ContractApplyManager(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public Vw_ContractApplyManager(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("ContractApplyId")]
        [Bindable(true)]
        public int ContractApplyId 
	    {
		    get
		    {
			    return GetColumnValue<int>("ContractApplyId");
		    }
            set 
		    {
			    SetColumnValue("ContractApplyId", value);
            }
        }
	      
        [XmlAttribute("ContractFileId")]
        [Bindable(true)]
        public int? ContractFileId 
	    {
		    get
		    {
			    return GetColumnValue<int?>("ContractFileId");
		    }
            set 
		    {
			    SetColumnValue("ContractFileId", value);
            }
        }
	      
        [XmlAttribute("SignName")]
        [Bindable(true)]
        public string SignName 
	    {
		    get
		    {
			    return GetColumnValue<string>("SignName");
		    }
            set 
		    {
			    SetColumnValue("SignName", value);
            }
        }
	      
        [XmlAttribute("ContractNum")]
        [Bindable(true)]
        public string ContractNum 
	    {
		    get
		    {
			    return GetColumnValue<string>("ContractNum");
		    }
            set 
		    {
			    SetColumnValue("ContractNum", value);
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
	      
        [XmlAttribute("Today")]
        [Bindable(true)]
        public string Today 
	    {
		    get
		    {
			    return GetColumnValue<string>("Today");
		    }
            set 
		    {
			    SetColumnValue("Today", value);
            }
        }
	      
        [XmlAttribute("ContractName")]
        [Bindable(true)]
        public string ContractName 
	    {
		    get
		    {
			    return GetColumnValue<string>("ContractName");
		    }
            set 
		    {
			    SetColumnValue("ContractName", value);
            }
        }
	      
        [XmlAttribute("BeginDate")]
        [Bindable(true)]
        public string BeginDate 
	    {
		    get
		    {
			    return GetColumnValue<string>("BeginDate");
		    }
            set 
		    {
			    SetColumnValue("BeginDate", value);
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
	      
        [XmlAttribute("ContractDes")]
        [Bindable(true)]
        public string ContractDes 
	    {
		    get
		    {
			    return GetColumnValue<string>("ContractDes");
		    }
            set 
		    {
			    SetColumnValue("ContractDes", value);
            }
        }
	      
        [XmlAttribute("BigMoney")]
        [Bindable(true)]
        public string BigMoney 
	    {
		    get
		    {
			    return GetColumnValue<string>("BigMoney");
		    }
            set 
		    {
			    SetColumnValue("BigMoney", value);
            }
        }
	      
        [XmlAttribute("SmallMoney")]
        [Bindable(true)]
        public string SmallMoney 
	    {
		    get
		    {
			    return GetColumnValue<string>("SmallMoney");
		    }
            set 
		    {
			    SetColumnValue("SmallMoney", value);
            }
        }
	      
        [XmlAttribute("UseStampType")]
        [Bindable(true)]
        public string UseStampType 
	    {
		    get
		    {
			    return GetColumnValue<string>("UseStampType");
		    }
            set 
		    {
			    SetColumnValue("UseStampType", value);
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
	      
        [XmlAttribute("IsMoney")]
        [Bindable(true)]
        public int? IsMoney 
	    {
		    get
		    {
			    return GetColumnValue<int?>("IsMoney");
		    }
            set 
		    {
			    SetColumnValue("IsMoney", value);
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
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string ContractApplyId = @"ContractApplyId";
            
            public static string ContractFileId = @"ContractFileId";
            
            public static string SignName = @"SignName";
            
            public static string ContractNum = @"ContractNum";
            
            public static string SheetNum = @"SheetNum";
            
            public static string Today = @"Today";
            
            public static string ContractName = @"ContractName";
            
            public static string BeginDate = @"BeginDate";
            
            public static string ApplyDate = @"ApplyDate";
            
            public static string ContractDes = @"ContractDes";
            
            public static string BigMoney = @"BigMoney";
            
            public static string SmallMoney = @"SmallMoney";
            
            public static string UseStampType = @"UseStampType";
            
            public static string SectionView = @"SectionView";
            
            public static string ManagerView = @"ManagerView";
            
            public static string IsMoney = @"IsMoney";
            
            public static string ApplyTime = @"ApplyTime";
            
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
