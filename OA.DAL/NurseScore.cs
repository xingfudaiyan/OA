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
	/// Strongly-typed collection for the NurseScore class.
	/// </summary>
    [Serializable]
	public partial class NurseScoreCollection : ActiveList<NurseScore, NurseScoreCollection>
	{	   
		public NurseScoreCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>NurseScoreCollection</returns>
		public NurseScoreCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                NurseScore o = this[i];
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
	/// This is an ActiveRecord class which wraps the NurseScore_tb table.
	/// </summary>
	[Serializable]
	public partial class NurseScore : ActiveRecord<NurseScore>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public NurseScore()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public NurseScore(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public NurseScore(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public NurseScore(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("NurseScore_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarNurseScoreId = new TableSchema.TableColumn(schema);
				colvarNurseScoreId.ColumnName = "NurseScoreId";
				colvarNurseScoreId.DataType = DbType.Int32;
				colvarNurseScoreId.MaxLength = 0;
				colvarNurseScoreId.AutoIncrement = true;
				colvarNurseScoreId.IsNullable = false;
				colvarNurseScoreId.IsPrimaryKey = true;
				colvarNurseScoreId.IsForeignKey = false;
				colvarNurseScoreId.IsReadOnly = false;
				colvarNurseScoreId.DefaultSetting = @"";
				colvarNurseScoreId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNurseScoreId);
				
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
				
				TableSchema.TableColumn colvarSelfns1 = new TableSchema.TableColumn(schema);
				colvarSelfns1.ColumnName = "Selfns1";
				colvarSelfns1.DataType = DbType.String;
				colvarSelfns1.MaxLength = 10;
				colvarSelfns1.AutoIncrement = false;
				colvarSelfns1.IsNullable = true;
				colvarSelfns1.IsPrimaryKey = false;
				colvarSelfns1.IsForeignKey = false;
				colvarSelfns1.IsReadOnly = false;
				colvarSelfns1.DefaultSetting = @"";
				colvarSelfns1.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfns1);
				
				TableSchema.TableColumn colvarSelfns2 = new TableSchema.TableColumn(schema);
				colvarSelfns2.ColumnName = "Selfns2";
				colvarSelfns2.DataType = DbType.String;
				colvarSelfns2.MaxLength = 10;
				colvarSelfns2.AutoIncrement = false;
				colvarSelfns2.IsNullable = true;
				colvarSelfns2.IsPrimaryKey = false;
				colvarSelfns2.IsForeignKey = false;
				colvarSelfns2.IsReadOnly = false;
				colvarSelfns2.DefaultSetting = @"";
				colvarSelfns2.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfns2);
				
				TableSchema.TableColumn colvarSelfns3 = new TableSchema.TableColumn(schema);
				colvarSelfns3.ColumnName = "Selfns3";
				colvarSelfns3.DataType = DbType.String;
				colvarSelfns3.MaxLength = 10;
				colvarSelfns3.AutoIncrement = false;
				colvarSelfns3.IsNullable = true;
				colvarSelfns3.IsPrimaryKey = false;
				colvarSelfns3.IsForeignKey = false;
				colvarSelfns3.IsReadOnly = false;
				colvarSelfns3.DefaultSetting = @"";
				colvarSelfns3.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfns3);
				
				TableSchema.TableColumn colvarSelfns4 = new TableSchema.TableColumn(schema);
				colvarSelfns4.ColumnName = "Selfns4";
				colvarSelfns4.DataType = DbType.String;
				colvarSelfns4.MaxLength = 10;
				colvarSelfns4.AutoIncrement = false;
				colvarSelfns4.IsNullable = true;
				colvarSelfns4.IsPrimaryKey = false;
				colvarSelfns4.IsForeignKey = false;
				colvarSelfns4.IsReadOnly = false;
				colvarSelfns4.DefaultSetting = @"";
				colvarSelfns4.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfns4);
				
				TableSchema.TableColumn colvarSelfns5 = new TableSchema.TableColumn(schema);
				colvarSelfns5.ColumnName = "Selfns5";
				colvarSelfns5.DataType = DbType.String;
				colvarSelfns5.MaxLength = 10;
				colvarSelfns5.AutoIncrement = false;
				colvarSelfns5.IsNullable = true;
				colvarSelfns5.IsPrimaryKey = false;
				colvarSelfns5.IsForeignKey = false;
				colvarSelfns5.IsReadOnly = false;
				colvarSelfns5.DefaultSetting = @"";
				colvarSelfns5.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfns5);
				
				TableSchema.TableColumn colvarSelfns6 = new TableSchema.TableColumn(schema);
				colvarSelfns6.ColumnName = "Selfns6";
				colvarSelfns6.DataType = DbType.String;
				colvarSelfns6.MaxLength = 10;
				colvarSelfns6.AutoIncrement = false;
				colvarSelfns6.IsNullable = true;
				colvarSelfns6.IsPrimaryKey = false;
				colvarSelfns6.IsForeignKey = false;
				colvarSelfns6.IsReadOnly = false;
				colvarSelfns6.DefaultSetting = @"";
				colvarSelfns6.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfns6);
				
				TableSchema.TableColumn colvarSelfns7 = new TableSchema.TableColumn(schema);
				colvarSelfns7.ColumnName = "Selfns7";
				colvarSelfns7.DataType = DbType.String;
				colvarSelfns7.MaxLength = 10;
				colvarSelfns7.AutoIncrement = false;
				colvarSelfns7.IsNullable = true;
				colvarSelfns7.IsPrimaryKey = false;
				colvarSelfns7.IsForeignKey = false;
				colvarSelfns7.IsReadOnly = false;
				colvarSelfns7.DefaultSetting = @"";
				colvarSelfns7.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfns7);
				
				TableSchema.TableColumn colvarSelfns8 = new TableSchema.TableColumn(schema);
				colvarSelfns8.ColumnName = "Selfns8";
				colvarSelfns8.DataType = DbType.String;
				colvarSelfns8.MaxLength = 10;
				colvarSelfns8.AutoIncrement = false;
				colvarSelfns8.IsNullable = true;
				colvarSelfns8.IsPrimaryKey = false;
				colvarSelfns8.IsForeignKey = false;
				colvarSelfns8.IsReadOnly = false;
				colvarSelfns8.DefaultSetting = @"";
				colvarSelfns8.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfns8);
				
				TableSchema.TableColumn colvarSelfns9 = new TableSchema.TableColumn(schema);
				colvarSelfns9.ColumnName = "Selfns9";
				colvarSelfns9.DataType = DbType.String;
				colvarSelfns9.MaxLength = 10;
				colvarSelfns9.AutoIncrement = false;
				colvarSelfns9.IsNullable = true;
				colvarSelfns9.IsPrimaryKey = false;
				colvarSelfns9.IsForeignKey = false;
				colvarSelfns9.IsReadOnly = false;
				colvarSelfns9.DefaultSetting = @"";
				colvarSelfns9.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfns9);
				
				TableSchema.TableColumn colvarSelfns10 = new TableSchema.TableColumn(schema);
				colvarSelfns10.ColumnName = "Selfns10";
				colvarSelfns10.DataType = DbType.String;
				colvarSelfns10.MaxLength = 10;
				colvarSelfns10.AutoIncrement = false;
				colvarSelfns10.IsNullable = true;
				colvarSelfns10.IsPrimaryKey = false;
				colvarSelfns10.IsForeignKey = false;
				colvarSelfns10.IsReadOnly = false;
				colvarSelfns10.DefaultSetting = @"";
				colvarSelfns10.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfns10);
				
				TableSchema.TableColumn colvarSelfns11 = new TableSchema.TableColumn(schema);
				colvarSelfns11.ColumnName = "Selfns11";
				colvarSelfns11.DataType = DbType.String;
				colvarSelfns11.MaxLength = 10;
				colvarSelfns11.AutoIncrement = false;
				colvarSelfns11.IsNullable = true;
				colvarSelfns11.IsPrimaryKey = false;
				colvarSelfns11.IsForeignKey = false;
				colvarSelfns11.IsReadOnly = false;
				colvarSelfns11.DefaultSetting = @"";
				colvarSelfns11.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfns11);
				
				TableSchema.TableColumn colvarSelfns12 = new TableSchema.TableColumn(schema);
				colvarSelfns12.ColumnName = "Selfns12";
				colvarSelfns12.DataType = DbType.String;
				colvarSelfns12.MaxLength = 10;
				colvarSelfns12.AutoIncrement = false;
				colvarSelfns12.IsNullable = true;
				colvarSelfns12.IsPrimaryKey = false;
				colvarSelfns12.IsForeignKey = false;
				colvarSelfns12.IsReadOnly = false;
				colvarSelfns12.DefaultSetting = @"";
				colvarSelfns12.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfns12);
				
				TableSchema.TableColumn colvarSelfns13 = new TableSchema.TableColumn(schema);
				colvarSelfns13.ColumnName = "Selfns13";
				colvarSelfns13.DataType = DbType.String;
				colvarSelfns13.MaxLength = 10;
				colvarSelfns13.AutoIncrement = false;
				colvarSelfns13.IsNullable = true;
				colvarSelfns13.IsPrimaryKey = false;
				colvarSelfns13.IsForeignKey = false;
				colvarSelfns13.IsReadOnly = false;
				colvarSelfns13.DefaultSetting = @"";
				colvarSelfns13.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfns13);
				
				TableSchema.TableColumn colvarSelfns14 = new TableSchema.TableColumn(schema);
				colvarSelfns14.ColumnName = "Selfns14";
				colvarSelfns14.DataType = DbType.String;
				colvarSelfns14.MaxLength = 10;
				colvarSelfns14.AutoIncrement = false;
				colvarSelfns14.IsNullable = true;
				colvarSelfns14.IsPrimaryKey = false;
				colvarSelfns14.IsForeignKey = false;
				colvarSelfns14.IsReadOnly = false;
				colvarSelfns14.DefaultSetting = @"";
				colvarSelfns14.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfns14);
				
				TableSchema.TableColumn colvarSelfns15 = new TableSchema.TableColumn(schema);
				colvarSelfns15.ColumnName = "Selfns15";
				colvarSelfns15.DataType = DbType.String;
				colvarSelfns15.MaxLength = 10;
				colvarSelfns15.AutoIncrement = false;
				colvarSelfns15.IsNullable = true;
				colvarSelfns15.IsPrimaryKey = false;
				colvarSelfns15.IsForeignKey = false;
				colvarSelfns15.IsReadOnly = false;
				colvarSelfns15.DefaultSetting = @"";
				colvarSelfns15.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfns15);
				
				TableSchema.TableColumn colvarSelfns16 = new TableSchema.TableColumn(schema);
				colvarSelfns16.ColumnName = "Selfns16";
				colvarSelfns16.DataType = DbType.String;
				colvarSelfns16.MaxLength = 10;
				colvarSelfns16.AutoIncrement = false;
				colvarSelfns16.IsNullable = true;
				colvarSelfns16.IsPrimaryKey = false;
				colvarSelfns16.IsForeignKey = false;
				colvarSelfns16.IsReadOnly = false;
				colvarSelfns16.DefaultSetting = @"";
				colvarSelfns16.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfns16);
				
				TableSchema.TableColumn colvarSelfns17 = new TableSchema.TableColumn(schema);
				colvarSelfns17.ColumnName = "Selfns17";
				colvarSelfns17.DataType = DbType.String;
				colvarSelfns17.MaxLength = 10;
				colvarSelfns17.AutoIncrement = false;
				colvarSelfns17.IsNullable = true;
				colvarSelfns17.IsPrimaryKey = false;
				colvarSelfns17.IsForeignKey = false;
				colvarSelfns17.IsReadOnly = false;
				colvarSelfns17.DefaultSetting = @"";
				colvarSelfns17.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfns17);
				
				TableSchema.TableColumn colvarSelfns18 = new TableSchema.TableColumn(schema);
				colvarSelfns18.ColumnName = "Selfns18";
				colvarSelfns18.DataType = DbType.String;
				colvarSelfns18.MaxLength = 10;
				colvarSelfns18.AutoIncrement = false;
				colvarSelfns18.IsNullable = true;
				colvarSelfns18.IsPrimaryKey = false;
				colvarSelfns18.IsForeignKey = false;
				colvarSelfns18.IsReadOnly = false;
				colvarSelfns18.DefaultSetting = @"";
				colvarSelfns18.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfns18);
				
				TableSchema.TableColumn colvarSelfns19 = new TableSchema.TableColumn(schema);
				colvarSelfns19.ColumnName = "Selfns19";
				colvarSelfns19.DataType = DbType.String;
				colvarSelfns19.MaxLength = 10;
				colvarSelfns19.AutoIncrement = false;
				colvarSelfns19.IsNullable = true;
				colvarSelfns19.IsPrimaryKey = false;
				colvarSelfns19.IsForeignKey = false;
				colvarSelfns19.IsReadOnly = false;
				colvarSelfns19.DefaultSetting = @"";
				colvarSelfns19.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfns19);
				
				TableSchema.TableColumn colvarSelfns20 = new TableSchema.TableColumn(schema);
				colvarSelfns20.ColumnName = "Selfns20";
				colvarSelfns20.DataType = DbType.String;
				colvarSelfns20.MaxLength = 10;
				colvarSelfns20.AutoIncrement = false;
				colvarSelfns20.IsNullable = true;
				colvarSelfns20.IsPrimaryKey = false;
				colvarSelfns20.IsForeignKey = false;
				colvarSelfns20.IsReadOnly = false;
				colvarSelfns20.DefaultSetting = @"";
				colvarSelfns20.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfns20);
				
				TableSchema.TableColumn colvarSelfns21 = new TableSchema.TableColumn(schema);
				colvarSelfns21.ColumnName = "Selfns21";
				colvarSelfns21.DataType = DbType.String;
				colvarSelfns21.MaxLength = 10;
				colvarSelfns21.AutoIncrement = false;
				colvarSelfns21.IsNullable = true;
				colvarSelfns21.IsPrimaryKey = false;
				colvarSelfns21.IsForeignKey = false;
				colvarSelfns21.IsReadOnly = false;
				colvarSelfns21.DefaultSetting = @"";
				colvarSelfns21.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfns21);
				
				TableSchema.TableColumn colvarSelfns22 = new TableSchema.TableColumn(schema);
				colvarSelfns22.ColumnName = "Selfns22";
				colvarSelfns22.DataType = DbType.String;
				colvarSelfns22.MaxLength = 10;
				colvarSelfns22.AutoIncrement = false;
				colvarSelfns22.IsNullable = true;
				colvarSelfns22.IsPrimaryKey = false;
				colvarSelfns22.IsForeignKey = false;
				colvarSelfns22.IsReadOnly = false;
				colvarSelfns22.DefaultSetting = @"";
				colvarSelfns22.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfns22);
				
				TableSchema.TableColumn colvarSelfns23 = new TableSchema.TableColumn(schema);
				colvarSelfns23.ColumnName = "Selfns23";
				colvarSelfns23.DataType = DbType.String;
				colvarSelfns23.MaxLength = 10;
				colvarSelfns23.AutoIncrement = false;
				colvarSelfns23.IsNullable = true;
				colvarSelfns23.IsPrimaryKey = false;
				colvarSelfns23.IsForeignKey = false;
				colvarSelfns23.IsReadOnly = false;
				colvarSelfns23.DefaultSetting = @"";
				colvarSelfns23.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfns23);
				
				TableSchema.TableColumn colvarUpns1 = new TableSchema.TableColumn(schema);
				colvarUpns1.ColumnName = "Upns1";
				colvarUpns1.DataType = DbType.String;
				colvarUpns1.MaxLength = 10;
				colvarUpns1.AutoIncrement = false;
				colvarUpns1.IsNullable = true;
				colvarUpns1.IsPrimaryKey = false;
				colvarUpns1.IsForeignKey = false;
				colvarUpns1.IsReadOnly = false;
				colvarUpns1.DefaultSetting = @"";
				colvarUpns1.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpns1);
				
				TableSchema.TableColumn colvarUpns2 = new TableSchema.TableColumn(schema);
				colvarUpns2.ColumnName = "Upns2";
				colvarUpns2.DataType = DbType.String;
				colvarUpns2.MaxLength = 10;
				colvarUpns2.AutoIncrement = false;
				colvarUpns2.IsNullable = true;
				colvarUpns2.IsPrimaryKey = false;
				colvarUpns2.IsForeignKey = false;
				colvarUpns2.IsReadOnly = false;
				colvarUpns2.DefaultSetting = @"";
				colvarUpns2.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpns2);
				
				TableSchema.TableColumn colvarUpns3 = new TableSchema.TableColumn(schema);
				colvarUpns3.ColumnName = "Upns3";
				colvarUpns3.DataType = DbType.String;
				colvarUpns3.MaxLength = 10;
				colvarUpns3.AutoIncrement = false;
				colvarUpns3.IsNullable = true;
				colvarUpns3.IsPrimaryKey = false;
				colvarUpns3.IsForeignKey = false;
				colvarUpns3.IsReadOnly = false;
				colvarUpns3.DefaultSetting = @"";
				colvarUpns3.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpns3);
				
				TableSchema.TableColumn colvarUpns4 = new TableSchema.TableColumn(schema);
				colvarUpns4.ColumnName = "Upns4";
				colvarUpns4.DataType = DbType.String;
				colvarUpns4.MaxLength = 10;
				colvarUpns4.AutoIncrement = false;
				colvarUpns4.IsNullable = true;
				colvarUpns4.IsPrimaryKey = false;
				colvarUpns4.IsForeignKey = false;
				colvarUpns4.IsReadOnly = false;
				colvarUpns4.DefaultSetting = @"";
				colvarUpns4.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpns4);
				
				TableSchema.TableColumn colvarUpns5 = new TableSchema.TableColumn(schema);
				colvarUpns5.ColumnName = "Upns5";
				colvarUpns5.DataType = DbType.String;
				colvarUpns5.MaxLength = 10;
				colvarUpns5.AutoIncrement = false;
				colvarUpns5.IsNullable = true;
				colvarUpns5.IsPrimaryKey = false;
				colvarUpns5.IsForeignKey = false;
				colvarUpns5.IsReadOnly = false;
				colvarUpns5.DefaultSetting = @"";
				colvarUpns5.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpns5);
				
				TableSchema.TableColumn colvarUpns6 = new TableSchema.TableColumn(schema);
				colvarUpns6.ColumnName = "Upns6";
				colvarUpns6.DataType = DbType.String;
				colvarUpns6.MaxLength = 10;
				colvarUpns6.AutoIncrement = false;
				colvarUpns6.IsNullable = true;
				colvarUpns6.IsPrimaryKey = false;
				colvarUpns6.IsForeignKey = false;
				colvarUpns6.IsReadOnly = false;
				colvarUpns6.DefaultSetting = @"";
				colvarUpns6.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpns6);
				
				TableSchema.TableColumn colvarUpns7 = new TableSchema.TableColumn(schema);
				colvarUpns7.ColumnName = "Upns7";
				colvarUpns7.DataType = DbType.String;
				colvarUpns7.MaxLength = 10;
				colvarUpns7.AutoIncrement = false;
				colvarUpns7.IsNullable = true;
				colvarUpns7.IsPrimaryKey = false;
				colvarUpns7.IsForeignKey = false;
				colvarUpns7.IsReadOnly = false;
				colvarUpns7.DefaultSetting = @"";
				colvarUpns7.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpns7);
				
				TableSchema.TableColumn colvarUpns8 = new TableSchema.TableColumn(schema);
				colvarUpns8.ColumnName = "Upns8";
				colvarUpns8.DataType = DbType.String;
				colvarUpns8.MaxLength = 10;
				colvarUpns8.AutoIncrement = false;
				colvarUpns8.IsNullable = true;
				colvarUpns8.IsPrimaryKey = false;
				colvarUpns8.IsForeignKey = false;
				colvarUpns8.IsReadOnly = false;
				colvarUpns8.DefaultSetting = @"";
				colvarUpns8.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpns8);
				
				TableSchema.TableColumn colvarUpns9 = new TableSchema.TableColumn(schema);
				colvarUpns9.ColumnName = "Upns9";
				colvarUpns9.DataType = DbType.String;
				colvarUpns9.MaxLength = 10;
				colvarUpns9.AutoIncrement = false;
				colvarUpns9.IsNullable = true;
				colvarUpns9.IsPrimaryKey = false;
				colvarUpns9.IsForeignKey = false;
				colvarUpns9.IsReadOnly = false;
				colvarUpns9.DefaultSetting = @"";
				colvarUpns9.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpns9);
				
				TableSchema.TableColumn colvarUpns10 = new TableSchema.TableColumn(schema);
				colvarUpns10.ColumnName = "Upns10";
				colvarUpns10.DataType = DbType.String;
				colvarUpns10.MaxLength = 10;
				colvarUpns10.AutoIncrement = false;
				colvarUpns10.IsNullable = true;
				colvarUpns10.IsPrimaryKey = false;
				colvarUpns10.IsForeignKey = false;
				colvarUpns10.IsReadOnly = false;
				colvarUpns10.DefaultSetting = @"";
				colvarUpns10.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpns10);
				
				TableSchema.TableColumn colvarUpns11 = new TableSchema.TableColumn(schema);
				colvarUpns11.ColumnName = "Upns11";
				colvarUpns11.DataType = DbType.String;
				colvarUpns11.MaxLength = 10;
				colvarUpns11.AutoIncrement = false;
				colvarUpns11.IsNullable = true;
				colvarUpns11.IsPrimaryKey = false;
				colvarUpns11.IsForeignKey = false;
				colvarUpns11.IsReadOnly = false;
				colvarUpns11.DefaultSetting = @"";
				colvarUpns11.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpns11);
				
				TableSchema.TableColumn colvarUpns12 = new TableSchema.TableColumn(schema);
				colvarUpns12.ColumnName = "Upns12";
				colvarUpns12.DataType = DbType.String;
				colvarUpns12.MaxLength = 10;
				colvarUpns12.AutoIncrement = false;
				colvarUpns12.IsNullable = true;
				colvarUpns12.IsPrimaryKey = false;
				colvarUpns12.IsForeignKey = false;
				colvarUpns12.IsReadOnly = false;
				colvarUpns12.DefaultSetting = @"";
				colvarUpns12.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpns12);
				
				TableSchema.TableColumn colvarUpns13 = new TableSchema.TableColumn(schema);
				colvarUpns13.ColumnName = "Upns13";
				colvarUpns13.DataType = DbType.String;
				colvarUpns13.MaxLength = 10;
				colvarUpns13.AutoIncrement = false;
				colvarUpns13.IsNullable = true;
				colvarUpns13.IsPrimaryKey = false;
				colvarUpns13.IsForeignKey = false;
				colvarUpns13.IsReadOnly = false;
				colvarUpns13.DefaultSetting = @"";
				colvarUpns13.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpns13);
				
				TableSchema.TableColumn colvarUpns14 = new TableSchema.TableColumn(schema);
				colvarUpns14.ColumnName = "Upns14";
				colvarUpns14.DataType = DbType.String;
				colvarUpns14.MaxLength = 10;
				colvarUpns14.AutoIncrement = false;
				colvarUpns14.IsNullable = true;
				colvarUpns14.IsPrimaryKey = false;
				colvarUpns14.IsForeignKey = false;
				colvarUpns14.IsReadOnly = false;
				colvarUpns14.DefaultSetting = @"";
				colvarUpns14.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpns14);
				
				TableSchema.TableColumn colvarUpns15 = new TableSchema.TableColumn(schema);
				colvarUpns15.ColumnName = "Upns15";
				colvarUpns15.DataType = DbType.String;
				colvarUpns15.MaxLength = 10;
				colvarUpns15.AutoIncrement = false;
				colvarUpns15.IsNullable = true;
				colvarUpns15.IsPrimaryKey = false;
				colvarUpns15.IsForeignKey = false;
				colvarUpns15.IsReadOnly = false;
				colvarUpns15.DefaultSetting = @"";
				colvarUpns15.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpns15);
				
				TableSchema.TableColumn colvarUpns16 = new TableSchema.TableColumn(schema);
				colvarUpns16.ColumnName = "Upns16";
				colvarUpns16.DataType = DbType.String;
				colvarUpns16.MaxLength = 10;
				colvarUpns16.AutoIncrement = false;
				colvarUpns16.IsNullable = true;
				colvarUpns16.IsPrimaryKey = false;
				colvarUpns16.IsForeignKey = false;
				colvarUpns16.IsReadOnly = false;
				colvarUpns16.DefaultSetting = @"";
				colvarUpns16.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpns16);
				
				TableSchema.TableColumn colvarUpns17 = new TableSchema.TableColumn(schema);
				colvarUpns17.ColumnName = "Upns17";
				colvarUpns17.DataType = DbType.String;
				colvarUpns17.MaxLength = 10;
				colvarUpns17.AutoIncrement = false;
				colvarUpns17.IsNullable = true;
				colvarUpns17.IsPrimaryKey = false;
				colvarUpns17.IsForeignKey = false;
				colvarUpns17.IsReadOnly = false;
				colvarUpns17.DefaultSetting = @"";
				colvarUpns17.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpns17);
				
				TableSchema.TableColumn colvarUpns18 = new TableSchema.TableColumn(schema);
				colvarUpns18.ColumnName = "Upns18";
				colvarUpns18.DataType = DbType.String;
				colvarUpns18.MaxLength = 10;
				colvarUpns18.AutoIncrement = false;
				colvarUpns18.IsNullable = true;
				colvarUpns18.IsPrimaryKey = false;
				colvarUpns18.IsForeignKey = false;
				colvarUpns18.IsReadOnly = false;
				colvarUpns18.DefaultSetting = @"";
				colvarUpns18.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpns18);
				
				TableSchema.TableColumn colvarUpns19 = new TableSchema.TableColumn(schema);
				colvarUpns19.ColumnName = "Upns19";
				colvarUpns19.DataType = DbType.String;
				colvarUpns19.MaxLength = 10;
				colvarUpns19.AutoIncrement = false;
				colvarUpns19.IsNullable = true;
				colvarUpns19.IsPrimaryKey = false;
				colvarUpns19.IsForeignKey = false;
				colvarUpns19.IsReadOnly = false;
				colvarUpns19.DefaultSetting = @"";
				colvarUpns19.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpns19);
				
				TableSchema.TableColumn colvarUpns20 = new TableSchema.TableColumn(schema);
				colvarUpns20.ColumnName = "Upns20";
				colvarUpns20.DataType = DbType.String;
				colvarUpns20.MaxLength = 10;
				colvarUpns20.AutoIncrement = false;
				colvarUpns20.IsNullable = true;
				colvarUpns20.IsPrimaryKey = false;
				colvarUpns20.IsForeignKey = false;
				colvarUpns20.IsReadOnly = false;
				colvarUpns20.DefaultSetting = @"";
				colvarUpns20.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpns20);
				
				TableSchema.TableColumn colvarUpns21 = new TableSchema.TableColumn(schema);
				colvarUpns21.ColumnName = "Upns21";
				colvarUpns21.DataType = DbType.String;
				colvarUpns21.MaxLength = 10;
				colvarUpns21.AutoIncrement = false;
				colvarUpns21.IsNullable = true;
				colvarUpns21.IsPrimaryKey = false;
				colvarUpns21.IsForeignKey = false;
				colvarUpns21.IsReadOnly = false;
				colvarUpns21.DefaultSetting = @"";
				colvarUpns21.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpns21);
				
				TableSchema.TableColumn colvarUpns22 = new TableSchema.TableColumn(schema);
				colvarUpns22.ColumnName = "Upns22";
				colvarUpns22.DataType = DbType.String;
				colvarUpns22.MaxLength = 10;
				colvarUpns22.AutoIncrement = false;
				colvarUpns22.IsNullable = true;
				colvarUpns22.IsPrimaryKey = false;
				colvarUpns22.IsForeignKey = false;
				colvarUpns22.IsReadOnly = false;
				colvarUpns22.DefaultSetting = @"";
				colvarUpns22.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpns22);
				
				TableSchema.TableColumn colvarUpns23 = new TableSchema.TableColumn(schema);
				colvarUpns23.ColumnName = "Upns23";
				colvarUpns23.DataType = DbType.String;
				colvarUpns23.MaxLength = 10;
				colvarUpns23.AutoIncrement = false;
				colvarUpns23.IsNullable = true;
				colvarUpns23.IsPrimaryKey = false;
				colvarUpns23.IsForeignKey = false;
				colvarUpns23.IsReadOnly = false;
				colvarUpns23.DefaultSetting = @"";
				colvarUpns23.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpns23);
				
				TableSchema.TableColumn colvarSecns1 = new TableSchema.TableColumn(schema);
				colvarSecns1.ColumnName = "Secns1";
				colvarSecns1.DataType = DbType.String;
				colvarSecns1.MaxLength = 10;
				colvarSecns1.AutoIncrement = false;
				colvarSecns1.IsNullable = true;
				colvarSecns1.IsPrimaryKey = false;
				colvarSecns1.IsForeignKey = false;
				colvarSecns1.IsReadOnly = false;
				colvarSecns1.DefaultSetting = @"";
				colvarSecns1.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecns1);
				
				TableSchema.TableColumn colvarSecns2 = new TableSchema.TableColumn(schema);
				colvarSecns2.ColumnName = "Secns2";
				colvarSecns2.DataType = DbType.String;
				colvarSecns2.MaxLength = 10;
				colvarSecns2.AutoIncrement = false;
				colvarSecns2.IsNullable = true;
				colvarSecns2.IsPrimaryKey = false;
				colvarSecns2.IsForeignKey = false;
				colvarSecns2.IsReadOnly = false;
				colvarSecns2.DefaultSetting = @"";
				colvarSecns2.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecns2);
				
				TableSchema.TableColumn colvarSecns3 = new TableSchema.TableColumn(schema);
				colvarSecns3.ColumnName = "Secns3";
				colvarSecns3.DataType = DbType.String;
				colvarSecns3.MaxLength = 10;
				colvarSecns3.AutoIncrement = false;
				colvarSecns3.IsNullable = true;
				colvarSecns3.IsPrimaryKey = false;
				colvarSecns3.IsForeignKey = false;
				colvarSecns3.IsReadOnly = false;
				colvarSecns3.DefaultSetting = @"";
				colvarSecns3.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecns3);
				
				TableSchema.TableColumn colvarSecns4 = new TableSchema.TableColumn(schema);
				colvarSecns4.ColumnName = "Secns4";
				colvarSecns4.DataType = DbType.String;
				colvarSecns4.MaxLength = 10;
				colvarSecns4.AutoIncrement = false;
				colvarSecns4.IsNullable = true;
				colvarSecns4.IsPrimaryKey = false;
				colvarSecns4.IsForeignKey = false;
				colvarSecns4.IsReadOnly = false;
				colvarSecns4.DefaultSetting = @"";
				colvarSecns4.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecns4);
				
				TableSchema.TableColumn colvarSecns5 = new TableSchema.TableColumn(schema);
				colvarSecns5.ColumnName = "Secns5";
				colvarSecns5.DataType = DbType.String;
				colvarSecns5.MaxLength = 10;
				colvarSecns5.AutoIncrement = false;
				colvarSecns5.IsNullable = true;
				colvarSecns5.IsPrimaryKey = false;
				colvarSecns5.IsForeignKey = false;
				colvarSecns5.IsReadOnly = false;
				colvarSecns5.DefaultSetting = @"";
				colvarSecns5.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecns5);
				
				TableSchema.TableColumn colvarSecns6 = new TableSchema.TableColumn(schema);
				colvarSecns6.ColumnName = "Secns6";
				colvarSecns6.DataType = DbType.String;
				colvarSecns6.MaxLength = 10;
				colvarSecns6.AutoIncrement = false;
				colvarSecns6.IsNullable = true;
				colvarSecns6.IsPrimaryKey = false;
				colvarSecns6.IsForeignKey = false;
				colvarSecns6.IsReadOnly = false;
				colvarSecns6.DefaultSetting = @"";
				colvarSecns6.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecns6);
				
				TableSchema.TableColumn colvarSecns7 = new TableSchema.TableColumn(schema);
				colvarSecns7.ColumnName = "Secns7";
				colvarSecns7.DataType = DbType.String;
				colvarSecns7.MaxLength = 10;
				colvarSecns7.AutoIncrement = false;
				colvarSecns7.IsNullable = true;
				colvarSecns7.IsPrimaryKey = false;
				colvarSecns7.IsForeignKey = false;
				colvarSecns7.IsReadOnly = false;
				colvarSecns7.DefaultSetting = @"";
				colvarSecns7.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecns7);
				
				TableSchema.TableColumn colvarSecns8 = new TableSchema.TableColumn(schema);
				colvarSecns8.ColumnName = "Secns8";
				colvarSecns8.DataType = DbType.String;
				colvarSecns8.MaxLength = 10;
				colvarSecns8.AutoIncrement = false;
				colvarSecns8.IsNullable = true;
				colvarSecns8.IsPrimaryKey = false;
				colvarSecns8.IsForeignKey = false;
				colvarSecns8.IsReadOnly = false;
				colvarSecns8.DefaultSetting = @"";
				colvarSecns8.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecns8);
				
				TableSchema.TableColumn colvarSecns9 = new TableSchema.TableColumn(schema);
				colvarSecns9.ColumnName = "Secns9";
				colvarSecns9.DataType = DbType.String;
				colvarSecns9.MaxLength = 10;
				colvarSecns9.AutoIncrement = false;
				colvarSecns9.IsNullable = true;
				colvarSecns9.IsPrimaryKey = false;
				colvarSecns9.IsForeignKey = false;
				colvarSecns9.IsReadOnly = false;
				colvarSecns9.DefaultSetting = @"";
				colvarSecns9.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecns9);
				
				TableSchema.TableColumn colvarSecns10 = new TableSchema.TableColumn(schema);
				colvarSecns10.ColumnName = "Secns10";
				colvarSecns10.DataType = DbType.String;
				colvarSecns10.MaxLength = 10;
				colvarSecns10.AutoIncrement = false;
				colvarSecns10.IsNullable = true;
				colvarSecns10.IsPrimaryKey = false;
				colvarSecns10.IsForeignKey = false;
				colvarSecns10.IsReadOnly = false;
				colvarSecns10.DefaultSetting = @"";
				colvarSecns10.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecns10);
				
				TableSchema.TableColumn colvarSecns11 = new TableSchema.TableColumn(schema);
				colvarSecns11.ColumnName = "Secns11";
				colvarSecns11.DataType = DbType.String;
				colvarSecns11.MaxLength = 10;
				colvarSecns11.AutoIncrement = false;
				colvarSecns11.IsNullable = true;
				colvarSecns11.IsPrimaryKey = false;
				colvarSecns11.IsForeignKey = false;
				colvarSecns11.IsReadOnly = false;
				colvarSecns11.DefaultSetting = @"";
				colvarSecns11.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecns11);
				
				TableSchema.TableColumn colvarSecns12 = new TableSchema.TableColumn(schema);
				colvarSecns12.ColumnName = "Secns12";
				colvarSecns12.DataType = DbType.String;
				colvarSecns12.MaxLength = 10;
				colvarSecns12.AutoIncrement = false;
				colvarSecns12.IsNullable = true;
				colvarSecns12.IsPrimaryKey = false;
				colvarSecns12.IsForeignKey = false;
				colvarSecns12.IsReadOnly = false;
				colvarSecns12.DefaultSetting = @"";
				colvarSecns12.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecns12);
				
				TableSchema.TableColumn colvarSecns13 = new TableSchema.TableColumn(schema);
				colvarSecns13.ColumnName = "Secns13";
				colvarSecns13.DataType = DbType.String;
				colvarSecns13.MaxLength = 10;
				colvarSecns13.AutoIncrement = false;
				colvarSecns13.IsNullable = true;
				colvarSecns13.IsPrimaryKey = false;
				colvarSecns13.IsForeignKey = false;
				colvarSecns13.IsReadOnly = false;
				colvarSecns13.DefaultSetting = @"";
				colvarSecns13.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecns13);
				
				TableSchema.TableColumn colvarSecns14 = new TableSchema.TableColumn(schema);
				colvarSecns14.ColumnName = "Secns14";
				colvarSecns14.DataType = DbType.String;
				colvarSecns14.MaxLength = 10;
				colvarSecns14.AutoIncrement = false;
				colvarSecns14.IsNullable = true;
				colvarSecns14.IsPrimaryKey = false;
				colvarSecns14.IsForeignKey = false;
				colvarSecns14.IsReadOnly = false;
				colvarSecns14.DefaultSetting = @"";
				colvarSecns14.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecns14);
				
				TableSchema.TableColumn colvarSecns15 = new TableSchema.TableColumn(schema);
				colvarSecns15.ColumnName = "Secns15";
				colvarSecns15.DataType = DbType.String;
				colvarSecns15.MaxLength = 10;
				colvarSecns15.AutoIncrement = false;
				colvarSecns15.IsNullable = true;
				colvarSecns15.IsPrimaryKey = false;
				colvarSecns15.IsForeignKey = false;
				colvarSecns15.IsReadOnly = false;
				colvarSecns15.DefaultSetting = @"";
				colvarSecns15.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecns15);
				
				TableSchema.TableColumn colvarSecns16 = new TableSchema.TableColumn(schema);
				colvarSecns16.ColumnName = "Secns16";
				colvarSecns16.DataType = DbType.String;
				colvarSecns16.MaxLength = 10;
				colvarSecns16.AutoIncrement = false;
				colvarSecns16.IsNullable = true;
				colvarSecns16.IsPrimaryKey = false;
				colvarSecns16.IsForeignKey = false;
				colvarSecns16.IsReadOnly = false;
				colvarSecns16.DefaultSetting = @"";
				colvarSecns16.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecns16);
				
				TableSchema.TableColumn colvarSecns17 = new TableSchema.TableColumn(schema);
				colvarSecns17.ColumnName = "Secns17";
				colvarSecns17.DataType = DbType.String;
				colvarSecns17.MaxLength = 10;
				colvarSecns17.AutoIncrement = false;
				colvarSecns17.IsNullable = true;
				colvarSecns17.IsPrimaryKey = false;
				colvarSecns17.IsForeignKey = false;
				colvarSecns17.IsReadOnly = false;
				colvarSecns17.DefaultSetting = @"";
				colvarSecns17.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecns17);
				
				TableSchema.TableColumn colvarSecns18 = new TableSchema.TableColumn(schema);
				colvarSecns18.ColumnName = "Secns18";
				colvarSecns18.DataType = DbType.String;
				colvarSecns18.MaxLength = 10;
				colvarSecns18.AutoIncrement = false;
				colvarSecns18.IsNullable = true;
				colvarSecns18.IsPrimaryKey = false;
				colvarSecns18.IsForeignKey = false;
				colvarSecns18.IsReadOnly = false;
				colvarSecns18.DefaultSetting = @"";
				colvarSecns18.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecns18);
				
				TableSchema.TableColumn colvarSecns19 = new TableSchema.TableColumn(schema);
				colvarSecns19.ColumnName = "Secns19";
				colvarSecns19.DataType = DbType.String;
				colvarSecns19.MaxLength = 10;
				colvarSecns19.AutoIncrement = false;
				colvarSecns19.IsNullable = true;
				colvarSecns19.IsPrimaryKey = false;
				colvarSecns19.IsForeignKey = false;
				colvarSecns19.IsReadOnly = false;
				colvarSecns19.DefaultSetting = @"";
				colvarSecns19.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecns19);
				
				TableSchema.TableColumn colvarSecns20 = new TableSchema.TableColumn(schema);
				colvarSecns20.ColumnName = "Secns20";
				colvarSecns20.DataType = DbType.String;
				colvarSecns20.MaxLength = 10;
				colvarSecns20.AutoIncrement = false;
				colvarSecns20.IsNullable = true;
				colvarSecns20.IsPrimaryKey = false;
				colvarSecns20.IsForeignKey = false;
				colvarSecns20.IsReadOnly = false;
				colvarSecns20.DefaultSetting = @"";
				colvarSecns20.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecns20);
				
				TableSchema.TableColumn colvarSecns21 = new TableSchema.TableColumn(schema);
				colvarSecns21.ColumnName = "Secns21";
				colvarSecns21.DataType = DbType.String;
				colvarSecns21.MaxLength = 10;
				colvarSecns21.AutoIncrement = false;
				colvarSecns21.IsNullable = true;
				colvarSecns21.IsPrimaryKey = false;
				colvarSecns21.IsForeignKey = false;
				colvarSecns21.IsReadOnly = false;
				colvarSecns21.DefaultSetting = @"";
				colvarSecns21.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecns21);
				
				TableSchema.TableColumn colvarSecns22 = new TableSchema.TableColumn(schema);
				colvarSecns22.ColumnName = "Secns22";
				colvarSecns22.DataType = DbType.String;
				colvarSecns22.MaxLength = 10;
				colvarSecns22.AutoIncrement = false;
				colvarSecns22.IsNullable = true;
				colvarSecns22.IsPrimaryKey = false;
				colvarSecns22.IsForeignKey = false;
				colvarSecns22.IsReadOnly = false;
				colvarSecns22.DefaultSetting = @"";
				colvarSecns22.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecns22);
				
				TableSchema.TableColumn colvarSecns23 = new TableSchema.TableColumn(schema);
				colvarSecns23.ColumnName = "Secns23";
				colvarSecns23.DataType = DbType.String;
				colvarSecns23.MaxLength = 10;
				colvarSecns23.AutoIncrement = false;
				colvarSecns23.IsNullable = true;
				colvarSecns23.IsPrimaryKey = false;
				colvarSecns23.IsForeignKey = false;
				colvarSecns23.IsReadOnly = false;
				colvarSecns23.DefaultSetting = @"";
				colvarSecns23.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecns23);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("NurseScore_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("NurseScoreId")]
		[Bindable(true)]
		public int NurseScoreId 
		{
			get { return GetColumnValue<int>(Columns.NurseScoreId); }
			set { SetColumnValue(Columns.NurseScoreId, value); }
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
		  
		[XmlAttribute("Selfns1")]
		[Bindable(true)]
		public string Selfns1 
		{
			get { return GetColumnValue<string>(Columns.Selfns1); }
			set { SetColumnValue(Columns.Selfns1, value); }
		}
		  
		[XmlAttribute("Selfns2")]
		[Bindable(true)]
		public string Selfns2 
		{
			get { return GetColumnValue<string>(Columns.Selfns2); }
			set { SetColumnValue(Columns.Selfns2, value); }
		}
		  
		[XmlAttribute("Selfns3")]
		[Bindable(true)]
		public string Selfns3 
		{
			get { return GetColumnValue<string>(Columns.Selfns3); }
			set { SetColumnValue(Columns.Selfns3, value); }
		}
		  
		[XmlAttribute("Selfns4")]
		[Bindable(true)]
		public string Selfns4 
		{
			get { return GetColumnValue<string>(Columns.Selfns4); }
			set { SetColumnValue(Columns.Selfns4, value); }
		}
		  
		[XmlAttribute("Selfns5")]
		[Bindable(true)]
		public string Selfns5 
		{
			get { return GetColumnValue<string>(Columns.Selfns5); }
			set { SetColumnValue(Columns.Selfns5, value); }
		}
		  
		[XmlAttribute("Selfns6")]
		[Bindable(true)]
		public string Selfns6 
		{
			get { return GetColumnValue<string>(Columns.Selfns6); }
			set { SetColumnValue(Columns.Selfns6, value); }
		}
		  
		[XmlAttribute("Selfns7")]
		[Bindable(true)]
		public string Selfns7 
		{
			get { return GetColumnValue<string>(Columns.Selfns7); }
			set { SetColumnValue(Columns.Selfns7, value); }
		}
		  
		[XmlAttribute("Selfns8")]
		[Bindable(true)]
		public string Selfns8 
		{
			get { return GetColumnValue<string>(Columns.Selfns8); }
			set { SetColumnValue(Columns.Selfns8, value); }
		}
		  
		[XmlAttribute("Selfns9")]
		[Bindable(true)]
		public string Selfns9 
		{
			get { return GetColumnValue<string>(Columns.Selfns9); }
			set { SetColumnValue(Columns.Selfns9, value); }
		}
		  
		[XmlAttribute("Selfns10")]
		[Bindable(true)]
		public string Selfns10 
		{
			get { return GetColumnValue<string>(Columns.Selfns10); }
			set { SetColumnValue(Columns.Selfns10, value); }
		}
		  
		[XmlAttribute("Selfns11")]
		[Bindable(true)]
		public string Selfns11 
		{
			get { return GetColumnValue<string>(Columns.Selfns11); }
			set { SetColumnValue(Columns.Selfns11, value); }
		}
		  
		[XmlAttribute("Selfns12")]
		[Bindable(true)]
		public string Selfns12 
		{
			get { return GetColumnValue<string>(Columns.Selfns12); }
			set { SetColumnValue(Columns.Selfns12, value); }
		}
		  
		[XmlAttribute("Selfns13")]
		[Bindable(true)]
		public string Selfns13 
		{
			get { return GetColumnValue<string>(Columns.Selfns13); }
			set { SetColumnValue(Columns.Selfns13, value); }
		}
		  
		[XmlAttribute("Selfns14")]
		[Bindable(true)]
		public string Selfns14 
		{
			get { return GetColumnValue<string>(Columns.Selfns14); }
			set { SetColumnValue(Columns.Selfns14, value); }
		}
		  
		[XmlAttribute("Selfns15")]
		[Bindable(true)]
		public string Selfns15 
		{
			get { return GetColumnValue<string>(Columns.Selfns15); }
			set { SetColumnValue(Columns.Selfns15, value); }
		}
		  
		[XmlAttribute("Selfns16")]
		[Bindable(true)]
		public string Selfns16 
		{
			get { return GetColumnValue<string>(Columns.Selfns16); }
			set { SetColumnValue(Columns.Selfns16, value); }
		}
		  
		[XmlAttribute("Selfns17")]
		[Bindable(true)]
		public string Selfns17 
		{
			get { return GetColumnValue<string>(Columns.Selfns17); }
			set { SetColumnValue(Columns.Selfns17, value); }
		}
		  
		[XmlAttribute("Selfns18")]
		[Bindable(true)]
		public string Selfns18 
		{
			get { return GetColumnValue<string>(Columns.Selfns18); }
			set { SetColumnValue(Columns.Selfns18, value); }
		}
		  
		[XmlAttribute("Selfns19")]
		[Bindable(true)]
		public string Selfns19 
		{
			get { return GetColumnValue<string>(Columns.Selfns19); }
			set { SetColumnValue(Columns.Selfns19, value); }
		}
		  
		[XmlAttribute("Selfns20")]
		[Bindable(true)]
		public string Selfns20 
		{
			get { return GetColumnValue<string>(Columns.Selfns20); }
			set { SetColumnValue(Columns.Selfns20, value); }
		}
		  
		[XmlAttribute("Selfns21")]
		[Bindable(true)]
		public string Selfns21 
		{
			get { return GetColumnValue<string>(Columns.Selfns21); }
			set { SetColumnValue(Columns.Selfns21, value); }
		}
		  
		[XmlAttribute("Selfns22")]
		[Bindable(true)]
		public string Selfns22 
		{
			get { return GetColumnValue<string>(Columns.Selfns22); }
			set { SetColumnValue(Columns.Selfns22, value); }
		}
		  
		[XmlAttribute("Selfns23")]
		[Bindable(true)]
		public string Selfns23 
		{
			get { return GetColumnValue<string>(Columns.Selfns23); }
			set { SetColumnValue(Columns.Selfns23, value); }
		}
		  
		[XmlAttribute("Upns1")]
		[Bindable(true)]
		public string Upns1 
		{
			get { return GetColumnValue<string>(Columns.Upns1); }
			set { SetColumnValue(Columns.Upns1, value); }
		}
		  
		[XmlAttribute("Upns2")]
		[Bindable(true)]
		public string Upns2 
		{
			get { return GetColumnValue<string>(Columns.Upns2); }
			set { SetColumnValue(Columns.Upns2, value); }
		}
		  
		[XmlAttribute("Upns3")]
		[Bindable(true)]
		public string Upns3 
		{
			get { return GetColumnValue<string>(Columns.Upns3); }
			set { SetColumnValue(Columns.Upns3, value); }
		}
		  
		[XmlAttribute("Upns4")]
		[Bindable(true)]
		public string Upns4 
		{
			get { return GetColumnValue<string>(Columns.Upns4); }
			set { SetColumnValue(Columns.Upns4, value); }
		}
		  
		[XmlAttribute("Upns5")]
		[Bindable(true)]
		public string Upns5 
		{
			get { return GetColumnValue<string>(Columns.Upns5); }
			set { SetColumnValue(Columns.Upns5, value); }
		}
		  
		[XmlAttribute("Upns6")]
		[Bindable(true)]
		public string Upns6 
		{
			get { return GetColumnValue<string>(Columns.Upns6); }
			set { SetColumnValue(Columns.Upns6, value); }
		}
		  
		[XmlAttribute("Upns7")]
		[Bindable(true)]
		public string Upns7 
		{
			get { return GetColumnValue<string>(Columns.Upns7); }
			set { SetColumnValue(Columns.Upns7, value); }
		}
		  
		[XmlAttribute("Upns8")]
		[Bindable(true)]
		public string Upns8 
		{
			get { return GetColumnValue<string>(Columns.Upns8); }
			set { SetColumnValue(Columns.Upns8, value); }
		}
		  
		[XmlAttribute("Upns9")]
		[Bindable(true)]
		public string Upns9 
		{
			get { return GetColumnValue<string>(Columns.Upns9); }
			set { SetColumnValue(Columns.Upns9, value); }
		}
		  
		[XmlAttribute("Upns10")]
		[Bindable(true)]
		public string Upns10 
		{
			get { return GetColumnValue<string>(Columns.Upns10); }
			set { SetColumnValue(Columns.Upns10, value); }
		}
		  
		[XmlAttribute("Upns11")]
		[Bindable(true)]
		public string Upns11 
		{
			get { return GetColumnValue<string>(Columns.Upns11); }
			set { SetColumnValue(Columns.Upns11, value); }
		}
		  
		[XmlAttribute("Upns12")]
		[Bindable(true)]
		public string Upns12 
		{
			get { return GetColumnValue<string>(Columns.Upns12); }
			set { SetColumnValue(Columns.Upns12, value); }
		}
		  
		[XmlAttribute("Upns13")]
		[Bindable(true)]
		public string Upns13 
		{
			get { return GetColumnValue<string>(Columns.Upns13); }
			set { SetColumnValue(Columns.Upns13, value); }
		}
		  
		[XmlAttribute("Upns14")]
		[Bindable(true)]
		public string Upns14 
		{
			get { return GetColumnValue<string>(Columns.Upns14); }
			set { SetColumnValue(Columns.Upns14, value); }
		}
		  
		[XmlAttribute("Upns15")]
		[Bindable(true)]
		public string Upns15 
		{
			get { return GetColumnValue<string>(Columns.Upns15); }
			set { SetColumnValue(Columns.Upns15, value); }
		}
		  
		[XmlAttribute("Upns16")]
		[Bindable(true)]
		public string Upns16 
		{
			get { return GetColumnValue<string>(Columns.Upns16); }
			set { SetColumnValue(Columns.Upns16, value); }
		}
		  
		[XmlAttribute("Upns17")]
		[Bindable(true)]
		public string Upns17 
		{
			get { return GetColumnValue<string>(Columns.Upns17); }
			set { SetColumnValue(Columns.Upns17, value); }
		}
		  
		[XmlAttribute("Upns18")]
		[Bindable(true)]
		public string Upns18 
		{
			get { return GetColumnValue<string>(Columns.Upns18); }
			set { SetColumnValue(Columns.Upns18, value); }
		}
		  
		[XmlAttribute("Upns19")]
		[Bindable(true)]
		public string Upns19 
		{
			get { return GetColumnValue<string>(Columns.Upns19); }
			set { SetColumnValue(Columns.Upns19, value); }
		}
		  
		[XmlAttribute("Upns20")]
		[Bindable(true)]
		public string Upns20 
		{
			get { return GetColumnValue<string>(Columns.Upns20); }
			set { SetColumnValue(Columns.Upns20, value); }
		}
		  
		[XmlAttribute("Upns21")]
		[Bindable(true)]
		public string Upns21 
		{
			get { return GetColumnValue<string>(Columns.Upns21); }
			set { SetColumnValue(Columns.Upns21, value); }
		}
		  
		[XmlAttribute("Upns22")]
		[Bindable(true)]
		public string Upns22 
		{
			get { return GetColumnValue<string>(Columns.Upns22); }
			set { SetColumnValue(Columns.Upns22, value); }
		}
		  
		[XmlAttribute("Upns23")]
		[Bindable(true)]
		public string Upns23 
		{
			get { return GetColumnValue<string>(Columns.Upns23); }
			set { SetColumnValue(Columns.Upns23, value); }
		}
		  
		[XmlAttribute("Secns1")]
		[Bindable(true)]
		public string Secns1 
		{
			get { return GetColumnValue<string>(Columns.Secns1); }
			set { SetColumnValue(Columns.Secns1, value); }
		}
		  
		[XmlAttribute("Secns2")]
		[Bindable(true)]
		public string Secns2 
		{
			get { return GetColumnValue<string>(Columns.Secns2); }
			set { SetColumnValue(Columns.Secns2, value); }
		}
		  
		[XmlAttribute("Secns3")]
		[Bindable(true)]
		public string Secns3 
		{
			get { return GetColumnValue<string>(Columns.Secns3); }
			set { SetColumnValue(Columns.Secns3, value); }
		}
		  
		[XmlAttribute("Secns4")]
		[Bindable(true)]
		public string Secns4 
		{
			get { return GetColumnValue<string>(Columns.Secns4); }
			set { SetColumnValue(Columns.Secns4, value); }
		}
		  
		[XmlAttribute("Secns5")]
		[Bindable(true)]
		public string Secns5 
		{
			get { return GetColumnValue<string>(Columns.Secns5); }
			set { SetColumnValue(Columns.Secns5, value); }
		}
		  
		[XmlAttribute("Secns6")]
		[Bindable(true)]
		public string Secns6 
		{
			get { return GetColumnValue<string>(Columns.Secns6); }
			set { SetColumnValue(Columns.Secns6, value); }
		}
		  
		[XmlAttribute("Secns7")]
		[Bindable(true)]
		public string Secns7 
		{
			get { return GetColumnValue<string>(Columns.Secns7); }
			set { SetColumnValue(Columns.Secns7, value); }
		}
		  
		[XmlAttribute("Secns8")]
		[Bindable(true)]
		public string Secns8 
		{
			get { return GetColumnValue<string>(Columns.Secns8); }
			set { SetColumnValue(Columns.Secns8, value); }
		}
		  
		[XmlAttribute("Secns9")]
		[Bindable(true)]
		public string Secns9 
		{
			get { return GetColumnValue<string>(Columns.Secns9); }
			set { SetColumnValue(Columns.Secns9, value); }
		}
		  
		[XmlAttribute("Secns10")]
		[Bindable(true)]
		public string Secns10 
		{
			get { return GetColumnValue<string>(Columns.Secns10); }
			set { SetColumnValue(Columns.Secns10, value); }
		}
		  
		[XmlAttribute("Secns11")]
		[Bindable(true)]
		public string Secns11 
		{
			get { return GetColumnValue<string>(Columns.Secns11); }
			set { SetColumnValue(Columns.Secns11, value); }
		}
		  
		[XmlAttribute("Secns12")]
		[Bindable(true)]
		public string Secns12 
		{
			get { return GetColumnValue<string>(Columns.Secns12); }
			set { SetColumnValue(Columns.Secns12, value); }
		}
		  
		[XmlAttribute("Secns13")]
		[Bindable(true)]
		public string Secns13 
		{
			get { return GetColumnValue<string>(Columns.Secns13); }
			set { SetColumnValue(Columns.Secns13, value); }
		}
		  
		[XmlAttribute("Secns14")]
		[Bindable(true)]
		public string Secns14 
		{
			get { return GetColumnValue<string>(Columns.Secns14); }
			set { SetColumnValue(Columns.Secns14, value); }
		}
		  
		[XmlAttribute("Secns15")]
		[Bindable(true)]
		public string Secns15 
		{
			get { return GetColumnValue<string>(Columns.Secns15); }
			set { SetColumnValue(Columns.Secns15, value); }
		}
		  
		[XmlAttribute("Secns16")]
		[Bindable(true)]
		public string Secns16 
		{
			get { return GetColumnValue<string>(Columns.Secns16); }
			set { SetColumnValue(Columns.Secns16, value); }
		}
		  
		[XmlAttribute("Secns17")]
		[Bindable(true)]
		public string Secns17 
		{
			get { return GetColumnValue<string>(Columns.Secns17); }
			set { SetColumnValue(Columns.Secns17, value); }
		}
		  
		[XmlAttribute("Secns18")]
		[Bindable(true)]
		public string Secns18 
		{
			get { return GetColumnValue<string>(Columns.Secns18); }
			set { SetColumnValue(Columns.Secns18, value); }
		}
		  
		[XmlAttribute("Secns19")]
		[Bindable(true)]
		public string Secns19 
		{
			get { return GetColumnValue<string>(Columns.Secns19); }
			set { SetColumnValue(Columns.Secns19, value); }
		}
		  
		[XmlAttribute("Secns20")]
		[Bindable(true)]
		public string Secns20 
		{
			get { return GetColumnValue<string>(Columns.Secns20); }
			set { SetColumnValue(Columns.Secns20, value); }
		}
		  
		[XmlAttribute("Secns21")]
		[Bindable(true)]
		public string Secns21 
		{
			get { return GetColumnValue<string>(Columns.Secns21); }
			set { SetColumnValue(Columns.Secns21, value); }
		}
		  
		[XmlAttribute("Secns22")]
		[Bindable(true)]
		public string Secns22 
		{
			get { return GetColumnValue<string>(Columns.Secns22); }
			set { SetColumnValue(Columns.Secns22, value); }
		}
		  
		[XmlAttribute("Secns23")]
		[Bindable(true)]
		public string Secns23 
		{
			get { return GetColumnValue<string>(Columns.Secns23); }
			set { SetColumnValue(Columns.Secns23, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varDateSpan,int? varEvaluateLevelId,string varTotalScore,string varUpViews,int? varYearId,int? varMonthId,int? varEmployeeId,int? varIsSubmit,string varSelfns1,string varSelfns2,string varSelfns3,string varSelfns4,string varSelfns5,string varSelfns6,string varSelfns7,string varSelfns8,string varSelfns9,string varSelfns10,string varSelfns11,string varSelfns12,string varSelfns13,string varSelfns14,string varSelfns15,string varSelfns16,string varSelfns17,string varSelfns18,string varSelfns19,string varSelfns20,string varSelfns21,string varSelfns22,string varSelfns23,string varUpns1,string varUpns2,string varUpns3,string varUpns4,string varUpns5,string varUpns6,string varUpns7,string varUpns8,string varUpns9,string varUpns10,string varUpns11,string varUpns12,string varUpns13,string varUpns14,string varUpns15,string varUpns16,string varUpns17,string varUpns18,string varUpns19,string varUpns20,string varUpns21,string varUpns22,string varUpns23,string varSecns1,string varSecns2,string varSecns3,string varSecns4,string varSecns5,string varSecns6,string varSecns7,string varSecns8,string varSecns9,string varSecns10,string varSecns11,string varSecns12,string varSecns13,string varSecns14,string varSecns15,string varSecns16,string varSecns17,string varSecns18,string varSecns19,string varSecns20,string varSecns21,string varSecns22,string varSecns23)
		{
			NurseScore item = new NurseScore();
			
			item.DateSpan = varDateSpan;
			
			item.EvaluateLevelId = varEvaluateLevelId;
			
			item.TotalScore = varTotalScore;
			
			item.UpViews = varUpViews;
			
			item.YearId = varYearId;
			
			item.MonthId = varMonthId;
			
			item.EmployeeId = varEmployeeId;
			
			item.IsSubmit = varIsSubmit;
			
			item.Selfns1 = varSelfns1;
			
			item.Selfns2 = varSelfns2;
			
			item.Selfns3 = varSelfns3;
			
			item.Selfns4 = varSelfns4;
			
			item.Selfns5 = varSelfns5;
			
			item.Selfns6 = varSelfns6;
			
			item.Selfns7 = varSelfns7;
			
			item.Selfns8 = varSelfns8;
			
			item.Selfns9 = varSelfns9;
			
			item.Selfns10 = varSelfns10;
			
			item.Selfns11 = varSelfns11;
			
			item.Selfns12 = varSelfns12;
			
			item.Selfns13 = varSelfns13;
			
			item.Selfns14 = varSelfns14;
			
			item.Selfns15 = varSelfns15;
			
			item.Selfns16 = varSelfns16;
			
			item.Selfns17 = varSelfns17;
			
			item.Selfns18 = varSelfns18;
			
			item.Selfns19 = varSelfns19;
			
			item.Selfns20 = varSelfns20;
			
			item.Selfns21 = varSelfns21;
			
			item.Selfns22 = varSelfns22;
			
			item.Selfns23 = varSelfns23;
			
			item.Upns1 = varUpns1;
			
			item.Upns2 = varUpns2;
			
			item.Upns3 = varUpns3;
			
			item.Upns4 = varUpns4;
			
			item.Upns5 = varUpns5;
			
			item.Upns6 = varUpns6;
			
			item.Upns7 = varUpns7;
			
			item.Upns8 = varUpns8;
			
			item.Upns9 = varUpns9;
			
			item.Upns10 = varUpns10;
			
			item.Upns11 = varUpns11;
			
			item.Upns12 = varUpns12;
			
			item.Upns13 = varUpns13;
			
			item.Upns14 = varUpns14;
			
			item.Upns15 = varUpns15;
			
			item.Upns16 = varUpns16;
			
			item.Upns17 = varUpns17;
			
			item.Upns18 = varUpns18;
			
			item.Upns19 = varUpns19;
			
			item.Upns20 = varUpns20;
			
			item.Upns21 = varUpns21;
			
			item.Upns22 = varUpns22;
			
			item.Upns23 = varUpns23;
			
			item.Secns1 = varSecns1;
			
			item.Secns2 = varSecns2;
			
			item.Secns3 = varSecns3;
			
			item.Secns4 = varSecns4;
			
			item.Secns5 = varSecns5;
			
			item.Secns6 = varSecns6;
			
			item.Secns7 = varSecns7;
			
			item.Secns8 = varSecns8;
			
			item.Secns9 = varSecns9;
			
			item.Secns10 = varSecns10;
			
			item.Secns11 = varSecns11;
			
			item.Secns12 = varSecns12;
			
			item.Secns13 = varSecns13;
			
			item.Secns14 = varSecns14;
			
			item.Secns15 = varSecns15;
			
			item.Secns16 = varSecns16;
			
			item.Secns17 = varSecns17;
			
			item.Secns18 = varSecns18;
			
			item.Secns19 = varSecns19;
			
			item.Secns20 = varSecns20;
			
			item.Secns21 = varSecns21;
			
			item.Secns22 = varSecns22;
			
			item.Secns23 = varSecns23;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varNurseScoreId,string varDateSpan,int? varEvaluateLevelId,string varTotalScore,string varUpViews,int? varYearId,int? varMonthId,int? varEmployeeId,int? varIsSubmit,string varSelfns1,string varSelfns2,string varSelfns3,string varSelfns4,string varSelfns5,string varSelfns6,string varSelfns7,string varSelfns8,string varSelfns9,string varSelfns10,string varSelfns11,string varSelfns12,string varSelfns13,string varSelfns14,string varSelfns15,string varSelfns16,string varSelfns17,string varSelfns18,string varSelfns19,string varSelfns20,string varSelfns21,string varSelfns22,string varSelfns23,string varUpns1,string varUpns2,string varUpns3,string varUpns4,string varUpns5,string varUpns6,string varUpns7,string varUpns8,string varUpns9,string varUpns10,string varUpns11,string varUpns12,string varUpns13,string varUpns14,string varUpns15,string varUpns16,string varUpns17,string varUpns18,string varUpns19,string varUpns20,string varUpns21,string varUpns22,string varUpns23,string varSecns1,string varSecns2,string varSecns3,string varSecns4,string varSecns5,string varSecns6,string varSecns7,string varSecns8,string varSecns9,string varSecns10,string varSecns11,string varSecns12,string varSecns13,string varSecns14,string varSecns15,string varSecns16,string varSecns17,string varSecns18,string varSecns19,string varSecns20,string varSecns21,string varSecns22,string varSecns23)
		{
			NurseScore item = new NurseScore();
			
				item.NurseScoreId = varNurseScoreId;
			
				item.DateSpan = varDateSpan;
			
				item.EvaluateLevelId = varEvaluateLevelId;
			
				item.TotalScore = varTotalScore;
			
				item.UpViews = varUpViews;
			
				item.YearId = varYearId;
			
				item.MonthId = varMonthId;
			
				item.EmployeeId = varEmployeeId;
			
				item.IsSubmit = varIsSubmit;
			
				item.Selfns1 = varSelfns1;
			
				item.Selfns2 = varSelfns2;
			
				item.Selfns3 = varSelfns3;
			
				item.Selfns4 = varSelfns4;
			
				item.Selfns5 = varSelfns5;
			
				item.Selfns6 = varSelfns6;
			
				item.Selfns7 = varSelfns7;
			
				item.Selfns8 = varSelfns8;
			
				item.Selfns9 = varSelfns9;
			
				item.Selfns10 = varSelfns10;
			
				item.Selfns11 = varSelfns11;
			
				item.Selfns12 = varSelfns12;
			
				item.Selfns13 = varSelfns13;
			
				item.Selfns14 = varSelfns14;
			
				item.Selfns15 = varSelfns15;
			
				item.Selfns16 = varSelfns16;
			
				item.Selfns17 = varSelfns17;
			
				item.Selfns18 = varSelfns18;
			
				item.Selfns19 = varSelfns19;
			
				item.Selfns20 = varSelfns20;
			
				item.Selfns21 = varSelfns21;
			
				item.Selfns22 = varSelfns22;
			
				item.Selfns23 = varSelfns23;
			
				item.Upns1 = varUpns1;
			
				item.Upns2 = varUpns2;
			
				item.Upns3 = varUpns3;
			
				item.Upns4 = varUpns4;
			
				item.Upns5 = varUpns5;
			
				item.Upns6 = varUpns6;
			
				item.Upns7 = varUpns7;
			
				item.Upns8 = varUpns8;
			
				item.Upns9 = varUpns9;
			
				item.Upns10 = varUpns10;
			
				item.Upns11 = varUpns11;
			
				item.Upns12 = varUpns12;
			
				item.Upns13 = varUpns13;
			
				item.Upns14 = varUpns14;
			
				item.Upns15 = varUpns15;
			
				item.Upns16 = varUpns16;
			
				item.Upns17 = varUpns17;
			
				item.Upns18 = varUpns18;
			
				item.Upns19 = varUpns19;
			
				item.Upns20 = varUpns20;
			
				item.Upns21 = varUpns21;
			
				item.Upns22 = varUpns22;
			
				item.Upns23 = varUpns23;
			
				item.Secns1 = varSecns1;
			
				item.Secns2 = varSecns2;
			
				item.Secns3 = varSecns3;
			
				item.Secns4 = varSecns4;
			
				item.Secns5 = varSecns5;
			
				item.Secns6 = varSecns6;
			
				item.Secns7 = varSecns7;
			
				item.Secns8 = varSecns8;
			
				item.Secns9 = varSecns9;
			
				item.Secns10 = varSecns10;
			
				item.Secns11 = varSecns11;
			
				item.Secns12 = varSecns12;
			
				item.Secns13 = varSecns13;
			
				item.Secns14 = varSecns14;
			
				item.Secns15 = varSecns15;
			
				item.Secns16 = varSecns16;
			
				item.Secns17 = varSecns17;
			
				item.Secns18 = varSecns18;
			
				item.Secns19 = varSecns19;
			
				item.Secns20 = varSecns20;
			
				item.Secns21 = varSecns21;
			
				item.Secns22 = varSecns22;
			
				item.Secns23 = varSecns23;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn NurseScoreIdColumn
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
        
        
        
        public static TableSchema.TableColumn Selfns1Column
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfns2Column
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfns3Column
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfns4Column
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfns5Column
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfns6Column
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfns7Column
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfns8Column
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfns9Column
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfns10Column
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfns11Column
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfns12Column
        {
            get { return Schema.Columns[20]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfns13Column
        {
            get { return Schema.Columns[21]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfns14Column
        {
            get { return Schema.Columns[22]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfns15Column
        {
            get { return Schema.Columns[23]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfns16Column
        {
            get { return Schema.Columns[24]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfns17Column
        {
            get { return Schema.Columns[25]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfns18Column
        {
            get { return Schema.Columns[26]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfns19Column
        {
            get { return Schema.Columns[27]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfns20Column
        {
            get { return Schema.Columns[28]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfns21Column
        {
            get { return Schema.Columns[29]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfns22Column
        {
            get { return Schema.Columns[30]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfns23Column
        {
            get { return Schema.Columns[31]; }
        }
        
        
        
        public static TableSchema.TableColumn Upns1Column
        {
            get { return Schema.Columns[32]; }
        }
        
        
        
        public static TableSchema.TableColumn Upns2Column
        {
            get { return Schema.Columns[33]; }
        }
        
        
        
        public static TableSchema.TableColumn Upns3Column
        {
            get { return Schema.Columns[34]; }
        }
        
        
        
        public static TableSchema.TableColumn Upns4Column
        {
            get { return Schema.Columns[35]; }
        }
        
        
        
        public static TableSchema.TableColumn Upns5Column
        {
            get { return Schema.Columns[36]; }
        }
        
        
        
        public static TableSchema.TableColumn Upns6Column
        {
            get { return Schema.Columns[37]; }
        }
        
        
        
        public static TableSchema.TableColumn Upns7Column
        {
            get { return Schema.Columns[38]; }
        }
        
        
        
        public static TableSchema.TableColumn Upns8Column
        {
            get { return Schema.Columns[39]; }
        }
        
        
        
        public static TableSchema.TableColumn Upns9Column
        {
            get { return Schema.Columns[40]; }
        }
        
        
        
        public static TableSchema.TableColumn Upns10Column
        {
            get { return Schema.Columns[41]; }
        }
        
        
        
        public static TableSchema.TableColumn Upns11Column
        {
            get { return Schema.Columns[42]; }
        }
        
        
        
        public static TableSchema.TableColumn Upns12Column
        {
            get { return Schema.Columns[43]; }
        }
        
        
        
        public static TableSchema.TableColumn Upns13Column
        {
            get { return Schema.Columns[44]; }
        }
        
        
        
        public static TableSchema.TableColumn Upns14Column
        {
            get { return Schema.Columns[45]; }
        }
        
        
        
        public static TableSchema.TableColumn Upns15Column
        {
            get { return Schema.Columns[46]; }
        }
        
        
        
        public static TableSchema.TableColumn Upns16Column
        {
            get { return Schema.Columns[47]; }
        }
        
        
        
        public static TableSchema.TableColumn Upns17Column
        {
            get { return Schema.Columns[48]; }
        }
        
        
        
        public static TableSchema.TableColumn Upns18Column
        {
            get { return Schema.Columns[49]; }
        }
        
        
        
        public static TableSchema.TableColumn Upns19Column
        {
            get { return Schema.Columns[50]; }
        }
        
        
        
        public static TableSchema.TableColumn Upns20Column
        {
            get { return Schema.Columns[51]; }
        }
        
        
        
        public static TableSchema.TableColumn Upns21Column
        {
            get { return Schema.Columns[52]; }
        }
        
        
        
        public static TableSchema.TableColumn Upns22Column
        {
            get { return Schema.Columns[53]; }
        }
        
        
        
        public static TableSchema.TableColumn Upns23Column
        {
            get { return Schema.Columns[54]; }
        }
        
        
        
        public static TableSchema.TableColumn Secns1Column
        {
            get { return Schema.Columns[55]; }
        }
        
        
        
        public static TableSchema.TableColumn Secns2Column
        {
            get { return Schema.Columns[56]; }
        }
        
        
        
        public static TableSchema.TableColumn Secns3Column
        {
            get { return Schema.Columns[57]; }
        }
        
        
        
        public static TableSchema.TableColumn Secns4Column
        {
            get { return Schema.Columns[58]; }
        }
        
        
        
        public static TableSchema.TableColumn Secns5Column
        {
            get { return Schema.Columns[59]; }
        }
        
        
        
        public static TableSchema.TableColumn Secns6Column
        {
            get { return Schema.Columns[60]; }
        }
        
        
        
        public static TableSchema.TableColumn Secns7Column
        {
            get { return Schema.Columns[61]; }
        }
        
        
        
        public static TableSchema.TableColumn Secns8Column
        {
            get { return Schema.Columns[62]; }
        }
        
        
        
        public static TableSchema.TableColumn Secns9Column
        {
            get { return Schema.Columns[63]; }
        }
        
        
        
        public static TableSchema.TableColumn Secns10Column
        {
            get { return Schema.Columns[64]; }
        }
        
        
        
        public static TableSchema.TableColumn Secns11Column
        {
            get { return Schema.Columns[65]; }
        }
        
        
        
        public static TableSchema.TableColumn Secns12Column
        {
            get { return Schema.Columns[66]; }
        }
        
        
        
        public static TableSchema.TableColumn Secns13Column
        {
            get { return Schema.Columns[67]; }
        }
        
        
        
        public static TableSchema.TableColumn Secns14Column
        {
            get { return Schema.Columns[68]; }
        }
        
        
        
        public static TableSchema.TableColumn Secns15Column
        {
            get { return Schema.Columns[69]; }
        }
        
        
        
        public static TableSchema.TableColumn Secns16Column
        {
            get { return Schema.Columns[70]; }
        }
        
        
        
        public static TableSchema.TableColumn Secns17Column
        {
            get { return Schema.Columns[71]; }
        }
        
        
        
        public static TableSchema.TableColumn Secns18Column
        {
            get { return Schema.Columns[72]; }
        }
        
        
        
        public static TableSchema.TableColumn Secns19Column
        {
            get { return Schema.Columns[73]; }
        }
        
        
        
        public static TableSchema.TableColumn Secns20Column
        {
            get { return Schema.Columns[74]; }
        }
        
        
        
        public static TableSchema.TableColumn Secns21Column
        {
            get { return Schema.Columns[75]; }
        }
        
        
        
        public static TableSchema.TableColumn Secns22Column
        {
            get { return Schema.Columns[76]; }
        }
        
        
        
        public static TableSchema.TableColumn Secns23Column
        {
            get { return Schema.Columns[77]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string NurseScoreId = @"NurseScoreId";
			 public static string DateSpan = @"DateSpan";
			 public static string EvaluateLevelId = @"EvaluateLevelId";
			 public static string TotalScore = @"TotalScore";
			 public static string UpViews = @"UpViews";
			 public static string YearId = @"YearId";
			 public static string MonthId = @"MonthId";
			 public static string EmployeeId = @"EmployeeId";
			 public static string IsSubmit = @"IsSubmit";
			 public static string Selfns1 = @"Selfns1";
			 public static string Selfns2 = @"Selfns2";
			 public static string Selfns3 = @"Selfns3";
			 public static string Selfns4 = @"Selfns4";
			 public static string Selfns5 = @"Selfns5";
			 public static string Selfns6 = @"Selfns6";
			 public static string Selfns7 = @"Selfns7";
			 public static string Selfns8 = @"Selfns8";
			 public static string Selfns9 = @"Selfns9";
			 public static string Selfns10 = @"Selfns10";
			 public static string Selfns11 = @"Selfns11";
			 public static string Selfns12 = @"Selfns12";
			 public static string Selfns13 = @"Selfns13";
			 public static string Selfns14 = @"Selfns14";
			 public static string Selfns15 = @"Selfns15";
			 public static string Selfns16 = @"Selfns16";
			 public static string Selfns17 = @"Selfns17";
			 public static string Selfns18 = @"Selfns18";
			 public static string Selfns19 = @"Selfns19";
			 public static string Selfns20 = @"Selfns20";
			 public static string Selfns21 = @"Selfns21";
			 public static string Selfns22 = @"Selfns22";
			 public static string Selfns23 = @"Selfns23";
			 public static string Upns1 = @"Upns1";
			 public static string Upns2 = @"Upns2";
			 public static string Upns3 = @"Upns3";
			 public static string Upns4 = @"Upns4";
			 public static string Upns5 = @"Upns5";
			 public static string Upns6 = @"Upns6";
			 public static string Upns7 = @"Upns7";
			 public static string Upns8 = @"Upns8";
			 public static string Upns9 = @"Upns9";
			 public static string Upns10 = @"Upns10";
			 public static string Upns11 = @"Upns11";
			 public static string Upns12 = @"Upns12";
			 public static string Upns13 = @"Upns13";
			 public static string Upns14 = @"Upns14";
			 public static string Upns15 = @"Upns15";
			 public static string Upns16 = @"Upns16";
			 public static string Upns17 = @"Upns17";
			 public static string Upns18 = @"Upns18";
			 public static string Upns19 = @"Upns19";
			 public static string Upns20 = @"Upns20";
			 public static string Upns21 = @"Upns21";
			 public static string Upns22 = @"Upns22";
			 public static string Upns23 = @"Upns23";
			 public static string Secns1 = @"Secns1";
			 public static string Secns2 = @"Secns2";
			 public static string Secns3 = @"Secns3";
			 public static string Secns4 = @"Secns4";
			 public static string Secns5 = @"Secns5";
			 public static string Secns6 = @"Secns6";
			 public static string Secns7 = @"Secns7";
			 public static string Secns8 = @"Secns8";
			 public static string Secns9 = @"Secns9";
			 public static string Secns10 = @"Secns10";
			 public static string Secns11 = @"Secns11";
			 public static string Secns12 = @"Secns12";
			 public static string Secns13 = @"Secns13";
			 public static string Secns14 = @"Secns14";
			 public static string Secns15 = @"Secns15";
			 public static string Secns16 = @"Secns16";
			 public static string Secns17 = @"Secns17";
			 public static string Secns18 = @"Secns18";
			 public static string Secns19 = @"Secns19";
			 public static string Secns20 = @"Secns20";
			 public static string Secns21 = @"Secns21";
			 public static string Secns22 = @"Secns22";
			 public static string Secns23 = @"Secns23";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
