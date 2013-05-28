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
	/// Strongly-typed collection for the EmLevel class.
	/// </summary>
    [Serializable]
	public partial class EmLevelCollection : ActiveList<EmLevel, EmLevelCollection>
	{	   
		public EmLevelCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>EmLevelCollection</returns>
		public EmLevelCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                EmLevel o = this[i];
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
	/// This is an ActiveRecord class which wraps the EmLevel_tb table.
	/// </summary>
	[Serializable]
	public partial class EmLevel : ActiveRecord<EmLevel>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public EmLevel()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public EmLevel(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public EmLevel(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public EmLevel(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("EmLevel_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarEmlevelId = new TableSchema.TableColumn(schema);
				colvarEmlevelId.ColumnName = "EmlevelId";
				colvarEmlevelId.DataType = DbType.Int32;
				colvarEmlevelId.MaxLength = 0;
				colvarEmlevelId.AutoIncrement = true;
				colvarEmlevelId.IsNullable = false;
				colvarEmlevelId.IsPrimaryKey = true;
				colvarEmlevelId.IsForeignKey = false;
				colvarEmlevelId.IsReadOnly = false;
				colvarEmlevelId.DefaultSetting = @"";
				colvarEmlevelId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEmlevelId);
				
				TableSchema.TableColumn colvarEmLevelName = new TableSchema.TableColumn(schema);
				colvarEmLevelName.ColumnName = "EmLevelName";
				colvarEmLevelName.DataType = DbType.String;
				colvarEmLevelName.MaxLength = 50;
				colvarEmLevelName.AutoIncrement = false;
				colvarEmLevelName.IsNullable = true;
				colvarEmLevelName.IsPrimaryKey = false;
				colvarEmLevelName.IsForeignKey = false;
				colvarEmLevelName.IsReadOnly = false;
				colvarEmLevelName.DefaultSetting = @"";
				colvarEmLevelName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEmLevelName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("EmLevel_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("EmlevelId")]
		[Bindable(true)]
		public int EmlevelId 
		{
			get { return GetColumnValue<int>(Columns.EmlevelId); }
			set { SetColumnValue(Columns.EmlevelId, value); }
		}
		  
		[XmlAttribute("EmLevelName")]
		[Bindable(true)]
		public string EmLevelName 
		{
			get { return GetColumnValue<string>(Columns.EmLevelName); }
			set { SetColumnValue(Columns.EmLevelName, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varEmLevelName)
		{
			EmLevel item = new EmLevel();
			
			item.EmLevelName = varEmLevelName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varEmlevelId,string varEmLevelName)
		{
			EmLevel item = new EmLevel();
			
				item.EmlevelId = varEmlevelId;
			
				item.EmLevelName = varEmLevelName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn EmlevelIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn EmLevelNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string EmlevelId = @"EmlevelId";
			 public static string EmLevelName = @"EmLevelName";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
