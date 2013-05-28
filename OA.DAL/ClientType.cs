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
namespace CanYou.OA.DAL
{
	/// <summary>
	/// Strongly-typed collection for the ClientType class.
	/// </summary>
    [Serializable]
	public partial class ClientTypeCollection : ActiveList<ClientType, ClientTypeCollection>
	{	   
		public ClientTypeCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>ClientTypeCollection</returns>
		public ClientTypeCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                ClientType o = this[i];
                foreach (SubSonic.Where w in this.wheres)
                {
                    bool remove = false;
                    System.Reflection.PropertyInfo pi = o.GetType().GetProperty(w.ColumnName);
                    if (pi.CanRead)
                    {
                        object val = pi.GetValue(o, null);
                        switch (w.Comparison)
                        {
                            case SubSonic.Comparison.Equals:
                                if (!val.Equals(w.ParameterValue))
                                {
                                    remove = true;
                                }
                                break;
                        }
                    }
                    if (remove)
                    {
                        this.Remove(o);
                        break;
                    }
                }
            }
            return this;
        }
		
		
	}
	/// <summary>
	/// This is an ActiveRecord class which wraps the ClientType_tb table.
	/// </summary>
	[Serializable]
	public partial class ClientType : ActiveRecord<ClientType>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public ClientType()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public ClientType(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public ClientType(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public ClientType(string columnName, object columnValue)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByParam(columnName,columnValue);
		}
		
		protected static void SetSQLProps() { GetTableSchema(); }
		
		#endregion
		
		#region Schema and Query Accessor	
		public static Query CreateQuery() { return new Query(Schema); }
		public static TableSchema.Table Schema
		{
			get
			{
				if (BaseSchema == null)
					SetSQLProps();
				return BaseSchema;
			}
		}
		
		private static void GetTableSchema() 
		{
			if(!IsSchemaInitialized)
			{
				//Schema declaration
				TableSchema.Table schema = new TableSchema.Table("ClientType_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarClientTypeId = new TableSchema.TableColumn(schema);
				colvarClientTypeId.ColumnName = "ClientTypeId";
				colvarClientTypeId.DataType = DbType.Int32;
				colvarClientTypeId.MaxLength = 0;
				colvarClientTypeId.AutoIncrement = true;
				colvarClientTypeId.IsNullable = false;
				colvarClientTypeId.IsPrimaryKey = true;
				colvarClientTypeId.IsForeignKey = false;
				colvarClientTypeId.IsReadOnly = false;
				colvarClientTypeId.DefaultSetting = @"";
				colvarClientTypeId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarClientTypeId);
				
				TableSchema.TableColumn colvarClientTypeName = new TableSchema.TableColumn(schema);
				colvarClientTypeName.ColumnName = "ClientTypeName";
				colvarClientTypeName.DataType = DbType.String;
				colvarClientTypeName.MaxLength = 50;
				colvarClientTypeName.AutoIncrement = false;
				colvarClientTypeName.IsNullable = true;
				colvarClientTypeName.IsPrimaryKey = false;
				colvarClientTypeName.IsForeignKey = false;
				colvarClientTypeName.IsReadOnly = false;
				colvarClientTypeName.DefaultSetting = @"";
				colvarClientTypeName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarClientTypeName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("ClientType_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("ClientTypeId")]
		[Bindable(true)]
		public int ClientTypeId 
		{
			get { return GetColumnValue<int>(Columns.ClientTypeId); }
			set { SetColumnValue(Columns.ClientTypeId, value); }
		}
		  
		[XmlAttribute("ClientTypeName")]
		[Bindable(true)]
		public string ClientTypeName 
		{
			get { return GetColumnValue<string>(Columns.ClientTypeName); }
			set { SetColumnValue(Columns.ClientTypeName, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varClientTypeName)
		{
			ClientType item = new ClientType();
			
			item.ClientTypeName = varClientTypeName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varClientTypeId,string varClientTypeName)
		{
			ClientType item = new ClientType();
			
				item.ClientTypeId = varClientTypeId;
			
				item.ClientTypeName = varClientTypeName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn ClientTypeIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ClientTypeNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string ClientTypeId = @"ClientTypeId";
			 public static string ClientTypeName = @"ClientTypeName";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
