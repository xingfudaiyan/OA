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
	/// Strongly-typed collection for the OfferFile class.
	/// </summary>
    [Serializable]
	public partial class OfferFileCollection : ActiveList<OfferFile, OfferFileCollection>
	{	   
		public OfferFileCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>OfferFileCollection</returns>
		public OfferFileCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                OfferFile o = this[i];
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
	/// This is an ActiveRecord class which wraps the OfferFile_tb table.
	/// </summary>
	[Serializable]
	public partial class OfferFile : ActiveRecord<OfferFile>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public OfferFile()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public OfferFile(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public OfferFile(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public OfferFile(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("OfferFile_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarOfferFileId = new TableSchema.TableColumn(schema);
				colvarOfferFileId.ColumnName = "OfferFileId";
				colvarOfferFileId.DataType = DbType.Int32;
				colvarOfferFileId.MaxLength = 0;
				colvarOfferFileId.AutoIncrement = true;
				colvarOfferFileId.IsNullable = false;
				colvarOfferFileId.IsPrimaryKey = true;
				colvarOfferFileId.IsForeignKey = false;
				colvarOfferFileId.IsReadOnly = false;
				colvarOfferFileId.DefaultSetting = @"";
				colvarOfferFileId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOfferFileId);
				
				TableSchema.TableColumn colvarOfferFileName = new TableSchema.TableColumn(schema);
				colvarOfferFileName.ColumnName = "OfferFileName";
				colvarOfferFileName.DataType = DbType.String;
				colvarOfferFileName.MaxLength = 50;
				colvarOfferFileName.AutoIncrement = false;
				colvarOfferFileName.IsNullable = true;
				colvarOfferFileName.IsPrimaryKey = false;
				colvarOfferFileName.IsForeignKey = false;
				colvarOfferFileName.IsReadOnly = false;
				colvarOfferFileName.DefaultSetting = @"";
				colvarOfferFileName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOfferFileName);
				
				TableSchema.TableColumn colvarPhyFileName = new TableSchema.TableColumn(schema);
				colvarPhyFileName.ColumnName = "PhyFileName";
				colvarPhyFileName.DataType = DbType.String;
				colvarPhyFileName.MaxLength = 100;
				colvarPhyFileName.AutoIncrement = false;
				colvarPhyFileName.IsNullable = true;
				colvarPhyFileName.IsPrimaryKey = false;
				colvarPhyFileName.IsForeignKey = false;
				colvarPhyFileName.IsReadOnly = false;
				colvarPhyFileName.DefaultSetting = @"";
				colvarPhyFileName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPhyFileName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("OfferFile_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("OfferFileId")]
		[Bindable(true)]
		public int OfferFileId 
		{
			get { return GetColumnValue<int>(Columns.OfferFileId); }
			set { SetColumnValue(Columns.OfferFileId, value); }
		}
		  
		[XmlAttribute("OfferFileName")]
		[Bindable(true)]
		public string OfferFileName 
		{
			get { return GetColumnValue<string>(Columns.OfferFileName); }
			set { SetColumnValue(Columns.OfferFileName, value); }
		}
		  
		[XmlAttribute("PhyFileName")]
		[Bindable(true)]
		public string PhyFileName 
		{
			get { return GetColumnValue<string>(Columns.PhyFileName); }
			set { SetColumnValue(Columns.PhyFileName, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varOfferFileName,string varPhyFileName)
		{
			OfferFile item = new OfferFile();
			
			item.OfferFileName = varOfferFileName;
			
			item.PhyFileName = varPhyFileName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varOfferFileId,string varOfferFileName,string varPhyFileName)
		{
			OfferFile item = new OfferFile();
			
				item.OfferFileId = varOfferFileId;
			
				item.OfferFileName = varOfferFileName;
			
				item.PhyFileName = varPhyFileName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn OfferFileIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn OfferFileNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn PhyFileNameColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string OfferFileId = @"OfferFileId";
			 public static string OfferFileName = @"OfferFileName";
			 public static string PhyFileName = @"PhyFileName";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
