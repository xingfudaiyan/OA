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
    /// Strongly-typed collection for the Vw_ProcessRole class.
    /// </summary>
    [Serializable]
    public partial class Vw_ProcessRoleCollection : ReadOnlyList<Vw_ProcessRole, Vw_ProcessRoleCollection>
    {        
        public Vw_ProcessRoleCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the vw_ProcessRole view.
    /// </summary>
    [Serializable]
    public partial class Vw_ProcessRole : ReadOnlyRecord<Vw_ProcessRole>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("vw_ProcessRole", TableType.View, DataService.GetInstance("SubsonicProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarProcessId = new TableSchema.TableColumn(schema);
                colvarProcessId.ColumnName = "ProcessId";
                colvarProcessId.DataType = DbType.Int32;
                colvarProcessId.MaxLength = 0;
                colvarProcessId.AutoIncrement = false;
                colvarProcessId.IsNullable = false;
                colvarProcessId.IsPrimaryKey = false;
                colvarProcessId.IsForeignKey = false;
                colvarProcessId.IsReadOnly = false;
                
                schema.Columns.Add(colvarProcessId);
                
                TableSchema.TableColumn colvarProcessName = new TableSchema.TableColumn(schema);
                colvarProcessName.ColumnName = "ProcessName";
                colvarProcessName.DataType = DbType.String;
                colvarProcessName.MaxLength = 50;
                colvarProcessName.AutoIncrement = false;
                colvarProcessName.IsNullable = true;
                colvarProcessName.IsPrimaryKey = false;
                colvarProcessName.IsForeignKey = false;
                colvarProcessName.IsReadOnly = false;
                
                schema.Columns.Add(colvarProcessName);
                
                TableSchema.TableColumn colvarRoleName = new TableSchema.TableColumn(schema);
                colvarRoleName.ColumnName = "RoleName";
                colvarRoleName.DataType = DbType.String;
                colvarRoleName.MaxLength = 50;
                colvarRoleName.AutoIncrement = false;
                colvarRoleName.IsNullable = true;
                colvarRoleName.IsPrimaryKey = false;
                colvarRoleName.IsForeignKey = false;
                colvarRoleName.IsReadOnly = false;
                
                schema.Columns.Add(colvarRoleName);
                
                TableSchema.TableColumn colvarRoleId = new TableSchema.TableColumn(schema);
                colvarRoleId.ColumnName = "RoleId";
                colvarRoleId.DataType = DbType.Int32;
                colvarRoleId.MaxLength = 0;
                colvarRoleId.AutoIncrement = false;
                colvarRoleId.IsNullable = false;
                colvarRoleId.IsPrimaryKey = false;
                colvarRoleId.IsForeignKey = false;
                colvarRoleId.IsReadOnly = false;
                
                schema.Columns.Add(colvarRoleId);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["SubsonicProvider"].AddSchema("vw_ProcessRole",schema);
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
	    public Vw_ProcessRole()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public Vw_ProcessRole(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public Vw_ProcessRole(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public Vw_ProcessRole(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("ProcessId")]
        [Bindable(true)]
        public int ProcessId 
	    {
		    get
		    {
			    return GetColumnValue<int>("ProcessId");
		    }
            set 
		    {
			    SetColumnValue("ProcessId", value);
            }
        }
	      
        [XmlAttribute("ProcessName")]
        [Bindable(true)]
        public string ProcessName 
	    {
		    get
		    {
			    return GetColumnValue<string>("ProcessName");
		    }
            set 
		    {
			    SetColumnValue("ProcessName", value);
            }
        }
	      
        [XmlAttribute("RoleName")]
        [Bindable(true)]
        public string RoleName 
	    {
		    get
		    {
			    return GetColumnValue<string>("RoleName");
		    }
            set 
		    {
			    SetColumnValue("RoleName", value);
            }
        }
	      
        [XmlAttribute("RoleId")]
        [Bindable(true)]
        public int RoleId 
	    {
		    get
		    {
			    return GetColumnValue<int>("RoleId");
		    }
            set 
		    {
			    SetColumnValue("RoleId", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string ProcessId = @"ProcessId";
            
            public static string ProcessName = @"ProcessName";
            
            public static string RoleName = @"RoleName";
            
            public static string RoleId = @"RoleId";
            
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
