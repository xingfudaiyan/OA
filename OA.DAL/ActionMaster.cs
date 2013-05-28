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
	/// Strongly-typed collection for the ActionMaster class.
	/// </summary>
    [Serializable]
	public partial class ActionMasterCollection : ActiveList<ActionMaster, ActionMasterCollection>
	{	   
		public ActionMasterCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>ActionMasterCollection</returns>
		public ActionMasterCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                ActionMaster o = this[i];
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
	/// This is an ActiveRecord class which wraps the ActionMaster_tb table.
	/// </summary>
	[Serializable]
	public partial class ActionMaster : ActiveRecord<ActionMaster>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public ActionMaster()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public ActionMaster(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public ActionMaster(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public ActionMaster(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("ActionMaster_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarActionMasterId = new TableSchema.TableColumn(schema);
				colvarActionMasterId.ColumnName = "ActionMasterId";
				colvarActionMasterId.DataType = DbType.Int32;
				colvarActionMasterId.MaxLength = 0;
				colvarActionMasterId.AutoIncrement = true;
				colvarActionMasterId.IsNullable = false;
				colvarActionMasterId.IsPrimaryKey = true;
				colvarActionMasterId.IsForeignKey = false;
				colvarActionMasterId.IsReadOnly = false;
				colvarActionMasterId.DefaultSetting = @"";
				colvarActionMasterId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarActionMasterId);
				
				TableSchema.TableColumn colvarActionId = new TableSchema.TableColumn(schema);
				colvarActionId.ColumnName = "ActionId";
				colvarActionId.DataType = DbType.Int32;
				colvarActionId.MaxLength = 0;
				colvarActionId.AutoIncrement = false;
				colvarActionId.IsNullable = false;
				colvarActionId.IsPrimaryKey = false;
				colvarActionId.IsForeignKey = true;
				colvarActionId.IsReadOnly = false;
				colvarActionId.DefaultSetting = @"";
				
					colvarActionId.ForeignKeyTableName = "Action_tb";
				schema.Columns.Add(colvarActionId);
				
				TableSchema.TableColumn colvarMasterId = new TableSchema.TableColumn(schema);
				colvarMasterId.ColumnName = "MasterId";
				colvarMasterId.DataType = DbType.Int32;
				colvarMasterId.MaxLength = 0;
				colvarMasterId.AutoIncrement = false;
				colvarMasterId.IsNullable = false;
				colvarMasterId.IsPrimaryKey = false;
				colvarMasterId.IsForeignKey = true;
				colvarMasterId.IsReadOnly = false;
				colvarMasterId.DefaultSetting = @"";
				
					colvarMasterId.ForeignKeyTableName = "Master_tb";
				schema.Columns.Add(colvarMasterId);
				
				TableSchema.TableColumn colvarIsPass = new TableSchema.TableColumn(schema);
				colvarIsPass.ColumnName = "IsPass";
				colvarIsPass.DataType = DbType.Int32;
				colvarIsPass.MaxLength = 0;
				colvarIsPass.AutoIncrement = false;
				colvarIsPass.IsNullable = true;
				colvarIsPass.IsPrimaryKey = false;
				colvarIsPass.IsForeignKey = false;
				colvarIsPass.IsReadOnly = false;
				colvarIsPass.DefaultSetting = @"";
				colvarIsPass.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIsPass);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("ActionMaster_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("ActionMasterId")]
		[Bindable(true)]
		public int ActionMasterId 
		{
			get { return GetColumnValue<int>(Columns.ActionMasterId); }
			set { SetColumnValue(Columns.ActionMasterId, value); }
		}
		  
		[XmlAttribute("ActionId")]
		[Bindable(true)]
		public int ActionId 
		{
			get { return GetColumnValue<int>(Columns.ActionId); }
			set { SetColumnValue(Columns.ActionId, value); }
		}
		  
		[XmlAttribute("MasterId")]
		[Bindable(true)]
		public int MasterId 
		{
			get { return GetColumnValue<int>(Columns.MasterId); }
			set { SetColumnValue(Columns.MasterId, value); }
		}
		  
		[XmlAttribute("IsPass")]
		[Bindable(true)]
		public int? IsPass 
		{
			get { return GetColumnValue<int?>(Columns.IsPass); }
			set { SetColumnValue(Columns.IsPass, value); }
		}
		
		#endregion
		
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a Action ActiveRecord object related to this ActionMaster
		/// 
		/// </summary>
		public CanYou.OA.DAL.Action Action
		{
			get { return CanYou.OA.DAL.Action.FetchByID(this.ActionId); }
			set { SetColumnValue("ActionId", value.ActionId); }
		}
		
		
		/// <summary>
		/// Returns a Master ActiveRecord object related to this ActionMaster
		/// 
		/// </summary>
		public CanYou.OA.DAL.Master Master
		{
			get { return CanYou.OA.DAL.Master.FetchByID(this.MasterId); }
			set { SetColumnValue("MasterId", value.MasterId); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varActionId,int varMasterId,int? varIsPass)
		{
			ActionMaster item = new ActionMaster();
			
			item.ActionId = varActionId;
			
			item.MasterId = varMasterId;
			
			item.IsPass = varIsPass;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varActionMasterId,int varActionId,int varMasterId,int? varIsPass)
		{
			ActionMaster item = new ActionMaster();
			
				item.ActionMasterId = varActionMasterId;
			
				item.ActionId = varActionId;
			
				item.MasterId = varMasterId;
			
				item.IsPass = varIsPass;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn ActionMasterIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ActionIdColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn MasterIdColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn IsPassColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string ActionMasterId = @"ActionMasterId";
			 public static string ActionId = @"ActionId";
			 public static string MasterId = @"MasterId";
			 public static string IsPass = @"IsPass";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
