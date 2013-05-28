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
	/// Strongly-typed collection for the MarketScore class.
	/// </summary>
    [Serializable]
	public partial class MarketScoreCollection : ActiveList<MarketScore, MarketScoreCollection>
	{	   
		public MarketScoreCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>MarketScoreCollection</returns>
		public MarketScoreCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                MarketScore o = this[i];
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
	/// This is an ActiveRecord class which wraps the MarketScore_tb table.
	/// </summary>
	[Serializable]
	public partial class MarketScore : ActiveRecord<MarketScore>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public MarketScore()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public MarketScore(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public MarketScore(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public MarketScore(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("MarketScore_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarMarketScoreId = new TableSchema.TableColumn(schema);
				colvarMarketScoreId.ColumnName = "MarketScoreId";
				colvarMarketScoreId.DataType = DbType.Int32;
				colvarMarketScoreId.MaxLength = 0;
				colvarMarketScoreId.AutoIncrement = true;
				colvarMarketScoreId.IsNullable = false;
				colvarMarketScoreId.IsPrimaryKey = true;
				colvarMarketScoreId.IsForeignKey = false;
				colvarMarketScoreId.IsReadOnly = false;
				colvarMarketScoreId.DefaultSetting = @"";
				colvarMarketScoreId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMarketScoreId);
				
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
				
				TableSchema.TableColumn colvarSelfms1 = new TableSchema.TableColumn(schema);
				colvarSelfms1.ColumnName = "Selfms1";
				colvarSelfms1.DataType = DbType.String;
				colvarSelfms1.MaxLength = 10;
				colvarSelfms1.AutoIncrement = false;
				colvarSelfms1.IsNullable = true;
				colvarSelfms1.IsPrimaryKey = false;
				colvarSelfms1.IsForeignKey = false;
				colvarSelfms1.IsReadOnly = false;
				colvarSelfms1.DefaultSetting = @"";
				colvarSelfms1.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfms1);
				
				TableSchema.TableColumn colvarSelfms2 = new TableSchema.TableColumn(schema);
				colvarSelfms2.ColumnName = "Selfms2";
				colvarSelfms2.DataType = DbType.String;
				colvarSelfms2.MaxLength = 10;
				colvarSelfms2.AutoIncrement = false;
				colvarSelfms2.IsNullable = true;
				colvarSelfms2.IsPrimaryKey = false;
				colvarSelfms2.IsForeignKey = false;
				colvarSelfms2.IsReadOnly = false;
				colvarSelfms2.DefaultSetting = @"";
				colvarSelfms2.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfms2);
				
				TableSchema.TableColumn colvarSelfms3 = new TableSchema.TableColumn(schema);
				colvarSelfms3.ColumnName = "Selfms3";
				colvarSelfms3.DataType = DbType.String;
				colvarSelfms3.MaxLength = 10;
				colvarSelfms3.AutoIncrement = false;
				colvarSelfms3.IsNullable = true;
				colvarSelfms3.IsPrimaryKey = false;
				colvarSelfms3.IsForeignKey = false;
				colvarSelfms3.IsReadOnly = false;
				colvarSelfms3.DefaultSetting = @"";
				colvarSelfms3.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfms3);
				
				TableSchema.TableColumn colvarSelfms4 = new TableSchema.TableColumn(schema);
				colvarSelfms4.ColumnName = "Selfms4";
				colvarSelfms4.DataType = DbType.String;
				colvarSelfms4.MaxLength = 10;
				colvarSelfms4.AutoIncrement = false;
				colvarSelfms4.IsNullable = true;
				colvarSelfms4.IsPrimaryKey = false;
				colvarSelfms4.IsForeignKey = false;
				colvarSelfms4.IsReadOnly = false;
				colvarSelfms4.DefaultSetting = @"";
				colvarSelfms4.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfms4);
				
				TableSchema.TableColumn colvarSelfms5 = new TableSchema.TableColumn(schema);
				colvarSelfms5.ColumnName = "Selfms5";
				colvarSelfms5.DataType = DbType.String;
				colvarSelfms5.MaxLength = 10;
				colvarSelfms5.AutoIncrement = false;
				colvarSelfms5.IsNullable = true;
				colvarSelfms5.IsPrimaryKey = false;
				colvarSelfms5.IsForeignKey = false;
				colvarSelfms5.IsReadOnly = false;
				colvarSelfms5.DefaultSetting = @"";
				colvarSelfms5.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfms5);
				
				TableSchema.TableColumn colvarSelfms6 = new TableSchema.TableColumn(schema);
				colvarSelfms6.ColumnName = "Selfms6";
				colvarSelfms6.DataType = DbType.String;
				colvarSelfms6.MaxLength = 10;
				colvarSelfms6.AutoIncrement = false;
				colvarSelfms6.IsNullable = true;
				colvarSelfms6.IsPrimaryKey = false;
				colvarSelfms6.IsForeignKey = false;
				colvarSelfms6.IsReadOnly = false;
				colvarSelfms6.DefaultSetting = @"";
				colvarSelfms6.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfms6);
				
				TableSchema.TableColumn colvarSelfms7 = new TableSchema.TableColumn(schema);
				colvarSelfms7.ColumnName = "Selfms7";
				colvarSelfms7.DataType = DbType.String;
				colvarSelfms7.MaxLength = 10;
				colvarSelfms7.AutoIncrement = false;
				colvarSelfms7.IsNullable = true;
				colvarSelfms7.IsPrimaryKey = false;
				colvarSelfms7.IsForeignKey = false;
				colvarSelfms7.IsReadOnly = false;
				colvarSelfms7.DefaultSetting = @"";
				colvarSelfms7.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfms7);
				
				TableSchema.TableColumn colvarSelfms8 = new TableSchema.TableColumn(schema);
				colvarSelfms8.ColumnName = "Selfms8";
				colvarSelfms8.DataType = DbType.String;
				colvarSelfms8.MaxLength = 10;
				colvarSelfms8.AutoIncrement = false;
				colvarSelfms8.IsNullable = true;
				colvarSelfms8.IsPrimaryKey = false;
				colvarSelfms8.IsForeignKey = false;
				colvarSelfms8.IsReadOnly = false;
				colvarSelfms8.DefaultSetting = @"";
				colvarSelfms8.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfms8);
				
				TableSchema.TableColumn colvarSelfms9 = new TableSchema.TableColumn(schema);
				colvarSelfms9.ColumnName = "Selfms9";
				colvarSelfms9.DataType = DbType.String;
				colvarSelfms9.MaxLength = 10;
				colvarSelfms9.AutoIncrement = false;
				colvarSelfms9.IsNullable = true;
				colvarSelfms9.IsPrimaryKey = false;
				colvarSelfms9.IsForeignKey = false;
				colvarSelfms9.IsReadOnly = false;
				colvarSelfms9.DefaultSetting = @"";
				colvarSelfms9.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfms9);
				
				TableSchema.TableColumn colvarSelfms10 = new TableSchema.TableColumn(schema);
				colvarSelfms10.ColumnName = "Selfms10";
				colvarSelfms10.DataType = DbType.String;
				colvarSelfms10.MaxLength = 10;
				colvarSelfms10.AutoIncrement = false;
				colvarSelfms10.IsNullable = true;
				colvarSelfms10.IsPrimaryKey = false;
				colvarSelfms10.IsForeignKey = false;
				colvarSelfms10.IsReadOnly = false;
				colvarSelfms10.DefaultSetting = @"";
				colvarSelfms10.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfms10);
				
				TableSchema.TableColumn colvarSelfms11 = new TableSchema.TableColumn(schema);
				colvarSelfms11.ColumnName = "Selfms11";
				colvarSelfms11.DataType = DbType.String;
				colvarSelfms11.MaxLength = 10;
				colvarSelfms11.AutoIncrement = false;
				colvarSelfms11.IsNullable = true;
				colvarSelfms11.IsPrimaryKey = false;
				colvarSelfms11.IsForeignKey = false;
				colvarSelfms11.IsReadOnly = false;
				colvarSelfms11.DefaultSetting = @"";
				colvarSelfms11.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfms11);
				
				TableSchema.TableColumn colvarSelfms12 = new TableSchema.TableColumn(schema);
				colvarSelfms12.ColumnName = "Selfms12";
				colvarSelfms12.DataType = DbType.String;
				colvarSelfms12.MaxLength = 10;
				colvarSelfms12.AutoIncrement = false;
				colvarSelfms12.IsNullable = true;
				colvarSelfms12.IsPrimaryKey = false;
				colvarSelfms12.IsForeignKey = false;
				colvarSelfms12.IsReadOnly = false;
				colvarSelfms12.DefaultSetting = @"";
				colvarSelfms12.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfms12);
				
				TableSchema.TableColumn colvarSelfms13 = new TableSchema.TableColumn(schema);
				colvarSelfms13.ColumnName = "Selfms13";
				colvarSelfms13.DataType = DbType.String;
				colvarSelfms13.MaxLength = 10;
				colvarSelfms13.AutoIncrement = false;
				colvarSelfms13.IsNullable = true;
				colvarSelfms13.IsPrimaryKey = false;
				colvarSelfms13.IsForeignKey = false;
				colvarSelfms13.IsReadOnly = false;
				colvarSelfms13.DefaultSetting = @"";
				colvarSelfms13.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfms13);
				
				TableSchema.TableColumn colvarSelfms14 = new TableSchema.TableColumn(schema);
				colvarSelfms14.ColumnName = "Selfms14";
				colvarSelfms14.DataType = DbType.String;
				colvarSelfms14.MaxLength = 10;
				colvarSelfms14.AutoIncrement = false;
				colvarSelfms14.IsNullable = true;
				colvarSelfms14.IsPrimaryKey = false;
				colvarSelfms14.IsForeignKey = false;
				colvarSelfms14.IsReadOnly = false;
				colvarSelfms14.DefaultSetting = @"";
				colvarSelfms14.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfms14);
				
				TableSchema.TableColumn colvarSelfms15 = new TableSchema.TableColumn(schema);
				colvarSelfms15.ColumnName = "Selfms15";
				colvarSelfms15.DataType = DbType.String;
				colvarSelfms15.MaxLength = 10;
				colvarSelfms15.AutoIncrement = false;
				colvarSelfms15.IsNullable = true;
				colvarSelfms15.IsPrimaryKey = false;
				colvarSelfms15.IsForeignKey = false;
				colvarSelfms15.IsReadOnly = false;
				colvarSelfms15.DefaultSetting = @"";
				colvarSelfms15.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfms15);
				
				TableSchema.TableColumn colvarSelfms16 = new TableSchema.TableColumn(schema);
				colvarSelfms16.ColumnName = "Selfms16";
				colvarSelfms16.DataType = DbType.String;
				colvarSelfms16.MaxLength = 10;
				colvarSelfms16.AutoIncrement = false;
				colvarSelfms16.IsNullable = true;
				colvarSelfms16.IsPrimaryKey = false;
				colvarSelfms16.IsForeignKey = false;
				colvarSelfms16.IsReadOnly = false;
				colvarSelfms16.DefaultSetting = @"";
				colvarSelfms16.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfms16);
				
				TableSchema.TableColumn colvarSelfms17 = new TableSchema.TableColumn(schema);
				colvarSelfms17.ColumnName = "Selfms17";
				colvarSelfms17.DataType = DbType.String;
				colvarSelfms17.MaxLength = 10;
				colvarSelfms17.AutoIncrement = false;
				colvarSelfms17.IsNullable = true;
				colvarSelfms17.IsPrimaryKey = false;
				colvarSelfms17.IsForeignKey = false;
				colvarSelfms17.IsReadOnly = false;
				colvarSelfms17.DefaultSetting = @"";
				colvarSelfms17.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfms17);
				
				TableSchema.TableColumn colvarSelfms18 = new TableSchema.TableColumn(schema);
				colvarSelfms18.ColumnName = "Selfms18";
				colvarSelfms18.DataType = DbType.String;
				colvarSelfms18.MaxLength = 10;
				colvarSelfms18.AutoIncrement = false;
				colvarSelfms18.IsNullable = true;
				colvarSelfms18.IsPrimaryKey = false;
				colvarSelfms18.IsForeignKey = false;
				colvarSelfms18.IsReadOnly = false;
				colvarSelfms18.DefaultSetting = @"";
				colvarSelfms18.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfms18);
				
				TableSchema.TableColumn colvarSelfms19 = new TableSchema.TableColumn(schema);
				colvarSelfms19.ColumnName = "Selfms19";
				colvarSelfms19.DataType = DbType.String;
				colvarSelfms19.MaxLength = 10;
				colvarSelfms19.AutoIncrement = false;
				colvarSelfms19.IsNullable = true;
				colvarSelfms19.IsPrimaryKey = false;
				colvarSelfms19.IsForeignKey = false;
				colvarSelfms19.IsReadOnly = false;
				colvarSelfms19.DefaultSetting = @"";
				colvarSelfms19.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfms19);
				
				TableSchema.TableColumn colvarSelfms20 = new TableSchema.TableColumn(schema);
				colvarSelfms20.ColumnName = "Selfms20";
				colvarSelfms20.DataType = DbType.String;
				colvarSelfms20.MaxLength = 10;
				colvarSelfms20.AutoIncrement = false;
				colvarSelfms20.IsNullable = true;
				colvarSelfms20.IsPrimaryKey = false;
				colvarSelfms20.IsForeignKey = false;
				colvarSelfms20.IsReadOnly = false;
				colvarSelfms20.DefaultSetting = @"";
				colvarSelfms20.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfms20);
				
				TableSchema.TableColumn colvarSelfms21 = new TableSchema.TableColumn(schema);
				colvarSelfms21.ColumnName = "Selfms21";
				colvarSelfms21.DataType = DbType.String;
				colvarSelfms21.MaxLength = 10;
				colvarSelfms21.AutoIncrement = false;
				colvarSelfms21.IsNullable = true;
				colvarSelfms21.IsPrimaryKey = false;
				colvarSelfms21.IsForeignKey = false;
				colvarSelfms21.IsReadOnly = false;
				colvarSelfms21.DefaultSetting = @"";
				colvarSelfms21.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfms21);
				
				TableSchema.TableColumn colvarSelfms22 = new TableSchema.TableColumn(schema);
				colvarSelfms22.ColumnName = "Selfms22";
				colvarSelfms22.DataType = DbType.String;
				colvarSelfms22.MaxLength = 10;
				colvarSelfms22.AutoIncrement = false;
				colvarSelfms22.IsNullable = true;
				colvarSelfms22.IsPrimaryKey = false;
				colvarSelfms22.IsForeignKey = false;
				colvarSelfms22.IsReadOnly = false;
				colvarSelfms22.DefaultSetting = @"";
				colvarSelfms22.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfms22);
				
				TableSchema.TableColumn colvarSelfms23 = new TableSchema.TableColumn(schema);
				colvarSelfms23.ColumnName = "Selfms23";
				colvarSelfms23.DataType = DbType.String;
				colvarSelfms23.MaxLength = 10;
				colvarSelfms23.AutoIncrement = false;
				colvarSelfms23.IsNullable = true;
				colvarSelfms23.IsPrimaryKey = false;
				colvarSelfms23.IsForeignKey = false;
				colvarSelfms23.IsReadOnly = false;
				colvarSelfms23.DefaultSetting = @"";
				colvarSelfms23.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfms23);
				
				TableSchema.TableColumn colvarSelfms24 = new TableSchema.TableColumn(schema);
				colvarSelfms24.ColumnName = "Selfms24";
				colvarSelfms24.DataType = DbType.String;
				colvarSelfms24.MaxLength = 10;
				colvarSelfms24.AutoIncrement = false;
				colvarSelfms24.IsNullable = true;
				colvarSelfms24.IsPrimaryKey = false;
				colvarSelfms24.IsForeignKey = false;
				colvarSelfms24.IsReadOnly = false;
				colvarSelfms24.DefaultSetting = @"";
				colvarSelfms24.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfms24);
				
				TableSchema.TableColumn colvarUpms1 = new TableSchema.TableColumn(schema);
				colvarUpms1.ColumnName = "Upms1";
				colvarUpms1.DataType = DbType.String;
				colvarUpms1.MaxLength = 10;
				colvarUpms1.AutoIncrement = false;
				colvarUpms1.IsNullable = true;
				colvarUpms1.IsPrimaryKey = false;
				colvarUpms1.IsForeignKey = false;
				colvarUpms1.IsReadOnly = false;
				colvarUpms1.DefaultSetting = @"";
				colvarUpms1.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpms1);
				
				TableSchema.TableColumn colvarUpms2 = new TableSchema.TableColumn(schema);
				colvarUpms2.ColumnName = "Upms2";
				colvarUpms2.DataType = DbType.String;
				colvarUpms2.MaxLength = 10;
				colvarUpms2.AutoIncrement = false;
				colvarUpms2.IsNullable = true;
				colvarUpms2.IsPrimaryKey = false;
				colvarUpms2.IsForeignKey = false;
				colvarUpms2.IsReadOnly = false;
				colvarUpms2.DefaultSetting = @"";
				colvarUpms2.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpms2);
				
				TableSchema.TableColumn colvarUpms3 = new TableSchema.TableColumn(schema);
				colvarUpms3.ColumnName = "Upms3";
				colvarUpms3.DataType = DbType.String;
				colvarUpms3.MaxLength = 10;
				colvarUpms3.AutoIncrement = false;
				colvarUpms3.IsNullable = true;
				colvarUpms3.IsPrimaryKey = false;
				colvarUpms3.IsForeignKey = false;
				colvarUpms3.IsReadOnly = false;
				colvarUpms3.DefaultSetting = @"";
				colvarUpms3.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpms3);
				
				TableSchema.TableColumn colvarUpms4 = new TableSchema.TableColumn(schema);
				colvarUpms4.ColumnName = "Upms4";
				colvarUpms4.DataType = DbType.String;
				colvarUpms4.MaxLength = 10;
				colvarUpms4.AutoIncrement = false;
				colvarUpms4.IsNullable = true;
				colvarUpms4.IsPrimaryKey = false;
				colvarUpms4.IsForeignKey = false;
				colvarUpms4.IsReadOnly = false;
				colvarUpms4.DefaultSetting = @"";
				colvarUpms4.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpms4);
				
				TableSchema.TableColumn colvarUpms5 = new TableSchema.TableColumn(schema);
				colvarUpms5.ColumnName = "Upms5";
				colvarUpms5.DataType = DbType.String;
				colvarUpms5.MaxLength = 10;
				colvarUpms5.AutoIncrement = false;
				colvarUpms5.IsNullable = true;
				colvarUpms5.IsPrimaryKey = false;
				colvarUpms5.IsForeignKey = false;
				colvarUpms5.IsReadOnly = false;
				colvarUpms5.DefaultSetting = @"";
				colvarUpms5.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpms5);
				
				TableSchema.TableColumn colvarUpms6 = new TableSchema.TableColumn(schema);
				colvarUpms6.ColumnName = "Upms6";
				colvarUpms6.DataType = DbType.String;
				colvarUpms6.MaxLength = 10;
				colvarUpms6.AutoIncrement = false;
				colvarUpms6.IsNullable = true;
				colvarUpms6.IsPrimaryKey = false;
				colvarUpms6.IsForeignKey = false;
				colvarUpms6.IsReadOnly = false;
				colvarUpms6.DefaultSetting = @"";
				colvarUpms6.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpms6);
				
				TableSchema.TableColumn colvarUpms7 = new TableSchema.TableColumn(schema);
				colvarUpms7.ColumnName = "Upms7";
				colvarUpms7.DataType = DbType.String;
				colvarUpms7.MaxLength = 10;
				colvarUpms7.AutoIncrement = false;
				colvarUpms7.IsNullable = true;
				colvarUpms7.IsPrimaryKey = false;
				colvarUpms7.IsForeignKey = false;
				colvarUpms7.IsReadOnly = false;
				colvarUpms7.DefaultSetting = @"";
				colvarUpms7.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpms7);
				
				TableSchema.TableColumn colvarUpms8 = new TableSchema.TableColumn(schema);
				colvarUpms8.ColumnName = "Upms8";
				colvarUpms8.DataType = DbType.String;
				colvarUpms8.MaxLength = 10;
				colvarUpms8.AutoIncrement = false;
				colvarUpms8.IsNullable = true;
				colvarUpms8.IsPrimaryKey = false;
				colvarUpms8.IsForeignKey = false;
				colvarUpms8.IsReadOnly = false;
				colvarUpms8.DefaultSetting = @"";
				colvarUpms8.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpms8);
				
				TableSchema.TableColumn colvarUpms9 = new TableSchema.TableColumn(schema);
				colvarUpms9.ColumnName = "Upms9";
				colvarUpms9.DataType = DbType.String;
				colvarUpms9.MaxLength = 10;
				colvarUpms9.AutoIncrement = false;
				colvarUpms9.IsNullable = true;
				colvarUpms9.IsPrimaryKey = false;
				colvarUpms9.IsForeignKey = false;
				colvarUpms9.IsReadOnly = false;
				colvarUpms9.DefaultSetting = @"";
				colvarUpms9.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpms9);
				
				TableSchema.TableColumn colvarUpms10 = new TableSchema.TableColumn(schema);
				colvarUpms10.ColumnName = "Upms10";
				colvarUpms10.DataType = DbType.String;
				colvarUpms10.MaxLength = 10;
				colvarUpms10.AutoIncrement = false;
				colvarUpms10.IsNullable = true;
				colvarUpms10.IsPrimaryKey = false;
				colvarUpms10.IsForeignKey = false;
				colvarUpms10.IsReadOnly = false;
				colvarUpms10.DefaultSetting = @"";
				colvarUpms10.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpms10);
				
				TableSchema.TableColumn colvarUpms11 = new TableSchema.TableColumn(schema);
				colvarUpms11.ColumnName = "Upms11";
				colvarUpms11.DataType = DbType.String;
				colvarUpms11.MaxLength = 10;
				colvarUpms11.AutoIncrement = false;
				colvarUpms11.IsNullable = true;
				colvarUpms11.IsPrimaryKey = false;
				colvarUpms11.IsForeignKey = false;
				colvarUpms11.IsReadOnly = false;
				colvarUpms11.DefaultSetting = @"";
				colvarUpms11.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpms11);
				
				TableSchema.TableColumn colvarUpms12 = new TableSchema.TableColumn(schema);
				colvarUpms12.ColumnName = "Upms12";
				colvarUpms12.DataType = DbType.String;
				colvarUpms12.MaxLength = 10;
				colvarUpms12.AutoIncrement = false;
				colvarUpms12.IsNullable = true;
				colvarUpms12.IsPrimaryKey = false;
				colvarUpms12.IsForeignKey = false;
				colvarUpms12.IsReadOnly = false;
				colvarUpms12.DefaultSetting = @"";
				colvarUpms12.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpms12);
				
				TableSchema.TableColumn colvarUpms13 = new TableSchema.TableColumn(schema);
				colvarUpms13.ColumnName = "Upms13";
				colvarUpms13.DataType = DbType.String;
				colvarUpms13.MaxLength = 10;
				colvarUpms13.AutoIncrement = false;
				colvarUpms13.IsNullable = true;
				colvarUpms13.IsPrimaryKey = false;
				colvarUpms13.IsForeignKey = false;
				colvarUpms13.IsReadOnly = false;
				colvarUpms13.DefaultSetting = @"";
				colvarUpms13.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpms13);
				
				TableSchema.TableColumn colvarUpms14 = new TableSchema.TableColumn(schema);
				colvarUpms14.ColumnName = "Upms14";
				colvarUpms14.DataType = DbType.String;
				colvarUpms14.MaxLength = 10;
				colvarUpms14.AutoIncrement = false;
				colvarUpms14.IsNullable = true;
				colvarUpms14.IsPrimaryKey = false;
				colvarUpms14.IsForeignKey = false;
				colvarUpms14.IsReadOnly = false;
				colvarUpms14.DefaultSetting = @"";
				colvarUpms14.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpms14);
				
				TableSchema.TableColumn colvarUpms15 = new TableSchema.TableColumn(schema);
				colvarUpms15.ColumnName = "Upms15";
				colvarUpms15.DataType = DbType.String;
				colvarUpms15.MaxLength = 10;
				colvarUpms15.AutoIncrement = false;
				colvarUpms15.IsNullable = true;
				colvarUpms15.IsPrimaryKey = false;
				colvarUpms15.IsForeignKey = false;
				colvarUpms15.IsReadOnly = false;
				colvarUpms15.DefaultSetting = @"";
				colvarUpms15.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpms15);
				
				TableSchema.TableColumn colvarUpms16 = new TableSchema.TableColumn(schema);
				colvarUpms16.ColumnName = "Upms16";
				colvarUpms16.DataType = DbType.String;
				colvarUpms16.MaxLength = 10;
				colvarUpms16.AutoIncrement = false;
				colvarUpms16.IsNullable = true;
				colvarUpms16.IsPrimaryKey = false;
				colvarUpms16.IsForeignKey = false;
				colvarUpms16.IsReadOnly = false;
				colvarUpms16.DefaultSetting = @"";
				colvarUpms16.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpms16);
				
				TableSchema.TableColumn colvarUpms17 = new TableSchema.TableColumn(schema);
				colvarUpms17.ColumnName = "Upms17";
				colvarUpms17.DataType = DbType.String;
				colvarUpms17.MaxLength = 10;
				colvarUpms17.AutoIncrement = false;
				colvarUpms17.IsNullable = true;
				colvarUpms17.IsPrimaryKey = false;
				colvarUpms17.IsForeignKey = false;
				colvarUpms17.IsReadOnly = false;
				colvarUpms17.DefaultSetting = @"";
				colvarUpms17.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpms17);
				
				TableSchema.TableColumn colvarUpms18 = new TableSchema.TableColumn(schema);
				colvarUpms18.ColumnName = "Upms18";
				colvarUpms18.DataType = DbType.String;
				colvarUpms18.MaxLength = 10;
				colvarUpms18.AutoIncrement = false;
				colvarUpms18.IsNullable = true;
				colvarUpms18.IsPrimaryKey = false;
				colvarUpms18.IsForeignKey = false;
				colvarUpms18.IsReadOnly = false;
				colvarUpms18.DefaultSetting = @"";
				colvarUpms18.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpms18);
				
				TableSchema.TableColumn colvarUpms19 = new TableSchema.TableColumn(schema);
				colvarUpms19.ColumnName = "Upms19";
				colvarUpms19.DataType = DbType.String;
				colvarUpms19.MaxLength = 10;
				colvarUpms19.AutoIncrement = false;
				colvarUpms19.IsNullable = true;
				colvarUpms19.IsPrimaryKey = false;
				colvarUpms19.IsForeignKey = false;
				colvarUpms19.IsReadOnly = false;
				colvarUpms19.DefaultSetting = @"";
				colvarUpms19.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpms19);
				
				TableSchema.TableColumn colvarUpms20 = new TableSchema.TableColumn(schema);
				colvarUpms20.ColumnName = "Upms20";
				colvarUpms20.DataType = DbType.String;
				colvarUpms20.MaxLength = 10;
				colvarUpms20.AutoIncrement = false;
				colvarUpms20.IsNullable = true;
				colvarUpms20.IsPrimaryKey = false;
				colvarUpms20.IsForeignKey = false;
				colvarUpms20.IsReadOnly = false;
				colvarUpms20.DefaultSetting = @"";
				colvarUpms20.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpms20);
				
				TableSchema.TableColumn colvarUpms21 = new TableSchema.TableColumn(schema);
				colvarUpms21.ColumnName = "Upms21";
				colvarUpms21.DataType = DbType.String;
				colvarUpms21.MaxLength = 10;
				colvarUpms21.AutoIncrement = false;
				colvarUpms21.IsNullable = true;
				colvarUpms21.IsPrimaryKey = false;
				colvarUpms21.IsForeignKey = false;
				colvarUpms21.IsReadOnly = false;
				colvarUpms21.DefaultSetting = @"";
				colvarUpms21.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpms21);
				
				TableSchema.TableColumn colvarUpms22 = new TableSchema.TableColumn(schema);
				colvarUpms22.ColumnName = "Upms22";
				colvarUpms22.DataType = DbType.String;
				colvarUpms22.MaxLength = 10;
				colvarUpms22.AutoIncrement = false;
				colvarUpms22.IsNullable = true;
				colvarUpms22.IsPrimaryKey = false;
				colvarUpms22.IsForeignKey = false;
				colvarUpms22.IsReadOnly = false;
				colvarUpms22.DefaultSetting = @"";
				colvarUpms22.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpms22);
				
				TableSchema.TableColumn colvarUpms23 = new TableSchema.TableColumn(schema);
				colvarUpms23.ColumnName = "Upms23";
				colvarUpms23.DataType = DbType.String;
				colvarUpms23.MaxLength = 10;
				colvarUpms23.AutoIncrement = false;
				colvarUpms23.IsNullable = true;
				colvarUpms23.IsPrimaryKey = false;
				colvarUpms23.IsForeignKey = false;
				colvarUpms23.IsReadOnly = false;
				colvarUpms23.DefaultSetting = @"";
				colvarUpms23.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpms23);
				
				TableSchema.TableColumn colvarUpms24 = new TableSchema.TableColumn(schema);
				colvarUpms24.ColumnName = "Upms24";
				colvarUpms24.DataType = DbType.String;
				colvarUpms24.MaxLength = 10;
				colvarUpms24.AutoIncrement = false;
				colvarUpms24.IsNullable = true;
				colvarUpms24.IsPrimaryKey = false;
				colvarUpms24.IsForeignKey = false;
				colvarUpms24.IsReadOnly = false;
				colvarUpms24.DefaultSetting = @"";
				colvarUpms24.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpms24);
				
				TableSchema.TableColumn colvarSecms1 = new TableSchema.TableColumn(schema);
				colvarSecms1.ColumnName = "Secms1";
				colvarSecms1.DataType = DbType.String;
				colvarSecms1.MaxLength = 10;
				colvarSecms1.AutoIncrement = false;
				colvarSecms1.IsNullable = true;
				colvarSecms1.IsPrimaryKey = false;
				colvarSecms1.IsForeignKey = false;
				colvarSecms1.IsReadOnly = false;
				colvarSecms1.DefaultSetting = @"";
				colvarSecms1.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecms1);
				
				TableSchema.TableColumn colvarSecms2 = new TableSchema.TableColumn(schema);
				colvarSecms2.ColumnName = "Secms2";
				colvarSecms2.DataType = DbType.String;
				colvarSecms2.MaxLength = 10;
				colvarSecms2.AutoIncrement = false;
				colvarSecms2.IsNullable = true;
				colvarSecms2.IsPrimaryKey = false;
				colvarSecms2.IsForeignKey = false;
				colvarSecms2.IsReadOnly = false;
				colvarSecms2.DefaultSetting = @"";
				colvarSecms2.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecms2);
				
				TableSchema.TableColumn colvarSecms3 = new TableSchema.TableColumn(schema);
				colvarSecms3.ColumnName = "Secms3";
				colvarSecms3.DataType = DbType.String;
				colvarSecms3.MaxLength = 10;
				colvarSecms3.AutoIncrement = false;
				colvarSecms3.IsNullable = true;
				colvarSecms3.IsPrimaryKey = false;
				colvarSecms3.IsForeignKey = false;
				colvarSecms3.IsReadOnly = false;
				colvarSecms3.DefaultSetting = @"";
				colvarSecms3.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecms3);
				
				TableSchema.TableColumn colvarSecms4 = new TableSchema.TableColumn(schema);
				colvarSecms4.ColumnName = "Secms4";
				colvarSecms4.DataType = DbType.String;
				colvarSecms4.MaxLength = 10;
				colvarSecms4.AutoIncrement = false;
				colvarSecms4.IsNullable = true;
				colvarSecms4.IsPrimaryKey = false;
				colvarSecms4.IsForeignKey = false;
				colvarSecms4.IsReadOnly = false;
				colvarSecms4.DefaultSetting = @"";
				colvarSecms4.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecms4);
				
				TableSchema.TableColumn colvarSecms5 = new TableSchema.TableColumn(schema);
				colvarSecms5.ColumnName = "Secms5";
				colvarSecms5.DataType = DbType.String;
				colvarSecms5.MaxLength = 10;
				colvarSecms5.AutoIncrement = false;
				colvarSecms5.IsNullable = true;
				colvarSecms5.IsPrimaryKey = false;
				colvarSecms5.IsForeignKey = false;
				colvarSecms5.IsReadOnly = false;
				colvarSecms5.DefaultSetting = @"";
				colvarSecms5.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecms5);
				
				TableSchema.TableColumn colvarSecms6 = new TableSchema.TableColumn(schema);
				colvarSecms6.ColumnName = "Secms6";
				colvarSecms6.DataType = DbType.String;
				colvarSecms6.MaxLength = 10;
				colvarSecms6.AutoIncrement = false;
				colvarSecms6.IsNullable = true;
				colvarSecms6.IsPrimaryKey = false;
				colvarSecms6.IsForeignKey = false;
				colvarSecms6.IsReadOnly = false;
				colvarSecms6.DefaultSetting = @"";
				colvarSecms6.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecms6);
				
				TableSchema.TableColumn colvarSecms7 = new TableSchema.TableColumn(schema);
				colvarSecms7.ColumnName = "Secms7";
				colvarSecms7.DataType = DbType.String;
				colvarSecms7.MaxLength = 10;
				colvarSecms7.AutoIncrement = false;
				colvarSecms7.IsNullable = true;
				colvarSecms7.IsPrimaryKey = false;
				colvarSecms7.IsForeignKey = false;
				colvarSecms7.IsReadOnly = false;
				colvarSecms7.DefaultSetting = @"";
				colvarSecms7.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecms7);
				
				TableSchema.TableColumn colvarSecms8 = new TableSchema.TableColumn(schema);
				colvarSecms8.ColumnName = "Secms8";
				colvarSecms8.DataType = DbType.String;
				colvarSecms8.MaxLength = 10;
				colvarSecms8.AutoIncrement = false;
				colvarSecms8.IsNullable = true;
				colvarSecms8.IsPrimaryKey = false;
				colvarSecms8.IsForeignKey = false;
				colvarSecms8.IsReadOnly = false;
				colvarSecms8.DefaultSetting = @"";
				colvarSecms8.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecms8);
				
				TableSchema.TableColumn colvarSecms9 = new TableSchema.TableColumn(schema);
				colvarSecms9.ColumnName = "Secms9";
				colvarSecms9.DataType = DbType.String;
				colvarSecms9.MaxLength = 10;
				colvarSecms9.AutoIncrement = false;
				colvarSecms9.IsNullable = true;
				colvarSecms9.IsPrimaryKey = false;
				colvarSecms9.IsForeignKey = false;
				colvarSecms9.IsReadOnly = false;
				colvarSecms9.DefaultSetting = @"";
				colvarSecms9.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecms9);
				
				TableSchema.TableColumn colvarSecms10 = new TableSchema.TableColumn(schema);
				colvarSecms10.ColumnName = "Secms10";
				colvarSecms10.DataType = DbType.String;
				colvarSecms10.MaxLength = 10;
				colvarSecms10.AutoIncrement = false;
				colvarSecms10.IsNullable = true;
				colvarSecms10.IsPrimaryKey = false;
				colvarSecms10.IsForeignKey = false;
				colvarSecms10.IsReadOnly = false;
				colvarSecms10.DefaultSetting = @"";
				colvarSecms10.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecms10);
				
				TableSchema.TableColumn colvarSecms11 = new TableSchema.TableColumn(schema);
				colvarSecms11.ColumnName = "Secms11";
				colvarSecms11.DataType = DbType.String;
				colvarSecms11.MaxLength = 10;
				colvarSecms11.AutoIncrement = false;
				colvarSecms11.IsNullable = true;
				colvarSecms11.IsPrimaryKey = false;
				colvarSecms11.IsForeignKey = false;
				colvarSecms11.IsReadOnly = false;
				colvarSecms11.DefaultSetting = @"";
				colvarSecms11.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecms11);
				
				TableSchema.TableColumn colvarSecms12 = new TableSchema.TableColumn(schema);
				colvarSecms12.ColumnName = "Secms12";
				colvarSecms12.DataType = DbType.String;
				colvarSecms12.MaxLength = 10;
				colvarSecms12.AutoIncrement = false;
				colvarSecms12.IsNullable = true;
				colvarSecms12.IsPrimaryKey = false;
				colvarSecms12.IsForeignKey = false;
				colvarSecms12.IsReadOnly = false;
				colvarSecms12.DefaultSetting = @"";
				colvarSecms12.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecms12);
				
				TableSchema.TableColumn colvarSecms13 = new TableSchema.TableColumn(schema);
				colvarSecms13.ColumnName = "Secms13";
				colvarSecms13.DataType = DbType.String;
				colvarSecms13.MaxLength = 10;
				colvarSecms13.AutoIncrement = false;
				colvarSecms13.IsNullable = true;
				colvarSecms13.IsPrimaryKey = false;
				colvarSecms13.IsForeignKey = false;
				colvarSecms13.IsReadOnly = false;
				colvarSecms13.DefaultSetting = @"";
				colvarSecms13.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecms13);
				
				TableSchema.TableColumn colvarSecms14 = new TableSchema.TableColumn(schema);
				colvarSecms14.ColumnName = "Secms14";
				colvarSecms14.DataType = DbType.String;
				colvarSecms14.MaxLength = 10;
				colvarSecms14.AutoIncrement = false;
				colvarSecms14.IsNullable = true;
				colvarSecms14.IsPrimaryKey = false;
				colvarSecms14.IsForeignKey = false;
				colvarSecms14.IsReadOnly = false;
				colvarSecms14.DefaultSetting = @"";
				colvarSecms14.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecms14);
				
				TableSchema.TableColumn colvarSecms15 = new TableSchema.TableColumn(schema);
				colvarSecms15.ColumnName = "Secms15";
				colvarSecms15.DataType = DbType.String;
				colvarSecms15.MaxLength = 10;
				colvarSecms15.AutoIncrement = false;
				colvarSecms15.IsNullable = true;
				colvarSecms15.IsPrimaryKey = false;
				colvarSecms15.IsForeignKey = false;
				colvarSecms15.IsReadOnly = false;
				colvarSecms15.DefaultSetting = @"";
				colvarSecms15.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecms15);
				
				TableSchema.TableColumn colvarSecms16 = new TableSchema.TableColumn(schema);
				colvarSecms16.ColumnName = "Secms16";
				colvarSecms16.DataType = DbType.String;
				colvarSecms16.MaxLength = 10;
				colvarSecms16.AutoIncrement = false;
				colvarSecms16.IsNullable = true;
				colvarSecms16.IsPrimaryKey = false;
				colvarSecms16.IsForeignKey = false;
				colvarSecms16.IsReadOnly = false;
				colvarSecms16.DefaultSetting = @"";
				colvarSecms16.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecms16);
				
				TableSchema.TableColumn colvarSecms17 = new TableSchema.TableColumn(schema);
				colvarSecms17.ColumnName = "Secms17";
				colvarSecms17.DataType = DbType.String;
				colvarSecms17.MaxLength = 10;
				colvarSecms17.AutoIncrement = false;
				colvarSecms17.IsNullable = true;
				colvarSecms17.IsPrimaryKey = false;
				colvarSecms17.IsForeignKey = false;
				colvarSecms17.IsReadOnly = false;
				colvarSecms17.DefaultSetting = @"";
				colvarSecms17.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecms17);
				
				TableSchema.TableColumn colvarSecms18 = new TableSchema.TableColumn(schema);
				colvarSecms18.ColumnName = "Secms18";
				colvarSecms18.DataType = DbType.String;
				colvarSecms18.MaxLength = 10;
				colvarSecms18.AutoIncrement = false;
				colvarSecms18.IsNullable = true;
				colvarSecms18.IsPrimaryKey = false;
				colvarSecms18.IsForeignKey = false;
				colvarSecms18.IsReadOnly = false;
				colvarSecms18.DefaultSetting = @"";
				colvarSecms18.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecms18);
				
				TableSchema.TableColumn colvarSecms19 = new TableSchema.TableColumn(schema);
				colvarSecms19.ColumnName = "Secms19";
				colvarSecms19.DataType = DbType.String;
				colvarSecms19.MaxLength = 10;
				colvarSecms19.AutoIncrement = false;
				colvarSecms19.IsNullable = true;
				colvarSecms19.IsPrimaryKey = false;
				colvarSecms19.IsForeignKey = false;
				colvarSecms19.IsReadOnly = false;
				colvarSecms19.DefaultSetting = @"";
				colvarSecms19.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecms19);
				
				TableSchema.TableColumn colvarSecms20 = new TableSchema.TableColumn(schema);
				colvarSecms20.ColumnName = "Secms20";
				colvarSecms20.DataType = DbType.String;
				colvarSecms20.MaxLength = 10;
				colvarSecms20.AutoIncrement = false;
				colvarSecms20.IsNullable = true;
				colvarSecms20.IsPrimaryKey = false;
				colvarSecms20.IsForeignKey = false;
				colvarSecms20.IsReadOnly = false;
				colvarSecms20.DefaultSetting = @"";
				colvarSecms20.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecms20);
				
				TableSchema.TableColumn colvarSecms21 = new TableSchema.TableColumn(schema);
				colvarSecms21.ColumnName = "Secms21";
				colvarSecms21.DataType = DbType.String;
				colvarSecms21.MaxLength = 10;
				colvarSecms21.AutoIncrement = false;
				colvarSecms21.IsNullable = true;
				colvarSecms21.IsPrimaryKey = false;
				colvarSecms21.IsForeignKey = false;
				colvarSecms21.IsReadOnly = false;
				colvarSecms21.DefaultSetting = @"";
				colvarSecms21.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecms21);
				
				TableSchema.TableColumn colvarSecms22 = new TableSchema.TableColumn(schema);
				colvarSecms22.ColumnName = "Secms22";
				colvarSecms22.DataType = DbType.String;
				colvarSecms22.MaxLength = 10;
				colvarSecms22.AutoIncrement = false;
				colvarSecms22.IsNullable = true;
				colvarSecms22.IsPrimaryKey = false;
				colvarSecms22.IsForeignKey = false;
				colvarSecms22.IsReadOnly = false;
				colvarSecms22.DefaultSetting = @"";
				colvarSecms22.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecms22);
				
				TableSchema.TableColumn colvarSecms23 = new TableSchema.TableColumn(schema);
				colvarSecms23.ColumnName = "Secms23";
				colvarSecms23.DataType = DbType.String;
				colvarSecms23.MaxLength = 10;
				colvarSecms23.AutoIncrement = false;
				colvarSecms23.IsNullable = true;
				colvarSecms23.IsPrimaryKey = false;
				colvarSecms23.IsForeignKey = false;
				colvarSecms23.IsReadOnly = false;
				colvarSecms23.DefaultSetting = @"";
				colvarSecms23.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecms23);
				
				TableSchema.TableColumn colvarSecms24 = new TableSchema.TableColumn(schema);
				colvarSecms24.ColumnName = "Secms24";
				colvarSecms24.DataType = DbType.String;
				colvarSecms24.MaxLength = 10;
				colvarSecms24.AutoIncrement = false;
				colvarSecms24.IsNullable = true;
				colvarSecms24.IsPrimaryKey = false;
				colvarSecms24.IsForeignKey = false;
				colvarSecms24.IsReadOnly = false;
				colvarSecms24.DefaultSetting = @"";
				colvarSecms24.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecms24);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("MarketScore_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("MarketScoreId")]
		[Bindable(true)]
		public int MarketScoreId 
		{
			get { return GetColumnValue<int>(Columns.MarketScoreId); }
			set { SetColumnValue(Columns.MarketScoreId, value); }
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
		  
		[XmlAttribute("Selfms1")]
		[Bindable(true)]
		public string Selfms1 
		{
			get { return GetColumnValue<string>(Columns.Selfms1); }
			set { SetColumnValue(Columns.Selfms1, value); }
		}
		  
		[XmlAttribute("Selfms2")]
		[Bindable(true)]
		public string Selfms2 
		{
			get { return GetColumnValue<string>(Columns.Selfms2); }
			set { SetColumnValue(Columns.Selfms2, value); }
		}
		  
		[XmlAttribute("Selfms3")]
		[Bindable(true)]
		public string Selfms3 
		{
			get { return GetColumnValue<string>(Columns.Selfms3); }
			set { SetColumnValue(Columns.Selfms3, value); }
		}
		  
		[XmlAttribute("Selfms4")]
		[Bindable(true)]
		public string Selfms4 
		{
			get { return GetColumnValue<string>(Columns.Selfms4); }
			set { SetColumnValue(Columns.Selfms4, value); }
		}
		  
		[XmlAttribute("Selfms5")]
		[Bindable(true)]
		public string Selfms5 
		{
			get { return GetColumnValue<string>(Columns.Selfms5); }
			set { SetColumnValue(Columns.Selfms5, value); }
		}
		  
		[XmlAttribute("Selfms6")]
		[Bindable(true)]
		public string Selfms6 
		{
			get { return GetColumnValue<string>(Columns.Selfms6); }
			set { SetColumnValue(Columns.Selfms6, value); }
		}
		  
		[XmlAttribute("Selfms7")]
		[Bindable(true)]
		public string Selfms7 
		{
			get { return GetColumnValue<string>(Columns.Selfms7); }
			set { SetColumnValue(Columns.Selfms7, value); }
		}
		  
		[XmlAttribute("Selfms8")]
		[Bindable(true)]
		public string Selfms8 
		{
			get { return GetColumnValue<string>(Columns.Selfms8); }
			set { SetColumnValue(Columns.Selfms8, value); }
		}
		  
		[XmlAttribute("Selfms9")]
		[Bindable(true)]
		public string Selfms9 
		{
			get { return GetColumnValue<string>(Columns.Selfms9); }
			set { SetColumnValue(Columns.Selfms9, value); }
		}
		  
		[XmlAttribute("Selfms10")]
		[Bindable(true)]
		public string Selfms10 
		{
			get { return GetColumnValue<string>(Columns.Selfms10); }
			set { SetColumnValue(Columns.Selfms10, value); }
		}
		  
		[XmlAttribute("Selfms11")]
		[Bindable(true)]
		public string Selfms11 
		{
			get { return GetColumnValue<string>(Columns.Selfms11); }
			set { SetColumnValue(Columns.Selfms11, value); }
		}
		  
		[XmlAttribute("Selfms12")]
		[Bindable(true)]
		public string Selfms12 
		{
			get { return GetColumnValue<string>(Columns.Selfms12); }
			set { SetColumnValue(Columns.Selfms12, value); }
		}
		  
		[XmlAttribute("Selfms13")]
		[Bindable(true)]
		public string Selfms13 
		{
			get { return GetColumnValue<string>(Columns.Selfms13); }
			set { SetColumnValue(Columns.Selfms13, value); }
		}
		  
		[XmlAttribute("Selfms14")]
		[Bindable(true)]
		public string Selfms14 
		{
			get { return GetColumnValue<string>(Columns.Selfms14); }
			set { SetColumnValue(Columns.Selfms14, value); }
		}
		  
		[XmlAttribute("Selfms15")]
		[Bindable(true)]
		public string Selfms15 
		{
			get { return GetColumnValue<string>(Columns.Selfms15); }
			set { SetColumnValue(Columns.Selfms15, value); }
		}
		  
		[XmlAttribute("Selfms16")]
		[Bindable(true)]
		public string Selfms16 
		{
			get { return GetColumnValue<string>(Columns.Selfms16); }
			set { SetColumnValue(Columns.Selfms16, value); }
		}
		  
		[XmlAttribute("Selfms17")]
		[Bindable(true)]
		public string Selfms17 
		{
			get { return GetColumnValue<string>(Columns.Selfms17); }
			set { SetColumnValue(Columns.Selfms17, value); }
		}
		  
		[XmlAttribute("Selfms18")]
		[Bindable(true)]
		public string Selfms18 
		{
			get { return GetColumnValue<string>(Columns.Selfms18); }
			set { SetColumnValue(Columns.Selfms18, value); }
		}
		  
		[XmlAttribute("Selfms19")]
		[Bindable(true)]
		public string Selfms19 
		{
			get { return GetColumnValue<string>(Columns.Selfms19); }
			set { SetColumnValue(Columns.Selfms19, value); }
		}
		  
		[XmlAttribute("Selfms20")]
		[Bindable(true)]
		public string Selfms20 
		{
			get { return GetColumnValue<string>(Columns.Selfms20); }
			set { SetColumnValue(Columns.Selfms20, value); }
		}
		  
		[XmlAttribute("Selfms21")]
		[Bindable(true)]
		public string Selfms21 
		{
			get { return GetColumnValue<string>(Columns.Selfms21); }
			set { SetColumnValue(Columns.Selfms21, value); }
		}
		  
		[XmlAttribute("Selfms22")]
		[Bindable(true)]
		public string Selfms22 
		{
			get { return GetColumnValue<string>(Columns.Selfms22); }
			set { SetColumnValue(Columns.Selfms22, value); }
		}
		  
		[XmlAttribute("Selfms23")]
		[Bindable(true)]
		public string Selfms23 
		{
			get { return GetColumnValue<string>(Columns.Selfms23); }
			set { SetColumnValue(Columns.Selfms23, value); }
		}
		  
		[XmlAttribute("Selfms24")]
		[Bindable(true)]
		public string Selfms24 
		{
			get { return GetColumnValue<string>(Columns.Selfms24); }
			set { SetColumnValue(Columns.Selfms24, value); }
		}
		  
		[XmlAttribute("Upms1")]
		[Bindable(true)]
		public string Upms1 
		{
			get { return GetColumnValue<string>(Columns.Upms1); }
			set { SetColumnValue(Columns.Upms1, value); }
		}
		  
		[XmlAttribute("Upms2")]
		[Bindable(true)]
		public string Upms2 
		{
			get { return GetColumnValue<string>(Columns.Upms2); }
			set { SetColumnValue(Columns.Upms2, value); }
		}
		  
		[XmlAttribute("Upms3")]
		[Bindable(true)]
		public string Upms3 
		{
			get { return GetColumnValue<string>(Columns.Upms3); }
			set { SetColumnValue(Columns.Upms3, value); }
		}
		  
		[XmlAttribute("Upms4")]
		[Bindable(true)]
		public string Upms4 
		{
			get { return GetColumnValue<string>(Columns.Upms4); }
			set { SetColumnValue(Columns.Upms4, value); }
		}
		  
		[XmlAttribute("Upms5")]
		[Bindable(true)]
		public string Upms5 
		{
			get { return GetColumnValue<string>(Columns.Upms5); }
			set { SetColumnValue(Columns.Upms5, value); }
		}
		  
		[XmlAttribute("Upms6")]
		[Bindable(true)]
		public string Upms6 
		{
			get { return GetColumnValue<string>(Columns.Upms6); }
			set { SetColumnValue(Columns.Upms6, value); }
		}
		  
		[XmlAttribute("Upms7")]
		[Bindable(true)]
		public string Upms7 
		{
			get { return GetColumnValue<string>(Columns.Upms7); }
			set { SetColumnValue(Columns.Upms7, value); }
		}
		  
		[XmlAttribute("Upms8")]
		[Bindable(true)]
		public string Upms8 
		{
			get { return GetColumnValue<string>(Columns.Upms8); }
			set { SetColumnValue(Columns.Upms8, value); }
		}
		  
		[XmlAttribute("Upms9")]
		[Bindable(true)]
		public string Upms9 
		{
			get { return GetColumnValue<string>(Columns.Upms9); }
			set { SetColumnValue(Columns.Upms9, value); }
		}
		  
		[XmlAttribute("Upms10")]
		[Bindable(true)]
		public string Upms10 
		{
			get { return GetColumnValue<string>(Columns.Upms10); }
			set { SetColumnValue(Columns.Upms10, value); }
		}
		  
		[XmlAttribute("Upms11")]
		[Bindable(true)]
		public string Upms11 
		{
			get { return GetColumnValue<string>(Columns.Upms11); }
			set { SetColumnValue(Columns.Upms11, value); }
		}
		  
		[XmlAttribute("Upms12")]
		[Bindable(true)]
		public string Upms12 
		{
			get { return GetColumnValue<string>(Columns.Upms12); }
			set { SetColumnValue(Columns.Upms12, value); }
		}
		  
		[XmlAttribute("Upms13")]
		[Bindable(true)]
		public string Upms13 
		{
			get { return GetColumnValue<string>(Columns.Upms13); }
			set { SetColumnValue(Columns.Upms13, value); }
		}
		  
		[XmlAttribute("Upms14")]
		[Bindable(true)]
		public string Upms14 
		{
			get { return GetColumnValue<string>(Columns.Upms14); }
			set { SetColumnValue(Columns.Upms14, value); }
		}
		  
		[XmlAttribute("Upms15")]
		[Bindable(true)]
		public string Upms15 
		{
			get { return GetColumnValue<string>(Columns.Upms15); }
			set { SetColumnValue(Columns.Upms15, value); }
		}
		  
		[XmlAttribute("Upms16")]
		[Bindable(true)]
		public string Upms16 
		{
			get { return GetColumnValue<string>(Columns.Upms16); }
			set { SetColumnValue(Columns.Upms16, value); }
		}
		  
		[XmlAttribute("Upms17")]
		[Bindable(true)]
		public string Upms17 
		{
			get { return GetColumnValue<string>(Columns.Upms17); }
			set { SetColumnValue(Columns.Upms17, value); }
		}
		  
		[XmlAttribute("Upms18")]
		[Bindable(true)]
		public string Upms18 
		{
			get { return GetColumnValue<string>(Columns.Upms18); }
			set { SetColumnValue(Columns.Upms18, value); }
		}
		  
		[XmlAttribute("Upms19")]
		[Bindable(true)]
		public string Upms19 
		{
			get { return GetColumnValue<string>(Columns.Upms19); }
			set { SetColumnValue(Columns.Upms19, value); }
		}
		  
		[XmlAttribute("Upms20")]
		[Bindable(true)]
		public string Upms20 
		{
			get { return GetColumnValue<string>(Columns.Upms20); }
			set { SetColumnValue(Columns.Upms20, value); }
		}
		  
		[XmlAttribute("Upms21")]
		[Bindable(true)]
		public string Upms21 
		{
			get { return GetColumnValue<string>(Columns.Upms21); }
			set { SetColumnValue(Columns.Upms21, value); }
		}
		  
		[XmlAttribute("Upms22")]
		[Bindable(true)]
		public string Upms22 
		{
			get { return GetColumnValue<string>(Columns.Upms22); }
			set { SetColumnValue(Columns.Upms22, value); }
		}
		  
		[XmlAttribute("Upms23")]
		[Bindable(true)]
		public string Upms23 
		{
			get { return GetColumnValue<string>(Columns.Upms23); }
			set { SetColumnValue(Columns.Upms23, value); }
		}
		  
		[XmlAttribute("Upms24")]
		[Bindable(true)]
		public string Upms24 
		{
			get { return GetColumnValue<string>(Columns.Upms24); }
			set { SetColumnValue(Columns.Upms24, value); }
		}
		  
		[XmlAttribute("Secms1")]
		[Bindable(true)]
		public string Secms1 
		{
			get { return GetColumnValue<string>(Columns.Secms1); }
			set { SetColumnValue(Columns.Secms1, value); }
		}
		  
		[XmlAttribute("Secms2")]
		[Bindable(true)]
		public string Secms2 
		{
			get { return GetColumnValue<string>(Columns.Secms2); }
			set { SetColumnValue(Columns.Secms2, value); }
		}
		  
		[XmlAttribute("Secms3")]
		[Bindable(true)]
		public string Secms3 
		{
			get { return GetColumnValue<string>(Columns.Secms3); }
			set { SetColumnValue(Columns.Secms3, value); }
		}
		  
		[XmlAttribute("Secms4")]
		[Bindable(true)]
		public string Secms4 
		{
			get { return GetColumnValue<string>(Columns.Secms4); }
			set { SetColumnValue(Columns.Secms4, value); }
		}
		  
		[XmlAttribute("Secms5")]
		[Bindable(true)]
		public string Secms5 
		{
			get { return GetColumnValue<string>(Columns.Secms5); }
			set { SetColumnValue(Columns.Secms5, value); }
		}
		  
		[XmlAttribute("Secms6")]
		[Bindable(true)]
		public string Secms6 
		{
			get { return GetColumnValue<string>(Columns.Secms6); }
			set { SetColumnValue(Columns.Secms6, value); }
		}
		  
		[XmlAttribute("Secms7")]
		[Bindable(true)]
		public string Secms7 
		{
			get { return GetColumnValue<string>(Columns.Secms7); }
			set { SetColumnValue(Columns.Secms7, value); }
		}
		  
		[XmlAttribute("Secms8")]
		[Bindable(true)]
		public string Secms8 
		{
			get { return GetColumnValue<string>(Columns.Secms8); }
			set { SetColumnValue(Columns.Secms8, value); }
		}
		  
		[XmlAttribute("Secms9")]
		[Bindable(true)]
		public string Secms9 
		{
			get { return GetColumnValue<string>(Columns.Secms9); }
			set { SetColumnValue(Columns.Secms9, value); }
		}
		  
		[XmlAttribute("Secms10")]
		[Bindable(true)]
		public string Secms10 
		{
			get { return GetColumnValue<string>(Columns.Secms10); }
			set { SetColumnValue(Columns.Secms10, value); }
		}
		  
		[XmlAttribute("Secms11")]
		[Bindable(true)]
		public string Secms11 
		{
			get { return GetColumnValue<string>(Columns.Secms11); }
			set { SetColumnValue(Columns.Secms11, value); }
		}
		  
		[XmlAttribute("Secms12")]
		[Bindable(true)]
		public string Secms12 
		{
			get { return GetColumnValue<string>(Columns.Secms12); }
			set { SetColumnValue(Columns.Secms12, value); }
		}
		  
		[XmlAttribute("Secms13")]
		[Bindable(true)]
		public string Secms13 
		{
			get { return GetColumnValue<string>(Columns.Secms13); }
			set { SetColumnValue(Columns.Secms13, value); }
		}
		  
		[XmlAttribute("Secms14")]
		[Bindable(true)]
		public string Secms14 
		{
			get { return GetColumnValue<string>(Columns.Secms14); }
			set { SetColumnValue(Columns.Secms14, value); }
		}
		  
		[XmlAttribute("Secms15")]
		[Bindable(true)]
		public string Secms15 
		{
			get { return GetColumnValue<string>(Columns.Secms15); }
			set { SetColumnValue(Columns.Secms15, value); }
		}
		  
		[XmlAttribute("Secms16")]
		[Bindable(true)]
		public string Secms16 
		{
			get { return GetColumnValue<string>(Columns.Secms16); }
			set { SetColumnValue(Columns.Secms16, value); }
		}
		  
		[XmlAttribute("Secms17")]
		[Bindable(true)]
		public string Secms17 
		{
			get { return GetColumnValue<string>(Columns.Secms17); }
			set { SetColumnValue(Columns.Secms17, value); }
		}
		  
		[XmlAttribute("Secms18")]
		[Bindable(true)]
		public string Secms18 
		{
			get { return GetColumnValue<string>(Columns.Secms18); }
			set { SetColumnValue(Columns.Secms18, value); }
		}
		  
		[XmlAttribute("Secms19")]
		[Bindable(true)]
		public string Secms19 
		{
			get { return GetColumnValue<string>(Columns.Secms19); }
			set { SetColumnValue(Columns.Secms19, value); }
		}
		  
		[XmlAttribute("Secms20")]
		[Bindable(true)]
		public string Secms20 
		{
			get { return GetColumnValue<string>(Columns.Secms20); }
			set { SetColumnValue(Columns.Secms20, value); }
		}
		  
		[XmlAttribute("Secms21")]
		[Bindable(true)]
		public string Secms21 
		{
			get { return GetColumnValue<string>(Columns.Secms21); }
			set { SetColumnValue(Columns.Secms21, value); }
		}
		  
		[XmlAttribute("Secms22")]
		[Bindable(true)]
		public string Secms22 
		{
			get { return GetColumnValue<string>(Columns.Secms22); }
			set { SetColumnValue(Columns.Secms22, value); }
		}
		  
		[XmlAttribute("Secms23")]
		[Bindable(true)]
		public string Secms23 
		{
			get { return GetColumnValue<string>(Columns.Secms23); }
			set { SetColumnValue(Columns.Secms23, value); }
		}
		  
		[XmlAttribute("Secms24")]
		[Bindable(true)]
		public string Secms24 
		{
			get { return GetColumnValue<string>(Columns.Secms24); }
			set { SetColumnValue(Columns.Secms24, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varDateSpan,int? varEvaluateLevelId,string varTotalScore,string varUpViews,int? varYearId,int? varMonthId,int? varEmployeeId,int? varIsSubmit,string varSelfms1,string varSelfms2,string varSelfms3,string varSelfms4,string varSelfms5,string varSelfms6,string varSelfms7,string varSelfms8,string varSelfms9,string varSelfms10,string varSelfms11,string varSelfms12,string varSelfms13,string varSelfms14,string varSelfms15,string varSelfms16,string varSelfms17,string varSelfms18,string varSelfms19,string varSelfms20,string varSelfms21,string varSelfms22,string varSelfms23,string varSelfms24,string varUpms1,string varUpms2,string varUpms3,string varUpms4,string varUpms5,string varUpms6,string varUpms7,string varUpms8,string varUpms9,string varUpms10,string varUpms11,string varUpms12,string varUpms13,string varUpms14,string varUpms15,string varUpms16,string varUpms17,string varUpms18,string varUpms19,string varUpms20,string varUpms21,string varUpms22,string varUpms23,string varUpms24,string varSecms1,string varSecms2,string varSecms3,string varSecms4,string varSecms5,string varSecms6,string varSecms7,string varSecms8,string varSecms9,string varSecms10,string varSecms11,string varSecms12,string varSecms13,string varSecms14,string varSecms15,string varSecms16,string varSecms17,string varSecms18,string varSecms19,string varSecms20,string varSecms21,string varSecms22,string varSecms23,string varSecms24)
		{
			MarketScore item = new MarketScore();
			
			item.DateSpan = varDateSpan;
			
			item.EvaluateLevelId = varEvaluateLevelId;
			
			item.TotalScore = varTotalScore;
			
			item.UpViews = varUpViews;
			
			item.YearId = varYearId;
			
			item.MonthId = varMonthId;
			
			item.EmployeeId = varEmployeeId;
			
			item.IsSubmit = varIsSubmit;
			
			item.Selfms1 = varSelfms1;
			
			item.Selfms2 = varSelfms2;
			
			item.Selfms3 = varSelfms3;
			
			item.Selfms4 = varSelfms4;
			
			item.Selfms5 = varSelfms5;
			
			item.Selfms6 = varSelfms6;
			
			item.Selfms7 = varSelfms7;
			
			item.Selfms8 = varSelfms8;
			
			item.Selfms9 = varSelfms9;
			
			item.Selfms10 = varSelfms10;
			
			item.Selfms11 = varSelfms11;
			
			item.Selfms12 = varSelfms12;
			
			item.Selfms13 = varSelfms13;
			
			item.Selfms14 = varSelfms14;
			
			item.Selfms15 = varSelfms15;
			
			item.Selfms16 = varSelfms16;
			
			item.Selfms17 = varSelfms17;
			
			item.Selfms18 = varSelfms18;
			
			item.Selfms19 = varSelfms19;
			
			item.Selfms20 = varSelfms20;
			
			item.Selfms21 = varSelfms21;
			
			item.Selfms22 = varSelfms22;
			
			item.Selfms23 = varSelfms23;
			
			item.Selfms24 = varSelfms24;
			
			item.Upms1 = varUpms1;
			
			item.Upms2 = varUpms2;
			
			item.Upms3 = varUpms3;
			
			item.Upms4 = varUpms4;
			
			item.Upms5 = varUpms5;
			
			item.Upms6 = varUpms6;
			
			item.Upms7 = varUpms7;
			
			item.Upms8 = varUpms8;
			
			item.Upms9 = varUpms9;
			
			item.Upms10 = varUpms10;
			
			item.Upms11 = varUpms11;
			
			item.Upms12 = varUpms12;
			
			item.Upms13 = varUpms13;
			
			item.Upms14 = varUpms14;
			
			item.Upms15 = varUpms15;
			
			item.Upms16 = varUpms16;
			
			item.Upms17 = varUpms17;
			
			item.Upms18 = varUpms18;
			
			item.Upms19 = varUpms19;
			
			item.Upms20 = varUpms20;
			
			item.Upms21 = varUpms21;
			
			item.Upms22 = varUpms22;
			
			item.Upms23 = varUpms23;
			
			item.Upms24 = varUpms24;
			
			item.Secms1 = varSecms1;
			
			item.Secms2 = varSecms2;
			
			item.Secms3 = varSecms3;
			
			item.Secms4 = varSecms4;
			
			item.Secms5 = varSecms5;
			
			item.Secms6 = varSecms6;
			
			item.Secms7 = varSecms7;
			
			item.Secms8 = varSecms8;
			
			item.Secms9 = varSecms9;
			
			item.Secms10 = varSecms10;
			
			item.Secms11 = varSecms11;
			
			item.Secms12 = varSecms12;
			
			item.Secms13 = varSecms13;
			
			item.Secms14 = varSecms14;
			
			item.Secms15 = varSecms15;
			
			item.Secms16 = varSecms16;
			
			item.Secms17 = varSecms17;
			
			item.Secms18 = varSecms18;
			
			item.Secms19 = varSecms19;
			
			item.Secms20 = varSecms20;
			
			item.Secms21 = varSecms21;
			
			item.Secms22 = varSecms22;
			
			item.Secms23 = varSecms23;
			
			item.Secms24 = varSecms24;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varMarketScoreId,string varDateSpan,int? varEvaluateLevelId,string varTotalScore,string varUpViews,int? varYearId,int? varMonthId,int? varEmployeeId,int? varIsSubmit,string varSelfms1,string varSelfms2,string varSelfms3,string varSelfms4,string varSelfms5,string varSelfms6,string varSelfms7,string varSelfms8,string varSelfms9,string varSelfms10,string varSelfms11,string varSelfms12,string varSelfms13,string varSelfms14,string varSelfms15,string varSelfms16,string varSelfms17,string varSelfms18,string varSelfms19,string varSelfms20,string varSelfms21,string varSelfms22,string varSelfms23,string varSelfms24,string varUpms1,string varUpms2,string varUpms3,string varUpms4,string varUpms5,string varUpms6,string varUpms7,string varUpms8,string varUpms9,string varUpms10,string varUpms11,string varUpms12,string varUpms13,string varUpms14,string varUpms15,string varUpms16,string varUpms17,string varUpms18,string varUpms19,string varUpms20,string varUpms21,string varUpms22,string varUpms23,string varUpms24,string varSecms1,string varSecms2,string varSecms3,string varSecms4,string varSecms5,string varSecms6,string varSecms7,string varSecms8,string varSecms9,string varSecms10,string varSecms11,string varSecms12,string varSecms13,string varSecms14,string varSecms15,string varSecms16,string varSecms17,string varSecms18,string varSecms19,string varSecms20,string varSecms21,string varSecms22,string varSecms23,string varSecms24)
		{
			MarketScore item = new MarketScore();
			
				item.MarketScoreId = varMarketScoreId;
			
				item.DateSpan = varDateSpan;
			
				item.EvaluateLevelId = varEvaluateLevelId;
			
				item.TotalScore = varTotalScore;
			
				item.UpViews = varUpViews;
			
				item.YearId = varYearId;
			
				item.MonthId = varMonthId;
			
				item.EmployeeId = varEmployeeId;
			
				item.IsSubmit = varIsSubmit;
			
				item.Selfms1 = varSelfms1;
			
				item.Selfms2 = varSelfms2;
			
				item.Selfms3 = varSelfms3;
			
				item.Selfms4 = varSelfms4;
			
				item.Selfms5 = varSelfms5;
			
				item.Selfms6 = varSelfms6;
			
				item.Selfms7 = varSelfms7;
			
				item.Selfms8 = varSelfms8;
			
				item.Selfms9 = varSelfms9;
			
				item.Selfms10 = varSelfms10;
			
				item.Selfms11 = varSelfms11;
			
				item.Selfms12 = varSelfms12;
			
				item.Selfms13 = varSelfms13;
			
				item.Selfms14 = varSelfms14;
			
				item.Selfms15 = varSelfms15;
			
				item.Selfms16 = varSelfms16;
			
				item.Selfms17 = varSelfms17;
			
				item.Selfms18 = varSelfms18;
			
				item.Selfms19 = varSelfms19;
			
				item.Selfms20 = varSelfms20;
			
				item.Selfms21 = varSelfms21;
			
				item.Selfms22 = varSelfms22;
			
				item.Selfms23 = varSelfms23;
			
				item.Selfms24 = varSelfms24;
			
				item.Upms1 = varUpms1;
			
				item.Upms2 = varUpms2;
			
				item.Upms3 = varUpms3;
			
				item.Upms4 = varUpms4;
			
				item.Upms5 = varUpms5;
			
				item.Upms6 = varUpms6;
			
				item.Upms7 = varUpms7;
			
				item.Upms8 = varUpms8;
			
				item.Upms9 = varUpms9;
			
				item.Upms10 = varUpms10;
			
				item.Upms11 = varUpms11;
			
				item.Upms12 = varUpms12;
			
				item.Upms13 = varUpms13;
			
				item.Upms14 = varUpms14;
			
				item.Upms15 = varUpms15;
			
				item.Upms16 = varUpms16;
			
				item.Upms17 = varUpms17;
			
				item.Upms18 = varUpms18;
			
				item.Upms19 = varUpms19;
			
				item.Upms20 = varUpms20;
			
				item.Upms21 = varUpms21;
			
				item.Upms22 = varUpms22;
			
				item.Upms23 = varUpms23;
			
				item.Upms24 = varUpms24;
			
				item.Secms1 = varSecms1;
			
				item.Secms2 = varSecms2;
			
				item.Secms3 = varSecms3;
			
				item.Secms4 = varSecms4;
			
				item.Secms5 = varSecms5;
			
				item.Secms6 = varSecms6;
			
				item.Secms7 = varSecms7;
			
				item.Secms8 = varSecms8;
			
				item.Secms9 = varSecms9;
			
				item.Secms10 = varSecms10;
			
				item.Secms11 = varSecms11;
			
				item.Secms12 = varSecms12;
			
				item.Secms13 = varSecms13;
			
				item.Secms14 = varSecms14;
			
				item.Secms15 = varSecms15;
			
				item.Secms16 = varSecms16;
			
				item.Secms17 = varSecms17;
			
				item.Secms18 = varSecms18;
			
				item.Secms19 = varSecms19;
			
				item.Secms20 = varSecms20;
			
				item.Secms21 = varSecms21;
			
				item.Secms22 = varSecms22;
			
				item.Secms23 = varSecms23;
			
				item.Secms24 = varSecms24;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn MarketScoreIdColumn
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
        
        
        
        public static TableSchema.TableColumn Selfms1Column
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfms2Column
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfms3Column
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfms4Column
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfms5Column
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfms6Column
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfms7Column
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfms8Column
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfms9Column
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfms10Column
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfms11Column
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfms12Column
        {
            get { return Schema.Columns[20]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfms13Column
        {
            get { return Schema.Columns[21]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfms14Column
        {
            get { return Schema.Columns[22]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfms15Column
        {
            get { return Schema.Columns[23]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfms16Column
        {
            get { return Schema.Columns[24]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfms17Column
        {
            get { return Schema.Columns[25]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfms18Column
        {
            get { return Schema.Columns[26]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfms19Column
        {
            get { return Schema.Columns[27]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfms20Column
        {
            get { return Schema.Columns[28]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfms21Column
        {
            get { return Schema.Columns[29]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfms22Column
        {
            get { return Schema.Columns[30]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfms23Column
        {
            get { return Schema.Columns[31]; }
        }
        
        
        
        public static TableSchema.TableColumn Selfms24Column
        {
            get { return Schema.Columns[32]; }
        }
        
        
        
        public static TableSchema.TableColumn Upms1Column
        {
            get { return Schema.Columns[33]; }
        }
        
        
        
        public static TableSchema.TableColumn Upms2Column
        {
            get { return Schema.Columns[34]; }
        }
        
        
        
        public static TableSchema.TableColumn Upms3Column
        {
            get { return Schema.Columns[35]; }
        }
        
        
        
        public static TableSchema.TableColumn Upms4Column
        {
            get { return Schema.Columns[36]; }
        }
        
        
        
        public static TableSchema.TableColumn Upms5Column
        {
            get { return Schema.Columns[37]; }
        }
        
        
        
        public static TableSchema.TableColumn Upms6Column
        {
            get { return Schema.Columns[38]; }
        }
        
        
        
        public static TableSchema.TableColumn Upms7Column
        {
            get { return Schema.Columns[39]; }
        }
        
        
        
        public static TableSchema.TableColumn Upms8Column
        {
            get { return Schema.Columns[40]; }
        }
        
        
        
        public static TableSchema.TableColumn Upms9Column
        {
            get { return Schema.Columns[41]; }
        }
        
        
        
        public static TableSchema.TableColumn Upms10Column
        {
            get { return Schema.Columns[42]; }
        }
        
        
        
        public static TableSchema.TableColumn Upms11Column
        {
            get { return Schema.Columns[43]; }
        }
        
        
        
        public static TableSchema.TableColumn Upms12Column
        {
            get { return Schema.Columns[44]; }
        }
        
        
        
        public static TableSchema.TableColumn Upms13Column
        {
            get { return Schema.Columns[45]; }
        }
        
        
        
        public static TableSchema.TableColumn Upms14Column
        {
            get { return Schema.Columns[46]; }
        }
        
        
        
        public static TableSchema.TableColumn Upms15Column
        {
            get { return Schema.Columns[47]; }
        }
        
        
        
        public static TableSchema.TableColumn Upms16Column
        {
            get { return Schema.Columns[48]; }
        }
        
        
        
        public static TableSchema.TableColumn Upms17Column
        {
            get { return Schema.Columns[49]; }
        }
        
        
        
        public static TableSchema.TableColumn Upms18Column
        {
            get { return Schema.Columns[50]; }
        }
        
        
        
        public static TableSchema.TableColumn Upms19Column
        {
            get { return Schema.Columns[51]; }
        }
        
        
        
        public static TableSchema.TableColumn Upms20Column
        {
            get { return Schema.Columns[52]; }
        }
        
        
        
        public static TableSchema.TableColumn Upms21Column
        {
            get { return Schema.Columns[53]; }
        }
        
        
        
        public static TableSchema.TableColumn Upms22Column
        {
            get { return Schema.Columns[54]; }
        }
        
        
        
        public static TableSchema.TableColumn Upms23Column
        {
            get { return Schema.Columns[55]; }
        }
        
        
        
        public static TableSchema.TableColumn Upms24Column
        {
            get { return Schema.Columns[56]; }
        }
        
        
        
        public static TableSchema.TableColumn Secms1Column
        {
            get { return Schema.Columns[57]; }
        }
        
        
        
        public static TableSchema.TableColumn Secms2Column
        {
            get { return Schema.Columns[58]; }
        }
        
        
        
        public static TableSchema.TableColumn Secms3Column
        {
            get { return Schema.Columns[59]; }
        }
        
        
        
        public static TableSchema.TableColumn Secms4Column
        {
            get { return Schema.Columns[60]; }
        }
        
        
        
        public static TableSchema.TableColumn Secms5Column
        {
            get { return Schema.Columns[61]; }
        }
        
        
        
        public static TableSchema.TableColumn Secms6Column
        {
            get { return Schema.Columns[62]; }
        }
        
        
        
        public static TableSchema.TableColumn Secms7Column
        {
            get { return Schema.Columns[63]; }
        }
        
        
        
        public static TableSchema.TableColumn Secms8Column
        {
            get { return Schema.Columns[64]; }
        }
        
        
        
        public static TableSchema.TableColumn Secms9Column
        {
            get { return Schema.Columns[65]; }
        }
        
        
        
        public static TableSchema.TableColumn Secms10Column
        {
            get { return Schema.Columns[66]; }
        }
        
        
        
        public static TableSchema.TableColumn Secms11Column
        {
            get { return Schema.Columns[67]; }
        }
        
        
        
        public static TableSchema.TableColumn Secms12Column
        {
            get { return Schema.Columns[68]; }
        }
        
        
        
        public static TableSchema.TableColumn Secms13Column
        {
            get { return Schema.Columns[69]; }
        }
        
        
        
        public static TableSchema.TableColumn Secms14Column
        {
            get { return Schema.Columns[70]; }
        }
        
        
        
        public static TableSchema.TableColumn Secms15Column
        {
            get { return Schema.Columns[71]; }
        }
        
        
        
        public static TableSchema.TableColumn Secms16Column
        {
            get { return Schema.Columns[72]; }
        }
        
        
        
        public static TableSchema.TableColumn Secms17Column
        {
            get { return Schema.Columns[73]; }
        }
        
        
        
        public static TableSchema.TableColumn Secms18Column
        {
            get { return Schema.Columns[74]; }
        }
        
        
        
        public static TableSchema.TableColumn Secms19Column
        {
            get { return Schema.Columns[75]; }
        }
        
        
        
        public static TableSchema.TableColumn Secms20Column
        {
            get { return Schema.Columns[76]; }
        }
        
        
        
        public static TableSchema.TableColumn Secms21Column
        {
            get { return Schema.Columns[77]; }
        }
        
        
        
        public static TableSchema.TableColumn Secms22Column
        {
            get { return Schema.Columns[78]; }
        }
        
        
        
        public static TableSchema.TableColumn Secms23Column
        {
            get { return Schema.Columns[79]; }
        }
        
        
        
        public static TableSchema.TableColumn Secms24Column
        {
            get { return Schema.Columns[80]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string MarketScoreId = @"MarketScoreId";
			 public static string DateSpan = @"DateSpan";
			 public static string EvaluateLevelId = @"EvaluateLevelId";
			 public static string TotalScore = @"TotalScore";
			 public static string UpViews = @"UpViews";
			 public static string YearId = @"YearId";
			 public static string MonthId = @"MonthId";
			 public static string EmployeeId = @"EmployeeId";
			 public static string IsSubmit = @"IsSubmit";
			 public static string Selfms1 = @"Selfms1";
			 public static string Selfms2 = @"Selfms2";
			 public static string Selfms3 = @"Selfms3";
			 public static string Selfms4 = @"Selfms4";
			 public static string Selfms5 = @"Selfms5";
			 public static string Selfms6 = @"Selfms6";
			 public static string Selfms7 = @"Selfms7";
			 public static string Selfms8 = @"Selfms8";
			 public static string Selfms9 = @"Selfms9";
			 public static string Selfms10 = @"Selfms10";
			 public static string Selfms11 = @"Selfms11";
			 public static string Selfms12 = @"Selfms12";
			 public static string Selfms13 = @"Selfms13";
			 public static string Selfms14 = @"Selfms14";
			 public static string Selfms15 = @"Selfms15";
			 public static string Selfms16 = @"Selfms16";
			 public static string Selfms17 = @"Selfms17";
			 public static string Selfms18 = @"Selfms18";
			 public static string Selfms19 = @"Selfms19";
			 public static string Selfms20 = @"Selfms20";
			 public static string Selfms21 = @"Selfms21";
			 public static string Selfms22 = @"Selfms22";
			 public static string Selfms23 = @"Selfms23";
			 public static string Selfms24 = @"Selfms24";
			 public static string Upms1 = @"Upms1";
			 public static string Upms2 = @"Upms2";
			 public static string Upms3 = @"Upms3";
			 public static string Upms4 = @"Upms4";
			 public static string Upms5 = @"Upms5";
			 public static string Upms6 = @"Upms6";
			 public static string Upms7 = @"Upms7";
			 public static string Upms8 = @"Upms8";
			 public static string Upms9 = @"Upms9";
			 public static string Upms10 = @"Upms10";
			 public static string Upms11 = @"Upms11";
			 public static string Upms12 = @"Upms12";
			 public static string Upms13 = @"Upms13";
			 public static string Upms14 = @"Upms14";
			 public static string Upms15 = @"Upms15";
			 public static string Upms16 = @"Upms16";
			 public static string Upms17 = @"Upms17";
			 public static string Upms18 = @"Upms18";
			 public static string Upms19 = @"Upms19";
			 public static string Upms20 = @"Upms20";
			 public static string Upms21 = @"Upms21";
			 public static string Upms22 = @"Upms22";
			 public static string Upms23 = @"Upms23";
			 public static string Upms24 = @"Upms24";
			 public static string Secms1 = @"Secms1";
			 public static string Secms2 = @"Secms2";
			 public static string Secms3 = @"Secms3";
			 public static string Secms4 = @"Secms4";
			 public static string Secms5 = @"Secms5";
			 public static string Secms6 = @"Secms6";
			 public static string Secms7 = @"Secms7";
			 public static string Secms8 = @"Secms8";
			 public static string Secms9 = @"Secms9";
			 public static string Secms10 = @"Secms10";
			 public static string Secms11 = @"Secms11";
			 public static string Secms12 = @"Secms12";
			 public static string Secms13 = @"Secms13";
			 public static string Secms14 = @"Secms14";
			 public static string Secms15 = @"Secms15";
			 public static string Secms16 = @"Secms16";
			 public static string Secms17 = @"Secms17";
			 public static string Secms18 = @"Secms18";
			 public static string Secms19 = @"Secms19";
			 public static string Secms20 = @"Secms20";
			 public static string Secms21 = @"Secms21";
			 public static string Secms22 = @"Secms22";
			 public static string Secms23 = @"Secms23";
			 public static string Secms24 = @"Secms24";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
