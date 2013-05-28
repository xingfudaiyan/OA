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
	/// Strongly-typed collection for the ProjectLevel class.
	/// </summary>
    [Serializable]
	public partial class ProjectLevelCollection : ActiveList<ProjectLevel, ProjectLevelCollection>
	{	   
		public ProjectLevelCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>ProjectLevelCollection</returns>
		public ProjectLevelCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                ProjectLevel o = this[i];
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
	/// This is an ActiveRecord class which wraps the ProjectLevel_tb table.
	/// </summary>
	[Serializable]
	public partial class ProjectLevel : ActiveRecord<ProjectLevel>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public ProjectLevel()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public ProjectLevel(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public ProjectLevel(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public ProjectLevel(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("ProjectLevel_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarProjectLevelId = new TableSchema.TableColumn(schema);
				colvarProjectLevelId.ColumnName = "ProjectLevelId";
				colvarProjectLevelId.DataType = DbType.Int32;
				colvarProjectLevelId.MaxLength = 0;
				colvarProjectLevelId.AutoIncrement = true;
				colvarProjectLevelId.IsNullable = false;
				colvarProjectLevelId.IsPrimaryKey = true;
				colvarProjectLevelId.IsForeignKey = false;
				colvarProjectLevelId.IsReadOnly = false;
				colvarProjectLevelId.DefaultSetting = @"";
				colvarProjectLevelId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProjectLevelId);
				
				TableSchema.TableColumn colvarProjectLevelName = new TableSchema.TableColumn(schema);
				colvarProjectLevelName.ColumnName = "ProjectLevelName";
				colvarProjectLevelName.DataType = DbType.String;
				colvarProjectLevelName.MaxLength = 50;
				colvarProjectLevelName.AutoIncrement = false;
				colvarProjectLevelName.IsNullable = true;
				colvarProjectLevelName.IsPrimaryKey = false;
				colvarProjectLevelName.IsForeignKey = false;
				colvarProjectLevelName.IsReadOnly = false;
				colvarProjectLevelName.DefaultSetting = @"";
				colvarProjectLevelName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProjectLevelName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("ProjectLevel_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("ProjectLevelId")]
		[Bindable(true)]
		public int ProjectLevelId 
		{
			get { return GetColumnValue<int>(Columns.ProjectLevelId); }
			set { SetColumnValue(Columns.ProjectLevelId, value); }
		}
		  
		[XmlAttribute("ProjectLevelName")]
		[Bindable(true)]
		public string ProjectLevelName 
		{
			get { return GetColumnValue<string>(Columns.ProjectLevelName); }
			set { SetColumnValue(Columns.ProjectLevelName, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varProjectLevelName)
		{
			ProjectLevel item = new ProjectLevel();
			
			item.ProjectLevelName = varProjectLevelName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varProjectLevelId,string varProjectLevelName)
		{
			ProjectLevel item = new ProjectLevel();
			
				item.ProjectLevelId = varProjectLevelId;
			
				item.ProjectLevelName = varProjectLevelName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn ProjectLevelIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ProjectLevelNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string ProjectLevelId = @"ProjectLevelId";
			 public static string ProjectLevelName = @"ProjectLevelName";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
