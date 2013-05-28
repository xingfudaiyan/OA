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
	/// Strongly-typed collection for the Employee class.
	/// </summary>
    [Serializable]
	public partial class EmployeeCollection : ActiveList<Employee, EmployeeCollection>
	{	   
		public EmployeeCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>EmployeeCollection</returns>
		public EmployeeCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                Employee o = this[i];
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
	/// This is an ActiveRecord class which wraps the Employee_tb table.
	/// </summary>
	[Serializable]
	public partial class Employee : ActiveRecord<Employee>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public Employee()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public Employee(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public Employee(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public Employee(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("Employee_tb", TableType.Table, DataService.GetInstance("SubsonicProvider"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarEmployeeId = new TableSchema.TableColumn(schema);
				colvarEmployeeId.ColumnName = "EmployeeId";
				colvarEmployeeId.DataType = DbType.Int32;
				colvarEmployeeId.MaxLength = 0;
				colvarEmployeeId.AutoIncrement = true;
				colvarEmployeeId.IsNullable = false;
				colvarEmployeeId.IsPrimaryKey = true;
				colvarEmployeeId.IsForeignKey = false;
				colvarEmployeeId.IsReadOnly = false;
				colvarEmployeeId.DefaultSetting = @"";
				colvarEmployeeId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEmployeeId);
				
				TableSchema.TableColumn colvarContactId = new TableSchema.TableColumn(schema);
				colvarContactId.ColumnName = "ContactId";
				colvarContactId.DataType = DbType.Int32;
				colvarContactId.MaxLength = 0;
				colvarContactId.AutoIncrement = false;
				colvarContactId.IsNullable = false;
				colvarContactId.IsPrimaryKey = false;
				colvarContactId.IsForeignKey = true;
				colvarContactId.IsReadOnly = false;
				colvarContactId.DefaultSetting = @"";
				
					colvarContactId.ForeignKeyTableName = "Contact_tb";
				schema.Columns.Add(colvarContactId);
				
				TableSchema.TableColumn colvarEmployeeName = new TableSchema.TableColumn(schema);
				colvarEmployeeName.ColumnName = "EmployeeName";
				colvarEmployeeName.DataType = DbType.String;
				colvarEmployeeName.MaxLength = 50;
				colvarEmployeeName.AutoIncrement = false;
				colvarEmployeeName.IsNullable = false;
				colvarEmployeeName.IsPrimaryKey = false;
				colvarEmployeeName.IsForeignKey = false;
				colvarEmployeeName.IsReadOnly = false;
				colvarEmployeeName.DefaultSetting = @"";
				colvarEmployeeName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEmployeeName);
				
				TableSchema.TableColumn colvarPositionId = new TableSchema.TableColumn(schema);
				colvarPositionId.ColumnName = "PositionId";
				colvarPositionId.DataType = DbType.Int32;
				colvarPositionId.MaxLength = 0;
				colvarPositionId.AutoIncrement = false;
				colvarPositionId.IsNullable = false;
				colvarPositionId.IsPrimaryKey = false;
				colvarPositionId.IsForeignKey = true;
				colvarPositionId.IsReadOnly = false;
				colvarPositionId.DefaultSetting = @"";
				
					colvarPositionId.ForeignKeyTableName = "Position_tb";
				schema.Columns.Add(colvarPositionId);
				
				TableSchema.TableColumn colvarSex = new TableSchema.TableColumn(schema);
				colvarSex.ColumnName = "Sex";
				colvarSex.DataType = DbType.Int32;
				colvarSex.MaxLength = 0;
				colvarSex.AutoIncrement = false;
				colvarSex.IsNullable = false;
				colvarSex.IsPrimaryKey = false;
				colvarSex.IsForeignKey = false;
				colvarSex.IsReadOnly = false;
				colvarSex.DefaultSetting = @"";
				colvarSex.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSex);
				
				TableSchema.TableColumn colvarBirthday = new TableSchema.TableColumn(schema);
				colvarBirthday.ColumnName = "Birthday";
				colvarBirthday.DataType = DbType.DateTime;
				colvarBirthday.MaxLength = 0;
				colvarBirthday.AutoIncrement = false;
				colvarBirthday.IsNullable = true;
				colvarBirthday.IsPrimaryKey = false;
				colvarBirthday.IsForeignKey = false;
				colvarBirthday.IsReadOnly = false;
				colvarBirthday.DefaultSetting = @"";
				colvarBirthday.ForeignKeyTableName = "";
				schema.Columns.Add(colvarBirthday);
				
				TableSchema.TableColumn colvarMarrage = new TableSchema.TableColumn(schema);
				colvarMarrage.ColumnName = "Marrage";
				colvarMarrage.DataType = DbType.Int32;
				colvarMarrage.MaxLength = 0;
				colvarMarrage.AutoIncrement = false;
				colvarMarrage.IsNullable = true;
				colvarMarrage.IsPrimaryKey = false;
				colvarMarrage.IsForeignKey = false;
				colvarMarrage.IsReadOnly = false;
				colvarMarrage.DefaultSetting = @"";
				colvarMarrage.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMarrage);
				
				TableSchema.TableColumn colvarAddress = new TableSchema.TableColumn(schema);
				colvarAddress.ColumnName = "Address";
				colvarAddress.DataType = DbType.String;
				colvarAddress.MaxLength = 100;
				colvarAddress.AutoIncrement = false;
				colvarAddress.IsNullable = true;
				colvarAddress.IsPrimaryKey = false;
				colvarAddress.IsForeignKey = false;
				colvarAddress.IsReadOnly = false;
				colvarAddress.DefaultSetting = @"";
				colvarAddress.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAddress);
				
				TableSchema.TableColumn colvarNativePlace = new TableSchema.TableColumn(schema);
				colvarNativePlace.ColumnName = "NativePlace";
				colvarNativePlace.DataType = DbType.String;
				colvarNativePlace.MaxLength = 50;
				colvarNativePlace.AutoIncrement = false;
				colvarNativePlace.IsNullable = true;
				colvarNativePlace.IsPrimaryKey = false;
				colvarNativePlace.IsForeignKey = false;
				colvarNativePlace.IsReadOnly = false;
				colvarNativePlace.DefaultSetting = @"";
				colvarNativePlace.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNativePlace);
				
				TableSchema.TableColumn colvarPoliticsId = new TableSchema.TableColumn(schema);
				colvarPoliticsId.ColumnName = "PoliticsId";
				colvarPoliticsId.DataType = DbType.Int32;
				colvarPoliticsId.MaxLength = 0;
				colvarPoliticsId.AutoIncrement = false;
				colvarPoliticsId.IsNullable = false;
				colvarPoliticsId.IsPrimaryKey = false;
				colvarPoliticsId.IsForeignKey = true;
				colvarPoliticsId.IsReadOnly = false;
				colvarPoliticsId.DefaultSetting = @"";
				
					colvarPoliticsId.ForeignKeyTableName = "Politics_tb";
				schema.Columns.Add(colvarPoliticsId);
				
				TableSchema.TableColumn colvarIdentyNum = new TableSchema.TableColumn(schema);
				colvarIdentyNum.ColumnName = "IdentyNum";
				colvarIdentyNum.DataType = DbType.String;
				colvarIdentyNum.MaxLength = 50;
				colvarIdentyNum.AutoIncrement = false;
				colvarIdentyNum.IsNullable = false;
				colvarIdentyNum.IsPrimaryKey = false;
				colvarIdentyNum.IsForeignKey = false;
				colvarIdentyNum.IsReadOnly = false;
				colvarIdentyNum.DefaultSetting = @"";
				colvarIdentyNum.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdentyNum);
				
				TableSchema.TableColumn colvarSchool = new TableSchema.TableColumn(schema);
				colvarSchool.ColumnName = "School";
				colvarSchool.DataType = DbType.String;
				colvarSchool.MaxLength = 50;
				colvarSchool.AutoIncrement = false;
				colvarSchool.IsNullable = true;
				colvarSchool.IsPrimaryKey = false;
				colvarSchool.IsForeignKey = false;
				colvarSchool.IsReadOnly = false;
				colvarSchool.DefaultSetting = @"";
				colvarSchool.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSchool);
				
				TableSchema.TableColumn colvarMajor = new TableSchema.TableColumn(schema);
				colvarMajor.ColumnName = "Major";
				colvarMajor.DataType = DbType.String;
				colvarMajor.MaxLength = 50;
				colvarMajor.AutoIncrement = false;
				colvarMajor.IsNullable = true;
				colvarMajor.IsPrimaryKey = false;
				colvarMajor.IsForeignKey = false;
				colvarMajor.IsReadOnly = false;
				colvarMajor.DefaultSetting = @"";
				colvarMajor.ForeignKeyTableName = "";
				schema.Columns.Add(colvarMajor);
				
				TableSchema.TableColumn colvarEducationId = new TableSchema.TableColumn(schema);
				colvarEducationId.ColumnName = "EducationId";
				colvarEducationId.DataType = DbType.Int32;
				colvarEducationId.MaxLength = 0;
				colvarEducationId.AutoIncrement = false;
				colvarEducationId.IsNullable = false;
				colvarEducationId.IsPrimaryKey = false;
				colvarEducationId.IsForeignKey = true;
				colvarEducationId.IsReadOnly = false;
				colvarEducationId.DefaultSetting = @"";
				
					colvarEducationId.ForeignKeyTableName = "Education_tb";
				schema.Columns.Add(colvarEducationId);
				
				TableSchema.TableColumn colvarLanguageId = new TableSchema.TableColumn(schema);
				colvarLanguageId.ColumnName = "LanguageId";
				colvarLanguageId.DataType = DbType.Int32;
				colvarLanguageId.MaxLength = 0;
				colvarLanguageId.AutoIncrement = false;
				colvarLanguageId.IsNullable = false;
				colvarLanguageId.IsPrimaryKey = false;
				colvarLanguageId.IsForeignKey = true;
				colvarLanguageId.IsReadOnly = false;
				colvarLanguageId.DefaultSetting = @"";
				
					colvarLanguageId.ForeignKeyTableName = "Language_tb";
				schema.Columns.Add(colvarLanguageId);
				
				TableSchema.TableColumn colvarCertificate = new TableSchema.TableColumn(schema);
				colvarCertificate.ColumnName = "Certificate";
				colvarCertificate.DataType = DbType.String;
				colvarCertificate.MaxLength = 50;
				colvarCertificate.AutoIncrement = false;
				colvarCertificate.IsNullable = true;
				colvarCertificate.IsPrimaryKey = false;
				colvarCertificate.IsForeignKey = false;
				colvarCertificate.IsReadOnly = false;
				colvarCertificate.DefaultSetting = @"";
				colvarCertificate.ForeignKeyTableName = "";
				schema.Columns.Add(colvarCertificate);
				
				TableSchema.TableColumn colvarJobTime = new TableSchema.TableColumn(schema);
				colvarJobTime.ColumnName = "JobTime";
				colvarJobTime.DataType = DbType.DateTime;
				colvarJobTime.MaxLength = 0;
				colvarJobTime.AutoIncrement = false;
				colvarJobTime.IsNullable = true;
				colvarJobTime.IsPrimaryKey = false;
				colvarJobTime.IsForeignKey = false;
				colvarJobTime.IsReadOnly = false;
				colvarJobTime.DefaultSetting = @"";
				colvarJobTime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarJobTime);
				
				TableSchema.TableColumn colvarJoinTime = new TableSchema.TableColumn(schema);
				colvarJoinTime.ColumnName = "JoinTime";
				colvarJoinTime.DataType = DbType.DateTime;
				colvarJoinTime.MaxLength = 0;
				colvarJoinTime.AutoIncrement = false;
				colvarJoinTime.IsNullable = true;
				colvarJoinTime.IsPrimaryKey = false;
				colvarJoinTime.IsForeignKey = false;
				colvarJoinTime.IsReadOnly = false;
				colvarJoinTime.DefaultSetting = @"";
				colvarJoinTime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarJoinTime);
				
				TableSchema.TableColumn colvarDepartId = new TableSchema.TableColumn(schema);
				colvarDepartId.ColumnName = "DepartId";
				colvarDepartId.DataType = DbType.Int32;
				colvarDepartId.MaxLength = 0;
				colvarDepartId.AutoIncrement = false;
				colvarDepartId.IsNullable = false;
				colvarDepartId.IsPrimaryKey = false;
				colvarDepartId.IsForeignKey = true;
				colvarDepartId.IsReadOnly = false;
				colvarDepartId.DefaultSetting = @"";
				
					colvarDepartId.ForeignKeyTableName = "Depart_tb";
				schema.Columns.Add(colvarDepartId);
				
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
				
				TableSchema.TableColumn colvarOffJobTime = new TableSchema.TableColumn(schema);
				colvarOffJobTime.ColumnName = "OffJobTime";
				colvarOffJobTime.DataType = DbType.DateTime;
				colvarOffJobTime.MaxLength = 0;
				colvarOffJobTime.AutoIncrement = false;
				colvarOffJobTime.IsNullable = true;
				colvarOffJobTime.IsPrimaryKey = false;
				colvarOffJobTime.IsForeignKey = false;
				colvarOffJobTime.IsReadOnly = false;
				colvarOffJobTime.DefaultSetting = @"";
				colvarOffJobTime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarOffJobTime);
				
				TableSchema.TableColumn colvarImage = new TableSchema.TableColumn(schema);
				colvarImage.ColumnName = "Image";
				colvarImage.DataType = DbType.String;
				colvarImage.MaxLength = 50;
				colvarImage.AutoIncrement = false;
				colvarImage.IsNullable = true;
				colvarImage.IsPrimaryKey = false;
				colvarImage.IsForeignKey = false;
				colvarImage.IsReadOnly = false;
				colvarImage.DefaultSetting = @"";
				colvarImage.ForeignKeyTableName = "";
				schema.Columns.Add(colvarImage);
				
				TableSchema.TableColumn colvarQq = new TableSchema.TableColumn(schema);
				colvarQq.ColumnName = "Qq";
				colvarQq.DataType = DbType.String;
				colvarQq.MaxLength = 50;
				colvarQq.AutoIncrement = false;
				colvarQq.IsNullable = true;
				colvarQq.IsPrimaryKey = false;
				colvarQq.IsForeignKey = false;
				colvarQq.IsReadOnly = false;
				colvarQq.DefaultSetting = @"";
				colvarQq.ForeignKeyTableName = "";
				schema.Columns.Add(colvarQq);
				
				TableSchema.TableColumn colvarTurnTime = new TableSchema.TableColumn(schema);
				colvarTurnTime.ColumnName = "TurnTime";
				colvarTurnTime.DataType = DbType.String;
				colvarTurnTime.MaxLength = 50;
				colvarTurnTime.AutoIncrement = false;
				colvarTurnTime.IsNullable = true;
				colvarTurnTime.IsPrimaryKey = false;
				colvarTurnTime.IsForeignKey = false;
				colvarTurnTime.IsReadOnly = false;
				colvarTurnTime.DefaultSetting = @"";
				colvarTurnTime.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTurnTime);
				
				TableSchema.TableColumn colvarEmLevelId = new TableSchema.TableColumn(schema);
				colvarEmLevelId.ColumnName = "EmLevelId";
				colvarEmLevelId.DataType = DbType.Int32;
				colvarEmLevelId.MaxLength = 0;
				colvarEmLevelId.AutoIncrement = false;
				colvarEmLevelId.IsNullable = true;
				colvarEmLevelId.IsPrimaryKey = false;
				colvarEmLevelId.IsForeignKey = false;
				colvarEmLevelId.IsReadOnly = false;
				colvarEmLevelId.DefaultSetting = @"";
				colvarEmLevelId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEmLevelId);
				
				TableSchema.TableColumn colvarEmDangId = new TableSchema.TableColumn(schema);
				colvarEmDangId.ColumnName = "EmDangId";
				colvarEmDangId.DataType = DbType.Int32;
				colvarEmDangId.MaxLength = 0;
				colvarEmDangId.AutoIncrement = false;
				colvarEmDangId.IsNullable = true;
				colvarEmDangId.IsPrimaryKey = false;
				colvarEmDangId.IsForeignKey = false;
				colvarEmDangId.IsReadOnly = false;
				colvarEmDangId.DefaultSetting = @"";
				colvarEmDangId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEmDangId);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["SubsonicProvider"].AddSchema("Employee_tb",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("EmployeeId")]
		[Bindable(true)]
		public int EmployeeId 
		{
			get { return GetColumnValue<int>(Columns.EmployeeId); }
			set { SetColumnValue(Columns.EmployeeId, value); }
		}
		  
		[XmlAttribute("ContactId")]
		[Bindable(true)]
		public int ContactId 
		{
			get { return GetColumnValue<int>(Columns.ContactId); }
			set { SetColumnValue(Columns.ContactId, value); }
		}
		  
		[XmlAttribute("EmployeeName")]
		[Bindable(true)]
		public string EmployeeName 
		{
			get { return GetColumnValue<string>(Columns.EmployeeName); }
			set { SetColumnValue(Columns.EmployeeName, value); }
		}
		  
		[XmlAttribute("PositionId")]
		[Bindable(true)]
		public int PositionId 
		{
			get { return GetColumnValue<int>(Columns.PositionId); }
			set { SetColumnValue(Columns.PositionId, value); }
		}
		  
		[XmlAttribute("Sex")]
		[Bindable(true)]
		public int Sex 
		{
			get { return GetColumnValue<int>(Columns.Sex); }
			set { SetColumnValue(Columns.Sex, value); }
		}
		  
		[XmlAttribute("Birthday")]
		[Bindable(true)]
		public DateTime? Birthday 
		{
			get { return GetColumnValue<DateTime?>(Columns.Birthday); }
			set { SetColumnValue(Columns.Birthday, value); }
		}
		  
		[XmlAttribute("Marrage")]
		[Bindable(true)]
		public int? Marrage 
		{
			get { return GetColumnValue<int?>(Columns.Marrage); }
			set { SetColumnValue(Columns.Marrage, value); }
		}
		  
		[XmlAttribute("Address")]
		[Bindable(true)]
		public string Address 
		{
			get { return GetColumnValue<string>(Columns.Address); }
			set { SetColumnValue(Columns.Address, value); }
		}
		  
		[XmlAttribute("NativePlace")]
		[Bindable(true)]
		public string NativePlace 
		{
			get { return GetColumnValue<string>(Columns.NativePlace); }
			set { SetColumnValue(Columns.NativePlace, value); }
		}
		  
		[XmlAttribute("PoliticsId")]
		[Bindable(true)]
		public int PoliticsId 
		{
			get { return GetColumnValue<int>(Columns.PoliticsId); }
			set { SetColumnValue(Columns.PoliticsId, value); }
		}
		  
		[XmlAttribute("IdentyNum")]
		[Bindable(true)]
		public string IdentyNum 
		{
			get { return GetColumnValue<string>(Columns.IdentyNum); }
			set { SetColumnValue(Columns.IdentyNum, value); }
		}
		  
		[XmlAttribute("School")]
		[Bindable(true)]
		public string School 
		{
			get { return GetColumnValue<string>(Columns.School); }
			set { SetColumnValue(Columns.School, value); }
		}
		  
		[XmlAttribute("Major")]
		[Bindable(true)]
		public string Major 
		{
			get { return GetColumnValue<string>(Columns.Major); }
			set { SetColumnValue(Columns.Major, value); }
		}
		  
		[XmlAttribute("EducationId")]
		[Bindable(true)]
		public int EducationId 
		{
			get { return GetColumnValue<int>(Columns.EducationId); }
			set { SetColumnValue(Columns.EducationId, value); }
		}
		  
		[XmlAttribute("LanguageId")]
		[Bindable(true)]
		public int LanguageId 
		{
			get { return GetColumnValue<int>(Columns.LanguageId); }
			set { SetColumnValue(Columns.LanguageId, value); }
		}
		  
		[XmlAttribute("Certificate")]
		[Bindable(true)]
		public string Certificate 
		{
			get { return GetColumnValue<string>(Columns.Certificate); }
			set { SetColumnValue(Columns.Certificate, value); }
		}
		  
		[XmlAttribute("JobTime")]
		[Bindable(true)]
		public DateTime? JobTime 
		{
			get { return GetColumnValue<DateTime?>(Columns.JobTime); }
			set { SetColumnValue(Columns.JobTime, value); }
		}
		  
		[XmlAttribute("JoinTime")]
		[Bindable(true)]
		public DateTime? JoinTime 
		{
			get { return GetColumnValue<DateTime?>(Columns.JoinTime); }
			set { SetColumnValue(Columns.JoinTime, value); }
		}
		  
		[XmlAttribute("DepartId")]
		[Bindable(true)]
		public int DepartId 
		{
			get { return GetColumnValue<int>(Columns.DepartId); }
			set { SetColumnValue(Columns.DepartId, value); }
		}
		  
		[XmlAttribute("State")]
		[Bindable(true)]
		public int? State 
		{
			get { return GetColumnValue<int?>(Columns.State); }
			set { SetColumnValue(Columns.State, value); }
		}
		  
		[XmlAttribute("OffJobTime")]
		[Bindable(true)]
		public DateTime? OffJobTime 
		{
			get { return GetColumnValue<DateTime?>(Columns.OffJobTime); }
			set { SetColumnValue(Columns.OffJobTime, value); }
		}
		  
		[XmlAttribute("Image")]
		[Bindable(true)]
		public string Image 
		{
			get { return GetColumnValue<string>(Columns.Image); }
			set { SetColumnValue(Columns.Image, value); }
		}
		  
		[XmlAttribute("Qq")]
		[Bindable(true)]
		public string Qq 
		{
			get { return GetColumnValue<string>(Columns.Qq); }
			set { SetColumnValue(Columns.Qq, value); }
		}
		  
		[XmlAttribute("TurnTime")]
		[Bindable(true)]
		public string TurnTime 
		{
			get { return GetColumnValue<string>(Columns.TurnTime); }
			set { SetColumnValue(Columns.TurnTime, value); }
		}
		  
		[XmlAttribute("EmLevelId")]
		[Bindable(true)]
		public int? EmLevelId 
		{
			get { return GetColumnValue<int?>(Columns.EmLevelId); }
			set { SetColumnValue(Columns.EmLevelId, value); }
		}
		  
		[XmlAttribute("EmDangId")]
		[Bindable(true)]
		public int? EmDangId 
		{
			get { return GetColumnValue<int?>(Columns.EmDangId); }
			set { SetColumnValue(Columns.EmDangId, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		public CanYou.OA.DAL.FileCollection FileRecords()
		{
			return new CanYou.OA.DAL.FileCollection().Where(File.Columns.SendEmployeeId, EmployeeId).Load();
		}
		public CanYou.OA.DAL.MasterCollection MasterRecords()
		{
			return new CanYou.OA.DAL.MasterCollection().Where(Master.Columns.EmployeeId, EmployeeId).Load();
		}
		public CanYou.OA.DAL.WeekSumCollection WeekSumRecords()
		{
			return new CanYou.OA.DAL.WeekSumCollection().Where(WeekSum.Columns.SendEmployeeId, EmployeeId).Load();
		}
		#endregion
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a Contact ActiveRecord object related to this Employee
		/// 
		/// </summary>
		public CanYou.OA.DAL.Contact Contact
		{
			get { return CanYou.OA.DAL.Contact.FetchByID(this.ContactId); }
			set { SetColumnValue("ContactId", value.ContactId); }
		}
		
		
		/// <summary>
		/// Returns a Depart ActiveRecord object related to this Employee
		/// 
		/// </summary>
		public CanYou.OA.DAL.Depart Depart
		{
			get { return CanYou.OA.DAL.Depart.FetchByID(this.DepartId); }
			set { SetColumnValue("DepartId", value.DepartId); }
		}
		
		
		/// <summary>
		/// Returns a Education ActiveRecord object related to this Employee
		/// 
		/// </summary>
		public CanYou.OA.DAL.Education Education
		{
			get { return CanYou.OA.DAL.Education.FetchByID(this.EducationId); }
			set { SetColumnValue("EducationId", value.EducationId); }
		}
		
		
		/// <summary>
		/// Returns a Language ActiveRecord object related to this Employee
		/// 
		/// </summary>
		public CanYou.OA.DAL.Language Language
		{
			get { return CanYou.OA.DAL.Language.FetchByID(this.LanguageId); }
			set { SetColumnValue("LanguageId", value.LanguageId); }
		}
		
		
		/// <summary>
		/// Returns a Politics ActiveRecord object related to this Employee
		/// 
		/// </summary>
		public CanYou.OA.DAL.Politics Politics
		{
			get { return CanYou.OA.DAL.Politics.FetchByID(this.PoliticsId); }
			set { SetColumnValue("PoliticsId", value.PoliticsId); }
		}
		
		
		/// <summary>
		/// Returns a Position ActiveRecord object related to this Employee
		/// 
		/// </summary>
		public CanYou.OA.DAL.Position Position
		{
			get { return CanYou.OA.DAL.Position.FetchByID(this.PositionId); }
			set { SetColumnValue("PositionId", value.PositionId); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varContactId,string varEmployeeName,int varPositionId,int varSex,DateTime? varBirthday,int? varMarrage,string varAddress,string varNativePlace,int varPoliticsId,string varIdentyNum,string varSchool,string varMajor,int varEducationId,int varLanguageId,string varCertificate,DateTime? varJobTime,DateTime? varJoinTime,int varDepartId,int? varState,DateTime? varOffJobTime,string varImage,string varQq,string varTurnTime,int? varEmLevelId,int? varEmDangId)
		{
			Employee item = new Employee();
			
			item.ContactId = varContactId;
			
			item.EmployeeName = varEmployeeName;
			
			item.PositionId = varPositionId;
			
			item.Sex = varSex;
			
			item.Birthday = varBirthday;
			
			item.Marrage = varMarrage;
			
			item.Address = varAddress;
			
			item.NativePlace = varNativePlace;
			
			item.PoliticsId = varPoliticsId;
			
			item.IdentyNum = varIdentyNum;
			
			item.School = varSchool;
			
			item.Major = varMajor;
			
			item.EducationId = varEducationId;
			
			item.LanguageId = varLanguageId;
			
			item.Certificate = varCertificate;
			
			item.JobTime = varJobTime;
			
			item.JoinTime = varJoinTime;
			
			item.DepartId = varDepartId;
			
			item.State = varState;
			
			item.OffJobTime = varOffJobTime;
			
			item.Image = varImage;
			
			item.Qq = varQq;
			
			item.TurnTime = varTurnTime;
			
			item.EmLevelId = varEmLevelId;
			
			item.EmDangId = varEmDangId;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varEmployeeId,int varContactId,string varEmployeeName,int varPositionId,int varSex,DateTime? varBirthday,int? varMarrage,string varAddress,string varNativePlace,int varPoliticsId,string varIdentyNum,string varSchool,string varMajor,int varEducationId,int varLanguageId,string varCertificate,DateTime? varJobTime,DateTime? varJoinTime,int varDepartId,int? varState,DateTime? varOffJobTime,string varImage,string varQq,string varTurnTime,int? varEmLevelId,int? varEmDangId)
		{
			Employee item = new Employee();
			
				item.EmployeeId = varEmployeeId;
			
				item.ContactId = varContactId;
			
				item.EmployeeName = varEmployeeName;
			
				item.PositionId = varPositionId;
			
				item.Sex = varSex;
			
				item.Birthday = varBirthday;
			
				item.Marrage = varMarrage;
			
				item.Address = varAddress;
			
				item.NativePlace = varNativePlace;
			
				item.PoliticsId = varPoliticsId;
			
				item.IdentyNum = varIdentyNum;
			
				item.School = varSchool;
			
				item.Major = varMajor;
			
				item.EducationId = varEducationId;
			
				item.LanguageId = varLanguageId;
			
				item.Certificate = varCertificate;
			
				item.JobTime = varJobTime;
			
				item.JoinTime = varJoinTime;
			
				item.DepartId = varDepartId;
			
				item.State = varState;
			
				item.OffJobTime = varOffJobTime;
			
				item.Image = varImage;
			
				item.Qq = varQq;
			
				item.TurnTime = varTurnTime;
			
				item.EmLevelId = varEmLevelId;
			
				item.EmDangId = varEmDangId;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn EmployeeIdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ContactIdColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn EmployeeNameColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn PositionIdColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn SexColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn BirthdayColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn MarrageColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn AddressColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn NativePlaceColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn PoliticsIdColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn IdentyNumColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn SchoolColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn MajorColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        public static TableSchema.TableColumn EducationIdColumn
        {
            get { return Schema.Columns[13]; }
        }
        
        
        
        public static TableSchema.TableColumn LanguageIdColumn
        {
            get { return Schema.Columns[14]; }
        }
        
        
        
        public static TableSchema.TableColumn CertificateColumn
        {
            get { return Schema.Columns[15]; }
        }
        
        
        
        public static TableSchema.TableColumn JobTimeColumn
        {
            get { return Schema.Columns[16]; }
        }
        
        
        
        public static TableSchema.TableColumn JoinTimeColumn
        {
            get { return Schema.Columns[17]; }
        }
        
        
        
        public static TableSchema.TableColumn DepartIdColumn
        {
            get { return Schema.Columns[18]; }
        }
        
        
        
        public static TableSchema.TableColumn StateColumn
        {
            get { return Schema.Columns[19]; }
        }
        
        
        
        public static TableSchema.TableColumn OffJobTimeColumn
        {
            get { return Schema.Columns[20]; }
        }
        
        
        
        public static TableSchema.TableColumn ImageColumn
        {
            get { return Schema.Columns[21]; }
        }
        
        
        
        public static TableSchema.TableColumn QqColumn
        {
            get { return Schema.Columns[22]; }
        }
        
        
        
        public static TableSchema.TableColumn TurnTimeColumn
        {
            get { return Schema.Columns[23]; }
        }
        
        
        
        public static TableSchema.TableColumn EmLevelIdColumn
        {
            get { return Schema.Columns[24]; }
        }
        
        
        
        public static TableSchema.TableColumn EmDangIdColumn
        {
            get { return Schema.Columns[25]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string EmployeeId = @"EmployeeId";
			 public static string ContactId = @"ContactId";
			 public static string EmployeeName = @"EmployeeName";
			 public static string PositionId = @"PositionId";
			 public static string Sex = @"Sex";
			 public static string Birthday = @"Birthday";
			 public static string Marrage = @"Marrage";
			 public static string Address = @"Address";
			 public static string NativePlace = @"NativePlace";
			 public static string PoliticsId = @"PoliticsId";
			 public static string IdentyNum = @"IdentyNum";
			 public static string School = @"School";
			 public static string Major = @"Major";
			 public static string EducationId = @"EducationId";
			 public static string LanguageId = @"LanguageId";
			 public static string Certificate = @"Certificate";
			 public static string JobTime = @"JobTime";
			 public static string JoinTime = @"JoinTime";
			 public static string DepartId = @"DepartId";
			 public static string State = @"State";
			 public static string OffJobTime = @"OffJobTime";
			 public static string Image = @"Image";
			 public static string Qq = @"Qq";
			 public static string TurnTime = @"TurnTime";
			 public static string EmLevelId = @"EmLevelId";
			 public static string EmDangId = @"EmDangId";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
}
        #endregion
	}
}
