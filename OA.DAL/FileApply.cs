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
	/// Strongly-typed collection for the FileApply class.
	/// </summary>
    [Serializable]
	public partial class FileApplyCollection : ActiveList<FileApply, FileApplyCollection>
	{	   
		public FileApplyCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>FileApplyCollection</returns>
		public FileApplyCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                FileApply o = this[i];
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
	/// This is an ActiveRecord class which wraps the FileApply_tb table.
	/// </summary>
	[Serializable]
	public partial class FileApply : ActiveRecord<FileApply>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public FileApply()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public FileApply(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public FileApply(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public FileApply(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("FileApply_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarFileApplyId = new TableSchema.TableColumn(schema);
				colvarFileApplyId.ColumnName = "FileApplyId";
				colvarFileApplyId.DataType = DbType.Int32;
				colvarFileApplyId.MaxLength = 0;
				colvarFileApplyId.AutoIncrement = true;
				colvarFileApplyId.IsNullable = false;
				colvarFileApplyId.IsPrimaryKey = true;
				colvarFileApplyId.IsForeignKey = false;
				colvarFileApplyId.IsReadOnly = false;
				colvarFileApplyId.DefaultSetting = @"";
				colvarFileApplyId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFileApplyId);
				
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
				
				TableSchema.TableColumn colvarFilesName = new TableSchema.TableColumn(schema);
				colvarFilesName.ColumnName = "FilesName";
				colvarFilesName.DataType = DbType.String;
				colvarFilesName.MaxLength = 50;
				colvarFilesName.AutoIncrement = false;
				colvarFilesName.IsNullable = true;
				colvarFilesName.IsPrimaryKey = false;
				colvarFilesName.IsForeignKey = false;
				colvarFilesName.IsReadOnly = false;
				colvarFilesName.DefaultSetting = @"";
				colvarFilesName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFilesName);
				
				TableSchema.TableColumn colvarFileType = new TableSchema.TableColumn(schema);
				colvarFileType.ColumnName = "FileType";
				colvarFileType.DataType = DbType.String;
				colvarFileType.MaxLength = 50;
				colvarFileType.AutoIncrement = false;
				colvarFileType.IsNullable = true;
				colvarFileType.IsPrimaryKey = false;
				colvarFileType.IsForeignKey = false;
				colvarFileType.IsReadOnly = false;
				colvarFileType.DefaultSetting = @"";
				colvarFileType.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFileType);
				
				TableSchema.TableColumn colvarFileDes = new TableSchema.TableColumn(schema);
				colvarFileDes.ColumnName = "FileDes";
				colvarFileDes.DataType = DbType.String;
				colvarFileDes.MaxLength = -1;
				colvarFileDes.AutoIncrement = false;
				colvarFileDes.IsNullable = true;
				colvarFileDes.IsPrimaryKey = false;
				colvarFileDes.IsForeignKey = false;
				colvarFileDes.IsReadOnly = false;
				colvarFileDes.DefaultSetting = @"";
				colvarFileDes.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFileDes);
				
				TableSchema.TableColumn colvarDepartView = new TableSchema.TableColumn(schema);
				colvarDepartView.ColumnName = "DepartView";
				colvarDepartView.DataType = DbType.String;
				colvarDepartView.MaxLength = -1;
				colvarDepartView.AutoIncrement = false;
				colvarDepartView.IsNullable = true;
				colvarDepartView.IsPrimaryKey = false;
				colvarDepartView.IsForeignKey = false;
				colvarDepartView.IsReadOnly = false;
				colvarDepartView.DefaultSetting = @"";
				colvarDepartView.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDepartView);
				
				TableSchema.TableColumn colvarManagerView = new TableSchema.TableColumn(schema);
				colvarManagerView.ColumnName = "ManagerView";
				colvarManagerView.DataType = DbType.String;
				colvarManagerView.MaxLength = -1;
				colvarManagerView.AutoIncrement = false;
				colvarManagerView.IsNullable = true;
				colvarManagerView.IsPrimaryKey = false;
				colvarManagerView.IsForeignKey = false;
				colvarManagerView.IsReadOnly = false;
				colvarManagerView.DefaultSetting = @"";
				colvarManagerView.ForeignKeyTableName = "";
				schema.Columns.Add(colvarManagerView);
				
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
				
				TableSchema.TableColumn colvarFileOfApplyId = new TableSchema.TableColumn(schema);
				colvarFileOfApplyId.ColumnName = "FileOfApplyId";
				colvarFileOfApplyId.DataType = DbType.Int32;
				colvarFileOfApplyId.MaxLength = 0;
				colvarFileOfApplyId.AutoIncrement = false;
				colvarFileOfApplyId.IsNullable = true;
				colvarFileOfApplyId.IsPrimaryKey = false;
				colvarFileOfApplyId.IsForeignKey = false;
				colvarFileOfApplyId.IsReadOnly = false;
				colvarFileOfApplyId.DefaultSetting = @"";
				colvarFileOfApplyId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFileOfApplyId);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("FileApply_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("FileApplyId")]
		[Bindable(true)]
		public int FileApplyId 
		{
			get { return GetColumnValue<int>(Columns.FileApplyId); }
			set { SetColumnValue(Columns.FileApplyId, value); }
		}
		  
		[XmlAttribute("ApplyTime")]
		[Bindable(true)]
		public string ApplyTime 
		{
			get { return GetColumnValue<string>(Columns.ApplyTime); }
			set { SetColumnValue(Columns.ApplyTime, value); }
		}
		  
		[XmlAttribute("FilesName")]
		[Bindable(true)]
		public string FilesName 
		{
			get { return GetColumnValue<string>(Columns.FilesName); }
			set { SetColumnValue(Columns.FilesName, value); }
		}
		  
		[XmlAttribute("FileType")]
		[Bindable(true)]
		public string FileType 
		{
			get { return GetColumnValue<string>(Columns.FileType); }
			set { SetColumnValue(Columns.FileType, value); }
		}
		  
		[XmlAttribute("FileDes")]
		[Bindable(true)]
		public string FileDes 
		{
			get { return GetColumnValue<string>(Columns.FileDes); }
			set { SetColumnValue(Columns.FileDes, value); }
		}
		  
		[XmlAttribute("DepartView")]
		[Bindable(true)]
		public string DepartView 
		{
			get { return GetColumnValue<string>(Columns.DepartView); }
			set { SetColumnValue(Columns.DepartView, value); }
		}
		  
		[XmlAttribute("ManagerView")]
		[Bindable(true)]
		public string ManagerView 
		{
			get { return GetColumnValue<string>(Columns.ManagerView); }
			set { SetColumnValue(Columns.ManagerView, value); }
		}
		  
		[XmlAttribute("State")]
		[Bindable(true)]
		public int? State 
		{
			get { return GetColumnValue<int?>(Columns.State); }
			set { SetColumnValue(Columns.State, value); }
		}
		  
		[XmlAttribute("DepartName")]
		[Bindable(true)]
		public string DepartName 
		{
			get { return GetColumnValue<string>(Columns.DepartName); }
			set { SetColumnValue(Columns.DepartName, value); }
		}
		  
		[XmlAttribute("ApplyName")]
		[Bindable(true)]
		public string ApplyName 
		{
			get { return GetColumnValue<string>(Columns.ApplyName); }
			set { SetColumnValue(Columns.ApplyName, value); }
		}
		  
		[XmlAttribute("FileOfApplyId")]
		[Bindable(true)]
		public int? FileOfApplyId 
		{
			get { return GetColumnValue<int?>(Columns.FileOfApplyId); }
			set { SetColumnValue(Columns.FileOfApplyId, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varApplyTime,string varFilesName,string varFileType,string varFileDes,string varDepartView,string varManagerView,int? varState,string varDepartName,string varApplyName,int? varFileOfApplyId)
		{
			FileApply item = new FileApply();
			
			item.ApplyTime = varApplyTime;
			
			item.FilesName = varFilesName;
			
			item.FileType = varFileType;
			
			item.FileDes = varFileDes;
			
			item.DepartView = varDepartView;
			
			item.ManagerView = varManagerView;
			
			item.State = varState;
			
			item.DepartName = varDepartName;
			
			item.ApplyName = varApplyName;
			
			item.FileOfApplyId = varFileOfApplyId;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varFileApplyId,string varApplyTime,string varFilesName,string varFileType,string varFileDes,string varDepartView,string varManagerView,int? varState,string varDepartName,string varApplyName,int? varFileOfApplyId)
		{
			FileApply item = new FileApply();
			
				item.FileApplyId = varFileApplyId;
			
				item.ApplyTime = varApplyTime;
			
				item.FilesName = varFilesName;
			
				item.FileType = varFileType;
			
				item.FileDes = varFileDes;
			
				item.DepartView = varDepartView;
			
				item.ManagerView = varManagerView;
			
				item.State = varState;
			
				item.DepartName = varDepartName;
			
				item.ApplyName = varApplyName;
			
				item.FileOfApplyId = varFileOfApplyId;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn FileApplyIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ApplyTimeColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn FilesNameColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn FileTypeColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn FileDesColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn DepartViewColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn ManagerViewColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn StateColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn DepartNameColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn ApplyNameColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn FileOfApplyIdColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string FileApplyId = @"FileApplyId";
			 public static string ApplyTime = @"ApplyTime";
			 public static string FilesName = @"FilesName";
			 public static string FileType = @"FileType";
			 public static string FileDes = @"FileDes";
			 public static string DepartView = @"DepartView";
			 public static string ManagerView = @"ManagerView";
			 public static string State = @"State";
			 public static string DepartName = @"DepartName";
			 public static string ApplyName = @"ApplyName";
			 public static string FileOfApplyId = @"FileOfApplyId";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
