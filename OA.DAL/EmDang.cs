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
	/// Strongly-typed collection for the EmDang class.
	/// </summary>
    [Serializable]
	public partial class EmDangCollection : ActiveList<EmDang, EmDangCollection>
	{	   
		public EmDangCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>EmDangCollection</returns>
		public EmDangCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                EmDang o = this[i];
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
	/// This is an ActiveRecord class which wraps the EmDang_tb table.
	/// </summary>
	[Serializable]
	public partial class EmDang : ActiveRecord<EmDang>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public EmDang()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public EmDang(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public EmDang(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public EmDang(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("EmDang_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarEmDangId = new TableSchema.TableColumn(schema);
				colvarEmDangId.ColumnName = "EmDangId";
				colvarEmDangId.DataType = DbType.Int32;
				colvarEmDangId.MaxLength = 0;
				colvarEmDangId.AutoIncrement = true;
				colvarEmDangId.IsNullable = false;
				colvarEmDangId.IsPrimaryKey = true;
				colvarEmDangId.IsForeignKey = false;
				colvarEmDangId.IsReadOnly = false;
				colvarEmDangId.DefaultSetting = @"";
				colvarEmDangId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEmDangId);
				
				TableSchema.TableColumn colvarEmDangName = new TableSchema.TableColumn(schema);
				colvarEmDangName.ColumnName = "EmDangName";
				colvarEmDangName.DataType = DbType.String;
				colvarEmDangName.MaxLength = 50;
				colvarEmDangName.AutoIncrement = false;
				colvarEmDangName.IsNullable = true;
				colvarEmDangName.IsPrimaryKey = false;
				colvarEmDangName.IsForeignKey = false;
				colvarEmDangName.IsReadOnly = false;
				colvarEmDangName.DefaultSetting = @"";
				colvarEmDangName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEmDangName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("EmDang_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("EmDangId")]
		[Bindable(true)]
		public int EmDangId 
		{
			get { return GetColumnValue<int>(Columns.EmDangId); }
			set { SetColumnValue(Columns.EmDangId, value); }
		}
		  
		[XmlAttribute("EmDangName")]
		[Bindable(true)]
		public string EmDangName 
		{
			get { return GetColumnValue<string>(Columns.EmDangName); }
			set { SetColumnValue(Columns.EmDangName, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varEmDangName)
		{
			EmDang item = new EmDang();
			
			item.EmDangName = varEmDangName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varEmDangId,string varEmDangName)
		{
			EmDang item = new EmDang();
			
				item.EmDangId = varEmDangId;
			
				item.EmDangName = varEmDangName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn EmDangIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn EmDangNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string EmDangId = @"EmDangId";
			 public static string EmDangName = @"EmDangName";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
