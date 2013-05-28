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
	/// Strongly-typed collection for the Week class.
	/// </summary>
    [Serializable]
	public partial class WeekCollection : ActiveList<Week, WeekCollection>
	{	   
		public WeekCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>WeekCollection</returns>
		public WeekCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                Week o = this[i];
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
	/// This is an ActiveRecord class which wraps the Week_tb table.
	/// </summary>
	[Serializable]
	public partial class Week : ActiveRecord<Week>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public Week()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public Week(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public Week(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public Week(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("Week_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarWeekId = new TableSchema.TableColumn(schema);
				colvarWeekId.ColumnName = "WeekId";
				colvarWeekId.DataType = DbType.Int32;
				colvarWeekId.MaxLength = 0;
				colvarWeekId.AutoIncrement = true;
				colvarWeekId.IsNullable = false;
				colvarWeekId.IsPrimaryKey = true;
				colvarWeekId.IsForeignKey = false;
				colvarWeekId.IsReadOnly = false;
				colvarWeekId.DefaultSetting = @"";
				colvarWeekId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarWeekId);
				
				TableSchema.TableColumn colvarWeekName = new TableSchema.TableColumn(schema);
				colvarWeekName.ColumnName = "WeekName";
				colvarWeekName.DataType = DbType.String;
				colvarWeekName.MaxLength = 50;
				colvarWeekName.AutoIncrement = false;
				colvarWeekName.IsNullable = false;
				colvarWeekName.IsPrimaryKey = false;
				colvarWeekName.IsForeignKey = false;
				colvarWeekName.IsReadOnly = false;
				colvarWeekName.DefaultSetting = @"";
				colvarWeekName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarWeekName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("Week_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("WeekId")]
		[Bindable(true)]
		public int WeekId 
		{
			get { return GetColumnValue<int>(Columns.WeekId); }
			set { SetColumnValue(Columns.WeekId, value); }
		}
		  
		[XmlAttribute("WeekName")]
		[Bindable(true)]
		public string WeekName 
		{
			get { return GetColumnValue<string>(Columns.WeekName); }
			set { SetColumnValue(Columns.WeekName, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		public CanYou.OA.DAL.DayCollection DayRecords()
		{
			return new CanYou.OA.DAL.DayCollection().Where(Day.Columns.WeekId, WeekId).Load();
		}
		#endregion
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varWeekName)
		{
			Week item = new Week();
			
			item.WeekName = varWeekName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varWeekId,string varWeekName)
		{
			Week item = new Week();
			
				item.WeekId = varWeekId;
			
				item.WeekName = varWeekName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn WeekIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn WeekNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string WeekId = @"WeekId";
			 public static string WeekName = @"WeekName";
						
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
