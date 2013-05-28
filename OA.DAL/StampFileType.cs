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
	/// Strongly-typed collection for the StampFileType class.
	/// </summary>
    [Serializable]
	public partial class StampFileTypeCollection : ActiveList<StampFileType, StampFileTypeCollection>
	{	   
		public StampFileTypeCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>StampFileTypeCollection</returns>
		public StampFileTypeCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                StampFileType o = this[i];
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
	/// This is an ActiveRecord class which wraps the StampFileType_tb table.
	/// </summary>
	[Serializable]
	public partial class StampFileType : ActiveRecord<StampFileType>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public StampFileType()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public StampFileType(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public StampFileType(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public StampFileType(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("StampFileType_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarStampFileTypeId = new TableSchema.TableColumn(schema);
				colvarStampFileTypeId.ColumnName = "StampFileTypeId";
				colvarStampFileTypeId.DataType = DbType.Int32;
				colvarStampFileTypeId.MaxLength = 0;
				colvarStampFileTypeId.AutoIncrement = true;
				colvarStampFileTypeId.IsNullable = false;
				colvarStampFileTypeId.IsPrimaryKey = true;
				colvarStampFileTypeId.IsForeignKey = false;
				colvarStampFileTypeId.IsReadOnly = false;
				colvarStampFileTypeId.DefaultSetting = @"";
				colvarStampFileTypeId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarStampFileTypeId);
				
				TableSchema.TableColumn colvarStampFileTypeName = new TableSchema.TableColumn(schema);
				colvarStampFileTypeName.ColumnName = "StampFileTypeName";
				colvarStampFileTypeName.DataType = DbType.String;
				colvarStampFileTypeName.MaxLength = 50;
				colvarStampFileTypeName.AutoIncrement = false;
				colvarStampFileTypeName.IsNullable = true;
				colvarStampFileTypeName.IsPrimaryKey = false;
				colvarStampFileTypeName.IsForeignKey = false;
				colvarStampFileTypeName.IsReadOnly = false;
				colvarStampFileTypeName.DefaultSetting = @"";
				colvarStampFileTypeName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarStampFileTypeName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("StampFileType_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("StampFileTypeId")]
		[Bindable(true)]
		public int StampFileTypeId 
		{
			get { return GetColumnValue<int>(Columns.StampFileTypeId); }
			set { SetColumnValue(Columns.StampFileTypeId, value); }
		}
		  
		[XmlAttribute("StampFileTypeName")]
		[Bindable(true)]
		public string StampFileTypeName 
		{
			get { return GetColumnValue<string>(Columns.StampFileTypeName); }
			set { SetColumnValue(Columns.StampFileTypeName, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varStampFileTypeName)
		{
			StampFileType item = new StampFileType();
			
			item.StampFileTypeName = varStampFileTypeName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varStampFileTypeId,string varStampFileTypeName)
		{
			StampFileType item = new StampFileType();
			
				item.StampFileTypeId = varStampFileTypeId;
			
				item.StampFileTypeName = varStampFileTypeName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn StampFileTypeIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn StampFileTypeNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string StampFileTypeId = @"StampFileTypeId";
			 public static string StampFileTypeName = @"StampFileTypeName";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
