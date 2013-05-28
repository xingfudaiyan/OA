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
	/// Strongly-typed collection for the Relate class.
	/// </summary>
    [Serializable]
	public partial class RelateCollection : ActiveList<Relate, RelateCollection>
	{	   
		public RelateCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>RelateCollection</returns>
		public RelateCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                Relate o = this[i];
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
	/// This is an ActiveRecord class which wraps the Relate_tb table.
	/// </summary>
	[Serializable]
	public partial class Relate : ActiveRecord<Relate>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public Relate()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public Relate(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public Relate(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public Relate(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("Relate_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarRelateId = new TableSchema.TableColumn(schema);
				colvarRelateId.ColumnName = "RelateId";
				colvarRelateId.DataType = DbType.Int32;
				colvarRelateId.MaxLength = 0;
				colvarRelateId.AutoIncrement = true;
				colvarRelateId.IsNullable = false;
				colvarRelateId.IsPrimaryKey = true;
				colvarRelateId.IsForeignKey = false;
				colvarRelateId.IsReadOnly = false;
				colvarRelateId.DefaultSetting = @"";
				colvarRelateId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRelateId);
				
				TableSchema.TableColumn colvarRelateName = new TableSchema.TableColumn(schema);
				colvarRelateName.ColumnName = "RelateName";
				colvarRelateName.DataType = DbType.String;
				colvarRelateName.MaxLength = 50;
				colvarRelateName.AutoIncrement = false;
				colvarRelateName.IsNullable = true;
				colvarRelateName.IsPrimaryKey = false;
				colvarRelateName.IsForeignKey = false;
				colvarRelateName.IsReadOnly = false;
				colvarRelateName.DefaultSetting = @"";
				colvarRelateName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRelateName);
				
				TableSchema.TableColumn colvarMobile = new TableSchema.TableColumn(schema);
				colvarMobile.ColumnName = "Mobile";
				colvarMobile.DataType = DbType.String;
				colvarMobile.MaxLength = 50;
				colvarMobile.AutoIncrement = false;
				colvarMobile.IsNullable = true;
				colvarMobile.IsPrimaryKey = false;
				colvarMobile.IsForeignKey = false;
				colvarMobile.IsReadOnly = false;
				colvarMobile.DefaultSetting = @"";
				colvarMobile.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMobile);
				
				TableSchema.TableColumn colvarEmail = new TableSchema.TableColumn(schema);
				colvarEmail.ColumnName = "Email";
				colvarEmail.DataType = DbType.String;
				colvarEmail.MaxLength = 50;
				colvarEmail.AutoIncrement = false;
				colvarEmail.IsNullable = true;
				colvarEmail.IsPrimaryKey = false;
				colvarEmail.IsForeignKey = false;
				colvarEmail.IsReadOnly = false;
				colvarEmail.DefaultSetting = @"";
				colvarEmail.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEmail);
				
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
				
				TableSchema.TableColumn colvarClientId = new TableSchema.TableColumn(schema);
				colvarClientId.ColumnName = "ClientId";
				colvarClientId.DataType = DbType.Int32;
				colvarClientId.MaxLength = 0;
				colvarClientId.AutoIncrement = false;
				colvarClientId.IsNullable = true;
				colvarClientId.IsPrimaryKey = false;
				colvarClientId.IsForeignKey = false;
				colvarClientId.IsReadOnly = false;
				colvarClientId.DefaultSetting = @"";
				colvarClientId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarClientId);
				
				TableSchema.TableColumn colvarPosition = new TableSchema.TableColumn(schema);
				colvarPosition.ColumnName = "Position";
				colvarPosition.DataType = DbType.String;
				colvarPosition.MaxLength = 50;
				colvarPosition.AutoIncrement = false;
				colvarPosition.IsNullable = true;
				colvarPosition.IsPrimaryKey = false;
				colvarPosition.IsForeignKey = false;
				colvarPosition.IsReadOnly = false;
				colvarPosition.DefaultSetting = @"";
				colvarPosition.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPosition);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("Relate_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("RelateId")]
		[Bindable(true)]
		public int RelateId 
		{
			get { return GetColumnValue<int>(Columns.RelateId); }
			set { SetColumnValue(Columns.RelateId, value); }
		}
		  
		[XmlAttribute("RelateName")]
		[Bindable(true)]
		public string RelateName 
		{
			get { return GetColumnValue<string>(Columns.RelateName); }
			set { SetColumnValue(Columns.RelateName, value); }
		}
		  
		[XmlAttribute("Mobile")]
		[Bindable(true)]
		public string Mobile 
		{
			get { return GetColumnValue<string>(Columns.Mobile); }
			set { SetColumnValue(Columns.Mobile, value); }
		}
		  
		[XmlAttribute("Email")]
		[Bindable(true)]
		public string Email 
		{
			get { return GetColumnValue<string>(Columns.Email); }
			set { SetColumnValue(Columns.Email, value); }
		}
		  
		[XmlAttribute("Memo")]
		[Bindable(true)]
		public string Memo 
		{
			get { return GetColumnValue<string>(Columns.Memo); }
			set { SetColumnValue(Columns.Memo, value); }
		}
		  
		[XmlAttribute("ClientId")]
		[Bindable(true)]
		public int? ClientId 
		{
			get { return GetColumnValue<int?>(Columns.ClientId); }
			set { SetColumnValue(Columns.ClientId, value); }
		}
		  
		[XmlAttribute("Position")]
		[Bindable(true)]
		public string Position 
		{
			get { return GetColumnValue<string>(Columns.Position); }
			set { SetColumnValue(Columns.Position, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varRelateName,string varMobile,string varEmail,string varMemo,int? varClientId,string varPosition)
		{
			Relate item = new Relate();
			
			item.RelateName = varRelateName;
			
			item.Mobile = varMobile;
			
			item.Email = varEmail;
			
			item.Memo = varMemo;
			
			item.ClientId = varClientId;
			
			item.Position = varPosition;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varRelateId,string varRelateName,string varMobile,string varEmail,string varMemo,int? varClientId,string varPosition)
		{
			Relate item = new Relate();
			
				item.RelateId = varRelateId;
			
				item.RelateName = varRelateName;
			
				item.Mobile = varMobile;
			
				item.Email = varEmail;
			
				item.Memo = varMemo;
			
				item.ClientId = varClientId;
			
				item.Position = varPosition;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn RelateIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn RelateNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn MobileColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn EmailColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn MemoColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn ClientIdColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn PositionColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string RelateId = @"RelateId";
			 public static string RelateName = @"RelateName";
			 public static string Mobile = @"Mobile";
			 public static string Email = @"Email";
			 public static string Memo = @"Memo";
			 public static string ClientId = @"ClientId";
			 public static string Position = @"Position";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
