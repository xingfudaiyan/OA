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
	/// Strongly-typed collection for the FrontScore class.
	/// </summary>
    [Serializable]
	public partial class FrontScoreCollection : ActiveList<FrontScore, FrontScoreCollection>
	{	   
		public FrontScoreCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>FrontScoreCollection</returns>
		public FrontScoreCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                FrontScore o = this[i];
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
	/// This is an ActiveRecord class which wraps the FrontScore_tb table.
	/// </summary>
	[Serializable]
	public partial class FrontScore : ActiveRecord<FrontScore>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public FrontScore()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public FrontScore(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public FrontScore(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public FrontScore(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("FrontScore_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarFrontScoreId = new TableSchema.TableColumn(schema);
				colvarFrontScoreId.ColumnName = "FrontScoreId";
				colvarFrontScoreId.DataType = DbType.Int32;
				colvarFrontScoreId.MaxLength = 0;
				colvarFrontScoreId.AutoIncrement = true;
				colvarFrontScoreId.IsNullable = false;
				colvarFrontScoreId.IsPrimaryKey = true;
				colvarFrontScoreId.IsForeignKey = false;
				colvarFrontScoreId.IsReadOnly = false;
				colvarFrontScoreId.DefaultSetting = @"";
				colvarFrontScoreId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFrontScoreId);
				
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
				
				TableSchema.TableColumn colvarSelffs1 = new TableSchema.TableColumn(schema);
				colvarSelffs1.ColumnName = "Selffs1";
				colvarSelffs1.DataType = DbType.String;
				colvarSelffs1.MaxLength = 10;
				colvarSelffs1.AutoIncrement = false;
				colvarSelffs1.IsNullable = true;
				colvarSelffs1.IsPrimaryKey = false;
				colvarSelffs1.IsForeignKey = false;
				colvarSelffs1.IsReadOnly = false;
				colvarSelffs1.DefaultSetting = @"";
				colvarSelffs1.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelffs1);
				
				TableSchema.TableColumn colvarSelffs2 = new TableSchema.TableColumn(schema);
				colvarSelffs2.ColumnName = "Selffs2";
				colvarSelffs2.DataType = DbType.String;
				colvarSelffs2.MaxLength = 10;
				colvarSelffs2.AutoIncrement = false;
				colvarSelffs2.IsNullable = true;
				colvarSelffs2.IsPrimaryKey = false;
				colvarSelffs2.IsForeignKey = false;
				colvarSelffs2.IsReadOnly = false;
				colvarSelffs2.DefaultSetting = @"";
				colvarSelffs2.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelffs2);
				
				TableSchema.TableColumn colvarSelffs3 = new TableSchema.TableColumn(schema);
				colvarSelffs3.ColumnName = "Selffs3";
				colvarSelffs3.DataType = DbType.String;
				colvarSelffs3.MaxLength = 10;
				colvarSelffs3.AutoIncrement = false;
				colvarSelffs3.IsNullable = true;
				colvarSelffs3.IsPrimaryKey = false;
				colvarSelffs3.IsForeignKey = false;
				colvarSelffs3.IsReadOnly = false;
				colvarSelffs3.DefaultSetting = @"";
				colvarSelffs3.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelffs3);
				
				TableSchema.TableColumn colvarSelffs4 = new TableSchema.TableColumn(schema);
				colvarSelffs4.ColumnName = "Selffs4";
				colvarSelffs4.DataType = DbType.String;
				colvarSelffs4.MaxLength = 10;
				colvarSelffs4.AutoIncrement = false;
				colvarSelffs4.IsNullable = true;
				colvarSelffs4.IsPrimaryKey = false;
				colvarSelffs4.IsForeignKey = false;
				colvarSelffs4.IsReadOnly = false;
				colvarSelffs4.DefaultSetting = @"";
				colvarSelffs4.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelffs4);
				
				TableSchema.TableColumn colvarSelffs5 = new TableSchema.TableColumn(schema);
				colvarSelffs5.ColumnName = "Selffs5";
				colvarSelffs5.DataType = DbType.String;
				colvarSelffs5.MaxLength = 10;
				colvarSelffs5.AutoIncrement = false;
				colvarSelffs5.IsNullable = true;
				colvarSelffs5.IsPrimaryKey = false;
				colvarSelffs5.IsForeignKey = false;
				colvarSelffs5.IsReadOnly = false;
				colvarSelffs5.DefaultSetting = @"";
				colvarSelffs5.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelffs5);
				
				TableSchema.TableColumn colvarSelffs6 = new TableSchema.TableColumn(schema);
				colvarSelffs6.ColumnName = "Selffs6";
				colvarSelffs6.DataType = DbType.String;
				colvarSelffs6.MaxLength = 10;
				colvarSelffs6.AutoIncrement = false;
				colvarSelffs6.IsNullable = true;
				colvarSelffs6.IsPrimaryKey = false;
				colvarSelffs6.IsForeignKey = false;
				colvarSelffs6.IsReadOnly = false;
				colvarSelffs6.DefaultSetting = @"";
				colvarSelffs6.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelffs6);
				
				TableSchema.TableColumn colvarSelffs7 = new TableSchema.TableColumn(schema);
				colvarSelffs7.ColumnName = "Selffs7";
				colvarSelffs7.DataType = DbType.String;
				colvarSelffs7.MaxLength = 10;
				colvarSelffs7.AutoIncrement = false;
				colvarSelffs7.IsNullable = true;
				colvarSelffs7.IsPrimaryKey = false;
				colvarSelffs7.IsForeignKey = false;
				colvarSelffs7.IsReadOnly = false;
				colvarSelffs7.DefaultSetting = @"";
				colvarSelffs7.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelffs7);
				
				TableSchema.TableColumn colvarSelffs8 = new TableSchema.TableColumn(schema);
				colvarSelffs8.ColumnName = "Selffs8";
				colvarSelffs8.DataType = DbType.String;
				colvarSelffs8.MaxLength = 10;
				colvarSelffs8.AutoIncrement = false;
				colvarSelffs8.IsNullable = true;
				colvarSelffs8.IsPrimaryKey = false;
				colvarSelffs8.IsForeignKey = false;
				colvarSelffs8.IsReadOnly = false;
				colvarSelffs8.DefaultSetting = @"";
				colvarSelffs8.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelffs8);
				
				TableSchema.TableColumn colvarSelffs9 = new TableSchema.TableColumn(schema);
				colvarSelffs9.ColumnName = "Selffs9";
				colvarSelffs9.DataType = DbType.String;
				colvarSelffs9.MaxLength = 10;
				colvarSelffs9.AutoIncrement = false;
				colvarSelffs9.IsNullable = true;
				colvarSelffs9.IsPrimaryKey = false;
				colvarSelffs9.IsForeignKey = false;
				colvarSelffs9.IsReadOnly = false;
				colvarSelffs9.DefaultSetting = @"";
				colvarSelffs9.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelffs9);
				
				TableSchema.TableColumn colvarSelffs10 = new TableSchema.TableColumn(schema);
				colvarSelffs10.ColumnName = "Selffs10";
				colvarSelffs10.DataType = DbType.String;
				colvarSelffs10.MaxLength = 10;
				colvarSelffs10.AutoIncrement = false;
				colvarSelffs10.IsNullable = true;
				colvarSelffs10.IsPrimaryKey = false;
				colvarSelffs10.IsForeignKey = false;
				colvarSelffs10.IsReadOnly = false;
				colvarSelffs10.DefaultSetting = @"";
				colvarSelffs10.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelffs10);
				
				TableSchema.TableColumn colvarSelffs11 = new TableSchema.TableColumn(schema);
				colvarSelffs11.ColumnName = "Selffs11";
				colvarSelffs11.DataType = DbType.String;
				colvarSelffs11.MaxLength = 10;
				colvarSelffs11.AutoIncrement = false;
				colvarSelffs11.IsNullable = true;
				colvarSelffs11.IsPrimaryKey = false;
				colvarSelffs11.IsForeignKey = false;
				colvarSelffs11.IsReadOnly = false;
				colvarSelffs11.DefaultSetting = @"";
				colvarSelffs11.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelffs11);
				
				TableSchema.TableColumn colvarSelffs12 = new TableSchema.TableColumn(schema);
				colvarSelffs12.ColumnName = "Selffs12";
				colvarSelffs12.DataType = DbType.String;
				colvarSelffs12.MaxLength = 10;
				colvarSelffs12.AutoIncrement = false;
				colvarSelffs12.IsNullable = true;
				colvarSelffs12.IsPrimaryKey = false;
				colvarSelffs12.IsForeignKey = false;
				colvarSelffs12.IsReadOnly = false;
				colvarSelffs12.DefaultSetting = @"";
				colvarSelffs12.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelffs12);
				
				TableSchema.TableColumn colvarSelffs13 = new TableSchema.TableColumn(schema);
				colvarSelffs13.ColumnName = "Selffs13";
				colvarSelffs13.DataType = DbType.String;
				colvarSelffs13.MaxLength = 10;
				colvarSelffs13.AutoIncrement = false;
				colvarSelffs13.IsNullable = true;
				colvarSelffs13.IsPrimaryKey = false;
				colvarSelffs13.IsForeignKey = false;
				colvarSelffs13.IsReadOnly = false;
				colvarSelffs13.DefaultSetting = @"";
				colvarSelffs13.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelffs13);
				
				TableSchema.TableColumn colvarSelffs14 = new TableSchema.TableColumn(schema);
				colvarSelffs14.ColumnName = "Selffs14";
				colvarSelffs14.DataType = DbType.String;
				colvarSelffs14.MaxLength = 10;
				colvarSelffs14.AutoIncrement = false;
				colvarSelffs14.IsNullable = true;
				colvarSelffs14.IsPrimaryKey = false;
				colvarSelffs14.IsForeignKey = false;
				colvarSelffs14.IsReadOnly = false;
				colvarSelffs14.DefaultSetting = @"";
				colvarSelffs14.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelffs14);
				
				TableSchema.TableColumn colvarSelffs15 = new TableSchema.TableColumn(schema);
				colvarSelffs15.ColumnName = "Selffs15";
				colvarSelffs15.DataType = DbType.String;
				colvarSelffs15.MaxLength = 10;
				colvarSelffs15.AutoIncrement = false;
				colvarSelffs15.IsNullable = true;
				colvarSelffs15.IsPrimaryKey = false;
				colvarSelffs15.IsForeignKey = false;
				colvarSelffs15.IsReadOnly = false;
				colvarSelffs15.DefaultSetting = @"";
				colvarSelffs15.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelffs15);
				
				TableSchema.TableColumn colvarSelffs16 = new TableSchema.TableColumn(schema);
				colvarSelffs16.ColumnName = "Selffs16";
				colvarSelffs16.DataType = DbType.String;
				colvarSelffs16.MaxLength = 10;
				colvarSelffs16.AutoIncrement = false;
				colvarSelffs16.IsNullable = true;
				colvarSelffs16.IsPrimaryKey = false;
				colvarSelffs16.IsForeignKey = false;
				colvarSelffs16.IsReadOnly = false;
				colvarSelffs16.DefaultSetting = @"";
				colvarSelffs16.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelffs16);
				
				TableSchema.TableColumn colvarSelffs17 = new TableSchema.TableColumn(schema);
				colvarSelffs17.ColumnName = "Selffs17";
				colvarSelffs17.DataType = DbType.String;
				colvarSelffs17.MaxLength = 10;
				colvarSelffs17.AutoIncrement = false;
				colvarSelffs17.IsNullable = true;
				colvarSelffs17.IsPrimaryKey = false;
				colvarSelffs17.IsForeignKey = false;
				colvarSelffs17.IsReadOnly = false;
				colvarSelffs17.DefaultSetting = @"";
				colvarSelffs17.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelffs17);
				
				TableSchema.TableColumn colvarSelffs18 = new TableSchema.TableColumn(schema);
				colvarSelffs18.ColumnName = "Selffs18";
				colvarSelffs18.DataType = DbType.String;
				colvarSelffs18.MaxLength = 10;
				colvarSelffs18.AutoIncrement = false;
				colvarSelffs18.IsNullable = true;
				colvarSelffs18.IsPrimaryKey = false;
				colvarSelffs18.IsForeignKey = false;
				colvarSelffs18.IsReadOnly = false;
				colvarSelffs18.DefaultSetting = @"";
				colvarSelffs18.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelffs18);
				
				TableSchema.TableColumn colvarSelffs19 = new TableSchema.TableColumn(schema);
				colvarSelffs19.ColumnName = "Selffs19";
				colvarSelffs19.DataType = DbType.String;
				colvarSelffs19.MaxLength = 10;
				colvarSelffs19.AutoIncrement = false;
				colvarSelffs19.IsNullable = true;
				colvarSelffs19.IsPrimaryKey = false;
				colvarSelffs19.IsForeignKey = false;
				colvarSelffs19.IsReadOnly = false;
				colvarSelffs19.DefaultSetting = @"";
				colvarSelffs19.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelffs19);
				
				TableSchema.TableColumn colvarSelffs20 = new TableSchema.TableColumn(schema);
				colvarSelffs20.ColumnName = "Selffs20";
				colvarSelffs20.DataType = DbType.String;
				colvarSelffs20.MaxLength = 10;
				colvarSelffs20.AutoIncrement = false;
				colvarSelffs20.IsNullable = true;
				colvarSelffs20.IsPrimaryKey = false;
				colvarSelffs20.IsForeignKey = false;
				colvarSelffs20.IsReadOnly = false;
				colvarSelffs20.DefaultSetting = @"";
				colvarSelffs20.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelffs20);
				
				TableSchema.TableColumn colvarSelffs21 = new TableSchema.TableColumn(schema);
				colvarSelffs21.ColumnName = "Selffs21";
				colvarSelffs21.DataType = DbType.String;
				colvarSelffs21.MaxLength = 10;
				colvarSelffs21.AutoIncrement = false;
				colvarSelffs21.IsNullable = true;
				colvarSelffs21.IsPrimaryKey = false;
				colvarSelffs21.IsForeignKey = false;
				colvarSelffs21.IsReadOnly = false;
				colvarSelffs21.DefaultSetting = @"";
				colvarSelffs21.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelffs21);
				
				TableSchema.TableColumn colvarUpfs1 = new TableSchema.TableColumn(schema);
				colvarUpfs1.ColumnName = "Upfs1";
				colvarUpfs1.DataType = DbType.String;
				colvarUpfs1.MaxLength = 10;
				colvarUpfs1.AutoIncrement = false;
				colvarUpfs1.IsNullable = true;
				colvarUpfs1.IsPrimaryKey = false;
				colvarUpfs1.IsForeignKey = false;
				colvarUpfs1.IsReadOnly = false;
				colvarUpfs1.DefaultSetting = @"";
				colvarUpfs1.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpfs1);
				
				TableSchema.TableColumn colvarUpfs2 = new TableSchema.TableColumn(schema);
				colvarUpfs2.ColumnName = "Upfs2";
				colvarUpfs2.DataType = DbType.String;
				colvarUpfs2.MaxLength = 10;
				colvarUpfs2.AutoIncrement = false;
				colvarUpfs2.IsNullable = true;
				colvarUpfs2.IsPrimaryKey = false;
				colvarUpfs2.IsForeignKey = false;
				colvarUpfs2.IsReadOnly = false;
				colvarUpfs2.DefaultSetting = @"";
				colvarUpfs2.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpfs2);
				
				TableSchema.TableColumn colvarUpfs3 = new TableSchema.TableColumn(schema);
				colvarUpfs3.ColumnName = "Upfs3";
				colvarUpfs3.DataType = DbType.String;
				colvarUpfs3.MaxLength = 10;
				colvarUpfs3.AutoIncrement = false;
				colvarUpfs3.IsNullable = true;
				colvarUpfs3.IsPrimaryKey = false;
				colvarUpfs3.IsForeignKey = false;
				colvarUpfs3.IsReadOnly = false;
				colvarUpfs3.DefaultSetting = @"";
				colvarUpfs3.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpfs3);
				
				TableSchema.TableColumn colvarUpfs4 = new TableSchema.TableColumn(schema);
				colvarUpfs4.ColumnName = "Upfs4";
				colvarUpfs4.DataType = DbType.String;
				colvarUpfs4.MaxLength = 10;
				colvarUpfs4.AutoIncrement = false;
				colvarUpfs4.IsNullable = true;
				colvarUpfs4.IsPrimaryKey = false;
				colvarUpfs4.IsForeignKey = false;
				colvarUpfs4.IsReadOnly = false;
				colvarUpfs4.DefaultSetting = @"";
				colvarUpfs4.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpfs4);
				
				TableSchema.TableColumn colvarUpfs5 = new TableSchema.TableColumn(schema);
				colvarUpfs5.ColumnName = "Upfs5";
				colvarUpfs5.DataType = DbType.String;
				colvarUpfs5.MaxLength = 10;
				colvarUpfs5.AutoIncrement = false;
				colvarUpfs5.IsNullable = true;
				colvarUpfs5.IsPrimaryKey = false;
				colvarUpfs5.IsForeignKey = false;
				colvarUpfs5.IsReadOnly = false;
				colvarUpfs5.DefaultSetting = @"";
				colvarUpfs5.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpfs5);
				
				TableSchema.TableColumn colvarUpfs6 = new TableSchema.TableColumn(schema);
				colvarUpfs6.ColumnName = "Upfs6";
				colvarUpfs6.DataType = DbType.String;
				colvarUpfs6.MaxLength = 10;
				colvarUpfs6.AutoIncrement = false;
				colvarUpfs6.IsNullable = true;
				colvarUpfs6.IsPrimaryKey = false;
				colvarUpfs6.IsForeignKey = false;
				colvarUpfs6.IsReadOnly = false;
				colvarUpfs6.DefaultSetting = @"";
				colvarUpfs6.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpfs6);
				
				TableSchema.TableColumn colvarUpfs7 = new TableSchema.TableColumn(schema);
				colvarUpfs7.ColumnName = "Upfs7";
				colvarUpfs7.DataType = DbType.String;
				colvarUpfs7.MaxLength = 10;
				colvarUpfs7.AutoIncrement = false;
				colvarUpfs7.IsNullable = true;
				colvarUpfs7.IsPrimaryKey = false;
				colvarUpfs7.IsForeignKey = false;
				colvarUpfs7.IsReadOnly = false;
				colvarUpfs7.DefaultSetting = @"";
				colvarUpfs7.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpfs7);
				
				TableSchema.TableColumn colvarUpfs8 = new TableSchema.TableColumn(schema);
				colvarUpfs8.ColumnName = "Upfs8";
				colvarUpfs8.DataType = DbType.String;
				colvarUpfs8.MaxLength = 10;
				colvarUpfs8.AutoIncrement = false;
				colvarUpfs8.IsNullable = true;
				colvarUpfs8.IsPrimaryKey = false;
				colvarUpfs8.IsForeignKey = false;
				colvarUpfs8.IsReadOnly = false;
				colvarUpfs8.DefaultSetting = @"";
				colvarUpfs8.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpfs8);
				
				TableSchema.TableColumn colvarUpfs9 = new TableSchema.TableColumn(schema);
				colvarUpfs9.ColumnName = "Upfs9";
				colvarUpfs9.DataType = DbType.String;
				colvarUpfs9.MaxLength = 10;
				colvarUpfs9.AutoIncrement = false;
				colvarUpfs9.IsNullable = true;
				colvarUpfs9.IsPrimaryKey = false;
				colvarUpfs9.IsForeignKey = false;
				colvarUpfs9.IsReadOnly = false;
				colvarUpfs9.DefaultSetting = @"";
				colvarUpfs9.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpfs9);
				
				TableSchema.TableColumn colvarUpfs10 = new TableSchema.TableColumn(schema);
				colvarUpfs10.ColumnName = "Upfs10";
				colvarUpfs10.DataType = DbType.String;
				colvarUpfs10.MaxLength = 10;
				colvarUpfs10.AutoIncrement = false;
				colvarUpfs10.IsNullable = true;
				colvarUpfs10.IsPrimaryKey = false;
				colvarUpfs10.IsForeignKey = false;
				colvarUpfs10.IsReadOnly = false;
				colvarUpfs10.DefaultSetting = @"";
				colvarUpfs10.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpfs10);
				
				TableSchema.TableColumn colvarUpfs11 = new TableSchema.TableColumn(schema);
				colvarUpfs11.ColumnName = "Upfs11";
				colvarUpfs11.DataType = DbType.String;
				colvarUpfs11.MaxLength = 10;
				colvarUpfs11.AutoIncrement = false;
				colvarUpfs11.IsNullable = true;
				colvarUpfs11.IsPrimaryKey = false;
				colvarUpfs11.IsForeignKey = false;
				colvarUpfs11.IsReadOnly = false;
				colvarUpfs11.DefaultSetting = @"";
				colvarUpfs11.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpfs11);
				
				TableSchema.TableColumn colvarUpfs12 = new TableSchema.TableColumn(schema);
				colvarUpfs12.ColumnName = "Upfs12";
				colvarUpfs12.DataType = DbType.String;
				colvarUpfs12.MaxLength = 10;
				colvarUpfs12.AutoIncrement = false;
				colvarUpfs12.IsNullable = true;
				colvarUpfs12.IsPrimaryKey = false;
				colvarUpfs12.IsForeignKey = false;
				colvarUpfs12.IsReadOnly = false;
				colvarUpfs12.DefaultSetting = @"";
				colvarUpfs12.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpfs12);
				
				TableSchema.TableColumn colvarUpfs13 = new TableSchema.TableColumn(schema);
				colvarUpfs13.ColumnName = "Upfs13";
				colvarUpfs13.DataType = DbType.String;
				colvarUpfs13.MaxLength = 10;
				colvarUpfs13.AutoIncrement = false;
				colvarUpfs13.IsNullable = true;
				colvarUpfs13.IsPrimaryKey = false;
				colvarUpfs13.IsForeignKey = false;
				colvarUpfs13.IsReadOnly = false;
				colvarUpfs13.DefaultSetting = @"";
				colvarUpfs13.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpfs13);
				
				TableSchema.TableColumn colvarUpfs14 = new TableSchema.TableColumn(schema);
				colvarUpfs14.ColumnName = "Upfs14";
				colvarUpfs14.DataType = DbType.String;
				colvarUpfs14.MaxLength = 10;
				colvarUpfs14.AutoIncrement = false;
				colvarUpfs14.IsNullable = true;
				colvarUpfs14.IsPrimaryKey = false;
				colvarUpfs14.IsForeignKey = false;
				colvarUpfs14.IsReadOnly = false;
				colvarUpfs14.DefaultSetting = @"";
				colvarUpfs14.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpfs14);
				
				TableSchema.TableColumn colvarUpfs15 = new TableSchema.TableColumn(schema);
				colvarUpfs15.ColumnName = "Upfs15";
				colvarUpfs15.DataType = DbType.String;
				colvarUpfs15.MaxLength = 10;
				colvarUpfs15.AutoIncrement = false;
				colvarUpfs15.IsNullable = true;
				colvarUpfs15.IsPrimaryKey = false;
				colvarUpfs15.IsForeignKey = false;
				colvarUpfs15.IsReadOnly = false;
				colvarUpfs15.DefaultSetting = @"";
				colvarUpfs15.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpfs15);
				
				TableSchema.TableColumn colvarUpfs16 = new TableSchema.TableColumn(schema);
				colvarUpfs16.ColumnName = "Upfs16";
				colvarUpfs16.DataType = DbType.String;
				colvarUpfs16.MaxLength = 10;
				colvarUpfs16.AutoIncrement = false;
				colvarUpfs16.IsNullable = true;
				colvarUpfs16.IsPrimaryKey = false;
				colvarUpfs16.IsForeignKey = false;
				colvarUpfs16.IsReadOnly = false;
				colvarUpfs16.DefaultSetting = @"";
				colvarUpfs16.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpfs16);
				
				TableSchema.TableColumn colvarUpfs17 = new TableSchema.TableColumn(schema);
				colvarUpfs17.ColumnName = "Upfs17";
				colvarUpfs17.DataType = DbType.String;
				colvarUpfs17.MaxLength = 10;
				colvarUpfs17.AutoIncrement = false;
				colvarUpfs17.IsNullable = true;
				colvarUpfs17.IsPrimaryKey = false;
				colvarUpfs17.IsForeignKey = false;
				colvarUpfs17.IsReadOnly = false;
				colvarUpfs17.DefaultSetting = @"";
				colvarUpfs17.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpfs17);
				
				TableSchema.TableColumn colvarUpfs18 = new TableSchema.TableColumn(schema);
				colvarUpfs18.ColumnName = "Upfs18";
				colvarUpfs18.DataType = DbType.String;
				colvarUpfs18.MaxLength = 10;
				colvarUpfs18.AutoIncrement = false;
				colvarUpfs18.IsNullable = true;
				colvarUpfs18.IsPrimaryKey = false;
				colvarUpfs18.IsForeignKey = false;
				colvarUpfs18.IsReadOnly = false;
				colvarUpfs18.DefaultSetting = @"";
				colvarUpfs18.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpfs18);
				
				TableSchema.TableColumn colvarUpfs19 = new TableSchema.TableColumn(schema);
				colvarUpfs19.ColumnName = "Upfs19";
				colvarUpfs19.DataType = DbType.String;
				colvarUpfs19.MaxLength = 10;
				colvarUpfs19.AutoIncrement = false;
				colvarUpfs19.IsNullable = true;
				colvarUpfs19.IsPrimaryKey = false;
				colvarUpfs19.IsForeignKey = false;
				colvarUpfs19.IsReadOnly = false;
				colvarUpfs19.DefaultSetting = @"";
				colvarUpfs19.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpfs19);
				
				TableSchema.TableColumn colvarUpfs20 = new TableSchema.TableColumn(schema);
				colvarUpfs20.ColumnName = "Upfs20";
				colvarUpfs20.DataType = DbType.String;
				colvarUpfs20.MaxLength = 10;
				colvarUpfs20.AutoIncrement = false;
				colvarUpfs20.IsNullable = true;
				colvarUpfs20.IsPrimaryKey = false;
				colvarUpfs20.IsForeignKey = false;
				colvarUpfs20.IsReadOnly = false;
				colvarUpfs20.DefaultSetting = @"";
				colvarUpfs20.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpfs20);
				
				TableSchema.TableColumn colvarUpfs21 = new TableSchema.TableColumn(schema);
				colvarUpfs21.ColumnName = "Upfs21";
				colvarUpfs21.DataType = DbType.String;
				colvarUpfs21.MaxLength = 10;
				colvarUpfs21.AutoIncrement = false;
				colvarUpfs21.IsNullable = true;
				colvarUpfs21.IsPrimaryKey = false;
				colvarUpfs21.IsForeignKey = false;
				colvarUpfs21.IsReadOnly = false;
				colvarUpfs21.DefaultSetting = @"";
				colvarUpfs21.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpfs21);
				
				TableSchema.TableColumn colvarSecfs1 = new TableSchema.TableColumn(schema);
				colvarSecfs1.ColumnName = "Secfs1";
				colvarSecfs1.DataType = DbType.String;
				colvarSecfs1.MaxLength = 10;
				colvarSecfs1.AutoIncrement = false;
				colvarSecfs1.IsNullable = true;
				colvarSecfs1.IsPrimaryKey = false;
				colvarSecfs1.IsForeignKey = false;
				colvarSecfs1.IsReadOnly = false;
				colvarSecfs1.DefaultSetting = @"";
				colvarSecfs1.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecfs1);
				
				TableSchema.TableColumn colvarSecfs2 = new TableSchema.TableColumn(schema);
				colvarSecfs2.ColumnName = "Secfs2";
				colvarSecfs2.DataType = DbType.String;
				colvarSecfs2.MaxLength = 10;
				colvarSecfs2.AutoIncrement = false;
				colvarSecfs2.IsNullable = true;
				colvarSecfs2.IsPrimaryKey = false;
				colvarSecfs2.IsForeignKey = false;
				colvarSecfs2.IsReadOnly = false;
				colvarSecfs2.DefaultSetting = @"";
				colvarSecfs2.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecfs2);
				
				TableSchema.TableColumn colvarSecfs3 = new TableSchema.TableColumn(schema);
				colvarSecfs3.ColumnName = "Secfs3";
				colvarSecfs3.DataType = DbType.String;
				colvarSecfs3.MaxLength = 10;
				colvarSecfs3.AutoIncrement = false;
				colvarSecfs3.IsNullable = true;
				colvarSecfs3.IsPrimaryKey = false;
				colvarSecfs3.IsForeignKey = false;
				colvarSecfs3.IsReadOnly = false;
				colvarSecfs3.DefaultSetting = @"";
				colvarSecfs3.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecfs3);
				
				TableSchema.TableColumn colvarSecfs4 = new TableSchema.TableColumn(schema);
				colvarSecfs4.ColumnName = "Secfs4";
				colvarSecfs4.DataType = DbType.String;
				colvarSecfs4.MaxLength = 10;
				colvarSecfs4.AutoIncrement = false;
				colvarSecfs4.IsNullable = true;
				colvarSecfs4.IsPrimaryKey = false;
				colvarSecfs4.IsForeignKey = false;
				colvarSecfs4.IsReadOnly = false;
				colvarSecfs4.DefaultSetting = @"";
				colvarSecfs4.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecfs4);
				
				TableSchema.TableColumn colvarSecfs5 = new TableSchema.TableColumn(schema);
				colvarSecfs5.ColumnName = "Secfs5";
				colvarSecfs5.DataType = DbType.String;
				colvarSecfs5.MaxLength = 10;
				colvarSecfs5.AutoIncrement = false;
				colvarSecfs5.IsNullable = true;
				colvarSecfs5.IsPrimaryKey = false;
				colvarSecfs5.IsForeignKey = false;
				colvarSecfs5.IsReadOnly = false;
				colvarSecfs5.DefaultSetting = @"";
				colvarSecfs5.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecfs5);
				
				TableSchema.TableColumn colvarSecfs6 = new TableSchema.TableColumn(schema);
				colvarSecfs6.ColumnName = "Secfs6";
				colvarSecfs6.DataType = DbType.String;
				colvarSecfs6.MaxLength = 10;
				colvarSecfs6.AutoIncrement = false;
				colvarSecfs6.IsNullable = true;
				colvarSecfs6.IsPrimaryKey = false;
				colvarSecfs6.IsForeignKey = false;
				colvarSecfs6.IsReadOnly = false;
				colvarSecfs6.DefaultSetting = @"";
				colvarSecfs6.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecfs6);
				
				TableSchema.TableColumn colvarSecfs7 = new TableSchema.TableColumn(schema);
				colvarSecfs7.ColumnName = "Secfs7";
				colvarSecfs7.DataType = DbType.String;
				colvarSecfs7.MaxLength = 10;
				colvarSecfs7.AutoIncrement = false;
				colvarSecfs7.IsNullable = true;
				colvarSecfs7.IsPrimaryKey = false;
				colvarSecfs7.IsForeignKey = false;
				colvarSecfs7.IsReadOnly = false;
				colvarSecfs7.DefaultSetting = @"";
				colvarSecfs7.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecfs7);
				
				TableSchema.TableColumn colvarSecfs8 = new TableSchema.TableColumn(schema);
				colvarSecfs8.ColumnName = "Secfs8";
				colvarSecfs8.DataType = DbType.String;
				colvarSecfs8.MaxLength = 10;
				colvarSecfs8.AutoIncrement = false;
				colvarSecfs8.IsNullable = true;
				colvarSecfs8.IsPrimaryKey = false;
				colvarSecfs8.IsForeignKey = false;
				colvarSecfs8.IsReadOnly = false;
				colvarSecfs8.DefaultSetting = @"";
				colvarSecfs8.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecfs8);
				
				TableSchema.TableColumn colvarSecfs9 = new TableSchema.TableColumn(schema);
				colvarSecfs9.ColumnName = "Secfs9";
				colvarSecfs9.DataType = DbType.String;
				colvarSecfs9.MaxLength = 10;
				colvarSecfs9.AutoIncrement = false;
				colvarSecfs9.IsNullable = true;
				colvarSecfs9.IsPrimaryKey = false;
				colvarSecfs9.IsForeignKey = false;
				colvarSecfs9.IsReadOnly = false;
				colvarSecfs9.DefaultSetting = @"";
				colvarSecfs9.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecfs9);
				
				TableSchema.TableColumn colvarSecfs10 = new TableSchema.TableColumn(schema);
				colvarSecfs10.ColumnName = "Secfs10";
				colvarSecfs10.DataType = DbType.String;
				colvarSecfs10.MaxLength = 10;
				colvarSecfs10.AutoIncrement = false;
				colvarSecfs10.IsNullable = true;
				colvarSecfs10.IsPrimaryKey = false;
				colvarSecfs10.IsForeignKey = false;
				colvarSecfs10.IsReadOnly = false;
				colvarSecfs10.DefaultSetting = @"";
				colvarSecfs10.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecfs10);
				
				TableSchema.TableColumn colvarSecfs11 = new TableSchema.TableColumn(schema);
				colvarSecfs11.ColumnName = "Secfs11";
				colvarSecfs11.DataType = DbType.String;
				colvarSecfs11.MaxLength = 10;
				colvarSecfs11.AutoIncrement = false;
				colvarSecfs11.IsNullable = true;
				colvarSecfs11.IsPrimaryKey = false;
				colvarSecfs11.IsForeignKey = false;
				colvarSecfs11.IsReadOnly = false;
				colvarSecfs11.DefaultSetting = @"";
				colvarSecfs11.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecfs11);
				
				TableSchema.TableColumn colvarSecfs12 = new TableSchema.TableColumn(schema);
				colvarSecfs12.ColumnName = "Secfs12";
				colvarSecfs12.DataType = DbType.String;
				colvarSecfs12.MaxLength = 10;
				colvarSecfs12.AutoIncrement = false;
				colvarSecfs12.IsNullable = true;
				colvarSecfs12.IsPrimaryKey = false;
				colvarSecfs12.IsForeignKey = false;
				colvarSecfs12.IsReadOnly = false;
				colvarSecfs12.DefaultSetting = @"";
				colvarSecfs12.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecfs12);
				
				TableSchema.TableColumn colvarSecfs13 = new TableSchema.TableColumn(schema);
				colvarSecfs13.ColumnName = "Secfs13";
				colvarSecfs13.DataType = DbType.String;
				colvarSecfs13.MaxLength = 10;
				colvarSecfs13.AutoIncrement = false;
				colvarSecfs13.IsNullable = true;
				colvarSecfs13.IsPrimaryKey = false;
				colvarSecfs13.IsForeignKey = false;
				colvarSecfs13.IsReadOnly = false;
				colvarSecfs13.DefaultSetting = @"";
				colvarSecfs13.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecfs13);
				
				TableSchema.TableColumn colvarSecfs14 = new TableSchema.TableColumn(schema);
				colvarSecfs14.ColumnName = "Secfs14";
				colvarSecfs14.DataType = DbType.String;
				colvarSecfs14.MaxLength = 10;
				colvarSecfs14.AutoIncrement = false;
				colvarSecfs14.IsNullable = true;
				colvarSecfs14.IsPrimaryKey = false;
				colvarSecfs14.IsForeignKey = false;
				colvarSecfs14.IsReadOnly = false;
				colvarSecfs14.DefaultSetting = @"";
				colvarSecfs14.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecfs14);
				
				TableSchema.TableColumn colvarSecfs15 = new TableSchema.TableColumn(schema);
				colvarSecfs15.ColumnName = "Secfs15";
				colvarSecfs15.DataType = DbType.String;
				colvarSecfs15.MaxLength = 10;
				colvarSecfs15.AutoIncrement = false;
				colvarSecfs15.IsNullable = true;
				colvarSecfs15.IsPrimaryKey = false;
				colvarSecfs15.IsForeignKey = false;
				colvarSecfs15.IsReadOnly = false;
				colvarSecfs15.DefaultSetting = @"";
				colvarSecfs15.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecfs15);
				
				TableSchema.TableColumn colvarSecfs16 = new TableSchema.TableColumn(schema);
				colvarSecfs16.ColumnName = "Secfs16";
				colvarSecfs16.DataType = DbType.String;
				colvarSecfs16.MaxLength = 10;
				colvarSecfs16.AutoIncrement = false;
				colvarSecfs16.IsNullable = true;
				colvarSecfs16.IsPrimaryKey = false;
				colvarSecfs16.IsForeignKey = false;
				colvarSecfs16.IsReadOnly = false;
				colvarSecfs16.DefaultSetting = @"";
				colvarSecfs16.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecfs16);
				
				TableSchema.TableColumn colvarSecfs17 = new TableSchema.TableColumn(schema);
				colvarSecfs17.ColumnName = "Secfs17";
				colvarSecfs17.DataType = DbType.String;
				colvarSecfs17.MaxLength = 10;
				colvarSecfs17.AutoIncrement = false;
				colvarSecfs17.IsNullable = true;
				colvarSecfs17.IsPrimaryKey = false;
				colvarSecfs17.IsForeignKey = false;
				colvarSecfs17.IsReadOnly = false;
				colvarSecfs17.DefaultSetting = @"";
				colvarSecfs17.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecfs17);
				
				TableSchema.TableColumn colvarSecfs18 = new TableSchema.TableColumn(schema);
				colvarSecfs18.ColumnName = "Secfs18";
				colvarSecfs18.DataType = DbType.String;
				colvarSecfs18.MaxLength = 10;
				colvarSecfs18.AutoIncrement = false;
				colvarSecfs18.IsNullable = true;
				colvarSecfs18.IsPrimaryKey = false;
				colvarSecfs18.IsForeignKey = false;
				colvarSecfs18.IsReadOnly = false;
				colvarSecfs18.DefaultSetting = @"";
				colvarSecfs18.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecfs18);
				
				TableSchema.TableColumn colvarSecfs19 = new TableSchema.TableColumn(schema);
				colvarSecfs19.ColumnName = "Secfs19";
				colvarSecfs19.DataType = DbType.String;
				colvarSecfs19.MaxLength = 10;
				colvarSecfs19.AutoIncrement = false;
				colvarSecfs19.IsNullable = true;
				colvarSecfs19.IsPrimaryKey = false;
				colvarSecfs19.IsForeignKey = false;
				colvarSecfs19.IsReadOnly = false;
				colvarSecfs19.DefaultSetting = @"";
				colvarSecfs19.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecfs19);
				
				TableSchema.TableColumn colvarSecfs20 = new TableSchema.TableColumn(schema);
				colvarSecfs20.ColumnName = "Secfs20";
				colvarSecfs20.DataType = DbType.String;
				colvarSecfs20.MaxLength = 10;
				colvarSecfs20.AutoIncrement = false;
				colvarSecfs20.IsNullable = true;
				colvarSecfs20.IsPrimaryKey = false;
				colvarSecfs20.IsForeignKey = false;
				colvarSecfs20.IsReadOnly = false;
				colvarSecfs20.DefaultSetting = @"";
				colvarSecfs20.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecfs20);
				
				TableSchema.TableColumn colvarSecfs21 = new TableSchema.TableColumn(schema);
				colvarSecfs21.ColumnName = "Secfs21";
				colvarSecfs21.DataType = DbType.String;
				colvarSecfs21.MaxLength = 10;
				colvarSecfs21.AutoIncrement = false;
				colvarSecfs21.IsNullable = true;
				colvarSecfs21.IsPrimaryKey = false;
				colvarSecfs21.IsForeignKey = false;
				colvarSecfs21.IsReadOnly = false;
				colvarSecfs21.DefaultSetting = @"";
				colvarSecfs21.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSecfs21);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("FrontScore_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("FrontScoreId")]
		[Bindable(true)]
		public int FrontScoreId 
		{
			get { return GetColumnValue<int>(Columns.FrontScoreId); }
			set { SetColumnValue(Columns.FrontScoreId, value); }
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
		  
		[XmlAttribute("Selffs1")]
		[Bindable(true)]
		public string Selffs1 
		{
			get { return GetColumnValue<string>(Columns.Selffs1); }
			set { SetColumnValue(Columns.Selffs1, value); }
		}
		  
		[XmlAttribute("Selffs2")]
		[Bindable(true)]
		public string Selffs2 
		{
			get { return GetColumnValue<string>(Columns.Selffs2); }
			set { SetColumnValue(Columns.Selffs2, value); }
		}
		  
		[XmlAttribute("Selffs3")]
		[Bindable(true)]
		public string Selffs3 
		{
			get { return GetColumnValue<string>(Columns.Selffs3); }
			set { SetColumnValue(Columns.Selffs3, value); }
		}
		  
		[XmlAttribute("Selffs4")]
		[Bindable(true)]
		public string Selffs4 
		{
			get { return GetColumnValue<string>(Columns.Selffs4); }
			set { SetColumnValue(Columns.Selffs4, value); }
		}
		  
		[XmlAttribute("Selffs5")]
		[Bindable(true)]
		public string Selffs5 
		{
			get { return GetColumnValue<string>(Columns.Selffs5); }
			set { SetColumnValue(Columns.Selffs5, value); }
		}
		  
		[XmlAttribute("Selffs6")]
		[Bindable(true)]
		public string Selffs6 
		{
			get { return GetColumnValue<string>(Columns.Selffs6); }
			set { SetColumnValue(Columns.Selffs6, value); }
		}
		  
		[XmlAttribute("Selffs7")]
		[Bindable(true)]
		public string Selffs7 
		{
			get { return GetColumnValue<string>(Columns.Selffs7); }
			set { SetColumnValue(Columns.Selffs7, value); }
		}
		  
		[XmlAttribute("Selffs8")]
		[Bindable(true)]
		public string Selffs8 
		{
			get { return GetColumnValue<string>(Columns.Selffs8); }
			set { SetColumnValue(Columns.Selffs8, value); }
		}
		  
		[XmlAttribute("Selffs9")]
		[Bindable(true)]
		public string Selffs9 
		{
			get { return GetColumnValue<string>(Columns.Selffs9); }
			set { SetColumnValue(Columns.Selffs9, value); }
		}
		  
		[XmlAttribute("Selffs10")]
		[Bindable(true)]
		public string Selffs10 
		{
			get { return GetColumnValue<string>(Columns.Selffs10); }
			set { SetColumnValue(Columns.Selffs10, value); }
		}
		  
		[XmlAttribute("Selffs11")]
		[Bindable(true)]
		public string Selffs11 
		{
			get { return GetColumnValue<string>(Columns.Selffs11); }
			set { SetColumnValue(Columns.Selffs11, value); }
		}
		  
		[XmlAttribute("Selffs12")]
		[Bindable(true)]
		public string Selffs12 
		{
			get { return GetColumnValue<string>(Columns.Selffs12); }
			set { SetColumnValue(Columns.Selffs12, value); }
		}
		  
		[XmlAttribute("Selffs13")]
		[Bindable(true)]
		public string Selffs13 
		{
			get { return GetColumnValue<string>(Columns.Selffs13); }
			set { SetColumnValue(Columns.Selffs13, value); }
		}
		  
		[XmlAttribute("Selffs14")]
		[Bindable(true)]
		public string Selffs14 
		{
			get { return GetColumnValue<string>(Columns.Selffs14); }
			set { SetColumnValue(Columns.Selffs14, value); }
		}
		  
		[XmlAttribute("Selffs15")]
		[Bindable(true)]
		public string Selffs15 
		{
			get { return GetColumnValue<string>(Columns.Selffs15); }
			set { SetColumnValue(Columns.Selffs15, value); }
		}
		  
		[XmlAttribute("Selffs16")]
		[Bindable(true)]
		public string Selffs16 
		{
			get { return GetColumnValue<string>(Columns.Selffs16); }
			set { SetColumnValue(Columns.Selffs16, value); }
		}
		  
		[XmlAttribute("Selffs17")]
		[Bindable(true)]
		public string Selffs17 
		{
			get { return GetColumnValue<string>(Columns.Selffs17); }
			set { SetColumnValue(Columns.Selffs17, value); }
		}
		  
		[XmlAttribute("Selffs18")]
		[Bindable(true)]
		public string Selffs18 
		{
			get { return GetColumnValue<string>(Columns.Selffs18); }
			set { SetColumnValue(Columns.Selffs18, value); }
		}
		  
		[XmlAttribute("Selffs19")]
		[Bindable(true)]
		public string Selffs19 
		{
			get { return GetColumnValue<string>(Columns.Selffs19); }
			set { SetColumnValue(Columns.Selffs19, value); }
		}
		  
		[XmlAttribute("Selffs20")]
		[Bindable(true)]
		public string Selffs20 
		{
			get { return GetColumnValue<string>(Columns.Selffs20); }
			set { SetColumnValue(Columns.Selffs20, value); }
		}
		  
		[XmlAttribute("Selffs21")]
		[Bindable(true)]
		public string Selffs21 
		{
			get { return GetColumnValue<string>(Columns.Selffs21); }
			set { SetColumnValue(Columns.Selffs21, value); }
		}
		  
		[XmlAttribute("Upfs1")]
		[Bindable(true)]
		public string Upfs1 
		{
			get { return GetColumnValue<string>(Columns.Upfs1); }
			set { SetColumnValue(Columns.Upfs1, value); }
		}
		  
		[XmlAttribute("Upfs2")]
		[Bindable(true)]
		public string Upfs2 
		{
			get { return GetColumnValue<string>(Columns.Upfs2); }
			set { SetColumnValue(Columns.Upfs2, value); }
		}
		  
		[XmlAttribute("Upfs3")]
		[Bindable(true)]
		public string Upfs3 
		{
			get { return GetColumnValue<string>(Columns.Upfs3); }
			set { SetColumnValue(Columns.Upfs3, value); }
		}
		  
		[XmlAttribute("Upfs4")]
		[Bindable(true)]
		public string Upfs4 
		{
			get { return GetColumnValue<string>(Columns.Upfs4); }
			set { SetColumnValue(Columns.Upfs4, value); }
		}
		  
		[XmlAttribute("Upfs5")]
		[Bindable(true)]
		public string Upfs5 
		{
			get { return GetColumnValue<string>(Columns.Upfs5); }
			set { SetColumnValue(Columns.Upfs5, value); }
		}
		  
		[XmlAttribute("Upfs6")]
		[Bindable(true)]
		public string Upfs6 
		{
			get { return GetColumnValue<string>(Columns.Upfs6); }
			set { SetColumnValue(Columns.Upfs6, value); }
		}
		  
		[XmlAttribute("Upfs7")]
		[Bindable(true)]
		public string Upfs7 
		{
			get { return GetColumnValue<string>(Columns.Upfs7); }
			set { SetColumnValue(Columns.Upfs7, value); }
		}
		  
		[XmlAttribute("Upfs8")]
		[Bindable(true)]
		public string Upfs8 
		{
			get { return GetColumnValue<string>(Columns.Upfs8); }
			set { SetColumnValue(Columns.Upfs8, value); }
		}
		  
		[XmlAttribute("Upfs9")]
		[Bindable(true)]
		public string Upfs9 
		{
			get { return GetColumnValue<string>(Columns.Upfs9); }
			set { SetColumnValue(Columns.Upfs9, value); }
		}
		  
		[XmlAttribute("Upfs10")]
		[Bindable(true)]
		public string Upfs10 
		{
			get { return GetColumnValue<string>(Columns.Upfs10); }
			set { SetColumnValue(Columns.Upfs10, value); }
		}
		  
		[XmlAttribute("Upfs11")]
		[Bindable(true)]
		public string Upfs11 
		{
			get { return GetColumnValue<string>(Columns.Upfs11); }
			set { SetColumnValue(Columns.Upfs11, value); }
		}
		  
		[XmlAttribute("Upfs12")]
		[Bindable(true)]
		public string Upfs12 
		{
			get { return GetColumnValue<string>(Columns.Upfs12); }
			set { SetColumnValue(Columns.Upfs12, value); }
		}
		  
		[XmlAttribute("Upfs13")]
		[Bindable(true)]
		public string Upfs13 
		{
			get { return GetColumnValue<string>(Columns.Upfs13); }
			set { SetColumnValue(Columns.Upfs13, value); }
		}
		  
		[XmlAttribute("Upfs14")]
		[Bindable(true)]
		public string Upfs14 
		{
			get { return GetColumnValue<string>(Columns.Upfs14); }
			set { SetColumnValue(Columns.Upfs14, value); }
		}
		  
		[XmlAttribute("Upfs15")]
		[Bindable(true)]
		public string Upfs15 
		{
			get { return GetColumnValue<string>(Columns.Upfs15); }
			set { SetColumnValue(Columns.Upfs15, value); }
		}
		  
		[XmlAttribute("Upfs16")]
		[Bindable(true)]
		public string Upfs16 
		{
			get { return GetColumnValue<string>(Columns.Upfs16); }
			set { SetColumnValue(Columns.Upfs16, value); }
		}
		  
		[XmlAttribute("Upfs17")]
		[Bindable(true)]
		public string Upfs17 
		{
			get { return GetColumnValue<string>(Columns.Upfs17); }
			set { SetColumnValue(Columns.Upfs17, value); }
		}
		  
		[XmlAttribute("Upfs18")]
		[Bindable(true)]
		public string Upfs18 
		{
			get { return GetColumnValue<string>(Columns.Upfs18); }
			set { SetColumnValue(Columns.Upfs18, value); }
		}
		  
		[XmlAttribute("Upfs19")]
		[Bindable(true)]
		public string Upfs19 
		{
			get { return GetColumnValue<string>(Columns.Upfs19); }
			set { SetColumnValue(Columns.Upfs19, value); }
		}
		  
		[XmlAttribute("Upfs20")]
		[Bindable(true)]
		public string Upfs20 
		{
			get { return GetColumnValue<string>(Columns.Upfs20); }
			set { SetColumnValue(Columns.Upfs20, value); }
		}
		  
		[XmlAttribute("Upfs21")]
		[Bindable(true)]
		public string Upfs21 
		{
			get { return GetColumnValue<string>(Columns.Upfs21); }
			set { SetColumnValue(Columns.Upfs21, value); }
		}
		  
		[XmlAttribute("Secfs1")]
		[Bindable(true)]
		public string Secfs1 
		{
			get { return GetColumnValue<string>(Columns.Secfs1); }
			set { SetColumnValue(Columns.Secfs1, value); }
		}
		  
		[XmlAttribute("Secfs2")]
		[Bindable(true)]
		public string Secfs2 
		{
			get { return GetColumnValue<string>(Columns.Secfs2); }
			set { SetColumnValue(Columns.Secfs2, value); }
		}
		  
		[XmlAttribute("Secfs3")]
		[Bindable(true)]
		public string Secfs3 
		{
			get { return GetColumnValue<string>(Columns.Secfs3); }
			set { SetColumnValue(Columns.Secfs3, value); }
		}
		  
		[XmlAttribute("Secfs4")]
		[Bindable(true)]
		public string Secfs4 
		{
			get { return GetColumnValue<string>(Columns.Secfs4); }
			set { SetColumnValue(Columns.Secfs4, value); }
		}
		  
		[XmlAttribute("Secfs5")]
		[Bindable(true)]
		public string Secfs5 
		{
			get { return GetColumnValue<string>(Columns.Secfs5); }
			set { SetColumnValue(Columns.Secfs5, value); }
		}
		  
		[XmlAttribute("Secfs6")]
		[Bindable(true)]
		public string Secfs6 
		{
			get { return GetColumnValue<string>(Columns.Secfs6); }
			set { SetColumnValue(Columns.Secfs6, value); }
		}
		  
		[XmlAttribute("Secfs7")]
		[Bindable(true)]
		public string Secfs7 
		{
			get { return GetColumnValue<string>(Columns.Secfs7); }
			set { SetColumnValue(Columns.Secfs7, value); }
		}
		  
		[XmlAttribute("Secfs8")]
		[Bindable(true)]
		public string Secfs8 
		{
			get { return GetColumnValue<string>(Columns.Secfs8); }
			set { SetColumnValue(Columns.Secfs8, value); }
		}
		  
		[XmlAttribute("Secfs9")]
		[Bindable(true)]
		public string Secfs9 
		{
			get { return GetColumnValue<string>(Columns.Secfs9); }
			set { SetColumnValue(Columns.Secfs9, value); }
		}
		  
		[XmlAttribute("Secfs10")]
		[Bindable(true)]
		public string Secfs10 
		{
			get { return GetColumnValue<string>(Columns.Secfs10); }
			set { SetColumnValue(Columns.Secfs10, value); }
		}
		  
		[XmlAttribute("Secfs11")]
		[Bindable(true)]
		public string Secfs11 
		{
			get { return GetColumnValue<string>(Columns.Secfs11); }
			set { SetColumnValue(Columns.Secfs11, value); }
		}
		  
		[XmlAttribute("Secfs12")]
		[Bindable(true)]
		public string Secfs12 
		{
			get { return GetColumnValue<string>(Columns.Secfs12); }
			set { SetColumnValue(Columns.Secfs12, value); }
		}
		  
		[XmlAttribute("Secfs13")]
		[Bindable(true)]
		public string Secfs13 
		{
			get { return GetColumnValue<string>(Columns.Secfs13); }
			set { SetColumnValue(Columns.Secfs13, value); }
		}
		  
		[XmlAttribute("Secfs14")]
		[Bindable(true)]
		public string Secfs14 
		{
			get { return GetColumnValue<string>(Columns.Secfs14); }
			set { SetColumnValue(Columns.Secfs14, value); }
		}
		  
		[XmlAttribute("Secfs15")]
		[Bindable(true)]
		public string Secfs15 
		{
			get { return GetColumnValue<string>(Columns.Secfs15); }
			set { SetColumnValue(Columns.Secfs15, value); }
		}
		  
		[XmlAttribute("Secfs16")]
		[Bindable(true)]
		public string Secfs16 
		{
			get { return GetColumnValue<string>(Columns.Secfs16); }
			set { SetColumnValue(Columns.Secfs16, value); }
		}
		  
		[XmlAttribute("Secfs17")]
		[Bindable(true)]
		public string Secfs17 
		{
			get { return GetColumnValue<string>(Columns.Secfs17); }
			set { SetColumnValue(Columns.Secfs17, value); }
		}
		  
		[XmlAttribute("Secfs18")]
		[Bindable(true)]
		public string Secfs18 
		{
			get { return GetColumnValue<string>(Columns.Secfs18); }
			set { SetColumnValue(Columns.Secfs18, value); }
		}
		  
		[XmlAttribute("Secfs19")]
		[Bindable(true)]
		public string Secfs19 
		{
			get { return GetColumnValue<string>(Columns.Secfs19); }
			set { SetColumnValue(Columns.Secfs19, value); }
		}
		  
		[XmlAttribute("Secfs20")]
		[Bindable(true)]
		public string Secfs20 
		{
			get { return GetColumnValue<string>(Columns.Secfs20); }
			set { SetColumnValue(Columns.Secfs20, value); }
		}
		  
		[XmlAttribute("Secfs21")]
		[Bindable(true)]
		public string Secfs21 
		{
			get { return GetColumnValue<string>(Columns.Secfs21); }
			set { SetColumnValue(Columns.Secfs21, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varDateSpan,int? varEvaluateLevelId,string varTotalScore,string varUpViews,int? varYearId,int? varMonthId,int? varEmployeeId,int? varIsSubmit,string varSelffs1,string varSelffs2,string varSelffs3,string varSelffs4,string varSelffs5,string varSelffs6,string varSelffs7,string varSelffs8,string varSelffs9,string varSelffs10,string varSelffs11,string varSelffs12,string varSelffs13,string varSelffs14,string varSelffs15,string varSelffs16,string varSelffs17,string varSelffs18,string varSelffs19,string varSelffs20,string varSelffs21,string varUpfs1,string varUpfs2,string varUpfs3,string varUpfs4,string varUpfs5,string varUpfs6,string varUpfs7,string varUpfs8,string varUpfs9,string varUpfs10,string varUpfs11,string varUpfs12,string varUpfs13,string varUpfs14,string varUpfs15,string varUpfs16,string varUpfs17,string varUpfs18,string varUpfs19,string varUpfs20,string varUpfs21,string varSecfs1,string varSecfs2,string varSecfs3,string varSecfs4,string varSecfs5,string varSecfs6,string varSecfs7,string varSecfs8,string varSecfs9,string varSecfs10,string varSecfs11,string varSecfs12,string varSecfs13,string varSecfs14,string varSecfs15,string varSecfs16,string varSecfs17,string varSecfs18,string varSecfs19,string varSecfs20,string varSecfs21)
		{
			FrontScore item = new FrontScore();
			
			item.DateSpan = varDateSpan;
			
			item.EvaluateLevelId = varEvaluateLevelId;
			
			item.TotalScore = varTotalScore;
			
			item.UpViews = varUpViews;
			
			item.YearId = varYearId;
			
			item.MonthId = varMonthId;
			
			item.EmployeeId = varEmployeeId;
			
			item.IsSubmit = varIsSubmit;
			
			item.Selffs1 = varSelffs1;
			
			item.Selffs2 = varSelffs2;
			
			item.Selffs3 = varSelffs3;
			
			item.Selffs4 = varSelffs4;
			
			item.Selffs5 = varSelffs5;
			
			item.Selffs6 = varSelffs6;
			
			item.Selffs7 = varSelffs7;
			
			item.Selffs8 = varSelffs8;
			
			item.Selffs9 = varSelffs9;
			
			item.Selffs10 = varSelffs10;
			
			item.Selffs11 = varSelffs11;
			
			item.Selffs12 = varSelffs12;
			
			item.Selffs13 = varSelffs13;
			
			item.Selffs14 = varSelffs14;
			
			item.Selffs15 = varSelffs15;
			
			item.Selffs16 = varSelffs16;
			
			item.Selffs17 = varSelffs17;
			
			item.Selffs18 = varSelffs18;
			
			item.Selffs19 = varSelffs19;
			
			item.Selffs20 = varSelffs20;
			
			item.Selffs21 = varSelffs21;
			
			item.Upfs1 = varUpfs1;
			
			item.Upfs2 = varUpfs2;
			
			item.Upfs3 = varUpfs3;
			
			item.Upfs4 = varUpfs4;
			
			item.Upfs5 = varUpfs5;
			
			item.Upfs6 = varUpfs6;
			
			item.Upfs7 = varUpfs7;
			
			item.Upfs8 = varUpfs8;
			
			item.Upfs9 = varUpfs9;
			
			item.Upfs10 = varUpfs10;
			
			item.Upfs11 = varUpfs11;
			
			item.Upfs12 = varUpfs12;
			
			item.Upfs13 = varUpfs13;
			
			item.Upfs14 = varUpfs14;
			
			item.Upfs15 = varUpfs15;
			
			item.Upfs16 = varUpfs16;
			
			item.Upfs17 = varUpfs17;
			
			item.Upfs18 = varUpfs18;
			
			item.Upfs19 = varUpfs19;
			
			item.Upfs20 = varUpfs20;
			
			item.Upfs21 = varUpfs21;
			
			item.Secfs1 = varSecfs1;
			
			item.Secfs2 = varSecfs2;
			
			item.Secfs3 = varSecfs3;
			
			item.Secfs4 = varSecfs4;
			
			item.Secfs5 = varSecfs5;
			
			item.Secfs6 = varSecfs6;
			
			item.Secfs7 = varSecfs7;
			
			item.Secfs8 = varSecfs8;
			
			item.Secfs9 = varSecfs9;
			
			item.Secfs10 = varSecfs10;
			
			item.Secfs11 = varSecfs11;
			
			item.Secfs12 = varSecfs12;
			
			item.Secfs13 = varSecfs13;
			
			item.Secfs14 = varSecfs14;
			
			item.Secfs15 = varSecfs15;
			
			item.Secfs16 = varSecfs16;
			
			item.Secfs17 = varSecfs17;
			
			item.Secfs18 = varSecfs18;
			
			item.Secfs19 = varSecfs19;
			
			item.Secfs20 = varSecfs20;
			
			item.Secfs21 = varSecfs21;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varFrontScoreId,string varDateSpan,int? varEvaluateLevelId,string varTotalScore,string varUpViews,int? varYearId,int? varMonthId,int? varEmployeeId,int? varIsSubmit,string varSelffs1,string varSelffs2,string varSelffs3,string varSelffs4,string varSelffs5,string varSelffs6,string varSelffs7,string varSelffs8,string varSelffs9,string varSelffs10,string varSelffs11,string varSelffs12,string varSelffs13,string varSelffs14,string varSelffs15,string varSelffs16,string varSelffs17,string varSelffs18,string varSelffs19,string varSelffs20,string varSelffs21,string varUpfs1,string varUpfs2,string varUpfs3,string varUpfs4,string varUpfs5,string varUpfs6,string varUpfs7,string varUpfs8,string varUpfs9,string varUpfs10,string varUpfs11,string varUpfs12,string varUpfs13,string varUpfs14,string varUpfs15,string varUpfs16,string varUpfs17,string varUpfs18,string varUpfs19,string varUpfs20,string varUpfs21,string varSecfs1,string varSecfs2,string varSecfs3,string varSecfs4,string varSecfs5,string varSecfs6,string varSecfs7,string varSecfs8,string varSecfs9,string varSecfs10,string varSecfs11,string varSecfs12,string varSecfs13,string varSecfs14,string varSecfs15,string varSecfs16,string varSecfs17,string varSecfs18,string varSecfs19,string varSecfs20,string varSecfs21)
		{
			FrontScore item = new FrontScore();
			
				item.FrontScoreId = varFrontScoreId;
			
				item.DateSpan = varDateSpan;
			
				item.EvaluateLevelId = varEvaluateLevelId;
			
				item.TotalScore = varTotalScore;
			
				item.UpViews = varUpViews;
			
				item.YearId = varYearId;
			
				item.MonthId = varMonthId;
			
				item.EmployeeId = varEmployeeId;
			
				item.IsSubmit = varIsSubmit;
			
				item.Selffs1 = varSelffs1;
			
				item.Selffs2 = varSelffs2;
			
				item.Selffs3 = varSelffs3;
			
				item.Selffs4 = varSelffs4;
			
				item.Selffs5 = varSelffs5;
			
				item.Selffs6 = varSelffs6;
			
				item.Selffs7 = varSelffs7;
			
				item.Selffs8 = varSelffs8;
			
				item.Selffs9 = varSelffs9;
			
				item.Selffs10 = varSelffs10;
			
				item.Selffs11 = varSelffs11;
			
				item.Selffs12 = varSelffs12;
			
				item.Selffs13 = varSelffs13;
			
				item.Selffs14 = varSelffs14;
			
				item.Selffs15 = varSelffs15;
			
				item.Selffs16 = varSelffs16;
			
				item.Selffs17 = varSelffs17;
			
				item.Selffs18 = varSelffs18;
			
				item.Selffs19 = varSelffs19;
			
				item.Selffs20 = varSelffs20;
			
				item.Selffs21 = varSelffs21;
			
				item.Upfs1 = varUpfs1;
			
				item.Upfs2 = varUpfs2;
			
				item.Upfs3 = varUpfs3;
			
				item.Upfs4 = varUpfs4;
			
				item.Upfs5 = varUpfs5;
			
				item.Upfs6 = varUpfs6;
			
				item.Upfs7 = varUpfs7;
			
				item.Upfs8 = varUpfs8;
			
				item.Upfs9 = varUpfs9;
			
				item.Upfs10 = varUpfs10;
			
				item.Upfs11 = varUpfs11;
			
				item.Upfs12 = varUpfs12;
			
				item.Upfs13 = varUpfs13;
			
				item.Upfs14 = varUpfs14;
			
				item.Upfs15 = varUpfs15;
			
				item.Upfs16 = varUpfs16;
			
				item.Upfs17 = varUpfs17;
			
				item.Upfs18 = varUpfs18;
			
				item.Upfs19 = varUpfs19;
			
				item.Upfs20 = varUpfs20;
			
				item.Upfs21 = varUpfs21;
			
				item.Secfs1 = varSecfs1;
			
				item.Secfs2 = varSecfs2;
			
				item.Secfs3 = varSecfs3;
			
				item.Secfs4 = varSecfs4;
			
				item.Secfs5 = varSecfs5;
			
				item.Secfs6 = varSecfs6;
			
				item.Secfs7 = varSecfs7;
			
				item.Secfs8 = varSecfs8;
			
				item.Secfs9 = varSecfs9;
			
				item.Secfs10 = varSecfs10;
			
				item.Secfs11 = varSecfs11;
			
				item.Secfs12 = varSecfs12;
			
				item.Secfs13 = varSecfs13;
			
				item.Secfs14 = varSecfs14;
			
				item.Secfs15 = varSecfs15;
			
				item.Secfs16 = varSecfs16;
			
				item.Secfs17 = varSecfs17;
			
				item.Secfs18 = varSecfs18;
			
				item.Secfs19 = varSecfs19;
			
				item.Secfs20 = varSecfs20;
			
				item.Secfs21 = varSecfs21;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn FrontScoreIdColumn
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
        
        
        
        public static TableSchema.TableColumn Selffs1Column
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn Selffs2Column
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn Selffs3Column
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn Selffs4Column
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn Selffs5Column
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn Selffs6Column
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn Selffs7Column
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn Selffs8Column
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn Selffs9Column
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn Selffs10Column
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn Selffs11Column
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        public static TableSchema.TableColumn Selffs12Column
        {
            get { return Schema.Columns[20]; }
        }
        
        
        
        public static TableSchema.TableColumn Selffs13Column
        {
            get { return Schema.Columns[21]; }
        }
        
        
        
        public static TableSchema.TableColumn Selffs14Column
        {
            get { return Schema.Columns[22]; }
        }
        
        
        
        public static TableSchema.TableColumn Selffs15Column
        {
            get { return Schema.Columns[23]; }
        }
        
        
        
        public static TableSchema.TableColumn Selffs16Column
        {
            get { return Schema.Columns[24]; }
        }
        
        
        
        public static TableSchema.TableColumn Selffs17Column
        {
            get { return Schema.Columns[25]; }
        }
        
        
        
        public static TableSchema.TableColumn Selffs18Column
        {
            get { return Schema.Columns[26]; }
        }
        
        
        
        public static TableSchema.TableColumn Selffs19Column
        {
            get { return Schema.Columns[27]; }
        }
        
        
        
        public static TableSchema.TableColumn Selffs20Column
        {
            get { return Schema.Columns[28]; }
        }
        
        
        
        public static TableSchema.TableColumn Selffs21Column
        {
            get { return Schema.Columns[29]; }
        }
        
        
        
        public static TableSchema.TableColumn Upfs1Column
        {
            get { return Schema.Columns[30]; }
        }
        
        
        
        public static TableSchema.TableColumn Upfs2Column
        {
            get { return Schema.Columns[31]; }
        }
        
        
        
        public static TableSchema.TableColumn Upfs3Column
        {
            get { return Schema.Columns[32]; }
        }
        
        
        
        public static TableSchema.TableColumn Upfs4Column
        {
            get { return Schema.Columns[33]; }
        }
        
        
        
        public static TableSchema.TableColumn Upfs5Column
        {
            get { return Schema.Columns[34]; }
        }
        
        
        
        public static TableSchema.TableColumn Upfs6Column
        {
            get { return Schema.Columns[35]; }
        }
        
        
        
        public static TableSchema.TableColumn Upfs7Column
        {
            get { return Schema.Columns[36]; }
        }
        
        
        
        public static TableSchema.TableColumn Upfs8Column
        {
            get { return Schema.Columns[37]; }
        }
        
        
        
        public static TableSchema.TableColumn Upfs9Column
        {
            get { return Schema.Columns[38]; }
        }
        
        
        
        public static TableSchema.TableColumn Upfs10Column
        {
            get { return Schema.Columns[39]; }
        }
        
        
        
        public static TableSchema.TableColumn Upfs11Column
        {
            get { return Schema.Columns[40]; }
        }
        
        
        
        public static TableSchema.TableColumn Upfs12Column
        {
            get { return Schema.Columns[41]; }
        }
        
        
        
        public static TableSchema.TableColumn Upfs13Column
        {
            get { return Schema.Columns[42]; }
        }
        
        
        
        public static TableSchema.TableColumn Upfs14Column
        {
            get { return Schema.Columns[43]; }
        }
        
        
        
        public static TableSchema.TableColumn Upfs15Column
        {
            get { return Schema.Columns[44]; }
        }
        
        
        
        public static TableSchema.TableColumn Upfs16Column
        {
            get { return Schema.Columns[45]; }
        }
        
        
        
        public static TableSchema.TableColumn Upfs17Column
        {
            get { return Schema.Columns[46]; }
        }
        
        
        
        public static TableSchema.TableColumn Upfs18Column
        {
            get { return Schema.Columns[47]; }
        }
        
        
        
        public static TableSchema.TableColumn Upfs19Column
        {
            get { return Schema.Columns[48]; }
        }
        
        
        
        public static TableSchema.TableColumn Upfs20Column
        {
            get { return Schema.Columns[49]; }
        }
        
        
        
        public static TableSchema.TableColumn Upfs21Column
        {
            get { return Schema.Columns[50]; }
        }
        
        
        
        public static TableSchema.TableColumn Secfs1Column
        {
            get { return Schema.Columns[51]; }
        }
        
        
        
        public static TableSchema.TableColumn Secfs2Column
        {
            get { return Schema.Columns[52]; }
        }
        
        
        
        public static TableSchema.TableColumn Secfs3Column
        {
            get { return Schema.Columns[53]; }
        }
        
        
        
        public static TableSchema.TableColumn Secfs4Column
        {
            get { return Schema.Columns[54]; }
        }
        
        
        
        public static TableSchema.TableColumn Secfs5Column
        {
            get { return Schema.Columns[55]; }
        }
        
        
        
        public static TableSchema.TableColumn Secfs6Column
        {
            get { return Schema.Columns[56]; }
        }
        
        
        
        public static TableSchema.TableColumn Secfs7Column
        {
            get { return Schema.Columns[57]; }
        }
        
        
        
        public static TableSchema.TableColumn Secfs8Column
        {
            get { return Schema.Columns[58]; }
        }
        
        
        
        public static TableSchema.TableColumn Secfs9Column
        {
            get { return Schema.Columns[59]; }
        }
        
        
        
        public static TableSchema.TableColumn Secfs10Column
        {
            get { return Schema.Columns[60]; }
        }
        
        
        
        public static TableSchema.TableColumn Secfs11Column
        {
            get { return Schema.Columns[61]; }
        }
        
        
        
        public static TableSchema.TableColumn Secfs12Column
        {
            get { return Schema.Columns[62]; }
        }
        
        
        
        public static TableSchema.TableColumn Secfs13Column
        {
            get { return Schema.Columns[63]; }
        }
        
        
        
        public static TableSchema.TableColumn Secfs14Column
        {
            get { return Schema.Columns[64]; }
        }
        
        
        
        public static TableSchema.TableColumn Secfs15Column
        {
            get { return Schema.Columns[65]; }
        }
        
        
        
        public static TableSchema.TableColumn Secfs16Column
        {
            get { return Schema.Columns[66]; }
        }
        
        
        
        public static TableSchema.TableColumn Secfs17Column
        {
            get { return Schema.Columns[67]; }
        }
        
        
        
        public static TableSchema.TableColumn Secfs18Column
        {
            get { return Schema.Columns[68]; }
        }
        
        
        
        public static TableSchema.TableColumn Secfs19Column
        {
            get { return Schema.Columns[69]; }
        }
        
        
        
        public static TableSchema.TableColumn Secfs20Column
        {
            get { return Schema.Columns[70]; }
        }
        
        
        
        public static TableSchema.TableColumn Secfs21Column
        {
            get { return Schema.Columns[71]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string FrontScoreId = @"FrontScoreId";
			 public static string DateSpan = @"DateSpan";
			 public static string EvaluateLevelId = @"EvaluateLevelId";
			 public static string TotalScore = @"TotalScore";
			 public static string UpViews = @"UpViews";
			 public static string YearId = @"YearId";
			 public static string MonthId = @"MonthId";
			 public static string EmployeeId = @"EmployeeId";
			 public static string IsSubmit = @"IsSubmit";
			 public static string Selffs1 = @"Selffs1";
			 public static string Selffs2 = @"Selffs2";
			 public static string Selffs3 = @"Selffs3";
			 public static string Selffs4 = @"Selffs4";
			 public static string Selffs5 = @"Selffs5";
			 public static string Selffs6 = @"Selffs6";
			 public static string Selffs7 = @"Selffs7";
			 public static string Selffs8 = @"Selffs8";
			 public static string Selffs9 = @"Selffs9";
			 public static string Selffs10 = @"Selffs10";
			 public static string Selffs11 = @"Selffs11";
			 public static string Selffs12 = @"Selffs12";
			 public static string Selffs13 = @"Selffs13";
			 public static string Selffs14 = @"Selffs14";
			 public static string Selffs15 = @"Selffs15";
			 public static string Selffs16 = @"Selffs16";
			 public static string Selffs17 = @"Selffs17";
			 public static string Selffs18 = @"Selffs18";
			 public static string Selffs19 = @"Selffs19";
			 public static string Selffs20 = @"Selffs20";
			 public static string Selffs21 = @"Selffs21";
			 public static string Upfs1 = @"Upfs1";
			 public static string Upfs2 = @"Upfs2";
			 public static string Upfs3 = @"Upfs3";
			 public static string Upfs4 = @"Upfs4";
			 public static string Upfs5 = @"Upfs5";
			 public static string Upfs6 = @"Upfs6";
			 public static string Upfs7 = @"Upfs7";
			 public static string Upfs8 = @"Upfs8";
			 public static string Upfs9 = @"Upfs9";
			 public static string Upfs10 = @"Upfs10";
			 public static string Upfs11 = @"Upfs11";
			 public static string Upfs12 = @"Upfs12";
			 public static string Upfs13 = @"Upfs13";
			 public static string Upfs14 = @"Upfs14";
			 public static string Upfs15 = @"Upfs15";
			 public static string Upfs16 = @"Upfs16";
			 public static string Upfs17 = @"Upfs17";
			 public static string Upfs18 = @"Upfs18";
			 public static string Upfs19 = @"Upfs19";
			 public static string Upfs20 = @"Upfs20";
			 public static string Upfs21 = @"Upfs21";
			 public static string Secfs1 = @"Secfs1";
			 public static string Secfs2 = @"Secfs2";
			 public static string Secfs3 = @"Secfs3";
			 public static string Secfs4 = @"Secfs4";
			 public static string Secfs5 = @"Secfs5";
			 public static string Secfs6 = @"Secfs6";
			 public static string Secfs7 = @"Secfs7";
			 public static string Secfs8 = @"Secfs8";
			 public static string Secfs9 = @"Secfs9";
			 public static string Secfs10 = @"Secfs10";
			 public static string Secfs11 = @"Secfs11";
			 public static string Secfs12 = @"Secfs12";
			 public static string Secfs13 = @"Secfs13";
			 public static string Secfs14 = @"Secfs14";
			 public static string Secfs15 = @"Secfs15";
			 public static string Secfs16 = @"Secfs16";
			 public static string Secfs17 = @"Secfs17";
			 public static string Secfs18 = @"Secfs18";
			 public static string Secfs19 = @"Secfs19";
			 public static string Secfs20 = @"Secfs20";
			 public static string Secfs21 = @"Secfs21";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
