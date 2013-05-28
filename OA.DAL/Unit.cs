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
	/// Strongly-typed collection for the Unit class.
	/// </summary>
    [Serializable]
	public partial class UnitCollection : ActiveList<Unit, UnitCollection>
	{	   
		public UnitCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>UnitCollection</returns>
		public UnitCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                Unit o = this[i];
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
	/// This is an ActiveRecord class which wraps the Unit_tb table.
	/// </summary>
	[Serializable]
	public partial class Unit : ActiveRecord<Unit>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public Unit()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public Unit(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public Unit(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public Unit(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("Unit_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarUnitId = new TableSchema.TableColumn(schema);
				colvarUnitId.ColumnName = "UnitId";
				colvarUnitId.DataType = DbType.Int32;
				colvarUnitId.MaxLength = 0;
				colvarUnitId.AutoIncrement = true;
				colvarUnitId.IsNullable = false;
				colvarUnitId.IsPrimaryKey = true;
				colvarUnitId.IsForeignKey = false;
				colvarUnitId.IsReadOnly = false;
				colvarUnitId.DefaultSetting = @"";
				colvarUnitId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUnitId);
				
				TableSchema.TableColumn colvarUnitName = new TableSchema.TableColumn(schema);
				colvarUnitName.ColumnName = "UnitName";
				colvarUnitName.DataType = DbType.String;
				colvarUnitName.MaxLength = 50;
				colvarUnitName.AutoIncrement = false;
				colvarUnitName.IsNullable = false;
				colvarUnitName.IsPrimaryKey = false;
				colvarUnitName.IsForeignKey = false;
				colvarUnitName.IsReadOnly = false;
				colvarUnitName.DefaultSetting = @"";
				colvarUnitName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUnitName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("Unit_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("UnitId")]
		[Bindable(true)]
		public int UnitId 
		{
			get { return GetColumnValue<int>(Columns.UnitId); }
			set { SetColumnValue(Columns.UnitId, value); }
		}
		  
		[XmlAttribute("UnitName")]
		[Bindable(true)]
		public string UnitName 
		{
			get { return GetColumnValue<string>(Columns.UnitName); }
			set { SetColumnValue(Columns.UnitName, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varUnitName)
		{
			Unit item = new Unit();
			
			item.UnitName = varUnitName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varUnitId,string varUnitName)
		{
			Unit item = new Unit();
			
				item.UnitId = varUnitId;
			
				item.UnitName = varUnitName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn UnitIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn UnitNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string UnitId = @"UnitId";
			 public static string UnitName = @"UnitName";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
