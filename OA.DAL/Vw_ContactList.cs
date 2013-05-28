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
    /// Strongly-typed collection for the Vw_ContactList class.
    /// </summary>
    [Serializable]
    public partial class Vw_ContactListCollection : ReadOnlyList<Vw_ContactList, Vw_ContactListCollection>
    {        
        public Vw_ContactListCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the vw_ContactList view.
    /// </summary>
    [Serializable]
    public partial class Vw_ContactList : ReadOnlyRecord<Vw_ContactList>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("vw_ContactList", TableType.View, DataService.GetInstance("SubsonicProvider"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarContactId = new TableSchema.TableColumn(schema);
                colvarContactId.ColumnName = "ContactId";
                colvarContactId.DataType = DbType.Int32;
                colvarContactId.MaxLength = 0;
                colvarContactId.AutoIncrement = false;
                colvarContactId.IsNullable = false;
                colvarContactId.IsPrimaryKey = false;
                colvarContactId.IsForeignKey = false;
                colvarContactId.IsReadOnly = false;
                
                schema.Columns.Add(colvarContactId);
                
                TableSchema.TableColumn colvarMobile = new TableSchema.TableColumn(schema);
                colvarMobile.ColumnName = "Mobile";
                colvarMobile.DataType = DbType.String;
                colvarMobile.MaxLength = 50;
                colvarMobile.AutoIncrement = false;
                colvarMobile.IsNullable = true;
                colvarMobile.IsPrimaryKey = false;
                colvarMobile.IsForeignKey = false;
                colvarMobile.IsReadOnly = false;
                
                schema.Columns.Add(colvarMobile);
                
                TableSchema.TableColumn colvarOfficephone = new TableSchema.TableColumn(schema);
                colvarOfficephone.ColumnName = "Officephone";
                colvarOfficephone.DataType = DbType.String;
                colvarOfficephone.MaxLength = 50;
                colvarOfficephone.AutoIncrement = false;
                colvarOfficephone.IsNullable = true;
                colvarOfficephone.IsPrimaryKey = false;
                colvarOfficephone.IsForeignKey = false;
                colvarOfficephone.IsReadOnly = false;
                
                schema.Columns.Add(colvarOfficephone);
                
                TableSchema.TableColumn colvarPhoneExt = new TableSchema.TableColumn(schema);
                colvarPhoneExt.ColumnName = "PhoneExt";
                colvarPhoneExt.DataType = DbType.String;
                colvarPhoneExt.MaxLength = 50;
                colvarPhoneExt.AutoIncrement = false;
                colvarPhoneExt.IsNullable = true;
                colvarPhoneExt.IsPrimaryKey = false;
                colvarPhoneExt.IsForeignKey = false;
                colvarPhoneExt.IsReadOnly = false;
                
                schema.Columns.Add(colvarPhoneExt);
                
                TableSchema.TableColumn colvarHomephone = new TableSchema.TableColumn(schema);
                colvarHomephone.ColumnName = "Homephone";
                colvarHomephone.DataType = DbType.String;
                colvarHomephone.MaxLength = 50;
                colvarHomephone.AutoIncrement = false;
                colvarHomephone.IsNullable = true;
                colvarHomephone.IsPrimaryKey = false;
                colvarHomephone.IsForeignKey = false;
                colvarHomephone.IsReadOnly = false;
                
                schema.Columns.Add(colvarHomephone);
                
                TableSchema.TableColumn colvarEmail = new TableSchema.TableColumn(schema);
                colvarEmail.ColumnName = "Email";
                colvarEmail.DataType = DbType.String;
                colvarEmail.MaxLength = 50;
                colvarEmail.AutoIncrement = false;
                colvarEmail.IsNullable = true;
                colvarEmail.IsPrimaryKey = false;
                colvarEmail.IsForeignKey = false;
                colvarEmail.IsReadOnly = false;
                
                schema.Columns.Add(colvarEmail);
                
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
                
                TableSchema.TableColumn colvarPositionName = new TableSchema.TableColumn(schema);
                colvarPositionName.ColumnName = "PositionName";
                colvarPositionName.DataType = DbType.String;
                colvarPositionName.MaxLength = 50;
                colvarPositionName.AutoIncrement = false;
                colvarPositionName.IsNullable = true;
                colvarPositionName.IsPrimaryKey = false;
                colvarPositionName.IsForeignKey = false;
                colvarPositionName.IsReadOnly = false;
                
                schema.Columns.Add(colvarPositionName);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["SubsonicProvider"].AddSchema("vw_ContactList",schema);
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
	    public Vw_ContactList()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public Vw_ContactList(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public Vw_ContactList(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public Vw_ContactList(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("ContactId")]
        [Bindable(true)]
        public int ContactId 
	    {
		    get
		    {
			    return GetColumnValue<int>("ContactId");
		    }
            set 
		    {
			    SetColumnValue("ContactId", value);
            }
        }
	      
        [XmlAttribute("Mobile")]
        [Bindable(true)]
        public string Mobile 
	    {
		    get
		    {
			    return GetColumnValue<string>("Mobile");
		    }
            set 
		    {
			    SetColumnValue("Mobile", value);
            }
        }
	      
        [XmlAttribute("Officephone")]
        [Bindable(true)]
        public string Officephone 
	    {
		    get
		    {
			    return GetColumnValue<string>("Officephone");
		    }
            set 
		    {
			    SetColumnValue("Officephone", value);
            }
        }
	      
        [XmlAttribute("PhoneExt")]
        [Bindable(true)]
        public string PhoneExt 
	    {
		    get
		    {
			    return GetColumnValue<string>("PhoneExt");
		    }
            set 
		    {
			    SetColumnValue("PhoneExt", value);
            }
        }
	      
        [XmlAttribute("Homephone")]
        [Bindable(true)]
        public string Homephone 
	    {
		    get
		    {
			    return GetColumnValue<string>("Homephone");
		    }
            set 
		    {
			    SetColumnValue("Homephone", value);
            }
        }
	      
        [XmlAttribute("Email")]
        [Bindable(true)]
        public string Email 
	    {
		    get
		    {
			    return GetColumnValue<string>("Email");
		    }
            set 
		    {
			    SetColumnValue("Email", value);
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
	      
        [XmlAttribute("PositionName")]
        [Bindable(true)]
        public string PositionName 
	    {
		    get
		    {
			    return GetColumnValue<string>("PositionName");
		    }
            set 
		    {
			    SetColumnValue("PositionName", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string ContactId = @"ContactId";
            
            public static string Mobile = @"Mobile";
            
            public static string Officephone = @"Officephone";
            
            public static string PhoneExt = @"PhoneExt";
            
            public static string Homephone = @"Homephone";
            
            public static string Email = @"Email";
            
            public static string EmployeeName = @"EmployeeName";
            
            public static string DepartName = @"DepartName";
            
            public static string PositionName = @"PositionName";
            
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
