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
	/// Strongly-typed collection for the SpecialExp class.
	/// </summary>
    [Serializable]
	public partial class SpecialExpCollection : ActiveList<SpecialExp, SpecialExpCollection>
	{	   
		public SpecialExpCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>SpecialExpCollection</returns>
		public SpecialExpCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                SpecialExp o = this[i];
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
	/// This is an ActiveRecord class which wraps the SpecialExp_tb table.
	/// </summary>
	[Serializable]
	public partial class SpecialExp : ActiveRecord<SpecialExp>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public SpecialExp()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public SpecialExp(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public SpecialExp(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public SpecialExp(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("SpecialExp_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarSpecialExpId = new TableSchema.TableColumn(schema);
				colvarSpecialExpId.ColumnName = "SpecialExpId";
				colvarSpecialExpId.DataType = DbType.Int32;
				colvarSpecialExpId.MaxLength = 0;
				colvarSpecialExpId.AutoIncrement = true;
				colvarSpecialExpId.IsNullable = false;
				colvarSpecialExpId.IsPrimaryKey = true;
				colvarSpecialExpId.IsForeignKey = false;
				colvarSpecialExpId.IsReadOnly = false;
				colvarSpecialExpId.DefaultSetting = @"";
				colvarSpecialExpId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSpecialExpId);
				
				TableSchema.TableColumn colvarMainSpecialExpId = new TableSchema.TableColumn(schema);
				colvarMainSpecialExpId.ColumnName = "MainSpecialExpId";
				colvarMainSpecialExpId.DataType = DbType.Int32;
				colvarMainSpecialExpId.MaxLength = 0;
				colvarMainSpecialExpId.AutoIncrement = false;
				colvarMainSpecialExpId.IsNullable = true;
				colvarMainSpecialExpId.IsPrimaryKey = false;
				colvarMainSpecialExpId.IsForeignKey = false;
				colvarMainSpecialExpId.IsReadOnly = false;
				colvarMainSpecialExpId.DefaultSetting = @"";
				colvarMainSpecialExpId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMainSpecialExpId);
				
				TableSchema.TableColumn colvarProjectStepId = new TableSchema.TableColumn(schema);
				colvarProjectStepId.ColumnName = "ProjectStepId";
				colvarProjectStepId.DataType = DbType.Int32;
				colvarProjectStepId.MaxLength = 0;
				colvarProjectStepId.AutoIncrement = false;
				colvarProjectStepId.IsNullable = true;
				colvarProjectStepId.IsPrimaryKey = false;
				colvarProjectStepId.IsForeignKey = false;
				colvarProjectStepId.IsReadOnly = false;
				colvarProjectStepId.DefaultSetting = @"";
				colvarProjectStepId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProjectStepId);
				
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
				
				TableSchema.TableColumn colvarApplyPeople = new TableSchema.TableColumn(schema);
				colvarApplyPeople.ColumnName = "ApplyPeople";
				colvarApplyPeople.DataType = DbType.String;
				colvarApplyPeople.MaxLength = 50;
				colvarApplyPeople.AutoIncrement = false;
				colvarApplyPeople.IsNullable = true;
				colvarApplyPeople.IsPrimaryKey = false;
				colvarApplyPeople.IsForeignKey = false;
				colvarApplyPeople.IsReadOnly = false;
				colvarApplyPeople.DefaultSetting = @"";
				colvarApplyPeople.ForeignKeyTableName = "";
				schema.Columns.Add(colvarApplyPeople);
				
				TableSchema.TableColumn colvarApplyDate = new TableSchema.TableColumn(schema);
				colvarApplyDate.ColumnName = "ApplyDate";
				colvarApplyDate.DataType = DbType.DateTime;
				colvarApplyDate.MaxLength = 0;
				colvarApplyDate.AutoIncrement = false;
				colvarApplyDate.IsNullable = true;
				colvarApplyDate.IsPrimaryKey = false;
				colvarApplyDate.IsForeignKey = false;
				colvarApplyDate.IsReadOnly = false;
				colvarApplyDate.DefaultSetting = @"";
				colvarApplyDate.ForeignKeyTableName = "";
				schema.Columns.Add(colvarApplyDate);
				
				TableSchema.TableColumn colvarApplyReason = new TableSchema.TableColumn(schema);
				colvarApplyReason.ColumnName = "ApplyReason";
				colvarApplyReason.DataType = DbType.String;
				colvarApplyReason.MaxLength = 50;
				colvarApplyReason.AutoIncrement = false;
				colvarApplyReason.IsNullable = true;
				colvarApplyReason.IsPrimaryKey = false;
				colvarApplyReason.IsForeignKey = false;
				colvarApplyReason.IsReadOnly = false;
				colvarApplyReason.DefaultSetting = @"";
				colvarApplyReason.ForeignKeyTableName = "";
				schema.Columns.Add(colvarApplyReason);
				
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
				
				TableSchema.TableColumn colvarApplyMoney = new TableSchema.TableColumn(schema);
				colvarApplyMoney.ColumnName = "ApplyMoney";
				colvarApplyMoney.DataType = DbType.String;
				colvarApplyMoney.MaxLength = 50;
				colvarApplyMoney.AutoIncrement = false;
				colvarApplyMoney.IsNullable = true;
				colvarApplyMoney.IsPrimaryKey = false;
				colvarApplyMoney.IsForeignKey = false;
				colvarApplyMoney.IsReadOnly = false;
				colvarApplyMoney.DefaultSetting = @"";
				colvarApplyMoney.ForeignKeyTableName = "";
				schema.Columns.Add(colvarApplyMoney);
				
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
				
				TableSchema.TableColumn colvarSignName = new TableSchema.TableColumn(schema);
				colvarSignName.ColumnName = "SignName";
				colvarSignName.DataType = DbType.Int32;
				colvarSignName.MaxLength = 0;
				colvarSignName.AutoIncrement = false;
				colvarSignName.IsNullable = true;
				colvarSignName.IsPrimaryKey = false;
				colvarSignName.IsForeignKey = false;
				colvarSignName.IsReadOnly = false;
				colvarSignName.DefaultSetting = @"";
				colvarSignName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSignName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("SpecialExp_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("SpecialExpId")]
		[Bindable(true)]
		public int SpecialExpId 
		{
			get { return GetColumnValue<int>(Columns.SpecialExpId); }
			set { SetColumnValue(Columns.SpecialExpId, value); }
		}
		  
		[XmlAttribute("MainSpecialExpId")]
		[Bindable(true)]
		public int? MainSpecialExpId 
		{
			get { return GetColumnValue<int?>(Columns.MainSpecialExpId); }
			set { SetColumnValue(Columns.MainSpecialExpId, value); }
		}
		  
		[XmlAttribute("ProjectStepId")]
		[Bindable(true)]
		public int? ProjectStepId 
		{
			get { return GetColumnValue<int?>(Columns.ProjectStepId); }
			set { SetColumnValue(Columns.ProjectStepId, value); }
		}
		  
		[XmlAttribute("MainProjectCreateId")]
		[Bindable(true)]
		public int? MainProjectCreateId 
		{
			get { return GetColumnValue<int?>(Columns.MainProjectCreateId); }
			set { SetColumnValue(Columns.MainProjectCreateId, value); }
		}
		  
		[XmlAttribute("SheetNum")]
		[Bindable(true)]
		public string SheetNum 
		{
			get { return GetColumnValue<string>(Columns.SheetNum); }
			set { SetColumnValue(Columns.SheetNum, value); }
		}
		  
		[XmlAttribute("ApplyPeople")]
		[Bindable(true)]
		public string ApplyPeople 
		{
			get { return GetColumnValue<string>(Columns.ApplyPeople); }
			set { SetColumnValue(Columns.ApplyPeople, value); }
		}
		  
		[XmlAttribute("ApplyDate")]
		[Bindable(true)]
		public DateTime? ApplyDate 
		{
			get { return GetColumnValue<DateTime?>(Columns.ApplyDate); }
			set { SetColumnValue(Columns.ApplyDate, value); }
		}
		  
		[XmlAttribute("ApplyReason")]
		[Bindable(true)]
		public string ApplyReason 
		{
			get { return GetColumnValue<string>(Columns.ApplyReason); }
			set { SetColumnValue(Columns.ApplyReason, value); }
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
		  
		[XmlAttribute("PreEmployeeId")]
		[Bindable(true)]
		public int? PreEmployeeId 
		{
			get { return GetColumnValue<int?>(Columns.PreEmployeeId); }
			set { SetColumnValue(Columns.PreEmployeeId, value); }
		}
		  
		[XmlAttribute("SendEmployeeId")]
		[Bindable(true)]
		public int? SendEmployeeId 
		{
			get { return GetColumnValue<int?>(Columns.SendEmployeeId); }
			set { SetColumnValue(Columns.SendEmployeeId, value); }
		}
		  
		[XmlAttribute("RecvEmployeeId")]
		[Bindable(true)]
		public int? RecvEmployeeId 
		{
			get { return GetColumnValue<int?>(Columns.RecvEmployeeId); }
			set { SetColumnValue(Columns.RecvEmployeeId, value); }
		}
		  
		[XmlAttribute("Recv1EmployeeId")]
		[Bindable(true)]
		public int? Recv1EmployeeId 
		{
			get { return GetColumnValue<int?>(Columns.Recv1EmployeeId); }
			set { SetColumnValue(Columns.Recv1EmployeeId, value); }
		}
		  
		[XmlAttribute("Recv2EmployeeId")]
		[Bindable(true)]
		public int? Recv2EmployeeId 
		{
			get { return GetColumnValue<int?>(Columns.Recv2EmployeeId); }
			set { SetColumnValue(Columns.Recv2EmployeeId, value); }
		}
		  
		[XmlAttribute("PreEmployeeName")]
		[Bindable(true)]
		public string PreEmployeeName 
		{
			get { return GetColumnValue<string>(Columns.PreEmployeeName); }
			set { SetColumnValue(Columns.PreEmployeeName, value); }
		}
		  
		[XmlAttribute("SendEmployeeName")]
		[Bindable(true)]
		public string SendEmployeeName 
		{
			get { return GetColumnValue<string>(Columns.SendEmployeeName); }
			set { SetColumnValue(Columns.SendEmployeeName, value); }
		}
		  
		[XmlAttribute("RecvEmployeeName")]
		[Bindable(true)]
		public string RecvEmployeeName 
		{
			get { return GetColumnValue<string>(Columns.RecvEmployeeName); }
			set { SetColumnValue(Columns.RecvEmployeeName, value); }
		}
		  
		[XmlAttribute("Recv1EmployeeName")]
		[Bindable(true)]
		public string Recv1EmployeeName 
		{
			get { return GetColumnValue<string>(Columns.Recv1EmployeeName); }
			set { SetColumnValue(Columns.Recv1EmployeeName, value); }
		}
		  
		[XmlAttribute("Recv2EmployeeName")]
		[Bindable(true)]
		public string Recv2EmployeeName 
		{
			get { return GetColumnValue<string>(Columns.Recv2EmployeeName); }
			set { SetColumnValue(Columns.Recv2EmployeeName, value); }
		}
		  
		[XmlAttribute("IsNewCreate")]
		[Bindable(true)]
		public int? IsNewCreate 
		{
			get { return GetColumnValue<int?>(Columns.IsNewCreate); }
			set { SetColumnValue(Columns.IsNewCreate, value); }
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
		  
		[XmlAttribute("ApplyMoney")]
		[Bindable(true)]
		public string ApplyMoney 
		{
			get { return GetColumnValue<string>(Columns.ApplyMoney); }
			set { SetColumnValue(Columns.ApplyMoney, value); }
		}
		  
		[XmlAttribute("Today")]
		[Bindable(true)]
		public string Today 
		{
			get { return GetColumnValue<string>(Columns.Today); }
			set { SetColumnValue(Columns.Today, value); }
		}
		  
		[XmlAttribute("SignName")]
		[Bindable(true)]
		public int? SignName 
		{
			get { return GetColumnValue<int?>(Columns.SignName); }
			set { SetColumnValue(Columns.SignName, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int? varMainSpecialExpId,int? varProjectStepId,int? varMainProjectCreateId,string varSheetNum,string varApplyPeople,DateTime? varApplyDate,string varApplyReason,int? varPreIsApply,int? varIsApprove,int? varIsApply,int? varIsApply1,int? varIsApply2,int? varPreIsOver,int? varIsOver1,int? varIsOver2,DateTime? varPreApplyTime,DateTime? varApproveTime,DateTime? varApplyTime,DateTime? varApply1Time,DateTime? varApply2Time,int? varPreEmployeeId,int? varSendEmployeeId,int? varRecvEmployeeId,int? varRecv1EmployeeId,int? varRecv2EmployeeId,string varPreEmployeeName,string varSendEmployeeName,string varRecvEmployeeName,string varRecv1EmployeeName,string varRecv2EmployeeName,int? varIsNewCreate,int? varIsMain,int? varIsMain1,int? varIsMain2,int? varIsMain3,string varApplyMoney,string varToday,int? varSignName)
		{
			SpecialExp item = new SpecialExp();
			
			item.MainSpecialExpId = varMainSpecialExpId;
			
			item.ProjectStepId = varProjectStepId;
			
			item.MainProjectCreateId = varMainProjectCreateId;
			
			item.SheetNum = varSheetNum;
			
			item.ApplyPeople = varApplyPeople;
			
			item.ApplyDate = varApplyDate;
			
			item.ApplyReason = varApplyReason;
			
			item.PreIsApply = varPreIsApply;
			
			item.IsApprove = varIsApprove;
			
			item.IsApply = varIsApply;
			
			item.IsApply1 = varIsApply1;
			
			item.IsApply2 = varIsApply2;
			
			item.PreIsOver = varPreIsOver;
			
			item.IsOver1 = varIsOver1;
			
			item.IsOver2 = varIsOver2;
			
			item.PreApplyTime = varPreApplyTime;
			
			item.ApproveTime = varApproveTime;
			
			item.ApplyTime = varApplyTime;
			
			item.Apply1Time = varApply1Time;
			
			item.Apply2Time = varApply2Time;
			
			item.PreEmployeeId = varPreEmployeeId;
			
			item.SendEmployeeId = varSendEmployeeId;
			
			item.RecvEmployeeId = varRecvEmployeeId;
			
			item.Recv1EmployeeId = varRecv1EmployeeId;
			
			item.Recv2EmployeeId = varRecv2EmployeeId;
			
			item.PreEmployeeName = varPreEmployeeName;
			
			item.SendEmployeeName = varSendEmployeeName;
			
			item.RecvEmployeeName = varRecvEmployeeName;
			
			item.Recv1EmployeeName = varRecv1EmployeeName;
			
			item.Recv2EmployeeName = varRecv2EmployeeName;
			
			item.IsNewCreate = varIsNewCreate;
			
			item.IsMain = varIsMain;
			
			item.IsMain1 = varIsMain1;
			
			item.IsMain2 = varIsMain2;
			
			item.IsMain3 = varIsMain3;
			
			item.ApplyMoney = varApplyMoney;
			
			item.Today = varToday;
			
			item.SignName = varSignName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varSpecialExpId,int? varMainSpecialExpId,int? varProjectStepId,int? varMainProjectCreateId,string varSheetNum,string varApplyPeople,DateTime? varApplyDate,string varApplyReason,int? varPreIsApply,int? varIsApprove,int? varIsApply,int? varIsApply1,int? varIsApply2,int? varPreIsOver,int? varIsOver1,int? varIsOver2,DateTime? varPreApplyTime,DateTime? varApproveTime,DateTime? varApplyTime,DateTime? varApply1Time,DateTime? varApply2Time,int? varPreEmployeeId,int? varSendEmployeeId,int? varRecvEmployeeId,int? varRecv1EmployeeId,int? varRecv2EmployeeId,string varPreEmployeeName,string varSendEmployeeName,string varRecvEmployeeName,string varRecv1EmployeeName,string varRecv2EmployeeName,int? varIsNewCreate,int? varIsMain,int? varIsMain1,int? varIsMain2,int? varIsMain3,string varApplyMoney,string varToday,int? varSignName)
		{
			SpecialExp item = new SpecialExp();
			
				item.SpecialExpId = varSpecialExpId;
			
				item.MainSpecialExpId = varMainSpecialExpId;
			
				item.ProjectStepId = varProjectStepId;
			
				item.MainProjectCreateId = varMainProjectCreateId;
			
				item.SheetNum = varSheetNum;
			
				item.ApplyPeople = varApplyPeople;
			
				item.ApplyDate = varApplyDate;
			
				item.ApplyReason = varApplyReason;
			
				item.PreIsApply = varPreIsApply;
			
				item.IsApprove = varIsApprove;
			
				item.IsApply = varIsApply;
			
				item.IsApply1 = varIsApply1;
			
				item.IsApply2 = varIsApply2;
			
				item.PreIsOver = varPreIsOver;
			
				item.IsOver1 = varIsOver1;
			
				item.IsOver2 = varIsOver2;
			
				item.PreApplyTime = varPreApplyTime;
			
				item.ApproveTime = varApproveTime;
			
				item.ApplyTime = varApplyTime;
			
				item.Apply1Time = varApply1Time;
			
				item.Apply2Time = varApply2Time;
			
				item.PreEmployeeId = varPreEmployeeId;
			
				item.SendEmployeeId = varSendEmployeeId;
			
				item.RecvEmployeeId = varRecvEmployeeId;
			
				item.Recv1EmployeeId = varRecv1EmployeeId;
			
				item.Recv2EmployeeId = varRecv2EmployeeId;
			
				item.PreEmployeeName = varPreEmployeeName;
			
				item.SendEmployeeName = varSendEmployeeName;
			
				item.RecvEmployeeName = varRecvEmployeeName;
			
				item.Recv1EmployeeName = varRecv1EmployeeName;
			
				item.Recv2EmployeeName = varRecv2EmployeeName;
			
				item.IsNewCreate = varIsNewCreate;
			
				item.IsMain = varIsMain;
			
				item.IsMain1 = varIsMain1;
			
				item.IsMain2 = varIsMain2;
			
				item.IsMain3 = varIsMain3;
			
				item.ApplyMoney = varApplyMoney;
			
				item.Today = varToday;
			
				item.SignName = varSignName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn SpecialExpIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn MainSpecialExpIdColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn ProjectStepIdColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn MainProjectCreateIdColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn SheetNumColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn ApplyPeopleColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn ApplyDateColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn ApplyReasonColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn PreIsApplyColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn IsApproveColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn IsApplyColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn IsApply1Column
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn IsApply2Column
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn PreIsOverColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn IsOver1Column
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn IsOver2Column
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn PreApplyTimeColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn ApproveTimeColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn ApplyTimeColumn
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn Apply1TimeColumn
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        public static TableSchema.TableColumn Apply2TimeColumn
        {
            get { return Schema.Columns[20]; }
        }
        
        
        
        public static TableSchema.TableColumn PreEmployeeIdColumn
        {
            get { return Schema.Columns[21]; }
        }
        
        
        
        public static TableSchema.TableColumn SendEmployeeIdColumn
        {
            get { return Schema.Columns[22]; }
        }
        
        
        
        public static TableSchema.TableColumn RecvEmployeeIdColumn
        {
            get { return Schema.Columns[23]; }
        }
        
        
        
        public static TableSchema.TableColumn Recv1EmployeeIdColumn
        {
            get { return Schema.Columns[24]; }
        }
        
        
        
        public static TableSchema.TableColumn Recv2EmployeeIdColumn
        {
            get { return Schema.Columns[25]; }
        }
        
        
        
        public static TableSchema.TableColumn PreEmployeeNameColumn
        {
            get { return Schema.Columns[26]; }
        }
        
        
        
        public static TableSchema.TableColumn SendEmployeeNameColumn
        {
            get { return Schema.Columns[27]; }
        }
        
        
        
        public static TableSchema.TableColumn RecvEmployeeNameColumn
        {
            get { return Schema.Columns[28]; }
        }
        
        
        
        public static TableSchema.TableColumn Recv1EmployeeNameColumn
        {
            get { return Schema.Columns[29]; }
        }
        
        
        
        public static TableSchema.TableColumn Recv2EmployeeNameColumn
        {
            get { return Schema.Columns[30]; }
        }
        
        
        
        public static TableSchema.TableColumn IsNewCreateColumn
        {
            get { return Schema.Columns[31]; }
        }
        
        
        
        public static TableSchema.TableColumn IsMainColumn
        {
            get { return Schema.Columns[32]; }
        }
        
        
        
        public static TableSchema.TableColumn IsMain1Column
        {
            get { return Schema.Columns[33]; }
        }
        
        
        
        public static TableSchema.TableColumn IsMain2Column
        {
            get { return Schema.Columns[34]; }
        }
        
        
        
        public static TableSchema.TableColumn IsMain3Column
        {
            get { return Schema.Columns[35]; }
        }
        
        
        
        public static TableSchema.TableColumn ApplyMoneyColumn
        {
            get { return Schema.Columns[36]; }
        }
        
        
        
        public static TableSchema.TableColumn TodayColumn
        {
            get { return Schema.Columns[37]; }
        }
        
        
        
        public static TableSchema.TableColumn SignNameColumn
        {
            get { return Schema.Columns[38]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string SpecialExpId = @"SpecialExpId";
			 public static string MainSpecialExpId = @"MainSpecialExpId";
			 public static string ProjectStepId = @"ProjectStepId";
			 public static string MainProjectCreateId = @"MainProjectCreateId";
			 public static string SheetNum = @"SheetNum";
			 public static string ApplyPeople = @"ApplyPeople";
			 public static string ApplyDate = @"ApplyDate";
			 public static string ApplyReason = @"ApplyReason";
			 public static string PreIsApply = @"PreIsApply";
			 public static string IsApprove = @"IsApprove";
			 public static string IsApply = @"IsApply";
			 public static string IsApply1 = @"IsApply1";
			 public static string IsApply2 = @"IsApply2";
			 public static string PreIsOver = @"PreIsOver";
			 public static string IsOver1 = @"IsOver1";
			 public static string IsOver2 = @"IsOver2";
			 public static string PreApplyTime = @"PreApplyTime";
			 public static string ApproveTime = @"ApproveTime";
			 public static string ApplyTime = @"ApplyTime";
			 public static string Apply1Time = @"Apply1Time";
			 public static string Apply2Time = @"Apply2Time";
			 public static string PreEmployeeId = @"PreEmployeeId";
			 public static string SendEmployeeId = @"SendEmployeeId";
			 public static string RecvEmployeeId = @"RecvEmployeeId";
			 public static string Recv1EmployeeId = @"Recv1EmployeeId";
			 public static string Recv2EmployeeId = @"Recv2EmployeeId";
			 public static string PreEmployeeName = @"PreEmployeeName";
			 public static string SendEmployeeName = @"SendEmployeeName";
			 public static string RecvEmployeeName = @"RecvEmployeeName";
			 public static string Recv1EmployeeName = @"Recv1EmployeeName";
			 public static string Recv2EmployeeName = @"Recv2EmployeeName";
			 public static string IsNewCreate = @"IsNewCreate";
			 public static string IsMain = @"IsMain";
			 public static string IsMain1 = @"IsMain1";
			 public static string IsMain2 = @"IsMain2";
			 public static string IsMain3 = @"IsMain3";
			 public static string ApplyMoney = @"ApplyMoney";
			 public static string Today = @"Today";
			 public static string SignName = @"SignName";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
