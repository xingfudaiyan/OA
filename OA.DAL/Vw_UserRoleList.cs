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
    /// Strongly-typed collection for the Vw_UserRoleList class.
    /// </summary>
    [Serializable]
    public partial class Vw_UserRoleListCollection : ReadOnlyList<Vw_UserRoleList, Vw_UserRoleListCollection>
    {        
        public Vw_UserRoleListCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the vw_UserRoleList view.
    /// </summary>
    [Serializable]
    public partial class Vw_UserRoleList : ReadOnlyRecord<Vw_UserRoleList>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("vw_UserRoleList", TableType.View, DataService.GetInstance("SubsonicProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
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
                DataService.Providers["SubsonicProvider"].AddSchema("vw_UserRoleList",schema);
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
	    public Vw_UserRoleList()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public Vw_UserRoleList(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public Vw_UserRoleList(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public Vw_UserRoleList(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
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
		    
		    
            public static string EmployeeName = @"EmployeeName";
            
            public static string MasterName = @"MasterName";
            
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
