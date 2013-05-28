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
	/// Strongly-typed collection for the State class.
	/// </summary>
    [Serializable]
	public partial class StateCollection : ActiveList<State, StateCollection>
	{	   
		public StateCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>StateCollection</returns>
		public StateCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                State o = this[i];
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
	/// This is an ActiveRecord class which wraps the State_tb table.
	/// </summary>
	[Serializable]
	public partial class State : ActiveRecord<State>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public State()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public State(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public State(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public State(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("State_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarStateId = new TableSchema.TableColumn(schema);
				colvarStateId.ColumnName = "StateId";
				colvarStateId.DataType = DbType.Int32;
				colvarStateId.MaxLength = 0;
				colvarStateId.AutoIncrement = true;
				colvarStateId.IsNullable = false;
				colvarStateId.IsPrimaryKey = true;
				colvarStateId.IsForeignKey = false;
				colvarStateId.IsReadOnly = false;
				colvarStateId.DefaultSetting = @"";
				colvarStateId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarStateId);
				
				TableSchema.TableColumn colvarStateName = new TableSchema.TableColumn(schema);
				colvarStateName.ColumnName = "StateName";
				colvarStateName.DataType = DbType.String;
				colvarStateName.MaxLength = 50;
				colvarStateName.AutoIncrement = false;
				colvarStateName.IsNullable = true;
				colvarStateName.IsPrimaryKey = false;
				colvarStateName.IsForeignKey = false;
				colvarStateName.IsReadOnly = false;
				colvarStateName.DefaultSetting = @"";
				colvarStateName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarStateName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("State_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("StateId")]
		[Bindable(true)]
		public int StateId 
		{
			get { return GetColumnValue<int>(Columns.StateId); }
			set { SetColumnValue(Columns.StateId, value); }
		}
		  
		[XmlAttribute("StateName")]
		[Bindable(true)]
		public string StateName 
		{
			get { return GetColumnValue<string>(Columns.StateName); }
			set { SetColumnValue(Columns.StateName, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varStateName)
		{
			State item = new State();
			
			item.StateName = varStateName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varStateId,string varStateName)
		{
			State item = new State();
			
				item.StateId = varStateId;
			
				item.StateName = varStateName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn StateIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn StateNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string StateId = @"StateId";
			 public static string StateName = @"StateName";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
