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
	/// Strongly-typed collection for the YeWu class.
	/// </summary>
    [Serializable]
	public partial class YeWuCollection : ActiveList<YeWu, YeWuCollection>
	{	   
		public YeWuCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>YeWuCollection</returns>
		public YeWuCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                YeWu o = this[i];
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
	/// This is an ActiveRecord class which wraps the YeWu_tb table.
	/// </summary>
	[Serializable]
	public partial class YeWu : ActiveRecord<YeWu>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public YeWu()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public YeWu(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public YeWu(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public YeWu(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("YeWu_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarYeWuId = new TableSchema.TableColumn(schema);
				colvarYeWuId.ColumnName = "YeWuId";
				colvarYeWuId.DataType = DbType.Int32;
				colvarYeWuId.MaxLength = 0;
				colvarYeWuId.AutoIncrement = true;
				colvarYeWuId.IsNullable = false;
				colvarYeWuId.IsPrimaryKey = true;
				colvarYeWuId.IsForeignKey = false;
				colvarYeWuId.IsReadOnly = false;
				colvarYeWuId.DefaultSetting = @"";
				colvarYeWuId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarYeWuId);
				
				TableSchema.TableColumn colvarYeWuName = new TableSchema.TableColumn(schema);
				colvarYeWuName.ColumnName = "YeWuName";
				colvarYeWuName.DataType = DbType.String;
				colvarYeWuName.MaxLength = 50;
				colvarYeWuName.AutoIncrement = false;
				colvarYeWuName.IsNullable = true;
				colvarYeWuName.IsPrimaryKey = false;
				colvarYeWuName.IsForeignKey = false;
				colvarYeWuName.IsReadOnly = false;
				colvarYeWuName.DefaultSetting = @"";
				colvarYeWuName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarYeWuName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("YeWu_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("YeWuId")]
		[Bindable(true)]
		public int YeWuId 
		{
			get { return GetColumnValue<int>(Columns.YeWuId); }
			set { SetColumnValue(Columns.YeWuId, value); }
		}
		  
		[XmlAttribute("YeWuName")]
		[Bindable(true)]
		public string YeWuName 
		{
			get { return GetColumnValue<string>(Columns.YeWuName); }
			set { SetColumnValue(Columns.YeWuName, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varYeWuName)
		{
			YeWu item = new YeWu();
			
			item.YeWuName = varYeWuName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varYeWuId,string varYeWuName)
		{
			YeWu item = new YeWu();
			
				item.YeWuId = varYeWuId;
			
				item.YeWuName = varYeWuName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn YeWuIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn YeWuNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string YeWuId = @"YeWuId";
			 public static string YeWuName = @"YeWuName";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
