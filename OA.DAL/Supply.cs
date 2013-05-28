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
	/// Strongly-typed collection for the Supply class.
	/// </summary>
    [Serializable]
	public partial class SupplyCollection : ActiveList<Supply, SupplyCollection>
	{	   
		public SupplyCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>SupplyCollection</returns>
		public SupplyCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                Supply o = this[i];
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
	/// This is an ActiveRecord class which wraps the Supply_tb table.
	/// </summary>
	[Serializable]
	public partial class Supply : ActiveRecord<Supply>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public Supply()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public Supply(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public Supply(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public Supply(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("Supply_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarSupplyId = new TableSchema.TableColumn(schema);
				colvarSupplyId.ColumnName = "SupplyId";
				colvarSupplyId.DataType = DbType.Int32;
				colvarSupplyId.MaxLength = 0;
				colvarSupplyId.AutoIncrement = true;
				colvarSupplyId.IsNullable = false;
				colvarSupplyId.IsPrimaryKey = true;
				colvarSupplyId.IsForeignKey = false;
				colvarSupplyId.IsReadOnly = false;
				colvarSupplyId.DefaultSetting = @"";
				colvarSupplyId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSupplyId);
				
				TableSchema.TableColumn colvarSupplyName = new TableSchema.TableColumn(schema);
				colvarSupplyName.ColumnName = "SupplyName";
				colvarSupplyName.DataType = DbType.String;
				colvarSupplyName.MaxLength = 50;
				colvarSupplyName.AutoIncrement = false;
				colvarSupplyName.IsNullable = true;
				colvarSupplyName.IsPrimaryKey = false;
				colvarSupplyName.IsForeignKey = false;
				colvarSupplyName.IsReadOnly = false;
				colvarSupplyName.DefaultSetting = @"";
				colvarSupplyName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSupplyName);
				
				TableSchema.TableColumn colvarSheetNum = new TableSchema.TableColumn(schema);
				colvarSheetNum.ColumnName = "SheetNum";
				colvarSheetNum.DataType = DbType.String;
				colvarSheetNum.MaxLength = 50;
				colvarSheetNum.AutoIncrement = false;
				colvarSheetNum.IsNullable = true;
				colvarSheetNum.IsPrimaryKey = false;
				colvarSheetNum.IsForeignKey = false;
				colvarSheetNum.IsReadOnly = false;
				colvarSheetNum.DefaultSetting = @"";
				colvarSheetNum.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSheetNum);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("Supply_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("SupplyId")]
		[Bindable(true)]
		public int SupplyId 
		{
			get { return GetColumnValue<int>(Columns.SupplyId); }
			set { SetColumnValue(Columns.SupplyId, value); }
		}
		  
		[XmlAttribute("SupplyName")]
		[Bindable(true)]
		public string SupplyName 
		{
			get { return GetColumnValue<string>(Columns.SupplyName); }
			set { SetColumnValue(Columns.SupplyName, value); }
		}
		  
		[XmlAttribute("SheetNum")]
		[Bindable(true)]
		public string SheetNum 
		{
			get { return GetColumnValue<string>(Columns.SheetNum); }
			set { SetColumnValue(Columns.SheetNum, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varSupplyName,string varSheetNum)
		{
			Supply item = new Supply();
			
			item.SupplyName = varSupplyName;
			
			item.SheetNum = varSheetNum;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varSupplyId,string varSupplyName,string varSheetNum)
		{
			Supply item = new Supply();
			
				item.SupplyId = varSupplyId;
			
				item.SupplyName = varSupplyName;
			
				item.SheetNum = varSheetNum;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn SupplyIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn SupplyNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn SheetNumColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string SupplyId = @"SupplyId";
			 public static string SupplyName = @"SupplyName";
			 public static string SheetNum = @"SheetNum";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
