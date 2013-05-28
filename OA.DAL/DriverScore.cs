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
	/// Strongly-typed collection for the DriverScore class.
	/// </summary>
    [Serializable]
	public partial class DriverScoreCollection : ActiveList<DriverScore, DriverScoreCollection>
	{	   
		public DriverScoreCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>DriverScoreCollection</returns>
		public DriverScoreCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                DriverScore o = this[i];
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
	/// This is an ActiveRecord class which wraps the DriverScore_tb table.
	/// </summary>
	[Serializable]
	public partial class DriverScore : ActiveRecord<DriverScore>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public DriverScore()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public DriverScore(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public DriverScore(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public DriverScore(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("DriverScore_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarDriverScoreId = new TableSchema.TableColumn(schema);
				colvarDriverScoreId.ColumnName = "DriverScoreId";
				colvarDriverScoreId.DataType = DbType.Int32;
				colvarDriverScoreId.MaxLength = 0;
				colvarDriverScoreId.AutoIncrement = true;
				colvarDriverScoreId.IsNullable = false;
				colvarDriverScoreId.IsPrimaryKey = true;
				colvarDriverScoreId.IsForeignKey = false;
				colvarDriverScoreId.IsReadOnly = false;
				colvarDriverScoreId.DefaultSetting = @"";
				colvarDriverScoreId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDriverScoreId);
				
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
				
				TableSchema.TableColumn colvarSelfds1 = new TableSchema.TableColumn(schema);
				colvarSelfds1.ColumnName = "Selfds1";
				colvarSelfds1.DataType = DbType.String;
				colvarSelfds1.MaxLength = 10;
				colvarSelfds1.AutoIncrement = false;
				colvarSelfds1.IsNullable = true;
				colvarSelfds1.IsPrimaryKey = false;
				colvarSelfds1.IsForeignKey = false;
				colvarSelfds1.IsReadOnly = false;
				colvarSelfds1.DefaultSetting = @"";
				colvarSelfds1.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfds1);
				
				TableSchema.TableColumn colvarSelfds2 = new TableSchema.TableColumn(schema);
				colvarSelfds2.ColumnName = "Selfds2";
				colvarSelfds2.DataType = DbType.String;
				colvarSelfds2.MaxLength = 10;
				colvarSelfds2.AutoIncrement = false;
				colvarSelfds2.IsNullable = true;
				colvarSelfds2.IsPrimaryKey = false;
				colvarSelfds2.IsForeignKey = false;
				colvarSelfds2.IsReadOnly = false;
				colvarSelfds2.DefaultSetting = @"";
				colvarSelfds2.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfds2);
				
				TableSchema.TableColumn colvarSelfds3 = new TableSchema.TableColumn(schema);
				colvarSelfds3.ColumnName = "Selfds3";
				colvarSelfds3.DataType = DbType.String;
				colvarSelfds3.MaxLength = 10;
				colvarSelfds3.AutoIncrement = false;
				colvarSelfds3.IsNullable = true;
				colvarSelfds3.IsPrimaryKey = false;
				colvarSelfds3.IsForeignKey = false;
				colvarSelfds3.IsReadOnly = false;
				colvarSelfds3.DefaultSetting = @"";
				colvarSelfds3.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfds3);
				
				TableSchema.TableColumn colvarSelfds4 = new TableSchema.TableColumn(schema);
				colvarSelfds4.ColumnName = "Selfds4";
				colvarSelfds4.DataType = DbType.String;
				colvarSelfds4.MaxLength = 10;
				colvarSelfds4.AutoIncrement = false;
				colvarSelfds4.IsNullable = true;
				colvarSelfds4.IsPrimaryKey = false;
				colvarSelfds4.IsForeignKey = false;
				colvarSelfds4.IsReadOnly = false;
				colvarSelfds4.DefaultSetting = @"";
				colvarSelfds4.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfds4);
				
				TableSchema.TableColumn colvarSelfds5 = new TableSchema.TableColumn(schema);
				colvarSelfds5.ColumnName = "Selfds5";
				colvarSelfds5.DataType = DbType.String;
				colvarSelfds5.MaxLength = 10;
				colvarSelfds5.AutoIncrement = false;
				colvarSelfds5.IsNullable = true;
				colvarSelfds5.IsPrimaryKey = false;
				colvarSelfds5.IsForeignKey = false;
				colvarSelfds5.IsReadOnly = false;
				colvarSelfds5.DefaultSetting = @"";
				colvarSelfds5.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfds5);
				
				TableSchema.TableColumn colvarSelfds6 = new TableSchema.TableColumn(schema);
				colvarSelfds6.ColumnName = "Selfds6";
				colvarSelfds6.DataType = DbType.String;
				colvarSelfds6.MaxLength = 10;
				colvarSelfds6.AutoIncrement = false;
				colvarSelfds6.IsNullable = true;
				colvarSelfds6.IsPrimaryKey = false;
				colvarSelfds6.IsForeignKey = false;
				colvarSelfds6.IsReadOnly = false;
				colvarSelfds6.DefaultSetting = @"";
				colvarSelfds6.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfds6);
				
				TableSchema.TableColumn colvarSelfds7 = new TableSchema.TableColumn(schema);
				colvarSelfds7.ColumnName = "Selfds7";
				colvarSelfds7.DataType = DbType.String;
				colvarSelfds7.MaxLength = 10;
				colvarSelfds7.AutoIncrement = false;
				colvarSelfds7.IsNullable = true;
				colvarSelfds7.IsPrimaryKey = false;
				colvarSelfds7.IsForeignKey = false;
				colvarSelfds7.IsReadOnly = false;
				colvarSelfds7.DefaultSetting = @"";
				colvarSelfds7.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfds7);
				
				TableSchema.TableColumn colvarSelfds8 = new TableSchema.TableColumn(schema);
				colvarSelfds8.ColumnName = "Selfds8";
				colvarSelfds8.DataType = DbType.String;
				colvarSelfds8.MaxLength = 10;
				colvarSelfds8.AutoIncrement = false;
				colvarSelfds8.IsNullable = true;
				colvarSelfds8.IsPrimaryKey = false;
				colvarSelfds8.IsForeignKey = false;
				colvarSelfds8.IsReadOnly = false;
				colvarSelfds8.DefaultSetting = @"";
				colvarSelfds8.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfds8);
				
				TableSchema.TableColumn colvarSelfds9 = new TableSchema.TableColumn(schema);
				colvarSelfds9.ColumnName = "Selfds9";
				colvarSelfds9.DataType = DbType.String;
				colvarSelfds9.MaxLength = 10;
				colvarSelfds9.AutoIncrement = false;
				colvarSelfds9.IsNullable = true;
				colvarSelfds9.IsPrimaryKey = false;
				colvarSelfds9.IsForeignKey = false;
				colvarSelfds9.IsReadOnly = false;
				colvarSelfds9.DefaultSetting = @"";
				colvarSelfds9.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfds9);
				
				TableSchema.TableColumn colvarSelfds10 = new TableSchema.TableColumn(schema);
				colvarSelfds10.ColumnName = "Selfds10";
				colvarSelfds10.DataType = DbType.String;
				colvarSelfds10.MaxLength = 10;
				colvarSelfds10.AutoIncrement = false;
				colvarSelfds10.IsNullable = true;
				colvarSelfds10.IsPrimaryKey = false;
				colvarSelfds10.IsForeignKey = false;
				colvarSelfds10.IsReadOnly = false;
				colvarSelfds10.DefaultSetting = @"";
				colvarSelfds10.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfds10);
				
				TableSchema.TableColumn colvarSelfds11 = new TableSchema.TableColumn(schema);
				colvarSelfds11.ColumnName = "Selfds11";
				colvarSelfds11.DataType = DbType.String;
				colvarSelfds11.MaxLength = 10;
				colvarSelfds11.AutoIncrement = false;
				colvarSelfds11.IsNullable = true;
				colvarSelfds11.IsPrimaryKey = false;
				colvarSelfds11.IsForeignKey = false;
				colvarSelfds11.IsReadOnly = false;
				colvarSelfds11.DefaultSetting = @"";
				colvarSelfds11.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfds11);
				
				TableSchema.TableColumn colvarSelfds12 = new TableSchema.TableColumn(schema);
				colvarSelfds12.ColumnName = "Selfds12";
				colvarSelfds12.DataType = DbType.String;
				colvarSelfds12.MaxLength = 10;
				colvarSelfds12.AutoIncrement = false;
				colvarSelfds12.IsNullable = true;
				colvarSelfds12.IsPrimaryKey = false;
				colvarSelfds12.IsForeignKey = false;
				colvarSelfds12.IsReadOnly = false;
				colvarSelfds12.DefaultSetting = @"";
				colvarSelfds12.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfds12);
				
				TableSchema.TableColumn colvarSelfds13 = new TableSchema.TableColumn(schema);
				colvarSelfds13.ColumnName = "Selfds13";
				colvarSelfds13.DataType = DbType.String;
				colvarSelfds13.MaxLength = 10;
				colvarSelfds13.AutoIncrement = false;
				colvarSelfds13.IsNullable = true;
				colvarSelfds13.IsPrimaryKey = false;
				colvarSelfds13.IsForeignKey = false;
				colvarSelfds13.IsReadOnly = false;
				colvarSelfds13.DefaultSetting = @"";
				colvarSelfds13.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfds13);
				
				TableSchema.TableColumn colvarSelfds14 = new TableSchema.TableColumn(schema);
				colvarSelfds14.ColumnName = "Selfds14";
				colvarSelfds14.DataType = DbType.String;
				colvarSelfds14.MaxLength = 10;
				colvarSelfds14.AutoIncrement = false;
				colvarSelfds14.IsNullable = true;
				colvarSelfds14.IsPrimaryKey = false;
				colvarSelfds14.IsForeignKey = false;
				colvarSelfds14.IsReadOnly = false;
				colvarSelfds14.DefaultSetting = @"";
				colvarSelfds14.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfds14);
				
				TableSchema.TableColumn colvarSelfds15 = new TableSchema.TableColumn(schema);
				colvarSelfds15.ColumnName = "Selfds15";
				colvarSelfds15.DataType = DbType.String;
				colvarSelfds15.MaxLength = 10;
				colvarSelfds15.AutoIncrement = false;
				colvarSelfds15.IsNullable = true;
				colvarSelfds15.IsPrimaryKey = false;
				colvarSelfds15.IsForeignKey = false;
				colvarSelfds15.IsReadOnly = false;
				colvarSelfds15.DefaultSetting = @"";
				colvarSelfds15.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfds15);
				
				TableSchema.TableColumn colvarSelfds16 = new TableSchema.TableColumn(schema);
				colvarSelfds16.ColumnName = "Selfds16";
				colvarSelfds16.DataType = DbType.String;
				colvarSelfds16.MaxLength = 10;
				colvarSelfds16.AutoIncrement = false;
				colvarSelfds16.IsNullable = true;
				colvarSelfds16.IsPrimaryKey = false;
				colvarSelfds16.IsForeignKey = false;
				colvarSelfds16.IsReadOnly = false;
				colvarSelfds16.DefaultSetting = @"";
				colvarSelfds16.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfds16);
				
				TableSchema.TableColumn colvarSelfds17 = new TableSchema.TableColumn(schema);
				colvarSelfds17.ColumnName = "Selfds17";
				colvarSelfds17.DataType = DbType.String;
				colvarSelfds17.MaxLength = 10;
				colvarSelfds17.AutoIncrement = false;
				colvarSelfds17.IsNullable = true;
				colvarSelfds17.IsPrimaryKey = false;
				colvarSelfds17.IsForeignKey = false;
				colvarSelfds17.IsReadOnly = false;
				colvarSelfds17.DefaultSetting = @"";
				colvarSelfds17.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfds17);
				
				TableSchema.TableColumn colvarSelfds18 = new TableSchema.TableColumn(schema);
				colvarSelfds18.ColumnName = "Selfds18";
				colvarSelfds18.DataType = DbType.String;
				colvarSelfds18.MaxLength = 10;
				colvarSelfds18.AutoIncrement = false;
				colvarSelfds18.IsNullable = true;
				colvarSelfds18.IsPrimaryKey = false;
				colvarSelfds18.IsForeignKey = false;
				colvarSelfds18.IsReadOnly = false;
				colvarSelfds18.DefaultSetting = @"";
				colvarSelfds18.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfds18);
				
				TableSchema.TableColumn colvarSelfds19 = new TableSchema.TableColumn(schema);
				colvarSelfds19.ColumnName = "Selfds19";
				colvarSelfds19.DataType = DbType.String;
				colvarSelfds19.MaxLength = 10;
				colvarSelfds19.AutoIncrement = false;
				colvarSelfds19.IsNullable = true;
				colvarSelfds19.IsPrimaryKey = false;
				colvarSelfds19.IsForeignKey = false;
				colvarSelfds19.IsReadOnly = false;
				colvarSelfds19.DefaultSetting = @"";
				colvarSelfds19.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfds19);
				
				TableSchema.TableColumn colvarSelfds20 = new TableSchema.TableColumn(schema);
				colvarSelfds20.ColumnName = "Selfds20";
				colvarSelfds20.DataType = DbType.String;
				colvarSelfds20.MaxLength = 10;
				colvarSelfds20.AutoIncrement = false;
				colvarSelfds20.IsNullable = true;
				colvarSelfds20.IsPrimaryKey = false;
				colvarSelfds20.IsForeignKey = false;
				colvarSelfds20.IsReadOnly = false;
				colvarSelfds20.DefaultSetting = @"";
				colvarSelfds20.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfds20);
				
				TableSchema.TableColumn colvarSelfds21 = new TableSchema.TableColumn(schema);
				colvarSelfds21.ColumnName = "Selfds21";
				colvarSelfds21.DataType = DbType.String;
				colvarSelfds21.MaxLength = 10;
				colvarSelfds21.AutoIncrement = false;
				colvarSelfds21.IsNullable = true;
				colvarSelfds21.IsPrimaryKey = false;
				colvarSelfds21.IsForeignKey = false;
				colvarSelfds21.IsReadOnly = false;
				colvarSelfds21.DefaultSetting = @"";
				colvarSelfds21.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfds21);
				
				TableSchema.TableColumn colvarSelfds22 = new TableSchema.TableColumn(schema);
				colvarSelfds22.ColumnName = "Selfds22";
				colvarSelfds22.DataType = DbType.String;
				colvarSelfds22.MaxLength = 10;
				colvarSelfds22.AutoIncrement = false;
				colvarSelfds22.IsNullable = true;
				colvarSelfds22.IsPrimaryKey = false;
				colvarSelfds22.IsForeignKey = false;
				colvarSelfds22.IsReadOnly = false;
				colvarSelfds22.DefaultSetting = @"";
				colvarSelfds22.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfds22);
				
				TableSchema.TableColumn colvarSelfds23 = new TableSchema.TableColumn(schema);
				colvarSelfds23.ColumnName = "Selfds23";
				colvarSelfds23.DataType = DbType.String;
				colvarSelfds23.MaxLength = 10;
				colvarSelfds23.AutoIncrement = false;
				colvarSelfds23.IsNullable = true;
				colvarSelfds23.IsPrimaryKey = false;
				colvarSelfds23.IsForeignKey = false;
				colvarSelfds23.IsReadOnly = false;
				colvarSelfds23.DefaultSetting = @"";
				colvarSelfds23.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfds23);
				
				TableSchema.TableColumn colvarUpds1 = new TableSchema.TableColumn(schema);
				colvarUpds1.ColumnName = "Upds1";
				colvarUpds1.DataType = DbType.String;
				colvarUpds1.MaxLength = 10;
				colvarUpds1.AutoIncrement = false;
				colvarUpds1.IsNullable = true;
				colvarUpds1.IsPrimaryKey = false;
				colvarUpds1.IsForeignKey = false;
				colvarUpds1.IsReadOnly = false;
				colvarUpds1.DefaultSetting = @"";
				colvarUpds1.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpds1);
				
				TableSchema.TableColumn colvarUpds2 = new TableSchema.TableColumn(schema);
				colvarUpds2.ColumnName = "Upds2";
				colvarUpds2.DataType = DbType.String;
				colvarUpds2.MaxLength = 10;
				colvarUpds2.AutoIncrement = false;
				colvarUpds2.IsNullable = true;
				colvarUpds2.IsPrimaryKey = false;
				colvarUpds2.IsForeignKey = false;
				colvarUpds2.IsReadOnly = false;
				colvarUpds2.DefaultSetting = @"";
				colvarUpds2.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpds2);
				
				TableSchema.TableColumn colvarUpds3 = new TableSchema.TableColumn(schema);
				colvarUpds3.ColumnName = "Upds3";
				colvarUpds3.DataType = DbType.String;
				colvarUpds3.MaxLength = 10;
				colvarUpds3.AutoIncrement = false;
				colvarUpds3.IsNullable = true;
				colvarUpds3.IsPrimaryKey = false;
				colvarUpds3.IsForeignKey = false;
				colvarUpds3.IsReadOnly = false;
				colvarUpds3.DefaultSetting = @"";
				colvarUpds3.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpds3);
				
				TableSchema.TableColumn colvarUpds4 = new TableSchema.TableColumn(schema);
				colvarUpds4.ColumnName = "Upds4";
				colvarUpds4.DataType = DbType.String;
				colvarUpds4.MaxLength = 10;
				colvarUpds4.AutoIncrement = false;
				colvarUpds4.IsNullable = true;
				colvarUpds4.IsPrimaryKey = false;
				colvarUpds4.IsForeignKey = false;
				colvarUpds4.IsReadOnly = false;
				colvarUpds4.DefaultSetting = @"";
				colvarUpds4.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpds4);
				
				TableSchema.TableColumn colvarUpds5 = new TableSchema.TableColumn(schema);
				colvarUpds5.ColumnName = "Upds5";
				colvarUpds5.DataType = DbType.String;
				colvarUpds5.MaxLength = 10;
				colvarUpds5.AutoIncrement = false;
				colvarUpds5.IsNullable = true;
				colvarUpds5.IsPrimaryKey = false;
				colvarUpds5.IsForeignKey = false;
				colvarUpds5.IsReadOnly = false;
				colvarUpds5.DefaultSetting = @"";
				colvarUpds5.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpds5);
				
				TableSchema.TableColumn colvarUpds6 = new TableSchema.TableColumn(schema);
				colvarUpds6.ColumnName = "Upds6";
				colvarUpds6.DataType = DbType.String;
				colvarUpds6.MaxLength = 10;
				colvarUpds6.AutoIncrement = false;
				colvarUpds6.IsNullable = true;
				colvarUpds6.IsPrimaryKey = false;
				colvarUpds6.IsForeignKey = false;
				colvarUpds6.IsReadOnly = false;
				colvarUpds6.DefaultSetting = @"";
				colvarUpds6.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpds6);
				
				TableSchema.TableColumn colvarUpds7 = new TableSchema.TableColumn(schema);
				colvarUpds7.ColumnName = "Upds7";
				colvarUpds7.DataType = DbType.String;
				colvarUpds7.MaxLength = 10;
				colvarUpds7.AutoIncrement = false;
				colvarUpds7.IsNullable = true;
				colvarUpds7.IsPrimaryKey = false;
				colvarUpds7.IsForeignKey = false;
				colvarUpds7.IsReadOnly = false;
				colvarUpds7.DefaultSetting = @"";
				colvarUpds7.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpds7);
				
				TableSchema.TableColumn colvarUpds8 = new TableSchema.TableColumn(schema);
				colvarUpds8.ColumnName = "Upds8";
				colvarUpds8.DataType = DbType.String;
				colvarUpds8.MaxLength = 10;
				colvarUpds8.AutoIncrement = false;
				colvarUpds8.IsNullable = true;
				colvarUpds8.IsPrimaryKey = false;
				colvarUpds8.IsForeignKey = false;
				colvarUpds8.IsReadOnly = false;
				colvarUpds8.DefaultSetting = @"";
				colvarUpds8.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpds8);
				
				TableSchema.TableColumn colvarUpds9 = new TableSchema.TableColumn(schema);
				colvarUpds9.ColumnName = "Upds9";
				colvarUpds9.DataType = DbType.String;
				colvarUpds9.MaxLength = 10;
				colvarUpds9.AutoIncrement = false;
				colvarUpds9.IsNullable = true;
				colvarUpds9.IsPrimaryKey = false;
				colvarUpds9.IsForeignKey = false;
				colvarUpds9.IsReadOnly = false;
				colvarUpds9.DefaultSetting = @"";
				colvarUpds9.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpds9);
				
				TableSchema.TableColumn colvarUpds10 = new TableSchema.TableColumn(schema);
				colvarUpds10.ColumnName = "Upds10";
				colvarUpds10.DataType = DbType.String;
				colvarUpds10.MaxLength = 10;
				colvarUpds10.AutoIncrement = false;
				colvarUpds10.IsNullable = true;
				colvarUpds10.IsPrimaryKey = false;
				colvarUpds10.IsForeignKey = false;
				colvarUpds10.IsReadOnly = false;
				colvarUpds10.DefaultSetting = @"";
				colvarUpds10.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpds10);
				
				TableSchema.TableColumn colvarUpds11 = new TableSchema.TableColumn(schema);
				colvarUpds11.ColumnName = "Upds11";
				colvarUpds11.DataType = DbType.String;
				colvarUpds11.MaxLength = 10;
				colvarUpds11.AutoIncrement = false;
				colvarUpds11.IsNullable = true;
				colvarUpds11.IsPrimaryKey = false;
				colvarUpds11.IsForeignKey = false;
				colvarUpds11.IsReadOnly = false;
				colvarUpds11.DefaultSetting = @"";
				colvarUpds11.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpds11);
				
				TableSchema.TableColumn colvarUpds12 = new TableSchema.TableColumn(schema);
				colvarUpds12.ColumnName = "Upds12";
				colvarUpds12.DataType = DbType.String;
				colvarUpds12.MaxLength = 10;
				colvarUpds12.AutoIncrement = false;
				colvarUpds12.IsNullable = true;
				colvarUpds12.IsPrimaryKey = false;
				colvarUpds12.IsForeignKey = false;
				colvarUpds12.IsReadOnly = false;
				colvarUpds12.DefaultSetting = @"";
				colvarUpds12.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpds12);
				
				TableSchema.TableColumn colvarUpds13 = new TableSchema.TableColumn(schema);
				colvarUpds13.ColumnName = "Upds13";
				colvarUpds13.DataType = DbType.String;
				colvarUpds13.MaxLength = 10;
				colvarUpds13.AutoIncrement = false;
				colvarUpds13.IsNullable = true;
				colvarUpds13.IsPrimaryKey = false;
				colvarUpds13.IsForeignKey = false;
				colvarUpds13.IsReadOnly = false;
				colvarUpds13.DefaultSetting = @"";
				colvarUpds13.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpds13);
				
				TableSchema.TableColumn colvarUpds14 = new TableSchema.TableColumn(schema);
				colvarUpds14.ColumnName = "Upds14";
				colvarUpds14.DataType = DbType.String;
				colvarUpds14.MaxLength = 10;
				colvarUpds14.AutoIncrement = false;
				colvarUpds14.IsNullable = true;
				colvarUpds14.IsPrimaryKey = false;
				colvarUpds14.IsForeignKey = false;
				colvarUpds14.IsReadOnly = false;
				colvarUpds14.DefaultSetting = @"";
				colvarUpds14.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpds14);
				
				TableSchema.TableColumn colvarUpds15 = new TableSchema.TableColumn(schema);
				colvarUpds15.ColumnName = "Upds15";
				colvarUpds15.DataType = DbType.String;
				colvarUpds15.MaxLength = 10;
				colvarUpds15.AutoIncrement = false;
				colvarUpds15.IsNullable = true;
				colvarUpds15.IsPrimaryKey = false;
				colvarUpds15.IsForeignKey = false;
				colvarUpds15.IsReadOnly = false;
				colvarUpds15.DefaultSetting = @"";
				colvarUpds15.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpds15);
				
				TableSchema.TableColumn colvarUpds16 = new TableSchema.TableColumn(schema);
				colvarUpds16.ColumnName = "Upds16";
				colvarUpds16.DataType = DbType.String;
				colvarUpds16.MaxLength = 10;
				colvarUpds16.AutoIncrement = false;
				colvarUpds16.IsNullable = true;
				colvarUpds16.IsPrimaryKey = false;
				colvarUpds16.IsForeignKey = false;
				colvarUpds16.IsReadOnly = false;
				colvarUpds16.DefaultSetting = @"";
				colvarUpds16.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpds16);
				
				TableSchema.TableColumn colvarUpds17 = new TableSchema.TableColumn(schema);
				colvarUpds17.ColumnName = "Upds17";
				colvarUpds17.DataType = DbType.String;
				colvarUpds17.MaxLength = 10;
				colvarUpds17.AutoIncrement = false;
				colvarUpds17.IsNullable = true;
				colvarUpds17.IsPrimaryKey = false;
				colvarUpds17.IsForeignKey = false;
				colvarUpds17.IsReadOnly = false;
				colvarUpds17.DefaultSetting = @"";
				colvarUpds17.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpds17);
				
				TableSchema.TableColumn colvarUpds18 = new TableSchema.TableColumn(schema);
				colvarUpds18.ColumnName = "Upds18";
				colvarUpds18.DataType = DbType.String;
				colvarUpds18.MaxLength = 10;
				colvarUpds18.AutoIncrement = false;
				colvarUpds18.IsNullable = true;
				colvarUpds18.IsPrimaryKey = false;
				colvarUpds18.IsForeignKey = false;
				colvarUpds18.IsReadOnly = false;
				colvarUpds18.DefaultSetting = @"";
				colvarUpds18.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpds18);
				
				TableSchema.TableColumn colvarUpds19 = new TableSchema.TableColumn(schema);
				colvarUpds19.ColumnName = "Upds19";
				colvarUpds19.DataType = DbType.String;
				colvarUpds19.MaxLength = 10;
				colvarUpds19.AutoIncrement = false;
				colvarUpds19.IsNullable = true;
				colvarUpds19.IsPrimaryKey = false;
				colvarUpds19.IsForeignKey = false;
				colvarUpds19.IsReadOnly = false;
				colvarUpds19.DefaultSetting = @"";
				colvarUpds19.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpds19);
				
				TableSchema.TableColumn colvarUpds20 = new TableSchema.TableColumn(schema);
				colvarUpds20.ColumnName = "Upds20";
				colvarUpds20.DataType = DbType.String;
				colvarUpds20.MaxLength = 10;
				colvarUpds20.AutoIncrement = false;
				colvarUpds20.IsNullable = true;
				colvarUpds20.IsPrimaryKey = false;
				colvarUpds20.IsForeignKey = false;
				colvarUpds20.IsReadOnly = false;
				colvarUpds20.DefaultSetting = @"";
				colvarUpds20.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpds20);
				
				TableSchema.TableColumn colvarUpds21 = new TableSchema.TableColumn(schema);
				colvarUpds21.ColumnName = "Upds21";
				colvarUpds21.DataType = DbType.String;
				colvarUpds21.MaxLength = 10;
				colvarUpds21.AutoIncrement = false;
				colvarUpds21.IsNullable = true;
				colvarUpds21.IsPrimaryKey = false;
				colvarUpds21.IsForeignKey = false;
				colvarUpds21.IsReadOnly = false;
				colvarUpds21.DefaultSetting = @"";
				colvarUpds21.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpds21);
				
				TableSchema.TableColumn colvarUpds22 = new TableSchema.TableColumn(schema);
				colvarUpds22.ColumnName = "Upds22";
				colvarUpds22.DataType = DbType.String;
				colvarUpds22.MaxLength = 10;
				colvarUpds22.AutoIncrement = false;
				colvarUpds22.IsNullable = true;
				colvarUpds22.IsPrimaryKey = false;
				colvarUpds22.IsForeignKey = false;
				colvarUpds22.IsReadOnly = false;
				colvarUpds22.DefaultSetting = @"";
				colvarUpds22.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpds22);
				
				TableSchema.TableColumn colvarUpds23 = new TableSchema.TableColumn(schema);
				colvarUpds23.ColumnName = "Upds23";
				colvarUpds23.DataType = DbType.String;
				colvarUpds23.MaxLength = 10;
				colvarUpds23.AutoIncrement = false;
				colvarUpds23.IsNullable = true;
				colvarUpds23.IsPrimaryKey = false;
				colvarUpds23.IsForeignKey = false;
				colvarUpds23.IsReadOnly = false;
				colvarUpds23.DefaultSetting = @"";
				colvarUpds23.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpds23);
				
				TableSchema.TableColumn colvarSecds1 = new TableSchema.TableColumn(schema);
				colvarSecds1.ColumnName = "Secds1";
				colvarSecds1.DataType = DbType.String;
				colvarSecds1.MaxLength = 10;
				colvarSecds1.AutoIncrement = false;
				colvarSecds1.IsNullable = true;
				colvarSecds1.IsPrimaryKey = false;
				colvarSecds1.IsForeignKey = false;
				colvarSecds1.IsReadOnly = false;
				colvarSecds1.DefaultSetting = @"";
				colvarSecds1.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecds1);
				
				TableSchema.TableColumn colvarSecds2 = new TableSchema.TableColumn(schema);
				colvarSecds2.ColumnName = "Secds2";
				colvarSecds2.DataType = DbType.String;
				colvarSecds2.MaxLength = 10;
				colvarSecds2.AutoIncrement = false;
				colvarSecds2.IsNullable = true;
				colvarSecds2.IsPrimaryKey = false;
				colvarSecds2.IsForeignKey = false;
				colvarSecds2.IsReadOnly = false;
				colvarSecds2.DefaultSetting = @"";
				colvarSecds2.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecds2);
				
				TableSchema.TableColumn colvarSecds3 = new TableSchema.TableColumn(schema);
				colvarSecds3.ColumnName = "Secds3";
				colvarSecds3.DataType = DbType.String;
				colvarSecds3.MaxLength = 10;
				colvarSecds3.AutoIncrement = false;
				colvarSecds3.IsNullable = true;
				colvarSecds3.IsPrimaryKey = false;
				colvarSecds3.IsForeignKey = false;
				colvarSecds3.IsReadOnly = false;
				colvarSecds3.DefaultSetting = @"";
				colvarSecds3.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecds3);
				
				TableSchema.TableColumn colvarSecds4 = new TableSchema.TableColumn(schema);
				colvarSecds4.ColumnName = "Secds4";
				colvarSecds4.DataType = DbType.String;
				colvarSecds4.MaxLength = 10;
				colvarSecds4.AutoIncrement = false;
				colvarSecds4.IsNullable = true;
				colvarSecds4.IsPrimaryKey = false;
				colvarSecds4.IsForeignKey = false;
				colvarSecds4.IsReadOnly = false;
				colvarSecds4.DefaultSetting = @"";
				colvarSecds4.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecds4);
				
				TableSchema.TableColumn colvarSecds5 = new TableSchema.TableColumn(schema);
				colvarSecds5.ColumnName = "Secds5";
				colvarSecds5.DataType = DbType.String;
				colvarSecds5.MaxLength = 10;
				colvarSecds5.AutoIncrement = false;
				colvarSecds5.IsNullable = true;
				colvarSecds5.IsPrimaryKey = false;
				colvarSecds5.IsForeignKey = false;
				colvarSecds5.IsReadOnly = false;
				colvarSecds5.DefaultSetting = @"";
				colvarSecds5.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecds5);
				
				TableSchema.TableColumn colvarSecds6 = new TableSchema.TableColumn(schema);
				colvarSecds6.ColumnName = "Secds6";
				colvarSecds6.DataType = DbType.String;
				colvarSecds6.MaxLength = 10;
				colvarSecds6.AutoIncrement = false;
				colvarSecds6.IsNullable = true;
				colvarSecds6.IsPrimaryKey = false;
				colvarSecds6.IsForeignKey = false;
				colvarSecds6.IsReadOnly = false;
				colvarSecds6.DefaultSetting = @"";
				colvarSecds6.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecds6);
				
				TableSchema.TableColumn colvarSecds7 = new TableSchema.TableColumn(schema);
				colvarSecds7.ColumnName = "Secds7";
				colvarSecds7.DataType = DbType.String;
				colvarSecds7.MaxLength = 10;
				colvarSecds7.AutoIncrement = false;
				colvarSecds7.IsNullable = true;
				colvarSecds7.IsPrimaryKey = false;
				colvarSecds7.IsForeignKey = false;
				colvarSecds7.IsReadOnly = false;
				colvarSecds7.DefaultSetting = @"";
				colvarSecds7.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecds7);
				
				TableSchema.TableColumn colvarSecds8 = new TableSchema.TableColumn(schema);
				colvarSecds8.ColumnName = "Secds8";
				colvarSecds8.DataType = DbType.String;
				colvarSecds8.MaxLength = 10;
				colvarSecds8.AutoIncrement = false;
				colvarSecds8.IsNullable = true;
				colvarSecds8.IsPrimaryKey = false;
				colvarSecds8.IsForeignKey = false;
				colvarSecds8.IsReadOnly = false;
				colvarSecds8.DefaultSetting = @"";
				colvarSecds8.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecds8);
				
				TableSchema.TableColumn colvarSecds9 = new TableSchema.TableColumn(schema);
				colvarSecds9.ColumnName = "Secds9";
				colvarSecds9.DataType = DbType.String;
				colvarSecds9.MaxLength = 10;
				colvarSecds9.AutoIncrement = false;
				colvarSecds9.IsNullable = true;
				colvarSecds9.IsPrimaryKey = false;
				colvarSecds9.IsForeignKey = false;
				colvarSecds9.IsReadOnly = false;
				colvarSecds9.DefaultSetting = @"";
				colvarSecds9.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecds9);
				
				TableSchema.TableColumn colvarSecds10 = new TableSchema.TableColumn(schema);
				colvarSecds10.ColumnName = "Secds10";
				colvarSecds10.DataType = DbType.String;
				colvarSecds10.MaxLength = 10;
				colvarSecds10.AutoIncrement = false;
				colvarSecds10.IsNullable = true;
				colvarSecds10.IsPrimaryKey = false;
				colvarSecds10.IsForeignKey = false;
				colvarSecds10.IsReadOnly = false;
				colvarSecds10.DefaultSetting = @"";
				colvarSecds10.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecds10);
				
				TableSchema.TableColumn colvarSecds11 = new TableSchema.TableColumn(schema);
				colvarSecds11.ColumnName = "Secds11";
				colvarSecds11.DataType = DbType.String;
				colvarSecds11.MaxLength = 10;
				colvarSecds11.AutoIncrement = false;
				colvarSecds11.IsNullable = true;
				colvarSecds11.IsPrimaryKey = false;
				colvarSecds11.IsForeignKey = false;
				colvarSecds11.IsReadOnly = false;
				colvarSecds11.DefaultSetting = @"";
				colvarSecds11.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecds11);
				
				TableSchema.TableColumn colvarSecds12 = new TableSchema.TableColumn(schema);
				colvarSecds12.ColumnName = "Secds12";
				colvarSecds12.DataType = DbType.String;
				colvarSecds12.MaxLength = 10;
				colvarSecds12.AutoIncrement = false;
				colvarSecds12.IsNullable = true;
				colvarSecds12.IsPrimaryKey = false;
				colvarSecds12.IsForeignKey = false;
				colvarSecds12.IsReadOnly = false;
				colvarSecds12.DefaultSetting = @"";
				colvarSecds12.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecds12);
				
				TableSchema.TableColumn colvarSecds13 = new TableSchema.TableColumn(schema);
				colvarSecds13.ColumnName = "Secds13";
				colvarSecds13.DataType = DbType.String;
				colvarSecds13.MaxLength = 10;
				colvarSecds13.AutoIncrement = false;
				colvarSecds13.IsNullable = true;
				colvarSecds13.IsPrimaryKey = false;
				colvarSecds13.IsForeignKey = false;
				colvarSecds13.IsReadOnly = false;
				colvarSecds13.DefaultSetting = @"";
				colvarSecds13.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecds13);
				
				TableSchema.TableColumn colvarSecds14 = new TableSchema.TableColumn(schema);
				colvarSecds14.ColumnName = "Secds14";
				colvarSecds14.DataType = DbType.String;
				colvarSecds14.MaxLength = 10;
				colvarSecds14.AutoIncrement = false;
				colvarSecds14.IsNullable = true;
				colvarSecds14.IsPrimaryKey = false;
				colvarSecds14.IsForeignKey = false;
				colvarSecds14.IsReadOnly = false;
				colvarSecds14.DefaultSetting = @"";
				colvarSecds14.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecds14);
				
				TableSchema.TableColumn colvarSecds15 = new TableSchema.TableColumn(schema);
				colvarSecds15.ColumnName = "Secds15";
				colvarSecds15.DataType = DbType.String;
				colvarSecds15.MaxLength = 10;
				colvarSecds15.AutoIncrement = false;
				colvarSecds15.IsNullable = true;
				colvarSecds15.IsPrimaryKey = false;
				colvarSecds15.IsForeignKey = false;
				colvarSecds15.IsReadOnly = false;
				colvarSecds15.DefaultSetting = @"";
				colvarSecds15.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecds15);
				
				TableSchema.TableColumn colvarSecds16 = new TableSchema.TableColumn(schema);
				colvarSecds16.ColumnName = "Secds16";
				colvarSecds16.DataType = DbType.String;
				colvarSecds16.MaxLength = 10;
				colvarSecds16.AutoIncrement = false;
				colvarSecds16.IsNullable = true;
				colvarSecds16.IsPrimaryKey = false;
				colvarSecds16.IsForeignKey = false;
				colvarSecds16.IsReadOnly = false;
				colvarSecds16.DefaultSetting = @"";
				colvarSecds16.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecds16);
				
				TableSchema.TableColumn colvarSecds17 = new TableSchema.TableColumn(schema);
				colvarSecds17.ColumnName = "Secds17";
				colvarSecds17.DataType = DbType.String;
				colvarSecds17.MaxLength = 10;
				colvarSecds17.AutoIncrement = false;
				colvarSecds17.IsNullable = true;
				colvarSecds17.IsPrimaryKey = false;
				colvarSecds17.IsForeignKey = false;
				colvarSecds17.IsReadOnly = false;
				colvarSecds17.DefaultSetting = @"";
				colvarSecds17.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecds17);
				
				TableSchema.TableColumn colvarSecds18 = new TableSchema.TableColumn(schema);
				colvarSecds18.ColumnName = "Secds18";
				colvarSecds18.DataType = DbType.String;
				colvarSecds18.MaxLength = 10;
				colvarSecds18.AutoIncrement = false;
				colvarSecds18.IsNullable = true;
				colvarSecds18.IsPrimaryKey = false;
				colvarSecds18.IsForeignKey = false;
				colvarSecds18.IsReadOnly = false;
				colvarSecds18.DefaultSetting = @"";
				colvarSecds18.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecds18);
				
				TableSchema.TableColumn colvarSecds19 = new TableSchema.TableColumn(schema);
				colvarSecds19.ColumnName = "Secds19";
				colvarSecds19.DataType = DbType.String;
				colvarSecds19.MaxLength = 10;
				colvarSecds19.AutoIncrement = false;
				colvarSecds19.IsNullable = true;
				colvarSecds19.IsPrimaryKey = false;
				colvarSecds19.IsForeignKey = false;
				colvarSecds19.IsReadOnly = false;
				colvarSecds19.DefaultSetting = @"";
				colvarSecds19.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecds19);
				
				TableSchema.TableColumn colvarSecds20 = new TableSchema.TableColumn(schema);
				colvarSecds20.ColumnName = "Secds20";
				colvarSecds20.DataType = DbType.String;
				colvarSecds20.MaxLength = 10;
				colvarSecds20.AutoIncrement = false;
				colvarSecds20.IsNullable = true;
				colvarSecds20.IsPrimaryKey = false;
				colvarSecds20.IsForeignKey = false;
				colvarSecds20.IsReadOnly = false;
				colvarSecds20.DefaultSetting = @"";
				colvarSecds20.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecds20);
				
				TableSchema.TableColumn colvarSecds21 = new TableSchema.TableColumn(schema);
				colvarSecds21.ColumnName = "Secds21";
				colvarSecds21.DataType = DbType.String;
				colvarSecds21.MaxLength = 10;
				colvarSecds21.AutoIncrement = false;
				colvarSecds21.IsNullable = true;
				colvarSecds21.IsPrimaryKey = false;
				colvarSecds21.IsForeignKey = false;
				colvarSecds21.IsReadOnly = false;
				colvarSecds21.DefaultSetting = @"";
				colvarSecds21.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecds21);
				
				TableSchema.TableColumn colvarSecds22 = new TableSchema.TableColumn(schema);
				colvarSecds22.ColumnName = "Secds22";
				colvarSecds22.DataType = DbType.String;
				colvarSecds22.MaxLength = 10;
				colvarSecds22.AutoIncrement = false;
				colvarSecds22.IsNullable = true;
				colvarSecds22.IsPrimaryKey = false;
				colvarSecds22.IsForeignKey = false;
				colvarSecds22.IsReadOnly = false;
				colvarSecds22.DefaultSetting = @"";
				colvarSecds22.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecds22);
				
				TableSchema.TableColumn colvarSecds23 = new TableSchema.TableColumn(schema);
				colvarSecds23.ColumnName = "Secds23";
				colvarSecds23.DataType = DbType.String;
				colvarSecds23.MaxLength = 10;
				colvarSecds23.AutoIncrement = false;
				colvarSecds23.IsNullable = true;
				colvarSecds23.IsPrimaryKey = false;
				colvarSecds23.IsForeignKey = false;
				colvarSecds23.IsReadOnly = false;
				colvarSecds23.DefaultSetting = @"";
				colvarSecds23.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecds23);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("DriverScore_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("DriverScoreId")]
		[Bindable(true)]
		public int DriverScoreId 
		{
			get { return GetColumnValue<int>(Columns.DriverScoreId); }
			set { SetColumnValue(Columns.DriverScoreId, value); }
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
		  
		[XmlAttribute("Selfds1")]
		[Bindable(true)]
		public string Selfds1 
		{
			get { return GetColumnValue<string>(Columns.Selfds1); }
			set { SetColumnValue(Columns.Selfds1, value); }
		}
		  
		[XmlAttribute("Selfds2")]
		[Bindable(true)]
		public string Selfds2 
		{
			get { return GetColumnValue<string>(Columns.Selfds2); }
			set { SetColumnValue(Columns.Selfds2, value); }
		}
		  
		[XmlAttribute("Selfds3")]
		[Bindable(true)]
		public string Selfds3 
		{
			get { return GetColumnValue<string>(Columns.Selfds3); }
			set { SetColumnValue(Columns.Selfds3, value); }
		}
		  
		[XmlAttribute("Selfds4")]
		[Bindable(true)]
		public string Selfds4 
		{
			get { return GetColumnValue<string>(Columns.Selfds4); }
			set { SetColumnValue(Columns.Selfds4, value); }
		}
		  
		[XmlAttribute("Selfds5")]
		[Bindable(true)]
		public string Selfds5 
		{
			get { return GetColumnValue<string>(Columns.Selfds5); }
			set { SetColumnValue(Columns.Selfds5, value); }
		}
		  
		[XmlAttribute("Selfds6")]
		[Bindable(true)]
		public string Selfds6 
		{
			get { return GetColumnValue<string>(Columns.Selfds6); }
			set { SetColumnValue(Columns.Selfds6, value); }
		}
		  
		[XmlAttribute("Selfds7")]
		[Bindable(true)]
		public string Selfds7 
		{
			get { return GetColumnValue<string>(Columns.Selfds7); }
			set { SetColumnValue(Columns.Selfds7, value); }
		}
		  
		[XmlAttribute("Selfds8")]
		[Bindable(true)]
		public string Selfds8 
		{
			get { return GetColumnValue<string>(Columns.Selfds8); }
			set { SetColumnValue(Columns.Selfds8, value); }
		}
		  
		[XmlAttribute("Selfds9")]
		[Bindable(true)]
		public string Selfds9 
		{
			get { return GetColumnValue<string>(Columns.Selfds9); }
			set { SetColumnValue(Columns.Selfds9, value); }
		}
		  
		[XmlAttribute("Selfds10")]
		[Bindable(true)]
		public string Selfds10 
		{
			get { return GetColumnValue<string>(Columns.Selfds10); }
			set { SetColumnValue(Columns.Selfds10, value); }
		}
		  
		[XmlAttribute("Selfds11")]
		[Bindable(true)]
		public string Selfds11 
		{
			get { return GetColumnValue<string>(Columns.Selfds11); }
			set { SetColumnValue(Columns.Selfds11, value); }
		}
		  
		[XmlAttribute("Selfds12")]
		[Bindable(true)]
		public string Selfds12 
		{
			get { return GetColumnValue<string>(Columns.Selfds12); }
			set { SetColumnValue(Columns.Selfds12, value); }
		}
		  
		[XmlAttribute("Selfds13")]
		[Bindable(true)]
		public string Selfds13 
		{
			get { return GetColumnValue<string>(Columns.Selfds13); }
			set { SetColumnValue(Columns.Selfds13, value); }
		}
		  
		[XmlAttribute("Selfds14")]
		[Bindable(true)]
		public string Selfds14 
		{
			get { return GetColumnValue<string>(Columns.Selfds14); }
			set { SetColumnValue(Columns.Selfds14, value); }
		}
		  
		[XmlAttribute("Selfds15")]
		[Bindable(true)]
		public string Selfds15 
		{
			get { return GetColumnValue<string>(Columns.Selfds15); }
			set { SetColumnValue(Columns.Selfds15, value); }
		}
		  
		[XmlAttribute("Selfds16")]
		[Bindable(true)]
		public string Selfds16 
		{
			get { return GetColumnValue<string>(Columns.Selfds16); }
			set { SetColumnValue(Columns.Selfds16, value); }
		}
		  
		[XmlAttribute("Selfds17")]
		[Bindable(true)]
		public string Selfds17 
		{
			get { return GetColumnValue<string>(Columns.Selfds17); }
			set { SetColumnValue(Columns.Selfds17, value); }
		}
		  
		[XmlAttribute("Selfds18")]
		[Bindable(true)]
		public string Selfds18 
		{
			get { return GetColumnValue<string>(Columns.Selfds18); }
			set { SetColumnValue(Columns.Selfds18, value); }
		}
		  
		[XmlAttribute("Selfds19")]
		[Bindable(true)]
		public string Selfds19 
		{
			get { return GetColumnValue<string>(Columns.Selfds19); }
			set { SetColumnValue(Columns.Selfds19, value); }
		}
		  
		[XmlAttribute("Selfds20")]
		[Bindable(true)]
		public string Selfds20 
		{
			get { return GetColumnValue<string>(Columns.Selfds20); }
			set { SetColumnValue(Columns.Selfds20, value); }
		}
		  
		[XmlAttribute("Selfds21")]
		[Bindable(true)]
		public string Selfds21 
		{
			get { return GetColumnValue<string>(Columns.Selfds21); }
			set { SetColumnValue(Columns.Selfds21, value); }
		}
		  
		[XmlAttribute("Selfds22")]
		[Bindable(true)]
		public string Selfds22 
		{
			get { return GetColumnValue<string>(Columns.Selfds22); }
			set { SetColumnValue(Columns.Selfds22, value); }
		}
		  
		[XmlAttribute("Selfds23")]
		[Bindable(true)]
		public string Selfds23 
		{
			get { return GetColumnValue<string>(Columns.Selfds23); }
			set { SetColumnValue(Columns.Selfds23, value); }
		}
		  
		[XmlAttribute("Upds1")]
		[Bindable(true)]
		public string Upds1 
		{
			get { return GetColumnValue<string>(Columns.Upds1); }
			set { SetColumnValue(Columns.Upds1, value); }
		}
		  
		[XmlAttribute("Upds2")]
		[Bindable(true)]
		public string Upds2 
		{
			get { return GetColumnValue<string>(Columns.Upds2); }
			set { SetColumnValue(Columns.Upds2, value); }
		}
		  
		[XmlAttribute("Upds3")]
		[Bindable(true)]
		public string Upds3 
		{
			get { return GetColumnValue<string>(Columns.Upds3); }
			set { SetColumnValue(Columns.Upds3, value); }
		}
		  
		[XmlAttribute("Upds4")]
		[Bindable(true)]
		public string Upds4 
		{
			get { return GetColumnValue<string>(Columns.Upds4); }
			set { SetColumnValue(Columns.Upds4, value); }
		}
		  
		[XmlAttribute("Upds5")]
		[Bindable(true)]
		public string Upds5 
		{
			get { return GetColumnValue<string>(Columns.Upds5); }
			set { SetColumnValue(Columns.Upds5, value); }
		}
		  
		[XmlAttribute("Upds6")]
		[Bindable(true)]
		public string Upds6 
		{
			get { return GetColumnValue<string>(Columns.Upds6); }
			set { SetColumnValue(Columns.Upds6, value); }
		}
		  
		[XmlAttribute("Upds7")]
		[Bindable(true)]
		public string Upds7 
		{
			get { return GetColumnValue<string>(Columns.Upds7); }
			set { SetColumnValue(Columns.Upds7, value); }
		}
		  
		[XmlAttribute("Upds8")]
		[Bindable(true)]
		public string Upds8 
		{
			get { return GetColumnValue<string>(Columns.Upds8); }
			set { SetColumnValue(Columns.Upds8, value); }
		}
		  
		[XmlAttribute("Upds9")]
		[Bindable(true)]
		public string Upds9 
		{
			get { return GetColumnValue<string>(Columns.Upds9); }
			set { SetColumnValue(Columns.Upds9, value); }
		}
		  
		[XmlAttribute("Upds10")]
		[Bindable(true)]
		public string Upds10 
		{
			get { return GetColumnValue<string>(Columns.Upds10); }
			set { SetColumnValue(Columns.Upds10, value); }
		}
		  
		[XmlAttribute("Upds11")]
		[Bindable(true)]
		public string Upds11 
		{
			get { return GetColumnValue<string>(Columns.Upds11); }
			set { SetColumnValue(Columns.Upds11, value); }
		}
		  
		[XmlAttribute("Upds12")]
		[Bindable(true)]
		public string Upds12 
		{
			get { return GetColumnValue<string>(Columns.Upds12); }
			set { SetColumnValue(Columns.Upds12, value); }
		}
		  
		[XmlAttribute("Upds13")]
		[Bindable(true)]
		public string Upds13 
		{
			get { return GetColumnValue<string>(Columns.Upds13); }
			set { SetColumnValue(Columns.Upds13, value); }
		}
		  
		[XmlAttribute("Upds14")]
		[Bindable(true)]
		public string Upds14 
		{
			get { return GetColumnValue<string>(Columns.Upds14); }
			set { SetColumnValue(Columns.Upds14, value); }
		}
		  
		[XmlAttribute("Upds15")]
		[Bindable(true)]
		public string Upds15 
		{
			get { return GetColumnValue<string>(Columns.Upds15); }
			set { SetColumnValue(Columns.Upds15, value); }
		}
		  
		[XmlAttribute("Upds16")]
		[Bindable(true)]
		public string Upds16 
		{
			get { return GetColumnValue<string>(Columns.Upds16); }
			set { SetColumnValue(Columns.Upds16, value); }
		}
		  
		[XmlAttribute("Upds17")]
		[Bindable(true)]
		public string Upds17 
		{
			get { return GetColumnValue<string>(Columns.Upds17); }
			set { SetColumnValue(Columns.Upds17, value); }
		}
		  
		[XmlAttribute("Upds18")]
		[Bindable(true)]
		public string Upds18 
		{
			get { return GetColumnValue<string>(Columns.Upds18); }
			set { SetColumnValue(Columns.Upds18, value); }
		}
		  
		[XmlAttribute("Upds19")]
		[Bindable(true)]
		public string Upds19 
		{
			get { return GetColumnValue<string>(Columns.Upds19); }
			set { SetColumnValue(Columns.Upds19, value); }
		}
		  
		[XmlAttribute("Upds20")]
		[Bindable(true)]
		public string Upds20 
		{
			get { return GetColumnValue<string>(Columns.Upds20); }
			set { SetColumnValue(Columns.Upds20, value); }
		}
		  
		[XmlAttribute("Upds21")]
		[Bindable(true)]
		public string Upds21 
		{
			get { return GetColumnValue<string>(Columns.Upds21); }
			set { SetColumnValue(Columns.Upds21, value); }
		}
		  
		[XmlAttribute("Upds22")]
		[Bindable(true)]
		public string Upds22 
		{
			get { return GetColumnValue<string>(Columns.Upds22); }
			set { SetColumnValue(Columns.Upds22, value); }
		}
		  
		[XmlAttribute("Upds23")]
		[Bindable(true)]
		public string Upds23 
		{
			get { return GetColumnValue<string>(Columns.Upds23); }
			set { SetColumnValue(Columns.Upds23, value); }
		}
		  
		[XmlAttribute("Secds1")]
		[Bindable(true)]
		public string Secds1 
		{
			get { return GetColumnValue<string>(Columns.Secds1); }
			set { SetColumnValue(Columns.Secds1, value); }
		}
		  
		[XmlAttribute("Secds2")]
		[Bindable(true)]
		public string Secds2 
		{
			get { return GetColumnValue<string>(Columns.Secds2); }
			set { SetColumnValue(Columns.Secds2, value); }
		}
		  
		[XmlAttribute("Secds3")]
		[Bindable(true)]
		public string Secds3 
		{
			get { return GetColumnValue<string>(Columns.Secds3); }
			set { SetColumnValue(Columns.Secds3, value); }
		}
		  
		[XmlAttribute("Secds4")]
		[Bindable(true)]
		public string Secds4 
		{
			get { return GetColumnValue<string>(Columns.Secds4); }
			set { SetColumnValue(Columns.Secds4, value); }
		}
		  
		[XmlAttribute("Secds5")]
		[Bindable(true)]
		public string Secds5 
		{
			get { return GetColumnValue<string>(Columns.Secds5); }
			set { SetColumnValue(Columns.Secds5, value); }
		}
		  
		[XmlAttribute("Secds6")]
		[Bindable(true)]
		public string Secds6 
		{
			get { return GetColumnValue<string>(Columns.Secds6); }
			set { SetColumnValue(Columns.Secds6, value); }
		}
		  
		[XmlAttribute("Secds7")]
		[Bindable(true)]
		public string Secds7 
		{
			get { return GetColumnValue<string>(Columns.Secds7); }
			set { SetColumnValue(Columns.Secds7, value); }
		}
		  
		[XmlAttribute("Secds8")]
		[Bindable(true)]
		public string Secds8 
		{
			get { return GetColumnValue<string>(Columns.Secds8); }
			set { SetColumnValue(Columns.Secds8, value); }
		}
		  
		[XmlAttribute("Secds9")]
		[Bindable(true)]
		public string Secds9 
		{
			get { return GetColumnValue<string>(Columns.Secds9); }
			set { SetColumnValue(Columns.Secds9, value); }
		}
		  
		[XmlAttribute("Secds10")]
		[Bindable(true)]
		public string Secds10 
		{
			get { return GetColumnValue<string>(Columns.Secds10); }
			set { SetColumnValue(Columns.Secds10, value); }
		}
		  
		[XmlAttribute("Secds11")]
		[Bindable(true)]
		public string Secds11 
		{
			get { return GetColumnValue<string>(Columns.Secds11); }
			set { SetColumnValue(Columns.Secds11, value); }
		}
		  
		[XmlAttribute("Secds12")]
		[Bindable(true)]
		public string Secds12 
		{
			get { return GetColumnValue<string>(Columns.Secds12); }
			set { SetColumnValue(Columns.Secds12, value); }
		}
		  
		[XmlAttribute("Secds13")]
		[Bindable(true)]
		public string Secds13 
		{
			get { return GetColumnValue<string>(Columns.Secds13); }
			set { SetColumnValue(Columns.Secds13, value); }
		}
		  
		[XmlAttribute("Secds14")]
		[Bindable(true)]
		public string Secds14 
		{
			get { return GetColumnValue<string>(Columns.Secds14); }
			set { SetColumnValue(Columns.Secds14, value); }
		}
		  
		[XmlAttribute("Secds15")]
		[Bindable(true)]
		public string Secds15 
		{
			get { return GetColumnValue<string>(Columns.Secds15); }
			set { SetColumnValue(Columns.Secds15, value); }
		}
		  
		[XmlAttribute("Secds16")]
		[Bindable(true)]
		public string Secds16 
		{
			get { return GetColumnValue<string>(Columns.Secds16); }
			set { SetColumnValue(Columns.Secds16, value); }
		}
		  
		[XmlAttribute("Secds17")]
		[Bindable(true)]
		public string Secds17 
		{
			get { return GetColumnValue<string>(Columns.Secds17); }
			set { SetColumnValue(Columns.Secds17, value); }
		}
		  
		[XmlAttribute("Secds18")]
		[Bindable(true)]
		public string Secds18 
		{
			get { return GetColumnValue<string>(Columns.Secds18); }
			set { SetColumnValue(Columns.Secds18, value); }
		}
		  
		[XmlAttribute("Secds19")]
		[Bindable(true)]
		public string Secds19 
		{
			get { return GetColumnValue<string>(Columns.Secds19); }
			set { SetColumnValue(Columns.Secds19, value); }
		}
		  
		[XmlAttribute("Secds20")]
		[Bindable(true)]
		public string Secds20 
		{
			get { return GetColumnValue<string>(Columns.Secds20); }
			set { SetColumnValue(Columns.Secds20, value); }
		}
		  
		[XmlAttribute("Secds21")]
		[Bindable(true)]
		public string Secds21 
		{
			get { return GetColumnValue<string>(Columns.Secds21); }
			set { SetColumnValue(Columns.Secds21, value); }
		}
		  
		[XmlAttribute("Secds22")]
		[Bindable(true)]
		public string Secds22 
		{
			get { return GetColumnValue<string>(Columns.Secds22); }
			set { SetColumnValue(Columns.Secds22, value); }
		}
		  
		[XmlAttribute("Secds23")]
		[Bindable(true)]
		public string Secds23 
		{
			get { return GetColumnValue<string>(Columns.Secds23); }
			set { SetColumnValue(Columns.Secds23, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varDateSpan,int? varEvaluateLevelId,string varTotalScore,string varUpViews,int? varYearId,int? varMonthId,int? varEmployeeId,int? varIsSubmit,string varSelfds1,string varSelfds2,string varSelfds3,string varSelfds4,string varSelfds5,string varSelfds6,string varSelfds7,string varSelfds8,string varSelfds9,string varSelfds10,string varSelfds11,string varSelfds12,string varSelfds13,string varSelfds14,string varSelfds15,string varSelfds16,string varSelfds17,string varSelfds18,string varSelfds19,string varSelfds20,string varSelfds21,string varSelfds22,string varSelfds23,string varUpds1,string varUpds2,string varUpds3,string varUpds4,string varUpds5,string varUpds6,string varUpds7,string varUpds8,string varUpds9,string varUpds10,string varUpds11,string varUpds12,string varUpds13,string varUpds14,string varUpds15,string varUpds16,string varUpds17,string varUpds18,string varUpds19,string varUpds20,string varUpds21,string varUpds22,string varUpds23,string varSecds1,string varSecds2,string varSecds3,string varSecds4,string varSecds5,string varSecds6,string varSecds7,string varSecds8,string varSecds9,string varSecds10,string varSecds11,string varSecds12,string varSecds13,string varSecds14,string varSecds15,string varSecds16,string varSecds17,string varSecds18,string varSecds19,string varSecds20,string varSecds21,string varSecds22,string varSecds23)
		{
			DriverScore item = new DriverScore();
			
			item.DateSpan = varDateSpan;
			
			item.EvaluateLevelId = varEvaluateLevelId;
			
			item.TotalScore = varTotalScore;
			
			item.UpViews = varUpViews;
			
			item.YearId = varYearId;
			
			item.MonthId = varMonthId;
			
			item.EmployeeId = varEmployeeId;
			
			item.IsSubmit = varIsSubmit;
			
			item.Selfds1 = varSelfds1;
			
			item.Selfds2 = varSelfds2;
			
			item.Selfds3 = varSelfds3;
			
			item.Selfds4 = varSelfds4;
			
			item.Selfds5 = varSelfds5;
			
			item.Selfds6 = varSelfds6;
			
			item.Selfds7 = varSelfds7;
			
			item.Selfds8 = varSelfds8;
			
			item.Selfds9 = varSelfds9;
			
			item.Selfds10 = varSelfds10;
			
			item.Selfds11 = varSelfds11;
			
			item.Selfds12 = varSelfds12;
			
			item.Selfds13 = varSelfds13;
			
			item.Selfds14 = varSelfds14;
			
			item.Selfds15 = varSelfds15;
			
			item.Selfds16 = varSelfds16;
			
			item.Selfds17 = varSelfds17;
			
			item.Selfds18 = varSelfds18;
			
			item.Selfds19 = varSelfds19;
			
			item.Selfds20 = varSelfds20;
			
			item.Selfds21 = varSelfds21;
			
			item.Selfds22 = varSelfds22;
			
			item.Selfds23 = varSelfds23;
			
			item.Upds1 = varUpds1;
			
			item.Upds2 = varUpds2;
			
			item.Upds3 = varUpds3;
			
			item.Upds4 = varUpds4;
			
			item.Upds5 = varUpds5;
			
			item.Upds6 = varUpds6;
			
			item.Upds7 = varUpds7;
			
			item.Upds8 = varUpds8;
			
			item.Upds9 = varUpds9;
			
			item.Upds10 = varUpds10;
			
			item.Upds11 = varUpds11;
			
			item.Upds12 = varUpds12;
			
			item.Upds13 = varUpds13;
			
			item.Upds14 = varUpds14;
			
			item.Upds15 = varUpds15;
			
			item.Upds16 = varUpds16;
			
			item.Upds17 = varUpds17;
			
			item.Upds18 = varUpds18;
			
			item.Upds19 = varUpds19;
			
			item.Upds20 = varUpds20;
			
			item.Upds21 = varUpds21;
			
			item.Upds22 = varUpds22;
			
			item.Upds23 = varUpds23;
			
			item.Secds1 = varSecds1;
			
			item.Secds2 = varSecds2;
			
			item.Secds3 = varSecds3;
			
			item.Secds4 = varSecds4;
			
			item.Secds5 = varSecds5;
			
			item.Secds6 = varSecds6;
			
			item.Secds7 = varSecds7;
			
			item.Secds8 = varSecds8;
			
			item.Secds9 = varSecds9;
			
			item.Secds10 = varSecds10;
			
			item.Secds11 = varSecds11;
			
			item.Secds12 = varSecds12;
			
			item.Secds13 = varSecds13;
			
			item.Secds14 = varSecds14;
			
			item.Secds15 = varSecds15;
			
			item.Secds16 = varSecds16;
			
			item.Secds17 = varSecds17;
			
			item.Secds18 = varSecds18;
			
			item.Secds19 = varSecds19;
			
			item.Secds20 = varSecds20;
			
			item.Secds21 = varSecds21;
			
			item.Secds22 = varSecds22;
			
			item.Secds23 = varSecds23;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varDriverScoreId,string varDateSpan,int? varEvaluateLevelId,string varTotalScore,string varUpViews,int? varYearId,int? varMonthId,int? varEmployeeId,int? varIsSubmit,string varSelfds1,string varSelfds2,string varSelfds3,string varSelfds4,string varSelfds5,string varSelfds6,string varSelfds7,string varSelfds8,string varSelfds9,string varSelfds10,string varSelfds11,string varSelfds12,string varSelfds13,string varSelfds14,string varSelfds15,string varSelfds16,string varSelfds17,string varSelfds18,string varSelfds19,string varSelfds20,string varSelfds21,string varSelfds22,string varSelfds23,string varUpds1,string varUpds2,string varUpds3,string varUpds4,string varUpds5,string varUpds6,string varUpds7,string varUpds8,string varUpds9,string varUpds10,string varUpds11,string varUpds12,string varUpds13,string varUpds14,string varUpds15,string varUpds16,string varUpds17,string varUpds18,string varUpds19,string varUpds20,string varUpds21,string varUpds22,string varUpds23,string varSecds1,string varSecds2,string varSecds3,string varSecds4,string varSecds5,string varSecds6,string varSecds7,string varSecds8,string varSecds9,string varSecds10,string varSecds11,string varSecds12,string varSecds13,string varSecds14,string varSecds15,string varSecds16,string varSecds17,string varSecds18,string varSecds19,string varSecds20,string varSecds21,string varSecds22,string varSecds23)
		{
			DriverScore item = new DriverScore();
			
				item.DriverScoreId = varDriverScoreId;
			
				item.DateSpan = varDateSpan;
			
				item.EvaluateLevelId = varEvaluateLevelId;
			
				item.TotalScore = varTotalScore;
			
				item.UpViews = varUpViews;
			
				item.YearId = varYearId;
			
				item.MonthId = varMonthId;
			
				item.EmployeeId = varEmployeeId;
			
				item.IsSubmit = varIsSubmit;
			
				item.Selfds1 = varSelfds1;
			
				item.Selfds2 = varSelfds2;
			
				item.Selfds3 = varSelfds3;
			
				item.Selfds4 = varSelfds4;
			
				item.Selfds5 = varSelfds5;
			
				item.Selfds6 = varSelfds6;
			
				item.Selfds7 = varSelfds7;
			
				item.Selfds8 = varSelfds8;
			
				item.Selfds9 = varSelfds9;
			
				item.Selfds10 = varSelfds10;
			
				item.Selfds11 = varSelfds11;
			
				item.Selfds12 = varSelfds12;
			
				item.Selfds13 = varSelfds13;
			
				item.Selfds14 = varSelfds14;
			
				item.Selfds15 = varSelfds15;
			
				item.Selfds16 = varSelfds16;
			
				item.Selfds17 = varSelfds17;
			
				item.Selfds18 = varSelfds18;
			
				item.Selfds19 = varSelfds19;
			
				item.Selfds20 = varSelfds20;
			
				item.Selfds21 = varSelfds21;
			
				item.Selfds22 = varSelfds22;
			
				item.Selfds23 = varSelfds23;
			
				item.Upds1 = varUpds1;
			
				item.Upds2 = varUpds2;
			
				item.Upds3 = varUpds3;
			
				item.Upds4 = varUpds4;
			
				item.Upds5 = varUpds5;
			
				item.Upds6 = varUpds6;
			
				item.Upds7 = varUpds7;
			
				item.Upds8 = varUpds8;
			
				item.Upds9 = varUpds9;
			
				item.Upds10 = varUpds10;
			
				item.Upds11 = varUpds11;
			
				item.Upds12 = varUpds12;
			
				item.Upds13 = varUpds13;
			
				item.Upds14 = varUpds14;
			
				item.Upds15 = varUpds15;
			
				item.Upds16 = varUpds16;
			
				item.Upds17 = varUpds17;
			
				item.Upds18 = varUpds18;
			
				item.Upds19 = varUpds19;
			
				item.Upds20 = varUpds20;
			
				item.Upds21 = varUpds21;
			
				item.Upds22 = varUpds22;
			
				item.Upds23 = varUpds23;
			
				item.Secds1 = varSecds1;
			
				item.Secds2 = varSecds2;
			
				item.Secds3 = varSecds3;
			
				item.Secds4 = varSecds4;
			
				item.Secds5 = varSecds5;
			
				item.Secds6 = varSecds6;
			
				item.Secds7 = varSecds7;
			
				item.Secds8 = varSecds8;
			
				item.Secds9 = varSecds9;
			
				item.Secds10 = varSecds10;
			
				item.Secds11 = varSecds11;
			
				item.Secds12 = varSecds12;
			
				item.Secds13 = varSecds13;
			
				item.Secds14 = varSecds14;
			
				item.Secds15 = varSecds15;
			
				item.Secds16 = varSecds16;
			
				item.Secds17 = varSecds17;
			
				item.Secds18 = varSecds18;
			
				item.Secds19 = varSecds19;
			
				item.Secds20 = varSecds20;
			
				item.Secds21 = varSecds21;
			
				item.Secds22 = varSecds22;
			
				item.Secds23 = varSecds23;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn DriverScoreIdColumn
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
        
        
        
        public static TableSchema.TableColumn Selfds1Column
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfds2Column
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfds3Column
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfds4Column
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfds5Column
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfds6Column
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfds7Column
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfds8Column
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfds9Column
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfds10Column
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfds11Column
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfds12Column
        {
            get { return Schema.Columns[20]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfds13Column
        {
            get { return Schema.Columns[21]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfds14Column
        {
            get { return Schema.Columns[22]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfds15Column
        {
            get { return Schema.Columns[23]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfds16Column
        {
            get { return Schema.Columns[24]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfds17Column
        {
            get { return Schema.Columns[25]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfds18Column
        {
            get { return Schema.Columns[26]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfds19Column
        {
            get { return Schema.Columns[27]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfds20Column
        {
            get { return Schema.Columns[28]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfds21Column
        {
            get { return Schema.Columns[29]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfds22Column
        {
            get { return Schema.Columns[30]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfds23Column
        {
            get { return Schema.Columns[31]; }
        }
        
        
        
        public static TableSchema.TableColumn Upds1Column
        {
            get { return Schema.Columns[32]; }
        }
        
        
        
        public static TableSchema.TableColumn Upds2Column
        {
            get { return Schema.Columns[33]; }
        }
        
        
        
        public static TableSchema.TableColumn Upds3Column
        {
            get { return Schema.Columns[34]; }
        }
        
        
        
        public static TableSchema.TableColumn Upds4Column
        {
            get { return Schema.Columns[35]; }
        }
        
        
        
        public static TableSchema.TableColumn Upds5Column
        {
            get { return Schema.Columns[36]; }
        }
        
        
        
        public static TableSchema.TableColumn Upds6Column
        {
            get { return Schema.Columns[37]; }
        }
        
        
        
        public static TableSchema.TableColumn Upds7Column
        {
            get { return Schema.Columns[38]; }
        }
        
        
        
        public static TableSchema.TableColumn Upds8Column
        {
            get { return Schema.Columns[39]; }
        }
        
        
        
        public static TableSchema.TableColumn Upds9Column
        {
            get { return Schema.Columns[40]; }
        }
        
        
        
        public static TableSchema.TableColumn Upds10Column
        {
            get { return Schema.Columns[41]; }
        }
        
        
        
        public static TableSchema.TableColumn Upds11Column
        {
            get { return Schema.Columns[42]; }
        }
        
        
        
        public static TableSchema.TableColumn Upds12Column
        {
            get { return Schema.Columns[43]; }
        }
        
        
        
        public static TableSchema.TableColumn Upds13Column
        {
            get { return Schema.Columns[44]; }
        }
        
        
        
        public static TableSchema.TableColumn Upds14Column
        {
            get { return Schema.Columns[45]; }
        }
        
        
        
        public static TableSchema.TableColumn Upds15Column
        {
            get { return Schema.Columns[46]; }
        }
        
        
        
        public static TableSchema.TableColumn Upds16Column
        {
            get { return Schema.Columns[47]; }
        }
        
        
        
        public static TableSchema.TableColumn Upds17Column
        {
            get { return Schema.Columns[48]; }
        }
        
        
        
        public static TableSchema.TableColumn Upds18Column
        {
            get { return Schema.Columns[49]; }
        }
        
        
        
        public static TableSchema.TableColumn Upds19Column
        {
            get { return Schema.Columns[50]; }
        }
        
        
        
        public static TableSchema.TableColumn Upds20Column
        {
            get { return Schema.Columns[51]; }
        }
        
        
        
        public static TableSchema.TableColumn Upds21Column
        {
            get { return Schema.Columns[52]; }
        }
        
        
        
        public static TableSchema.TableColumn Upds22Column
        {
            get { return Schema.Columns[53]; }
        }
        
        
        
        public static TableSchema.TableColumn Upds23Column
        {
            get { return Schema.Columns[54]; }
        }
        
        
        
        public static TableSchema.TableColumn Secds1Column
        {
            get { return Schema.Columns[55]; }
        }
        
        
        
        public static TableSchema.TableColumn Secds2Column
        {
            get { return Schema.Columns[56]; }
        }
        
        
        
        public static TableSchema.TableColumn Secds3Column
        {
            get { return Schema.Columns[57]; }
        }
        
        
        
        public static TableSchema.TableColumn Secds4Column
        {
            get { return Schema.Columns[58]; }
        }
        
        
        
        public static TableSchema.TableColumn Secds5Column
        {
            get { return Schema.Columns[59]; }
        }
        
        
        
        public static TableSchema.TableColumn Secds6Column
        {
            get { return Schema.Columns[60]; }
        }
        
        
        
        public static TableSchema.TableColumn Secds7Column
        {
            get { return Schema.Columns[61]; }
        }
        
        
        
        public static TableSchema.TableColumn Secds8Column
        {
            get { return Schema.Columns[62]; }
        }
        
        
        
        public static TableSchema.TableColumn Secds9Column
        {
            get { return Schema.Columns[63]; }
        }
        
        
        
        public static TableSchema.TableColumn Secds10Column
        {
            get { return Schema.Columns[64]; }
        }
        
        
        
        public static TableSchema.TableColumn Secds11Column
        {
            get { return Schema.Columns[65]; }
        }
        
        
        
        public static TableSchema.TableColumn Secds12Column
        {
            get { return Schema.Columns[66]; }
        }
        
        
        
        public static TableSchema.TableColumn Secds13Column
        {
            get { return Schema.Columns[67]; }
        }
        
        
        
        public static TableSchema.TableColumn Secds14Column
        {
            get { return Schema.Columns[68]; }
        }
        
        
        
        public static TableSchema.TableColumn Secds15Column
        {
            get { return Schema.Columns[69]; }
        }
        
        
        
        public static TableSchema.TableColumn Secds16Column
        {
            get { return Schema.Columns[70]; }
        }
        
        
        
        public static TableSchema.TableColumn Secds17Column
        {
            get { return Schema.Columns[71]; }
        }
        
        
        
        public static TableSchema.TableColumn Secds18Column
        {
            get { return Schema.Columns[72]; }
        }
        
        
        
        public static TableSchema.TableColumn Secds19Column
        {
            get { return Schema.Columns[73]; }
        }
        
        
        
        public static TableSchema.TableColumn Secds20Column
        {
            get { return Schema.Columns[74]; }
        }
        
        
        
        public static TableSchema.TableColumn Secds21Column
        {
            get { return Schema.Columns[75]; }
        }
        
        
        
        public static TableSchema.TableColumn Secds22Column
        {
            get { return Schema.Columns[76]; }
        }
        
        
        
        public static TableSchema.TableColumn Secds23Column
        {
            get { return Schema.Columns[77]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string DriverScoreId = @"DriverScoreId";
			 public static string DateSpan = @"DateSpan";
			 public static string EvaluateLevelId = @"EvaluateLevelId";
			 public static string TotalScore = @"TotalScore";
			 public static string UpViews = @"UpViews";
			 public static string YearId = @"YearId";
			 public static string MonthId = @"MonthId";
			 public static string EmployeeId = @"EmployeeId";
			 public static string IsSubmit = @"IsSubmit";
			 public static string Selfds1 = @"Selfds1";
			 public static string Selfds2 = @"Selfds2";
			 public static string Selfds3 = @"Selfds3";
			 public static string Selfds4 = @"Selfds4";
			 public static string Selfds5 = @"Selfds5";
			 public static string Selfds6 = @"Selfds6";
			 public static string Selfds7 = @"Selfds7";
			 public static string Selfds8 = @"Selfds8";
			 public static string Selfds9 = @"Selfds9";
			 public static string Selfds10 = @"Selfds10";
			 public static string Selfds11 = @"Selfds11";
			 public static string Selfds12 = @"Selfds12";
			 public static string Selfds13 = @"Selfds13";
			 public static string Selfds14 = @"Selfds14";
			 public static string Selfds15 = @"Selfds15";
			 public static string Selfds16 = @"Selfds16";
			 public static string Selfds17 = @"Selfds17";
			 public static string Selfds18 = @"Selfds18";
			 public static string Selfds19 = @"Selfds19";
			 public static string Selfds20 = @"Selfds20";
			 public static string Selfds21 = @"Selfds21";
			 public static string Selfds22 = @"Selfds22";
			 public static string Selfds23 = @"Selfds23";
			 public static string Upds1 = @"Upds1";
			 public static string Upds2 = @"Upds2";
			 public static string Upds3 = @"Upds3";
			 public static string Upds4 = @"Upds4";
			 public static string Upds5 = @"Upds5";
			 public static string Upds6 = @"Upds6";
			 public static string Upds7 = @"Upds7";
			 public static string Upds8 = @"Upds8";
			 public static string Upds9 = @"Upds9";
			 public static string Upds10 = @"Upds10";
			 public static string Upds11 = @"Upds11";
			 public static string Upds12 = @"Upds12";
			 public static string Upds13 = @"Upds13";
			 public static string Upds14 = @"Upds14";
			 public static string Upds15 = @"Upds15";
			 public static string Upds16 = @"Upds16";
			 public static string Upds17 = @"Upds17";
			 public static string Upds18 = @"Upds18";
			 public static string Upds19 = @"Upds19";
			 public static string Upds20 = @"Upds20";
			 public static string Upds21 = @"Upds21";
			 public static string Upds22 = @"Upds22";
			 public static string Upds23 = @"Upds23";
			 public static string Secds1 = @"Secds1";
			 public static string Secds2 = @"Secds2";
			 public static string Secds3 = @"Secds3";
			 public static string Secds4 = @"Secds4";
			 public static string Secds5 = @"Secds5";
			 public static string Secds6 = @"Secds6";
			 public static string Secds7 = @"Secds7";
			 public static string Secds8 = @"Secds8";
			 public static string Secds9 = @"Secds9";
			 public static string Secds10 = @"Secds10";
			 public static string Secds11 = @"Secds11";
			 public static string Secds12 = @"Secds12";
			 public static string Secds13 = @"Secds13";
			 public static string Secds14 = @"Secds14";
			 public static string Secds15 = @"Secds15";
			 public static string Secds16 = @"Secds16";
			 public static string Secds17 = @"Secds17";
			 public static string Secds18 = @"Secds18";
			 public static string Secds19 = @"Secds19";
			 public static string Secds20 = @"Secds20";
			 public static string Secds21 = @"Secds21";
			 public static string Secds22 = @"Secds22";
			 public static string Secds23 = @"Secds23";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
