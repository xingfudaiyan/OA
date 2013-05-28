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
	/// Strongly-typed collection for the CarApply class.
	/// </summary>
    [Serializable]
	public partial class CarApplyCollection : ActiveList<CarApply, CarApplyCollection>
	{	   
		public CarApplyCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>CarApplyCollection</returns>
		public CarApplyCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                CarApply o = this[i];
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
	/// This is an ActiveRecord class which wraps the CarApply_tb table.
	/// </summary>
	[Serializable]
	public partial class CarApply : ActiveRecord<CarApply>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public CarApply()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public CarApply(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public CarApply(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public CarApply(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("CarApply_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarCarApplyId = new TableSchema.TableColumn(schema);
				colvarCarApplyId.ColumnName = "CarApplyId";
				colvarCarApplyId.DataType = DbType.Int32;
				colvarCarApplyId.MaxLength = 0;
				colvarCarApplyId.AutoIncrement = true;
				colvarCarApplyId.IsNullable = false;
				colvarCarApplyId.IsPrimaryKey = true;
				colvarCarApplyId.IsForeignKey = false;
				colvarCarApplyId.IsReadOnly = false;
				colvarCarApplyId.DefaultSetting = @"";
				colvarCarApplyId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCarApplyId);
				
				TableSchema.TableColumn colvarSheetNum = new TableSchema.TableColumn(schema);
				colvarSheetNum.ColumnName = "SheetNum";
				colvarSheetNum.DataType = DbType.String;
				colvarSheetNum.MaxLength = 50;
				colvarSheetNum.AutoIncrement = false;
				colvarSheetNum.IsNullable = true;
				colvarSheetNum.IsPrimaryKey = false;
				colvarSheetNum.IsForeignKey = false;
				colvarSheetNum.IsReadOnly = false;
				colvarSheetNum.DefaultSetting = @"";
				colvarSheetNum.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSheetNum);
				
				TableSchema.TableColumn colvarApplyTime = new TableSchema.TableColumn(schema);
				colvarApplyTime.ColumnName = "ApplyTime";
				colvarApplyTime.DataType = DbType.DateTime;
				colvarApplyTime.MaxLength = 0;
				colvarApplyTime.AutoIncrement = false;
				colvarApplyTime.IsNullable = true;
				colvarApplyTime.IsPrimaryKey = false;
				colvarApplyTime.IsForeignKey = false;
				colvarApplyTime.IsReadOnly = false;
				colvarApplyTime.DefaultSetting = @"";
				colvarApplyTime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarApplyTime);
				
				TableSchema.TableColumn colvarBeginSite = new TableSchema.TableColumn(schema);
				colvarBeginSite.ColumnName = "BeginSite";
				colvarBeginSite.DataType = DbType.String;
				colvarBeginSite.MaxLength = 50;
				colvarBeginSite.AutoIncrement = false;
				colvarBeginSite.IsNullable = true;
				colvarBeginSite.IsPrimaryKey = false;
				colvarBeginSite.IsForeignKey = false;
				colvarBeginSite.IsReadOnly = false;
				colvarBeginSite.DefaultSetting = @"";
				colvarBeginSite.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBeginSite);
				
				TableSchema.TableColumn colvarEndSite = new TableSchema.TableColumn(schema);
				colvarEndSite.ColumnName = "EndSite";
				colvarEndSite.DataType = DbType.String;
				colvarEndSite.MaxLength = 50;
				colvarEndSite.AutoIncrement = false;
				colvarEndSite.IsNullable = true;
				colvarEndSite.IsPrimaryKey = false;
				colvarEndSite.IsForeignKey = false;
				colvarEndSite.IsReadOnly = false;
				colvarEndSite.DefaultSetting = @"";
				colvarEndSite.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEndSite);
				
				TableSchema.TableColumn colvarReason = new TableSchema.TableColumn(schema);
				colvarReason.ColumnName = "Reason";
				colvarReason.DataType = DbType.String;
				colvarReason.MaxLength = 50;
				colvarReason.AutoIncrement = false;
				colvarReason.IsNullable = true;
				colvarReason.IsPrimaryKey = false;
				colvarReason.IsForeignKey = false;
				colvarReason.IsReadOnly = false;
				colvarReason.DefaultSetting = @"";
				colvarReason.ForeignKeyTableName = "";
				schema.Columns.Add(colvarReason);
				
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
				
				TableSchema.TableColumn colvarStateId = new TableSchema.TableColumn(schema);
				colvarStateId.ColumnName = "StateId";
				colvarStateId.DataType = DbType.Int32;
				colvarStateId.MaxLength = 0;
				colvarStateId.AutoIncrement = false;
				colvarStateId.IsNullable = true;
				colvarStateId.IsPrimaryKey = false;
				colvarStateId.IsForeignKey = false;
				colvarStateId.IsReadOnly = false;
				colvarStateId.DefaultSetting = @"";
				colvarStateId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarStateId);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("CarApply_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("CarApplyId")]
		[Bindable(true)]
		public int CarApplyId 
		{
			get { return GetColumnValue<int>(Columns.CarApplyId); }
			set { SetColumnValue(Columns.CarApplyId, value); }
		}
		  
		[XmlAttribute("SheetNum")]
		[Bindable(true)]
		public string SheetNum 
		{
			get { return GetColumnValue<string>(Columns.SheetNum); }
			set { SetColumnValue(Columns.SheetNum, value); }
		}
		  
		[XmlAttribute("ApplyTime")]
		[Bindable(true)]
		public DateTime? ApplyTime 
		{
			get { return GetColumnValue<DateTime?>(Columns.ApplyTime); }
			set { SetColumnValue(Columns.ApplyTime, value); }
		}
		  
		[XmlAttribute("BeginSite")]
		[Bindable(true)]
		public string BeginSite 
		{
			get { return GetColumnValue<string>(Columns.BeginSite); }
			set { SetColumnValue(Columns.BeginSite, value); }
		}
		  
		[XmlAttribute("EndSite")]
		[Bindable(true)]
		public string EndSite 
		{
			get { return GetColumnValue<string>(Columns.EndSite); }
			set { SetColumnValue(Columns.EndSite, value); }
		}
		  
		[XmlAttribute("Reason")]
		[Bindable(true)]
		public string Reason 
		{
			get { return GetColumnValue<string>(Columns.Reason); }
			set { SetColumnValue(Columns.Reason, value); }
		}
		  
		[XmlAttribute("Memo")]
		[Bindable(true)]
		public string Memo 
		{
			get { return GetColumnValue<string>(Columns.Memo); }
			set { SetColumnValue(Columns.Memo, value); }
		}
		  
		[XmlAttribute("StateId")]
		[Bindable(true)]
		public int? StateId 
		{
			get { return GetColumnValue<int?>(Columns.StateId); }
			set { SetColumnValue(Columns.StateId, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varSheetNum,DateTime? varApplyTime,string varBeginSite,string varEndSite,string varReason,string varMemo,int? varStateId)
		{
			CarApply item = new CarApply();
			
			item.SheetNum = varSheetNum;
			
			item.ApplyTime = varApplyTime;
			
			item.BeginSite = varBeginSite;
			
			item.EndSite = varEndSite;
			
			item.Reason = varReason;
			
			item.Memo = varMemo;
			
			item.StateId = varStateId;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varCarApplyId,string varSheetNum,DateTime? varApplyTime,string varBeginSite,string varEndSite,string varReason,string varMemo,int? varStateId)
		{
			CarApply item = new CarApply();
			
				item.CarApplyId = varCarApplyId;
			
				item.SheetNum = varSheetNum;
			
				item.ApplyTime = varApplyTime;
			
				item.BeginSite = varBeginSite;
			
				item.EndSite = varEndSite;
			
				item.Reason = varReason;
			
				item.Memo = varMemo;
			
				item.StateId = varStateId;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn CarApplyIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn SheetNumColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn ApplyTimeColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn BeginSiteColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn EndSiteColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn ReasonColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn MemoColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn StateIdColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string CarApplyId = @"CarApplyId";
			 public static string SheetNum = @"SheetNum";
			 public static string ApplyTime = @"ApplyTime";
			 public static string BeginSite = @"BeginSite";
			 public static string EndSite = @"EndSite";
			 public static string Reason = @"Reason";
			 public static string Memo = @"Memo";
			 public static string StateId = @"StateId";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
