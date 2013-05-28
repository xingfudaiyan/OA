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
	/// Strongly-typed collection for the TechMaScore class.
	/// </summary>
    [Serializable]
	public partial class TechMaScoreCollection : ActiveList<TechMaScore, TechMaScoreCollection>
	{	   
		public TechMaScoreCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TechMaScoreCollection</returns>
		public TechMaScoreCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TechMaScore o = this[i];
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
	/// This is an ActiveRecord class which wraps the TechMaScore_tb table.
	/// </summary>
	[Serializable]
	public partial class TechMaScore : ActiveRecord<TechMaScore>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TechMaScore()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TechMaScore(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TechMaScore(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TechMaScore(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TechMaScore_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarTechMaScoreId = new TableSchema.TableColumn(schema);
				colvarTechMaScoreId.ColumnName = "TechMaScoreId";
				colvarTechMaScoreId.DataType = DbType.Int32;
				colvarTechMaScoreId.MaxLength = 0;
				colvarTechMaScoreId.AutoIncrement = true;
				colvarTechMaScoreId.IsNullable = false;
				colvarTechMaScoreId.IsPrimaryKey = true;
				colvarTechMaScoreId.IsForeignKey = false;
				colvarTechMaScoreId.IsReadOnly = false;
				colvarTechMaScoreId.DefaultSetting = @"";
				colvarTechMaScoreId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTechMaScoreId);
				
				TableSchema.TableColumn colvarReason = new TableSchema.TableColumn(schema);
				colvarReason.ColumnName = "Reason";
				colvarReason.DataType = DbType.String;
				colvarReason.MaxLength = 100;
				colvarReason.AutoIncrement = false;
				colvarReason.IsNullable = true;
				colvarReason.IsPrimaryKey = false;
				colvarReason.IsForeignKey = false;
				colvarReason.IsReadOnly = false;
				colvarReason.DefaultSetting = @"";
				colvarReason.ForeignKeyTableName = "";
				schema.Columns.Add(colvarReason);
				
				TableSchema.TableColumn colvarAddMinusScore = new TableSchema.TableColumn(schema);
				colvarAddMinusScore.ColumnName = "AddMinusScore";
				colvarAddMinusScore.DataType = DbType.String;
				colvarAddMinusScore.MaxLength = 10;
				colvarAddMinusScore.AutoIncrement = false;
				colvarAddMinusScore.IsNullable = true;
				colvarAddMinusScore.IsPrimaryKey = false;
				colvarAddMinusScore.IsForeignKey = false;
				colvarAddMinusScore.IsReadOnly = false;
				colvarAddMinusScore.DefaultSetting = @"";
				colvarAddMinusScore.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAddMinusScore);
				
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
				
				TableSchema.TableColumn colvarUpView = new TableSchema.TableColumn(schema);
				colvarUpView.ColumnName = "UpView";
				colvarUpView.DataType = DbType.String;
				colvarUpView.MaxLength = -1;
				colvarUpView.AutoIncrement = false;
				colvarUpView.IsNullable = true;
				colvarUpView.IsPrimaryKey = false;
				colvarUpView.IsForeignKey = false;
				colvarUpView.IsReadOnly = false;
				colvarUpView.DefaultSetting = @"";
				colvarUpView.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpView);
				
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
				
				TableSchema.TableColumn colvarDateSpan = new TableSchema.TableColumn(schema);
				colvarDateSpan.ColumnName = "DateSpan";
				colvarDateSpan.DataType = DbType.String;
				colvarDateSpan.MaxLength = 20;
				colvarDateSpan.AutoIncrement = false;
				colvarDateSpan.IsNullable = true;
				colvarDateSpan.IsPrimaryKey = false;
				colvarDateSpan.IsForeignKey = false;
				colvarDateSpan.IsReadOnly = false;
				colvarDateSpan.DefaultSetting = @"";
				colvarDateSpan.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDateSpan);
				
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
				
				TableSchema.TableColumn colvarSelfScore1 = new TableSchema.TableColumn(schema);
				colvarSelfScore1.ColumnName = "SelfScore1";
				colvarSelfScore1.DataType = DbType.String;
				colvarSelfScore1.MaxLength = 10;
				colvarSelfScore1.AutoIncrement = false;
				colvarSelfScore1.IsNullable = true;
				colvarSelfScore1.IsPrimaryKey = false;
				colvarSelfScore1.IsForeignKey = false;
				colvarSelfScore1.IsReadOnly = false;
				colvarSelfScore1.DefaultSetting = @"";
				colvarSelfScore1.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfScore1);
				
				TableSchema.TableColumn colvarSelfScore2 = new TableSchema.TableColumn(schema);
				colvarSelfScore2.ColumnName = "SelfScore2";
				colvarSelfScore2.DataType = DbType.String;
				colvarSelfScore2.MaxLength = 10;
				colvarSelfScore2.AutoIncrement = false;
				colvarSelfScore2.IsNullable = true;
				colvarSelfScore2.IsPrimaryKey = false;
				colvarSelfScore2.IsForeignKey = false;
				colvarSelfScore2.IsReadOnly = false;
				colvarSelfScore2.DefaultSetting = @"";
				colvarSelfScore2.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfScore2);
				
				TableSchema.TableColumn colvarSelfScore3 = new TableSchema.TableColumn(schema);
				colvarSelfScore3.ColumnName = "SelfScore3";
				colvarSelfScore3.DataType = DbType.String;
				colvarSelfScore3.MaxLength = 10;
				colvarSelfScore3.AutoIncrement = false;
				colvarSelfScore3.IsNullable = true;
				colvarSelfScore3.IsPrimaryKey = false;
				colvarSelfScore3.IsForeignKey = false;
				colvarSelfScore3.IsReadOnly = false;
				colvarSelfScore3.DefaultSetting = @"";
				colvarSelfScore3.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfScore3);
				
				TableSchema.TableColumn colvarSelfScore4 = new TableSchema.TableColumn(schema);
				colvarSelfScore4.ColumnName = "SelfScore4";
				colvarSelfScore4.DataType = DbType.String;
				colvarSelfScore4.MaxLength = 10;
				colvarSelfScore4.AutoIncrement = false;
				colvarSelfScore4.IsNullable = true;
				colvarSelfScore4.IsPrimaryKey = false;
				colvarSelfScore4.IsForeignKey = false;
				colvarSelfScore4.IsReadOnly = false;
				colvarSelfScore4.DefaultSetting = @"";
				colvarSelfScore4.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfScore4);
				
				TableSchema.TableColumn colvarSelfScore5 = new TableSchema.TableColumn(schema);
				colvarSelfScore5.ColumnName = "SelfScore5";
				colvarSelfScore5.DataType = DbType.String;
				colvarSelfScore5.MaxLength = 10;
				colvarSelfScore5.AutoIncrement = false;
				colvarSelfScore5.IsNullable = true;
				colvarSelfScore5.IsPrimaryKey = false;
				colvarSelfScore5.IsForeignKey = false;
				colvarSelfScore5.IsReadOnly = false;
				colvarSelfScore5.DefaultSetting = @"";
				colvarSelfScore5.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfScore5);
				
				TableSchema.TableColumn colvarSelfScore6 = new TableSchema.TableColumn(schema);
				colvarSelfScore6.ColumnName = "SelfScore6";
				colvarSelfScore6.DataType = DbType.String;
				colvarSelfScore6.MaxLength = 10;
				colvarSelfScore6.AutoIncrement = false;
				colvarSelfScore6.IsNullable = true;
				colvarSelfScore6.IsPrimaryKey = false;
				colvarSelfScore6.IsForeignKey = false;
				colvarSelfScore6.IsReadOnly = false;
				colvarSelfScore6.DefaultSetting = @"";
				colvarSelfScore6.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfScore6);
				
				TableSchema.TableColumn colvarSelfScore7 = new TableSchema.TableColumn(schema);
				colvarSelfScore7.ColumnName = "SelfScore7";
				colvarSelfScore7.DataType = DbType.String;
				colvarSelfScore7.MaxLength = 10;
				colvarSelfScore7.AutoIncrement = false;
				colvarSelfScore7.IsNullable = true;
				colvarSelfScore7.IsPrimaryKey = false;
				colvarSelfScore7.IsForeignKey = false;
				colvarSelfScore7.IsReadOnly = false;
				colvarSelfScore7.DefaultSetting = @"";
				colvarSelfScore7.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfScore7);
				
				TableSchema.TableColumn colvarSelfScore8 = new TableSchema.TableColumn(schema);
				colvarSelfScore8.ColumnName = "SelfScore8";
				colvarSelfScore8.DataType = DbType.String;
				colvarSelfScore8.MaxLength = 10;
				colvarSelfScore8.AutoIncrement = false;
				colvarSelfScore8.IsNullable = true;
				colvarSelfScore8.IsPrimaryKey = false;
				colvarSelfScore8.IsForeignKey = false;
				colvarSelfScore8.IsReadOnly = false;
				colvarSelfScore8.DefaultSetting = @"";
				colvarSelfScore8.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfScore8);
				
				TableSchema.TableColumn colvarSelfScore9 = new TableSchema.TableColumn(schema);
				colvarSelfScore9.ColumnName = "SelfScore9";
				colvarSelfScore9.DataType = DbType.String;
				colvarSelfScore9.MaxLength = 10;
				colvarSelfScore9.AutoIncrement = false;
				colvarSelfScore9.IsNullable = true;
				colvarSelfScore9.IsPrimaryKey = false;
				colvarSelfScore9.IsForeignKey = false;
				colvarSelfScore9.IsReadOnly = false;
				colvarSelfScore9.DefaultSetting = @"";
				colvarSelfScore9.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfScore9);
				
				TableSchema.TableColumn colvarSelfScore10 = new TableSchema.TableColumn(schema);
				colvarSelfScore10.ColumnName = "SelfScore10";
				colvarSelfScore10.DataType = DbType.String;
				colvarSelfScore10.MaxLength = 10;
				colvarSelfScore10.AutoIncrement = false;
				colvarSelfScore10.IsNullable = true;
				colvarSelfScore10.IsPrimaryKey = false;
				colvarSelfScore10.IsForeignKey = false;
				colvarSelfScore10.IsReadOnly = false;
				colvarSelfScore10.DefaultSetting = @"";
				colvarSelfScore10.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfScore10);
				
				TableSchema.TableColumn colvarSelfScore11 = new TableSchema.TableColumn(schema);
				colvarSelfScore11.ColumnName = "SelfScore11";
				colvarSelfScore11.DataType = DbType.String;
				colvarSelfScore11.MaxLength = 10;
				colvarSelfScore11.AutoIncrement = false;
				colvarSelfScore11.IsNullable = true;
				colvarSelfScore11.IsPrimaryKey = false;
				colvarSelfScore11.IsForeignKey = false;
				colvarSelfScore11.IsReadOnly = false;
				colvarSelfScore11.DefaultSetting = @"";
				colvarSelfScore11.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfScore11);
				
				TableSchema.TableColumn colvarSelfScore12 = new TableSchema.TableColumn(schema);
				colvarSelfScore12.ColumnName = "SelfScore12";
				colvarSelfScore12.DataType = DbType.String;
				colvarSelfScore12.MaxLength = 10;
				colvarSelfScore12.AutoIncrement = false;
				colvarSelfScore12.IsNullable = true;
				colvarSelfScore12.IsPrimaryKey = false;
				colvarSelfScore12.IsForeignKey = false;
				colvarSelfScore12.IsReadOnly = false;
				colvarSelfScore12.DefaultSetting = @"";
				colvarSelfScore12.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfScore12);
				
				TableSchema.TableColumn colvarSelfScore13 = new TableSchema.TableColumn(schema);
				colvarSelfScore13.ColumnName = "SelfScore13";
				colvarSelfScore13.DataType = DbType.String;
				colvarSelfScore13.MaxLength = 10;
				colvarSelfScore13.AutoIncrement = false;
				colvarSelfScore13.IsNullable = true;
				colvarSelfScore13.IsPrimaryKey = false;
				colvarSelfScore13.IsForeignKey = false;
				colvarSelfScore13.IsReadOnly = false;
				colvarSelfScore13.DefaultSetting = @"";
				colvarSelfScore13.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfScore13);
				
				TableSchema.TableColumn colvarUpScore1 = new TableSchema.TableColumn(schema);
				colvarUpScore1.ColumnName = "UpScore1";
				colvarUpScore1.DataType = DbType.String;
				colvarUpScore1.MaxLength = 10;
				colvarUpScore1.AutoIncrement = false;
				colvarUpScore1.IsNullable = true;
				colvarUpScore1.IsPrimaryKey = false;
				colvarUpScore1.IsForeignKey = false;
				colvarUpScore1.IsReadOnly = false;
				colvarUpScore1.DefaultSetting = @"";
				colvarUpScore1.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpScore1);
				
				TableSchema.TableColumn colvarUpScore2 = new TableSchema.TableColumn(schema);
				colvarUpScore2.ColumnName = "UpScore2";
				colvarUpScore2.DataType = DbType.String;
				colvarUpScore2.MaxLength = 10;
				colvarUpScore2.AutoIncrement = false;
				colvarUpScore2.IsNullable = true;
				colvarUpScore2.IsPrimaryKey = false;
				colvarUpScore2.IsForeignKey = false;
				colvarUpScore2.IsReadOnly = false;
				colvarUpScore2.DefaultSetting = @"";
				colvarUpScore2.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpScore2);
				
				TableSchema.TableColumn colvarUpScore3 = new TableSchema.TableColumn(schema);
				colvarUpScore3.ColumnName = "UpScore3";
				colvarUpScore3.DataType = DbType.String;
				colvarUpScore3.MaxLength = 10;
				colvarUpScore3.AutoIncrement = false;
				colvarUpScore3.IsNullable = true;
				colvarUpScore3.IsPrimaryKey = false;
				colvarUpScore3.IsForeignKey = false;
				colvarUpScore3.IsReadOnly = false;
				colvarUpScore3.DefaultSetting = @"";
				colvarUpScore3.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpScore3);
				
				TableSchema.TableColumn colvarUpScore4 = new TableSchema.TableColumn(schema);
				colvarUpScore4.ColumnName = "UpScore4";
				colvarUpScore4.DataType = DbType.String;
				colvarUpScore4.MaxLength = 10;
				colvarUpScore4.AutoIncrement = false;
				colvarUpScore4.IsNullable = true;
				colvarUpScore4.IsPrimaryKey = false;
				colvarUpScore4.IsForeignKey = false;
				colvarUpScore4.IsReadOnly = false;
				colvarUpScore4.DefaultSetting = @"";
				colvarUpScore4.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpScore4);
				
				TableSchema.TableColumn colvarUpScore5 = new TableSchema.TableColumn(schema);
				colvarUpScore5.ColumnName = "UpScore5";
				colvarUpScore5.DataType = DbType.String;
				colvarUpScore5.MaxLength = 10;
				colvarUpScore5.AutoIncrement = false;
				colvarUpScore5.IsNullable = true;
				colvarUpScore5.IsPrimaryKey = false;
				colvarUpScore5.IsForeignKey = false;
				colvarUpScore5.IsReadOnly = false;
				colvarUpScore5.DefaultSetting = @"";
				colvarUpScore5.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpScore5);
				
				TableSchema.TableColumn colvarUpScore6 = new TableSchema.TableColumn(schema);
				colvarUpScore6.ColumnName = "UpScore6";
				colvarUpScore6.DataType = DbType.String;
				colvarUpScore6.MaxLength = 10;
				colvarUpScore6.AutoIncrement = false;
				colvarUpScore6.IsNullable = true;
				colvarUpScore6.IsPrimaryKey = false;
				colvarUpScore6.IsForeignKey = false;
				colvarUpScore6.IsReadOnly = false;
				colvarUpScore6.DefaultSetting = @"";
				colvarUpScore6.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpScore6);
				
				TableSchema.TableColumn colvarUpScore7 = new TableSchema.TableColumn(schema);
				colvarUpScore7.ColumnName = "UpScore7";
				colvarUpScore7.DataType = DbType.String;
				colvarUpScore7.MaxLength = 10;
				colvarUpScore7.AutoIncrement = false;
				colvarUpScore7.IsNullable = true;
				colvarUpScore7.IsPrimaryKey = false;
				colvarUpScore7.IsForeignKey = false;
				colvarUpScore7.IsReadOnly = false;
				colvarUpScore7.DefaultSetting = @"";
				colvarUpScore7.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpScore7);
				
				TableSchema.TableColumn colvarUpScore8 = new TableSchema.TableColumn(schema);
				colvarUpScore8.ColumnName = "UpScore8";
				colvarUpScore8.DataType = DbType.String;
				colvarUpScore8.MaxLength = 10;
				colvarUpScore8.AutoIncrement = false;
				colvarUpScore8.IsNullable = true;
				colvarUpScore8.IsPrimaryKey = false;
				colvarUpScore8.IsForeignKey = false;
				colvarUpScore8.IsReadOnly = false;
				colvarUpScore8.DefaultSetting = @"";
				colvarUpScore8.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpScore8);
				
				TableSchema.TableColumn colvarUpScore9 = new TableSchema.TableColumn(schema);
				colvarUpScore9.ColumnName = "UpScore9";
				colvarUpScore9.DataType = DbType.String;
				colvarUpScore9.MaxLength = 10;
				colvarUpScore9.AutoIncrement = false;
				colvarUpScore9.IsNullable = true;
				colvarUpScore9.IsPrimaryKey = false;
				colvarUpScore9.IsForeignKey = false;
				colvarUpScore9.IsReadOnly = false;
				colvarUpScore9.DefaultSetting = @"";
				colvarUpScore9.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpScore9);
				
				TableSchema.TableColumn colvarUpScore10 = new TableSchema.TableColumn(schema);
				colvarUpScore10.ColumnName = "UpScore10";
				colvarUpScore10.DataType = DbType.String;
				colvarUpScore10.MaxLength = 10;
				colvarUpScore10.AutoIncrement = false;
				colvarUpScore10.IsNullable = true;
				colvarUpScore10.IsPrimaryKey = false;
				colvarUpScore10.IsForeignKey = false;
				colvarUpScore10.IsReadOnly = false;
				colvarUpScore10.DefaultSetting = @"";
				colvarUpScore10.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpScore10);
				
				TableSchema.TableColumn colvarUpScore11 = new TableSchema.TableColumn(schema);
				colvarUpScore11.ColumnName = "UpScore11";
				colvarUpScore11.DataType = DbType.String;
				colvarUpScore11.MaxLength = 10;
				colvarUpScore11.AutoIncrement = false;
				colvarUpScore11.IsNullable = true;
				colvarUpScore11.IsPrimaryKey = false;
				colvarUpScore11.IsForeignKey = false;
				colvarUpScore11.IsReadOnly = false;
				colvarUpScore11.DefaultSetting = @"";
				colvarUpScore11.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpScore11);
				
				TableSchema.TableColumn colvarUpScore12 = new TableSchema.TableColumn(schema);
				colvarUpScore12.ColumnName = "UpScore12";
				colvarUpScore12.DataType = DbType.String;
				colvarUpScore12.MaxLength = 10;
				colvarUpScore12.AutoIncrement = false;
				colvarUpScore12.IsNullable = true;
				colvarUpScore12.IsPrimaryKey = false;
				colvarUpScore12.IsForeignKey = false;
				colvarUpScore12.IsReadOnly = false;
				colvarUpScore12.DefaultSetting = @"";
				colvarUpScore12.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpScore12);
				
				TableSchema.TableColumn colvarUpScore13 = new TableSchema.TableColumn(schema);
				colvarUpScore13.ColumnName = "UpScore13";
				colvarUpScore13.DataType = DbType.String;
				colvarUpScore13.MaxLength = 10;
				colvarUpScore13.AutoIncrement = false;
				colvarUpScore13.IsNullable = true;
				colvarUpScore13.IsPrimaryKey = false;
				colvarUpScore13.IsForeignKey = false;
				colvarUpScore13.IsReadOnly = false;
				colvarUpScore13.DefaultSetting = @"";
				colvarUpScore13.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpScore13);
				
				TableSchema.TableColumn colvarSectScore1 = new TableSchema.TableColumn(schema);
				colvarSectScore1.ColumnName = "SectScore1";
				colvarSectScore1.DataType = DbType.String;
				colvarSectScore1.MaxLength = 10;
				colvarSectScore1.AutoIncrement = false;
				colvarSectScore1.IsNullable = true;
				colvarSectScore1.IsPrimaryKey = false;
				colvarSectScore1.IsForeignKey = false;
				colvarSectScore1.IsReadOnly = false;
				colvarSectScore1.DefaultSetting = @"";
				colvarSectScore1.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSectScore1);
				
				TableSchema.TableColumn colvarSectScore2 = new TableSchema.TableColumn(schema);
				colvarSectScore2.ColumnName = "SectScore2";
				colvarSectScore2.DataType = DbType.String;
				colvarSectScore2.MaxLength = 10;
				colvarSectScore2.AutoIncrement = false;
				colvarSectScore2.IsNullable = true;
				colvarSectScore2.IsPrimaryKey = false;
				colvarSectScore2.IsForeignKey = false;
				colvarSectScore2.IsReadOnly = false;
				colvarSectScore2.DefaultSetting = @"";
				colvarSectScore2.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSectScore2);
				
				TableSchema.TableColumn colvarSectScore3 = new TableSchema.TableColumn(schema);
				colvarSectScore3.ColumnName = "SectScore3";
				colvarSectScore3.DataType = DbType.String;
				colvarSectScore3.MaxLength = 10;
				colvarSectScore3.AutoIncrement = false;
				colvarSectScore3.IsNullable = true;
				colvarSectScore3.IsPrimaryKey = false;
				colvarSectScore3.IsForeignKey = false;
				colvarSectScore3.IsReadOnly = false;
				colvarSectScore3.DefaultSetting = @"";
				colvarSectScore3.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSectScore3);
				
				TableSchema.TableColumn colvarSectScore4 = new TableSchema.TableColumn(schema);
				colvarSectScore4.ColumnName = "SectScore4";
				colvarSectScore4.DataType = DbType.String;
				colvarSectScore4.MaxLength = 10;
				colvarSectScore4.AutoIncrement = false;
				colvarSectScore4.IsNullable = true;
				colvarSectScore4.IsPrimaryKey = false;
				colvarSectScore4.IsForeignKey = false;
				colvarSectScore4.IsReadOnly = false;
				colvarSectScore4.DefaultSetting = @"";
				colvarSectScore4.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSectScore4);
				
				TableSchema.TableColumn colvarSectScore5 = new TableSchema.TableColumn(schema);
				colvarSectScore5.ColumnName = "SectScore5";
				colvarSectScore5.DataType = DbType.String;
				colvarSectScore5.MaxLength = 10;
				colvarSectScore5.AutoIncrement = false;
				colvarSectScore5.IsNullable = true;
				colvarSectScore5.IsPrimaryKey = false;
				colvarSectScore5.IsForeignKey = false;
				colvarSectScore5.IsReadOnly = false;
				colvarSectScore5.DefaultSetting = @"";
				colvarSectScore5.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSectScore5);
				
				TableSchema.TableColumn colvarSectScore6 = new TableSchema.TableColumn(schema);
				colvarSectScore6.ColumnName = "SectScore6";
				colvarSectScore6.DataType = DbType.String;
				colvarSectScore6.MaxLength = 10;
				colvarSectScore6.AutoIncrement = false;
				colvarSectScore6.IsNullable = true;
				colvarSectScore6.IsPrimaryKey = false;
				colvarSectScore6.IsForeignKey = false;
				colvarSectScore6.IsReadOnly = false;
				colvarSectScore6.DefaultSetting = @"";
				colvarSectScore6.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSectScore6);
				
				TableSchema.TableColumn colvarSectScore7 = new TableSchema.TableColumn(schema);
				colvarSectScore7.ColumnName = "SectScore7";
				colvarSectScore7.DataType = DbType.String;
				colvarSectScore7.MaxLength = 10;
				colvarSectScore7.AutoIncrement = false;
				colvarSectScore7.IsNullable = true;
				colvarSectScore7.IsPrimaryKey = false;
				colvarSectScore7.IsForeignKey = false;
				colvarSectScore7.IsReadOnly = false;
				colvarSectScore7.DefaultSetting = @"";
				colvarSectScore7.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSectScore7);
				
				TableSchema.TableColumn colvarSectScore8 = new TableSchema.TableColumn(schema);
				colvarSectScore8.ColumnName = "SectScore8";
				colvarSectScore8.DataType = DbType.String;
				colvarSectScore8.MaxLength = 10;
				colvarSectScore8.AutoIncrement = false;
				colvarSectScore8.IsNullable = true;
				colvarSectScore8.IsPrimaryKey = false;
				colvarSectScore8.IsForeignKey = false;
				colvarSectScore8.IsReadOnly = false;
				colvarSectScore8.DefaultSetting = @"";
				colvarSectScore8.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSectScore8);
				
				TableSchema.TableColumn colvarSectScore9 = new TableSchema.TableColumn(schema);
				colvarSectScore9.ColumnName = "SectScore9";
				colvarSectScore9.DataType = DbType.String;
				colvarSectScore9.MaxLength = 10;
				colvarSectScore9.AutoIncrement = false;
				colvarSectScore9.IsNullable = true;
				colvarSectScore9.IsPrimaryKey = false;
				colvarSectScore9.IsForeignKey = false;
				colvarSectScore9.IsReadOnly = false;
				colvarSectScore9.DefaultSetting = @"";
				colvarSectScore9.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSectScore9);
				
				TableSchema.TableColumn colvarSectScore10 = new TableSchema.TableColumn(schema);
				colvarSectScore10.ColumnName = "SectScore10";
				colvarSectScore10.DataType = DbType.String;
				colvarSectScore10.MaxLength = 10;
				colvarSectScore10.AutoIncrement = false;
				colvarSectScore10.IsNullable = true;
				colvarSectScore10.IsPrimaryKey = false;
				colvarSectScore10.IsForeignKey = false;
				colvarSectScore10.IsReadOnly = false;
				colvarSectScore10.DefaultSetting = @"";
				colvarSectScore10.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSectScore10);
				
				TableSchema.TableColumn colvarSectScore11 = new TableSchema.TableColumn(schema);
				colvarSectScore11.ColumnName = "SectScore11";
				colvarSectScore11.DataType = DbType.String;
				colvarSectScore11.MaxLength = 10;
				colvarSectScore11.AutoIncrement = false;
				colvarSectScore11.IsNullable = true;
				colvarSectScore11.IsPrimaryKey = false;
				colvarSectScore11.IsForeignKey = false;
				colvarSectScore11.IsReadOnly = false;
				colvarSectScore11.DefaultSetting = @"";
				colvarSectScore11.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSectScore11);
				
				TableSchema.TableColumn colvarSectScore12 = new TableSchema.TableColumn(schema);
				colvarSectScore12.ColumnName = "SectScore12";
				colvarSectScore12.DataType = DbType.String;
				colvarSectScore12.MaxLength = 10;
				colvarSectScore12.AutoIncrement = false;
				colvarSectScore12.IsNullable = true;
				colvarSectScore12.IsPrimaryKey = false;
				colvarSectScore12.IsForeignKey = false;
				colvarSectScore12.IsReadOnly = false;
				colvarSectScore12.DefaultSetting = @"";
				colvarSectScore12.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSectScore12);
				
				TableSchema.TableColumn colvarSectScore13 = new TableSchema.TableColumn(schema);
				colvarSectScore13.ColumnName = "SectScore13";
				colvarSectScore13.DataType = DbType.String;
				colvarSectScore13.MaxLength = 10;
				colvarSectScore13.AutoIncrement = false;
				colvarSectScore13.IsNullable = true;
				colvarSectScore13.IsPrimaryKey = false;
				colvarSectScore13.IsForeignKey = false;
				colvarSectScore13.IsReadOnly = false;
				colvarSectScore13.DefaultSetting = @"";
				colvarSectScore13.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSectScore13);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("TechMaScore_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("TechMaScoreId")]
		[Bindable(true)]
		public int TechMaScoreId 
		{
			get { return GetColumnValue<int>(Columns.TechMaScoreId); }
			set { SetColumnValue(Columns.TechMaScoreId, value); }
		}
		  
		[XmlAttribute("Reason")]
		[Bindable(true)]
		public string Reason 
		{
			get { return GetColumnValue<string>(Columns.Reason); }
			set { SetColumnValue(Columns.Reason, value); }
		}
		  
		[XmlAttribute("AddMinusScore")]
		[Bindable(true)]
		public string AddMinusScore 
		{
			get { return GetColumnValue<string>(Columns.AddMinusScore); }
			set { SetColumnValue(Columns.AddMinusScore, value); }
		}
		  
		[XmlAttribute("TotalScore")]
		[Bindable(true)]
		public string TotalScore 
		{
			get { return GetColumnValue<string>(Columns.TotalScore); }
			set { SetColumnValue(Columns.TotalScore, value); }
		}
		  
		[XmlAttribute("UpView")]
		[Bindable(true)]
		public string UpView 
		{
			get { return GetColumnValue<string>(Columns.UpView); }
			set { SetColumnValue(Columns.UpView, value); }
		}
		  
		[XmlAttribute("EvaluateLevelId")]
		[Bindable(true)]
		public int? EvaluateLevelId 
		{
			get { return GetColumnValue<int?>(Columns.EvaluateLevelId); }
			set { SetColumnValue(Columns.EvaluateLevelId, value); }
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
		  
		[XmlAttribute("DateSpan")]
		[Bindable(true)]
		public string DateSpan 
		{
			get { return GetColumnValue<string>(Columns.DateSpan); }
			set { SetColumnValue(Columns.DateSpan, value); }
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
		  
		[XmlAttribute("SelfScore1")]
		[Bindable(true)]
		public string SelfScore1 
		{
			get { return GetColumnValue<string>(Columns.SelfScore1); }
			set { SetColumnValue(Columns.SelfScore1, value); }
		}
		  
		[XmlAttribute("SelfScore2")]
		[Bindable(true)]
		public string SelfScore2 
		{
			get { return GetColumnValue<string>(Columns.SelfScore2); }
			set { SetColumnValue(Columns.SelfScore2, value); }
		}
		  
		[XmlAttribute("SelfScore3")]
		[Bindable(true)]
		public string SelfScore3 
		{
			get { return GetColumnValue<string>(Columns.SelfScore3); }
			set { SetColumnValue(Columns.SelfScore3, value); }
		}
		  
		[XmlAttribute("SelfScore4")]
		[Bindable(true)]
		public string SelfScore4 
		{
			get { return GetColumnValue<string>(Columns.SelfScore4); }
			set { SetColumnValue(Columns.SelfScore4, value); }
		}
		  
		[XmlAttribute("SelfScore5")]
		[Bindable(true)]
		public string SelfScore5 
		{
			get { return GetColumnValue<string>(Columns.SelfScore5); }
			set { SetColumnValue(Columns.SelfScore5, value); }
		}
		  
		[XmlAttribute("SelfScore6")]
		[Bindable(true)]
		public string SelfScore6 
		{
			get { return GetColumnValue<string>(Columns.SelfScore6); }
			set { SetColumnValue(Columns.SelfScore6, value); }
		}
		  
		[XmlAttribute("SelfScore7")]
		[Bindable(true)]
		public string SelfScore7 
		{
			get { return GetColumnValue<string>(Columns.SelfScore7); }
			set { SetColumnValue(Columns.SelfScore7, value); }
		}
		  
		[XmlAttribute("SelfScore8")]
		[Bindable(true)]
		public string SelfScore8 
		{
			get { return GetColumnValue<string>(Columns.SelfScore8); }
			set { SetColumnValue(Columns.SelfScore8, value); }
		}
		  
		[XmlAttribute("SelfScore9")]
		[Bindable(true)]
		public string SelfScore9 
		{
			get { return GetColumnValue<string>(Columns.SelfScore9); }
			set { SetColumnValue(Columns.SelfScore9, value); }
		}
		  
		[XmlAttribute("SelfScore10")]
		[Bindable(true)]
		public string SelfScore10 
		{
			get { return GetColumnValue<string>(Columns.SelfScore10); }
			set { SetColumnValue(Columns.SelfScore10, value); }
		}
		  
		[XmlAttribute("SelfScore11")]
		[Bindable(true)]
		public string SelfScore11 
		{
			get { return GetColumnValue<string>(Columns.SelfScore11); }
			set { SetColumnValue(Columns.SelfScore11, value); }
		}
		  
		[XmlAttribute("SelfScore12")]
		[Bindable(true)]
		public string SelfScore12 
		{
			get { return GetColumnValue<string>(Columns.SelfScore12); }
			set { SetColumnValue(Columns.SelfScore12, value); }
		}
		  
		[XmlAttribute("SelfScore13")]
		[Bindable(true)]
		public string SelfScore13 
		{
			get { return GetColumnValue<string>(Columns.SelfScore13); }
			set { SetColumnValue(Columns.SelfScore13, value); }
		}
		  
		[XmlAttribute("UpScore1")]
		[Bindable(true)]
		public string UpScore1 
		{
			get { return GetColumnValue<string>(Columns.UpScore1); }
			set { SetColumnValue(Columns.UpScore1, value); }
		}
		  
		[XmlAttribute("UpScore2")]
		[Bindable(true)]
		public string UpScore2 
		{
			get { return GetColumnValue<string>(Columns.UpScore2); }
			set { SetColumnValue(Columns.UpScore2, value); }
		}
		  
		[XmlAttribute("UpScore3")]
		[Bindable(true)]
		public string UpScore3 
		{
			get { return GetColumnValue<string>(Columns.UpScore3); }
			set { SetColumnValue(Columns.UpScore3, value); }
		}
		  
		[XmlAttribute("UpScore4")]
		[Bindable(true)]
		public string UpScore4 
		{
			get { return GetColumnValue<string>(Columns.UpScore4); }
			set { SetColumnValue(Columns.UpScore4, value); }
		}
		  
		[XmlAttribute("UpScore5")]
		[Bindable(true)]
		public string UpScore5 
		{
			get { return GetColumnValue<string>(Columns.UpScore5); }
			set { SetColumnValue(Columns.UpScore5, value); }
		}
		  
		[XmlAttribute("UpScore6")]
		[Bindable(true)]
		public string UpScore6 
		{
			get { return GetColumnValue<string>(Columns.UpScore6); }
			set { SetColumnValue(Columns.UpScore6, value); }
		}
		  
		[XmlAttribute("UpScore7")]
		[Bindable(true)]
		public string UpScore7 
		{
			get { return GetColumnValue<string>(Columns.UpScore7); }
			set { SetColumnValue(Columns.UpScore7, value); }
		}
		  
		[XmlAttribute("UpScore8")]
		[Bindable(true)]
		public string UpScore8 
		{
			get { return GetColumnValue<string>(Columns.UpScore8); }
			set { SetColumnValue(Columns.UpScore8, value); }
		}
		  
		[XmlAttribute("UpScore9")]
		[Bindable(true)]
		public string UpScore9 
		{
			get { return GetColumnValue<string>(Columns.UpScore9); }
			set { SetColumnValue(Columns.UpScore9, value); }
		}
		  
		[XmlAttribute("UpScore10")]
		[Bindable(true)]
		public string UpScore10 
		{
			get { return GetColumnValue<string>(Columns.UpScore10); }
			set { SetColumnValue(Columns.UpScore10, value); }
		}
		  
		[XmlAttribute("UpScore11")]
		[Bindable(true)]
		public string UpScore11 
		{
			get { return GetColumnValue<string>(Columns.UpScore11); }
			set { SetColumnValue(Columns.UpScore11, value); }
		}
		  
		[XmlAttribute("UpScore12")]
		[Bindable(true)]
		public string UpScore12 
		{
			get { return GetColumnValue<string>(Columns.UpScore12); }
			set { SetColumnValue(Columns.UpScore12, value); }
		}
		  
		[XmlAttribute("UpScore13")]
		[Bindable(true)]
		public string UpScore13 
		{
			get { return GetColumnValue<string>(Columns.UpScore13); }
			set { SetColumnValue(Columns.UpScore13, value); }
		}
		  
		[XmlAttribute("SectScore1")]
		[Bindable(true)]
		public string SectScore1 
		{
			get { return GetColumnValue<string>(Columns.SectScore1); }
			set { SetColumnValue(Columns.SectScore1, value); }
		}
		  
		[XmlAttribute("SectScore2")]
		[Bindable(true)]
		public string SectScore2 
		{
			get { return GetColumnValue<string>(Columns.SectScore2); }
			set { SetColumnValue(Columns.SectScore2, value); }
		}
		  
		[XmlAttribute("SectScore3")]
		[Bindable(true)]
		public string SectScore3 
		{
			get { return GetColumnValue<string>(Columns.SectScore3); }
			set { SetColumnValue(Columns.SectScore3, value); }
		}
		  
		[XmlAttribute("SectScore4")]
		[Bindable(true)]
		public string SectScore4 
		{
			get { return GetColumnValue<string>(Columns.SectScore4); }
			set { SetColumnValue(Columns.SectScore4, value); }
		}
		  
		[XmlAttribute("SectScore5")]
		[Bindable(true)]
		public string SectScore5 
		{
			get { return GetColumnValue<string>(Columns.SectScore5); }
			set { SetColumnValue(Columns.SectScore5, value); }
		}
		  
		[XmlAttribute("SectScore6")]
		[Bindable(true)]
		public string SectScore6 
		{
			get { return GetColumnValue<string>(Columns.SectScore6); }
			set { SetColumnValue(Columns.SectScore6, value); }
		}
		  
		[XmlAttribute("SectScore7")]
		[Bindable(true)]
		public string SectScore7 
		{
			get { return GetColumnValue<string>(Columns.SectScore7); }
			set { SetColumnValue(Columns.SectScore7, value); }
		}
		  
		[XmlAttribute("SectScore8")]
		[Bindable(true)]
		public string SectScore8 
		{
			get { return GetColumnValue<string>(Columns.SectScore8); }
			set { SetColumnValue(Columns.SectScore8, value); }
		}
		  
		[XmlAttribute("SectScore9")]
		[Bindable(true)]
		public string SectScore9 
		{
			get { return GetColumnValue<string>(Columns.SectScore9); }
			set { SetColumnValue(Columns.SectScore9, value); }
		}
		  
		[XmlAttribute("SectScore10")]
		[Bindable(true)]
		public string SectScore10 
		{
			get { return GetColumnValue<string>(Columns.SectScore10); }
			set { SetColumnValue(Columns.SectScore10, value); }
		}
		  
		[XmlAttribute("SectScore11")]
		[Bindable(true)]
		public string SectScore11 
		{
			get { return GetColumnValue<string>(Columns.SectScore11); }
			set { SetColumnValue(Columns.SectScore11, value); }
		}
		  
		[XmlAttribute("SectScore12")]
		[Bindable(true)]
		public string SectScore12 
		{
			get { return GetColumnValue<string>(Columns.SectScore12); }
			set { SetColumnValue(Columns.SectScore12, value); }
		}
		  
		[XmlAttribute("SectScore13")]
		[Bindable(true)]
		public string SectScore13 
		{
			get { return GetColumnValue<string>(Columns.SectScore13); }
			set { SetColumnValue(Columns.SectScore13, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varReason,string varAddMinusScore,string varTotalScore,string varUpView,int? varEvaluateLevelId,int? varYearId,int? varMonthId,string varDateSpan,int? varEmployeeId,int? varIsSubmit,string varSelfScore1,string varSelfScore2,string varSelfScore3,string varSelfScore4,string varSelfScore5,string varSelfScore6,string varSelfScore7,string varSelfScore8,string varSelfScore9,string varSelfScore10,string varSelfScore11,string varSelfScore12,string varSelfScore13,string varUpScore1,string varUpScore2,string varUpScore3,string varUpScore4,string varUpScore5,string varUpScore6,string varUpScore7,string varUpScore8,string varUpScore9,string varUpScore10,string varUpScore11,string varUpScore12,string varUpScore13,string varSectScore1,string varSectScore2,string varSectScore3,string varSectScore4,string varSectScore5,string varSectScore6,string varSectScore7,string varSectScore8,string varSectScore9,string varSectScore10,string varSectScore11,string varSectScore12,string varSectScore13)
		{
			TechMaScore item = new TechMaScore();
			
			item.Reason = varReason;
			
			item.AddMinusScore = varAddMinusScore;
			
			item.TotalScore = varTotalScore;
			
			item.UpView = varUpView;
			
			item.EvaluateLevelId = varEvaluateLevelId;
			
			item.YearId = varYearId;
			
			item.MonthId = varMonthId;
			
			item.DateSpan = varDateSpan;
			
			item.EmployeeId = varEmployeeId;
			
			item.IsSubmit = varIsSubmit;
			
			item.SelfScore1 = varSelfScore1;
			
			item.SelfScore2 = varSelfScore2;
			
			item.SelfScore3 = varSelfScore3;
			
			item.SelfScore4 = varSelfScore4;
			
			item.SelfScore5 = varSelfScore5;
			
			item.SelfScore6 = varSelfScore6;
			
			item.SelfScore7 = varSelfScore7;
			
			item.SelfScore8 = varSelfScore8;
			
			item.SelfScore9 = varSelfScore9;
			
			item.SelfScore10 = varSelfScore10;
			
			item.SelfScore11 = varSelfScore11;
			
			item.SelfScore12 = varSelfScore12;
			
			item.SelfScore13 = varSelfScore13;
			
			item.UpScore1 = varUpScore1;
			
			item.UpScore2 = varUpScore2;
			
			item.UpScore3 = varUpScore3;
			
			item.UpScore4 = varUpScore4;
			
			item.UpScore5 = varUpScore5;
			
			item.UpScore6 = varUpScore6;
			
			item.UpScore7 = varUpScore7;
			
			item.UpScore8 = varUpScore8;
			
			item.UpScore9 = varUpScore9;
			
			item.UpScore10 = varUpScore10;
			
			item.UpScore11 = varUpScore11;
			
			item.UpScore12 = varUpScore12;
			
			item.UpScore13 = varUpScore13;
			
			item.SectScore1 = varSectScore1;
			
			item.SectScore2 = varSectScore2;
			
			item.SectScore3 = varSectScore3;
			
			item.SectScore4 = varSectScore4;
			
			item.SectScore5 = varSectScore5;
			
			item.SectScore6 = varSectScore6;
			
			item.SectScore7 = varSectScore7;
			
			item.SectScore8 = varSectScore8;
			
			item.SectScore9 = varSectScore9;
			
			item.SectScore10 = varSectScore10;
			
			item.SectScore11 = varSectScore11;
			
			item.SectScore12 = varSectScore12;
			
			item.SectScore13 = varSectScore13;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varTechMaScoreId,string varReason,string varAddMinusScore,string varTotalScore,string varUpView,int? varEvaluateLevelId,int? varYearId,int? varMonthId,string varDateSpan,int? varEmployeeId,int? varIsSubmit,string varSelfScore1,string varSelfScore2,string varSelfScore3,string varSelfScore4,string varSelfScore5,string varSelfScore6,string varSelfScore7,string varSelfScore8,string varSelfScore9,string varSelfScore10,string varSelfScore11,string varSelfScore12,string varSelfScore13,string varUpScore1,string varUpScore2,string varUpScore3,string varUpScore4,string varUpScore5,string varUpScore6,string varUpScore7,string varUpScore8,string varUpScore9,string varUpScore10,string varUpScore11,string varUpScore12,string varUpScore13,string varSectScore1,string varSectScore2,string varSectScore3,string varSectScore4,string varSectScore5,string varSectScore6,string varSectScore7,string varSectScore8,string varSectScore9,string varSectScore10,string varSectScore11,string varSectScore12,string varSectScore13)
		{
			TechMaScore item = new TechMaScore();
			
				item.TechMaScoreId = varTechMaScoreId;
			
				item.Reason = varReason;
			
				item.AddMinusScore = varAddMinusScore;
			
				item.TotalScore = varTotalScore;
			
				item.UpView = varUpView;
			
				item.EvaluateLevelId = varEvaluateLevelId;
			
				item.YearId = varYearId;
			
				item.MonthId = varMonthId;
			
				item.DateSpan = varDateSpan;
			
				item.EmployeeId = varEmployeeId;
			
				item.IsSubmit = varIsSubmit;
			
				item.SelfScore1 = varSelfScore1;
			
				item.SelfScore2 = varSelfScore2;
			
				item.SelfScore3 = varSelfScore3;
			
				item.SelfScore4 = varSelfScore4;
			
				item.SelfScore5 = varSelfScore5;
			
				item.SelfScore6 = varSelfScore6;
			
				item.SelfScore7 = varSelfScore7;
			
				item.SelfScore8 = varSelfScore8;
			
				item.SelfScore9 = varSelfScore9;
			
				item.SelfScore10 = varSelfScore10;
			
				item.SelfScore11 = varSelfScore11;
			
				item.SelfScore12 = varSelfScore12;
			
				item.SelfScore13 = varSelfScore13;
			
				item.UpScore1 = varUpScore1;
			
				item.UpScore2 = varUpScore2;
			
				item.UpScore3 = varUpScore3;
			
				item.UpScore4 = varUpScore4;
			
				item.UpScore5 = varUpScore5;
			
				item.UpScore6 = varUpScore6;
			
				item.UpScore7 = varUpScore7;
			
				item.UpScore8 = varUpScore8;
			
				item.UpScore9 = varUpScore9;
			
				item.UpScore10 = varUpScore10;
			
				item.UpScore11 = varUpScore11;
			
				item.UpScore12 = varUpScore12;
			
				item.UpScore13 = varUpScore13;
			
				item.SectScore1 = varSectScore1;
			
				item.SectScore2 = varSectScore2;
			
				item.SectScore3 = varSectScore3;
			
				item.SectScore4 = varSectScore4;
			
				item.SectScore5 = varSectScore5;
			
				item.SectScore6 = varSectScore6;
			
				item.SectScore7 = varSectScore7;
			
				item.SectScore8 = varSectScore8;
			
				item.SectScore9 = varSectScore9;
			
				item.SectScore10 = varSectScore10;
			
				item.SectScore11 = varSectScore11;
			
				item.SectScore12 = varSectScore12;
			
				item.SectScore13 = varSectScore13;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn TechMaScoreIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ReasonColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn AddMinusScoreColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn TotalScoreColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn UpViewColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn EvaluateLevelIdColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn YearIdColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn MonthIdColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn DateSpanColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn EmployeeIdColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn IsSubmitColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn SelfScore1Column
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn SelfScore2Column
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn SelfScore3Column
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn SelfScore4Column
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn SelfScore5Column
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn SelfScore6Column
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn SelfScore7Column
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn SelfScore8Column
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn SelfScore9Column
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        public static TableSchema.TableColumn SelfScore10Column
        {
            get { return Schema.Columns[20]; }
        }
        
        
        
        public static TableSchema.TableColumn SelfScore11Column
        {
            get { return Schema.Columns[21]; }
        }
        
        
        
        public static TableSchema.TableColumn SelfScore12Column
        {
            get { return Schema.Columns[22]; }
        }
        
        
        
        public static TableSchema.TableColumn SelfScore13Column
        {
            get { return Schema.Columns[23]; }
        }
        
        
        
        public static TableSchema.TableColumn UpScore1Column
        {
            get { return Schema.Columns[24]; }
        }
        
        
        
        public static TableSchema.TableColumn UpScore2Column
        {
            get { return Schema.Columns[25]; }
        }
        
        
        
        public static TableSchema.TableColumn UpScore3Column
        {
            get { return Schema.Columns[26]; }
        }
        
        
        
        public static TableSchema.TableColumn UpScore4Column
        {
            get { return Schema.Columns[27]; }
        }
        
        
        
        public static TableSchema.TableColumn UpScore5Column
        {
            get { return Schema.Columns[28]; }
        }
        
        
        
        public static TableSchema.TableColumn UpScore6Column
        {
            get { return Schema.Columns[29]; }
        }
        
        
        
        public static TableSchema.TableColumn UpScore7Column
        {
            get { return Schema.Columns[30]; }
        }
        
        
        
        public static TableSchema.TableColumn UpScore8Column
        {
            get { return Schema.Columns[31]; }
        }
        
        
        
        public static TableSchema.TableColumn UpScore9Column
        {
            get { return Schema.Columns[32]; }
        }
        
        
        
        public static TableSchema.TableColumn UpScore10Column
        {
            get { return Schema.Columns[33]; }
        }
        
        
        
        public static TableSchema.TableColumn UpScore11Column
        {
            get { return Schema.Columns[34]; }
        }
        
        
        
        public static TableSchema.TableColumn UpScore12Column
        {
            get { return Schema.Columns[35]; }
        }
        
        
        
        public static TableSchema.TableColumn UpScore13Column
        {
            get { return Schema.Columns[36]; }
        }
        
        
        
        public static TableSchema.TableColumn SectScore1Column
        {
            get { return Schema.Columns[37]; }
        }
        
        
        
        public static TableSchema.TableColumn SectScore2Column
        {
            get { return Schema.Columns[38]; }
        }
        
        
        
        public static TableSchema.TableColumn SectScore3Column
        {
            get { return Schema.Columns[39]; }
        }
        
        
        
        public static TableSchema.TableColumn SectScore4Column
        {
            get { return Schema.Columns[40]; }
        }
        
        
        
        public static TableSchema.TableColumn SectScore5Column
        {
            get { return Schema.Columns[41]; }
        }
        
        
        
        public static TableSchema.TableColumn SectScore6Column
        {
            get { return Schema.Columns[42]; }
        }
        
        
        
        public static TableSchema.TableColumn SectScore7Column
        {
            get { return Schema.Columns[43]; }
        }
        
        
        
        public static TableSchema.TableColumn SectScore8Column
        {
            get { return Schema.Columns[44]; }
        }
        
        
        
        public static TableSchema.TableColumn SectScore9Column
        {
            get { return Schema.Columns[45]; }
        }
        
        
        
        public static TableSchema.TableColumn SectScore10Column
        {
            get { return Schema.Columns[46]; }
        }
        
        
        
        public static TableSchema.TableColumn SectScore11Column
        {
            get { return Schema.Columns[47]; }
        }
        
        
        
        public static TableSchema.TableColumn SectScore12Column
        {
            get { return Schema.Columns[48]; }
        }
        
        
        
        public static TableSchema.TableColumn SectScore13Column
        {
            get { return Schema.Columns[49]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string TechMaScoreId = @"TechMaScoreId";
			 public static string Reason = @"Reason";
			 public static string AddMinusScore = @"AddMinusScore";
			 public static string TotalScore = @"TotalScore";
			 public static string UpView = @"UpView";
			 public static string EvaluateLevelId = @"EvaluateLevelId";
			 public static string YearId = @"YearId";
			 public static string MonthId = @"MonthId";
			 public static string DateSpan = @"DateSpan";
			 public static string EmployeeId = @"EmployeeId";
			 public static string IsSubmit = @"IsSubmit";
			 public static string SelfScore1 = @"SelfScore1";
			 public static string SelfScore2 = @"SelfScore2";
			 public static string SelfScore3 = @"SelfScore3";
			 public static string SelfScore4 = @"SelfScore4";
			 public static string SelfScore5 = @"SelfScore5";
			 public static string SelfScore6 = @"SelfScore6";
			 public static string SelfScore7 = @"SelfScore7";
			 public static string SelfScore8 = @"SelfScore8";
			 public static string SelfScore9 = @"SelfScore9";
			 public static string SelfScore10 = @"SelfScore10";
			 public static string SelfScore11 = @"SelfScore11";
			 public static string SelfScore12 = @"SelfScore12";
			 public static string SelfScore13 = @"SelfScore13";
			 public static string UpScore1 = @"UpScore1";
			 public static string UpScore2 = @"UpScore2";
			 public static string UpScore3 = @"UpScore3";
			 public static string UpScore4 = @"UpScore4";
			 public static string UpScore5 = @"UpScore5";
			 public static string UpScore6 = @"UpScore6";
			 public static string UpScore7 = @"UpScore7";
			 public static string UpScore8 = @"UpScore8";
			 public static string UpScore9 = @"UpScore9";
			 public static string UpScore10 = @"UpScore10";
			 public static string UpScore11 = @"UpScore11";
			 public static string UpScore12 = @"UpScore12";
			 public static string UpScore13 = @"UpScore13";
			 public static string SectScore1 = @"SectScore1";
			 public static string SectScore2 = @"SectScore2";
			 public static string SectScore3 = @"SectScore3";
			 public static string SectScore4 = @"SectScore4";
			 public static string SectScore5 = @"SectScore5";
			 public static string SectScore6 = @"SectScore6";
			 public static string SectScore7 = @"SectScore7";
			 public static string SectScore8 = @"SectScore8";
			 public static string SectScore9 = @"SectScore9";
			 public static string SectScore10 = @"SectScore10";
			 public static string SectScore11 = @"SectScore11";
			 public static string SectScore12 = @"SectScore12";
			 public static string SectScore13 = @"SectScore13";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
