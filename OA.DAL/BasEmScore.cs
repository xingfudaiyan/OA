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
	/// Strongly-typed collection for the BasEmScore class.
	/// </summary>
    [Serializable]
	public partial class BasEmScoreCollection : ActiveList<BasEmScore, BasEmScoreCollection>
	{	   
		public BasEmScoreCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>BasEmScoreCollection</returns>
		public BasEmScoreCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                BasEmScore o = this[i];
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
	/// This is an ActiveRecord class which wraps the BasEmScore_tb table.
	/// </summary>
	[Serializable]
	public partial class BasEmScore : ActiveRecord<BasEmScore>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public BasEmScore()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public BasEmScore(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public BasEmScore(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public BasEmScore(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("BasEmScore_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarBasEmScoreId = new TableSchema.TableColumn(schema);
				colvarBasEmScoreId.ColumnName = "BasEmScoreId";
				colvarBasEmScoreId.DataType = DbType.Int32;
				colvarBasEmScoreId.MaxLength = 0;
				colvarBasEmScoreId.AutoIncrement = true;
				colvarBasEmScoreId.IsNullable = false;
				colvarBasEmScoreId.IsPrimaryKey = true;
				colvarBasEmScoreId.IsForeignKey = false;
				colvarBasEmScoreId.IsReadOnly = false;
				colvarBasEmScoreId.DefaultSetting = @"";
				colvarBasEmScoreId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBasEmScoreId);
				
				TableSchema.TableColumn colvarDateSpan = new TableSchema.TableColumn(schema);
				colvarDateSpan.ColumnName = "DateSpan";
				colvarDateSpan.DataType = DbType.String;
				colvarDateSpan.MaxLength = 10;
				colvarDateSpan.AutoIncrement = false;
				colvarDateSpan.IsNullable = true;
				colvarDateSpan.IsPrimaryKey = false;
				colvarDateSpan.IsForeignKey = false;
				colvarDateSpan.IsReadOnly = false;
				colvarDateSpan.DefaultSetting = @"";
				colvarDateSpan.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDateSpan);
				
				TableSchema.TableColumn colvarEvaluateLevelId = new TableSchema.TableColumn(schema);
				colvarEvaluateLevelId.ColumnName = "EvaluateLevelId";
				colvarEvaluateLevelId.DataType = DbType.Int32;
				colvarEvaluateLevelId.MaxLength = 0;
				colvarEvaluateLevelId.AutoIncrement = false;
				colvarEvaluateLevelId.IsNullable = true;
				colvarEvaluateLevelId.IsPrimaryKey = false;
				colvarEvaluateLevelId.IsForeignKey = false;
				colvarEvaluateLevelId.IsReadOnly = false;
				colvarEvaluateLevelId.DefaultSetting = @"";
				colvarEvaluateLevelId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEvaluateLevelId);
				
				TableSchema.TableColumn colvarTotalScore = new TableSchema.TableColumn(schema);
				colvarTotalScore.ColumnName = "TotalScore";
				colvarTotalScore.DataType = DbType.String;
				colvarTotalScore.MaxLength = 10;
				colvarTotalScore.AutoIncrement = false;
				colvarTotalScore.IsNullable = true;
				colvarTotalScore.IsPrimaryKey = false;
				colvarTotalScore.IsForeignKey = false;
				colvarTotalScore.IsReadOnly = false;
				colvarTotalScore.DefaultSetting = @"";
				colvarTotalScore.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTotalScore);
				
				TableSchema.TableColumn colvarUpViews = new TableSchema.TableColumn(schema);
				colvarUpViews.ColumnName = "UpViews";
				colvarUpViews.DataType = DbType.String;
				colvarUpViews.MaxLength = -1;
				colvarUpViews.AutoIncrement = false;
				colvarUpViews.IsNullable = true;
				colvarUpViews.IsPrimaryKey = false;
				colvarUpViews.IsForeignKey = false;
				colvarUpViews.IsReadOnly = false;
				colvarUpViews.DefaultSetting = @"";
				colvarUpViews.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpViews);
				
				TableSchema.TableColumn colvarYearId = new TableSchema.TableColumn(schema);
				colvarYearId.ColumnName = "YearId";
				colvarYearId.DataType = DbType.Int32;
				colvarYearId.MaxLength = 0;
				colvarYearId.AutoIncrement = false;
				colvarYearId.IsNullable = true;
				colvarYearId.IsPrimaryKey = false;
				colvarYearId.IsForeignKey = false;
				colvarYearId.IsReadOnly = false;
				colvarYearId.DefaultSetting = @"";
				colvarYearId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarYearId);
				
				TableSchema.TableColumn colvarMonthId = new TableSchema.TableColumn(schema);
				colvarMonthId.ColumnName = "MonthId";
				colvarMonthId.DataType = DbType.Int32;
				colvarMonthId.MaxLength = 0;
				colvarMonthId.AutoIncrement = false;
				colvarMonthId.IsNullable = true;
				colvarMonthId.IsPrimaryKey = false;
				colvarMonthId.IsForeignKey = false;
				colvarMonthId.IsReadOnly = false;
				colvarMonthId.DefaultSetting = @"";
				colvarMonthId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMonthId);
				
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
				
				TableSchema.TableColumn colvarSelfbas1 = new TableSchema.TableColumn(schema);
				colvarSelfbas1.ColumnName = "Selfbas1";
				colvarSelfbas1.DataType = DbType.String;
				colvarSelfbas1.MaxLength = 10;
				colvarSelfbas1.AutoIncrement = false;
				colvarSelfbas1.IsNullable = true;
				colvarSelfbas1.IsPrimaryKey = false;
				colvarSelfbas1.IsForeignKey = false;
				colvarSelfbas1.IsReadOnly = false;
				colvarSelfbas1.DefaultSetting = @"";
				colvarSelfbas1.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfbas1);
				
				TableSchema.TableColumn colvarSelfbas2 = new TableSchema.TableColumn(schema);
				colvarSelfbas2.ColumnName = "Selfbas2";
				colvarSelfbas2.DataType = DbType.String;
				colvarSelfbas2.MaxLength = 10;
				colvarSelfbas2.AutoIncrement = false;
				colvarSelfbas2.IsNullable = true;
				colvarSelfbas2.IsPrimaryKey = false;
				colvarSelfbas2.IsForeignKey = false;
				colvarSelfbas2.IsReadOnly = false;
				colvarSelfbas2.DefaultSetting = @"";
				colvarSelfbas2.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfbas2);
				
				TableSchema.TableColumn colvarSelfbas3 = new TableSchema.TableColumn(schema);
				colvarSelfbas3.ColumnName = "Selfbas3";
				colvarSelfbas3.DataType = DbType.String;
				colvarSelfbas3.MaxLength = 10;
				colvarSelfbas3.AutoIncrement = false;
				colvarSelfbas3.IsNullable = true;
				colvarSelfbas3.IsPrimaryKey = false;
				colvarSelfbas3.IsForeignKey = false;
				colvarSelfbas3.IsReadOnly = false;
				colvarSelfbas3.DefaultSetting = @"";
				colvarSelfbas3.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfbas3);
				
				TableSchema.TableColumn colvarSelfbas4 = new TableSchema.TableColumn(schema);
				colvarSelfbas4.ColumnName = "Selfbas4";
				colvarSelfbas4.DataType = DbType.String;
				colvarSelfbas4.MaxLength = 10;
				colvarSelfbas4.AutoIncrement = false;
				colvarSelfbas4.IsNullable = true;
				colvarSelfbas4.IsPrimaryKey = false;
				colvarSelfbas4.IsForeignKey = false;
				colvarSelfbas4.IsReadOnly = false;
				colvarSelfbas4.DefaultSetting = @"";
				colvarSelfbas4.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfbas4);
				
				TableSchema.TableColumn colvarSelfbas5 = new TableSchema.TableColumn(schema);
				colvarSelfbas5.ColumnName = "Selfbas5";
				colvarSelfbas5.DataType = DbType.String;
				colvarSelfbas5.MaxLength = 10;
				colvarSelfbas5.AutoIncrement = false;
				colvarSelfbas5.IsNullable = true;
				colvarSelfbas5.IsPrimaryKey = false;
				colvarSelfbas5.IsForeignKey = false;
				colvarSelfbas5.IsReadOnly = false;
				colvarSelfbas5.DefaultSetting = @"";
				colvarSelfbas5.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfbas5);
				
				TableSchema.TableColumn colvarSelfbas6 = new TableSchema.TableColumn(schema);
				colvarSelfbas6.ColumnName = "Selfbas6";
				colvarSelfbas6.DataType = DbType.String;
				colvarSelfbas6.MaxLength = 10;
				colvarSelfbas6.AutoIncrement = false;
				colvarSelfbas6.IsNullable = true;
				colvarSelfbas6.IsPrimaryKey = false;
				colvarSelfbas6.IsForeignKey = false;
				colvarSelfbas6.IsReadOnly = false;
				colvarSelfbas6.DefaultSetting = @"";
				colvarSelfbas6.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfbas6);
				
				TableSchema.TableColumn colvarSelfbas7 = new TableSchema.TableColumn(schema);
				colvarSelfbas7.ColumnName = "Selfbas7";
				colvarSelfbas7.DataType = DbType.String;
				colvarSelfbas7.MaxLength = 10;
				colvarSelfbas7.AutoIncrement = false;
				colvarSelfbas7.IsNullable = true;
				colvarSelfbas7.IsPrimaryKey = false;
				colvarSelfbas7.IsForeignKey = false;
				colvarSelfbas7.IsReadOnly = false;
				colvarSelfbas7.DefaultSetting = @"";
				colvarSelfbas7.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfbas7);
				
				TableSchema.TableColumn colvarSelfbas8 = new TableSchema.TableColumn(schema);
				colvarSelfbas8.ColumnName = "Selfbas8";
				colvarSelfbas8.DataType = DbType.String;
				colvarSelfbas8.MaxLength = 10;
				colvarSelfbas8.AutoIncrement = false;
				colvarSelfbas8.IsNullable = true;
				colvarSelfbas8.IsPrimaryKey = false;
				colvarSelfbas8.IsForeignKey = false;
				colvarSelfbas8.IsReadOnly = false;
				colvarSelfbas8.DefaultSetting = @"";
				colvarSelfbas8.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfbas8);
				
				TableSchema.TableColumn colvarSelfbas9 = new TableSchema.TableColumn(schema);
				colvarSelfbas9.ColumnName = "Selfbas9";
				colvarSelfbas9.DataType = DbType.String;
				colvarSelfbas9.MaxLength = 10;
				colvarSelfbas9.AutoIncrement = false;
				colvarSelfbas9.IsNullable = true;
				colvarSelfbas9.IsPrimaryKey = false;
				colvarSelfbas9.IsForeignKey = false;
				colvarSelfbas9.IsReadOnly = false;
				colvarSelfbas9.DefaultSetting = @"";
				colvarSelfbas9.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfbas9);
				
				TableSchema.TableColumn colvarSelfbas10 = new TableSchema.TableColumn(schema);
				colvarSelfbas10.ColumnName = "Selfbas10";
				colvarSelfbas10.DataType = DbType.String;
				colvarSelfbas10.MaxLength = 10;
				colvarSelfbas10.AutoIncrement = false;
				colvarSelfbas10.IsNullable = true;
				colvarSelfbas10.IsPrimaryKey = false;
				colvarSelfbas10.IsForeignKey = false;
				colvarSelfbas10.IsReadOnly = false;
				colvarSelfbas10.DefaultSetting = @"";
				colvarSelfbas10.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfbas10);
				
				TableSchema.TableColumn colvarSelfbas11 = new TableSchema.TableColumn(schema);
				colvarSelfbas11.ColumnName = "Selfbas11";
				colvarSelfbas11.DataType = DbType.String;
				colvarSelfbas11.MaxLength = 10;
				colvarSelfbas11.AutoIncrement = false;
				colvarSelfbas11.IsNullable = true;
				colvarSelfbas11.IsPrimaryKey = false;
				colvarSelfbas11.IsForeignKey = false;
				colvarSelfbas11.IsReadOnly = false;
				colvarSelfbas11.DefaultSetting = @"";
				colvarSelfbas11.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfbas11);
				
				TableSchema.TableColumn colvarSelfbas12 = new TableSchema.TableColumn(schema);
				colvarSelfbas12.ColumnName = "Selfbas12";
				colvarSelfbas12.DataType = DbType.String;
				colvarSelfbas12.MaxLength = 10;
				colvarSelfbas12.AutoIncrement = false;
				colvarSelfbas12.IsNullable = true;
				colvarSelfbas12.IsPrimaryKey = false;
				colvarSelfbas12.IsForeignKey = false;
				colvarSelfbas12.IsReadOnly = false;
				colvarSelfbas12.DefaultSetting = @"";
				colvarSelfbas12.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfbas12);
				
				TableSchema.TableColumn colvarSelfbas13 = new TableSchema.TableColumn(schema);
				colvarSelfbas13.ColumnName = "Selfbas13";
				colvarSelfbas13.DataType = DbType.String;
				colvarSelfbas13.MaxLength = 10;
				colvarSelfbas13.AutoIncrement = false;
				colvarSelfbas13.IsNullable = true;
				colvarSelfbas13.IsPrimaryKey = false;
				colvarSelfbas13.IsForeignKey = false;
				colvarSelfbas13.IsReadOnly = false;
				colvarSelfbas13.DefaultSetting = @"";
				colvarSelfbas13.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfbas13);
				
				TableSchema.TableColumn colvarSelfbas14 = new TableSchema.TableColumn(schema);
				colvarSelfbas14.ColumnName = "Selfbas14";
				colvarSelfbas14.DataType = DbType.String;
				colvarSelfbas14.MaxLength = 10;
				colvarSelfbas14.AutoIncrement = false;
				colvarSelfbas14.IsNullable = true;
				colvarSelfbas14.IsPrimaryKey = false;
				colvarSelfbas14.IsForeignKey = false;
				colvarSelfbas14.IsReadOnly = false;
				colvarSelfbas14.DefaultSetting = @"";
				colvarSelfbas14.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfbas14);
				
				TableSchema.TableColumn colvarSelfbas15 = new TableSchema.TableColumn(schema);
				colvarSelfbas15.ColumnName = "Selfbas15";
				colvarSelfbas15.DataType = DbType.String;
				colvarSelfbas15.MaxLength = 10;
				colvarSelfbas15.AutoIncrement = false;
				colvarSelfbas15.IsNullable = true;
				colvarSelfbas15.IsPrimaryKey = false;
				colvarSelfbas15.IsForeignKey = false;
				colvarSelfbas15.IsReadOnly = false;
				colvarSelfbas15.DefaultSetting = @"";
				colvarSelfbas15.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfbas15);
				
				TableSchema.TableColumn colvarSelfbas16 = new TableSchema.TableColumn(schema);
				colvarSelfbas16.ColumnName = "Selfbas16";
				colvarSelfbas16.DataType = DbType.String;
				colvarSelfbas16.MaxLength = 10;
				colvarSelfbas16.AutoIncrement = false;
				colvarSelfbas16.IsNullable = true;
				colvarSelfbas16.IsPrimaryKey = false;
				colvarSelfbas16.IsForeignKey = false;
				colvarSelfbas16.IsReadOnly = false;
				colvarSelfbas16.DefaultSetting = @"";
				colvarSelfbas16.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfbas16);
				
				TableSchema.TableColumn colvarSelfbas17 = new TableSchema.TableColumn(schema);
				colvarSelfbas17.ColumnName = "Selfbas17";
				colvarSelfbas17.DataType = DbType.String;
				colvarSelfbas17.MaxLength = 10;
				colvarSelfbas17.AutoIncrement = false;
				colvarSelfbas17.IsNullable = true;
				colvarSelfbas17.IsPrimaryKey = false;
				colvarSelfbas17.IsForeignKey = false;
				colvarSelfbas17.IsReadOnly = false;
				colvarSelfbas17.DefaultSetting = @"";
				colvarSelfbas17.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfbas17);
				
				TableSchema.TableColumn colvarUpbas1 = new TableSchema.TableColumn(schema);
				colvarUpbas1.ColumnName = "Upbas1";
				colvarUpbas1.DataType = DbType.String;
				colvarUpbas1.MaxLength = 10;
				colvarUpbas1.AutoIncrement = false;
				colvarUpbas1.IsNullable = true;
				colvarUpbas1.IsPrimaryKey = false;
				colvarUpbas1.IsForeignKey = false;
				colvarUpbas1.IsReadOnly = false;
				colvarUpbas1.DefaultSetting = @"";
				colvarUpbas1.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpbas1);
				
				TableSchema.TableColumn colvarUpbas2 = new TableSchema.TableColumn(schema);
				colvarUpbas2.ColumnName = "Upbas2";
				colvarUpbas2.DataType = DbType.String;
				colvarUpbas2.MaxLength = 10;
				colvarUpbas2.AutoIncrement = false;
				colvarUpbas2.IsNullable = true;
				colvarUpbas2.IsPrimaryKey = false;
				colvarUpbas2.IsForeignKey = false;
				colvarUpbas2.IsReadOnly = false;
				colvarUpbas2.DefaultSetting = @"";
				colvarUpbas2.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpbas2);
				
				TableSchema.TableColumn colvarUpbas3 = new TableSchema.TableColumn(schema);
				colvarUpbas3.ColumnName = "Upbas3";
				colvarUpbas3.DataType = DbType.String;
				colvarUpbas3.MaxLength = 10;
				colvarUpbas3.AutoIncrement = false;
				colvarUpbas3.IsNullable = true;
				colvarUpbas3.IsPrimaryKey = false;
				colvarUpbas3.IsForeignKey = false;
				colvarUpbas3.IsReadOnly = false;
				colvarUpbas3.DefaultSetting = @"";
				colvarUpbas3.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpbas3);
				
				TableSchema.TableColumn colvarUpbas4 = new TableSchema.TableColumn(schema);
				colvarUpbas4.ColumnName = "Upbas4";
				colvarUpbas4.DataType = DbType.String;
				colvarUpbas4.MaxLength = 10;
				colvarUpbas4.AutoIncrement = false;
				colvarUpbas4.IsNullable = true;
				colvarUpbas4.IsPrimaryKey = false;
				colvarUpbas4.IsForeignKey = false;
				colvarUpbas4.IsReadOnly = false;
				colvarUpbas4.DefaultSetting = @"";
				colvarUpbas4.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpbas4);
				
				TableSchema.TableColumn colvarUpbas5 = new TableSchema.TableColumn(schema);
				colvarUpbas5.ColumnName = "Upbas5";
				colvarUpbas5.DataType = DbType.String;
				colvarUpbas5.MaxLength = 10;
				colvarUpbas5.AutoIncrement = false;
				colvarUpbas5.IsNullable = true;
				colvarUpbas5.IsPrimaryKey = false;
				colvarUpbas5.IsForeignKey = false;
				colvarUpbas5.IsReadOnly = false;
				colvarUpbas5.DefaultSetting = @"";
				colvarUpbas5.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpbas5);
				
				TableSchema.TableColumn colvarUpbas6 = new TableSchema.TableColumn(schema);
				colvarUpbas6.ColumnName = "Upbas6";
				colvarUpbas6.DataType = DbType.String;
				colvarUpbas6.MaxLength = 10;
				colvarUpbas6.AutoIncrement = false;
				colvarUpbas6.IsNullable = true;
				colvarUpbas6.IsPrimaryKey = false;
				colvarUpbas6.IsForeignKey = false;
				colvarUpbas6.IsReadOnly = false;
				colvarUpbas6.DefaultSetting = @"";
				colvarUpbas6.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpbas6);
				
				TableSchema.TableColumn colvarUpbas7 = new TableSchema.TableColumn(schema);
				colvarUpbas7.ColumnName = "Upbas7";
				colvarUpbas7.DataType = DbType.String;
				colvarUpbas7.MaxLength = 10;
				colvarUpbas7.AutoIncrement = false;
				colvarUpbas7.IsNullable = true;
				colvarUpbas7.IsPrimaryKey = false;
				colvarUpbas7.IsForeignKey = false;
				colvarUpbas7.IsReadOnly = false;
				colvarUpbas7.DefaultSetting = @"";
				colvarUpbas7.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpbas7);
				
				TableSchema.TableColumn colvarUpbas8 = new TableSchema.TableColumn(schema);
				colvarUpbas8.ColumnName = "Upbas8";
				colvarUpbas8.DataType = DbType.String;
				colvarUpbas8.MaxLength = 10;
				colvarUpbas8.AutoIncrement = false;
				colvarUpbas8.IsNullable = true;
				colvarUpbas8.IsPrimaryKey = false;
				colvarUpbas8.IsForeignKey = false;
				colvarUpbas8.IsReadOnly = false;
				colvarUpbas8.DefaultSetting = @"";
				colvarUpbas8.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpbas8);
				
				TableSchema.TableColumn colvarUpbas9 = new TableSchema.TableColumn(schema);
				colvarUpbas9.ColumnName = "Upbas9";
				colvarUpbas9.DataType = DbType.String;
				colvarUpbas9.MaxLength = 10;
				colvarUpbas9.AutoIncrement = false;
				colvarUpbas9.IsNullable = true;
				colvarUpbas9.IsPrimaryKey = false;
				colvarUpbas9.IsForeignKey = false;
				colvarUpbas9.IsReadOnly = false;
				colvarUpbas9.DefaultSetting = @"";
				colvarUpbas9.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpbas9);
				
				TableSchema.TableColumn colvarUpbas10 = new TableSchema.TableColumn(schema);
				colvarUpbas10.ColumnName = "Upbas10";
				colvarUpbas10.DataType = DbType.String;
				colvarUpbas10.MaxLength = 10;
				colvarUpbas10.AutoIncrement = false;
				colvarUpbas10.IsNullable = true;
				colvarUpbas10.IsPrimaryKey = false;
				colvarUpbas10.IsForeignKey = false;
				colvarUpbas10.IsReadOnly = false;
				colvarUpbas10.DefaultSetting = @"";
				colvarUpbas10.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpbas10);
				
				TableSchema.TableColumn colvarUpbas11 = new TableSchema.TableColumn(schema);
				colvarUpbas11.ColumnName = "Upbas11";
				colvarUpbas11.DataType = DbType.String;
				colvarUpbas11.MaxLength = 10;
				colvarUpbas11.AutoIncrement = false;
				colvarUpbas11.IsNullable = true;
				colvarUpbas11.IsPrimaryKey = false;
				colvarUpbas11.IsForeignKey = false;
				colvarUpbas11.IsReadOnly = false;
				colvarUpbas11.DefaultSetting = @"";
				colvarUpbas11.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpbas11);
				
				TableSchema.TableColumn colvarUpbas12 = new TableSchema.TableColumn(schema);
				colvarUpbas12.ColumnName = "Upbas12";
				colvarUpbas12.DataType = DbType.String;
				colvarUpbas12.MaxLength = 10;
				colvarUpbas12.AutoIncrement = false;
				colvarUpbas12.IsNullable = true;
				colvarUpbas12.IsPrimaryKey = false;
				colvarUpbas12.IsForeignKey = false;
				colvarUpbas12.IsReadOnly = false;
				colvarUpbas12.DefaultSetting = @"";
				colvarUpbas12.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpbas12);
				
				TableSchema.TableColumn colvarUpbas13 = new TableSchema.TableColumn(schema);
				colvarUpbas13.ColumnName = "Upbas13";
				colvarUpbas13.DataType = DbType.String;
				colvarUpbas13.MaxLength = 10;
				colvarUpbas13.AutoIncrement = false;
				colvarUpbas13.IsNullable = true;
				colvarUpbas13.IsPrimaryKey = false;
				colvarUpbas13.IsForeignKey = false;
				colvarUpbas13.IsReadOnly = false;
				colvarUpbas13.DefaultSetting = @"";
				colvarUpbas13.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpbas13);
				
				TableSchema.TableColumn colvarUpbas14 = new TableSchema.TableColumn(schema);
				colvarUpbas14.ColumnName = "Upbas14";
				colvarUpbas14.DataType = DbType.String;
				colvarUpbas14.MaxLength = 10;
				colvarUpbas14.AutoIncrement = false;
				colvarUpbas14.IsNullable = true;
				colvarUpbas14.IsPrimaryKey = false;
				colvarUpbas14.IsForeignKey = false;
				colvarUpbas14.IsReadOnly = false;
				colvarUpbas14.DefaultSetting = @"";
				colvarUpbas14.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpbas14);
				
				TableSchema.TableColumn colvarUpbas15 = new TableSchema.TableColumn(schema);
				colvarUpbas15.ColumnName = "Upbas15";
				colvarUpbas15.DataType = DbType.String;
				colvarUpbas15.MaxLength = 10;
				colvarUpbas15.AutoIncrement = false;
				colvarUpbas15.IsNullable = true;
				colvarUpbas15.IsPrimaryKey = false;
				colvarUpbas15.IsForeignKey = false;
				colvarUpbas15.IsReadOnly = false;
				colvarUpbas15.DefaultSetting = @"";
				colvarUpbas15.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpbas15);
				
				TableSchema.TableColumn colvarUpbas16 = new TableSchema.TableColumn(schema);
				colvarUpbas16.ColumnName = "Upbas16";
				colvarUpbas16.DataType = DbType.String;
				colvarUpbas16.MaxLength = 10;
				colvarUpbas16.AutoIncrement = false;
				colvarUpbas16.IsNullable = true;
				colvarUpbas16.IsPrimaryKey = false;
				colvarUpbas16.IsForeignKey = false;
				colvarUpbas16.IsReadOnly = false;
				colvarUpbas16.DefaultSetting = @"";
				colvarUpbas16.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpbas16);
				
				TableSchema.TableColumn colvarUpbas17 = new TableSchema.TableColumn(schema);
				colvarUpbas17.ColumnName = "Upbas17";
				colvarUpbas17.DataType = DbType.String;
				colvarUpbas17.MaxLength = 10;
				colvarUpbas17.AutoIncrement = false;
				colvarUpbas17.IsNullable = true;
				colvarUpbas17.IsPrimaryKey = false;
				colvarUpbas17.IsForeignKey = false;
				colvarUpbas17.IsReadOnly = false;
				colvarUpbas17.DefaultSetting = @"";
				colvarUpbas17.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpbas17);
				
				TableSchema.TableColumn colvarSecbas1 = new TableSchema.TableColumn(schema);
				colvarSecbas1.ColumnName = "Secbas1";
				colvarSecbas1.DataType = DbType.String;
				colvarSecbas1.MaxLength = 10;
				colvarSecbas1.AutoIncrement = false;
				colvarSecbas1.IsNullable = true;
				colvarSecbas1.IsPrimaryKey = false;
				colvarSecbas1.IsForeignKey = false;
				colvarSecbas1.IsReadOnly = false;
				colvarSecbas1.DefaultSetting = @"";
				colvarSecbas1.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecbas1);
				
				TableSchema.TableColumn colvarSecbas2 = new TableSchema.TableColumn(schema);
				colvarSecbas2.ColumnName = "Secbas2";
				colvarSecbas2.DataType = DbType.String;
				colvarSecbas2.MaxLength = 10;
				colvarSecbas2.AutoIncrement = false;
				colvarSecbas2.IsNullable = true;
				colvarSecbas2.IsPrimaryKey = false;
				colvarSecbas2.IsForeignKey = false;
				colvarSecbas2.IsReadOnly = false;
				colvarSecbas2.DefaultSetting = @"";
				colvarSecbas2.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecbas2);
				
				TableSchema.TableColumn colvarSecbas3 = new TableSchema.TableColumn(schema);
				colvarSecbas3.ColumnName = "Secbas3";
				colvarSecbas3.DataType = DbType.String;
				colvarSecbas3.MaxLength = 10;
				colvarSecbas3.AutoIncrement = false;
				colvarSecbas3.IsNullable = true;
				colvarSecbas3.IsPrimaryKey = false;
				colvarSecbas3.IsForeignKey = false;
				colvarSecbas3.IsReadOnly = false;
				colvarSecbas3.DefaultSetting = @"";
				colvarSecbas3.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecbas3);
				
				TableSchema.TableColumn colvarSecbas4 = new TableSchema.TableColumn(schema);
				colvarSecbas4.ColumnName = "Secbas4";
				colvarSecbas4.DataType = DbType.String;
				colvarSecbas4.MaxLength = 10;
				colvarSecbas4.AutoIncrement = false;
				colvarSecbas4.IsNullable = true;
				colvarSecbas4.IsPrimaryKey = false;
				colvarSecbas4.IsForeignKey = false;
				colvarSecbas4.IsReadOnly = false;
				colvarSecbas4.DefaultSetting = @"";
				colvarSecbas4.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecbas4);
				
				TableSchema.TableColumn colvarSecbas5 = new TableSchema.TableColumn(schema);
				colvarSecbas5.ColumnName = "Secbas5";
				colvarSecbas5.DataType = DbType.String;
				colvarSecbas5.MaxLength = 10;
				colvarSecbas5.AutoIncrement = false;
				colvarSecbas5.IsNullable = true;
				colvarSecbas5.IsPrimaryKey = false;
				colvarSecbas5.IsForeignKey = false;
				colvarSecbas5.IsReadOnly = false;
				colvarSecbas5.DefaultSetting = @"";
				colvarSecbas5.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecbas5);
				
				TableSchema.TableColumn colvarSecbas6 = new TableSchema.TableColumn(schema);
				colvarSecbas6.ColumnName = "Secbas6";
				colvarSecbas6.DataType = DbType.String;
				colvarSecbas6.MaxLength = 10;
				colvarSecbas6.AutoIncrement = false;
				colvarSecbas6.IsNullable = true;
				colvarSecbas6.IsPrimaryKey = false;
				colvarSecbas6.IsForeignKey = false;
				colvarSecbas6.IsReadOnly = false;
				colvarSecbas6.DefaultSetting = @"";
				colvarSecbas6.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecbas6);
				
				TableSchema.TableColumn colvarSecbas7 = new TableSchema.TableColumn(schema);
				colvarSecbas7.ColumnName = "Secbas7";
				colvarSecbas7.DataType = DbType.String;
				colvarSecbas7.MaxLength = 10;
				colvarSecbas7.AutoIncrement = false;
				colvarSecbas7.IsNullable = true;
				colvarSecbas7.IsPrimaryKey = false;
				colvarSecbas7.IsForeignKey = false;
				colvarSecbas7.IsReadOnly = false;
				colvarSecbas7.DefaultSetting = @"";
				colvarSecbas7.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecbas7);
				
				TableSchema.TableColumn colvarSecbas8 = new TableSchema.TableColumn(schema);
				colvarSecbas8.ColumnName = "Secbas8";
				colvarSecbas8.DataType = DbType.String;
				colvarSecbas8.MaxLength = 10;
				colvarSecbas8.AutoIncrement = false;
				colvarSecbas8.IsNullable = true;
				colvarSecbas8.IsPrimaryKey = false;
				colvarSecbas8.IsForeignKey = false;
				colvarSecbas8.IsReadOnly = false;
				colvarSecbas8.DefaultSetting = @"";
				colvarSecbas8.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecbas8);
				
				TableSchema.TableColumn colvarSecbas9 = new TableSchema.TableColumn(schema);
				colvarSecbas9.ColumnName = "Secbas9";
				colvarSecbas9.DataType = DbType.String;
				colvarSecbas9.MaxLength = 10;
				colvarSecbas9.AutoIncrement = false;
				colvarSecbas9.IsNullable = true;
				colvarSecbas9.IsPrimaryKey = false;
				colvarSecbas9.IsForeignKey = false;
				colvarSecbas9.IsReadOnly = false;
				colvarSecbas9.DefaultSetting = @"";
				colvarSecbas9.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecbas9);
				
				TableSchema.TableColumn colvarSecbas10 = new TableSchema.TableColumn(schema);
				colvarSecbas10.ColumnName = "Secbas10";
				colvarSecbas10.DataType = DbType.String;
				colvarSecbas10.MaxLength = 10;
				colvarSecbas10.AutoIncrement = false;
				colvarSecbas10.IsNullable = true;
				colvarSecbas10.IsPrimaryKey = false;
				colvarSecbas10.IsForeignKey = false;
				colvarSecbas10.IsReadOnly = false;
				colvarSecbas10.DefaultSetting = @"";
				colvarSecbas10.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecbas10);
				
				TableSchema.TableColumn colvarSecbas11 = new TableSchema.TableColumn(schema);
				colvarSecbas11.ColumnName = "Secbas11";
				colvarSecbas11.DataType = DbType.String;
				colvarSecbas11.MaxLength = 10;
				colvarSecbas11.AutoIncrement = false;
				colvarSecbas11.IsNullable = true;
				colvarSecbas11.IsPrimaryKey = false;
				colvarSecbas11.IsForeignKey = false;
				colvarSecbas11.IsReadOnly = false;
				colvarSecbas11.DefaultSetting = @"";
				colvarSecbas11.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecbas11);
				
				TableSchema.TableColumn colvarSecbas12 = new TableSchema.TableColumn(schema);
				colvarSecbas12.ColumnName = "Secbas12";
				colvarSecbas12.DataType = DbType.String;
				colvarSecbas12.MaxLength = 10;
				colvarSecbas12.AutoIncrement = false;
				colvarSecbas12.IsNullable = true;
				colvarSecbas12.IsPrimaryKey = false;
				colvarSecbas12.IsForeignKey = false;
				colvarSecbas12.IsReadOnly = false;
				colvarSecbas12.DefaultSetting = @"";
				colvarSecbas12.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecbas12);
				
				TableSchema.TableColumn colvarSecbas13 = new TableSchema.TableColumn(schema);
				colvarSecbas13.ColumnName = "Secbas13";
				colvarSecbas13.DataType = DbType.String;
				colvarSecbas13.MaxLength = 10;
				colvarSecbas13.AutoIncrement = false;
				colvarSecbas13.IsNullable = true;
				colvarSecbas13.IsPrimaryKey = false;
				colvarSecbas13.IsForeignKey = false;
				colvarSecbas13.IsReadOnly = false;
				colvarSecbas13.DefaultSetting = @"";
				colvarSecbas13.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecbas13);
				
				TableSchema.TableColumn colvarSecbas14 = new TableSchema.TableColumn(schema);
				colvarSecbas14.ColumnName = "Secbas14";
				colvarSecbas14.DataType = DbType.String;
				colvarSecbas14.MaxLength = 10;
				colvarSecbas14.AutoIncrement = false;
				colvarSecbas14.IsNullable = true;
				colvarSecbas14.IsPrimaryKey = false;
				colvarSecbas14.IsForeignKey = false;
				colvarSecbas14.IsReadOnly = false;
				colvarSecbas14.DefaultSetting = @"";
				colvarSecbas14.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecbas14);
				
				TableSchema.TableColumn colvarSecbas15 = new TableSchema.TableColumn(schema);
				colvarSecbas15.ColumnName = "Secbas15";
				colvarSecbas15.DataType = DbType.String;
				colvarSecbas15.MaxLength = 10;
				colvarSecbas15.AutoIncrement = false;
				colvarSecbas15.IsNullable = true;
				colvarSecbas15.IsPrimaryKey = false;
				colvarSecbas15.IsForeignKey = false;
				colvarSecbas15.IsReadOnly = false;
				colvarSecbas15.DefaultSetting = @"";
				colvarSecbas15.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecbas15);
				
				TableSchema.TableColumn colvarSecbas16 = new TableSchema.TableColumn(schema);
				colvarSecbas16.ColumnName = "Secbas16";
				colvarSecbas16.DataType = DbType.String;
				colvarSecbas16.MaxLength = 10;
				colvarSecbas16.AutoIncrement = false;
				colvarSecbas16.IsNullable = true;
				colvarSecbas16.IsPrimaryKey = false;
				colvarSecbas16.IsForeignKey = false;
				colvarSecbas16.IsReadOnly = false;
				colvarSecbas16.DefaultSetting = @"";
				colvarSecbas16.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecbas16);
				
				TableSchema.TableColumn colvarSecbas17 = new TableSchema.TableColumn(schema);
				colvarSecbas17.ColumnName = "Secbas17";
				colvarSecbas17.DataType = DbType.String;
				colvarSecbas17.MaxLength = 10;
				colvarSecbas17.AutoIncrement = false;
				colvarSecbas17.IsNullable = true;
				colvarSecbas17.IsPrimaryKey = false;
				colvarSecbas17.IsForeignKey = false;
				colvarSecbas17.IsReadOnly = false;
				colvarSecbas17.DefaultSetting = @"";
				colvarSecbas17.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecbas17);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("BasEmScore_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("BasEmScoreId")]
		[Bindable(true)]
		public int BasEmScoreId 
		{
			get { return GetColumnValue<int>(Columns.BasEmScoreId); }
			set { SetColumnValue(Columns.BasEmScoreId, value); }
		}
		  
		[XmlAttribute("DateSpan")]
		[Bindable(true)]
		public string DateSpan 
		{
			get { return GetColumnValue<string>(Columns.DateSpan); }
			set { SetColumnValue(Columns.DateSpan, value); }
		}
		  
		[XmlAttribute("EvaluateLevelId")]
		[Bindable(true)]
		public int? EvaluateLevelId 
		{
			get { return GetColumnValue<int?>(Columns.EvaluateLevelId); }
			set { SetColumnValue(Columns.EvaluateLevelId, value); }
		}
		  
		[XmlAttribute("TotalScore")]
		[Bindable(true)]
		public string TotalScore 
		{
			get { return GetColumnValue<string>(Columns.TotalScore); }
			set { SetColumnValue(Columns.TotalScore, value); }
		}
		  
		[XmlAttribute("UpViews")]
		[Bindable(true)]
		public string UpViews 
		{
			get { return GetColumnValue<string>(Columns.UpViews); }
			set { SetColumnValue(Columns.UpViews, value); }
		}
		  
		[XmlAttribute("YearId")]
		[Bindable(true)]
		public int? YearId 
		{
			get { return GetColumnValue<int?>(Columns.YearId); }
			set { SetColumnValue(Columns.YearId, value); }
		}
		  
		[XmlAttribute("MonthId")]
		[Bindable(true)]
		public int? MonthId 
		{
			get { return GetColumnValue<int?>(Columns.MonthId); }
			set { SetColumnValue(Columns.MonthId, value); }
		}
		  
		[XmlAttribute("EmployeeId")]
		[Bindable(true)]
		public int? EmployeeId 
		{
			get { return GetColumnValue<int?>(Columns.EmployeeId); }
			set { SetColumnValue(Columns.EmployeeId, value); }
		}
		  
		[XmlAttribute("IsSubmit")]
		[Bindable(true)]
		public int? IsSubmit 
		{
			get { return GetColumnValue<int?>(Columns.IsSubmit); }
			set { SetColumnValue(Columns.IsSubmit, value); }
		}
		  
		[XmlAttribute("Selfbas1")]
		[Bindable(true)]
		public string Selfbas1 
		{
			get { return GetColumnValue<string>(Columns.Selfbas1); }
			set { SetColumnValue(Columns.Selfbas1, value); }
		}
		  
		[XmlAttribute("Selfbas2")]
		[Bindable(true)]
		public string Selfbas2 
		{
			get { return GetColumnValue<string>(Columns.Selfbas2); }
			set { SetColumnValue(Columns.Selfbas2, value); }
		}
		  
		[XmlAttribute("Selfbas3")]
		[Bindable(true)]
		public string Selfbas3 
		{
			get { return GetColumnValue<string>(Columns.Selfbas3); }
			set { SetColumnValue(Columns.Selfbas3, value); }
		}
		  
		[XmlAttribute("Selfbas4")]
		[Bindable(true)]
		public string Selfbas4 
		{
			get { return GetColumnValue<string>(Columns.Selfbas4); }
			set { SetColumnValue(Columns.Selfbas4, value); }
		}
		  
		[XmlAttribute("Selfbas5")]
		[Bindable(true)]
		public string Selfbas5 
		{
			get { return GetColumnValue<string>(Columns.Selfbas5); }
			set { SetColumnValue(Columns.Selfbas5, value); }
		}
		  
		[XmlAttribute("Selfbas6")]
		[Bindable(true)]
		public string Selfbas6 
		{
			get { return GetColumnValue<string>(Columns.Selfbas6); }
			set { SetColumnValue(Columns.Selfbas6, value); }
		}
		  
		[XmlAttribute("Selfbas7")]
		[Bindable(true)]
		public string Selfbas7 
		{
			get { return GetColumnValue<string>(Columns.Selfbas7); }
			set { SetColumnValue(Columns.Selfbas7, value); }
		}
		  
		[XmlAttribute("Selfbas8")]
		[Bindable(true)]
		public string Selfbas8 
		{
			get { return GetColumnValue<string>(Columns.Selfbas8); }
			set { SetColumnValue(Columns.Selfbas8, value); }
		}
		  
		[XmlAttribute("Selfbas9")]
		[Bindable(true)]
		public string Selfbas9 
		{
			get { return GetColumnValue<string>(Columns.Selfbas9); }
			set { SetColumnValue(Columns.Selfbas9, value); }
		}
		  
		[XmlAttribute("Selfbas10")]
		[Bindable(true)]
		public string Selfbas10 
		{
			get { return GetColumnValue<string>(Columns.Selfbas10); }
			set { SetColumnValue(Columns.Selfbas10, value); }
		}
		  
		[XmlAttribute("Selfbas11")]
		[Bindable(true)]
		public string Selfbas11 
		{
			get { return GetColumnValue<string>(Columns.Selfbas11); }
			set { SetColumnValue(Columns.Selfbas11, value); }
		}
		  
		[XmlAttribute("Selfbas12")]
		[Bindable(true)]
		public string Selfbas12 
		{
			get { return GetColumnValue<string>(Columns.Selfbas12); }
			set { SetColumnValue(Columns.Selfbas12, value); }
		}
		  
		[XmlAttribute("Selfbas13")]
		[Bindable(true)]
		public string Selfbas13 
		{
			get { return GetColumnValue<string>(Columns.Selfbas13); }
			set { SetColumnValue(Columns.Selfbas13, value); }
		}
		  
		[XmlAttribute("Selfbas14")]
		[Bindable(true)]
		public string Selfbas14 
		{
			get { return GetColumnValue<string>(Columns.Selfbas14); }
			set { SetColumnValue(Columns.Selfbas14, value); }
		}
		  
		[XmlAttribute("Selfbas15")]
		[Bindable(true)]
		public string Selfbas15 
		{
			get { return GetColumnValue<string>(Columns.Selfbas15); }
			set { SetColumnValue(Columns.Selfbas15, value); }
		}
		  
		[XmlAttribute("Selfbas16")]
		[Bindable(true)]
		public string Selfbas16 
		{
			get { return GetColumnValue<string>(Columns.Selfbas16); }
			set { SetColumnValue(Columns.Selfbas16, value); }
		}
		  
		[XmlAttribute("Selfbas17")]
		[Bindable(true)]
		public string Selfbas17 
		{
			get { return GetColumnValue<string>(Columns.Selfbas17); }
			set { SetColumnValue(Columns.Selfbas17, value); }
		}
		  
		[XmlAttribute("Upbas1")]
		[Bindable(true)]
		public string Upbas1 
		{
			get { return GetColumnValue<string>(Columns.Upbas1); }
			set { SetColumnValue(Columns.Upbas1, value); }
		}
		  
		[XmlAttribute("Upbas2")]
		[Bindable(true)]
		public string Upbas2 
		{
			get { return GetColumnValue<string>(Columns.Upbas2); }
			set { SetColumnValue(Columns.Upbas2, value); }
		}
		  
		[XmlAttribute("Upbas3")]
		[Bindable(true)]
		public string Upbas3 
		{
			get { return GetColumnValue<string>(Columns.Upbas3); }
			set { SetColumnValue(Columns.Upbas3, value); }
		}
		  
		[XmlAttribute("Upbas4")]
		[Bindable(true)]
		public string Upbas4 
		{
			get { return GetColumnValue<string>(Columns.Upbas4); }
			set { SetColumnValue(Columns.Upbas4, value); }
		}
		  
		[XmlAttribute("Upbas5")]
		[Bindable(true)]
		public string Upbas5 
		{
			get { return GetColumnValue<string>(Columns.Upbas5); }
			set { SetColumnValue(Columns.Upbas5, value); }
		}
		  
		[XmlAttribute("Upbas6")]
		[Bindable(true)]
		public string Upbas6 
		{
			get { return GetColumnValue<string>(Columns.Upbas6); }
			set { SetColumnValue(Columns.Upbas6, value); }
		}
		  
		[XmlAttribute("Upbas7")]
		[Bindable(true)]
		public string Upbas7 
		{
			get { return GetColumnValue<string>(Columns.Upbas7); }
			set { SetColumnValue(Columns.Upbas7, value); }
		}
		  
		[XmlAttribute("Upbas8")]
		[Bindable(true)]
		public string Upbas8 
		{
			get { return GetColumnValue<string>(Columns.Upbas8); }
			set { SetColumnValue(Columns.Upbas8, value); }
		}
		  
		[XmlAttribute("Upbas9")]
		[Bindable(true)]
		public string Upbas9 
		{
			get { return GetColumnValue<string>(Columns.Upbas9); }
			set { SetColumnValue(Columns.Upbas9, value); }
		}
		  
		[XmlAttribute("Upbas10")]
		[Bindable(true)]
		public string Upbas10 
		{
			get { return GetColumnValue<string>(Columns.Upbas10); }
			set { SetColumnValue(Columns.Upbas10, value); }
		}
		  
		[XmlAttribute("Upbas11")]
		[Bindable(true)]
		public string Upbas11 
		{
			get { return GetColumnValue<string>(Columns.Upbas11); }
			set { SetColumnValue(Columns.Upbas11, value); }
		}
		  
		[XmlAttribute("Upbas12")]
		[Bindable(true)]
		public string Upbas12 
		{
			get { return GetColumnValue<string>(Columns.Upbas12); }
			set { SetColumnValue(Columns.Upbas12, value); }
		}
		  
		[XmlAttribute("Upbas13")]
		[Bindable(true)]
		public string Upbas13 
		{
			get { return GetColumnValue<string>(Columns.Upbas13); }
			set { SetColumnValue(Columns.Upbas13, value); }
		}
		  
		[XmlAttribute("Upbas14")]
		[Bindable(true)]
		public string Upbas14 
		{
			get { return GetColumnValue<string>(Columns.Upbas14); }
			set { SetColumnValue(Columns.Upbas14, value); }
		}
		  
		[XmlAttribute("Upbas15")]
		[Bindable(true)]
		public string Upbas15 
		{
			get { return GetColumnValue<string>(Columns.Upbas15); }
			set { SetColumnValue(Columns.Upbas15, value); }
		}
		  
		[XmlAttribute("Upbas16")]
		[Bindable(true)]
		public string Upbas16 
		{
			get { return GetColumnValue<string>(Columns.Upbas16); }
			set { SetColumnValue(Columns.Upbas16, value); }
		}
		  
		[XmlAttribute("Upbas17")]
		[Bindable(true)]
		public string Upbas17 
		{
			get { return GetColumnValue<string>(Columns.Upbas17); }
			set { SetColumnValue(Columns.Upbas17, value); }
		}
		  
		[XmlAttribute("Secbas1")]
		[Bindable(true)]
		public string Secbas1 
		{
			get { return GetColumnValue<string>(Columns.Secbas1); }
			set { SetColumnValue(Columns.Secbas1, value); }
		}
		  
		[XmlAttribute("Secbas2")]
		[Bindable(true)]
		public string Secbas2 
		{
			get { return GetColumnValue<string>(Columns.Secbas2); }
			set { SetColumnValue(Columns.Secbas2, value); }
		}
		  
		[XmlAttribute("Secbas3")]
		[Bindable(true)]
		public string Secbas3 
		{
			get { return GetColumnValue<string>(Columns.Secbas3); }
			set { SetColumnValue(Columns.Secbas3, value); }
		}
		  
		[XmlAttribute("Secbas4")]
		[Bindable(true)]
		public string Secbas4 
		{
			get { return GetColumnValue<string>(Columns.Secbas4); }
			set { SetColumnValue(Columns.Secbas4, value); }
		}
		  
		[XmlAttribute("Secbas5")]
		[Bindable(true)]
		public string Secbas5 
		{
			get { return GetColumnValue<string>(Columns.Secbas5); }
			set { SetColumnValue(Columns.Secbas5, value); }
		}
		  
		[XmlAttribute("Secbas6")]
		[Bindable(true)]
		public string Secbas6 
		{
			get { return GetColumnValue<string>(Columns.Secbas6); }
			set { SetColumnValue(Columns.Secbas6, value); }
		}
		  
		[XmlAttribute("Secbas7")]
		[Bindable(true)]
		public string Secbas7 
		{
			get { return GetColumnValue<string>(Columns.Secbas7); }
			set { SetColumnValue(Columns.Secbas7, value); }
		}
		  
		[XmlAttribute("Secbas8")]
		[Bindable(true)]
		public string Secbas8 
		{
			get { return GetColumnValue<string>(Columns.Secbas8); }
			set { SetColumnValue(Columns.Secbas8, value); }
		}
		  
		[XmlAttribute("Secbas9")]
		[Bindable(true)]
		public string Secbas9 
		{
			get { return GetColumnValue<string>(Columns.Secbas9); }
			set { SetColumnValue(Columns.Secbas9, value); }
		}
		  
		[XmlAttribute("Secbas10")]
		[Bindable(true)]
		public string Secbas10 
		{
			get { return GetColumnValue<string>(Columns.Secbas10); }
			set { SetColumnValue(Columns.Secbas10, value); }
		}
		  
		[XmlAttribute("Secbas11")]
		[Bindable(true)]
		public string Secbas11 
		{
			get { return GetColumnValue<string>(Columns.Secbas11); }
			set { SetColumnValue(Columns.Secbas11, value); }
		}
		  
		[XmlAttribute("Secbas12")]
		[Bindable(true)]
		public string Secbas12 
		{
			get { return GetColumnValue<string>(Columns.Secbas12); }
			set { SetColumnValue(Columns.Secbas12, value); }
		}
		  
		[XmlAttribute("Secbas13")]
		[Bindable(true)]
		public string Secbas13 
		{
			get { return GetColumnValue<string>(Columns.Secbas13); }
			set { SetColumnValue(Columns.Secbas13, value); }
		}
		  
		[XmlAttribute("Secbas14")]
		[Bindable(true)]
		public string Secbas14 
		{
			get { return GetColumnValue<string>(Columns.Secbas14); }
			set { SetColumnValue(Columns.Secbas14, value); }
		}
		  
		[XmlAttribute("Secbas15")]
		[Bindable(true)]
		public string Secbas15 
		{
			get { return GetColumnValue<string>(Columns.Secbas15); }
			set { SetColumnValue(Columns.Secbas15, value); }
		}
		  
		[XmlAttribute("Secbas16")]
		[Bindable(true)]
		public string Secbas16 
		{
			get { return GetColumnValue<string>(Columns.Secbas16); }
			set { SetColumnValue(Columns.Secbas16, value); }
		}
		  
		[XmlAttribute("Secbas17")]
		[Bindable(true)]
		public string Secbas17 
		{
			get { return GetColumnValue<string>(Columns.Secbas17); }
			set { SetColumnValue(Columns.Secbas17, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varDateSpan,int? varEvaluateLevelId,string varTotalScore,string varUpViews,int? varYearId,int? varMonthId,int? varEmployeeId,int? varIsSubmit,string varSelfbas1,string varSelfbas2,string varSelfbas3,string varSelfbas4,string varSelfbas5,string varSelfbas6,string varSelfbas7,string varSelfbas8,string varSelfbas9,string varSelfbas10,string varSelfbas11,string varSelfbas12,string varSelfbas13,string varSelfbas14,string varSelfbas15,string varSelfbas16,string varSelfbas17,string varUpbas1,string varUpbas2,string varUpbas3,string varUpbas4,string varUpbas5,string varUpbas6,string varUpbas7,string varUpbas8,string varUpbas9,string varUpbas10,string varUpbas11,string varUpbas12,string varUpbas13,string varUpbas14,string varUpbas15,string varUpbas16,string varUpbas17,string varSecbas1,string varSecbas2,string varSecbas3,string varSecbas4,string varSecbas5,string varSecbas6,string varSecbas7,string varSecbas8,string varSecbas9,string varSecbas10,string varSecbas11,string varSecbas12,string varSecbas13,string varSecbas14,string varSecbas15,string varSecbas16,string varSecbas17)
		{
			BasEmScore item = new BasEmScore();
			
			item.DateSpan = varDateSpan;
			
			item.EvaluateLevelId = varEvaluateLevelId;
			
			item.TotalScore = varTotalScore;
			
			item.UpViews = varUpViews;
			
			item.YearId = varYearId;
			
			item.MonthId = varMonthId;
			
			item.EmployeeId = varEmployeeId;
			
			item.IsSubmit = varIsSubmit;
			
			item.Selfbas1 = varSelfbas1;
			
			item.Selfbas2 = varSelfbas2;
			
			item.Selfbas3 = varSelfbas3;
			
			item.Selfbas4 = varSelfbas4;
			
			item.Selfbas5 = varSelfbas5;
			
			item.Selfbas6 = varSelfbas6;
			
			item.Selfbas7 = varSelfbas7;
			
			item.Selfbas8 = varSelfbas8;
			
			item.Selfbas9 = varSelfbas9;
			
			item.Selfbas10 = varSelfbas10;
			
			item.Selfbas11 = varSelfbas11;
			
			item.Selfbas12 = varSelfbas12;
			
			item.Selfbas13 = varSelfbas13;
			
			item.Selfbas14 = varSelfbas14;
			
			item.Selfbas15 = varSelfbas15;
			
			item.Selfbas16 = varSelfbas16;
			
			item.Selfbas17 = varSelfbas17;
			
			item.Upbas1 = varUpbas1;
			
			item.Upbas2 = varUpbas2;
			
			item.Upbas3 = varUpbas3;
			
			item.Upbas4 = varUpbas4;
			
			item.Upbas5 = varUpbas5;
			
			item.Upbas6 = varUpbas6;
			
			item.Upbas7 = varUpbas7;
			
			item.Upbas8 = varUpbas8;
			
			item.Upbas9 = varUpbas9;
			
			item.Upbas10 = varUpbas10;
			
			item.Upbas11 = varUpbas11;
			
			item.Upbas12 = varUpbas12;
			
			item.Upbas13 = varUpbas13;
			
			item.Upbas14 = varUpbas14;
			
			item.Upbas15 = varUpbas15;
			
			item.Upbas16 = varUpbas16;
			
			item.Upbas17 = varUpbas17;
			
			item.Secbas1 = varSecbas1;
			
			item.Secbas2 = varSecbas2;
			
			item.Secbas3 = varSecbas3;
			
			item.Secbas4 = varSecbas4;
			
			item.Secbas5 = varSecbas5;
			
			item.Secbas6 = varSecbas6;
			
			item.Secbas7 = varSecbas7;
			
			item.Secbas8 = varSecbas8;
			
			item.Secbas9 = varSecbas9;
			
			item.Secbas10 = varSecbas10;
			
			item.Secbas11 = varSecbas11;
			
			item.Secbas12 = varSecbas12;
			
			item.Secbas13 = varSecbas13;
			
			item.Secbas14 = varSecbas14;
			
			item.Secbas15 = varSecbas15;
			
			item.Secbas16 = varSecbas16;
			
			item.Secbas17 = varSecbas17;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varBasEmScoreId,string varDateSpan,int? varEvaluateLevelId,string varTotalScore,string varUpViews,int? varYearId,int? varMonthId,int? varEmployeeId,int? varIsSubmit,string varSelfbas1,string varSelfbas2,string varSelfbas3,string varSelfbas4,string varSelfbas5,string varSelfbas6,string varSelfbas7,string varSelfbas8,string varSelfbas9,string varSelfbas10,string varSelfbas11,string varSelfbas12,string varSelfbas13,string varSelfbas14,string varSelfbas15,string varSelfbas16,string varSelfbas17,string varUpbas1,string varUpbas2,string varUpbas3,string varUpbas4,string varUpbas5,string varUpbas6,string varUpbas7,string varUpbas8,string varUpbas9,string varUpbas10,string varUpbas11,string varUpbas12,string varUpbas13,string varUpbas14,string varUpbas15,string varUpbas16,string varUpbas17,string varSecbas1,string varSecbas2,string varSecbas3,string varSecbas4,string varSecbas5,string varSecbas6,string varSecbas7,string varSecbas8,string varSecbas9,string varSecbas10,string varSecbas11,string varSecbas12,string varSecbas13,string varSecbas14,string varSecbas15,string varSecbas16,string varSecbas17)
		{
			BasEmScore item = new BasEmScore();
			
				item.BasEmScoreId = varBasEmScoreId;
			
				item.DateSpan = varDateSpan;
			
				item.EvaluateLevelId = varEvaluateLevelId;
			
				item.TotalScore = varTotalScore;
			
				item.UpViews = varUpViews;
			
				item.YearId = varYearId;
			
				item.MonthId = varMonthId;
			
				item.EmployeeId = varEmployeeId;
			
				item.IsSubmit = varIsSubmit;
			
				item.Selfbas1 = varSelfbas1;
			
				item.Selfbas2 = varSelfbas2;
			
				item.Selfbas3 = varSelfbas3;
			
				item.Selfbas4 = varSelfbas4;
			
				item.Selfbas5 = varSelfbas5;
			
				item.Selfbas6 = varSelfbas6;
			
				item.Selfbas7 = varSelfbas7;
			
				item.Selfbas8 = varSelfbas8;
			
				item.Selfbas9 = varSelfbas9;
			
				item.Selfbas10 = varSelfbas10;
			
				item.Selfbas11 = varSelfbas11;
			
				item.Selfbas12 = varSelfbas12;
			
				item.Selfbas13 = varSelfbas13;
			
				item.Selfbas14 = varSelfbas14;
			
				item.Selfbas15 = varSelfbas15;
			
				item.Selfbas16 = varSelfbas16;
			
				item.Selfbas17 = varSelfbas17;
			
				item.Upbas1 = varUpbas1;
			
				item.Upbas2 = varUpbas2;
			
				item.Upbas3 = varUpbas3;
			
				item.Upbas4 = varUpbas4;
			
				item.Upbas5 = varUpbas5;
			
				item.Upbas6 = varUpbas6;
			
				item.Upbas7 = varUpbas7;
			
				item.Upbas8 = varUpbas8;
			
				item.Upbas9 = varUpbas9;
			
				item.Upbas10 = varUpbas10;
			
				item.Upbas11 = varUpbas11;
			
				item.Upbas12 = varUpbas12;
			
				item.Upbas13 = varUpbas13;
			
				item.Upbas14 = varUpbas14;
			
				item.Upbas15 = varUpbas15;
			
				item.Upbas16 = varUpbas16;
			
				item.Upbas17 = varUpbas17;
			
				item.Secbas1 = varSecbas1;
			
				item.Secbas2 = varSecbas2;
			
				item.Secbas3 = varSecbas3;
			
				item.Secbas4 = varSecbas4;
			
				item.Secbas5 = varSecbas5;
			
				item.Secbas6 = varSecbas6;
			
				item.Secbas7 = varSecbas7;
			
				item.Secbas8 = varSecbas8;
			
				item.Secbas9 = varSecbas9;
			
				item.Secbas10 = varSecbas10;
			
				item.Secbas11 = varSecbas11;
			
				item.Secbas12 = varSecbas12;
			
				item.Secbas13 = varSecbas13;
			
				item.Secbas14 = varSecbas14;
			
				item.Secbas15 = varSecbas15;
			
				item.Secbas16 = varSecbas16;
			
				item.Secbas17 = varSecbas17;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn BasEmScoreIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn DateSpanColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn EvaluateLevelIdColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn TotalScoreColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn UpViewsColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn YearIdColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn MonthIdColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn EmployeeIdColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn IsSubmitColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfbas1Column
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfbas2Column
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfbas3Column
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfbas4Column
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfbas5Column
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfbas6Column
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfbas7Column
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfbas8Column
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfbas9Column
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfbas10Column
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfbas11Column
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfbas12Column
        {
            get { return Schema.Columns[20]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfbas13Column
        {
            get { return Schema.Columns[21]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfbas14Column
        {
            get { return Schema.Columns[22]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfbas15Column
        {
            get { return Schema.Columns[23]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfbas16Column
        {
            get { return Schema.Columns[24]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfbas17Column
        {
            get { return Schema.Columns[25]; }
        }
        
        
        
        public static TableSchema.TableColumn Upbas1Column
        {
            get { return Schema.Columns[26]; }
        }
        
        
        
        public static TableSchema.TableColumn Upbas2Column
        {
            get { return Schema.Columns[27]; }
        }
        
        
        
        public static TableSchema.TableColumn Upbas3Column
        {
            get { return Schema.Columns[28]; }
        }
        
        
        
        public static TableSchema.TableColumn Upbas4Column
        {
            get { return Schema.Columns[29]; }
        }
        
        
        
        public static TableSchema.TableColumn Upbas5Column
        {
            get { return Schema.Columns[30]; }
        }
        
        
        
        public static TableSchema.TableColumn Upbas6Column
        {
            get { return Schema.Columns[31]; }
        }
        
        
        
        public static TableSchema.TableColumn Upbas7Column
        {
            get { return Schema.Columns[32]; }
        }
        
        
        
        public static TableSchema.TableColumn Upbas8Column
        {
            get { return Schema.Columns[33]; }
        }
        
        
        
        public static TableSchema.TableColumn Upbas9Column
        {
            get { return Schema.Columns[34]; }
        }
        
        
        
        public static TableSchema.TableColumn Upbas10Column
        {
            get { return Schema.Columns[35]; }
        }
        
        
        
        public static TableSchema.TableColumn Upbas11Column
        {
            get { return Schema.Columns[36]; }
        }
        
        
        
        public static TableSchema.TableColumn Upbas12Column
        {
            get { return Schema.Columns[37]; }
        }
        
        
        
        public static TableSchema.TableColumn Upbas13Column
        {
            get { return Schema.Columns[38]; }
        }
        
        
        
        public static TableSchema.TableColumn Upbas14Column
        {
            get { return Schema.Columns[39]; }
        }
        
        
        
        public static TableSchema.TableColumn Upbas15Column
        {
            get { return Schema.Columns[40]; }
        }
        
        
        
        public static TableSchema.TableColumn Upbas16Column
        {
            get { return Schema.Columns[41]; }
        }
        
        
        
        public static TableSchema.TableColumn Upbas17Column
        {
            get { return Schema.Columns[42]; }
        }
        
        
        
        public static TableSchema.TableColumn Secbas1Column
        {
            get { return Schema.Columns[43]; }
        }
        
        
        
        public static TableSchema.TableColumn Secbas2Column
        {
            get { return Schema.Columns[44]; }
        }
        
        
        
        public static TableSchema.TableColumn Secbas3Column
        {
            get { return Schema.Columns[45]; }
        }
        
        
        
        public static TableSchema.TableColumn Secbas4Column
        {
            get { return Schema.Columns[46]; }
        }
        
        
        
        public static TableSchema.TableColumn Secbas5Column
        {
            get { return Schema.Columns[47]; }
        }
        
        
        
        public static TableSchema.TableColumn Secbas6Column
        {
            get { return Schema.Columns[48]; }
        }
        
        
        
        public static TableSchema.TableColumn Secbas7Column
        {
            get { return Schema.Columns[49]; }
        }
        
        
        
        public static TableSchema.TableColumn Secbas8Column
        {
            get { return Schema.Columns[50]; }
        }
        
        
        
        public static TableSchema.TableColumn Secbas9Column
        {
            get { return Schema.Columns[51]; }
        }
        
        
        
        public static TableSchema.TableColumn Secbas10Column
        {
            get { return Schema.Columns[52]; }
        }
        
        
        
        public static TableSchema.TableColumn Secbas11Column
        {
            get { return Schema.Columns[53]; }
        }
        
        
        
        public static TableSchema.TableColumn Secbas12Column
        {
            get { return Schema.Columns[54]; }
        }
        
        
        
        public static TableSchema.TableColumn Secbas13Column
        {
            get { return Schema.Columns[55]; }
        }
        
        
        
        public static TableSchema.TableColumn Secbas14Column
        {
            get { return Schema.Columns[56]; }
        }
        
        
        
        public static TableSchema.TableColumn Secbas15Column
        {
            get { return Schema.Columns[57]; }
        }
        
        
        
        public static TableSchema.TableColumn Secbas16Column
        {
            get { return Schema.Columns[58]; }
        }
        
        
        
        public static TableSchema.TableColumn Secbas17Column
        {
            get { return Schema.Columns[59]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string BasEmScoreId = @"BasEmScoreId";
			 public static string DateSpan = @"DateSpan";
			 public static string EvaluateLevelId = @"EvaluateLevelId";
			 public static string TotalScore = @"TotalScore";
			 public static string UpViews = @"UpViews";
			 public static string YearId = @"YearId";
			 public static string MonthId = @"MonthId";
			 public static string EmployeeId = @"EmployeeId";
			 public static string IsSubmit = @"IsSubmit";
			 public static string Selfbas1 = @"Selfbas1";
			 public static string Selfbas2 = @"Selfbas2";
			 public static string Selfbas3 = @"Selfbas3";
			 public static string Selfbas4 = @"Selfbas4";
			 public static string Selfbas5 = @"Selfbas5";
			 public static string Selfbas6 = @"Selfbas6";
			 public static string Selfbas7 = @"Selfbas7";
			 public static string Selfbas8 = @"Selfbas8";
			 public static string Selfbas9 = @"Selfbas9";
			 public static string Selfbas10 = @"Selfbas10";
			 public static string Selfbas11 = @"Selfbas11";
			 public static string Selfbas12 = @"Selfbas12";
			 public static string Selfbas13 = @"Selfbas13";
			 public static string Selfbas14 = @"Selfbas14";
			 public static string Selfbas15 = @"Selfbas15";
			 public static string Selfbas16 = @"Selfbas16";
			 public static string Selfbas17 = @"Selfbas17";
			 public static string Upbas1 = @"Upbas1";
			 public static string Upbas2 = @"Upbas2";
			 public static string Upbas3 = @"Upbas3";
			 public static string Upbas4 = @"Upbas4";
			 public static string Upbas5 = @"Upbas5";
			 public static string Upbas6 = @"Upbas6";
			 public static string Upbas7 = @"Upbas7";
			 public static string Upbas8 = @"Upbas8";
			 public static string Upbas9 = @"Upbas9";
			 public static string Upbas10 = @"Upbas10";
			 public static string Upbas11 = @"Upbas11";
			 public static string Upbas12 = @"Upbas12";
			 public static string Upbas13 = @"Upbas13";
			 public static string Upbas14 = @"Upbas14";
			 public static string Upbas15 = @"Upbas15";
			 public static string Upbas16 = @"Upbas16";
			 public static string Upbas17 = @"Upbas17";
			 public static string Secbas1 = @"Secbas1";
			 public static string Secbas2 = @"Secbas2";
			 public static string Secbas3 = @"Secbas3";
			 public static string Secbas4 = @"Secbas4";
			 public static string Secbas5 = @"Secbas5";
			 public static string Secbas6 = @"Secbas6";
			 public static string Secbas7 = @"Secbas7";
			 public static string Secbas8 = @"Secbas8";
			 public static string Secbas9 = @"Secbas9";
			 public static string Secbas10 = @"Secbas10";
			 public static string Secbas11 = @"Secbas11";
			 public static string Secbas12 = @"Secbas12";
			 public static string Secbas13 = @"Secbas13";
			 public static string Secbas14 = @"Secbas14";
			 public static string Secbas15 = @"Secbas15";
			 public static string Secbas16 = @"Secbas16";
			 public static string Secbas17 = @"Secbas17";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
