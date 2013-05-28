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
	/// Strongly-typed collection for the RelateBExp class.
	/// </summary>
    [Serializable]
	public partial class RelateBExpCollection : ActiveList<RelateBExp, RelateBExpCollection>
	{	   
		public RelateBExpCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>RelateBExpCollection</returns>
		public RelateBExpCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                RelateBExp o = this[i];
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
	/// This is an ActiveRecord class which wraps the RelateBExp_tb table.
	/// </summary>
	[Serializable]
	public partial class RelateBExp : ActiveRecord<RelateBExp>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public RelateBExp()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public RelateBExp(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public RelateBExp(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public RelateBExp(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("RelateBExp_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarRelateBExpId = new TableSchema.TableColumn(schema);
				colvarRelateBExpId.ColumnName = "RelateBExpId";
				colvarRelateBExpId.DataType = DbType.Int32;
				colvarRelateBExpId.MaxLength = 0;
				colvarRelateBExpId.AutoIncrement = true;
				colvarRelateBExpId.IsNullable = false;
				colvarRelateBExpId.IsPrimaryKey = true;
				colvarRelateBExpId.IsForeignKey = false;
				colvarRelateBExpId.IsReadOnly = false;
				colvarRelateBExpId.DefaultSetting = @"";
				colvarRelateBExpId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRelateBExpId);
				
				TableSchema.TableColumn colvarRelateId = new TableSchema.TableColumn(schema);
				colvarRelateId.ColumnName = "RelateId";
				colvarRelateId.DataType = DbType.Int32;
				colvarRelateId.MaxLength = 0;
				colvarRelateId.AutoIncrement = false;
				colvarRelateId.IsNullable = true;
				colvarRelateId.IsPrimaryKey = false;
				colvarRelateId.IsForeignKey = false;
				colvarRelateId.IsReadOnly = false;
				colvarRelateId.DefaultSetting = @"";
				colvarRelateId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRelateId);
				
				TableSchema.TableColumn colvarBusinessExpId = new TableSchema.TableColumn(schema);
				colvarBusinessExpId.ColumnName = "BusinessExpId";
				colvarBusinessExpId.DataType = DbType.Int32;
				colvarBusinessExpId.MaxLength = 0;
				colvarBusinessExpId.AutoIncrement = false;
				colvarBusinessExpId.IsNullable = true;
				colvarBusinessExpId.IsPrimaryKey = false;
				colvarBusinessExpId.IsForeignKey = false;
				colvarBusinessExpId.IsReadOnly = false;
				colvarBusinessExpId.DefaultSetting = @"";
				colvarBusinessExpId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBusinessExpId);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("RelateBExp_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("RelateBExpId")]
		[Bindable(true)]
		public int RelateBExpId 
		{
			get { return GetColumnValue<int>(Columns.RelateBExpId); }
			set { SetColumnValue(Columns.RelateBExpId, value); }
		}
		  
		[XmlAttribute("RelateId")]
		[Bindable(true)]
		public int? RelateId 
		{
			get { return GetColumnValue<int?>(Columns.RelateId); }
			set { SetColumnValue(Columns.RelateId, value); }
		}
		  
		[XmlAttribute("BusinessExpId")]
		[Bindable(true)]
		public int? BusinessExpId 
		{
			get { return GetColumnValue<int?>(Columns.BusinessExpId); }
			set { SetColumnValue(Columns.BusinessExpId, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int? varRelateId,int? varBusinessExpId)
		{
			RelateBExp item = new RelateBExp();
			
			item.RelateId = varRelateId;
			
			item.BusinessExpId = varBusinessExpId;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varRelateBExpId,int? varRelateId,int? varBusinessExpId)
		{
			RelateBExp item = new RelateBExp();
			
				item.RelateBExpId = varRelateBExpId;
			
				item.RelateId = varRelateId;
			
				item.BusinessExpId = varBusinessExpId;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn RelateBExpIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn RelateIdColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn BusinessExpIdColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string RelateBExpId = @"RelateBExpId";
			 public static string RelateId = @"RelateId";
			 public static string BusinessExpId = @"BusinessExpId";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
