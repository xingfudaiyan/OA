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
    /// Strongly-typed collection for the Vw_Notice class.
    /// </summary>
    [Serializable]
    public partial class Vw_NoticeCollection : ReadOnlyList<Vw_Notice, Vw_NoticeCollection>
    {        
        public Vw_NoticeCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the vw_Notice view.
    /// </summary>
    [Serializable]
    public partial class Vw_Notice : ReadOnlyRecord<Vw_Notice>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("vw_Notice", TableType.View, DataService.GetInstance("SubsonicProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarNoticeId = new TableSchema.TableColumn(schema);
                colvarNoticeId.ColumnName = "NoticeId";
                colvarNoticeId.DataType = DbType.Int32;
                colvarNoticeId.MaxLength = 0;
                colvarNoticeId.AutoIncrement = false;
                colvarNoticeId.IsNullable = false;
                colvarNoticeId.IsPrimaryKey = false;
                colvarNoticeId.IsForeignKey = false;
                colvarNoticeId.IsReadOnly = false;
                
                schema.Columns.Add(colvarNoticeId);
                
                TableSchema.TableColumn colvarNoticeContent = new TableSchema.TableColumn(schema);
                colvarNoticeContent.ColumnName = "NoticeContent";
                colvarNoticeContent.DataType = DbType.String;
                colvarNoticeContent.MaxLength = -1;
                colvarNoticeContent.AutoIncrement = false;
                colvarNoticeContent.IsNullable = true;
                colvarNoticeContent.IsPrimaryKey = false;
                colvarNoticeContent.IsForeignKey = false;
                colvarNoticeContent.IsReadOnly = false;
                
                schema.Columns.Add(colvarNoticeContent);
                
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
                
                TableSchema.TableColumn colvarNoticeTime = new TableSchema.TableColumn(schema);
                colvarNoticeTime.ColumnName = "NoticeTime";
                colvarNoticeTime.DataType = DbType.String;
                colvarNoticeTime.MaxLength = 50;
                colvarNoticeTime.AutoIncrement = false;
                colvarNoticeTime.IsNullable = true;
                colvarNoticeTime.IsPrimaryKey = false;
                colvarNoticeTime.IsForeignKey = false;
                colvarNoticeTime.IsReadOnly = false;
                
                schema.Columns.Add(colvarNoticeTime);
                
                TableSchema.TableColumn colvarNoticeTitle = new TableSchema.TableColumn(schema);
                colvarNoticeTitle.ColumnName = "NoticeTitle";
                colvarNoticeTitle.DataType = DbType.String;
                colvarNoticeTitle.MaxLength = 50;
                colvarNoticeTitle.AutoIncrement = false;
                colvarNoticeTitle.IsNullable = true;
                colvarNoticeTitle.IsPrimaryKey = false;
                colvarNoticeTitle.IsForeignKey = false;
                colvarNoticeTitle.IsReadOnly = false;
                
                schema.Columns.Add(colvarNoticeTitle);
                
                TableSchema.TableColumn colvarEmployeeName = new TableSchema.TableColumn(schema);
                colvarEmployeeName.ColumnName = "EmployeeName";
                colvarEmployeeName.DataType = DbType.String;
                colvarEmployeeName.MaxLength = 50;
                colvarEmployeeName.AutoIncrement = false;
                colvarEmployeeName.IsNullable = true;
                colvarEmployeeName.IsPrimaryKey = false;
                colvarEmployeeName.IsForeignKey = false;
                colvarEmployeeName.IsReadOnly = false;
                
                schema.Columns.Add(colvarEmployeeName);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["SubsonicProvider"].AddSchema("vw_Notice",schema);
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
	    public Vw_Notice()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public Vw_Notice(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public Vw_Notice(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public Vw_Notice(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("NoticeId")]
        [Bindable(true)]
        public int NoticeId 
	    {
		    get
		    {
			    return GetColumnValue<int>("NoticeId");
		    }
            set 
		    {
			    SetColumnValue("NoticeId", value);
            }
        }
	      
        [XmlAttribute("NoticeContent")]
        [Bindable(true)]
        public string NoticeContent 
	    {
		    get
		    {
			    return GetColumnValue<string>("NoticeContent");
		    }
            set 
		    {
			    SetColumnValue("NoticeContent", value);
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
	      
        [XmlAttribute("NoticeTime")]
        [Bindable(true)]
        public string NoticeTime 
	    {
		    get
		    {
			    return GetColumnValue<string>("NoticeTime");
		    }
            set 
		    {
			    SetColumnValue("NoticeTime", value);
            }
        }
	      
        [XmlAttribute("NoticeTitle")]
        [Bindable(true)]
        public string NoticeTitle 
	    {
		    get
		    {
			    return GetColumnValue<string>("NoticeTitle");
		    }
            set 
		    {
			    SetColumnValue("NoticeTitle", value);
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
		    
		    
            public static string NoticeId = @"NoticeId";
            
            public static string NoticeContent = @"NoticeContent";
            
            public static string SignName = @"SignName";
            
            public static string NoticeTime = @"NoticeTime";
            
            public static string NoticeTitle = @"NoticeTitle";
            
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
