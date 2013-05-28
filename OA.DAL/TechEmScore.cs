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
	/// Strongly-typed collection for the TechEmScore class.
	/// </summary>
    [Serializable]
	public partial class TechEmScoreCollection : ActiveList<TechEmScore, TechEmScoreCollection>
	{	   
		public TechEmScoreCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TechEmScoreCollection</returns>
		public TechEmScoreCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TechEmScore o = this[i];
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
	/// This is an ActiveRecord class which wraps the TechEmScore_tb table.
	/// </summary>
	[Serializable]
	public partial class TechEmScore : ActiveRecord<TechEmScore>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TechEmScore()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TechEmScore(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TechEmScore(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TechEmScore(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TechEmScore_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarTechEmScoreId = new TableSchema.TableColumn(schema);
				colvarTechEmScoreId.ColumnName = "TechEmScoreId";
				colvarTechEmScoreId.DataType = DbType.Int32;
				colvarTechEmScoreId.MaxLength = 0;
				colvarTechEmScoreId.AutoIncrement = true;
				colvarTechEmScoreId.IsNullable = false;
				colvarTechEmScoreId.IsPrimaryKey = true;
				colvarTechEmScoreId.IsForeignKey = false;
				colvarTechEmScoreId.IsReadOnly = false;
				colvarTechEmScoreId.DefaultSetting = @"";
				colvarTechEmScoreId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTechEmScoreId);
				
				TableSchema.TableColumn colvarSelfPlan = new TableSchema.TableColumn(schema);
				colvarSelfPlan.ColumnName = "SelfPlan";
				colvarSelfPlan.DataType = DbType.String;
				colvarSelfPlan.MaxLength = 10;
				colvarSelfPlan.AutoIncrement = false;
				colvarSelfPlan.IsNullable = true;
				colvarSelfPlan.IsPrimaryKey = false;
				colvarSelfPlan.IsForeignKey = false;
				colvarSelfPlan.IsReadOnly = false;
				colvarSelfPlan.DefaultSetting = @"";
				colvarSelfPlan.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfPlan);
				
				TableSchema.TableColumn colvarSelfWorkTotal = new TableSchema.TableColumn(schema);
				colvarSelfWorkTotal.ColumnName = "SelfWorkTotal";
				colvarSelfWorkTotal.DataType = DbType.String;
				colvarSelfWorkTotal.MaxLength = 10;
				colvarSelfWorkTotal.AutoIncrement = false;
				colvarSelfWorkTotal.IsNullable = true;
				colvarSelfWorkTotal.IsPrimaryKey = false;
				colvarSelfWorkTotal.IsForeignKey = false;
				colvarSelfWorkTotal.IsReadOnly = false;
				colvarSelfWorkTotal.DefaultSetting = @"";
				colvarSelfWorkTotal.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfWorkTotal);
				
				TableSchema.TableColumn colvarSelfWorkSpeed = new TableSchema.TableColumn(schema);
				colvarSelfWorkSpeed.ColumnName = "SelfWorkSpeed";
				colvarSelfWorkSpeed.DataType = DbType.String;
				colvarSelfWorkSpeed.MaxLength = 10;
				colvarSelfWorkSpeed.AutoIncrement = false;
				colvarSelfWorkSpeed.IsNullable = true;
				colvarSelfWorkSpeed.IsPrimaryKey = false;
				colvarSelfWorkSpeed.IsForeignKey = false;
				colvarSelfWorkSpeed.IsReadOnly = false;
				colvarSelfWorkSpeed.DefaultSetting = @"";
				colvarSelfWorkSpeed.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfWorkSpeed);
				
				TableSchema.TableColumn colvarSelfCommunicate = new TableSchema.TableColumn(schema);
				colvarSelfCommunicate.ColumnName = "SelfCommunicate";
				colvarSelfCommunicate.DataType = DbType.String;
				colvarSelfCommunicate.MaxLength = 10;
				colvarSelfCommunicate.AutoIncrement = false;
				colvarSelfCommunicate.IsNullable = true;
				colvarSelfCommunicate.IsPrimaryKey = false;
				colvarSelfCommunicate.IsForeignKey = false;
				colvarSelfCommunicate.IsReadOnly = false;
				colvarSelfCommunicate.DefaultSetting = @"";
				colvarSelfCommunicate.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfCommunicate);
				
				TableSchema.TableColumn colvarSelfDescipline = new TableSchema.TableColumn(schema);
				colvarSelfDescipline.ColumnName = "SelfDescipline";
				colvarSelfDescipline.DataType = DbType.String;
				colvarSelfDescipline.MaxLength = 10;
				colvarSelfDescipline.AutoIncrement = false;
				colvarSelfDescipline.IsNullable = true;
				colvarSelfDescipline.IsPrimaryKey = false;
				colvarSelfDescipline.IsForeignKey = false;
				colvarSelfDescipline.IsReadOnly = false;
				colvarSelfDescipline.DefaultSetting = @"";
				colvarSelfDescipline.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfDescipline);
				
				TableSchema.TableColumn colvarSelfExecute = new TableSchema.TableColumn(schema);
				colvarSelfExecute.ColumnName = "SelfExecute";
				colvarSelfExecute.DataType = DbType.String;
				colvarSelfExecute.MaxLength = 10;
				colvarSelfExecute.AutoIncrement = false;
				colvarSelfExecute.IsNullable = true;
				colvarSelfExecute.IsPrimaryKey = false;
				colvarSelfExecute.IsForeignKey = false;
				colvarSelfExecute.IsReadOnly = false;
				colvarSelfExecute.DefaultSetting = @"";
				colvarSelfExecute.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfExecute);
				
				TableSchema.TableColumn colvarSelfRoute = new TableSchema.TableColumn(schema);
				colvarSelfRoute.ColumnName = "SelfRoute";
				colvarSelfRoute.DataType = DbType.String;
				colvarSelfRoute.MaxLength = 10;
				colvarSelfRoute.AutoIncrement = false;
				colvarSelfRoute.IsNullable = true;
				colvarSelfRoute.IsPrimaryKey = false;
				colvarSelfRoute.IsForeignKey = false;
				colvarSelfRoute.IsReadOnly = false;
				colvarSelfRoute.DefaultSetting = @"";
				colvarSelfRoute.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfRoute);
				
				TableSchema.TableColumn colvarSelfProfession = new TableSchema.TableColumn(schema);
				colvarSelfProfession.ColumnName = "SelfProfession";
				colvarSelfProfession.DataType = DbType.String;
				colvarSelfProfession.MaxLength = 10;
				colvarSelfProfession.AutoIncrement = false;
				colvarSelfProfession.IsNullable = true;
				colvarSelfProfession.IsPrimaryKey = false;
				colvarSelfProfession.IsForeignKey = false;
				colvarSelfProfession.IsReadOnly = false;
				colvarSelfProfession.DefaultSetting = @"";
				colvarSelfProfession.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfProfession);
				
				TableSchema.TableColumn colvarSelfAttitude = new TableSchema.TableColumn(schema);
				colvarSelfAttitude.ColumnName = "SelfAttitude";
				colvarSelfAttitude.DataType = DbType.String;
				colvarSelfAttitude.MaxLength = 10;
				colvarSelfAttitude.AutoIncrement = false;
				colvarSelfAttitude.IsNullable = true;
				colvarSelfAttitude.IsPrimaryKey = false;
				colvarSelfAttitude.IsForeignKey = false;
				colvarSelfAttitude.IsReadOnly = false;
				colvarSelfAttitude.DefaultSetting = @"";
				colvarSelfAttitude.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfAttitude);
				
				TableSchema.TableColumn colvarSelfComplex = new TableSchema.TableColumn(schema);
				colvarSelfComplex.ColumnName = "SelfComplex";
				colvarSelfComplex.DataType = DbType.String;
				colvarSelfComplex.MaxLength = 10;
				colvarSelfComplex.AutoIncrement = false;
				colvarSelfComplex.IsNullable = true;
				colvarSelfComplex.IsPrimaryKey = false;
				colvarSelfComplex.IsForeignKey = false;
				colvarSelfComplex.IsReadOnly = false;
				colvarSelfComplex.DefaultSetting = @"";
				colvarSelfComplex.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfComplex);
				
				TableSchema.TableColumn colvarSelfSpeciality = new TableSchema.TableColumn(schema);
				colvarSelfSpeciality.ColumnName = "SelfSpeciality";
				colvarSelfSpeciality.DataType = DbType.String;
				colvarSelfSpeciality.MaxLength = 10;
				colvarSelfSpeciality.AutoIncrement = false;
				colvarSelfSpeciality.IsNullable = true;
				colvarSelfSpeciality.IsPrimaryKey = false;
				colvarSelfSpeciality.IsForeignKey = false;
				colvarSelfSpeciality.IsReadOnly = false;
				colvarSelfSpeciality.DefaultSetting = @"";
				colvarSelfSpeciality.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSelfSpeciality);
				
				TableSchema.TableColumn colvarUpPlan = new TableSchema.TableColumn(schema);
				colvarUpPlan.ColumnName = "UpPlan";
				colvarUpPlan.DataType = DbType.String;
				colvarUpPlan.MaxLength = 10;
				colvarUpPlan.AutoIncrement = false;
				colvarUpPlan.IsNullable = true;
				colvarUpPlan.IsPrimaryKey = false;
				colvarUpPlan.IsForeignKey = false;
				colvarUpPlan.IsReadOnly = false;
				colvarUpPlan.DefaultSetting = @"";
				colvarUpPlan.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpPlan);
				
				TableSchema.TableColumn colvarUpWorkTotal = new TableSchema.TableColumn(schema);
				colvarUpWorkTotal.ColumnName = "UpWorkTotal";
				colvarUpWorkTotal.DataType = DbType.String;
				colvarUpWorkTotal.MaxLength = 10;
				colvarUpWorkTotal.AutoIncrement = false;
				colvarUpWorkTotal.IsNullable = true;
				colvarUpWorkTotal.IsPrimaryKey = false;
				colvarUpWorkTotal.IsForeignKey = false;
				colvarUpWorkTotal.IsReadOnly = false;
				colvarUpWorkTotal.DefaultSetting = @"";
				colvarUpWorkTotal.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpWorkTotal);
				
				TableSchema.TableColumn colvarUpWorkSpeed = new TableSchema.TableColumn(schema);
				colvarUpWorkSpeed.ColumnName = "UpWorkSpeed";
				colvarUpWorkSpeed.DataType = DbType.String;
				colvarUpWorkSpeed.MaxLength = 10;
				colvarUpWorkSpeed.AutoIncrement = false;
				colvarUpWorkSpeed.IsNullable = true;
				colvarUpWorkSpeed.IsPrimaryKey = false;
				colvarUpWorkSpeed.IsForeignKey = false;
				colvarUpWorkSpeed.IsReadOnly = false;
				colvarUpWorkSpeed.DefaultSetting = @"";
				colvarUpWorkSpeed.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpWorkSpeed);
				
				TableSchema.TableColumn colvarUpCommunicate = new TableSchema.TableColumn(schema);
				colvarUpCommunicate.ColumnName = "UpCommunicate";
				colvarUpCommunicate.DataType = DbType.String;
				colvarUpCommunicate.MaxLength = 10;
				colvarUpCommunicate.AutoIncrement = false;
				colvarUpCommunicate.IsNullable = true;
				colvarUpCommunicate.IsPrimaryKey = false;
				colvarUpCommunicate.IsForeignKey = false;
				colvarUpCommunicate.IsReadOnly = false;
				colvarUpCommunicate.DefaultSetting = @"";
				colvarUpCommunicate.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpCommunicate);
				
				TableSchema.TableColumn colvarUpDescipline = new TableSchema.TableColumn(schema);
				colvarUpDescipline.ColumnName = "UpDescipline";
				colvarUpDescipline.DataType = DbType.String;
				colvarUpDescipline.MaxLength = 10;
				colvarUpDescipline.AutoIncrement = false;
				colvarUpDescipline.IsNullable = true;
				colvarUpDescipline.IsPrimaryKey = false;
				colvarUpDescipline.IsForeignKey = false;
				colvarUpDescipline.IsReadOnly = false;
				colvarUpDescipline.DefaultSetting = @"";
				colvarUpDescipline.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpDescipline);
				
				TableSchema.TableColumn colvarUpExecute = new TableSchema.TableColumn(schema);
				colvarUpExecute.ColumnName = "UpExecute";
				colvarUpExecute.DataType = DbType.String;
				colvarUpExecute.MaxLength = 10;
				colvarUpExecute.AutoIncrement = false;
				colvarUpExecute.IsNullable = true;
				colvarUpExecute.IsPrimaryKey = false;
				colvarUpExecute.IsForeignKey = false;
				colvarUpExecute.IsReadOnly = false;
				colvarUpExecute.DefaultSetting = @"";
				colvarUpExecute.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpExecute);
				
				TableSchema.TableColumn colvarUpRoute = new TableSchema.TableColumn(schema);
				colvarUpRoute.ColumnName = "UpRoute";
				colvarUpRoute.DataType = DbType.String;
				colvarUpRoute.MaxLength = 10;
				colvarUpRoute.AutoIncrement = false;
				colvarUpRoute.IsNullable = true;
				colvarUpRoute.IsPrimaryKey = false;
				colvarUpRoute.IsForeignKey = false;
				colvarUpRoute.IsReadOnly = false;
				colvarUpRoute.DefaultSetting = @"";
				colvarUpRoute.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpRoute);
				
				TableSchema.TableColumn colvarUpProfession = new TableSchema.TableColumn(schema);
				colvarUpProfession.ColumnName = "UpProfession";
				colvarUpProfession.DataType = DbType.String;
				colvarUpProfession.MaxLength = 10;
				colvarUpProfession.AutoIncrement = false;
				colvarUpProfession.IsNullable = true;
				colvarUpProfession.IsPrimaryKey = false;
				colvarUpProfession.IsForeignKey = false;
				colvarUpProfession.IsReadOnly = false;
				colvarUpProfession.DefaultSetting = @"";
				colvarUpProfession.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpProfession);
				
				TableSchema.TableColumn colvarUpAttitude = new TableSchema.TableColumn(schema);
				colvarUpAttitude.ColumnName = "UpAttitude";
				colvarUpAttitude.DataType = DbType.String;
				colvarUpAttitude.MaxLength = 10;
				colvarUpAttitude.AutoIncrement = false;
				colvarUpAttitude.IsNullable = true;
				colvarUpAttitude.IsPrimaryKey = false;
				colvarUpAttitude.IsForeignKey = false;
				colvarUpAttitude.IsReadOnly = false;
				colvarUpAttitude.DefaultSetting = @"";
				colvarUpAttitude.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpAttitude);
				
				TableSchema.TableColumn colvarUpComplex = new TableSchema.TableColumn(schema);
				colvarUpComplex.ColumnName = "UpComplex";
				colvarUpComplex.DataType = DbType.String;
				colvarUpComplex.MaxLength = 10;
				colvarUpComplex.AutoIncrement = false;
				colvarUpComplex.IsNullable = true;
				colvarUpComplex.IsPrimaryKey = false;
				colvarUpComplex.IsForeignKey = false;
				colvarUpComplex.IsReadOnly = false;
				colvarUpComplex.DefaultSetting = @"";
				colvarUpComplex.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpComplex);
				
				TableSchema.TableColumn colvarUpSpeciality = new TableSchema.TableColumn(schema);
				colvarUpSpeciality.ColumnName = "UpSpeciality";
				colvarUpSpeciality.DataType = DbType.String;
				colvarUpSpeciality.MaxLength = 10;
				colvarUpSpeciality.AutoIncrement = false;
				colvarUpSpeciality.IsNullable = true;
				colvarUpSpeciality.IsPrimaryKey = false;
				colvarUpSpeciality.IsForeignKey = false;
				colvarUpSpeciality.IsReadOnly = false;
				colvarUpSpeciality.DefaultSetting = @"";
				colvarUpSpeciality.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUpSpeciality);
				
				TableSchema.TableColumn colvarSectPlan = new TableSchema.TableColumn(schema);
				colvarSectPlan.ColumnName = "SectPlan";
				colvarSectPlan.DataType = DbType.String;
				colvarSectPlan.MaxLength = 10;
				colvarSectPlan.AutoIncrement = false;
				colvarSectPlan.IsNullable = true;
				colvarSectPlan.IsPrimaryKey = false;
				colvarSectPlan.IsForeignKey = false;
				colvarSectPlan.IsReadOnly = false;
				colvarSectPlan.DefaultSetting = @"";
				colvarSectPlan.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSectPlan);
				
				TableSchema.TableColumn colvarSectWorkTotal = new TableSchema.TableColumn(schema);
				colvarSectWorkTotal.ColumnName = "SectWorkTotal";
				colvarSectWorkTotal.DataType = DbType.String;
				colvarSectWorkTotal.MaxLength = 10;
				colvarSectWorkTotal.AutoIncrement = false;
				colvarSectWorkTotal.IsNullable = true;
				colvarSectWorkTotal.IsPrimaryKey = false;
				colvarSectWorkTotal.IsForeignKey = false;
				colvarSectWorkTotal.IsReadOnly = false;
				colvarSectWorkTotal.DefaultSetting = @"";
				colvarSectWorkTotal.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSectWorkTotal);
				
				TableSchema.TableColumn colvarSectWorkSpeed = new TableSchema.TableColumn(schema);
				colvarSectWorkSpeed.ColumnName = "SectWorkSpeed";
				colvarSectWorkSpeed.DataType = DbType.String;
				colvarSectWorkSpeed.MaxLength = 10;
				colvarSectWorkSpeed.AutoIncrement = false;
				colvarSectWorkSpeed.IsNullable = true;
				colvarSectWorkSpeed.IsPrimaryKey = false;
				colvarSectWorkSpeed.IsForeignKey = false;
				colvarSectWorkSpeed.IsReadOnly = false;
				colvarSectWorkSpeed.DefaultSetting = @"";
				colvarSectWorkSpeed.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSectWorkSpeed);
				
				TableSchema.TableColumn colvarSectCommunicate = new TableSchema.TableColumn(schema);
				colvarSectCommunicate.ColumnName = "SectCommunicate";
				colvarSectCommunicate.DataType = DbType.String;
				colvarSectCommunicate.MaxLength = 10;
				colvarSectCommunicate.AutoIncrement = false;
				colvarSectCommunicate.IsNullable = true;
				colvarSectCommunicate.IsPrimaryKey = false;
				colvarSectCommunicate.IsForeignKey = false;
				colvarSectCommunicate.IsReadOnly = false;
				colvarSectCommunicate.DefaultSetting = @"";
				colvarSectCommunicate.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSectCommunicate);
				
				TableSchema.TableColumn colvarSectDescipline = new TableSchema.TableColumn(schema);
				colvarSectDescipline.ColumnName = "SectDescipline";
				colvarSectDescipline.DataType = DbType.String;
				colvarSectDescipline.MaxLength = 10;
				colvarSectDescipline.AutoIncrement = false;
				colvarSectDescipline.IsNullable = true;
				colvarSectDescipline.IsPrimaryKey = false;
				colvarSectDescipline.IsForeignKey = false;
				colvarSectDescipline.IsReadOnly = false;
				colvarSectDescipline.DefaultSetting = @"";
				colvarSectDescipline.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSectDescipline);
				
				TableSchema.TableColumn colvarSectExecute = new TableSchema.TableColumn(schema);
				colvarSectExecute.ColumnName = "SectExecute";
				colvarSectExecute.DataType = DbType.String;
				colvarSectExecute.MaxLength = 10;
				colvarSectExecute.AutoIncrement = false;
				colvarSectExecute.IsNullable = true;
				colvarSectExecute.IsPrimaryKey = false;
				colvarSectExecute.IsForeignKey = false;
				colvarSectExecute.IsReadOnly = false;
				colvarSectExecute.DefaultSetting = @"";
				colvarSectExecute.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSectExecute);
				
				TableSchema.TableColumn colvarSectRoute = new TableSchema.TableColumn(schema);
				colvarSectRoute.ColumnName = "SectRoute";
				colvarSectRoute.DataType = DbType.String;
				colvarSectRoute.MaxLength = 10;
				colvarSectRoute.AutoIncrement = false;
				colvarSectRoute.IsNullable = true;
				colvarSectRoute.IsPrimaryKey = false;
				colvarSectRoute.IsForeignKey = false;
				colvarSectRoute.IsReadOnly = false;
				colvarSectRoute.DefaultSetting = @"";
				colvarSectRoute.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSectRoute);
				
				TableSchema.TableColumn colvarSectProfession = new TableSchema.TableColumn(schema);
				colvarSectProfession.ColumnName = "SectProfession";
				colvarSectProfession.DataType = DbType.String;
				colvarSectProfession.MaxLength = 10;
				colvarSectProfession.AutoIncrement = false;
				colvarSectProfession.IsNullable = true;
				colvarSectProfession.IsPrimaryKey = false;
				colvarSectProfession.IsForeignKey = false;
				colvarSectProfession.IsReadOnly = false;
				colvarSectProfession.DefaultSetting = @"";
				colvarSectProfession.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSectProfession);
				
				TableSchema.TableColumn colvarSectAttitude = new TableSchema.TableColumn(schema);
				colvarSectAttitude.ColumnName = "SectAttitude";
				colvarSectAttitude.DataType = DbType.String;
				colvarSectAttitude.MaxLength = 10;
				colvarSectAttitude.AutoIncrement = false;
				colvarSectAttitude.IsNullable = true;
				colvarSectAttitude.IsPrimaryKey = false;
				colvarSectAttitude.IsForeignKey = false;
				colvarSectAttitude.IsReadOnly = false;
				colvarSectAttitude.DefaultSetting = @"";
				colvarSectAttitude.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSectAttitude);
				
				TableSchema.TableColumn colvarSectComplex = new TableSchema.TableColumn(schema);
				colvarSectComplex.ColumnName = "SectComplex";
				colvarSectComplex.DataType = DbType.String;
				colvarSectComplex.MaxLength = 10;
				colvarSectComplex.AutoIncrement = false;
				colvarSectComplex.IsNullable = true;
				colvarSectComplex.IsPrimaryKey = false;
				colvarSectComplex.IsForeignKey = false;
				colvarSectComplex.IsReadOnly = false;
				colvarSectComplex.DefaultSetting = @"";
				colvarSectComplex.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSectComplex);
				
				TableSchema.TableColumn colvarSectSpeciality = new TableSchema.TableColumn(schema);
				colvarSectSpeciality.ColumnName = "SectSpeciality";
				colvarSectSpeciality.DataType = DbType.String;
				colvarSectSpeciality.MaxLength = 10;
				colvarSectSpeciality.AutoIncrement = false;
				colvarSectSpeciality.IsNullable = true;
				colvarSectSpeciality.IsPrimaryKey = false;
				colvarSectSpeciality.IsForeignKey = false;
				colvarSectSpeciality.IsReadOnly = false;
				colvarSectSpeciality.DefaultSetting = @"";
				colvarSectSpeciality.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSectSpeciality);
				
				TableSchema.TableColumn colvarPlanFinish = new TableSchema.TableColumn(schema);
				colvarPlanFinish.ColumnName = "PlanFinish";
				colvarPlanFinish.DataType = DbType.String;
				colvarPlanFinish.MaxLength = 50;
				colvarPlanFinish.AutoIncrement = false;
				colvarPlanFinish.IsNullable = true;
				colvarPlanFinish.IsPrimaryKey = false;
				colvarPlanFinish.IsForeignKey = false;
				colvarPlanFinish.IsReadOnly = false;
				colvarPlanFinish.DefaultSetting = @"";
				colvarPlanFinish.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPlanFinish);
				
				TableSchema.TableColumn colvarActualFinish = new TableSchema.TableColumn(schema);
				colvarActualFinish.ColumnName = "ActualFinish";
				colvarActualFinish.DataType = DbType.String;
				colvarActualFinish.MaxLength = 50;
				colvarActualFinish.AutoIncrement = false;
				colvarActualFinish.IsNullable = true;
				colvarActualFinish.IsPrimaryKey = false;
				colvarActualFinish.IsForeignKey = false;
				colvarActualFinish.IsReadOnly = false;
				colvarActualFinish.DefaultSetting = @"";
				colvarActualFinish.ForeignKeyTableName = "";
				schema.Columns.Add(colvarActualFinish);
				
				TableSchema.TableColumn colvarFinishRate = new TableSchema.TableColumn(schema);
				colvarFinishRate.ColumnName = "FinishRate";
				colvarFinishRate.DataType = DbType.String;
				colvarFinishRate.MaxLength = 10;
				colvarFinishRate.AutoIncrement = false;
				colvarFinishRate.IsNullable = true;
				colvarFinishRate.IsPrimaryKey = false;
				colvarFinishRate.IsForeignKey = false;
				colvarFinishRate.IsReadOnly = false;
				colvarFinishRate.DefaultSetting = @"";
				colvarFinishRate.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFinishRate);
				
				TableSchema.TableColumn colvarFinishScore = new TableSchema.TableColumn(schema);
				colvarFinishScore.ColumnName = "FinishScore";
				colvarFinishScore.DataType = DbType.String;
				colvarFinishScore.MaxLength = 10;
				colvarFinishScore.AutoIncrement = false;
				colvarFinishScore.IsNullable = true;
				colvarFinishScore.IsPrimaryKey = false;
				colvarFinishScore.IsForeignKey = false;
				colvarFinishScore.IsReadOnly = false;
				colvarFinishScore.DefaultSetting = @"";
				colvarFinishScore.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFinishScore);
				
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
				
				TableSchema.TableColumn colvarAddMinusSocre = new TableSchema.TableColumn(schema);
				colvarAddMinusSocre.ColumnName = "AddMinusSocre";
				colvarAddMinusSocre.DataType = DbType.String;
				colvarAddMinusSocre.MaxLength = 10;
				colvarAddMinusSocre.AutoIncrement = false;
				colvarAddMinusSocre.IsNullable = true;
				colvarAddMinusSocre.IsPrimaryKey = false;
				colvarAddMinusSocre.IsForeignKey = false;
				colvarAddMinusSocre.IsReadOnly = false;
				colvarAddMinusSocre.DefaultSetting = @"";
				colvarAddMinusSocre.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAddMinusSocre);
				
				TableSchema.TableColumn colvarTotalScore = new TableSchema.TableColumn(schema);
				colvarTotalScore.ColumnName = "TotalScore";
				colvarTotalScore.DataType = DbType.String;
				colvarTotalScore.MaxLength = -1;
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
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("TechEmScore_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("TechEmScoreId")]
		[Bindable(true)]
		public int TechEmScoreId 
		{
			get { return GetColumnValue<int>(Columns.TechEmScoreId); }
			set { SetColumnValue(Columns.TechEmScoreId, value); }
		}
		  
		[XmlAttribute("SelfPlan")]
		[Bindable(true)]
		public string SelfPlan 
		{
			get { return GetColumnValue<string>(Columns.SelfPlan); }
			set { SetColumnValue(Columns.SelfPlan, value); }
		}
		  
		[XmlAttribute("SelfWorkTotal")]
		[Bindable(true)]
		public string SelfWorkTotal 
		{
			get { return GetColumnValue<string>(Columns.SelfWorkTotal); }
			set { SetColumnValue(Columns.SelfWorkTotal, value); }
		}
		  
		[XmlAttribute("SelfWorkSpeed")]
		[Bindable(true)]
		public string SelfWorkSpeed 
		{
			get { return GetColumnValue<string>(Columns.SelfWorkSpeed); }
			set { SetColumnValue(Columns.SelfWorkSpeed, value); }
		}
		  
		[XmlAttribute("SelfCommunicate")]
		[Bindable(true)]
		public string SelfCommunicate 
		{
			get { return GetColumnValue<string>(Columns.SelfCommunicate); }
			set { SetColumnValue(Columns.SelfCommunicate, value); }
		}
		  
		[XmlAttribute("SelfDescipline")]
		[Bindable(true)]
		public string SelfDescipline 
		{
			get { return GetColumnValue<string>(Columns.SelfDescipline); }
			set { SetColumnValue(Columns.SelfDescipline, value); }
		}
		  
		[XmlAttribute("SelfExecute")]
		[Bindable(true)]
		public string SelfExecute 
		{
			get { return GetColumnValue<string>(Columns.SelfExecute); }
			set { SetColumnValue(Columns.SelfExecute, value); }
		}
		  
		[XmlAttribute("SelfRoute")]
		[Bindable(true)]
		public string SelfRoute 
		{
			get { return GetColumnValue<string>(Columns.SelfRoute); }
			set { SetColumnValue(Columns.SelfRoute, value); }
		}
		  
		[XmlAttribute("SelfProfession")]
		[Bindable(true)]
		public string SelfProfession 
		{
			get { return GetColumnValue<string>(Columns.SelfProfession); }
			set { SetColumnValue(Columns.SelfProfession, value); }
		}
		  
		[XmlAttribute("SelfAttitude")]
		[Bindable(true)]
		public string SelfAttitude 
		{
			get { return GetColumnValue<string>(Columns.SelfAttitude); }
			set { SetColumnValue(Columns.SelfAttitude, value); }
		}
		  
		[XmlAttribute("SelfComplex")]
		[Bindable(true)]
		public string SelfComplex 
		{
			get { return GetColumnValue<string>(Columns.SelfComplex); }
			set { SetColumnValue(Columns.SelfComplex, value); }
		}
		  
		[XmlAttribute("SelfSpeciality")]
		[Bindable(true)]
		public string SelfSpeciality 
		{
			get { return GetColumnValue<string>(Columns.SelfSpeciality); }
			set { SetColumnValue(Columns.SelfSpeciality, value); }
		}
		  
		[XmlAttribute("UpPlan")]
		[Bindable(true)]
		public string UpPlan 
		{
			get { return GetColumnValue<string>(Columns.UpPlan); }
			set { SetColumnValue(Columns.UpPlan, value); }
		}
		  
		[XmlAttribute("UpWorkTotal")]
		[Bindable(true)]
		public string UpWorkTotal 
		{
			get { return GetColumnValue<string>(Columns.UpWorkTotal); }
			set { SetColumnValue(Columns.UpWorkTotal, value); }
		}
		  
		[XmlAttribute("UpWorkSpeed")]
		[Bindable(true)]
		public string UpWorkSpeed 
		{
			get { return GetColumnValue<string>(Columns.UpWorkSpeed); }
			set { SetColumnValue(Columns.UpWorkSpeed, value); }
		}
		  
		[XmlAttribute("UpCommunicate")]
		[Bindable(true)]
		public string UpCommunicate 
		{
			get { return GetColumnValue<string>(Columns.UpCommunicate); }
			set { SetColumnValue(Columns.UpCommunicate, value); }
		}
		  
		[XmlAttribute("UpDescipline")]
		[Bindable(true)]
		public string UpDescipline 
		{
			get { return GetColumnValue<string>(Columns.UpDescipline); }
			set { SetColumnValue(Columns.UpDescipline, value); }
		}
		  
		[XmlAttribute("UpExecute")]
		[Bindable(true)]
		public string UpExecute 
		{
			get { return GetColumnValue<string>(Columns.UpExecute); }
			set { SetColumnValue(Columns.UpExecute, value); }
		}
		  
		[XmlAttribute("UpRoute")]
		[Bindable(true)]
		public string UpRoute 
		{
			get { return GetColumnValue<string>(Columns.UpRoute); }
			set { SetColumnValue(Columns.UpRoute, value); }
		}
		  
		[XmlAttribute("UpProfession")]
		[Bindable(true)]
		public string UpProfession 
		{
			get { return GetColumnValue<string>(Columns.UpProfession); }
			set { SetColumnValue(Columns.UpProfession, value); }
		}
		  
		[XmlAttribute("UpAttitude")]
		[Bindable(true)]
		public string UpAttitude 
		{
			get { return GetColumnValue<string>(Columns.UpAttitude); }
			set { SetColumnValue(Columns.UpAttitude, value); }
		}
		  
		[XmlAttribute("UpComplex")]
		[Bindable(true)]
		public string UpComplex 
		{
			get { return GetColumnValue<string>(Columns.UpComplex); }
			set { SetColumnValue(Columns.UpComplex, value); }
		}
		  
		[XmlAttribute("UpSpeciality")]
		[Bindable(true)]
		public string UpSpeciality 
		{
			get { return GetColumnValue<string>(Columns.UpSpeciality); }
			set { SetColumnValue(Columns.UpSpeciality, value); }
		}
		  
		[XmlAttribute("SectPlan")]
		[Bindable(true)]
		public string SectPlan 
		{
			get { return GetColumnValue<string>(Columns.SectPlan); }
			set { SetColumnValue(Columns.SectPlan, value); }
		}
		  
		[XmlAttribute("SectWorkTotal")]
		[Bindable(true)]
		public string SectWorkTotal 
		{
			get { return GetColumnValue<string>(Columns.SectWorkTotal); }
			set { SetColumnValue(Columns.SectWorkTotal, value); }
		}
		  
		[XmlAttribute("SectWorkSpeed")]
		[Bindable(true)]
		public string SectWorkSpeed 
		{
			get { return GetColumnValue<string>(Columns.SectWorkSpeed); }
			set { SetColumnValue(Columns.SectWorkSpeed, value); }
		}
		  
		[XmlAttribute("SectCommunicate")]
		[Bindable(true)]
		public string SectCommunicate 
		{
			get { return GetColumnValue<string>(Columns.SectCommunicate); }
			set { SetColumnValue(Columns.SectCommunicate, value); }
		}
		  
		[XmlAttribute("SectDescipline")]
		[Bindable(true)]
		public string SectDescipline 
		{
			get { return GetColumnValue<string>(Columns.SectDescipline); }
			set { SetColumnValue(Columns.SectDescipline, value); }
		}
		  
		[XmlAttribute("SectExecute")]
		[Bindable(true)]
		public string SectExecute 
		{
			get { return GetColumnValue<string>(Columns.SectExecute); }
			set { SetColumnValue(Columns.SectExecute, value); }
		}
		  
		[XmlAttribute("SectRoute")]
		[Bindable(true)]
		public string SectRoute 
		{
			get { return GetColumnValue<string>(Columns.SectRoute); }
			set { SetColumnValue(Columns.SectRoute, value); }
		}
		  
		[XmlAttribute("SectProfession")]
		[Bindable(true)]
		public string SectProfession 
		{
			get { return GetColumnValue<string>(Columns.SectProfession); }
			set { SetColumnValue(Columns.SectProfession, value); }
		}
		  
		[XmlAttribute("SectAttitude")]
		[Bindable(true)]
		public string SectAttitude 
		{
			get { return GetColumnValue<string>(Columns.SectAttitude); }
			set { SetColumnValue(Columns.SectAttitude, value); }
		}
		  
		[XmlAttribute("SectComplex")]
		[Bindable(true)]
		public string SectComplex 
		{
			get { return GetColumnValue<string>(Columns.SectComplex); }
			set { SetColumnValue(Columns.SectComplex, value); }
		}
		  
		[XmlAttribute("SectSpeciality")]
		[Bindable(true)]
		public string SectSpeciality 
		{
			get { return GetColumnValue<string>(Columns.SectSpeciality); }
			set { SetColumnValue(Columns.SectSpeciality, value); }
		}
		  
		[XmlAttribute("PlanFinish")]
		[Bindable(true)]
		public string PlanFinish 
		{
			get { return GetColumnValue<string>(Columns.PlanFinish); }
			set { SetColumnValue(Columns.PlanFinish, value); }
		}
		  
		[XmlAttribute("ActualFinish")]
		[Bindable(true)]
		public string ActualFinish 
		{
			get { return GetColumnValue<string>(Columns.ActualFinish); }
			set { SetColumnValue(Columns.ActualFinish, value); }
		}
		  
		[XmlAttribute("FinishRate")]
		[Bindable(true)]
		public string FinishRate 
		{
			get { return GetColumnValue<string>(Columns.FinishRate); }
			set { SetColumnValue(Columns.FinishRate, value); }
		}
		  
		[XmlAttribute("FinishScore")]
		[Bindable(true)]
		public string FinishScore 
		{
			get { return GetColumnValue<string>(Columns.FinishScore); }
			set { SetColumnValue(Columns.FinishScore, value); }
		}
		  
		[XmlAttribute("Reason")]
		[Bindable(true)]
		public string Reason 
		{
			get { return GetColumnValue<string>(Columns.Reason); }
			set { SetColumnValue(Columns.Reason, value); }
		}
		  
		[XmlAttribute("AddMinusSocre")]
		[Bindable(true)]
		public string AddMinusSocre 
		{
			get { return GetColumnValue<string>(Columns.AddMinusSocre); }
			set { SetColumnValue(Columns.AddMinusSocre, value); }
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
		  
		[XmlAttribute("DateSpan")]
		[Bindable(true)]
		public string DateSpan 
		{
			get { return GetColumnValue<string>(Columns.DateSpan); }
			set { SetColumnValue(Columns.DateSpan, value); }
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
		  
		[XmlAttribute("EvaluateLevelId")]
		[Bindable(true)]
		public int? EvaluateLevelId 
		{
			get { return GetColumnValue<int?>(Columns.EvaluateLevelId); }
			set { SetColumnValue(Columns.EvaluateLevelId, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varSelfPlan,string varSelfWorkTotal,string varSelfWorkSpeed,string varSelfCommunicate,string varSelfDescipline,string varSelfExecute,string varSelfRoute,string varSelfProfession,string varSelfAttitude,string varSelfComplex,string varSelfSpeciality,string varUpPlan,string varUpWorkTotal,string varUpWorkSpeed,string varUpCommunicate,string varUpDescipline,string varUpExecute,string varUpRoute,string varUpProfession,string varUpAttitude,string varUpComplex,string varUpSpeciality,string varSectPlan,string varSectWorkTotal,string varSectWorkSpeed,string varSectCommunicate,string varSectDescipline,string varSectExecute,string varSectRoute,string varSectProfession,string varSectAttitude,string varSectComplex,string varSectSpeciality,string varPlanFinish,string varActualFinish,string varFinishRate,string varFinishScore,string varReason,string varAddMinusSocre,string varTotalScore,string varUpViews,int? varEmployeeId,int? varIsSubmit,string varDateSpan,int? varYearId,int? varMonthId,int? varEvaluateLevelId)
		{
			TechEmScore item = new TechEmScore();
			
			item.SelfPlan = varSelfPlan;
			
			item.SelfWorkTotal = varSelfWorkTotal;
			
			item.SelfWorkSpeed = varSelfWorkSpeed;
			
			item.SelfCommunicate = varSelfCommunicate;
			
			item.SelfDescipline = varSelfDescipline;
			
			item.SelfExecute = varSelfExecute;
			
			item.SelfRoute = varSelfRoute;
			
			item.SelfProfession = varSelfProfession;
			
			item.SelfAttitude = varSelfAttitude;
			
			item.SelfComplex = varSelfComplex;
			
			item.SelfSpeciality = varSelfSpeciality;
			
			item.UpPlan = varUpPlan;
			
			item.UpWorkTotal = varUpWorkTotal;
			
			item.UpWorkSpeed = varUpWorkSpeed;
			
			item.UpCommunicate = varUpCommunicate;
			
			item.UpDescipline = varUpDescipline;
			
			item.UpExecute = varUpExecute;
			
			item.UpRoute = varUpRoute;
			
			item.UpProfession = varUpProfession;
			
			item.UpAttitude = varUpAttitude;
			
			item.UpComplex = varUpComplex;
			
			item.UpSpeciality = varUpSpeciality;
			
			item.SectPlan = varSectPlan;
			
			item.SectWorkTotal = varSectWorkTotal;
			
			item.SectWorkSpeed = varSectWorkSpeed;
			
			item.SectCommunicate = varSectCommunicate;
			
			item.SectDescipline = varSectDescipline;
			
			item.SectExecute = varSectExecute;
			
			item.SectRoute = varSectRoute;
			
			item.SectProfession = varSectProfession;
			
			item.SectAttitude = varSectAttitude;
			
			item.SectComplex = varSectComplex;
			
			item.SectSpeciality = varSectSpeciality;
			
			item.PlanFinish = varPlanFinish;
			
			item.ActualFinish = varActualFinish;
			
			item.FinishRate = varFinishRate;
			
			item.FinishScore = varFinishScore;
			
			item.Reason = varReason;
			
			item.AddMinusSocre = varAddMinusSocre;
			
			item.TotalScore = varTotalScore;
			
			item.UpViews = varUpViews;
			
			item.EmployeeId = varEmployeeId;
			
			item.IsSubmit = varIsSubmit;
			
			item.DateSpan = varDateSpan;
			
			item.YearId = varYearId;
			
			item.MonthId = varMonthId;
			
			item.EvaluateLevelId = varEvaluateLevelId;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varTechEmScoreId,string varSelfPlan,string varSelfWorkTotal,string varSelfWorkSpeed,string varSelfCommunicate,string varSelfDescipline,string varSelfExecute,string varSelfRoute,string varSelfProfession,string varSelfAttitude,string varSelfComplex,string varSelfSpeciality,string varUpPlan,string varUpWorkTotal,string varUpWorkSpeed,string varUpCommunicate,string varUpDescipline,string varUpExecute,string varUpRoute,string varUpProfession,string varUpAttitude,string varUpComplex,string varUpSpeciality,string varSectPlan,string varSectWorkTotal,string varSectWorkSpeed,string varSectCommunicate,string varSectDescipline,string varSectExecute,string varSectRoute,string varSectProfession,string varSectAttitude,string varSectComplex,string varSectSpeciality,string varPlanFinish,string varActualFinish,string varFinishRate,string varFinishScore,string varReason,string varAddMinusSocre,string varTotalScore,string varUpViews,int? varEmployeeId,int? varIsSubmit,string varDateSpan,int? varYearId,int? varMonthId,int? varEvaluateLevelId)
		{
			TechEmScore item = new TechEmScore();
			
				item.TechEmScoreId = varTechEmScoreId;
			
				item.SelfPlan = varSelfPlan;
			
				item.SelfWorkTotal = varSelfWorkTotal;
			
				item.SelfWorkSpeed = varSelfWorkSpeed;
			
				item.SelfCommunicate = varSelfCommunicate;
			
				item.SelfDescipline = varSelfDescipline;
			
				item.SelfExecute = varSelfExecute;
			
				item.SelfRoute = varSelfRoute;
			
				item.SelfProfession = varSelfProfession;
			
				item.SelfAttitude = varSelfAttitude;
			
				item.SelfComplex = varSelfComplex;
			
				item.SelfSpeciality = varSelfSpeciality;
			
				item.UpPlan = varUpPlan;
			
				item.UpWorkTotal = varUpWorkTotal;
			
				item.UpWorkSpeed = varUpWorkSpeed;
			
				item.UpCommunicate = varUpCommunicate;
			
				item.UpDescipline = varUpDescipline;
			
				item.UpExecute = varUpExecute;
			
				item.UpRoute = varUpRoute;
			
				item.UpProfession = varUpProfession;
			
				item.UpAttitude = varUpAttitude;
			
				item.UpComplex = varUpComplex;
			
				item.UpSpeciality = varUpSpeciality;
			
				item.SectPlan = varSectPlan;
			
				item.SectWorkTotal = varSectWorkTotal;
			
				item.SectWorkSpeed = varSectWorkSpeed;
			
				item.SectCommunicate = varSectCommunicate;
			
				item.SectDescipline = varSectDescipline;
			
				item.SectExecute = varSectExecute;
			
				item.SectRoute = varSectRoute;
			
				item.SectProfession = varSectProfession;
			
				item.SectAttitude = varSectAttitude;
			
				item.SectComplex = varSectComplex;
			
				item.SectSpeciality = varSectSpeciality;
			
				item.PlanFinish = varPlanFinish;
			
				item.ActualFinish = varActualFinish;
			
				item.FinishRate = varFinishRate;
			
				item.FinishScore = varFinishScore;
			
				item.Reason = varReason;
			
				item.AddMinusSocre = varAddMinusSocre;
			
				item.TotalScore = varTotalScore;
			
				item.UpViews = varUpViews;
			
				item.EmployeeId = varEmployeeId;
			
				item.IsSubmit = varIsSubmit;
			
				item.DateSpan = varDateSpan;
			
				item.YearId = varYearId;
			
				item.MonthId = varMonthId;
			
				item.EvaluateLevelId = varEvaluateLevelId;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn TechEmScoreIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn SelfPlanColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn SelfWorkTotalColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn SelfWorkSpeedColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn SelfCommunicateColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn SelfDesciplineColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn SelfExecuteColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn SelfRouteColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn SelfProfessionColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn SelfAttitudeColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn SelfComplexColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn SelfSpecialityColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn UpPlanColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn UpWorkTotalColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn UpWorkSpeedColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn UpCommunicateColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn UpDesciplineColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn UpExecuteColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn UpRouteColumn
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn UpProfessionColumn
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        public static TableSchema.TableColumn UpAttitudeColumn
        {
            get { return Schema.Columns[20]; }
        }
        
        
        
        public static TableSchema.TableColumn UpComplexColumn
        {
            get { return Schema.Columns[21]; }
        }
        
        
        
        public static TableSchema.TableColumn UpSpecialityColumn
        {
            get { return Schema.Columns[22]; }
        }
        
        
        
        public static TableSchema.TableColumn SectPlanColumn
        {
            get { return Schema.Columns[23]; }
        }
        
        
        
        public static TableSchema.TableColumn SectWorkTotalColumn
        {
            get { return Schema.Columns[24]; }
        }
        
        
        
        public static TableSchema.TableColumn SectWorkSpeedColumn
        {
            get { return Schema.Columns[25]; }
        }
        
        
        
        public static TableSchema.TableColumn SectCommunicateColumn
        {
            get { return Schema.Columns[26]; }
        }
        
        
        
        public static TableSchema.TableColumn SectDesciplineColumn
        {
            get { return Schema.Columns[27]; }
        }
        
        
        
        public static TableSchema.TableColumn SectExecuteColumn
        {
            get { return Schema.Columns[28]; }
        }
        
        
        
        public static TableSchema.TableColumn SectRouteColumn
        {
            get { return Schema.Columns[29]; }
        }
        
        
        
        public static TableSchema.TableColumn SectProfessionColumn
        {
            get { return Schema.Columns[30]; }
        }
        
        
        
        public static TableSchema.TableColumn SectAttitudeColumn
        {
            get { return Schema.Columns[31]; }
        }
        
        
        
        public static TableSchema.TableColumn SectComplexColumn
        {
            get { return Schema.Columns[32]; }
        }
        
        
        
        public static TableSchema.TableColumn SectSpecialityColumn
        {
            get { return Schema.Columns[33]; }
        }
        
        
        
        public static TableSchema.TableColumn PlanFinishColumn
        {
            get { return Schema.Columns[34]; }
        }
        
        
        
        public static TableSchema.TableColumn ActualFinishColumn
        {
            get { return Schema.Columns[35]; }
        }
        
        
        
        public static TableSchema.TableColumn FinishRateColumn
        {
            get { return Schema.Columns[36]; }
        }
        
        
        
        public static TableSchema.TableColumn FinishScoreColumn
        {
            get { return Schema.Columns[37]; }
        }
        
        
        
        public static TableSchema.TableColumn ReasonColumn
        {
            get { return Schema.Columns[38]; }
        }
        
        
        
        public static TableSchema.TableColumn AddMinusSocreColumn
        {
            get { return Schema.Columns[39]; }
        }
        
        
        
        public static TableSchema.TableColumn TotalScoreColumn
        {
            get { return Schema.Columns[40]; }
        }
        
        
        
        public static TableSchema.TableColumn UpViewsColumn
        {
            get { return Schema.Columns[41]; }
        }
        
        
        
        public static TableSchema.TableColumn EmployeeIdColumn
        {
            get { return Schema.Columns[42]; }
        }
        
        
        
        public static TableSchema.TableColumn IsSubmitColumn
        {
            get { return Schema.Columns[43]; }
        }
        
        
        
        public static TableSchema.TableColumn DateSpanColumn
        {
            get { return Schema.Columns[44]; }
        }
        
        
        
        public static TableSchema.TableColumn YearIdColumn
        {
            get { return Schema.Columns[45]; }
        }
        
        
        
        public static TableSchema.TableColumn MonthIdColumn
        {
            get { return Schema.Columns[46]; }
        }
        
        
        
        public static TableSchema.TableColumn EvaluateLevelIdColumn
        {
            get { return Schema.Columns[47]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string TechEmScoreId = @"TechEmScoreId";
			 public static string SelfPlan = @"SelfPlan";
			 public static string SelfWorkTotal = @"SelfWorkTotal";
			 public static string SelfWorkSpeed = @"SelfWorkSpeed";
			 public static string SelfCommunicate = @"SelfCommunicate";
			 public static string SelfDescipline = @"SelfDescipline";
			 public static string SelfExecute = @"SelfExecute";
			 public static string SelfRoute = @"SelfRoute";
			 public static string SelfProfession = @"SelfProfession";
			 public static string SelfAttitude = @"SelfAttitude";
			 public static string SelfComplex = @"SelfComplex";
			 public static string SelfSpeciality = @"SelfSpeciality";
			 public static string UpPlan = @"UpPlan";
			 public static string UpWorkTotal = @"UpWorkTotal";
			 public static string UpWorkSpeed = @"UpWorkSpeed";
			 public static string UpCommunicate = @"UpCommunicate";
			 public static string UpDescipline = @"UpDescipline";
			 public static string UpExecute = @"UpExecute";
			 public static string UpRoute = @"UpRoute";
			 public static string UpProfession = @"UpProfession";
			 public static string UpAttitude = @"UpAttitude";
			 public static string UpComplex = @"UpComplex";
			 public static string UpSpeciality = @"UpSpeciality";
			 public static string SectPlan = @"SectPlan";
			 public static string SectWorkTotal = @"SectWorkTotal";
			 public static string SectWorkSpeed = @"SectWorkSpeed";
			 public static string SectCommunicate = @"SectCommunicate";
			 public static string SectDescipline = @"SectDescipline";
			 public static string SectExecute = @"SectExecute";
			 public static string SectRoute = @"SectRoute";
			 public static string SectProfession = @"SectProfession";
			 public static string SectAttitude = @"SectAttitude";
			 public static string SectComplex = @"SectComplex";
			 public static string SectSpeciality = @"SectSpeciality";
			 public static string PlanFinish = @"PlanFinish";
			 public static string ActualFinish = @"ActualFinish";
			 public static string FinishRate = @"FinishRate";
			 public static string FinishScore = @"FinishScore";
			 public static string Reason = @"Reason";
			 public static string AddMinusSocre = @"AddMinusSocre";
			 public static string TotalScore = @"TotalScore";
			 public static string UpViews = @"UpViews";
			 public static string EmployeeId = @"EmployeeId";
			 public static string IsSubmit = @"IsSubmit";
			 public static string DateSpan = @"DateSpan";
			 public static string YearId = @"YearId";
			 public static string MonthId = @"MonthId";
			 public static string EvaluateLevelId = @"EvaluateLevelId";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
