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
	/// Strongly-typed collection for the OutRegist class.
	/// </summary>
    [Serializable]
	public partial class OutRegistCollection : ActiveList<OutRegist, OutRegistCollection>
	{	   
		public OutRegistCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>OutRegistCollection</returns>
		public OutRegistCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                OutRegist o = this[i];
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
	/// This is an ActiveRecord class which wraps the OutRegist_tb table.
	/// </summary>
	[Serializable]
	public partial class OutRegist : ActiveRecord<OutRegist>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public OutRegist()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public OutRegist(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public OutRegist(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public OutRegist(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("OutRegist_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarOutRegistId = new TableSchema.TableColumn(schema);
				colvarOutRegistId.ColumnName = "OutRegistId";
				colvarOutRegistId.DataType = DbType.Int32;
				colvarOutRegistId.MaxLength = 0;
				colvarOutRegistId.AutoIncrement = true;
				colvarOutRegistId.IsNullable = false;
				colvarOutRegistId.IsPrimaryKey = true;
				colvarOutRegistId.IsForeignKey = false;
				colvarOutRegistId.IsReadOnly = false;
				colvarOutRegistId.DefaultSetting = @"";
				colvarOutRegistId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOutRegistId);
				
				TableSchema.TableColumn colvarOutDate = new TableSchema.TableColumn(schema);
				colvarOutDate.ColumnName = "OutDate";
				colvarOutDate.DataType = DbType.String;
				colvarOutDate.MaxLength = 50;
				colvarOutDate.AutoIncrement = false;
				colvarOutDate.IsNullable = true;
				colvarOutDate.IsPrimaryKey = false;
				colvarOutDate.IsForeignKey = false;
				colvarOutDate.IsReadOnly = false;
				colvarOutDate.DefaultSetting = @"";
				colvarOutDate.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOutDate);
				
				TableSchema.TableColumn colvarOutTime = new TableSchema.TableColumn(schema);
				colvarOutTime.ColumnName = "OutTime";
				colvarOutTime.DataType = DbType.String;
				colvarOutTime.MaxLength = 50;
				colvarOutTime.AutoIncrement = false;
				colvarOutTime.IsNullable = true;
				colvarOutTime.IsPrimaryKey = false;
				colvarOutTime.IsForeignKey = false;
				colvarOutTime.IsReadOnly = false;
				colvarOutTime.DefaultSetting = @"";
				colvarOutTime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOutTime);
				
				TableSchema.TableColumn colvarOutContent = new TableSchema.TableColumn(schema);
				colvarOutContent.ColumnName = "OutContent";
				colvarOutContent.DataType = DbType.String;
				colvarOutContent.MaxLength = -1;
				colvarOutContent.AutoIncrement = false;
				colvarOutContent.IsNullable = true;
				colvarOutContent.IsPrimaryKey = false;
				colvarOutContent.IsForeignKey = false;
				colvarOutContent.IsReadOnly = false;
				colvarOutContent.DefaultSetting = @"";
				colvarOutContent.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOutContent);
				
				TableSchema.TableColumn colvarBackTime = new TableSchema.TableColumn(schema);
				colvarBackTime.ColumnName = "BackTime";
				colvarBackTime.DataType = DbType.String;
				colvarBackTime.MaxLength = 50;
				colvarBackTime.AutoIncrement = false;
				colvarBackTime.IsNullable = true;
				colvarBackTime.IsPrimaryKey = false;
				colvarBackTime.IsForeignKey = false;
				colvarBackTime.IsReadOnly = false;
				colvarBackTime.DefaultSetting = @"";
				colvarBackTime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBackTime);
				
				TableSchema.TableColumn colvarOutTool = new TableSchema.TableColumn(schema);
				colvarOutTool.ColumnName = "OutTool";
				colvarOutTool.DataType = DbType.String;
				colvarOutTool.MaxLength = 50;
				colvarOutTool.AutoIncrement = false;
				colvarOutTool.IsNullable = true;
				colvarOutTool.IsPrimaryKey = false;
				colvarOutTool.IsForeignKey = false;
				colvarOutTool.IsReadOnly = false;
				colvarOutTool.DefaultSetting = @"";
				colvarOutTool.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOutTool);
				
				TableSchema.TableColumn colvarMemo = new TableSchema.TableColumn(schema);
				colvarMemo.ColumnName = "Memo";
				colvarMemo.DataType = DbType.String;
				colvarMemo.MaxLength = -1;
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
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("OutRegist_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("OutRegistId")]
		[Bindable(true)]
		public int OutRegistId 
		{
			get { return GetColumnValue<int>(Columns.OutRegistId); }
			set { SetColumnValue(Columns.OutRegistId, value); }
		}
		  
		[XmlAttribute("OutDate")]
		[Bindable(true)]
		public string OutDate 
		{
			get { return GetColumnValue<string>(Columns.OutDate); }
			set { SetColumnValue(Columns.OutDate, value); }
		}
		  
		[XmlAttribute("OutTime")]
		[Bindable(true)]
		public string OutTime 
		{
			get { return GetColumnValue<string>(Columns.OutTime); }
			set { SetColumnValue(Columns.OutTime, value); }
		}
		  
		[XmlAttribute("OutContent")]
		[Bindable(true)]
		public string OutContent 
		{
			get { return GetColumnValue<string>(Columns.OutContent); }
			set { SetColumnValue(Columns.OutContent, value); }
		}
		  
		[XmlAttribute("BackTime")]
		[Bindable(true)]
		public string BackTime 
		{
			get { return GetColumnValue<string>(Columns.BackTime); }
			set { SetColumnValue(Columns.BackTime, value); }
		}
		  
		[XmlAttribute("OutTool")]
		[Bindable(true)]
		public string OutTool 
		{
			get { return GetColumnValue<string>(Columns.OutTool); }
			set { SetColumnValue(Columns.OutTool, value); }
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
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varOutDate,string varOutTime,string varOutContent,string varBackTime,string varOutTool,string varMemo,string varApplyName,string varDepartName,int? varState)
		{
			OutRegist item = new OutRegist();
			
			item.OutDate = varOutDate;
			
			item.OutTime = varOutTime;
			
			item.OutContent = varOutContent;
			
			item.BackTime = varBackTime;
			
			item.OutTool = varOutTool;
			
			item.Memo = varMemo;
			
			item.ApplyName = varApplyName;
			
			item.DepartName = varDepartName;
			
			item.State = varState;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varOutRegistId,string varOutDate,string varOutTime,string varOutContent,string varBackTime,string varOutTool,string varMemo,string varApplyName,string varDepartName,int? varState)
		{
			OutRegist item = new OutRegist();
			
				item.OutRegistId = varOutRegistId;
			
				item.OutDate = varOutDate;
			
				item.OutTime = varOutTime;
			
				item.OutContent = varOutContent;
			
				item.BackTime = varBackTime;
			
				item.OutTool = varOutTool;
			
				item.Memo = varMemo;
			
				item.ApplyName = varApplyName;
			
				item.DepartName = varDepartName;
			
				item.State = varState;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn OutRegistIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn OutDateColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn OutTimeColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn OutContentColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn BackTimeColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn OutToolColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn MemoColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn ApplyNameColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn DepartNameColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn StateColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string OutRegistId = @"OutRegistId";
			 public static string OutDate = @"OutDate";
			 public static string OutTime = @"OutTime";
			 public static string OutContent = @"OutContent";
			 public static string BackTime = @"BackTime";
			 public static string OutTool = @"OutTool";
			 public static string Memo = @"Memo";
			 public static string ApplyName = @"ApplyName";
			 public static string DepartName = @"DepartName";
			 public static string State = @"State";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
