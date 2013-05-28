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
	/// Strongly-typed collection for the Stamp class.
	/// </summary>
    [Serializable]
	public partial class StampCollection : ActiveList<Stamp, StampCollection>
	{	   
		public StampCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>StampCollection</returns>
		public StampCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                Stamp o = this[i];
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
	/// This is an ActiveRecord class which wraps the Stamp_tb table.
	/// </summary>
	[Serializable]
	public partial class Stamp : ActiveRecord<Stamp>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public Stamp()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public Stamp(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public Stamp(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public Stamp(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("Stamp_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarStampId = new TableSchema.TableColumn(schema);
				colvarStampId.ColumnName = "StampId";
				colvarStampId.DataType = DbType.Int32;
				colvarStampId.MaxLength = 0;
				colvarStampId.AutoIncrement = true;
				colvarStampId.IsNullable = false;
				colvarStampId.IsPrimaryKey = true;
				colvarStampId.IsForeignKey = false;
				colvarStampId.IsReadOnly = false;
				colvarStampId.DefaultSetting = @"";
				colvarStampId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarStampId);
				
				TableSchema.TableColumn colvarUseDate = new TableSchema.TableColumn(schema);
				colvarUseDate.ColumnName = "UseDate";
				colvarUseDate.DataType = DbType.String;
				colvarUseDate.MaxLength = 50;
				colvarUseDate.AutoIncrement = false;
				colvarUseDate.IsNullable = true;
				colvarUseDate.IsPrimaryKey = false;
				colvarUseDate.IsForeignKey = false;
				colvarUseDate.IsReadOnly = false;
				colvarUseDate.DefaultSetting = @"";
				colvarUseDate.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUseDate);
				
				TableSchema.TableColumn colvarStampFileTypeId = new TableSchema.TableColumn(schema);
				colvarStampFileTypeId.ColumnName = "StampFileTypeId";
				colvarStampFileTypeId.DataType = DbType.Int32;
				colvarStampFileTypeId.MaxLength = 0;
				colvarStampFileTypeId.AutoIncrement = false;
				colvarStampFileTypeId.IsNullable = true;
				colvarStampFileTypeId.IsPrimaryKey = false;
				colvarStampFileTypeId.IsForeignKey = false;
				colvarStampFileTypeId.IsReadOnly = false;
				colvarStampFileTypeId.DefaultSetting = @"";
				colvarStampFileTypeId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarStampFileTypeId);
				
				TableSchema.TableColumn colvarStampTypeId = new TableSchema.TableColumn(schema);
				colvarStampTypeId.ColumnName = "StampTypeId";
				colvarStampTypeId.DataType = DbType.Int32;
				colvarStampTypeId.MaxLength = 0;
				colvarStampTypeId.AutoIncrement = false;
				colvarStampTypeId.IsNullable = true;
				colvarStampTypeId.IsPrimaryKey = false;
				colvarStampTypeId.IsForeignKey = false;
				colvarStampTypeId.IsReadOnly = false;
				colvarStampTypeId.DefaultSetting = @"";
				colvarStampTypeId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarStampTypeId);
				
				TableSchema.TableColumn colvarStampuse = new TableSchema.TableColumn(schema);
				colvarStampuse.ColumnName = "Stampuse";
				colvarStampuse.DataType = DbType.String;
				colvarStampuse.MaxLength = 50;
				colvarStampuse.AutoIncrement = false;
				colvarStampuse.IsNullable = true;
				colvarStampuse.IsPrimaryKey = false;
				colvarStampuse.IsForeignKey = false;
				colvarStampuse.IsReadOnly = false;
				colvarStampuse.DefaultSetting = @"";
				colvarStampuse.ForeignKeyTableName = "";
				schema.Columns.Add(colvarStampuse);
				
				TableSchema.TableColumn colvarMemo = new TableSchema.TableColumn(schema);
				colvarMemo.ColumnName = "Memo";
				colvarMemo.DataType = DbType.String;
				colvarMemo.MaxLength = 50;
				colvarMemo.AutoIncrement = false;
				colvarMemo.IsNullable = true;
				colvarMemo.IsPrimaryKey = false;
				colvarMemo.IsForeignKey = false;
				colvarMemo.IsReadOnly = false;
				colvarMemo.DefaultSetting = @"";
				colvarMemo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMemo);
				
				TableSchema.TableColumn colvarApplyName = new TableSchema.TableColumn(schema);
				colvarApplyName.ColumnName = "ApplyName";
				colvarApplyName.DataType = DbType.String;
				colvarApplyName.MaxLength = 50;
				colvarApplyName.AutoIncrement = false;
				colvarApplyName.IsNullable = true;
				colvarApplyName.IsPrimaryKey = false;
				colvarApplyName.IsForeignKey = false;
				colvarApplyName.IsReadOnly = false;
				colvarApplyName.DefaultSetting = @"";
				colvarApplyName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarApplyName);
				
				TableSchema.TableColumn colvarDepartName = new TableSchema.TableColumn(schema);
				colvarDepartName.ColumnName = "DepartName";
				colvarDepartName.DataType = DbType.String;
				colvarDepartName.MaxLength = 50;
				colvarDepartName.AutoIncrement = false;
				colvarDepartName.IsNullable = true;
				colvarDepartName.IsPrimaryKey = false;
				colvarDepartName.IsForeignKey = false;
				colvarDepartName.IsReadOnly = false;
				colvarDepartName.DefaultSetting = @"";
				colvarDepartName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDepartName);
				
				TableSchema.TableColumn colvarState = new TableSchema.TableColumn(schema);
				colvarState.ColumnName = "State";
				colvarState.DataType = DbType.Int32;
				colvarState.MaxLength = 0;
				colvarState.AutoIncrement = false;
				colvarState.IsNullable = true;
				colvarState.IsPrimaryKey = false;
				colvarState.IsForeignKey = false;
				colvarState.IsReadOnly = false;
				colvarState.DefaultSetting = @"";
				colvarState.ForeignKeyTableName = "";
				schema.Columns.Add(colvarState);
				
				TableSchema.TableColumn colvarApplyTime = new TableSchema.TableColumn(schema);
				colvarApplyTime.ColumnName = "ApplyTime";
				colvarApplyTime.DataType = DbType.String;
				colvarApplyTime.MaxLength = 50;
				colvarApplyTime.AutoIncrement = false;
				colvarApplyTime.IsNullable = true;
				colvarApplyTime.IsPrimaryKey = false;
				colvarApplyTime.IsForeignKey = false;
				colvarApplyTime.IsReadOnly = false;
				colvarApplyTime.DefaultSetting = @"";
				colvarApplyTime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarApplyTime);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("Stamp_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("StampId")]
		[Bindable(true)]
		public int StampId 
		{
			get { return GetColumnValue<int>(Columns.StampId); }
			set { SetColumnValue(Columns.StampId, value); }
		}
		  
		[XmlAttribute("UseDate")]
		[Bindable(true)]
		public string UseDate 
		{
			get { return GetColumnValue<string>(Columns.UseDate); }
			set { SetColumnValue(Columns.UseDate, value); }
		}
		  
		[XmlAttribute("StampFileTypeId")]
		[Bindable(true)]
		public int? StampFileTypeId 
		{
			get { return GetColumnValue<int?>(Columns.StampFileTypeId); }
			set { SetColumnValue(Columns.StampFileTypeId, value); }
		}
		  
		[XmlAttribute("StampTypeId")]
		[Bindable(true)]
		public int? StampTypeId 
		{
			get { return GetColumnValue<int?>(Columns.StampTypeId); }
			set { SetColumnValue(Columns.StampTypeId, value); }
		}
		  
		[XmlAttribute("Stampuse")]
		[Bindable(true)]
		public string Stampuse 
		{
			get { return GetColumnValue<string>(Columns.Stampuse); }
			set { SetColumnValue(Columns.Stampuse, value); }
		}
		  
		[XmlAttribute("Memo")]
		[Bindable(true)]
		public string Memo 
		{
			get { return GetColumnValue<string>(Columns.Memo); }
			set { SetColumnValue(Columns.Memo, value); }
		}
		  
		[XmlAttribute("ApplyName")]
		[Bindable(true)]
		public string ApplyName 
		{
			get { return GetColumnValue<string>(Columns.ApplyName); }
			set { SetColumnValue(Columns.ApplyName, value); }
		}
		  
		[XmlAttribute("DepartName")]
		[Bindable(true)]
		public string DepartName 
		{
			get { return GetColumnValue<string>(Columns.DepartName); }
			set { SetColumnValue(Columns.DepartName, value); }
		}
		  
		[XmlAttribute("State")]
		[Bindable(true)]
		public int? State 
		{
			get { return GetColumnValue<int?>(Columns.State); }
			set { SetColumnValue(Columns.State, value); }
		}
		  
		[XmlAttribute("ApplyTime")]
		[Bindable(true)]
		public string ApplyTime 
		{
			get { return GetColumnValue<string>(Columns.ApplyTime); }
			set { SetColumnValue(Columns.ApplyTime, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varUseDate,int? varStampFileTypeId,int? varStampTypeId,string varStampuse,string varMemo,string varApplyName,string varDepartName,int? varState,string varApplyTime)
		{
			Stamp item = new Stamp();
			
			item.UseDate = varUseDate;
			
			item.StampFileTypeId = varStampFileTypeId;
			
			item.StampTypeId = varStampTypeId;
			
			item.Stampuse = varStampuse;
			
			item.Memo = varMemo;
			
			item.ApplyName = varApplyName;
			
			item.DepartName = varDepartName;
			
			item.State = varState;
			
			item.ApplyTime = varApplyTime;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varStampId,string varUseDate,int? varStampFileTypeId,int? varStampTypeId,string varStampuse,string varMemo,string varApplyName,string varDepartName,int? varState,string varApplyTime)
		{
			Stamp item = new Stamp();
			
				item.StampId = varStampId;
			
				item.UseDate = varUseDate;
			
				item.StampFileTypeId = varStampFileTypeId;
			
				item.StampTypeId = varStampTypeId;
			
				item.Stampuse = varStampuse;
			
				item.Memo = varMemo;
			
				item.ApplyName = varApplyName;
			
				item.DepartName = varDepartName;
			
				item.State = varState;
			
				item.ApplyTime = varApplyTime;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn StampIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn UseDateColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn StampFileTypeIdColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn StampTypeIdColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn StampuseColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn MemoColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn ApplyNameColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn DepartNameColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn StateColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn ApplyTimeColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string StampId = @"StampId";
			 public static string UseDate = @"UseDate";
			 public static string StampFileTypeId = @"StampFileTypeId";
			 public static string StampTypeId = @"StampTypeId";
			 public static string Stampuse = @"Stampuse";
			 public static string Memo = @"Memo";
			 public static string ApplyName = @"ApplyName";
			 public static string DepartName = @"DepartName";
			 public static string State = @"State";
			 public static string ApplyTime = @"ApplyTime";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
