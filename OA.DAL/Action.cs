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
	/// Strongly-typed collection for the Action class.
	/// </summary>
    [Serializable]
	public partial class ActionCollection : ActiveList<Action, ActionCollection>
	{	   
		public ActionCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>ActionCollection</returns>
		public ActionCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                Action o = this[i];
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
	/// This is an ActiveRecord class which wraps the Action_tb table.
	/// </summary>
	[Serializable]
	public partial class Action : ActiveRecord<Action>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public Action()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public Action(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public Action(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public Action(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("Action_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarActionId = new TableSchema.TableColumn(schema);
				colvarActionId.ColumnName = "ActionId";
				colvarActionId.DataType = DbType.Int32;
				colvarActionId.MaxLength = 0;
				colvarActionId.AutoIncrement = true;
				colvarActionId.IsNullable = false;
				colvarActionId.IsPrimaryKey = true;
				colvarActionId.IsForeignKey = false;
				colvarActionId.IsReadOnly = false;
				colvarActionId.DefaultSetting = @"";
				colvarActionId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarActionId);
				
				TableSchema.TableColumn colvarActionName = new TableSchema.TableColumn(schema);
				colvarActionName.ColumnName = "ActionName";
				colvarActionName.DataType = DbType.String;
				colvarActionName.MaxLength = 50;
				colvarActionName.AutoIncrement = false;
				colvarActionName.IsNullable = false;
				colvarActionName.IsPrimaryKey = false;
				colvarActionName.IsForeignKey = false;
				colvarActionName.IsReadOnly = false;
				colvarActionName.DefaultSetting = @"";
				colvarActionName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarActionName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("Action_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("ActionId")]
		[Bindable(true)]
		public int ActionId 
		{
			get { return GetColumnValue<int>(Columns.ActionId); }
			set { SetColumnValue(Columns.ActionId, value); }
		}
		  
		[XmlAttribute("ActionName")]
		[Bindable(true)]
		public string ActionName 
		{
			get { return GetColumnValue<string>(Columns.ActionName); }
			set { SetColumnValue(Columns.ActionName, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		public CanYou.OA.DAL.ActionMasterCollection ActionMasterRecords()
		{
			return new CanYou.OA.DAL.ActionMasterCollection().Where(ActionMaster.Columns.ActionId, ActionId).Load();
		}
		#endregion
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varActionName)
		{
			Action item = new Action();
			
			item.ActionName = varActionName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varActionId,string varActionName)
		{
			Action item = new Action();
			
				item.ActionId = varActionId;
			
				item.ActionName = varActionName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn ActionIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ActionNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string ActionId = @"ActionId";
			 public static string ActionName = @"ActionName";
						
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
