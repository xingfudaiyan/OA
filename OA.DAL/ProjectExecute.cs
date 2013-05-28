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
	/// Strongly-typed collection for the ProjectExecute class.
	/// </summary>
    [Serializable]
	public partial class ProjectExecuteCollection : ActiveList<ProjectExecute, ProjectExecuteCollection>
	{	   
		public ProjectExecuteCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>ProjectExecuteCollection</returns>
		public ProjectExecuteCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                ProjectExecute o = this[i];
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
	/// This is an ActiveRecord class which wraps the ProjectExecute_tb table.
	/// </summary>
	[Serializable]
	public partial class ProjectExecute : ActiveRecord<ProjectExecute>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public ProjectExecute()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public ProjectExecute(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public ProjectExecute(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public ProjectExecute(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("ProjectExecute_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarProjectExecuteId = new TableSchema.TableColumn(schema);
				colvarProjectExecuteId.ColumnName = "ProjectExecuteId";
				colvarProjectExecuteId.DataType = DbType.Int32;
				colvarProjectExecuteId.MaxLength = 0;
				colvarProjectExecuteId.AutoIncrement = true;
				colvarProjectExecuteId.IsNullable = false;
				colvarProjectExecuteId.IsPrimaryKey = true;
				colvarProjectExecuteId.IsForeignKey = false;
				colvarProjectExecuteId.IsReadOnly = false;
				colvarProjectExecuteId.DefaultSetting = @"";
				colvarProjectExecuteId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProjectExecuteId);
				
				TableSchema.TableColumn colvarProjectExecuteTypeId = new TableSchema.TableColumn(schema);
				colvarProjectExecuteTypeId.ColumnName = "ProjectExecuteTypeId";
				colvarProjectExecuteTypeId.DataType = DbType.Int32;
				colvarProjectExecuteTypeId.MaxLength = 0;
				colvarProjectExecuteTypeId.AutoIncrement = false;
				colvarProjectExecuteTypeId.IsNullable = true;
				colvarProjectExecuteTypeId.IsPrimaryKey = false;
				colvarProjectExecuteTypeId.IsForeignKey = true;
				colvarProjectExecuteTypeId.IsReadOnly = false;
				colvarProjectExecuteTypeId.DefaultSetting = @"";
				
					colvarProjectExecuteTypeId.ForeignKeyTableName = "WorkSheetType_tb";
				schema.Columns.Add(colvarProjectExecuteTypeId);
				
				TableSchema.TableColumn colvarMainProjectExecuteId = new TableSchema.TableColumn(schema);
				colvarMainProjectExecuteId.ColumnName = "MainProjectExecuteId";
				colvarMainProjectExecuteId.DataType = DbType.Int32;
				colvarMainProjectExecuteId.MaxLength = 0;
				colvarMainProjectExecuteId.AutoIncrement = false;
				colvarMainProjectExecuteId.IsNullable = true;
				colvarMainProjectExecuteId.IsPrimaryKey = false;
				colvarMainProjectExecuteId.IsForeignKey = false;
				colvarMainProjectExecuteId.IsReadOnly = false;
				colvarMainProjectExecuteId.DefaultSetting = @"";
				colvarMainProjectExecuteId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMainProjectExecuteId);
				
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
				
				TableSchema.TableColumn colvarRelateId = new TableSchema.TableColumn(schema);
				colvarRelateId.ColumnName = "RelateId";
				colvarRelateId.DataType = DbType.Int32;
				colvarRelateId.MaxLength = 0;
				colvarRelateId.AutoIncrement = false;
				colvarRelateId.IsNullable = true;
				colvarRelateId.IsPrimaryKey = false;
				colvarRelateId.IsForeignKey = false;
				colvarRelateId.IsReadOnly = false;
				colvarRelateId.DefaultSetting = @"";
				colvarRelateId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRelateId);
				
				TableSchema.TableColumn colvarContractId = new TableSchema.TableColumn(schema);
				colvarContractId.ColumnName = "ContractId";
				colvarContractId.DataType = DbType.Int32;
				colvarContractId.MaxLength = 0;
				colvarContractId.AutoIncrement = false;
				colvarContractId.IsNullable = true;
				colvarContractId.IsPrimaryKey = false;
				colvarContractId.IsForeignKey = false;
				colvarContractId.IsReadOnly = false;
				colvarContractId.DefaultSetting = @"";
				colvarContractId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarContractId);
				
				TableSchema.TableColumn colvarMainProjectCreateId = new TableSchema.TableColumn(schema);
				colvarMainProjectCreateId.ColumnName = "MainProjectCreateId";
				colvarMainProjectCreateId.DataType = DbType.Int32;
				colvarMainProjectCreateId.MaxLength = 0;
				colvarMainProjectCreateId.AutoIncrement = false;
				colvarMainProjectCreateId.IsNullable = true;
				colvarMainProjectCreateId.IsPrimaryKey = false;
				colvarMainProjectCreateId.IsForeignKey = false;
				colvarMainProjectCreateId.IsReadOnly = false;
				colvarMainProjectCreateId.DefaultSetting = @"";
				colvarMainProjectCreateId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMainProjectCreateId);
				
				TableSchema.TableColumn colvarWorkSheetNum = new TableSchema.TableColumn(schema);
				colvarWorkSheetNum.ColumnName = "WorkSheetNum";
				colvarWorkSheetNum.DataType = DbType.String;
				colvarWorkSheetNum.MaxLength = 50;
				colvarWorkSheetNum.AutoIncrement = false;
				colvarWorkSheetNum.IsNullable = true;
				colvarWorkSheetNum.IsPrimaryKey = false;
				colvarWorkSheetNum.IsForeignKey = false;
				colvarWorkSheetNum.IsReadOnly = false;
				colvarWorkSheetNum.DefaultSetting = @"";
				colvarWorkSheetNum.ForeignKeyTableName = "";
				schema.Columns.Add(colvarWorkSheetNum);
				
				TableSchema.TableColumn colvarSubmitPeople = new TableSchema.TableColumn(schema);
				colvarSubmitPeople.ColumnName = "SubmitPeople";
				colvarSubmitPeople.DataType = DbType.String;
				colvarSubmitPeople.MaxLength = 50;
				colvarSubmitPeople.AutoIncrement = false;
				colvarSubmitPeople.IsNullable = true;
				colvarSubmitPeople.IsPrimaryKey = false;
				colvarSubmitPeople.IsForeignKey = false;
				colvarSubmitPeople.IsReadOnly = false;
				colvarSubmitPeople.DefaultSetting = @"";
				colvarSubmitPeople.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSubmitPeople);
				
				TableSchema.TableColumn colvarOffSheetTime = new TableSchema.TableColumn(schema);
				colvarOffSheetTime.ColumnName = "OffSheetTime";
				colvarOffSheetTime.DataType = DbType.DateTime;
				colvarOffSheetTime.MaxLength = 0;
				colvarOffSheetTime.AutoIncrement = false;
				colvarOffSheetTime.IsNullable = true;
				colvarOffSheetTime.IsPrimaryKey = false;
				colvarOffSheetTime.IsForeignKey = false;
				colvarOffSheetTime.IsReadOnly = false;
				colvarOffSheetTime.DefaultSetting = @"";
				colvarOffSheetTime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOffSheetTime);
				
				TableSchema.TableColumn colvarOtherDescribe = new TableSchema.TableColumn(schema);
				colvarOtherDescribe.ColumnName = "OtherDescribe";
				colvarOtherDescribe.DataType = DbType.String;
				colvarOtherDescribe.MaxLength = 50;
				colvarOtherDescribe.AutoIncrement = false;
				colvarOtherDescribe.IsNullable = true;
				colvarOtherDescribe.IsPrimaryKey = false;
				colvarOtherDescribe.IsForeignKey = false;
				colvarOtherDescribe.IsReadOnly = false;
				colvarOtherDescribe.DefaultSetting = @"";
				colvarOtherDescribe.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOtherDescribe);
				
				TableSchema.TableColumn colvarTechRequire = new TableSchema.TableColumn(schema);
				colvarTechRequire.ColumnName = "TechRequire";
				colvarTechRequire.DataType = DbType.String;
				colvarTechRequire.MaxLength = 50;
				colvarTechRequire.AutoIncrement = false;
				colvarTechRequire.IsNullable = true;
				colvarTechRequire.IsPrimaryKey = false;
				colvarTechRequire.IsForeignKey = false;
				colvarTechRequire.IsReadOnly = false;
				colvarTechRequire.DefaultSetting = @"";
				colvarTechRequire.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTechRequire);
				
				TableSchema.TableColumn colvarOtherRequire = new TableSchema.TableColumn(schema);
				colvarOtherRequire.ColumnName = "OtherRequire";
				colvarOtherRequire.DataType = DbType.String;
				colvarOtherRequire.MaxLength = 50;
				colvarOtherRequire.AutoIncrement = false;
				colvarOtherRequire.IsNullable = true;
				colvarOtherRequire.IsPrimaryKey = false;
				colvarOtherRequire.IsForeignKey = false;
				colvarOtherRequire.IsReadOnly = false;
				colvarOtherRequire.DefaultSetting = @"";
				colvarOtherRequire.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOtherRequire);
				
				TableSchema.TableColumn colvarTimeLimit = new TableSchema.TableColumn(schema);
				colvarTimeLimit.ColumnName = "TimeLimit";
				colvarTimeLimit.DataType = DbType.DateTime;
				colvarTimeLimit.MaxLength = 0;
				colvarTimeLimit.AutoIncrement = false;
				colvarTimeLimit.IsNullable = true;
				colvarTimeLimit.IsPrimaryKey = false;
				colvarTimeLimit.IsForeignKey = false;
				colvarTimeLimit.IsReadOnly = false;
				colvarTimeLimit.DefaultSetting = @"";
				colvarTimeLimit.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTimeLimit);
				
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
				
				TableSchema.TableColumn colvarOthers = new TableSchema.TableColumn(schema);
				colvarOthers.ColumnName = "Others";
				colvarOthers.DataType = DbType.String;
				colvarOthers.MaxLength = 50;
				colvarOthers.AutoIncrement = false;
				colvarOthers.IsNullable = true;
				colvarOthers.IsPrimaryKey = false;
				colvarOthers.IsForeignKey = false;
				colvarOthers.IsReadOnly = false;
				colvarOthers.DefaultSetting = @"";
				colvarOthers.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOthers);
				
				TableSchema.TableColumn colvarPreEmployeeId = new TableSchema.TableColumn(schema);
				colvarPreEmployeeId.ColumnName = "PreEmployeeId";
				colvarPreEmployeeId.DataType = DbType.Int32;
				colvarPreEmployeeId.MaxLength = 0;
				colvarPreEmployeeId.AutoIncrement = false;
				colvarPreEmployeeId.IsNullable = true;
				colvarPreEmployeeId.IsPrimaryKey = false;
				colvarPreEmployeeId.IsForeignKey = false;
				colvarPreEmployeeId.IsReadOnly = false;
				colvarPreEmployeeId.DefaultSetting = @"";
				colvarPreEmployeeId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPreEmployeeId);
				
				TableSchema.TableColumn colvarPreEmployeeName = new TableSchema.TableColumn(schema);
				colvarPreEmployeeName.ColumnName = "PreEmployeeName";
				colvarPreEmployeeName.DataType = DbType.String;
				colvarPreEmployeeName.MaxLength = 50;
				colvarPreEmployeeName.AutoIncrement = false;
				colvarPreEmployeeName.IsNullable = true;
				colvarPreEmployeeName.IsPrimaryKey = false;
				colvarPreEmployeeName.IsForeignKey = false;
				colvarPreEmployeeName.IsReadOnly = false;
				colvarPreEmployeeName.DefaultSetting = @"";
				colvarPreEmployeeName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPreEmployeeName);
				
				TableSchema.TableColumn colvarSendEmployeeId = new TableSchema.TableColumn(schema);
				colvarSendEmployeeId.ColumnName = "SendEmployeeId";
				colvarSendEmployeeId.DataType = DbType.Int32;
				colvarSendEmployeeId.MaxLength = 0;
				colvarSendEmployeeId.AutoIncrement = false;
				colvarSendEmployeeId.IsNullable = true;
				colvarSendEmployeeId.IsPrimaryKey = false;
				colvarSendEmployeeId.IsForeignKey = false;
				colvarSendEmployeeId.IsReadOnly = false;
				colvarSendEmployeeId.DefaultSetting = @"";
				colvarSendEmployeeId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSendEmployeeId);
				
				TableSchema.TableColumn colvarSendEmployeeName = new TableSchema.TableColumn(schema);
				colvarSendEmployeeName.ColumnName = "SendEmployeeName";
				colvarSendEmployeeName.DataType = DbType.String;
				colvarSendEmployeeName.MaxLength = 50;
				colvarSendEmployeeName.AutoIncrement = false;
				colvarSendEmployeeName.IsNullable = true;
				colvarSendEmployeeName.IsPrimaryKey = false;
				colvarSendEmployeeName.IsForeignKey = false;
				colvarSendEmployeeName.IsReadOnly = false;
				colvarSendEmployeeName.DefaultSetting = @"";
				colvarSendEmployeeName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSendEmployeeName);
				
				TableSchema.TableColumn colvarRecvEmployeeId = new TableSchema.TableColumn(schema);
				colvarRecvEmployeeId.ColumnName = "RecvEmployeeId";
				colvarRecvEmployeeId.DataType = DbType.Int32;
				colvarRecvEmployeeId.MaxLength = 0;
				colvarRecvEmployeeId.AutoIncrement = false;
				colvarRecvEmployeeId.IsNullable = true;
				colvarRecvEmployeeId.IsPrimaryKey = false;
				colvarRecvEmployeeId.IsForeignKey = false;
				colvarRecvEmployeeId.IsReadOnly = false;
				colvarRecvEmployeeId.DefaultSetting = @"";
				colvarRecvEmployeeId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRecvEmployeeId);
				
				TableSchema.TableColumn colvarRecvEmployeeName = new TableSchema.TableColumn(schema);
				colvarRecvEmployeeName.ColumnName = "RecvEmployeeName";
				colvarRecvEmployeeName.DataType = DbType.String;
				colvarRecvEmployeeName.MaxLength = 50;
				colvarRecvEmployeeName.AutoIncrement = false;
				colvarRecvEmployeeName.IsNullable = true;
				colvarRecvEmployeeName.IsPrimaryKey = false;
				colvarRecvEmployeeName.IsForeignKey = false;
				colvarRecvEmployeeName.IsReadOnly = false;
				colvarRecvEmployeeName.DefaultSetting = @"";
				colvarRecvEmployeeName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRecvEmployeeName);
				
				TableSchema.TableColumn colvarRecv1EmployeeId = new TableSchema.TableColumn(schema);
				colvarRecv1EmployeeId.ColumnName = "Recv1EmployeeId";
				colvarRecv1EmployeeId.DataType = DbType.Int32;
				colvarRecv1EmployeeId.MaxLength = 0;
				colvarRecv1EmployeeId.AutoIncrement = false;
				colvarRecv1EmployeeId.IsNullable = true;
				colvarRecv1EmployeeId.IsPrimaryKey = false;
				colvarRecv1EmployeeId.IsForeignKey = false;
				colvarRecv1EmployeeId.IsReadOnly = false;
				colvarRecv1EmployeeId.DefaultSetting = @"";
				colvarRecv1EmployeeId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRecv1EmployeeId);
				
				TableSchema.TableColumn colvarRecv1EmployeeName = new TableSchema.TableColumn(schema);
				colvarRecv1EmployeeName.ColumnName = "Recv1EmployeeName";
				colvarRecv1EmployeeName.DataType = DbType.String;
				colvarRecv1EmployeeName.MaxLength = 50;
				colvarRecv1EmployeeName.AutoIncrement = false;
				colvarRecv1EmployeeName.IsNullable = true;
				colvarRecv1EmployeeName.IsPrimaryKey = false;
				colvarRecv1EmployeeName.IsForeignKey = false;
				colvarRecv1EmployeeName.IsReadOnly = false;
				colvarRecv1EmployeeName.DefaultSetting = @"";
				colvarRecv1EmployeeName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRecv1EmployeeName);
				
				TableSchema.TableColumn colvarRecv2EmployeeId = new TableSchema.TableColumn(schema);
				colvarRecv2EmployeeId.ColumnName = "Recv2EmployeeId";
				colvarRecv2EmployeeId.DataType = DbType.Int32;
				colvarRecv2EmployeeId.MaxLength = 0;
				colvarRecv2EmployeeId.AutoIncrement = false;
				colvarRecv2EmployeeId.IsNullable = true;
				colvarRecv2EmployeeId.IsPrimaryKey = false;
				colvarRecv2EmployeeId.IsForeignKey = false;
				colvarRecv2EmployeeId.IsReadOnly = false;
				colvarRecv2EmployeeId.DefaultSetting = @"";
				colvarRecv2EmployeeId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRecv2EmployeeId);
				
				TableSchema.TableColumn colvarRecv2EmployeeName = new TableSchema.TableColumn(schema);
				colvarRecv2EmployeeName.ColumnName = "Recv2EmployeeName";
				colvarRecv2EmployeeName.DataType = DbType.String;
				colvarRecv2EmployeeName.MaxLength = 50;
				colvarRecv2EmployeeName.AutoIncrement = false;
				colvarRecv2EmployeeName.IsNullable = true;
				colvarRecv2EmployeeName.IsPrimaryKey = false;
				colvarRecv2EmployeeName.IsForeignKey = false;
				colvarRecv2EmployeeName.IsReadOnly = false;
				colvarRecv2EmployeeName.DefaultSetting = @"";
				colvarRecv2EmployeeName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarRecv2EmployeeName);
				
				TableSchema.TableColumn colvarPreIsApply = new TableSchema.TableColumn(schema);
				colvarPreIsApply.ColumnName = "PreIsApply";
				colvarPreIsApply.DataType = DbType.Int32;
				colvarPreIsApply.MaxLength = 0;
				colvarPreIsApply.AutoIncrement = false;
				colvarPreIsApply.IsNullable = true;
				colvarPreIsApply.IsPrimaryKey = false;
				colvarPreIsApply.IsForeignKey = false;
				colvarPreIsApply.IsReadOnly = false;
				colvarPreIsApply.DefaultSetting = @"";
				colvarPreIsApply.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPreIsApply);
				
				TableSchema.TableColumn colvarIsApprove = new TableSchema.TableColumn(schema);
				colvarIsApprove.ColumnName = "IsApprove";
				colvarIsApprove.DataType = DbType.Int32;
				colvarIsApprove.MaxLength = 0;
				colvarIsApprove.AutoIncrement = false;
				colvarIsApprove.IsNullable = true;
				colvarIsApprove.IsPrimaryKey = false;
				colvarIsApprove.IsForeignKey = false;
				colvarIsApprove.IsReadOnly = false;
				colvarIsApprove.DefaultSetting = @"";
				colvarIsApprove.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIsApprove);
				
				TableSchema.TableColumn colvarIsApply = new TableSchema.TableColumn(schema);
				colvarIsApply.ColumnName = "IsApply";
				colvarIsApply.DataType = DbType.Int32;
				colvarIsApply.MaxLength = 0;
				colvarIsApply.AutoIncrement = false;
				colvarIsApply.IsNullable = true;
				colvarIsApply.IsPrimaryKey = false;
				colvarIsApply.IsForeignKey = false;
				colvarIsApply.IsReadOnly = false;
				colvarIsApply.DefaultSetting = @"";
				colvarIsApply.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIsApply);
				
				TableSchema.TableColumn colvarIsApply1 = new TableSchema.TableColumn(schema);
				colvarIsApply1.ColumnName = "IsApply1";
				colvarIsApply1.DataType = DbType.Int32;
				colvarIsApply1.MaxLength = 0;
				colvarIsApply1.AutoIncrement = false;
				colvarIsApply1.IsNullable = true;
				colvarIsApply1.IsPrimaryKey = false;
				colvarIsApply1.IsForeignKey = false;
				colvarIsApply1.IsReadOnly = false;
				colvarIsApply1.DefaultSetting = @"";
				colvarIsApply1.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIsApply1);
				
				TableSchema.TableColumn colvarIsApply2 = new TableSchema.TableColumn(schema);
				colvarIsApply2.ColumnName = "IsApply2";
				colvarIsApply2.DataType = DbType.Int32;
				colvarIsApply2.MaxLength = 0;
				colvarIsApply2.AutoIncrement = false;
				colvarIsApply2.IsNullable = true;
				colvarIsApply2.IsPrimaryKey = false;
				colvarIsApply2.IsForeignKey = false;
				colvarIsApply2.IsReadOnly = false;
				colvarIsApply2.DefaultSetting = @"";
				colvarIsApply2.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIsApply2);
				
				TableSchema.TableColumn colvarPreApplyTime = new TableSchema.TableColumn(schema);
				colvarPreApplyTime.ColumnName = "PreApplyTime";
				colvarPreApplyTime.DataType = DbType.DateTime;
				colvarPreApplyTime.MaxLength = 0;
				colvarPreApplyTime.AutoIncrement = false;
				colvarPreApplyTime.IsNullable = true;
				colvarPreApplyTime.IsPrimaryKey = false;
				colvarPreApplyTime.IsForeignKey = false;
				colvarPreApplyTime.IsReadOnly = false;
				colvarPreApplyTime.DefaultSetting = @"";
				colvarPreApplyTime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPreApplyTime);
				
				TableSchema.TableColumn colvarApproveTime = new TableSchema.TableColumn(schema);
				colvarApproveTime.ColumnName = "ApproveTime";
				colvarApproveTime.DataType = DbType.DateTime;
				colvarApproveTime.MaxLength = 0;
				colvarApproveTime.AutoIncrement = false;
				colvarApproveTime.IsNullable = true;
				colvarApproveTime.IsPrimaryKey = false;
				colvarApproveTime.IsForeignKey = false;
				colvarApproveTime.IsReadOnly = false;
				colvarApproveTime.DefaultSetting = @"";
				colvarApproveTime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarApproveTime);
				
				TableSchema.TableColumn colvarApplyTime = new TableSchema.TableColumn(schema);
				colvarApplyTime.ColumnName = "ApplyTime";
				colvarApplyTime.DataType = DbType.DateTime;
				colvarApplyTime.MaxLength = 0;
				colvarApplyTime.AutoIncrement = false;
				colvarApplyTime.IsNullable = true;
				colvarApplyTime.IsPrimaryKey = false;
				colvarApplyTime.IsForeignKey = false;
				colvarApplyTime.IsReadOnly = false;
				colvarApplyTime.DefaultSetting = @"";
				colvarApplyTime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarApplyTime);
				
				TableSchema.TableColumn colvarApply1Time = new TableSchema.TableColumn(schema);
				colvarApply1Time.ColumnName = "Apply1Time";
				colvarApply1Time.DataType = DbType.DateTime;
				colvarApply1Time.MaxLength = 0;
				colvarApply1Time.AutoIncrement = false;
				colvarApply1Time.IsNullable = true;
				colvarApply1Time.IsPrimaryKey = false;
				colvarApply1Time.IsForeignKey = false;
				colvarApply1Time.IsReadOnly = false;
				colvarApply1Time.DefaultSetting = @"";
				colvarApply1Time.ForeignKeyTableName = "";
				schema.Columns.Add(colvarApply1Time);
				
				TableSchema.TableColumn colvarApply2Time = new TableSchema.TableColumn(schema);
				colvarApply2Time.ColumnName = "Apply2Time";
				colvarApply2Time.DataType = DbType.DateTime;
				colvarApply2Time.MaxLength = 0;
				colvarApply2Time.AutoIncrement = false;
				colvarApply2Time.IsNullable = true;
				colvarApply2Time.IsPrimaryKey = false;
				colvarApply2Time.IsForeignKey = false;
				colvarApply2Time.IsReadOnly = false;
				colvarApply2Time.DefaultSetting = @"";
				colvarApply2Time.ForeignKeyTableName = "";
				schema.Columns.Add(colvarApply2Time);
				
				TableSchema.TableColumn colvarPreIsOver = new TableSchema.TableColumn(schema);
				colvarPreIsOver.ColumnName = "PreIsOver";
				colvarPreIsOver.DataType = DbType.Int32;
				colvarPreIsOver.MaxLength = 0;
				colvarPreIsOver.AutoIncrement = false;
				colvarPreIsOver.IsNullable = true;
				colvarPreIsOver.IsPrimaryKey = false;
				colvarPreIsOver.IsForeignKey = false;
				colvarPreIsOver.IsReadOnly = false;
				colvarPreIsOver.DefaultSetting = @"";
				colvarPreIsOver.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPreIsOver);
				
				TableSchema.TableColumn colvarIsOver1 = new TableSchema.TableColumn(schema);
				colvarIsOver1.ColumnName = "IsOver1";
				colvarIsOver1.DataType = DbType.Int32;
				colvarIsOver1.MaxLength = 0;
				colvarIsOver1.AutoIncrement = false;
				colvarIsOver1.IsNullable = true;
				colvarIsOver1.IsPrimaryKey = false;
				colvarIsOver1.IsForeignKey = false;
				colvarIsOver1.IsReadOnly = false;
				colvarIsOver1.DefaultSetting = @"";
				colvarIsOver1.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIsOver1);
				
				TableSchema.TableColumn colvarIsOver2 = new TableSchema.TableColumn(schema);
				colvarIsOver2.ColumnName = "IsOver2";
				colvarIsOver2.DataType = DbType.Int32;
				colvarIsOver2.MaxLength = 0;
				colvarIsOver2.AutoIncrement = false;
				colvarIsOver2.IsNullable = true;
				colvarIsOver2.IsPrimaryKey = false;
				colvarIsOver2.IsForeignKey = false;
				colvarIsOver2.IsReadOnly = false;
				colvarIsOver2.DefaultSetting = @"";
				colvarIsOver2.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIsOver2);
				
				TableSchema.TableColumn colvarIsMain = new TableSchema.TableColumn(schema);
				colvarIsMain.ColumnName = "IsMain";
				colvarIsMain.DataType = DbType.Int32;
				colvarIsMain.MaxLength = 0;
				colvarIsMain.AutoIncrement = false;
				colvarIsMain.IsNullable = true;
				colvarIsMain.IsPrimaryKey = false;
				colvarIsMain.IsForeignKey = false;
				colvarIsMain.IsReadOnly = false;
				colvarIsMain.DefaultSetting = @"";
				colvarIsMain.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIsMain);
				
				TableSchema.TableColumn colvarIsMain1 = new TableSchema.TableColumn(schema);
				colvarIsMain1.ColumnName = "IsMain1";
				colvarIsMain1.DataType = DbType.Int32;
				colvarIsMain1.MaxLength = 0;
				colvarIsMain1.AutoIncrement = false;
				colvarIsMain1.IsNullable = true;
				colvarIsMain1.IsPrimaryKey = false;
				colvarIsMain1.IsForeignKey = false;
				colvarIsMain1.IsReadOnly = false;
				colvarIsMain1.DefaultSetting = @"";
				colvarIsMain1.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIsMain1);
				
				TableSchema.TableColumn colvarIsMain2 = new TableSchema.TableColumn(schema);
				colvarIsMain2.ColumnName = "IsMain2";
				colvarIsMain2.DataType = DbType.Int32;
				colvarIsMain2.MaxLength = 0;
				colvarIsMain2.AutoIncrement = false;
				colvarIsMain2.IsNullable = true;
				colvarIsMain2.IsPrimaryKey = false;
				colvarIsMain2.IsForeignKey = false;
				colvarIsMain2.IsReadOnly = false;
				colvarIsMain2.DefaultSetting = @"";
				colvarIsMain2.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIsMain2);
				
				TableSchema.TableColumn colvarIsMain3 = new TableSchema.TableColumn(schema);
				colvarIsMain3.ColumnName = "IsMain3";
				colvarIsMain3.DataType = DbType.Int32;
				colvarIsMain3.MaxLength = 0;
				colvarIsMain3.AutoIncrement = false;
				colvarIsMain3.IsNullable = true;
				colvarIsMain3.IsPrimaryKey = false;
				colvarIsMain3.IsForeignKey = false;
				colvarIsMain3.IsReadOnly = false;
				colvarIsMain3.DefaultSetting = @"";
				colvarIsMain3.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIsMain3);
				
				TableSchema.TableColumn colvarIsNewCreate = new TableSchema.TableColumn(schema);
				colvarIsNewCreate.ColumnName = "IsNewCreate";
				colvarIsNewCreate.DataType = DbType.Int32;
				colvarIsNewCreate.MaxLength = 0;
				colvarIsNewCreate.AutoIncrement = false;
				colvarIsNewCreate.IsNullable = true;
				colvarIsNewCreate.IsPrimaryKey = false;
				colvarIsNewCreate.IsForeignKey = false;
				colvarIsNewCreate.IsReadOnly = false;
				colvarIsNewCreate.DefaultSetting = @"";
				colvarIsNewCreate.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIsNewCreate);
				
				TableSchema.TableColumn colvarToday = new TableSchema.TableColumn(schema);
				colvarToday.ColumnName = "Today";
				colvarToday.DataType = DbType.String;
				colvarToday.MaxLength = 50;
				colvarToday.AutoIncrement = false;
				colvarToday.IsNullable = true;
				colvarToday.IsPrimaryKey = false;
				colvarToday.IsForeignKey = false;
				colvarToday.IsReadOnly = false;
				colvarToday.DefaultSetting = @"";
				colvarToday.ForeignKeyTableName = "";
				schema.Columns.Add(colvarToday);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("ProjectExecute_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("ProjectExecuteId")]
		[Bindable(true)]
		public int ProjectExecuteId 
		{
			get { return GetColumnValue<int>(Columns.ProjectExecuteId); }
			set { SetColumnValue(Columns.ProjectExecuteId, value); }
		}
		  
		[XmlAttribute("ProjectExecuteTypeId")]
		[Bindable(true)]
		public int? ProjectExecuteTypeId 
		{
			get { return GetColumnValue<int?>(Columns.ProjectExecuteTypeId); }
			set { SetColumnValue(Columns.ProjectExecuteTypeId, value); }
		}
		  
		[XmlAttribute("MainProjectExecuteId")]
		[Bindable(true)]
		public int? MainProjectExecuteId 
		{
			get { return GetColumnValue<int?>(Columns.MainProjectExecuteId); }
			set { SetColumnValue(Columns.MainProjectExecuteId, value); }
		}
		  
		[XmlAttribute("ClientId")]
		[Bindable(true)]
		public int? ClientId 
		{
			get { return GetColumnValue<int?>(Columns.ClientId); }
			set { SetColumnValue(Columns.ClientId, value); }
		}
		  
		[XmlAttribute("RelateId")]
		[Bindable(true)]
		public int? RelateId 
		{
			get { return GetColumnValue<int?>(Columns.RelateId); }
			set { SetColumnValue(Columns.RelateId, value); }
		}
		  
		[XmlAttribute("ContractId")]
		[Bindable(true)]
		public int? ContractId 
		{
			get { return GetColumnValue<int?>(Columns.ContractId); }
			set { SetColumnValue(Columns.ContractId, value); }
		}
		  
		[XmlAttribute("MainProjectCreateId")]
		[Bindable(true)]
		public int? MainProjectCreateId 
		{
			get { return GetColumnValue<int?>(Columns.MainProjectCreateId); }
			set { SetColumnValue(Columns.MainProjectCreateId, value); }
		}
		  
		[XmlAttribute("WorkSheetNum")]
		[Bindable(true)]
		public string WorkSheetNum 
		{
			get { return GetColumnValue<string>(Columns.WorkSheetNum); }
			set { SetColumnValue(Columns.WorkSheetNum, value); }
		}
		  
		[XmlAttribute("SubmitPeople")]
		[Bindable(true)]
		public string SubmitPeople 
		{
			get { return GetColumnValue<string>(Columns.SubmitPeople); }
			set { SetColumnValue(Columns.SubmitPeople, value); }
		}
		  
		[XmlAttribute("OffSheetTime")]
		[Bindable(true)]
		public DateTime? OffSheetTime 
		{
			get { return GetColumnValue<DateTime?>(Columns.OffSheetTime); }
			set { SetColumnValue(Columns.OffSheetTime, value); }
		}
		  
		[XmlAttribute("OtherDescribe")]
		[Bindable(true)]
		public string OtherDescribe 
		{
			get { return GetColumnValue<string>(Columns.OtherDescribe); }
			set { SetColumnValue(Columns.OtherDescribe, value); }
		}
		  
		[XmlAttribute("TechRequire")]
		[Bindable(true)]
		public string TechRequire 
		{
			get { return GetColumnValue<string>(Columns.TechRequire); }
			set { SetColumnValue(Columns.TechRequire, value); }
		}
		  
		[XmlAttribute("OtherRequire")]
		[Bindable(true)]
		public string OtherRequire 
		{
			get { return GetColumnValue<string>(Columns.OtherRequire); }
			set { SetColumnValue(Columns.OtherRequire, value); }
		}
		  
		[XmlAttribute("TimeLimit")]
		[Bindable(true)]
		public DateTime? TimeLimit 
		{
			get { return GetColumnValue<DateTime?>(Columns.TimeLimit); }
			set { SetColumnValue(Columns.TimeLimit, value); }
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
		  
		[XmlAttribute("Others")]
		[Bindable(true)]
		public string Others 
		{
			get { return GetColumnValue<string>(Columns.Others); }
			set { SetColumnValue(Columns.Others, value); }
		}
		  
		[XmlAttribute("PreEmployeeId")]
		[Bindable(true)]
		public int? PreEmployeeId 
		{
			get { return GetColumnValue<int?>(Columns.PreEmployeeId); }
			set { SetColumnValue(Columns.PreEmployeeId, value); }
		}
		  
		[XmlAttribute("PreEmployeeName")]
		[Bindable(true)]
		public string PreEmployeeName 
		{
			get { return GetColumnValue<string>(Columns.PreEmployeeName); }
			set { SetColumnValue(Columns.PreEmployeeName, value); }
		}
		  
		[XmlAttribute("SendEmployeeId")]
		[Bindable(true)]
		public int? SendEmployeeId 
		{
			get { return GetColumnValue<int?>(Columns.SendEmployeeId); }
			set { SetColumnValue(Columns.SendEmployeeId, value); }
		}
		  
		[XmlAttribute("SendEmployeeName")]
		[Bindable(true)]
		public string SendEmployeeName 
		{
			get { return GetColumnValue<string>(Columns.SendEmployeeName); }
			set { SetColumnValue(Columns.SendEmployeeName, value); }
		}
		  
		[XmlAttribute("RecvEmployeeId")]
		[Bindable(true)]
		public int? RecvEmployeeId 
		{
			get { return GetColumnValue<int?>(Columns.RecvEmployeeId); }
			set { SetColumnValue(Columns.RecvEmployeeId, value); }
		}
		  
		[XmlAttribute("RecvEmployeeName")]
		[Bindable(true)]
		public string RecvEmployeeName 
		{
			get { return GetColumnValue<string>(Columns.RecvEmployeeName); }
			set { SetColumnValue(Columns.RecvEmployeeName, value); }
		}
		  
		[XmlAttribute("Recv1EmployeeId")]
		[Bindable(true)]
		public int? Recv1EmployeeId 
		{
			get { return GetColumnValue<int?>(Columns.Recv1EmployeeId); }
			set { SetColumnValue(Columns.Recv1EmployeeId, value); }
		}
		  
		[XmlAttribute("Recv1EmployeeName")]
		[Bindable(true)]
		public string Recv1EmployeeName 
		{
			get { return GetColumnValue<string>(Columns.Recv1EmployeeName); }
			set { SetColumnValue(Columns.Recv1EmployeeName, value); }
		}
		  
		[XmlAttribute("Recv2EmployeeId")]
		[Bindable(true)]
		public int? Recv2EmployeeId 
		{
			get { return GetColumnValue<int?>(Columns.Recv2EmployeeId); }
			set { SetColumnValue(Columns.Recv2EmployeeId, value); }
		}
		  
		[XmlAttribute("Recv2EmployeeName")]
		[Bindable(true)]
		public string Recv2EmployeeName 
		{
			get { return GetColumnValue<string>(Columns.Recv2EmployeeName); }
			set { SetColumnValue(Columns.Recv2EmployeeName, value); }
		}
		  
		[XmlAttribute("PreIsApply")]
		[Bindable(true)]
		public int? PreIsApply 
		{
			get { return GetColumnValue<int?>(Columns.PreIsApply); }
			set { SetColumnValue(Columns.PreIsApply, value); }
		}
		  
		[XmlAttribute("IsApprove")]
		[Bindable(true)]
		public int? IsApprove 
		{
			get { return GetColumnValue<int?>(Columns.IsApprove); }
			set { SetColumnValue(Columns.IsApprove, value); }
		}
		  
		[XmlAttribute("IsApply")]
		[Bindable(true)]
		public int? IsApply 
		{
			get { return GetColumnValue<int?>(Columns.IsApply); }
			set { SetColumnValue(Columns.IsApply, value); }
		}
		  
		[XmlAttribute("IsApply1")]
		[Bindable(true)]
		public int? IsApply1 
		{
			get { return GetColumnValue<int?>(Columns.IsApply1); }
			set { SetColumnValue(Columns.IsApply1, value); }
		}
		  
		[XmlAttribute("IsApply2")]
		[Bindable(true)]
		public int? IsApply2 
		{
			get { return GetColumnValue<int?>(Columns.IsApply2); }
			set { SetColumnValue(Columns.IsApply2, value); }
		}
		  
		[XmlAttribute("PreApplyTime")]
		[Bindable(true)]
		public DateTime? PreApplyTime 
		{
			get { return GetColumnValue<DateTime?>(Columns.PreApplyTime); }
			set { SetColumnValue(Columns.PreApplyTime, value); }
		}
		  
		[XmlAttribute("ApproveTime")]
		[Bindable(true)]
		public DateTime? ApproveTime 
		{
			get { return GetColumnValue<DateTime?>(Columns.ApproveTime); }
			set { SetColumnValue(Columns.ApproveTime, value); }
		}
		  
		[XmlAttribute("ApplyTime")]
		[Bindable(true)]
		public DateTime? ApplyTime 
		{
			get { return GetColumnValue<DateTime?>(Columns.ApplyTime); }
			set { SetColumnValue(Columns.ApplyTime, value); }
		}
		  
		[XmlAttribute("Apply1Time")]
		[Bindable(true)]
		public DateTime? Apply1Time 
		{
			get { return GetColumnValue<DateTime?>(Columns.Apply1Time); }
			set { SetColumnValue(Columns.Apply1Time, value); }
		}
		  
		[XmlAttribute("Apply2Time")]
		[Bindable(true)]
		public DateTime? Apply2Time 
		{
			get { return GetColumnValue<DateTime?>(Columns.Apply2Time); }
			set { SetColumnValue(Columns.Apply2Time, value); }
		}
		  
		[XmlAttribute("PreIsOver")]
		[Bindable(true)]
		public int? PreIsOver 
		{
			get { return GetColumnValue<int?>(Columns.PreIsOver); }
			set { SetColumnValue(Columns.PreIsOver, value); }
		}
		  
		[XmlAttribute("IsOver1")]
		[Bindable(true)]
		public int? IsOver1 
		{
			get { return GetColumnValue<int?>(Columns.IsOver1); }
			set { SetColumnValue(Columns.IsOver1, value); }
		}
		  
		[XmlAttribute("IsOver2")]
		[Bindable(true)]
		public int? IsOver2 
		{
			get { return GetColumnValue<int?>(Columns.IsOver2); }
			set { SetColumnValue(Columns.IsOver2, value); }
		}
		  
		[XmlAttribute("IsMain")]
		[Bindable(true)]
		public int? IsMain 
		{
			get { return GetColumnValue<int?>(Columns.IsMain); }
			set { SetColumnValue(Columns.IsMain, value); }
		}
		  
		[XmlAttribute("IsMain1")]
		[Bindable(true)]
		public int? IsMain1 
		{
			get { return GetColumnValue<int?>(Columns.IsMain1); }
			set { SetColumnValue(Columns.IsMain1, value); }
		}
		  
		[XmlAttribute("IsMain2")]
		[Bindable(true)]
		public int? IsMain2 
		{
			get { return GetColumnValue<int?>(Columns.IsMain2); }
			set { SetColumnValue(Columns.IsMain2, value); }
		}
		  
		[XmlAttribute("IsMain3")]
		[Bindable(true)]
		public int? IsMain3 
		{
			get { return GetColumnValue<int?>(Columns.IsMain3); }
			set { SetColumnValue(Columns.IsMain3, value); }
		}
		  
		[XmlAttribute("IsNewCreate")]
		[Bindable(true)]
		public int? IsNewCreate 
		{
			get { return GetColumnValue<int?>(Columns.IsNewCreate); }
			set { SetColumnValue(Columns.IsNewCreate, value); }
		}
		  
		[XmlAttribute("Today")]
		[Bindable(true)]
		public string Today 
		{
			get { return GetColumnValue<string>(Columns.Today); }
			set { SetColumnValue(Columns.Today, value); }
		}
		
		#endregion
		
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a WorkSheetType ActiveRecord object related to this ProjectExecute
		/// 
		/// </summary>
		public CanYou.OA.DAL.WorkSheetType WorkSheetType
		{
			get { return CanYou.OA.DAL.WorkSheetType.FetchByID(this.ProjectExecuteTypeId); }
			set { SetColumnValue("ProjectExecuteTypeId", value.WorkSheetTypeId); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int? varProjectExecuteTypeId,int? varMainProjectExecuteId,int? varClientId,int? varRelateId,int? varContractId,int? varMainProjectCreateId,string varWorkSheetNum,string varSubmitPeople,DateTime? varOffSheetTime,string varOtherDescribe,string varTechRequire,string varOtherRequire,DateTime? varTimeLimit,string varMarketView,string varTechView,string varOthers,int? varPreEmployeeId,string varPreEmployeeName,int? varSendEmployeeId,string varSendEmployeeName,int? varRecvEmployeeId,string varRecvEmployeeName,int? varRecv1EmployeeId,string varRecv1EmployeeName,int? varRecv2EmployeeId,string varRecv2EmployeeName,int? varPreIsApply,int? varIsApprove,int? varIsApply,int? varIsApply1,int? varIsApply2,DateTime? varPreApplyTime,DateTime? varApproveTime,DateTime? varApplyTime,DateTime? varApply1Time,DateTime? varApply2Time,int? varPreIsOver,int? varIsOver1,int? varIsOver2,int? varIsMain,int? varIsMain1,int? varIsMain2,int? varIsMain3,int? varIsNewCreate,string varToday)
		{
			ProjectExecute item = new ProjectExecute();
			
			item.ProjectExecuteTypeId = varProjectExecuteTypeId;
			
			item.MainProjectExecuteId = varMainProjectExecuteId;
			
			item.ClientId = varClientId;
			
			item.RelateId = varRelateId;
			
			item.ContractId = varContractId;
			
			item.MainProjectCreateId = varMainProjectCreateId;
			
			item.WorkSheetNum = varWorkSheetNum;
			
			item.SubmitPeople = varSubmitPeople;
			
			item.OffSheetTime = varOffSheetTime;
			
			item.OtherDescribe = varOtherDescribe;
			
			item.TechRequire = varTechRequire;
			
			item.OtherRequire = varOtherRequire;
			
			item.TimeLimit = varTimeLimit;
			
			item.MarketView = varMarketView;
			
			item.TechView = varTechView;
			
			item.Others = varOthers;
			
			item.PreEmployeeId = varPreEmployeeId;
			
			item.PreEmployeeName = varPreEmployeeName;
			
			item.SendEmployeeId = varSendEmployeeId;
			
			item.SendEmployeeName = varSendEmployeeName;
			
			item.RecvEmployeeId = varRecvEmployeeId;
			
			item.RecvEmployeeName = varRecvEmployeeName;
			
			item.Recv1EmployeeId = varRecv1EmployeeId;
			
			item.Recv1EmployeeName = varRecv1EmployeeName;
			
			item.Recv2EmployeeId = varRecv2EmployeeId;
			
			item.Recv2EmployeeName = varRecv2EmployeeName;
			
			item.PreIsApply = varPreIsApply;
			
			item.IsApprove = varIsApprove;
			
			item.IsApply = varIsApply;
			
			item.IsApply1 = varIsApply1;
			
			item.IsApply2 = varIsApply2;
			
			item.PreApplyTime = varPreApplyTime;
			
			item.ApproveTime = varApproveTime;
			
			item.ApplyTime = varApplyTime;
			
			item.Apply1Time = varApply1Time;
			
			item.Apply2Time = varApply2Time;
			
			item.PreIsOver = varPreIsOver;
			
			item.IsOver1 = varIsOver1;
			
			item.IsOver2 = varIsOver2;
			
			item.IsMain = varIsMain;
			
			item.IsMain1 = varIsMain1;
			
			item.IsMain2 = varIsMain2;
			
			item.IsMain3 = varIsMain3;
			
			item.IsNewCreate = varIsNewCreate;
			
			item.Today = varToday;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varProjectExecuteId,int? varProjectExecuteTypeId,int? varMainProjectExecuteId,int? varClientId,int? varRelateId,int? varContractId,int? varMainProjectCreateId,string varWorkSheetNum,string varSubmitPeople,DateTime? varOffSheetTime,string varOtherDescribe,string varTechRequire,string varOtherRequire,DateTime? varTimeLimit,string varMarketView,string varTechView,string varOthers,int? varPreEmployeeId,string varPreEmployeeName,int? varSendEmployeeId,string varSendEmployeeName,int? varRecvEmployeeId,string varRecvEmployeeName,int? varRecv1EmployeeId,string varRecv1EmployeeName,int? varRecv2EmployeeId,string varRecv2EmployeeName,int? varPreIsApply,int? varIsApprove,int? varIsApply,int? varIsApply1,int? varIsApply2,DateTime? varPreApplyTime,DateTime? varApproveTime,DateTime? varApplyTime,DateTime? varApply1Time,DateTime? varApply2Time,int? varPreIsOver,int? varIsOver1,int? varIsOver2,int? varIsMain,int? varIsMain1,int? varIsMain2,int? varIsMain3,int? varIsNewCreate,string varToday)
		{
			ProjectExecute item = new ProjectExecute();
			
				item.ProjectExecuteId = varProjectExecuteId;
			
				item.ProjectExecuteTypeId = varProjectExecuteTypeId;
			
				item.MainProjectExecuteId = varMainProjectExecuteId;
			
				item.ClientId = varClientId;
			
				item.RelateId = varRelateId;
			
				item.ContractId = varContractId;
			
				item.MainProjectCreateId = varMainProjectCreateId;
			
				item.WorkSheetNum = varWorkSheetNum;
			
				item.SubmitPeople = varSubmitPeople;
			
				item.OffSheetTime = varOffSheetTime;
			
				item.OtherDescribe = varOtherDescribe;
			
				item.TechRequire = varTechRequire;
			
				item.OtherRequire = varOtherRequire;
			
				item.TimeLimit = varTimeLimit;
			
				item.MarketView = varMarketView;
			
				item.TechView = varTechView;
			
				item.Others = varOthers;
			
				item.PreEmployeeId = varPreEmployeeId;
			
				item.PreEmployeeName = varPreEmployeeName;
			
				item.SendEmployeeId = varSendEmployeeId;
			
				item.SendEmployeeName = varSendEmployeeName;
			
				item.RecvEmployeeId = varRecvEmployeeId;
			
				item.RecvEmployeeName = varRecvEmployeeName;
			
				item.Recv1EmployeeId = varRecv1EmployeeId;
			
				item.Recv1EmployeeName = varRecv1EmployeeName;
			
				item.Recv2EmployeeId = varRecv2EmployeeId;
			
				item.Recv2EmployeeName = varRecv2EmployeeName;
			
				item.PreIsApply = varPreIsApply;
			
				item.IsApprove = varIsApprove;
			
				item.IsApply = varIsApply;
			
				item.IsApply1 = varIsApply1;
			
				item.IsApply2 = varIsApply2;
			
				item.PreApplyTime = varPreApplyTime;
			
				item.ApproveTime = varApproveTime;
			
				item.ApplyTime = varApplyTime;
			
				item.Apply1Time = varApply1Time;
			
				item.Apply2Time = varApply2Time;
			
				item.PreIsOver = varPreIsOver;
			
				item.IsOver1 = varIsOver1;
			
				item.IsOver2 = varIsOver2;
			
				item.IsMain = varIsMain;
			
				item.IsMain1 = varIsMain1;
			
				item.IsMain2 = varIsMain2;
			
				item.IsMain3 = varIsMain3;
			
				item.IsNewCreate = varIsNewCreate;
			
				item.Today = varToday;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn ProjectExecuteIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ProjectExecuteTypeIdColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn MainProjectExecuteIdColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn ClientIdColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn RelateIdColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn ContractIdColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn MainProjectCreateIdColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn WorkSheetNumColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn SubmitPeopleColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn OffSheetTimeColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn OtherDescribeColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn TechRequireColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn OtherRequireColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn TimeLimitColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn MarketViewColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn TechViewColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn OthersColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn PreEmployeeIdColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn PreEmployeeNameColumn
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn SendEmployeeIdColumn
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        public static TableSchema.TableColumn SendEmployeeNameColumn
        {
            get { return Schema.Columns[20]; }
        }
        
        
        
        public static TableSchema.TableColumn RecvEmployeeIdColumn
        {
            get { return Schema.Columns[21]; }
        }
        
        
        
        public static TableSchema.TableColumn RecvEmployeeNameColumn
        {
            get { return Schema.Columns[22]; }
        }
        
        
        
        public static TableSchema.TableColumn Recv1EmployeeIdColumn
        {
            get { return Schema.Columns[23]; }
        }
        
        
        
        public static TableSchema.TableColumn Recv1EmployeeNameColumn
        {
            get { return Schema.Columns[24]; }
        }
        
        
        
        public static TableSchema.TableColumn Recv2EmployeeIdColumn
        {
            get { return Schema.Columns[25]; }
        }
        
        
        
        public static TableSchema.TableColumn Recv2EmployeeNameColumn
        {
            get { return Schema.Columns[26]; }
        }
        
        
        
        public static TableSchema.TableColumn PreIsApplyColumn
        {
            get { return Schema.Columns[27]; }
        }
        
        
        
        public static TableSchema.TableColumn IsApproveColumn
        {
            get { return Schema.Columns[28]; }
        }
        
        
        
        public static TableSchema.TableColumn IsApplyColumn
        {
            get { return Schema.Columns[29]; }
        }
        
        
        
        public static TableSchema.TableColumn IsApply1Column
        {
            get { return Schema.Columns[30]; }
        }
        
        
        
        public static TableSchema.TableColumn IsApply2Column
        {
            get { return Schema.Columns[31]; }
        }
        
        
        
        public static TableSchema.TableColumn PreApplyTimeColumn
        {
            get { return Schema.Columns[32]; }
        }
        
        
        
        public static TableSchema.TableColumn ApproveTimeColumn
        {
            get { return Schema.Columns[33]; }
        }
        
        
        
        public static TableSchema.TableColumn ApplyTimeColumn
        {
            get { return Schema.Columns[34]; }
        }
        
        
        
        public static TableSchema.TableColumn Apply1TimeColumn
        {
            get { return Schema.Columns[35]; }
        }
        
        
        
        public static TableSchema.TableColumn Apply2TimeColumn
        {
            get { return Schema.Columns[36]; }
        }
        
        
        
        public static TableSchema.TableColumn PreIsOverColumn
        {
            get { return Schema.Columns[37]; }
        }
        
        
        
        public static TableSchema.TableColumn IsOver1Column
        {
            get { return Schema.Columns[38]; }
        }
        
        
        
        public static TableSchema.TableColumn IsOver2Column
        {
            get { return Schema.Columns[39]; }
        }
        
        
        
        public static TableSchema.TableColumn IsMainColumn
        {
            get { return Schema.Columns[40]; }
        }
        
        
        
        public static TableSchema.TableColumn IsMain1Column
        {
            get { return Schema.Columns[41]; }
        }
        
        
        
        public static TableSchema.TableColumn IsMain2Column
        {
            get { return Schema.Columns[42]; }
        }
        
        
        
        public static TableSchema.TableColumn IsMain3Column
        {
            get { return Schema.Columns[43]; }
        }
        
        
        
        public static TableSchema.TableColumn IsNewCreateColumn
        {
            get { return Schema.Columns[44]; }
        }
        
        
        
        public static TableSchema.TableColumn TodayColumn
        {
            get { return Schema.Columns[45]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string ProjectExecuteId = @"ProjectExecuteId";
			 public static string ProjectExecuteTypeId = @"ProjectExecuteTypeId";
			 public static string MainProjectExecuteId = @"MainProjectExecuteId";
			 public static string ClientId = @"ClientId";
			 public static string RelateId = @"RelateId";
			 public static string ContractId = @"ContractId";
			 public static string MainProjectCreateId = @"MainProjectCreateId";
			 public static string WorkSheetNum = @"WorkSheetNum";
			 public static string SubmitPeople = @"SubmitPeople";
			 public static string OffSheetTime = @"OffSheetTime";
			 public static string OtherDescribe = @"OtherDescribe";
			 public static string TechRequire = @"TechRequire";
			 public static string OtherRequire = @"OtherRequire";
			 public static string TimeLimit = @"TimeLimit";
			 public static string MarketView = @"MarketView";
			 public static string TechView = @"TechView";
			 public static string Others = @"Others";
			 public static string PreEmployeeId = @"PreEmployeeId";
			 public static string PreEmployeeName = @"PreEmployeeName";
			 public static string SendEmployeeId = @"SendEmployeeId";
			 public static string SendEmployeeName = @"SendEmployeeName";
			 public static string RecvEmployeeId = @"RecvEmployeeId";
			 public static string RecvEmployeeName = @"RecvEmployeeName";
			 public static string Recv1EmployeeId = @"Recv1EmployeeId";
			 public static string Recv1EmployeeName = @"Recv1EmployeeName";
			 public static string Recv2EmployeeId = @"Recv2EmployeeId";
			 public static string Recv2EmployeeName = @"Recv2EmployeeName";
			 public static string PreIsApply = @"PreIsApply";
			 public static string IsApprove = @"IsApprove";
			 public static string IsApply = @"IsApply";
			 public static string IsApply1 = @"IsApply1";
			 public static string IsApply2 = @"IsApply2";
			 public static string PreApplyTime = @"PreApplyTime";
			 public static string ApproveTime = @"ApproveTime";
			 public static string ApplyTime = @"ApplyTime";
			 public static string Apply1Time = @"Apply1Time";
			 public static string Apply2Time = @"Apply2Time";
			 public static string PreIsOver = @"PreIsOver";
			 public static string IsOver1 = @"IsOver1";
			 public static string IsOver2 = @"IsOver2";
			 public static string IsMain = @"IsMain";
			 public static string IsMain1 = @"IsMain1";
			 public static string IsMain2 = @"IsMain2";
			 public static string IsMain3 = @"IsMain3";
			 public static string IsNewCreate = @"IsNewCreate";
			 public static string Today = @"Today";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
