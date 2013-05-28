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
	/// Strongly-typed collection for the Asset class.
	/// </summary>
    [Serializable]
	public partial class AssetCollection : ActiveList<Asset, AssetCollection>
	{	   
		public AssetCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>AssetCollection</returns>
		public AssetCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                Asset o = this[i];
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
	/// This is an ActiveRecord class which wraps the Asset_tb table.
	/// </summary>
	[Serializable]
	public partial class Asset : ActiveRecord<Asset>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public Asset()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public Asset(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public Asset(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public Asset(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("Asset_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarAssetId = new TableSchema.TableColumn(schema);
				colvarAssetId.ColumnName = "AssetId";
				colvarAssetId.DataType = DbType.Int32;
				colvarAssetId.MaxLength = 0;
				colvarAssetId.AutoIncrement = true;
				colvarAssetId.IsNullable = false;
				colvarAssetId.IsPrimaryKey = true;
				colvarAssetId.IsForeignKey = false;
				colvarAssetId.IsReadOnly = false;
				colvarAssetId.DefaultSetting = @"";
				colvarAssetId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAssetId);
				
				TableSchema.TableColumn colvarAssetName = new TableSchema.TableColumn(schema);
				colvarAssetName.ColumnName = "AssetName";
				colvarAssetName.DataType = DbType.String;
				colvarAssetName.MaxLength = 50;
				colvarAssetName.AutoIncrement = false;
				colvarAssetName.IsNullable = true;
				colvarAssetName.IsPrimaryKey = false;
				colvarAssetName.IsForeignKey = false;
				colvarAssetName.IsReadOnly = false;
				colvarAssetName.DefaultSetting = @"";
				colvarAssetName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAssetName);
				
				TableSchema.TableColumn colvarType = new TableSchema.TableColumn(schema);
				colvarType.ColumnName = "Type";
				colvarType.DataType = DbType.String;
				colvarType.MaxLength = 50;
				colvarType.AutoIncrement = false;
				colvarType.IsNullable = true;
				colvarType.IsPrimaryKey = false;
				colvarType.IsForeignKey = false;
				colvarType.IsReadOnly = false;
				colvarType.DefaultSetting = @"";
				colvarType.ForeignKeyTableName = "";
				schema.Columns.Add(colvarType);
				
				TableSchema.TableColumn colvarDepartName = new TableSchema.TableColumn(schema);
				colvarDepartName.ColumnName = "DepartName";
				colvarDepartName.DataType = DbType.String;
				colvarDepartName.MaxLength = 50;
				colvarDepartName.AutoIncrement = false;
				colvarDepartName.IsNullable = true;
				colvarDepartName.IsPrimaryKey = false;
				colvarDepartName.IsForeignKey = false;
				colvarDepartName.IsReadOnly = false;
				colvarDepartName.DefaultSetting = @"";
				colvarDepartName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDepartName);
				
				TableSchema.TableColumn colvarSiteName = new TableSchema.TableColumn(schema);
				colvarSiteName.ColumnName = "SiteName";
				colvarSiteName.DataType = DbType.String;
				colvarSiteName.MaxLength = 50;
				colvarSiteName.AutoIncrement = false;
				colvarSiteName.IsNullable = true;
				colvarSiteName.IsPrimaryKey = false;
				colvarSiteName.IsForeignKey = false;
				colvarSiteName.IsReadOnly = false;
				colvarSiteName.DefaultSetting = @"";
				colvarSiteName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSiteName);
				
				TableSchema.TableColumn colvarUnitName = new TableSchema.TableColumn(schema);
				colvarUnitName.ColumnName = "UnitName";
				colvarUnitName.DataType = DbType.String;
				colvarUnitName.MaxLength = 50;
				colvarUnitName.AutoIncrement = false;
				colvarUnitName.IsNullable = true;
				colvarUnitName.IsPrimaryKey = false;
				colvarUnitName.IsForeignKey = false;
				colvarUnitName.IsReadOnly = false;
				colvarUnitName.DefaultSetting = @"";
				colvarUnitName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUnitName);
				
				TableSchema.TableColumn colvarAmount = new TableSchema.TableColumn(schema);
				colvarAmount.ColumnName = "Amount";
				colvarAmount.DataType = DbType.String;
				colvarAmount.MaxLength = 50;
				colvarAmount.AutoIncrement = false;
				colvarAmount.IsNullable = true;
				colvarAmount.IsPrimaryKey = false;
				colvarAmount.IsForeignKey = false;
				colvarAmount.IsReadOnly = false;
				colvarAmount.DefaultSetting = @"";
				colvarAmount.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAmount);
				
				TableSchema.TableColumn colvarPrice = new TableSchema.TableColumn(schema);
				colvarPrice.ColumnName = "Price";
				colvarPrice.DataType = DbType.String;
				colvarPrice.MaxLength = 50;
				colvarPrice.AutoIncrement = false;
				colvarPrice.IsNullable = true;
				colvarPrice.IsPrimaryKey = false;
				colvarPrice.IsForeignKey = false;
				colvarPrice.IsReadOnly = false;
				colvarPrice.DefaultSetting = @"";
				colvarPrice.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPrice);
				
				TableSchema.TableColumn colvarMemo = new TableSchema.TableColumn(schema);
				colvarMemo.ColumnName = "Memo";
				colvarMemo.DataType = DbType.String;
				colvarMemo.MaxLength = -1;
				colvarMemo.AutoIncrement = false;
				colvarMemo.IsNullable = true;
				colvarMemo.IsPrimaryKey = false;
				colvarMemo.IsForeignKey = false;
				colvarMemo.IsReadOnly = false;
				colvarMemo.DefaultSetting = @"";
				colvarMemo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMemo);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("Asset_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("AssetId")]
		[Bindable(true)]
		public int AssetId 
		{
			get { return GetColumnValue<int>(Columns.AssetId); }
			set { SetColumnValue(Columns.AssetId, value); }
		}
		  
		[XmlAttribute("AssetName")]
		[Bindable(true)]
		public string AssetName 
		{
			get { return GetColumnValue<string>(Columns.AssetName); }
			set { SetColumnValue(Columns.AssetName, value); }
		}
		  
		[XmlAttribute("Type")]
		[Bindable(true)]
		public string Type 
		{
			get { return GetColumnValue<string>(Columns.Type); }
			set { SetColumnValue(Columns.Type, value); }
		}
		  
		[XmlAttribute("DepartName")]
		[Bindable(true)]
		public string DepartName 
		{
			get { return GetColumnValue<string>(Columns.DepartName); }
			set { SetColumnValue(Columns.DepartName, value); }
		}
		  
		[XmlAttribute("SiteName")]
		[Bindable(true)]
		public string SiteName 
		{
			get { return GetColumnValue<string>(Columns.SiteName); }
			set { SetColumnValue(Columns.SiteName, value); }
		}
		  
		[XmlAttribute("UnitName")]
		[Bindable(true)]
		public string UnitName 
		{
			get { return GetColumnValue<string>(Columns.UnitName); }
			set { SetColumnValue(Columns.UnitName, value); }
		}
		  
		[XmlAttribute("Amount")]
		[Bindable(true)]
		public string Amount 
		{
			get { return GetColumnValue<string>(Columns.Amount); }
			set { SetColumnValue(Columns.Amount, value); }
		}
		  
		[XmlAttribute("Price")]
		[Bindable(true)]
		public string Price 
		{
			get { return GetColumnValue<string>(Columns.Price); }
			set { SetColumnValue(Columns.Price, value); }
		}
		  
		[XmlAttribute("Memo")]
		[Bindable(true)]
		public string Memo 
		{
			get { return GetColumnValue<string>(Columns.Memo); }
			set { SetColumnValue(Columns.Memo, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varAssetName,string varType,string varDepartName,string varSiteName,string varUnitName,string varAmount,string varPrice,string varMemo)
		{
			Asset item = new Asset();
			
			item.AssetName = varAssetName;
			
			item.Type = varType;
			
			item.DepartName = varDepartName;
			
			item.SiteName = varSiteName;
			
			item.UnitName = varUnitName;
			
			item.Amount = varAmount;
			
			item.Price = varPrice;
			
			item.Memo = varMemo;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varAssetId,string varAssetName,string varType,string varDepartName,string varSiteName,string varUnitName,string varAmount,string varPrice,string varMemo)
		{
			Asset item = new Asset();
			
				item.AssetId = varAssetId;
			
				item.AssetName = varAssetName;
			
				item.Type = varType;
			
				item.DepartName = varDepartName;
			
				item.SiteName = varSiteName;
			
				item.UnitName = varUnitName;
			
				item.Amount = varAmount;
			
				item.Price = varPrice;
			
				item.Memo = varMemo;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn AssetIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn AssetNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn TypeColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn DepartNameColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn SiteNameColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn UnitNameColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn AmountColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn PriceColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn MemoColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string AssetId = @"AssetId";
			 public static string AssetName = @"AssetName";
			 public static string Type = @"Type";
			 public static string DepartName = @"DepartName";
			 public static string SiteName = @"SiteName";
			 public static string UnitName = @"UnitName";
			 public static string Amount = @"Amount";
			 public static string Price = @"Price";
			 public static string Memo = @"Memo";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
