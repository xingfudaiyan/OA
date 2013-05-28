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
	/// Strongly-typed collection for the HolidayType class.
	/// </summary>
    [Serializable]
	public partial class HolidayTypeCollection : ActiveList<HolidayType, HolidayTypeCollection>
	{	   
		public HolidayTypeCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>HolidayTypeCollection</returns>
		public HolidayTypeCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                HolidayType o = this[i];
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
	/// This is an ActiveRecord class which wraps the HolidayType_tb table.
	/// </summary>
	[Serializable]
	public partial class HolidayType : ActiveRecord<HolidayType>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public HolidayType()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public HolidayType(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public HolidayType(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public HolidayType(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("HolidayType_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarHolidayTypeId = new TableSchema.TableColumn(schema);
				colvarHolidayTypeId.ColumnName = "HolidayTypeId";
				colvarHolidayTypeId.DataType = DbType.Int32;
				colvarHolidayTypeId.MaxLength = 0;
				colvarHolidayTypeId.AutoIncrement = true;
				colvarHolidayTypeId.IsNullable = false;
				colvarHolidayTypeId.IsPrimaryKey = true;
				colvarHolidayTypeId.IsForeignKey = false;
				colvarHolidayTypeId.IsReadOnly = false;
				colvarHolidayTypeId.DefaultSetting = @"";
				colvarHolidayTypeId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarHolidayTypeId);
				
				TableSchema.TableColumn colvarHolidayTypeName = new TableSchema.TableColumn(schema);
				colvarHolidayTypeName.ColumnName = "HolidayTypeName";
				colvarHolidayTypeName.DataType = DbType.String;
				colvarHolidayTypeName.MaxLength = 50;
				colvarHolidayTypeName.AutoIncrement = false;
				colvarHolidayTypeName.IsNullable = false;
				colvarHolidayTypeName.IsPrimaryKey = false;
				colvarHolidayTypeName.IsForeignKey = false;
				colvarHolidayTypeName.IsReadOnly = false;
				colvarHolidayTypeName.DefaultSetting = @"";
				colvarHolidayTypeName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarHolidayTypeName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("HolidayType_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("HolidayTypeId")]
		[Bindable(true)]
		public int HolidayTypeId 
		{
			get { return GetColumnValue<int>(Columns.HolidayTypeId); }
			set { SetColumnValue(Columns.HolidayTypeId, value); }
		}
		  
		[XmlAttribute("HolidayTypeName")]
		[Bindable(true)]
		public string HolidayTypeName 
		{
			get { return GetColumnValue<string>(Columns.HolidayTypeName); }
			set { SetColumnValue(Columns.HolidayTypeName, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varHolidayTypeName)
		{
			HolidayType item = new HolidayType();
			
			item.HolidayTypeName = varHolidayTypeName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varHolidayTypeId,string varHolidayTypeName)
		{
			HolidayType item = new HolidayType();
			
				item.HolidayTypeId = varHolidayTypeId;
			
				item.HolidayTypeName = varHolidayTypeName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn HolidayTypeIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn HolidayTypeNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string HolidayTypeId = @"HolidayTypeId";
			 public static string HolidayTypeName = @"HolidayTypeName";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
