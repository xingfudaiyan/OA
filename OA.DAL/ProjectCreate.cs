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
	/// Strongly-typed collection for the ProjectCreate class.
	/// </summary>
    [Serializable]
	public partial class ProjectCreateCollection : ActiveList<ProjectCreate, ProjectCreateCollection>
	{	   
		public ProjectCreateCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>ProjectCreateCollection</returns>
		public ProjectCreateCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                ProjectCreate o = this[i];
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
	/// This is an ActiveRecord class which wraps the ProjectCreate_tb table.
	/// </summary>
	[Serializable]
	public partial class ProjectCreate : ActiveRecord<ProjectCreate>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public ProjectCreate()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public ProjectCreate(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public ProjectCreate(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public ProjectCreate(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("ProjectCreate_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarProjectCreateId = new TableSchema.TableColumn(schema);
				colvarProjectCreateId.ColumnName = "ProjectCreateId";
				colvarProjectCreateId.DataType = DbType.Int32;
				colvarProjectCreateId.MaxLength = 0;
				colvarProjectCreateId.AutoIncrement = true;
				colvarProjectCreateId.IsNullable = false;
				colvarProjectCreateId.IsPrimaryKey = true;
				colvarProjectCreateId.IsForeignKey = false;
				colvarProjectCreateId.IsReadOnly = false;
				colvarProjectCreateId.DefaultSetting = @"";
				colvarProjectCreateId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProjectCreateId);
				
				TableSchema.TableColumn colvarClientId = new TableSchema.TableColumn(schema);
				colvarClientId.ColumnName = "ClientId";
				colvarClientId.DataType = DbType.Int32;
				colvarClientId.MaxLength = 0;
				colvarClientId.AutoIncrement = false;
				colvarClientId.IsNullable = true;
				colvarClientId.IsPrimaryKey = false;
				colvarClientId.IsForeignKey = false;
				colvarClientId.IsReadOnly = false;
				colvarClientId.DefaultSetting = @"";
				colvarClientId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarClientId);
				
				TableSchema.TableColumn colvarProjectLevelId = new TableSchema.TableColumn(schema);
				colvarProjectLevelId.ColumnName = "ProjectLevelId";
				colvarProjectLevelId.DataType = DbType.Int32;
				colvarProjectLevelId.MaxLength = 0;
				colvarProjectLevelId.AutoIncrement = false;
				colvarProjectLevelId.IsNullable = true;
				colvarProjectLevelId.IsPrimaryKey = false;
				colvarProjectLevelId.IsForeignKey = false;
				colvarProjectLevelId.IsReadOnly = false;
				colvarProjectLevelId.DefaultSetting = @"";
				colvarProjectLevelId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProjectLevelId);
				
				TableSchema.TableColumn colvarProjectTypeId = new TableSchema.TableColumn(schema);
				colvarProjectTypeId.ColumnName = "ProjectTypeId";
				colvarProjectTypeId.DataType = DbType.Int32;
				colvarProjectTypeId.MaxLength = 0;
				colvarProjectTypeId.AutoIncrement = false;
				colvarProjectTypeId.IsNullable = true;
				colvarProjectTypeId.IsPrimaryKey = false;
				colvarProjectTypeId.IsForeignKey = false;
				colvarProjectTypeId.IsReadOnly = false;
				colvarProjectTypeId.DefaultSetting = @"";
				colvarProjectTypeId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProjectTypeId);
				
				TableSchema.TableColumn colvarYeWuId = new TableSchema.TableColumn(schema);
				colvarYeWuId.ColumnName = "YeWuId";
				colvarYeWuId.DataType = DbType.Int32;
				colvarYeWuId.MaxLength = 0;
				colvarYeWuId.AutoIncrement = false;
				colvarYeWuId.IsNullable = true;
				colvarYeWuId.IsPrimaryKey = false;
				colvarYeWuId.IsForeignKey = false;
				colvarYeWuId.IsReadOnly = false;
				colvarYeWuId.DefaultSetting = @"";
				colvarYeWuId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarYeWuId);
				
				TableSchema.TableColumn colvarProjectName = new TableSchema.TableColumn(schema);
				colvarProjectName.ColumnName = "ProjectName";
				colvarProjectName.DataType = DbType.String;
				colvarProjectName.MaxLength = 50;
				colvarProjectName.AutoIncrement = false;
				colvarProjectName.IsNullable = true;
				colvarProjectName.IsPrimaryKey = false;
				colvarProjectName.IsForeignKey = false;
				colvarProjectName.IsReadOnly = false;
				colvarProjectName.DefaultSetting = @"";
				colvarProjectName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProjectName);
				
				TableSchema.TableColumn colvarPreMoney = new TableSchema.TableColumn(schema);
				colvarPreMoney.ColumnName = "PreMoney";
				colvarPreMoney.DataType = DbType.String;
				colvarPreMoney.MaxLength = 50;
				colvarPreMoney.AutoIncrement = false;
				colvarPreMoney.IsNullable = true;
				colvarPreMoney.IsPrimaryKey = false;
				colvarPreMoney.IsForeignKey = false;
				colvarPreMoney.IsReadOnly = false;
				colvarPreMoney.DefaultSetting = @"";
				colvarPreMoney.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPreMoney);
				
				TableSchema.TableColumn colvarPreProfit = new TableSchema.TableColumn(schema);
				colvarPreProfit.ColumnName = "PreProfit";
				colvarPreProfit.DataType = DbType.String;
				colvarPreProfit.MaxLength = 50;
				colvarPreProfit.AutoIncrement = false;
				colvarPreProfit.IsNullable = true;
				colvarPreProfit.IsPrimaryKey = false;
				colvarPreProfit.IsForeignKey = false;
				colvarPreProfit.IsReadOnly = false;
				colvarPreProfit.DefaultSetting = @"";
				colvarPreProfit.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPreProfit);
				
				TableSchema.TableColumn colvarApplyDate = new TableSchema.TableColumn(schema);
				colvarApplyDate.ColumnName = "ApplyDate";
				colvarApplyDate.DataType = DbType.String;
				colvarApplyDate.MaxLength = 50;
				colvarApplyDate.AutoIncrement = false;
				colvarApplyDate.IsNullable = true;
				colvarApplyDate.IsPrimaryKey = false;
				colvarApplyDate.IsForeignKey = false;
				colvarApplyDate.IsReadOnly = false;
				colvarApplyDate.DefaultSetting = @"";
				colvarApplyDate.ForeignKeyTableName = "";
				schema.Columns.Add(colvarApplyDate);
				
				TableSchema.TableColumn colvarCreatePhaseExp = new TableSchema.TableColumn(schema);
				colvarCreatePhaseExp.ColumnName = "CreatePhaseExp";
				colvarCreatePhaseExp.DataType = DbType.String;
				colvarCreatePhaseExp.MaxLength = 50;
				colvarCreatePhaseExp.AutoIncrement = false;
				colvarCreatePhaseExp.IsNullable = true;
				colvarCreatePhaseExp.IsPrimaryKey = false;
				colvarCreatePhaseExp.IsForeignKey = false;
				colvarCreatePhaseExp.IsReadOnly = false;
				colvarCreatePhaseExp.DefaultSetting = @"";
				colvarCreatePhaseExp.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCreatePhaseExp);
				
				TableSchema.TableColumn colvarProposePhaseExp = new TableSchema.TableColumn(schema);
				colvarProposePhaseExp.ColumnName = "ProposePhaseExp";
				colvarProposePhaseExp.DataType = DbType.String;
				colvarProposePhaseExp.MaxLength = 50;
				colvarProposePhaseExp.AutoIncrement = false;
				colvarProposePhaseExp.IsNullable = true;
				colvarProposePhaseExp.IsPrimaryKey = false;
				colvarProposePhaseExp.IsForeignKey = false;
				colvarProposePhaseExp.IsReadOnly = false;
				colvarProposePhaseExp.DefaultSetting = @"";
				colvarProposePhaseExp.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProposePhaseExp);
				
				TableSchema.TableColumn colvarCallbidPhaseExp = new TableSchema.TableColumn(schema);
				colvarCallbidPhaseExp.ColumnName = "CallbidPhaseExp";
				colvarCallbidPhaseExp.DataType = DbType.String;
				colvarCallbidPhaseExp.MaxLength = 50;
				colvarCallbidPhaseExp.AutoIncrement = false;
				colvarCallbidPhaseExp.IsNullable = true;
				colvarCallbidPhaseExp.IsPrimaryKey = false;
				colvarCallbidPhaseExp.IsForeignKey = false;
				colvarCallbidPhaseExp.IsReadOnly = false;
				colvarCallbidPhaseExp.DefaultSetting = @"";
				colvarCallbidPhaseExp.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCallbidPhaseExp);
				
				TableSchema.TableColumn colvarTalkPhaseExp = new TableSchema.TableColumn(schema);
				colvarTalkPhaseExp.ColumnName = "TalkPhaseExp";
				colvarTalkPhaseExp.DataType = DbType.String;
				colvarTalkPhaseExp.MaxLength = 50;
				colvarTalkPhaseExp.AutoIncrement = false;
				colvarTalkPhaseExp.IsNullable = true;
				colvarTalkPhaseExp.IsPrimaryKey = false;
				colvarTalkPhaseExp.IsForeignKey = false;
				colvarTalkPhaseExp.IsReadOnly = false;
				colvarTalkPhaseExp.DefaultSetting = @"";
				colvarTalkPhaseExp.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTalkPhaseExp);
				
				TableSchema.TableColumn colvarCarryPhaseExp = new TableSchema.TableColumn(schema);
				colvarCarryPhaseExp.ColumnName = "CarryPhaseExp";
				colvarCarryPhaseExp.DataType = DbType.String;
				colvarCarryPhaseExp.MaxLength = 50;
				colvarCarryPhaseExp.AutoIncrement = false;
				colvarCarryPhaseExp.IsNullable = true;
				colvarCarryPhaseExp.IsPrimaryKey = false;
				colvarCarryPhaseExp.IsForeignKey = false;
				colvarCarryPhaseExp.IsReadOnly = false;
				colvarCarryPhaseExp.DefaultSetting = @"";
				colvarCarryPhaseExp.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCarryPhaseExp);
				
				TableSchema.TableColumn colvarNeedDescribe = new TableSchema.TableColumn(schema);
				colvarNeedDescribe.ColumnName = "NeedDescribe";
				colvarNeedDescribe.DataType = DbType.String;
				colvarNeedDescribe.MaxLength = -1;
				colvarNeedDescribe.AutoIncrement = false;
				colvarNeedDescribe.IsNullable = true;
				colvarNeedDescribe.IsPrimaryKey = false;
				colvarNeedDescribe.IsForeignKey = false;
				colvarNeedDescribe.IsReadOnly = false;
				colvarNeedDescribe.DefaultSetting = @"";
				colvarNeedDescribe.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNeedDescribe);
				
				TableSchema.TableColumn colvarCompitDescribe = new TableSchema.TableColumn(schema);
				colvarCompitDescribe.ColumnName = "CompitDescribe";
				colvarCompitDescribe.DataType = DbType.String;
				colvarCompitDescribe.MaxLength = -1;
				colvarCompitDescribe.AutoIncrement = false;
				colvarCompitDescribe.IsNullable = true;
				colvarCompitDescribe.IsPrimaryKey = false;
				colvarCompitDescribe.IsForeignKey = false;
				colvarCompitDescribe.IsReadOnly = false;
				colvarCompitDescribe.DefaultSetting = @"";
				colvarCompitDescribe.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCompitDescribe);
				
				TableSchema.TableColumn colvarClientDescribe = new TableSchema.TableColumn(schema);
				colvarClientDescribe.ColumnName = "ClientDescribe";
				colvarClientDescribe.DataType = DbType.String;
				colvarClientDescribe.MaxLength = -1;
				colvarClientDescribe.AutoIncrement = false;
				colvarClientDescribe.IsNullable = true;
				colvarClientDescribe.IsPrimaryKey = false;
				colvarClientDescribe.IsForeignKey = false;
				colvarClientDescribe.IsReadOnly = false;
				colvarClientDescribe.DefaultSetting = @"";
				colvarClientDescribe.ForeignKeyTableName = "";
				schema.Columns.Add(colvarClientDescribe);
				
				TableSchema.TableColumn colvarTechDescribe = new TableSchema.TableColumn(schema);
				colvarTechDescribe.ColumnName = "TechDescribe";
				colvarTechDescribe.DataType = DbType.String;
				colvarTechDescribe.MaxLength = -1;
				colvarTechDescribe.AutoIncrement = false;
				colvarTechDescribe.IsNullable = true;
				colvarTechDescribe.IsPrimaryKey = false;
				colvarTechDescribe.IsForeignKey = false;
				colvarTechDescribe.IsReadOnly = false;
				colvarTechDescribe.DefaultSetting = @"";
				colvarTechDescribe.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTechDescribe);
				
				TableSchema.TableColumn colvarBusinessDescribe = new TableSchema.TableColumn(schema);
				colvarBusinessDescribe.ColumnName = "BusinessDescribe";
				colvarBusinessDescribe.DataType = DbType.String;
				colvarBusinessDescribe.MaxLength = -1;
				colvarBusinessDescribe.AutoIncrement = false;
				colvarBusinessDescribe.IsNullable = true;
				colvarBusinessDescribe.IsPrimaryKey = false;
				colvarBusinessDescribe.IsForeignKey = false;
				colvarBusinessDescribe.IsReadOnly = false;
				colvarBusinessDescribe.DefaultSetting = @"";
				colvarBusinessDescribe.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBusinessDescribe);
				
				TableSchema.TableColumn colvarRiskDescribe = new TableSchema.TableColumn(schema);
				colvarRiskDescribe.ColumnName = "RiskDescribe";
				colvarRiskDescribe.DataType = DbType.String;
				colvarRiskDescribe.MaxLength = -1;
				colvarRiskDescribe.AutoIncrement = false;
				colvarRiskDescribe.IsNullable = true;
				colvarRiskDescribe.IsPrimaryKey = false;
				colvarRiskDescribe.IsForeignKey = false;
				colvarRiskDescribe.IsReadOnly = false;
				colvarRiskDescribe.DefaultSetting = @"";
				colvarRiskDescribe.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRiskDescribe);
				
				TableSchema.TableColumn colvarStrategyDesribe = new TableSchema.TableColumn(schema);
				colvarStrategyDesribe.ColumnName = "StrategyDesribe";
				colvarStrategyDesribe.DataType = DbType.String;
				colvarStrategyDesribe.MaxLength = -1;
				colvarStrategyDesribe.AutoIncrement = false;
				colvarStrategyDesribe.IsNullable = true;
				colvarStrategyDesribe.IsPrimaryKey = false;
				colvarStrategyDesribe.IsForeignKey = false;
				colvarStrategyDesribe.IsReadOnly = false;
				colvarStrategyDesribe.DefaultSetting = @"";
				colvarStrategyDesribe.ForeignKeyTableName = "";
				schema.Columns.Add(colvarStrategyDesribe);
				
				TableSchema.TableColumn colvarMemo = new TableSchema.TableColumn(schema);
				colvarMemo.ColumnName = "Memo";
				colvarMemo.DataType = DbType.String;
				colvarMemo.MaxLength = -1;
				colvarMemo.AutoIncrement = false;
				colvarMemo.IsNullable = true;
				colvarMemo.IsPrimaryKey = false;
				colvarMemo.IsForeignKey = false;
				colvarMemo.IsReadOnly = false;
				colvarMemo.DefaultSetting = @"";
				colvarMemo.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMemo);
				
				TableSchema.TableColumn colvarMarketView = new TableSchema.TableColumn(schema);
				colvarMarketView.ColumnName = "MarketView";
				colvarMarketView.DataType = DbType.String;
				colvarMarketView.MaxLength = 50;
				colvarMarketView.AutoIncrement = false;
				colvarMarketView.IsNullable = true;
				colvarMarketView.IsPrimaryKey = false;
				colvarMarketView.IsForeignKey = false;
				colvarMarketView.IsReadOnly = false;
				colvarMarketView.DefaultSetting = @"";
				colvarMarketView.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMarketView);
				
				TableSchema.TableColumn colvarTechView = new TableSchema.TableColumn(schema);
				colvarTechView.ColumnName = "TechView";
				colvarTechView.DataType = DbType.String;
				colvarTechView.MaxLength = 50;
				colvarTechView.AutoIncrement = false;
				colvarTechView.IsNullable = true;
				colvarTechView.IsPrimaryKey = false;
				colvarTechView.IsForeignKey = false;
				colvarTechView.IsReadOnly = false;
				colvarTechView.DefaultSetting = @"";
				colvarTechView.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTechView);
				
				TableSchema.TableColumn colvarManagerView = new TableSchema.TableColumn(schema);
				colvarManagerView.ColumnName = "ManagerView";
				colvarManagerView.DataType = DbType.String;
				colvarManagerView.MaxLength = 50;
				colvarManagerView.AutoIncrement = false;
				colvarManagerView.IsNullable = true;
				colvarManagerView.IsPrimaryKey = false;
				colvarManagerView.IsForeignKey = false;
				colvarManagerView.IsReadOnly = false;
				colvarManagerView.DefaultSetting = @"";
				colvarManagerView.ForeignKeyTableName = "";
				schema.Columns.Add(colvarManagerView);
				
				TableSchema.TableColumn colvarSheetNum = new TableSchema.TableColumn(schema);
				colvarSheetNum.ColumnName = "SheetNum";
				colvarSheetNum.DataType = DbType.String;
				colvarSheetNum.MaxLength = 50;
				colvarSheetNum.AutoIncrement = false;
				colvarSheetNum.IsNullable = true;
				colvarSheetNum.IsPrimaryKey = false;
				colvarSheetNum.IsForeignKey = false;
				colvarSheetNum.IsReadOnly = false;
				colvarSheetNum.DefaultSetting = @"";
				colvarSheetNum.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSheetNum);
				
				TableSchema.TableColumn colvarToday = new TableSchema.TableColumn(schema);
				colvarToday.ColumnName = "Today";
				colvarToday.DataType = DbType.String;
				colvarToday.MaxLength = 20;
				colvarToday.AutoIncrement = false;
				colvarToday.IsNullable = true;
				colvarToday.IsPrimaryKey = false;
				colvarToday.IsForeignKey = false;
				colvarToday.IsReadOnly = false;
				colvarToday.DefaultSetting = @"";
				colvarToday.ForeignKeyTableName = "";
				schema.Columns.Add(colvarToday);
				
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
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("ProjectCreate_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("ProjectCreateId")]
		[Bindable(true)]
		public int ProjectCreateId 
		{
			get { return GetColumnValue<int>(Columns.ProjectCreateId); }
			set { SetColumnValue(Columns.ProjectCreateId, value); }
		}
		  
		[XmlAttribute("ClientId")]
		[Bindable(true)]
		public int? ClientId 
		{
			get { return GetColumnValue<int?>(Columns.ClientId); }
			set { SetColumnValue(Columns.ClientId, value); }
		}
		  
		[XmlAttribute("ProjectLevelId")]
		[Bindable(true)]
		public int? ProjectLevelId 
		{
			get { return GetColumnValue<int?>(Columns.ProjectLevelId); }
			set { SetColumnValue(Columns.ProjectLevelId, value); }
		}
		  
		[XmlAttribute("ProjectTypeId")]
		[Bindable(true)]
		public int? ProjectTypeId 
		{
			get { return GetColumnValue<int?>(Columns.ProjectTypeId); }
			set { SetColumnValue(Columns.ProjectTypeId, value); }
		}
		  
		[XmlAttribute("YeWuId")]
		[Bindable(true)]
		public int? YeWuId 
		{
			get { return GetColumnValue<int?>(Columns.YeWuId); }
			set { SetColumnValue(Columns.YeWuId, value); }
		}
		  
		[XmlAttribute("ProjectName")]
		[Bindable(true)]
		public string ProjectName 
		{
			get { return GetColumnValue<string>(Columns.ProjectName); }
			set { SetColumnValue(Columns.ProjectName, value); }
		}
		  
		[XmlAttribute("PreMoney")]
		[Bindable(true)]
		public string PreMoney 
		{
			get { return GetColumnValue<string>(Columns.PreMoney); }
			set { SetColumnValue(Columns.PreMoney, value); }
		}
		  
		[XmlAttribute("PreProfit")]
		[Bindable(true)]
		public string PreProfit 
		{
			get { return GetColumnValue<string>(Columns.PreProfit); }
			set { SetColumnValue(Columns.PreProfit, value); }
		}
		  
		[XmlAttribute("ApplyDate")]
		[Bindable(true)]
		public string ApplyDate 
		{
			get { return GetColumnValue<string>(Columns.ApplyDate); }
			set { SetColumnValue(Columns.ApplyDate, value); }
		}
		  
		[XmlAttribute("CreatePhaseExp")]
		[Bindable(true)]
		public string CreatePhaseExp 
		{
			get { return GetColumnValue<string>(Columns.CreatePhaseExp); }
			set { SetColumnValue(Columns.CreatePhaseExp, value); }
		}
		  
		[XmlAttribute("ProposePhaseExp")]
		[Bindable(true)]
		public string ProposePhaseExp 
		{
			get { return GetColumnValue<string>(Columns.ProposePhaseExp); }
			set { SetColumnValue(Columns.ProposePhaseExp, value); }
		}
		  
		[XmlAttribute("CallbidPhaseExp")]
		[Bindable(true)]
		public string CallbidPhaseExp 
		{
			get { return GetColumnValue<string>(Columns.CallbidPhaseExp); }
			set { SetColumnValue(Columns.CallbidPhaseExp, value); }
		}
		  
		[XmlAttribute("TalkPhaseExp")]
		[Bindable(true)]
		public string TalkPhaseExp 
		{
			get { return GetColumnValue<string>(Columns.TalkPhaseExp); }
			set { SetColumnValue(Columns.TalkPhaseExp, value); }
		}
		  
		[XmlAttribute("CarryPhaseExp")]
		[Bindable(true)]
		public string CarryPhaseExp 
		{
			get { return GetColumnValue<string>(Columns.CarryPhaseExp); }
			set { SetColumnValue(Columns.CarryPhaseExp, value); }
		}
		  
		[XmlAttribute("NeedDescribe")]
		[Bindable(true)]
		public string NeedDescribe 
		{
			get { return GetColumnValue<string>(Columns.NeedDescribe); }
			set { SetColumnValue(Columns.NeedDescribe, value); }
		}
		  
		[XmlAttribute("CompitDescribe")]
		[Bindable(true)]
		public string CompitDescribe 
		{
			get { return GetColumnValue<string>(Columns.CompitDescribe); }
			set { SetColumnValue(Columns.CompitDescribe, value); }
		}
		  
		[XmlAttribute("ClientDescribe")]
		[Bindable(true)]
		public string ClientDescribe 
		{
			get { return GetColumnValue<string>(Columns.ClientDescribe); }
			set { SetColumnValue(Columns.ClientDescribe, value); }
		}
		  
		[XmlAttribute("TechDescribe")]
		[Bindable(true)]
		public string TechDescribe 
		{
			get { return GetColumnValue<string>(Columns.TechDescribe); }
			set { SetColumnValue(Columns.TechDescribe, value); }
		}
		  
		[XmlAttribute("BusinessDescribe")]
		[Bindable(true)]
		public string BusinessDescribe 
		{
			get { return GetColumnValue<string>(Columns.BusinessDescribe); }
			set { SetColumnValue(Columns.BusinessDescribe, value); }
		}
		  
		[XmlAttribute("RiskDescribe")]
		[Bindable(true)]
		public string RiskDescribe 
		{
			get { return GetColumnValue<string>(Columns.RiskDescribe); }
			set { SetColumnValue(Columns.RiskDescribe, value); }
		}
		  
		[XmlAttribute("StrategyDesribe")]
		[Bindable(true)]
		public string StrategyDesribe 
		{
			get { return GetColumnValue<string>(Columns.StrategyDesribe); }
			set { SetColumnValue(Columns.StrategyDesribe, value); }
		}
		  
		[XmlAttribute("Memo")]
		[Bindable(true)]
		public string Memo 
		{
			get { return GetColumnValue<string>(Columns.Memo); }
			set { SetColumnValue(Columns.Memo, value); }
		}
		  
		[XmlAttribute("MarketView")]
		[Bindable(true)]
		public string MarketView 
		{
			get { return GetColumnValue<string>(Columns.MarketView); }
			set { SetColumnValue(Columns.MarketView, value); }
		}
		  
		[XmlAttribute("TechView")]
		[Bindable(true)]
		public string TechView 
		{
			get { return GetColumnValue<string>(Columns.TechView); }
			set { SetColumnValue(Columns.TechView, value); }
		}
		  
		[XmlAttribute("ManagerView")]
		[Bindable(true)]
		public string ManagerView 
		{
			get { return GetColumnValue<string>(Columns.ManagerView); }
			set { SetColumnValue(Columns.ManagerView, value); }
		}
		  
		[XmlAttribute("SheetNum")]
		[Bindable(true)]
		public string SheetNum 
		{
			get { return GetColumnValue<string>(Columns.SheetNum); }
			set { SetColumnValue(Columns.SheetNum, value); }
		}
		  
		[XmlAttribute("Today")]
		[Bindable(true)]
		public string Today 
		{
			get { return GetColumnValue<string>(Columns.Today); }
			set { SetColumnValue(Columns.Today, value); }
		}
		  
		[XmlAttribute("ApplyName")]
		[Bindable(true)]
		public string ApplyName 
		{
			get { return GetColumnValue<string>(Columns.ApplyName); }
			set { SetColumnValue(Columns.ApplyName, value); }
		}
		  
		[XmlAttribute("DepartName")]
		[Bindable(true)]
		public string DepartName 
		{
			get { return GetColumnValue<string>(Columns.DepartName); }
			set { SetColumnValue(Columns.DepartName, value); }
		}
		  
		[XmlAttribute("State")]
		[Bindable(true)]
		public int? State 
		{
			get { return GetColumnValue<int?>(Columns.State); }
			set { SetColumnValue(Columns.State, value); }
		}
		  
		[XmlAttribute("ApplyTime")]
		[Bindable(true)]
		public string ApplyTime 
		{
			get { return GetColumnValue<string>(Columns.ApplyTime); }
			set { SetColumnValue(Columns.ApplyTime, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int? varClientId,int? varProjectLevelId,int? varProjectTypeId,int? varYeWuId,string varProjectName,string varPreMoney,string varPreProfit,string varApplyDate,string varCreatePhaseExp,string varProposePhaseExp,string varCallbidPhaseExp,string varTalkPhaseExp,string varCarryPhaseExp,string varNeedDescribe,string varCompitDescribe,string varClientDescribe,string varTechDescribe,string varBusinessDescribe,string varRiskDescribe,string varStrategyDesribe,string varMemo,string varMarketView,string varTechView,string varManagerView,string varSheetNum,string varToday,string varApplyName,string varDepartName,int? varState,string varApplyTime)
		{
			ProjectCreate item = new ProjectCreate();
			
			item.ClientId = varClientId;
			
			item.ProjectLevelId = varProjectLevelId;
			
			item.ProjectTypeId = varProjectTypeId;
			
			item.YeWuId = varYeWuId;
			
			item.ProjectName = varProjectName;
			
			item.PreMoney = varPreMoney;
			
			item.PreProfit = varPreProfit;
			
			item.ApplyDate = varApplyDate;
			
			item.CreatePhaseExp = varCreatePhaseExp;
			
			item.ProposePhaseExp = varProposePhaseExp;
			
			item.CallbidPhaseExp = varCallbidPhaseExp;
			
			item.TalkPhaseExp = varTalkPhaseExp;
			
			item.CarryPhaseExp = varCarryPhaseExp;
			
			item.NeedDescribe = varNeedDescribe;
			
			item.CompitDescribe = varCompitDescribe;
			
			item.ClientDescribe = varClientDescribe;
			
			item.TechDescribe = varTechDescribe;
			
			item.BusinessDescribe = varBusinessDescribe;
			
			item.RiskDescribe = varRiskDescribe;
			
			item.StrategyDesribe = varStrategyDesribe;
			
			item.Memo = varMemo;
			
			item.MarketView = varMarketView;
			
			item.TechView = varTechView;
			
			item.ManagerView = varManagerView;
			
			item.SheetNum = varSheetNum;
			
			item.Today = varToday;
			
			item.ApplyName = varApplyName;
			
			item.DepartName = varDepartName;
			
			item.State = varState;
			
			item.ApplyTime = varApplyTime;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varProjectCreateId,int? varClientId,int? varProjectLevelId,int? varProjectTypeId,int? varYeWuId,string varProjectName,string varPreMoney,string varPreProfit,string varApplyDate,string varCreatePhaseExp,string varProposePhaseExp,string varCallbidPhaseExp,string varTalkPhaseExp,string varCarryPhaseExp,string varNeedDescribe,string varCompitDescribe,string varClientDescribe,string varTechDescribe,string varBusinessDescribe,string varRiskDescribe,string varStrategyDesribe,string varMemo,string varMarketView,string varTechView,string varManagerView,string varSheetNum,string varToday,string varApplyName,string varDepartName,int? varState,string varApplyTime)
		{
			ProjectCreate item = new ProjectCreate();
			
				item.ProjectCreateId = varProjectCreateId;
			
				item.ClientId = varClientId;
			
				item.ProjectLevelId = varProjectLevelId;
			
				item.ProjectTypeId = varProjectTypeId;
			
				item.YeWuId = varYeWuId;
			
				item.ProjectName = varProjectName;
			
				item.PreMoney = varPreMoney;
			
				item.PreProfit = varPreProfit;
			
				item.ApplyDate = varApplyDate;
			
				item.CreatePhaseExp = varCreatePhaseExp;
			
				item.ProposePhaseExp = varProposePhaseExp;
			
				item.CallbidPhaseExp = varCallbidPhaseExp;
			
				item.TalkPhaseExp = varTalkPhaseExp;
			
				item.CarryPhaseExp = varCarryPhaseExp;
			
				item.NeedDescribe = varNeedDescribe;
			
				item.CompitDescribe = varCompitDescribe;
			
				item.ClientDescribe = varClientDescribe;
			
				item.TechDescribe = varTechDescribe;
			
				item.BusinessDescribe = varBusinessDescribe;
			
				item.RiskDescribe = varRiskDescribe;
			
				item.StrategyDesribe = varStrategyDesribe;
			
				item.Memo = varMemo;
			
				item.MarketView = varMarketView;
			
				item.TechView = varTechView;
			
				item.ManagerView = varManagerView;
			
				item.SheetNum = varSheetNum;
			
				item.Today = varToday;
			
				item.ApplyName = varApplyName;
			
				item.DepartName = varDepartName;
			
				item.State = varState;
			
				item.ApplyTime = varApplyTime;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn ProjectCreateIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ClientIdColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn ProjectLevelIdColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn ProjectTypeIdColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn YeWuIdColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn ProjectNameColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn PreMoneyColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn PreProfitColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn ApplyDateColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn CreatePhaseExpColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn ProposePhaseExpColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn CallbidPhaseExpColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn TalkPhaseExpColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn CarryPhaseExpColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn NeedDescribeColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn CompitDescribeColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn ClientDescribeColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn TechDescribeColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn BusinessDescribeColumn
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn RiskDescribeColumn
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        public static TableSchema.TableColumn StrategyDesribeColumn
        {
            get { return Schema.Columns[20]; }
        }
        
        
        
        public static TableSchema.TableColumn MemoColumn
        {
            get { return Schema.Columns[21]; }
        }
        
        
        
        public static TableSchema.TableColumn MarketViewColumn
        {
            get { return Schema.Columns[22]; }
        }
        
        
        
        public static TableSchema.TableColumn TechViewColumn
        {
            get { return Schema.Columns[23]; }
        }
        
        
        
        public static TableSchema.TableColumn ManagerViewColumn
        {
            get { return Schema.Columns[24]; }
        }
        
        
        
        public static TableSchema.TableColumn SheetNumColumn
        {
            get { return Schema.Columns[25]; }
        }
        
        
        
        public static TableSchema.TableColumn TodayColumn
        {
            get { return Schema.Columns[26]; }
        }
        
        
        
        public static TableSchema.TableColumn ApplyNameColumn
        {
            get { return Schema.Columns[27]; }
        }
        
        
        
        public static TableSchema.TableColumn DepartNameColumn
        {
            get { return Schema.Columns[28]; }
        }
        
        
        
        public static TableSchema.TableColumn StateColumn
        {
            get { return Schema.Columns[29]; }
        }
        
        
        
        public static TableSchema.TableColumn ApplyTimeColumn
        {
            get { return Schema.Columns[30]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string ProjectCreateId = @"ProjectCreateId";
			 public static string ClientId = @"ClientId";
			 public static string ProjectLevelId = @"ProjectLevelId";
			 public static string ProjectTypeId = @"ProjectTypeId";
			 public static string YeWuId = @"YeWuId";
			 public static string ProjectName = @"ProjectName";
			 public static string PreMoney = @"PreMoney";
			 public static string PreProfit = @"PreProfit";
			 public static string ApplyDate = @"ApplyDate";
			 public static string CreatePhaseExp = @"CreatePhaseExp";
			 public static string ProposePhaseExp = @"ProposePhaseExp";
			 public static string CallbidPhaseExp = @"CallbidPhaseExp";
			 public static string TalkPhaseExp = @"TalkPhaseExp";
			 public static string CarryPhaseExp = @"CarryPhaseExp";
			 public static string NeedDescribe = @"NeedDescribe";
			 public static string CompitDescribe = @"CompitDescribe";
			 public static string ClientDescribe = @"ClientDescribe";
			 public static string TechDescribe = @"TechDescribe";
			 public static string BusinessDescribe = @"BusinessDescribe";
			 public static string RiskDescribe = @"RiskDescribe";
			 public static string StrategyDesribe = @"StrategyDesribe";
			 public static string Memo = @"Memo";
			 public static string MarketView = @"MarketView";
			 public static string TechView = @"TechView";
			 public static string ManagerView = @"ManagerView";
			 public static string SheetNum = @"SheetNum";
			 public static string Today = @"Today";
			 public static string ApplyName = @"ApplyName";
			 public static string DepartName = @"DepartName";
			 public static string State = @"State";
			 public static string ApplyTime = @"ApplyTime";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
