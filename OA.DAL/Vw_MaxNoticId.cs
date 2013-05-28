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
    /// Strongly-typed collection for the Vw_MaxNoticId class.
    /// </summary>
    [Serializable]
    public partial class Vw_MaxNoticIdCollection : ReadOnlyList<Vw_MaxNoticId, Vw_MaxNoticIdCollection>
    {        
        public Vw_MaxNoticIdCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the vw_MaxNoticId view.
    /// </summary>
    [Serializable]
    public partial class Vw_MaxNoticId : ReadOnlyRecord<Vw_MaxNoticId>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("vw_MaxNoticId", TableType.View, DataService.GetInstance("SubsonicProvider"));
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
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["SubsonicProvider"].AddSchema("vw_MaxNoticId",schema);
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
	    public Vw_MaxNoticId()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public Vw_MaxNoticId(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public Vw_MaxNoticId(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public Vw_MaxNoticId(string columnName, object columnValue)
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
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string NoticeId = @"NoticeId";
            
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
