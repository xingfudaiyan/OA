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
	/// Strongly-typed collection for the ProductType class.
	/// </summary>
    [Serializable]
	public partial class ProductTypeCollection : ActiveList<ProductType, ProductTypeCollection>
	{	   
		public ProductTypeCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>ProductTypeCollection</returns>
		public ProductTypeCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                ProductType o = this[i];
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
	/// This is an ActiveRecord class which wraps the ProductType_tb table.
	/// </summary>
	[Serializable]
	public partial class ProductType : ActiveRecord<ProductType>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public ProductType()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public ProductType(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public ProductType(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public ProductType(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("ProductType_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarProductTypeId = new TableSchema.TableColumn(schema);
				colvarProductTypeId.ColumnName = "ProductTypeId";
				colvarProductTypeId.DataType = DbType.Int32;
				colvarProductTypeId.MaxLength = 0;
				colvarProductTypeId.AutoIncrement = true;
				colvarProductTypeId.IsNullable = false;
				colvarProductTypeId.IsPrimaryKey = true;
				colvarProductTypeId.IsForeignKey = false;
				colvarProductTypeId.IsReadOnly = false;
				colvarProductTypeId.DefaultSetting = @"";
				colvarProductTypeId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProductTypeId);
				
				TableSchema.TableColumn colvarProductName = new TableSchema.TableColumn(schema);
				colvarProductName.ColumnName = "ProductName";
				colvarProductName.DataType = DbType.String;
				colvarProductName.MaxLength = 50;
				colvarProductName.AutoIncrement = false;
				colvarProductName.IsNullable = true;
				colvarProductName.IsPrimaryKey = false;
				colvarProductName.IsForeignKey = false;
				colvarProductName.IsReadOnly = false;
				colvarProductName.DefaultSetting = @"";
				colvarProductName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProductName);
				
				TableSchema.TableColumn colvarOfferPriceId = new TableSchema.TableColumn(schema);
				colvarOfferPriceId.ColumnName = "OfferPriceId";
				colvarOfferPriceId.DataType = DbType.Int32;
				colvarOfferPriceId.MaxLength = 0;
				colvarOfferPriceId.AutoIncrement = false;
				colvarOfferPriceId.IsNullable = true;
				colvarOfferPriceId.IsPrimaryKey = false;
				colvarOfferPriceId.IsForeignKey = false;
				colvarOfferPriceId.IsReadOnly = false;
				colvarOfferPriceId.DefaultSetting = @"";
				colvarOfferPriceId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOfferPriceId);
				
				TableSchema.TableColumn colvarModel = new TableSchema.TableColumn(schema);
				colvarModel.ColumnName = "Model";
				colvarModel.DataType = DbType.String;
				colvarModel.MaxLength = 50;
				colvarModel.AutoIncrement = false;
				colvarModel.IsNullable = true;
				colvarModel.IsPrimaryKey = false;
				colvarModel.IsForeignKey = false;
				colvarModel.IsReadOnly = false;
				colvarModel.DefaultSetting = @"";
				colvarModel.ForeignKeyTableName = "";
				schema.Columns.Add(colvarModel);
				
				TableSchema.TableColumn colvarUnit = new TableSchema.TableColumn(schema);
				colvarUnit.ColumnName = "Unit";
				colvarUnit.DataType = DbType.String;
				colvarUnit.MaxLength = 50;
				colvarUnit.AutoIncrement = false;
				colvarUnit.IsNullable = true;
				colvarUnit.IsPrimaryKey = false;
				colvarUnit.IsForeignKey = false;
				colvarUnit.IsReadOnly = false;
				colvarUnit.DefaultSetting = @"";
				colvarUnit.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUnit);
				
				TableSchema.TableColumn colvarNum = new TableSchema.TableColumn(schema);
				colvarNum.ColumnName = "Num";
				colvarNum.DataType = DbType.String;
				colvarNum.MaxLength = 50;
				colvarNum.AutoIncrement = false;
				colvarNum.IsNullable = true;
				colvarNum.IsPrimaryKey = false;
				colvarNum.IsForeignKey = false;
				colvarNum.IsReadOnly = false;
				colvarNum.DefaultSetting = @"";
				colvarNum.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNum);
				
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
				
				TableSchema.TableColumn colvarSums = new TableSchema.TableColumn(schema);
				colvarSums.ColumnName = "Sums";
				colvarSums.DataType = DbType.String;
				colvarSums.MaxLength = 50;
				colvarSums.AutoIncrement = false;
				colvarSums.IsNullable = true;
				colvarSums.IsPrimaryKey = false;
				colvarSums.IsForeignKey = false;
				colvarSums.IsReadOnly = false;
				colvarSums.DefaultSetting = @"";
				colvarSums.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSums);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("ProductType_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("ProductTypeId")]
		[Bindable(true)]
		public int ProductTypeId 
		{
			get { return GetColumnValue<int>(Columns.ProductTypeId); }
			set { SetColumnValue(Columns.ProductTypeId, value); }
		}
		  
		[XmlAttribute("ProductName")]
		[Bindable(true)]
		public string ProductName 
		{
			get { return GetColumnValue<string>(Columns.ProductName); }
			set { SetColumnValue(Columns.ProductName, value); }
		}
		  
		[XmlAttribute("OfferPriceId")]
		[Bindable(true)]
		public int? OfferPriceId 
		{
			get { return GetColumnValue<int?>(Columns.OfferPriceId); }
			set { SetColumnValue(Columns.OfferPriceId, value); }
		}
		  
		[XmlAttribute("Model")]
		[Bindable(true)]
		public string Model 
		{
			get { return GetColumnValue<string>(Columns.Model); }
			set { SetColumnValue(Columns.Model, value); }
		}
		  
		[XmlAttribute("Unit")]
		[Bindable(true)]
		public string Unit 
		{
			get { return GetColumnValue<string>(Columns.Unit); }
			set { SetColumnValue(Columns.Unit, value); }
		}
		  
		[XmlAttribute("Num")]
		[Bindable(true)]
		public string Num 
		{
			get { return GetColumnValue<string>(Columns.Num); }
			set { SetColumnValue(Columns.Num, value); }
		}
		  
		[XmlAttribute("Price")]
		[Bindable(true)]
		public string Price 
		{
			get { return GetColumnValue<string>(Columns.Price); }
			set { SetColumnValue(Columns.Price, value); }
		}
		  
		[XmlAttribute("Sums")]
		[Bindable(true)]
		public string Sums 
		{
			get { return GetColumnValue<string>(Columns.Sums); }
			set { SetColumnValue(Columns.Sums, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varProductName,int? varOfferPriceId,string varModel,string varUnit,string varNum,string varPrice,string varSums)
		{
			ProductType item = new ProductType();
			
			item.ProductName = varProductName;
			
			item.OfferPriceId = varOfferPriceId;
			
			item.Model = varModel;
			
			item.Unit = varUnit;
			
			item.Num = varNum;
			
			item.Price = varPrice;
			
			item.Sums = varSums;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varProductTypeId,string varProductName,int? varOfferPriceId,string varModel,string varUnit,string varNum,string varPrice,string varSums)
		{
			ProductType item = new ProductType();
			
				item.ProductTypeId = varProductTypeId;
			
				item.ProductName = varProductName;
			
				item.OfferPriceId = varOfferPriceId;
			
				item.Model = varModel;
			
				item.Unit = varUnit;
			
				item.Num = varNum;
			
				item.Price = varPrice;
			
				item.Sums = varSums;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn ProductTypeIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ProductNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn OfferPriceIdColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn ModelColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn UnitColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn NumColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn PriceColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn SumsColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string ProductTypeId = @"ProductTypeId";
			 public static string ProductName = @"ProductName";
			 public static string OfferPriceId = @"OfferPriceId";
			 public static string Model = @"Model";
			 public static string Unit = @"Unit";
			 public static string Num = @"Num";
			 public static string Price = @"Price";
			 public static string Sums = @"Sums";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
