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
	/// Strongly-typed collection for the Politics class.
	/// </summary>
    [Serializable]
	public partial class PoliticsCollection : ActiveList<Politics, PoliticsCollection>
	{	   
		public PoliticsCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>PoliticsCollection</returns>
		public PoliticsCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                Politics o = this[i];
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
	/// This is an ActiveRecord class which wraps the Politics_tb table.
	/// </summary>
	[Serializable]
	public partial class Politics : ActiveRecord<Politics>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public Politics()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public Politics(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public Politics(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public Politics(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("Politics_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarPoliticsId = new TableSchema.TableColumn(schema);
				colvarPoliticsId.ColumnName = "PoliticsId";
				colvarPoliticsId.DataType = DbType.Int32;
				colvarPoliticsId.MaxLength = 0;
				colvarPoliticsId.AutoIncrement = true;
				colvarPoliticsId.IsNullable = false;
				colvarPoliticsId.IsPrimaryKey = true;
				colvarPoliticsId.IsForeignKey = false;
				colvarPoliticsId.IsReadOnly = false;
				colvarPoliticsId.DefaultSetting = @"";
				colvarPoliticsId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPoliticsId);
				
				TableSchema.TableColumn colvarPoliticsName = new TableSchema.TableColumn(schema);
				colvarPoliticsName.ColumnName = "PoliticsName";
				colvarPoliticsName.DataType = DbType.String;
				colvarPoliticsName.MaxLength = 50;
				colvarPoliticsName.AutoIncrement = false;
				colvarPoliticsName.IsNullable = true;
				colvarPoliticsName.IsPrimaryKey = false;
				colvarPoliticsName.IsForeignKey = false;
				colvarPoliticsName.IsReadOnly = false;
				colvarPoliticsName.DefaultSetting = @"";
				colvarPoliticsName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPoliticsName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("Politics_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("PoliticsId")]
		[Bindable(true)]
		public int PoliticsId 
		{
			get { return GetColumnValue<int>(Columns.PoliticsId); }
			set { SetColumnValue(Columns.PoliticsId, value); }
		}
		  
		[XmlAttribute("PoliticsName")]
		[Bindable(true)]
		public string PoliticsName 
		{
			get { return GetColumnValue<string>(Columns.PoliticsName); }
			set { SetColumnValue(Columns.PoliticsName, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		public CanYou.OA.DAL.EmployeeCollection EmployeeRecords()
		{
			return new CanYou.OA.DAL.EmployeeCollection().Where(Employee.Columns.PoliticsId, PoliticsId).Load();
		}
		#endregion
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varPoliticsName)
		{
			Politics item = new Politics();
			
			item.PoliticsName = varPoliticsName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varPoliticsId,string varPoliticsName)
		{
			Politics item = new Politics();
			
				item.PoliticsId = varPoliticsId;
			
				item.PoliticsName = varPoliticsName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn PoliticsIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn PoliticsNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string PoliticsId = @"PoliticsId";
			 public static string PoliticsName = @"PoliticsName";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
}
        #endregion
	}
}
