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
	/// Strongly-typed collection for the OtGroup class.
	/// </summary>
    [Serializable]
	public partial class OtGroupCollection : ActiveList<OtGroup, OtGroupCollection>
	{	   
		public OtGroupCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>OtGroupCollection</returns>
		public OtGroupCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                OtGroup o = this[i];
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
	/// This is an ActiveRecord class which wraps the OtGroup_tb table.
	/// </summary>
	[Serializable]
	public partial class OtGroup : ActiveRecord<OtGroup>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public OtGroup()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public OtGroup(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public OtGroup(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public OtGroup(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("OtGroup_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarOtGroupId = new TableSchema.TableColumn(schema);
				colvarOtGroupId.ColumnName = "OtGroupId";
				colvarOtGroupId.DataType = DbType.Int32;
				colvarOtGroupId.MaxLength = 0;
				colvarOtGroupId.AutoIncrement = true;
				colvarOtGroupId.IsNullable = false;
				colvarOtGroupId.IsPrimaryKey = true;
				colvarOtGroupId.IsForeignKey = false;
				colvarOtGroupId.IsReadOnly = false;
				colvarOtGroupId.DefaultSetting = @"";
				colvarOtGroupId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOtGroupId);
				
				TableSchema.TableColumn colvarGroupName = new TableSchema.TableColumn(schema);
				colvarGroupName.ColumnName = "GroupName";
				colvarGroupName.DataType = DbType.String;
				colvarGroupName.MaxLength = 50;
				colvarGroupName.AutoIncrement = false;
				colvarGroupName.IsNullable = true;
				colvarGroupName.IsPrimaryKey = false;
				colvarGroupName.IsForeignKey = false;
				colvarGroupName.IsReadOnly = false;
				colvarGroupName.DefaultSetting = @"";
				colvarGroupName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarGroupName);
				
				TableSchema.TableColumn colvarOverTimeId = new TableSchema.TableColumn(schema);
				colvarOverTimeId.ColumnName = "OverTimeId";
				colvarOverTimeId.DataType = DbType.Int32;
				colvarOverTimeId.MaxLength = 0;
				colvarOverTimeId.AutoIncrement = false;
				colvarOverTimeId.IsNullable = true;
				colvarOverTimeId.IsPrimaryKey = false;
				colvarOverTimeId.IsForeignKey = false;
				colvarOverTimeId.IsReadOnly = false;
				colvarOverTimeId.DefaultSetting = @"";
				colvarOverTimeId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOverTimeId);
				
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
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("OtGroup_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("OtGroupId")]
		[Bindable(true)]
		public int OtGroupId 
		{
			get { return GetColumnValue<int>(Columns.OtGroupId); }
			set { SetColumnValue(Columns.OtGroupId, value); }
		}
		  
		[XmlAttribute("GroupName")]
		[Bindable(true)]
		public string GroupName 
		{
			get { return GetColumnValue<string>(Columns.GroupName); }
			set { SetColumnValue(Columns.GroupName, value); }
		}
		  
		[XmlAttribute("OverTimeId")]
		[Bindable(true)]
		public int? OverTimeId 
		{
			get { return GetColumnValue<int?>(Columns.OverTimeId); }
			set { SetColumnValue(Columns.OverTimeId, value); }
		}
		  
		[XmlAttribute("ApplyName")]
		[Bindable(true)]
		public string ApplyName 
		{
			get { return GetColumnValue<string>(Columns.ApplyName); }
			set { SetColumnValue(Columns.ApplyName, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varGroupName,int? varOverTimeId,string varApplyName)
		{
			OtGroup item = new OtGroup();
			
			item.GroupName = varGroupName;
			
			item.OverTimeId = varOverTimeId;
			
			item.ApplyName = varApplyName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varOtGroupId,string varGroupName,int? varOverTimeId,string varApplyName)
		{
			OtGroup item = new OtGroup();
			
				item.OtGroupId = varOtGroupId;
			
				item.GroupName = varGroupName;
			
				item.OverTimeId = varOverTimeId;
			
				item.ApplyName = varApplyName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn OtGroupIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn GroupNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn OverTimeIdColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn ApplyNameColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string OtGroupId = @"OtGroupId";
			 public static string GroupName = @"GroupName";
			 public static string OverTimeId = @"OverTimeId";
			 public static string ApplyName = @"ApplyName";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
