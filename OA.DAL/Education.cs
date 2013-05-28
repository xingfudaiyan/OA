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
	/// Strongly-typed collection for the Education class.
	/// </summary>
    [Serializable]
	public partial class EducationCollection : ActiveList<Education, EducationCollection>
	{	   
		public EducationCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>EducationCollection</returns>
		public EducationCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                Education o = this[i];
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
	/// This is an ActiveRecord class which wraps the Education_tb table.
	/// </summary>
	[Serializable]
	public partial class Education : ActiveRecord<Education>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public Education()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public Education(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public Education(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public Education(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("Education_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarEducationId = new TableSchema.TableColumn(schema);
				colvarEducationId.ColumnName = "EducationId";
				colvarEducationId.DataType = DbType.Int32;
				colvarEducationId.MaxLength = 0;
				colvarEducationId.AutoIncrement = true;
				colvarEducationId.IsNullable = false;
				colvarEducationId.IsPrimaryKey = true;
				colvarEducationId.IsForeignKey = false;
				colvarEducationId.IsReadOnly = false;
				colvarEducationId.DefaultSetting = @"";
				colvarEducationId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEducationId);
				
				TableSchema.TableColumn colvarEducationName = new TableSchema.TableColumn(schema);
				colvarEducationName.ColumnName = "EducationName";
				colvarEducationName.DataType = DbType.String;
				colvarEducationName.MaxLength = 50;
				colvarEducationName.AutoIncrement = false;
				colvarEducationName.IsNullable = true;
				colvarEducationName.IsPrimaryKey = false;
				colvarEducationName.IsForeignKey = false;
				colvarEducationName.IsReadOnly = false;
				colvarEducationName.DefaultSetting = @"";
				colvarEducationName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEducationName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("Education_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("EducationId")]
		[Bindable(true)]
		public int EducationId 
		{
			get { return GetColumnValue<int>(Columns.EducationId); }
			set { SetColumnValue(Columns.EducationId, value); }
		}
		  
		[XmlAttribute("EducationName")]
		[Bindable(true)]
		public string EducationName 
		{
			get { return GetColumnValue<string>(Columns.EducationName); }
			set { SetColumnValue(Columns.EducationName, value); }
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
			return new CanYou.OA.DAL.EmployeeCollection().Where(Employee.Columns.EducationId, EducationId).Load();
		}
		#endregion
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varEducationName)
		{
			Education item = new Education();
			
			item.EducationName = varEducationName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varEducationId,string varEducationName)
		{
			Education item = new Education();
			
				item.EducationId = varEducationId;
			
				item.EducationName = varEducationName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn EducationIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn EducationNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string EducationId = @"EducationId";
			 public static string EducationName = @"EducationName";
						
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
