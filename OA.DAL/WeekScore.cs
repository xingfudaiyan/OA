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
	/// Strongly-typed collection for the WeekScore class.
	/// </summary>
    [Serializable]
	public partial class WeekScoreCollection : ActiveList<WeekScore, WeekScoreCollection>
	{	   
		public WeekScoreCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>WeekScoreCollection</returns>
		public WeekScoreCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                WeekScore o = this[i];
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
	/// This is an ActiveRecord class which wraps the WeekScore_tb table.
	/// </summary>
	[Serializable]
	public partial class WeekScore : ActiveRecord<WeekScore>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public WeekScore()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public WeekScore(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public WeekScore(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public WeekScore(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("WeekScore_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarWeekScoreId = new TableSchema.TableColumn(schema);
				colvarWeekScoreId.ColumnName = "WeekScoreId";
				colvarWeekScoreId.DataType = DbType.Int32;
				colvarWeekScoreId.MaxLength = 0;
				colvarWeekScoreId.AutoIncrement = true;
				colvarWeekScoreId.IsNullable = false;
				colvarWeekScoreId.IsPrimaryKey = true;
				colvarWeekScoreId.IsForeignKey = false;
				colvarWeekScoreId.IsReadOnly = false;
				colvarWeekScoreId.DefaultSetting = @"";
				colvarWeekScoreId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarWeekScoreId);
				
				TableSchema.TableColumn colvarWeekScoreNum = new TableSchema.TableColumn(schema);
				colvarWeekScoreNum.ColumnName = "WeekScoreNum";
				colvarWeekScoreNum.DataType = DbType.String;
				colvarWeekScoreNum.MaxLength = 50;
				colvarWeekScoreNum.AutoIncrement = false;
				colvarWeekScoreNum.IsNullable = true;
				colvarWeekScoreNum.IsPrimaryKey = false;
				colvarWeekScoreNum.IsForeignKey = false;
				colvarWeekScoreNum.IsReadOnly = false;
				colvarWeekScoreNum.DefaultSetting = @"";
				colvarWeekScoreNum.ForeignKeyTableName = "";
				schema.Columns.Add(colvarWeekScoreNum);
				
				TableSchema.TableColumn colvarIsSubmit = new TableSchema.TableColumn(schema);
				colvarIsSubmit.ColumnName = "IsSubmit";
				colvarIsSubmit.DataType = DbType.Int32;
				colvarIsSubmit.MaxLength = 0;
				colvarIsSubmit.AutoIncrement = false;
				colvarIsSubmit.IsNullable = true;
				colvarIsSubmit.IsPrimaryKey = false;
				colvarIsSubmit.IsForeignKey = false;
				colvarIsSubmit.IsReadOnly = false;
				colvarIsSubmit.DefaultSetting = @"";
				colvarIsSubmit.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIsSubmit);
				
				TableSchema.TableColumn colvarEmployeeId = new TableSchema.TableColumn(schema);
				colvarEmployeeId.ColumnName = "EmployeeId";
				colvarEmployeeId.DataType = DbType.Int32;
				colvarEmployeeId.MaxLength = 0;
				colvarEmployeeId.AutoIncrement = false;
				colvarEmployeeId.IsNullable = true;
				colvarEmployeeId.IsPrimaryKey = false;
				colvarEmployeeId.IsForeignKey = false;
				colvarEmployeeId.IsReadOnly = false;
				colvarEmployeeId.DefaultSetting = @"";
				colvarEmployeeId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEmployeeId);
				
				TableSchema.TableColumn colvarTotalScore = new TableSchema.TableColumn(schema);
				colvarTotalScore.ColumnName = "TotalScore";
				colvarTotalScore.DataType = DbType.String;
				colvarTotalScore.MaxLength = 50;
				colvarTotalScore.AutoIncrement = false;
				colvarTotalScore.IsNullable = true;
				colvarTotalScore.IsPrimaryKey = false;
				colvarTotalScore.IsForeignKey = false;
				colvarTotalScore.IsReadOnly = false;
				colvarTotalScore.DefaultSetting = @"";
				colvarTotalScore.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTotalScore);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("WeekScore_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("WeekScoreId")]
		[Bindable(true)]
		public int WeekScoreId 
		{
			get { return GetColumnValue<int>(Columns.WeekScoreId); }
			set { SetColumnValue(Columns.WeekScoreId, value); }
		}
		  
		[XmlAttribute("WeekScoreNum")]
		[Bindable(true)]
		public string WeekScoreNum 
		{
			get { return GetColumnValue<string>(Columns.WeekScoreNum); }
			set { SetColumnValue(Columns.WeekScoreNum, value); }
		}
		  
		[XmlAttribute("IsSubmit")]
		[Bindable(true)]
		public int? IsSubmit 
		{
			get { return GetColumnValue<int?>(Columns.IsSubmit); }
			set { SetColumnValue(Columns.IsSubmit, value); }
		}
		  
		[XmlAttribute("EmployeeId")]
		[Bindable(true)]
		public int? EmployeeId 
		{
			get { return GetColumnValue<int?>(Columns.EmployeeId); }
			set { SetColumnValue(Columns.EmployeeId, value); }
		}
		  
		[XmlAttribute("TotalScore")]
		[Bindable(true)]
		public string TotalScore 
		{
			get { return GetColumnValue<string>(Columns.TotalScore); }
			set { SetColumnValue(Columns.TotalScore, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varWeekScoreNum,int? varIsSubmit,int? varEmployeeId,string varTotalScore)
		{
			WeekScore item = new WeekScore();
			
			item.WeekScoreNum = varWeekScoreNum;
			
			item.IsSubmit = varIsSubmit;
			
			item.EmployeeId = varEmployeeId;
			
			item.TotalScore = varTotalScore;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varWeekScoreId,string varWeekScoreNum,int? varIsSubmit,int? varEmployeeId,string varTotalScore)
		{
			WeekScore item = new WeekScore();
			
				item.WeekScoreId = varWeekScoreId;
			
				item.WeekScoreNum = varWeekScoreNum;
			
				item.IsSubmit = varIsSubmit;
			
				item.EmployeeId = varEmployeeId;
			
				item.TotalScore = varTotalScore;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn WeekScoreIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn WeekScoreNumColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn IsSubmitColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn EmployeeIdColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn TotalScoreColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string WeekScoreId = @"WeekScoreId";
			 public static string WeekScoreNum = @"WeekScoreNum";
			 public static string IsSubmit = @"IsSubmit";
			 public static string EmployeeId = @"EmployeeId";
			 public static string TotalScore = @"TotalScore";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
