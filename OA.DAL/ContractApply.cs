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
	/// Strongly-typed collection for the ContractApply class.
	/// </summary>
    [Serializable]
	public partial class ContractApplyCollection : ActiveList<ContractApply, ContractApplyCollection>
	{	   
		public ContractApplyCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>ContractApplyCollection</returns>
		public ContractApplyCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                ContractApply o = this[i];
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
	/// This is an ActiveRecord class which wraps the ContractApply_tb table.
	/// </summary>
	[Serializable]
	public partial class ContractApply : ActiveRecord<ContractApply>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public ContractApply()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public ContractApply(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public ContractApply(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public ContractApply(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("ContractApply_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarContractApplyId = new TableSchema.TableColumn(schema);
				colvarContractApplyId.ColumnName = "ContractApplyId";
				colvarContractApplyId.DataType = DbType.Int32;
				colvarContractApplyId.MaxLength = 0;
				colvarContractApplyId.AutoIncrement = true;
				colvarContractApplyId.IsNullable = false;
				colvarContractApplyId.IsPrimaryKey = true;
				colvarContractApplyId.IsForeignKey = false;
				colvarContractApplyId.IsReadOnly = false;
				colvarContractApplyId.DefaultSetting = @"";
				colvarContractApplyId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarContractApplyId);
				
				TableSchema.TableColumn colvarContractFileId = new TableSchema.TableColumn(schema);
				colvarContractFileId.ColumnName = "ContractFileId";
				colvarContractFileId.DataType = DbType.Int32;
				colvarContractFileId.MaxLength = 0;
				colvarContractFileId.AutoIncrement = false;
				colvarContractFileId.IsNullable = true;
				colvarContractFileId.IsPrimaryKey = false;
				colvarContractFileId.IsForeignKey = false;
				colvarContractFileId.IsReadOnly = false;
				colvarContractFileId.DefaultSetting = @"";
				colvarContractFileId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarContractFileId);
				
				TableSchema.TableColumn colvarSignName = new TableSchema.TableColumn(schema);
				colvarSignName.ColumnName = "SignName";
				colvarSignName.DataType = DbType.String;
				colvarSignName.MaxLength = 50;
				colvarSignName.AutoIncrement = false;
				colvarSignName.IsNullable = true;
				colvarSignName.IsPrimaryKey = false;
				colvarSignName.IsForeignKey = false;
				colvarSignName.IsReadOnly = false;
				colvarSignName.DefaultSetting = @"";
				colvarSignName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSignName);
				
				TableSchema.TableColumn colvarContractNum = new TableSchema.TableColumn(schema);
				colvarContractNum.ColumnName = "ContractNum";
				colvarContractNum.DataType = DbType.String;
				colvarContractNum.MaxLength = 50;
				colvarContractNum.AutoIncrement = false;
				colvarContractNum.IsNullable = true;
				colvarContractNum.IsPrimaryKey = false;
				colvarContractNum.IsForeignKey = false;
				colvarContractNum.IsReadOnly = false;
				colvarContractNum.DefaultSetting = @"";
				colvarContractNum.ForeignKeyTableName = "";
				schema.Columns.Add(colvarContractNum);
				
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
				colvarToday.MaxLength = 50;
				colvarToday.AutoIncrement = false;
				colvarToday.IsNullable = true;
				colvarToday.IsPrimaryKey = false;
				colvarToday.IsForeignKey = false;
				colvarToday.IsReadOnly = false;
				colvarToday.DefaultSetting = @"";
				colvarToday.ForeignKeyTableName = "";
				schema.Columns.Add(colvarToday);
				
				TableSchema.TableColumn colvarContractName = new TableSchema.TableColumn(schema);
				colvarContractName.ColumnName = "ContractName";
				colvarContractName.DataType = DbType.String;
				colvarContractName.MaxLength = 50;
				colvarContractName.AutoIncrement = false;
				colvarContractName.IsNullable = true;
				colvarContractName.IsPrimaryKey = false;
				colvarContractName.IsForeignKey = false;
				colvarContractName.IsReadOnly = false;
				colvarContractName.DefaultSetting = @"";
				colvarContractName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarContractName);
				
				TableSchema.TableColumn colvarBeginDate = new TableSchema.TableColumn(schema);
				colvarBeginDate.ColumnName = "BeginDate";
				colvarBeginDate.DataType = DbType.String;
				colvarBeginDate.MaxLength = 50;
				colvarBeginDate.AutoIncrement = false;
				colvarBeginDate.IsNullable = true;
				colvarBeginDate.IsPrimaryKey = false;
				colvarBeginDate.IsForeignKey = false;
				colvarBeginDate.IsReadOnly = false;
				colvarBeginDate.DefaultSetting = @"";
				colvarBeginDate.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBeginDate);
				
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
				
				TableSchema.TableColumn colvarContractDes = new TableSchema.TableColumn(schema);
				colvarContractDes.ColumnName = "ContractDes";
				colvarContractDes.DataType = DbType.String;
				colvarContractDes.MaxLength = -1;
				colvarContractDes.AutoIncrement = false;
				colvarContractDes.IsNullable = true;
				colvarContractDes.IsPrimaryKey = false;
				colvarContractDes.IsForeignKey = false;
				colvarContractDes.IsReadOnly = false;
				colvarContractDes.DefaultSetting = @"";
				colvarContractDes.ForeignKeyTableName = "";
				schema.Columns.Add(colvarContractDes);
				
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
				
				TableSchema.TableColumn colvarSmallMoney = new TableSchema.TableColumn(schema);
				colvarSmallMoney.ColumnName = "SmallMoney";
				colvarSmallMoney.DataType = DbType.String;
				colvarSmallMoney.MaxLength = 50;
				colvarSmallMoney.AutoIncrement = false;
				colvarSmallMoney.IsNullable = true;
				colvarSmallMoney.IsPrimaryKey = false;
				colvarSmallMoney.IsForeignKey = false;
				colvarSmallMoney.IsReadOnly = false;
				colvarSmallMoney.DefaultSetting = @"";
				colvarSmallMoney.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSmallMoney);
				
				TableSchema.TableColumn colvarUseStampType = new TableSchema.TableColumn(schema);
				colvarUseStampType.ColumnName = "UseStampType";
				colvarUseStampType.DataType = DbType.String;
				colvarUseStampType.MaxLength = 50;
				colvarUseStampType.AutoIncrement = false;
				colvarUseStampType.IsNullable = true;
				colvarUseStampType.IsPrimaryKey = false;
				colvarUseStampType.IsForeignKey = false;
				colvarUseStampType.IsReadOnly = false;
				colvarUseStampType.DefaultSetting = @"";
				colvarUseStampType.ForeignKeyTableName = "";
				schema.Columns.Add(colvarUseStampType);
				
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
				
				TableSchema.TableColumn colvarIsMoney = new TableSchema.TableColumn(schema);
				colvarIsMoney.ColumnName = "IsMoney";
				colvarIsMoney.DataType = DbType.Int32;
				colvarIsMoney.MaxLength = 0;
				colvarIsMoney.AutoIncrement = false;
				colvarIsMoney.IsNullable = true;
				colvarIsMoney.IsPrimaryKey = false;
				colvarIsMoney.IsForeignKey = false;
				colvarIsMoney.IsReadOnly = false;
				colvarIsMoney.DefaultSetting = @"";
				colvarIsMoney.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIsMoney);
				
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
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("ContractApply_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("ContractApplyId")]
		[Bindable(true)]
		public int ContractApplyId 
		{
			get { return GetColumnValue<int>(Columns.ContractApplyId); }
			set { SetColumnValue(Columns.ContractApplyId, value); }
		}
		  
		[XmlAttribute("ContractFileId")]
		[Bindable(true)]
		public int? ContractFileId 
		{
			get { return GetColumnValue<int?>(Columns.ContractFileId); }
			set { SetColumnValue(Columns.ContractFileId, value); }
		}
		  
		[XmlAttribute("SignName")]
		[Bindable(true)]
		public string SignName 
		{
			get { return GetColumnValue<string>(Columns.SignName); }
			set { SetColumnValue(Columns.SignName, value); }
		}
		  
		[XmlAttribute("ContractNum")]
		[Bindable(true)]
		public string ContractNum 
		{
			get { return GetColumnValue<string>(Columns.ContractNum); }
			set { SetColumnValue(Columns.ContractNum, value); }
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
		  
		[XmlAttribute("ContractName")]
		[Bindable(true)]
		public string ContractName 
		{
			get { return GetColumnValue<string>(Columns.ContractName); }
			set { SetColumnValue(Columns.ContractName, value); }
		}
		  
		[XmlAttribute("BeginDate")]
		[Bindable(true)]
		public string BeginDate 
		{
			get { return GetColumnValue<string>(Columns.BeginDate); }
			set { SetColumnValue(Columns.BeginDate, value); }
		}
		  
		[XmlAttribute("ApplyDate")]
		[Bindable(true)]
		public string ApplyDate 
		{
			get { return GetColumnValue<string>(Columns.ApplyDate); }
			set { SetColumnValue(Columns.ApplyDate, value); }
		}
		  
		[XmlAttribute("ContractDes")]
		[Bindable(true)]
		public string ContractDes 
		{
			get { return GetColumnValue<string>(Columns.ContractDes); }
			set { SetColumnValue(Columns.ContractDes, value); }
		}
		  
		[XmlAttribute("BigMoney")]
		[Bindable(true)]
		public string BigMoney 
		{
			get { return GetColumnValue<string>(Columns.BigMoney); }
			set { SetColumnValue(Columns.BigMoney, value); }
		}
		  
		[XmlAttribute("SmallMoney")]
		[Bindable(true)]
		public string SmallMoney 
		{
			get { return GetColumnValue<string>(Columns.SmallMoney); }
			set { SetColumnValue(Columns.SmallMoney, value); }
		}
		  
		[XmlAttribute("UseStampType")]
		[Bindable(true)]
		public string UseStampType 
		{
			get { return GetColumnValue<string>(Columns.UseStampType); }
			set { SetColumnValue(Columns.UseStampType, value); }
		}
		  
		[XmlAttribute("SectionView")]
		[Bindable(true)]
		public string SectionView 
		{
			get { return GetColumnValue<string>(Columns.SectionView); }
			set { SetColumnValue(Columns.SectionView, value); }
		}
		  
		[XmlAttribute("ManagerView")]
		[Bindable(true)]
		public string ManagerView 
		{
			get { return GetColumnValue<string>(Columns.ManagerView); }
			set { SetColumnValue(Columns.ManagerView, value); }
		}
		  
		[XmlAttribute("IsMoney")]
		[Bindable(true)]
		public int? IsMoney 
		{
			get { return GetColumnValue<int?>(Columns.IsMoney); }
			set { SetColumnValue(Columns.IsMoney, value); }
		}
		  
		[XmlAttribute("ApplyTime")]
		[Bindable(true)]
		public string ApplyTime 
		{
			get { return GetColumnValue<string>(Columns.ApplyTime); }
			set { SetColumnValue(Columns.ApplyTime, value); }
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
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int? varContractFileId,string varSignName,string varContractNum,string varSheetNum,string varToday,string varContractName,string varBeginDate,string varApplyDate,string varContractDes,string varBigMoney,string varSmallMoney,string varUseStampType,string varSectionView,string varManagerView,int? varIsMoney,string varApplyTime,string varApplyName,string varDepartName,int? varState)
		{
			ContractApply item = new ContractApply();
			
			item.ContractFileId = varContractFileId;
			
			item.SignName = varSignName;
			
			item.ContractNum = varContractNum;
			
			item.SheetNum = varSheetNum;
			
			item.Today = varToday;
			
			item.ContractName = varContractName;
			
			item.BeginDate = varBeginDate;
			
			item.ApplyDate = varApplyDate;
			
			item.ContractDes = varContractDes;
			
			item.BigMoney = varBigMoney;
			
			item.SmallMoney = varSmallMoney;
			
			item.UseStampType = varUseStampType;
			
			item.SectionView = varSectionView;
			
			item.ManagerView = varManagerView;
			
			item.IsMoney = varIsMoney;
			
			item.ApplyTime = varApplyTime;
			
			item.ApplyName = varApplyName;
			
			item.DepartName = varDepartName;
			
			item.State = varState;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varContractApplyId,int? varContractFileId,string varSignName,string varContractNum,string varSheetNum,string varToday,string varContractName,string varBeginDate,string varApplyDate,string varContractDes,string varBigMoney,string varSmallMoney,string varUseStampType,string varSectionView,string varManagerView,int? varIsMoney,string varApplyTime,string varApplyName,string varDepartName,int? varState)
		{
			ContractApply item = new ContractApply();
			
				item.ContractApplyId = varContractApplyId;
			
				item.ContractFileId = varContractFileId;
			
				item.SignName = varSignName;
			
				item.ContractNum = varContractNum;
			
				item.SheetNum = varSheetNum;
			
				item.Today = varToday;
			
				item.ContractName = varContractName;
			
				item.BeginDate = varBeginDate;
			
				item.ApplyDate = varApplyDate;
			
				item.ContractDes = varContractDes;
			
				item.BigMoney = varBigMoney;
			
				item.SmallMoney = varSmallMoney;
			
				item.UseStampType = varUseStampType;
			
				item.SectionView = varSectionView;
			
				item.ManagerView = varManagerView;
			
				item.IsMoney = varIsMoney;
			
				item.ApplyTime = varApplyTime;
			
				item.ApplyName = varApplyName;
			
				item.DepartName = varDepartName;
			
				item.State = varState;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn ContractApplyIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ContractFileIdColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn SignNameColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn ContractNumColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn SheetNumColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn TodayColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn ContractNameColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn BeginDateColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn ApplyDateColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn ContractDesColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn BigMoneyColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn SmallMoneyColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn UseStampTypeColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn SectionViewColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn ManagerViewColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn IsMoneyColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn ApplyTimeColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn ApplyNameColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn DepartNameColumn
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn StateColumn
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string ContractApplyId = @"ContractApplyId";
			 public static string ContractFileId = @"ContractFileId";
			 public static string SignName = @"SignName";
			 public static string ContractNum = @"ContractNum";
			 public static string SheetNum = @"SheetNum";
			 public static string Today = @"Today";
			 public static string ContractName = @"ContractName";
			 public static string BeginDate = @"BeginDate";
			 public static string ApplyDate = @"ApplyDate";
			 public static string ContractDes = @"ContractDes";
			 public static string BigMoney = @"BigMoney";
			 public static string SmallMoney = @"SmallMoney";
			 public static string UseStampType = @"UseStampType";
			 public static string SectionView = @"SectionView";
			 public static string ManagerView = @"ManagerView";
			 public static string IsMoney = @"IsMoney";
			 public static string ApplyTime = @"ApplyTime";
			 public static string ApplyName = @"ApplyName";
			 public static string DepartName = @"DepartName";
			 public static string State = @"State";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
