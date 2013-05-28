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
    /// Strongly-typed collection for the Vw_MsgGv class.
    /// </summary>
    [Serializable]
    public partial class Vw_MsgGvCollection : ReadOnlyList<Vw_MsgGv, Vw_MsgGvCollection>
    {        
        public Vw_MsgGvCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the vw_MsgGv view.
    /// </summary>
    [Serializable]
    public partial class Vw_MsgGv : ReadOnlyRecord<Vw_MsgGv>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("vw_MsgGv", TableType.View, DataService.GetInstance("SubsonicProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarMessageId = new TableSchema.TableColumn(schema);
                colvarMessageId.ColumnName = "MessageId";
                colvarMessageId.DataType = DbType.Int32;
                colvarMessageId.MaxLength = 0;
                colvarMessageId.AutoIncrement = false;
                colvarMessageId.IsNullable = false;
                colvarMessageId.IsPrimaryKey = false;
                colvarMessageId.IsForeignKey = false;
                colvarMessageId.IsReadOnly = false;
                
                schema.Columns.Add(colvarMessageId);
                
                TableSchema.TableColumn colvarMsg = new TableSchema.TableColumn(schema);
                colvarMsg.ColumnName = "Msg";
                colvarMsg.DataType = DbType.String;
                colvarMsg.MaxLength = 50;
                colvarMsg.AutoIncrement = false;
                colvarMsg.IsNullable = true;
                colvarMsg.IsPrimaryKey = false;
                colvarMsg.IsForeignKey = false;
                colvarMsg.IsReadOnly = false;
                
                schema.Columns.Add(colvarMsg);
                
                TableSchema.TableColumn colvarMsgTime = new TableSchema.TableColumn(schema);
                colvarMsgTime.ColumnName = "MsgTime";
                colvarMsgTime.DataType = DbType.String;
                colvarMsgTime.MaxLength = 50;
                colvarMsgTime.AutoIncrement = false;
                colvarMsgTime.IsNullable = true;
                colvarMsgTime.IsPrimaryKey = false;
                colvarMsgTime.IsForeignKey = false;
                colvarMsgTime.IsReadOnly = false;
                
                schema.Columns.Add(colvarMsgTime);
                
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
                
                TableSchema.TableColumn colvarRecvName = new TableSchema.TableColumn(schema);
                colvarRecvName.ColumnName = "RecvName";
                colvarRecvName.DataType = DbType.String;
                colvarRecvName.MaxLength = 50;
                colvarRecvName.AutoIncrement = false;
                colvarRecvName.IsNullable = false;
                colvarRecvName.IsPrimaryKey = false;
                colvarRecvName.IsForeignKey = false;
                colvarRecvName.IsReadOnly = false;
                
                schema.Columns.Add(colvarRecvName);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["SubsonicProvider"].AddSchema("vw_MsgGv",schema);
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
	    public Vw_MsgGv()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public Vw_MsgGv(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public Vw_MsgGv(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public Vw_MsgGv(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("MessageId")]
        [Bindable(true)]
        public int MessageId 
	    {
		    get
		    {
			    return GetColumnValue<int>("MessageId");
		    }
            set 
		    {
			    SetColumnValue("MessageId", value);
            }
        }
	      
        [XmlAttribute("Msg")]
        [Bindable(true)]
        public string Msg 
	    {
		    get
		    {
			    return GetColumnValue<string>("Msg");
		    }
            set 
		    {
			    SetColumnValue("Msg", value);
            }
        }
	      
        [XmlAttribute("MsgTime")]
        [Bindable(true)]
        public string MsgTime 
	    {
		    get
		    {
			    return GetColumnValue<string>("MsgTime");
		    }
            set 
		    {
			    SetColumnValue("MsgTime", value);
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
	      
        [XmlAttribute("RecvName")]
        [Bindable(true)]
        public string RecvName 
	    {
		    get
		    {
			    return GetColumnValue<string>("RecvName");
		    }
            set 
		    {
			    SetColumnValue("RecvName", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string MessageId = @"MessageId";
            
            public static string Msg = @"Msg";
            
            public static string MsgTime = @"MsgTime";
            
            public static string EmployeeName = @"EmployeeName";
            
            public static string RecvName = @"RecvName";
            
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
