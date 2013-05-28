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
	/// Strongly-typed collection for the EvaluateLevel class.
	/// </summary>
    [Serializable]
	public partial class EvaluateLevelCollection : ActiveList<EvaluateLevel, EvaluateLevelCollection>
	{	   
		public EvaluateLevelCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>EvaluateLevelCollection</returns>
		public EvaluateLevelCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                EvaluateLevel o = this[i];
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
	/// This is an ActiveRecord class which wraps the EvaluateLevel_tb table.
	/// </summary>
	[Serializable]
	public partial class EvaluateLevel : ActiveRecord<EvaluateLevel>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public EvaluateLevel()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public EvaluateLevel(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public EvaluateLevel(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public EvaluateLevel(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("EvaluateLevel_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarEvaluateLevelId = new TableSchema.TableColumn(schema);
				colvarEvaluateLevelId.ColumnName = "EvaluateLevelId";
				colvarEvaluateLevelId.DataType = DbType.Int32;
				colvarEvaluateLevelId.MaxLength = 0;
				colvarEvaluateLevelId.AutoIncrement = true;
				colvarEvaluateLevelId.IsNullable = false;
				colvarEvaluateLevelId.IsPrimaryKey = true;
				colvarEvaluateLevelId.IsForeignKey = false;
				colvarEvaluateLevelId.IsReadOnly = false;
				colvarEvaluateLevelId.DefaultSetting = @"";
				colvarEvaluateLevelId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEvaluateLevelId);
				
				TableSchema.TableColumn colvarEvaluateName = new TableSchema.TableColumn(schema);
				colvarEvaluateName.ColumnName = "EvaluateName";
				colvarEvaluateName.DataType = DbType.String;
				colvarEvaluateName.MaxLength = 15;
				colvarEvaluateName.AutoIncrement = false;
				colvarEvaluateName.IsNullable = true;
				colvarEvaluateName.IsPrimaryKey = false;
				colvarEvaluateName.IsForeignKey = false;
				colvarEvaluateName.IsReadOnly = false;
				colvarEvaluateName.DefaultSetting = @"";
				colvarEvaluateName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEvaluateName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("EvaluateLevel_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("EvaluateLevelId")]
		[Bindable(true)]
		public int EvaluateLevelId 
		{
			get { return GetColumnValue<int>(Columns.EvaluateLevelId); }
			set { SetColumnValue(Columns.EvaluateLevelId, value); }
		}
		  
		[XmlAttribute("EvaluateName")]
		[Bindable(true)]
		public string EvaluateName 
		{
			get { return GetColumnValue<string>(Columns.EvaluateName); }
			set { SetColumnValue(Columns.EvaluateName, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varEvaluateName)
		{
			EvaluateLevel item = new EvaluateLevel();
			
			item.EvaluateName = varEvaluateName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varEvaluateLevelId,string varEvaluateName)
		{
			EvaluateLevel item = new EvaluateLevel();
			
				item.EvaluateLevelId = varEvaluateLevelId;
			
				item.EvaluateName = varEvaluateName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn EvaluateLevelIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn EvaluateNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string EvaluateLevelId = @"EvaluateLevelId";
			 public static string EvaluateName = @"EvaluateName";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
