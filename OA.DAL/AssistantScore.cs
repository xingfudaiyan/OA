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
	/// Strongly-typed collection for the AssistantScore class.
	/// </summary>
    [Serializable]
	public partial class AssistantScoreCollection : ActiveList<AssistantScore, AssistantScoreCollection>
	{	   
		public AssistantScoreCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>AssistantScoreCollection</returns>
		public AssistantScoreCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                AssistantScore o = this[i];
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
	/// This is an ActiveRecord class which wraps the AssistantScore_tb table.
	/// </summary>
	[Serializable]
	public partial class AssistantScore : ActiveRecord<AssistantScore>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public AssistantScore()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public AssistantScore(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public AssistantScore(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public AssistantScore(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("AssistantScore_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarAssistantScoreId = new TableSchema.TableColumn(schema);
				colvarAssistantScoreId.ColumnName = "AssistantScoreId";
				colvarAssistantScoreId.DataType = DbType.Int32;
				colvarAssistantScoreId.MaxLength = 0;
				colvarAssistantScoreId.AutoIncrement = true;
				colvarAssistantScoreId.IsNullable = false;
				colvarAssistantScoreId.IsPrimaryKey = true;
				colvarAssistantScoreId.IsForeignKey = false;
				colvarAssistantScoreId.IsReadOnly = false;
				colvarAssistantScoreId.DefaultSetting = @"";
				colvarAssistantScoreId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAssistantScoreId);
				
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
				
				TableSchema.TableColumn colvarSelfas1 = new TableSchema.TableColumn(schema);
				colvarSelfas1.ColumnName = "Selfas1";
				colvarSelfas1.DataType = DbType.String;
				colvarSelfas1.MaxLength = 10;
				colvarSelfas1.AutoIncrement = false;
				colvarSelfas1.IsNullable = true;
				colvarSelfas1.IsPrimaryKey = false;
				colvarSelfas1.IsForeignKey = false;
				colvarSelfas1.IsReadOnly = false;
				colvarSelfas1.DefaultSetting = @"";
				colvarSelfas1.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfas1);
				
				TableSchema.TableColumn colvarSelfas2 = new TableSchema.TableColumn(schema);
				colvarSelfas2.ColumnName = "Selfas2";
				colvarSelfas2.DataType = DbType.String;
				colvarSelfas2.MaxLength = 10;
				colvarSelfas2.AutoIncrement = false;
				colvarSelfas2.IsNullable = true;
				colvarSelfas2.IsPrimaryKey = false;
				colvarSelfas2.IsForeignKey = false;
				colvarSelfas2.IsReadOnly = false;
				colvarSelfas2.DefaultSetting = @"";
				colvarSelfas2.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfas2);
				
				TableSchema.TableColumn colvarSelfas3 = new TableSchema.TableColumn(schema);
				colvarSelfas3.ColumnName = "Selfas3";
				colvarSelfas3.DataType = DbType.String;
				colvarSelfas3.MaxLength = 10;
				colvarSelfas3.AutoIncrement = false;
				colvarSelfas3.IsNullable = true;
				colvarSelfas3.IsPrimaryKey = false;
				colvarSelfas3.IsForeignKey = false;
				colvarSelfas3.IsReadOnly = false;
				colvarSelfas3.DefaultSetting = @"";
				colvarSelfas3.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfas3);
				
				TableSchema.TableColumn colvarSelfas4 = new TableSchema.TableColumn(schema);
				colvarSelfas4.ColumnName = "Selfas4";
				colvarSelfas4.DataType = DbType.String;
				colvarSelfas4.MaxLength = 10;
				colvarSelfas4.AutoIncrement = false;
				colvarSelfas4.IsNullable = true;
				colvarSelfas4.IsPrimaryKey = false;
				colvarSelfas4.IsForeignKey = false;
				colvarSelfas4.IsReadOnly = false;
				colvarSelfas4.DefaultSetting = @"";
				colvarSelfas4.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfas4);
				
				TableSchema.TableColumn colvarSelfas5 = new TableSchema.TableColumn(schema);
				colvarSelfas5.ColumnName = "Selfas5";
				colvarSelfas5.DataType = DbType.String;
				colvarSelfas5.MaxLength = 10;
				colvarSelfas5.AutoIncrement = false;
				colvarSelfas5.IsNullable = true;
				colvarSelfas5.IsPrimaryKey = false;
				colvarSelfas5.IsForeignKey = false;
				colvarSelfas5.IsReadOnly = false;
				colvarSelfas5.DefaultSetting = @"";
				colvarSelfas5.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfas5);
				
				TableSchema.TableColumn colvarSelfas6 = new TableSchema.TableColumn(schema);
				colvarSelfas6.ColumnName = "Selfas6";
				colvarSelfas6.DataType = DbType.String;
				colvarSelfas6.MaxLength = 10;
				colvarSelfas6.AutoIncrement = false;
				colvarSelfas6.IsNullable = true;
				colvarSelfas6.IsPrimaryKey = false;
				colvarSelfas6.IsForeignKey = false;
				colvarSelfas6.IsReadOnly = false;
				colvarSelfas6.DefaultSetting = @"";
				colvarSelfas6.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfas6);
				
				TableSchema.TableColumn colvarSelfas7 = new TableSchema.TableColumn(schema);
				colvarSelfas7.ColumnName = "Selfas7";
				colvarSelfas7.DataType = DbType.String;
				colvarSelfas7.MaxLength = 10;
				colvarSelfas7.AutoIncrement = false;
				colvarSelfas7.IsNullable = true;
				colvarSelfas7.IsPrimaryKey = false;
				colvarSelfas7.IsForeignKey = false;
				colvarSelfas7.IsReadOnly = false;
				colvarSelfas7.DefaultSetting = @"";
				colvarSelfas7.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfas7);
				
				TableSchema.TableColumn colvarSelfas8 = new TableSchema.TableColumn(schema);
				colvarSelfas8.ColumnName = "Selfas8";
				colvarSelfas8.DataType = DbType.String;
				colvarSelfas8.MaxLength = 10;
				colvarSelfas8.AutoIncrement = false;
				colvarSelfas8.IsNullable = true;
				colvarSelfas8.IsPrimaryKey = false;
				colvarSelfas8.IsForeignKey = false;
				colvarSelfas8.IsReadOnly = false;
				colvarSelfas8.DefaultSetting = @"";
				colvarSelfas8.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfas8);
				
				TableSchema.TableColumn colvarSelfas9 = new TableSchema.TableColumn(schema);
				colvarSelfas9.ColumnName = "Selfas9";
				colvarSelfas9.DataType = DbType.String;
				colvarSelfas9.MaxLength = 10;
				colvarSelfas9.AutoIncrement = false;
				colvarSelfas9.IsNullable = true;
				colvarSelfas9.IsPrimaryKey = false;
				colvarSelfas9.IsForeignKey = false;
				colvarSelfas9.IsReadOnly = false;
				colvarSelfas9.DefaultSetting = @"";
				colvarSelfas9.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfas9);
				
				TableSchema.TableColumn colvarSelfas10 = new TableSchema.TableColumn(schema);
				colvarSelfas10.ColumnName = "Selfas10";
				colvarSelfas10.DataType = DbType.String;
				colvarSelfas10.MaxLength = 10;
				colvarSelfas10.AutoIncrement = false;
				colvarSelfas10.IsNullable = true;
				colvarSelfas10.IsPrimaryKey = false;
				colvarSelfas10.IsForeignKey = false;
				colvarSelfas10.IsReadOnly = false;
				colvarSelfas10.DefaultSetting = @"";
				colvarSelfas10.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfas10);
				
				TableSchema.TableColumn colvarSelfas11 = new TableSchema.TableColumn(schema);
				colvarSelfas11.ColumnName = "Selfas11";
				colvarSelfas11.DataType = DbType.String;
				colvarSelfas11.MaxLength = 10;
				colvarSelfas11.AutoIncrement = false;
				colvarSelfas11.IsNullable = true;
				colvarSelfas11.IsPrimaryKey = false;
				colvarSelfas11.IsForeignKey = false;
				colvarSelfas11.IsReadOnly = false;
				colvarSelfas11.DefaultSetting = @"";
				colvarSelfas11.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfas11);
				
				TableSchema.TableColumn colvarSelfas12 = new TableSchema.TableColumn(schema);
				colvarSelfas12.ColumnName = "Selfas12";
				colvarSelfas12.DataType = DbType.String;
				colvarSelfas12.MaxLength = 10;
				colvarSelfas12.AutoIncrement = false;
				colvarSelfas12.IsNullable = true;
				colvarSelfas12.IsPrimaryKey = false;
				colvarSelfas12.IsForeignKey = false;
				colvarSelfas12.IsReadOnly = false;
				colvarSelfas12.DefaultSetting = @"";
				colvarSelfas12.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfas12);
				
				TableSchema.TableColumn colvarSelfas13 = new TableSchema.TableColumn(schema);
				colvarSelfas13.ColumnName = "Selfas13";
				colvarSelfas13.DataType = DbType.String;
				colvarSelfas13.MaxLength = 10;
				colvarSelfas13.AutoIncrement = false;
				colvarSelfas13.IsNullable = true;
				colvarSelfas13.IsPrimaryKey = false;
				colvarSelfas13.IsForeignKey = false;
				colvarSelfas13.IsReadOnly = false;
				colvarSelfas13.DefaultSetting = @"";
				colvarSelfas13.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfas13);
				
				TableSchema.TableColumn colvarSelfas14 = new TableSchema.TableColumn(schema);
				colvarSelfas14.ColumnName = "Selfas14";
				colvarSelfas14.DataType = DbType.String;
				colvarSelfas14.MaxLength = 10;
				colvarSelfas14.AutoIncrement = false;
				colvarSelfas14.IsNullable = true;
				colvarSelfas14.IsPrimaryKey = false;
				colvarSelfas14.IsForeignKey = false;
				colvarSelfas14.IsReadOnly = false;
				colvarSelfas14.DefaultSetting = @"";
				colvarSelfas14.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfas14);
				
				TableSchema.TableColumn colvarSelfas15 = new TableSchema.TableColumn(schema);
				colvarSelfas15.ColumnName = "Selfas15";
				colvarSelfas15.DataType = DbType.String;
				colvarSelfas15.MaxLength = 10;
				colvarSelfas15.AutoIncrement = false;
				colvarSelfas15.IsNullable = true;
				colvarSelfas15.IsPrimaryKey = false;
				colvarSelfas15.IsForeignKey = false;
				colvarSelfas15.IsReadOnly = false;
				colvarSelfas15.DefaultSetting = @"";
				colvarSelfas15.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfas15);
				
				TableSchema.TableColumn colvarSelfas16 = new TableSchema.TableColumn(schema);
				colvarSelfas16.ColumnName = "Selfas16";
				colvarSelfas16.DataType = DbType.String;
				colvarSelfas16.MaxLength = 10;
				colvarSelfas16.AutoIncrement = false;
				colvarSelfas16.IsNullable = true;
				colvarSelfas16.IsPrimaryKey = false;
				colvarSelfas16.IsForeignKey = false;
				colvarSelfas16.IsReadOnly = false;
				colvarSelfas16.DefaultSetting = @"";
				colvarSelfas16.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfas16);
				
				TableSchema.TableColumn colvarSelfas17 = new TableSchema.TableColumn(schema);
				colvarSelfas17.ColumnName = "Selfas17";
				colvarSelfas17.DataType = DbType.String;
				colvarSelfas17.MaxLength = 10;
				colvarSelfas17.AutoIncrement = false;
				colvarSelfas17.IsNullable = true;
				colvarSelfas17.IsPrimaryKey = false;
				colvarSelfas17.IsForeignKey = false;
				colvarSelfas17.IsReadOnly = false;
				colvarSelfas17.DefaultSetting = @"";
				colvarSelfas17.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfas17);
				
				TableSchema.TableColumn colvarSelfas18 = new TableSchema.TableColumn(schema);
				colvarSelfas18.ColumnName = "Selfas18";
				colvarSelfas18.DataType = DbType.String;
				colvarSelfas18.MaxLength = 10;
				colvarSelfas18.AutoIncrement = false;
				colvarSelfas18.IsNullable = true;
				colvarSelfas18.IsPrimaryKey = false;
				colvarSelfas18.IsForeignKey = false;
				colvarSelfas18.IsReadOnly = false;
				colvarSelfas18.DefaultSetting = @"";
				colvarSelfas18.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfas18);
				
				TableSchema.TableColumn colvarSelfas19 = new TableSchema.TableColumn(schema);
				colvarSelfas19.ColumnName = "Selfas19";
				colvarSelfas19.DataType = DbType.String;
				colvarSelfas19.MaxLength = 10;
				colvarSelfas19.AutoIncrement = false;
				colvarSelfas19.IsNullable = true;
				colvarSelfas19.IsPrimaryKey = false;
				colvarSelfas19.IsForeignKey = false;
				colvarSelfas19.IsReadOnly = false;
				colvarSelfas19.DefaultSetting = @"";
				colvarSelfas19.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfas19);
				
				TableSchema.TableColumn colvarUpas1 = new TableSchema.TableColumn(schema);
				colvarUpas1.ColumnName = "Upas1";
				colvarUpas1.DataType = DbType.String;
				colvarUpas1.MaxLength = 10;
				colvarUpas1.AutoIncrement = false;
				colvarUpas1.IsNullable = true;
				colvarUpas1.IsPrimaryKey = false;
				colvarUpas1.IsForeignKey = false;
				colvarUpas1.IsReadOnly = false;
				colvarUpas1.DefaultSetting = @"";
				colvarUpas1.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpas1);
				
				TableSchema.TableColumn colvarUpas2 = new TableSchema.TableColumn(schema);
				colvarUpas2.ColumnName = "Upas2";
				colvarUpas2.DataType = DbType.String;
				colvarUpas2.MaxLength = 10;
				colvarUpas2.AutoIncrement = false;
				colvarUpas2.IsNullable = true;
				colvarUpas2.IsPrimaryKey = false;
				colvarUpas2.IsForeignKey = false;
				colvarUpas2.IsReadOnly = false;
				colvarUpas2.DefaultSetting = @"";
				colvarUpas2.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpas2);
				
				TableSchema.TableColumn colvarUpas3 = new TableSchema.TableColumn(schema);
				colvarUpas3.ColumnName = "Upas3";
				colvarUpas3.DataType = DbType.String;
				colvarUpas3.MaxLength = 10;
				colvarUpas3.AutoIncrement = false;
				colvarUpas3.IsNullable = true;
				colvarUpas3.IsPrimaryKey = false;
				colvarUpas3.IsForeignKey = false;
				colvarUpas3.IsReadOnly = false;
				colvarUpas3.DefaultSetting = @"";
				colvarUpas3.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpas3);
				
				TableSchema.TableColumn colvarUpas4 = new TableSchema.TableColumn(schema);
				colvarUpas4.ColumnName = "Upas4";
				colvarUpas4.DataType = DbType.String;
				colvarUpas4.MaxLength = 10;
				colvarUpas4.AutoIncrement = false;
				colvarUpas4.IsNullable = true;
				colvarUpas4.IsPrimaryKey = false;
				colvarUpas4.IsForeignKey = false;
				colvarUpas4.IsReadOnly = false;
				colvarUpas4.DefaultSetting = @"";
				colvarUpas4.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpas4);
				
				TableSchema.TableColumn colvarUpas5 = new TableSchema.TableColumn(schema);
				colvarUpas5.ColumnName = "Upas5";
				colvarUpas5.DataType = DbType.String;
				colvarUpas5.MaxLength = 10;
				colvarUpas5.AutoIncrement = false;
				colvarUpas5.IsNullable = true;
				colvarUpas5.IsPrimaryKey = false;
				colvarUpas5.IsForeignKey = false;
				colvarUpas5.IsReadOnly = false;
				colvarUpas5.DefaultSetting = @"";
				colvarUpas5.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpas5);
				
				TableSchema.TableColumn colvarUpas6 = new TableSchema.TableColumn(schema);
				colvarUpas6.ColumnName = "Upas6";
				colvarUpas6.DataType = DbType.String;
				colvarUpas6.MaxLength = 10;
				colvarUpas6.AutoIncrement = false;
				colvarUpas6.IsNullable = true;
				colvarUpas6.IsPrimaryKey = false;
				colvarUpas6.IsForeignKey = false;
				colvarUpas6.IsReadOnly = false;
				colvarUpas6.DefaultSetting = @"";
				colvarUpas6.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpas6);
				
				TableSchema.TableColumn colvarUpas7 = new TableSchema.TableColumn(schema);
				colvarUpas7.ColumnName = "Upas7";
				colvarUpas7.DataType = DbType.String;
				colvarUpas7.MaxLength = 10;
				colvarUpas7.AutoIncrement = false;
				colvarUpas7.IsNullable = true;
				colvarUpas7.IsPrimaryKey = false;
				colvarUpas7.IsForeignKey = false;
				colvarUpas7.IsReadOnly = false;
				colvarUpas7.DefaultSetting = @"";
				colvarUpas7.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpas7);
				
				TableSchema.TableColumn colvarUpas8 = new TableSchema.TableColumn(schema);
				colvarUpas8.ColumnName = "Upas8";
				colvarUpas8.DataType = DbType.String;
				colvarUpas8.MaxLength = 10;
				colvarUpas8.AutoIncrement = false;
				colvarUpas8.IsNullable = true;
				colvarUpas8.IsPrimaryKey = false;
				colvarUpas8.IsForeignKey = false;
				colvarUpas8.IsReadOnly = false;
				colvarUpas8.DefaultSetting = @"";
				colvarUpas8.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpas8);
				
				TableSchema.TableColumn colvarUpas9 = new TableSchema.TableColumn(schema);
				colvarUpas9.ColumnName = "Upas9";
				colvarUpas9.DataType = DbType.String;
				colvarUpas9.MaxLength = 10;
				colvarUpas9.AutoIncrement = false;
				colvarUpas9.IsNullable = true;
				colvarUpas9.IsPrimaryKey = false;
				colvarUpas9.IsForeignKey = false;
				colvarUpas9.IsReadOnly = false;
				colvarUpas9.DefaultSetting = @"";
				colvarUpas9.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpas9);
				
				TableSchema.TableColumn colvarUpas10 = new TableSchema.TableColumn(schema);
				colvarUpas10.ColumnName = "Upas10";
				colvarUpas10.DataType = DbType.String;
				colvarUpas10.MaxLength = 10;
				colvarUpas10.AutoIncrement = false;
				colvarUpas10.IsNullable = true;
				colvarUpas10.IsPrimaryKey = false;
				colvarUpas10.IsForeignKey = false;
				colvarUpas10.IsReadOnly = false;
				colvarUpas10.DefaultSetting = @"";
				colvarUpas10.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpas10);
				
				TableSchema.TableColumn colvarUpas11 = new TableSchema.TableColumn(schema);
				colvarUpas11.ColumnName = "Upas11";
				colvarUpas11.DataType = DbType.String;
				colvarUpas11.MaxLength = 10;
				colvarUpas11.AutoIncrement = false;
				colvarUpas11.IsNullable = true;
				colvarUpas11.IsPrimaryKey = false;
				colvarUpas11.IsForeignKey = false;
				colvarUpas11.IsReadOnly = false;
				colvarUpas11.DefaultSetting = @"";
				colvarUpas11.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpas11);
				
				TableSchema.TableColumn colvarUpas12 = new TableSchema.TableColumn(schema);
				colvarUpas12.ColumnName = "Upas12";
				colvarUpas12.DataType = DbType.String;
				colvarUpas12.MaxLength = 10;
				colvarUpas12.AutoIncrement = false;
				colvarUpas12.IsNullable = true;
				colvarUpas12.IsPrimaryKey = false;
				colvarUpas12.IsForeignKey = false;
				colvarUpas12.IsReadOnly = false;
				colvarUpas12.DefaultSetting = @"";
				colvarUpas12.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpas12);
				
				TableSchema.TableColumn colvarUpas13 = new TableSchema.TableColumn(schema);
				colvarUpas13.ColumnName = "Upas13";
				colvarUpas13.DataType = DbType.String;
				colvarUpas13.MaxLength = 10;
				colvarUpas13.AutoIncrement = false;
				colvarUpas13.IsNullable = true;
				colvarUpas13.IsPrimaryKey = false;
				colvarUpas13.IsForeignKey = false;
				colvarUpas13.IsReadOnly = false;
				colvarUpas13.DefaultSetting = @"";
				colvarUpas13.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpas13);
				
				TableSchema.TableColumn colvarUpas14 = new TableSchema.TableColumn(schema);
				colvarUpas14.ColumnName = "Upas14";
				colvarUpas14.DataType = DbType.String;
				colvarUpas14.MaxLength = 10;
				colvarUpas14.AutoIncrement = false;
				colvarUpas14.IsNullable = true;
				colvarUpas14.IsPrimaryKey = false;
				colvarUpas14.IsForeignKey = false;
				colvarUpas14.IsReadOnly = false;
				colvarUpas14.DefaultSetting = @"";
				colvarUpas14.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpas14);
				
				TableSchema.TableColumn colvarUpas15 = new TableSchema.TableColumn(schema);
				colvarUpas15.ColumnName = "Upas15";
				colvarUpas15.DataType = DbType.String;
				colvarUpas15.MaxLength = 10;
				colvarUpas15.AutoIncrement = false;
				colvarUpas15.IsNullable = true;
				colvarUpas15.IsPrimaryKey = false;
				colvarUpas15.IsForeignKey = false;
				colvarUpas15.IsReadOnly = false;
				colvarUpas15.DefaultSetting = @"";
				colvarUpas15.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpas15);
				
				TableSchema.TableColumn colvarUpas16 = new TableSchema.TableColumn(schema);
				colvarUpas16.ColumnName = "Upas16";
				colvarUpas16.DataType = DbType.String;
				colvarUpas16.MaxLength = 10;
				colvarUpas16.AutoIncrement = false;
				colvarUpas16.IsNullable = true;
				colvarUpas16.IsPrimaryKey = false;
				colvarUpas16.IsForeignKey = false;
				colvarUpas16.IsReadOnly = false;
				colvarUpas16.DefaultSetting = @"";
				colvarUpas16.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpas16);
				
				TableSchema.TableColumn colvarUpas17 = new TableSchema.TableColumn(schema);
				colvarUpas17.ColumnName = "Upas17";
				colvarUpas17.DataType = DbType.String;
				colvarUpas17.MaxLength = 10;
				colvarUpas17.AutoIncrement = false;
				colvarUpas17.IsNullable = true;
				colvarUpas17.IsPrimaryKey = false;
				colvarUpas17.IsForeignKey = false;
				colvarUpas17.IsReadOnly = false;
				colvarUpas17.DefaultSetting = @"";
				colvarUpas17.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpas17);
				
				TableSchema.TableColumn colvarUpas18 = new TableSchema.TableColumn(schema);
				colvarUpas18.ColumnName = "Upas18";
				colvarUpas18.DataType = DbType.String;
				colvarUpas18.MaxLength = 10;
				colvarUpas18.AutoIncrement = false;
				colvarUpas18.IsNullable = true;
				colvarUpas18.IsPrimaryKey = false;
				colvarUpas18.IsForeignKey = false;
				colvarUpas18.IsReadOnly = false;
				colvarUpas18.DefaultSetting = @"";
				colvarUpas18.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpas18);
				
				TableSchema.TableColumn colvarUpas19 = new TableSchema.TableColumn(schema);
				colvarUpas19.ColumnName = "Upas19";
				colvarUpas19.DataType = DbType.String;
				colvarUpas19.MaxLength = 10;
				colvarUpas19.AutoIncrement = false;
				colvarUpas19.IsNullable = true;
				colvarUpas19.IsPrimaryKey = false;
				colvarUpas19.IsForeignKey = false;
				colvarUpas19.IsReadOnly = false;
				colvarUpas19.DefaultSetting = @"";
				colvarUpas19.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpas19);
				
				TableSchema.TableColumn colvarSecas1 = new TableSchema.TableColumn(schema);
				colvarSecas1.ColumnName = "Secas1";
				colvarSecas1.DataType = DbType.String;
				colvarSecas1.MaxLength = 10;
				colvarSecas1.AutoIncrement = false;
				colvarSecas1.IsNullable = true;
				colvarSecas1.IsPrimaryKey = false;
				colvarSecas1.IsForeignKey = false;
				colvarSecas1.IsReadOnly = false;
				colvarSecas1.DefaultSetting = @"";
				colvarSecas1.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecas1);
				
				TableSchema.TableColumn colvarSecas2 = new TableSchema.TableColumn(schema);
				colvarSecas2.ColumnName = "Secas2";
				colvarSecas2.DataType = DbType.String;
				colvarSecas2.MaxLength = 10;
				colvarSecas2.AutoIncrement = false;
				colvarSecas2.IsNullable = true;
				colvarSecas2.IsPrimaryKey = false;
				colvarSecas2.IsForeignKey = false;
				colvarSecas2.IsReadOnly = false;
				colvarSecas2.DefaultSetting = @"";
				colvarSecas2.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecas2);
				
				TableSchema.TableColumn colvarSecas3 = new TableSchema.TableColumn(schema);
				colvarSecas3.ColumnName = "Secas3";
				colvarSecas3.DataType = DbType.String;
				colvarSecas3.MaxLength = 10;
				colvarSecas3.AutoIncrement = false;
				colvarSecas3.IsNullable = true;
				colvarSecas3.IsPrimaryKey = false;
				colvarSecas3.IsForeignKey = false;
				colvarSecas3.IsReadOnly = false;
				colvarSecas3.DefaultSetting = @"";
				colvarSecas3.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecas3);
				
				TableSchema.TableColumn colvarSecas4 = new TableSchema.TableColumn(schema);
				colvarSecas4.ColumnName = "Secas4";
				colvarSecas4.DataType = DbType.String;
				colvarSecas4.MaxLength = 10;
				colvarSecas4.AutoIncrement = false;
				colvarSecas4.IsNullable = true;
				colvarSecas4.IsPrimaryKey = false;
				colvarSecas4.IsForeignKey = false;
				colvarSecas4.IsReadOnly = false;
				colvarSecas4.DefaultSetting = @"";
				colvarSecas4.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecas4);
				
				TableSchema.TableColumn colvarSecas5 = new TableSchema.TableColumn(schema);
				colvarSecas5.ColumnName = "Secas5";
				colvarSecas5.DataType = DbType.String;
				colvarSecas5.MaxLength = 10;
				colvarSecas5.AutoIncrement = false;
				colvarSecas5.IsNullable = true;
				colvarSecas5.IsPrimaryKey = false;
				colvarSecas5.IsForeignKey = false;
				colvarSecas5.IsReadOnly = false;
				colvarSecas5.DefaultSetting = @"";
				colvarSecas5.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecas5);
				
				TableSchema.TableColumn colvarSecas6 = new TableSchema.TableColumn(schema);
				colvarSecas6.ColumnName = "Secas6";
				colvarSecas6.DataType = DbType.String;
				colvarSecas6.MaxLength = 10;
				colvarSecas6.AutoIncrement = false;
				colvarSecas6.IsNullable = true;
				colvarSecas6.IsPrimaryKey = false;
				colvarSecas6.IsForeignKey = false;
				colvarSecas6.IsReadOnly = false;
				colvarSecas6.DefaultSetting = @"";
				colvarSecas6.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecas6);
				
				TableSchema.TableColumn colvarSecas7 = new TableSchema.TableColumn(schema);
				colvarSecas7.ColumnName = "Secas7";
				colvarSecas7.DataType = DbType.String;
				colvarSecas7.MaxLength = 10;
				colvarSecas7.AutoIncrement = false;
				colvarSecas7.IsNullable = true;
				colvarSecas7.IsPrimaryKey = false;
				colvarSecas7.IsForeignKey = false;
				colvarSecas7.IsReadOnly = false;
				colvarSecas7.DefaultSetting = @"";
				colvarSecas7.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecas7);
				
				TableSchema.TableColumn colvarSecas8 = new TableSchema.TableColumn(schema);
				colvarSecas8.ColumnName = "Secas8";
				colvarSecas8.DataType = DbType.String;
				colvarSecas8.MaxLength = 10;
				colvarSecas8.AutoIncrement = false;
				colvarSecas8.IsNullable = true;
				colvarSecas8.IsPrimaryKey = false;
				colvarSecas8.IsForeignKey = false;
				colvarSecas8.IsReadOnly = false;
				colvarSecas8.DefaultSetting = @"";
				colvarSecas8.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecas8);
				
				TableSchema.TableColumn colvarSecas9 = new TableSchema.TableColumn(schema);
				colvarSecas9.ColumnName = "Secas9";
				colvarSecas9.DataType = DbType.String;
				colvarSecas9.MaxLength = 10;
				colvarSecas9.AutoIncrement = false;
				colvarSecas9.IsNullable = true;
				colvarSecas9.IsPrimaryKey = false;
				colvarSecas9.IsForeignKey = false;
				colvarSecas9.IsReadOnly = false;
				colvarSecas9.DefaultSetting = @"";
				colvarSecas9.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecas9);
				
				TableSchema.TableColumn colvarSecas10 = new TableSchema.TableColumn(schema);
				colvarSecas10.ColumnName = "Secas10";
				colvarSecas10.DataType = DbType.String;
				colvarSecas10.MaxLength = 10;
				colvarSecas10.AutoIncrement = false;
				colvarSecas10.IsNullable = true;
				colvarSecas10.IsPrimaryKey = false;
				colvarSecas10.IsForeignKey = false;
				colvarSecas10.IsReadOnly = false;
				colvarSecas10.DefaultSetting = @"";
				colvarSecas10.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecas10);
				
				TableSchema.TableColumn colvarSecas11 = new TableSchema.TableColumn(schema);
				colvarSecas11.ColumnName = "Secas11";
				colvarSecas11.DataType = DbType.String;
				colvarSecas11.MaxLength = 10;
				colvarSecas11.AutoIncrement = false;
				colvarSecas11.IsNullable = true;
				colvarSecas11.IsPrimaryKey = false;
				colvarSecas11.IsForeignKey = false;
				colvarSecas11.IsReadOnly = false;
				colvarSecas11.DefaultSetting = @"";
				colvarSecas11.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecas11);
				
				TableSchema.TableColumn colvarSecas12 = new TableSchema.TableColumn(schema);
				colvarSecas12.ColumnName = "Secas12";
				colvarSecas12.DataType = DbType.String;
				colvarSecas12.MaxLength = 10;
				colvarSecas12.AutoIncrement = false;
				colvarSecas12.IsNullable = true;
				colvarSecas12.IsPrimaryKey = false;
				colvarSecas12.IsForeignKey = false;
				colvarSecas12.IsReadOnly = false;
				colvarSecas12.DefaultSetting = @"";
				colvarSecas12.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecas12);
				
				TableSchema.TableColumn colvarSecas13 = new TableSchema.TableColumn(schema);
				colvarSecas13.ColumnName = "Secas13";
				colvarSecas13.DataType = DbType.String;
				colvarSecas13.MaxLength = 10;
				colvarSecas13.AutoIncrement = false;
				colvarSecas13.IsNullable = true;
				colvarSecas13.IsPrimaryKey = false;
				colvarSecas13.IsForeignKey = false;
				colvarSecas13.IsReadOnly = false;
				colvarSecas13.DefaultSetting = @"";
				colvarSecas13.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecas13);
				
				TableSchema.TableColumn colvarSecas14 = new TableSchema.TableColumn(schema);
				colvarSecas14.ColumnName = "Secas14";
				colvarSecas14.DataType = DbType.String;
				colvarSecas14.MaxLength = 10;
				colvarSecas14.AutoIncrement = false;
				colvarSecas14.IsNullable = true;
				colvarSecas14.IsPrimaryKey = false;
				colvarSecas14.IsForeignKey = false;
				colvarSecas14.IsReadOnly = false;
				colvarSecas14.DefaultSetting = @"";
				colvarSecas14.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecas14);
				
				TableSchema.TableColumn colvarSecas15 = new TableSchema.TableColumn(schema);
				colvarSecas15.ColumnName = "Secas15";
				colvarSecas15.DataType = DbType.String;
				colvarSecas15.MaxLength = 10;
				colvarSecas15.AutoIncrement = false;
				colvarSecas15.IsNullable = true;
				colvarSecas15.IsPrimaryKey = false;
				colvarSecas15.IsForeignKey = false;
				colvarSecas15.IsReadOnly = false;
				colvarSecas15.DefaultSetting = @"";
				colvarSecas15.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecas15);
				
				TableSchema.TableColumn colvarSecas16 = new TableSchema.TableColumn(schema);
				colvarSecas16.ColumnName = "Secas16";
				colvarSecas16.DataType = DbType.String;
				colvarSecas16.MaxLength = 10;
				colvarSecas16.AutoIncrement = false;
				colvarSecas16.IsNullable = true;
				colvarSecas16.IsPrimaryKey = false;
				colvarSecas16.IsForeignKey = false;
				colvarSecas16.IsReadOnly = false;
				colvarSecas16.DefaultSetting = @"";
				colvarSecas16.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecas16);
				
				TableSchema.TableColumn colvarSecas17 = new TableSchema.TableColumn(schema);
				colvarSecas17.ColumnName = "Secas17";
				colvarSecas17.DataType = DbType.String;
				colvarSecas17.MaxLength = 10;
				colvarSecas17.AutoIncrement = false;
				colvarSecas17.IsNullable = true;
				colvarSecas17.IsPrimaryKey = false;
				colvarSecas17.IsForeignKey = false;
				colvarSecas17.IsReadOnly = false;
				colvarSecas17.DefaultSetting = @"";
				colvarSecas17.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecas17);
				
				TableSchema.TableColumn colvarSecas18 = new TableSchema.TableColumn(schema);
				colvarSecas18.ColumnName = "Secas18";
				colvarSecas18.DataType = DbType.String;
				colvarSecas18.MaxLength = 10;
				colvarSecas18.AutoIncrement = false;
				colvarSecas18.IsNullable = true;
				colvarSecas18.IsPrimaryKey = false;
				colvarSecas18.IsForeignKey = false;
				colvarSecas18.IsReadOnly = false;
				colvarSecas18.DefaultSetting = @"";
				colvarSecas18.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecas18);
				
				TableSchema.TableColumn colvarSecas19 = new TableSchema.TableColumn(schema);
				colvarSecas19.ColumnName = "Secas19";
				colvarSecas19.DataType = DbType.String;
				colvarSecas19.MaxLength = 10;
				colvarSecas19.AutoIncrement = false;
				colvarSecas19.IsNullable = true;
				colvarSecas19.IsPrimaryKey = false;
				colvarSecas19.IsForeignKey = false;
				colvarSecas19.IsReadOnly = false;
				colvarSecas19.DefaultSetting = @"";
				colvarSecas19.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecas19);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("AssistantScore_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("AssistantScoreId")]
		[Bindable(true)]
		public int AssistantScoreId 
		{
			get { return GetColumnValue<int>(Columns.AssistantScoreId); }
			set { SetColumnValue(Columns.AssistantScoreId, value); }
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
		  
		[XmlAttribute("Selfas1")]
		[Bindable(true)]
		public string Selfas1 
		{
			get { return GetColumnValue<string>(Columns.Selfas1); }
			set { SetColumnValue(Columns.Selfas1, value); }
		}
		  
		[XmlAttribute("Selfas2")]
		[Bindable(true)]
		public string Selfas2 
		{
			get { return GetColumnValue<string>(Columns.Selfas2); }
			set { SetColumnValue(Columns.Selfas2, value); }
		}
		  
		[XmlAttribute("Selfas3")]
		[Bindable(true)]
		public string Selfas3 
		{
			get { return GetColumnValue<string>(Columns.Selfas3); }
			set { SetColumnValue(Columns.Selfas3, value); }
		}
		  
		[XmlAttribute("Selfas4")]
		[Bindable(true)]
		public string Selfas4 
		{
			get { return GetColumnValue<string>(Columns.Selfas4); }
			set { SetColumnValue(Columns.Selfas4, value); }
		}
		  
		[XmlAttribute("Selfas5")]
		[Bindable(true)]
		public string Selfas5 
		{
			get { return GetColumnValue<string>(Columns.Selfas5); }
			set { SetColumnValue(Columns.Selfas5, value); }
		}
		  
		[XmlAttribute("Selfas6")]
		[Bindable(true)]
		public string Selfas6 
		{
			get { return GetColumnValue<string>(Columns.Selfas6); }
			set { SetColumnValue(Columns.Selfas6, value); }
		}
		  
		[XmlAttribute("Selfas7")]
		[Bindable(true)]
		public string Selfas7 
		{
			get { return GetColumnValue<string>(Columns.Selfas7); }
			set { SetColumnValue(Columns.Selfas7, value); }
		}
		  
		[XmlAttribute("Selfas8")]
		[Bindable(true)]
		public string Selfas8 
		{
			get { return GetColumnValue<string>(Columns.Selfas8); }
			set { SetColumnValue(Columns.Selfas8, value); }
		}
		  
		[XmlAttribute("Selfas9")]
		[Bindable(true)]
		public string Selfas9 
		{
			get { return GetColumnValue<string>(Columns.Selfas9); }
			set { SetColumnValue(Columns.Selfas9, value); }
		}
		  
		[XmlAttribute("Selfas10")]
		[Bindable(true)]
		public string Selfas10 
		{
			get { return GetColumnValue<string>(Columns.Selfas10); }
			set { SetColumnValue(Columns.Selfas10, value); }
		}
		  
		[XmlAttribute("Selfas11")]
		[Bindable(true)]
		public string Selfas11 
		{
			get { return GetColumnValue<string>(Columns.Selfas11); }
			set { SetColumnValue(Columns.Selfas11, value); }
		}
		  
		[XmlAttribute("Selfas12")]
		[Bindable(true)]
		public string Selfas12 
		{
			get { return GetColumnValue<string>(Columns.Selfas12); }
			set { SetColumnValue(Columns.Selfas12, value); }
		}
		  
		[XmlAttribute("Selfas13")]
		[Bindable(true)]
		public string Selfas13 
		{
			get { return GetColumnValue<string>(Columns.Selfas13); }
			set { SetColumnValue(Columns.Selfas13, value); }
		}
		  
		[XmlAttribute("Selfas14")]
		[Bindable(true)]
		public string Selfas14 
		{
			get { return GetColumnValue<string>(Columns.Selfas14); }
			set { SetColumnValue(Columns.Selfas14, value); }
		}
		  
		[XmlAttribute("Selfas15")]
		[Bindable(true)]
		public string Selfas15 
		{
			get { return GetColumnValue<string>(Columns.Selfas15); }
			set { SetColumnValue(Columns.Selfas15, value); }
		}
		  
		[XmlAttribute("Selfas16")]
		[Bindable(true)]
		public string Selfas16 
		{
			get { return GetColumnValue<string>(Columns.Selfas16); }
			set { SetColumnValue(Columns.Selfas16, value); }
		}
		  
		[XmlAttribute("Selfas17")]
		[Bindable(true)]
		public string Selfas17 
		{
			get { return GetColumnValue<string>(Columns.Selfas17); }
			set { SetColumnValue(Columns.Selfas17, value); }
		}
		  
		[XmlAttribute("Selfas18")]
		[Bindable(true)]
		public string Selfas18 
		{
			get { return GetColumnValue<string>(Columns.Selfas18); }
			set { SetColumnValue(Columns.Selfas18, value); }
		}
		  
		[XmlAttribute("Selfas19")]
		[Bindable(true)]
		public string Selfas19 
		{
			get { return GetColumnValue<string>(Columns.Selfas19); }
			set { SetColumnValue(Columns.Selfas19, value); }
		}
		  
		[XmlAttribute("Upas1")]
		[Bindable(true)]
		public string Upas1 
		{
			get { return GetColumnValue<string>(Columns.Upas1); }
			set { SetColumnValue(Columns.Upas1, value); }
		}
		  
		[XmlAttribute("Upas2")]
		[Bindable(true)]
		public string Upas2 
		{
			get { return GetColumnValue<string>(Columns.Upas2); }
			set { SetColumnValue(Columns.Upas2, value); }
		}
		  
		[XmlAttribute("Upas3")]
		[Bindable(true)]
		public string Upas3 
		{
			get { return GetColumnValue<string>(Columns.Upas3); }
			set { SetColumnValue(Columns.Upas3, value); }
		}
		  
		[XmlAttribute("Upas4")]
		[Bindable(true)]
		public string Upas4 
		{
			get { return GetColumnValue<string>(Columns.Upas4); }
			set { SetColumnValue(Columns.Upas4, value); }
		}
		  
		[XmlAttribute("Upas5")]
		[Bindable(true)]
		public string Upas5 
		{
			get { return GetColumnValue<string>(Columns.Upas5); }
			set { SetColumnValue(Columns.Upas5, value); }
		}
		  
		[XmlAttribute("Upas6")]
		[Bindable(true)]
		public string Upas6 
		{
			get { return GetColumnValue<string>(Columns.Upas6); }
			set { SetColumnValue(Columns.Upas6, value); }
		}
		  
		[XmlAttribute("Upas7")]
		[Bindable(true)]
		public string Upas7 
		{
			get { return GetColumnValue<string>(Columns.Upas7); }
			set { SetColumnValue(Columns.Upas7, value); }
		}
		  
		[XmlAttribute("Upas8")]
		[Bindable(true)]
		public string Upas8 
		{
			get { return GetColumnValue<string>(Columns.Upas8); }
			set { SetColumnValue(Columns.Upas8, value); }
		}
		  
		[XmlAttribute("Upas9")]
		[Bindable(true)]
		public string Upas9 
		{
			get { return GetColumnValue<string>(Columns.Upas9); }
			set { SetColumnValue(Columns.Upas9, value); }
		}
		  
		[XmlAttribute("Upas10")]
		[Bindable(true)]
		public string Upas10 
		{
			get { return GetColumnValue<string>(Columns.Upas10); }
			set { SetColumnValue(Columns.Upas10, value); }
		}
		  
		[XmlAttribute("Upas11")]
		[Bindable(true)]
		public string Upas11 
		{
			get { return GetColumnValue<string>(Columns.Upas11); }
			set { SetColumnValue(Columns.Upas11, value); }
		}
		  
		[XmlAttribute("Upas12")]
		[Bindable(true)]
		public string Upas12 
		{
			get { return GetColumnValue<string>(Columns.Upas12); }
			set { SetColumnValue(Columns.Upas12, value); }
		}
		  
		[XmlAttribute("Upas13")]
		[Bindable(true)]
		public string Upas13 
		{
			get { return GetColumnValue<string>(Columns.Upas13); }
			set { SetColumnValue(Columns.Upas13, value); }
		}
		  
		[XmlAttribute("Upas14")]
		[Bindable(true)]
		public string Upas14 
		{
			get { return GetColumnValue<string>(Columns.Upas14); }
			set { SetColumnValue(Columns.Upas14, value); }
		}
		  
		[XmlAttribute("Upas15")]
		[Bindable(true)]
		public string Upas15 
		{
			get { return GetColumnValue<string>(Columns.Upas15); }
			set { SetColumnValue(Columns.Upas15, value); }
		}
		  
		[XmlAttribute("Upas16")]
		[Bindable(true)]
		public string Upas16 
		{
			get { return GetColumnValue<string>(Columns.Upas16); }
			set { SetColumnValue(Columns.Upas16, value); }
		}
		  
		[XmlAttribute("Upas17")]
		[Bindable(true)]
		public string Upas17 
		{
			get { return GetColumnValue<string>(Columns.Upas17); }
			set { SetColumnValue(Columns.Upas17, value); }
		}
		  
		[XmlAttribute("Upas18")]
		[Bindable(true)]
		public string Upas18 
		{
			get { return GetColumnValue<string>(Columns.Upas18); }
			set { SetColumnValue(Columns.Upas18, value); }
		}
		  
		[XmlAttribute("Upas19")]
		[Bindable(true)]
		public string Upas19 
		{
			get { return GetColumnValue<string>(Columns.Upas19); }
			set { SetColumnValue(Columns.Upas19, value); }
		}
		  
		[XmlAttribute("Secas1")]
		[Bindable(true)]
		public string Secas1 
		{
			get { return GetColumnValue<string>(Columns.Secas1); }
			set { SetColumnValue(Columns.Secas1, value); }
		}
		  
		[XmlAttribute("Secas2")]
		[Bindable(true)]
		public string Secas2 
		{
			get { return GetColumnValue<string>(Columns.Secas2); }
			set { SetColumnValue(Columns.Secas2, value); }
		}
		  
		[XmlAttribute("Secas3")]
		[Bindable(true)]
		public string Secas3 
		{
			get { return GetColumnValue<string>(Columns.Secas3); }
			set { SetColumnValue(Columns.Secas3, value); }
		}
		  
		[XmlAttribute("Secas4")]
		[Bindable(true)]
		public string Secas4 
		{
			get { return GetColumnValue<string>(Columns.Secas4); }
			set { SetColumnValue(Columns.Secas4, value); }
		}
		  
		[XmlAttribute("Secas5")]
		[Bindable(true)]
		public string Secas5 
		{
			get { return GetColumnValue<string>(Columns.Secas5); }
			set { SetColumnValue(Columns.Secas5, value); }
		}
		  
		[XmlAttribute("Secas6")]
		[Bindable(true)]
		public string Secas6 
		{
			get { return GetColumnValue<string>(Columns.Secas6); }
			set { SetColumnValue(Columns.Secas6, value); }
		}
		  
		[XmlAttribute("Secas7")]
		[Bindable(true)]
		public string Secas7 
		{
			get { return GetColumnValue<string>(Columns.Secas7); }
			set { SetColumnValue(Columns.Secas7, value); }
		}
		  
		[XmlAttribute("Secas8")]
		[Bindable(true)]
		public string Secas8 
		{
			get { return GetColumnValue<string>(Columns.Secas8); }
			set { SetColumnValue(Columns.Secas8, value); }
		}
		  
		[XmlAttribute("Secas9")]
		[Bindable(true)]
		public string Secas9 
		{
			get { return GetColumnValue<string>(Columns.Secas9); }
			set { SetColumnValue(Columns.Secas9, value); }
		}
		  
		[XmlAttribute("Secas10")]
		[Bindable(true)]
		public string Secas10 
		{
			get { return GetColumnValue<string>(Columns.Secas10); }
			set { SetColumnValue(Columns.Secas10, value); }
		}
		  
		[XmlAttribute("Secas11")]
		[Bindable(true)]
		public string Secas11 
		{
			get { return GetColumnValue<string>(Columns.Secas11); }
			set { SetColumnValue(Columns.Secas11, value); }
		}
		  
		[XmlAttribute("Secas12")]
		[Bindable(true)]
		public string Secas12 
		{
			get { return GetColumnValue<string>(Columns.Secas12); }
			set { SetColumnValue(Columns.Secas12, value); }
		}
		  
		[XmlAttribute("Secas13")]
		[Bindable(true)]
		public string Secas13 
		{
			get { return GetColumnValue<string>(Columns.Secas13); }
			set { SetColumnValue(Columns.Secas13, value); }
		}
		  
		[XmlAttribute("Secas14")]
		[Bindable(true)]
		public string Secas14 
		{
			get { return GetColumnValue<string>(Columns.Secas14); }
			set { SetColumnValue(Columns.Secas14, value); }
		}
		  
		[XmlAttribute("Secas15")]
		[Bindable(true)]
		public string Secas15 
		{
			get { return GetColumnValue<string>(Columns.Secas15); }
			set { SetColumnValue(Columns.Secas15, value); }
		}
		  
		[XmlAttribute("Secas16")]
		[Bindable(true)]
		public string Secas16 
		{
			get { return GetColumnValue<string>(Columns.Secas16); }
			set { SetColumnValue(Columns.Secas16, value); }
		}
		  
		[XmlAttribute("Secas17")]
		[Bindable(true)]
		public string Secas17 
		{
			get { return GetColumnValue<string>(Columns.Secas17); }
			set { SetColumnValue(Columns.Secas17, value); }
		}
		  
		[XmlAttribute("Secas18")]
		[Bindable(true)]
		public string Secas18 
		{
			get { return GetColumnValue<string>(Columns.Secas18); }
			set { SetColumnValue(Columns.Secas18, value); }
		}
		  
		[XmlAttribute("Secas19")]
		[Bindable(true)]
		public string Secas19 
		{
			get { return GetColumnValue<string>(Columns.Secas19); }
			set { SetColumnValue(Columns.Secas19, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varDateSpan,int? varEvaluateLevelId,string varTotalScore,string varUpViews,int? varYearId,int? varMonthId,int? varEmployeeId,int? varIsSubmit,string varSelfas1,string varSelfas2,string varSelfas3,string varSelfas4,string varSelfas5,string varSelfas6,string varSelfas7,string varSelfas8,string varSelfas9,string varSelfas10,string varSelfas11,string varSelfas12,string varSelfas13,string varSelfas14,string varSelfas15,string varSelfas16,string varSelfas17,string varSelfas18,string varSelfas19,string varUpas1,string varUpas2,string varUpas3,string varUpas4,string varUpas5,string varUpas6,string varUpas7,string varUpas8,string varUpas9,string varUpas10,string varUpas11,string varUpas12,string varUpas13,string varUpas14,string varUpas15,string varUpas16,string varUpas17,string varUpas18,string varUpas19,string varSecas1,string varSecas2,string varSecas3,string varSecas4,string varSecas5,string varSecas6,string varSecas7,string varSecas8,string varSecas9,string varSecas10,string varSecas11,string varSecas12,string varSecas13,string varSecas14,string varSecas15,string varSecas16,string varSecas17,string varSecas18,string varSecas19)
		{
			AssistantScore item = new AssistantScore();
			
			item.DateSpan = varDateSpan;
			
			item.EvaluateLevelId = varEvaluateLevelId;
			
			item.TotalScore = varTotalScore;
			
			item.UpViews = varUpViews;
			
			item.YearId = varYearId;
			
			item.MonthId = varMonthId;
			
			item.EmployeeId = varEmployeeId;
			
			item.IsSubmit = varIsSubmit;
			
			item.Selfas1 = varSelfas1;
			
			item.Selfas2 = varSelfas2;
			
			item.Selfas3 = varSelfas3;
			
			item.Selfas4 = varSelfas4;
			
			item.Selfas5 = varSelfas5;
			
			item.Selfas6 = varSelfas6;
			
			item.Selfas7 = varSelfas7;
			
			item.Selfas8 = varSelfas8;
			
			item.Selfas9 = varSelfas9;
			
			item.Selfas10 = varSelfas10;
			
			item.Selfas11 = varSelfas11;
			
			item.Selfas12 = varSelfas12;
			
			item.Selfas13 = varSelfas13;
			
			item.Selfas14 = varSelfas14;
			
			item.Selfas15 = varSelfas15;
			
			item.Selfas16 = varSelfas16;
			
			item.Selfas17 = varSelfas17;
			
			item.Selfas18 = varSelfas18;
			
			item.Selfas19 = varSelfas19;
			
			item.Upas1 = varUpas1;
			
			item.Upas2 = varUpas2;
			
			item.Upas3 = varUpas3;
			
			item.Upas4 = varUpas4;
			
			item.Upas5 = varUpas5;
			
			item.Upas6 = varUpas6;
			
			item.Upas7 = varUpas7;
			
			item.Upas8 = varUpas8;
			
			item.Upas9 = varUpas9;
			
			item.Upas10 = varUpas10;
			
			item.Upas11 = varUpas11;
			
			item.Upas12 = varUpas12;
			
			item.Upas13 = varUpas13;
			
			item.Upas14 = varUpas14;
			
			item.Upas15 = varUpas15;
			
			item.Upas16 = varUpas16;
			
			item.Upas17 = varUpas17;
			
			item.Upas18 = varUpas18;
			
			item.Upas19 = varUpas19;
			
			item.Secas1 = varSecas1;
			
			item.Secas2 = varSecas2;
			
			item.Secas3 = varSecas3;
			
			item.Secas4 = varSecas4;
			
			item.Secas5 = varSecas5;
			
			item.Secas6 = varSecas6;
			
			item.Secas7 = varSecas7;
			
			item.Secas8 = varSecas8;
			
			item.Secas9 = varSecas9;
			
			item.Secas10 = varSecas10;
			
			item.Secas11 = varSecas11;
			
			item.Secas12 = varSecas12;
			
			item.Secas13 = varSecas13;
			
			item.Secas14 = varSecas14;
			
			item.Secas15 = varSecas15;
			
			item.Secas16 = varSecas16;
			
			item.Secas17 = varSecas17;
			
			item.Secas18 = varSecas18;
			
			item.Secas19 = varSecas19;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varAssistantScoreId,string varDateSpan,int? varEvaluateLevelId,string varTotalScore,string varUpViews,int? varYearId,int? varMonthId,int? varEmployeeId,int? varIsSubmit,string varSelfas1,string varSelfas2,string varSelfas3,string varSelfas4,string varSelfas5,string varSelfas6,string varSelfas7,string varSelfas8,string varSelfas9,string varSelfas10,string varSelfas11,string varSelfas12,string varSelfas13,string varSelfas14,string varSelfas15,string varSelfas16,string varSelfas17,string varSelfas18,string varSelfas19,string varUpas1,string varUpas2,string varUpas3,string varUpas4,string varUpas5,string varUpas6,string varUpas7,string varUpas8,string varUpas9,string varUpas10,string varUpas11,string varUpas12,string varUpas13,string varUpas14,string varUpas15,string varUpas16,string varUpas17,string varUpas18,string varUpas19,string varSecas1,string varSecas2,string varSecas3,string varSecas4,string varSecas5,string varSecas6,string varSecas7,string varSecas8,string varSecas9,string varSecas10,string varSecas11,string varSecas12,string varSecas13,string varSecas14,string varSecas15,string varSecas16,string varSecas17,string varSecas18,string varSecas19)
		{
			AssistantScore item = new AssistantScore();
			
				item.AssistantScoreId = varAssistantScoreId;
			
				item.DateSpan = varDateSpan;
			
				item.EvaluateLevelId = varEvaluateLevelId;
			
				item.TotalScore = varTotalScore;
			
				item.UpViews = varUpViews;
			
				item.YearId = varYearId;
			
				item.MonthId = varMonthId;
			
				item.EmployeeId = varEmployeeId;
			
				item.IsSubmit = varIsSubmit;
			
				item.Selfas1 = varSelfas1;
			
				item.Selfas2 = varSelfas2;
			
				item.Selfas3 = varSelfas3;
			
				item.Selfas4 = varSelfas4;
			
				item.Selfas5 = varSelfas5;
			
				item.Selfas6 = varSelfas6;
			
				item.Selfas7 = varSelfas7;
			
				item.Selfas8 = varSelfas8;
			
				item.Selfas9 = varSelfas9;
			
				item.Selfas10 = varSelfas10;
			
				item.Selfas11 = varSelfas11;
			
				item.Selfas12 = varSelfas12;
			
				item.Selfas13 = varSelfas13;
			
				item.Selfas14 = varSelfas14;
			
				item.Selfas15 = varSelfas15;
			
				item.Selfas16 = varSelfas16;
			
				item.Selfas17 = varSelfas17;
			
				item.Selfas18 = varSelfas18;
			
				item.Selfas19 = varSelfas19;
			
				item.Upas1 = varUpas1;
			
				item.Upas2 = varUpas2;
			
				item.Upas3 = varUpas3;
			
				item.Upas4 = varUpas4;
			
				item.Upas5 = varUpas5;
			
				item.Upas6 = varUpas6;
			
				item.Upas7 = varUpas7;
			
				item.Upas8 = varUpas8;
			
				item.Upas9 = varUpas9;
			
				item.Upas10 = varUpas10;
			
				item.Upas11 = varUpas11;
			
				item.Upas12 = varUpas12;
			
				item.Upas13 = varUpas13;
			
				item.Upas14 = varUpas14;
			
				item.Upas15 = varUpas15;
			
				item.Upas16 = varUpas16;
			
				item.Upas17 = varUpas17;
			
				item.Upas18 = varUpas18;
			
				item.Upas19 = varUpas19;
			
				item.Secas1 = varSecas1;
			
				item.Secas2 = varSecas2;
			
				item.Secas3 = varSecas3;
			
				item.Secas4 = varSecas4;
			
				item.Secas5 = varSecas5;
			
				item.Secas6 = varSecas6;
			
				item.Secas7 = varSecas7;
			
				item.Secas8 = varSecas8;
			
				item.Secas9 = varSecas9;
			
				item.Secas10 = varSecas10;
			
				item.Secas11 = varSecas11;
			
				item.Secas12 = varSecas12;
			
				item.Secas13 = varSecas13;
			
				item.Secas14 = varSecas14;
			
				item.Secas15 = varSecas15;
			
				item.Secas16 = varSecas16;
			
				item.Secas17 = varSecas17;
			
				item.Secas18 = varSecas18;
			
				item.Secas19 = varSecas19;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn AssistantScoreIdColumn
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
        
        
        
        public static TableSchema.TableColumn Selfas1Column
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfas2Column
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfas3Column
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfas4Column
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfas5Column
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfas6Column
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfas7Column
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfas8Column
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfas9Column
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfas10Column
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfas11Column
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfas12Column
        {
            get { return Schema.Columns[20]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfas13Column
        {
            get { return Schema.Columns[21]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfas14Column
        {
            get { return Schema.Columns[22]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfas15Column
        {
            get { return Schema.Columns[23]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfas16Column
        {
            get { return Schema.Columns[24]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfas17Column
        {
            get { return Schema.Columns[25]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfas18Column
        {
            get { return Schema.Columns[26]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfas19Column
        {
            get { return Schema.Columns[27]; }
        }
        
        
        
        public static TableSchema.TableColumn Upas1Column
        {
            get { return Schema.Columns[28]; }
        }
        
        
        
        public static TableSchema.TableColumn Upas2Column
        {
            get { return Schema.Columns[29]; }
        }
        
        
        
        public static TableSchema.TableColumn Upas3Column
        {
            get { return Schema.Columns[30]; }
        }
        
        
        
        public static TableSchema.TableColumn Upas4Column
        {
            get { return Schema.Columns[31]; }
        }
        
        
        
        public static TableSchema.TableColumn Upas5Column
        {
            get { return Schema.Columns[32]; }
        }
        
        
        
        public static TableSchema.TableColumn Upas6Column
        {
            get { return Schema.Columns[33]; }
        }
        
        
        
        public static TableSchema.TableColumn Upas7Column
        {
            get { return Schema.Columns[34]; }
        }
        
        
        
        public static TableSchema.TableColumn Upas8Column
        {
            get { return Schema.Columns[35]; }
        }
        
        
        
        public static TableSchema.TableColumn Upas9Column
        {
            get { return Schema.Columns[36]; }
        }
        
        
        
        public static TableSchema.TableColumn Upas10Column
        {
            get { return Schema.Columns[37]; }
        }
        
        
        
        public static TableSchema.TableColumn Upas11Column
        {
            get { return Schema.Columns[38]; }
        }
        
        
        
        public static TableSchema.TableColumn Upas12Column
        {
            get { return Schema.Columns[39]; }
        }
        
        
        
        public static TableSchema.TableColumn Upas13Column
        {
            get { return Schema.Columns[40]; }
        }
        
        
        
        public static TableSchema.TableColumn Upas14Column
        {
            get { return Schema.Columns[41]; }
        }
        
        
        
        public static TableSchema.TableColumn Upas15Column
        {
            get { return Schema.Columns[42]; }
        }
        
        
        
        public static TableSchema.TableColumn Upas16Column
        {
            get { return Schema.Columns[43]; }
        }
        
        
        
        public static TableSchema.TableColumn Upas17Column
        {
            get { return Schema.Columns[44]; }
        }
        
        
        
        public static TableSchema.TableColumn Upas18Column
        {
            get { return Schema.Columns[45]; }
        }
        
        
        
        public static TableSchema.TableColumn Upas19Column
        {
            get { return Schema.Columns[46]; }
        }
        
        
        
        public static TableSchema.TableColumn Secas1Column
        {
            get { return Schema.Columns[47]; }
        }
        
        
        
        public static TableSchema.TableColumn Secas2Column
        {
            get { return Schema.Columns[48]; }
        }
        
        
        
        public static TableSchema.TableColumn Secas3Column
        {
            get { return Schema.Columns[49]; }
        }
        
        
        
        public static TableSchema.TableColumn Secas4Column
        {
            get { return Schema.Columns[50]; }
        }
        
        
        
        public static TableSchema.TableColumn Secas5Column
        {
            get { return Schema.Columns[51]; }
        }
        
        
        
        public static TableSchema.TableColumn Secas6Column
        {
            get { return Schema.Columns[52]; }
        }
        
        
        
        public static TableSchema.TableColumn Secas7Column
        {
            get { return Schema.Columns[53]; }
        }
        
        
        
        public static TableSchema.TableColumn Secas8Column
        {
            get { return Schema.Columns[54]; }
        }
        
        
        
        public static TableSchema.TableColumn Secas9Column
        {
            get { return Schema.Columns[55]; }
        }
        
        
        
        public static TableSchema.TableColumn Secas10Column
        {
            get { return Schema.Columns[56]; }
        }
        
        
        
        public static TableSchema.TableColumn Secas11Column
        {
            get { return Schema.Columns[57]; }
        }
        
        
        
        public static TableSchema.TableColumn Secas12Column
        {
            get { return Schema.Columns[58]; }
        }
        
        
        
        public static TableSchema.TableColumn Secas13Column
        {
            get { return Schema.Columns[59]; }
        }
        
        
        
        public static TableSchema.TableColumn Secas14Column
        {
            get { return Schema.Columns[60]; }
        }
        
        
        
        public static TableSchema.TableColumn Secas15Column
        {
            get { return Schema.Columns[61]; }
        }
        
        
        
        public static TableSchema.TableColumn Secas16Column
        {
            get { return Schema.Columns[62]; }
        }
        
        
        
        public static TableSchema.TableColumn Secas17Column
        {
            get { return Schema.Columns[63]; }
        }
        
        
        
        public static TableSchema.TableColumn Secas18Column
        {
            get { return Schema.Columns[64]; }
        }
        
        
        
        public static TableSchema.TableColumn Secas19Column
        {
            get { return Schema.Columns[65]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string AssistantScoreId = @"AssistantScoreId";
			 public static string DateSpan = @"DateSpan";
			 public static string EvaluateLevelId = @"EvaluateLevelId";
			 public static string TotalScore = @"TotalScore";
			 public static string UpViews = @"UpViews";
			 public static string YearId = @"YearId";
			 public static string MonthId = @"MonthId";
			 public static string EmployeeId = @"EmployeeId";
			 public static string IsSubmit = @"IsSubmit";
			 public static string Selfas1 = @"Selfas1";
			 public static string Selfas2 = @"Selfas2";
			 public static string Selfas3 = @"Selfas3";
			 public static string Selfas4 = @"Selfas4";
			 public static string Selfas5 = @"Selfas5";
			 public static string Selfas6 = @"Selfas6";
			 public static string Selfas7 = @"Selfas7";
			 public static string Selfas8 = @"Selfas8";
			 public static string Selfas9 = @"Selfas9";
			 public static string Selfas10 = @"Selfas10";
			 public static string Selfas11 = @"Selfas11";
			 public static string Selfas12 = @"Selfas12";
			 public static string Selfas13 = @"Selfas13";
			 public static string Selfas14 = @"Selfas14";
			 public static string Selfas15 = @"Selfas15";
			 public static string Selfas16 = @"Selfas16";
			 public static string Selfas17 = @"Selfas17";
			 public static string Selfas18 = @"Selfas18";
			 public static string Selfas19 = @"Selfas19";
			 public static string Upas1 = @"Upas1";
			 public static string Upas2 = @"Upas2";
			 public static string Upas3 = @"Upas3";
			 public static string Upas4 = @"Upas4";
			 public static string Upas5 = @"Upas5";
			 public static string Upas6 = @"Upas6";
			 public static string Upas7 = @"Upas7";
			 public static string Upas8 = @"Upas8";
			 public static string Upas9 = @"Upas9";
			 public static string Upas10 = @"Upas10";
			 public static string Upas11 = @"Upas11";
			 public static string Upas12 = @"Upas12";
			 public static string Upas13 = @"Upas13";
			 public static string Upas14 = @"Upas14";
			 public static string Upas15 = @"Upas15";
			 public static string Upas16 = @"Upas16";
			 public static string Upas17 = @"Upas17";
			 public static string Upas18 = @"Upas18";
			 public static string Upas19 = @"Upas19";
			 public static string Secas1 = @"Secas1";
			 public static string Secas2 = @"Secas2";
			 public static string Secas3 = @"Secas3";
			 public static string Secas4 = @"Secas4";
			 public static string Secas5 = @"Secas5";
			 public static string Secas6 = @"Secas6";
			 public static string Secas7 = @"Secas7";
			 public static string Secas8 = @"Secas8";
			 public static string Secas9 = @"Secas9";
			 public static string Secas10 = @"Secas10";
			 public static string Secas11 = @"Secas11";
			 public static string Secas12 = @"Secas12";
			 public static string Secas13 = @"Secas13";
			 public static string Secas14 = @"Secas14";
			 public static string Secas15 = @"Secas15";
			 public static string Secas16 = @"Secas16";
			 public static string Secas17 = @"Secas17";
			 public static string Secas18 = @"Secas18";
			 public static string Secas19 = @"Secas19";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
