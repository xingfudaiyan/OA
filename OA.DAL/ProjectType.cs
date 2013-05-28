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
	/// Strongly-typed collection for the ProjectType class.
	/// </summary>
    [Serializable]
	public partial class ProjectTypeCollection : ActiveList<ProjectType, ProjectTypeCollection>
	{	   
		public ProjectTypeCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>ProjectTypeCollection</returns>
		public ProjectTypeCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                ProjectType o = this[i];
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
	/// This is an ActiveRecord class which wraps the ProjectType_tb table.
	/// </summary>
	[Serializable]
	public partial class ProjectType : ActiveRecord<ProjectType>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public ProjectType()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public ProjectType(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public ProjectType(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public ProjectType(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("ProjectType_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarProjectTypeId = new TableSchema.TableColumn(schema);
				colvarProjectTypeId.ColumnName = "ProjectTypeId";
				colvarProjectTypeId.DataType = DbType.Int32;
				colvarProjectTypeId.MaxLength = 0;
				colvarProjectTypeId.AutoIncrement = true;
				colvarProjectTypeId.IsNullable = false;
				colvarProjectTypeId.IsPrimaryKey = true;
				colvarProjectTypeId.IsForeignKey = false;
				colvarProjectTypeId.IsReadOnly = false;
				colvarProjectTypeId.DefaultSetting = @"";
				colvarProjectTypeId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProjectTypeId);
				
				TableSchema.TableColumn colvarProjectTypeName = new TableSchema.TableColumn(schema);
				colvarProjectTypeName.ColumnName = "ProjectTypeName";
				colvarProjectTypeName.DataType = DbType.String;
				colvarProjectTypeName.MaxLength = 50;
				colvarProjectTypeName.AutoIncrement = false;
				colvarProjectTypeName.IsNullable = true;
				colvarProjectTypeName.IsPrimaryKey = false;
				colvarProjectTypeName.IsForeignKey = false;
				colvarProjectTypeName.IsReadOnly = false;
				colvarProjectTypeName.DefaultSetting = @"";
				colvarProjectTypeName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProjectTypeName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("ProjectType_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("ProjectTypeId")]
		[Bindable(true)]
		public int ProjectTypeId 
		{
			get { return GetColumnValue<int>(Columns.ProjectTypeId); }
			set { SetColumnValue(Columns.ProjectTypeId, value); }
		}
		  
		[XmlAttribute("ProjectTypeName")]
		[Bindable(true)]
		public string ProjectTypeName 
		{
			get { return GetColumnValue<string>(Columns.ProjectTypeName); }
			set { SetColumnValue(Columns.ProjectTypeName, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varProjectTypeName)
		{
			ProjectType item = new ProjectType();
			
			item.ProjectTypeName = varProjectTypeName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varProjectTypeId,string varProjectTypeName)
		{
			ProjectType item = new ProjectType();
			
				item.ProjectTypeId = varProjectTypeId;
			
				item.ProjectTypeName = varProjectTypeName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn ProjectTypeIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ProjectTypeNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string ProjectTypeId = @"ProjectTypeId";
			 public static string ProjectTypeName = @"ProjectTypeName";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
