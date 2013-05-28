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
	/// Strongly-typed collection for the ProjectExecuteType class.
	/// </summary>
    [Serializable]
	public partial class ProjectExecuteTypeCollection : ActiveList<ProjectExecuteType, ProjectExecuteTypeCollection>
	{	   
		public ProjectExecuteTypeCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>ProjectExecuteTypeCollection</returns>
		public ProjectExecuteTypeCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                ProjectExecuteType o = this[i];
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
	/// This is an ActiveRecord class which wraps the ProjectExecuteType_tb table.
	/// </summary>
	[Serializable]
	public partial class ProjectExecuteType : ActiveRecord<ProjectExecuteType>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public ProjectExecuteType()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public ProjectExecuteType(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public ProjectExecuteType(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public ProjectExecuteType(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("ProjectExecuteType_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarProjectExecuteTypeId = new TableSchema.TableColumn(schema);
				colvarProjectExecuteTypeId.ColumnName = "ProjectExecuteTypeId";
				colvarProjectExecuteTypeId.DataType = DbType.Int32;
				colvarProjectExecuteTypeId.MaxLength = 0;
				colvarProjectExecuteTypeId.AutoIncrement = true;
				colvarProjectExecuteTypeId.IsNullable = false;
				colvarProjectExecuteTypeId.IsPrimaryKey = true;
				colvarProjectExecuteTypeId.IsForeignKey = false;
				colvarProjectExecuteTypeId.IsReadOnly = false;
				colvarProjectExecuteTypeId.DefaultSetting = @"";
				colvarProjectExecuteTypeId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProjectExecuteTypeId);
				
				TableSchema.TableColumn colvarProjectExecuteTypeName = new TableSchema.TableColumn(schema);
				colvarProjectExecuteTypeName.ColumnName = "ProjectExecuteTypeName";
				colvarProjectExecuteTypeName.DataType = DbType.String;
				colvarProjectExecuteTypeName.MaxLength = 50;
				colvarProjectExecuteTypeName.AutoIncrement = false;
				colvarProjectExecuteTypeName.IsNullable = true;
				colvarProjectExecuteTypeName.IsPrimaryKey = false;
				colvarProjectExecuteTypeName.IsForeignKey = false;
				colvarProjectExecuteTypeName.IsReadOnly = false;
				colvarProjectExecuteTypeName.DefaultSetting = @"";
				colvarProjectExecuteTypeName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProjectExecuteTypeName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("ProjectExecuteType_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("ProjectExecuteTypeId")]
		[Bindable(true)]
		public int ProjectExecuteTypeId 
		{
			get { return GetColumnValue<int>(Columns.ProjectExecuteTypeId); }
			set { SetColumnValue(Columns.ProjectExecuteTypeId, value); }
		}
		  
		[XmlAttribute("ProjectExecuteTypeName")]
		[Bindable(true)]
		public string ProjectExecuteTypeName 
		{
			get { return GetColumnValue<string>(Columns.ProjectExecuteTypeName); }
			set { SetColumnValue(Columns.ProjectExecuteTypeName, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varProjectExecuteTypeName)
		{
			ProjectExecuteType item = new ProjectExecuteType();
			
			item.ProjectExecuteTypeName = varProjectExecuteTypeName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varProjectExecuteTypeId,string varProjectExecuteTypeName)
		{
			ProjectExecuteType item = new ProjectExecuteType();
			
				item.ProjectExecuteTypeId = varProjectExecuteTypeId;
			
				item.ProjectExecuteTypeName = varProjectExecuteTypeName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn ProjectExecuteTypeIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ProjectExecuteTypeNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string ProjectExecuteTypeId = @"ProjectExecuteTypeId";
			 public static string ProjectExecuteTypeName = @"ProjectExecuteTypeName";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
