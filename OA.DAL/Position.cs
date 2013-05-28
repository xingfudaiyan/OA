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
	/// Strongly-typed collection for the Position class.
	/// </summary>
    [Serializable]
	public partial class PositionCollection : ActiveList<Position, PositionCollection>
	{	   
		public PositionCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>PositionCollection</returns>
		public PositionCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                Position o = this[i];
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
	/// This is an ActiveRecord class which wraps the Position_tb table.
	/// </summary>
	[Serializable]
	public partial class Position : ActiveRecord<Position>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public Position()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public Position(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public Position(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public Position(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("Position_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarPositionId = new TableSchema.TableColumn(schema);
				colvarPositionId.ColumnName = "PositionId";
				colvarPositionId.DataType = DbType.Int32;
				colvarPositionId.MaxLength = 0;
				colvarPositionId.AutoIncrement = true;
				colvarPositionId.IsNullable = false;
				colvarPositionId.IsPrimaryKey = true;
				colvarPositionId.IsForeignKey = false;
				colvarPositionId.IsReadOnly = false;
				colvarPositionId.DefaultSetting = @"";
				colvarPositionId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPositionId);
				
				TableSchema.TableColumn colvarPositionName = new TableSchema.TableColumn(schema);
				colvarPositionName.ColumnName = "PositionName";
				colvarPositionName.DataType = DbType.String;
				colvarPositionName.MaxLength = 50;
				colvarPositionName.AutoIncrement = false;
				colvarPositionName.IsNullable = true;
				colvarPositionName.IsPrimaryKey = false;
				colvarPositionName.IsForeignKey = false;
				colvarPositionName.IsReadOnly = false;
				colvarPositionName.DefaultSetting = @"";
				colvarPositionName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPositionName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("Position_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("PositionId")]
		[Bindable(true)]
		public int PositionId 
		{
			get { return GetColumnValue<int>(Columns.PositionId); }
			set { SetColumnValue(Columns.PositionId, value); }
		}
		  
		[XmlAttribute("PositionName")]
		[Bindable(true)]
		public string PositionName 
		{
			get { return GetColumnValue<string>(Columns.PositionName); }
			set { SetColumnValue(Columns.PositionName, value); }
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
			return new CanYou.OA.DAL.EmployeeCollection().Where(Employee.Columns.PositionId, PositionId).Load();
		}
		#endregion
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varPositionName)
		{
			Position item = new Position();
			
			item.PositionName = varPositionName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varPositionId,string varPositionName)
		{
			Position item = new Position();
			
				item.PositionId = varPositionId;
			
				item.PositionName = varPositionName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn PositionIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn PositionNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string PositionId = @"PositionId";
			 public static string PositionName = @"PositionName";
						
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
