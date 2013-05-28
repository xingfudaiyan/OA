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
	/// Strongly-typed collection for the StampType class.
	/// </summary>
    [Serializable]
	public partial class StampTypeCollection : ActiveList<StampType, StampTypeCollection>
	{	   
		public StampTypeCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>StampTypeCollection</returns>
		public StampTypeCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                StampType o = this[i];
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
	/// This is an ActiveRecord class which wraps the StampType_tb table.
	/// </summary>
	[Serializable]
	public partial class StampType : ActiveRecord<StampType>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public StampType()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public StampType(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public StampType(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public StampType(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("StampType_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarStampTypeId = new TableSchema.TableColumn(schema);
				colvarStampTypeId.ColumnName = "StampTypeId";
				colvarStampTypeId.DataType = DbType.Int32;
				colvarStampTypeId.MaxLength = 0;
				colvarStampTypeId.AutoIncrement = true;
				colvarStampTypeId.IsNullable = false;
				colvarStampTypeId.IsPrimaryKey = true;
				colvarStampTypeId.IsForeignKey = false;
				colvarStampTypeId.IsReadOnly = false;
				colvarStampTypeId.DefaultSetting = @"";
				colvarStampTypeId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarStampTypeId);
				
				TableSchema.TableColumn colvarStampName = new TableSchema.TableColumn(schema);
				colvarStampName.ColumnName = "StampName";
				colvarStampName.DataType = DbType.String;
				colvarStampName.MaxLength = 50;
				colvarStampName.AutoIncrement = false;
				colvarStampName.IsNullable = true;
				colvarStampName.IsPrimaryKey = false;
				colvarStampName.IsForeignKey = false;
				colvarStampName.IsReadOnly = false;
				colvarStampName.DefaultSetting = @"";
				colvarStampName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarStampName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("StampType_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("StampTypeId")]
		[Bindable(true)]
		public int StampTypeId 
		{
			get { return GetColumnValue<int>(Columns.StampTypeId); }
			set { SetColumnValue(Columns.StampTypeId, value); }
		}
		  
		[XmlAttribute("StampName")]
		[Bindable(true)]
		public string StampName 
		{
			get { return GetColumnValue<string>(Columns.StampName); }
			set { SetColumnValue(Columns.StampName, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varStampName)
		{
			StampType item = new StampType();
			
			item.StampName = varStampName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varStampTypeId,string varStampName)
		{
			StampType item = new StampType();
			
				item.StampTypeId = varStampTypeId;
			
				item.StampName = varStampName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn StampTypeIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn StampNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string StampTypeId = @"StampTypeId";
			 public static string StampName = @"StampName";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
