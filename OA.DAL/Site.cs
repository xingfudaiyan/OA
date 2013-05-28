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
	/// Strongly-typed collection for the Site class.
	/// </summary>
    [Serializable]
	public partial class SiteCollection : ActiveList<Site, SiteCollection>
	{	   
		public SiteCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>SiteCollection</returns>
		public SiteCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                Site o = this[i];
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
	/// This is an ActiveRecord class which wraps the Site_tb table.
	/// </summary>
	[Serializable]
	public partial class Site : ActiveRecord<Site>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public Site()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public Site(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public Site(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public Site(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("Site_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarSiteId = new TableSchema.TableColumn(schema);
				colvarSiteId.ColumnName = "SiteId";
				colvarSiteId.DataType = DbType.Int32;
				colvarSiteId.MaxLength = 0;
				colvarSiteId.AutoIncrement = true;
				colvarSiteId.IsNullable = false;
				colvarSiteId.IsPrimaryKey = true;
				colvarSiteId.IsForeignKey = false;
				colvarSiteId.IsReadOnly = false;
				colvarSiteId.DefaultSetting = @"";
				colvarSiteId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSiteId);
				
				TableSchema.TableColumn colvarSiteName = new TableSchema.TableColumn(schema);
				colvarSiteName.ColumnName = "SiteName";
				colvarSiteName.DataType = DbType.String;
				colvarSiteName.MaxLength = 50;
				colvarSiteName.AutoIncrement = false;
				colvarSiteName.IsNullable = false;
				colvarSiteName.IsPrimaryKey = false;
				colvarSiteName.IsForeignKey = false;
				colvarSiteName.IsReadOnly = false;
				colvarSiteName.DefaultSetting = @"";
				colvarSiteName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSiteName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("Site_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("SiteId")]
		[Bindable(true)]
		public int SiteId 
		{
			get { return GetColumnValue<int>(Columns.SiteId); }
			set { SetColumnValue(Columns.SiteId, value); }
		}
		  
		[XmlAttribute("SiteName")]
		[Bindable(true)]
		public string SiteName 
		{
			get { return GetColumnValue<string>(Columns.SiteName); }
			set { SetColumnValue(Columns.SiteName, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varSiteName)
		{
			Site item = new Site();
			
			item.SiteName = varSiteName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varSiteId,string varSiteName)
		{
			Site item = new Site();
			
				item.SiteId = varSiteId;
			
				item.SiteName = varSiteName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn SiteIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn SiteNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string SiteId = @"SiteId";
			 public static string SiteName = @"SiteName";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
