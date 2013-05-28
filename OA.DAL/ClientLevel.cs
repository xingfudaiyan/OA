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
	/// Strongly-typed collection for the ClientLevel class.
	/// </summary>
    [Serializable]
	public partial class ClientLevelCollection : ActiveList<ClientLevel, ClientLevelCollection>
	{	   
		public ClientLevelCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>ClientLevelCollection</returns>
		public ClientLevelCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                ClientLevel o = this[i];
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
	/// This is an ActiveRecord class which wraps the ClientLevel_tb table.
	/// </summary>
	[Serializable]
	public partial class ClientLevel : ActiveRecord<ClientLevel>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public ClientLevel()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public ClientLevel(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public ClientLevel(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public ClientLevel(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("ClientLevel_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarClientLevelId = new TableSchema.TableColumn(schema);
				colvarClientLevelId.ColumnName = "ClientLevelId";
				colvarClientLevelId.DataType = DbType.Int32;
				colvarClientLevelId.MaxLength = 0;
				colvarClientLevelId.AutoIncrement = true;
				colvarClientLevelId.IsNullable = false;
				colvarClientLevelId.IsPrimaryKey = true;
				colvarClientLevelId.IsForeignKey = false;
				colvarClientLevelId.IsReadOnly = false;
				colvarClientLevelId.DefaultSetting = @"";
				colvarClientLevelId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarClientLevelId);
				
				TableSchema.TableColumn colvarClientLevelName = new TableSchema.TableColumn(schema);
				colvarClientLevelName.ColumnName = "ClientLevelName";
				colvarClientLevelName.DataType = DbType.String;
				colvarClientLevelName.MaxLength = 50;
				colvarClientLevelName.AutoIncrement = false;
				colvarClientLevelName.IsNullable = true;
				colvarClientLevelName.IsPrimaryKey = false;
				colvarClientLevelName.IsForeignKey = false;
				colvarClientLevelName.IsReadOnly = false;
				colvarClientLevelName.DefaultSetting = @"";
				colvarClientLevelName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarClientLevelName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("ClientLevel_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("ClientLevelId")]
		[Bindable(true)]
		public int ClientLevelId 
		{
			get { return GetColumnValue<int>(Columns.ClientLevelId); }
			set { SetColumnValue(Columns.ClientLevelId, value); }
		}
		  
		[XmlAttribute("ClientLevelName")]
		[Bindable(true)]
		public string ClientLevelName 
		{
			get { return GetColumnValue<string>(Columns.ClientLevelName); }
			set { SetColumnValue(Columns.ClientLevelName, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varClientLevelName)
		{
			ClientLevel item = new ClientLevel();
			
			item.ClientLevelName = varClientLevelName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varClientLevelId,string varClientLevelName)
		{
			ClientLevel item = new ClientLevel();
			
				item.ClientLevelId = varClientLevelId;
			
				item.ClientLevelName = varClientLevelName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn ClientLevelIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ClientLevelNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string ClientLevelId = @"ClientLevelId";
			 public static string ClientLevelName = @"ClientLevelName";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
