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
	/// Strongly-typed collection for the MainOfferPrice class.
	/// </summary>
    [Serializable]
	public partial class MainOfferPriceCollection : ActiveList<MainOfferPrice, MainOfferPriceCollection>
	{	   
		public MainOfferPriceCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>MainOfferPriceCollection</returns>
		public MainOfferPriceCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                MainOfferPrice o = this[i];
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
	/// This is an ActiveRecord class which wraps the MainOfferPrice_tb table.
	/// </summary>
	[Serializable]
	public partial class MainOfferPrice : ActiveRecord<MainOfferPrice>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public MainOfferPrice()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public MainOfferPrice(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public MainOfferPrice(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public MainOfferPrice(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("MainOfferPrice_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarMainOfferPriceId = new TableSchema.TableColumn(schema);
				colvarMainOfferPriceId.ColumnName = "MainOfferPriceId";
				colvarMainOfferPriceId.DataType = DbType.Int32;
				colvarMainOfferPriceId.MaxLength = 0;
				colvarMainOfferPriceId.AutoIncrement = true;
				colvarMainOfferPriceId.IsNullable = false;
				colvarMainOfferPriceId.IsPrimaryKey = true;
				colvarMainOfferPriceId.IsForeignKey = false;
				colvarMainOfferPriceId.IsReadOnly = false;
				colvarMainOfferPriceId.DefaultSetting = @"";
				colvarMainOfferPriceId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMainOfferPriceId);
				
				TableSchema.TableColumn colvarMainOfferPriceName = new TableSchema.TableColumn(schema);
				colvarMainOfferPriceName.ColumnName = "MainOfferPriceName";
				colvarMainOfferPriceName.DataType = DbType.String;
				colvarMainOfferPriceName.MaxLength = 50;
				colvarMainOfferPriceName.AutoIncrement = false;
				colvarMainOfferPriceName.IsNullable = true;
				colvarMainOfferPriceName.IsPrimaryKey = false;
				colvarMainOfferPriceName.IsForeignKey = false;
				colvarMainOfferPriceName.IsReadOnly = false;
				colvarMainOfferPriceName.DefaultSetting = @"";
				colvarMainOfferPriceName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMainOfferPriceName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("MainOfferPrice_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("MainOfferPriceId")]
		[Bindable(true)]
		public int MainOfferPriceId 
		{
			get { return GetColumnValue<int>(Columns.MainOfferPriceId); }
			set { SetColumnValue(Columns.MainOfferPriceId, value); }
		}
		  
		[XmlAttribute("MainOfferPriceName")]
		[Bindable(true)]
		public string MainOfferPriceName 
		{
			get { return GetColumnValue<string>(Columns.MainOfferPriceName); }
			set { SetColumnValue(Columns.MainOfferPriceName, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varMainOfferPriceName)
		{
			MainOfferPrice item = new MainOfferPrice();
			
			item.MainOfferPriceName = varMainOfferPriceName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varMainOfferPriceId,string varMainOfferPriceName)
		{
			MainOfferPrice item = new MainOfferPrice();
			
				item.MainOfferPriceId = varMainOfferPriceId;
			
				item.MainOfferPriceName = varMainOfferPriceName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn MainOfferPriceIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn MainOfferPriceNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string MainOfferPriceId = @"MainOfferPriceId";
			 public static string MainOfferPriceName = @"MainOfferPriceName";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
