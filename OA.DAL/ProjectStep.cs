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
	/// Strongly-typed collection for the ProjectStep class.
	/// </summary>
    [Serializable]
	public partial class ProjectStepCollection : ActiveList<ProjectStep, ProjectStepCollection>
	{	   
		public ProjectStepCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>ProjectStepCollection</returns>
		public ProjectStepCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                ProjectStep o = this[i];
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
	/// This is an ActiveRecord class which wraps the ProjectStep_tb table.
	/// </summary>
	[Serializable]
	public partial class ProjectStep : ActiveRecord<ProjectStep>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public ProjectStep()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public ProjectStep(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public ProjectStep(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public ProjectStep(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("ProjectStep_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarProjectStepId = new TableSchema.TableColumn(schema);
				colvarProjectStepId.ColumnName = "ProjectStepId";
				colvarProjectStepId.DataType = DbType.Int32;
				colvarProjectStepId.MaxLength = 0;
				colvarProjectStepId.AutoIncrement = true;
				colvarProjectStepId.IsNullable = false;
				colvarProjectStepId.IsPrimaryKey = true;
				colvarProjectStepId.IsForeignKey = false;
				colvarProjectStepId.IsReadOnly = false;
				colvarProjectStepId.DefaultSetting = @"";
				colvarProjectStepId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProjectStepId);
				
				TableSchema.TableColumn colvarProjectStepName = new TableSchema.TableColumn(schema);
				colvarProjectStepName.ColumnName = "ProjectStepName";
				colvarProjectStepName.DataType = DbType.String;
				colvarProjectStepName.MaxLength = 50;
				colvarProjectStepName.AutoIncrement = false;
				colvarProjectStepName.IsNullable = true;
				colvarProjectStepName.IsPrimaryKey = false;
				colvarProjectStepName.IsForeignKey = false;
				colvarProjectStepName.IsReadOnly = false;
				colvarProjectStepName.DefaultSetting = @"";
				colvarProjectStepName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProjectStepName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("ProjectStep_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("ProjectStepId")]
		[Bindable(true)]
		public int ProjectStepId 
		{
			get { return GetColumnValue<int>(Columns.ProjectStepId); }
			set { SetColumnValue(Columns.ProjectStepId, value); }
		}
		  
		[XmlAttribute("ProjectStepName")]
		[Bindable(true)]
		public string ProjectStepName 
		{
			get { return GetColumnValue<string>(Columns.ProjectStepName); }
			set { SetColumnValue(Columns.ProjectStepName, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varProjectStepName)
		{
			ProjectStep item = new ProjectStep();
			
			item.ProjectStepName = varProjectStepName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varProjectStepId,string varProjectStepName)
		{
			ProjectStep item = new ProjectStep();
			
				item.ProjectStepId = varProjectStepId;
			
				item.ProjectStepName = varProjectStepName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn ProjectStepIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ProjectStepNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string ProjectStepId = @"ProjectStepId";
			 public static string ProjectStepName = @"ProjectStepName";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
