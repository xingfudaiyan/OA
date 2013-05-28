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
	/// Strongly-typed collection for the OfferPrice class.
	/// </summary>
    [Serializable]
	public partial class OfferPriceCollection : ActiveList<OfferPrice, OfferPriceCollection>
	{	   
		public OfferPriceCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>OfferPriceCollection</returns>
		public OfferPriceCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                OfferPrice o = this[i];
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
	/// This is an ActiveRecord class which wraps the OfferPrice_tb table.
	/// </summary>
	[Serializable]
	public partial class OfferPrice : ActiveRecord<OfferPrice>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public OfferPrice()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public OfferPrice(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public OfferPrice(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public OfferPrice(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("OfferPrice_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarOfferPriceId = new TableSchema.TableColumn(schema);
				colvarOfferPriceId.ColumnName = "OfferPriceId";
				colvarOfferPriceId.DataType = DbType.Int32;
				colvarOfferPriceId.MaxLength = 0;
				colvarOfferPriceId.AutoIncrement = true;
				colvarOfferPriceId.IsNullable = false;
				colvarOfferPriceId.IsPrimaryKey = true;
				colvarOfferPriceId.IsForeignKey = false;
				colvarOfferPriceId.IsReadOnly = false;
				colvarOfferPriceId.DefaultSetting = @"";
				colvarOfferPriceId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOfferPriceId);
				
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
				
				TableSchema.TableColumn colvarMainOfferPriceId = new TableSchema.TableColumn(schema);
				colvarMainOfferPriceId.ColumnName = "MainOfferPriceId";
				colvarMainOfferPriceId.DataType = DbType.Int32;
				colvarMainOfferPriceId.MaxLength = 0;
				colvarMainOfferPriceId.AutoIncrement = false;
				colvarMainOfferPriceId.IsNullable = true;
				colvarMainOfferPriceId.IsPrimaryKey = false;
				colvarMainOfferPriceId.IsForeignKey = false;
				colvarMainOfferPriceId.IsReadOnly = false;
				colvarMainOfferPriceId.DefaultSetting = @"";
				colvarMainOfferPriceId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMainOfferPriceId);
				
				TableSchema.TableColumn colvarProjectDes = new TableSchema.TableColumn(schema);
				colvarProjectDes.ColumnName = "ProjectDes";
				colvarProjectDes.DataType = DbType.String;
				colvarProjectDes.MaxLength = 50;
				colvarProjectDes.AutoIncrement = false;
				colvarProjectDes.IsNullable = true;
				colvarProjectDes.IsPrimaryKey = false;
				colvarProjectDes.IsForeignKey = false;
				colvarProjectDes.IsReadOnly = false;
				colvarProjectDes.DefaultSetting = @"";
				colvarProjectDes.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProjectDes);
				
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
				
				TableSchema.TableColumn colvarFillTableDate = new TableSchema.TableColumn(schema);
				colvarFillTableDate.ColumnName = "FillTableDate";
				colvarFillTableDate.DataType = DbType.DateTime;
				colvarFillTableDate.MaxLength = 0;
				colvarFillTableDate.AutoIncrement = false;
				colvarFillTableDate.IsNullable = true;
				colvarFillTableDate.IsPrimaryKey = false;
				colvarFillTableDate.IsForeignKey = false;
				colvarFillTableDate.IsReadOnly = false;
				colvarFillTableDate.DefaultSetting = @"";
				colvarFillTableDate.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFillTableDate);
				
				TableSchema.TableColumn colvarFinaceView = new TableSchema.TableColumn(schema);
				colvarFinaceView.ColumnName = "FinaceView";
				colvarFinaceView.DataType = DbType.String;
				colvarFinaceView.MaxLength = 50;
				colvarFinaceView.AutoIncrement = false;
				colvarFinaceView.IsNullable = true;
				colvarFinaceView.IsPrimaryKey = false;
				colvarFinaceView.IsForeignKey = false;
				colvarFinaceView.IsReadOnly = false;
				colvarFinaceView.DefaultSetting = @"";
				colvarFinaceView.ForeignKeyTableName = "";
				schema.Columns.Add(colvarFinaceView);
				
				TableSchema.TableColumn colvarSectionView = new TableSchema.TableColumn(schema);
				colvarSectionView.ColumnName = "SectionView";
				colvarSectionView.DataType = DbType.String;
				colvarSectionView.MaxLength = 50;
				colvarSectionView.AutoIncrement = false;
				colvarSectionView.IsNullable = true;
				colvarSectionView.IsPrimaryKey = false;
				colvarSectionView.IsForeignKey = false;
				colvarSectionView.IsReadOnly = false;
				colvarSectionView.DefaultSetting = @"";
				colvarSectionView.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSectionView);
				
				TableSchema.TableColumn colvarMangerView = new TableSchema.TableColumn(schema);
				colvarMangerView.ColumnName = "MangerView";
				colvarMangerView.DataType = DbType.String;
				colvarMangerView.MaxLength = 50;
				colvarMangerView.AutoIncrement = false;
				colvarMangerView.IsNullable = true;
				colvarMangerView.IsPrimaryKey = false;
				colvarMangerView.IsForeignKey = false;
				colvarMangerView.IsReadOnly = false;
				colvarMangerView.DefaultSetting = @"";
				colvarMangerView.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMangerView);
				
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
				
				TableSchema.TableColumn colvarPreEmployeeId = new TableSchema.TableColumn(schema);
				colvarPreEmployeeId.ColumnName = "PreEmployeeId";
				colvarPreEmployeeId.DataType = DbType.Int32;
				colvarPreEmployeeId.MaxLength = 0;
				colvarPreEmployeeId.AutoIncrement = false;
				colvarPreEmployeeId.IsNullable = false;
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
				colvarIsMain1.IsNullable = false;
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
				
				TableSchema.TableColumn colvarOfferPriceTypeId = new TableSchema.TableColumn(schema);
				colvarOfferPriceTypeId.ColumnName = "OfferPriceTypeId";
				colvarOfferPriceTypeId.DataType = DbType.Int32;
				colvarOfferPriceTypeId.MaxLength = 0;
				colvarOfferPriceTypeId.AutoIncrement = false;
				colvarOfferPriceTypeId.IsNullable = true;
				colvarOfferPriceTypeId.IsPrimaryKey = false;
				colvarOfferPriceTypeId.IsForeignKey = false;
				colvarOfferPriceTypeId.IsReadOnly = false;
				colvarOfferPriceTypeId.DefaultSetting = @"";
				colvarOfferPriceTypeId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOfferPriceTypeId);
				
				TableSchema.TableColumn colvarOfferFileId = new TableSchema.TableColumn(schema);
				colvarOfferFileId.ColumnName = "OfferFileId";
				colvarOfferFileId.DataType = DbType.Int32;
				colvarOfferFileId.MaxLength = 0;
				colvarOfferFileId.AutoIncrement = false;
				colvarOfferFileId.IsNullable = true;
				colvarOfferFileId.IsPrimaryKey = false;
				colvarOfferFileId.IsForeignKey = false;
				colvarOfferFileId.IsReadOnly = false;
				colvarOfferFileId.DefaultSetting = @"";
				colvarOfferFileId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOfferFileId);
				
				TableSchema.TableColumn colvarMoneySum = new TableSchema.TableColumn(schema);
				colvarMoneySum.ColumnName = "MoneySum";
				colvarMoneySum.DataType = DbType.String;
				colvarMoneySum.MaxLength = 50;
				colvarMoneySum.AutoIncrement = false;
				colvarMoneySum.IsNullable = true;
				colvarMoneySum.IsPrimaryKey = false;
				colvarMoneySum.IsForeignKey = false;
				colvarMoneySum.IsReadOnly = false;
				colvarMoneySum.DefaultSetting = @"";
				colvarMoneySum.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMoneySum);
				
				TableSchema.TableColumn colvarBigMoney = new TableSchema.TableColumn(schema);
				colvarBigMoney.ColumnName = "BigMoney";
				colvarBigMoney.DataType = DbType.String;
				colvarBigMoney.MaxLength = 50;
				colvarBigMoney.AutoIncrement = false;
				colvarBigMoney.IsNullable = true;
				colvarBigMoney.IsPrimaryKey = false;
				colvarBigMoney.IsForeignKey = false;
				colvarBigMoney.IsReadOnly = false;
				colvarBigMoney.DefaultSetting = @"";
				colvarBigMoney.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBigMoney);
				
				TableSchema.TableColumn colvarProductMoneySum = new TableSchema.TableColumn(schema);
				colvarProductMoneySum.ColumnName = "ProductMoneySum";
				colvarProductMoneySum.DataType = DbType.String;
				colvarProductMoneySum.MaxLength = 50;
				colvarProductMoneySum.AutoIncrement = false;
				colvarProductMoneySum.IsNullable = true;
				colvarProductMoneySum.IsPrimaryKey = false;
				colvarProductMoneySum.IsForeignKey = false;
				colvarProductMoneySum.IsReadOnly = false;
				colvarProductMoneySum.DefaultSetting = @"";
				colvarProductMoneySum.ForeignKeyTableName = "";
				schema.Columns.Add(colvarProductMoneySum);
				
				TableSchema.TableColumn colvarIsSignName = new TableSchema.TableColumn(schema);
				colvarIsSignName.ColumnName = "IsSignName";
				colvarIsSignName.DataType = DbType.Int32;
				colvarIsSignName.MaxLength = 0;
				colvarIsSignName.AutoIncrement = false;
				colvarIsSignName.IsNullable = true;
				colvarIsSignName.IsPrimaryKey = false;
				colvarIsSignName.IsForeignKey = false;
				colvarIsSignName.IsReadOnly = false;
				colvarIsSignName.DefaultSetting = @"";
				colvarIsSignName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIsSignName);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("OfferPrice_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("OfferPriceId")]
		[Bindable(true)]
		public int OfferPriceId 
		{
			get { return GetColumnValue<int>(Columns.OfferPriceId); }
			set { SetColumnValue(Columns.OfferPriceId, value); }
		}
		  
		[XmlAttribute("EmployeeId")]
		[Bindable(true)]
		public int? EmployeeId 
		{
			get { return GetColumnValue<int?>(Columns.EmployeeId); }
			set { SetColumnValue(Columns.EmployeeId, value); }
		}
		  
		[XmlAttribute("MainProjectCreateId")]
		[Bindable(true)]
		public int? MainProjectCreateId 
		{
			get { return GetColumnValue<int?>(Columns.MainProjectCreateId); }
			set { SetColumnValue(Columns.MainProjectCreateId, value); }
		}
		  
		[XmlAttribute("MainOfferPriceId")]
		[Bindable(true)]
		public int? MainOfferPriceId 
		{
			get { return GetColumnValue<int?>(Columns.MainOfferPriceId); }
			set { SetColumnValue(Columns.MainOfferPriceId, value); }
		}
		  
		[XmlAttribute("ProjectDes")]
		[Bindable(true)]
		public string ProjectDes 
		{
			get { return GetColumnValue<string>(Columns.ProjectDes); }
			set { SetColumnValue(Columns.ProjectDes, value); }
		}
		  
		[XmlAttribute("SheetNum")]
		[Bindable(true)]
		public string SheetNum 
		{
			get { return GetColumnValue<string>(Columns.SheetNum); }
			set { SetColumnValue(Columns.SheetNum, value); }
		}
		  
		[XmlAttribute("FillTableDate")]
		[Bindable(true)]
		public DateTime? FillTableDate 
		{
			get { return GetColumnValue<DateTime?>(Columns.FillTableDate); }
			set { SetColumnValue(Columns.FillTableDate, value); }
		}
		  
		[XmlAttribute("FinaceView")]
		[Bindable(true)]
		public string FinaceView 
		{
			get { return GetColumnValue<string>(Columns.FinaceView); }
			set { SetColumnValue(Columns.FinaceView, value); }
		}
		  
		[XmlAttribute("SectionView")]
		[Bindable(true)]
		public string SectionView 
		{
			get { return GetColumnValue<string>(Columns.SectionView); }
			set { SetColumnValue(Columns.SectionView, value); }
		}
		  
		[XmlAttribute("MangerView")]
		[Bindable(true)]
		public string MangerView 
		{
			get { return GetColumnValue<string>(Columns.MangerView); }
			set { SetColumnValue(Columns.MangerView, value); }
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
		  
		[XmlAttribute("SendEmployeeId")]
		[Bindable(true)]
		public int? SendEmployeeId 
		{
			get { return GetColumnValue<int?>(Columns.SendEmployeeId); }
			set { SetColumnValue(Columns.SendEmployeeId, value); }
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
		  
		[XmlAttribute("SendEmployeeName")]
		[Bindable(true)]
		public string SendEmployeeName 
		{
			get { return GetColumnValue<string>(Columns.SendEmployeeName); }
			set { SetColumnValue(Columns.SendEmployeeName, value); }
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
		  
		[XmlAttribute("PreEmployeeId")]
		[Bindable(true)]
		public int PreEmployeeId 
		{
			get { return GetColumnValue<int>(Columns.PreEmployeeId); }
			set { SetColumnValue(Columns.PreEmployeeId, value); }
		}
		  
		[XmlAttribute("PreEmployeeName")]
		[Bindable(true)]
		public string PreEmployeeName 
		{
			get { return GetColumnValue<string>(Columns.PreEmployeeName); }
			set { SetColumnValue(Columns.PreEmployeeName, value); }
		}
		  
		[XmlAttribute("PreIsApply")]
		[Bindable(true)]
		public int? PreIsApply 
		{
			get { return GetColumnValue<int?>(Columns.PreIsApply); }
			set { SetColumnValue(Columns.PreIsApply, value); }
		}
		  
		[XmlAttribute("PreIsOver")]
		[Bindable(true)]
		public int? PreIsOver 
		{
			get { return GetColumnValue<int?>(Columns.PreIsOver); }
			set { SetColumnValue(Columns.PreIsOver, value); }
		}
		  
		[XmlAttribute("PreApplyTime")]
		[Bindable(true)]
		public DateTime? PreApplyTime 
		{
			get { return GetColumnValue<DateTime?>(Columns.PreApplyTime); }
			set { SetColumnValue(Columns.PreApplyTime, value); }
		}
		  
		[XmlAttribute("RecvEmployeeId")]
		[Bindable(true)]
		public int? RecvEmployeeId 
		{
			get { return GetColumnValue<int?>(Columns.RecvEmployeeId); }
			set { SetColumnValue(Columns.RecvEmployeeId, value); }
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
		public int IsMain1 
		{
			get { return GetColumnValue<int>(Columns.IsMain1); }
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
		  
		[XmlAttribute("IsApprove")]
		[Bindable(true)]
		public int? IsApprove 
		{
			get { return GetColumnValue<int?>(Columns.IsApprove); }
			set { SetColumnValue(Columns.IsApprove, value); }
		}
		  
		[XmlAttribute("ApproveTime")]
		[Bindable(true)]
		public DateTime? ApproveTime 
		{
			get { return GetColumnValue<DateTime?>(Columns.ApproveTime); }
			set { SetColumnValue(Columns.ApproveTime, value); }
		}
		  
		[XmlAttribute("Today")]
		[Bindable(true)]
		public string Today 
		{
			get { return GetColumnValue<string>(Columns.Today); }
			set { SetColumnValue(Columns.Today, value); }
		}
		  
		[XmlAttribute("OfferPriceTypeId")]
		[Bindable(true)]
		public int? OfferPriceTypeId 
		{
			get { return GetColumnValue<int?>(Columns.OfferPriceTypeId); }
			set { SetColumnValue(Columns.OfferPriceTypeId, value); }
		}
		  
		[XmlAttribute("OfferFileId")]
		[Bindable(true)]
		public int? OfferFileId 
		{
			get { return GetColumnValue<int?>(Columns.OfferFileId); }
			set { SetColumnValue(Columns.OfferFileId, value); }
		}
		  
		[XmlAttribute("MoneySum")]
		[Bindable(true)]
		public string MoneySum 
		{
			get { return GetColumnValue<string>(Columns.MoneySum); }
			set { SetColumnValue(Columns.MoneySum, value); }
		}
		  
		[XmlAttribute("BigMoney")]
		[Bindable(true)]
		public string BigMoney 
		{
			get { return GetColumnValue<string>(Columns.BigMoney); }
			set { SetColumnValue(Columns.BigMoney, value); }
		}
		  
		[XmlAttribute("ProductMoneySum")]
		[Bindable(true)]
		public string ProductMoneySum 
		{
			get { return GetColumnValue<string>(Columns.ProductMoneySum); }
			set { SetColumnValue(Columns.ProductMoneySum, value); }
		}
		  
		[XmlAttribute("IsSignName")]
		[Bindable(true)]
		public int? IsSignName 
		{
			get { return GetColumnValue<int?>(Columns.IsSignName); }
			set { SetColumnValue(Columns.IsSignName, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int? varEmployeeId,int? varMainProjectCreateId,int? varMainOfferPriceId,string varProjectDes,string varSheetNum,DateTime? varFillTableDate,string varFinaceView,string varSectionView,string varMangerView,int? varIsApply,int? varIsApply1,int? varIsApply2,int? varIsOver1,int? varIsOver2,DateTime? varApplyTime,DateTime? varApply1Time,DateTime? varApply2Time,int? varSendEmployeeId,int? varRecv1EmployeeId,int? varRecv2EmployeeId,string varSendEmployeeName,string varRecv1EmployeeName,string varRecv2EmployeeName,int varPreEmployeeId,string varPreEmployeeName,int? varPreIsApply,int? varPreIsOver,DateTime? varPreApplyTime,int? varRecvEmployeeId,int? varIsMain,int varIsMain1,int? varIsMain2,int? varIsMain3,int? varIsNewCreate,int? varIsApprove,DateTime? varApproveTime,string varToday,int? varOfferPriceTypeId,int? varOfferFileId,string varMoneySum,string varBigMoney,string varProductMoneySum,int? varIsSignName)
		{
			OfferPrice item = new OfferPrice();
			
			item.EmployeeId = varEmployeeId;
			
			item.MainProjectCreateId = varMainProjectCreateId;
			
			item.MainOfferPriceId = varMainOfferPriceId;
			
			item.ProjectDes = varProjectDes;
			
			item.SheetNum = varSheetNum;
			
			item.FillTableDate = varFillTableDate;
			
			item.FinaceView = varFinaceView;
			
			item.SectionView = varSectionView;
			
			item.MangerView = varMangerView;
			
			item.IsApply = varIsApply;
			
			item.IsApply1 = varIsApply1;
			
			item.IsApply2 = varIsApply2;
			
			item.IsOver1 = varIsOver1;
			
			item.IsOver2 = varIsOver2;
			
			item.ApplyTime = varApplyTime;
			
			item.Apply1Time = varApply1Time;
			
			item.Apply2Time = varApply2Time;
			
			item.SendEmployeeId = varSendEmployeeId;
			
			item.Recv1EmployeeId = varRecv1EmployeeId;
			
			item.Recv2EmployeeId = varRecv2EmployeeId;
			
			item.SendEmployeeName = varSendEmployeeName;
			
			item.Recv1EmployeeName = varRecv1EmployeeName;
			
			item.Recv2EmployeeName = varRecv2EmployeeName;
			
			item.PreEmployeeId = varPreEmployeeId;
			
			item.PreEmployeeName = varPreEmployeeName;
			
			item.PreIsApply = varPreIsApply;
			
			item.PreIsOver = varPreIsOver;
			
			item.PreApplyTime = varPreApplyTime;
			
			item.RecvEmployeeId = varRecvEmployeeId;
			
			item.IsMain = varIsMain;
			
			item.IsMain1 = varIsMain1;
			
			item.IsMain2 = varIsMain2;
			
			item.IsMain3 = varIsMain3;
			
			item.IsNewCreate = varIsNewCreate;
			
			item.IsApprove = varIsApprove;
			
			item.ApproveTime = varApproveTime;
			
			item.Today = varToday;
			
			item.OfferPriceTypeId = varOfferPriceTypeId;
			
			item.OfferFileId = varOfferFileId;
			
			item.MoneySum = varMoneySum;
			
			item.BigMoney = varBigMoney;
			
			item.ProductMoneySum = varProductMoneySum;
			
			item.IsSignName = varIsSignName;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varOfferPriceId,int? varEmployeeId,int? varMainProjectCreateId,int? varMainOfferPriceId,string varProjectDes,string varSheetNum,DateTime? varFillTableDate,string varFinaceView,string varSectionView,string varMangerView,int? varIsApply,int? varIsApply1,int? varIsApply2,int? varIsOver1,int? varIsOver2,DateTime? varApplyTime,DateTime? varApply1Time,DateTime? varApply2Time,int? varSendEmployeeId,int? varRecv1EmployeeId,int? varRecv2EmployeeId,string varSendEmployeeName,string varRecv1EmployeeName,string varRecv2EmployeeName,int varPreEmployeeId,string varPreEmployeeName,int? varPreIsApply,int? varPreIsOver,DateTime? varPreApplyTime,int? varRecvEmployeeId,int? varIsMain,int varIsMain1,int? varIsMain2,int? varIsMain3,int? varIsNewCreate,int? varIsApprove,DateTime? varApproveTime,string varToday,int? varOfferPriceTypeId,int? varOfferFileId,string varMoneySum,string varBigMoney,string varProductMoneySum,int? varIsSignName)
		{
			OfferPrice item = new OfferPrice();
			
				item.OfferPriceId = varOfferPriceId;
			
				item.EmployeeId = varEmployeeId;
			
				item.MainProjectCreateId = varMainProjectCreateId;
			
				item.MainOfferPriceId = varMainOfferPriceId;
			
				item.ProjectDes = varProjectDes;
			
				item.SheetNum = varSheetNum;
			
				item.FillTableDate = varFillTableDate;
			
				item.FinaceView = varFinaceView;
			
				item.SectionView = varSectionView;
			
				item.MangerView = varMangerView;
			
				item.IsApply = varIsApply;
			
				item.IsApply1 = varIsApply1;
			
				item.IsApply2 = varIsApply2;
			
				item.IsOver1 = varIsOver1;
			
				item.IsOver2 = varIsOver2;
			
				item.ApplyTime = varApplyTime;
			
				item.Apply1Time = varApply1Time;
			
				item.Apply2Time = varApply2Time;
			
				item.SendEmployeeId = varSendEmployeeId;
			
				item.Recv1EmployeeId = varRecv1EmployeeId;
			
				item.Recv2EmployeeId = varRecv2EmployeeId;
			
				item.SendEmployeeName = varSendEmployeeName;
			
				item.Recv1EmployeeName = varRecv1EmployeeName;
			
				item.Recv2EmployeeName = varRecv2EmployeeName;
			
				item.PreEmployeeId = varPreEmployeeId;
			
				item.PreEmployeeName = varPreEmployeeName;
			
				item.PreIsApply = varPreIsApply;
			
				item.PreIsOver = varPreIsOver;
			
				item.PreApplyTime = varPreApplyTime;
			
				item.RecvEmployeeId = varRecvEmployeeId;
			
				item.IsMain = varIsMain;
			
				item.IsMain1 = varIsMain1;
			
				item.IsMain2 = varIsMain2;
			
				item.IsMain3 = varIsMain3;
			
				item.IsNewCreate = varIsNewCreate;
			
				item.IsApprove = varIsApprove;
			
				item.ApproveTime = varApproveTime;
			
				item.Today = varToday;
			
				item.OfferPriceTypeId = varOfferPriceTypeId;
			
				item.OfferFileId = varOfferFileId;
			
				item.MoneySum = varMoneySum;
			
				item.BigMoney = varBigMoney;
			
				item.ProductMoneySum = varProductMoneySum;
			
				item.IsSignName = varIsSignName;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn OfferPriceIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn EmployeeIdColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn MainProjectCreateIdColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn MainOfferPriceIdColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn ProjectDesColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn SheetNumColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn FillTableDateColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn FinaceViewColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn SectionViewColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn MangerViewColumn
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
        
        
        
        public static TableSchema.TableColumn IsOver1Column
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn IsOver2Column
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn ApplyTimeColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn Apply1TimeColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn Apply2TimeColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn SendEmployeeIdColumn
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn Recv1EmployeeIdColumn
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        public static TableSchema.TableColumn Recv2EmployeeIdColumn
        {
            get { return Schema.Columns[20]; }
        }
        
        
        
        public static TableSchema.TableColumn SendEmployeeNameColumn
        {
            get { return Schema.Columns[21]; }
        }
        
        
        
        public static TableSchema.TableColumn Recv1EmployeeNameColumn
        {
            get { return Schema.Columns[22]; }
        }
        
        
        
        public static TableSchema.TableColumn Recv2EmployeeNameColumn
        {
            get { return Schema.Columns[23]; }
        }
        
        
        
        public static TableSchema.TableColumn PreEmployeeIdColumn
        {
            get { return Schema.Columns[24]; }
        }
        
        
        
        public static TableSchema.TableColumn PreEmployeeNameColumn
        {
            get { return Schema.Columns[25]; }
        }
        
        
        
        public static TableSchema.TableColumn PreIsApplyColumn
        {
            get { return Schema.Columns[26]; }
        }
        
        
        
        public static TableSchema.TableColumn PreIsOverColumn
        {
            get { return Schema.Columns[27]; }
        }
        
        
        
        public static TableSchema.TableColumn PreApplyTimeColumn
        {
            get { return Schema.Columns[28]; }
        }
        
        
        
        public static TableSchema.TableColumn RecvEmployeeIdColumn
        {
            get { return Schema.Columns[29]; }
        }
        
        
        
        public static TableSchema.TableColumn IsMainColumn
        {
            get { return Schema.Columns[30]; }
        }
        
        
        
        public static TableSchema.TableColumn IsMain1Column
        {
            get { return Schema.Columns[31]; }
        }
        
        
        
        public static TableSchema.TableColumn IsMain2Column
        {
            get { return Schema.Columns[32]; }
        }
        
        
        
        public static TableSchema.TableColumn IsMain3Column
        {
            get { return Schema.Columns[33]; }
        }
        
        
        
        public static TableSchema.TableColumn IsNewCreateColumn
        {
            get { return Schema.Columns[34]; }
        }
        
        
        
        public static TableSchema.TableColumn IsApproveColumn
        {
            get { return Schema.Columns[35]; }
        }
        
        
        
        public static TableSchema.TableColumn ApproveTimeColumn
        {
            get { return Schema.Columns[36]; }
        }
        
        
        
        public static TableSchema.TableColumn TodayColumn
        {
            get { return Schema.Columns[37]; }
        }
        
        
        
        public static TableSchema.TableColumn OfferPriceTypeIdColumn
        {
            get { return Schema.Columns[38]; }
        }
        
        
        
        public static TableSchema.TableColumn OfferFileIdColumn
        {
            get { return Schema.Columns[39]; }
        }
        
        
        
        public static TableSchema.TableColumn MoneySumColumn
        {
            get { return Schema.Columns[40]; }
        }
        
        
        
        public static TableSchema.TableColumn BigMoneyColumn
        {
            get { return Schema.Columns[41]; }
        }
        
        
        
        public static TableSchema.TableColumn ProductMoneySumColumn
        {
            get { return Schema.Columns[42]; }
        }
        
        
        
        public static TableSchema.TableColumn IsSignNameColumn
        {
            get { return Schema.Columns[43]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string OfferPriceId = @"OfferPriceId";
			 public static string EmployeeId = @"EmployeeId";
			 public static string MainProjectCreateId = @"MainProjectCreateId";
			 public static string MainOfferPriceId = @"MainOfferPriceId";
			 public static string ProjectDes = @"ProjectDes";
			 public static string SheetNum = @"SheetNum";
			 public static string FillTableDate = @"FillTableDate";
			 public static string FinaceView = @"FinaceView";
			 public static string SectionView = @"SectionView";
			 public static string MangerView = @"MangerView";
			 public static string IsApply = @"IsApply";
			 public static string IsApply1 = @"IsApply1";
			 public static string IsApply2 = @"IsApply2";
			 public static string IsOver1 = @"IsOver1";
			 public static string IsOver2 = @"IsOver2";
			 public static string ApplyTime = @"ApplyTime";
			 public static string Apply1Time = @"Apply1Time";
			 public static string Apply2Time = @"Apply2Time";
			 public static string SendEmployeeId = @"SendEmployeeId";
			 public static string Recv1EmployeeId = @"Recv1EmployeeId";
			 public static string Recv2EmployeeId = @"Recv2EmployeeId";
			 public static string SendEmployeeName = @"SendEmployeeName";
			 public static string Recv1EmployeeName = @"Recv1EmployeeName";
			 public static string Recv2EmployeeName = @"Recv2EmployeeName";
			 public static string PreEmployeeId = @"PreEmployeeId";
			 public static string PreEmployeeName = @"PreEmployeeName";
			 public static string PreIsApply = @"PreIsApply";
			 public static string PreIsOver = @"PreIsOver";
			 public static string PreApplyTime = @"PreApplyTime";
			 public static string RecvEmployeeId = @"RecvEmployeeId";
			 public static string IsMain = @"IsMain";
			 public static string IsMain1 = @"IsMain1";
			 public static string IsMain2 = @"IsMain2";
			 public static string IsMain3 = @"IsMain3";
			 public static string IsNewCreate = @"IsNewCreate";
			 public static string IsApprove = @"IsApprove";
			 public static string ApproveTime = @"ApproveTime";
			 public static string Today = @"Today";
			 public static string OfferPriceTypeId = @"OfferPriceTypeId";
			 public static string OfferFileId = @"OfferFileId";
			 public static string MoneySum = @"MoneySum";
			 public static string BigMoney = @"BigMoney";
			 public static string ProductMoneySum = @"ProductMoneySum";
			 public static string IsSignName = @"IsSignName";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
